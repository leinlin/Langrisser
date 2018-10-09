using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000249 RID: 585
	[ProtoContract(Name = "ConfigDataHeroInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataHeroInfo : IExtensible
	{
		// Token: 0x06002435 RID: 9269 RVA: 0x000A6D38 File Offset: 0x000A4F38
		public ConfigDataHeroInfo()
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

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x000A6E30 File Offset: 0x000A5030
		// (set) Token: 0x06002437 RID: 9271 RVA: 0x000A6E38 File Offset: 0x000A5038
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

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x000A6E44 File Offset: 0x000A5044
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x000A6E4C File Offset: 0x000A504C
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

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x000A6E58 File Offset: 0x000A5058
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x000A6E60 File Offset: 0x000A5060
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

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x000A6E6C File Offset: 0x000A506C
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x000A6E74 File Offset: 0x000A5074
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

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x000A6E80 File Offset: 0x000A5080
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x000A6E88 File Offset: 0x000A5088
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

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x000A6E94 File Offset: 0x000A5094
		// (set) Token: 0x06002441 RID: 9281 RVA: 0x000A6E9C File Offset: 0x000A509C
		[ProtoMember(7, IsRequired = true, Name = "Name_Eng", DataFormat = DataFormat.Default)]
		public string Name_Eng
		{
			get
			{
				return this._Name_Eng;
			}
			set
			{
				this._Name_Eng = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x000A6EA8 File Offset: 0x000A50A8
		// (set) Token: 0x06002443 RID: 9283 RVA: 0x000A6EB0 File Offset: 0x000A50B0
		[ProtoMember(8, IsRequired = true, Name = "JobWord", DataFormat = DataFormat.Default)]
		public string JobWord
		{
			get
			{
				return this._JobWord;
			}
			set
			{
				this._JobWord = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x000A6EBC File Offset: 0x000A50BC
		// (set) Token: 0x06002445 RID: 9285 RVA: 0x000A6EC4 File Offset: 0x000A50C4
		[ProtoMember(9, IsRequired = true, Name = "JobWordKey", DataFormat = DataFormat.Default)]
		public string JobWordKey
		{
			get
			{
				return this._JobWordKey;
			}
			set
			{
				this._JobWordKey = value;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x000A6ED0 File Offset: 0x000A50D0
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x000A6ED8 File Offset: 0x000A50D8
		[ProtoMember(10, IsRequired = true, Name = "Useable", DataFormat = DataFormat.Default)]
		public bool Useable
		{
			get
			{
				return this._Useable;
			}
			set
			{
				this._Useable = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x000A6EE4 File Offset: 0x000A50E4
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x000A6EEC File Offset: 0x000A50EC
		[ProtoMember(11, IsRequired = true, Name = "Sex", DataFormat = DataFormat.TwosComplement)]
		public int Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				this._Sex = value;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x000A6EF8 File Offset: 0x000A50F8
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x000A6F00 File Offset: 0x000A5100
		[ProtoMember(12, IsRequired = true, Name = "Star", DataFormat = DataFormat.TwosComplement)]
		public int Star
		{
			get
			{
				return this._Star;
			}
			set
			{
				this._Star = value;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x000A6F0C File Offset: 0x000A510C
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x000A6F14 File Offset: 0x000A5114
		[ProtoMember(13, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
		public int Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				this._Rank = value;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x000A6F20 File Offset: 0x000A5120
		[ProtoMember(14, Name = "StarToRank", DataFormat = DataFormat.Default)]
		public List<HeroInfoStarToRank> StarToRank
		{
			get
			{
				return this._StarToRank;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x000A6F28 File Offset: 0x000A5128
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x000A6F30 File Offset: 0x000A5130
		[ProtoMember(15, IsRequired = true, Name = "FragmentItem_ID", DataFormat = DataFormat.TwosComplement)]
		public int FragmentItem_ID
		{
			get
			{
				return this._FragmentItem_ID;
			}
			set
			{
				this._FragmentItem_ID = value;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x000A6F3C File Offset: 0x000A513C
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x000A6F44 File Offset: 0x000A5144
		[ProtoMember(16, IsRequired = true, Name = "ExchangedFragmentCount", DataFormat = DataFormat.TwosComplement)]
		public int ExchangedFragmentCount
		{
			get
			{
				return this._ExchangedFragmentCount;
			}
			set
			{
				this._ExchangedFragmentCount = value;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x000A6F50 File Offset: 0x000A5150
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x000A6F58 File Offset: 0x000A5158
		[ProtoMember(17, IsRequired = true, Name = "Soldier_ID", DataFormat = DataFormat.TwosComplement)]
		public int Soldier_ID
		{
			get
			{
				return this._Soldier_ID;
			}
			set
			{
				this._Soldier_ID = value;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x000A6F64 File Offset: 0x000A5164
		[ProtoMember(18, Name = "SelectableSoldier_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> SelectableSoldier_ID
		{
			get
			{
				return this._SelectableSoldier_ID;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06002456 RID: 9302 RVA: 0x000A6F6C File Offset: 0x000A516C
		[ProtoMember(19, Name = "Skills_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Skills_ID
		{
			get
			{
				return this._Skills_ID;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x000A6F74 File Offset: 0x000A5174
		[ProtoMember(20, Name = "HiddenSkills_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> HiddenSkills_ID
		{
			get
			{
				return this._HiddenSkills_ID;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x000A6F7C File Offset: 0x000A517C
		// (set) Token: 0x06002459 RID: 9305 RVA: 0x000A6F84 File Offset: 0x000A5184
		[ProtoMember(21, IsRequired = true, Name = "HPCmd_INI", DataFormat = DataFormat.TwosComplement)]
		public int HPCmd_INI
		{
			get
			{
				return this._HPCmd_INI;
			}
			set
			{
				this._HPCmd_INI = value;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x000A6F90 File Offset: 0x000A5190
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x000A6F98 File Offset: 0x000A5198
		[ProtoMember(22, IsRequired = true, Name = "DFCmd_INI", DataFormat = DataFormat.TwosComplement)]
		public int DFCmd_INI
		{
			get
			{
				return this._DFCmd_INI;
			}
			set
			{
				this._DFCmd_INI = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x000A6FA4 File Offset: 0x000A51A4
		// (set) Token: 0x0600245D RID: 9309 RVA: 0x000A6FAC File Offset: 0x000A51AC
		[ProtoMember(23, IsRequired = true, Name = "ATCmd_INI", DataFormat = DataFormat.TwosComplement)]
		public int ATCmd_INI
		{
			get
			{
				return this._ATCmd_INI;
			}
			set
			{
				this._ATCmd_INI = value;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600245E RID: 9310 RVA: 0x000A6FB8 File Offset: 0x000A51B8
		// (set) Token: 0x0600245F RID: 9311 RVA: 0x000A6FC0 File Offset: 0x000A51C0
		[ProtoMember(24, IsRequired = true, Name = "MagicDFCmd_INI", DataFormat = DataFormat.TwosComplement)]
		public int MagicDFCmd_INI
		{
			get
			{
				return this._MagicDFCmd_INI;
			}
			set
			{
				this._MagicDFCmd_INI = value;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002460 RID: 9312 RVA: 0x000A6FCC File Offset: 0x000A51CC
		// (set) Token: 0x06002461 RID: 9313 RVA: 0x000A6FD4 File Offset: 0x000A51D4
		[ProtoMember(25, IsRequired = true, Name = "CmdRating", DataFormat = DataFormat.Default)]
		public string CmdRating
		{
			get
			{
				return this._CmdRating;
			}
			set
			{
				this._CmdRating = value;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x000A6FE0 File Offset: 0x000A51E0
		[ProtoMember(26, Name = "HPStar", DataFormat = DataFormat.TwosComplement)]
		public List<int> HPStar
		{
			get
			{
				return this._HPStar;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000A6FE8 File Offset: 0x000A51E8
		[ProtoMember(27, Name = "ATStar", DataFormat = DataFormat.TwosComplement)]
		public List<int> ATStar
		{
			get
			{
				return this._ATStar;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000A6FF0 File Offset: 0x000A51F0
		[ProtoMember(28, Name = "MagicStar", DataFormat = DataFormat.TwosComplement)]
		public List<int> MagicStar
		{
			get
			{
				return this._MagicStar;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x000A6FF8 File Offset: 0x000A51F8
		[ProtoMember(29, Name = "DFStar", DataFormat = DataFormat.TwosComplement)]
		public List<int> DFStar
		{
			get
			{
				return this._DFStar;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x000A7000 File Offset: 0x000A5200
		[ProtoMember(30, Name = "MagicDFStar", DataFormat = DataFormat.TwosComplement)]
		public List<int> MagicDFStar
		{
			get
			{
				return this._MagicDFStar;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x000A7008 File Offset: 0x000A5208
		[ProtoMember(31, Name = "DEXStar", DataFormat = DataFormat.TwosComplement)]
		public List<int> DEXStar
		{
			get
			{
				return this._DEXStar;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x000A7010 File Offset: 0x000A5210
		// (set) Token: 0x06002469 RID: 9321 RVA: 0x000A7018 File Offset: 0x000A5218
		[ProtoMember(32, IsRequired = true, Name = "JobConnection_ID", DataFormat = DataFormat.TwosComplement)]
		public int JobConnection_ID
		{
			get
			{
				return this._JobConnection_ID;
			}
			set
			{
				this._JobConnection_ID = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x000A7024 File Offset: 0x000A5224
		[ProtoMember(33, Name = "UseableJobConnections_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> UseableJobConnections_ID
		{
			get
			{
				return this._UseableJobConnections_ID;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x000A702C File Offset: 0x000A522C
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x000A7034 File Offset: 0x000A5234
		[ProtoMember(34, IsRequired = true, Name = "CharImage_ID", DataFormat = DataFormat.TwosComplement)]
		public int CharImage_ID
		{
			get
			{
				return this._CharImage_ID;
			}
			set
			{
				this._CharImage_ID = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x000A7040 File Offset: 0x000A5240
		// (set) Token: 0x0600246E RID: 9326 RVA: 0x000A7048 File Offset: 0x000A5248
		[ProtoMember(35, IsRequired = true, Name = "HeroInformation_ID", DataFormat = DataFormat.TwosComplement)]
		public int HeroInformation_ID
		{
			get
			{
				return this._HeroInformation_ID;
			}
			set
			{
				this._HeroInformation_ID = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x000A7054 File Offset: 0x000A5254
		[ProtoMember(36, Name = "TechCanLearnSoldiers_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> TechCanLearnSoldiers_ID
		{
			get
			{
				return this._TechCanLearnSoldiers_ID;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x000A705C File Offset: 0x000A525C
		[ProtoMember(37, Name = "Skins_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> Skins_ID
		{
			get
			{
				return this._Skins_ID;
			}
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x000A7064 File Offset: 0x000A5264
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x000A7074 File Offset: 0x000A5274
		public int GetRank(int heroStar)
		{
			int i;
			for (i = 0; i < this.StarToRank.Count; i++)
			{
				if (heroStar < this.StarToRank[i].Star)
				{
					break;
				}
			}
			if (i > 0)
			{
				return this.StarToRank[i - 1].Rank;
			}
			return this.Rank;
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x000A70DC File Offset: 0x000A52DC
		public ConfigDataCharImageInfo GetCharImageInfo(int heroStar)
		{
			int i;
			for (i = 0; i < this.StarToRank.Count; i++)
			{
				if (heroStar < this.StarToRank[i].Star)
				{
					break;
				}
			}
			if (i > 0)
			{
				return this.m_starToCharImageInfos[i - 1];
			}
			return this.m_charImageInfo;
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x000A713C File Offset: 0x000A533C
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

		// Token: 0x06002475 RID: 9333 RVA: 0x000A7208 File Offset: 0x000A5408
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001607 RID: 5639
		private int _ID;

		// Token: 0x04001608 RID: 5640
		private string _Name;

		// Token: 0x04001609 RID: 5641
		private string _NameStrKey;

		// Token: 0x0400160A RID: 5642
		private string _Desc;

		// Token: 0x0400160B RID: 5643
		private string _DescStrKey;

		// Token: 0x0400160C RID: 5644
		private string _Name_Eng;

		// Token: 0x0400160D RID: 5645
		private string _JobWord;

		// Token: 0x0400160E RID: 5646
		private string _JobWordKey;

		// Token: 0x0400160F RID: 5647
		private bool _Useable;

		// Token: 0x04001610 RID: 5648
		private int _Sex;

		// Token: 0x04001611 RID: 5649
		private int _Star;

		// Token: 0x04001612 RID: 5650
		private int _Rank;

		// Token: 0x04001613 RID: 5651
		private readonly List<HeroInfoStarToRank> _StarToRank = new List<HeroInfoStarToRank>();

		// Token: 0x04001614 RID: 5652
		private int _FragmentItem_ID;

		// Token: 0x04001615 RID: 5653
		private int _ExchangedFragmentCount;

		// Token: 0x04001616 RID: 5654
		private int _Soldier_ID;

		// Token: 0x04001617 RID: 5655
		private readonly List<int> _SelectableSoldier_ID = new List<int>();

		// Token: 0x04001618 RID: 5656
		private readonly List<int> _Skills_ID = new List<int>();

		// Token: 0x04001619 RID: 5657
		private readonly List<int> _HiddenSkills_ID = new List<int>();

		// Token: 0x0400161A RID: 5658
		private int _HPCmd_INI;

		// Token: 0x0400161B RID: 5659
		private int _DFCmd_INI;

		// Token: 0x0400161C RID: 5660
		private int _ATCmd_INI;

		// Token: 0x0400161D RID: 5661
		private int _MagicDFCmd_INI;

		// Token: 0x0400161E RID: 5662
		private string _CmdRating;

		// Token: 0x0400161F RID: 5663
		private readonly List<int> _HPStar = new List<int>();

		// Token: 0x04001620 RID: 5664
		private readonly List<int> _ATStar = new List<int>();

		// Token: 0x04001621 RID: 5665
		private readonly List<int> _MagicStar = new List<int>();

		// Token: 0x04001622 RID: 5666
		private readonly List<int> _DFStar = new List<int>();

		// Token: 0x04001623 RID: 5667
		private readonly List<int> _MagicDFStar = new List<int>();

		// Token: 0x04001624 RID: 5668
		private readonly List<int> _DEXStar = new List<int>();

		// Token: 0x04001625 RID: 5669
		private int _JobConnection_ID;

		// Token: 0x04001626 RID: 5670
		private readonly List<int> _UseableJobConnections_ID = new List<int>();

		// Token: 0x04001627 RID: 5671
		private int _CharImage_ID;

		// Token: 0x04001628 RID: 5672
		private int _HeroInformation_ID;

		// Token: 0x04001629 RID: 5673
		private readonly List<int> _TechCanLearnSoldiers_ID = new List<int>();

		// Token: 0x0400162A RID: 5674
		private readonly List<int> _Skins_ID = new List<int>();

		// Token: 0x0400162B RID: 5675
		private IExtension extensionObject;

		// Token: 0x0400162C RID: 5676
		public ConfigDataSoldierInfo m_soldierInfo;

		// Token: 0x0400162D RID: 5677
		public ConfigDataSkillInfo[] m_skillInfos;

		// Token: 0x0400162E RID: 5678
		public ConfigDataSkillInfo[] m_hiddenSkillInfos;

		// Token: 0x0400162F RID: 5679
		public ConfigDataJobConnectionInfo m_jobConnectionInfo;

		// Token: 0x04001630 RID: 5680
		public ConfigDataJobConnectionInfo[] m_useableJobConnectionInfos;

		// Token: 0x04001631 RID: 5681
		public ConfigDataItemInfo m_fragmentItemInfo;

		// Token: 0x04001632 RID: 5682
		public ConfigDataCharImageInfo m_charImageInfo;

		// Token: 0x04001633 RID: 5683
		public ConfigDataCharImageInfo[] m_starToCharImageInfos;

		// Token: 0x04001634 RID: 5684
		public ConfigDataHeroInformationInfo m_informationInfo;

		// Token: 0x04001635 RID: 5685
		public List<int> m_heroTagIds;

		// Token: 0x04001636 RID: 5686
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001637 RID: 5687
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001638 RID: 5688
		private LuaFunction m_ctor_hotfix;
	}
}
