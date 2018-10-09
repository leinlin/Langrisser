using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020001F8 RID: 504
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataActivityCardPoolGroupInfo")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataActivityCardPoolGroupInfo : IExtensible, ICardPoolItemWeight
	{
		// Token: 0x06001CB0 RID: 7344 RVA: 0x00099B80 File Offset: 0x00097D80
		public ConfigDataActivityCardPoolGroupInfo()
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

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x00099BF4 File Offset: 0x00097DF4
		// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x00099BFC File Offset: 0x00097DFC
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x00099C08 File Offset: 0x00097E08
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x00099C10 File Offset: 0x00097E10
		[ProtoMember(3, IsRequired = true, Name = "Description", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x00099C1C File Offset: 0x00097E1C
		// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x00099C24 File Offset: 0x00097E24
		[ProtoMember(4, IsRequired = true, Name = "GroupID", DataFormat = DataFormat.TwosComplement)]
		public int GroupID
		{
			get
			{
				return this._GroupID;
			}
			set
			{
				this._GroupID = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001CB7 RID: 7351 RVA: 0x00099C30 File Offset: 0x00097E30
		[ProtoMember(5, Name = "CardItems", DataFormat = DataFormat.Default)]
		public List<Goods> CardItems
		{
			get
			{
				return this._CardItems;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00099C38 File Offset: 0x00097E38
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00099C40 File Offset: 0x00097E40
		[ProtoMember(6, IsRequired = true, Name = "DefaultWeight", DataFormat = DataFormat.TwosComplement)]
		public int DefaultWeight
		{
			get
			{
				return this._DefaultWeight;
			}
			set
			{
				this._DefaultWeight = value;
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00099C4C File Offset: 0x00097E4C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00099C5C File Offset: 0x00097E5C
		public int CardPoolItemID
		{
			get
			{
				return this.ID;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x00099C64 File Offset: 0x00097E64
		public List<Goods> Items
		{
			get
			{
				return this.CardItems;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x00099C6C File Offset: 0x00097E6C
		public int ItemDefaultWeight
		{
			get
			{
				return this.DefaultWeight;
			}
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00099C74 File Offset: 0x00097E74
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

		// Token: 0x06001CBF RID: 7359 RVA: 0x00099D40 File Offset: 0x00097F40
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataActivityCardPoolGroupInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400111C RID: 4380
		private int _ID;

		// Token: 0x0400111D RID: 4381
		private string _Description;

		// Token: 0x0400111E RID: 4382
		private int _GroupID;

		// Token: 0x0400111F RID: 4383
		private readonly List<Goods> _CardItems = new List<Goods>();

		// Token: 0x04001120 RID: 4384
		private int _DefaultWeight;

		// Token: 0x04001121 RID: 4385
		private IExtension extensionObject;

		// Token: 0x04001122 RID: 4386
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001123 RID: 4387
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001124 RID: 4388
		private LuaFunction m_ctor_hotfix;
	}
}
