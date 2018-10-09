using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200026D RID: 621
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataRafflePoolInfo")]
	[Serializable]
	public class ConfigDataRafflePoolInfo : IExtensible
	{
		// Token: 0x060027E4 RID: 10212 RVA: 0x000ACC08 File Offset: 0x000AAE08
		public ConfigDataRafflePoolInfo()
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

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x000ACC84 File Offset: 0x000AAE84
		// (set) Token: 0x060027E6 RID: 10214 RVA: 0x000ACC8C File Offset: 0x000AAE8C
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

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x000ACC98 File Offset: 0x000AAE98
		// (set) Token: 0x060027E8 RID: 10216 RVA: 0x000ACCA0 File Offset: 0x000AAEA0
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

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x000ACCAC File Offset: 0x000AAEAC
		// (set) Token: 0x060027EA RID: 10218 RVA: 0x000ACCB4 File Offset: 0x000AAEB4
		[ProtoMember(4, IsRequired = true, Name = "GoodsType", DataFormat = DataFormat.TwosComplement)]
		public GoodsType GoodsType
		{
			get
			{
				return this._GoodsType;
			}
			set
			{
				this._GoodsType = value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x000ACCC0 File Offset: 0x000AAEC0
		// (set) Token: 0x060027EC RID: 10220 RVA: 0x000ACCC8 File Offset: 0x000AAEC8
		[ProtoMember(5, IsRequired = true, Name = "DrawItemID", DataFormat = DataFormat.TwosComplement)]
		public int DrawItemID
		{
			get
			{
				return this._DrawItemID;
			}
			set
			{
				this._DrawItemID = value;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x000ACCD4 File Offset: 0x000AAED4
		// (set) Token: 0x060027EE RID: 10222 RVA: 0x000ACCDC File Offset: 0x000AAEDC
		[ProtoMember(6, IsRequired = true, Name = "FreeDrawCount", DataFormat = DataFormat.TwosComplement)]
		public int FreeDrawCount
		{
			get
			{
				return this._FreeDrawCount;
			}
			set
			{
				this._FreeDrawCount = value;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x000ACCE8 File Offset: 0x000AAEE8
		[ProtoMember(7, Name = "Costs", DataFormat = DataFormat.Default)]
		public List<Int32Pair> Costs
		{
			get
			{
				return this._Costs;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x000ACCF0 File Offset: 0x000AAEF0
		[ProtoMember(8, Name = "RaffleItems", DataFormat = DataFormat.Default)]
		public List<RaffleItem> RaffleItems
		{
			get
			{
				return this._RaffleItems;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x000ACCF8 File Offset: 0x000AAEF8
		// (set) Token: 0x060027F2 RID: 10226 RVA: 0x000ACD00 File Offset: 0x000AAF00
		[ProtoMember(9, IsRequired = true, Name = "Description", DataFormat = DataFormat.Default)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				this._Description = value;
			}
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000ACD0C File Offset: 0x000AAF0C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x000ACD1C File Offset: 0x000AAF1C
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

		// Token: 0x060027F5 RID: 10229 RVA: 0x000ACDE8 File Offset: 0x000AAFE8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRafflePoolInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001877 RID: 6263
		private int _ID;

		// Token: 0x04001878 RID: 6264
		private string _Name;

		// Token: 0x04001879 RID: 6265
		private GoodsType _GoodsType;

		// Token: 0x0400187A RID: 6266
		private int _DrawItemID;

		// Token: 0x0400187B RID: 6267
		private int _FreeDrawCount;

		// Token: 0x0400187C RID: 6268
		private readonly List<Int32Pair> _Costs = new List<Int32Pair>();

		// Token: 0x0400187D RID: 6269
		private readonly List<RaffleItem> _RaffleItems = new List<RaffleItem>();

		// Token: 0x0400187E RID: 6270
		private string _Description;

		// Token: 0x0400187F RID: 6271
		private IExtension extensionObject;

		// Token: 0x04001880 RID: 6272
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001881 RID: 6273
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001882 RID: 6274
		private LuaFunction m_ctor_hotfix;
	}
}
