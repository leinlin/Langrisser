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
	// Token: 0x020008DF RID: 2271
	[HotFix]
	public class ResourceComponent : ResourceComponentCommon
	{
		// Token: 0x06007644 RID: 30276 RVA: 0x00205AE0 File Offset: 0x00203CE0
		public ResourceComponent()
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

		// Token: 0x06007645 RID: 30277 RVA: 0x00205B48 File Offset: 0x00203D48
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

		// Token: 0x06007646 RID: 30278 RVA: 0x00205BC4 File Offset: 0x00203DC4
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

		// Token: 0x06007647 RID: 30279 RVA: 0x00205C2C File Offset: 0x00203E2C
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

		// Token: 0x06007648 RID: 30280 RVA: 0x00205C94 File Offset: 0x00203E94
		public void DeSerialize(DSResourceNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSResourceNtf_hotfix != null)
			{
				this.m_DeSerializeDSResourceNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_resourceDS.ClearInitedData();
			this.m_resourceDS.InitResource(PlayerOutOfBagItem.FromPB(msg.Resource));
			this.m_resourceDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			base.EffectValidMonthCard();
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x00205D44 File Offset: 0x00203F44
		public void UpdateMonthCard(int monthCard, long expiredTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateMonthCardInt32Int64_hotfix != null)
			{
				this.m_UpdateMonthCardInt32Int64_hotfix.call(new object[]
				{
					this,
					monthCard,
					expiredTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			if (new DateTime(expiredTime) <= currentTime)
			{
				base.RemoveMonthCard(monthCard);
			}
			else
			{
				this.AddMonthCard(monthCard, new DateTime(expiredTime), null);
			}
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x00205DFC File Offset: 0x00203FFC
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
			return this.m_resourceDS.ClientVersion;
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x0600764B RID: 30283 RVA: 0x00205E74 File Offset: 0x00204074
		// (set) Token: 0x0600764C RID: 30284 RVA: 0x00205E94 File Offset: 0x00204094
		[DoNotToLua]
		public new ResourceComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ResourceComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x00205EA0 File Offset: 0x002040A0
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x00205EA8 File Offset: 0x002040A8
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x00205EB0 File Offset: 0x002040B0
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x00205EB8 File Offset: 0x002040B8
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x00205EC0 File Offset: 0x002040C0
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x00205ECC File Offset: 0x002040CC
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00205ED4 File Offset: 0x002040D4
		private void __callBase_EffectValidMonthCard()
		{
			base.EffectValidMonthCard();
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00205EDC File Offset: 0x002040DC
		private List<MonthCard> __callBase_GetAllValidMonthCards()
		{
			return base.GetAllValidMonthCards();
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x00205EE4 File Offset: 0x002040E4
		private void __callBase_AddMonthCard(int monthCardId, DateTime expiredTime, string goodsId)
		{
			base.AddMonthCard(monthCardId, expiredTime, goodsId);
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x00205EF0 File Offset: 0x002040F0
		private bool __callBase_RemoveMonthCard(int monthCardId)
		{
			return base.RemoveMonthCard(monthCardId);
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x00205EFC File Offset: 0x002040FC
		private MonthCard __callBase_FindMonthCardById(int cardId)
		{
			return base.FindMonthCardById(cardId);
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x00205F08 File Offset: 0x00204108
		private bool __callBase_IsMonthCardVaild(int cardId)
		{
			return base.IsMonthCardVaild(cardId);
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x00205F14 File Offset: 0x00204114
		private void __callBase_OnMonthCardValid(int monthCardId)
		{
			base.OnMonthCardValid(monthCardId);
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x00205F20 File Offset: 0x00204120
		private void __callBase_OnMonthCardInvalid(int monthCardId)
		{
			base.OnMonthCardInvalid(monthCardId);
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x00205F2C File Offset: 0x0020412C
		private bool __callBase_HasHeadFrameId(int headFrameId)
		{
			return base.HasHeadFrameId(headFrameId);
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00205F38 File Offset: 0x00204138
		private void __callBase_AddHeadFrame(int headFrameId, GameFunctionType causeId, string location)
		{
			base.AddHeadFrame(headFrameId, causeId, location);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00205F44 File Offset: 0x00204144
		private void __callBase_AddHeroSkin(int heroSkinId, GameFunctionType causeId, string location)
		{
			base.AddHeroSkin(heroSkinId, causeId, location);
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00205F50 File Offset: 0x00204150
		private void __callBase_AddSoldierSkin(int soldierSkinId, GameFunctionType causeId, string location)
		{
			base.AddSoldierSkin(soldierSkinId, causeId, location);
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x00205F5C File Offset: 0x0020415C
		private bool __callBase_HasOwn(GoodsType goodtypeId, int id)
		{
			return base.HasOwn(goodtypeId, id);
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x00205F68 File Offset: 0x00204168
		private void __callBase_OnCreateBagItemEventCallBack(BagItemBase bagItem)
		{
			base.OnCreateBagItemEventCallBack(bagItem);
		}

		// Token: 0x06007661 RID: 30305 RVA: 0x00205F74 File Offset: 0x00204174
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
					this.m_DeSerializeDSResourceNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_UpdateMonthCardInt32Int64_hotfix = (luaObj.RawGet("UpdateMonthCard") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x002060D8 File Offset: 0x002042D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ResourceComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400560A RID: 22026
		[DoNotToLua]
		private ResourceComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400560B RID: 22027
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400560C RID: 22028
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400560D RID: 22029
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400560E RID: 22030
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400560F RID: 22031
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005610 RID: 22032
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005611 RID: 22033
		private LuaFunction m_DeSerializeDSResourceNtf_hotfix;

		// Token: 0x04005612 RID: 22034
		private LuaFunction m_UpdateMonthCardInt32Int64_hotfix;

		// Token: 0x04005613 RID: 22035
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x020008E0 RID: 2272
		public new class LuaExportHelper
		{
			// Token: 0x06007663 RID: 30307 RVA: 0x00206140 File Offset: 0x00204340
			public LuaExportHelper(ResourceComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007664 RID: 30308 RVA: 0x00206150 File Offset: 0x00204350
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007665 RID: 30309 RVA: 0x00206160 File Offset: 0x00204360
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007666 RID: 30310 RVA: 0x00206170 File Offset: 0x00204370
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06007667 RID: 30311 RVA: 0x00206180 File Offset: 0x00204380
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007668 RID: 30312 RVA: 0x00206190 File Offset: 0x00204390
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007669 RID: 30313 RVA: 0x002061A0 File Offset: 0x002043A0
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600766A RID: 30314 RVA: 0x002061B0 File Offset: 0x002043B0
			public void __callBase_EffectValidMonthCard()
			{
				this.m_owner.__callBase_EffectValidMonthCard();
			}

			// Token: 0x0600766B RID: 30315 RVA: 0x002061C0 File Offset: 0x002043C0
			public List<MonthCard> __callBase_GetAllValidMonthCards()
			{
				return this.m_owner.__callBase_GetAllValidMonthCards();
			}

			// Token: 0x0600766C RID: 30316 RVA: 0x002061D0 File Offset: 0x002043D0
			public void __callBase_AddMonthCard(int monthCardId, DateTime expiredTime, string goodsId)
			{
				this.m_owner.__callBase_AddMonthCard(monthCardId, expiredTime, goodsId);
			}

			// Token: 0x0600766D RID: 30317 RVA: 0x002061E0 File Offset: 0x002043E0
			public bool __callBase_RemoveMonthCard(int monthCardId)
			{
				return this.m_owner.__callBase_RemoveMonthCard(monthCardId);
			}

			// Token: 0x0600766E RID: 30318 RVA: 0x002061F0 File Offset: 0x002043F0
			public MonthCard __callBase_FindMonthCardById(int cardId)
			{
				return this.m_owner.__callBase_FindMonthCardById(cardId);
			}

			// Token: 0x0600766F RID: 30319 RVA: 0x00206200 File Offset: 0x00204400
			public bool __callBase_IsMonthCardVaild(int cardId)
			{
				return this.m_owner.__callBase_IsMonthCardVaild(cardId);
			}

			// Token: 0x06007670 RID: 30320 RVA: 0x00206210 File Offset: 0x00204410
			public void __callBase_OnMonthCardValid(int monthCardId)
			{
				this.m_owner.__callBase_OnMonthCardValid(monthCardId);
			}

			// Token: 0x06007671 RID: 30321 RVA: 0x00206220 File Offset: 0x00204420
			public void __callBase_OnMonthCardInvalid(int monthCardId)
			{
				this.m_owner.__callBase_OnMonthCardInvalid(monthCardId);
			}

			// Token: 0x06007672 RID: 30322 RVA: 0x00206230 File Offset: 0x00204430
			public bool __callBase_HasHeadFrameId(int headFrameId)
			{
				return this.m_owner.__callBase_HasHeadFrameId(headFrameId);
			}

			// Token: 0x06007673 RID: 30323 RVA: 0x00206240 File Offset: 0x00204440
			public void __callBase_AddHeadFrame(int headFrameId, GameFunctionType causeId, string location)
			{
				this.m_owner.__callBase_AddHeadFrame(headFrameId, causeId, location);
			}

			// Token: 0x06007674 RID: 30324 RVA: 0x00206250 File Offset: 0x00204450
			public void __callBase_AddHeroSkin(int heroSkinId, GameFunctionType causeId, string location)
			{
				this.m_owner.__callBase_AddHeroSkin(heroSkinId, causeId, location);
			}

			// Token: 0x06007675 RID: 30325 RVA: 0x00206260 File Offset: 0x00204460
			public void __callBase_AddSoldierSkin(int soldierSkinId, GameFunctionType causeId, string location)
			{
				this.m_owner.__callBase_AddSoldierSkin(soldierSkinId, causeId, location);
			}

			// Token: 0x06007676 RID: 30326 RVA: 0x00206270 File Offset: 0x00204470
			public bool __callBase_HasOwn(GoodsType goodtypeId, int id)
			{
				return this.m_owner.__callBase_HasOwn(goodtypeId, id);
			}

			// Token: 0x06007677 RID: 30327 RVA: 0x00206280 File Offset: 0x00204480
			public void __callBase_OnCreateBagItemEventCallBack(BagItemBase bagItem)
			{
				this.m_owner.__callBase_OnCreateBagItemEventCallBack(bagItem);
			}

			// Token: 0x04005614 RID: 22036
			private ResourceComponent m_owner;
		}
	}
}
