using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000273 RID: 627
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataRandomStoreInfo")]
	[Serializable]
	public class ConfigDataRandomStoreInfo : IExtensible
	{
		// Token: 0x06002822 RID: 10274 RVA: 0x000AD7B0 File Offset: 0x000AB9B0
		public ConfigDataRandomStoreInfo()
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

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x000AD818 File Offset: 0x000ABA18
		// (set) Token: 0x06002824 RID: 10276 RVA: 0x000AD820 File Offset: 0x000ABA20
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

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x000AD82C File Offset: 0x000ABA2C
		// (set) Token: 0x06002826 RID: 10278 RVA: 0x000AD834 File Offset: 0x000ABA34
		[ProtoMember(3, IsRequired = true, Name = "ItemCount", DataFormat = DataFormat.TwosComplement)]
		public int ItemCount
		{
			get
			{
				return this._ItemCount;
			}
			set
			{
				this._ItemCount = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x000AD840 File Offset: 0x000ABA40
		// (set) Token: 0x06002828 RID: 10280 RVA: 0x000AD848 File Offset: 0x000ABA48
		[ProtoMember(4, IsRequired = true, Name = "FlushRuleType", DataFormat = DataFormat.TwosComplement)]
		public FlushRuleType FlushRuleType
		{
			get
			{
				return this._FlushRuleType;
			}
			set
			{
				this._FlushRuleType = value;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x000AD854 File Offset: 0x000ABA54
		// (set) Token: 0x0600282A RID: 10282 RVA: 0x000AD85C File Offset: 0x000ABA5C
		[ProtoMember(5, IsRequired = true, Name = "Param", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x000AD868 File Offset: 0x000ABA68
		// (set) Token: 0x0600282C RID: 10284 RVA: 0x000AD870 File Offset: 0x000ABA70
		[ProtoMember(6, IsRequired = true, Name = "CurrencyType", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x000AD87C File Offset: 0x000ABA7C
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x000AD884 File Offset: 0x000ABA84
		[ProtoMember(7, IsRequired = true, Name = "Price", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x0600282F RID: 10287 RVA: 0x000AD890 File Offset: 0x000ABA90
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x000AD8A0 File Offset: 0x000ABAA0
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

		// Token: 0x06002831 RID: 10289 RVA: 0x000AD96C File Offset: 0x000ABB6C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRandomStoreInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040018A4 RID: 6308
		private int _ID;

		// Token: 0x040018A5 RID: 6309
		private int _ItemCount;

		// Token: 0x040018A6 RID: 6310
		private FlushRuleType _FlushRuleType;

		// Token: 0x040018A7 RID: 6311
		private int _Param;

		// Token: 0x040018A8 RID: 6312
		private GoodsType _CurrencyType;

		// Token: 0x040018A9 RID: 6313
		private int _Price;

		// Token: 0x040018AA RID: 6314
		private IExtension extensionObject;

		// Token: 0x040018AB RID: 6315
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040018AC RID: 6316
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040018AD RID: 6317
		private LuaFunction m_ctor_hotfix;
	}
}
