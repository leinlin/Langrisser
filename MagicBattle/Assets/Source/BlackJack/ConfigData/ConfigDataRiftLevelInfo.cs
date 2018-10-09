using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000283 RID: 643
	[ProtoContract(Name = "ConfigDataRiftLevelInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataRiftLevelInfo : IExtensible
	{
		// Token: 0x06002953 RID: 10579 RVA: 0x000AFC98 File Offset: 0x000ADE98
		public ConfigDataRiftLevelInfo()
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

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x000AFD40 File Offset: 0x000ADF40
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x000AFD48 File Offset: 0x000ADF48
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

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x000AFD54 File Offset: 0x000ADF54
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x000AFD5C File Offset: 0x000ADF5C
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

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x000AFD68 File Offset: 0x000ADF68
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x000AFD70 File Offset: 0x000ADF70
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

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x000AFD7C File Offset: 0x000ADF7C
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x000AFD84 File Offset: 0x000ADF84
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

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000AFD90 File Offset: 0x000ADF90
		// (set) Token: 0x0600295D RID: 10589 RVA: 0x000AFD98 File Offset: 0x000ADF98
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

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000AFDA4 File Offset: 0x000ADFA4
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x000AFDAC File Offset: 0x000ADFAC
		[ProtoMember(7, IsRequired = true, Name = "ChapterID", DataFormat = DataFormat.TwosComplement)]
		public int ChapterID
		{
			get
			{
				return this._ChapterID;
			}
			set
			{
				this._ChapterID = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x000AFDB8 File Offset: 0x000ADFB8
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x000AFDC0 File Offset: 0x000ADFC0
		[ProtoMember(8, IsRequired = true, Name = "OwnNum", DataFormat = DataFormat.TwosComplement)]
		public int OwnNum
		{
			get
			{
				return this._OwnNum;
			}
			set
			{
				this._OwnNum = value;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x000AFDCC File Offset: 0x000ADFCC
		// (set) Token: 0x06002963 RID: 10595 RVA: 0x000AFDD4 File Offset: 0x000ADFD4
		[ProtoMember(9, IsRequired = true, Name = "NameNum", DataFormat = DataFormat.Default)]
		public string NameNum
		{
			get
			{
				return this._NameNum;
			}
			set
			{
				this._NameNum = value;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x000AFDE0 File Offset: 0x000ADFE0
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x000AFDE8 File Offset: 0x000ADFE8
		[ProtoMember(10, IsRequired = true, Name = "ChallengeCount", DataFormat = DataFormat.TwosComplement)]
		public int ChallengeCount
		{
			get
			{
				return this._ChallengeCount;
			}
			set
			{
				this._ChallengeCount = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000AFDF4 File Offset: 0x000ADFF4
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x000AFDFC File Offset: 0x000ADFFC
		[ProtoMember(11, IsRequired = true, Name = "EnergySuccess", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000AFE08 File Offset: 0x000AE008
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x000AFE10 File Offset: 0x000AE010
		[ProtoMember(12, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000AFE1C File Offset: 0x000AE01C
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x000AFE24 File Offset: 0x000AE024
		[ProtoMember(13, IsRequired = true, Name = "MonsterLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x000AFE30 File Offset: 0x000AE030
		// (set) Token: 0x0600296D RID: 10605 RVA: 0x000AFE38 File Offset: 0x000AE038
		[ProtoMember(14, IsRequired = true, Name = "Battle_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x000AFE44 File Offset: 0x000AE044
		// (set) Token: 0x0600296F RID: 10607 RVA: 0x000AFE4C File Offset: 0x000AE04C
		[ProtoMember(15, IsRequired = true, Name = "PreLevel_ID", DataFormat = DataFormat.TwosComplement)]
		public int PreLevel_ID
		{
			get
			{
				return this._PreLevel_ID;
			}
			set
			{
				this._PreLevel_ID = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x000AFE58 File Offset: 0x000AE058
		// (set) Token: 0x06002971 RID: 10609 RVA: 0x000AFE60 File Offset: 0x000AE060
		[ProtoMember(16, IsRequired = true, Name = "PlayerLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x000AFE6C File Offset: 0x000AE06C
		[ProtoMember(17, Name = "UnlockConditions", DataFormat = DataFormat.Default)]
		public List<RiftLevelInfoUnlockConditions> UnlockConditions
		{
			get
			{
				return this._UnlockConditions;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x000AFE74 File Offset: 0x000AE074
		// (set) Token: 0x06002974 RID: 10612 RVA: 0x000AFE7C File Offset: 0x000AE07C
		[ProtoMember(18, IsRequired = true, Name = "StarTurnMax", DataFormat = DataFormat.TwosComplement)]
		public int StarTurnMax
		{
			get
			{
				return this._StarTurnMax;
			}
			set
			{
				this._StarTurnMax = value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x000AFE88 File Offset: 0x000AE088
		// (set) Token: 0x06002976 RID: 10614 RVA: 0x000AFE90 File Offset: 0x000AE090
		[ProtoMember(19, IsRequired = true, Name = "StarDeadMax", DataFormat = DataFormat.TwosComplement)]
		public int StarDeadMax
		{
			get
			{
				return this._StarDeadMax;
			}
			set
			{
				this._StarDeadMax = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x000AFE9C File Offset: 0x000AE09C
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x000AFEA4 File Offset: 0x000AE0A4
		[ProtoMember(20, IsRequired = true, Name = "Achievement1_ID", DataFormat = DataFormat.TwosComplement)]
		public int Achievement1_ID
		{
			get
			{
				return this._Achievement1_ID;
			}
			set
			{
				this._Achievement1_ID = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x000AFEB0 File Offset: 0x000AE0B0
		[ProtoMember(21, Name = "AchievementReward1", DataFormat = DataFormat.Default)]
		public List<Goods> AchievementReward1
		{
			get
			{
				return this._AchievementReward1;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x0600297A RID: 10618 RVA: 0x000AFEB8 File Offset: 0x000AE0B8
		// (set) Token: 0x0600297B RID: 10619 RVA: 0x000AFEC0 File Offset: 0x000AE0C0
		[ProtoMember(22, IsRequired = true, Name = "Achievement2_ID", DataFormat = DataFormat.TwosComplement)]
		public int Achievement2_ID
		{
			get
			{
				return this._Achievement2_ID;
			}
			set
			{
				this._Achievement2_ID = value;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x000AFECC File Offset: 0x000AE0CC
		[ProtoMember(23, Name = "AchievementReward2", DataFormat = DataFormat.Default)]
		public List<Goods> AchievementReward2
		{
			get
			{
				return this._AchievementReward2;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x000AFED4 File Offset: 0x000AE0D4
		// (set) Token: 0x0600297E RID: 10622 RVA: 0x000AFEDC File Offset: 0x000AE0DC
		[ProtoMember(24, IsRequired = true, Name = "Achievement3_ID", DataFormat = DataFormat.TwosComplement)]
		public int Achievement3_ID
		{
			get
			{
				return this._Achievement3_ID;
			}
			set
			{
				this._Achievement3_ID = value;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x000AFEE8 File Offset: 0x000AE0E8
		[ProtoMember(25, Name = "AchievementReward3", DataFormat = DataFormat.Default)]
		public List<Goods> AchievementReward3
		{
			get
			{
				return this._AchievementReward3;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002980 RID: 10624 RVA: 0x000AFEF0 File Offset: 0x000AE0F0
		// (set) Token: 0x06002981 RID: 10625 RVA: 0x000AFEF8 File Offset: 0x000AE0F8
		[ProtoMember(26, IsRequired = true, Name = "PlayerExpReward", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002982 RID: 10626 RVA: 0x000AFF04 File Offset: 0x000AE104
		// (set) Token: 0x06002983 RID: 10627 RVA: 0x000AFF0C File Offset: 0x000AE10C
		[ProtoMember(27, IsRequired = true, Name = "HeroExpReward", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002984 RID: 10628 RVA: 0x000AFF18 File Offset: 0x000AE118
		// (set) Token: 0x06002985 RID: 10629 RVA: 0x000AFF20 File Offset: 0x000AE120
		[ProtoMember(28, IsRequired = true, Name = "GoldReward", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x000AFF2C File Offset: 0x000AE12C
		[ProtoMember(29, Name = "FirstReward", DataFormat = DataFormat.Default)]
		public List<Goods> FirstReward
		{
			get
			{
				return this._FirstReward;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x000AFF34 File Offset: 0x000AE134
		[ProtoMember(30, Name = "RaidReward", DataFormat = DataFormat.Default)]
		public List<Goods> RaidReward
		{
			get
			{
				return this._RaidReward;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002988 RID: 10632 RVA: 0x000AFF3C File Offset: 0x000AE13C
		// (set) Token: 0x06002989 RID: 10633 RVA: 0x000AFF44 File Offset: 0x000AE144
		[ProtoMember(31, IsRequired = true, Name = "Drop_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x000AFF50 File Offset: 0x000AE150
		// (set) Token: 0x0600298B RID: 10635 RVA: 0x000AFF58 File Offset: 0x000AE158
		[ProtoMember(32, IsRequired = true, Name = "OperationalActivityDrop_ID", DataFormat = DataFormat.TwosComplement)]
		public int OperationalActivityDrop_ID
		{
			get
			{
				return this._OperationalActivityDrop_ID;
			}
			set
			{
				this._OperationalActivityDrop_ID = value;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x0600298C RID: 10636 RVA: 0x000AFF64 File Offset: 0x000AE164
		// (set) Token: 0x0600298D RID: 10637 RVA: 0x000AFF6C File Offset: 0x000AE16C
		[ProtoMember(33, IsRequired = true, Name = "DisplayRewardCount", DataFormat = DataFormat.TwosComplement)]
		public int DisplayRewardCount
		{
			get
			{
				return this._DisplayRewardCount;
			}
			set
			{
				this._DisplayRewardCount = value;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x0600298E RID: 10638 RVA: 0x000AFF78 File Offset: 0x000AE178
		// (set) Token: 0x0600298F RID: 10639 RVA: 0x000AFF80 File Offset: 0x000AE180
		[ProtoMember(34, IsRequired = true, Name = "Image", DataFormat = DataFormat.Default)]
		public string Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				this._Image = value;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x000AFF8C File Offset: 0x000AE18C
		// (set) Token: 0x06002991 RID: 10641 RVA: 0x000AFF94 File Offset: 0x000AE194
		[ProtoMember(35, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x000AFFA0 File Offset: 0x000AE1A0
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x000AFFA8 File Offset: 0x000AE1A8
		[ProtoMember(36, IsRequired = true, Name = "IconX", DataFormat = DataFormat.TwosComplement)]
		public int IconX
		{
			get
			{
				return this._IconX;
			}
			set
			{
				this._IconX = value;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x000AFFB4 File Offset: 0x000AE1B4
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x000AFFBC File Offset: 0x000AE1BC
		[ProtoMember(37, IsRequired = true, Name = "IconY", DataFormat = DataFormat.TwosComplement)]
		public int IconY
		{
			get
			{
				return this._IconY;
			}
			set
			{
				this._IconY = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x000AFFC8 File Offset: 0x000AE1C8
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x000AFFD0 File Offset: 0x000AE1D0
		[ProtoMember(38, IsRequired = true, Name = "Strategy", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x000AFFDC File Offset: 0x000AE1DC
		// (set) Token: 0x06002999 RID: 10649 RVA: 0x000AFFE4 File Offset: 0x000AE1E4
		[ProtoMember(39, IsRequired = true, Name = "LevelType", DataFormat = DataFormat.TwosComplement)]
		public RiftLevelType LevelType
		{
			get
			{
				return this._LevelType;
			}
			set
			{
				this._LevelType = value;
			}
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000AFFF0 File Offset: 0x000AE1F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000B0000 File Offset: 0x000AE200
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

		// Token: 0x0600299C RID: 10652 RVA: 0x000B00CC File Offset: 0x000AE2CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRiftLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400196F RID: 6511
		private int _ID;

		// Token: 0x04001970 RID: 6512
		private string _Name;

		// Token: 0x04001971 RID: 6513
		private string _NameStrKey;

		// Token: 0x04001972 RID: 6514
		private string _Desc;

		// Token: 0x04001973 RID: 6515
		private string _DescStrKey;

		// Token: 0x04001974 RID: 6516
		private int _ChapterID;

		// Token: 0x04001975 RID: 6517
		private int _OwnNum;

		// Token: 0x04001976 RID: 6518
		private string _NameNum;

		// Token: 0x04001977 RID: 6519
		private int _ChallengeCount;

		// Token: 0x04001978 RID: 6520
		private int _EnergySuccess;

		// Token: 0x04001979 RID: 6521
		private int _EnergyFail;

		// Token: 0x0400197A RID: 6522
		private int _MonsterLevel;

		// Token: 0x0400197B RID: 6523
		private int _Battle_ID;

		// Token: 0x0400197C RID: 6524
		private int _PreLevel_ID;

		// Token: 0x0400197D RID: 6525
		private int _PlayerLevel;

		// Token: 0x0400197E RID: 6526
		private readonly List<RiftLevelInfoUnlockConditions> _UnlockConditions = new List<RiftLevelInfoUnlockConditions>();

		// Token: 0x0400197F RID: 6527
		private int _StarTurnMax;

		// Token: 0x04001980 RID: 6528
		private int _StarDeadMax;

		// Token: 0x04001981 RID: 6529
		private int _Achievement1_ID;

		// Token: 0x04001982 RID: 6530
		private readonly List<Goods> _AchievementReward1 = new List<Goods>();

		// Token: 0x04001983 RID: 6531
		private int _Achievement2_ID;

		// Token: 0x04001984 RID: 6532
		private readonly List<Goods> _AchievementReward2 = new List<Goods>();

		// Token: 0x04001985 RID: 6533
		private int _Achievement3_ID;

		// Token: 0x04001986 RID: 6534
		private readonly List<Goods> _AchievementReward3 = new List<Goods>();

		// Token: 0x04001987 RID: 6535
		private int _PlayerExpReward;

		// Token: 0x04001988 RID: 6536
		private int _HeroExpReward;

		// Token: 0x04001989 RID: 6537
		private int _GoldReward;

		// Token: 0x0400198A RID: 6538
		private readonly List<Goods> _FirstReward = new List<Goods>();

		// Token: 0x0400198B RID: 6539
		private readonly List<Goods> _RaidReward = new List<Goods>();

		// Token: 0x0400198C RID: 6540
		private int _Drop_ID;

		// Token: 0x0400198D RID: 6541
		private int _OperationalActivityDrop_ID;

		// Token: 0x0400198E RID: 6542
		private int _DisplayRewardCount;

		// Token: 0x0400198F RID: 6543
		private string _Image;

		// Token: 0x04001990 RID: 6544
		private string _Icon;

		// Token: 0x04001991 RID: 6545
		private int _IconX;

		// Token: 0x04001992 RID: 6546
		private int _IconY;

		// Token: 0x04001993 RID: 6547
		private string _Strategy;

		// Token: 0x04001994 RID: 6548
		private RiftLevelType _LevelType;

		// Token: 0x04001995 RID: 6549
		private IExtension extensionObject;

		// Token: 0x04001996 RID: 6550
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x04001997 RID: 6551
		public int m_chapterId;

		// Token: 0x04001998 RID: 6552
		public ConfigDataRiftChapterInfo m_chapterInfo;

		// Token: 0x04001999 RID: 6553
		public BattleLevelAchievement[] m_achievements;

		// Token: 0x0400199A RID: 6554
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400199B RID: 6555
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400199C RID: 6556
		private LuaFunction m_ctor_hotfix;
	}
}
