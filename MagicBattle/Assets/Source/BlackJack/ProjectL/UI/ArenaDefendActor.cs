using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009F8 RID: 2552
	[HotFix]
	public class ArenaDefendActor
	{
		// Token: 0x060097EB RID: 38891 RVA: 0x002B5B50 File Offset: 0x002B3D50
		public ArenaDefendActor(ArenaDefendBattle uiTask)
		{
			this.m_battle = uiTask;
			this.m_tweenFromColor = (this.m_tweenToColor = new Colori(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorArenaDefendBattle_hotfix != null)
			{
				this.m_ctorArenaDefendBattle_hotfix.call(new object[]
				{
					this,
					uiTask
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060097EC RID: 38892 RVA: 0x002B5C04 File Offset: 0x002B3E04
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
			this.DestroyGraphics();
		}

		// Token: 0x060097ED RID: 38893 RVA: 0x002B5C6C File Offset: 0x002B3E6C
		private void DestroyGraphics()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyGraphics_hotfix != null)
			{
				this.m_DestroyGraphics_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_graphics.Length; i++)
			{
				if (this.m_graphics[i] != null)
				{
					this.m_battle.DestroyGraphic(this.m_graphics[i]);
					this.m_graphics[i] = null;
				}
			}
		}

		// Token: 0x060097EE RID: 38894 RVA: 0x002B5D10 File Offset: 0x002B3F10
		public void SetHero(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroBattleHero_hotfix != null)
			{
				this.m_SetHeroBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_soldierCount = 2;
			this.UpdateGraphics();
		}

		// Token: 0x060097EF RID: 38895 RVA: 0x002B5D94 File Offset: 0x002B3F94
		public void UpdateGraphics()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateGraphics_hotfix != null)
			{
				this.m_UpdateGraphics_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero == null)
			{
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			bool flag = false;
			ConfigDataJobConnectionInfo jobConnectionInfo = this.m_hero.GetActiveJob().JobConnectionInfo;
			if (jobConnectionInfo != null)
			{
				string heroModelAssetPath = UIUtility.GetHeroModelAssetPath(this.m_hero);
				flag = this.UpdateGraphic(0, heroModelAssetPath, (float)jobConnectionInfo.BF_ModelScale * 0.01f, jobConnectionInfo.ReplaceAnims);
			}
			ConfigDataSoldierInfo selectedSoldierInfo = this.m_hero.SelectedSoldierInfo;
			if (selectedSoldierInfo != null)
			{
				ConfigDataModelSkinResourceInfo selectedSoldierModelSkinResourceInfo = this.m_hero.GetSelectedSoldierModelSkinResourceInfo(configDataLoader);
				string text = string.Empty;
				if (selectedSoldierModelSkinResourceInfo != null)
				{
					text = selectedSoldierModelSkinResourceInfo.Model;
				}
				if (string.IsNullOrEmpty(text))
				{
					text = selectedSoldierInfo.Model;
				}
				for (int i = 1; i <= this.m_soldierCount; i++)
				{
					flag |= this.UpdateGraphic(i, text, (float)selectedSoldierInfo.BF_ModelScale * 0.01f, selectedSoldierInfo.ReplaceAnims);
				}
			}
			if (flag)
			{
				this.PlayAnimation("idle", true);
			}
		}

		// Token: 0x060097F0 RID: 38896 RVA: 0x002B5EF0 File Offset: 0x002B40F0
		private bool UpdateGraphic(int idx, string assetName, float scale, List<ReplaceAnim> replaceAnims)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateGraphicInt32StringSingleList`1_hotfix != null)
			{
				return Convert.ToBoolean(this.m_UpdateGraphicInt32StringSingleList`1_hotfix.call(new object[]
				{
					this,
					idx,
					assetName,
					scale,
					replaceAnims
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_graphics[idx] != null && this.m_graphics[idx].AssetName == assetName)
			{
				return false;
			}
			this.m_battle.DestroyGraphic(this.m_graphics[idx]);
			this.m_graphics[idx] = this.m_battle.CreateGraphic(assetName, scale);
			if (this.m_graphics[idx] != null)
			{
				this.m_graphics[idx].SetReplaceAnimations(replaceAnims);
			}
			return true;
		}

		// Token: 0x060097F1 RID: 38897 RVA: 0x002B6008 File Offset: 0x002B4208
		public BattleHero GetHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHero_hotfix != null)
			{
				return (BattleHero)this.m_GetHero_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_hero;
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x002B607C File Offset: 0x002B427C
		private void PlayAnimation(string name, bool loop)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayAnimationStringBoolean_hotfix != null)
			{
				this.m_PlayAnimationStringBoolean_hotfix.call(new object[]
				{
					this,
					name,
					loop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (GenericGraphic genericGraphic in this.m_graphics)
			{
				if (genericGraphic != null)
				{
					genericGraphic.PlayAnimation(name, loop);
				}
			}
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x002B612C File Offset: 0x002B432C
		public void SetPosition(GridPosition p, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPositionGridPositionInt32_hotfix != null)
			{
				this.m_SetPositionGridPositionInt32_hotfix.call(new object[]
				{
					this,
					p,
					dir
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_position = p;
			this.m_direction = dir;
			this.TickGraphic(0f);
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x002B61C8 File Offset: 0x002B43C8
		public GridPosition GetPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPosition_hotfix != null)
			{
				return (GridPosition)this.m_GetPosition_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_position;
		}

		// Token: 0x060097F5 RID: 38901 RVA: 0x002B623C File Offset: 0x002B443C
		public int GetDirection()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDirection_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDirection_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_direction;
		}

		// Token: 0x060097F6 RID: 38902 RVA: 0x002B62B0 File Offset: 0x002B44B0
		public void TweenColor(Colori c)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TweenColorColori_hotfix != null)
			{
				this.m_TweenColorColori_hotfix.call(new object[]
				{
					this,
					c
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_tweenFromColor = this.m_tweenToColor;
			this.m_tweenToColor = c;
			this.m_tweenColorTime = 0.1f;
		}

		// Token: 0x060097F7 RID: 38903 RVA: 0x002B6340 File Offset: 0x002B4540
		public void TickGraphic(float dt)
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
			Vector2 a = this.m_battle.GridPositionToWorldPosition(this.m_position);
			int num = this.m_battle.ArenaBattleInfo.m_battlefieldInfo.Width / 2;
			int num2 = this.m_direction;
			if (num2 == 0)
			{
				num2 = ((this.m_position.x > num) ? -1 : 1);
			}
			for (int i = 0; i < this.m_graphics.Length; i++)
			{
				if (this.m_graphics[i] != null)
				{
					this.m_graphics[i].SetPosition(this.ComputeGraphicPosition(a + this.GetGraphicOffset(i, num2)));
					this.m_graphics[i].SetDirection(num2);
				}
			}
			if (this.m_tweenColorTime > 0f)
			{
				this.m_tweenColorTime -= dt;
				if (this.m_tweenColorTime < 0f)
				{
					this.m_tweenColorTime = 0f;
				}
				Colori color = Colori.Lerp(this.m_tweenToColor, this.m_tweenFromColor, this.m_tweenColorTime / 0.1f);
				foreach (GenericGraphic genericGraphic in this.m_graphics)
				{
					if (genericGraphic != null)
					{
						genericGraphic.SetColor(color);
					}
				}
			}
			foreach (GenericGraphic genericGraphic2 in this.m_graphics)
			{
				if (genericGraphic2 != null)
				{
					genericGraphic2.Tick(dt);
				}
			}
		}

		// Token: 0x060097F8 RID: 38904 RVA: 0x002B651C File Offset: 0x002B471C
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
			foreach (GenericGraphic genericGraphic in this.m_graphics)
			{
				if (genericGraphic != null)
				{
					genericGraphic.Pause(pause);
				}
			}
		}

		// Token: 0x060097F9 RID: 38905 RVA: 0x002B65B8 File Offset: 0x002B47B8
		private Vector3 ComputeGraphicPosition(Vector2 p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ComputeGraphicPositionVector2_hotfix != null)
			{
				return (Vector3)this.m_ComputeGraphicPositionVector2_hotfix.call(new object[]
				{
					this,
					p
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new Vector3(p.x, p.y, p.y * 0.01f);
		}

		// Token: 0x060097FA RID: 38906 RVA: 0x002B6654 File Offset: 0x002B4854
		private Vector2 GetGraphicOffset(int idx, int dir)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGraphicOffsetInt32Int32_hotfix != null)
			{
				return (Vector2)this.m_GetGraphicOffsetInt32Int32_hotfix.call(new object[]
				{
					this,
					idx,
					dir
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool hasHeroAndSoldier = this.m_hero.HeroId != 0 && this.m_hero.SelectedSoldierId != 0;
			return ClientBattleActor.ComputeGraphicOffset(idx, dir, this.m_soldierCount, hasHeroAndSoldier);
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x060097FB RID: 38907 RVA: 0x002B6714 File Offset: 0x002B4914
		// (set) Token: 0x060097FC RID: 38908 RVA: 0x002B6734 File Offset: 0x002B4934
		[DoNotToLua]
		public ArenaDefendActor.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaDefendActor.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060097FD RID: 38909 RVA: 0x002B6740 File Offset: 0x002B4940
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
					this.m_ctorArenaDefendBattle_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_Destroy_hotfix = (luaObj.RawGet("Destroy") as LuaFunction);
					this.m_DestroyGraphics_hotfix = (luaObj.RawGet("DestroyGraphics") as LuaFunction);
					this.m_SetHeroBattleHero_hotfix = (luaObj.RawGet("SetHero") as LuaFunction);
					this.m_UpdateGraphics_hotfix = (luaObj.RawGet("UpdateGraphics") as LuaFunction);
					this.m_UpdateGraphicInt32StringSingleList`1_hotfix = (luaObj.RawGet("UpdateGraphic") as LuaFunction);
					this.m_GetHero_hotfix = (luaObj.RawGet("GetHero") as LuaFunction);
					this.m_PlayAnimationStringBoolean_hotfix = (luaObj.RawGet("PlayAnimation") as LuaFunction);
					this.m_SetPositionGridPositionInt32_hotfix = (luaObj.RawGet("SetPosition") as LuaFunction);
					this.m_GetPosition_hotfix = (luaObj.RawGet("GetPosition") as LuaFunction);
					this.m_GetDirection_hotfix = (luaObj.RawGet("GetDirection") as LuaFunction);
					this.m_TweenColorColori_hotfix = (luaObj.RawGet("TweenColor") as LuaFunction);
					this.m_TickGraphicSingle_hotfix = (luaObj.RawGet("TickGraphic") as LuaFunction);
					this.m_PauseBoolean_hotfix = (luaObj.RawGet("Pause") as LuaFunction);
					this.m_ComputeGraphicPositionVector2_hotfix = (luaObj.RawGet("ComputeGraphicPosition") as LuaFunction);
					this.m_GetGraphicOffsetInt32Int32_hotfix = (luaObj.RawGet("GetGraphicOffset") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060097FE RID: 38910 RVA: 0x002B6984 File Offset: 0x002B4B84
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaDefendActor));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006853 RID: 26707
		private GridPosition m_position;

		// Token: 0x04006854 RID: 26708
		private int m_direction;

		// Token: 0x04006855 RID: 26709
		private int m_soldierCount;

		// Token: 0x04006856 RID: 26710
		private BattleHero m_hero;

		// Token: 0x04006857 RID: 26711
		private ArenaDefendBattle m_battle;

		// Token: 0x04006858 RID: 26712
		private Colori m_tweenFromColor;

		// Token: 0x04006859 RID: 26713
		private Colori m_tweenToColor;

		// Token: 0x0400685A RID: 26714
		private float m_tweenColorTime;

		// Token: 0x0400685B RID: 26715
		private GenericGraphic[] m_graphics = new GenericGraphic[3];

		// Token: 0x0400685C RID: 26716
		[DoNotToLua]
		private ArenaDefendActor.LuaExportHelper luaExportHelper;

		// Token: 0x0400685D RID: 26717
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400685E RID: 26718
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400685F RID: 26719
		private LuaFunction m_ctorArenaDefendBattle_hotfix;

		// Token: 0x04006860 RID: 26720
		private LuaFunction m_Destroy_hotfix;

		// Token: 0x04006861 RID: 26721
		private LuaFunction m_DestroyGraphics_hotfix;

		// Token: 0x04006862 RID: 26722
		private LuaFunction m_SetHeroBattleHero_hotfix;

		// Token: 0x04006863 RID: 26723
		private LuaFunction m_UpdateGraphics_hotfix;

		// Token: 0x04006864 RID: 26724
		private LuaFunction m_UpdateGraphicInt32StringSingleList;

		// Token: 0x04006865 RID: 26725
		private LuaFunction m_GetHero_hotfix;

		// Token: 0x04006866 RID: 26726
		private LuaFunction m_PlayAnimationStringBoolean_hotfix;

		// Token: 0x04006867 RID: 26727
		private LuaFunction m_SetPositionGridPositionInt32_hotfix;

		// Token: 0x04006868 RID: 26728
		private LuaFunction m_GetPosition_hotfix;

		// Token: 0x04006869 RID: 26729
		private LuaFunction m_GetDirection_hotfix;

		// Token: 0x0400686A RID: 26730
		private LuaFunction m_TweenColorColori_hotfix;

		// Token: 0x0400686B RID: 26731
		private LuaFunction m_TickGraphicSingle_hotfix;

		// Token: 0x0400686C RID: 26732
		private LuaFunction m_PauseBoolean_hotfix;

		// Token: 0x0400686D RID: 26733
		private LuaFunction m_ComputeGraphicPositionVector2_hotfix;

		// Token: 0x0400686E RID: 26734
		private LuaFunction m_GetGraphicOffsetInt32Int32_hotfix;

		// Token: 0x020009F9 RID: 2553
		public class LuaExportHelper
		{
			// Token: 0x060097FF RID: 38911 RVA: 0x002B69EC File Offset: 0x002B4BEC
			public LuaExportHelper(ArenaDefendActor owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001F44 RID: 8004
			// (get) Token: 0x06009800 RID: 38912 RVA: 0x002B69FC File Offset: 0x002B4BFC
			// (set) Token: 0x06009801 RID: 38913 RVA: 0x002B6A0C File Offset: 0x002B4C0C
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

			// Token: 0x17001F45 RID: 8005
			// (get) Token: 0x06009802 RID: 38914 RVA: 0x002B6A1C File Offset: 0x002B4C1C
			// (set) Token: 0x06009803 RID: 38915 RVA: 0x002B6A2C File Offset: 0x002B4C2C
			public int m_direction
			{
				get
				{
					return this.m_owner.m_direction;
				}
				set
				{
					this.m_owner.m_direction = value;
				}
			}

			// Token: 0x17001F46 RID: 8006
			// (get) Token: 0x06009804 RID: 38916 RVA: 0x002B6A3C File Offset: 0x002B4C3C
			// (set) Token: 0x06009805 RID: 38917 RVA: 0x002B6A4C File Offset: 0x002B4C4C
			public int m_soldierCount
			{
				get
				{
					return this.m_owner.m_soldierCount;
				}
				set
				{
					this.m_owner.m_soldierCount = value;
				}
			}

			// Token: 0x17001F47 RID: 8007
			// (get) Token: 0x06009806 RID: 38918 RVA: 0x002B6A5C File Offset: 0x002B4C5C
			// (set) Token: 0x06009807 RID: 38919 RVA: 0x002B6A6C File Offset: 0x002B4C6C
			public BattleHero m_hero
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

			// Token: 0x17001F48 RID: 8008
			// (get) Token: 0x06009808 RID: 38920 RVA: 0x002B6A7C File Offset: 0x002B4C7C
			// (set) Token: 0x06009809 RID: 38921 RVA: 0x002B6A8C File Offset: 0x002B4C8C
			public ArenaDefendBattle m_battle
			{
				get
				{
					return this.m_owner.m_battle;
				}
				set
				{
					this.m_owner.m_battle = value;
				}
			}

			// Token: 0x17001F49 RID: 8009
			// (get) Token: 0x0600980A RID: 38922 RVA: 0x002B6A9C File Offset: 0x002B4C9C
			// (set) Token: 0x0600980B RID: 38923 RVA: 0x002B6AAC File Offset: 0x002B4CAC
			public Colori m_tweenFromColor
			{
				get
				{
					return this.m_owner.m_tweenFromColor;
				}
				set
				{
					this.m_owner.m_tweenFromColor = value;
				}
			}

			// Token: 0x17001F4A RID: 8010
			// (get) Token: 0x0600980C RID: 38924 RVA: 0x002B6ABC File Offset: 0x002B4CBC
			// (set) Token: 0x0600980D RID: 38925 RVA: 0x002B6ACC File Offset: 0x002B4CCC
			public Colori m_tweenToColor
			{
				get
				{
					return this.m_owner.m_tweenToColor;
				}
				set
				{
					this.m_owner.m_tweenToColor = value;
				}
			}

			// Token: 0x17001F4B RID: 8011
			// (get) Token: 0x0600980E RID: 38926 RVA: 0x002B6ADC File Offset: 0x002B4CDC
			// (set) Token: 0x0600980F RID: 38927 RVA: 0x002B6AEC File Offset: 0x002B4CEC
			public float m_tweenColorTime
			{
				get
				{
					return this.m_owner.m_tweenColorTime;
				}
				set
				{
					this.m_owner.m_tweenColorTime = value;
				}
			}

			// Token: 0x17001F4C RID: 8012
			// (get) Token: 0x06009810 RID: 38928 RVA: 0x002B6AFC File Offset: 0x002B4CFC
			// (set) Token: 0x06009811 RID: 38929 RVA: 0x002B6B0C File Offset: 0x002B4D0C
			public GenericGraphic[] m_graphics
			{
				get
				{
					return this.m_owner.m_graphics;
				}
				set
				{
					this.m_owner.m_graphics = value;
				}
			}

			// Token: 0x06009812 RID: 38930 RVA: 0x002B6B1C File Offset: 0x002B4D1C
			public void DestroyGraphics()
			{
				this.m_owner.DestroyGraphics();
			}

			// Token: 0x06009813 RID: 38931 RVA: 0x002B6B2C File Offset: 0x002B4D2C
			public bool UpdateGraphic(int idx, string assetName, float scale, List<ReplaceAnim> replaceAnims)
			{
				return this.m_owner.UpdateGraphic(idx, assetName, scale, replaceAnims);
			}

			// Token: 0x06009814 RID: 38932 RVA: 0x002B6B40 File Offset: 0x002B4D40
			public void PlayAnimation(string name, bool loop)
			{
				this.m_owner.PlayAnimation(name, loop);
			}

			// Token: 0x06009815 RID: 38933 RVA: 0x002B6B50 File Offset: 0x002B4D50
			public Vector3 ComputeGraphicPosition(Vector2 p)
			{
				return this.m_owner.ComputeGraphicPosition(p);
			}

			// Token: 0x06009816 RID: 38934 RVA: 0x002B6B60 File Offset: 0x002B4D60
			public Vector2 GetGraphicOffset(int idx, int dir)
			{
				return this.m_owner.GetGraphicOffset(idx, dir);
			}

			// Token: 0x0400686F RID: 26735
			private ArenaDefendActor m_owner;
		}
	}
}
