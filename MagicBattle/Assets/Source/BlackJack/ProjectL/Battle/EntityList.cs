using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003C2 RID: 962
	[HotFix]
	public class EntityList
	{
		// Token: 0x0600397D RID: 14717 RVA: 0x00106A4C File Offset: 0x00104C4C
		public EntityList()
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

		// Token: 0x0600397E RID: 14718 RVA: 0x00106AB4 File Offset: 0x00104CB4
		public static void RemoveAll<T>(List<T> list) where T : Entity
		{
			foreach (T t in list)
			{
				t.Dispose();
			}
			list.Clear();
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00106B18 File Offset: 0x00104D18
		public static void Tick<T>(List<T> list) where T : Entity
		{
			for (int i = 0; i < list.Count; i++)
			{
				T t = list[i];
				if (!t.IsDeleteMe && !t.IsPaused)
				{
					t.Tick();
				}
			}
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x00106B78 File Offset: 0x00104D78
		public static void RemoveDeleted<T>(List<T> list) where T : Entity
		{
			int i = 0;
			while (i < list.Count)
			{
				T t = list[i];
				if (t.IsDeleteMe)
				{
					list.RemoveAt(i);
					t.Dispose();
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x00106BD0 File Offset: 0x00104DD0
		public static void TickGraphic<T>(List<T> list, float dt) where T : Entity
		{
			foreach (T t in list)
			{
				if (!t.IsDeleteMe)
				{
					t.TickGraphic(dt);
				}
			}
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x00106C40 File Offset: 0x00104E40
		public static void Draw<T>(List<T> list) where T : Entity
		{
			foreach (T t in list)
			{
				if (!t.IsDeleteMe)
				{
					t.Draw();
				}
			}
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00106CB0 File Offset: 0x00104EB0
		public static void Pause<T>(List<T> list, bool pause) where T : Entity
		{
			foreach (T t in list)
			{
				if (!t.IsDeleteMe)
				{
					t.Pause(pause);
				}
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06003984 RID: 14724 RVA: 0x00106D20 File Offset: 0x00104F20
		// (set) Token: 0x06003985 RID: 14725 RVA: 0x00106D40 File Offset: 0x00104F40
		[DoNotToLua]
		public EntityList.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EntityList.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x00106D4C File Offset: 0x00104F4C
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

		// Token: 0x06003987 RID: 14727 RVA: 0x00106E18 File Offset: 0x00105018
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EntityList));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002C2F RID: 11311
		[DoNotToLua]
		private EntityList.LuaExportHelper luaExportHelper;

		// Token: 0x04002C30 RID: 11312
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002C31 RID: 11313
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002C32 RID: 11314
		private LuaFunction m_ctor_hotfix;

		// Token: 0x020003C3 RID: 963
		public class LuaExportHelper
		{
			// Token: 0x06003988 RID: 14728 RVA: 0x00106E80 File Offset: 0x00105080
			public LuaExportHelper(EntityList owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002C33 RID: 11315
			private EntityList m_owner;
		}
	}
}
