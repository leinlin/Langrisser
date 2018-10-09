using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000228 RID: 552
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataDialogInfo")]
	[Serializable]
	public class ConfigDataDialogInfo : IExtensible
	{
		// Token: 0x060020E4 RID: 8420 RVA: 0x000A1680 File Offset: 0x0009F880
		public ConfigDataDialogInfo()
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

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x000A174C File Offset: 0x0009F94C
		// (set) Token: 0x060020E6 RID: 8422 RVA: 0x000A1754 File Offset: 0x0009F954
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

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x000A1760 File Offset: 0x0009F960
		// (set) Token: 0x060020E8 RID: 8424 RVA: 0x000A1768 File Offset: 0x0009F968
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

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x000A1774 File Offset: 0x0009F974
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x000A177C File Offset: 0x0009F97C
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

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x000A1788 File Offset: 0x0009F988
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x000A1790 File Offset: 0x0009F990
		[ProtoMember(5, IsRequired = true, Name = "NextDialog_ID", DataFormat = DataFormat.TwosComplement)]
		public int NextDialog_ID
		{
			get
			{
				return this._NextDialog_ID;
			}
			set
			{
				this._NextDialog_ID = value;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x000A179C File Offset: 0x0009F99C
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x000A17A4 File Offset: 0x0009F9A4
		[ProtoMember(6, IsRequired = true, Name = "FrameType", DataFormat = DataFormat.TwosComplement)]
		public int FrameType
		{
			get
			{
				return this._FrameType;
			}
			set
			{
				this._FrameType = value;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x000A17B0 File Offset: 0x0009F9B0
		// (set) Token: 0x060020F0 RID: 8432 RVA: 0x000A17B8 File Offset: 0x0009F9B8
		[ProtoMember(7, IsRequired = true, Name = "PlaceName", DataFormat = DataFormat.Default)]
		public string PlaceName
		{
			get
			{
				return this._PlaceName;
			}
			set
			{
				this._PlaceName = value;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060020F1 RID: 8433 RVA: 0x000A17C4 File Offset: 0x0009F9C4
		// (set) Token: 0x060020F2 RID: 8434 RVA: 0x000A17CC File Offset: 0x0009F9CC
		[ProtoMember(8, IsRequired = true, Name = "PlaceNameStrKey", DataFormat = DataFormat.Default)]
		public string PlaceNameStrKey
		{
			get
			{
				return this._PlaceNameStrKey;
			}
			set
			{
				this._PlaceNameStrKey = value;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060020F3 RID: 8435 RVA: 0x000A17D8 File Offset: 0x0009F9D8
		// (set) Token: 0x060020F4 RID: 8436 RVA: 0x000A17E0 File Offset: 0x0009F9E0
		[ProtoMember(9, IsRequired = true, Name = "CharName", DataFormat = DataFormat.Default)]
		public string CharName
		{
			get
			{
				return this._CharName;
			}
			set
			{
				this._CharName = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x000A17EC File Offset: 0x0009F9EC
		// (set) Token: 0x060020F6 RID: 8438 RVA: 0x000A17F4 File Offset: 0x0009F9F4
		[ProtoMember(10, IsRequired = true, Name = "CharNameStrKey", DataFormat = DataFormat.Default)]
		public string CharNameStrKey
		{
			get
			{
				return this._CharNameStrKey;
			}
			set
			{
				this._CharNameStrKey = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x000A1800 File Offset: 0x0009FA00
		// (set) Token: 0x060020F8 RID: 8440 RVA: 0x000A1808 File Offset: 0x0009FA08
		[ProtoMember(11, IsRequired = true, Name = "CharImage_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x000A1814 File Offset: 0x0009FA14
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x000A181C File Offset: 0x0009FA1C
		[ProtoMember(12, IsRequired = true, Name = "Position", DataFormat = DataFormat.TwosComplement)]
		public int Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				this._Position = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x000A1828 File Offset: 0x0009FA28
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x000A1830 File Offset: 0x0009FA30
		[ProtoMember(13, IsRequired = true, Name = "EnterType", DataFormat = DataFormat.TwosComplement)]
		public int EnterType
		{
			get
			{
				return this._EnterType;
			}
			set
			{
				this._EnterType = value;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x000A183C File Offset: 0x0009FA3C
		// (set) Token: 0x060020FE RID: 8446 RVA: 0x000A1844 File Offset: 0x0009FA44
		[ProtoMember(14, IsRequired = true, Name = "BGM", DataFormat = DataFormat.Default)]
		public string BGM
		{
			get
			{
				return this._BGM;
			}
			set
			{
				this._BGM = value;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x000A1850 File Offset: 0x0009FA50
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x000A1858 File Offset: 0x0009FA58
		[ProtoMember(15, IsRequired = true, Name = "LeaveType", DataFormat = DataFormat.TwosComplement)]
		public int LeaveType
		{
			get
			{
				return this._LeaveType;
			}
			set
			{
				this._LeaveType = value;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x000A1864 File Offset: 0x0009FA64
		// (set) Token: 0x06002102 RID: 8450 RVA: 0x000A186C File Offset: 0x0009FA6C
		[ProtoMember(16, IsRequired = true, Name = "TogetherLeave", DataFormat = DataFormat.Default)]
		public bool TogetherLeave
		{
			get
			{
				return this._TogetherLeave;
			}
			set
			{
				this._TogetherLeave = value;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x000A1878 File Offset: 0x0009FA78
		// (set) Token: 0x06002104 RID: 8452 RVA: 0x000A1880 File Offset: 0x0009FA80
		[ProtoMember(17, IsRequired = true, Name = "LeaveTime", DataFormat = DataFormat.TwosComplement)]
		public int LeaveTime
		{
			get
			{
				return this._LeaveTime;
			}
			set
			{
				this._LeaveTime = value;
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x000A188C File Offset: 0x0009FA8C
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x000A1894 File Offset: 0x0009FA94
		[ProtoMember(18, IsRequired = true, Name = "PreAnimation", DataFormat = DataFormat.Default)]
		public string PreAnimation
		{
			get
			{
				return this._PreAnimation;
			}
			set
			{
				this._PreAnimation = value;
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x000A18A0 File Offset: 0x0009FAA0
		// (set) Token: 0x06002108 RID: 8456 RVA: 0x000A18A8 File Offset: 0x0009FAA8
		[ProtoMember(19, IsRequired = true, Name = "PreFacialAnimation", DataFormat = DataFormat.Default)]
		public string PreFacialAnimation
		{
			get
			{
				return this._PreFacialAnimation;
			}
			set
			{
				this._PreFacialAnimation = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x000A18B4 File Offset: 0x0009FAB4
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x000A18BC File Offset: 0x0009FABC
		[ProtoMember(20, IsRequired = true, Name = "IdleAnimation", DataFormat = DataFormat.Default)]
		public string IdleAnimation
		{
			get
			{
				return this._IdleAnimation;
			}
			set
			{
				this._IdleAnimation = value;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x000A18C8 File Offset: 0x0009FAC8
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x000A18D0 File Offset: 0x0009FAD0
		[ProtoMember(21, IsRequired = true, Name = "IdleFacialAnimation", DataFormat = DataFormat.Default)]
		public string IdleFacialAnimation
		{
			get
			{
				return this._IdleFacialAnimation;
			}
			set
			{
				this._IdleFacialAnimation = value;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x000A18DC File Offset: 0x0009FADC
		// (set) Token: 0x0600210E RID: 8462 RVA: 0x000A18E4 File Offset: 0x0009FAE4
		[ProtoMember(22, IsRequired = true, Name = "Background", DataFormat = DataFormat.Default)]
		public string Background
		{
			get
			{
				return this._Background;
			}
			set
			{
				this._Background = value;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x000A18F0 File Offset: 0x0009FAF0
		// (set) Token: 0x06002110 RID: 8464 RVA: 0x000A18F8 File Offset: 0x0009FAF8
		[ProtoMember(23, IsRequired = true, Name = "BackgroundImage", DataFormat = DataFormat.Default)]
		public string BackgroundImage
		{
			get
			{
				return this._BackgroundImage;
			}
			set
			{
				this._BackgroundImage = value;
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x000A1904 File Offset: 0x0009FB04
		// (set) Token: 0x06002112 RID: 8466 RVA: 0x000A190C File Offset: 0x0009FB0C
		[ProtoMember(24, IsRequired = true, Name = "BackgroundX", DataFormat = DataFormat.TwosComplement)]
		public int BackgroundX
		{
			get
			{
				return this._BackgroundX;
			}
			set
			{
				this._BackgroundX = value;
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x000A1918 File Offset: 0x0009FB18
		// (set) Token: 0x06002114 RID: 8468 RVA: 0x000A1920 File Offset: 0x0009FB20
		[ProtoMember(25, IsRequired = true, Name = "Voice", DataFormat = DataFormat.Default)]
		public string Voice
		{
			get
			{
				return this._Voice;
			}
			set
			{
				this._Voice = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x000A192C File Offset: 0x0009FB2C
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x000A1934 File Offset: 0x0009FB34
		[ProtoMember(26, IsRequired = true, Name = "Words", DataFormat = DataFormat.Default)]
		public string Words
		{
			get
			{
				return this._Words;
			}
			set
			{
				this._Words = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x000A1940 File Offset: 0x0009FB40
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x000A1948 File Offset: 0x0009FB48
		[ProtoMember(27, IsRequired = true, Name = "WordsStrKey", DataFormat = DataFormat.Default)]
		public string WordsStrKey
		{
			get
			{
				return this._WordsStrKey;
			}
			set
			{
				this._WordsStrKey = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x000A1954 File Offset: 0x0009FB54
		[ProtoMember(28, Name = "BeforeEnterEffectGroup1", DataFormat = DataFormat.TwosComplement)]
		public List<int> BeforeEnterEffectGroup1
		{
			get
			{
				return this._BeforeEnterEffectGroup1;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x000A195C File Offset: 0x0009FB5C
		[ProtoMember(29, Name = "BeforeEnterEffectGroup2", DataFormat = DataFormat.TwosComplement)]
		public List<int> BeforeEnterEffectGroup2
		{
			get
			{
				return this._BeforeEnterEffectGroup2;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x000A1964 File Offset: 0x0009FB64
		[ProtoMember(30, Name = "BeforeEnterEffectGroup3", DataFormat = DataFormat.TwosComplement)]
		public List<int> BeforeEnterEffectGroup3
		{
			get
			{
				return this._BeforeEnterEffectGroup3;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x000A196C File Offset: 0x0009FB6C
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x000A1974 File Offset: 0x0009FB74
		[ProtoMember(31, IsRequired = true, Name = "BeforeEnterInsertEffect", DataFormat = DataFormat.TwosComplement)]
		public int BeforeEnterInsertEffect
		{
			get
			{
				return this._BeforeEnterInsertEffect;
			}
			set
			{
				this._BeforeEnterInsertEffect = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x000A1980 File Offset: 0x0009FB80
		[ProtoMember(32, Name = "BeforeTalkEffectGroup1", DataFormat = DataFormat.TwosComplement)]
		public List<int> BeforeTalkEffectGroup1
		{
			get
			{
				return this._BeforeTalkEffectGroup1;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x000A1988 File Offset: 0x0009FB88
		[ProtoMember(33, Name = "BeforeTalkEffectGroup2", DataFormat = DataFormat.TwosComplement)]
		public List<int> BeforeTalkEffectGroup2
		{
			get
			{
				return this._BeforeTalkEffectGroup2;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x000A1990 File Offset: 0x0009FB90
		[ProtoMember(34, Name = "BeforeTalkEffectGroup3", DataFormat = DataFormat.TwosComplement)]
		public List<int> BeforeTalkEffectGroup3
		{
			get
			{
				return this._BeforeTalkEffectGroup3;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x000A1998 File Offset: 0x0009FB98
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x000A19A0 File Offset: 0x0009FBA0
		[ProtoMember(35, IsRequired = true, Name = "BeforeTalkInsertEffect", DataFormat = DataFormat.TwosComplement)]
		public int BeforeTalkInsertEffect
		{
			get
			{
				return this._BeforeTalkInsertEffect;
			}
			set
			{
				this._BeforeTalkInsertEffect = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x000A19AC File Offset: 0x0009FBAC
		[ProtoMember(36, Name = "AfterTalkEffectGroup1", DataFormat = DataFormat.TwosComplement)]
		public List<int> AfterTalkEffectGroup1
		{
			get
			{
				return this._AfterTalkEffectGroup1;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002124 RID: 8484 RVA: 0x000A19B4 File Offset: 0x0009FBB4
		[ProtoMember(37, Name = "AfterTalkEffectGroup2", DataFormat = DataFormat.TwosComplement)]
		public List<int> AfterTalkEffectGroup2
		{
			get
			{
				return this._AfterTalkEffectGroup2;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x000A19BC File Offset: 0x0009FBBC
		[ProtoMember(38, Name = "AfterTalkEffectGroup3", DataFormat = DataFormat.TwosComplement)]
		public List<int> AfterTalkEffectGroup3
		{
			get
			{
				return this._AfterTalkEffectGroup3;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06002126 RID: 8486 RVA: 0x000A19C4 File Offset: 0x0009FBC4
		// (set) Token: 0x06002127 RID: 8487 RVA: 0x000A19CC File Offset: 0x0009FBCC
		[ProtoMember(39, IsRequired = true, Name = "AfterTalkInsertEffect", DataFormat = DataFormat.TwosComplement)]
		public int AfterTalkInsertEffect
		{
			get
			{
				return this._AfterTalkInsertEffect;
			}
			set
			{
				this._AfterTalkInsertEffect = value;
			}
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000A19D8 File Offset: 0x0009FBD8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x000A19E8 File Offset: 0x0009FBE8
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

		// Token: 0x0600212A RID: 8490 RVA: 0x000A1AB4 File Offset: 0x0009FCB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataDialogInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040013E4 RID: 5092
		private int _ID;

		// Token: 0x040013E5 RID: 5093
		private string _Name;

		// Token: 0x040013E6 RID: 5094
		private string _NameStrKey;

		// Token: 0x040013E7 RID: 5095
		private int _NextDialog_ID;

		// Token: 0x040013E8 RID: 5096
		private int _FrameType;

		// Token: 0x040013E9 RID: 5097
		private string _PlaceName;

		// Token: 0x040013EA RID: 5098
		private string _PlaceNameStrKey;

		// Token: 0x040013EB RID: 5099
		private string _CharName;

		// Token: 0x040013EC RID: 5100
		private string _CharNameStrKey;

		// Token: 0x040013ED RID: 5101
		private int _CharImage_ID;

		// Token: 0x040013EE RID: 5102
		private int _Position;

		// Token: 0x040013EF RID: 5103
		private int _EnterType;

		// Token: 0x040013F0 RID: 5104
		private string _BGM;

		// Token: 0x040013F1 RID: 5105
		private int _LeaveType;

		// Token: 0x040013F2 RID: 5106
		private bool _TogetherLeave;

		// Token: 0x040013F3 RID: 5107
		private int _LeaveTime;

		// Token: 0x040013F4 RID: 5108
		private string _PreAnimation;

		// Token: 0x040013F5 RID: 5109
		private string _PreFacialAnimation;

		// Token: 0x040013F6 RID: 5110
		private string _IdleAnimation;

		// Token: 0x040013F7 RID: 5111
		private string _IdleFacialAnimation;

		// Token: 0x040013F8 RID: 5112
		private string _Background;

		// Token: 0x040013F9 RID: 5113
		private string _BackgroundImage;

		// Token: 0x040013FA RID: 5114
		private int _BackgroundX;

		// Token: 0x040013FB RID: 5115
		private string _Voice;

		// Token: 0x040013FC RID: 5116
		private string _Words;

		// Token: 0x040013FD RID: 5117
		private string _WordsStrKey;

		// Token: 0x040013FE RID: 5118
		private readonly List<int> _BeforeEnterEffectGroup1 = new List<int>();

		// Token: 0x040013FF RID: 5119
		private readonly List<int> _BeforeEnterEffectGroup2 = new List<int>();

		// Token: 0x04001400 RID: 5120
		private readonly List<int> _BeforeEnterEffectGroup3 = new List<int>();

		// Token: 0x04001401 RID: 5121
		private int _BeforeEnterInsertEffect;

		// Token: 0x04001402 RID: 5122
		private readonly List<int> _BeforeTalkEffectGroup1 = new List<int>();

		// Token: 0x04001403 RID: 5123
		private readonly List<int> _BeforeTalkEffectGroup2 = new List<int>();

		// Token: 0x04001404 RID: 5124
		private readonly List<int> _BeforeTalkEffectGroup3 = new List<int>();

		// Token: 0x04001405 RID: 5125
		private int _BeforeTalkInsertEffect;

		// Token: 0x04001406 RID: 5126
		private readonly List<int> _AfterTalkEffectGroup1 = new List<int>();

		// Token: 0x04001407 RID: 5127
		private readonly List<int> _AfterTalkEffectGroup2 = new List<int>();

		// Token: 0x04001408 RID: 5128
		private readonly List<int> _AfterTalkEffectGroup3 = new List<int>();

		// Token: 0x04001409 RID: 5129
		private int _AfterTalkInsertEffect;

		// Token: 0x0400140A RID: 5130
		private IExtension extensionObject;

		// Token: 0x0400140B RID: 5131
		public ConfigDataDialogInfo m_prevDialogInfo;

		// Token: 0x0400140C RID: 5132
		public ConfigDataDialogInfo m_nextDialogInfo;

		// Token: 0x0400140D RID: 5133
		public ConfigDataCharImageInfo m_charImageInfo;

		// Token: 0x0400140E RID: 5134
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400140F RID: 5135
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001410 RID: 5136
		private LuaFunction m_ctor_hotfix;
	}
}
