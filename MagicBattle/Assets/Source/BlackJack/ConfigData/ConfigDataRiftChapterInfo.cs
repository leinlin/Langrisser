using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000282 RID: 642
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataRiftChapterInfo")]
	[Serializable]
	public class ConfigDataRiftChapterInfo : IExtensible
	{
		// Token: 0x0600292A RID: 10538 RVA: 0x000AF94C File Offset: 0x000ADB4C
		public ConfigDataRiftChapterInfo()
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

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x000AF9EC File Offset: 0x000ADBEC
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x000AF9F4 File Offset: 0x000ADBF4
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

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x000AFA00 File Offset: 0x000ADC00
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x000AFA08 File Offset: 0x000ADC08
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

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x0600292F RID: 10543 RVA: 0x000AFA14 File Offset: 0x000ADC14
		// (set) Token: 0x06002930 RID: 10544 RVA: 0x000AFA1C File Offset: 0x000ADC1C
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

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002931 RID: 10545 RVA: 0x000AFA28 File Offset: 0x000ADC28
		// (set) Token: 0x06002932 RID: 10546 RVA: 0x000AFA30 File Offset: 0x000ADC30
		[ProtoMember(5, IsRequired = true, Name = "TitleName", DataFormat = DataFormat.Default)]
		public string TitleName
		{
			get
			{
				return this._TitleName;
			}
			set
			{
				this._TitleName = value;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002933 RID: 10547 RVA: 0x000AFA3C File Offset: 0x000ADC3C
		// (set) Token: 0x06002934 RID: 10548 RVA: 0x000AFA44 File Offset: 0x000ADC44
		[ProtoMember(6, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002935 RID: 10549 RVA: 0x000AFA50 File Offset: 0x000ADC50
		// (set) Token: 0x06002936 RID: 10550 RVA: 0x000AFA58 File Offset: 0x000ADC58
		[ProtoMember(7, IsRequired = true, Name = "DescStrKey", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x000AFA64 File Offset: 0x000ADC64
		// (set) Token: 0x06002938 RID: 10552 RVA: 0x000AFA6C File Offset: 0x000ADC6C
		[ProtoMember(8, IsRequired = true, Name = "Place", DataFormat = DataFormat.Default)]
		public string Place
		{
			get
			{
				return this._Place;
			}
			set
			{
				this._Place = value;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x000AFA78 File Offset: 0x000ADC78
		// (set) Token: 0x0600293A RID: 10554 RVA: 0x000AFA80 File Offset: 0x000ADC80
		[ProtoMember(9, IsRequired = true, Name = "PlaceStrKey", DataFormat = DataFormat.Default)]
		public string PlaceStrKey
		{
			get
			{
				return this._PlaceStrKey;
			}
			set
			{
				this._PlaceStrKey = value;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x000AFA8C File Offset: 0x000ADC8C
		[ProtoMember(10, Name = "UnlockConditions", DataFormat = DataFormat.Default)]
		public List<RiftChapterInfoUnlockConditions> UnlockConditions
		{
			get
			{
				return this._UnlockConditions;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x000AFA94 File Offset: 0x000ADC94
		// (set) Token: 0x0600293D RID: 10557 RVA: 0x000AFA9C File Offset: 0x000ADC9C
		[ProtoMember(11, IsRequired = true, Name = "Hard", DataFormat = DataFormat.TwosComplement)]
		public int Hard
		{
			get
			{
				return this._Hard;
			}
			set
			{
				this._Hard = value;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x000AFAA8 File Offset: 0x000ADCA8
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x000AFAB0 File Offset: 0x000ADCB0
		[ProtoMember(12, IsRequired = true, Name = "HardChapter", DataFormat = DataFormat.TwosComplement)]
		public int HardChapter
		{
			get
			{
				return this._HardChapter;
			}
			set
			{
				this._HardChapter = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000AFABC File Offset: 0x000ADCBC
		[ProtoMember(13, Name = "RiftLevels_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> RiftLevels_ID
		{
			get
			{
				return this._RiftLevels_ID;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x000AFAC4 File Offset: 0x000ADCC4
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x000AFACC File Offset: 0x000ADCCC
		[ProtoMember(14, IsRequired = true, Name = "Reward1Star", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x000AFAD8 File Offset: 0x000ADCD8
		[ProtoMember(15, Name = "Reward1", DataFormat = DataFormat.Default)]
		public List<Goods> Reward1
		{
			get
			{
				return this._Reward1;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x000AFAE0 File Offset: 0x000ADCE0
		// (set) Token: 0x06002945 RID: 10565 RVA: 0x000AFAE8 File Offset: 0x000ADCE8
		[ProtoMember(16, IsRequired = true, Name = "Reward2Star", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x000AFAF4 File Offset: 0x000ADCF4
		[ProtoMember(17, Name = "Reward2", DataFormat = DataFormat.Default)]
		public List<Goods> Reward2
		{
			get
			{
				return this._Reward2;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x000AFAFC File Offset: 0x000ADCFC
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x000AFB04 File Offset: 0x000ADD04
		[ProtoMember(18, IsRequired = true, Name = "Reward3Star", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002949 RID: 10569 RVA: 0x000AFB10 File Offset: 0x000ADD10
		[ProtoMember(19, Name = "Reward3", DataFormat = DataFormat.Default)]
		public List<Goods> Reward3
		{
			get
			{
				return this._Reward3;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x000AFB18 File Offset: 0x000ADD18
		// (set) Token: 0x0600294B RID: 10571 RVA: 0x000AFB20 File Offset: 0x000ADD20
		[ProtoMember(20, IsRequired = true, Name = "Image", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x000AFB2C File Offset: 0x000ADD2C
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x000AFB34 File Offset: 0x000ADD34
		[ProtoMember(21, IsRequired = true, Name = "ChapterBGPrefabName", DataFormat = DataFormat.Default)]
		public string ChapterBGPrefabName
		{
			get
			{
				return this._ChapterBGPrefabName;
			}
			set
			{
				this._ChapterBGPrefabName = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x000AFB40 File Offset: 0x000ADD40
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x000AFB48 File Offset: 0x000ADD48
		[ProtoMember(22, IsRequired = true, Name = "IsOpened", DataFormat = DataFormat.Default)]
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

		// Token: 0x06002950 RID: 10576 RVA: 0x000AFB54 File Offset: 0x000ADD54
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x000AFB64 File Offset: 0x000ADD64
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

		// Token: 0x06002952 RID: 10578 RVA: 0x000AFC30 File Offset: 0x000ADE30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRiftChapterInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001954 RID: 6484
		private int _ID;

		// Token: 0x04001955 RID: 6485
		private string _Name;

		// Token: 0x04001956 RID: 6486
		private string _NameStrKey;

		// Token: 0x04001957 RID: 6487
		private string _TitleName;

		// Token: 0x04001958 RID: 6488
		private string _Desc;

		// Token: 0x04001959 RID: 6489
		private string _DescStrKey;

		// Token: 0x0400195A RID: 6490
		private string _Place;

		// Token: 0x0400195B RID: 6491
		private string _PlaceStrKey;

		// Token: 0x0400195C RID: 6492
		private readonly List<RiftChapterInfoUnlockConditions> _UnlockConditions = new List<RiftChapterInfoUnlockConditions>();

		// Token: 0x0400195D RID: 6493
		private int _Hard;

		// Token: 0x0400195E RID: 6494
		private int _HardChapter;

		// Token: 0x0400195F RID: 6495
		private readonly List<int> _RiftLevels_ID = new List<int>();

		// Token: 0x04001960 RID: 6496
		private int _Reward1Star;

		// Token: 0x04001961 RID: 6497
		private readonly List<Goods> _Reward1 = new List<Goods>();

		// Token: 0x04001962 RID: 6498
		private int _Reward2Star;

		// Token: 0x04001963 RID: 6499
		private readonly List<Goods> _Reward2 = new List<Goods>();

		// Token: 0x04001964 RID: 6500
		private int _Reward3Star;

		// Token: 0x04001965 RID: 6501
		private readonly List<Goods> _Reward3 = new List<Goods>();

		// Token: 0x04001966 RID: 6502
		private string _Image;

		// Token: 0x04001967 RID: 6503
		private string _ChapterBGPrefabName;

		// Token: 0x04001968 RID: 6504
		private bool _IsOpened;

		// Token: 0x04001969 RID: 6505
		private IExtension extensionObject;

		// Token: 0x0400196A RID: 6506
		public ConfigDataRiftChapterInfo m_hardChapterInfo;

		// Token: 0x0400196B RID: 6507
		public ConfigDataRiftLevelInfo[] m_levelInfos;

		// Token: 0x0400196C RID: 6508
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400196D RID: 6509
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400196E RID: 6510
		private LuaFunction m_ctor_hotfix;
	}
}
