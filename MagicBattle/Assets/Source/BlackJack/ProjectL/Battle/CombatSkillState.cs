using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003B9 RID: 953
	[HotFix]
	public class CombatSkillState
	{
		// Token: 0x06003894 RID: 14484 RVA: 0x00100DF4 File Offset: 0x000FEFF4
		public CombatSkillState()
		{
			this.m_delayHits = new List<DelayHit>();
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

		// Token: 0x06003895 RID: 14485 RVA: 0x00100E68 File Offset: 0x000FF068
		public void AddDelayHit(int frame, Vector2i pos, CombatActor target)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddDelayHitInt32Vector2iCombatActor_hotfix != null)
			{
				this.m_AddDelayHitInt32Vector2iCombatActor_hotfix.call(new object[]
				{
					this,
					frame,
					pos,
					target
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hitCount >= this.m_skillInfo.HitCountMax)
			{
				return;
			}
			int index = 0;
			for (int i = this.m_delayHits.Count - 1; i >= 0; i--)
			{
				if (this.m_delayHits[i].m_frame <= frame)
				{
					index = i + 1;
					break;
				}
			}
			DelayHit item = default(DelayHit);
			item.m_frame = frame;
			item.m_position = pos;
			item.m_targetActor = target;
			this.m_delayHits.Insert(index, item);
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x00100F80 File Offset: 0x000FF180
		public int GetDelayHitFrameMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDelayHitFrameMax_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDelayHitFrameMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_delayHits == null || this.m_delayHits.Count <= 0)
			{
				return -1;
			}
			return this.m_delayHits[this.m_delayHits.Count - 1].m_frame;
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x0010102C File Offset: 0x000FF22C
		public bool IsCritical(bool targetIsHero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCriticalBoolean_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCriticalBoolean_hotfix.call(new object[]
				{
					this,
					targetIsHero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (targetIsHero)
			{
				return this.m_isToHeroCritical;
			}
			return this.m_isToSoldierCritical;
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x001010BC File Offset: 0x000FF2BC
		// (set) Token: 0x06003899 RID: 14489 RVA: 0x001010DC File Offset: 0x000FF2DC
		[DoNotToLua]
		public CombatSkillState.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CombatSkillState.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600389A RID: 14490 RVA: 0x001010E8 File Offset: 0x000FF2E8
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
					this.m_AddDelayHitInt32Vector2iCombatActor_hotfix = (luaObj.RawGet("AddDelayHit") as LuaFunction);
					this.m_GetDelayHitFrameMax_hotfix = (luaObj.RawGet("GetDelayHitFrameMax") as LuaFunction);
					this.m_IsCriticalBoolean_hotfix = (luaObj.RawGet("IsCritical") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600389B RID: 14491 RVA: 0x00101200 File Offset: 0x000FF400
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CombatSkillState));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002B81 RID: 11137
		public ConfigDataSkillInfo m_skillInfo;

		// Token: 0x04002B82 RID: 11138
		public ushort m_hitId;

		// Token: 0x04002B83 RID: 11139
		public int m_hitCount;

		// Token: 0x04002B84 RID: 11140
		public int m_preAttackHitCount;

		// Token: 0x04002B85 RID: 11141
		public List<DelayHit> m_delayHits;

		// Token: 0x04002B86 RID: 11142
		public bool m_isToHeroCritical;

		// Token: 0x04002B87 RID: 11143
		public bool m_isToSoldierCritical;

		// Token: 0x04002B88 RID: 11144
		[DoNotToLua]
		private CombatSkillState.LuaExportHelper luaExportHelper;

		// Token: 0x04002B89 RID: 11145
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002B8A RID: 11146
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002B8B RID: 11147
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002B8C RID: 11148
		private LuaFunction m_AddDelayHitInt32Vector2iCombatActor_hotfix;

		// Token: 0x04002B8D RID: 11149
		private LuaFunction m_GetDelayHitFrameMax_hotfix;

		// Token: 0x04002B8E RID: 11150
		private LuaFunction m_IsCriticalBoolean_hotfix;

		// Token: 0x020003BA RID: 954
		public class LuaExportHelper
		{
			// Token: 0x0600389C RID: 14492 RVA: 0x00101268 File Offset: 0x000FF468
			public LuaExportHelper(CombatSkillState owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002B8F RID: 11151
			private CombatSkillState m_owner;
		}
	}
}
