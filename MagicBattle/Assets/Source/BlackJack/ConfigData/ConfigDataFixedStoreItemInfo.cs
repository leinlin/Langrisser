using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000231 RID: 561
	[ProtoContract(Name = "ConfigDataFixedStoreItemInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataFixedStoreItemInfo : IExtensible
	{
		// Token: 0x06002237 RID: 8759 RVA: 0x000A3328 File Offset: 0x000A1528
		public ConfigDataFixedStoreItemInfo()
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

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x000A339C File Offset: 0x000A159C
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x000A33A4 File Offset: 0x000A15A4
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

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x000A33B0 File Offset: 0x000A15B0
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x000A33B8 File Offset: 0x000A15B8
		[ProtoMember(3, IsRequired = true, Name = "StoreID", DataFormat = DataFormat.TwosComplement)]
		public StoreId StoreID
		{
			get
			{
				return this._StoreID;
			}
			set
			{
				this._StoreID = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x000A33C4 File Offset: 0x000A15C4
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x000A33CC File Offset: 0x000A15CC
		[ProtoMember(4, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x000A33D8 File Offset: 0x000A15D8
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x000A33E0 File Offset: 0x000A15E0
		[ProtoMember(5, IsRequired = true, Name = "ItemType", DataFormat = DataFormat.TwosComplement)]
		public GoodsType ItemType
		{
			get
			{
				return this._ItemType;
			}
			set
			{
				this._ItemType = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x000A33EC File Offset: 0x000A15EC
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x000A33F4 File Offset: 0x000A15F4
		[ProtoMember(6, IsRequired = true, Name = "ItemId", DataFormat = DataFormat.TwosComplement)]
		public int ItemId
		{
			get
			{
				return this._ItemId;
			}
			set
			{
				this._ItemId = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x000A3400 File Offset: 0x000A1600
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x000A3408 File Offset: 0x000A1608
		[ProtoMember(7, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
		public int Nums
		{
			get
			{
				return this._Nums;
			}
			set
			{
				this._Nums = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x000A3414 File Offset: 0x000A1614
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x000A341C File Offset: 0x000A161C
		[ProtoMember(8, IsRequired = true, Name = "ShowStartTime", DataFormat = DataFormat.Default)]
		public string ShowStartTime
		{
			get
			{
				return this._ShowStartTime;
			}
			set
			{
				this._ShowStartTime = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x000A3428 File Offset: 0x000A1628
		// (set) Token: 0x06002247 RID: 8775 RVA: 0x000A3430 File Offset: 0x000A1630
		[ProtoMember(9, IsRequired = true, Name = "ShowEndTime", DataFormat = DataFormat.Default)]
		public string ShowEndTime
		{
			get
			{
				return this._ShowEndTime;
			}
			set
			{
				this._ShowEndTime = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x000A343C File Offset: 0x000A163C
		// (set) Token: 0x06002249 RID: 8777 RVA: 0x000A3444 File Offset: 0x000A1644
		[ProtoMember(10, IsRequired = true, Name = "BuyLimitType", DataFormat = DataFormat.TwosComplement)]
		public BuyRuleType BuyLimitType
		{
			get
			{
				return this._BuyLimitType;
			}
			set
			{
				this._BuyLimitType = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x000A3450 File Offset: 0x000A1650
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x000A3458 File Offset: 0x000A1658
		[ProtoMember(11, IsRequired = true, Name = "Param", DataFormat = DataFormat.TwosComplement)]
		public int Param
		{
			get
			{
				return this._Param;
			}
			set
			{
				this._Param = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x000A3464 File Offset: 0x000A1664
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x000A346C File Offset: 0x000A166C
		[ProtoMember(12, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				this._Count = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x000A3478 File Offset: 0x000A1678
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x000A3480 File Offset: 0x000A1680
		[ProtoMember(13, IsRequired = true, Name = "CurrencyType", DataFormat = DataFormat.TwosComplement)]
		public GoodsType CurrencyType
		{
			get
			{
				return this._CurrencyType;
			}
			set
			{
				this._CurrencyType = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x000A348C File Offset: 0x000A168C
		[ProtoMember(14, Name = "FirstReward", DataFormat = DataFormat.Default)]
		public List<Goods> FirstReward
		{
			get
			{
				return this._FirstReward;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x000A3494 File Offset: 0x000A1694
		// (set) Token: 0x06002252 RID: 8786 RVA: 0x000A349C File Offset: 0x000A169C
		[ProtoMember(15, IsRequired = true, Name = "FirstPrice", DataFormat = DataFormat.TwosComplement)]
		public int FirstPrice
		{
			get
			{
				return this._FirstPrice;
			}
			set
			{
				this._FirstPrice = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x000A34A8 File Offset: 0x000A16A8
		// (set) Token: 0x06002254 RID: 8788 RVA: 0x000A34B0 File Offset: 0x000A16B0
		[ProtoMember(16, IsRequired = true, Name = "NormalPrice", DataFormat = DataFormat.TwosComplement)]
		public int NormalPrice
		{
			get
			{
				return this._NormalPrice;
			}
			set
			{
				this._NormalPrice = value;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x000A34BC File Offset: 0x000A16BC
		// (set) Token: 0x06002256 RID: 8790 RVA: 0x000A34C4 File Offset: 0x000A16C4
		[ProtoMember(17, IsRequired = true, Name = "DiscountPrice", DataFormat = DataFormat.TwosComplement)]
		public int DiscountPrice
		{
			get
			{
				return this._DiscountPrice;
			}
			set
			{
				this._DiscountPrice = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x000A34D0 File Offset: 0x000A16D0
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x000A34D8 File Offset: 0x000A16D8
		[ProtoMember(18, IsRequired = true, Name = "DiscountStartTime", DataFormat = DataFormat.Default)]
		public string DiscountStartTime
		{
			get
			{
				return this._DiscountStartTime;
			}
			set
			{
				this._DiscountStartTime = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x000A34E4 File Offset: 0x000A16E4
		// (set) Token: 0x0600225A RID: 8794 RVA: 0x000A34EC File Offset: 0x000A16EC
		[ProtoMember(19, IsRequired = true, Name = "DiscountEndTime", DataFormat = DataFormat.Default)]
		public string DiscountEndTime
		{
			get
			{
				return this._DiscountEndTime;
			}
			set
			{
				this._DiscountEndTime = value;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x000A34F8 File Offset: 0x000A16F8
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x000A3500 File Offset: 0x000A1700
		[ProtoMember(20, IsRequired = true, Name = "Lable", DataFormat = DataFormat.TwosComplement)]
		public LabelType Lable
		{
			get
			{
				return this._Lable;
			}
			set
			{
				this._Lable = value;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x000A350C File Offset: 0x000A170C
		// (set) Token: 0x0600225E RID: 8798 RVA: 0x000A3514 File Offset: 0x000A1714
		[ProtoMember(21, IsRequired = true, Name = "IsFirstOnSale", DataFormat = DataFormat.Default)]
		public bool IsFirstOnSale
		{
			get
			{
				return this._IsFirstOnSale;
			}
			set
			{
				this._IsFirstOnSale = value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x000A3520 File Offset: 0x000A1720
		// (set) Token: 0x06002260 RID: 8800 RVA: 0x000A3528 File Offset: 0x000A1728
		[ProtoMember(22, IsRequired = true, Name = "UISort", DataFormat = DataFormat.TwosComplement)]
		public int UISort
		{
			get
			{
				return this._UISort;
			}
			set
			{
				this._UISort = value;
			}
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x000A3534 File Offset: 0x000A1734
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x000A3544 File Offset: 0x000A1744
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

		// Token: 0x06002263 RID: 8803 RVA: 0x000A3610 File Offset: 0x000A1810
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataFixedStoreItemInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040014B9 RID: 5305
		private int _ID;

		// Token: 0x040014BA RID: 5306
		private StoreId _StoreID;

		// Token: 0x040014BB RID: 5307
		private string _Name;

		// Token: 0x040014BC RID: 5308
		private GoodsType _ItemType;

		// Token: 0x040014BD RID: 5309
		private int _ItemId;

		// Token: 0x040014BE RID: 5310
		private int _Nums;

		// Token: 0x040014BF RID: 5311
		private string _ShowStartTime;

		// Token: 0x040014C0 RID: 5312
		private string _ShowEndTime;

		// Token: 0x040014C1 RID: 5313
		private BuyRuleType _BuyLimitType;

		// Token: 0x040014C2 RID: 5314
		private int _Param;

		// Token: 0x040014C3 RID: 5315
		private int _Count;

		// Token: 0x040014C4 RID: 5316
		private GoodsType _CurrencyType;

		// Token: 0x040014C5 RID: 5317
		private readonly List<Goods> _FirstReward = new List<Goods>();

		// Token: 0x040014C6 RID: 5318
		private int _FirstPrice;

		// Token: 0x040014C7 RID: 5319
		private int _NormalPrice;

		// Token: 0x040014C8 RID: 5320
		private int _DiscountPrice;

		// Token: 0x040014C9 RID: 5321
		private string _DiscountStartTime;

		// Token: 0x040014CA RID: 5322
		private string _DiscountEndTime;

		// Token: 0x040014CB RID: 5323
		private LabelType _Lable;

		// Token: 0x040014CC RID: 5324
		private bool _IsFirstOnSale;

		// Token: 0x040014CD RID: 5325
		private int _UISort;

		// Token: 0x040014CE RID: 5326
		private IExtension extensionObject;

		// Token: 0x040014CF RID: 5327
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040014D0 RID: 5328
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040014D1 RID: 5329
		private LuaFunction m_ctor_hotfix;
	}
}
