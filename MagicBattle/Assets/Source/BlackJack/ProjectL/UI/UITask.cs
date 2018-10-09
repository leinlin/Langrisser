using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Resource;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FD9 RID: 4057
	[HotFix]
	public class UITask : UITaskBase
	{
		// Token: 0x060144B4 RID: 83124 RVA: 0x00528ADC File Offset: 0x00526CDC
		public UITask(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060144B5 RID: 83125 RVA: 0x00528B68 File Offset: 0x00526D68
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isOpeningUI = true;
			this.m_isNeedRegisterPlayerContextEvents = true;
			if (AssetUtility.Instance != null)
			{
				AssetUtility.Instance.RegisterDynamicAssetCache(this.m_dynamicResCacheDict);
				AssetUtility.Instance.EventOnMemoryWarning += this.OnMemoryWarning;
			}
			bool result = base.OnStart(intent);
			Debug.Log(base.GetType().Name + ".OnStart");
			SystemUtility.LogBatteryStatus();
			return result;
		}

		// Token: 0x060144B6 RID: 83126 RVA: 0x00528C4C File Offset: 0x00526E4C
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isPlayerContextEventsRegistered)
			{
				this.m_isPlayerContextEventsRegistered = false;
				this.UnregisterPlayerContextEvents();
			}
			if (AssetUtility.Instance != null)
			{
				AssetUtility.Instance.UnregisterDynamicAssetCache(this.m_dynamicResCacheDict);
				AssetUtility.Instance.EventOnMemoryWarning -= this.OnMemoryWarning;
			}
			base.OnStop();
			Debug.Log(base.GetType().Name + ".OnStop");
		}

		// Token: 0x060144B7 RID: 83127 RVA: 0x00528D18 File Offset: 0x00526F18
		protected override void OnPause()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPause_hotfix != null)
			{
				this.m_OnPause_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isPlayerContextEventsRegistered)
			{
				this.m_isPlayerContextEventsRegistered = false;
				this.UnregisterPlayerContextEvents();
			}
			base.OnPause();
			Debug.Log(base.GetType().Name + ".OnPause");
		}

		// Token: 0x060144B8 RID: 83128 RVA: 0x00528DB0 File Offset: 0x00526FB0
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isOpeningUI = true;
			this.m_isNeedRegisterPlayerContextEvents = true;
			this.InitLayerStateOnLoadAllResCompleted();
			bool result = base.OnResume(intent);
			Debug.Log(base.GetType().Name + ".OnResume");
			SystemUtility.LogBatteryStatus();
			return result;
		}

		// Token: 0x060144B9 RID: 83129 RVA: 0x00528E68 File Offset: 0x00527068
		public override bool OnNewIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNewIntentUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnNewIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool result = base.OnNewIntent(intent);
			Debug.Log(base.GetType().Name + ".OnNewIntent");
			return result;
		}

		// Token: 0x060144BA RID: 83130 RVA: 0x00528F08 File Offset: 0x00527108
		public override void EnableUIInput(bool isEnable, bool? isGlobalEnable = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableUIInputBooleanNullable`1_hotfix != null)
			{
				this.m_EnableUIInputBooleanNullable`1_hotfix.call(new object[]
				{
					this,
					isEnable,
					isGlobalEnable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.EnableUIInput(isEnable, null);
			if (CommonUIController.Instance != null)
			{
				CommonUIController.Instance.FrameworkUITaskEnableInput(isEnable);
			}
		}

		// Token: 0x060144BB RID: 83131 RVA: 0x00528FB4 File Offset: 0x005271B4
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_assets.Count > 0;
		}

		// Token: 0x060144BC RID: 83132 RVA: 0x00529030 File Offset: 0x00527230
		protected override List<string> CollectAllDynamicResForLoad()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAllDynamicResForLoad_hotfix != null)
			{
				return (List<string>)this.m_CollectAllDynamicResForLoad_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_assets;
		}

		// Token: 0x060144BD RID: 83133 RVA: 0x005290A4 File Offset: 0x005272A4
		protected virtual void RegisterPlayerContextEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterPlayerContextEvents_hotfix != null)
			{
				this.m_RegisterPlayerContextEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060144BE RID: 83134 RVA: 0x00529104 File Offset: 0x00527304
		protected virtual void UnregisterPlayerContextEvents()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnregisterPlayerContextEvents_hotfix != null)
			{
				this.m_UnregisterPlayerContextEvents_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060144BF RID: 83135 RVA: 0x00529164 File Offset: 0x00527364
		protected override void PostUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostUpdateView_hotfix != null)
			{
				this.m_PostUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isNeedRegisterPlayerContextEvents)
			{
				this.m_isNeedRegisterPlayerContextEvents = false;
				if (!this.m_isPlayerContextEventsRegistered)
				{
					this.m_isPlayerContextEventsRegistered = true;
					this.RegisterPlayerContextEvents();
				}
			}
			this.m_isOpeningUI = false;
			UIUtility.SetLongFrame();
			base.PostUpdateView();
		}

		// Token: 0x060144C0 RID: 83136 RVA: 0x00529200 File Offset: 0x00527400
		protected void CollectPreloadResourceList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectPreloadResourceList_hotfix != null)
			{
				this.m_CollectPreloadResourceList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.ClearAssetList();
			bool flag = SystemUtility.IsLowSystemMemory();
			bool flag2 = SystemUtility.IsLargeSystemMemory();
			this.CollectAsset("UI/Common_New_ABS/Material/UISpine.mat");
			this.CollectAsset("UI/Common_New_ABS/Material/UISpine2.mat");
			this.CollectAsset("UI/Common_New_ABS/Material/UISpine_SepAlpha.mat");
			this.CollectAsset("UI/Common_New_ABS/Material/UISpine2_SepAlpha.mat");
			this.CollectAsset("UI/Icon/Piece_ABS/Material/PieceIcon.mat");
			this.CollectAsset("UI/Icon/Card_ABS/Material/CardIcon.mat");
			this.CollectAsset("UI/Icon/HeroSkin_ABS/Material/HeroSkinIcon.mat");
			this.CollectAsset("UI/Icon/SoldierSkin_ABS/Material/SoldierSkinIcon.mat");
			this.CollectSpriteAsset("UI/Common_New_ABS/Icon/Bead_Blue.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Icon/Bead_Green.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Pattern_Blood_Green.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Pattern_Blood_Red.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Pattern_Blood_Blue.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Pattern_Blood_Green01.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Pattern_Blood_Red01.png");
			if (flag2)
			{
				this.CollectAsset("UI/World_ABS/Prefab/WorldUIPrefab.prefab");
				this.CollectAsset("WorldMap/WorldMap1_ABS/WorldMap1a_Prefab.prefab");
			}
			this.CollectSpriteAsset("UI/Icon/Item_ABS/Item_Gold.png");
			this.CollectSpriteAsset("UI/Icon/Item_ABS/Item_PlayerExp.png");
			this.CollectSpriteAsset("UI/Icon/Item_ABS/Item_MagicCrystal.png");
			this.CollectSpriteAsset("UI/Icon/Item_ABS/Item_Bread.png");
			this.CollectSpriteAsset("UI/Icon/Item_ABS/Item_PVPTicket.png");
			this.CollectSpriteAsset("UI/Icon/Item_ABS/Item_PvpCoin.png");
			this.CollectSpriteAsset("UI/Icon/Item_ABS/Item_ETicket-God.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Icon/Icon_Friendship_1.png");
			this.CollectSpriteAsset("UI/Icon/Item_ABS/Item_MemoryEssence.png");
			this.CollectSpriteAsset("UI/Icon/Item_ABS/Icon_DragonScale_01.png");
			this.CollectSpriteAsset("UI/Icon/Item_ABS/Icon_DragonScale_02.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Icon/Icon_GuildCoin.png");
			if (flag2)
			{
				this.CollectAsset("UI/Rift_ABS/Prefab/RiftChapterUIPrefab.prefab");
				this.CollectAsset("UI/Rift_ABS/Prefab/RiftLevelUIPrefab.prefab");
				this.CollectAsset("UI/Arena_ABS/Prefab/ArenaUIPrefab.prefab");
				this.CollectAsset("UI/Uncharted_ABS/Prefab/UnchartedUIPrefab.prefab");
			}
			this.CollectSpriteAsset("UI/Common_New_ABS/Border_Icon_Copper.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Border_Icon_Copper.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Border_Icon_Silver.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Border_Icon_Gold.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Border_Icon_Colour.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Border_Icon_Colour.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Border_Icon_Gray.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Icon/Icon_One.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Icon/Icon_Two.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Icon/Icon_Three.png");
			if (flag2)
			{
				this.CollectAsset("UI/Rift_ABS/Prefab/RiftBackgroundUIPrefab.prefab");
				this.CollectAsset("UI/HeroTraining_ABS/Prefab/HeroTrainingUIPrefab.prefab");
				this.CollectAsset("UI/Aniki_ABS/Prefab/AnikiUIPrefab.prefab");
				this.CollectAsset("UI/Thearchy_ABS/Prefab/ThearchyUIPrefab.prefab");
			}
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Rank_N.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Rank_R.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Rank_SR.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Rank_SSR.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Word_1.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Word_2.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Word_3.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Font_S.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Font_A.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Font_B.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Font_C.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Font_D.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Font_E.png");
			if (!flag)
			{
				this.CollectAsset("UI/Hero_ABS/Prefab/HeroListUIPrefab.prefab");
				this.CollectAsset("UI/Hero_ABS/Prefab/HeroDetailUIPrefab.prefab");
				this.CollectAsset("UI/Hero_ABS/Prefab/HeroDetailInfoUIPrefab.prefab");
				this.CollectAsset("UI/Hero_ABS/Prefab/HeroDetailJobUIPrefab.prefab");
			}
			this.CollectSpriteAsset("UI/HeadFrame_ABS/Card_Thumbnail_04.png");
			this.CollectSpriteAsset("UI/HeadFrame_ABS/Card_Thumbnail_03.png");
			this.CollectSpriteAsset("UI/HeadFrame_ABS/Card_Thumbnail_02.png");
			this.CollectSpriteAsset("UI/HeadFrame_ABS/Card_Thumbnail_01.png");
			this.CollectSpriteAsset("UI/HeadFrame_ABS/Card_Thumbnail_01.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Word_1P.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Word_2P.png");
			this.CollectSpriteAsset("UI/Common_New_ABS/Font/Word_3P.png");
			this.CollectAsset("FX/UI_ABS/UI_Fx/U_click_down.prefab");
			this.CollectAsset("FX/UI_ABS/UI_Fx/U_click_down.prefab");
			this.CollectAsset("FX/UI_ABS/UI_Fx/U_click.prefab");
			this.CollectAsset("FX/UI_ABS/UI_Fx/U_click_open.prefab");
			this.CollectAsset("FX/UI_ABS/UIFX_HPBarBreak_S_Pfb.prefab");
			this.CollectAsset("FX/UI_ABS/UIFX_HPBarBreak_L_Pfb.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/common_die.prefab");
			this.CollectAsset("Spine/Effect_ABS/effect_death/EffectDeath1Prefab.prefab");
			this.CollectAsset("Spine/Effect_ABS/effect_death/EffectDeath2Prefab.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/common_Teleport_2start.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/common_Teleport_2end.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/common_Refresh.prefab");
			if (flag2)
			{
				this.CollectAsset("UI/Common_ABS/Prefab/CommonUIPrefab.prefab");
				this.CollectAsset("UI/Rift_ABS/Prefab/RiftPanel06UIPrefab.prefab");
				this.CollectAsset("UI/World_ABS/Prefab/WorldScenePrefab.prefab");
			}
			this.CollectAsset("FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceEmpty_G.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceInMan_G.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchEnd_G.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceEmpty_R.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceInMan_R.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchEnd_R.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceEmpty_B.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceInMan_B.prefab");
			this.CollectAsset("FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchEnd_B.prefab");
			foreach (KeyValuePair<int, ConfigDataCharImageInfo> keyValuePair in configDataLoader.GetAllConfigDataCharImageInfo())
			{
				this.CollectSpriteAsset(keyValuePair.Value.RoundHeadImage);
				this.CollectSpriteAsset(keyValuePair.Value.SmallHeadImage);
				this.CollectSpriteAsset(keyValuePair.Value.SummonHeadImage);
			}
			if (!flag)
			{
				this.CollectAsset("UI/Hero_ABS/Prefab/HeroDetailSoldierUIPrefab.prefab");
				this.CollectAsset("UI/Hero_ABS/Prefab/HeroDetailEquipmentUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattleScenePrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattleRoomUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattleUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattleDanmakuUIPrefab.prefab");
			}
			foreach (KeyValuePair<int, ConfigDataArmyInfo> keyValuePair2 in configDataLoader.GetAllConfigDataArmyInfo())
			{
				this.CollectSpriteAsset(keyValuePair2.Value.Icon);
				this.CollectSpriteAsset(keyValuePair2.Value.Icon_NoBack);
			}
			foreach (KeyValuePair<int, ConfigDataJobInfo> keyValuePair3 in configDataLoader.GetAllConfigDataJobInfo())
			{
				this.CollectSpriteAsset(keyValuePair3.Value.JobIcon);
			}
			foreach (KeyValuePair<int, ConfigDataSkillInfo> keyValuePair4 in configDataLoader.GetAllConfigDataSkillInfo())
			{
				this.CollectSpriteAsset(keyValuePair4.Value.Icon);
			}
			foreach (KeyValuePair<int, ConfigDataBuffInfo> keyValuePair5 in configDataLoader.GetAllConfigDataBuffInfo())
			{
				this.CollectSpriteAsset(keyValuePair5.Value.Icon);
			}
			if (!flag)
			{
				this.CollectAsset("UI/Battle_ABS/Prefab/BattleActorInfoUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattlePrepareUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/PVPBattlePrepareUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattlePrepareActorInfoUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/ActionOrderUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattlePauseUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattleTreasureDialogUIPrefab.prefab");
			}
			foreach (KeyValuePair<int, ConfigDataItemInfo> keyValuePair6 in configDataLoader.GetAllConfigDataItemInfo())
			{
				this.CollectSpriteAsset(keyValuePair6.Value.Icon);
			}
			foreach (KeyValuePair<int, ConfigDataJobMaterialInfo> keyValuePair7 in configDataLoader.GetAllConfigDataJobMaterialInfo())
			{
				this.CollectSpriteAsset(keyValuePair7.Value.Icon);
			}
			foreach (KeyValuePair<int, ConfigDataEquipmentInfo> keyValuePair8 in configDataLoader.GetAllConfigDataEquipmentInfo())
			{
				this.CollectSpriteAsset(keyValuePair8.Value.Icon);
			}
			foreach (KeyValuePair<int, ConfigDataEnchantStoneInfo> keyValuePair9 in configDataLoader.GetAllConfigDataEnchantStoneInfo())
			{
				this.CollectSpriteAsset(keyValuePair9.Value.Icon);
			}
			foreach (KeyValuePair<int, ConfigDataResonanceInfo> keyValuePair10 in configDataLoader.GetAllConfigDataResonanceInfo())
			{
				this.CollectSpriteAsset(keyValuePair10.Value.SmallIcon);
				this.CollectSpriteAsset(keyValuePair10.Value.ActiveIcon);
				this.CollectSpriteAsset(keyValuePair10.Value.InactiveIcon);
			}
			if (!flag)
			{
				this.CollectAsset("UI/Battle_ABS/Prefab/CombatUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/PreCombatUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattleCommonUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattleResultUIPrefab.prefab");
				this.CollectAsset("UI/Battle_ABS/Prefab/BattleLoseUIPrefab.prefab");
			}
			foreach (KeyValuePair<int, ConfigDataTerrainInfo> keyValuePair11 in configDataLoader.GetAllConfigDataTerrainInfo())
			{
				this.CollectSpriteAsset(keyValuePair11.Value.InfoImage);
				this.CollectSpriteAsset(keyValuePair11.Value.MapTileImage);
			}
			foreach (KeyValuePair<int, ConfigDataSmallExpressionPathInfo> keyValuePair12 in configDataLoader.GetAllConfigDataSmallExpressionPathInfo())
			{
				this.CollectSpriteAsset(keyValuePair12.Value.SmallExpressionIconPath);
			}
			foreach (KeyValuePair<int, ConfigDataBigExpressionInfo> keyValuePair13 in configDataLoader.GetAllConfigDataBigExpressionInfo())
			{
				this.CollectSpriteAsset(keyValuePair13.Value.ExpressionIconPath);
			}
			foreach (string assetName in UIAsset.GoldNumbers)
			{
				this.CollectSpriteAsset(assetName);
			}
			foreach (KeyValuePair<int, ConfigDataHeadFrameInfo> keyValuePair14 in configDataLoader.GetAllConfigDataHeadFrameInfo())
			{
				this.CollectAsset(keyValuePair14.Value.ResourcePath);
				this.CollectSpriteAsset(keyValuePair14.Value.Icon);
			}
			if (!flag)
			{
				this.CollectAsset("UI/Common_ABS/Prefab/ChestUIPrefab.prefab");
				this.CollectAsset("UI/Common_ABS/Prefab/GetRewardGoodsUIPrefab.prefab");
			}
			if (!flag)
			{
				AssetUtility.Instance.InitLruAssetCache(1, 5);
				AssetUtility.Instance.InitLruAssetCache(2, 5);
				AssetUtility.Instance.InitLruAssetCache(3, 5);
				AssetUtility.Instance.InitLruAssetCache(4, 5);
				AssetUtility.Instance.InitLruAssetCache(5, 40);
				AssetUtility.Instance.InitLruAssetCache(6, 8);
			}
		}

		// Token: 0x060144C1 RID: 83137 RVA: 0x00529D94 File Offset: 0x00527F94
		protected void ClearAssetList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAssetList_hotfix != null)
			{
				this.m_ClearAssetList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_assets.Clear();
		}

		// Token: 0x060144C2 RID: 83138 RVA: 0x00529E00 File Offset: 0x00528000
		protected void CollectAsset(string assetName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectAssetString_hotfix != null)
			{
				this.m_CollectAssetString_hotfix.call(new object[]
				{
					this,
					assetName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AssetUtility.AddAssetToList(assetName, this.m_assets);
		}

		// Token: 0x060144C3 RID: 83139 RVA: 0x00529E7C File Offset: 0x0052807C
		protected void CollectSpriteAsset(string assetName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectSpriteAssetString_hotfix != null)
			{
				this.m_CollectSpriteAssetString_hotfix.call(new object[]
				{
					this,
					assetName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AssetUtility.AddSpriteAssetToList(assetName, this.m_assets);
		}

		// Token: 0x060144C4 RID: 83140 RVA: 0x00529EF8 File Offset: 0x005280F8
		protected void CollectFxAsset(string assetName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CollectFxAssetString_hotfix != null)
			{
				this.m_CollectFxAssetString_hotfix.call(new object[]
				{
					this,
					assetName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(assetName))
			{
				return;
			}
			this.CollectAsset(assetName);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string text = configDataLoader.UtilityGetFxFlipName(assetName);
			if (!string.IsNullOrEmpty(text))
			{
				this.CollectAsset(text);
			}
		}

		// Token: 0x060144C5 RID: 83141 RVA: 0x00529FA8 File Offset: 0x005281A8
		private void StartLoadCustomRes(List<string> resPathList, Action onLoadCompleted)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLoadCustomResList`1Action_hotfix != null)
			{
				this.m_StartLoadCustomResList`1Action_hotfix.call(new object[]
				{
					this,
					resPathList,
					onLoadCompleted2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onLoadCompleted = onLoadCompleted2;
			UITask $this = this;
			if (resPathList == null || resPathList.Count == 0)
			{
				onLoadCompleted();
				return;
			}
			HashSet<string> hashSet = base.CalculateDynamicResReallyNeedLoad(resPathList);
			if (hashSet == null || hashSet.Count == 0)
			{
				onLoadCompleted();
				return;
			}
			this.m_loadingCustomResCorutineCount++;
			ResourceManager.Instance.StartLoadAssetsCorutine(hashSet, this.m_dynamicResCacheDict, delegate
			{
				$this.m_loadingCustomResCorutineCount--;
				if ($this.State == Task.TaskState.Running)
				{
					onLoadCompleted();
				}
			}, false);
		}

		// Token: 0x060144C6 RID: 83142 RVA: 0x0052A0AC File Offset: 0x005282AC
		protected void StartLoadCustomAssets(Action onLoadCompleted)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartLoadCustomAssetsAction_hotfix != null)
			{
				this.m_StartLoadCustomAssetsAction_hotfix.call(new object[]
				{
					this,
					onLoadCompleted
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartLoadCustomRes(this.m_assets, onLoadCompleted);
		}

		// Token: 0x060144C7 RID: 83143 RVA: 0x0052A12C File Offset: 0x0052832C
		protected bool IsLoadingCustomAssets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLoadingCustomAssets_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLoadingCustomAssets_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_loadingCustomResCorutineCount != 0;
		}

		// Token: 0x060144C8 RID: 83144 RVA: 0x0052A1A4 File Offset: 0x005283A4
		protected bool IsPipeLineRunning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPipeLineRunning_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPipeLineRunning_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (this.m_currPipeLineCtx != null && this.m_currPipeLineCtx.m_isRuning) || this.m_piplineQueue.Count != 0;
		}

		// Token: 0x060144C9 RID: 83145 RVA: 0x0052A240 File Offset: 0x00528440
		protected bool IsOpeningUI()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOpeningUI_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOpeningUI_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isOpeningUI;
		}

		// Token: 0x060144CA RID: 83146 RVA: 0x0052A2B4 File Offset: 0x005284B4
		protected UITaskBase ReturnPrevUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReturnPrevUITask_hotfix != null)
			{
				return (UITaskBase)this.m_ReturnPrevUITask_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
			if (uiintentReturnable != null && uiintentReturnable.PrevTaskIntent != null)
			{
				return UIManager.Instance.ReturnUITask(uiintentReturnable.PrevTaskIntent);
			}
			return null;
		}

		// Token: 0x060144CB RID: 83147 RVA: 0x0052A350 File Offset: 0x00528550
		protected void ClearUnusedDynamicResourceCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearUnusedDynamicResourceCache_hotfix != null)
			{
				this.m_ClearUnusedDynamicResourceCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_assets.Count > 0)
			{
				List<string> list = new List<string>();
				foreach (string item in this.m_dynamicResCacheDict.Keys)
				{
					if (!this.m_assets.Contains(item))
					{
						list.Add(item);
					}
				}
				foreach (string key in list)
				{
					this.m_dynamicResCacheDict.Remove(key);
				}
			}
			else
			{
				this.m_dynamicResCacheDict.Clear();
			}
		}

		// Token: 0x060144CC RID: 83148 RVA: 0x0052A48C File Offset: 0x0052868C
		protected virtual void OnMemoryWarning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryWarning_hotfix != null)
			{
				this.m_OnMemoryWarning_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x060144CD RID: 83149 RVA: 0x0052A4EC File Offset: 0x005286EC
		// (set) Token: 0x060144CE RID: 83150 RVA: 0x0052A50C File Offset: 0x0052870C
		[DoNotToLua]
		public new UITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060144CF RID: 83151 RVA: 0x0052A518 File Offset: 0x00528718
		private void __callBase_InitlizeBeforeManagerStartIt()
		{
			base.InitlizeBeforeManagerStartIt();
		}

		// Token: 0x060144D0 RID: 83152 RVA: 0x0052A520 File Offset: 0x00528720
		private void __callBase_PrepareForStartOrResume(UIIntent intent, Action<bool> onPrepareEnd)
		{
			base.PrepareForStartOrResume(intent, onPrepareEnd);
		}

		// Token: 0x060144D1 RID: 83153 RVA: 0x0052A52C File Offset: 0x0052872C
		private bool __callBase_OnStart(object param)
		{
			return base.OnStart(param);
		}

		// Token: 0x060144D2 RID: 83154 RVA: 0x0052A538 File Offset: 0x00528738
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x060144D3 RID: 83155 RVA: 0x0052A544 File Offset: 0x00528744
		private UITaskPipeLineCtx __callBase_GetPipeLineCtx()
		{
			return base.GetPipeLineCtx();
		}

		// Token: 0x060144D4 RID: 83156 RVA: 0x0052A54C File Offset: 0x0052874C
		private UITaskPipeLineCtx __callBase_CreatePipeLineCtx()
		{
			return base.CreatePipeLineCtx();
		}

		// Token: 0x060144D5 RID: 83157 RVA: 0x0052A554 File Offset: 0x00528754
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060144D6 RID: 83158 RVA: 0x0052A55C File Offset: 0x0052875C
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060144D7 RID: 83159 RVA: 0x0052A564 File Offset: 0x00528764
		private bool __callBase_OnResume(object param)
		{
			return base.OnResume(param);
		}

		// Token: 0x060144D8 RID: 83160 RVA: 0x0052A570 File Offset: 0x00528770
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x060144D9 RID: 83161 RVA: 0x0052A57C File Offset: 0x0052877C
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x060144DA RID: 83162 RVA: 0x0052A588 File Offset: 0x00528788
		private bool __callBase_StartUpdatePipeLine(UIIntent intent, bool onlyUpdateView, bool canBeSkip, bool enableQueue)
		{
			return base.StartUpdatePipeLine(intent, onlyUpdateView, canBeSkip, enableQueue);
		}

		// Token: 0x060144DB RID: 83163 RVA: 0x0052A598 File Offset: 0x00528798
		private bool __callBase_NeedSkipUpdatePipeLine(UIIntent intent, bool onlyUpdateView)
		{
			return base.NeedSkipUpdatePipeLine(intent, onlyUpdateView);
		}

		// Token: 0x060144DC RID: 83164 RVA: 0x0052A5A4 File Offset: 0x005287A4
		private bool __callBase_IsNeedUpdateDataCache()
		{
			return base.IsNeedUpdateDataCache();
		}

		// Token: 0x060144DD RID: 83165 RVA: 0x0052A5AC File Offset: 0x005287AC
		private void __callBase_UpdateDataCache()
		{
			base.UpdateDataCache();
		}

		// Token: 0x060144DE RID: 83166 RVA: 0x0052A5B4 File Offset: 0x005287B4
		private bool __callBase_IsNeedLoadStaticRes()
		{
			return base.IsNeedLoadStaticRes();
		}

		// Token: 0x060144DF RID: 83167 RVA: 0x0052A5BC File Offset: 0x005287BC
		private void __callBase_StartLoadStaticRes()
		{
			base.StartLoadStaticRes();
		}

		// Token: 0x060144E0 RID: 83168 RVA: 0x0052A5C4 File Offset: 0x005287C4
		private void __callBase_CheckLayerDescArray(List<UITaskBase.LayerDesc> layerDescArray)
		{
			base.CheckLayerDescArray(layerDescArray);
		}

		// Token: 0x060144E1 RID: 83169 RVA: 0x0052A5D0 File Offset: 0x005287D0
		private void __callBase_OnLoadStaticResCompleted()
		{
			base.OnLoadStaticResCompleted();
		}

		// Token: 0x060144E2 RID: 83170 RVA: 0x0052A5D8 File Offset: 0x005287D8
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060144E3 RID: 83171 RVA: 0x0052A5E0 File Offset: 0x005287E0
		private void __callBase_StartLoadDynamicRes()
		{
			base.StartLoadDynamicRes();
		}

		// Token: 0x060144E4 RID: 83172 RVA: 0x0052A5E8 File Offset: 0x005287E8
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060144E5 RID: 83173 RVA: 0x0052A5F0 File Offset: 0x005287F0
		private List<UITaskBase.LayerDesc> __callBase_CollectAllStaticResDescForLoad()
		{
			return base.CollectAllStaticResDescForLoad();
		}

		// Token: 0x060144E6 RID: 83174 RVA: 0x0052A5F8 File Offset: 0x005287F8
		private HashSet<string> __callBase_CalculateDynamicResReallyNeedLoad(List<string> resPathList)
		{
			return base.CalculateDynamicResReallyNeedLoad(resPathList);
		}

		// Token: 0x060144E7 RID: 83175 RVA: 0x0052A604 File Offset: 0x00528804
		private void __callBase_OnLoadDynamicResCompleted()
		{
			base.OnLoadDynamicResCompleted();
		}

		// Token: 0x060144E8 RID: 83176 RVA: 0x0052A60C File Offset: 0x0052880C
		private void __callBase_RedirectPipLineOnAllResReady(Action callBack)
		{
			base.RedirectPipLineOnAllResReady(callBack);
		}

		// Token: 0x060144E9 RID: 83177 RVA: 0x0052A618 File Offset: 0x00528818
		private void __callBase_OnLoadAllResCompleted()
		{
			base.OnLoadAllResCompleted();
		}

		// Token: 0x060144EA RID: 83178 RVA: 0x0052A620 File Offset: 0x00528820
		private void __callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted()
		{
			base.ReturnFromRedirectPipLineOnLoadAllResCompleted();
		}

		// Token: 0x060144EB RID: 83179 RVA: 0x0052A628 File Offset: 0x00528828
		private void __callBase_InitLayerStateOnLoadAllResCompleted()
		{
			base.InitLayerStateOnLoadAllResCompleted();
		}

		// Token: 0x060144EC RID: 83180 RVA: 0x0052A630 File Offset: 0x00528830
		private void __callBase_InitAllUIControllers()
		{
			base.InitAllUIControllers();
		}

		// Token: 0x060144ED RID: 83181 RVA: 0x0052A638 File Offset: 0x00528838
		private void __callBase_PostOnLoadAllResCompleted()
		{
			base.PostOnLoadAllResCompleted();
		}

		// Token: 0x060144EE RID: 83182 RVA: 0x0052A640 File Offset: 0x00528840
		private bool __callBase_IsLoadAllResCompleted()
		{
			return base.IsLoadAllResCompleted();
		}

		// Token: 0x060144EF RID: 83183 RVA: 0x0052A648 File Offset: 0x00528848
		private void __callBase_StartUpdateView()
		{
			base.StartUpdateView();
		}

		// Token: 0x060144F0 RID: 83184 RVA: 0x0052A650 File Offset: 0x00528850
		private void __callBase_UpdateView()
		{
			base.UpdateView();
		}

		// Token: 0x060144F1 RID: 83185 RVA: 0x0052A658 File Offset: 0x00528858
		private void __callBase_RegUpdateViewPlayingEffect(string name, int timeout, Action<string> onTimeOut)
		{
			base.RegUpdateViewPlayingEffect(name, timeout, onTimeOut);
		}

		// Token: 0x060144F2 RID: 83186 RVA: 0x0052A664 File Offset: 0x00528864
		private void __callBase_UnregUpdateViewPlayingEffect(string name, bool isTimeOut)
		{
			base.UnregUpdateViewPlayingEffect(name, isTimeOut);
		}

		// Token: 0x060144F3 RID: 83187 RVA: 0x0052A670 File Offset: 0x00528870
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060144F4 RID: 83188 RVA: 0x0052A678 File Offset: 0x00528878
		private void __callBase_PostUpdateViewBeforeClearContext()
		{
			base.PostUpdateViewBeforeClearContext();
		}

		// Token: 0x060144F5 RID: 83189 RVA: 0x0052A680 File Offset: 0x00528880
		private void __callBase_HideAllView()
		{
			base.HideAllView();
		}

		// Token: 0x060144F6 RID: 83190 RVA: 0x0052A688 File Offset: 0x00528888
		private void __callBase_ClearAllContextAndRes()
		{
			base.ClearAllContextAndRes();
		}

		// Token: 0x060144F7 RID: 83191 RVA: 0x0052A690 File Offset: 0x00528890
		private void __callBase_SaveContextInIntentOnPause()
		{
			base.SaveContextInIntentOnPause();
		}

		// Token: 0x060144F8 RID: 83192 RVA: 0x0052A698 File Offset: 0x00528898
		private void __callBase_ClearContextOnPause()
		{
			base.ClearContextOnPause();
		}

		// Token: 0x060144F9 RID: 83193 RVA: 0x0052A6A0 File Offset: 0x005288A0
		private void __callBase_ClearContextOnIntentChange(UIIntent newIntent)
		{
			base.ClearContextOnIntentChange(newIntent);
		}

		// Token: 0x060144FA RID: 83194 RVA: 0x0052A6AC File Offset: 0x005288AC
		private void __callBase_ClearContextOnUpdateViewEnd()
		{
			base.ClearContextOnUpdateViewEnd();
		}

		// Token: 0x060144FB RID: 83195 RVA: 0x0052A6B4 File Offset: 0x005288B4
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x060144FC RID: 83196 RVA: 0x0052A6C0 File Offset: 0x005288C0
		private UITaskBase.LayerDesc __callBase_GetLayerDescByName(string name)
		{
			return base.GetLayerDescByName(name);
		}

		// Token: 0x060144FD RID: 83197 RVA: 0x0052A6CC File Offset: 0x005288CC
		private SceneLayerBase __callBase_GetLayerByName(string name)
		{
			return base.GetLayerByName(name);
		}

		// Token: 0x060144FE RID: 83198 RVA: 0x0052A6D8 File Offset: 0x005288D8
		private void __callBase_RegisterModesDefine(string defaultMode, string[] modes)
		{
			base.RegisterModesDefine(defaultMode, modes);
		}

		// Token: 0x060144FF RID: 83199 RVA: 0x0052A6E4 File Offset: 0x005288E4
		private bool __callBase_SetCurrentMode(string mode)
		{
			return base.SetCurrentMode(mode);
		}

		// Token: 0x06014500 RID: 83200 RVA: 0x0052A6F0 File Offset: 0x005288F0
		private void __callBase_SetIsNeedPauseTimeOut(bool isNeed)
		{
			base.SetIsNeedPauseTimeOut(isNeed);
		}

		// Token: 0x06014501 RID: 83201 RVA: 0x0052A6FC File Offset: 0x005288FC
		private void __callBase_OnTick()
		{
			base.OnTick();
		}

		// Token: 0x06014502 RID: 83202 RVA: 0x0052A704 File Offset: 0x00528904
		private void __callBase_PostDelayTimeExecuteAction(Action action, float delaySeconds)
		{
			base.PostDelayTimeExecuteAction(action, delaySeconds);
		}

		// Token: 0x06014503 RID: 83203 RVA: 0x0052A710 File Offset: 0x00528910
		private void __callBase_PostDelayTicksExecuteAction(Action action, ulong delayTickCount)
		{
			base.PostDelayTicksExecuteAction(action, delayTickCount);
		}

		// Token: 0x06014504 RID: 83204 RVA: 0x0052A71C File Offset: 0x0052891C
		private void __callBase_SetTag(string tag)
		{
			base.SetTag(tag);
		}

		// Token: 0x06014505 RID: 83205 RVA: 0x0052A728 File Offset: 0x00528928
		private bool __callBase_HasTag(string tag)
		{
			return base.HasTag(tag);
		}

		// Token: 0x06014506 RID: 83206 RVA: 0x0052A734 File Offset: 0x00528934
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnPause_hotfix = (luaObj.RawGet("OnPause") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnNewIntentUIIntent_hotfix = (luaObj.RawGet("OnNewIntent") as LuaFunction);
					this.m_EnableUIInputBooleanNullable`1_hotfix = (luaObj.RawGet("EnableUIInput") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_CollectAllDynamicResForLoad_hotfix = (luaObj.RawGet("CollectAllDynamicResForLoad") as LuaFunction);
					this.m_RegisterPlayerContextEvents_hotfix = (luaObj.RawGet("RegisterPlayerContextEvents") as LuaFunction);
					this.m_UnregisterPlayerContextEvents_hotfix = (luaObj.RawGet("UnregisterPlayerContextEvents") as LuaFunction);
					this.m_PostUpdateView_hotfix = (luaObj.RawGet("PostUpdateView") as LuaFunction);
					this.m_CollectPreloadResourceList_hotfix = (luaObj.RawGet("CollectPreloadResourceList") as LuaFunction);
					this.m_ClearAssetList_hotfix = (luaObj.RawGet("ClearAssetList") as LuaFunction);
					this.m_CollectAssetString_hotfix = (luaObj.RawGet("CollectAsset") as LuaFunction);
					this.m_CollectSpriteAssetString_hotfix = (luaObj.RawGet("CollectSpriteAsset") as LuaFunction);
					this.m_CollectFxAssetString_hotfix = (luaObj.RawGet("CollectFxAsset") as LuaFunction);
					this.m_StartLoadCustomResList`1Action_hotfix = (luaObj.RawGet("StartLoadCustomRes") as LuaFunction);
					this.m_StartLoadCustomAssetsAction_hotfix = (luaObj.RawGet("StartLoadCustomAssets") as LuaFunction);
					this.m_IsLoadingCustomAssets_hotfix = (luaObj.RawGet("IsLoadingCustomAssets") as LuaFunction);
					this.m_IsPipeLineRunning_hotfix = (luaObj.RawGet("IsPipeLineRunning") as LuaFunction);
					this.m_IsOpeningUI_hotfix = (luaObj.RawGet("IsOpeningUI") as LuaFunction);
					this.m_ReturnPrevUITask_hotfix = (luaObj.RawGet("ReturnPrevUITask") as LuaFunction);
					this.m_ClearUnusedDynamicResourceCache_hotfix = (luaObj.RawGet("ClearUnusedDynamicResourceCache") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014507 RID: 83207 RVA: 0x0052AA58 File Offset: 0x00528C58
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B351 RID: 45905
		protected List<string> m_assets = new List<string>();

		// Token: 0x0400B352 RID: 45906
		private int m_loadingCustomResCorutineCount;

		// Token: 0x0400B353 RID: 45907
		protected bool m_isOpeningUI = true;

		// Token: 0x0400B354 RID: 45908
		protected bool m_isNeedRegisterPlayerContextEvents;

		// Token: 0x0400B355 RID: 45909
		protected bool m_isPlayerContextEventsRegistered;

		// Token: 0x0400B356 RID: 45910
		[DoNotToLua]
		private UITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B357 RID: 45911
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B358 RID: 45912
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B359 RID: 45913
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B35A RID: 45914
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400B35B RID: 45915
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x0400B35C RID: 45916
		private LuaFunction m_OnPause_hotfix;

		// Token: 0x0400B35D RID: 45917
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400B35E RID: 45918
		private LuaFunction m_OnNewIntentUIIntent_hotfix;

		// Token: 0x0400B35F RID: 45919
		private LuaFunction m_EnableUIInputBooleanNullable;

		// Token: 0x0400B360 RID: 45920
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400B361 RID: 45921
		private LuaFunction m_CollectAllDynamicResForLoad_hotfix;

		// Token: 0x0400B362 RID: 45922
		private LuaFunction m_RegisterPlayerContextEvents_hotfix;

		// Token: 0x0400B363 RID: 45923
		private LuaFunction m_UnregisterPlayerContextEvents_hotfix;

		// Token: 0x0400B364 RID: 45924
		private LuaFunction m_PostUpdateView_hotfix;

		// Token: 0x0400B365 RID: 45925
		private LuaFunction m_CollectPreloadResourceList_hotfix;

		// Token: 0x0400B366 RID: 45926
		private LuaFunction m_ClearAssetList_hotfix;

		// Token: 0x0400B367 RID: 45927
		private LuaFunction m_CollectAssetString_hotfix;

		// Token: 0x0400B368 RID: 45928
		private LuaFunction m_CollectSpriteAssetString_hotfix;

		// Token: 0x0400B369 RID: 45929
		private LuaFunction m_CollectFxAssetString_hotfix;

		// Token: 0x0400B36A RID: 45930
		private LuaFunction m_StartLoadCustomResList;

		// Token: 0x0400B36B RID: 45931
		private LuaFunction m_StartLoadCustomAssetsAction_hotfix;

		// Token: 0x0400B36C RID: 45932
		private LuaFunction m_IsLoadingCustomAssets_hotfix;

		// Token: 0x0400B36D RID: 45933
		private LuaFunction m_IsPipeLineRunning_hotfix;

		// Token: 0x0400B36E RID: 45934
		private LuaFunction m_IsOpeningUI_hotfix;

		// Token: 0x0400B36F RID: 45935
		private LuaFunction m_ReturnPrevUITask_hotfix;

		// Token: 0x0400B370 RID: 45936
		private LuaFunction m_ClearUnusedDynamicResourceCache_hotfix;

		// Token: 0x0400B371 RID: 45937
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x02000FDA RID: 4058
		public new class LuaExportHelper
		{
			// Token: 0x06014508 RID: 83208 RVA: 0x0052AAC0 File Offset: 0x00528CC0
			public LuaExportHelper(UITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014509 RID: 83209 RVA: 0x0052AAD0 File Offset: 0x00528CD0
			public void __callBase_InitlizeBeforeManagerStartIt()
			{
				this.m_owner.__callBase_InitlizeBeforeManagerStartIt();
			}

			// Token: 0x0601450A RID: 83210 RVA: 0x0052AAE0 File Offset: 0x00528CE0
			public void __callBase_PrepareForStartOrResume(UIIntent intent, Action<bool> onPrepareEnd)
			{
				this.m_owner.__callBase_PrepareForStartOrResume(intent, onPrepareEnd);
			}

			// Token: 0x0601450B RID: 83211 RVA: 0x0052AAF0 File Offset: 0x00528CF0
			public bool __callBase_OnStart(object param)
			{
				return this.m_owner.__callBase_OnStart(param);
			}

			// Token: 0x0601450C RID: 83212 RVA: 0x0052AB00 File Offset: 0x00528D00
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0601450D RID: 83213 RVA: 0x0052AB10 File Offset: 0x00528D10
			public UITaskPipeLineCtx __callBase_GetPipeLineCtx()
			{
				return this.m_owner.__callBase_GetPipeLineCtx();
			}

			// Token: 0x0601450E RID: 83214 RVA: 0x0052AB20 File Offset: 0x00528D20
			public UITaskPipeLineCtx __callBase_CreatePipeLineCtx()
			{
				return this.m_owner.__callBase_CreatePipeLineCtx();
			}

			// Token: 0x0601450F RID: 83215 RVA: 0x0052AB30 File Offset: 0x00528D30
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06014510 RID: 83216 RVA: 0x0052AB40 File Offset: 0x00528D40
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06014511 RID: 83217 RVA: 0x0052AB50 File Offset: 0x00528D50
			public bool __callBase_OnResume(object param)
			{
				return this.m_owner.__callBase_OnResume(param);
			}

			// Token: 0x06014512 RID: 83218 RVA: 0x0052AB60 File Offset: 0x00528D60
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06014513 RID: 83219 RVA: 0x0052AB70 File Offset: 0x00528D70
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06014514 RID: 83220 RVA: 0x0052AB80 File Offset: 0x00528D80
			public bool __callBase_StartUpdatePipeLine(UIIntent intent, bool onlyUpdateView, bool canBeSkip, bool enableQueue)
			{
				return this.m_owner.__callBase_StartUpdatePipeLine(intent, onlyUpdateView, canBeSkip, enableQueue);
			}

			// Token: 0x06014515 RID: 83221 RVA: 0x0052AB94 File Offset: 0x00528D94
			public bool __callBase_NeedSkipUpdatePipeLine(UIIntent intent, bool onlyUpdateView)
			{
				return this.m_owner.__callBase_NeedSkipUpdatePipeLine(intent, onlyUpdateView);
			}

			// Token: 0x06014516 RID: 83222 RVA: 0x0052ABA4 File Offset: 0x00528DA4
			public bool __callBase_IsNeedUpdateDataCache()
			{
				return this.m_owner.__callBase_IsNeedUpdateDataCache();
			}

			// Token: 0x06014517 RID: 83223 RVA: 0x0052ABB4 File Offset: 0x00528DB4
			public void __callBase_UpdateDataCache()
			{
				this.m_owner.__callBase_UpdateDataCache();
			}

			// Token: 0x06014518 RID: 83224 RVA: 0x0052ABC4 File Offset: 0x00528DC4
			public bool __callBase_IsNeedLoadStaticRes()
			{
				return this.m_owner.__callBase_IsNeedLoadStaticRes();
			}

			// Token: 0x06014519 RID: 83225 RVA: 0x0052ABD4 File Offset: 0x00528DD4
			public void __callBase_StartLoadStaticRes()
			{
				this.m_owner.__callBase_StartLoadStaticRes();
			}

			// Token: 0x0601451A RID: 83226 RVA: 0x0052ABE4 File Offset: 0x00528DE4
			public void __callBase_CheckLayerDescArray(List<UITaskBase.LayerDesc> layerDescArray)
			{
				this.m_owner.__callBase_CheckLayerDescArray(layerDescArray);
			}

			// Token: 0x0601451B RID: 83227 RVA: 0x0052ABF4 File Offset: 0x00528DF4
			public void __callBase_OnLoadStaticResCompleted()
			{
				this.m_owner.__callBase_OnLoadStaticResCompleted();
			}

			// Token: 0x0601451C RID: 83228 RVA: 0x0052AC04 File Offset: 0x00528E04
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0601451D RID: 83229 RVA: 0x0052AC14 File Offset: 0x00528E14
			public void __callBase_StartLoadDynamicRes()
			{
				this.m_owner.__callBase_StartLoadDynamicRes();
			}

			// Token: 0x0601451E RID: 83230 RVA: 0x0052AC24 File Offset: 0x00528E24
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0601451F RID: 83231 RVA: 0x0052AC34 File Offset: 0x00528E34
			public List<UITaskBase.LayerDesc> __callBase_CollectAllStaticResDescForLoad()
			{
				return this.m_owner.__callBase_CollectAllStaticResDescForLoad();
			}

			// Token: 0x06014520 RID: 83232 RVA: 0x0052AC44 File Offset: 0x00528E44
			public HashSet<string> __callBase_CalculateDynamicResReallyNeedLoad(List<string> resPathList)
			{
				return this.m_owner.__callBase_CalculateDynamicResReallyNeedLoad(resPathList);
			}

			// Token: 0x06014521 RID: 83233 RVA: 0x0052AC54 File Offset: 0x00528E54
			public void __callBase_OnLoadDynamicResCompleted()
			{
				this.m_owner.__callBase_OnLoadDynamicResCompleted();
			}

			// Token: 0x06014522 RID: 83234 RVA: 0x0052AC64 File Offset: 0x00528E64
			public void __callBase_RedirectPipLineOnAllResReady(Action callBack)
			{
				this.m_owner.__callBase_RedirectPipLineOnAllResReady(callBack);
			}

			// Token: 0x06014523 RID: 83235 RVA: 0x0052AC74 File Offset: 0x00528E74
			public void __callBase_OnLoadAllResCompleted()
			{
				this.m_owner.__callBase_OnLoadAllResCompleted();
			}

			// Token: 0x06014524 RID: 83236 RVA: 0x0052AC84 File Offset: 0x00528E84
			public void __callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted()
			{
				this.m_owner.__callBase_ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}

			// Token: 0x06014525 RID: 83237 RVA: 0x0052AC94 File Offset: 0x00528E94
			public void __callBase_InitLayerStateOnLoadAllResCompleted()
			{
				this.m_owner.__callBase_InitLayerStateOnLoadAllResCompleted();
			}

			// Token: 0x06014526 RID: 83238 RVA: 0x0052ACA4 File Offset: 0x00528EA4
			public void __callBase_InitAllUIControllers()
			{
				this.m_owner.__callBase_InitAllUIControllers();
			}

			// Token: 0x06014527 RID: 83239 RVA: 0x0052ACB4 File Offset: 0x00528EB4
			public void __callBase_PostOnLoadAllResCompleted()
			{
				this.m_owner.__callBase_PostOnLoadAllResCompleted();
			}

			// Token: 0x06014528 RID: 83240 RVA: 0x0052ACC4 File Offset: 0x00528EC4
			public bool __callBase_IsLoadAllResCompleted()
			{
				return this.m_owner.__callBase_IsLoadAllResCompleted();
			}

			// Token: 0x06014529 RID: 83241 RVA: 0x0052ACD4 File Offset: 0x00528ED4
			public void __callBase_StartUpdateView()
			{
				this.m_owner.__callBase_StartUpdateView();
			}

			// Token: 0x0601452A RID: 83242 RVA: 0x0052ACE4 File Offset: 0x00528EE4
			public void __callBase_UpdateView()
			{
				this.m_owner.__callBase_UpdateView();
			}

			// Token: 0x0601452B RID: 83243 RVA: 0x0052ACF4 File Offset: 0x00528EF4
			public void __callBase_RegUpdateViewPlayingEffect(string name, int timeout, Action<string> onTimeOut)
			{
				this.m_owner.__callBase_RegUpdateViewPlayingEffect(name, timeout, onTimeOut);
			}

			// Token: 0x0601452C RID: 83244 RVA: 0x0052AD04 File Offset: 0x00528F04
			public void __callBase_UnregUpdateViewPlayingEffect(string name, bool isTimeOut)
			{
				this.m_owner.__callBase_UnregUpdateViewPlayingEffect(name, isTimeOut);
			}

			// Token: 0x0601452D RID: 83245 RVA: 0x0052AD14 File Offset: 0x00528F14
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0601452E RID: 83246 RVA: 0x0052AD24 File Offset: 0x00528F24
			public void __callBase_PostUpdateViewBeforeClearContext()
			{
				this.m_owner.__callBase_PostUpdateViewBeforeClearContext();
			}

			// Token: 0x0601452F RID: 83247 RVA: 0x0052AD34 File Offset: 0x00528F34
			public void __callBase_HideAllView()
			{
				this.m_owner.__callBase_HideAllView();
			}

			// Token: 0x06014530 RID: 83248 RVA: 0x0052AD44 File Offset: 0x00528F44
			public void __callBase_ClearAllContextAndRes()
			{
				this.m_owner.__callBase_ClearAllContextAndRes();
			}

			// Token: 0x06014531 RID: 83249 RVA: 0x0052AD54 File Offset: 0x00528F54
			public void __callBase_SaveContextInIntentOnPause()
			{
				this.m_owner.__callBase_SaveContextInIntentOnPause();
			}

			// Token: 0x06014532 RID: 83250 RVA: 0x0052AD64 File Offset: 0x00528F64
			public void __callBase_ClearContextOnPause()
			{
				this.m_owner.__callBase_ClearContextOnPause();
			}

			// Token: 0x06014533 RID: 83251 RVA: 0x0052AD74 File Offset: 0x00528F74
			public void __callBase_ClearContextOnIntentChange(UIIntent newIntent)
			{
				this.m_owner.__callBase_ClearContextOnIntentChange(newIntent);
			}

			// Token: 0x06014534 RID: 83252 RVA: 0x0052AD84 File Offset: 0x00528F84
			public void __callBase_ClearContextOnUpdateViewEnd()
			{
				this.m_owner.__callBase_ClearContextOnUpdateViewEnd();
			}

			// Token: 0x06014535 RID: 83253 RVA: 0x0052AD94 File Offset: 0x00528F94
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06014536 RID: 83254 RVA: 0x0052ADA4 File Offset: 0x00528FA4
			public UITaskBase.LayerDesc __callBase_GetLayerDescByName(string name)
			{
				return this.m_owner.__callBase_GetLayerDescByName(name);
			}

			// Token: 0x06014537 RID: 83255 RVA: 0x0052ADB4 File Offset: 0x00528FB4
			public SceneLayerBase __callBase_GetLayerByName(string name)
			{
				return this.m_owner.__callBase_GetLayerByName(name);
			}

			// Token: 0x06014538 RID: 83256 RVA: 0x0052ADC4 File Offset: 0x00528FC4
			public void __callBase_RegisterModesDefine(string defaultMode, string[] modes)
			{
				this.m_owner.__callBase_RegisterModesDefine(defaultMode, modes);
			}

			// Token: 0x06014539 RID: 83257 RVA: 0x0052ADD4 File Offset: 0x00528FD4
			public bool __callBase_SetCurrentMode(string mode)
			{
				return this.m_owner.__callBase_SetCurrentMode(mode);
			}

			// Token: 0x0601453A RID: 83258 RVA: 0x0052ADE4 File Offset: 0x00528FE4
			public void __callBase_SetIsNeedPauseTimeOut(bool isNeed)
			{
				this.m_owner.__callBase_SetIsNeedPauseTimeOut(isNeed);
			}

			// Token: 0x0601453B RID: 83259 RVA: 0x0052ADF4 File Offset: 0x00528FF4
			public void __callBase_OnTick()
			{
				this.m_owner.__callBase_OnTick();
			}

			// Token: 0x0601453C RID: 83260 RVA: 0x0052AE04 File Offset: 0x00529004
			public void __callBase_PostDelayTimeExecuteAction(Action action, float delaySeconds)
			{
				this.m_owner.__callBase_PostDelayTimeExecuteAction(action, delaySeconds);
			}

			// Token: 0x0601453D RID: 83261 RVA: 0x0052AE14 File Offset: 0x00529014
			public void __callBase_PostDelayTicksExecuteAction(Action action, ulong delayTickCount)
			{
				this.m_owner.__callBase_PostDelayTicksExecuteAction(action, delayTickCount);
			}

			// Token: 0x0601453E RID: 83262 RVA: 0x0052AE24 File Offset: 0x00529024
			public void __callBase_SetTag(string tag)
			{
				this.m_owner.__callBase_SetTag(tag);
			}

			// Token: 0x0601453F RID: 83263 RVA: 0x0052AE34 File Offset: 0x00529034
			public bool __callBase_HasTag(string tag)
			{
				return this.m_owner.__callBase_HasTag(tag);
			}

			// Token: 0x17003C5D RID: 15453
			// (get) Token: 0x06014540 RID: 83264 RVA: 0x0052AE44 File Offset: 0x00529044
			// (set) Token: 0x06014541 RID: 83265 RVA: 0x0052AE54 File Offset: 0x00529054
			public List<string> m_assets
			{
				get
				{
					return this.m_owner.m_assets;
				}
				set
				{
					this.m_owner.m_assets = value;
				}
			}

			// Token: 0x17003C5E RID: 15454
			// (get) Token: 0x06014542 RID: 83266 RVA: 0x0052AE64 File Offset: 0x00529064
			// (set) Token: 0x06014543 RID: 83267 RVA: 0x0052AE74 File Offset: 0x00529074
			public int m_loadingCustomResCorutineCount
			{
				get
				{
					return this.m_owner.m_loadingCustomResCorutineCount;
				}
				set
				{
					this.m_owner.m_loadingCustomResCorutineCount = value;
				}
			}

			// Token: 0x17003C5F RID: 15455
			// (get) Token: 0x06014544 RID: 83268 RVA: 0x0052AE84 File Offset: 0x00529084
			// (set) Token: 0x06014545 RID: 83269 RVA: 0x0052AE94 File Offset: 0x00529094
			public bool m_isOpeningUI
			{
				get
				{
					return this.m_owner.m_isOpeningUI;
				}
				set
				{
					this.m_owner.m_isOpeningUI = value;
				}
			}

			// Token: 0x17003C60 RID: 15456
			// (get) Token: 0x06014546 RID: 83270 RVA: 0x0052AEA4 File Offset: 0x005290A4
			// (set) Token: 0x06014547 RID: 83271 RVA: 0x0052AEB4 File Offset: 0x005290B4
			public bool m_isNeedRegisterPlayerContextEvents
			{
				get
				{
					return this.m_owner.m_isNeedRegisterPlayerContextEvents;
				}
				set
				{
					this.m_owner.m_isNeedRegisterPlayerContextEvents = value;
				}
			}

			// Token: 0x17003C61 RID: 15457
			// (get) Token: 0x06014548 RID: 83272 RVA: 0x0052AEC4 File Offset: 0x005290C4
			// (set) Token: 0x06014549 RID: 83273 RVA: 0x0052AED4 File Offset: 0x005290D4
			public bool m_isPlayerContextEventsRegistered
			{
				get
				{
					return this.m_owner.m_isPlayerContextEventsRegistered;
				}
				set
				{
					this.m_owner.m_isPlayerContextEventsRegistered = value;
				}
			}

			// Token: 0x0601454A RID: 83274 RVA: 0x0052AEE4 File Offset: 0x005290E4
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0601454B RID: 83275 RVA: 0x0052AEF4 File Offset: 0x005290F4
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0601454C RID: 83276 RVA: 0x0052AF04 File Offset: 0x00529104
			public void OnPause()
			{
				this.m_owner.OnPause();
			}

			// Token: 0x0601454D RID: 83277 RVA: 0x0052AF14 File Offset: 0x00529114
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0601454E RID: 83278 RVA: 0x0052AF24 File Offset: 0x00529124
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0601454F RID: 83279 RVA: 0x0052AF34 File Offset: 0x00529134
			public List<string> CollectAllDynamicResForLoad()
			{
				return this.m_owner.CollectAllDynamicResForLoad();
			}

			// Token: 0x06014550 RID: 83280 RVA: 0x0052AF44 File Offset: 0x00529144
			public void RegisterPlayerContextEvents()
			{
				this.m_owner.RegisterPlayerContextEvents();
			}

			// Token: 0x06014551 RID: 83281 RVA: 0x0052AF54 File Offset: 0x00529154
			public void UnregisterPlayerContextEvents()
			{
				this.m_owner.UnregisterPlayerContextEvents();
			}

			// Token: 0x06014552 RID: 83282 RVA: 0x0052AF64 File Offset: 0x00529164
			public void PostUpdateView()
			{
				this.m_owner.PostUpdateView();
			}

			// Token: 0x06014553 RID: 83283 RVA: 0x0052AF74 File Offset: 0x00529174
			public void CollectPreloadResourceList()
			{
				this.m_owner.CollectPreloadResourceList();
			}

			// Token: 0x06014554 RID: 83284 RVA: 0x0052AF84 File Offset: 0x00529184
			public void ClearAssetList()
			{
				this.m_owner.ClearAssetList();
			}

			// Token: 0x06014555 RID: 83285 RVA: 0x0052AF94 File Offset: 0x00529194
			public void CollectAsset(string assetName)
			{
				this.m_owner.CollectAsset(assetName);
			}

			// Token: 0x06014556 RID: 83286 RVA: 0x0052AFA4 File Offset: 0x005291A4
			public void CollectSpriteAsset(string assetName)
			{
				this.m_owner.CollectSpriteAsset(assetName);
			}

			// Token: 0x06014557 RID: 83287 RVA: 0x0052AFB4 File Offset: 0x005291B4
			public void CollectFxAsset(string assetName)
			{
				this.m_owner.CollectFxAsset(assetName);
			}

			// Token: 0x06014558 RID: 83288 RVA: 0x0052AFC4 File Offset: 0x005291C4
			public void StartLoadCustomRes(List<string> resPathList, Action onLoadCompleted)
			{
				this.m_owner.StartLoadCustomRes(resPathList, onLoadCompleted);
			}

			// Token: 0x06014559 RID: 83289 RVA: 0x0052AFD4 File Offset: 0x005291D4
			public void StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0601455A RID: 83290 RVA: 0x0052AFE4 File Offset: 0x005291E4
			public bool IsLoadingCustomAssets()
			{
				return this.m_owner.IsLoadingCustomAssets();
			}

			// Token: 0x0601455B RID: 83291 RVA: 0x0052AFF4 File Offset: 0x005291F4
			public bool IsPipeLineRunning()
			{
				return this.m_owner.IsPipeLineRunning();
			}

			// Token: 0x0601455C RID: 83292 RVA: 0x0052B004 File Offset: 0x00529204
			public bool IsOpeningUI()
			{
				return this.m_owner.IsOpeningUI();
			}

			// Token: 0x0601455D RID: 83293 RVA: 0x0052B014 File Offset: 0x00529214
			public UITaskBase ReturnPrevUITask()
			{
				return this.m_owner.ReturnPrevUITask();
			}

			// Token: 0x0601455E RID: 83294 RVA: 0x0052B024 File Offset: 0x00529224
			public void ClearUnusedDynamicResourceCache()
			{
				this.m_owner.ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0601455F RID: 83295 RVA: 0x0052B034 File Offset: 0x00529234
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x0400B372 RID: 45938
			private UITask m_owner;
		}
	}
}
