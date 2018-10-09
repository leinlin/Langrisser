using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000238 RID: 568
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataGiftStoreItemInfo")]
	[Serializable]
	public class ConfigDataGiftStoreItemInfo : IExtensible
	{
		// Token: 0x060022BE RID: 8894 RVA: 0x000A4318 File Offset: 0x000A2518
		public ConfigDataGiftStoreItemInfo()
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

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x000A438C File Offset: 0x000A258C
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x000A4394 File Offset: 0x000A2594
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

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x000A43A0 File Offset: 0x000A25A0
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x000A43A8 File Offset: 0x000A25A8
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

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x000A43B4 File Offset: 0x000A25B4
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x000A43BC File Offset: 0x000A25BC
		[ProtoMember(4, IsRequired = true, Name = "StoreId", DataFormat = DataFormat.TwosComplement)]
		public StoreId StoreId
		{
			get
			{
				return this._StoreId;
			}
			set
			{
				this._StoreId = value;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x000A43C8 File Offset: 0x000A25C8
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x000A43D0 File Offset: 0x000A25D0
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

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x000A43DC File Offset: 0x000A25DC
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x000A43E4 File Offset: 0x000A25E4
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

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x000A43F0 File Offset: 0x000A25F0
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x000A43F8 File Offset: 0x000A25F8
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

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x000A4404 File Offset: 0x000A2604
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x000A440C File Offset: 0x000A260C
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

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x000A4418 File Offset: 0x000A2618
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x000A4420 File Offset: 0x000A2620
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x000A442C File Offset: 0x000A262C
		// (set) Token: 0x060022D0 RID: 8912 RVA: 0x000A4434 File Offset: 0x000A2634
		[ProtoMember(10, IsRequired = true, Name = "IsOperateGoods", DataFormat = DataFormat.Default)]
		public bool IsOperateGoods
		{
			get
			{
				return this._IsOperateGoods;
			}
			set
			{
				this._IsOperateGoods = value;
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x000A4440 File Offset: 0x000A2640
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x000A4448 File Offset: 0x000A2648
		[ProtoMember(11, IsRequired = true, Name = "BuyLimitType", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x000A4454 File Offset: 0x000A2654
		// (set) Token: 0x060022D4 RID: 8916 RVA: 0x000A445C File Offset: 0x000A265C
		[ProtoMember(12, IsRequired = true, Name = "Param", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x000A4468 File Offset: 0x000A2668
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x000A4470 File Offset: 0x000A2670
		[ProtoMember(13, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x000A447C File Offset: 0x000A267C
		[ProtoMember(14, Name = "FirstReward", DataFormat = DataFormat.Default)]
		public List<Goods> FirstReward
		{
			get
			{
				return this._FirstReward;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x000A4484 File Offset: 0x000A2684
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x000A448C File Offset: 0x000A268C
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

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x000A4498 File Offset: 0x000A2698
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x000A44A0 File Offset: 0x000A26A0
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

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x000A44AC File Offset: 0x000A26AC
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x000A44B4 File Offset: 0x000A26B4
		[ProtoMember(17, IsRequired = true, Name = "Lable", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x000A44C0 File Offset: 0x000A26C0
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x000A44C8 File Offset: 0x000A26C8
		[ProtoMember(18, IsRequired = true, Name = "IsAppleSubscribe", DataFormat = DataFormat.Default)]
		public bool IsAppleSubscribe
		{
			get
			{
				return this._IsAppleSubscribe;
			}
			set
			{
				this._IsAppleSubscribe = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000A44D4 File Offset: 0x000A26D4
		// (set) Token: 0x060022E1 RID: 8929 RVA: 0x000A44DC File Offset: 0x000A26DC
		[ProtoMember(19, IsRequired = true, Name = "FirstBuyCompensation", DataFormat = DataFormat.TwosComplement)]
		public int FirstBuyCompensation
		{
			get
			{
				return this._FirstBuyCompensation;
			}
			set
			{
				this._FirstBuyCompensation = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x000A44E8 File Offset: 0x000A26E8
		// (set) Token: 0x060022E3 RID: 8931 RVA: 0x000A44F0 File Offset: 0x000A26F0
		[ProtoMember(20, IsRequired = true, Name = "NormalBuyCompensation", DataFormat = DataFormat.TwosComplement)]
		public int NormalBuyCompensation
		{
			get
			{
				return this._NormalBuyCompensation;
			}
			set
			{
				this._NormalBuyCompensation = value;
			}
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x000A44FC File Offset: 0x000A26FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x000A450C File Offset: 0x000A270C
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

		// Token: 0x060022E6 RID: 8934 RVA: 0x000A45D8 File Offset: 0x000A27D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGiftStoreItemInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400150A RID: 5386
		private int _ID;

		// Token: 0x0400150B RID: 5387
		private string _Name;

		// Token: 0x0400150C RID: 5388
		private StoreId _StoreId;

		// Token: 0x0400150D RID: 5389
		private GoodsType _ItemType;

		// Token: 0x0400150E RID: 5390
		private int _ItemId;

		// Token: 0x0400150F RID: 5391
		private int _Nums;

		// Token: 0x04001510 RID: 5392
		private string _ShowStartTime;

		// Token: 0x04001511 RID: 5393
		private string _ShowEndTime;

		// Token: 0x04001512 RID: 5394
		private bool _IsOperateGoods;

		// Token: 0x04001513 RID: 5395
		private BuyRuleType _BuyLimitType;

		// Token: 0x04001514 RID: 5396
		private int _Param;

		// Token: 0x04001515 RID: 5397
		private int _Count;

		// Token: 0x04001516 RID: 5398
		private readonly List<Goods> _FirstReward = new List<Goods>();

		// Token: 0x04001517 RID: 5399
		private int _FirstPrice;

		// Token: 0x04001518 RID: 5400
		private int _NormalPrice;

		// Token: 0x04001519 RID: 5401
		private LabelType _Lable;

		// Token: 0x0400151A RID: 5402
		private bool _IsAppleSubscribe;

		// Token: 0x0400151B RID: 5403
		private int _FirstBuyCompensation;

		// Token: 0x0400151C RID: 5404
		private int _NormalBuyCompensation;

		// Token: 0x0400151D RID: 5405
		private IExtension extensionObject;

		// Token: 0x0400151E RID: 5406
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400151F RID: 5407
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001520 RID: 5408
		private LuaFunction m_ctor_hotfix;
	}
}
