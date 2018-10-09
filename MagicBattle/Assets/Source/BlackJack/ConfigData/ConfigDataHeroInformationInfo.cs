using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200024A RID: 586
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataHeroInformationInfo")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataHeroInformationInfo : IExtensible
	{
		// Token: 0x06002476 RID: 9334 RVA: 0x000A7270 File Offset: 0x000A5470
		public ConfigDataHeroInformationInfo()
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

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x000A7330 File Offset: 0x000A5530
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x000A7338 File Offset: 0x000A5538
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

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x000A7344 File Offset: 0x000A5544
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x000A734C File Offset: 0x000A554C
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

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x000A7358 File Offset: 0x000A5558
		[ProtoMember(4, Name = "HeroBiographies_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> HeroBiographies_ID
		{
			get
			{
				return this._HeroBiographies_ID;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600247C RID: 9340 RVA: 0x000A7360 File Offset: 0x000A5560
		[ProtoMember(5, Name = "HeroFetters_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> HeroFetters_ID
		{
			get
			{
				return this._HeroFetters_ID;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x000A7368 File Offset: 0x000A5568
		// (set) Token: 0x0600247E RID: 9342 RVA: 0x000A7370 File Offset: 0x000A5570
		[ProtoMember(6, IsRequired = true, Name = "HeroConfession", DataFormat = DataFormat.TwosComplement)]
		public int HeroConfession
		{
			get
			{
				return this._HeroConfession;
			}
			set
			{
				this._HeroConfession = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x000A737C File Offset: 0x000A557C
		// (set) Token: 0x06002480 RID: 9344 RVA: 0x000A7384 File Offset: 0x000A5584
		[ProtoMember(7, IsRequired = true, Name = "HeroPerformance_ID", DataFormat = DataFormat.TwosComplement)]
		public int HeroPerformance_ID
		{
			get
			{
				return this._HeroPerformance_ID;
			}
			set
			{
				this._HeroPerformance_ID = value;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x000A7390 File Offset: 0x000A5590
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x000A7398 File Offset: 0x000A5598
		[ProtoMember(8, IsRequired = true, Name = "IsDungeonLevelsUnLock", DataFormat = DataFormat.Default)]
		public bool IsDungeonLevelsUnLock
		{
			get
			{
				return this._IsDungeonLevelsUnLock;
			}
			set
			{
				this._IsDungeonLevelsUnLock = value;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x000A73A4 File Offset: 0x000A55A4
		[ProtoMember(9, Name = "DungeonLevels_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> DungeonLevels_ID
		{
			get
			{
				return this._DungeonLevels_ID;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x000A73AC File Offset: 0x000A55AC
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x000A73B4 File Offset: 0x000A55B4
		[ProtoMember(10, IsRequired = true, Name = "Reward1Star", DataFormat = DataFormat.TwosComplement)]
		public int Reward1Star
		{
			get
			{
				return this._Reward1Star;
			}
			set
			{
				this._Reward1Star = value;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x000A73C0 File Offset: 0x000A55C0
		[ProtoMember(11, Name = "Reward1", DataFormat = DataFormat.Default)]
		public List<Goods> Reward1
		{
			get
			{
				return this._Reward1;
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x000A73C8 File Offset: 0x000A55C8
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x000A73D0 File Offset: 0x000A55D0
		[ProtoMember(12, IsRequired = true, Name = "Reward2Star", DataFormat = DataFormat.TwosComplement)]
		public int Reward2Star
		{
			get
			{
				return this._Reward2Star;
			}
			set
			{
				this._Reward2Star = value;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x000A73DC File Offset: 0x000A55DC
		[ProtoMember(13, Name = "Reward2", DataFormat = DataFormat.Default)]
		public List<Goods> Reward2
		{
			get
			{
				return this._Reward2;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x000A73E4 File Offset: 0x000A55E4
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x000A73EC File Offset: 0x000A55EC
		[ProtoMember(14, IsRequired = true, Name = "Reward3Star", DataFormat = DataFormat.TwosComplement)]
		public int Reward3Star
		{
			get
			{
				return this._Reward3Star;
			}
			set
			{
				this._Reward3Star = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x000A73F8 File Offset: 0x000A55F8
		[ProtoMember(15, Name = "Reward3", DataFormat = DataFormat.Default)]
		public List<Goods> Reward3
		{
			get
			{
				return this._Reward3;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x000A7400 File Offset: 0x000A5600
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x000A7408 File Offset: 0x000A5608
		[ProtoMember(16, IsRequired = true, Name = "FavorabilityMaxLevel", DataFormat = DataFormat.TwosComplement)]
		public int FavorabilityMaxLevel
		{
			get
			{
				return this._FavorabilityMaxLevel;
			}
			set
			{
				this._FavorabilityMaxLevel = value;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x000A7414 File Offset: 0x000A5614
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x000A741C File Offset: 0x000A561C
		[ProtoMember(17, IsRequired = true, Name = "FavourabilityLevelUpReward", DataFormat = DataFormat.TwosComplement)]
		public int FavourabilityLevelUpReward
		{
			get
			{
				return this._FavourabilityLevelUpReward;
			}
			set
			{
				this._FavourabilityLevelUpReward = value;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x000A7428 File Offset: 0x000A5628
		[ProtoMember(18, Name = "HeroTouch", DataFormat = DataFormat.Default)]
		public List<HeroInteractor> HeroTouch
		{
			get
			{
				return this._HeroTouch;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x000A7430 File Offset: 0x000A5630
		// (set) Token: 0x06002493 RID: 9363 RVA: 0x000A7438 File Offset: 0x000A5638
		[ProtoMember(19, IsRequired = true, Name = "SendRewardsPerformance", DataFormat = DataFormat.TwosComplement)]
		public int SendRewardsPerformance
		{
			get
			{
				return this._SendRewardsPerformance;
			}
			set
			{
				this._SendRewardsPerformance = value;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x000A7444 File Offset: 0x000A5644
		[ProtoMember(20, Name = "InteractHeroPerformances_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> InteractHeroPerformances_ID
		{
			get
			{
				return this._InteractHeroPerformances_ID;
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x000A744C File Offset: 0x000A564C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x000A745C File Offset: 0x000A565C
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

		// Token: 0x06002497 RID: 9367 RVA: 0x000A7528 File Offset: 0x000A5728
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroInformationInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001639 RID: 5689
		private int _ID;

		// Token: 0x0400163A RID: 5690
		private string _Name;

		// Token: 0x0400163B RID: 5691
		private readonly List<int> _HeroBiographies_ID = new List<int>();

		// Token: 0x0400163C RID: 5692
		private readonly List<int> _HeroFetters_ID = new List<int>();

		// Token: 0x0400163D RID: 5693
		private int _HeroConfession;

		// Token: 0x0400163E RID: 5694
		private int _HeroPerformance_ID;

		// Token: 0x0400163F RID: 5695
		private bool _IsDungeonLevelsUnLock;

		// Token: 0x04001640 RID: 5696
		private readonly List<int> _DungeonLevels_ID = new List<int>();

		// Token: 0x04001641 RID: 5697
		private int _Reward1Star;

		// Token: 0x04001642 RID: 5698
		private readonly List<Goods> _Reward1 = new List<Goods>();

		// Token: 0x04001643 RID: 5699
		private int _Reward2Star;

		// Token: 0x04001644 RID: 5700
		private readonly List<Goods> _Reward2 = new List<Goods>();

		// Token: 0x04001645 RID: 5701
		private int _Reward3Star;

		// Token: 0x04001646 RID: 5702
		private readonly List<Goods> _Reward3 = new List<Goods>();

		// Token: 0x04001647 RID: 5703
		private int _FavorabilityMaxLevel;

		// Token: 0x04001648 RID: 5704
		private int _FavourabilityLevelUpReward;

		// Token: 0x04001649 RID: 5705
		private readonly List<HeroInteractor> _HeroTouch = new List<HeroInteractor>();

		// Token: 0x0400164A RID: 5706
		private int _SendRewardsPerformance;

		// Token: 0x0400164B RID: 5707
		private readonly List<int> _InteractHeroPerformances_ID = new List<int>();

		// Token: 0x0400164C RID: 5708
		private IExtension extensionObject;

		// Token: 0x0400164D RID: 5709
		public List<ConfigDataHeroFetterInfo> m_fetterInfos;

		// Token: 0x0400164E RID: 5710
		public ConfigDataHeroConfessionInfo m_confessionInfo;

		// Token: 0x0400164F RID: 5711
		public ConfigDataHeroInfo m_heroInfo;

		// Token: 0x04001650 RID: 5712
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001651 RID: 5713
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001652 RID: 5714
		private LuaFunction m_ctor_hotfix;
	}
}
