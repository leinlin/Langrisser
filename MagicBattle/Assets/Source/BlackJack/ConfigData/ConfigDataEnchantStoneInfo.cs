using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000229 RID: 553
	[ProtoContract(Name = "ConfigDataEnchantStoneInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataEnchantStoneInfo : IExtensible
	{
		// Token: 0x0600212B RID: 8491 RVA: 0x000A1B1C File Offset: 0x0009FD1C
		public ConfigDataEnchantStoneInfo()
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

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600212C RID: 8492 RVA: 0x000A1B90 File Offset: 0x0009FD90
		// (set) Token: 0x0600212D RID: 8493 RVA: 0x000A1B98 File Offset: 0x0009FD98
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

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x0600212E RID: 8494 RVA: 0x000A1BA4 File Offset: 0x0009FDA4
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x000A1BAC File Offset: 0x0009FDAC
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

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06002130 RID: 8496 RVA: 0x000A1BB8 File Offset: 0x0009FDB8
		// (set) Token: 0x06002131 RID: 8497 RVA: 0x000A1BC0 File Offset: 0x0009FDC0
		[ProtoMember(4, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x000A1BCC File Offset: 0x0009FDCC
		// (set) Token: 0x06002133 RID: 8499 RVA: 0x000A1BD4 File Offset: 0x0009FDD4
		[ProtoMember(5, IsRequired = true, Name = "Rank", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x000A1BE0 File Offset: 0x0009FDE0
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x000A1BE8 File Offset: 0x0009FDE8
		[ProtoMember(6, IsRequired = true, Name = "SellGold", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x000A1BFC File Offset: 0x0009FDFC
		[ProtoMember(7, IsRequired = true, Name = "DisplayType", DataFormat = DataFormat.TwosComplement)]
		public ItemDisplayType DisplayType
		{
			get
			{
				return this._DisplayType;
			}
			set
			{
				this._DisplayType = value;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x000A1C08 File Offset: 0x0009FE08
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x000A1C10 File Offset: 0x0009FE10
		[ProtoMember(8, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x000A1C1C File Offset: 0x0009FE1C
		[ProtoMember(9, Name = "GetPathList", DataFormat = DataFormat.Default)]
		public List<GetPathData> GetPathList
		{
			get
			{
				return this._GetPathList;
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000A1C24 File Offset: 0x0009FE24
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x000A1C2C File Offset: 0x0009FE2C
		[ProtoMember(10, IsRequired = true, Name = "GetPathDesc", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x000A1C38 File Offset: 0x0009FE38
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x000A1C40 File Offset: 0x0009FE40
		[ProtoMember(11, IsRequired = true, Name = "AlchemyGold", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x000A1C4C File Offset: 0x0009FE4C
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x000A1C54 File Offset: 0x0009FE54
		[ProtoMember(12, IsRequired = true, Name = "RandomDropRewardID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x000A1C60 File Offset: 0x0009FE60
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x000A1C68 File Offset: 0x0009FE68
		[ProtoMember(13, IsRequired = true, Name = "DisplayRewardCount", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000A1C74 File Offset: 0x0009FE74
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x000A1C7C File Offset: 0x0009FE7C
		[ProtoMember(15, IsRequired = true, Name = "Resonance_ID", DataFormat = DataFormat.TwosComplement)]
		public int Resonance_ID
		{
			get
			{
				return this._Resonance_ID;
			}
			set
			{
				this._Resonance_ID = value;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000A1C88 File Offset: 0x0009FE88
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x000A1C90 File Offset: 0x0009FE90
		[ProtoMember(17, IsRequired = true, Name = "CostGold", DataFormat = DataFormat.TwosComplement)]
		public int CostGold
		{
			get
			{
				return this._CostGold;
			}
			set
			{
				this._CostGold = value;
			}
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x000A1C9C File Offset: 0x0009FE9C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x000A1CAC File Offset: 0x0009FEAC
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

		// Token: 0x06002149 RID: 8521 RVA: 0x000A1D78 File Offset: 0x0009FF78
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataEnchantStoneInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001411 RID: 5137
		private int _ID;

		// Token: 0x04001412 RID: 5138
		private string _Name;

		// Token: 0x04001413 RID: 5139
		private string _Desc;

		// Token: 0x04001414 RID: 5140
		private int _Rank;

		// Token: 0x04001415 RID: 5141
		private int _SellGold;

		// Token: 0x04001416 RID: 5142
		private ItemDisplayType _DisplayType;

		// Token: 0x04001417 RID: 5143
		private string _Icon;

		// Token: 0x04001418 RID: 5144
		private readonly List<GetPathData> _GetPathList = new List<GetPathData>();

		// Token: 0x04001419 RID: 5145
		private string _GetPathDesc;

		// Token: 0x0400141A RID: 5146
		private int _AlchemyGold;

		// Token: 0x0400141B RID: 5147
		private int _RandomDropRewardID;

		// Token: 0x0400141C RID: 5148
		private int _DisplayRewardCount;

		// Token: 0x0400141D RID: 5149
		private int _Resonance_ID;

		// Token: 0x0400141E RID: 5150
		private int _CostGold;

		// Token: 0x0400141F RID: 5151
		private IExtension extensionObject;

		// Token: 0x04001420 RID: 5152
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001421 RID: 5153
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001422 RID: 5154
		private LuaFunction m_ctor_hotfix;
	}
}
