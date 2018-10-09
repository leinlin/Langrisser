using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000274 RID: 628
	[ProtoContract(Name = "ConfigDataRandomStoreItemInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataRandomStoreItemInfo : IExtensible
	{
		// Token: 0x06002832 RID: 10290 RVA: 0x000AD9D4 File Offset: 0x000ABBD4
		public ConfigDataRandomStoreItemInfo()
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

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x000ADA3C File Offset: 0x000ABC3C
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x000ADA44 File Offset: 0x000ABC44
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

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x000ADA50 File Offset: 0x000ABC50
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x000ADA58 File Offset: 0x000ABC58
		[ProtoMember(3, IsRequired = true, Name = "StoreID", DataFormat = DataFormat.TwosComplement)]
		public int StoreID
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

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x000ADA64 File Offset: 0x000ABC64
		// (set) Token: 0x06002838 RID: 10296 RVA: 0x000ADA6C File Offset: 0x000ABC6C
		[ProtoMember(4, IsRequired = true, Name = "LevelZoneID", DataFormat = DataFormat.TwosComplement)]
		public int LevelZoneID
		{
			get
			{
				return this._LevelZoneID;
			}
			set
			{
				this._LevelZoneID = value;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x000ADA78 File Offset: 0x000ABC78
		// (set) Token: 0x0600283A RID: 10298 RVA: 0x000ADA80 File Offset: 0x000ABC80
		[ProtoMember(5, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x000ADA8C File Offset: 0x000ABC8C
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x000ADA94 File Offset: 0x000ABC94
		[ProtoMember(6, IsRequired = true, Name = "ItemType", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x000ADAA0 File Offset: 0x000ABCA0
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x000ADAA8 File Offset: 0x000ABCA8
		[ProtoMember(7, IsRequired = true, Name = "ItemID", DataFormat = DataFormat.TwosComplement)]
		public int ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				this._ItemID = value;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x000ADAB4 File Offset: 0x000ABCB4
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x000ADABC File Offset: 0x000ABCBC
		[ProtoMember(8, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x000ADAC8 File Offset: 0x000ABCC8
		// (set) Token: 0x06002842 RID: 10306 RVA: 0x000ADAD0 File Offset: 0x000ABCD0
		[ProtoMember(9, IsRequired = true, Name = "CurrencyType", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x000ADADC File Offset: 0x000ABCDC
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x000ADAE4 File Offset: 0x000ABCE4
		[ProtoMember(10, IsRequired = true, Name = "Price", DataFormat = DataFormat.TwosComplement)]
		public int Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				this._Price = value;
			}
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000ADAF0 File Offset: 0x000ABCF0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x000ADB00 File Offset: 0x000ABD00
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

		// Token: 0x06002847 RID: 10311 RVA: 0x000ADBCC File Offset: 0x000ABDCC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRandomStoreItemInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040018AE RID: 6318
		private int _ID;

		// Token: 0x040018AF RID: 6319
		private int _StoreID;

		// Token: 0x040018B0 RID: 6320
		private int _LevelZoneID;

		// Token: 0x040018B1 RID: 6321
		private string _Name;

		// Token: 0x040018B2 RID: 6322
		private GoodsType _ItemType;

		// Token: 0x040018B3 RID: 6323
		private int _ItemID;

		// Token: 0x040018B4 RID: 6324
		private int _Count;

		// Token: 0x040018B5 RID: 6325
		private GoodsType _CurrencyType;

		// Token: 0x040018B6 RID: 6326
		private int _Price;

		// Token: 0x040018B7 RID: 6327
		private IExtension extensionObject;

		// Token: 0x040018B8 RID: 6328
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040018B9 RID: 6329
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040018BA RID: 6330
		private LuaFunction m_ctor_hotfix;
	}
}
