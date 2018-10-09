using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008D9 RID: 2265
	[HotFix]
	public class RandomStoreComponent : RandomStoreComponentCommon
	{
		// Token: 0x060075AF RID: 30127 RVA: 0x00203880 File Offset: 0x00201A80
		public RandomStoreComponent()
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

		// Token: 0x060075B0 RID: 30128 RVA: 0x002038E8 File Offset: 0x00201AE8
		public override void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00203964 File Offset: 0x00201B64
		public override void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.PostInit();
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x002039CC File Offset: 0x00201BCC
		public override void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.DeInit();
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x00203A34 File Offset: 0x00201C34
		public void DeSerialize(DSRandomStoreNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSRandomStoreNtf_hotfix != null)
			{
				this.m_DeSerializeDSRandomStoreNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitStores(ntf.Stores);
			this.m_randomStoreDS.InitVersion((ushort)ntf.Version, (ushort)ntf.Version);
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x00203ACC File Offset: 0x00201CCC
		public void InitStores(List<ProRandomStore> pbStores)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitStoresList`1_hotfix != null)
			{
				this.m_InitStoresList`1_hotfix.call(new object[]
				{
					this,
					pbStores
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_randomStoreDS.ClearInitedData();
			foreach (ProRandomStore pbStore in pbStores)
			{
				this.m_randomStoreDS.InitStore(RandomStore.PBStoreToStore(pbStore));
			}
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x00203B9C File Offset: 0x00201D9C
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_randomStoreDS.ClientVersion;
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x00203C14 File Offset: 0x00201E14
		public bool IsStoreInfoEmpty()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsStoreInfoEmpty_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsStoreInfoEmpty_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_randomStoreDS.Stores.Count == 0;
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x00203C94 File Offset: 0x00201E94
		public void SetStore(RandomStore store)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStoreRandomStore_hotfix != null)
			{
				this.m_SetStoreRandomStore_hotfix.call(new object[]
				{
					this,
					store
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_randomStoreDS.SetStore(store);
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x00203D10 File Offset: 0x00201F10
		public int GetManualFlushNums(int storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetManualFlushNumsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetManualFlushNumsInt32_hotfix.call(new object[]
				{
					this,
					storeId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_randomStoreDS.GetManualFlushNums(storeId);
		}

		// Token: 0x060075B9 RID: 30137 RVA: 0x00203D98 File Offset: 0x00201F98
		public int CanManualFlushRandomStore(RandomStore store)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanManualFlushRandomStoreRandomStore_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanManualFlushRandomStoreRandomStore_hotfix.call(new object[]
				{
					this,
					store
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRandomStoreInfo configDataRandomStoreInfo = this.m_configDataLoader.GetConfigDataRandomStoreInfo(store.Id);
			if (configDataRandomStoreInfo == null)
			{
				return -1103;
			}
			return base.CanManualFlushStore(store, configDataRandomStoreInfo);
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x00203E3C File Offset: 0x0020203C
		public int ManualFlushRandomStore(RandomStore store)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ManualFlushRandomStoreRandomStore_hotfix != null)
			{
				return Convert.ToInt32(this.m_ManualFlushRandomStoreRandomStore_hotfix.call(new object[]
				{
					this,
					store
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRandomStoreInfo configDataRandomStoreInfo = this.m_configDataLoader.GetConfigDataRandomStoreInfo(store.Id);
			if (configDataRandomStoreInfo == null)
			{
				return -1103;
			}
			this.SetStore(store);
			this.m_basicInfo.AddCurrency(configDataRandomStoreInfo.CurrencyType, -configDataRandomStoreInfo.Price, GameFunctionType.GameFunctionType_None, null);
			return 0;
		}

		// Token: 0x060075BB RID: 30139 RVA: 0x00203EFC File Offset: 0x002020FC
		public RandomStore GetStore(int storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStoreInt32_hotfix != null)
			{
				return (RandomStore)this.m_GetStoreInt32_hotfix.call(new object[]
				{
					this,
					storeId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_randomStoreDS.FindStore(storeId);
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x00203F84 File Offset: 0x00202184
		public DateTime GetStoreNextFlushTime(int storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStoreNextFlushTimeInt32_hotfix != null)
			{
				return (DateTime)this.m_GetStoreNextFlushTimeInt32_hotfix.call(new object[]
				{
					this,
					storeId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RandomStore store = this.GetStore(storeId);
			if (store == null)
			{
				return DateTime.MinValue;
			}
			return store.NextFlushTime;
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x0020401C File Offset: 0x0020221C
		public int BuyStoreItem(int storeId, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyStoreItemInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_BuyStoreItemInt32Int32_hotfix.call(new object[]
				{
					this,
					storeId,
					index
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RandomStore randomStore = this.m_randomStoreDS.FindStore(storeId);
			if (randomStore == null)
			{
				return -1100;
			}
			if (index < 0 || index >= randomStore.Items.Count)
			{
				return -1101;
			}
			RandomStoreItem storeItem = this.m_randomStoreDS.GetStoreItem(randomStore, index);
			if (base.IsBoughtStoreItem(storeItem))
			{
				return -1102;
			}
			ConfigDataRandomStoreItemInfo configDataRandomStoreItemInfo = this.m_configDataLoader.GetConfigDataRandomStoreItemInfo(storeItem.Id);
			int num = this.m_basicInfo.IsCurrencyEnough(configDataRandomStoreItemInfo.CurrencyType, configDataRandomStoreItemInfo.Price);
			if (num != 0)
			{
				return num;
			}
			this.m_basicInfo.AddCurrency(configDataRandomStoreItemInfo.CurrencyType, -configDataRandomStoreItemInfo.Price, GameFunctionType.GameFunctionType_None, null);
			this.m_randomStoreDS.BuyStoreItem(storeItem);
			base.OnBuyStoreItem(storeId, storeItem.Id);
			return storeItem.Id;
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x060075BE RID: 30142 RVA: 0x0020416C File Offset: 0x0020236C
		// (set) Token: 0x060075BF RID: 30143 RVA: 0x0020418C File Offset: 0x0020238C
		[DoNotToLua]
		public new RandomStoreComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RandomStoreComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x00204198 File Offset: 0x00202398
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x002041A0 File Offset: 0x002023A0
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x002041A8 File Offset: 0x002023A8
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x002041B0 File Offset: 0x002023B0
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x002041B8 File Offset: 0x002023B8
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x002041C4 File Offset: 0x002023C4
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x002041CC File Offset: 0x002023CC
		private void __callBase_OnFlushManualFlushNums()
		{
			base.OnFlushManualFlushNums();
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x002041D4 File Offset: 0x002023D4
		private bool __callBase_CanAutoFlushStore(RandomStore store)
		{
			return base.CanAutoFlushStore(store);
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x002041E0 File Offset: 0x002023E0
		private bool __callBase_IsBoughtStoreItem(RandomStoreItem storeItem)
		{
			return base.IsBoughtStoreItem(storeItem);
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x002041EC File Offset: 0x002023EC
		private int __callBase_CanManualFlushStore(RandomStore store, ConfigDataRandomStoreInfo storeInfo)
		{
			return base.CanManualFlushStore(store, storeInfo);
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x002041F8 File Offset: 0x002023F8
		private int __callBase_CanBuyRandomStoreItem(int storeId, int index, int selectedIndex)
		{
			return base.CanBuyRandomStoreItem(storeId, index, selectedIndex);
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x00204204 File Offset: 0x00202404
		private void __callBase_OnBuyStoreItem(int storeId, int goodsId)
		{
			base.OnBuyStoreItem(storeId, goodsId);
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x00204210 File Offset: 0x00202410
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSRandomStoreNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_InitStoresList`1_hotfix = (luaObj.RawGet("InitStores") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_IsStoreInfoEmpty_hotfix = (luaObj.RawGet("IsStoreInfoEmpty") as LuaFunction);
					this.m_SetStoreRandomStore_hotfix = (luaObj.RawGet("SetStore") as LuaFunction);
					this.m_GetManualFlushNumsInt32_hotfix = (luaObj.RawGet("GetManualFlushNums") as LuaFunction);
					this.m_CanManualFlushRandomStoreRandomStore_hotfix = (luaObj.RawGet("CanManualFlushRandomStore") as LuaFunction);
					this.m_ManualFlushRandomStoreRandomStore_hotfix = (luaObj.RawGet("ManualFlushRandomStore") as LuaFunction);
					this.m_GetStoreInt32_hotfix = (luaObj.RawGet("GetStore") as LuaFunction);
					this.m_GetStoreNextFlushTimeInt32_hotfix = (luaObj.RawGet("GetStoreNextFlushTime") as LuaFunction);
					this.m_BuyStoreItemInt32Int32_hotfix = (luaObj.RawGet("BuyStoreItem") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x0020443C File Offset: 0x0020263C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomStoreComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040055D6 RID: 21974
		[DoNotToLua]
		private RandomStoreComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040055D7 RID: 21975
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040055D8 RID: 21976
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040055D9 RID: 21977
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040055DA RID: 21978
		private LuaFunction m_Init_hotfix;

		// Token: 0x040055DB RID: 21979
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040055DC RID: 21980
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040055DD RID: 21981
		private LuaFunction m_DeSerializeDSRandomStoreNtf_hotfix;

		// Token: 0x040055DE RID: 21982
		private LuaFunction m_InitStoresList;

		// Token: 0x040055DF RID: 21983
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x040055E0 RID: 21984
		private LuaFunction m_IsStoreInfoEmpty_hotfix;

		// Token: 0x040055E1 RID: 21985
		private LuaFunction m_SetStoreRandomStore_hotfix;

		// Token: 0x040055E2 RID: 21986
		private LuaFunction m_GetManualFlushNumsInt32_hotfix;

		// Token: 0x040055E3 RID: 21987
		private LuaFunction m_CanManualFlushRandomStoreRandomStore_hotfix;

		// Token: 0x040055E4 RID: 21988
		private LuaFunction m_ManualFlushRandomStoreRandomStore_hotfix;

		// Token: 0x040055E5 RID: 21989
		private LuaFunction m_GetStoreInt32_hotfix;

		// Token: 0x040055E6 RID: 21990
		private LuaFunction m_GetStoreNextFlushTimeInt32_hotfix;

		// Token: 0x040055E7 RID: 21991
		private LuaFunction m_BuyStoreItemInt32Int32_hotfix;

		// Token: 0x020008DA RID: 2266
		public new class LuaExportHelper
		{
			// Token: 0x060075CE RID: 30158 RVA: 0x002044A4 File Offset: 0x002026A4
			public LuaExportHelper(RandomStoreComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060075CF RID: 30159 RVA: 0x002044B4 File Offset: 0x002026B4
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x060075D0 RID: 30160 RVA: 0x002044C4 File Offset: 0x002026C4
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x060075D1 RID: 30161 RVA: 0x002044D4 File Offset: 0x002026D4
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x060075D2 RID: 30162 RVA: 0x002044E4 File Offset: 0x002026E4
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x060075D3 RID: 30163 RVA: 0x002044F4 File Offset: 0x002026F4
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x060075D4 RID: 30164 RVA: 0x00204504 File Offset: 0x00202704
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x060075D5 RID: 30165 RVA: 0x00204514 File Offset: 0x00202714
			public void __callBase_OnFlushManualFlushNums()
			{
				this.m_owner.__callBase_OnFlushManualFlushNums();
			}

			// Token: 0x060075D6 RID: 30166 RVA: 0x00204524 File Offset: 0x00202724
			public bool __callBase_CanAutoFlushStore(RandomStore store)
			{
				return this.m_owner.__callBase_CanAutoFlushStore(store);
			}

			// Token: 0x060075D7 RID: 30167 RVA: 0x00204534 File Offset: 0x00202734
			public bool __callBase_IsBoughtStoreItem(RandomStoreItem storeItem)
			{
				return this.m_owner.__callBase_IsBoughtStoreItem(storeItem);
			}

			// Token: 0x060075D8 RID: 30168 RVA: 0x00204544 File Offset: 0x00202744
			public int __callBase_CanManualFlushStore(RandomStore store, ConfigDataRandomStoreInfo storeInfo)
			{
				return this.m_owner.__callBase_CanManualFlushStore(store, storeInfo);
			}

			// Token: 0x060075D9 RID: 30169 RVA: 0x00204554 File Offset: 0x00202754
			public int __callBase_CanBuyRandomStoreItem(int storeId, int index, int selectedIndex)
			{
				return this.m_owner.__callBase_CanBuyRandomStoreItem(storeId, index, selectedIndex);
			}

			// Token: 0x060075DA RID: 30170 RVA: 0x00204564 File Offset: 0x00202764
			public void __callBase_OnBuyStoreItem(int storeId, int goodsId)
			{
				this.m_owner.__callBase_OnBuyStoreItem(storeId, goodsId);
			}

			// Token: 0x040055E8 RID: 21992
			private RandomStoreComponent m_owner;
		}
	}
}
