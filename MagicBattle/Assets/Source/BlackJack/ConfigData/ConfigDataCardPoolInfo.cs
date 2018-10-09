using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200021C RID: 540
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataCardPoolInfo")]
	[Serializable]
	public class ConfigDataCardPoolInfo : IExtensible
	{
		// Token: 0x06001FB0 RID: 8112 RVA: 0x0009F7C0 File Offset: 0x0009D9C0
		public ConfigDataCardPoolInfo()
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

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0009F834 File Offset: 0x0009DA34
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x0009F83C File Offset: 0x0009DA3C
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

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0009F848 File Offset: 0x0009DA48
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x0009F850 File Offset: 0x0009DA50
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

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0009F85C File Offset: 0x0009DA5C
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x0009F864 File Offset: 0x0009DA64
		[ProtoMember(4, IsRequired = true, Name = "PoolType", DataFormat = DataFormat.TwosComplement)]
		public CardPoolType PoolType
		{
			get
			{
				return this._PoolType;
			}
			set
			{
				this._PoolType = value;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0009F870 File Offset: 0x0009DA70
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x0009F878 File Offset: 0x0009DA78
		[ProtoMember(5, IsRequired = true, Name = "SelectType", DataFormat = DataFormat.TwosComplement)]
		public CardSelectType SelectType
		{
			get
			{
				return this._SelectType;
			}
			set
			{
				this._SelectType = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0009F884 File Offset: 0x0009DA84
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0009F88C File Offset: 0x0009DA8C
		[ProtoMember(6, IsRequired = true, Name = "CrystalCost", DataFormat = DataFormat.TwosComplement)]
		public int CrystalCost
		{
			get
			{
				return this._CrystalCost;
			}
			set
			{
				this._CrystalCost = value;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x0009F898 File Offset: 0x0009DA98
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x0009F8A0 File Offset: 0x0009DAA0
		[ProtoMember(7, IsRequired = true, Name = "TenSelectDiscount", DataFormat = DataFormat.TwosComplement)]
		public int TenSelectDiscount
		{
			get
			{
				return this._TenSelectDiscount;
			}
			set
			{
				this._TenSelectDiscount = value;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x0009F8AC File Offset: 0x0009DAAC
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x0009F8B4 File Offset: 0x0009DAB4
		[ProtoMember(8, IsRequired = true, Name = "TenSelectCount", DataFormat = DataFormat.TwosComplement)]
		public int TenSelectCount
		{
			get
			{
				return this._TenSelectCount;
			}
			set
			{
				this._TenSelectCount = value;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0009F8C0 File Offset: 0x0009DAC0
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0009F8C8 File Offset: 0x0009DAC8
		[ProtoMember(9, IsRequired = true, Name = "TicketId", DataFormat = DataFormat.TwosComplement)]
		public int TicketId
		{
			get
			{
				return this._TicketId;
			}
			set
			{
				this._TicketId = value;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0009F8D4 File Offset: 0x0009DAD4
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x0009F8DC File Offset: 0x0009DADC
		[ProtoMember(10, IsRequired = true, Name = "CardPoolSelectMaxCount", DataFormat = DataFormat.TwosComplement)]
		public int CardPoolSelectMaxCount
		{
			get
			{
				return this._CardPoolSelectMaxCount;
			}
			set
			{
				this._CardPoolSelectMaxCount = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x0009F8E8 File Offset: 0x0009DAE8
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x0009F8F0 File Offset: 0x0009DAF0
		[ProtoMember(11, IsRequired = true, Name = "SortID", DataFormat = DataFormat.TwosComplement)]
		public int SortID
		{
			get
			{
				return this._SortID;
			}
			set
			{
				this._SortID = value;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0009F8FC File Offset: 0x0009DAFC
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x0009F904 File Offset: 0x0009DB04
		[ProtoMember(12, IsRequired = true, Name = "GuaranteedGroupID", DataFormat = DataFormat.TwosComplement)]
		public int GuaranteedGroupID
		{
			get
			{
				return this._GuaranteedGroupID;
			}
			set
			{
				this._GuaranteedGroupID = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x0009F910 File Offset: 0x0009DB10
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x0009F918 File Offset: 0x0009DB18
		[ProtoMember(13, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x0009F924 File Offset: 0x0009DB24
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x0009F92C File Offset: 0x0009DB2C
		[ProtoMember(14, IsRequired = true, Name = "AdsImage", DataFormat = DataFormat.Default)]
		public string AdsImage
		{
			get
			{
				return this._AdsImage;
			}
			set
			{
				this._AdsImage = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x0009F938 File Offset: 0x0009DB38
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x0009F940 File Offset: 0x0009DB40
		[ProtoMember(15, IsRequired = true, Name = "SelectProbabilityInfoID", DataFormat = DataFormat.TwosComplement)]
		public int SelectProbabilityInfoID
		{
			get
			{
				return this._SelectProbabilityInfoID;
			}
			set
			{
				this._SelectProbabilityInfoID = value;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0009F94C File Offset: 0x0009DB4C
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x0009F954 File Offset: 0x0009DB54
		[ProtoMember(16, IsRequired = true, Name = "SelectContentInfoID", DataFormat = DataFormat.TwosComplement)]
		public int SelectContentInfoID
		{
			get
			{
				return this._SelectContentInfoID;
			}
			set
			{
				this._SelectContentInfoID = value;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x0009F960 File Offset: 0x0009DB60
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x0009F968 File Offset: 0x0009DB68
		[ProtoMember(17, IsRequired = true, Name = "ToggleClickImage", DataFormat = DataFormat.Default)]
		public string ToggleClickImage
		{
			get
			{
				return this._ToggleClickImage;
			}
			set
			{
				this._ToggleClickImage = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0009F974 File Offset: 0x0009DB74
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0009F97C File Offset: 0x0009DB7C
		[ProtoMember(18, IsRequired = true, Name = "ToggleUnClickImage", DataFormat = DataFormat.Default)]
		public string ToggleUnClickImage
		{
			get
			{
				return this._ToggleUnClickImage;
			}
			set
			{
				this._ToggleUnClickImage = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x0009F988 File Offset: 0x0009DB88
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0009F990 File Offset: 0x0009DB90
		[ProtoMember(19, IsRequired = true, Name = "MissionCardPoolType", DataFormat = DataFormat.TwosComplement)]
		public MissionCardPoolType MissionCardPoolType
		{
			get
			{
				return this._MissionCardPoolType;
			}
			set
			{
				this._MissionCardPoolType = value;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0009F99C File Offset: 0x0009DB9C
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x0009F9A4 File Offset: 0x0009DBA4
		[ProtoMember(20, IsRequired = true, Name = "TenSelectGuaranteedMinCount", DataFormat = DataFormat.TwosComplement)]
		public int TenSelectGuaranteedMinCount
		{
			get
			{
				return this._TenSelectGuaranteedMinCount;
			}
			set
			{
				this._TenSelectGuaranteedMinCount = value;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0009F9B0 File Offset: 0x0009DBB0
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x0009F9B8 File Offset: 0x0009DBB8
		[ProtoMember(21, IsRequired = true, Name = "ReplaceHeroGroup", DataFormat = DataFormat.TwosComplement)]
		public int ReplaceHeroGroup
		{
			get
			{
				return this._ReplaceHeroGroup;
			}
			set
			{
				this._ReplaceHeroGroup = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x0009F9C4 File Offset: 0x0009DBC4
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x0009F9CC File Offset: 0x0009DBCC
		[ProtoMember(22, IsRequired = true, Name = "CardPoolDetailDesc", DataFormat = DataFormat.Default)]
		public string CardPoolDetailDesc
		{
			get
			{
				return this._CardPoolDetailDesc;
			}
			set
			{
				this._CardPoolDetailDesc = value;
			}
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x0009F9D8 File Offset: 0x0009DBD8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0009F9E8 File Offset: 0x0009DBE8
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

		// Token: 0x06001FDD RID: 8157 RVA: 0x0009FAB4 File Offset: 0x0009DCB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataCardPoolInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001320 RID: 4896
		private int _ID;

		// Token: 0x04001321 RID: 4897
		private string _Name;

		// Token: 0x04001322 RID: 4898
		private CardPoolType _PoolType;

		// Token: 0x04001323 RID: 4899
		private CardSelectType _SelectType;

		// Token: 0x04001324 RID: 4900
		private int _CrystalCost;

		// Token: 0x04001325 RID: 4901
		private int _TenSelectDiscount;

		// Token: 0x04001326 RID: 4902
		private int _TenSelectCount;

		// Token: 0x04001327 RID: 4903
		private int _TicketId;

		// Token: 0x04001328 RID: 4904
		private int _CardPoolSelectMaxCount;

		// Token: 0x04001329 RID: 4905
		private int _SortID;

		// Token: 0x0400132A RID: 4906
		private int _GuaranteedGroupID;

		// Token: 0x0400132B RID: 4907
		private string _Icon;

		// Token: 0x0400132C RID: 4908
		private string _AdsImage;

		// Token: 0x0400132D RID: 4909
		private int _SelectProbabilityInfoID;

		// Token: 0x0400132E RID: 4910
		private int _SelectContentInfoID;

		// Token: 0x0400132F RID: 4911
		private string _ToggleClickImage;

		// Token: 0x04001330 RID: 4912
		private string _ToggleUnClickImage;

		// Token: 0x04001331 RID: 4913
		private MissionCardPoolType _MissionCardPoolType;

		// Token: 0x04001332 RID: 4914
		private int _TenSelectGuaranteedMinCount;

		// Token: 0x04001333 RID: 4915
		private int _ReplaceHeroGroup;

		// Token: 0x04001334 RID: 4916
		private string _CardPoolDetailDesc;

		// Token: 0x04001335 RID: 4917
		private IExtension extensionObject;

		// Token: 0x04001336 RID: 4918
		public Dictionary<int, ConfigDataCardPoolGroupInfo> Groups = new Dictionary<int, ConfigDataCardPoolGroupInfo>();

		// Token: 0x04001337 RID: 4919
		public ConfigDataCardPoolGroupInfo m_replaceHeroGroup;

		// Token: 0x04001338 RID: 4920
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001339 RID: 4921
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400133A RID: 4922
		private LuaFunction m_ctor_hotfix;
	}
}
