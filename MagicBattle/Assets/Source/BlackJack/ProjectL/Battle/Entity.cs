using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003C0 RID: 960
	[HotFix]
	public class Entity
	{
		// Token: 0x06003967 RID: 14695 RVA: 0x001062C8 File Offset: 0x001044C8
		public Entity()
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

		// Token: 0x06003968 RID: 14696 RVA: 0x00106330 File Offset: 0x00104530
		public virtual void Dispose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Dispose_hotfix != null)
			{
				this.m_Dispose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x00106390 File Offset: 0x00104590
		public virtual void Tick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Tick_hotfix != null)
			{
				this.m_Tick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x001063F0 File Offset: 0x001045F0
		public virtual void TickGraphic(float dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickGraphicSingle_hotfix != null)
			{
				this.m_TickGraphicSingle_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x00106460 File Offset: 0x00104660
		public virtual void Draw()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Draw_hotfix != null)
			{
				this.m_Draw_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x001064C0 File Offset: 0x001046C0
		public void Pause(bool pause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PauseBoolean_hotfix != null)
			{
				this.m_PauseBoolean_hotfix.call(new object[]
				{
					this,
					pause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (pause != this.m_isPaused)
			{
				this.m_isPaused = pause;
				this.DoPause(pause);
			}
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x0010654C File Offset: 0x0010474C
		public virtual void DoPause(bool pause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoPauseBoolean_hotfix != null)
			{
				this.m_DoPauseBoolean_hotfix.call(new object[]
				{
					this,
					pause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x0600396E RID: 14702 RVA: 0x001065BC File Offset: 0x001047BC
		public int Id
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Id_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Id_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_id;
			}
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x00106630 File Offset: 0x00104830
		public void DeleteMe()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeleteMe_hotfix != null)
			{
				this.m_DeleteMe_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isDeleteMe = true;
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06003970 RID: 14704 RVA: 0x00106698 File Offset: 0x00104898
		public bool IsDeleteMe
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsDeleteMe_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsDeleteMe_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_isDeleteMe;
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x0010670C File Offset: 0x0010490C
		public bool IsPaused
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsPaused_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsPaused_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_isPaused;
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06003972 RID: 14706 RVA: 0x00106780 File Offset: 0x00104980
		// (set) Token: 0x06003973 RID: 14707 RVA: 0x001067A0 File Offset: 0x001049A0
		[DoNotToLua]
		public Entity.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new Entity.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x001067AC File Offset: 0x001049AC
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
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_PauseBoolean_hotfix = (luaObj.RawGet("Pause") as LuaFunction);
					this.m_DoPauseBoolean_hotfix = (luaObj.RawGet("DoPause") as LuaFunction);
					this.m_get_Id_hotfix = (luaObj.RawGet("get_Id") as LuaFunction);
					this.m_DeleteMe_hotfix = (luaObj.RawGet("DeleteMe") as LuaFunction);
					this.m_get_IsDeleteMe_hotfix = (luaObj.RawGet("get_IsDeleteMe") as LuaFunction);
					this.m_get_IsPaused_hotfix = (luaObj.RawGet("get_IsPaused") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00106974 File Offset: 0x00104B74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(Entity));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002C1D RID: 11293
		private bool m_isDeleteMe;

		// Token: 0x04002C1E RID: 11294
		private bool m_isPaused;

		// Token: 0x04002C1F RID: 11295
		protected int m_id;

		// Token: 0x04002C20 RID: 11296
		[DoNotToLua]
		private Entity.LuaExportHelper luaExportHelper;

		// Token: 0x04002C21 RID: 11297
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002C22 RID: 11298
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002C23 RID: 11299
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002C24 RID: 11300
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04002C25 RID: 11301
		private LuaFunction m_Tick_hotfix;

		// Token: 0x04002C26 RID: 11302
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x04002C27 RID: 11303
		private LuaFunction m_Draw_hotfix;

		// Token: 0x04002C28 RID: 11304
		private LuaFunction m_PauseBoolean_hotfix;

		// Token: 0x04002C29 RID: 11305
		private LuaFunction m_DoPauseBoolean_hotfix;

		// Token: 0x04002C2A RID: 11306
		private LuaFunction m_get_Id_hotfix;

		// Token: 0x04002C2B RID: 11307
		private LuaFunction m_DeleteMe_hotfix;

		// Token: 0x04002C2C RID: 11308
		private LuaFunction m_get_IsDeleteMe_hotfix;

		// Token: 0x04002C2D RID: 11309
		private LuaFunction m_get_IsPaused_hotfix;

		// Token: 0x020003C1 RID: 961
		public class LuaExportHelper
		{
			// Token: 0x06003976 RID: 14710 RVA: 0x001069DC File Offset: 0x00104BDC
			public LuaExportHelper(Entity owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000FD0 RID: 4048
			// (get) Token: 0x06003977 RID: 14711 RVA: 0x001069EC File Offset: 0x00104BEC
			// (set) Token: 0x06003978 RID: 14712 RVA: 0x001069FC File Offset: 0x00104BFC
			public bool m_isDeleteMe
			{
				get
				{
					return this.m_owner.m_isDeleteMe;
				}
				set
				{
					this.m_owner.m_isDeleteMe = value;
				}
			}

			// Token: 0x17000FD1 RID: 4049
			// (get) Token: 0x06003979 RID: 14713 RVA: 0x00106A0C File Offset: 0x00104C0C
			// (set) Token: 0x0600397A RID: 14714 RVA: 0x00106A1C File Offset: 0x00104C1C
			public bool m_isPaused
			{
				get
				{
					return this.m_owner.m_isPaused;
				}
				set
				{
					this.m_owner.m_isPaused = value;
				}
			}

			// Token: 0x17000FD2 RID: 4050
			// (get) Token: 0x0600397B RID: 14715 RVA: 0x00106A2C File Offset: 0x00104C2C
			// (set) Token: 0x0600397C RID: 14716 RVA: 0x00106A3C File Offset: 0x00104C3C
			public int m_id
			{
				get
				{
					return this.m_owner.m_id;
				}
				set
				{
					this.m_owner.m_id = value;
				}
			}

			// Token: 0x04002C2E RID: 11310
			private Entity m_owner;
		}
	}
}
