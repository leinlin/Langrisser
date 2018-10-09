using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A97 RID: 2711
	[HotFix]
	public class BattlePrepareTreasure
	{
		// Token: 0x0600ACA1 RID: 44193 RVA: 0x002FFE2C File Offset: 0x002FE02C
		public BattlePrepareTreasure()
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

		// Token: 0x0600ACA2 RID: 44194 RVA: 0x002FFE94 File Offset: 0x002FE094
		public void Initialize(ClientBattle clientBattle, ConfigDataBattleTreasureInfo treasureInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeClientBattleConfigDataBattleTreasureInfo_hotfix != null)
			{
				this.m_InitializeClientBattleConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					clientBattle,
					treasureInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle = clientBattle;
			this.m_battleTreasureInfo = treasureInfo;
			if (treasureInfo.ModelPosition.Count > 0)
			{
				this.m_position.x = treasureInfo.ModelPosition[0].X;
				this.m_position.y = treasureInfo.ModelPosition[0].Y;
			}
			this.m_graphic = clientBattle.CreateBattleGraphic(treasureInfo.Model, (float)treasureInfo.ModelScale * 0.01f);
			if (this.m_graphic != null)
			{
				this.m_graphic.SetParent(this.m_clientBattle.MapTreasureRoot);
				this.m_graphic.SetName("Treasure_" + treasureInfo.ID);
				Vector2 p = this.m_clientBattle.GridPositionToWorldPosition(this.m_position);
				this.m_graphic.SetPosition(this.ComputeGraphicPosition(p, 1f));
			}
		}

		// Token: 0x0600ACA3 RID: 44195 RVA: 0x002FFFF4 File Offset: 0x002FE1F4
		public ConfigDataBattleTreasureInfo GetBattleTreasureInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleTreasureInfo_hotfix != null)
			{
				return (ConfigDataBattleTreasureInfo)this.m_GetBattleTreasureInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleTreasureInfo;
		}

		// Token: 0x0600ACA4 RID: 44196 RVA: 0x00300068 File Offset: 0x002FE268
		public void Destroy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Destroy_hotfix != null)
			{
				this.m_Destroy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				this.m_clientBattle.DestroyBattleGraphic(this.m_graphic);
				this.m_graphic = null;
			}
		}

		// Token: 0x0600ACA5 RID: 44197 RVA: 0x003000EC File Offset: 0x002FE2EC
		private Vector3 ComputeGraphicPosition(Vector2 p, float zoffset)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeGraphicPositionVector2Single_hotfix != null)
			{
				return (Vector3)this.m_ComputeGraphicPositionVector2Single_hotfix.call(new object[]
				{
					this,
					p,
					zoffset
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new Vector3(p.x, p.y, p.y * 0.01f + zoffset);
		}

		// Token: 0x0600ACA6 RID: 44198 RVA: 0x0030019C File Offset: 0x002FE39C
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
			if (this.m_graphic != null)
			{
				this.m_graphic.Pause(pause);
			}
		}

		// Token: 0x0600ACA7 RID: 44199 RVA: 0x00300224 File Offset: 0x002FE424
		public void SetOpened(bool isOpened)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOpenedBoolean_hotfix != null)
			{
				this.m_SetOpenedBoolean_hotfix.call(new object[]
				{
					this,
					isOpened
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isOpened = isOpened;
			if (this.m_graphic != null)
			{
				this.m_graphic.PlayAnimation((!isOpened) ? "Standby" : "Opened", true);
			}
		}

		// Token: 0x0600ACA8 RID: 44200 RVA: 0x003002C8 File Offset: 0x002FE4C8
		public bool IsOpened()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOpened_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOpened_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isOpened;
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x0600ACA9 RID: 44201 RVA: 0x0030033C File Offset: 0x002FE53C
		// (set) Token: 0x0600ACAA RID: 44202 RVA: 0x0030035C File Offset: 0x002FE55C
		[DoNotToLua]
		public BattlePrepareTreasure.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattlePrepareTreasure.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600ACAB RID: 44203 RVA: 0x00300368 File Offset: 0x002FE568
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_InitializeClientBattleConfigDataBattleTreasureInfo_hotfix = (luaObj.RawGet("Initialize") as LuaFunction);
					this.m_GetBattleTreasureInfo_hotfix = (luaObj.RawGet("GetBattleTreasureInfo") as LuaFunction);
					this.m_Destroy_hotfix = (luaObj.RawGet("Destroy") as LuaFunction);
					this.m_ComputeGraphicPositionVector2Single_hotfix = (luaObj.RawGet("ComputeGraphicPosition") as LuaFunction);
					this.m_PauseBoolean_hotfix = (luaObj.RawGet("Pause") as LuaFunction);
					this.m_SetOpenedBoolean_hotfix = (luaObj.RawGet("SetOpened") as LuaFunction);
					this.m_IsOpened_hotfix = (luaObj.RawGet("IsOpened") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600ACAC RID: 44204 RVA: 0x003004E4 File Offset: 0x002FE6E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePrepareTreasure));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007108 RID: 28936
		private ClientBattle m_clientBattle;

		// Token: 0x04007109 RID: 28937
		private ConfigDataBattleTreasureInfo m_battleTreasureInfo;

		// Token: 0x0400710A RID: 28938
		private GenericGraphic m_graphic;

		// Token: 0x0400710B RID: 28939
		private GridPosition m_position;

		// Token: 0x0400710C RID: 28940
		private bool m_isOpened;

		// Token: 0x0400710D RID: 28941
		[DoNotToLua]
		private BattlePrepareTreasure.LuaExportHelper luaExportHelper;

		// Token: 0x0400710E RID: 28942
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400710F RID: 28943
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007110 RID: 28944
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04007111 RID: 28945
		private LuaFunction m_InitializeClientBattleConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x04007112 RID: 28946
		private LuaFunction m_GetBattleTreasureInfo_hotfix;

		// Token: 0x04007113 RID: 28947
		private LuaFunction m_Destroy_hotfix;

		// Token: 0x04007114 RID: 28948
		private LuaFunction m_ComputeGraphicPositionVector2Single_hotfix;

		// Token: 0x04007115 RID: 28949
		private LuaFunction m_PauseBoolean_hotfix;

		// Token: 0x04007116 RID: 28950
		private LuaFunction m_SetOpenedBoolean_hotfix;

		// Token: 0x04007117 RID: 28951
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x02000A98 RID: 2712
		public class LuaExportHelper
		{
			// Token: 0x0600ACAD RID: 44205 RVA: 0x0030054C File Offset: 0x002FE74C
			public LuaExportHelper(BattlePrepareTreasure owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x1700231B RID: 8987
			// (get) Token: 0x0600ACAE RID: 44206 RVA: 0x0030055C File Offset: 0x002FE75C
			// (set) Token: 0x0600ACAF RID: 44207 RVA: 0x0030056C File Offset: 0x002FE76C
			public ClientBattle m_clientBattle
			{
				get
				{
					return this.m_owner.m_clientBattle;
				}
				set
				{
					this.m_owner.m_clientBattle = value;
				}
			}

			// Token: 0x1700231C RID: 8988
			// (get) Token: 0x0600ACB0 RID: 44208 RVA: 0x0030057C File Offset: 0x002FE77C
			// (set) Token: 0x0600ACB1 RID: 44209 RVA: 0x0030058C File Offset: 0x002FE78C
			public ConfigDataBattleTreasureInfo m_battleTreasureInfo
			{
				get
				{
					return this.m_owner.m_battleTreasureInfo;
				}
				set
				{
					this.m_owner.m_battleTreasureInfo = value;
				}
			}

			// Token: 0x1700231D RID: 8989
			// (get) Token: 0x0600ACB2 RID: 44210 RVA: 0x0030059C File Offset: 0x002FE79C
			// (set) Token: 0x0600ACB3 RID: 44211 RVA: 0x003005AC File Offset: 0x002FE7AC
			public GenericGraphic m_graphic
			{
				get
				{
					return this.m_owner.m_graphic;
				}
				set
				{
					this.m_owner.m_graphic = value;
				}
			}

			// Token: 0x1700231E RID: 8990
			// (get) Token: 0x0600ACB4 RID: 44212 RVA: 0x003005BC File Offset: 0x002FE7BC
			// (set) Token: 0x0600ACB5 RID: 44213 RVA: 0x003005CC File Offset: 0x002FE7CC
			public GridPosition m_position
			{
				get
				{
					return this.m_owner.m_position;
				}
				set
				{
					this.m_owner.m_position = value;
				}
			}

			// Token: 0x1700231F RID: 8991
			// (get) Token: 0x0600ACB6 RID: 44214 RVA: 0x003005DC File Offset: 0x002FE7DC
			// (set) Token: 0x0600ACB7 RID: 44215 RVA: 0x003005EC File Offset: 0x002FE7EC
			public bool m_isOpened
			{
				get
				{
					return this.m_owner.m_isOpened;
				}
				set
				{
					this.m_owner.m_isOpened = value;
				}
			}

			// Token: 0x0600ACB8 RID: 44216 RVA: 0x003005FC File Offset: 0x002FE7FC
			public Vector3 ComputeGraphicPosition(Vector2 p, float zoffset)
			{
				return this.m_owner.ComputeGraphicPosition(p, zoffset);
			}

			// Token: 0x04007118 RID: 28952
			private BattlePrepareTreasure m_owner;
		}
	}
}
