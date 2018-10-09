using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000285 RID: 645
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataScoreLevelInfo")]
	[Serializable]
	public class ConfigDataScoreLevelInfo : IExtensible
	{
		// Token: 0x060029CD RID: 10701 RVA: 0x000B04A8 File Offset: 0x000AE6A8
		public ConfigDataScoreLevelInfo()
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

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x000B0524 File Offset: 0x000AE724
		// (set) Token: 0x060029CF RID: 10703 RVA: 0x000B052C File Offset: 0x000AE72C
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

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x000B0538 File Offset: 0x000AE738
		// (set) Token: 0x060029D1 RID: 10705 RVA: 0x000B0540 File Offset: 0x000AE740
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

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060029D2 RID: 10706 RVA: 0x000B054C File Offset: 0x000AE74C
		// (set) Token: 0x060029D3 RID: 10707 RVA: 0x000B0554 File Offset: 0x000AE754
		[ProtoMember(4, IsRequired = true, Name = "TeamName", DataFormat = DataFormat.Default)]
		public string TeamName
		{
			get
			{
				return this._TeamName;
			}
			set
			{
				this._TeamName = value;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x000B0560 File Offset: 0x000AE760
		// (set) Token: 0x060029D5 RID: 10709 RVA: 0x000B0568 File Offset: 0x000AE768
		[ProtoMember(5, IsRequired = true, Name = "PlayerLevelMin", DataFormat = DataFormat.TwosComplement)]
		public int PlayerLevelMin
		{
			get
			{
				return this._PlayerLevelMin;
			}
			set
			{
				this._PlayerLevelMin = value;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x000B0574 File Offset: 0x000AE774
		[ProtoMember(6, Name = "UnlockDaysDelayGroup", DataFormat = DataFormat.TwosComplement)]
		public List<int> UnlockDaysDelayGroup
		{
			get
			{
				return this._UnlockDaysDelayGroup;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000B057C File Offset: 0x000AE77C
		// (set) Token: 0x060029D8 RID: 10712 RVA: 0x000B0584 File Offset: 0x000AE784
		[ProtoMember(7, IsRequired = true, Name = "EnergySuccess", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x000B0590 File Offset: 0x000AE790
		// (set) Token: 0x060029DA RID: 10714 RVA: 0x000B0598 File Offset: 0x000AE798
		[ProtoMember(8, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x000B05A4 File Offset: 0x000AE7A4
		// (set) Token: 0x060029DC RID: 10716 RVA: 0x000B05AC File Offset: 0x000AE7AC
		[ProtoMember(9, IsRequired = true, Name = "EnergyTeam", DataFormat = DataFormat.TwosComplement)]
		public int EnergyTeam
		{
			get
			{
				return this._EnergyTeam;
			}
			set
			{
				this._EnergyTeam = value;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x000B05B8 File Offset: 0x000AE7B8
		// (set) Token: 0x060029DE RID: 10718 RVA: 0x000B05C0 File Offset: 0x000AE7C0
		[ProtoMember(10, IsRequired = true, Name = "MonsterLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x000B05CC File Offset: 0x000AE7CC
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x000B05D4 File Offset: 0x000AE7D4
		[ProtoMember(11, IsRequired = true, Name = "Battle_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x000B05E0 File Offset: 0x000AE7E0
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x000B05E8 File Offset: 0x000AE7E8
		[ProtoMember(12, IsRequired = true, Name = "PlayerExp", DataFormat = DataFormat.TwosComplement)]
		public int PlayerExp
		{
			get
			{
				return this._PlayerExp;
			}
			set
			{
				this._PlayerExp = value;
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x000B05F4 File Offset: 0x000AE7F4
		// (set) Token: 0x060029E4 RID: 10724 RVA: 0x000B05FC File Offset: 0x000AE7FC
		[ProtoMember(13, IsRequired = true, Name = "HeroExp", DataFormat = DataFormat.TwosComplement)]
		public int HeroExp
		{
			get
			{
				return this._HeroExp;
			}
			set
			{
				this._HeroExp = value;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x000B0608 File Offset: 0x000AE808
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x000B0610 File Offset: 0x000AE810
		[ProtoMember(14, IsRequired = true, Name = "GoldReward", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x000B061C File Offset: 0x000AE81C
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x000B0624 File Offset: 0x000AE824
		[ProtoMember(15, IsRequired = true, Name = "ScoreBase", DataFormat = DataFormat.TwosComplement)]
		public int ScoreBase
		{
			get
			{
				return this._ScoreBase;
			}
			set
			{
				this._ScoreBase = value;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x000B0630 File Offset: 0x000AE830
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x000B0638 File Offset: 0x000AE838
		[ProtoMember(16, IsRequired = true, Name = "DropID", DataFormat = DataFormat.TwosComplement)]
		public int DropID
		{
			get
			{
				return this._DropID;
			}
			set
			{
				this._DropID = value;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x000B0644 File Offset: 0x000AE844
		// (set) Token: 0x060029EC RID: 10732 RVA: 0x000B064C File Offset: 0x000AE84C
		[ProtoMember(17, IsRequired = true, Name = "ItemDropCountDisplay", DataFormat = DataFormat.TwosComplement)]
		public int ItemDropCountDisplay
		{
			get
			{
				return this._ItemDropCountDisplay;
			}
			set
			{
				this._ItemDropCountDisplay = value;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x000B0658 File Offset: 0x000AE858
		// (set) Token: 0x060029EE RID: 10734 RVA: 0x000B0660 File Offset: 0x000AE860
		[ProtoMember(18, IsRequired = true, Name = "TeamDrop_ID", DataFormat = DataFormat.TwosComplement)]
		public int TeamDrop_ID
		{
			get
			{
				return this._TeamDrop_ID;
			}
			set
			{
				this._TeamDrop_ID = value;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x000B066C File Offset: 0x000AE86C
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x000B0674 File Offset: 0x000AE874
		[ProtoMember(19, IsRequired = true, Name = "DayBonusDrop_ID", DataFormat = DataFormat.TwosComplement)]
		public int DayBonusDrop_ID
		{
			get
			{
				return this._DayBonusDrop_ID;
			}
			set
			{
				this._DayBonusDrop_ID = value;
			}
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x000B0680 File Offset: 0x000AE880
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060029F2 RID: 10738 RVA: 0x000B0690 File Offset: 0x000AE890
		// (set) Token: 0x060029F3 RID: 10739 RVA: 0x000B0698 File Offset: 0x000AE898
		public ConfigDataBattleInfo BattleInfo { get; set; }

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x000B06A4 File Offset: 0x000AE8A4
		// (set) Token: 0x060029F5 RID: 10741 RVA: 0x000B06AC File Offset: 0x000AE8AC
		public ConfigDataRandomDropRewardInfo RandomDropInfo { get; set; }

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x000B06B8 File Offset: 0x000AE8B8
		// (set) Token: 0x060029F7 RID: 10743 RVA: 0x000B06C0 File Offset: 0x000AE8C0
		public ConfigDataRandomDropRewardInfo TeamRandomDropInfo { get; set; }

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x000B06CC File Offset: 0x000AE8CC
		// (set) Token: 0x060029F9 RID: 10745 RVA: 0x000B06D4 File Offset: 0x000AE8D4
		public ConfigDataRandomDropRewardInfo DailyRandomDropInfo { get; set; }

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x000B06E0 File Offset: 0x000AE8E0
		// (set) Token: 0x060029FB RID: 10747 RVA: 0x000B06E8 File Offset: 0x000AE8E8
		public ConfigDataUnchartedScoreInfo UnchartedScoreInfo { get; set; }

		// Token: 0x060029FC RID: 10748 RVA: 0x000B06F4 File Offset: 0x000AE8F4
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

		// Token: 0x060029FD RID: 10749 RVA: 0x000B07C0 File Offset: 0x000AE9C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataScoreLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040019BF RID: 6591
		private int _ID;

		// Token: 0x040019C0 RID: 6592
		private string _Name;

		// Token: 0x040019C1 RID: 6593
		private string _TeamName;

		// Token: 0x040019C2 RID: 6594
		private int _PlayerLevelMin;

		// Token: 0x040019C3 RID: 6595
		private readonly List<int> _UnlockDaysDelayGroup = new List<int>();

		// Token: 0x040019C4 RID: 6596
		private int _EnergySuccess;

		// Token: 0x040019C5 RID: 6597
		private int _EnergyFail;

		// Token: 0x040019C6 RID: 6598
		private int _EnergyTeam;

		// Token: 0x040019C7 RID: 6599
		private int _MonsterLevel;

		// Token: 0x040019C8 RID: 6600
		private int _Battle_ID;

		// Token: 0x040019C9 RID: 6601
		private int _PlayerExp;

		// Token: 0x040019CA RID: 6602
		private int _HeroExp;

		// Token: 0x040019CB RID: 6603
		private int _GoldReward;

		// Token: 0x040019CC RID: 6604
		private int _ScoreBase;

		// Token: 0x040019CD RID: 6605
		private int _DropID;

		// Token: 0x040019CE RID: 6606
		private int _ItemDropCountDisplay;

		// Token: 0x040019CF RID: 6607
		private int _TeamDrop_ID;

		// Token: 0x040019D0 RID: 6608
		private int _DayBonusDrop_ID;

		// Token: 0x040019D1 RID: 6609
		private IExtension extensionObject;

		// Token: 0x040019D3 RID: 6611
		public HashSet<int> UnlockDaysDelayGroupSet = new HashSet<int>();

		// Token: 0x040019D8 RID: 6616
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040019D9 RID: 6617
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040019DA RID: 6618
		private LuaFunction m_ctor_hotfix;
	}
}
