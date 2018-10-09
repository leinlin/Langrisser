using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200025B RID: 603
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataJobMaterialInfo")]
	[Serializable]
	public class ConfigDataJobMaterialInfo : IExtensible
	{
		// Token: 0x06002656 RID: 9814 RVA: 0x000AA070 File Offset: 0x000A8270
		public ConfigDataJobMaterialInfo()
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

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x000AA0EC File Offset: 0x000A82EC
		// (set) Token: 0x06002658 RID: 9816 RVA: 0x000AA0F4 File Offset: 0x000A82F4
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

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x000AA100 File Offset: 0x000A8300
		// (set) Token: 0x0600265A RID: 9818 RVA: 0x000AA108 File Offset: 0x000A8308
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

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600265B RID: 9819 RVA: 0x000AA114 File Offset: 0x000A8314
		// (set) Token: 0x0600265C RID: 9820 RVA: 0x000AA11C File Offset: 0x000A831C
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

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x000AA128 File Offset: 0x000A8328
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x000AA130 File Offset: 0x000A8330
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

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x000AA13C File Offset: 0x000A833C
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x000AA144 File Offset: 0x000A8344
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

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x000AA150 File Offset: 0x000A8350
		// (set) Token: 0x06002662 RID: 9826 RVA: 0x000AA158 File Offset: 0x000A8358
		[ProtoMember(7, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x000AA164 File Offset: 0x000A8364
		// (set) Token: 0x06002664 RID: 9828 RVA: 0x000AA16C File Offset: 0x000A836C
		[ProtoMember(8, IsRequired = true, Name = "SellGold", DataFormat = DataFormat.TwosComplement)]
		public int SellGold
		{
			get
			{
				return this._SellGold;
			}
			set
			{
				this._SellGold = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002665 RID: 9829 RVA: 0x000AA178 File Offset: 0x000A8378
		// (set) Token: 0x06002666 RID: 9830 RVA: 0x000AA180 File Offset: 0x000A8380
		[ProtoMember(9, IsRequired = true, Name = "ComposeGold", DataFormat = DataFormat.TwosComplement)]
		public int ComposeGold
		{
			get
			{
				return this._ComposeGold;
			}
			set
			{
				this._ComposeGold = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06002667 RID: 9831 RVA: 0x000AA18C File Offset: 0x000A838C
		[ProtoMember(10, Name = "ComposeMaterials", DataFormat = DataFormat.Default)]
		public List<Goods> ComposeMaterials
		{
			get
			{
				return this._ComposeMaterials;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x000AA194 File Offset: 0x000A8394
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x000AA19C File Offset: 0x000A839C
		[ProtoMember(11, IsRequired = true, Name = "Property1_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property1_ID
		{
			get
			{
				return this._Property1_ID;
			}
			set
			{
				this._Property1_ID = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x000AA1A8 File Offset: 0x000A83A8
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x000AA1B0 File Offset: 0x000A83B0
		[ProtoMember(12, IsRequired = true, Name = "Property1_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property1_Value
		{
			get
			{
				return this._Property1_Value;
			}
			set
			{
				this._Property1_Value = value;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x000AA1BC File Offset: 0x000A83BC
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x000AA1C4 File Offset: 0x000A83C4
		[ProtoMember(13, IsRequired = true, Name = "Property2_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property2_ID
		{
			get
			{
				return this._Property2_ID;
			}
			set
			{
				this._Property2_ID = value;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x000AA1D0 File Offset: 0x000A83D0
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x000AA1D8 File Offset: 0x000A83D8
		[ProtoMember(14, IsRequired = true, Name = "Property2_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property2_Value
		{
			get
			{
				return this._Property2_Value;
			}
			set
			{
				this._Property2_Value = value;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x000AA1E4 File Offset: 0x000A83E4
		// (set) Token: 0x06002671 RID: 9841 RVA: 0x000AA1EC File Offset: 0x000A83EC
		[ProtoMember(15, IsRequired = true, Name = "Property3_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property3_ID
		{
			get
			{
				return this._Property3_ID;
			}
			set
			{
				this._Property3_ID = value;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x000AA1F8 File Offset: 0x000A83F8
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x000AA200 File Offset: 0x000A8400
		[ProtoMember(16, IsRequired = true, Name = "Property3_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property3_Value
		{
			get
			{
				return this._Property3_Value;
			}
			set
			{
				this._Property3_Value = value;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x000AA20C File Offset: 0x000A840C
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x000AA214 File Offset: 0x000A8414
		[ProtoMember(17, IsRequired = true, Name = "Property4_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property4_ID
		{
			get
			{
				return this._Property4_ID;
			}
			set
			{
				this._Property4_ID = value;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x000AA220 File Offset: 0x000A8420
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x000AA228 File Offset: 0x000A8428
		[ProtoMember(18, IsRequired = true, Name = "Property4_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property4_Value
		{
			get
			{
				return this._Property4_Value;
			}
			set
			{
				this._Property4_Value = value;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x000AA234 File Offset: 0x000A8434
		// (set) Token: 0x06002679 RID: 9849 RVA: 0x000AA23C File Offset: 0x000A843C
		[ProtoMember(19, IsRequired = true, Name = "Property5_ID", DataFormat = DataFormat.TwosComplement)]
		public PropertyModifyType Property5_ID
		{
			get
			{
				return this._Property5_ID;
			}
			set
			{
				this._Property5_ID = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x000AA248 File Offset: 0x000A8448
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x000AA250 File Offset: 0x000A8450
		[ProtoMember(20, IsRequired = true, Name = "Property5_Value", DataFormat = DataFormat.TwosComplement)]
		public int Property5_Value
		{
			get
			{
				return this._Property5_Value;
			}
			set
			{
				this._Property5_Value = value;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x000AA25C File Offset: 0x000A845C
		// (set) Token: 0x0600267D RID: 9853 RVA: 0x000AA264 File Offset: 0x000A8464
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

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x000AA270 File Offset: 0x000A8470
		[ProtoMember(23, Name = "GetPathList", DataFormat = DataFormat.Default)]
		public List<GetPathData> GetPathList
		{
			get
			{
				return this._GetPathList;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x000AA278 File Offset: 0x000A8478
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x000AA280 File Offset: 0x000A8480
		[ProtoMember(24, IsRequired = true, Name = "GetPathDesc", DataFormat = DataFormat.Default)]
		public string GetPathDesc
		{
			get
			{
				return this._GetPathDesc;
			}
			set
			{
				this._GetPathDesc = value;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x000AA28C File Offset: 0x000A848C
		// (set) Token: 0x06002682 RID: 9858 RVA: 0x000AA294 File Offset: 0x000A8494
		[ProtoMember(25, IsRequired = true, Name = "AlchemyGold", DataFormat = DataFormat.TwosComplement)]
		public int AlchemyGold
		{
			get
			{
				return this._AlchemyGold;
			}
			set
			{
				this._AlchemyGold = value;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x000AA2A0 File Offset: 0x000A84A0
		// (set) Token: 0x06002684 RID: 9860 RVA: 0x000AA2A8 File Offset: 0x000A84A8
		[ProtoMember(26, IsRequired = true, Name = "RandomDropRewardID", DataFormat = DataFormat.TwosComplement)]
		public int RandomDropRewardID
		{
			get
			{
				return this._RandomDropRewardID;
			}
			set
			{
				this._RandomDropRewardID = value;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x000AA2B4 File Offset: 0x000A84B4
		// (set) Token: 0x06002686 RID: 9862 RVA: 0x000AA2BC File Offset: 0x000A84BC
		[ProtoMember(27, IsRequired = true, Name = "DisplayRewardCount", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06002687 RID: 9863 RVA: 0x000AA2C8 File Offset: 0x000A84C8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x000AA2D8 File Offset: 0x000A84D8
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

		// Token: 0x06002689 RID: 9865 RVA: 0x000AA3A4 File Offset: 0x000A85A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataJobMaterialInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001774 RID: 6004
		private int _ID;

		// Token: 0x04001775 RID: 6005
		private string _Name;

		// Token: 0x04001776 RID: 6006
		private string _NameStrKey;

		// Token: 0x04001777 RID: 6007
		private string _Desc;

		// Token: 0x04001778 RID: 6008
		private string _DescStrKey;

		// Token: 0x04001779 RID: 6009
		private int _Rank;

		// Token: 0x0400177A RID: 6010
		private int _SellGold;

		// Token: 0x0400177B RID: 6011
		private int _ComposeGold;

		// Token: 0x0400177C RID: 6012
		private readonly List<Goods> _ComposeMaterials = new List<Goods>();

		// Token: 0x0400177D RID: 6013
		private PropertyModifyType _Property1_ID;

		// Token: 0x0400177E RID: 6014
		private int _Property1_Value;

		// Token: 0x0400177F RID: 6015
		private PropertyModifyType _Property2_ID;

		// Token: 0x04001780 RID: 6016
		private int _Property2_Value;

		// Token: 0x04001781 RID: 6017
		private PropertyModifyType _Property3_ID;

		// Token: 0x04001782 RID: 6018
		private int _Property3_Value;

		// Token: 0x04001783 RID: 6019
		private PropertyModifyType _Property4_ID;

		// Token: 0x04001784 RID: 6020
		private int _Property4_Value;

		// Token: 0x04001785 RID: 6021
		private PropertyModifyType _Property5_ID;

		// Token: 0x04001786 RID: 6022
		private int _Property5_Value;

		// Token: 0x04001787 RID: 6023
		private string _Icon;

		// Token: 0x04001788 RID: 6024
		private readonly List<GetPathData> _GetPathList = new List<GetPathData>();

		// Token: 0x04001789 RID: 6025
		private string _GetPathDesc;

		// Token: 0x0400178A RID: 6026
		private int _AlchemyGold;

		// Token: 0x0400178B RID: 6027
		private int _RandomDropRewardID;

		// Token: 0x0400178C RID: 6028
		private int _DisplayRewardCount;

		// Token: 0x0400178D RID: 6029
		private IExtension extensionObject;

		// Token: 0x0400178E RID: 6030
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400178F RID: 6031
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001790 RID: 6032
		private LuaFunction m_ctor_hotfix;
	}
}
