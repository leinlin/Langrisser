using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004A4 RID: 1188
	[HotFix]
	public class ResourceComponentCommon : IComponentBase
	{
		// Token: 0x060047ED RID: 18413 RVA: 0x001636FC File Offset: 0x001618FC
		public ResourceComponentCommon()
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

		// Token: 0x060047EE RID: 18414 RVA: 0x00163770 File Offset: 0x00161970
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "Resource";
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x001637E4 File Offset: 0x001619E4
		public virtual void Init()
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
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x00163844 File Offset: 0x00161A44
		public virtual void PostInit()
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
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_bag.CreateBagItemEvent += this.OnCreateBagItemEventCallBack;
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x001638F4 File Offset: 0x00161AF4
		public virtual void DeInit()
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
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x00163954 File Offset: 0x00161B54
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x001639C4 File Offset: 0x00161BC4
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x00163A44 File Offset: 0x00161C44
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x00163AB4 File Offset: 0x00161CB4
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060047F6 RID: 18422 RVA: 0x00163B14 File Offset: 0x00161D14
		// (set) Token: 0x060047F7 RID: 18423 RVA: 0x00163B88 File Offset: 0x00161D88
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x00163C00 File Offset: 0x00161E00
		protected void EffectValidMonthCard()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EffectValidMonthCard_hotfix != null)
			{
				this.m_EffectValidMonthCard_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (MonthCard monthCard in this.GetAllValidMonthCards())
			{
				this.OnMonthCardValid(monthCard.CardId);
			}
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x00163CB4 File Offset: 0x00161EB4
		public List<MonthCard> GetAllValidMonthCards()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllValidMonthCards_hotfix != null)
			{
				return (List<MonthCard>)this.m_GetAllValidMonthCards_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<MonthCard> list = new List<MonthCard>();
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			foreach (MonthCard monthCard in this.m_resourceDS.GetAllMonthCards())
			{
				if (monthCard.ExpiredTime > currentTime)
				{
					list.Add(monthCard);
				}
			}
			return list;
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x00163D98 File Offset: 0x00161F98
		public virtual void AddMonthCard(int monthCardId, DateTime expiredTime, string goodsId = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMonthCardInt32DateTimeString_hotfix != null)
			{
				this.m_AddMonthCardInt32DateTimeString_hotfix.call(new object[]
				{
					this,
					monthCardId,
					expiredTime,
					goodsId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_resourceDS.AddMonthCard(monthCardId, expiredTime, goodsId);
			if (this.IsMonthCardVaild(monthCardId))
			{
				this.OnMonthCardValid(monthCardId);
			}
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x00163E4C File Offset: 0x0016204C
		public bool RemoveMonthCard(int monthCardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveMonthCardInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RemoveMonthCardInt32_hotfix.call(new object[]
				{
					this,
					monthCardId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_resourceDS.RemoveMonthCard(monthCardId))
			{
				return false;
			}
			this.OnMonthCardInvalid(monthCardId);
			return true;
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x00163EE4 File Offset: 0x001620E4
		public MonthCard FindMonthCardById(int cardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindMonthCardByIdInt32_hotfix != null)
			{
				return (MonthCard)this.m_FindMonthCardByIdInt32_hotfix.call(new object[]
				{
					this,
					cardId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_resourceDS.FindMonthCardById(cardId);
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x00163F6C File Offset: 0x0016216C
		public bool IsMonthCardVaild(int cardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMonthCardVaildInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMonthCardVaildInt32_hotfix.call(new object[]
				{
					this,
					cardId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			MonthCard monthCard = this.FindMonthCardById(cardId);
			return monthCard != null && monthCard.ExpiredTime > this.m_basicInfo.GetCurrentTime();
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x00164010 File Offset: 0x00162210
		protected void OnMonthCardValid(int monthCardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMonthCardValidInt32_hotfix != null)
			{
				this.m_OnMonthCardValidInt32_hotfix.call(new object[]
				{
					this,
					monthCardId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.MonthCardValidEvent != null)
			{
				this.MonthCardValidEvent(monthCardId);
			}
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x00164098 File Offset: 0x00162298
		protected void OnMonthCardInvalid(int monthCardId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMonthCardInvalidInt32_hotfix != null)
			{
				this.m_OnMonthCardInvalidInt32_hotfix.call(new object[]
				{
					this,
					monthCardId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.MonthCardInvalidEvent != null)
			{
				this.MonthCardInvalidEvent(monthCardId);
			}
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x00164120 File Offset: 0x00162320
		public bool HasHeadFrameId(int headFrameId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasHeadFrameIdInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasHeadFrameIdInt32_hotfix.call(new object[]
				{
					this,
					headFrameId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_resourceDS.HasHeadFrameId(headFrameId);
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x001641A8 File Offset: 0x001623A8
		public virtual void AddHeadFrame(int headFrameId, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeadFrameInt32GameFunctionTypeString_hotfix != null)
			{
				this.m_AddHeadFrameInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					headFrameId,
					causeId,
					location
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_resourceDS.AddHeadFrame(headFrameId);
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x00164248 File Offset: 0x00162448
		public virtual void AddHeroSkin(int heroSkinId, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroSkinInt32GameFunctionTypeString_hotfix != null)
			{
				this.m_AddHeroSkinInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					heroSkinId,
					causeId,
					location
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.HasOwn(GoodsType.GoodsType_HeroSkin, heroSkinId))
			{
				return;
			}
			this.m_resourceDS.AddHeroSkin(heroSkinId);
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x001642F4 File Offset: 0x001624F4
		public virtual void AddSoldierSkin(int soldierSkinId, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddSoldierSkinInt32GameFunctionTypeString_hotfix != null)
			{
				this.m_AddSoldierSkinInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					soldierSkinId,
					causeId,
					location
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.HasOwn(GoodsType.GoodsType_SoldierSkin, soldierSkinId))
			{
				return;
			}
			this.m_resourceDS.AddSoldierSkin(soldierSkinId);
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x001643A0 File Offset: 0x001625A0
		public bool HasOwn(GoodsType goodtypeId, int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasOwnGoodsTypeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasOwnGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					goodtypeId,
					id
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goodtypeId == GoodsType.GoodsType_MonthCard)
			{
				MonthCard monthCard = this.FindMonthCardById(id);
				return monthCard != null && monthCard.ExpiredTime > this.m_basicInfo.GetCurrentTime();
			}
			return this.m_resourceDS.HasOwn(goodtypeId, id);
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x0016446C File Offset: 0x0016266C
		protected void OnCreateBagItemEventCallBack(BagItemBase bagItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCreateBagItemEventCallBackBagItemBase_hotfix != null)
			{
				this.m_OnCreateBagItemEventCallBackBagItemBase_hotfix.call(new object[]
				{
					this,
					bagItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (bagItem.GoodsTypeId == GoodsType.GoodsType_Equipment)
			{
				this.AddEquipmentId(bagItem.ContentId);
			}
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x001644F4 File Offset: 0x001626F4
		private void AddEquipmentId(int equipmentId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddEquipmentIdInt32_hotfix != null)
			{
				this.m_AddEquipmentIdInt32_hotfix.call(new object[]
				{
					this,
					equipmentId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.HasOwn(GoodsType.GoodsType_Equipment, equipmentId))
			{
				return;
			}
			this.m_resourceDS.AddEquipmentId(equipmentId);
		}

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x06004807 RID: 18439 RVA: 0x00164580 File Offset: 0x00162780
		// (remove) Token: 0x06004808 RID: 18440 RVA: 0x0016461C File Offset: 0x0016281C
		public event Action<int> MonthCardValidEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_MonthCardValidEventAction`1_hotfix != null)
				{
					this.m_add_MonthCardValidEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.MonthCardValidEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.MonthCardValidEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_MonthCardValidEventAction`1_hotfix != null)
				{
					this.m_remove_MonthCardValidEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.MonthCardValidEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.MonthCardValidEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x06004809 RID: 18441 RVA: 0x001646B8 File Offset: 0x001628B8
		// (remove) Token: 0x0600480A RID: 18442 RVA: 0x00164754 File Offset: 0x00162954
		public event Action<int> MonthCardInvalidEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_MonthCardInvalidEventAction`1_hotfix != null)
				{
					this.m_add_MonthCardInvalidEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.MonthCardInvalidEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.MonthCardInvalidEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_MonthCardInvalidEventAction`1_hotfix != null)
				{
					this.m_remove_MonthCardInvalidEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.MonthCardInvalidEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.MonthCardInvalidEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x001647F0 File Offset: 0x001629F0
		// (set) Token: 0x0600480C RID: 18444 RVA: 0x00164810 File Offset: 0x00162A10
		[DoNotToLua]
		public ResourceComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ResourceComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x0016481C File Offset: 0x00162A1C
		private void __callDele_MonthCardValidEvent(int obj)
		{
			Action<int> monthCardValidEvent = this.MonthCardValidEvent;
			if (monthCardValidEvent != null)
			{
				monthCardValidEvent(obj);
			}
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x00164840 File Offset: 0x00162A40
		private void __clearDele_MonthCardValidEvent(int obj)
		{
			this.MonthCardValidEvent = null;
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x0016484C File Offset: 0x00162A4C
		private void __callDele_MonthCardInvalidEvent(int obj)
		{
			Action<int> monthCardInvalidEvent = this.MonthCardInvalidEvent;
			if (monthCardInvalidEvent != null)
			{
				monthCardInvalidEvent(obj);
			}
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x00164870 File Offset: 0x00162A70
		private void __clearDele_MonthCardInvalidEvent(int obj)
		{
			this.MonthCardInvalidEvent = null;
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x0016487C File Offset: 0x00162A7C
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_EffectValidMonthCard_hotfix = (luaObj.RawGet("EffectValidMonthCard") as LuaFunction);
					this.m_GetAllValidMonthCards_hotfix = (luaObj.RawGet("GetAllValidMonthCards") as LuaFunction);
					this.m_AddMonthCardInt32DateTimeString_hotfix = (luaObj.RawGet("AddMonthCard") as LuaFunction);
					this.m_RemoveMonthCardInt32_hotfix = (luaObj.RawGet("RemoveMonthCard") as LuaFunction);
					this.m_FindMonthCardByIdInt32_hotfix = (luaObj.RawGet("FindMonthCardById") as LuaFunction);
					this.m_IsMonthCardVaildInt32_hotfix = (luaObj.RawGet("IsMonthCardVaild") as LuaFunction);
					this.m_OnMonthCardValidInt32_hotfix = (luaObj.RawGet("OnMonthCardValid") as LuaFunction);
					this.m_OnMonthCardInvalidInt32_hotfix = (luaObj.RawGet("OnMonthCardInvalid") as LuaFunction);
					this.m_HasHeadFrameIdInt32_hotfix = (luaObj.RawGet("HasHeadFrameId") as LuaFunction);
					this.m_AddHeadFrameInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddHeadFrame") as LuaFunction);
					this.m_AddHeroSkinInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddHeroSkin") as LuaFunction);
					this.m_AddSoldierSkinInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddSoldierSkin") as LuaFunction);
					this.m_HasOwnGoodsTypeInt32_hotfix = (luaObj.RawGet("HasOwn") as LuaFunction);
					this.m_OnCreateBagItemEventCallBackBagItemBase_hotfix = (luaObj.RawGet("OnCreateBagItemEventCallBack") as LuaFunction);
					this.m_AddEquipmentIdInt32_hotfix = (luaObj.RawGet("AddEquipmentId") as LuaFunction);
					this.m_add_MonthCardValidEventAction`1_hotfix = (luaObj.RawGet("add_MonthCardValidEvent") as LuaFunction);
					this.m_remove_MonthCardValidEventAction`1_hotfix = (luaObj.RawGet("remove_MonthCardValidEvent") as LuaFunction);
					this.m_add_MonthCardInvalidEventAction`1_hotfix = (luaObj.RawGet("add_MonthCardInvalidEvent") as LuaFunction);
					this.m_remove_MonthCardInvalidEventAction`1_hotfix = (luaObj.RawGet("remove_MonthCardInvalidEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x00164C1C File Offset: 0x00162E1C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ResourceComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003670 RID: 13936
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003671 RID: 13937
		protected DataSectionResource m_resourceDS = new DataSectionResource();

		// Token: 0x04003672 RID: 13938
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003673 RID: 13939
		protected BagComponentCommon m_bag;

		// Token: 0x04003676 RID: 13942
		[DoNotToLua]
		private ResourceComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04003677 RID: 13943
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003678 RID: 13944
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003679 RID: 13945
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400367A RID: 13946
		private LuaFunction m_GetName_hotfix;

		// Token: 0x0400367B RID: 13947
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400367C RID: 13948
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400367D RID: 13949
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400367E RID: 13950
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x0400367F RID: 13951
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003680 RID: 13952
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003681 RID: 13953
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003682 RID: 13954
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003683 RID: 13955
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003684 RID: 13956
		private LuaFunction m_EffectValidMonthCard_hotfix;

		// Token: 0x04003685 RID: 13957
		private LuaFunction m_GetAllValidMonthCards_hotfix;

		// Token: 0x04003686 RID: 13958
		private LuaFunction m_AddMonthCardInt32DateTimeString_hotfix;

		// Token: 0x04003687 RID: 13959
		private LuaFunction m_RemoveMonthCardInt32_hotfix;

		// Token: 0x04003688 RID: 13960
		private LuaFunction m_FindMonthCardByIdInt32_hotfix;

		// Token: 0x04003689 RID: 13961
		private LuaFunction m_IsMonthCardVaildInt32_hotfix;

		// Token: 0x0400368A RID: 13962
		private LuaFunction m_OnMonthCardValidInt32_hotfix;

		// Token: 0x0400368B RID: 13963
		private LuaFunction m_OnMonthCardInvalidInt32_hotfix;

		// Token: 0x0400368C RID: 13964
		private LuaFunction m_HasHeadFrameIdInt32_hotfix;

		// Token: 0x0400368D RID: 13965
		private LuaFunction m_AddHeadFrameInt32GameFunctionTypeString_hotfix;

		// Token: 0x0400368E RID: 13966
		private LuaFunction m_AddHeroSkinInt32GameFunctionTypeString_hotfix;

		// Token: 0x0400368F RID: 13967
		private LuaFunction m_AddSoldierSkinInt32GameFunctionTypeString_hotfix;

		// Token: 0x04003690 RID: 13968
		private LuaFunction m_HasOwnGoodsTypeInt32_hotfix;

		// Token: 0x04003691 RID: 13969
		private LuaFunction m_OnCreateBagItemEventCallBackBagItemBase_hotfix;

		// Token: 0x04003692 RID: 13970
		private LuaFunction m_AddEquipmentIdInt32_hotfix;

		// Token: 0x04003693 RID: 13971
		private LuaFunction m_add_MonthCardValidEventAction;

		// Token: 0x04003694 RID: 13972
		private LuaFunction m_remove_MonthCardValidEventAction;

		// Token: 0x04003695 RID: 13973
		private LuaFunction m_add_MonthCardInvalidEventAction;

		// Token: 0x04003696 RID: 13974
		private LuaFunction m_remove_MonthCardInvalidEventAction;

		// Token: 0x020004A5 RID: 1189
		public class LuaExportHelper
		{
			// Token: 0x06004813 RID: 18451 RVA: 0x00164C84 File Offset: 0x00162E84
			public LuaExportHelper(ResourceComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06004814 RID: 18452 RVA: 0x00164C94 File Offset: 0x00162E94
			public void __callDele_MonthCardValidEvent(int obj)
			{
				this.m_owner.__callDele_MonthCardValidEvent(obj);
			}

			// Token: 0x06004815 RID: 18453 RVA: 0x00164CA4 File Offset: 0x00162EA4
			public void __clearDele_MonthCardValidEvent(int obj)
			{
				this.m_owner.__clearDele_MonthCardValidEvent(obj);
			}

			// Token: 0x06004816 RID: 18454 RVA: 0x00164CB4 File Offset: 0x00162EB4
			public void __callDele_MonthCardInvalidEvent(int obj)
			{
				this.m_owner.__callDele_MonthCardInvalidEvent(obj);
			}

			// Token: 0x06004817 RID: 18455 RVA: 0x00164CC4 File Offset: 0x00162EC4
			public void __clearDele_MonthCardInvalidEvent(int obj)
			{
				this.m_owner.__clearDele_MonthCardInvalidEvent(obj);
			}

			// Token: 0x17001209 RID: 4617
			// (get) Token: 0x06004818 RID: 18456 RVA: 0x00164CD4 File Offset: 0x00162ED4
			// (set) Token: 0x06004819 RID: 18457 RVA: 0x00164CE4 File Offset: 0x00162EE4
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x1700120A RID: 4618
			// (get) Token: 0x0600481A RID: 18458 RVA: 0x00164CF4 File Offset: 0x00162EF4
			// (set) Token: 0x0600481B RID: 18459 RVA: 0x00164D04 File Offset: 0x00162F04
			public DataSectionResource m_resourceDS
			{
				get
				{
					return this.m_owner.m_resourceDS;
				}
				set
				{
					this.m_owner.m_resourceDS = value;
				}
			}

			// Token: 0x1700120B RID: 4619
			// (get) Token: 0x0600481C RID: 18460 RVA: 0x00164D14 File Offset: 0x00162F14
			// (set) Token: 0x0600481D RID: 18461 RVA: 0x00164D24 File Offset: 0x00162F24
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x1700120C RID: 4620
			// (get) Token: 0x0600481E RID: 18462 RVA: 0x00164D34 File Offset: 0x00162F34
			// (set) Token: 0x0600481F RID: 18463 RVA: 0x00164D44 File Offset: 0x00162F44
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x06004820 RID: 18464 RVA: 0x00164D54 File Offset: 0x00162F54
			public void EffectValidMonthCard()
			{
				this.m_owner.EffectValidMonthCard();
			}

			// Token: 0x06004821 RID: 18465 RVA: 0x00164D64 File Offset: 0x00162F64
			public void OnMonthCardValid(int monthCardId)
			{
				this.m_owner.OnMonthCardValid(monthCardId);
			}

			// Token: 0x06004822 RID: 18466 RVA: 0x00164D74 File Offset: 0x00162F74
			public void OnMonthCardInvalid(int monthCardId)
			{
				this.m_owner.OnMonthCardInvalid(monthCardId);
			}

			// Token: 0x06004823 RID: 18467 RVA: 0x00164D84 File Offset: 0x00162F84
			public void OnCreateBagItemEventCallBack(BagItemBase bagItem)
			{
				this.m_owner.OnCreateBagItemEventCallBack(bagItem);
			}

			// Token: 0x06004824 RID: 18468 RVA: 0x00164D94 File Offset: 0x00162F94
			public void AddEquipmentId(int equipmentId)
			{
				this.m_owner.AddEquipmentId(equipmentId);
			}

			// Token: 0x04003697 RID: 13975
			private ResourceComponentCommon m_owner;
		}
	}
}
