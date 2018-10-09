using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200096C RID: 2412
	[HotFix]
	public class ClientBattleTreasure : Entity
	{
		// Token: 0x060089C3 RID: 35267 RVA: 0x00281C50 File Offset: 0x0027FE50
		public ClientBattleTreasure()
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

		// Token: 0x060089C4 RID: 35268 RVA: 0x00281CB8 File Offset: 0x0027FEB8
		public void Initialize(ClientBattle battle, ConfigDataBattleTreasureInfo treasureInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitializeClientBattleConfigDataBattleTreasureInfo_hotfix != null)
			{
				this.m_InitializeClientBattleConfigDataBattleTreasureInfo_hotfix.call(new object[]
				{
					this,
					battle,
					treasureInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_clientBattle = battle;
			this.m_battleTreasureInfo = treasureInfo;
			if (treasureInfo.ModelPosition.Count > 0)
			{
				this.m_position.x = treasureInfo.ModelPosition[0].X;
				this.m_position.y = treasureInfo.ModelPosition[0].Y;
			}
			this.m_graphic = battle.CreateBattleGraphic(treasureInfo.Model, (float)treasureInfo.ModelScale * 0.01f);
			if (this.m_graphic != null)
			{
				this.m_graphic.SetParent(this.m_clientBattle.MapTreasureRoot);
				this.m_graphic.SetName("Treasure_" + treasureInfo.ID);
				this.UpdateGraphicPosition(1f);
			}
			this.m_isOpened = false;
			this.m_isGraphicSkillFade = false;
		}

		// Token: 0x060089C5 RID: 35269 RVA: 0x00281E08 File Offset: 0x00280008
		public override void Dispose()
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
			if (this.m_graphic != null)
			{
				this.m_clientBattle.DestroyBattleGraphic(this.m_graphic);
				this.m_graphic = null;
			}
		}

		// Token: 0x060089C6 RID: 35270 RVA: 0x00281E8C File Offset: 0x0028008C
		public override void Tick()
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

		// Token: 0x060089C7 RID: 35271 RVA: 0x00281EEC File Offset: 0x002800EC
		private void UpdateGraphicPosition(float zoffset)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateGraphicPositionSingle_hotfix != null)
			{
				this.m_UpdateGraphicPositionSingle_hotfix.call(new object[]
				{
					this,
					zoffset
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphic != null)
			{
				if (this.m_isGraphicSkillFade)
				{
					zoffset += 30f;
				}
				Vector2 p = this.m_clientBattle.GridPositionToWorldPosition(this.m_position);
				this.m_graphic.SetPosition(this.ComputeGraphicPosition(p, zoffset));
			}
		}

		// Token: 0x060089C8 RID: 35272 RVA: 0x00281FA0 File Offset: 0x002801A0
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

		// Token: 0x060089C9 RID: 35273 RVA: 0x00282050 File Offset: 0x00280250
		public override void Draw()
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

		// Token: 0x060089CA RID: 35274 RVA: 0x002820B0 File Offset: 0x002802B0
		public override void DoPause(bool pause)
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
			if (this.m_graphic != null)
			{
				this.m_graphic.Pause(pause);
			}
		}

		// Token: 0x060089CB RID: 35275 RVA: 0x00282138 File Offset: 0x00280338
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
				this.UpdateGraphicPosition(1f);
			}
		}

		// Token: 0x060089CC RID: 35276 RVA: 0x002821E8 File Offset: 0x002803E8
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

		// Token: 0x060089CD RID: 35277 RVA: 0x0028225C File Offset: 0x0028045C
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isOpened = true;
			if (this.m_graphic != null)
			{
				this.m_graphic.PlayAnimation("Open", false);
				this.UpdateGraphicPosition(-1f);
			}
		}

		// Token: 0x060089CE RID: 35278 RVA: 0x002822EC File Offset: 0x002804EC
		public void SetGraphicSkillFade(bool fade)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGraphicSkillFadeBoolean_hotfix != null)
			{
				this.m_SetGraphicSkillFadeBoolean_hotfix.call(new object[]
				{
					this,
					fade
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (fade != this.m_isGraphicSkillFade)
			{
				this.m_isGraphicSkillFade = fade;
				this.UpdateGraphicPosition(1f);
			}
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x060089CF RID: 35279 RVA: 0x0028237C File Offset: 0x0028057C
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
				return this.m_position;
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x060089D0 RID: 35280 RVA: 0x002823F0 File Offset: 0x002805F0
		public ConfigDataBattleTreasureInfo BattleTreasureInfo
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BattleTreasureInfo_hotfix != null)
				{
					return (ConfigDataBattleTreasureInfo)this.m_get_BattleTreasureInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_battleTreasureInfo;
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x060089D1 RID: 35281 RVA: 0x00282464 File Offset: 0x00280664
		// (set) Token: 0x060089D2 RID: 35282 RVA: 0x00282484 File Offset: 0x00280684
		[DoNotToLua]
		public new ClientBattleTreasure.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClientBattleTreasure.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060089D3 RID: 35283 RVA: 0x00282490 File Offset: 0x00280690
		private void __callBase_Dispose()
		{
			base.Dispose();
		}

		// Token: 0x060089D4 RID: 35284 RVA: 0x00282498 File Offset: 0x00280698
		private void __callBase_Tick()
		{
			base.Tick();
		}

		// Token: 0x060089D5 RID: 35285 RVA: 0x002824A0 File Offset: 0x002806A0
		private void __callBase_TickGraphic(float dt)
		{
			base.TickGraphic(dt);
		}

		// Token: 0x060089D6 RID: 35286 RVA: 0x002824AC File Offset: 0x002806AC
		private void __callBase_Draw()
		{
			base.Draw();
		}

		// Token: 0x060089D7 RID: 35287 RVA: 0x002824B4 File Offset: 0x002806B4
		private void __callBase_Pause(bool pause)
		{
			base.Pause(pause);
		}

		// Token: 0x060089D8 RID: 35288 RVA: 0x002824C0 File Offset: 0x002806C0
		private void __callBase_DoPause(bool pause)
		{
			base.DoPause(pause);
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x002824CC File Offset: 0x002806CC
		private void __callBase_DeleteMe()
		{
			base.DeleteMe();
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x002824D4 File Offset: 0x002806D4
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
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_UpdateGraphicPositionSingle_hotfix = (luaObj.RawGet("UpdateGraphicPosition") as LuaFunction);
					this.m_ComputeGraphicPositionVector2Single_hotfix = (luaObj.RawGet("ComputeGraphicPosition") as LuaFunction);
					this.m_Draw_hotfix = (luaObj.RawGet("Draw") as LuaFunction);
					this.m_DoPauseBoolean_hotfix = (luaObj.RawGet("DoPause") as LuaFunction);
					this.m_SetOpenedBoolean_hotfix = (luaObj.RawGet("SetOpened") as LuaFunction);
					this.m_IsOpened_hotfix = (luaObj.RawGet("IsOpened") as LuaFunction);
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_SetGraphicSkillFadeBoolean_hotfix = (luaObj.RawGet("SetGraphicSkillFade") as LuaFunction);
					this.m_get_Position_hotfix = (luaObj.RawGet("get_Position") as LuaFunction);
					this.m_get_BattleTreasureInfo_hotfix = (luaObj.RawGet("get_BattleTreasureInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x002826E4 File Offset: 0x002808E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientBattleTreasure));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400625A RID: 25178
		private ClientBattle m_clientBattle;

		// Token: 0x0400625B RID: 25179
		private ConfigDataBattleTreasureInfo m_battleTreasureInfo;

		// Token: 0x0400625C RID: 25180
		private GenericGraphic m_graphic;

		// Token: 0x0400625D RID: 25181
		private GridPosition m_position;

		// Token: 0x0400625E RID: 25182
		private bool m_isOpened;

		// Token: 0x0400625F RID: 25183
		private bool m_isGraphicSkillFade;

		// Token: 0x04006260 RID: 25184
		[DoNotToLua]
		private ClientBattleTreasure.LuaExportHelper luaExportHelper;

		// Token: 0x04006261 RID: 25185
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006262 RID: 25186
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006263 RID: 25187
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04006264 RID: 25188
		private LuaFunction m_InitializeClientBattleConfigDataBattleTreasureInfo_hotfix;

		// Token: 0x04006265 RID: 25189
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x04006266 RID: 25190
		private LuaFunction m_Tick_hotfix;

		// Token: 0x04006267 RID: 25191
		private LuaFunction m_UpdateGraphicPositionSingle_hotfix;

		// Token: 0x04006268 RID: 25192
		private LuaFunction m_ComputeGraphicPositionVector2Single_hotfix;

		// Token: 0x04006269 RID: 25193
		private LuaFunction m_Draw_hotfix;

		// Token: 0x0400626A RID: 25194
		private LuaFunction m_DoPauseBoolean_hotfix;

		// Token: 0x0400626B RID: 25195
		private LuaFunction m_SetOpenedBoolean_hotfix;

		// Token: 0x0400626C RID: 25196
		private LuaFunction m_IsOpened_hotfix;

		// Token: 0x0400626D RID: 25197
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400626E RID: 25198
		private LuaFunction m_SetGraphicSkillFadeBoolean_hotfix;

		// Token: 0x0400626F RID: 25199
		private LuaFunction m_get_Position_hotfix;

		// Token: 0x04006270 RID: 25200
		private LuaFunction m_get_BattleTreasureInfo_hotfix;

		// Token: 0x0200096D RID: 2413
		public new class LuaExportHelper
		{
			// Token: 0x060089DC RID: 35292 RVA: 0x0028274C File Offset: 0x0028094C
			public LuaExportHelper(ClientBattleTreasure owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060089DD RID: 35293 RVA: 0x0028275C File Offset: 0x0028095C
			public void __callBase_Dispose()
			{
				this.m_owner.__callBase_Dispose();
			}

			// Token: 0x060089DE RID: 35294 RVA: 0x0028276C File Offset: 0x0028096C
			public void __callBase_Tick()
			{
				this.m_owner.__callBase_Tick();
			}

			// Token: 0x060089DF RID: 35295 RVA: 0x0028277C File Offset: 0x0028097C
			public void __callBase_TickGraphic(float dt)
			{
				this.m_owner.__callBase_TickGraphic(dt);
			}

			// Token: 0x060089E0 RID: 35296 RVA: 0x0028278C File Offset: 0x0028098C
			public void __callBase_Draw()
			{
				this.m_owner.__callBase_Draw();
			}

			// Token: 0x060089E1 RID: 35297 RVA: 0x0028279C File Offset: 0x0028099C
			public void __callBase_Pause(bool pause)
			{
				this.m_owner.__callBase_Pause(pause);
			}

			// Token: 0x060089E2 RID: 35298 RVA: 0x002827AC File Offset: 0x002809AC
			public void __callBase_DoPause(bool pause)
			{
				this.m_owner.__callBase_DoPause(pause);
			}

			// Token: 0x060089E3 RID: 35299 RVA: 0x002827BC File Offset: 0x002809BC
			public void __callBase_DeleteMe()
			{
				this.m_owner.__callBase_DeleteMe();
			}

			// Token: 0x17001CE9 RID: 7401
			// (get) Token: 0x060089E4 RID: 35300 RVA: 0x002827CC File Offset: 0x002809CC
			// (set) Token: 0x060089E5 RID: 35301 RVA: 0x002827DC File Offset: 0x002809DC
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

			// Token: 0x17001CEA RID: 7402
			// (get) Token: 0x060089E6 RID: 35302 RVA: 0x002827EC File Offset: 0x002809EC
			// (set) Token: 0x060089E7 RID: 35303 RVA: 0x002827FC File Offset: 0x002809FC
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

			// Token: 0x17001CEB RID: 7403
			// (get) Token: 0x060089E8 RID: 35304 RVA: 0x0028280C File Offset: 0x00280A0C
			// (set) Token: 0x060089E9 RID: 35305 RVA: 0x0028281C File Offset: 0x00280A1C
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

			// Token: 0x17001CEC RID: 7404
			// (get) Token: 0x060089EA RID: 35306 RVA: 0x0028282C File Offset: 0x00280A2C
			// (set) Token: 0x060089EB RID: 35307 RVA: 0x0028283C File Offset: 0x00280A3C
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

			// Token: 0x17001CED RID: 7405
			// (get) Token: 0x060089EC RID: 35308 RVA: 0x0028284C File Offset: 0x00280A4C
			// (set) Token: 0x060089ED RID: 35309 RVA: 0x0028285C File Offset: 0x00280A5C
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

			// Token: 0x17001CEE RID: 7406
			// (get) Token: 0x060089EE RID: 35310 RVA: 0x0028286C File Offset: 0x00280A6C
			// (set) Token: 0x060089EF RID: 35311 RVA: 0x0028287C File Offset: 0x00280A7C
			public bool m_isGraphicSkillFade
			{
				get
				{
					return this.m_owner.m_isGraphicSkillFade;
				}
				set
				{
					this.m_owner.m_isGraphicSkillFade = value;
				}
			}

			// Token: 0x060089F0 RID: 35312 RVA: 0x0028288C File Offset: 0x00280A8C
			public void UpdateGraphicPosition(float zoffset)
			{
				this.m_owner.UpdateGraphicPosition(zoffset);
			}

			// Token: 0x060089F1 RID: 35313 RVA: 0x0028289C File Offset: 0x00280A9C
			public Vector3 ComputeGraphicPosition(Vector2 p, float zoffset)
			{
				return this.m_owner.ComputeGraphicPosition(p, zoffset);
			}

			// Token: 0x04006271 RID: 25201
			private ClientBattleTreasure m_owner;
		}
	}
}
