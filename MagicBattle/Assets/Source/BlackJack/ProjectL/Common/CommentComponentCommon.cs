using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200043C RID: 1084
	[HotFix]
	public class CommentComponentCommon : IComponentBase
	{
		// Token: 0x06003F95 RID: 16277 RVA: 0x00126FAC File Offset: 0x001251AC
		public CommentComponentCommon()
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

		// Token: 0x06003F96 RID: 16278 RVA: 0x00127014 File Offset: 0x00125214
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
			return "Comment";
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00127088 File Offset: 0x00125288
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
			this.m_commentDS = new DataSectionComment();
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x001270F4 File Offset: 0x001252F4
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
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x0012718C File Offset: 0x0012538C
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

		// Token: 0x06003F9A RID: 16282 RVA: 0x001271EC File Offset: 0x001253EC
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

		// Token: 0x06003F9B RID: 16283 RVA: 0x0012725C File Offset: 0x0012545C
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

		// Token: 0x06003F9C RID: 16284 RVA: 0x001272DC File Offset: 0x001254DC
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

		// Token: 0x06003F9D RID: 16285 RVA: 0x0012734C File Offset: 0x0012554C
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

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06003F9E RID: 16286 RVA: 0x001273AC File Offset: 0x001255AC
		// (set) Token: 0x06003F9F RID: 16287 RVA: 0x00127420 File Offset: 0x00125620
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

		// Token: 0x06003FA0 RID: 16288 RVA: 0x00127498 File Offset: 0x00125698
		public int CanCommentHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanCommentHeroInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanCommentHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_hero.HasGainHero(heroId))
			{
				return -1701;
			}
			PlayerHeroCommentEntry playerHeroCommentEntry = this.m_commentDS.FindPlayerHeroCommentEntry(heroId);
			if (playerHeroCommentEntry == null)
			{
				return 0;
			}
			return (playerHeroCommentEntry.CommentedNums >= this.m_configDataLoader.ConfigableConstId_PlayerSingleHeroCommentMaxNums) ? -1700 : 0;
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00127564 File Offset: 0x00125764
		public int CanPraiseHeroCommentEntry(int heroId, ulong entryInstanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanPraiseHeroCommentEntryInt32UInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanPraiseHeroCommentEntryInt32UInt64_hotfix.call(new object[]
				{
					this,
					heroId,
					entryInstanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_hero.HasGainHero(heroId))
			{
				return -1701;
			}
			PlayerHeroCommentEntry playerHeroCommentEntry = this.m_commentDS.FindPlayerHeroCommentEntry(heroId);
			if (playerHeroCommentEntry == null)
			{
				return 0;
			}
			return (!playerHeroCommentEntry.PraisedEntryInstanceIds.Contains(entryInstanceId)) ? 0 : -1702;
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x00127638 File Offset: 0x00125838
		public int CanGetHeroComment(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGetHeroCommentInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGetHeroCommentInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.m_hero.HasGainHero(heroId)) ? -1701 : 0;
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x001276D0 File Offset: 0x001258D0
		public int CanViewPlayerHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanViewPlayerHeroInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanViewPlayerHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.m_hero.HasGainHero(heroId)) ? -1701 : 0;
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x00127768 File Offset: 0x00125968
		public bool IsNeedTruncateHeroComment(string content)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedTruncateHeroCommentString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedTruncateHeroCommentString_hotfix.call(new object[]
				{
					this,
					content
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return content.Length > this.m_configDataLoader.ConfigableConstId_HeroCommentMaxLength;
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x001277F8 File Offset: 0x001259F8
		public string TruncateHeroComment(string content)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TruncateHeroCommentString_hotfix != null)
			{
				return (string)this.m_TruncateHeroCommentString_hotfix.call(new object[]
				{
					this,
					content
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return content.Substring(0, this.m_configDataLoader.ConfigableConstId_HeroCommentMaxLength);
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00127888 File Offset: 0x00125A88
		public PlayerHeroCommentEntry FindPlayerHeroCommentEntry(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPlayerHeroCommentEntryInt32_hotfix != null)
			{
				return (PlayerHeroCommentEntry)this.m_FindPlayerHeroCommentEntryInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_commentDS.FindPlayerHeroCommentEntry(heroId);
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06003FA7 RID: 16295 RVA: 0x00127910 File Offset: 0x00125B10
		// (set) Token: 0x06003FA8 RID: 16296 RVA: 0x00127930 File Offset: 0x00125B30
		[DoNotToLua]
		public CommentComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CommentComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x0012793C File Offset: 0x00125B3C
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
					this.m_CanCommentHeroInt32_hotfix = (luaObj.RawGet("CanCommentHero") as LuaFunction);
					this.m_CanPraiseHeroCommentEntryInt32UInt64_hotfix = (luaObj.RawGet("CanPraiseHeroCommentEntry") as LuaFunction);
					this.m_CanGetHeroCommentInt32_hotfix = (luaObj.RawGet("CanGetHeroComment") as LuaFunction);
					this.m_CanViewPlayerHeroInt32_hotfix = (luaObj.RawGet("CanViewPlayerHero") as LuaFunction);
					this.m_IsNeedTruncateHeroCommentString_hotfix = (luaObj.RawGet("IsNeedTruncateHeroComment") as LuaFunction);
					this.m_TruncateHeroCommentString_hotfix = (luaObj.RawGet("TruncateHeroComment") as LuaFunction);
					this.m_FindPlayerHeroCommentEntryInt32_hotfix = (luaObj.RawGet("FindPlayerHeroCommentEntry") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x00127BB0 File Offset: 0x00125DB0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CommentComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003006 RID: 12294
		protected DataSectionComment m_commentDS;

		// Token: 0x04003007 RID: 12295
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003008 RID: 12296
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04003009 RID: 12297
		protected HeroComponentCommon m_hero;

		// Token: 0x0400300A RID: 12298
		[DoNotToLua]
		private CommentComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x0400300B RID: 12299
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400300C RID: 12300
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400300D RID: 12301
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400300E RID: 12302
		private LuaFunction m_GetName_hotfix;

		// Token: 0x0400300F RID: 12303
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003010 RID: 12304
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003011 RID: 12305
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003012 RID: 12306
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003013 RID: 12307
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003014 RID: 12308
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003015 RID: 12309
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003016 RID: 12310
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003017 RID: 12311
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003018 RID: 12312
		private LuaFunction m_CanCommentHeroInt32_hotfix;

		// Token: 0x04003019 RID: 12313
		private LuaFunction m_CanPraiseHeroCommentEntryInt32UInt64_hotfix;

		// Token: 0x0400301A RID: 12314
		private LuaFunction m_CanGetHeroCommentInt32_hotfix;

		// Token: 0x0400301B RID: 12315
		private LuaFunction m_CanViewPlayerHeroInt32_hotfix;

		// Token: 0x0400301C RID: 12316
		private LuaFunction m_IsNeedTruncateHeroCommentString_hotfix;

		// Token: 0x0400301D RID: 12317
		private LuaFunction m_TruncateHeroCommentString_hotfix;

		// Token: 0x0400301E RID: 12318
		private LuaFunction m_FindPlayerHeroCommentEntryInt32_hotfix;

		// Token: 0x0200043D RID: 1085
		public class LuaExportHelper
		{
			// Token: 0x06003FAB RID: 16299 RVA: 0x00127C18 File Offset: 0x00125E18
			public LuaExportHelper(CommentComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x1700110D RID: 4365
			// (get) Token: 0x06003FAC RID: 16300 RVA: 0x00127C28 File Offset: 0x00125E28
			// (set) Token: 0x06003FAD RID: 16301 RVA: 0x00127C38 File Offset: 0x00125E38
			public DataSectionComment m_commentDS
			{
				get
				{
					return this.m_owner.m_commentDS;
				}
				set
				{
					this.m_owner.m_commentDS = value;
				}
			}

			// Token: 0x1700110E RID: 4366
			// (get) Token: 0x06003FAE RID: 16302 RVA: 0x00127C48 File Offset: 0x00125E48
			// (set) Token: 0x06003FAF RID: 16303 RVA: 0x00127C58 File Offset: 0x00125E58
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

			// Token: 0x1700110F RID: 4367
			// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x00127C68 File Offset: 0x00125E68
			// (set) Token: 0x06003FB1 RID: 16305 RVA: 0x00127C78 File Offset: 0x00125E78
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

			// Token: 0x17001110 RID: 4368
			// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x00127C88 File Offset: 0x00125E88
			// (set) Token: 0x06003FB3 RID: 16307 RVA: 0x00127C98 File Offset: 0x00125E98
			public HeroComponentCommon m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x0400301F RID: 12319
			private CommentComponentCommon m_owner;
		}
	}
}
