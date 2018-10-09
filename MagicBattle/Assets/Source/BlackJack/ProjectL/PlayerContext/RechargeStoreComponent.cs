using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008DD RID: 2269
	[HotFix]
	public class RechargeStoreComponent : RechargeStoreComponentCommon
	{
		// Token: 0x06007622 RID: 30242 RVA: 0x002051C0 File Offset: 0x002033C0
		public RechargeStoreComponent()
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

		// Token: 0x06007623 RID: 30243 RVA: 0x00205228 File Offset: 0x00203428
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

		// Token: 0x06007624 RID: 30244 RVA: 0x002052A4 File Offset: 0x002034A4
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

		// Token: 0x06007625 RID: 30245 RVA: 0x0020530C File Offset: 0x0020350C
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

		// Token: 0x06007626 RID: 30246 RVA: 0x00205374 File Offset: 0x00203574
		public void DeSerialize(DSRechargeStoreNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSRechargeStoreNtf_hotfix != null)
			{
				this.m_DeSerializeDSRechargeStoreNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_rechargeStoreDS.ClearInitedData();
			this.m_rechargeStoreDS.InitBoughtGoodsList(msg.BoughtGoodsList);
			this.m_rechargeStoreDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x0020541C File Offset: 0x0020361C
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
			return this.m_rechargeStoreDS.ClientVersion;
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00205494 File Offset: 0x00203694
		public void BuyGoods(int goodsId, int addRechargeCrystal)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyGoodsInt32Int32_hotfix != null)
			{
				this.m_BuyGoodsInt32Int32_hotfix.call(new object[]
				{
					this,
					goodsId,
					addRechargeCrystal
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.BuyGoods(goodsId);
			this.m_basicInfo.AddRechargedCrystal(addRechargeCrystal);
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x00205528 File Offset: 0x00203728
		public int GetCrystalOriginalNums(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCrystalOriginalNumsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCrystalOriginalNumsInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRechargeStoreItemInfo configDataRechargeStoreItemInfo = this.m_configDataLoader.GetConfigDataRechargeStoreItemInfo(goodsId);
			if (configDataRechargeStoreItemInfo == null)
			{
				return 0;
			}
			return configDataRechargeStoreItemInfo.GotCrystalNums;
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x002055C0 File Offset: 0x002037C0
		public int GetCrystalFirstBoughtRewardNums(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCrystalFirstBoughtRewardNumsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCrystalFirstBoughtRewardNumsInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRechargeStoreItemInfo configDataRechargeStoreItemInfo = this.m_configDataLoader.GetConfigDataRechargeStoreItemInfo(goodsId);
			if (configDataRechargeStoreItemInfo == null)
			{
				return 0;
			}
			return configDataRechargeStoreItemInfo.FirstBoughtReward;
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x00205658 File Offset: 0x00203858
		public int GetCrystalRepeatlyBoughtRewardNums(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCrystalRepeatlyBoughtRewardNumsInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCrystalRepeatlyBoughtRewardNumsInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRechargeStoreItemInfo configDataRechargeStoreItemInfo = this.m_configDataLoader.GetConfigDataRechargeStoreItemInfo(goodsId);
			if (configDataRechargeStoreItemInfo == null)
			{
				return 0;
			}
			return configDataRechargeStoreItemInfo.RepeatlyBoughtReward;
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x002056F0 File Offset: 0x002038F0
		public string GetGoodsIcon(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGoodsIconInt32_hotfix != null)
			{
				return (string)this.m_GetGoodsIconInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRechargeStoreItemInfo configDataRechargeStoreItemInfo = this.m_configDataLoader.GetConfigDataRechargeStoreItemInfo(goodsId);
			if (configDataRechargeStoreItemInfo == null)
			{
				return string.Empty;
			}
			return configDataRechargeStoreItemInfo.Icon;
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x0600762D RID: 30253 RVA: 0x0020578C File Offset: 0x0020398C
		// (set) Token: 0x0600762E RID: 30254 RVA: 0x002057AC File Offset: 0x002039AC
		[DoNotToLua]
		public new RechargeStoreComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RechargeStoreComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x002057B8 File Offset: 0x002039B8
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x002057C0 File Offset: 0x002039C0
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x002057C8 File Offset: 0x002039C8
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x002057D0 File Offset: 0x002039D0
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x002057D8 File Offset: 0x002039D8
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x002057E4 File Offset: 0x002039E4
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x002057EC File Offset: 0x002039EC
		private bool __callBase_IsGoodsBought(int goodsId)
		{
			return base.IsGoodsBought(goodsId);
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x002057F8 File Offset: 0x002039F8
		private int __callBase_CaculateGotCrystalNums(int goodsId)
		{
			return base.CaculateGotCrystalNums(goodsId);
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00205804 File Offset: 0x00203A04
		private void __callBase_BuyGoods(int goodsId)
		{
			base.BuyGoods(goodsId);
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x00205810 File Offset: 0x00203A10
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
					this.m_DeSerializeDSRechargeStoreNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_BuyGoodsInt32Int32_hotfix = (luaObj.RawGet("BuyGoods") as LuaFunction);
					this.m_GetCrystalOriginalNumsInt32_hotfix = (luaObj.RawGet("GetCrystalOriginalNums") as LuaFunction);
					this.m_GetCrystalFirstBoughtRewardNumsInt32_hotfix = (luaObj.RawGet("GetCrystalFirstBoughtRewardNums") as LuaFunction);
					this.m_GetCrystalRepeatlyBoughtRewardNumsInt32_hotfix = (luaObj.RawGet("GetCrystalRepeatlyBoughtRewardNums") as LuaFunction);
					this.m_GetGoodsIconInt32_hotfix = (luaObj.RawGet("GetGoodsIcon") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x002059D8 File Offset: 0x00203BD8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RechargeStoreComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040055FB RID: 22011
		[DoNotToLua]
		private RechargeStoreComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040055FC RID: 22012
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040055FD RID: 22013
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040055FE RID: 22014
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040055FF RID: 22015
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005600 RID: 22016
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005601 RID: 22017
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005602 RID: 22018
		private LuaFunction m_DeSerializeDSRechargeStoreNtf_hotfix;

		// Token: 0x04005603 RID: 22019
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005604 RID: 22020
		private LuaFunction m_BuyGoodsInt32Int32_hotfix;

		// Token: 0x04005605 RID: 22021
		private LuaFunction m_GetCrystalOriginalNumsInt32_hotfix;

		// Token: 0x04005606 RID: 22022
		private LuaFunction m_GetCrystalFirstBoughtRewardNumsInt32_hotfix;

		// Token: 0x04005607 RID: 22023
		private LuaFunction m_GetCrystalRepeatlyBoughtRewardNumsInt32_hotfix;

		// Token: 0x04005608 RID: 22024
		private LuaFunction m_GetGoodsIconInt32_hotfix;

		// Token: 0x020008DE RID: 2270
		public new class LuaExportHelper
		{
			// Token: 0x0600763A RID: 30266 RVA: 0x00205A40 File Offset: 0x00203C40
			public LuaExportHelper(RechargeStoreComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600763B RID: 30267 RVA: 0x00205A50 File Offset: 0x00203C50
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x0600763C RID: 30268 RVA: 0x00205A60 File Offset: 0x00203C60
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x0600763D RID: 30269 RVA: 0x00205A70 File Offset: 0x00203C70
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x0600763E RID: 30270 RVA: 0x00205A80 File Offset: 0x00203C80
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x0600763F RID: 30271 RVA: 0x00205A90 File Offset: 0x00203C90
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007640 RID: 30272 RVA: 0x00205AA0 File Offset: 0x00203CA0
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06007641 RID: 30273 RVA: 0x00205AB0 File Offset: 0x00203CB0
			public bool __callBase_IsGoodsBought(int goodsId)
			{
				return this.m_owner.__callBase_IsGoodsBought(goodsId);
			}

			// Token: 0x06007642 RID: 30274 RVA: 0x00205AC0 File Offset: 0x00203CC0
			public int __callBase_CaculateGotCrystalNums(int goodsId)
			{
				return this.m_owner.__callBase_CaculateGotCrystalNums(goodsId);
			}

			// Token: 0x06007643 RID: 30275 RVA: 0x00205AD0 File Offset: 0x00203CD0
			public void __callBase_BuyGoods(int goodsId)
			{
				this.m_owner.__callBase_BuyGoods(goodsId);
			}

			// Token: 0x04005609 RID: 22025
			private RechargeStoreComponent m_owner;
		}
	}
}
