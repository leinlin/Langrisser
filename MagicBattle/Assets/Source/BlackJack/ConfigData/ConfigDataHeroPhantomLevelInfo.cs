using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000250 RID: 592
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataHeroPhantomLevelInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataHeroPhantomLevelInfo : IExtensible
	{
		// Token: 0x060024E3 RID: 9443 RVA: 0x000A8030 File Offset: 0x000A6230
		public ConfigDataHeroPhantomLevelInfo()
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

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x000A80C4 File Offset: 0x000A62C4
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x000A80CC File Offset: 0x000A62CC
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

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000A80D8 File Offset: 0x000A62D8
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x000A80E0 File Offset: 0x000A62E0
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

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000A80EC File Offset: 0x000A62EC
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x000A80F4 File Offset: 0x000A62F4
		[ProtoMember(4, IsRequired = true, Name = "PreLevel", DataFormat = DataFormat.TwosComplement)]
		public int PreLevel
		{
			get
			{
				return this._PreLevel;
			}
			set
			{
				this._PreLevel = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x000A8100 File Offset: 0x000A6300
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x000A8108 File Offset: 0x000A6308
		[ProtoMember(5, IsRequired = true, Name = "EnergySuccess", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000A8114 File Offset: 0x000A6314
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x000A811C File Offset: 0x000A631C
		[ProtoMember(6, IsRequired = true, Name = "EnergyFail", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000A8128 File Offset: 0x000A6328
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x000A8130 File Offset: 0x000A6330
		[ProtoMember(7, IsRequired = true, Name = "MonsterLevel", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x000A813C File Offset: 0x000A633C
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x000A8144 File Offset: 0x000A6344
		[ProtoMember(8, IsRequired = true, Name = "Battle_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x000A8150 File Offset: 0x000A6350
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x000A8158 File Offset: 0x000A6358
		[ProtoMember(9, IsRequired = true, Name = "PlayerExp", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x000A8164 File Offset: 0x000A6364
		// (set) Token: 0x060024F5 RID: 9461 RVA: 0x000A816C File Offset: 0x000A636C
		[ProtoMember(10, IsRequired = true, Name = "HeroExp", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x000A8178 File Offset: 0x000A6378
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x000A8180 File Offset: 0x000A6380
		[ProtoMember(11, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public int Gold
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

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x000A818C File Offset: 0x000A638C
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x000A8194 File Offset: 0x000A6394
		[ProtoMember(12, IsRequired = true, Name = "DropID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x000A81A0 File Offset: 0x000A63A0
		[ProtoMember(13, Name = "FirstClearDropItems", DataFormat = DataFormat.Default)]
		public List<Goods> FirstClearDropItems
		{
			get
			{
				return this._FirstClearDropItems;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060024FB RID: 9467 RVA: 0x000A81A8 File Offset: 0x000A63A8
		// (set) Token: 0x060024FC RID: 9468 RVA: 0x000A81B0 File Offset: 0x000A63B0
		[ProtoMember(14, IsRequired = true, Name = "DisplayRewardCount", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x000A81BC File Offset: 0x000A63BC
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x000A81C4 File Offset: 0x000A63C4
		[ProtoMember(15, IsRequired = true, Name = "Achievement1ID", DataFormat = DataFormat.TwosComplement)]
		public int Achievement1ID
		{
			get
			{
				return this._Achievement1ID;
			}
			set
			{
				this._Achievement1ID = value;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x000A81D0 File Offset: 0x000A63D0
		[ProtoMember(16, Name = "Achievement1BonusItem", DataFormat = DataFormat.Default)]
		public List<Goods> Achievement1BonusItem
		{
			get
			{
				return this._Achievement1BonusItem;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x000A81D8 File Offset: 0x000A63D8
		// (set) Token: 0x06002501 RID: 9473 RVA: 0x000A81E0 File Offset: 0x000A63E0
		[ProtoMember(17, IsRequired = true, Name = "Achievement2ID", DataFormat = DataFormat.TwosComplement)]
		public int Achievement2ID
		{
			get
			{
				return this._Achievement2ID;
			}
			set
			{
				this._Achievement2ID = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x000A81EC File Offset: 0x000A63EC
		[ProtoMember(18, Name = "Achievement2BonusItem", DataFormat = DataFormat.Default)]
		public List<Goods> Achievement2BonusItem
		{
			get
			{
				return this._Achievement2BonusItem;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x000A81F4 File Offset: 0x000A63F4
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x000A81FC File Offset: 0x000A63FC
		[ProtoMember(19, IsRequired = true, Name = "Achievement3ID", DataFormat = DataFormat.TwosComplement)]
		public int Achievement3ID
		{
			get
			{
				return this._Achievement3ID;
			}
			set
			{
				this._Achievement3ID = value;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x000A8208 File Offset: 0x000A6408
		[ProtoMember(20, Name = "Achievement3BonusItem", DataFormat = DataFormat.Default)]
		public List<Goods> Achievement3BonusItem
		{
			get
			{
				return this._Achievement3BonusItem;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x000A8210 File Offset: 0x000A6410
		// (set) Token: 0x06002507 RID: 9479 RVA: 0x000A8218 File Offset: 0x000A6418
		[ProtoMember(21, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x000A8224 File Offset: 0x000A6424
		// (set) Token: 0x06002509 RID: 9481 RVA: 0x000A822C File Offset: 0x000A642C
		[ProtoMember(22, IsRequired = true, Name = "Strategy", DataFormat = DataFormat.Default)]
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

		// Token: 0x0600250A RID: 9482 RVA: 0x000A8238 File Offset: 0x000A6438
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000A8248 File Offset: 0x000A6448
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

		// Token: 0x0600250C RID: 9484 RVA: 0x000A8314 File Offset: 0x000A6514
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroPhantomLevelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001685 RID: 5765
		private int _ID;

		// Token: 0x04001686 RID: 5766
		private string _Name;

		// Token: 0x04001687 RID: 5767
		private int _PreLevel;

		// Token: 0x04001688 RID: 5768
		private int _EnergySuccess;

		// Token: 0x04001689 RID: 5769
		private int _EnergyFail;

		// Token: 0x0400168A RID: 5770
		private int _MonsterLevel;

		// Token: 0x0400168B RID: 5771
		private int _Battle_ID;

		// Token: 0x0400168C RID: 5772
		private int _PlayerExp;

		// Token: 0x0400168D RID: 5773
		private int _HeroExp;

		// Token: 0x0400168E RID: 5774
		private int _Gold;

		// Token: 0x0400168F RID: 5775
		private int _DropID;

		// Token: 0x04001690 RID: 5776
		private readonly List<Goods> _FirstClearDropItems = new List<Goods>();

		// Token: 0x04001691 RID: 5777
		private int _DisplayRewardCount;

		// Token: 0x04001692 RID: 5778
		private int _Achievement1ID;

		// Token: 0x04001693 RID: 5779
		private readonly List<Goods> _Achievement1BonusItem = new List<Goods>();

		// Token: 0x04001694 RID: 5780
		private int _Achievement2ID;

		// Token: 0x04001695 RID: 5781
		private readonly List<Goods> _Achievement2BonusItem = new List<Goods>();

		// Token: 0x04001696 RID: 5782
		private int _Achievement3ID;

		// Token: 0x04001697 RID: 5783
		private readonly List<Goods> _Achievement3BonusItem = new List<Goods>();

		// Token: 0x04001698 RID: 5784
		private string _Icon;

		// Token: 0x04001699 RID: 5785
		private string _Strategy;

		// Token: 0x0400169A RID: 5786
		private IExtension extensionObject;

		// Token: 0x0400169B RID: 5787
		public BattleLevelAchievement[] m_achievements;

		// Token: 0x0400169C RID: 5788
		public ConfigDataBattleInfo m_battleInfo;

		// Token: 0x0400169D RID: 5789
		public ConfigDataHeroPhantomInfo m_groupInfo;

		// Token: 0x0400169E RID: 5790
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400169F RID: 5791
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040016A0 RID: 5792
		private LuaFunction m_ctor_hotfix;
	}
}
