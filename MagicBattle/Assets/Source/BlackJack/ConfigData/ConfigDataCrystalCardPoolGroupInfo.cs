using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000224 RID: 548
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataCrystalCardPoolGroupInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataCrystalCardPoolGroupInfo : IExtensible, ICardPoolItemWeight
	{
		// Token: 0x0600209C RID: 8348 RVA: 0x000A0D9C File Offset: 0x0009EF9C
		public ConfigDataCrystalCardPoolGroupInfo()
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

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x000A0E10 File Offset: 0x0009F010
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x000A0E18 File Offset: 0x0009F018
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

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x000A0E24 File Offset: 0x0009F024
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x000A0E2C File Offset: 0x0009F02C
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

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000A0E38 File Offset: 0x0009F038
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x000A0E40 File Offset: 0x0009F040
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

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000A0E4C File Offset: 0x0009F04C
		[ProtoMember(5, Name = "CardItems", DataFormat = DataFormat.Default)]
		public List<Goods> CardItems
		{
			get
			{
				return this._CardItems;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x000A0E54 File Offset: 0x0009F054
		// (set) Token: 0x060020A5 RID: 8357 RVA: 0x000A0E5C File Offset: 0x0009F05C
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

		// Token: 0x060020A6 RID: 8358 RVA: 0x000A0E68 File Offset: 0x0009F068
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x000A0E78 File Offset: 0x0009F078
		public int CardPoolItemID
		{
			get
			{
				return this.ID;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x000A0E80 File Offset: 0x0009F080
		public List<Goods> Items
		{
			get
			{
				return this.CardItems;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x000A0E88 File Offset: 0x0009F088
		public int ItemDefaultWeight
		{
			get
			{
				return this.DefaultWeight;
			}
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x000A0E90 File Offset: 0x0009F090
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

		// Token: 0x060020AB RID: 8363 RVA: 0x000A0F5C File Offset: 0x0009F15C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataCrystalCardPoolGroupInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040013B9 RID: 5049
		private int _ID;

		// Token: 0x040013BA RID: 5050
		private string _Description;

		// Token: 0x040013BB RID: 5051
		private int _GroupID;

		// Token: 0x040013BC RID: 5052
		private readonly List<Goods> _CardItems = new List<Goods>();

		// Token: 0x040013BD RID: 5053
		private int _DefaultWeight;

		// Token: 0x040013BE RID: 5054
		private IExtension extensionObject;

		// Token: 0x040013BF RID: 5055
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040013C0 RID: 5056
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040013C1 RID: 5057
		private LuaFunction m_ctor_hotfix;
	}
}
