using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x02000383 RID: 899
	[HotFix]
	public class BuffState
	{
		// Token: 0x0600347C RID: 13436 RVA: 0x000DF320 File Offset: 0x000DD520
		public BuffState(int id, ConfigDataBuffInfo buffInfo, BattleActor applyer, BuffSourceType sourceType, ConfigDataSkillInfo sourceSkillInfo)
		{
			this.m_id = id;
			this.m_buffInfo = buffInfo;
			this.m_time = buffInfo.Time;
			this.m_applyer = applyer;
			this.m_sourceType = sourceType;
			this.m_sourceSkillInfo = sourceSkillInfo;
			this.m_parent = null;
			this.m_hasExtraTime = false;
			this.m_effectTimes = 0;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorInt32ConfigDataBuffInfoBattleActorBuffSourceTypeConfigDataSkillInfo_hotfix != null)
			{
				this.m_ctorInt32ConfigDataBuffInfoBattleActorBuffSourceTypeConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					id,
					buffInfo,
					applyer,
					sourceType,
					sourceSkillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x000DF41C File Offset: 0x000DD61C
		public bool IsChild()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsChild_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsChild_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_parent != null;
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x000DF494 File Offset: 0x000DD694
		public bool CanNotDispel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanNotDispel_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanNotDispel_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.m_buffInfo.IsDebuff && !this.m_buffInfo.IsEnhance) || this.m_buffInfo.IsInfiniteTime() || this.IsChild();
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x000DF544 File Offset: 0x000DD744
		// (set) Token: 0x06003480 RID: 13440 RVA: 0x000DF564 File Offset: 0x000DD764
		[DoNotToLua]
		public BuffState.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BuffState.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x000DF570 File Offset: 0x000DD770
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
					this.m_ctorInt32ConfigDataBuffInfoBattleActorBuffSourceTypeConfigDataSkillInfo_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_IsChild_hotfix = (luaObj.RawGet("IsChild") as LuaFunction);
					this.m_CanNotDispel_hotfix = (luaObj.RawGet("CanNotDispel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x000DF670 File Offset: 0x000DD870
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BuffState));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002835 RID: 10293
		public int m_id;

		// Token: 0x04002836 RID: 10294
		public int m_displayOrder;

		// Token: 0x04002837 RID: 10295
		public ConfigDataBuffInfo m_buffInfo;

		// Token: 0x04002838 RID: 10296
		public BuffSourceType m_sourceType;

		// Token: 0x04002839 RID: 10297
		public ConfigDataSkillInfo m_sourceSkillInfo;

		// Token: 0x0400283A RID: 10298
		public int m_time;

		// Token: 0x0400283B RID: 10299
		public int m_effectTimes;

		// Token: 0x0400283C RID: 10300
		public bool m_hasExtraTime;

		// Token: 0x0400283D RID: 10301
		public BattleActor m_applyer;

		// Token: 0x0400283E RID: 10302
		public BuffState m_parent;

		// Token: 0x0400283F RID: 10303
		[DoNotToLua]
		private BuffState.LuaExportHelper luaExportHelper;

		// Token: 0x04002840 RID: 10304
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002841 RID: 10305
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002842 RID: 10306
		private LuaFunction m_ctorInt32ConfigDataBuffInfoBattleActorBuffSourceTypeConfigDataSkillInfo_hotfix;

		// Token: 0x04002843 RID: 10307
		private LuaFunction m_IsChild_hotfix;

		// Token: 0x04002844 RID: 10308
		private LuaFunction m_CanNotDispel_hotfix;

		// Token: 0x02000384 RID: 900
		public class LuaExportHelper
		{
			// Token: 0x06003483 RID: 13443 RVA: 0x000DF6D8 File Offset: 0x000DD8D8
			public LuaExportHelper(BuffState owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002845 RID: 10309
			private BuffState m_owner;
		}
	}
}
