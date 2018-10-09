using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x02000380 RID: 896
	[HotFix]
	public class BehaviorTarget
	{
		// Token: 0x0600346D RID: 13421 RVA: 0x000DED88 File Offset: 0x000DCF88
		public BehaviorTarget(BattleActor actor)
		{
			this.m_actor = actor;
			this.m_pos = GridPosition.Null;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorBattleActor_hotfix != null)
			{
				this.m_ctorBattleActor_hotfix.call(new object[]
				{
					this,
					actor
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x000DEE1C File Offset: 0x000DD01C
		public BehaviorTarget(GridPosition pos)
		{
			this.m_pos = pos;
			this.m_actor = null;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorGridPosition_hotfix != null)
			{
				this.m_ctorGridPosition_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x000DEEAC File Offset: 0x000DD0AC
		public GridPosition Position
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Position_hotfix != null)
				{
					return (GridPosition)this.m_get_Position_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				if (this.m_actor != null)
				{
					return this.m_actor.Position;
				}
				return this.m_pos;
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x000DEF38 File Offset: 0x000DD138
		public BattleActor Actor
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Actor_hotfix != null)
				{
					return (BattleActor)this.m_get_Actor_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_actor;
			}
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x000DEFAC File Offset: 0x000DD1AC
		public bool IsEmpty()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEmpty_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEmpty_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_pos.Equals(GridPosition.Null) && this.m_actor == null;
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x000DF044 File Offset: 0x000DD244
		public override string ToString()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ToString_hotfix != null)
			{
				return (string)this.m_ToString_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_actor != null)
			{
				return this.m_actor.InstanceID;
			}
			if (this.m_pos != GridPosition.Null)
			{
				return this.m_pos.ToString();
			}
			return "Null";
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x000DF0F4 File Offset: 0x000DD2F4
		// (set) Token: 0x06003474 RID: 13428 RVA: 0x000DF114 File Offset: 0x000DD314
		[DoNotToLua]
		public BehaviorTarget.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BehaviorTarget.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x000DF120 File Offset: 0x000DD320
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
					this.m_ctorBattleActor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_ctorGridPosition_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_get_Position_hotfix = (luaObj.RawGet("get_Position") as LuaFunction);
					this.m_get_Actor_hotfix = (luaObj.RawGet("get_Actor") as LuaFunction);
					this.m_IsEmpty_hotfix = (luaObj.RawGet("IsEmpty") as LuaFunction);
					this.m_ToString_hotfix = (luaObj.RawGet("ToString") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x000DF268 File Offset: 0x000DD468
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BehaviorTarget));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002818 RID: 10264
		private GridPosition m_pos = GridPosition.Null;

		// Token: 0x04002819 RID: 10265
		private BattleActor m_actor;

		// Token: 0x0400281A RID: 10266
		[DoNotToLua]
		private BehaviorTarget.LuaExportHelper luaExportHelper;

		// Token: 0x0400281B RID: 10267
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400281C RID: 10268
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400281D RID: 10269
		private LuaFunction m_ctorBattleActor_hotfix;

		// Token: 0x0400281E RID: 10270
		private LuaFunction m_ctorGridPosition_hotfix;

		// Token: 0x0400281F RID: 10271
		private LuaFunction m_get_Position_hotfix;

		// Token: 0x04002820 RID: 10272
		private LuaFunction m_get_Actor_hotfix;

		// Token: 0x04002821 RID: 10273
		private LuaFunction m_IsEmpty_hotfix;

		// Token: 0x04002822 RID: 10274
		private LuaFunction m_ToString_hotfix;

		// Token: 0x02000381 RID: 897
		public class LuaExportHelper
		{
			// Token: 0x06003477 RID: 13431 RVA: 0x000DF2D0 File Offset: 0x000DD4D0
			public LuaExportHelper(BehaviorTarget owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000EB6 RID: 3766
			// (get) Token: 0x06003478 RID: 13432 RVA: 0x000DF2E0 File Offset: 0x000DD4E0
			// (set) Token: 0x06003479 RID: 13433 RVA: 0x000DF2F0 File Offset: 0x000DD4F0
			public GridPosition m_pos
			{
				get
				{
					return this.m_owner.m_pos;
				}
				set
				{
					this.m_owner.m_pos = value;
				}
			}

			// Token: 0x17000EB7 RID: 3767
			// (get) Token: 0x0600347A RID: 13434 RVA: 0x000DF300 File Offset: 0x000DD500
			// (set) Token: 0x0600347B RID: 13435 RVA: 0x000DF310 File Offset: 0x000DD510
			public BattleActor m_actor
			{
				get
				{
					return this.m_owner.m_actor;
				}
				set
				{
					this.m_owner.m_actor = value;
				}
			}

			// Token: 0x04002823 RID: 10275
			private BehaviorTarget m_owner;
		}
	}
}
