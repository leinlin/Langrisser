using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200021E RID: 542
	[ProtoContract(Name = "ConfigDataCharImageInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataCharImageInfo : IExtensible
	{
		// Token: 0x06002005 RID: 8197 RVA: 0x0009FE30 File Offset: 0x0009E030
		public ConfigDataCharImageInfo()
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

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x0009FEF0 File Offset: 0x0009E0F0
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x0009FEF8 File Offset: 0x0009E0F8
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

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x0009FF04 File Offset: 0x0009E104
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x0009FF0C File Offset: 0x0009E10C
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

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x0009FF18 File Offset: 0x0009E118
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x0009FF20 File Offset: 0x0009E120
		[ProtoMember(4, IsRequired = true, Name = "Spine", DataFormat = DataFormat.Default)]
		public string Spine
		{
			get
			{
				return this._Spine;
			}
			set
			{
				this._Spine = value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x0009FF2C File Offset: 0x0009E12C
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x0009FF34 File Offset: 0x0009E134
		[ProtoMember(5, IsRequired = true, Name = "HeroPainting", DataFormat = DataFormat.Default)]
		public string HeroPainting
		{
			get
			{
				return this._HeroPainting;
			}
			set
			{
				this._HeroPainting = value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x0009FF40 File Offset: 0x0009E140
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x0009FF48 File Offset: 0x0009E148
		[ProtoMember(6, IsRequired = true, Name = "Image", DataFormat = DataFormat.Default)]
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

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x0009FF54 File Offset: 0x0009E154
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x0009FF5C File Offset: 0x0009E15C
		[ProtoMember(7, IsRequired = true, Name = "Direction", DataFormat = DataFormat.TwosComplement)]
		public int Direction
		{
			get
			{
				return this._Direction;
			}
			set
			{
				this._Direction = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x0009FF68 File Offset: 0x0009E168
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x0009FF70 File Offset: 0x0009E170
		[ProtoMember(8, IsRequired = true, Name = "CVName", DataFormat = DataFormat.Default)]
		public string CVName
		{
			get
			{
				return this._CVName;
			}
			set
			{
				this._CVName = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x0009FF7C File Offset: 0x0009E17C
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x0009FF84 File Offset: 0x0009E184
		[ProtoMember(9, IsRequired = true, Name = "HeroDetailScale", DataFormat = DataFormat.TwosComplement)]
		public int HeroDetailScale
		{
			get
			{
				return this._HeroDetailScale;
			}
			set
			{
				this._HeroDetailScale = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x0009FF90 File Offset: 0x0009E190
		// (set) Token: 0x06002017 RID: 8215 RVA: 0x0009FF98 File Offset: 0x0009E198
		[ProtoMember(10, IsRequired = true, Name = "HeroDetailYOffset", DataFormat = DataFormat.TwosComplement)]
		public int HeroDetailYOffset
		{
			get
			{
				return this._HeroDetailYOffset;
			}
			set
			{
				this._HeroDetailYOffset = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x0009FFA4 File Offset: 0x0009E1A4
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x0009FFAC File Offset: 0x0009E1AC
		[ProtoMember(11, IsRequired = true, Name = "HeroFetterYOffset", DataFormat = DataFormat.TwosComplement)]
		public int HeroFetterYOffset
		{
			get
			{
				return this._HeroFetterYOffset;
			}
			set
			{
				this._HeroFetterYOffset = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x0009FFB8 File Offset: 0x0009E1B8
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x0009FFC0 File Offset: 0x0009E1C0
		[ProtoMember(12, IsRequired = true, Name = "CombatScale", DataFormat = DataFormat.TwosComplement)]
		public int CombatScale
		{
			get
			{
				return this._CombatScale;
			}
			set
			{
				this._CombatScale = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x0009FFCC File Offset: 0x0009E1CC
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x0009FFD4 File Offset: 0x0009E1D4
		[ProtoMember(13, IsRequired = true, Name = "CombatYOffset", DataFormat = DataFormat.TwosComplement)]
		public int CombatYOffset
		{
			get
			{
				return this._CombatYOffset;
			}
			set
			{
				this._CombatYOffset = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0009FFE0 File Offset: 0x0009E1E0
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x0009FFE8 File Offset: 0x0009E1E8
		[ProtoMember(14, IsRequired = true, Name = "BattleDialogScale", DataFormat = DataFormat.TwosComplement)]
		public int BattleDialogScale
		{
			get
			{
				return this._BattleDialogScale;
			}
			set
			{
				this._BattleDialogScale = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x0009FFF4 File Offset: 0x0009E1F4
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x0009FFFC File Offset: 0x0009E1FC
		[ProtoMember(15, IsRequired = true, Name = "BattleDialogYOffset", DataFormat = DataFormat.TwosComplement)]
		public int BattleDialogYOffset
		{
			get
			{
				return this._BattleDialogYOffset;
			}
			set
			{
				this._BattleDialogYOffset = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x000A0008 File Offset: 0x0009E208
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x000A0010 File Offset: 0x0009E210
		[ProtoMember(16, IsRequired = true, Name = "DialogScale", DataFormat = DataFormat.TwosComplement)]
		public int DialogScale
		{
			get
			{
				return this._DialogScale;
			}
			set
			{
				this._DialogScale = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x000A001C File Offset: 0x0009E21C
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x000A0024 File Offset: 0x0009E224
		[ProtoMember(17, IsRequired = true, Name = "DialogYOffset", DataFormat = DataFormat.TwosComplement)]
		public int DialogYOffset
		{
			get
			{
				return this._DialogYOffset;
			}
			set
			{
				this._DialogYOffset = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x000A0030 File Offset: 0x0009E230
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x000A0038 File Offset: 0x0009E238
		[ProtoMember(18, IsRequired = true, Name = "RoundHeadImage", DataFormat = DataFormat.Default)]
		public string RoundHeadImage
		{
			get
			{
				return this._RoundHeadImage;
			}
			set
			{
				this._RoundHeadImage = value;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x000A0044 File Offset: 0x0009E244
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x000A004C File Offset: 0x0009E24C
		[ProtoMember(19, IsRequired = true, Name = "SummonHeadImage", DataFormat = DataFormat.Default)]
		public string SummonHeadImage
		{
			get
			{
				return this._SummonHeadImage;
			}
			set
			{
				this._SummonHeadImage = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x000A0058 File Offset: 0x0009E258
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x000A0060 File Offset: 0x0009E260
		[ProtoMember(20, IsRequired = true, Name = "CardHeadImage", DataFormat = DataFormat.Default)]
		public string CardHeadImage
		{
			get
			{
				return this._CardHeadImage;
			}
			set
			{
				this._CardHeadImage = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x000A006C File Offset: 0x0009E26C
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x000A0074 File Offset: 0x0009E274
		[ProtoMember(21, IsRequired = true, Name = "SmallHeadImage", DataFormat = DataFormat.Default)]
		public string SmallHeadImage
		{
			get
			{
				return this._SmallHeadImage;
			}
			set
			{
				this._SmallHeadImage = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x000A0080 File Offset: 0x0009E280
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x000A0088 File Offset: 0x0009E288
		[ProtoMember(22, IsRequired = true, Name = "SkillCutscene_ID", DataFormat = DataFormat.TwosComplement)]
		public int SkillCutscene_ID
		{
			get
			{
				return this._SkillCutscene_ID;
			}
			set
			{
				this._SkillCutscene_ID = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x000A0094 File Offset: 0x0009E294
		// (set) Token: 0x06002031 RID: 8241 RVA: 0x000A009C File Offset: 0x0009E29C
		[ProtoMember(23, IsRequired = true, Name = "Sound_Die", DataFormat = DataFormat.Default)]
		public string Sound_Die
		{
			get
			{
				return this._Sound_Die;
			}
			set
			{
				this._Sound_Die = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x000A00A8 File Offset: 0x0009E2A8
		[ProtoMember(24, Name = "Performances", DataFormat = DataFormat.Default)]
		public List<PerformanceEffect> Performances
		{
			get
			{
				return this._Performances;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x000A00B0 File Offset: 0x0009E2B0
		[ProtoMember(25, Name = "BreakPerformances", DataFormat = DataFormat.Default)]
		public List<PerformanceEffect> BreakPerformances
		{
			get
			{
				return this._BreakPerformances;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x000A00B8 File Offset: 0x0009E2B8
		[ProtoMember(26, Name = "SummonPerformances", DataFormat = DataFormat.Default)]
		public List<PerformanceEffect> SummonPerformances
		{
			get
			{
				return this._SummonPerformances;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x000A00C0 File Offset: 0x0009E2C0
		[ProtoMember(27, Name = "JobTransferPerformances", DataFormat = DataFormat.Default)]
		public List<PerformanceEffect> JobTransferPerformances
		{
			get
			{
				return this._JobTransferPerformances;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x000A00C8 File Offset: 0x0009E2C8
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x000A00D0 File Offset: 0x0009E2D0
		[ProtoMember(28, IsRequired = true, Name = "BattleActionVoice1", DataFormat = DataFormat.Default)]
		public string BattleActionVoice1
		{
			get
			{
				return this._BattleActionVoice1;
			}
			set
			{
				this._BattleActionVoice1 = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x000A00DC File Offset: 0x0009E2DC
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x000A00E4 File Offset: 0x0009E2E4
		[ProtoMember(29, IsRequired = true, Name = "BattleActionVoice2", DataFormat = DataFormat.Default)]
		public string BattleActionVoice2
		{
			get
			{
				return this._BattleActionVoice2;
			}
			set
			{
				this._BattleActionVoice2 = value;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x000A00F0 File Offset: 0x0009E2F0
		// (set) Token: 0x0600203B RID: 8251 RVA: 0x000A00F8 File Offset: 0x0009E2F8
		[ProtoMember(30, IsRequired = true, Name = "BattleActionVoice3", DataFormat = DataFormat.Default)]
		public string BattleActionVoice3
		{
			get
			{
				return this._BattleActionVoice3;
			}
			set
			{
				this._BattleActionVoice3 = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x000A0104 File Offset: 0x0009E304
		[ProtoMember(31, Name = "NewPerformances", DataFormat = DataFormat.Default)]
		public List<FavourabilityPerformance> NewPerformances
		{
			get
			{
				return this._NewPerformances;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x000A010C File Offset: 0x0009E30C
		[ProtoMember(32, Name = "NewBreakPerformances", DataFormat = DataFormat.Default)]
		public List<FavourabilityPerformance> NewBreakPerformances
		{
			get
			{
				return this._NewBreakPerformances;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x000A0114 File Offset: 0x0009E314
		[ProtoMember(33, Name = "NewSummonPerformances", DataFormat = DataFormat.Default)]
		public List<FavourabilityPerformance> NewSummonPerformances
		{
			get
			{
				return this._NewSummonPerformances;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x000A011C File Offset: 0x0009E31C
		[ProtoMember(34, Name = "NewJobTransferPerformances", DataFormat = DataFormat.Default)]
		public List<FavourabilityPerformance> NewJobTransferPerformances
		{
			get
			{
				return this._NewJobTransferPerformances;
			}
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x000A0124 File Offset: 0x0009E324
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x000A0134 File Offset: 0x0009E334
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

		// Token: 0x06002042 RID: 8258 RVA: 0x000A0200 File Offset: 0x0009E400
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataCharImageInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001353 RID: 4947
		private int _ID;

		// Token: 0x04001354 RID: 4948
		private string _Name;

		// Token: 0x04001355 RID: 4949
		private string _Spine;

		// Token: 0x04001356 RID: 4950
		private string _HeroPainting;

		// Token: 0x04001357 RID: 4951
		private string _Image;

		// Token: 0x04001358 RID: 4952
		private int _Direction;

		// Token: 0x04001359 RID: 4953
		private string _CVName;

		// Token: 0x0400135A RID: 4954
		private int _HeroDetailScale;

		// Token: 0x0400135B RID: 4955
		private int _HeroDetailYOffset;

		// Token: 0x0400135C RID: 4956
		private int _HeroFetterYOffset;

		// Token: 0x0400135D RID: 4957
		private int _CombatScale;

		// Token: 0x0400135E RID: 4958
		private int _CombatYOffset;

		// Token: 0x0400135F RID: 4959
		private int _BattleDialogScale;

		// Token: 0x04001360 RID: 4960
		private int _BattleDialogYOffset;

		// Token: 0x04001361 RID: 4961
		private int _DialogScale;

		// Token: 0x04001362 RID: 4962
		private int _DialogYOffset;

		// Token: 0x04001363 RID: 4963
		private string _RoundHeadImage;

		// Token: 0x04001364 RID: 4964
		private string _SummonHeadImage;

		// Token: 0x04001365 RID: 4965
		private string _CardHeadImage;

		// Token: 0x04001366 RID: 4966
		private string _SmallHeadImage;

		// Token: 0x04001367 RID: 4967
		private int _SkillCutscene_ID;

		// Token: 0x04001368 RID: 4968
		private string _Sound_Die;

		// Token: 0x04001369 RID: 4969
		private readonly List<PerformanceEffect> _Performances = new List<PerformanceEffect>();

		// Token: 0x0400136A RID: 4970
		private readonly List<PerformanceEffect> _BreakPerformances = new List<PerformanceEffect>();

		// Token: 0x0400136B RID: 4971
		private readonly List<PerformanceEffect> _SummonPerformances = new List<PerformanceEffect>();

		// Token: 0x0400136C RID: 4972
		private readonly List<PerformanceEffect> _JobTransferPerformances = new List<PerformanceEffect>();

		// Token: 0x0400136D RID: 4973
		private string _BattleActionVoice1;

		// Token: 0x0400136E RID: 4974
		private string _BattleActionVoice2;

		// Token: 0x0400136F RID: 4975
		private string _BattleActionVoice3;

		// Token: 0x04001370 RID: 4976
		private readonly List<FavourabilityPerformance> _NewPerformances = new List<FavourabilityPerformance>();

		// Token: 0x04001371 RID: 4977
		private readonly List<FavourabilityPerformance> _NewBreakPerformances = new List<FavourabilityPerformance>();

		// Token: 0x04001372 RID: 4978
		private readonly List<FavourabilityPerformance> _NewSummonPerformances = new List<FavourabilityPerformance>();

		// Token: 0x04001373 RID: 4979
		private readonly List<FavourabilityPerformance> _NewJobTransferPerformances = new List<FavourabilityPerformance>();

		// Token: 0x04001374 RID: 4980
		private IExtension extensionObject;

		// Token: 0x04001375 RID: 4981
		public ConfigDataCutsceneInfo m_skillCutsceneInfo;

		// Token: 0x04001376 RID: 4982
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001377 RID: 4983
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001378 RID: 4984
		private LuaFunction m_ctor_hotfix;
	}
}
