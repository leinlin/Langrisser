using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000246 RID: 582
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataHeroDungeonLevelInfo")]
	[Serializable]
	public class ConfigDataHeroDungeonLevelInfo : IExtensible
	{
		// Token: 0x060023DC RID: 9180 RVA: 0x000A64D0 File Offset: 0x000A46D0
		public ConfigDataHeroDungeonLevelInfo()
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

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x000A6578 File Offset: 0x000A4778
		// (set) Token: 0x060023DE RID: 9182 RVA: 0x000A6580 File Offset: 0x000A4780
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

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x000A658C File Offset: 0x000A478C
		// (set) Token: 0x060023E0 RID: 9184 RVA: 0x000A6594 File Offset: 0x000A4794
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

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060023E1 RID: 9185 RVA: 0x000A65A0 File Offset: 0x000A47A0
		// (set) Token: 0x060023E2 RID: 9186 RVA: 0x000A65A8 File Offset: 0x000A47A8
		[ProtoMember(4, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060023E3 RID: 9187 RVA: 0x000A65B4 File Offset: 0x000A47B4
		// (set) Token: 0x060023E4 RID: 9188 RVA: 0x000A65BC File Offset: 0x000A47BC
		[ProtoMember(5, IsRequired = true, Name = "NameNum", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060023E5 RID: 9189 RVA: 0x000A65C8 File Offset: 0x000A47C8
		// (set) Token: 0x060023E6 RID: 9190 RVA: 0x000A65D0 File Offset: 0x000A47D0
		[ProtoMember(6, IsRequired = true, Name = "Resource", DataFormat = DataFormat.Default)]
		public string Resource
		{
			get
			{
				return this._Resource;
			}
			set
			{
				this._Resource = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060023E7 RID: 9191 RVA: 0x000A65DC File Offset: 0x000A47DC
		// (set) Token: 0x060023E8 RID: 9192 RVA: 0x000A65E4 File Offset: 0x000A47E4
		[ProtoMember(7, IsRequired = true, Name = "ChallengeCount", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060023E9 RID: 9193 RVA: 0x000A65F0 File Offset: 0x000A47F0
		// (set) Token: 0x060023EA RID: 9194 RVA: 0x000A65F8 File Offset: 0x000A47F8
		[ProtoMember(8, IsRequired = true, Name = "EnergySuccess", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x000A6604 File Offset: 0x000A4804
		// (set) Token: 0x060023EC RID: 9196 RVA: 0x000A660C File Offset: 0x000A480C
		[ProtoMember(9, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x000A6618 File Offset: 0x000A4818
		// (set) Token: 0x060023EE RID: 9198 RVA: 0x000A6620 File Offset: 0x000A4820
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

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x000A662C File Offset: 0x000A482C
		// (set) Token: 0x060023F0 RID: 9200 RVA: 0x000A6634 File Offset: 0x000A4834
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

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x000A6640 File Offset: 0x000A4840
		// (set) Token: 0x060023F2 RID: 9202 RVA: 0x000A6648 File Offset: 0x000A4848
		[ProtoMember(12, IsRequired = true, Name = "DialogBefore_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x000A6654 File Offset: 0x000A4854
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x000A665C File Offset: 0x000A485C
		[ProtoMember(13, IsRequired = true, Name = "DialogAfter_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x000A6668 File Offset: 0x000A4868
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x000A6670 File Offset: 0x000A4870
		[ProtoMember(14, IsRequired = true, Name = "PreLevel_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000A667C File Offset: 0x000A487C
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x000A6684 File Offset: 0x000A4884
		[ProtoMember(15, IsRequired = true, Name = "PlayerLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000A6690 File Offset: 0x000A4890
		[ProtoMember(16, Name = "UnlockConditions", DataFormat = DataFormat.Default)]
		public List<HeroDungeonLevelUnlcokCondition> UnlockConditions
		{
			get
			{
				return this._UnlockConditions;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x000A6698 File Offset: 0x000A4898
		// (set) Token: 0x060023FB RID: 9211 RVA: 0x000A66A0 File Offset: 0x000A48A0
		[ProtoMember(17, IsRequired = true, Name = "StarTurnMax", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x000A66AC File Offset: 0x000A48AC
		// (set) Token: 0x060023FD RID: 9213 RVA: 0x000A66B4 File Offset: 0x000A48B4
		[ProtoMember(18, IsRequired = true, Name = "StarDeadMax", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x000A66C0 File Offset: 0x000A48C0
		// (set) Token: 0x060023FF RID: 9215 RVA: 0x000A66C8 File Offset: 0x000A48C8
		[ProtoMember(19, IsRequired = true, Name = "Achievement1_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x000A66D4 File Offset: 0x000A48D4
		[ProtoMember(20, Name = "AchievementReward1", DataFormat = DataFormat.Default)]
		public List<Goods> AchievementReward1
		{
			get
			{
				return this._AchievementReward1;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x000A66DC File Offset: 0x000A48DC
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x000A66E4 File Offset: 0x000A48E4
		[ProtoMember(21, IsRequired = true, Name = "Achievement2_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x000A66F0 File Offset: 0x000A48F0
		[ProtoMember(22, Name = "AchievementReward2", DataFormat = DataFormat.Default)]
		public List<Goods> AchievementReward2
		{
			get
			{
				return this._AchievementReward2;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x000A66F8 File Offset: 0x000A48F8
		// (set) Token: 0x06002405 RID: 9221 RVA: 0x000A6700 File Offset: 0x000A4900
		[ProtoMember(23, IsRequired = true, Name = "Achievement3_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06002406 RID: 9222 RVA: 0x000A670C File Offset: 0x000A490C
		[ProtoMember(24, Name = "AchievementReward3", DataFormat = DataFormat.Default)]
		public List<Goods> AchievementReward3
		{
			get
			{
				return this._AchievementReward3;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x000A6714 File Offset: 0x000A4914
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x000A671C File Offset: 0x000A491C
		[ProtoMember(25, IsRequired = true, Name = "PlayerExpReward", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x000A6728 File Offset: 0x000A4928
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x000A6730 File Offset: 0x000A4930
		[ProtoMember(26, IsRequired = true, Name = "HeroExpReward", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x000A673C File Offset: 0x000A493C
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x000A6744 File Offset: 0x000A4944
		[ProtoMember(27, IsRequired = true, Name = "GoldReward", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000A6750 File Offset: 0x000A4950
		[ProtoMember(28, Name = "FirstReward", DataFormat = DataFormat.Default)]
		public List<Goods> FirstReward
		{
			get
			{
				return this._FirstReward;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x000A6758 File Offset: 0x000A4958
		[ProtoMember(29, Name = "RaidReward", DataFormat = DataFormat.Default)]
		public List<Goods> RaidReward
		{
			get
			{
				return this._RaidReward;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x000A6760 File Offset: 0x000A4960
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x000A6768 File Offset: 0x000A4968
		[ProtoMember(30, IsRequired = true, Name = "Drop_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x000A6774 File Offset: 0x000A4974
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x000A677C File Offset: 0x000A497C
		[ProtoMember(31, IsRequired = true, Name = "OperationalActivityDrop_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x000A6788 File Offset: 0x000A4988
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x000A6790 File Offset: 0x000A4990
		[ProtoMember(32, IsRequired = true, Name = "DisplayRewardCount", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x000A679C File Offset: 0x000A499C
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x000A67A4 File Offset: 0x000A49A4
		[ProtoMember(33, IsRequired = true, Name = "Strategy", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x000A67B0 File Offset: 0x000A49B0
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x000A67B8 File Offset: 0x000A49B8
		[ProtoMember(34, IsRequired = true, Name = "HeroFragment_ID", DataFormat = DataFormat.TwosComplement)]
		public int HeroFragment_ID
		{
			get
			{
				return this._HeroFragment_ID;
			}
			set
			{
				this._HeroFragment_ID = value;
			}
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x000A67C4 File Offset: 0x000A49C4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x000A67D4 File Offset: 0x000A49D4
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

		// Token: 0x0600241B RID: 9243 RVA: 0x000A68A0 File Offset: 0x000A4AA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroDungeonLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040015CA RID: 5578
		private int _ID;

		// Token: 0x040015CB RID: 5579
		private string _Name;

		// Token: 0x040015CC RID: 5580
		private string _Desc;

		// Token: 0x040015CD RID: 5581
		private string _NameNum;

		// Token: 0x040015CE RID: 5582
		private string _Resource;

		// Token: 0x040015CF RID: 5583
		private int _ChallengeCount;

		// Token: 0x040015D0 RID: 5584
		private int _EnergySuccess;

		// Token: 0x040015D1 RID: 5585
		private int _EnergyFail;

		// Token: 0x040015D2 RID: 5586
		private int _MonsterLevel;

		// Token: 0x040015D3 RID: 5587
		private int _Battle_ID;

		// Token: 0x040015D4 RID: 5588
		private int _DialogBefore_ID;

		// Token: 0x040015D5 RID: 5589
		private int _DialogAfter_ID;

		// Token: 0x040015D6 RID: 5590
		private int _PreLevel_ID;

		// Token: 0x040015D7 RID: 5591
		private int _PlayerLevel;

		// Token: 0x040015D8 RID: 5592
		private readonly List<HeroDungeonLevelUnlcokCondition> _UnlockConditions = new List<HeroDungeonLevelUnlcokCondition>();

		// Token: 0x040015D9 RID: 5593
		private int _StarTurnMax;

		// Token: 0x040015DA RID: 5594
		private int _StarDeadMax;

		// Token: 0x040015DB RID: 5595
		private int _Achievement1_ID;

		// Token: 0x040015DC RID: 5596
		private readonly List<Goods> _AchievementReward1 = new List<Goods>();

		// Token: 0x040015DD RID: 5597
		private int _Achievement2_ID;

		// Token: 0x040015DE RID: 5598
		private readonly List<Goods> _AchievementReward2 = new List<Goods>();

		// Token: 0x040015DF RID: 5599
		private int _Achievement3_ID;

		// Token: 0x040015E0 RID: 5600
		private readonly List<Goods> _AchievementReward3 = new List<Goods>();

		// Token: 0x040015E1 RID: 5601
		private int _PlayerExpReward;

		// Token: 0x040015E2 RID: 5602
		private int _HeroExpReward;

		// Token: 0x040015E3 RID: 5603
		private int _GoldReward;

		// Token: 0x040015E4 RID: 5604
		private readonly List<Goods> _FirstReward = new List<Goods>();

		// Token: 0x040015E5 RID: 5605
		private readonly List<Goods> _RaidReward = new List<Goods>();

		// Token: 0x040015E6 RID: 5606
		private int _Drop_ID;

		// Token: 0x040015E7 RID: 5607
		private int _OperationalActivityDrop_ID;

		// Token: 0x040015E8 RID: 5608
		private int _DisplayRewardCount;

		// Token: 0x040015E9 RID: 5609
		private string _Strategy;

		// Token: 0x040015EA RID: 5610
		private int _HeroFragment_ID;

		// Token: 0x040015EB RID: 5611
		private IExtension extensionObject;

		// Token: 0x040015EC RID: 5612
		public int m_chapterId;

		// Token: 0x040015ED RID: 5613
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x040015EE RID: 5614
		public BattleLevelAchievement[] m_achievements;

		// Token: 0x040015EF RID: 5615
		public ConfigDataDialogInfo m_dialogInfoBefore;

		// Token: 0x040015F0 RID: 5616
		public ConfigDataDialogInfo m_dialogInfoAfter;

		// Token: 0x040015F1 RID: 5617
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040015F2 RID: 5618
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040015F3 RID: 5619
		private LuaFunction m_ctor_hotfix;
	}
}
