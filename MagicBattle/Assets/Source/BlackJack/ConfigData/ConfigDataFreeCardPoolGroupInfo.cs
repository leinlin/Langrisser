using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000233 RID: 563
	[ProtoContract(Name = "ConfigDataFreeCardPoolGroupInfo")]
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataFreeCardPoolGroupInfo : IExtensible, ICardPoolItemWeight
	{
		// Token: 0x06002280 RID: 8832 RVA: 0x000A3914 File Offset: 0x000A1B14
		public ConfigDataFreeCardPoolGroupInfo()
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

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x000A3988 File Offset: 0x000A1B88
		// (set) Token: 0x06002282 RID: 8834 RVA: 0x000A3990 File Offset: 0x000A1B90
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

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x000A399C File Offset: 0x000A1B9C
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x000A39A4 File Offset: 0x000A1BA4
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x000A39B0 File Offset: 0x000A1BB0
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x000A39B8 File Offset: 0x000A1BB8
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

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x000A39C4 File Offset: 0x000A1BC4
		[ProtoMember(5, Name = "CardItems", DataFormat = DataFormat.Default)]
		public List<Goods> CardItems
		{
			get
			{
				return this._CardItems;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x000A39CC File Offset: 0x000A1BCC
		// (set) Token: 0x06002289 RID: 8841 RVA: 0x000A39D4 File Offset: 0x000A1BD4
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

		// Token: 0x0600228A RID: 8842 RVA: 0x000A39E0 File Offset: 0x000A1BE0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x000A39F0 File Offset: 0x000A1BF0
		public int CardPoolItemID
		{
			get
			{
				return this.ID;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x000A39F8 File Offset: 0x000A1BF8
		public List<Goods> Items
		{
			get
			{
				return this.CardItems;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x000A3A00 File Offset: 0x000A1C00
		public int ItemDefaultWeight
		{
			get
			{
				return this.DefaultWeight;
			}
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x000A3A08 File Offset: 0x000A1C08
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

		// Token: 0x0600228F RID: 8847 RVA: 0x000A3AD4 File Offset: 0x000A1CD4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataFreeCardPoolGroupInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040014E2 RID: 5346
		private int _ID;

		// Token: 0x040014E3 RID: 5347
		private string _Description;

		// Token: 0x040014E4 RID: 5348
		private int _GroupID;

		// Token: 0x040014E5 RID: 5349
		private readonly List<Goods> _CardItems = new List<Goods>();

		// Token: 0x040014E6 RID: 5350
		private int _DefaultWeight;

		// Token: 0x040014E7 RID: 5351
		private IExtension extensionObject;

		// Token: 0x040014E8 RID: 5352
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040014E9 RID: 5353
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040014EA RID: 5354
		private LuaFunction m_ctor_hotfix;
	}
}
