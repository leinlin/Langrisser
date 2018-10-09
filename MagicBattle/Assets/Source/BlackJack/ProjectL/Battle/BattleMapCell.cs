using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003A3 RID: 931
	[HotFix]
	public class BattleMapCell
	{
		// Token: 0x060036E7 RID: 14055 RVA: 0x000F3F64 File Offset: 0x000F2164
		public BattleMapCell()
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

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x000F3FCC File Offset: 0x000F21CC
		// (set) Token: 0x060036E9 RID: 14057 RVA: 0x000F3FEC File Offset: 0x000F21EC
		[DoNotToLua]
		public BattleMapCell.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleMapCell.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x000F3FF8 File Offset: 0x000F21F8
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

		// Token: 0x060036EB RID: 14059 RVA: 0x000F40C4 File Offset: 0x000F22C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleMapCell));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002A27 RID: 10791
		public ConfigDataTerrainInfo m_terrain;

		// Token: 0x04002A28 RID: 10792
		public BattleActor m_actor;

		// Token: 0x04002A29 RID: 10793
		public int m_region;

		// Token: 0x04002A2A RID: 10794
		[DoNotToLua]
		private BattleMapCell.LuaExportHelper luaExportHelper;

		// Token: 0x04002A2B RID: 10795
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002A2C RID: 10796
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002A2D RID: 10797
		private LuaFunction m_ctor_hotfix;

		// Token: 0x020003A4 RID: 932
		public class LuaExportHelper
		{
			// Token: 0x060036EC RID: 14060 RVA: 0x000F412C File Offset: 0x000F232C
			public LuaExportHelper(BattleMapCell owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002A2E RID: 10798
			private BattleMapCell m_owner;
		}
	}
}
