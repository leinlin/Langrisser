using System;
using System.Runtime.CompilerServices;

namespace SLua
{
	// Token: 0x02001103 RID: 4355
	[LuaBinder(3)]
	public class BindCustom
	{
		// Token: 0x06015A5D RID: 88669 RVA: 0x005826D4 File Offset: 0x005808D4
		public static Action<IntPtr>[] GetBindList()
		{
			Action<IntPtr>[] array = new Action<IntPtr>[1284];
			int num = 0;
			if (BindCustom.<>f__mg$cache0 == null)
			{
				BindCustom.<>f__mg$cache0 = new Action<IntPtr>(Lua_SLua_BJLuaObjHelper.reg);
			}
			array[num] = BindCustom.<>f__mg$cache0;
			int num2 = 1;
			if (BindCustom.<>f__mg$cache1 == null)
			{
				BindCustom.<>f__mg$cache1 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI.reg);
			}
			array[num2] = BindCustom.<>f__mg$cache1;
			int num3 = 2;
			if (BindCustom.<>f__mg$cache2 == null)
			{
				BindCustom.<>f__mg$cache2 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_AudioManager4CRI_PlaybacksOfSheet.reg);
			}
			array[num3] = BindCustom.<>f__mg$cache2;
			int num4 = 3;
			if (BindCustom.<>f__mg$cache3 == null)
			{
				BindCustom.<>f__mg$cache3 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_AudioManager4Unity.reg);
			}
			array[num4] = BindCustom.<>f__mg$cache3;
			int num5 = 4;
			if (BindCustom.<>f__mg$cache4 == null)
			{
				BindCustom.<>f__mg$cache4 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_OnClickSound.reg);
			}
			array[num5] = BindCustom.<>f__mg$cache4;
			int num6 = 5;
			if (BindCustom.<>f__mg$cache5 == null)
			{
				BindCustom.<>f__mg$cache5 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_OnHideSound.reg);
			}
			array[num6] = BindCustom.<>f__mg$cache5;
			int num7 = 6;
			if (BindCustom.<>f__mg$cache6 == null)
			{
				BindCustom.<>f__mg$cache6 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_OnImageFillAmmountSound.reg);
			}
			array[num7] = BindCustom.<>f__mg$cache6;
			int num8 = 7;
			if (BindCustom.<>f__mg$cache7 == null)
			{
				BindCustom.<>f__mg$cache7 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_OnShowSound.reg);
			}
			array[num8] = BindCustom.<>f__mg$cache7;
			int num9 = 8;
			if (BindCustom.<>f__mg$cache8 == null)
			{
				BindCustom.<>f__mg$cache8 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_SoundPlayer.reg);
			}
			array[num9] = BindCustom.<>f__mg$cache8;
			int num10 = 9;
			if (BindCustom.<>f__mg$cache9 == null)
			{
				BindCustom.<>f__mg$cache9 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_TypeDNName.reg);
			}
			array[num10] = BindCustom.<>f__mg$cache9;
			int num11 = 10;
			if (BindCustom.<>f__mg$cacheA == null)
			{
				BindCustom.<>f__mg$cacheA = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_ConfigData_ClientConfigDataLoaderBase.reg);
			}
			array[num11] = BindCustom.<>f__mg$cacheA;
			int num12 = 11;
			if (BindCustom.<>f__mg$cacheB == null)
			{
				BindCustom.<>f__mg$cacheB = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_GameManager.reg);
			}
			array[num12] = BindCustom.<>f__mg$cacheB;
			int num13 = 12;
			if (BindCustom.<>f__mg$cacheC == null)
			{
				BindCustom.<>f__mg$cacheC = new Action<IntPtr>(Lua_Debug.reg);
			}
			array[num13] = BindCustom.<>f__mg$cacheC;
			int num14 = 13;
			if (BindCustom.<>f__mg$cacheD == null)
			{
				BindCustom.<>f__mg$cacheD = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Lua_LuaCoroutineChecker.reg);
			}
			array[num14] = BindCustom.<>f__mg$cacheD;
			int num15 = 14;
			if (BindCustom.<>f__mg$cacheE == null)
			{
				BindCustom.<>f__mg$cacheE = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Lua_LuaExportChecker.reg);
			}
			array[num15] = BindCustom.<>f__mg$cacheE;
			int num16 = 15;
			if (BindCustom.<>f__mg$cacheF == null)
			{
				BindCustom.<>f__mg$cacheF = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Lua_LuaTestStruct.reg);
			}
			array[num16] = BindCustom.<>f__mg$cacheF;
			int num17 = 16;
			if (BindCustom.<>f__mg$cache10 == null)
			{
				BindCustom.<>f__mg$cache10 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixExample.reg);
			}
			array[num17] = BindCustom.<>f__mg$cache10;
			int num18 = 17;
			if (BindCustom.<>f__mg$cache11 == null)
			{
				BindCustom.<>f__mg$cache11 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Lua_LuaHotFixChecker.reg);
			}
			array[num18] = BindCustom.<>f__mg$cache11;
			int num19 = 18;
			if (BindCustom.<>f__mg$cache12 == null)
			{
				BindCustom.<>f__mg$cache12 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Lua_LuaManager.reg);
			}
			array[num19] = BindCustom.<>f__mg$cache12;
			int num20 = 19;
			if (BindCustom.<>f__mg$cache13 == null)
			{
				BindCustom.<>f__mg$cache13 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_PlayerContext_PlayerContextBase.reg);
			}
			array[num20] = BindCustom.<>f__mg$cache13;
			int num21 = 20;
			if (BindCustom.<>f__mg$cache14 == null)
			{
				BindCustom.<>f__mg$cache14 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.reg);
			}
			array[num21] = BindCustom.<>f__mg$cache14;
			int num22 = 21;
			if (BindCustom.<>f__mg$cache15 == null)
			{
				BindCustom.<>f__mg$cache15 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainerBase.reg);
			}
			array[num22] = BindCustom.<>f__mg$cache15;
			int num23 = 22;
			if (BindCustom.<>f__mg$cache16 == null)
			{
				BindCustom.<>f__mg$cache16 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainer.reg);
			}
			array[num23] = BindCustom.<>f__mg$cache16;
			int num24 = 23;
			if (BindCustom.<>f__mg$cache17 == null)
			{
				BindCustom.<>f__mg$cache17 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Resource_ResourceManager.reg);
			}
			array[num24] = BindCustom.<>f__mg$cache17;
			int num25 = 24;
			if (BindCustom.<>f__mg$cache18 == null)
			{
				BindCustom.<>f__mg$cache18 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.reg);
			}
			array[num25] = BindCustom.<>f__mg$cache18;
			int num26 = 25;
			if (BindCustom.<>f__mg$cache19 == null)
			{
				BindCustom.<>f__mg$cache19 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.reg);
			}
			array[num26] = BindCustom.<>f__mg$cache19;
			int num27 = 26;
			if (BindCustom.<>f__mg$cache1A == null)
			{
				BindCustom.<>f__mg$cache1A = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Scene_SceneManager.reg);
			}
			array[num27] = BindCustom.<>f__mg$cache1A;
			int num28 = 27;
			if (BindCustom.<>f__mg$cache1B == null)
			{
				BindCustom.<>f__mg$cache1B = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Scene_ThreeDSceneLayer.reg);
			}
			array[num28] = BindCustom.<>f__mg$cache1B;
			int num29 = 28;
			if (BindCustom.<>f__mg$cache1C == null)
			{
				BindCustom.<>f__mg$cache1C = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Scene_UISceneLayer.reg);
			}
			array[num29] = BindCustom.<>f__mg$cache1C;
			int num30 = 29;
			if (BindCustom.<>f__mg$cache1D == null)
			{
				BindCustom.<>f__mg$cache1D = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Scene_UnitySceneLayer.reg);
			}
			array[num30] = BindCustom.<>f__mg$cache1D;
			int num31 = 30;
			if (BindCustom.<>f__mg$cache1E == null)
			{
				BindCustom.<>f__mg$cache1E = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneUpdatePipeLineCtxBase.reg);
			}
			array[num31] = BindCustom.<>f__mg$cache1E;
			int num32 = 31;
			if (BindCustom.<>f__mg$cache1F == null)
			{
				BindCustom.<>f__mg$cache1F = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.reg);
			}
			array[num32] = BindCustom.<>f__mg$cache1F;
			int num33 = 32;
			if (BindCustom.<>f__mg$cache20 == null)
			{
				BindCustom.<>f__mg$cache20 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase.reg);
			}
			array[num33] = BindCustom.<>f__mg$cache20;
			int num34 = 33;
			if (BindCustom.<>f__mg$cache21 == null)
			{
				BindCustom.<>f__mg$cache21 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.reg);
			}
			array[num34] = BindCustom.<>f__mg$cache21;
			int num35 = 34;
			if (BindCustom.<>f__mg$cache22 == null)
			{
				BindCustom.<>f__mg$cache22 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_TaskNs_NetWorkTransactionTask.reg);
			}
			array[num35] = BindCustom.<>f__mg$cache22;
			int num36 = 35;
			if (BindCustom.<>f__mg$cache23 == null)
			{
				BindCustom.<>f__mg$cache23 = new Action<IntPtr>(Lua_BlackJack_Utils_TinyCorutineHelper.reg);
			}
			array[num36] = BindCustom.<>f__mg$cache23;
			int num37 = 36;
			if (BindCustom.<>f__mg$cache24 == null)
			{
				BindCustom.<>f__mg$cache24 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase.reg);
			}
			array[num37] = BindCustom.<>f__mg$cache24;
			int num38 = 37;
			if (BindCustom.<>f__mg$cache25 == null)
			{
				BindCustom.<>f__mg$cache25 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_UI_LoginUITaskBase.reg);
			}
			array[num38] = BindCustom.<>f__mg$cache25;
			int num39 = 38;
			if (BindCustom.<>f__mg$cache26 == null)
			{
				BindCustom.<>f__mg$cache26 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_UI_UIControllerBase.reg);
			}
			array[num39] = BindCustom.<>f__mg$cache26;
			int num40 = 39;
			if (BindCustom.<>f__mg$cache27 == null)
			{
				BindCustom.<>f__mg$cache27 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.reg);
			}
			array[num40] = BindCustom.<>f__mg$cache27;
			int num41 = 40;
			if (BindCustom.<>f__mg$cache28 == null)
			{
				BindCustom.<>f__mg$cache28 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.reg);
			}
			array[num41] = BindCustom.<>f__mg$cache28;
			int num42 = 41;
			if (BindCustom.<>f__mg$cache29 == null)
			{
				BindCustom.<>f__mg$cache29 = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.reg);
			}
			array[num42] = BindCustom.<>f__mg$cache29;
			int num43 = 42;
			if (BindCustom.<>f__mg$cache2A == null)
			{
				BindCustom.<>f__mg$cache2A = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.reg);
			}
			array[num43] = BindCustom.<>f__mg$cache2A;
			int num44 = 43;
			if (BindCustom.<>f__mg$cache2B == null)
			{
				BindCustom.<>f__mg$cache2B = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.reg);
			}
			array[num44] = BindCustom.<>f__mg$cache2B;
			int num45 = 44;
			if (BindCustom.<>f__mg$cache2C == null)
			{
				BindCustom.<>f__mg$cache2C = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_UIControllerDesc.reg);
			}
			array[num45] = BindCustom.<>f__mg$cache2C;
			int num46 = 45;
			if (BindCustom.<>f__mg$cache2D == null)
			{
				BindCustom.<>f__mg$cache2D = new Action<IntPtr>(Lua_BlackJack_BJFramework_Runtime_Util.reg);
			}
			array[num46] = BindCustom.<>f__mg$cache2D;
			int num47 = 46;
			if (BindCustom.<>f__mg$cache2E == null)
			{
				BindCustom.<>f__mg$cache2E = new Action<IntPtr>(Lua_BlackJack_ConfigData_ClientConfigDataLoader.reg);
			}
			array[num47] = BindCustom.<>f__mg$cache2E;
			int num48 = 47;
			if (BindCustom.<>f__mg$cache2F == null)
			{
				BindCustom.<>f__mg$cache2F = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataActivityCardPoolGroupInfo.reg);
			}
			array[num48] = BindCustom.<>f__mg$cache2F;
			int num49 = 48;
			if (BindCustom.<>f__mg$cache30 == null)
			{
				BindCustom.<>f__mg$cache30 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.reg);
			}
			array[num49] = BindCustom.<>f__mg$cache30;
			int num50 = 49;
			if (BindCustom.<>f__mg$cache31 == null)
			{
				BindCustom.<>f__mg$cache31 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataAnikiLevelInfo.reg);
			}
			array[num50] = BindCustom.<>f__mg$cache31;
			int num51 = 50;
			if (BindCustom.<>f__mg$cache32 == null)
			{
				BindCustom.<>f__mg$cache32 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataArenaBattleInfo.reg);
			}
			array[num51] = BindCustom.<>f__mg$cache32;
			int num52 = 51;
			if (BindCustom.<>f__mg$cache33 == null)
			{
				BindCustom.<>f__mg$cache33 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.reg);
			}
			array[num52] = BindCustom.<>f__mg$cache33;
			int num53 = 52;
			if (BindCustom.<>f__mg$cache34 == null)
			{
				BindCustom.<>f__mg$cache34 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBattleAchievementRelatedInfo.reg);
			}
			array[num53] = BindCustom.<>f__mg$cache34;
			int num54 = 53;
			if (BindCustom.<>f__mg$cache35 == null)
			{
				BindCustom.<>f__mg$cache35 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBattleDialogInfo.reg);
			}
			array[num54] = BindCustom.<>f__mg$cache35;
			int num55 = 54;
			if (BindCustom.<>f__mg$cache36 == null)
			{
				BindCustom.<>f__mg$cache36 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.reg);
			}
			array[num55] = BindCustom.<>f__mg$cache36;
			int num56 = 55;
			if (BindCustom.<>f__mg$cache37 == null)
			{
				BindCustom.<>f__mg$cache37 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.reg);
			}
			array[num56] = BindCustom.<>f__mg$cache37;
			int num57 = 56;
			if (BindCustom.<>f__mg$cache38 == null)
			{
				BindCustom.<>f__mg$cache38 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBattleInfo.reg);
			}
			array[num57] = BindCustom.<>f__mg$cache38;
			int num58 = 57;
			if (BindCustom.<>f__mg$cache39 == null)
			{
				BindCustom.<>f__mg$cache39 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBattleLoseConditionInfo.reg);
			}
			array[num58] = BindCustom.<>f__mg$cache39;
			int num59 = 58;
			if (BindCustom.<>f__mg$cache3A == null)
			{
				BindCustom.<>f__mg$cache3A = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBattlePerformInfo.reg);
			}
			array[num59] = BindCustom.<>f__mg$cache3A;
			int num60 = 59;
			if (BindCustom.<>f__mg$cache3B == null)
			{
				BindCustom.<>f__mg$cache3B = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBattleWinConditionInfo.reg);
			}
			array[num60] = BindCustom.<>f__mg$cache3B;
			int num61 = 60;
			if (BindCustom.<>f__mg$cache3C == null)
			{
				BindCustom.<>f__mg$cache3C = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBehavior.reg);
			}
			array[num61] = BindCustom.<>f__mg$cache3C;
			int num62 = 61;
			if (BindCustom.<>f__mg$cache3D == null)
			{
				BindCustom.<>f__mg$cache3D = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBehaviorChangeRule.reg);
			}
			array[num62] = BindCustom.<>f__mg$cache3D;
			int num63 = 62;
			if (BindCustom.<>f__mg$cache3E == null)
			{
				BindCustom.<>f__mg$cache3E = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.reg);
			}
			array[num63] = BindCustom.<>f__mg$cache3E;
			int num64 = 63;
			if (BindCustom.<>f__mg$cache3F == null)
			{
				BindCustom.<>f__mg$cache3F = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataCardPoolGroupInfo.reg);
			}
			array[num64] = BindCustom.<>f__mg$cache3F;
			int num65 = 64;
			if (BindCustom.<>f__mg$cache40 == null)
			{
				BindCustom.<>f__mg$cache40 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.reg);
			}
			array[num65] = BindCustom.<>f__mg$cache40;
			int num66 = 65;
			if (BindCustom.<>f__mg$cache41 == null)
			{
				BindCustom.<>f__mg$cache41 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.reg);
			}
			array[num66] = BindCustom.<>f__mg$cache41;
			int num67 = 66;
			if (BindCustom.<>f__mg$cache42 == null)
			{
				BindCustom.<>f__mg$cache42 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataCharImageInfo.reg);
			}
			array[num67] = BindCustom.<>f__mg$cache42;
			int num68 = 67;
			if (BindCustom.<>f__mg$cache43 == null)
			{
				BindCustom.<>f__mg$cache43 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleInfo.reg);
			}
			array[num68] = BindCustom.<>f__mg$cache43;
			int num69 = 68;
			if (BindCustom.<>f__mg$cache44 == null)
			{
				BindCustom.<>f__mg$cache44 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.reg);
			}
			array[num69] = BindCustom.<>f__mg$cache44;
			int num70 = 69;
			if (BindCustom.<>f__mg$cache45 == null)
			{
				BindCustom.<>f__mg$cache45 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataCrystalCardPoolGroupInfo.reg);
			}
			array[num70] = BindCustom.<>f__mg$cache45;
			int num71 = 70;
			if (BindCustom.<>f__mg$cache46 == null)
			{
				BindCustom.<>f__mg$cache46 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataDialogInfo.reg);
			}
			array[num71] = BindCustom.<>f__mg$cache46;
			int num72 = 71;
			if (BindCustom.<>f__mg$cache47 == null)
			{
				BindCustom.<>f__mg$cache47 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.reg);
			}
			array[num72] = BindCustom.<>f__mg$cache47;
			int num73 = 72;
			if (BindCustom.<>f__mg$cache48 == null)
			{
				BindCustom.<>f__mg$cache48 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataEventInfo.reg);
			}
			array[num73] = BindCustom.<>f__mg$cache48;
			int num74 = 73;
			if (BindCustom.<>f__mg$cache49 == null)
			{
				BindCustom.<>f__mg$cache49 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataFreeCardPoolGroupInfo.reg);
			}
			array[num74] = BindCustom.<>f__mg$cache49;
			int num75 = 74;
			if (BindCustom.<>f__mg$cache4A == null)
			{
				BindCustom.<>f__mg$cache4A = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataGoddessDialogInfo.reg);
			}
			array[num75] = BindCustom.<>f__mg$cache4A;
			int num76 = 75;
			if (BindCustom.<>f__mg$cache4B == null)
			{
				BindCustom.<>f__mg$cache4B = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataGroupBehavior.reg);
			}
			array[num76] = BindCustom.<>f__mg$cache4B;
			int num77 = 76;
			if (BindCustom.<>f__mg$cache4C == null)
			{
				BindCustom.<>f__mg$cache4C = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatDifficultyInfo.reg);
			}
			array[num77] = BindCustom.<>f__mg$cache4C;
			int num78 = 77;
			if (BindCustom.<>f__mg$cache4D == null)
			{
				BindCustom.<>f__mg$cache4D = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataGuildMassiveCombatLevelInfo.reg);
			}
			array[num78] = BindCustom.<>f__mg$cache4D;
			int num79 = 78;
			if (BindCustom.<>f__mg$cache4E == null)
			{
				BindCustom.<>f__mg$cache4E = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.reg);
			}
			array[num79] = BindCustom.<>f__mg$cache4E;
			int num80 = 79;
			if (BindCustom.<>f__mg$cache4F == null)
			{
				BindCustom.<>f__mg$cache4F = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.reg);
			}
			array[num80] = BindCustom.<>f__mg$cache4F;
			int num81 = 80;
			if (BindCustom.<>f__mg$cache50 == null)
			{
				BindCustom.<>f__mg$cache50 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.reg);
			}
			array[num81] = BindCustom.<>f__mg$cache50;
			int num82 = 81;
			if (BindCustom.<>f__mg$cache51 == null)
			{
				BindCustom.<>f__mg$cache51 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.reg);
			}
			array[num82] = BindCustom.<>f__mg$cache51;
			int num83 = 82;
			if (BindCustom.<>f__mg$cache52 == null)
			{
				BindCustom.<>f__mg$cache52 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomInfo.reg);
			}
			array[num83] = BindCustom.<>f__mg$cache52;
			int num84 = 83;
			if (BindCustom.<>f__mg$cache53 == null)
			{
				BindCustom.<>f__mg$cache53 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.reg);
			}
			array[num84] = BindCustom.<>f__mg$cache53;
			int num85 = 84;
			if (BindCustom.<>f__mg$cache54 == null)
			{
				BindCustom.<>f__mg$cache54 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.reg);
			}
			array[num85] = BindCustom.<>f__mg$cache54;
			int num86 = 85;
			if (BindCustom.<>f__mg$cache55 == null)
			{
				BindCustom.<>f__mg$cache55 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningInfo.reg);
			}
			array[num86] = BindCustom.<>f__mg$cache55;
			int num87 = 86;
			if (BindCustom.<>f__mg$cache56 == null)
			{
				BindCustom.<>f__mg$cache56 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataHeroTrainningLevelInfo.reg);
			}
			array[num87] = BindCustom.<>f__mg$cache56;
			int num88 = 87;
			if (BindCustom.<>f__mg$cache57 == null)
			{
				BindCustom.<>f__mg$cache57 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.reg);
			}
			array[num88] = BindCustom.<>f__mg$cache57;
			int num89 = 88;
			if (BindCustom.<>f__mg$cache58 == null)
			{
				BindCustom.<>f__mg$cache58 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataJobInfo.reg);
			}
			array[num89] = BindCustom.<>f__mg$cache58;
			int num90 = 89;
			if (BindCustom.<>f__mg$cache59 == null)
			{
				BindCustom.<>f__mg$cache59 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.reg);
			}
			array[num90] = BindCustom.<>f__mg$cache59;
			int num91 = 90;
			if (BindCustom.<>f__mg$cache5A == null)
			{
				BindCustom.<>f__mg$cache5A = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorInfo.reg);
			}
			array[num91] = BindCustom.<>f__mg$cache5A;
			int num92 = 91;
			if (BindCustom.<>f__mg$cache5B == null)
			{
				BindCustom.<>f__mg$cache5B = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataMemoryCorridorLevelInfo.reg);
			}
			array[num92] = BindCustom.<>f__mg$cache5B;
			int num93 = 92;
			if (BindCustom.<>f__mg$cache5C == null)
			{
				BindCustom.<>f__mg$cache5C = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataMissionInfo.reg);
			}
			array[num93] = BindCustom.<>f__mg$cache5C;
			int num94 = 93;
			if (BindCustom.<>f__mg$cache5D == null)
			{
				BindCustom.<>f__mg$cache5D = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataModelSkinResourceInfo.reg);
			}
			array[num94] = BindCustom.<>f__mg$cache5D;
			int num95 = 94;
			if (BindCustom.<>f__mg$cache5E == null)
			{
				BindCustom.<>f__mg$cache5E = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataPVPBattleInfo.reg);
			}
			array[num95] = BindCustom.<>f__mg$cache5E;
			int num96 = 95;
			if (BindCustom.<>f__mg$cache5F == null)
			{
				BindCustom.<>f__mg$cache5F = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataRealTimePVPBattleInfo.reg);
			}
			array[num96] = BindCustom.<>f__mg$cache5F;
			int num97 = 96;
			if (BindCustom.<>f__mg$cache60 == null)
			{
				BindCustom.<>f__mg$cache60 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataRegionInfo.reg);
			}
			array[num97] = BindCustom.<>f__mg$cache60;
			int num98 = 97;
			if (BindCustom.<>f__mg$cache61 == null)
			{
				BindCustom.<>f__mg$cache61 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataRiftChapterInfo.reg);
			}
			array[num98] = BindCustom.<>f__mg$cache61;
			int num99 = 98;
			if (BindCustom.<>f__mg$cache62 == null)
			{
				BindCustom.<>f__mg$cache62 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.reg);
			}
			array[num99] = BindCustom.<>f__mg$cache62;
			int num100 = 99;
			if (BindCustom.<>f__mg$cache63 == null)
			{
				BindCustom.<>f__mg$cache63 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataScenarioInfo.reg);
			}
			array[num100] = BindCustom.<>f__mg$cache63;
			int num101 = 100;
			if (BindCustom.<>f__mg$cache64 == null)
			{
				BindCustom.<>f__mg$cache64 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.reg);
			}
			array[num101] = BindCustom.<>f__mg$cache64;
			int num102 = 101;
			if (BindCustom.<>f__mg$cache65 == null)
			{
				BindCustom.<>f__mg$cache65 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.reg);
			}
			array[num102] = BindCustom.<>f__mg$cache65;
			int num103 = 102;
			if (BindCustom.<>f__mg$cache66 == null)
			{
				BindCustom.<>f__mg$cache66 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.reg);
			}
			array[num103] = BindCustom.<>f__mg$cache66;
			int num104 = 103;
			if (BindCustom.<>f__mg$cache67 == null)
			{
				BindCustom.<>f__mg$cache67 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataSoldierSkinInfo.reg);
			}
			array[num104] = BindCustom.<>f__mg$cache67;
			int num105 = 104;
			if (BindCustom.<>f__mg$cache68 == null)
			{
				BindCustom.<>f__mg$cache68 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialInfo.reg);
			}
			array[num105] = BindCustom.<>f__mg$cache68;
			int num106 = 105;
			if (BindCustom.<>f__mg$cache69 == null)
			{
				BindCustom.<>f__mg$cache69 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataThearchyTrialLevelInfo.reg);
			}
			array[num106] = BindCustom.<>f__mg$cache69;
			int num107 = 106;
			if (BindCustom.<>f__mg$cache6A == null)
			{
				BindCustom.<>f__mg$cache6A = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataTowerBattleRuleInfo.reg);
			}
			array[num107] = BindCustom.<>f__mg$cache6A;
			int num108 = 107;
			if (BindCustom.<>f__mg$cache6B == null)
			{
				BindCustom.<>f__mg$cache6B = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataTowerLevelInfo.reg);
			}
			array[num108] = BindCustom.<>f__mg$cache6B;
			int num109 = 108;
			if (BindCustom.<>f__mg$cache6C == null)
			{
				BindCustom.<>f__mg$cache6C = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataTrainingRoomInfo.reg);
			}
			array[num109] = BindCustom.<>f__mg$cache6C;
			int num110 = 109;
			if (BindCustom.<>f__mg$cache6D == null)
			{
				BindCustom.<>f__mg$cache6D = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.reg);
			}
			array[num110] = BindCustom.<>f__mg$cache6D;
			int num111 = 110;
			if (BindCustom.<>f__mg$cache6E == null)
			{
				BindCustom.<>f__mg$cache6E = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataTreasureLevelInfo.reg);
			}
			array[num111] = BindCustom.<>f__mg$cache6E;
			int num112 = 111;
			if (BindCustom.<>f__mg$cache6F == null)
			{
				BindCustom.<>f__mg$cache6F = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.reg);
			}
			array[num112] = BindCustom.<>f__mg$cache6F;
			int num113 = 112;
			if (BindCustom.<>f__mg$cache70 == null)
			{
				BindCustom.<>f__mg$cache70 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataUserGuideDialogInfo.reg);
			}
			array[num113] = BindCustom.<>f__mg$cache70;
			int num114 = 113;
			if (BindCustom.<>f__mg$cache71 == null)
			{
				BindCustom.<>f__mg$cache71 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.reg);
			}
			array[num114] = BindCustom.<>f__mg$cache71;
			int num115 = 114;
			if (BindCustom.<>f__mg$cache72 == null)
			{
				BindCustom.<>f__mg$cache72 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataWaypointInfo.reg);
			}
			array[num115] = BindCustom.<>f__mg$cache72;
			int num116 = 115;
			if (BindCustom.<>f__mg$cache73 == null)
			{
				BindCustom.<>f__mg$cache73 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataWorldMapInfo.reg);
			}
			array[num116] = BindCustom.<>f__mg$cache73;
			int num117 = 116;
			if (BindCustom.<>f__mg$cache74 == null)
			{
				BindCustom.<>f__mg$cache74 = new Action<IntPtr>(Lua_BlackJack_ConfigData_RandomStoreItemDataKey.reg);
			}
			array[num117] = BindCustom.<>f__mg$cache74;
			int num118 = 117;
			if (BindCustom.<>f__mg$cache75 == null)
			{
				BindCustom.<>f__mg$cache75 = new Action<IntPtr>(Lua_BlackJack_ConfigData_RandomStoreData.reg);
			}
			array[num118] = BindCustom.<>f__mg$cache75;
			int num119 = 118;
			if (BindCustom.<>f__mg$cache76 == null)
			{
				BindCustom.<>f__mg$cache76 = new Action<IntPtr>(Lua_BlackJack_ConfigData_RandomStoreItemData.reg);
			}
			array[num119] = BindCustom.<>f__mg$cache76;
			int num120 = 119;
			if (BindCustom.<>f__mg$cache77 == null)
			{
				BindCustom.<>f__mg$cache77 = new Action<IntPtr>(Lua_BlackJack_ConfigData_RandomDropDataInfo.reg);
			}
			array[num120] = BindCustom.<>f__mg$cache77;
			int num121 = 120;
			if (BindCustom.<>f__mg$cache78 == null)
			{
				BindCustom.<>f__mg$cache78 = new Action<IntPtr>(Lua_BlackJack_ConfigData_RandomDropRewardArea.reg);
			}
			array[num121] = BindCustom.<>f__mg$cache78;
			int num122 = 121;
			if (BindCustom.<>f__mg$cache79 == null)
			{
				BindCustom.<>f__mg$cache79 = new Action<IntPtr>(Lua_BlackJack_ConfigData_RandomDropRewardGroup.reg);
			}
			array[num122] = BindCustom.<>f__mg$cache79;
			int num123 = 122;
			if (BindCustom.<>f__mg$cache7A == null)
			{
				BindCustom.<>f__mg$cache7A = new Action<IntPtr>(Lua_BlackJack_ConfigData_FixedStoreDataInfo.reg);
			}
			array[num123] = BindCustom.<>f__mg$cache7A;
			int num124 = 123;
			if (BindCustom.<>f__mg$cache7B == null)
			{
				BindCustom.<>f__mg$cache7B = new Action<IntPtr>(Lua_BlackJack_ConfigData_FixedStoreInfo.reg);
			}
			array[num124] = BindCustom.<>f__mg$cache7B;
			int num125 = 124;
			if (BindCustom.<>f__mg$cache7C == null)
			{
				BindCustom.<>f__mg$cache7C = new Action<IntPtr>(Lua_BlackJack_ConfigData_SignRewardDataInfo.reg);
			}
			array[num125] = BindCustom.<>f__mg$cache7C;
			int num126 = 125;
			if (BindCustom.<>f__mg$cache7D == null)
			{
				BindCustom.<>f__mg$cache7D = new Action<IntPtr>(Lua_BlackJack_ConfigData_MonthSignRewardInfo.reg);
			}
			array[num126] = BindCustom.<>f__mg$cache7D;
			int num127 = 126;
			if (BindCustom.<>f__mg$cache7E == null)
			{
				BindCustom.<>f__mg$cache7E = new Action<IntPtr>(Lua_BlackJack_ConfigData_MissionDataInfo.reg);
			}
			array[num127] = BindCustom.<>f__mg$cache7E;
			int num128 = 127;
			if (BindCustom.<>f__mg$cache7F == null)
			{
				BindCustom.<>f__mg$cache7F = new Action<IntPtr>(Lua_BlackJack_ConfigData_ThearchyTrialDataInfo.reg);
			}
			array[num128] = BindCustom.<>f__mg$cache7F;
			int num129 = 128;
			if (BindCustom.<>f__mg$cache80 == null)
			{
				BindCustom.<>f__mg$cache80 = new Action<IntPtr>(Lua_BlackJack_ConfigData_AnikiGymDataInfo.reg);
			}
			array[num129] = BindCustom.<>f__mg$cache80;
			int num130 = 129;
			if (BindCustom.<>f__mg$cache81 == null)
			{
				BindCustom.<>f__mg$cache81 = new Action<IntPtr>(Lua_BlackJack_ConfigData_MemoryCorridorDataInfo.reg);
			}
			array[num130] = BindCustom.<>f__mg$cache81;
			int num131 = 130;
			if (BindCustom.<>f__mg$cache82 == null)
			{
				BindCustom.<>f__mg$cache82 = new Action<IntPtr>(Lua_BlackJack_ConfigData_HeroTrainningDataInfo.reg);
			}
			array[num131] = BindCustom.<>f__mg$cache82;
			int num132 = 131;
			if (BindCustom.<>f__mg$cache83 == null)
			{
				BindCustom.<>f__mg$cache83 = new Action<IntPtr>(Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.reg);
			}
			array[num132] = BindCustom.<>f__mg$cache83;
			int num133 = 132;
			if (BindCustom.<>f__mg$cache84 == null)
			{
				BindCustom.<>f__mg$cache84 = new Action<IntPtr>(Lua_BlackJack_ConfigData_RealTimePVPAvailableTime.reg);
			}
			array[num133] = BindCustom.<>f__mg$cache84;
			int num134 = 133;
			if (BindCustom.<>f__mg$cache85 == null)
			{
				BindCustom.<>f__mg$cache85 = new Action<IntPtr>(Lua_BlackJack_ConfigData_SpineAnimationSoundTable.reg);
			}
			array[num134] = BindCustom.<>f__mg$cache85;
			int num135 = 134;
			if (BindCustom.<>f__mg$cache86 == null)
			{
				BindCustom.<>f__mg$cache86 = new Action<IntPtr>(Lua_BlackJack_ConfigData_BattleLevelAchievement.reg);
			}
			array[num135] = BindCustom.<>f__mg$cache86;
			int num136 = 135;
			if (BindCustom.<>f__mg$cache87 == null)
			{
				BindCustom.<>f__mg$cache87 = new Action<IntPtr>(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.reg);
			}
			array[num136] = BindCustom.<>f__mg$cache87;
			int num137 = 136;
			if (BindCustom.<>f__mg$cache88 == null)
			{
				BindCustom.<>f__mg$cache88 = new Action<IntPtr>(Lua_BlackJack_ConfigData_TrainingTechInfo.reg);
			}
			array[num137] = BindCustom.<>f__mg$cache88;
			int num138 = 137;
			if (BindCustom.<>f__mg$cache89 == null)
			{
				BindCustom.<>f__mg$cache89 = new Action<IntPtr>(Lua_BlackJack_ConfigData_TrainingTechResourceRequirements.reg);
			}
			array[num138] = BindCustom.<>f__mg$cache89;
			int num139 = 138;
			if (BindCustom.<>f__mg$cache8A == null)
			{
				BindCustom.<>f__mg$cache8A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleActorLogInfo.reg);
			}
			array[num139] = BindCustom.<>f__mg$cache8A;
			int num140 = 139;
			if (BindCustom.<>f__mg$cache8B == null)
			{
				BindCustom.<>f__mg$cache8B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleHeroEquipment.reg);
			}
			array[num140] = BindCustom.<>f__mg$cache8B;
			int num141 = 140;
			if (BindCustom.<>f__mg$cache8C == null)
			{
				BindCustom.<>f__mg$cache8C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleHero.reg);
			}
			array[num141] = BindCustom.<>f__mg$cache8C;
			int num142 = 141;
			if (BindCustom.<>f__mg$cache8D == null)
			{
				BindCustom.<>f__mg$cache8D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleHeroJob.reg);
			}
			array[num142] = BindCustom.<>f__mg$cache8D;
			int num143 = 142;
			if (BindCustom.<>f__mg$cache8E == null)
			{
				BindCustom.<>f__mg$cache8E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.reg);
			}
			array[num143] = BindCustom.<>f__mg$cache8E;
			int num144 = 143;
			if (BindCustom.<>f__mg$cache8F == null)
			{
				BindCustom.<>f__mg$cache8F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.reg);
			}
			array[num144] = BindCustom.<>f__mg$cache8F;
			int num145 = 144;
			if (BindCustom.<>f__mg$cache90 == null)
			{
				BindCustom.<>f__mg$cache90 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleCommand.reg);
			}
			array[num145] = BindCustom.<>f__mg$cache90;
			int num146 = 145;
			if (BindCustom.<>f__mg$cache91 == null)
			{
				BindCustom.<>f__mg$cache91 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CommonBattleProperty.reg);
			}
			array[num146] = BindCustom.<>f__mg$cache91;
			int num147 = 146;
			if (BindCustom.<>f__mg$cache92 == null)
			{
				BindCustom.<>f__mg$cache92 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_Entity.reg);
			}
			array[num147] = BindCustom.<>f__mg$cache92;
			int num148 = 147;
			if (BindCustom.<>f__mg$cache93 == null)
			{
				BindCustom.<>f__mg$cache93 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleActor.reg);
			}
			array[num148] = BindCustom.<>f__mg$cache93;
			int num149 = 148;
			if (BindCustom.<>f__mg$cache94 == null)
			{
				BindCustom.<>f__mg$cache94 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleActorEquipment.reg);
			}
			array[num149] = BindCustom.<>f__mg$cache94;
			int num150 = 149;
			if (BindCustom.<>f__mg$cache95 == null)
			{
				BindCustom.<>f__mg$cache95 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BehaviorTarget.reg);
			}
			array[num150] = BindCustom.<>f__mg$cache95;
			int num151 = 150;
			if (BindCustom.<>f__mg$cache96 == null)
			{
				BindCustom.<>f__mg$cache96 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BuffState.reg);
			}
			array[num151] = BindCustom.<>f__mg$cache96;
			int num152 = 151;
			if (BindCustom.<>f__mg$cache97 == null)
			{
				BindCustom.<>f__mg$cache97 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleSkillState.reg);
			}
			array[num152] = BindCustom.<>f__mg$cache97;
			int num153 = 152;
			if (BindCustom.<>f__mg$cache98 == null)
			{
				BindCustom.<>f__mg$cache98 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleBase.reg);
			}
			array[num153] = BindCustom.<>f__mg$cache98;
			int num154 = 153;
			if (BindCustom.<>f__mg$cache99 == null)
			{
				BindCustom.<>f__mg$cache99 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleAchievementState.reg);
			}
			array[num154] = BindCustom.<>f__mg$cache99;
			int num155 = 154;
			if (BindCustom.<>f__mg$cache9A == null)
			{
				BindCustom.<>f__mg$cache9A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleWinConditionState.reg);
			}
			array[num155] = BindCustom.<>f__mg$cache9A;
			int num156 = 155;
			if (BindCustom.<>f__mg$cache9B == null)
			{
				BindCustom.<>f__mg$cache9B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleLoseConditionState.reg);
			}
			array[num156] = BindCustom.<>f__mg$cache9B;
			int num157 = 156;
			if (BindCustom.<>f__mg$cache9C == null)
			{
				BindCustom.<>f__mg$cache9C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleEventTriggerState.reg);
			}
			array[num157] = BindCustom.<>f__mg$cache9C;
			int num158 = 157;
			if (BindCustom.<>f__mg$cache9D == null)
			{
				BindCustom.<>f__mg$cache9D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleTeamSetup.reg);
			}
			array[num158] = BindCustom.<>f__mg$cache9D;
			int num159 = 158;
			if (BindCustom.<>f__mg$cache9E == null)
			{
				BindCustom.<>f__mg$cache9E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.reg);
			}
			array[num159] = BindCustom.<>f__mg$cache9E;
			int num160 = 159;
			if (BindCustom.<>f__mg$cache9F == null)
			{
				BindCustom.<>f__mg$cache9F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleTreasureState.reg);
			}
			array[num160] = BindCustom.<>f__mg$cache9F;
			int num161 = 160;
			if (BindCustom.<>f__mg$cacheA0 == null)
			{
				BindCustom.<>f__mg$cacheA0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleConst.reg);
			}
			array[num161] = BindCustom.<>f__mg$cacheA0;
			int num162 = 161;
			if (BindCustom.<>f__mg$cacheA1 == null)
			{
				BindCustom.<>f__mg$cacheA1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_CombatConst.reg);
			}
			array[num162] = BindCustom.<>f__mg$cacheA1;
			int num163 = 162;
			if (BindCustom.<>f__mg$cacheA2 == null)
			{
				BindCustom.<>f__mg$cacheA2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_ActorAnim.reg);
			}
			array[num163] = BindCustom.<>f__mg$cacheA2;
			int num164 = 163;
			if (BindCustom.<>f__mg$cacheA3 == null)
			{
				BindCustom.<>f__mg$cacheA3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleFormula.reg);
			}
			array[num164] = BindCustom.<>f__mg$cacheA3;
			int num165 = 164;
			if (BindCustom.<>f__mg$cacheA4 == null)
			{
				BindCustom.<>f__mg$cacheA4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleMapCell.reg);
			}
			array[num165] = BindCustom.<>f__mg$cacheA4;
			int num166 = 165;
			if (BindCustom.<>f__mg$cacheA5 == null)
			{
				BindCustom.<>f__mg$cacheA5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleMap.reg);
			}
			array[num166] = BindCustom.<>f__mg$cacheA5;
			int num167 = 166;
			if (BindCustom.<>f__mg$cacheA6 == null)
			{
				BindCustom.<>f__mg$cacheA6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattlePlayer.reg);
			}
			array[num167] = BindCustom.<>f__mg$cacheA6;
			int num168 = 167;
			if (BindCustom.<>f__mg$cacheA7 == null)
			{
				BindCustom.<>f__mg$cacheA7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattlePlayerTrainingTech.reg);
			}
			array[num168] = BindCustom.<>f__mg$cacheA7;
			int num169 = 168;
			if (BindCustom.<>f__mg$cacheA8 == null)
			{
				BindCustom.<>f__mg$cacheA8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleProperty.reg);
			}
			array[num169] = BindCustom.<>f__mg$cacheA8;
			int num170 = 169;
			if (BindCustom.<>f__mg$cacheA9 == null)
			{
				BindCustom.<>f__mg$cacheA9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattlePropertyModifier.reg);
			}
			array[num170] = BindCustom.<>f__mg$cacheA9;
			int num171 = 170;
			if (BindCustom.<>f__mg$cacheAA == null)
			{
				BindCustom.<>f__mg$cacheAA = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BattleTeam.reg);
			}
			array[num171] = BindCustom.<>f__mg$cacheAA;
			int num172 = 171;
			if (BindCustom.<>f__mg$cacheAB == null)
			{
				BindCustom.<>f__mg$cacheAB = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_BehaviorGroup.reg);
			}
			array[num172] = BindCustom.<>f__mg$cacheAB;
			int num173 = 172;
			if (BindCustom.<>f__mg$cacheAC == null)
			{
				BindCustom.<>f__mg$cacheAC = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_Combat.reg);
			}
			array[num173] = BindCustom.<>f__mg$cacheAC;
			int num174 = 173;
			if (BindCustom.<>f__mg$cacheAD == null)
			{
				BindCustom.<>f__mg$cacheAD = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_CombatActor.reg);
			}
			array[num174] = BindCustom.<>f__mg$cacheAD;
			int num175 = 174;
			if (BindCustom.<>f__mg$cacheAE == null)
			{
				BindCustom.<>f__mg$cacheAE = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_CombatSkillState.reg);
			}
			array[num175] = BindCustom.<>f__mg$cacheAE;
			int num176 = 175;
			if (BindCustom.<>f__mg$cacheAF == null)
			{
				BindCustom.<>f__mg$cacheAF = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_CombatFlyObject.reg);
			}
			array[num176] = BindCustom.<>f__mg$cacheAF;
			int num177 = 176;
			if (BindCustom.<>f__mg$cacheB0 == null)
			{
				BindCustom.<>f__mg$cacheB0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_CombatTeam.reg);
			}
			array[num177] = BindCustom.<>f__mg$cacheB0;
			int num178 = 177;
			if (BindCustom.<>f__mg$cacheB1 == null)
			{
				BindCustom.<>f__mg$cacheB1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_EntityList.reg);
			}
			array[num178] = BindCustom.<>f__mg$cacheB1;
			int num179 = 178;
			if (BindCustom.<>f__mg$cacheB2 == null)
			{
				BindCustom.<>f__mg$cacheB2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_NullBattleListener.reg);
			}
			array[num179] = BindCustom.<>f__mg$cacheB2;
			int num180 = 179;
			if (BindCustom.<>f__mg$cacheB3 == null)
			{
				BindCustom.<>f__mg$cacheB3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_PathNode.reg);
			}
			array[num180] = BindCustom.<>f__mg$cacheB3;
			int num181 = 180;
			if (BindCustom.<>f__mg$cacheB4 == null)
			{
				BindCustom.<>f__mg$cacheB4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_Pathfinder.reg);
			}
			array[num181] = BindCustom.<>f__mg$cacheB4;
			int num182 = 181;
			if (BindCustom.<>f__mg$cacheB5 == null)
			{
				BindCustom.<>f__mg$cacheB5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.reg);
			}
			array[num182] = BindCustom.<>f__mg$cacheB5;
			int num183 = 182;
			if (BindCustom.<>f__mg$cacheB6 == null)
			{
				BindCustom.<>f__mg$cacheB6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RandomNumber.reg);
			}
			array[num183] = BindCustom.<>f__mg$cacheB6;
			int num184 = 183;
			if (BindCustom.<>f__mg$cacheB7 == null)
			{
				BindCustom.<>f__mg$cacheB7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.reg);
			}
			array[num184] = BindCustom.<>f__mg$cacheB7;
			int num185 = 184;
			if (BindCustom.<>f__mg$cacheB8 == null)
			{
				BindCustom.<>f__mg$cacheB8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RealTimePVPInfo.reg);
			}
			array[num185] = BindCustom.<>f__mg$cacheB8;
			int num186 = 185;
			if (BindCustom.<>f__mg$cacheB9 == null)
			{
				BindCustom.<>f__mg$cacheB9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleUtility.reg);
			}
			array[num186] = BindCustom.<>f__mg$cacheB9;
			int num187 = 186;
			if (BindCustom.<>f__mg$cacheBA == null)
			{
				BindCustom.<>f__mg$cacheBA = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BusinessCard.reg);
			}
			array[num187] = BindCustom.<>f__mg$cacheBA;
			int num188 = 187;
			if (BindCustom.<>f__mg$cacheBB == null)
			{
				BindCustom.<>f__mg$cacheBB = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.reg);
			}
			array[num188] = BindCustom.<>f__mg$cacheBB;
			int num189 = 188;
			if (BindCustom.<>f__mg$cacheBC == null)
			{
				BindCustom.<>f__mg$cacheBC = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.reg);
			}
			array[num189] = BindCustom.<>f__mg$cacheBC;
			int num190 = 189;
			if (BindCustom.<>f__mg$cacheBD == null)
			{
				BindCustom.<>f__mg$cacheBD = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BusinessCardHeroSet.reg);
			}
			array[num190] = BindCustom.<>f__mg$cacheBD;
			int num191 = 190;
			if (BindCustom.<>f__mg$cacheBE == null)
			{
				BindCustom.<>f__mg$cacheBE = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.reg);
			}
			array[num191] = BindCustom.<>f__mg$cacheBE;
			int num192 = 191;
			if (BindCustom.<>f__mg$cacheBF == null)
			{
				BindCustom.<>f__mg$cacheBF = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_FriendConstDefine.reg);
			}
			array[num192] = BindCustom.<>f__mg$cacheBF;
			int num193 = 192;
			if (BindCustom.<>f__mg$cacheC0 == null)
			{
				BindCustom.<>f__mg$cacheC0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CommonConstDefine.reg);
			}
			array[num193] = BindCustom.<>f__mg$cacheC0;
			int num194 = 193;
			if (BindCustom.<>f__mg$cacheC1 == null)
			{
				BindCustom.<>f__mg$cacheC1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.reg);
			}
			array[num194] = BindCustom.<>f__mg$cacheC1;
			int num195 = 194;
			if (BindCustom.<>f__mg$cacheC2 == null)
			{
				BindCustom.<>f__mg$cacheC2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_Guild.reg);
			}
			array[num195] = BindCustom.<>f__mg$cacheC2;
			int num196 = 195;
			if (BindCustom.<>f__mg$cacheC3 == null)
			{
				BindCustom.<>f__mg$cacheC3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GuildMember.reg);
			}
			array[num196] = BindCustom.<>f__mg$cacheC3;
			int num197 = 196;
			if (BindCustom.<>f__mg$cacheC4 == null)
			{
				BindCustom.<>f__mg$cacheC4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GuildMemberCacheObject.reg);
			}
			array[num197] = BindCustom.<>f__mg$cacheC4;
			int num198 = 197;
			if (BindCustom.<>f__mg$cacheC5 == null)
			{
				BindCustom.<>f__mg$cacheC5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GuildSearchInfo.reg);
			}
			array[num198] = BindCustom.<>f__mg$cacheC5;
			int num199 = 198;
			if (BindCustom.<>f__mg$cacheC6 == null)
			{
				BindCustom.<>f__mg$cacheC6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatStronghold.reg);
			}
			array[num199] = BindCustom.<>f__mg$cacheC6;
			int num200 = 199;
			if (BindCustom.<>f__mg$cacheC7 == null)
			{
				BindCustom.<>f__mg$cacheC7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatMemberInfo.reg);
			}
			array[num200] = BindCustom.<>f__mg$cacheC7;
			int num201 = 200;
			if (BindCustom.<>f__mg$cacheC8 == null)
			{
				BindCustom.<>f__mg$cacheC8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatInfo.reg);
			}
			array[num201] = BindCustom.<>f__mg$cacheC8;
			int num202 = 201;
			if (BindCustom.<>f__mg$cacheC9 == null)
			{
				BindCustom.<>f__mg$cacheC9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GuildMassiveCombatGeneral.reg);
			}
			array[num202] = BindCustom.<>f__mg$cacheC9;
			int num203 = 202;
			if (BindCustom.<>f__mg$cacheCA == null)
			{
				BindCustom.<>f__mg$cacheCA = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GuildPlayerMassiveCombatInfo.reg);
			}
			array[num203] = BindCustom.<>f__mg$cacheCA;
			int num204 = 203;
			if (BindCustom.<>f__mg$cacheCB == null)
			{
				BindCustom.<>f__mg$cacheCB = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_Hero.reg);
			}
			array[num204] = BindCustom.<>f__mg$cacheCB;
			int num205 = 204;
			if (BindCustom.<>f__mg$cacheCC == null)
			{
				BindCustom.<>f__mg$cacheCC = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroJob.reg);
			}
			array[num205] = BindCustom.<>f__mg$cacheCC;
			int num206 = 205;
			if (BindCustom.<>f__mg$cacheCD == null)
			{
				BindCustom.<>f__mg$cacheCD = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RandomEventLevelZone.reg);
			}
			array[num206] = BindCustom.<>f__mg$cacheCD;
			int num207 = 206;
			if (BindCustom.<>f__mg$cacheCE == null)
			{
				BindCustom.<>f__mg$cacheCE = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RandomEventGroup.reg);
			}
			array[num207] = BindCustom.<>f__mg$cacheCE;
			int num208 = 207;
			if (BindCustom.<>f__mg$cacheCF == null)
			{
				BindCustom.<>f__mg$cacheCF = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RandomEvent.reg);
			}
			array[num208] = BindCustom.<>f__mg$cacheCF;
			int num209 = 208;
			if (BindCustom.<>f__mg$cacheD0 == null)
			{
				BindCustom.<>f__mg$cacheD0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CommonReportLog.reg);
			}
			array[num209] = BindCustom.<>f__mg$cacheD0;
			int num210 = 209;
			if (BindCustom.<>f__mg$cacheD1 == null)
			{
				BindCustom.<>f__mg$cacheD1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleReportLog.reg);
			}
			array[num210] = BindCustom.<>f__mg$cacheD1;
			int num211 = 210;
			if (BindCustom.<>f__mg$cacheD2 == null)
			{
				BindCustom.<>f__mg$cacheD2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleRoomBattleLog.reg);
			}
			array[num211] = BindCustom.<>f__mg$cacheD2;
			int num212 = 211;
			if (BindCustom.<>f__mg$cacheD3 == null)
			{
				BindCustom.<>f__mg$cacheD3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_SoldierSkin.reg);
			}
			array[num212] = BindCustom.<>f__mg$cacheD3;
			int num213 = 212;
			if (BindCustom.<>f__mg$cacheD4 == null)
			{
				BindCustom.<>f__mg$cacheD4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TeamRoom.reg);
			}
			array[num213] = BindCustom.<>f__mg$cacheD4;
			int num214 = 213;
			if (BindCustom.<>f__mg$cacheD5 == null)
			{
				BindCustom.<>f__mg$cacheD5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TeamRoomSetting.reg);
			}
			array[num214] = BindCustom.<>f__mg$cacheD5;
			int num215 = 214;
			if (BindCustom.<>f__mg$cacheD6 == null)
			{
				BindCustom.<>f__mg$cacheD6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TeamRoomInviteInfo.reg);
			}
			array[num215] = BindCustom.<>f__mg$cacheD6;
			int num216 = 215;
			if (BindCustom.<>f__mg$cacheD7 == null)
			{
				BindCustom.<>f__mg$cacheD7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TeamRoomPlayer.reg);
			}
			array[num216] = BindCustom.<>f__mg$cacheD7;
			int num217 = 216;
			if (BindCustom.<>f__mg$cacheD8 == null)
			{
				BindCustom.<>f__mg$cacheD8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TrainingGround.reg);
			}
			array[num217] = BindCustom.<>f__mg$cacheD8;
			int num218 = 217;
			if (BindCustom.<>f__mg$cacheD9 == null)
			{
				BindCustom.<>f__mg$cacheD9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TrainingRoom.reg);
			}
			array[num218] = BindCustom.<>f__mg$cacheD9;
			int num219 = 218;
			if (BindCustom.<>f__mg$cacheDA == null)
			{
				BindCustom.<>f__mg$cacheDA = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TrainingCourse.reg);
			}
			array[num219] = BindCustom.<>f__mg$cacheDA;
			int num220 = 219;
			if (BindCustom.<>f__mg$cacheDB == null)
			{
				BindCustom.<>f__mg$cacheDB = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TrainingTech.reg);
			}
			array[num220] = BindCustom.<>f__mg$cacheDB;
			int num221 = 220;
			if (BindCustom.<>f__mg$cacheDC == null)
			{
				BindCustom.<>f__mg$cacheDC = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_UserSocialRelation.reg);
			}
			array[num221] = BindCustom.<>f__mg$cacheDC;
			int num222 = 221;
			if (BindCustom.<>f__mg$cacheDD == null)
			{
				BindCustom.<>f__mg$cacheDD = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_UserSummary.reg);
			}
			array[num222] = BindCustom.<>f__mg$cacheDD;
			int num223 = 222;
			if (BindCustom.<>f__mg$cacheDE == null)
			{
				BindCustom.<>f__mg$cacheDE = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RoleGenerator.reg);
			}
			array[num223] = BindCustom.<>f__mg$cacheDE;
			int num224 = 223;
			if (BindCustom.<>f__mg$cacheDF == null)
			{
				BindCustom.<>f__mg$cacheDF = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RoleInfo.reg);
			}
			array[num224] = BindCustom.<>f__mg$cacheDF;
			int num225 = 224;
			if (BindCustom.<>f__mg$cacheE0 == null)
			{
				BindCustom.<>f__mg$cacheE0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GoodsNextFlushCaculateTools.reg);
			}
			array[num225] = BindCustom.<>f__mg$cacheE0;
			int num226 = 225;
			if (BindCustom.<>f__mg$cacheE1 == null)
			{
				BindCustom.<>f__mg$cacheE1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_AnikiGymComponentCommon.reg);
			}
			array[num226] = BindCustom.<>f__mg$cacheE1;
			int num227 = 226;
			if (BindCustom.<>f__mg$cacheE2 == null)
			{
				BindCustom.<>f__mg$cacheE2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaComponentCommon.reg);
			}
			array[num227] = BindCustom.<>f__mg$cacheE2;
			int num228 = 227;
			if (BindCustom.<>f__mg$cacheE3 == null)
			{
				BindCustom.<>f__mg$cacheE3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BagComponentCommon.reg);
			}
			array[num228] = BindCustom.<>f__mg$cacheE3;
			int num229 = 228;
			if (BindCustom.<>f__mg$cacheE4 == null)
			{
				BindCustom.<>f__mg$cacheE4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleComponentCommon.reg);
			}
			array[num229] = BindCustom.<>f__mg$cacheE4;
			int num230 = 229;
			if (BindCustom.<>f__mg$cacheE5 == null)
			{
				BindCustom.<>f__mg$cacheE5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.reg);
			}
			array[num230] = BindCustom.<>f__mg$cacheE5;
			int num231 = 230;
			if (BindCustom.<>f__mg$cacheE6 == null)
			{
				BindCustom.<>f__mg$cacheE6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.reg);
			}
			array[num231] = BindCustom.<>f__mg$cacheE6;
			int num232 = 231;
			if (BindCustom.<>f__mg$cacheE7 == null)
			{
				BindCustom.<>f__mg$cacheE7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ClimbTowerComponentCommon.reg);
			}
			array[num232] = BindCustom.<>f__mg$cacheE7;
			int num233 = 232;
			if (BindCustom.<>f__mg$cacheE8 == null)
			{
				BindCustom.<>f__mg$cacheE8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.reg);
			}
			array[num233] = BindCustom.<>f__mg$cacheE8;
			int num234 = 233;
			if (BindCustom.<>f__mg$cacheE9 == null)
			{
				BindCustom.<>f__mg$cacheE9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.reg);
			}
			array[num234] = BindCustom.<>f__mg$cacheE9;
			int num235 = 234;
			if (BindCustom.<>f__mg$cacheEA == null)
			{
				BindCustom.<>f__mg$cacheEA = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CooperateBattleCompomentCommon.reg);
			}
			array[num235] = BindCustom.<>f__mg$cacheEA;
			int num236 = 235;
			if (BindCustom.<>f__mg$cacheEB == null)
			{
				BindCustom.<>f__mg$cacheEB = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DanmakuComponentCommon.reg);
			}
			array[num236] = BindCustom.<>f__mg$cacheEB;
			int num237 = 236;
			if (BindCustom.<>f__mg$cacheEC == null)
			{
				BindCustom.<>f__mg$cacheEC = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_FixedStoreComponentCommon.reg);
			}
			array[num237] = BindCustom.<>f__mg$cacheEC;
			int num238 = 237;
			if (BindCustom.<>f__mg$cacheED == null)
			{
				BindCustom.<>f__mg$cacheED = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.reg);
			}
			array[num238] = BindCustom.<>f__mg$cacheED;
			int num239 = 238;
			if (BindCustom.<>f__mg$cacheEE == null)
			{
				BindCustom.<>f__mg$cacheEE = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GiftStoreComponentCommon.reg);
			}
			array[num239] = BindCustom.<>f__mg$cacheEE;
			int num240 = 239;
			if (BindCustom.<>f__mg$cacheEF == null)
			{
				BindCustom.<>f__mg$cacheEF = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon.reg);
			}
			array[num240] = BindCustom.<>f__mg$cacheEF;
			int num241 = 240;
			if (BindCustom.<>f__mg$cacheF0 == null)
			{
				BindCustom.<>f__mg$cacheF0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GuildComponentCommon.reg);
			}
			array[num241] = BindCustom.<>f__mg$cacheF0;
			int num242 = 241;
			if (BindCustom.<>f__mg$cacheF1 == null)
			{
				BindCustom.<>f__mg$cacheF1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.reg);
			}
			array[num242] = BindCustom.<>f__mg$cacheF1;
			int num243 = 242;
			if (BindCustom.<>f__mg$cacheF2 == null)
			{
				BindCustom.<>f__mg$cacheF2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroComponentCommon.reg);
			}
			array[num243] = BindCustom.<>f__mg$cacheF2;
			int num244 = 243;
			if (BindCustom.<>f__mg$cacheF3 == null)
			{
				BindCustom.<>f__mg$cacheF3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroDungeonComponentCommon.reg);
			}
			array[num244] = BindCustom.<>f__mg$cacheF3;
			int num245 = 244;
			if (BindCustom.<>f__mg$cacheF4 == null)
			{
				BindCustom.<>f__mg$cacheF4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroPhantomCompomentCommon.reg);
			}
			array[num245] = BindCustom.<>f__mg$cacheF4;
			int num246 = 245;
			if (BindCustom.<>f__mg$cacheF5 == null)
			{
				BindCustom.<>f__mg$cacheF5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroTrainningComponentCommon.reg);
			}
			array[num246] = BindCustom.<>f__mg$cacheF5;
			int num247 = 246;
			if (BindCustom.<>f__mg$cacheF6 == null)
			{
				BindCustom.<>f__mg$cacheF6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_LevelComponentCommon.reg);
			}
			array[num247] = BindCustom.<>f__mg$cacheF6;
			int num248 = 247;
			if (BindCustom.<>f__mg$cacheF7 == null)
			{
				BindCustom.<>f__mg$cacheF7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_MailComponentCommon.reg);
			}
			array[num248] = BindCustom.<>f__mg$cacheF7;
			int num249 = 248;
			if (BindCustom.<>f__mg$cacheF8 == null)
			{
				BindCustom.<>f__mg$cacheF8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_MemoryCorridorCompomentCommon.reg);
			}
			array[num249] = BindCustom.<>f__mg$cacheF8;
			int num250 = 249;
			if (BindCustom.<>f__mg$cacheF9 == null)
			{
				BindCustom.<>f__mg$cacheF9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_MissionComponentCommon.reg);
			}
			array[num250] = BindCustom.<>f__mg$cacheF9;
			int num251 = 250;
			if (BindCustom.<>f__mg$cacheFA == null)
			{
				BindCustom.<>f__mg$cacheFA = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_NoviceComponentCommon.reg);
			}
			array[num251] = BindCustom.<>f__mg$cacheFA;
			int num252 = 251;
			if (BindCustom.<>f__mg$cacheFB == null)
			{
				BindCustom.<>f__mg$cacheFB = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.reg);
			}
			array[num252] = BindCustom.<>f__mg$cacheFB;
			int num253 = 252;
			if (BindCustom.<>f__mg$cacheFC == null)
			{
				BindCustom.<>f__mg$cacheFC = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.reg);
			}
			array[num253] = BindCustom.<>f__mg$cacheFC;
			int num254 = 253;
			if (BindCustom.<>f__mg$cacheFD == null)
			{
				BindCustom.<>f__mg$cacheFD = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RaffleComponentCommon.reg);
			}
			array[num254] = BindCustom.<>f__mg$cacheFD;
			int num255 = 254;
			if (BindCustom.<>f__mg$cacheFE == null)
			{
				BindCustom.<>f__mg$cacheFE = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RandomStoreComponentCommon.reg);
			}
			array[num255] = BindCustom.<>f__mg$cacheFE;
			int num256 = 255;
			if (BindCustom.<>f__mg$cacheFF == null)
			{
				BindCustom.<>f__mg$cacheFF = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RealTimePVPComponentCommon.reg);
			}
			array[num256] = BindCustom.<>f__mg$cacheFF;
			int num257 = 256;
			if (BindCustom.<>f__mg$cache100 == null)
			{
				BindCustom.<>f__mg$cache100 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RechargeStoreComponentCommon.reg);
			}
			array[num257] = BindCustom.<>f__mg$cache100;
			int num258 = 257;
			if (BindCustom.<>f__mg$cache101 == null)
			{
				BindCustom.<>f__mg$cache101 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.reg);
			}
			array[num258] = BindCustom.<>f__mg$cache101;
			int num259 = 258;
			if (BindCustom.<>f__mg$cache102 == null)
			{
				BindCustom.<>f__mg$cache102 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RiftComponentCommon.reg);
			}
			array[num259] = BindCustom.<>f__mg$cache102;
			int num260 = 259;
			if (BindCustom.<>f__mg$cache103 == null)
			{
				BindCustom.<>f__mg$cache103 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_SelectCardComponentCommon.reg);
			}
			array[num260] = BindCustom.<>f__mg$cache103;
			int num261 = 260;
			if (BindCustom.<>f__mg$cache104 == null)
			{
				BindCustom.<>f__mg$cache104 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.reg);
			}
			array[num261] = BindCustom.<>f__mg$cache104;
			int num262 = 261;
			if (BindCustom.<>f__mg$cache105 == null)
			{
				BindCustom.<>f__mg$cache105 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.reg);
			}
			array[num262] = BindCustom.<>f__mg$cache105;
			int num263 = 262;
			if (BindCustom.<>f__mg$cache106 == null)
			{
				BindCustom.<>f__mg$cache106 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ThearchyTrialCompomentCommon.reg);
			}
			array[num263] = BindCustom.<>f__mg$cache106;
			int num264 = 263;
			if (BindCustom.<>f__mg$cache107 == null)
			{
				BindCustom.<>f__mg$cache107 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.reg);
			}
			array[num264] = BindCustom.<>f__mg$cache107;
			int num265 = 264;
			if (BindCustom.<>f__mg$cache108 == null)
			{
				BindCustom.<>f__mg$cache108 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TreasureMapComponentCommon.reg);
			}
			array[num265] = BindCustom.<>f__mg$cache108;
			int num266 = 265;
			if (BindCustom.<>f__mg$cache109 == null)
			{
				BindCustom.<>f__mg$cache109 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_UnchartedScoreComponentCommon.reg);
			}
			array[num266] = BindCustom.<>f__mg$cache109;
			int num267 = 266;
			if (BindCustom.<>f__mg$cache10A == null)
			{
				BindCustom.<>f__mg$cache10A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSection.reg);
			}
			array[num267] = BindCustom.<>f__mg$cache10A;
			int num268 = 267;
			if (BindCustom.<>f__mg$cache10B == null)
			{
				BindCustom.<>f__mg$cache10B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.reg);
			}
			array[num268] = BindCustom.<>f__mg$cache10B;
			int num269 = 268;
			if (BindCustom.<>f__mg$cache10C == null)
			{
				BindCustom.<>f__mg$cache10C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionAnnouncement.reg);
			}
			array[num269] = BindCustom.<>f__mg$cache10C;
			int num270 = 269;
			if (BindCustom.<>f__mg$cache10D == null)
			{
				BindCustom.<>f__mg$cache10D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionArena.reg);
			}
			array[num270] = BindCustom.<>f__mg$cache10D;
			int num271 = 270;
			if (BindCustom.<>f__mg$cache10E == null)
			{
				BindCustom.<>f__mg$cache10E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.reg);
			}
			array[num271] = BindCustom.<>f__mg$cache10E;
			int num272 = 271;
			if (BindCustom.<>f__mg$cache10F == null)
			{
				BindCustom.<>f__mg$cache10F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionBag.reg);
			}
			array[num272] = BindCustom.<>f__mg$cache10F;
			int num273 = 272;
			if (BindCustom.<>f__mg$cache110 == null)
			{
				BindCustom.<>f__mg$cache110 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionBattle.reg);
			}
			array[num273] = BindCustom.<>f__mg$cache110;
			int num274 = 273;
			if (BindCustom.<>f__mg$cache111 == null)
			{
				BindCustom.<>f__mg$cache111 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionChat.reg);
			}
			array[num274] = BindCustom.<>f__mg$cache111;
			int num275 = 274;
			if (BindCustom.<>f__mg$cache112 == null)
			{
				BindCustom.<>f__mg$cache112 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionComment.reg);
			}
			array[num275] = BindCustom.<>f__mg$cache112;
			int num276 = 275;
			if (BindCustom.<>f__mg$cache113 == null)
			{
				BindCustom.<>f__mg$cache113 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionCooperateBattle.reg);
			}
			array[num276] = BindCustom.<>f__mg$cache113;
			int num277 = 276;
			if (BindCustom.<>f__mg$cache114 == null)
			{
				BindCustom.<>f__mg$cache114 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.reg);
			}
			array[num277] = BindCustom.<>f__mg$cache114;
			int num278 = 277;
			if (BindCustom.<>f__mg$cache115 == null)
			{
				BindCustom.<>f__mg$cache115 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionFixedStore.reg);
			}
			array[num278] = BindCustom.<>f__mg$cache115;
			int num279 = 278;
			if (BindCustom.<>f__mg$cache116 == null)
			{
				BindCustom.<>f__mg$cache116 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionFriend.reg);
			}
			array[num279] = BindCustom.<>f__mg$cache116;
			int num280 = 279;
			if (BindCustom.<>f__mg$cache117 == null)
			{
				BindCustom.<>f__mg$cache117 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionGiftStore.reg);
			}
			array[num280] = BindCustom.<>f__mg$cache117;
			int num281 = 280;
			if (BindCustom.<>f__mg$cache118 == null)
			{
				BindCustom.<>f__mg$cache118 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionHero.reg);
			}
			array[num281] = BindCustom.<>f__mg$cache118;
			int num282 = 281;
			if (BindCustom.<>f__mg$cache119 == null)
			{
				BindCustom.<>f__mg$cache119 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionHeroAssistants.reg);
			}
			array[num282] = BindCustom.<>f__mg$cache119;
			int num283 = 282;
			if (BindCustom.<>f__mg$cache11A == null)
			{
				BindCustom.<>f__mg$cache11A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionHeroDungeon.reg);
			}
			array[num283] = BindCustom.<>f__mg$cache11A;
			int num284 = 283;
			if (BindCustom.<>f__mg$cache11B == null)
			{
				BindCustom.<>f__mg$cache11B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.reg);
			}
			array[num284] = BindCustom.<>f__mg$cache11B;
			int num285 = 284;
			if (BindCustom.<>f__mg$cache11C == null)
			{
				BindCustom.<>f__mg$cache11C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.reg);
			}
			array[num285] = BindCustom.<>f__mg$cache11C;
			int num286 = 285;
			if (BindCustom.<>f__mg$cache11D == null)
			{
				BindCustom.<>f__mg$cache11D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionLevel.reg);
			}
			array[num286] = BindCustom.<>f__mg$cache11D;
			int num287 = 286;
			if (BindCustom.<>f__mg$cache11E == null)
			{
				BindCustom.<>f__mg$cache11E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionMail.reg);
			}
			array[num287] = BindCustom.<>f__mg$cache11E;
			int num288 = 287;
			if (BindCustom.<>f__mg$cache11F == null)
			{
				BindCustom.<>f__mg$cache11F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.reg);
			}
			array[num288] = BindCustom.<>f__mg$cache11F;
			int num289 = 288;
			if (BindCustom.<>f__mg$cache120 == null)
			{
				BindCustom.<>f__mg$cache120 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionMission.reg);
			}
			array[num289] = BindCustom.<>f__mg$cache120;
			int num290 = 289;
			if (BindCustom.<>f__mg$cache121 == null)
			{
				BindCustom.<>f__mg$cache121 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionNovice.reg);
			}
			array[num290] = BindCustom.<>f__mg$cache121;
			int num291 = 290;
			if (BindCustom.<>f__mg$cache122 == null)
			{
				BindCustom.<>f__mg$cache122 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.reg);
			}
			array[num291] = BindCustom.<>f__mg$cache122;
			int num292 = 291;
			if (BindCustom.<>f__mg$cache123 == null)
			{
				BindCustom.<>f__mg$cache123 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.reg);
			}
			array[num292] = BindCustom.<>f__mg$cache123;
			int num293 = 292;
			if (BindCustom.<>f__mg$cache124 == null)
			{
				BindCustom.<>f__mg$cache124 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionRaffle.reg);
			}
			array[num293] = BindCustom.<>f__mg$cache124;
			int num294 = 293;
			if (BindCustom.<>f__mg$cache125 == null)
			{
				BindCustom.<>f__mg$cache125 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.reg);
			}
			array[num294] = BindCustom.<>f__mg$cache125;
			int num295 = 294;
			if (BindCustom.<>f__mg$cache126 == null)
			{
				BindCustom.<>f__mg$cache126 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionRandomStore.reg);
			}
			array[num295] = BindCustom.<>f__mg$cache126;
			int num296 = 295;
			if (BindCustom.<>f__mg$cache127 == null)
			{
				BindCustom.<>f__mg$cache127 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.reg);
			}
			array[num296] = BindCustom.<>f__mg$cache127;
			int num297 = 296;
			if (BindCustom.<>f__mg$cache128 == null)
			{
				BindCustom.<>f__mg$cache128 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RealTimePVPMatchStats.reg);
			}
			array[num297] = BindCustom.<>f__mg$cache128;
			int num298 = 297;
			if (BindCustom.<>f__mg$cache129 == null)
			{
				BindCustom.<>f__mg$cache129 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionRechargeStore.reg);
			}
			array[num298] = BindCustom.<>f__mg$cache129;
			int num299 = 298;
			if (BindCustom.<>f__mg$cache12A == null)
			{
				BindCustom.<>f__mg$cache12A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionResource.reg);
			}
			array[num299] = BindCustom.<>f__mg$cache12A;
			int num300 = 299;
			if (BindCustom.<>f__mg$cache12B == null)
			{
				BindCustom.<>f__mg$cache12B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionRift.reg);
			}
			array[num300] = BindCustom.<>f__mg$cache12B;
			int num301 = 300;
			if (BindCustom.<>f__mg$cache12C == null)
			{
				BindCustom.<>f__mg$cache12C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionSelectCard.reg);
			}
			array[num301] = BindCustom.<>f__mg$cache12C;
			int num302 = 301;
			if (BindCustom.<>f__mg$cache12D == null)
			{
				BindCustom.<>f__mg$cache12D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.reg);
			}
			array[num302] = BindCustom.<>f__mg$cache12D;
			int num303 = 302;
			if (BindCustom.<>f__mg$cache12E == null)
			{
				BindCustom.<>f__mg$cache12E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionSurvey.reg);
			}
			array[num303] = BindCustom.<>f__mg$cache12E;
			int num304 = 303;
			if (BindCustom.<>f__mg$cache12F == null)
			{
				BindCustom.<>f__mg$cache12F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionTeam.reg);
			}
			array[num304] = BindCustom.<>f__mg$cache12F;
			int num305 = 304;
			if (BindCustom.<>f__mg$cache130 == null)
			{
				BindCustom.<>f__mg$cache130 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.reg);
			}
			array[num305] = BindCustom.<>f__mg$cache130;
			int num306 = 305;
			if (BindCustom.<>f__mg$cache131 == null)
			{
				BindCustom.<>f__mg$cache131 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.reg);
			}
			array[num306] = BindCustom.<>f__mg$cache131;
			int num307 = 306;
			if (BindCustom.<>f__mg$cache132 == null)
			{
				BindCustom.<>f__mg$cache132 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.reg);
			}
			array[num307] = BindCustom.<>f__mg$cache132;
			int num308 = 307;
			if (BindCustom.<>f__mg$cache133 == null)
			{
				BindCustom.<>f__mg$cache133 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_Announcement.reg);
			}
			array[num308] = BindCustom.<>f__mg$cache133;
			int num309 = 308;
			if (BindCustom.<>f__mg$cache134 == null)
			{
				BindCustom.<>f__mg$cache134 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaPlayerInfo.reg);
			}
			array[num309] = BindCustom.<>f__mg$cache134;
			int num310 = 309;
			if (BindCustom.<>f__mg$cache135 == null)
			{
				BindCustom.<>f__mg$cache135 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeam.reg);
			}
			array[num310] = BindCustom.<>f__mg$cache135;
			int num311 = 310;
			if (BindCustom.<>f__mg$cache136 == null)
			{
				BindCustom.<>f__mg$cache136 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveHero.reg);
			}
			array[num311] = BindCustom.<>f__mg$cache136;
			int num312 = 311;
			if (BindCustom.<>f__mg$cache137 == null)
			{
				BindCustom.<>f__mg$cache137 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaPlayerDefensiveTeamSnapshot.reg);
			}
			array[num312] = BindCustom.<>f__mg$cache137;
			int num313 = 312;
			if (BindCustom.<>f__mg$cache138 == null)
			{
				BindCustom.<>f__mg$cache138 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaOpponentDefensiveBattleInfo.reg);
			}
			array[num313] = BindCustom.<>f__mg$cache138;
			int num314 = 313;
			if (BindCustom.<>f__mg$cache139 == null)
			{
				BindCustom.<>f__mg$cache139 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaOpponent.reg);
			}
			array[num314] = BindCustom.<>f__mg$cache139;
			int num315 = 314;
			if (BindCustom.<>f__mg$cache13A == null)
			{
				BindCustom.<>f__mg$cache13A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.reg);
			}
			array[num315] = BindCustom.<>f__mg$cache13A;
			int num316 = 315;
			if (BindCustom.<>f__mg$cache13B == null)
			{
				BindCustom.<>f__mg$cache13B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.reg);
			}
			array[num316] = BindCustom.<>f__mg$cache13B;
			int num317 = 316;
			if (BindCustom.<>f__mg$cache13C == null)
			{
				BindCustom.<>f__mg$cache13C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BattleReport.reg);
			}
			array[num317] = BindCustom.<>f__mg$cache13C;
			int num318 = 317;
			if (BindCustom.<>f__mg$cache13D == null)
			{
				BindCustom.<>f__mg$cache13D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaBattleReport.reg);
			}
			array[num318] = BindCustom.<>f__mg$cache13D;
			int num319 = 318;
			if (BindCustom.<>f__mg$cache13E == null)
			{
				BindCustom.<>f__mg$cache13E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ArenaBattleReportUpdateCache.reg);
			}
			array[num319] = BindCustom.<>f__mg$cache13E;
			int num320 = 319;
			if (BindCustom.<>f__mg$cache13F == null)
			{
				BindCustom.<>f__mg$cache13F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BagItemBase.reg);
			}
			array[num320] = BindCustom.<>f__mg$cache13F;
			int num321 = 320;
			if (BindCustom.<>f__mg$cache140 == null)
			{
				BindCustom.<>f__mg$cache140 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GoodsFactory.reg);
			}
			array[num321] = BindCustom.<>f__mg$cache140;
			int num322 = 321;
			if (BindCustom.<>f__mg$cache141 == null)
			{
				BindCustom.<>f__mg$cache141 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BagItemFactory.reg);
			}
			array[num322] = BindCustom.<>f__mg$cache141;
			int num323 = 322;
			if (BindCustom.<>f__mg$cache142 == null)
			{
				BindCustom.<>f__mg$cache142 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_EquipmentBagItem.reg);
			}
			array[num323] = BindCustom.<>f__mg$cache142;
			int num324 = 323;
			if (BindCustom.<>f__mg$cache143 == null)
			{
				BindCustom.<>f__mg$cache143 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroExpUseableBagItem.reg);
			}
			array[num324] = BindCustom.<>f__mg$cache143;
			int num325 = 324;
			if (BindCustom.<>f__mg$cache144 == null)
			{
				BindCustom.<>f__mg$cache144 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.reg);
			}
			array[num325] = BindCustom.<>f__mg$cache144;
			int num326 = 325;
			if (BindCustom.<>f__mg$cache145 == null)
			{
				BindCustom.<>f__mg$cache145 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GoldUsableBagItem.reg);
			}
			array[num326] = BindCustom.<>f__mg$cache145;
			int num327 = 326;
			if (BindCustom.<>f__mg$cache146 == null)
			{
				BindCustom.<>f__mg$cache146 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CrystalUsableBagItem.reg);
			}
			array[num327] = BindCustom.<>f__mg$cache146;
			int num328 = 327;
			if (BindCustom.<>f__mg$cache147 == null)
			{
				BindCustom.<>f__mg$cache147 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_EnergyUsableBagItem.reg);
			}
			array[num328] = BindCustom.<>f__mg$cache147;
			int num329 = 328;
			if (BindCustom.<>f__mg$cache148 == null)
			{
				BindCustom.<>f__mg$cache148 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ChangeNameUsableBagItem.reg);
			}
			array[num329] = BindCustom.<>f__mg$cache148;
			int num330 = 329;
			if (BindCustom.<>f__mg$cache149 == null)
			{
				BindCustom.<>f__mg$cache149 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_UnusableBagItem.reg);
			}
			array[num330] = BindCustom.<>f__mg$cache149;
			int num331 = 330;
			if (BindCustom.<>f__mg$cache14A == null)
			{
				BindCustom.<>f__mg$cache14A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_JobMaterialBagItem.reg);
			}
			array[num331] = BindCustom.<>f__mg$cache14A;
			int num332 = 331;
			if (BindCustom.<>f__mg$cache14B == null)
			{
				BindCustom.<>f__mg$cache14B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_EnchantStoneBagItem.reg);
			}
			array[num332] = BindCustom.<>f__mg$cache14B;
			int num333 = 332;
			if (BindCustom.<>f__mg$cache14C == null)
			{
				BindCustom.<>f__mg$cache14C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroFragmentBagItem.reg);
			}
			array[num333] = BindCustom.<>f__mg$cache14C;
			int num334 = 333;
			if (BindCustom.<>f__mg$cache14D == null)
			{
				BindCustom.<>f__mg$cache14D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_StaticBoxBagItem.reg);
			}
			array[num334] = BindCustom.<>f__mg$cache14D;
			int num335 = 334;
			if (BindCustom.<>f__mg$cache14E == null)
			{
				BindCustom.<>f__mg$cache14E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RandomBoxBagItem.reg);
			}
			array[num335] = BindCustom.<>f__mg$cache14E;
			int num336 = 335;
			if (BindCustom.<>f__mg$cache14F == null)
			{
				BindCustom.<>f__mg$cache14F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_SelfSelectedBoxBagItem.reg);
			}
			array[num336] = BindCustom.<>f__mg$cache14F;
			int num337 = 336;
			if (BindCustom.<>f__mg$cache150 == null)
			{
				BindCustom.<>f__mg$cache150 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_AddHeroFavorabilityUseableBagItem.reg);
			}
			array[num337] = BindCustom.<>f__mg$cache150;
			int num338 = 337;
			if (BindCustom.<>f__mg$cache151 == null)
			{
				BindCustom.<>f__mg$cache151 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_BagItemUpdateCache.reg);
			}
			array[num338] = BindCustom.<>f__mg$cache151;
			int num339 = 338;
			if (BindCustom.<>f__mg$cache152 == null)
			{
				BindCustom.<>f__mg$cache152 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ProcessingBattle.reg);
			}
			array[num339] = BindCustom.<>f__mg$cache152;
			int num340 = 339;
			if (BindCustom.<>f__mg$cache153 == null)
			{
				BindCustom.<>f__mg$cache153 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CardPool.reg);
			}
			array[num340] = BindCustom.<>f__mg$cache153;
			int num341 = 340;
			if (BindCustom.<>f__mg$cache154 == null)
			{
				BindCustom.<>f__mg$cache154 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ChatMessageFactory.reg);
			}
			array[num341] = BindCustom.<>f__mg$cache154;
			int num342 = 341;
			if (BindCustom.<>f__mg$cache155 == null)
			{
				BindCustom.<>f__mg$cache155 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ChatMessage.reg);
			}
			array[num342] = BindCustom.<>f__mg$cache155;
			int num343 = 342;
			if (BindCustom.<>f__mg$cache156 == null)
			{
				BindCustom.<>f__mg$cache156 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ChatEnterRoomMessage.reg);
			}
			array[num343] = BindCustom.<>f__mg$cache156;
			int num344 = 343;
			if (BindCustom.<>f__mg$cache157 == null)
			{
				BindCustom.<>f__mg$cache157 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ChatTextMessage.reg);
			}
			array[num344] = BindCustom.<>f__mg$cache157;
			int num345 = 344;
			if (BindCustom.<>f__mg$cache158 == null)
			{
				BindCustom.<>f__mg$cache158 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.reg);
			}
			array[num345] = BindCustom.<>f__mg$cache158;
			int num346 = 345;
			if (BindCustom.<>f__mg$cache159 == null)
			{
				BindCustom.<>f__mg$cache159 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerInfo.reg);
			}
			array[num346] = BindCustom.<>f__mg$cache159;
			int num347 = 346;
			if (BindCustom.<>f__mg$cache15A == null)
			{
				BindCustom.<>f__mg$cache15A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GlobalClimbTowerFloor.reg);
			}
			array[num347] = BindCustom.<>f__mg$cache15A;
			int num348 = 347;
			if (BindCustom.<>f__mg$cache15B == null)
			{
				BindCustom.<>f__mg$cache15B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroComment.reg);
			}
			array[num348] = BindCustom.<>f__mg$cache15B;
			int num349 = 348;
			if (BindCustom.<>f__mg$cache15C == null)
			{
				BindCustom.<>f__mg$cache15C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.reg);
			}
			array[num349] = BindCustom.<>f__mg$cache15C;
			int num350 = 349;
			if (BindCustom.<>f__mg$cache15D == null)
			{
				BindCustom.<>f__mg$cache15D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_PlayerHeroCommentEntry.reg);
			}
			array[num350] = BindCustom.<>f__mg$cache15D;
			int num351 = 350;
			if (BindCustom.<>f__mg$cache15E == null)
			{
				BindCustom.<>f__mg$cache15E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CooperateBattleLevel.reg);
			}
			array[num351] = BindCustom.<>f__mg$cache15E;
			int num352 = 351;
			if (BindCustom.<>f__mg$cache15F == null)
			{
				BindCustom.<>f__mg$cache15F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CooperateBattle.reg);
			}
			array[num352] = BindCustom.<>f__mg$cache15F;
			int num353 = 352;
			if (BindCustom.<>f__mg$cache160 == null)
			{
				BindCustom.<>f__mg$cache160 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.reg);
			}
			array[num353] = BindCustom.<>f__mg$cache160;
			int num354 = 353;
			if (BindCustom.<>f__mg$cache161 == null)
			{
				BindCustom.<>f__mg$cache161 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_LevelDanmaku.reg);
			}
			array[num354] = BindCustom.<>f__mg$cache161;
			int num355 = 354;
			if (BindCustom.<>f__mg$cache162 == null)
			{
				BindCustom.<>f__mg$cache162 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_TurnDanmaku.reg);
			}
			array[num355] = BindCustom.<>f__mg$cache162;
			int num356 = 355;
			if (BindCustom.<>f__mg$cache163 == null)
			{
				BindCustom.<>f__mg$cache163 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DanmakuEntry.reg);
			}
			array[num356] = BindCustom.<>f__mg$cache163;
			int num357 = 356;
			if (BindCustom.<>f__mg$cache164 == null)
			{
				BindCustom.<>f__mg$cache164 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_PostDanmakuEntry.reg);
			}
			array[num357] = BindCustom.<>f__mg$cache164;
			int num358 = 357;
			if (BindCustom.<>f__mg$cache165 == null)
			{
				BindCustom.<>f__mg$cache165 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GiftStoreItem.reg);
			}
			array[num358] = BindCustom.<>f__mg$cache165;
			int num359 = 358;
			if (BindCustom.<>f__mg$cache166 == null)
			{
				BindCustom.<>f__mg$cache166 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_GiftStoreOperationalGoods.reg);
			}
			array[num359] = BindCustom.<>f__mg$cache166;
			int num360 = 359;
			if (BindCustom.<>f__mg$cache167 == null)
			{
				BindCustom.<>f__mg$cache167 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_OrderReward.reg);
			}
			array[num360] = BindCustom.<>f__mg$cache167;
			int num361 = 360;
			if (BindCustom.<>f__mg$cache168 == null)
			{
				BindCustom.<>f__mg$cache168 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroUpdateCache.reg);
			}
			array[num361] = BindCustom.<>f__mg$cache168;
			int num362 = 361;
			if (BindCustom.<>f__mg$cache169 == null)
			{
				BindCustom.<>f__mg$cache169 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroAssistants.reg);
			}
			array[num362] = BindCustom.<>f__mg$cache169;
			int num363 = 362;
			if (BindCustom.<>f__mg$cache16A == null)
			{
				BindCustom.<>f__mg$cache16A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroAssistantsTask.reg);
			}
			array[num363] = BindCustom.<>f__mg$cache16A;
			int num364 = 363;
			if (BindCustom.<>f__mg$cache16B == null)
			{
				BindCustom.<>f__mg$cache16B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.reg);
			}
			array[num364] = BindCustom.<>f__mg$cache16B;
			int num365 = 364;
			if (BindCustom.<>f__mg$cache16C == null)
			{
				BindCustom.<>f__mg$cache16C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.reg);
			}
			array[num365] = BindCustom.<>f__mg$cache16C;
			int num366 = 365;
			if (BindCustom.<>f__mg$cache16D == null)
			{
				BindCustom.<>f__mg$cache16D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.reg);
			}
			array[num366] = BindCustom.<>f__mg$cache16D;
			int num367 = 366;
			if (BindCustom.<>f__mg$cache16E == null)
			{
				BindCustom.<>f__mg$cache16E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroPhantomLevel.reg);
			}
			array[num367] = BindCustom.<>f__mg$cache16E;
			int num368 = 367;
			if (BindCustom.<>f__mg$cache16F == null)
			{
				BindCustom.<>f__mg$cache16F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroPhantom.reg);
			}
			array[num368] = BindCustom.<>f__mg$cache16F;
			int num369 = 368;
			if (BindCustom.<>f__mg$cache170 == null)
			{
				BindCustom.<>f__mg$cache170 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.reg);
			}
			array[num369] = BindCustom.<>f__mg$cache170;
			int num370 = 369;
			if (BindCustom.<>f__mg$cache171 == null)
			{
				BindCustom.<>f__mg$cache171 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_Mail.reg);
			}
			array[num370] = BindCustom.<>f__mg$cache171;
			int num371 = 370;
			if (BindCustom.<>f__mg$cache172 == null)
			{
				BindCustom.<>f__mg$cache172 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_UniformBatchMail.reg);
			}
			array[num371] = BindCustom.<>f__mg$cache172;
			int num372 = 371;
			if (BindCustom.<>f__mg$cache173 == null)
			{
				BindCustom.<>f__mg$cache173 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_Marquee.reg);
			}
			array[num372] = BindCustom.<>f__mg$cache173;
			int num373 = 372;
			if (BindCustom.<>f__mg$cache174 == null)
			{
				BindCustom.<>f__mg$cache174 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_Mission.reg);
			}
			array[num373] = BindCustom.<>f__mg$cache174;
			int num374 = 373;
			if (BindCustom.<>f__mg$cache175 == null)
			{
				BindCustom.<>f__mg$cache175 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_OperationalActivityFactory.reg);
			}
			array[num374] = BindCustom.<>f__mg$cache175;
			int num375 = 374;
			if (BindCustom.<>f__mg$cache176 == null)
			{
				BindCustom.<>f__mg$cache176 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.reg);
			}
			array[num375] = BindCustom.<>f__mg$cache176;
			int num376 = 375;
			if (BindCustom.<>f__mg$cache177 == null)
			{
				BindCustom.<>f__mg$cache177 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.reg);
			}
			array[num376] = BindCustom.<>f__mg$cache177;
			int num377 = 376;
			if (BindCustom.<>f__mg$cache178 == null)
			{
				BindCustom.<>f__mg$cache178 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.reg);
			}
			array[num377] = BindCustom.<>f__mg$cache178;
			int num378 = 377;
			if (BindCustom.<>f__mg$cache179 == null)
			{
				BindCustom.<>f__mg$cache179 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.reg);
			}
			array[num378] = BindCustom.<>f__mg$cache179;
			int num379 = 378;
			if (BindCustom.<>f__mg$cache17A == null)
			{
				BindCustom.<>f__mg$cache17A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.reg);
			}
			array[num379] = BindCustom.<>f__mg$cache17A;
			int num380 = 379;
			if (BindCustom.<>f__mg$cache17B == null)
			{
				BindCustom.<>f__mg$cache17B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.reg);
			}
			array[num380] = BindCustom.<>f__mg$cache17B;
			int num381 = 380;
			if (BindCustom.<>f__mg$cache17C == null)
			{
				BindCustom.<>f__mg$cache17C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.reg);
			}
			array[num381] = BindCustom.<>f__mg$cache17C;
			int num382 = 381;
			if (BindCustom.<>f__mg$cache17D == null)
			{
				BindCustom.<>f__mg$cache17D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.reg);
			}
			array[num382] = BindCustom.<>f__mg$cache17D;
			int num383 = 382;
			if (BindCustom.<>f__mg$cache17E == null)
			{
				BindCustom.<>f__mg$cache17E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_EffectOperationalActivity.reg);
			}
			array[num383] = BindCustom.<>f__mg$cache17E;
			int num384 = 383;
			if (BindCustom.<>f__mg$cache17F == null)
			{
				BindCustom.<>f__mg$cache17F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.reg);
			}
			array[num384] = BindCustom.<>f__mg$cache17F;
			int num385 = 384;
			if (BindCustom.<>f__mg$cache180 == null)
			{
				BindCustom.<>f__mg$cache180 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_PlayerOutOfBagItem.reg);
			}
			array[num385] = BindCustom.<>f__mg$cache180;
			int num386 = 385;
			if (BindCustom.<>f__mg$cache181 == null)
			{
				BindCustom.<>f__mg$cache181 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_MonthCard.reg);
			}
			array[num386] = BindCustom.<>f__mg$cache181;
			int num387 = 386;
			if (BindCustom.<>f__mg$cache182 == null)
			{
				BindCustom.<>f__mg$cache182 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RafflePool.reg);
			}
			array[num387] = BindCustom.<>f__mg$cache182;
			int num388 = 387;
			if (BindCustom.<>f__mg$cache183 == null)
			{
				BindCustom.<>f__mg$cache183 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RankingPlayerInfo.reg);
			}
			array[num388] = BindCustom.<>f__mg$cache183;
			int num389 = 388;
			if (BindCustom.<>f__mg$cache184 == null)
			{
				BindCustom.<>f__mg$cache184 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RankingTargetPlayerInfo.reg);
			}
			array[num389] = BindCustom.<>f__mg$cache184;
			int num390 = 389;
			if (BindCustom.<>f__mg$cache185 == null)
			{
				BindCustom.<>f__mg$cache185 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RankingListInfo.reg);
			}
			array[num390] = BindCustom.<>f__mg$cache185;
			int num391 = 390;
			if (BindCustom.<>f__mg$cache186 == null)
			{
				BindCustom.<>f__mg$cache186 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.reg);
			}
			array[num391] = BindCustom.<>f__mg$cache186;
			int num392 = 391;
			if (BindCustom.<>f__mg$cache187 == null)
			{
				BindCustom.<>f__mg$cache187 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.reg);
			}
			array[num392] = BindCustom.<>f__mg$cache187;
			int num393 = 392;
			if (BindCustom.<>f__mg$cache188 == null)
			{
				BindCustom.<>f__mg$cache188 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RiftChapter.reg);
			}
			array[num393] = BindCustom.<>f__mg$cache188;
			int num394 = 393;
			if (BindCustom.<>f__mg$cache189 == null)
			{
				BindCustom.<>f__mg$cache189 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RiftLevel.reg);
			}
			array[num394] = BindCustom.<>f__mg$cache189;
			int num395 = 394;
			if (BindCustom.<>f__mg$cache18A == null)
			{
				BindCustom.<>f__mg$cache18A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.reg);
			}
			array[num395] = BindCustom.<>f__mg$cache18A;
			int num396 = 395;
			if (BindCustom.<>f__mg$cache18B == null)
			{
				BindCustom.<>f__mg$cache18B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RandomStore.reg);
			}
			array[num396] = BindCustom.<>f__mg$cache18B;
			int num397 = 396;
			if (BindCustom.<>f__mg$cache18C == null)
			{
				BindCustom.<>f__mg$cache18C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_RandomStoreItem.reg);
			}
			array[num397] = BindCustom.<>f__mg$cache18C;
			int num398 = 397;
			if (BindCustom.<>f__mg$cache18D == null)
			{
				BindCustom.<>f__mg$cache18D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_FixedStore.reg);
			}
			array[num398] = BindCustom.<>f__mg$cache18D;
			int num399 = 398;
			if (BindCustom.<>f__mg$cache18E == null)
			{
				BindCustom.<>f__mg$cache18E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_FixedStoreItem.reg);
			}
			array[num399] = BindCustom.<>f__mg$cache18E;
			int num400 = 399;
			if (BindCustom.<>f__mg$cache18F == null)
			{
				BindCustom.<>f__mg$cache18F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_Survey.reg);
			}
			array[num400] = BindCustom.<>f__mg$cache18F;
			int num401 = 400;
			if (BindCustom.<>f__mg$cache190 == null)
			{
				BindCustom.<>f__mg$cache190 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_CacheObject.reg);
			}
			array[num401] = BindCustom.<>f__mg$cache190;
			int num402 = 401;
			if (BindCustom.<>f__mg$cache191 == null)
			{
				BindCustom.<>f__mg$cache191 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_UnThreadSafeLRUCacheObject.reg);
			}
			array[num402] = BindCustom.<>f__mg$cache191;
			int num403 = 402;
			if (BindCustom.<>f__mg$cache192 == null)
			{
				BindCustom.<>f__mg$cache192 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_DebugUtility.reg);
			}
			array[num403] = BindCustom.<>f__mg$cache192;
			int num404 = 403;
			if (BindCustom.<>f__mg$cache193 == null)
			{
				BindCustom.<>f__mg$cache193 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Common_StopwatchManager.reg);
			}
			array[num404] = BindCustom.<>f__mg$cache193;
			int num405 = 404;
			if (BindCustom.<>f__mg$cache194 == null)
			{
				BindCustom.<>f__mg$cache194 = new Action<IntPtr>(Lua_BlackJack_UtilityTools_ThreadSaftyRandom.reg);
			}
			array[num405] = BindCustom.<>f__mg$cache194;
			int num406 = 405;
			if (BindCustom.<>f__mg$cache195 == null)
			{
				BindCustom.<>f__mg$cache195 = new Action<IntPtr>(Lua_BlackJack_UtilityTools_RandomExtentions_UtilityFunction.reg);
			}
			array[num406] = BindCustom.<>f__mg$cache195;
			int num407 = 406;
			if (BindCustom.<>f__mg$cache196 == null)
			{
				BindCustom.<>f__mg$cache196 = new Action<IntPtr>(Lua_BlackJack_UtilityTools_MathCaculate.reg);
			}
			array[num407] = BindCustom.<>f__mg$cache196;
			int num408 = 407;
			if (BindCustom.<>f__mg$cache197 == null)
			{
				BindCustom.<>f__mg$cache197 = new Action<IntPtr>(Lua_BlackJack_UtilityTools_SensitiveWords.reg);
			}
			array[num408] = BindCustom.<>f__mg$cache197;
			int num409 = 408;
			if (BindCustom.<>f__mg$cache198 == null)
			{
				BindCustom.<>f__mg$cache198 = new Action<IntPtr>(Lua_BlackJack_UtilityTools_StringCheck.reg);
			}
			array[num409] = BindCustom.<>f__mg$cache198;
			int num410 = 409;
			if (BindCustom.<>f__mg$cache199 == null)
			{
				BindCustom.<>f__mg$cache199 = new Action<IntPtr>(Lua_BlackJack_UtilityTools_Find.reg);
			}
			array[num410] = BindCustom.<>f__mg$cache199;
			int num411 = 410;
			if (BindCustom.<>f__mg$cache19A == null)
			{
				BindCustom.<>f__mg$cache19A = new Action<IntPtr>(Lua_BlackJack_UtilityTools_MoneyCaculate.reg);
			}
			array[num411] = BindCustom.<>f__mg$cache19A;
			int num412 = 411;
			if (BindCustom.<>f__mg$cache19B == null)
			{
				BindCustom.<>f__mg$cache19B = new Action<IntPtr>(Lua_BlackJack_UtilityTools_HeadIconTools.reg);
			}
			array[num412] = BindCustom.<>f__mg$cache19B;
			int num413 = 412;
			if (BindCustom.<>f__mg$cache19C == null)
			{
				BindCustom.<>f__mg$cache19C = new Action<IntPtr>(Lua_BlackJack_UtilityTools_RMBStoreoreGoodsIdTools.reg);
			}
			array[num413] = BindCustom.<>f__mg$cache19C;
			int num414 = 413;
			if (BindCustom.<>f__mg$cache19D == null)
			{
				BindCustom.<>f__mg$cache19D = new Action<IntPtr>(Lua_BlackJack_UtilityTools_CountMinSketch.reg);
			}
			array[num414] = BindCustom.<>f__mg$cache19D;
			int num415 = 414;
			if (BindCustom.<>f__mg$cache19E == null)
			{
				BindCustom.<>f__mg$cache19E = new Action<IntPtr>(Lua_BlackJack_ProjectL_CommonDefine_ErrorCode.reg);
			}
			array[num415] = BindCustom.<>f__mg$cache19E;
			int num416 = 415;
			if (BindCustom.<>f__mg$cache19F == null)
			{
				BindCustom.<>f__mg$cache19F = new Action<IntPtr>(Lua_BlackJack_ProjectL_LibClient_Client.reg);
			}
			array[num416] = BindCustom.<>f__mg$cache19F;
			int num417 = 416;
			if (BindCustom.<>f__mg$cache1A0 == null)
			{
				BindCustom.<>f__mg$cache1A0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_LibClient_ClientFactory.reg);
			}
			array[num417] = BindCustom.<>f__mg$cache1A0;
			int num418 = 417;
			if (BindCustom.<>f__mg$cache1A1 == null)
			{
				BindCustom.<>f__mg$cache1A1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_LibClient_SessionToken.reg);
			}
			array[num418] = BindCustom.<>f__mg$cache1A1;
			int num419 = 418;
			if (BindCustom.<>f__mg$cache1A2 == null)
			{
				BindCustom.<>f__mg$cache1A2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_LibClient_StateMachine.reg);
			}
			array[num419] = BindCustom.<>f__mg$cache1A2;
			int num420 = 419;
			if (BindCustom.<>f__mg$cache1A3 == null)
			{
				BindCustom.<>f__mg$cache1A3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_LibClient_LibClientStateMachine.reg);
			}
			array[num420] = BindCustom.<>f__mg$cache1A3;
			int num421 = 420;
			if (BindCustom.<>f__mg$cache1A4 == null)
			{
				BindCustom.<>f__mg$cache1A4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_AssetUtility.reg);
			}
			array[num421] = BindCustom.<>f__mg$cache1A4;
			int num422 = 421;
			if (BindCustom.<>f__mg$cache1A5 == null)
			{
				BindCustom.<>f__mg$cache1A5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_LruAssetCache.reg);
			}
			array[num422] = BindCustom.<>f__mg$cache1A5;
			int num423 = 422;
			if (BindCustom.<>f__mg$cache1A6 == null)
			{
				BindCustom.<>f__mg$cache1A6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_AudioUtility.reg);
			}
			array[num423] = BindCustom.<>f__mg$cache1A6;
			int num424 = 423;
			if (BindCustom.<>f__mg$cache1A7 == null)
			{
				BindCustom.<>f__mg$cache1A7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_FileUtility.reg);
			}
			array[num424] = BindCustom.<>f__mg$cache1A7;
			int num425 = 424;
			if (BindCustom.<>f__mg$cache1A8 == null)
			{
				BindCustom.<>f__mg$cache1A8 = new Action<IntPtr>(Lua_GameEventID4PD.reg);
			}
			array[num425] = BindCustom.<>f__mg$cache1A8;
			int num426 = 425;
			if (BindCustom.<>f__mg$cache1A9 == null)
			{
				BindCustom.<>f__mg$cache1A9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.reg);
			}
			array[num426] = BindCustom.<>f__mg$cache1A9;
			int num427 = 426;
			if (BindCustom.<>f__mg$cache1AA == null)
			{
				BindCustom.<>f__mg$cache1AA = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_GameObjectUtility.reg);
			}
			array[num427] = BindCustom.<>f__mg$cache1AA;
			int num428 = 427;
			if (BindCustom.<>f__mg$cache1AB == null)
			{
				BindCustom.<>f__mg$cache1AB = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_GameObjectPool.reg);
			}
			array[num428] = BindCustom.<>f__mg$cache1AB;
			int num429 = 428;
			if (BindCustom.<>f__mg$cache1AC == null)
			{
				BindCustom.<>f__mg$cache1AC = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_JsonUtility.reg);
			}
			array[num429] = BindCustom.<>f__mg$cache1AC;
			int num430 = 429;
			if (BindCustom.<>f__mg$cache1AD == null)
			{
				BindCustom.<>f__mg$cache1AD = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_LocalAccountConfigData.reg);
			}
			array[num430] = BindCustom.<>f__mg$cache1AD;
			int num431 = 430;
			if (BindCustom.<>f__mg$cache1AE == null)
			{
				BindCustom.<>f__mg$cache1AE = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.reg);
			}
			array[num431] = BindCustom.<>f__mg$cache1AE;
			int num432 = 431;
			if (BindCustom.<>f__mg$cache1AF == null)
			{
				BindCustom.<>f__mg$cache1AF = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_LocalConfigData.reg);
			}
			array[num432] = BindCustom.<>f__mg$cache1AF;
			int num433 = 432;
			if (BindCustom.<>f__mg$cache1B0 == null)
			{
				BindCustom.<>f__mg$cache1B0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_LocalConfig.reg);
			}
			array[num433] = BindCustom.<>f__mg$cache1B0;
			int num434 = 433;
			if (BindCustom.<>f__mg$cache1B1 == null)
			{
				BindCustom.<>f__mg$cache1B1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData.reg);
			}
			array[num434] = BindCustom.<>f__mg$cache1B1;
			int num435 = 434;
			if (BindCustom.<>f__mg$cache1B2 == null)
			{
				BindCustom.<>f__mg$cache1B2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.reg);
			}
			array[num435] = BindCustom.<>f__mg$cache1B2;
			int num436 = 435;
			if (BindCustom.<>f__mg$cache1B3 == null)
			{
				BindCustom.<>f__mg$cache1B3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.reg);
			}
			array[num436] = BindCustom.<>f__mg$cache1B3;
			int num437 = 436;
			if (BindCustom.<>f__mg$cache1B4 == null)
			{
				BindCustom.<>f__mg$cache1B4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_MonoBehaviourEvent.reg);
			}
			array[num437] = BindCustom.<>f__mg$cache1B4;
			int num438 = 437;
			if (BindCustom.<>f__mg$cache1B5 == null)
			{
				BindCustom.<>f__mg$cache1B5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.reg);
			}
			array[num438] = BindCustom.<>f__mg$cache1B5;
			int num439 = 438;
			if (BindCustom.<>f__mg$cache1B6 == null)
			{
				BindCustom.<>f__mg$cache1B6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_SystemUtility.reg);
			}
			array[num439] = BindCustom.<>f__mg$cache1B6;
			int num440 = 439;
			if (BindCustom.<>f__mg$cache1B7 == null)
			{
				BindCustom.<>f__mg$cache1B7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_AnikiGymComponent.reg);
			}
			array[num440] = BindCustom.<>f__mg$cache1B7;
			int num441 = 440;
			if (BindCustom.<>f__mg$cache1B8 == null)
			{
				BindCustom.<>f__mg$cache1B8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ArenaComponent.reg);
			}
			array[num441] = BindCustom.<>f__mg$cache1B8;
			int num442 = 441;
			if (BindCustom.<>f__mg$cache1B9 == null)
			{
				BindCustom.<>f__mg$cache1B9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.reg);
			}
			array[num442] = BindCustom.<>f__mg$cache1B9;
			int num443 = 442;
			if (BindCustom.<>f__mg$cache1BA == null)
			{
				BindCustom.<>f__mg$cache1BA = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_BattleComponent.reg);
			}
			array[num443] = BindCustom.<>f__mg$cache1BA;
			int num444 = 443;
			if (BindCustom.<>f__mg$cache1BB == null)
			{
				BindCustom.<>f__mg$cache1BB = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_BattleRoom.reg);
			}
			array[num444] = BindCustom.<>f__mg$cache1BB;
			int num445 = 444;
			if (BindCustom.<>f__mg$cache1BC == null)
			{
				BindCustom.<>f__mg$cache1BC = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.reg);
			}
			array[num445] = BindCustom.<>f__mg$cache1BC;
			int num446 = 445;
			if (BindCustom.<>f__mg$cache1BD == null)
			{
				BindCustom.<>f__mg$cache1BD = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent.reg);
			}
			array[num446] = BindCustom.<>f__mg$cache1BD;
			int num447 = 446;
			if (BindCustom.<>f__mg$cache1BE == null)
			{
				BindCustom.<>f__mg$cache1BE = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatMessageClient.reg);
			}
			array[num447] = BindCustom.<>f__mg$cache1BE;
			int num448 = 447;
			if (BindCustom.<>f__mg$cache1BF == null)
			{
				BindCustom.<>f__mg$cache1BF = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ChatComponent_ChatSaveData.reg);
			}
			array[num448] = BindCustom.<>f__mg$cache1BF;
			int num449 = 448;
			if (BindCustom.<>f__mg$cache1C0 == null)
			{
				BindCustom.<>f__mg$cache1C0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.reg);
			}
			array[num449] = BindCustom.<>f__mg$cache1C0;
			int num450 = 449;
			if (BindCustom.<>f__mg$cache1C1 == null)
			{
				BindCustom.<>f__mg$cache1C1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupCompactInfo.reg);
			}
			array[num450] = BindCustom.<>f__mg$cache1C1;
			int num451 = 450;
			if (BindCustom.<>f__mg$cache1C2 == null)
			{
				BindCustom.<>f__mg$cache1C2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ChatUserCompactInfo.reg);
			}
			array[num451] = BindCustom.<>f__mg$cache1C2;
			int num452 = 451;
			if (BindCustom.<>f__mg$cache1C3 == null)
			{
				BindCustom.<>f__mg$cache1C3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ClimbTowerComponent.reg);
			}
			array[num452] = BindCustom.<>f__mg$cache1C3;
			int num453 = 452;
			if (BindCustom.<>f__mg$cache1C4 == null)
			{
				BindCustom.<>f__mg$cache1C4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_CommentComponent.reg);
			}
			array[num453] = BindCustom.<>f__mg$cache1C4;
			int num454 = 453;
			if (BindCustom.<>f__mg$cache1C5 == null)
			{
				BindCustom.<>f__mg$cache1C5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_CooperateBattleCompoment.reg);
			}
			array[num454] = BindCustom.<>f__mg$cache1C5;
			int num455 = 454;
			if (BindCustom.<>f__mg$cache1C6 == null)
			{
				BindCustom.<>f__mg$cache1C6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_DanmakuComponent.reg);
			}
			array[num455] = BindCustom.<>f__mg$cache1C6;
			int num456 = 455;
			if (BindCustom.<>f__mg$cache1C7 == null)
			{
				BindCustom.<>f__mg$cache1C7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_FixedStoreComponent.reg);
			}
			array[num456] = BindCustom.<>f__mg$cache1C7;
			int num457 = 456;
			if (BindCustom.<>f__mg$cache1C8 == null)
			{
				BindCustom.<>f__mg$cache1C8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.reg);
			}
			array[num457] = BindCustom.<>f__mg$cache1C8;
			int num458 = 457;
			if (BindCustom.<>f__mg$cache1C9 == null)
			{
				BindCustom.<>f__mg$cache1C9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.reg);
			}
			array[num458] = BindCustom.<>f__mg$cache1C9;
			int num459 = 458;
			if (BindCustom.<>f__mg$cache1CA == null)
			{
				BindCustom.<>f__mg$cache1CA = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_UserSummaryEqualityComparer.reg);
			}
			array[num459] = BindCustom.<>f__mg$cache1CA;
			int num460 = 459;
			if (BindCustom.<>f__mg$cache1CB == null)
			{
				BindCustom.<>f__mg$cache1CB = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_GiftStoreComponent.reg);
			}
			array[num460] = BindCustom.<>f__mg$cache1CB;
			int num461 = 460;
			if (BindCustom.<>f__mg$cache1CC == null)
			{
				BindCustom.<>f__mg$cache1CC = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent.reg);
			}
			array[num461] = BindCustom.<>f__mg$cache1CC;
			int num462 = 461;
			if (BindCustom.<>f__mg$cache1CD == null)
			{
				BindCustom.<>f__mg$cache1CD = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_CachedRankingListInfo.reg);
			}
			array[num462] = BindCustom.<>f__mg$cache1CD;
			int num463 = 462;
			if (BindCustom.<>f__mg$cache1CE == null)
			{
				BindCustom.<>f__mg$cache1CE = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_GuildComponent.reg);
			}
			array[num463] = BindCustom.<>f__mg$cache1CE;
			int num464 = 463;
			if (BindCustom.<>f__mg$cache1CF == null)
			{
				BindCustom.<>f__mg$cache1CF = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.reg);
			}
			array[num464] = BindCustom.<>f__mg$cache1CF;
			int num465 = 464;
			if (BindCustom.<>f__mg$cache1D0 == null)
			{
				BindCustom.<>f__mg$cache1D0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.reg);
			}
			array[num465] = BindCustom.<>f__mg$cache1D0;
			int num466 = 465;
			if (BindCustom.<>f__mg$cache1D1 == null)
			{
				BindCustom.<>f__mg$cache1D1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_HeroDungeonComponent.reg);
			}
			array[num466] = BindCustom.<>f__mg$cache1D1;
			int num467 = 466;
			if (BindCustom.<>f__mg$cache1D2 == null)
			{
				BindCustom.<>f__mg$cache1D2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_HeroPhantomCompoment.reg);
			}
			array[num467] = BindCustom.<>f__mg$cache1D2;
			int num468 = 467;
			if (BindCustom.<>f__mg$cache1D3 == null)
			{
				BindCustom.<>f__mg$cache1D3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_HeroTrainningComponent.reg);
			}
			array[num468] = BindCustom.<>f__mg$cache1D3;
			int num469 = 468;
			if (BindCustom.<>f__mg$cache1D4 == null)
			{
				BindCustom.<>f__mg$cache1D4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_LevelComponent.reg);
			}
			array[num469] = BindCustom.<>f__mg$cache1D4;
			int num470 = 469;
			if (BindCustom.<>f__mg$cache1D5 == null)
			{
				BindCustom.<>f__mg$cache1D5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.reg);
			}
			array[num470] = BindCustom.<>f__mg$cache1D5;
			int num471 = 470;
			if (BindCustom.<>f__mg$cache1D6 == null)
			{
				BindCustom.<>f__mg$cache1D6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_MemoryCorridorCompoment.reg);
			}
			array[num471] = BindCustom.<>f__mg$cache1D6;
			int num472 = 471;
			if (BindCustom.<>f__mg$cache1D7 == null)
			{
				BindCustom.<>f__mg$cache1D7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_MissionComponent.reg);
			}
			array[num472] = BindCustom.<>f__mg$cache1D7;
			int num473 = 472;
			if (BindCustom.<>f__mg$cache1D8 == null)
			{
				BindCustom.<>f__mg$cache1D8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.reg);
			}
			array[num473] = BindCustom.<>f__mg$cache1D8;
			int num474 = 473;
			if (BindCustom.<>f__mg$cache1D9 == null)
			{
				BindCustom.<>f__mg$cache1D9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.reg);
			}
			array[num474] = BindCustom.<>f__mg$cache1D9;
			int num475 = 474;
			if (BindCustom.<>f__mg$cache1DA == null)
			{
				BindCustom.<>f__mg$cache1DA = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_PlayerBasicInfoComponent.reg);
			}
			array[num475] = BindCustom.<>f__mg$cache1DA;
			int num476 = 475;
			if (BindCustom.<>f__mg$cache1DB == null)
			{
				BindCustom.<>f__mg$cache1DB = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_RaffleComponent.reg);
			}
			array[num476] = BindCustom.<>f__mg$cache1DB;
			int num477 = 476;
			if (BindCustom.<>f__mg$cache1DC == null)
			{
				BindCustom.<>f__mg$cache1DC = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_RandomStoreComponent.reg);
			}
			array[num477] = BindCustom.<>f__mg$cache1DC;
			int num478 = 477;
			if (BindCustom.<>f__mg$cache1DD == null)
			{
				BindCustom.<>f__mg$cache1DD = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_RealTimePVPComponent.reg);
			}
			array[num478] = BindCustom.<>f__mg$cache1DD;
			int num479 = 478;
			if (BindCustom.<>f__mg$cache1DE == null)
			{
				BindCustom.<>f__mg$cache1DE = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.reg);
			}
			array[num479] = BindCustom.<>f__mg$cache1DE;
			int num480 = 479;
			if (BindCustom.<>f__mg$cache1DF == null)
			{
				BindCustom.<>f__mg$cache1DF = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.reg);
			}
			array[num480] = BindCustom.<>f__mg$cache1DF;
			int num481 = 480;
			if (BindCustom.<>f__mg$cache1E0 == null)
			{
				BindCustom.<>f__mg$cache1E0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_RiftComponent.reg);
			}
			array[num481] = BindCustom.<>f__mg$cache1E0;
			int num482 = 481;
			if (BindCustom.<>f__mg$cache1E1 == null)
			{
				BindCustom.<>f__mg$cache1E1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_SelectCardComponent.reg);
			}
			array[num482] = BindCustom.<>f__mg$cache1E1;
			int num483 = 482;
			if (BindCustom.<>f__mg$cache1E2 == null)
			{
				BindCustom.<>f__mg$cache1E2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.reg);
			}
			array[num483] = BindCustom.<>f__mg$cache1E2;
			int num484 = 483;
			if (BindCustom.<>f__mg$cache1E3 == null)
			{
				BindCustom.<>f__mg$cache1E3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.reg);
			}
			array[num484] = BindCustom.<>f__mg$cache1E3;
			int num485 = 484;
			if (BindCustom.<>f__mg$cache1E4 == null)
			{
				BindCustom.<>f__mg$cache1E4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ThearchyTrialComponent.reg);
			}
			array[num485] = BindCustom.<>f__mg$cache1E4;
			int num486 = 485;
			if (BindCustom.<>f__mg$cache1E5 == null)
			{
				BindCustom.<>f__mg$cache1E5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.reg);
			}
			array[num486] = BindCustom.<>f__mg$cache1E5;
			int num487 = 486;
			if (BindCustom.<>f__mg$cache1E6 == null)
			{
				BindCustom.<>f__mg$cache1E6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_TreasureMapComponent.reg);
			}
			array[num487] = BindCustom.<>f__mg$cache1E6;
			int num488 = 487;
			if (BindCustom.<>f__mg$cache1E7 == null)
			{
				BindCustom.<>f__mg$cache1E7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_UnchartedScoreComponent.reg);
			}
			array[num488] = BindCustom.<>f__mg$cache1E7;
			int num489 = 488;
			if (BindCustom.<>f__mg$cache1E8 == null)
			{
				BindCustom.<>f__mg$cache1E8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_NetWorkClient.reg);
			}
			array[num489] = BindCustom.<>f__mg$cache1E8;
			int num490 = 489;
			if (BindCustom.<>f__mg$cache1E9 == null)
			{
				BindCustom.<>f__mg$cache1E9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContext.reg);
			}
			array[num490] = BindCustom.<>f__mg$cache1E9;
			int num491 = 490;
			if (BindCustom.<>f__mg$cache1EA == null)
			{
				BindCustom.<>f__mg$cache1EA = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_RewardPlayerStatus.reg);
			}
			array[num491] = BindCustom.<>f__mg$cache1EA;
			int num492 = 491;
			if (BindCustom.<>f__mg$cache1EB == null)
			{
				BindCustom.<>f__mg$cache1EB = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_RewardHeroStatus.reg);
			}
			array[num492] = BindCustom.<>f__mg$cache1EB;
			int num493 = 492;
			if (BindCustom.<>f__mg$cache1EC == null)
			{
				BindCustom.<>f__mg$cache1EC = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_CurrentBattle.reg);
			}
			array[num493] = BindCustom.<>f__mg$cache1EC;
			int num494 = 493;
			if (BindCustom.<>f__mg$cache1ED == null)
			{
				BindCustom.<>f__mg$cache1ED = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_Happening.reg);
			}
			array[num494] = BindCustom.<>f__mg$cache1ED;
			int num495 = 494;
			if (BindCustom.<>f__mg$cache1EE == null)
			{
				BindCustom.<>f__mg$cache1EE = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.reg);
			}
			array[num495] = BindCustom.<>f__mg$cache1EE;
			int num496 = 495;
			if (BindCustom.<>f__mg$cache1EF == null)
			{
				BindCustom.<>f__mg$cache1EF = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.reg);
			}
			array[num496] = BindCustom.<>f__mg$cache1EF;
			int num497 = 496;
			if (BindCustom.<>f__mg$cache1F0 == null)
			{
				BindCustom.<>f__mg$cache1F0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_PlayerContext_ProjectLPlayerContextWrapper.reg);
			}
			array[num497] = BindCustom.<>f__mg$cache1F0;
			int num498 = 497;
			if (BindCustom.<>f__mg$cache1F1 == null)
			{
				BindCustom.<>f__mg$cache1F1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_TouchStatus.reg);
			}
			array[num498] = BindCustom.<>f__mg$cache1F1;
			int num499 = 498;
			if (BindCustom.<>f__mg$cache1F2 == null)
			{
				BindCustom.<>f__mg$cache1F2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_CameraBase.reg);
			}
			array[num499] = BindCustom.<>f__mg$cache1F2;
			int num500 = 499;
			if (BindCustom.<>f__mg$cache1F3 == null)
			{
				BindCustom.<>f__mg$cache1F3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_BattleCamera.reg);
			}
			array[num500] = BindCustom.<>f__mg$cache1F3;
			int num501 = 500;
			if (BindCustom.<>f__mg$cache1F4 == null)
			{
				BindCustom.<>f__mg$cache1F4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle.reg);
			}
			array[num501] = BindCustom.<>f__mg$cache1F4;
			int num502 = 501;
			if (BindCustom.<>f__mg$cache1F5 == null)
			{
				BindCustom.<>f__mg$cache1F5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStart.reg);
			}
			array[num502] = BindCustom.<>f__mg$cache1F5;
			int num503 = 502;
			if (BindCustom.<>f__mg$cache1F6 == null)
			{
				BindCustom.<>f__mg$cache1F6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.reg);
			}
			array[num503] = BindCustom.<>f__mg$cache1F6;
			int num504 = 503;
			if (BindCustom.<>f__mg$cache1F7 == null)
			{
				BindCustom.<>f__mg$cache1F7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.reg);
			}
			array[num504] = BindCustom.<>f__mg$cache1F7;
			int num505 = 504;
			if (BindCustom.<>f__mg$cache1F8 == null)
			{
				BindCustom.<>f__mg$cache1F8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.reg);
			}
			array[num505] = BindCustom.<>f__mg$cache1F8;
			int num506 = 505;
			if (BindCustom.<>f__mg$cache1F9 == null)
			{
				BindCustom.<>f__mg$cache1F9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.reg);
			}
			array[num506] = BindCustom.<>f__mg$cache1F9;
			int num507 = 506;
			if (BindCustom.<>f__mg$cache1FA == null)
			{
				BindCustom.<>f__mg$cache1FA = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.reg);
			}
			array[num507] = BindCustom.<>f__mg$cache1FA;
			int num508 = 507;
			if (BindCustom.<>f__mg$cache1FB == null)
			{
				BindCustom.<>f__mg$cache1FB = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.reg);
			}
			array[num508] = BindCustom.<>f__mg$cache1FB;
			int num509 = 508;
			if (BindCustom.<>f__mg$cache1FC == null)
			{
				BindCustom.<>f__mg$cache1FC = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.reg);
			}
			array[num509] = BindCustom.<>f__mg$cache1FC;
			int num510 = 509;
			if (BindCustom.<>f__mg$cache1FD == null)
			{
				BindCustom.<>f__mg$cache1FD = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.reg);
			}
			array[num510] = BindCustom.<>f__mg$cache1FD;
			int num511 = 510;
			if (BindCustom.<>f__mg$cache1FE == null)
			{
				BindCustom.<>f__mg$cache1FE = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.reg);
			}
			array[num511] = BindCustom.<>f__mg$cache1FE;
			int num512 = 511;
			if (BindCustom.<>f__mg$cache1FF == null)
			{
				BindCustom.<>f__mg$cache1FF = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.reg);
			}
			array[num512] = BindCustom.<>f__mg$cache1FF;
			int num513 = 512;
			if (BindCustom.<>f__mg$cache200 == null)
			{
				BindCustom.<>f__mg$cache200 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattleActor.reg);
			}
			array[num513] = BindCustom.<>f__mg$cache200;
			int num514 = 513;
			if (BindCustom.<>f__mg$cache201 == null)
			{
				BindCustom.<>f__mg$cache201 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattleActor_GraphicState.reg);
			}
			array[num514] = BindCustom.<>f__mg$cache201;
			int num515 = 514;
			if (BindCustom.<>f__mg$cache202 == null)
			{
				BindCustom.<>f__mg$cache202 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorBuff.reg);
			}
			array[num515] = BindCustom.<>f__mg$cache202;
			int num516 = 515;
			if (BindCustom.<>f__mg$cache203 == null)
			{
				BindCustom.<>f__mg$cache203 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorAct.reg);
			}
			array[num516] = BindCustom.<>f__mg$cache203;
			int num517 = 516;
			if (BindCustom.<>f__mg$cache204 == null)
			{
				BindCustom.<>f__mg$cache204 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActActive.reg);
			}
			array[num517] = BindCustom.<>f__mg$cache204;
			int num518 = 517;
			if (BindCustom.<>f__mg$cache205 == null)
			{
				BindCustom.<>f__mg$cache205 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActActionBegin.reg);
			}
			array[num518] = BindCustom.<>f__mg$cache205;
			int num519 = 518;
			if (BindCustom.<>f__mg$cache206 == null)
			{
				BindCustom.<>f__mg$cache206 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActActionEnd.reg);
			}
			array[num519] = BindCustom.<>f__mg$cache206;
			int num520 = 519;
			if (BindCustom.<>f__mg$cache207 == null)
			{
				BindCustom.<>f__mg$cache207 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActMove.reg);
			}
			array[num520] = BindCustom.<>f__mg$cache207;
			int num521 = 520;
			if (BindCustom.<>f__mg$cache208 == null)
			{
				BindCustom.<>f__mg$cache208 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActTryMove.reg);
			}
			array[num521] = BindCustom.<>f__mg$cache208;
			int num522 = 521;
			if (BindCustom.<>f__mg$cache209 == null)
			{
				BindCustom.<>f__mg$cache209 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActPerformMove.reg);
			}
			array[num522] = BindCustom.<>f__mg$cache209;
			int num523 = 522;
			if (BindCustom.<>f__mg$cache20A == null)
			{
				BindCustom.<>f__mg$cache20A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.reg);
			}
			array[num523] = BindCustom.<>f__mg$cache20A;
			int num524 = 523;
			if (BindCustom.<>f__mg$cache20B == null)
			{
				BindCustom.<>f__mg$cache20B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.reg);
			}
			array[num524] = BindCustom.<>f__mg$cache20B;
			int num525 = 524;
			if (BindCustom.<>f__mg$cache20C == null)
			{
				BindCustom.<>f__mg$cache20C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.reg);
			}
			array[num525] = BindCustom.<>f__mg$cache20C;
			int num526 = 525;
			if (BindCustom.<>f__mg$cache20D == null)
			{
				BindCustom.<>f__mg$cache20D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayFx.reg);
			}
			array[num526] = BindCustom.<>f__mg$cache20D;
			int num527 = 526;
			if (BindCustom.<>f__mg$cache20E == null)
			{
				BindCustom.<>f__mg$cache20E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActPlayAnimation.reg);
			}
			array[num527] = BindCustom.<>f__mg$cache20E;
			int num528 = 527;
			if (BindCustom.<>f__mg$cache20F == null)
			{
				BindCustom.<>f__mg$cache20F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeIdleAnimation.reg);
			}
			array[num528] = BindCustom.<>f__mg$cache20F;
			int num529 = 528;
			if (BindCustom.<>f__mg$cache210 == null)
			{
				BindCustom.<>f__mg$cache210 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.reg);
			}
			array[num529] = BindCustom.<>f__mg$cache210;
			int num530 = 529;
			if (BindCustom.<>f__mg$cache211 == null)
			{
				BindCustom.<>f__mg$cache211 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.reg);
			}
			array[num530] = BindCustom.<>f__mg$cache211;
			int num531 = 530;
			if (BindCustom.<>f__mg$cache212 == null)
			{
				BindCustom.<>f__mg$cache212 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.reg);
			}
			array[num531] = BindCustom.<>f__mg$cache212;
			int num532 = 531;
			if (BindCustom.<>f__mg$cache213 == null)
			{
				BindCustom.<>f__mg$cache213 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActSkillHit.reg);
			}
			array[num532] = BindCustom.<>f__mg$cache213;
			int num533 = 532;
			if (BindCustom.<>f__mg$cache214 == null)
			{
				BindCustom.<>f__mg$cache214 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.reg);
			}
			array[num533] = BindCustom.<>f__mg$cache214;
			int num534 = 533;
			if (BindCustom.<>f__mg$cache215 == null)
			{
				BindCustom.<>f__mg$cache215 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActDetachBuff.reg);
			}
			array[num534] = BindCustom.<>f__mg$cache215;
			int num535 = 534;
			if (BindCustom.<>f__mg$cache216 == null)
			{
				BindCustom.<>f__mg$cache216 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActImmune.reg);
			}
			array[num535] = BindCustom.<>f__mg$cache216;
			int num536 = 535;
			if (BindCustom.<>f__mg$cache217 == null)
			{
				BindCustom.<>f__mg$cache217 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkill.reg);
			}
			array[num536] = BindCustom.<>f__mg$cache217;
			int num537 = 536;
			if (BindCustom.<>f__mg$cache218 == null)
			{
				BindCustom.<>f__mg$cache218 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActPassiveSkillHit.reg);
			}
			array[num537] = BindCustom.<>f__mg$cache218;
			int num538 = 537;
			if (BindCustom.<>f__mg$cache219 == null)
			{
				BindCustom.<>f__mg$cache219 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActBuffHit.reg);
			}
			array[num538] = BindCustom.<>f__mg$cache219;
			int num539 = 538;
			if (BindCustom.<>f__mg$cache21A == null)
			{
				BindCustom.<>f__mg$cache21A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActTerrainHit.reg);
			}
			array[num539] = BindCustom.<>f__mg$cache21A;
			int num540 = 539;
			if (BindCustom.<>f__mg$cache21B == null)
			{
				BindCustom.<>f__mg$cache21B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.reg);
			}
			array[num540] = BindCustom.<>f__mg$cache21B;
			int num541 = 540;
			if (BindCustom.<>f__mg$cache21C == null)
			{
				BindCustom.<>f__mg$cache21C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.reg);
			}
			array[num541] = BindCustom.<>f__mg$cache21C;
			int num542 = 541;
			if (BindCustom.<>f__mg$cache21D == null)
			{
				BindCustom.<>f__mg$cache21D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.reg);
			}
			array[num542] = BindCustom.<>f__mg$cache21D;
			int num543 = 542;
			if (BindCustom.<>f__mg$cache21E == null)
			{
				BindCustom.<>f__mg$cache21E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActDie.reg);
			}
			array[num543] = BindCustom.<>f__mg$cache21E;
			int num544 = 543;
			if (BindCustom.<>f__mg$cache21F == null)
			{
				BindCustom.<>f__mg$cache21F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.reg);
			}
			array[num544] = BindCustom.<>f__mg$cache21F;
			int num545 = 544;
			if (BindCustom.<>f__mg$cache220 == null)
			{
				BindCustom.<>f__mg$cache220 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.reg);
			}
			array[num545] = BindCustom.<>f__mg$cache220;
			int num546 = 545;
			if (BindCustom.<>f__mg$cache221 == null)
			{
				BindCustom.<>f__mg$cache221 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.reg);
			}
			array[num546] = BindCustom.<>f__mg$cache221;
			int num547 = 546;
			if (BindCustom.<>f__mg$cache222 == null)
			{
				BindCustom.<>f__mg$cache222 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.reg);
			}
			array[num547] = BindCustom.<>f__mg$cache222;
			int num548 = 547;
			if (BindCustom.<>f__mg$cache223 == null)
			{
				BindCustom.<>f__mg$cache223 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.reg);
			}
			array[num548] = BindCustom.<>f__mg$cache223;
			int num549 = 548;
			if (BindCustom.<>f__mg$cache224 == null)
			{
				BindCustom.<>f__mg$cache224 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActCameraFocus.reg);
			}
			array[num549] = BindCustom.<>f__mg$cache224;
			int num550 = 549;
			if (BindCustom.<>f__mg$cache225 == null)
			{
				BindCustom.<>f__mg$cache225 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.reg);
			}
			array[num550] = BindCustom.<>f__mg$cache225;
			int num551 = 550;
			if (BindCustom.<>f__mg$cache226 == null)
			{
				BindCustom.<>f__mg$cache226 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.reg);
			}
			array[num551] = BindCustom.<>f__mg$cache226;
			int num552 = 551;
			if (BindCustom.<>f__mg$cache227 == null)
			{
				BindCustom.<>f__mg$cache227 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.reg);
			}
			array[num552] = BindCustom.<>f__mg$cache227;
			int num553 = 552;
			if (BindCustom.<>f__mg$cache228 == null)
			{
				BindCustom.<>f__mg$cache228 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.reg);
			}
			array[num553] = BindCustom.<>f__mg$cache228;
			int num554 = 553;
			if (BindCustom.<>f__mg$cache229 == null)
			{
				BindCustom.<>f__mg$cache229 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActCancelCombat.reg);
			}
			array[num554] = BindCustom.<>f__mg$cache229;
			int num555 = 554;
			if (BindCustom.<>f__mg$cache22A == null)
			{
				BindCustom.<>f__mg$cache22A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActStartCombat.reg);
			}
			array[num555] = BindCustom.<>f__mg$cache22A;
			int num556 = 555;
			if (BindCustom.<>f__mg$cache22B == null)
			{
				BindCustom.<>f__mg$cache22B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientActorActStopCombat.reg);
			}
			array[num556] = BindCustom.<>f__mg$cache22B;
			int num557 = 556;
			if (BindCustom.<>f__mg$cache22C == null)
			{
				BindCustom.<>f__mg$cache22C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattle.reg);
			}
			array[num557] = BindCustom.<>f__mg$cache22C;
			int num558 = 557;
			if (BindCustom.<>f__mg$cache22D == null)
			{
				BindCustom.<>f__mg$cache22D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.reg);
			}
			array[num558] = BindCustom.<>f__mg$cache22D;
			int num559 = 558;
			if (BindCustom.<>f__mg$cache22E == null)
			{
				BindCustom.<>f__mg$cache22E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.reg);
			}
			array[num559] = BindCustom.<>f__mg$cache22E;
			int num560 = 559;
			if (BindCustom.<>f__mg$cache22F == null)
			{
				BindCustom.<>f__mg$cache22F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTurn.reg);
			}
			array[num560] = BindCustom.<>f__mg$cache22F;
			int num561 = 560;
			if (BindCustom.<>f__mg$cache230 == null)
			{
				BindCustom.<>f__mg$cache230 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.reg);
			}
			array[num561] = BindCustom.<>f__mg$cache230;
			int num562 = 561;
			if (BindCustom.<>f__mg$cache231 == null)
			{
				BindCustom.<>f__mg$cache231 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextPlayer.reg);
			}
			array[num562] = BindCustom.<>f__mg$cache231;
			int num563 = 562;
			if (BindCustom.<>f__mg$cache232 == null)
			{
				BindCustom.<>f__mg$cache232 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.reg);
			}
			array[num563] = BindCustom.<>f__mg$cache232;
			int num564 = 563;
			if (BindCustom.<>f__mg$cache233 == null)
			{
				BindCustom.<>f__mg$cache233 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_FastCombatActorInfo.reg);
			}
			array[num564] = BindCustom.<>f__mg$cache233;
			int num565 = 564;
			if (BindCustom.<>f__mg$cache234 == null)
			{
				BindCustom.<>f__mg$cache234 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActFastCombat.reg);
			}
			array[num565] = BindCustom.<>f__mg$cache234;
			int num566 = 565;
			if (BindCustom.<>f__mg$cache235 == null)
			{
				BindCustom.<>f__mg$cache235 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.reg);
			}
			array[num566] = BindCustom.<>f__mg$cache235;
			int num567 = 566;
			if (BindCustom.<>f__mg$cache236 == null)
			{
				BindCustom.<>f__mg$cache236 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.reg);
			}
			array[num567] = BindCustom.<>f__mg$cache236;
			int num568 = 567;
			if (BindCustom.<>f__mg$cache237 == null)
			{
				BindCustom.<>f__mg$cache237 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActStopBattlePerform.reg);
			}
			array[num568] = BindCustom.<>f__mg$cache237;
			int num569 = 568;
			if (BindCustom.<>f__mg$cache238 == null)
			{
				BindCustom.<>f__mg$cache238 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActChangeMapTerrain.reg);
			}
			array[num569] = BindCustom.<>f__mg$cache238;
			int num570 = 569;
			if (BindCustom.<>f__mg$cache239 == null)
			{
				BindCustom.<>f__mg$cache239 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActCameraFocus.reg);
			}
			array[num570] = BindCustom.<>f__mg$cache239;
			int num571 = 570;
			if (BindCustom.<>f__mg$cache23A == null)
			{
				BindCustom.<>f__mg$cache23A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayMusic.reg);
			}
			array[num571] = BindCustom.<>f__mg$cache23A;
			int num572 = 571;
			if (BindCustom.<>f__mg$cache23B == null)
			{
				BindCustom.<>f__mg$cache23B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlaySound.reg);
			}
			array[num572] = BindCustom.<>f__mg$cache23B;
			int num573 = 572;
			if (BindCustom.<>f__mg$cache23C == null)
			{
				BindCustom.<>f__mg$cache23C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActPlayFx.reg);
			}
			array[num573] = BindCustom.<>f__mg$cache23C;
			int num574 = 573;
			if (BindCustom.<>f__mg$cache23D == null)
			{
				BindCustom.<>f__mg$cache23D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.reg);
			}
			array[num574] = BindCustom.<>f__mg$cache23D;
			int num575 = 574;
			if (BindCustom.<>f__mg$cache23E == null)
			{
				BindCustom.<>f__mg$cache23E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.reg);
			}
			array[num575] = BindCustom.<>f__mg$cache23E;
			int num576 = 575;
			if (BindCustom.<>f__mg$cache23F == null)
			{
				BindCustom.<>f__mg$cache23F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.reg);
			}
			array[num576] = BindCustom.<>f__mg$cache23F;
			int num577 = 576;
			if (BindCustom.<>f__mg$cache240 == null)
			{
				BindCustom.<>f__mg$cache240 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_AssetCacheType.reg);
			}
			array[num577] = BindCustom.<>f__mg$cache240;
			int num578 = 577;
			if (BindCustom.<>f__mg$cache241 == null)
			{
				BindCustom.<>f__mg$cache241 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientBattleTreasure.reg);
			}
			array[num578] = BindCustom.<>f__mg$cache241;
			int num579 = 578;
			if (BindCustom.<>f__mg$cache242 == null)
			{
				BindCustom.<>f__mg$cache242 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_CombatCamera.reg);
			}
			array[num579] = BindCustom.<>f__mg$cache242;
			int num580 = 579;
			if (BindCustom.<>f__mg$cache243 == null)
			{
				BindCustom.<>f__mg$cache243 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.reg);
			}
			array[num580] = BindCustom.<>f__mg$cache243;
			int num581 = 580;
			if (BindCustom.<>f__mg$cache244 == null)
			{
				BindCustom.<>f__mg$cache244 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_FxPlayer.reg);
			}
			array[num581] = BindCustom.<>f__mg$cache244;
			int num582 = 581;
			if (BindCustom.<>f__mg$cache245 == null)
			{
				BindCustom.<>f__mg$cache245 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_GenericGraphic.reg);
			}
			array[num582] = BindCustom.<>f__mg$cache245;
			int num583 = 582;
			if (BindCustom.<>f__mg$cache246 == null)
			{
				BindCustom.<>f__mg$cache246 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.reg);
			}
			array[num583] = BindCustom.<>f__mg$cache246;
			int num584 = 583;
			if (BindCustom.<>f__mg$cache247 == null)
			{
				BindCustom.<>f__mg$cache247 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_GenericGraphic_FxInfo.reg);
			}
			array[num584] = BindCustom.<>f__mg$cache247;
			int num585 = 584;
			if (BindCustom.<>f__mg$cache248 == null)
			{
				BindCustom.<>f__mg$cache248 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_GenericGraphic_Ghost.reg);
			}
			array[num585] = BindCustom.<>f__mg$cache248;
			int num586 = 585;
			if (BindCustom.<>f__mg$cache249 == null)
			{
				BindCustom.<>f__mg$cache249 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.reg);
			}
			array[num586] = BindCustom.<>f__mg$cache249;
			int num587 = 586;
			if (BindCustom.<>f__mg$cache24A == null)
			{
				BindCustom.<>f__mg$cache24A = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_GraphicPool.reg);
			}
			array[num587] = BindCustom.<>f__mg$cache24A;
			int num588 = 587;
			if (BindCustom.<>f__mg$cache24B == null)
			{
				BindCustom.<>f__mg$cache24B = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_UISpineGraphic.reg);
			}
			array[num588] = BindCustom.<>f__mg$cache24B;
			int num589 = 588;
			if (BindCustom.<>f__mg$cache24C == null)
			{
				BindCustom.<>f__mg$cache24C = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientWorld.reg);
			}
			array[num589] = BindCustom.<>f__mg$cache24C;
			int num590 = 589;
			if (BindCustom.<>f__mg$cache24D == null)
			{
				BindCustom.<>f__mg$cache24D = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.reg);
			}
			array[num590] = BindCustom.<>f__mg$cache24D;
			int num591 = 590;
			if (BindCustom.<>f__mg$cache24E == null)
			{
				BindCustom.<>f__mg$cache24E = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientWorldEventActor.reg);
			}
			array[num591] = BindCustom.<>f__mg$cache24E;
			int num592 = 591;
			if (BindCustom.<>f__mg$cache24F == null)
			{
				BindCustom.<>f__mg$cache24F = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientWorldPlayerActor.reg);
			}
			array[num592] = BindCustom.<>f__mg$cache24F;
			int num593 = 592;
			if (BindCustom.<>f__mg$cache250 == null)
			{
				BindCustom.<>f__mg$cache250 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.reg);
			}
			array[num593] = BindCustom.<>f__mg$cache250;
			int num594 = 593;
			if (BindCustom.<>f__mg$cache251 == null)
			{
				BindCustom.<>f__mg$cache251 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_ClientWorldWaypoint.reg);
			}
			array[num594] = BindCustom.<>f__mg$cache251;
			int num595 = 594;
			if (BindCustom.<>f__mg$cache252 == null)
			{
				BindCustom.<>f__mg$cache252 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_WorldCamera.reg);
			}
			array[num595] = BindCustom.<>f__mg$cache252;
			int num596 = 595;
			if (BindCustom.<>f__mg$cache253 == null)
			{
				BindCustom.<>f__mg$cache253 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_WorldPathNode.reg);
			}
			array[num596] = BindCustom.<>f__mg$cache253;
			int num597 = 596;
			if (BindCustom.<>f__mg$cache254 == null)
			{
				BindCustom.<>f__mg$cache254 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_WorldPathfinder.reg);
			}
			array[num597] = BindCustom.<>f__mg$cache254;
			int num598 = 597;
			if (BindCustom.<>f__mg$cache255 == null)
			{
				BindCustom.<>f__mg$cache255 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.reg);
			}
			array[num598] = BindCustom.<>f__mg$cache255;
			int num599 = 598;
			if (BindCustom.<>f__mg$cache256 == null)
			{
				BindCustom.<>f__mg$cache256 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UINetTask.reg);
			}
			array[num599] = BindCustom.<>f__mg$cache256;
			int num600 = 599;
			if (BindCustom.<>f__mg$cache257 == null)
			{
				BindCustom.<>f__mg$cache257 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActivityGainRewardNetTask.reg);
			}
			array[num600] = BindCustom.<>f__mg$cache257;
			int num601 = 600;
			if (BindCustom.<>f__mg$cache258 == null)
			{
				BindCustom.<>f__mg$cache258 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActivityExchangeItemGroupNetTask.reg);
			}
			array[num601] = BindCustom.<>f__mg$cache258;
			int num602 = 601;
			if (BindCustom.<>f__mg$cache259 == null)
			{
				BindCustom.<>f__mg$cache259 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_NoviceClaimRewardReqNetTask.reg);
			}
			array[num602] = BindCustom.<>f__mg$cache259;
			int num603 = 602;
			if (BindCustom.<>f__mg$cache25A == null)
			{
				BindCustom.<>f__mg$cache25A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.reg);
			}
			array[num603] = BindCustom.<>f__mg$cache25A;
			int num604 = 603;
			if (BindCustom.<>f__mg$cache25B == null)
			{
				BindCustom.<>f__mg$cache25B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.reg);
			}
			array[num604] = BindCustom.<>f__mg$cache25B;
			int num605 = 604;
			if (BindCustom.<>f__mg$cache25C == null)
			{
				BindCustom.<>f__mg$cache25C = new Action<IntPtr>(Lua_Assets_Script_ProjectL_Runtime_UI_Activity_ActivityRewardUIController.reg);
			}
			array[num605] = BindCustom.<>f__mg$cache25C;
			int num606 = 605;
			if (BindCustom.<>f__mg$cache25D == null)
			{
				BindCustom.<>f__mg$cache25D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActivityUIController.reg);
			}
			array[num606] = BindCustom.<>f__mg$cache25D;
			int num607 = 606;
			if (BindCustom.<>f__mg$cache25E == null)
			{
				BindCustom.<>f__mg$cache25E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UITask.reg);
			}
			array[num607] = BindCustom.<>f__mg$cache25E;
			int num608 = 607;
			if (BindCustom.<>f__mg$cache25F == null)
			{
				BindCustom.<>f__mg$cache25F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActivityUITask.reg);
			}
			array[num608] = BindCustom.<>f__mg$cache25F;
			int num609 = 608;
			if (BindCustom.<>f__mg$cache260 == null)
			{
				BindCustom.<>f__mg$cache260 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUIController.reg);
			}
			array[num609] = BindCustom.<>f__mg$cache260;
			int num610 = 609;
			if (BindCustom.<>f__mg$cache261 == null)
			{
				BindCustom.<>f__mg$cache261 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DayButtonUIController.reg);
			}
			array[num610] = BindCustom.<>f__mg$cache261;
			int num611 = 610;
			if (BindCustom.<>f__mg$cache262 == null)
			{
				BindCustom.<>f__mg$cache262 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_OpenServiceMissonUIController.reg);
			}
			array[num611] = BindCustom.<>f__mg$cache262;
			int num612 = 611;
			if (BindCustom.<>f__mg$cache263 == null)
			{
				BindCustom.<>f__mg$cache263 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_IntegralGoodsUIController.reg);
			}
			array[num612] = BindCustom.<>f__mg$cache263;
			int num613 = 612;
			if (BindCustom.<>f__mg$cache264 == null)
			{
				BindCustom.<>f__mg$cache264 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_OpenServiceActivityUITask.reg);
			}
			array[num613] = BindCustom.<>f__mg$cache264;
			int num614 = 613;
			if (BindCustom.<>f__mg$cache265 == null)
			{
				BindCustom.<>f__mg$cache265 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActivityNoticeBigItemUIController.reg);
			}
			array[num614] = BindCustom.<>f__mg$cache265;
			int num615 = 614;
			if (BindCustom.<>f__mg$cache266 == null)
			{
				BindCustom.<>f__mg$cache266 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActivityNoticeSmallItemUIController.reg);
			}
			array[num615] = BindCustom.<>f__mg$cache266;
			int num616 = 615;
			if (BindCustom.<>f__mg$cache267 == null)
			{
				BindCustom.<>f__mg$cache267 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActivityNoticeUIController.reg);
			}
			array[num616] = BindCustom.<>f__mg$cache267;
			int num617 = 616;
			if (BindCustom.<>f__mg$cache268 == null)
			{
				BindCustom.<>f__mg$cache268 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActivityNoticeInfo.reg);
			}
			array[num617] = BindCustom.<>f__mg$cache268;
			int num618 = 617;
			if (BindCustom.<>f__mg$cache269 == null)
			{
				BindCustom.<>f__mg$cache269 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActivityNoticeUITask.reg);
			}
			array[num618] = BindCustom.<>f__mg$cache269;
			int num619 = 618;
			if (BindCustom.<>f__mg$cache26A == null)
			{
				BindCustom.<>f__mg$cache26A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AnikiLevelAttackNetTask.reg);
			}
			array[num619] = BindCustom.<>f__mg$cache26A;
			int num620 = 619;
			if (BindCustom.<>f__mg$cache26B == null)
			{
				BindCustom.<>f__mg$cache26B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AnikiLevelBattleFinishedNetTask.reg);
			}
			array[num620] = BindCustom.<>f__mg$cache26B;
			int num621 = 620;
			if (BindCustom.<>f__mg$cache26C == null)
			{
				BindCustom.<>f__mg$cache26C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AnikiUIController.reg);
			}
			array[num621] = BindCustom.<>f__mg$cache26C;
			int num622 = 621;
			if (BindCustom.<>f__mg$cache26D == null)
			{
				BindCustom.<>f__mg$cache26D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.reg);
			}
			array[num622] = BindCustom.<>f__mg$cache26D;
			int num623 = 622;
			if (BindCustom.<>f__mg$cache26E == null)
			{
				BindCustom.<>f__mg$cache26E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.reg);
			}
			array[num623] = BindCustom.<>f__mg$cache26E;
			int num624 = 623;
			if (BindCustom.<>f__mg$cache26F == null)
			{
				BindCustom.<>f__mg$cache26F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AnikiUITask.reg);
			}
			array[num624] = BindCustom.<>f__mg$cache26F;
			int num625 = 624;
			if (BindCustom.<>f__mg$cache270 == null)
			{
				BindCustom.<>f__mg$cache270 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AppScoreUIController.reg);
			}
			array[num625] = BindCustom.<>f__mg$cache270;
			int num626 = 625;
			if (BindCustom.<>f__mg$cache271 == null)
			{
				BindCustom.<>f__mg$cache271 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AppScoreUITask.reg);
			}
			array[num626] = BindCustom.<>f__mg$cache271;
			int num627 = 626;
			if (BindCustom.<>f__mg$cache272 == null)
			{
				BindCustom.<>f__mg$cache272 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArchiveUITask.reg);
			}
			array[num627] = BindCustom.<>f__mg$cache272;
			int num628 = 627;
			if (BindCustom.<>f__mg$cache273 == null)
			{
				BindCustom.<>f__mg$cache273 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController.reg);
			}
			array[num628] = BindCustom.<>f__mg$cache273;
			int num629 = 628;
			if (BindCustom.<>f__mg$cache274 == null)
			{
				BindCustom.<>f__mg$cache274 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.reg);
			}
			array[num629] = BindCustom.<>f__mg$cache274;
			int num630 = 629;
			if (BindCustom.<>f__mg$cache275 == null)
			{
				BindCustom.<>f__mg$cache275 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArchiveItemUIController.reg);
			}
			array[num630] = BindCustom.<>f__mg$cache275;
			int num631 = 630;
			if (BindCustom.<>f__mg$cache276 == null)
			{
				BindCustom.<>f__mg$cache276 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArchiveItemDetailInfoController.reg);
			}
			array[num631] = BindCustom.<>f__mg$cache276;
			int num632 = 631;
			if (BindCustom.<>f__mg$cache277 == null)
			{
				BindCustom.<>f__mg$cache277 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController.reg);
			}
			array[num632] = BindCustom.<>f__mg$cache277;
			int num633 = 632;
			if (BindCustom.<>f__mg$cache278 == null)
			{
				BindCustom.<>f__mg$cache278 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.reg);
			}
			array[num633] = BindCustom.<>f__mg$cache278;
			int num634 = 633;
			if (BindCustom.<>f__mg$cache279 == null)
			{
				BindCustom.<>f__mg$cache279 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.reg);
			}
			array[num634] = BindCustom.<>f__mg$cache279;
			int num635 = 634;
			if (BindCustom.<>f__mg$cache27A == null)
			{
				BindCustom.<>f__mg$cache27A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.reg);
			}
			array[num635] = BindCustom.<>f__mg$cache27A;
			int num636 = 635;
			if (BindCustom.<>f__mg$cache27B == null)
			{
				BindCustom.<>f__mg$cache27B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroShowUIController.reg);
			}
			array[num636] = BindCustom.<>f__mg$cache27B;
			int num637 = 636;
			if (BindCustom.<>f__mg$cache27C == null)
			{
				BindCustom.<>f__mg$cache27C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroShowComponent.reg);
			}
			array[num637] = BindCustom.<>f__mg$cache27C;
			int num638 = 637;
			if (BindCustom.<>f__mg$cache27D == null)
			{
				BindCustom.<>f__mg$cache27D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ManualUIController.reg);
			}
			array[num638] = BindCustom.<>f__mg$cache27D;
			int num639 = 638;
			if (BindCustom.<>f__mg$cache27E == null)
			{
				BindCustom.<>f__mg$cache27E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaDefendBattle.reg);
			}
			array[num639] = BindCustom.<>f__mg$cache27E;
			int num640 = 639;
			if (BindCustom.<>f__mg$cache27F == null)
			{
				BindCustom.<>f__mg$cache27F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaDefendMapUIController.reg);
			}
			array[num640] = BindCustom.<>f__mg$cache27F;
			int num641 = 640;
			if (BindCustom.<>f__mg$cache280 == null)
			{
				BindCustom.<>f__mg$cache280 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.reg);
			}
			array[num641] = BindCustom.<>f__mg$cache280;
			int num642 = 641;
			if (BindCustom.<>f__mg$cache281 == null)
			{
				BindCustom.<>f__mg$cache281 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaDefendActor.reg);
			}
			array[num642] = BindCustom.<>f__mg$cache281;
			int num643 = 642;
			if (BindCustom.<>f__mg$cache282 == null)
			{
				BindCustom.<>f__mg$cache282 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaDefendUIController.reg);
			}
			array[num643] = BindCustom.<>f__mg$cache282;
			int num644 = 643;
			if (BindCustom.<>f__mg$cache283 == null)
			{
				BindCustom.<>f__mg$cache283 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.reg);
			}
			array[num644] = BindCustom.<>f__mg$cache283;
			int num645 = 644;
			if (BindCustom.<>f__mg$cache284 == null)
			{
				BindCustom.<>f__mg$cache284 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaDefendMapToggle.reg);
			}
			array[num645] = BindCustom.<>f__mg$cache284;
			int num646 = 645;
			if (BindCustom.<>f__mg$cache285 == null)
			{
				BindCustom.<>f__mg$cache285 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaDefendRuleToggle.reg);
			}
			array[num646] = BindCustom.<>f__mg$cache285;
			int num647 = 646;
			if (BindCustom.<>f__mg$cache286 == null)
			{
				BindCustom.<>f__mg$cache286 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaDefendUITask.reg);
			}
			array[num647] = BindCustom.<>f__mg$cache286;
			int num648 = 647;
			if (BindCustom.<>f__mg$cache287 == null)
			{
				BindCustom.<>f__mg$cache287 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaPlayerInfoGetNetTask.reg);
			}
			array[num648] = BindCustom.<>f__mg$cache287;
			int num649 = 648;
			if (BindCustom.<>f__mg$cache288 == null)
			{
				BindCustom.<>f__mg$cache288 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaOpponentViewNetTask.reg);
			}
			array[num649] = BindCustom.<>f__mg$cache288;
			int num650 = 649;
			if (BindCustom.<>f__mg$cache289 == null)
			{
				BindCustom.<>f__mg$cache289 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackNetTask.reg);
			}
			array[num650] = BindCustom.<>f__mg$cache289;
			int num651 = 650;
			if (BindCustom.<>f__mg$cache28A == null)
			{
				BindCustom.<>f__mg$cache28A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaRevengeOpponentGetNetTask.reg);
			}
			array[num651] = BindCustom.<>f__mg$cache28A;
			int num652 = 651;
			if (BindCustom.<>f__mg$cache28B == null)
			{
				BindCustom.<>f__mg$cache28B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaOpponentRevengeNetTask.reg);
			}
			array[num652] = BindCustom.<>f__mg$cache28B;
			int num653 = 652;
			if (BindCustom.<>f__mg$cache28C == null)
			{
				BindCustom.<>f__mg$cache28C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaOpponentAttackFightingNetTask.reg);
			}
			array[num653] = BindCustom.<>f__mg$cache28C;
			int num654 = 653;
			if (BindCustom.<>f__mg$cache28D == null)
			{
				BindCustom.<>f__mg$cache28D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaBattleFinishedNetTask.reg);
			}
			array[num654] = BindCustom.<>f__mg$cache28D;
			int num655 = 654;
			if (BindCustom.<>f__mg$cache28E == null)
			{
				BindCustom.<>f__mg$cache28E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaPlayerSetDefensiveTeamNetTask.reg);
			}
			array[num655] = BindCustom.<>f__mg$cache28E;
			int num656 = 655;
			if (BindCustom.<>f__mg$cache28F == null)
			{
				BindCustom.<>f__mg$cache28F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaVictoryPointsRewardGainNetTask.reg);
			}
			array[num656] = BindCustom.<>f__mg$cache28F;
			int num657 = 656;
			if (BindCustom.<>f__mg$cache290 == null)
			{
				BindCustom.<>f__mg$cache290 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaBattleReportBasicDataGetNetTask.reg);
			}
			array[num657] = BindCustom.<>f__mg$cache290;
			int num658 = 657;
			if (BindCustom.<>f__mg$cache291 == null)
			{
				BindCustom.<>f__mg$cache291 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaBattleReportPlayBackDataGetNetTask.reg);
			}
			array[num658] = BindCustom.<>f__mg$cache291;
			int num659 = 658;
			if (BindCustom.<>f__mg$cache292 == null)
			{
				BindCustom.<>f__mg$cache292 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaTopRankPlayersGetNetTask.reg);
			}
			array[num659] = BindCustom.<>f__mg$cache292;
			int num660 = 659;
			if (BindCustom.<>f__mg$cache293 == null)
			{
				BindCustom.<>f__mg$cache293 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaTicketsBuyNetTask.reg);
			}
			array[num660] = BindCustom.<>f__mg$cache293;
			int num661 = 660;
			if (BindCustom.<>f__mg$cache294 == null)
			{
				BindCustom.<>f__mg$cache294 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaBattleReconnectNetTask.reg);
			}
			array[num661] = BindCustom.<>f__mg$cache294;
			int num662 = 661;
			if (BindCustom.<>f__mg$cache295 == null)
			{
				BindCustom.<>f__mg$cache295 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RealTimePVPWaitingForOpponentNetTask.reg);
			}
			array[num662] = BindCustom.<>f__mg$cache295;
			int num663 = 662;
			if (BindCustom.<>f__mg$cache296 == null)
			{
				BindCustom.<>f__mg$cache296 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RealTimePVPCancelWaitingForOpponentNetTask.reg);
			}
			array[num663] = BindCustom.<>f__mg$cache296;
			int num664 = 663;
			if (BindCustom.<>f__mg$cache297 == null)
			{
				BindCustom.<>f__mg$cache297 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RealTimePVPGetInfoNetTask.reg);
			}
			array[num664] = BindCustom.<>f__mg$cache297;
			int num665 = 664;
			if (BindCustom.<>f__mg$cache298 == null)
			{
				BindCustom.<>f__mg$cache298 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RealTimePVPGetTopPlayersNetTask.reg);
			}
			array[num665] = BindCustom.<>f__mg$cache298;
			int num666 = 665;
			if (BindCustom.<>f__mg$cache299 == null)
			{
				BindCustom.<>f__mg$cache299 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RealTimePVPAcquireWinsBonusNetTask.reg);
			}
			array[num666] = BindCustom.<>f__mg$cache299;
			int num667 = 666;
			if (BindCustom.<>f__mg$cache29A == null)
			{
				BindCustom.<>f__mg$cache29A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.reg);
			}
			array[num667] = BindCustom.<>f__mg$cache29A;
			int num668 = 667;
			if (BindCustom.<>f__mg$cache29B == null)
			{
				BindCustom.<>f__mg$cache29B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaSelectUITask.reg);
			}
			array[num668] = BindCustom.<>f__mg$cache29B;
			int num669 = 668;
			if (BindCustom.<>f__mg$cache29C == null)
			{
				BindCustom.<>f__mg$cache29C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaUIController.reg);
			}
			array[num669] = BindCustom.<>f__mg$cache29C;
			int num670 = 669;
			if (BindCustom.<>f__mg$cache29D == null)
			{
				BindCustom.<>f__mg$cache29D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaOpponentListItemUIController.reg);
			}
			array[num670] = BindCustom.<>f__mg$cache29D;
			int num671 = 670;
			if (BindCustom.<>f__mg$cache29E == null)
			{
				BindCustom.<>f__mg$cache29E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_OfflineArenaBattleReportListItemUIController.reg);
			}
			array[num671] = BindCustom.<>f__mg$cache29E;
			int num672 = 671;
			if (BindCustom.<>f__mg$cache29F == null)
			{
				BindCustom.<>f__mg$cache29F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_OnlineArenaBattleReportListItemUIController.reg);
			}
			array[num672] = BindCustom.<>f__mg$cache29F;
			int num673 = 672;
			if (BindCustom.<>f__mg$cache2A0 == null)
			{
				BindCustom.<>f__mg$cache2A0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaLevelListItemUIController.reg);
			}
			array[num673] = BindCustom.<>f__mg$cache2A0;
			int num674 = 673;
			if (BindCustom.<>f__mg$cache2A1 == null)
			{
				BindCustom.<>f__mg$cache2A1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaRankingListItemUIController.reg);
			}
			array[num674] = BindCustom.<>f__mg$cache2A1;
			int num675 = 674;
			if (BindCustom.<>f__mg$cache2A2 == null)
			{
				BindCustom.<>f__mg$cache2A2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.reg);
			}
			array[num675] = BindCustom.<>f__mg$cache2A2;
			int num676 = 675;
			if (BindCustom.<>f__mg$cache2A3 == null)
			{
				BindCustom.<>f__mg$cache2A3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaRankingRewardListItemUIController.reg);
			}
			array[num676] = BindCustom.<>f__mg$cache2A3;
			int num677 = 676;
			if (BindCustom.<>f__mg$cache2A4 == null)
			{
				BindCustom.<>f__mg$cache2A4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ArenaUITask.reg);
			}
			array[num677] = BindCustom.<>f__mg$cache2A4;
			int num678 = 677;
			if (BindCustom.<>f__mg$cache2A5 == null)
			{
				BindCustom.<>f__mg$cache2A5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AlchemyUIController.reg);
			}
			array[num678] = BindCustom.<>f__mg$cache2A5;
			int num679 = 678;
			if (BindCustom.<>f__mg$cache2A6 == null)
			{
				BindCustom.<>f__mg$cache2A6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BagFullUIController.reg);
			}
			array[num679] = BindCustom.<>f__mg$cache2A6;
			int num680 = 679;
			if (BindCustom.<>f__mg$cache2A7 == null)
			{
				BindCustom.<>f__mg$cache2A7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BagFullUITask.reg);
			}
			array[num680] = BindCustom.<>f__mg$cache2A7;
			int num681 = 680;
			if (BindCustom.<>f__mg$cache2A8 == null)
			{
				BindCustom.<>f__mg$cache2A8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BagItemUIController.reg);
			}
			array[num681] = BindCustom.<>f__mg$cache2A8;
			int num682 = 681;
			if (BindCustom.<>f__mg$cache2A9 == null)
			{
				BindCustom.<>f__mg$cache2A9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BagListUIController.reg);
			}
			array[num682] = BindCustom.<>f__mg$cache2A9;
			int num683 = 682;
			if (BindCustom.<>f__mg$cache2AA == null)
			{
				BindCustom.<>f__mg$cache2AA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BagListUITask.reg);
			}
			array[num683] = BindCustom.<>f__mg$cache2AA;
			int num684 = 683;
			if (BindCustom.<>f__mg$cache2AB == null)
			{
				BindCustom.<>f__mg$cache2AB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.reg);
			}
			array[num684] = BindCustom.<>f__mg$cache2AB;
			int num685 = 684;
			if (BindCustom.<>f__mg$cache2AC == null)
			{
				BindCustom.<>f__mg$cache2AC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BagItemSellNetTask.reg);
			}
			array[num685] = BindCustom.<>f__mg$cache2AC;
			int num686 = 685;
			if (BindCustom.<>f__mg$cache2AD == null)
			{
				BindCustom.<>f__mg$cache2AD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BagItemDecomposeNetTask.reg);
			}
			array[num686] = BindCustom.<>f__mg$cache2AD;
			int num687 = 686;
			if (BindCustom.<>f__mg$cache2AE == null)
			{
				BindCustom.<>f__mg$cache2AE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActionOrderUIController.reg);
			}
			array[num687] = BindCustom.<>f__mg$cache2AE;
			int num688 = 687;
			if (BindCustom.<>f__mg$cache2AF == null)
			{
				BindCustom.<>f__mg$cache2AF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleAchievementItemUIController.reg);
			}
			array[num688] = BindCustom.<>f__mg$cache2AF;
			int num689 = 688;
			if (BindCustom.<>f__mg$cache2B0 == null)
			{
				BindCustom.<>f__mg$cache2B0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleActorInfoUIController.reg);
			}
			array[num689] = BindCustom.<>f__mg$cache2B0;
			int num690 = 689;
			if (BindCustom.<>f__mg$cache2B1 == null)
			{
				BindCustom.<>f__mg$cache2B1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BuffDesc.reg);
			}
			array[num690] = BindCustom.<>f__mg$cache2B1;
			int num691 = 690;
			if (BindCustom.<>f__mg$cache2B2 == null)
			{
				BindCustom.<>f__mg$cache2B2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SkillDesc.reg);
			}
			array[num691] = BindCustom.<>f__mg$cache2B2;
			int num692 = 691;
			if (BindCustom.<>f__mg$cache2B3 == null)
			{
				BindCustom.<>f__mg$cache2B3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleActorUIController.reg);
			}
			array[num692] = BindCustom.<>f__mg$cache2B3;
			int num693 = 692;
			if (BindCustom.<>f__mg$cache2B4 == null)
			{
				BindCustom.<>f__mg$cache2B4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleCommonUIController.reg);
			}
			array[num693] = BindCustom.<>f__mg$cache2B4;
			int num694 = 693;
			if (BindCustom.<>f__mg$cache2B5 == null)
			{
				BindCustom.<>f__mg$cache2B5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleDanmakuUIController.reg);
			}
			array[num694] = BindCustom.<>f__mg$cache2B5;
			int num695 = 694;
			if (BindCustom.<>f__mg$cache2B6 == null)
			{
				BindCustom.<>f__mg$cache2B6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleDialogUIController.reg);
			}
			array[num695] = BindCustom.<>f__mg$cache2B6;
			int num696 = 695;
			if (BindCustom.<>f__mg$cache2B7 == null)
			{
				BindCustom.<>f__mg$cache2B7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleDialogBoxUIController.reg);
			}
			array[num696] = BindCustom.<>f__mg$cache2B7;
			int num697 = 696;
			if (BindCustom.<>f__mg$cache2B8 == null)
			{
				BindCustom.<>f__mg$cache2B8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleDialogUITask.reg);
			}
			array[num697] = BindCustom.<>f__mg$cache2B8;
			int num698 = 697;
			if (BindCustom.<>f__mg$cache2B9 == null)
			{
				BindCustom.<>f__mg$cache2B9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleLoseUIController.reg);
			}
			array[num698] = BindCustom.<>f__mg$cache2B9;
			int num699 = 698;
			if (BindCustom.<>f__mg$cache2BA == null)
			{
				BindCustom.<>f__mg$cache2BA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleLoseUITask.reg);
			}
			array[num699] = BindCustom.<>f__mg$cache2BA;
			int num700 = 699;
			if (BindCustom.<>f__mg$cache2BB == null)
			{
				BindCustom.<>f__mg$cache2BB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleMapUIController.reg);
			}
			array[num700] = BindCustom.<>f__mg$cache2BB;
			int num701 = 700;
			if (BindCustom.<>f__mg$cache2BC == null)
			{
				BindCustom.<>f__mg$cache2BC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RegionGridEffect.reg);
			}
			array[num701] = BindCustom.<>f__mg$cache2BC;
			int num702 = 701;
			if (BindCustom.<>f__mg$cache2BD == null)
			{
				BindCustom.<>f__mg$cache2BD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleCancelNetTask.reg);
			}
			array[num702] = BindCustom.<>f__mg$cache2BD;
			int num703 = 702;
			if (BindCustom.<>f__mg$cache2BE == null)
			{
				BindCustom.<>f__mg$cache2BE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleArmyRandomSeedGetNetTask.reg);
			}
			array[num703] = BindCustom.<>f__mg$cache2BE;
			int num704 = 703;
			if (BindCustom.<>f__mg$cache2BF == null)
			{
				BindCustom.<>f__mg$cache2BF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleTeamSetNetTask.reg);
			}
			array[num704] = BindCustom.<>f__mg$cache2BF;
			int num705 = 704;
			if (BindCustom.<>f__mg$cache2C0 == null)
			{
				BindCustom.<>f__mg$cache2C0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DanmakuGetNetTask.reg);
			}
			array[num705] = BindCustom.<>f__mg$cache2C0;
			int num706 = 705;
			if (BindCustom.<>f__mg$cache2C1 == null)
			{
				BindCustom.<>f__mg$cache2C1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DanmakuPostNetTask.reg);
			}
			array[num706] = BindCustom.<>f__mg$cache2C1;
			int num707 = 706;
			if (BindCustom.<>f__mg$cache2C2 == null)
			{
				BindCustom.<>f__mg$cache2C2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomPlayerStatusChangeNetTask.reg);
			}
			array[num707] = BindCustom.<>f__mg$cache2C2;
			int num708 = 707;
			if (BindCustom.<>f__mg$cache2C3 == null)
			{
				BindCustom.<>f__mg$cache2C3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomHeroSetupNetTask.reg);
			}
			array[num708] = BindCustom.<>f__mg$cache2C3;
			int num709 = 708;
			if (BindCustom.<>f__mg$cache2C4 == null)
			{
				BindCustom.<>f__mg$cache2C4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomHeroSwapNetTask.reg);
			}
			array[num709] = BindCustom.<>f__mg$cache2C4;
			int num710 = 709;
			if (BindCustom.<>f__mg$cache2C5 == null)
			{
				BindCustom.<>f__mg$cache2C5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomHeroPutdownNetTask.reg);
			}
			array[num710] = BindCustom.<>f__mg$cache2C5;
			int num711 = 710;
			if (BindCustom.<>f__mg$cache2C6 == null)
			{
				BindCustom.<>f__mg$cache2C6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomHeroProtectNetTask.reg);
			}
			array[num711] = BindCustom.<>f__mg$cache2C6;
			int num712 = 711;
			if (BindCustom.<>f__mg$cache2C7 == null)
			{
				BindCustom.<>f__mg$cache2C7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomHeroBanNetTask.reg);
			}
			array[num712] = BindCustom.<>f__mg$cache2C7;
			int num713 = 712;
			if (BindCustom.<>f__mg$cache2C8 == null)
			{
				BindCustom.<>f__mg$cache2C8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomEndCurrentBPTurnNetTask.reg);
			}
			array[num713] = BindCustom.<>f__mg$cache2C8;
			int num714 = 713;
			if (BindCustom.<>f__mg$cache2C9 == null)
			{
				BindCustom.<>f__mg$cache2C9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomBattleCommandExecuteNetTask.reg);
			}
			array[num714] = BindCustom.<>f__mg$cache2C9;
			int num715 = 714;
			if (BindCustom.<>f__mg$cache2CA == null)
			{
				BindCustom.<>f__mg$cache2CA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomQuitNetTask.reg);
			}
			array[num715] = BindCustom.<>f__mg$cache2CA;
			int num716 = 715;
			if (BindCustom.<>f__mg$cache2CB == null)
			{
				BindCustom.<>f__mg$cache2CB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomPlayerActionBeginNetTask.reg);
			}
			array[num716] = BindCustom.<>f__mg$cache2CB;
			int num717 = 716;
			if (BindCustom.<>f__mg$cache2CC == null)
			{
				BindCustom.<>f__mg$cache2CC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomGetNetTask.reg);
			}
			array[num717] = BindCustom.<>f__mg$cache2CC;
			int num718 = 717;
			if (BindCustom.<>f__mg$cache2CD == null)
			{
				BindCustom.<>f__mg$cache2CD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattlePauseUIController.reg);
			}
			array[num718] = BindCustom.<>f__mg$cache2CD;
			int num719 = 718;
			if (BindCustom.<>f__mg$cache2CE == null)
			{
				BindCustom.<>f__mg$cache2CE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DanmakuItemUIController.reg);
			}
			array[num719] = BindCustom.<>f__mg$cache2CE;
			int num720 = 719;
			if (BindCustom.<>f__mg$cache2CF == null)
			{
				BindCustom.<>f__mg$cache2CF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattlePrepareActorInfoUIController.reg);
			}
			array[num720] = BindCustom.<>f__mg$cache2CF;
			int num721 = 720;
			if (BindCustom.<>f__mg$cache2D0 == null)
			{
				BindCustom.<>f__mg$cache2D0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattlePrepareStageActor.reg);
			}
			array[num721] = BindCustom.<>f__mg$cache2D0;
			int num722 = 721;
			if (BindCustom.<>f__mg$cache2D1 == null)
			{
				BindCustom.<>f__mg$cache2D1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattlePrepareTreasure.reg);
			}
			array[num722] = BindCustom.<>f__mg$cache2D1;
			int num723 = 722;
			if (BindCustom.<>f__mg$cache2D2 == null)
			{
				BindCustom.<>f__mg$cache2D2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattlePrepareUIController.reg);
			}
			array[num723] = BindCustom.<>f__mg$cache2D2;
			int num724 = 723;
			if (BindCustom.<>f__mg$cache2D3 == null)
			{
				BindCustom.<>f__mg$cache2D3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDragButton.reg);
			}
			array[num724] = BindCustom.<>f__mg$cache2D3;
			int num725 = 724;
			if (BindCustom.<>f__mg$cache2D4 == null)
			{
				BindCustom.<>f__mg$cache2D4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleReportEndUIController.reg);
			}
			array[num725] = BindCustom.<>f__mg$cache2D4;
			int num726 = 725;
			if (BindCustom.<>f__mg$cache2D5 == null)
			{
				BindCustom.<>f__mg$cache2D5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleReportEndUITask.reg);
			}
			array[num726] = BindCustom.<>f__mg$cache2D5;
			int num727 = 726;
			if (BindCustom.<>f__mg$cache2D6 == null)
			{
				BindCustom.<>f__mg$cache2D6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleResultScoreUIController.reg);
			}
			array[num727] = BindCustom.<>f__mg$cache2D6;
			int num728 = 727;
			if (BindCustom.<>f__mg$cache2D7 == null)
			{
				BindCustom.<>f__mg$cache2D7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleResultScoreUITask.reg);
			}
			array[num728] = BindCustom.<>f__mg$cache2D7;
			int num729 = 728;
			if (BindCustom.<>f__mg$cache2D8 == null)
			{
				BindCustom.<>f__mg$cache2D8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleResultUIController.reg);
			}
			array[num729] = BindCustom.<>f__mg$cache2D8;
			int num730 = 729;
			if (BindCustom.<>f__mg$cache2D9 == null)
			{
				BindCustom.<>f__mg$cache2D9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.reg);
			}
			array[num730] = BindCustom.<>f__mg$cache2D9;
			int num731 = 730;
			if (BindCustom.<>f__mg$cache2DA == null)
			{
				BindCustom.<>f__mg$cache2DA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.reg);
			}
			array[num731] = BindCustom.<>f__mg$cache2DA;
			int num732 = 731;
			if (BindCustom.<>f__mg$cache2DB == null)
			{
				BindCustom.<>f__mg$cache2DB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleResultUITask.reg);
			}
			array[num732] = BindCustom.<>f__mg$cache2DB;
			int num733 = 732;
			if (BindCustom.<>f__mg$cache2DC == null)
			{
				BindCustom.<>f__mg$cache2DC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleRoomUIController.reg);
			}
			array[num733] = BindCustom.<>f__mg$cache2DC;
			int num734 = 733;
			if (BindCustom.<>f__mg$cache2DD == null)
			{
				BindCustom.<>f__mg$cache2DD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleTeamPlayerUIController.reg);
			}
			array[num734] = BindCustom.<>f__mg$cache2DD;
			int num735 = 734;
			if (BindCustom.<>f__mg$cache2DE == null)
			{
				BindCustom.<>f__mg$cache2DE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleSceneUIController.reg);
			}
			array[num735] = BindCustom.<>f__mg$cache2DE;
			int num736 = 735;
			if (BindCustom.<>f__mg$cache2DF == null)
			{
				BindCustom.<>f__mg$cache2DF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DamageNumber.reg);
			}
			array[num736] = BindCustom.<>f__mg$cache2DF;
			int num737 = 736;
			if (BindCustom.<>f__mg$cache2E0 == null)
			{
				BindCustom.<>f__mg$cache2E0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleSoldierItemUIController.reg);
			}
			array[num737] = BindCustom.<>f__mg$cache2E0;
			int num738 = 737;
			if (BindCustom.<>f__mg$cache2E1 == null)
			{
				BindCustom.<>f__mg$cache2E1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleTreasureDialogUIController.reg);
			}
			array[num738] = BindCustom.<>f__mg$cache2E1;
			int num739 = 738;
			if (BindCustom.<>f__mg$cache2E2 == null)
			{
				BindCustom.<>f__mg$cache2E2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleUIController.reg);
			}
			array[num739] = BindCustom.<>f__mg$cache2E2;
			int num740 = 739;
			if (BindCustom.<>f__mg$cache2E3 == null)
			{
				BindCustom.<>f__mg$cache2E3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleSkillButton.reg);
			}
			array[num740] = BindCustom.<>f__mg$cache2E3;
			int num741 = 740;
			if (BindCustom.<>f__mg$cache2E4 == null)
			{
				BindCustom.<>f__mg$cache2E4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleUITask.reg);
			}
			array[num741] = BindCustom.<>f__mg$cache2E4;
			int num742 = 741;
			if (BindCustom.<>f__mg$cache2E5 == null)
			{
				BindCustom.<>f__mg$cache2E5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_StagePosition.reg);
			}
			array[num742] = BindCustom.<>f__mg$cache2E5;
			int num743 = 742;
			if (BindCustom.<>f__mg$cache2E6 == null)
			{
				BindCustom.<>f__mg$cache2E6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CombatSceneUIController.reg);
			}
			array[num743] = BindCustom.<>f__mg$cache2E6;
			int num744 = 743;
			if (BindCustom.<>f__mg$cache2E7 == null)
			{
				BindCustom.<>f__mg$cache2E7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CombatUIController.reg);
			}
			array[num744] = BindCustom.<>f__mg$cache2E7;
			int num745 = 744;
			if (BindCustom.<>f__mg$cache2E8 == null)
			{
				BindCustom.<>f__mg$cache2E8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CombatUIController_HPState.reg);
			}
			array[num745] = BindCustom.<>f__mg$cache2E8;
			int num746 = 745;
			if (BindCustom.<>f__mg$cache2E9 == null)
			{
				BindCustom.<>f__mg$cache2E9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CombatCharUIController.reg);
			}
			array[num746] = BindCustom.<>f__mg$cache2E9;
			int num747 = 746;
			if (BindCustom.<>f__mg$cache2EA == null)
			{
				BindCustom.<>f__mg$cache2EA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PreCombatUIController.reg);
			}
			array[num747] = BindCustom.<>f__mg$cache2EA;
			int num748 = 747;
			if (BindCustom.<>f__mg$cache2EB == null)
			{
				BindCustom.<>f__mg$cache2EB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PVPBattlePrepareUIController.reg);
			}
			array[num748] = BindCustom.<>f__mg$cache2EB;
			int num749 = 748;
			if (BindCustom.<>f__mg$cache2EC == null)
			{
				BindCustom.<>f__mg$cache2EC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ARHeroListUIController.reg);
			}
			array[num749] = BindCustom.<>f__mg$cache2EC;
			int num750 = 749;
			if (BindCustom.<>f__mg$cache2ED == null)
			{
				BindCustom.<>f__mg$cache2ED = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.reg);
			}
			array[num750] = BindCustom.<>f__mg$cache2ED;
			int num751 = 750;
			if (BindCustom.<>f__mg$cache2EE == null)
			{
				BindCustom.<>f__mg$cache2EE = new Action<IntPtr>(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.reg);
			}
			array[num751] = BindCustom.<>f__mg$cache2EE;
			int num752 = 751;
			if (BindCustom.<>f__mg$cache2EF == null)
			{
				BindCustom.<>f__mg$cache2EF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ARShowSceneController.reg);
			}
			array[num752] = BindCustom.<>f__mg$cache2EF;
			int num753 = 752;
			if (BindCustom.<>f__mg$cache2F0 == null)
			{
				BindCustom.<>f__mg$cache2F0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ARShowUIController.reg);
			}
			array[num753] = BindCustom.<>f__mg$cache2F0;
			int num754 = 753;
			if (BindCustom.<>f__mg$cache2F1 == null)
			{
				BindCustom.<>f__mg$cache2F1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ARUITask.reg);
			}
			array[num754] = BindCustom.<>f__mg$cache2F1;
			int num755 = 754;
			if (BindCustom.<>f__mg$cache2F2 == null)
			{
				BindCustom.<>f__mg$cache2F2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardRandomShowChangeNetTask.reg);
			}
			array[num755] = BindCustom.<>f__mg$cache2F2;
			int num756 = 755;
			if (BindCustom.<>f__mg$cache2F3 == null)
			{
				BindCustom.<>f__mg$cache2F3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LikeNetTask.reg);
			}
			array[num756] = BindCustom.<>f__mg$cache2F3;
			int num757 = 756;
			if (BindCustom.<>f__mg$cache2F4 == null)
			{
				BindCustom.<>f__mg$cache2F4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardGetNetTask.reg);
			}
			array[num757] = BindCustom.<>f__mg$cache2F4;
			int num758 = 757;
			if (BindCustom.<>f__mg$cache2F5 == null)
			{
				BindCustom.<>f__mg$cache2F5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardDescUpdateNetTask.reg);
			}
			array[num758] = BindCustom.<>f__mg$cache2F5;
			int num759 = 758;
			if (BindCustom.<>f__mg$cache2F6 == null)
			{
				BindCustom.<>f__mg$cache2F6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardHeroSetUpdateNetTask.reg);
			}
			array[num759] = BindCustom.<>f__mg$cache2F6;
			int num760 = 759;
			if (BindCustom.<>f__mg$cache2F7 == null)
			{
				BindCustom.<>f__mg$cache2F7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardOftenUsedHeroItemController.reg);
			}
			array[num760] = BindCustom.<>f__mg$cache2F7;
			int num761 = 760;
			if (BindCustom.<>f__mg$cache2F8 == null)
			{
				BindCustom.<>f__mg$cache2F8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardUIController.reg);
			}
			array[num761] = BindCustom.<>f__mg$cache2F8;
			int num762 = 761;
			if (BindCustom.<>f__mg$cache2F9 == null)
			{
				BindCustom.<>f__mg$cache2F9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardUIController_GraphicInfo.reg);
			}
			array[num762] = BindCustom.<>f__mg$cache2F9;
			int num763 = 762;
			if (BindCustom.<>f__mg$cache2FA == null)
			{
				BindCustom.<>f__mg$cache2FA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardHeroEquipmentItemController.reg);
			}
			array[num763] = BindCustom.<>f__mg$cache2FA;
			int num764 = 763;
			if (BindCustom.<>f__mg$cache2FB == null)
			{
				BindCustom.<>f__mg$cache2FB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardHeroListItemUIController.reg);
			}
			array[num764] = BindCustom.<>f__mg$cache2FB;
			int num765 = 764;
			if (BindCustom.<>f__mg$cache2FC == null)
			{
				BindCustom.<>f__mg$cache2FC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.reg);
			}
			array[num765] = BindCustom.<>f__mg$cache2FC;
			int num766 = 765;
			if (BindCustom.<>f__mg$cache2FD == null)
			{
				BindCustom.<>f__mg$cache2FD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BusinessCardUITask.reg);
			}
			array[num766] = BindCustom.<>f__mg$cache2FD;
			int num767 = 766;
			if (BindCustom.<>f__mg$cache2FE == null)
			{
				BindCustom.<>f__mg$cache2FE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BigExpressionController.reg);
			}
			array[num767] = BindCustom.<>f__mg$cache2FE;
			int num768 = 767;
			if (BindCustom.<>f__mg$cache2FF == null)
			{
				BindCustom.<>f__mg$cache2FF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BigExpressionItem.reg);
			}
			array[num768] = BindCustom.<>f__mg$cache2FF;
			int num769 = 768;
			if (BindCustom.<>f__mg$cache300 == null)
			{
				BindCustom.<>f__mg$cache300 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BigExpressionInChatController.reg);
			}
			array[num769] = BindCustom.<>f__mg$cache300;
			int num770 = 769;
			if (BindCustom.<>f__mg$cache301 == null)
			{
				BindCustom.<>f__mg$cache301 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChatExpressionUIController.reg);
			}
			array[num770] = BindCustom.<>f__mg$cache301;
			int num771 = 770;
			if (BindCustom.<>f__mg$cache302 == null)
			{
				BindCustom.<>f__mg$cache302 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.reg);
			}
			array[num771] = BindCustom.<>f__mg$cache302;
			int num772 = 771;
			if (BindCustom.<>f__mg$cache303 == null)
			{
				BindCustom.<>f__mg$cache303 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChatItemManagerController.reg);
			}
			array[num772] = BindCustom.<>f__mg$cache303;
			int num773 = 772;
			if (BindCustom.<>f__mg$cache304 == null)
			{
				BindCustom.<>f__mg$cache304 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerChatItemUIController.reg);
			}
			array[num773] = BindCustom.<>f__mg$cache304;
			int num774 = 773;
			if (BindCustom.<>f__mg$cache305 == null)
			{
				BindCustom.<>f__mg$cache305 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SystemChatItemUIController.reg);
			}
			array[num774] = BindCustom.<>f__mg$cache305;
			int num775 = 774;
			if (BindCustom.<>f__mg$cache306 == null)
			{
				BindCustom.<>f__mg$cache306 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChatMessageSendNetTask.reg);
			}
			array[num775] = BindCustom.<>f__mg$cache306;
			int num776 = 775;
			if (BindCustom.<>f__mg$cache307 == null)
			{
				BindCustom.<>f__mg$cache307 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChatExpressionMessageSendNetTask.reg);
			}
			array[num776] = BindCustom.<>f__mg$cache307;
			int num777 = 776;
			if (BindCustom.<>f__mg$cache308 == null)
			{
				BindCustom.<>f__mg$cache308 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChatEnterRoomNetTask.reg);
			}
			array[num777] = BindCustom.<>f__mg$cache308;
			int num778 = 777;
			if (BindCustom.<>f__mg$cache309 == null)
			{
				BindCustom.<>f__mg$cache309 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChatGetPlayrInfoListNetTask.reg);
			}
			array[num778] = BindCustom.<>f__mg$cache309;
			int num779 = 778;
			if (BindCustom.<>f__mg$cache30A == null)
			{
				BindCustom.<>f__mg$cache30A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendGetUserSummaryReqNetTask.reg);
			}
			array[num779] = BindCustom.<>f__mg$cache30A;
			int num780 = 779;
			if (BindCustom.<>f__mg$cache30B == null)
			{
				BindCustom.<>f__mg$cache30B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChatUIController.reg);
			}
			array[num780] = BindCustom.<>f__mg$cache30B;
			int num781 = 780;
			if (BindCustom.<>f__mg$cache30C == null)
			{
				BindCustom.<>f__mg$cache30C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChatUITask.reg);
			}
			array[num781] = BindCustom.<>f__mg$cache30C;
			int num782 = 781;
			if (BindCustom.<>f__mg$cache30D == null)
			{
				BindCustom.<>f__mg$cache30D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread.reg);
			}
			array[num782] = BindCustom.<>f__mg$cache30D;
			int num783 = 782;
			if (BindCustom.<>f__mg$cache30E == null)
			{
				BindCustom.<>f__mg$cache30E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.reg);
			}
			array[num783] = BindCustom.<>f__mg$cache30E;
			int num784 = 783;
			if (BindCustom.<>f__mg$cache30F == null)
			{
				BindCustom.<>f__mg$cache30F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.reg);
			}
			array[num784] = BindCustom.<>f__mg$cache30F;
			int num785 = 784;
			if (BindCustom.<>f__mg$cache310 == null)
			{
				BindCustom.<>f__mg$cache310 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_VoiceChatCompression.reg);
			}
			array[num785] = BindCustom.<>f__mg$cache310;
			int num786 = 785;
			if (BindCustom.<>f__mg$cache311 == null)
			{
				BindCustom.<>f__mg$cache311 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_VoicePlayer.reg);
			}
			array[num786] = BindCustom.<>f__mg$cache311;
			int num787 = 786;
			if (BindCustom.<>f__mg$cache312 == null)
			{
				BindCustom.<>f__mg$cache312 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.reg);
			}
			array[num787] = BindCustom.<>f__mg$cache312;
			int num788 = 787;
			if (BindCustom.<>f__mg$cache313 == null)
			{
				BindCustom.<>f__mg$cache313 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_VoiceRecordHelper.reg);
			}
			array[num788] = BindCustom.<>f__mg$cache313;
			int num789 = 788;
			if (BindCustom.<>f__mg$cache314 == null)
			{
				BindCustom.<>f__mg$cache314 = new Action<IntPtr>(Lua_EmojiText_PosStringTuple.reg);
			}
			array[num789] = BindCustom.<>f__mg$cache314;
			int num790 = 789;
			if (BindCustom.<>f__mg$cache315 == null)
			{
				BindCustom.<>f__mg$cache315 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ExpressionParseController.reg);
			}
			array[num790] = BindCustom.<>f__mg$cache315;
			int num791 = 790;
			if (BindCustom.<>f__mg$cache316 == null)
			{
				BindCustom.<>f__mg$cache316 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ExpressionParseController_PosStringTuple.reg);
			}
			array[num791] = BindCustom.<>f__mg$cache316;
			int num792 = 791;
			if (BindCustom.<>f__mg$cache317 == null)
			{
				BindCustom.<>f__mg$cache317 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_VoiceRecordButtonListerner.reg);
			}
			array[num792] = BindCustom.<>f__mg$cache317;
			int num793 = 792;
			if (BindCustom.<>f__mg$cache318 == null)
			{
				BindCustom.<>f__mg$cache318 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_VoiceRecordUIController.reg);
			}
			array[num793] = BindCustom.<>f__mg$cache318;
			int num794 = 793;
			if (BindCustom.<>f__mg$cache319 == null)
			{
				BindCustom.<>f__mg$cache319 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_VoiceRecordUITask.reg);
			}
			array[num794] = BindCustom.<>f__mg$cache319;
			int num795 = 794;
			if (BindCustom.<>f__mg$cache31A == null)
			{
				BindCustom.<>f__mg$cache31A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUIController.reg);
			}
			array[num795] = BindCustom.<>f__mg$cache31A;
			int num796 = 795;
			if (BindCustom.<>f__mg$cache31B == null)
			{
				BindCustom.<>f__mg$cache31B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelInfoUITask.reg);
			}
			array[num796] = BindCustom.<>f__mg$cache31B;
			int num797 = 796;
			if (BindCustom.<>f__mg$cache31C == null)
			{
				BindCustom.<>f__mg$cache31C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerGetNetTask.reg);
			}
			array[num797] = BindCustom.<>f__mg$cache31C;
			int num798 = 797;
			if (BindCustom.<>f__mg$cache31D == null)
			{
				BindCustom.<>f__mg$cache31D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelAttackNetTask.reg);
			}
			array[num798] = BindCustom.<>f__mg$cache31D;
			int num799 = 798;
			if (BindCustom.<>f__mg$cache31E == null)
			{
				BindCustom.<>f__mg$cache31E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelBattleFinishedNetTask.reg);
			}
			array[num799] = BindCustom.<>f__mg$cache31E;
			int num800 = 799;
			if (BindCustom.<>f__mg$cache31F == null)
			{
				BindCustom.<>f__mg$cache31F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidNetTask.reg);
			}
			array[num800] = BindCustom.<>f__mg$cache31F;
			int num801 = 800;
			if (BindCustom.<>f__mg$cache320 == null)
			{
				BindCustom.<>f__mg$cache320 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUIController.reg);
			}
			array[num801] = BindCustom.<>f__mg$cache320;
			int num802 = 801;
			if (BindCustom.<>f__mg$cache321 == null)
			{
				BindCustom.<>f__mg$cache321 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerRaidUITask.reg);
			}
			array[num802] = BindCustom.<>f__mg$cache321;
			int num803 = 802;
			if (BindCustom.<>f__mg$cache322 == null)
			{
				BindCustom.<>f__mg$cache322 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerUIController.reg);
			}
			array[num803] = BindCustom.<>f__mg$cache322;
			int num804 = 803;
			if (BindCustom.<>f__mg$cache323 == null)
			{
				BindCustom.<>f__mg$cache323 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerFloorItemUIController.reg);
			}
			array[num804] = BindCustom.<>f__mg$cache323;
			int num805 = 804;
			if (BindCustom.<>f__mg$cache324 == null)
			{
				BindCustom.<>f__mg$cache324 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerRewardListItemUIController.reg);
			}
			array[num805] = BindCustom.<>f__mg$cache324;
			int num806 = 805;
			if (BindCustom.<>f__mg$cache325 == null)
			{
				BindCustom.<>f__mg$cache325 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ClimbTowerUITask.reg);
			}
			array[num806] = BindCustom.<>f__mg$cache325;
			int num807 = 806;
			if (BindCustom.<>f__mg$cache326 == null)
			{
				BindCustom.<>f__mg$cache326 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChestUIController.reg);
			}
			array[num807] = BindCustom.<>f__mg$cache326;
			int num808 = 807;
			if (BindCustom.<>f__mg$cache327 == null)
			{
				BindCustom.<>f__mg$cache327 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChestUITask.reg);
			}
			array[num808] = BindCustom.<>f__mg$cache327;
			int num809 = 808;
			if (BindCustom.<>f__mg$cache328 == null)
			{
				BindCustom.<>f__mg$cache328 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CommonUIController.reg);
			}
			array[num809] = BindCustom.<>f__mg$cache328;
			int num810 = 809;
			if (BindCustom.<>f__mg$cache329 == null)
			{
				BindCustom.<>f__mg$cache329 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CommonUITask.reg);
			}
			array[num810] = BindCustom.<>f__mg$cache329;
			int num811 = 810;
			if (BindCustom.<>f__mg$cache32A == null)
			{
				BindCustom.<>f__mg$cache32A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GetPathUIController.reg);
			}
			array[num811] = BindCustom.<>f__mg$cache32A;
			int num812 = 811;
			if (BindCustom.<>f__mg$cache32B == null)
			{
				BindCustom.<>f__mg$cache32B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GetPathItemUIController.reg);
			}
			array[num812] = BindCustom.<>f__mg$cache32B;
			int num813 = 812;
			if (BindCustom.<>f__mg$cache32C == null)
			{
				BindCustom.<>f__mg$cache32C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GetPathUITask.reg);
			}
			array[num813] = BindCustom.<>f__mg$cache32C;
			int num814 = 813;
			if (BindCustom.<>f__mg$cache32D == null)
			{
				BindCustom.<>f__mg$cache32D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUIController.reg);
			}
			array[num814] = BindCustom.<>f__mg$cache32D;
			int num815 = 814;
			if (BindCustom.<>f__mg$cache32E == null)
			{
				BindCustom.<>f__mg$cache32E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GetRewardGoodsUITask.reg);
			}
			array[num815] = BindCustom.<>f__mg$cache32E;
			int num816 = 815;
			if (BindCustom.<>f__mg$cache32F == null)
			{
				BindCustom.<>f__mg$cache32F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_InstructionUIController.reg);
			}
			array[num816] = BindCustom.<>f__mg$cache32F;
			int num817 = 816;
			if (BindCustom.<>f__mg$cache330 == null)
			{
				BindCustom.<>f__mg$cache330 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_InstructionUITask.reg);
			}
			array[num817] = BindCustom.<>f__mg$cache330;
			int num818 = 817;
			if (BindCustom.<>f__mg$cache331 == null)
			{
				BindCustom.<>f__mg$cache331 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_InviteNotifyUIController.reg);
			}
			array[num818] = BindCustom.<>f__mg$cache331;
			int num819 = 818;
			if (BindCustom.<>f__mg$cache332 == null)
			{
				BindCustom.<>f__mg$cache332 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_InviteNotifyUITask.reg);
			}
			array[num819] = BindCustom.<>f__mg$cache332;
			int num820 = 819;
			if (BindCustom.<>f__mg$cache333 == null)
			{
				BindCustom.<>f__mg$cache333 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LongPressComponent.reg);
			}
			array[num820] = BindCustom.<>f__mg$cache333;
			int num821 = 820;
			if (BindCustom.<>f__mg$cache334 == null)
			{
				BindCustom.<>f__mg$cache334 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MonthCardInfoUIController.reg);
			}
			array[num821] = BindCustom.<>f__mg$cache334;
			int num822 = 821;
			if (BindCustom.<>f__mg$cache335 == null)
			{
				BindCustom.<>f__mg$cache335 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MonthCardInfoUITask.reg);
			}
			array[num822] = BindCustom.<>f__mg$cache335;
			int num823 = 822;
			if (BindCustom.<>f__mg$cache336 == null)
			{
				BindCustom.<>f__mg$cache336 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.reg);
			}
			array[num823] = BindCustom.<>f__mg$cache336;
			int num824 = 823;
			if (BindCustom.<>f__mg$cache337 == null)
			{
				BindCustom.<>f__mg$cache337 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUITask.reg);
			}
			array[num824] = BindCustom.<>f__mg$cache337;
			int num825 = 824;
			if (BindCustom.<>f__mg$cache338 == null)
			{
				BindCustom.<>f__mg$cache338 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.reg);
			}
			array[num825] = BindCustom.<>f__mg$cache338;
			int num826 = 825;
			if (BindCustom.<>f__mg$cache339 == null)
			{
				BindCustom.<>f__mg$cache339 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.reg);
			}
			array[num826] = BindCustom.<>f__mg$cache339;
			int num827 = 826;
			if (BindCustom.<>f__mg$cache33A == null)
			{
				BindCustom.<>f__mg$cache33A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerSettingUITask.reg);
			}
			array[num827] = BindCustom.<>f__mg$cache33A;
			int num828 = 827;
			if (BindCustom.<>f__mg$cache33B == null)
			{
				BindCustom.<>f__mg$cache33B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUIController.reg);
			}
			array[num828] = BindCustom.<>f__mg$cache33B;
			int num829 = 828;
			if (BindCustom.<>f__mg$cache33C == null)
			{
				BindCustom.<>f__mg$cache33C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerSimpleInfoUITask.reg);
			}
			array[num829] = BindCustom.<>f__mg$cache33C;
			int num830 = 829;
			if (BindCustom.<>f__mg$cache33D == null)
			{
				BindCustom.<>f__mg$cache33D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PointDescComponent.reg);
			}
			array[num830] = BindCustom.<>f__mg$cache33D;
			int num831 = 830;
			if (BindCustom.<>f__mg$cache33E == null)
			{
				BindCustom.<>f__mg$cache33E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PointerPopup.reg);
			}
			array[num831] = BindCustom.<>f__mg$cache33E;
			int num832 = 831;
			if (BindCustom.<>f__mg$cache33F == null)
			{
				BindCustom.<>f__mg$cache33F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUIController.reg);
			}
			array[num832] = BindCustom.<>f__mg$cache33F;
			int num833 = 832;
			if (BindCustom.<>f__mg$cache340 == null)
			{
				BindCustom.<>f__mg$cache340 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RewardGoodsDescUITask.reg);
			}
			array[num833] = BindCustom.<>f__mg$cache340;
			int num834 = 833;
			if (BindCustom.<>f__mg$cache341 == null)
			{
				BindCustom.<>f__mg$cache341 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.reg);
			}
			array[num834] = BindCustom.<>f__mg$cache341;
			int num835 = 834;
			if (BindCustom.<>f__mg$cache342 == null)
			{
				BindCustom.<>f__mg$cache342 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ScreenFade.reg);
			}
			array[num835] = BindCustom.<>f__mg$cache342;
			int num836 = 835;
			if (BindCustom.<>f__mg$cache343 == null)
			{
				BindCustom.<>f__mg$cache343 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.reg);
			}
			array[num836] = BindCustom.<>f__mg$cache343;
			int num837 = 836;
			if (BindCustom.<>f__mg$cache344 == null)
			{
				BindCustom.<>f__mg$cache344 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ScrollItemBaseUIController.reg);
			}
			array[num837] = BindCustom.<>f__mg$cache344;
			int num838 = 837;
			if (BindCustom.<>f__mg$cache345 == null)
			{
				BindCustom.<>f__mg$cache345 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.reg);
			}
			array[num838] = BindCustom.<>f__mg$cache345;
			int num839 = 838;
			if (BindCustom.<>f__mg$cache346 == null)
			{
				BindCustom.<>f__mg$cache346 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SkillDescUIController.reg);
			}
			array[num839] = BindCustom.<>f__mg$cache346;
			int num840 = 839;
			if (BindCustom.<>f__mg$cache347 == null)
			{
				BindCustom.<>f__mg$cache347 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.reg);
			}
			array[num840] = BindCustom.<>f__mg$cache347;
			int num841 = 840;
			if (BindCustom.<>f__mg$cache348 == null)
			{
				BindCustom.<>f__mg$cache348 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TouchFx.reg);
			}
			array[num841] = BindCustom.<>f__mg$cache348;
			int num842 = 841;
			if (BindCustom.<>f__mg$cache349 == null)
			{
				BindCustom.<>f__mg$cache349 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUIController.reg);
			}
			array[num842] = BindCustom.<>f__mg$cache349;
			int num843 = 842;
			if (BindCustom.<>f__mg$cache34A == null)
			{
				BindCustom.<>f__mg$cache34A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WaitPVPInviteUITask.reg);
			}
			array[num843] = BindCustom.<>f__mg$cache34A;
			int num844 = 843;
			if (BindCustom.<>f__mg$cache34B == null)
			{
				BindCustom.<>f__mg$cache34B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ControllerDescriptionAttribute.reg);
			}
			array[num844] = BindCustom.<>f__mg$cache34B;
			int num845 = 844;
			if (BindCustom.<>f__mg$cache34C == null)
			{
				BindCustom.<>f__mg$cache34C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CooperateBattleUIController.reg);
			}
			array[num845] = BindCustom.<>f__mg$cache34C;
			int num846 = 845;
			if (BindCustom.<>f__mg$cache34D == null)
			{
				BindCustom.<>f__mg$cache34D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CooperateBattleLevelListItemUIController.reg);
			}
			array[num846] = BindCustom.<>f__mg$cache34D;
			int num847 = 846;
			if (BindCustom.<>f__mg$cache34E == null)
			{
				BindCustom.<>f__mg$cache34E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CooperateBattleUITask.reg);
			}
			array[num847] = BindCustom.<>f__mg$cache34E;
			int num848 = 847;
			if (BindCustom.<>f__mg$cache34F == null)
			{
				BindCustom.<>f__mg$cache34F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DialogCharUIController.reg);
			}
			array[num848] = BindCustom.<>f__mg$cache34F;
			int num849 = 848;
			if (BindCustom.<>f__mg$cache350 == null)
			{
				BindCustom.<>f__mg$cache350 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DialogUIController.reg);
			}
			array[num849] = BindCustom.<>f__mg$cache350;
			int num850 = 849;
			if (BindCustom.<>f__mg$cache351 == null)
			{
				BindCustom.<>f__mg$cache351 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DialogBoxUIController.reg);
			}
			array[num850] = BindCustom.<>f__mg$cache351;
			int num851 = 850;
			if (BindCustom.<>f__mg$cache352 == null)
			{
				BindCustom.<>f__mg$cache352 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DialogUITask.reg);
			}
			array[num851] = BindCustom.<>f__mg$cache352;
			int num852 = 851;
			if (BindCustom.<>f__mg$cache353 == null)
			{
				BindCustom.<>f__mg$cache353 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroAssistantAssignToTaskNetTask.reg);
			}
			array[num852] = BindCustom.<>f__mg$cache353;
			int num853 = 852;
			if (BindCustom.<>f__mg$cache354 == null)
			{
				BindCustom.<>f__mg$cache354 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroAssistantCancelTaskNetTask.reg);
			}
			array[num853] = BindCustom.<>f__mg$cache354;
			int num854 = 853;
			if (BindCustom.<>f__mg$cache355 == null)
			{
				BindCustom.<>f__mg$cache355 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroAssistantClaimRewardNetTask.reg);
			}
			array[num854] = BindCustom.<>f__mg$cache355;
			int num855 = 854;
			if (BindCustom.<>f__mg$cache356 == null)
			{
				BindCustom.<>f__mg$cache356 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TechLevelupNetTask.reg);
			}
			array[num855] = BindCustom.<>f__mg$cache356;
			int num856 = 855;
			if (BindCustom.<>f__mg$cache357 == null)
			{
				BindCustom.<>f__mg$cache357 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DrillSoldierManualUIController.reg);
			}
			array[num856] = BindCustom.<>f__mg$cache357;
			int num857 = 856;
			if (BindCustom.<>f__mg$cache358 == null)
			{
				BindCustom.<>f__mg$cache358 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SoldierManualItemUIController.reg);
			}
			array[num857] = BindCustom.<>f__mg$cache358;
			int num858 = 857;
			if (BindCustom.<>f__mg$cache359 == null)
			{
				BindCustom.<>f__mg$cache359 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DrillTrainingUIController.reg);
			}
			array[num858] = BindCustom.<>f__mg$cache359;
			int num859 = 858;
			if (BindCustom.<>f__mg$cache35A == null)
			{
				BindCustom.<>f__mg$cache35A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TrainingSkillItemUIController.reg);
			}
			array[num859] = BindCustom.<>f__mg$cache35A;
			int num860 = 859;
			if (BindCustom.<>f__mg$cache35B == null)
			{
				BindCustom.<>f__mg$cache35B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TrainingSkillEvolutionMaterialUIController.reg);
			}
			array[num860] = BindCustom.<>f__mg$cache35B;
			int num861 = 860;
			if (BindCustom.<>f__mg$cache35C == null)
			{
				BindCustom.<>f__mg$cache35C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DrillTutorUIController.reg);
			}
			array[num861] = BindCustom.<>f__mg$cache35C;
			int num862 = 861;
			if (BindCustom.<>f__mg$cache35D == null)
			{
				BindCustom.<>f__mg$cache35D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.reg);
			}
			array[num862] = BindCustom.<>f__mg$cache35D;
			int num863 = 862;
			if (BindCustom.<>f__mg$cache35E == null)
			{
				BindCustom.<>f__mg$cache35E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.reg);
			}
			array[num863] = BindCustom.<>f__mg$cache35E;
			int num864 = 863;
			if (BindCustom.<>f__mg$cache35F == null)
			{
				BindCustom.<>f__mg$cache35F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DrillUIController.reg);
			}
			array[num864] = BindCustom.<>f__mg$cache35F;
			int num865 = 864;
			if (BindCustom.<>f__mg$cache360 == null)
			{
				BindCustom.<>f__mg$cache360 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DrillRoomToggleUIController.reg);
			}
			array[num865] = BindCustom.<>f__mg$cache360;
			int num866 = 865;
			if (BindCustom.<>f__mg$cache361 == null)
			{
				BindCustom.<>f__mg$cache361 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CourseItemUIController.reg);
			}
			array[num866] = BindCustom.<>f__mg$cache361;
			int num867 = 866;
			if (BindCustom.<>f__mg$cache362 == null)
			{
				BindCustom.<>f__mg$cache362 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AssistanceTeamUIController.reg);
			}
			array[num867] = BindCustom.<>f__mg$cache362;
			int num868 = 867;
			if (BindCustom.<>f__mg$cache363 == null)
			{
				BindCustom.<>f__mg$cache363 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_DrillUITask.reg);
			}
			array[num868] = BindCustom.<>f__mg$cache363;
			int num869 = 868;
			if (BindCustom.<>f__mg$cache364 == null)
			{
				BindCustom.<>f__mg$cache364 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersConfessionUIController.reg);
			}
			array[num869] = BindCustom.<>f__mg$cache364;
			int num870 = 869;
			if (BindCustom.<>f__mg$cache365 == null)
			{
				BindCustom.<>f__mg$cache365 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.reg);
			}
			array[num870] = BindCustom.<>f__mg$cache365;
			int num871 = 870;
			if (BindCustom.<>f__mg$cache366 == null)
			{
				BindCustom.<>f__mg$cache366 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersConfessionEvolutionMaterialUIController.reg);
			}
			array[num871] = BindCustom.<>f__mg$cache366;
			int num872 = 871;
			if (BindCustom.<>f__mg$cache367 == null)
			{
				BindCustom.<>f__mg$cache367 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersConfessionUnlockConditionUIController.reg);
			}
			array[num872] = BindCustom.<>f__mg$cache367;
			int num873 = 872;
			if (BindCustom.<>f__mg$cache368 == null)
			{
				BindCustom.<>f__mg$cache368 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersFavorabilityUIController.reg);
			}
			array[num873] = BindCustom.<>f__mg$cache368;
			int num874 = 873;
			if (BindCustom.<>f__mg$cache369 == null)
			{
				BindCustom.<>f__mg$cache369 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_OnDragTrigger.reg);
			}
			array[num874] = BindCustom.<>f__mg$cache369;
			int num875 = 874;
			if (BindCustom.<>f__mg$cache36A == null)
			{
				BindCustom.<>f__mg$cache36A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.reg);
			}
			array[num875] = BindCustom.<>f__mg$cache36A;
			int num876 = 875;
			if (BindCustom.<>f__mg$cache36B == null)
			{
				BindCustom.<>f__mg$cache36B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.reg);
			}
			array[num876] = BindCustom.<>f__mg$cache36B;
			int num877 = 876;
			if (BindCustom.<>f__mg$cache36C == null)
			{
				BindCustom.<>f__mg$cache36C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersInformationLifeItemUIController.reg);
			}
			array[num877] = BindCustom.<>f__mg$cache36C;
			int num878 = 877;
			if (BindCustom.<>f__mg$cache36D == null)
			{
				BindCustom.<>f__mg$cache36D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.reg);
			}
			array[num878] = BindCustom.<>f__mg$cache36D;
			int num879 = 878;
			if (BindCustom.<>f__mg$cache36E == null)
			{
				BindCustom.<>f__mg$cache36E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroFavorabilityExpAddNetTask.reg);
			}
			array[num879] = BindCustom.<>f__mg$cache36E;
			int num880 = 879;
			if (BindCustom.<>f__mg$cache36F == null)
			{
				BindCustom.<>f__mg$cache36F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.reg);
			}
			array[num880] = BindCustom.<>f__mg$cache36F;
			int num881 = 880;
			if (BindCustom.<>f__mg$cache370 == null)
			{
				BindCustom.<>f__mg$cache370 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FetterSkillUnlockNetTask.reg);
			}
			array[num881] = BindCustom.<>f__mg$cache370;
			int num882 = 881;
			if (BindCustom.<>f__mg$cache371 == null)
			{
				BindCustom.<>f__mg$cache371 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroFetterLevelUpNetTask.reg);
			}
			array[num882] = BindCustom.<>f__mg$cache371;
			int num883 = 882;
			if (BindCustom.<>f__mg$cache372 == null)
			{
				BindCustom.<>f__mg$cache372 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroConfessNetTask.reg);
			}
			array[num883] = BindCustom.<>f__mg$cache372;
			int num884 = 883;
			if (BindCustom.<>f__mg$cache373 == null)
			{
				BindCustom.<>f__mg$cache373 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersUIController.reg);
			}
			array[num884] = BindCustom.<>f__mg$cache373;
			int num885 = 884;
			if (BindCustom.<>f__mg$cache374 == null)
			{
				BindCustom.<>f__mg$cache374 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersHeroListItemUIController.reg);
			}
			array[num885] = BindCustom.<>f__mg$cache374;
			int num886 = 885;
			if (BindCustom.<>f__mg$cache375 == null)
			{
				BindCustom.<>f__mg$cache375 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FettersUITask.reg);
			}
			array[num886] = BindCustom.<>f__mg$cache375;
			int num887 = 886;
			if (BindCustom.<>f__mg$cache376 == null)
			{
				BindCustom.<>f__mg$cache376 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GetFriendSocialRelationNetTask.reg);
			}
			array[num887] = BindCustom.<>f__mg$cache376;
			int num888 = 887;
			if (BindCustom.<>f__mg$cache377 == null)
			{
				BindCustom.<>f__mg$cache377 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendAddNetTask.reg);
			}
			array[num888] = BindCustom.<>f__mg$cache377;
			int num889 = 888;
			if (BindCustom.<>f__mg$cache378 == null)
			{
				BindCustom.<>f__mg$cache378 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendInviteAcceptNetTask.reg);
			}
			array[num889] = BindCustom.<>f__mg$cache378;
			int num890 = 889;
			if (BindCustom.<>f__mg$cache379 == null)
			{
				BindCustom.<>f__mg$cache379 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendInviteDeclineNetTask.reg);
			}
			array[num890] = BindCustom.<>f__mg$cache379;
			int num891 = 890;
			if (BindCustom.<>f__mg$cache37A == null)
			{
				BindCustom.<>f__mg$cache37A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendDeleteNetTask.reg);
			}
			array[num891] = BindCustom.<>f__mg$cache37A;
			int num892 = 891;
			if (BindCustom.<>f__mg$cache37B == null)
			{
				BindCustom.<>f__mg$cache37B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerBlockNetTask.reg);
			}
			array[num892] = BindCustom.<>f__mg$cache37B;
			int num893 = 892;
			if (BindCustom.<>f__mg$cache37C == null)
			{
				BindCustom.<>f__mg$cache37C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerUnblockNetTask.reg);
			}
			array[num893] = BindCustom.<>f__mg$cache37C;
			int num894 = 893;
			if (BindCustom.<>f__mg$cache37D == null)
			{
				BindCustom.<>f__mg$cache37D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendFindNetTask.reg);
			}
			array[num894] = BindCustom.<>f__mg$cache37D;
			int num895 = 894;
			if (BindCustom.<>f__mg$cache37E == null)
			{
				BindCustom.<>f__mg$cache37E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendSuggestedNetTask.reg);
			}
			array[num895] = BindCustom.<>f__mg$cache37E;
			int num896 = 895;
			if (BindCustom.<>f__mg$cache37F == null)
			{
				BindCustom.<>f__mg$cache37F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendGroupChangeOwnerNetTask.reg);
			}
			array[num896] = BindCustom.<>f__mg$cache37F;
			int num897 = 896;
			if (BindCustom.<>f__mg$cache380 == null)
			{
				BindCustom.<>f__mg$cache380 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendGroupChangeNameNetTask.reg);
			}
			array[num897] = BindCustom.<>f__mg$cache380;
			int num898 = 897;
			if (BindCustom.<>f__mg$cache381 == null)
			{
				BindCustom.<>f__mg$cache381 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendGroupCreateNetTask.reg);
			}
			array[num898] = BindCustom.<>f__mg$cache381;
			int num899 = 898;
			if (BindCustom.<>f__mg$cache382 == null)
			{
				BindCustom.<>f__mg$cache382 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendGroupMemberGetNetTask.reg);
			}
			array[num899] = BindCustom.<>f__mg$cache382;
			int num900 = 899;
			if (BindCustom.<>f__mg$cache383 == null)
			{
				BindCustom.<>f__mg$cache383 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendGroupAllGetNetTask.reg);
			}
			array[num900] = BindCustom.<>f__mg$cache383;
			int num901 = 900;
			if (BindCustom.<>f__mg$cache384 == null)
			{
				BindCustom.<>f__mg$cache384 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendInviteToGroupGetNetTask.reg);
			}
			array[num901] = BindCustom.<>f__mg$cache384;
			int num902 = 901;
			if (BindCustom.<>f__mg$cache385 == null)
			{
				BindCustom.<>f__mg$cache385 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendLeaveChatGroupNetTask.reg);
			}
			array[num902] = BindCustom.<>f__mg$cache385;
			int num903 = 902;
			if (BindCustom.<>f__mg$cache386 == null)
			{
				BindCustom.<>f__mg$cache386 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendKickChatGroupNetTask.reg);
			}
			array[num903] = BindCustom.<>f__mg$cache386;
			int num904 = 903;
			if (BindCustom.<>f__mg$cache387 == null)
			{
				BindCustom.<>f__mg$cache387 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendShipPointsSendNetTask.reg);
			}
			array[num904] = BindCustom.<>f__mg$cache387;
			int num905 = 904;
			if (BindCustom.<>f__mg$cache388 == null)
			{
				BindCustom.<>f__mg$cache388 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendShipPointsClaimNetTask.reg);
			}
			array[num905] = BindCustom.<>f__mg$cache388;
			int num906 = 905;
			if (BindCustom.<>f__mg$cache389 == null)
			{
				BindCustom.<>f__mg$cache389 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattlePracticeInviteNetTask.reg);
			}
			array[num906] = BindCustom.<>f__mg$cache389;
			int num907 = 906;
			if (BindCustom.<>f__mg$cache38A == null)
			{
				BindCustom.<>f__mg$cache38A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattlePracticeAcceptNetTask.reg);
			}
			array[num907] = BindCustom.<>f__mg$cache38A;
			int num908 = 907;
			if (BindCustom.<>f__mg$cache38B == null)
			{
				BindCustom.<>f__mg$cache38B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattlePracticeDeclineNetTask.reg);
			}
			array[num908] = BindCustom.<>f__mg$cache38B;
			int num909 = 908;
			if (BindCustom.<>f__mg$cache38C == null)
			{
				BindCustom.<>f__mg$cache38C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattlePracticeCancelNetTask.reg);
			}
			array[num909] = BindCustom.<>f__mg$cache38C;
			int num910 = 909;
			if (BindCustom.<>f__mg$cache38D == null)
			{
				BindCustom.<>f__mg$cache38D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendUIController.reg);
			}
			array[num910] = BindCustom.<>f__mg$cache38D;
			int num911 = 910;
			if (BindCustom.<>f__mg$cache38E == null)
			{
				BindCustom.<>f__mg$cache38E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendBigItemUIController.reg);
			}
			array[num911] = BindCustom.<>f__mg$cache38E;
			int num912 = 911;
			if (BindCustom.<>f__mg$cache38F == null)
			{
				BindCustom.<>f__mg$cache38F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.reg);
			}
			array[num912] = BindCustom.<>f__mg$cache38F;
			int num913 = 912;
			if (BindCustom.<>f__mg$cache390 == null)
			{
				BindCustom.<>f__mg$cache390 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.reg);
			}
			array[num913] = BindCustom.<>f__mg$cache390;
			int num914 = 913;
			if (BindCustom.<>f__mg$cache391 == null)
			{
				BindCustom.<>f__mg$cache391 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FriendUITask.reg);
			}
			array[num914] = BindCustom.<>f__mg$cache391;
			int num915 = 914;
			if (BindCustom.<>f__mg$cache392 == null)
			{
				BindCustom.<>f__mg$cache392 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SetProtagonistNetTask.reg);
			}
			array[num915] = BindCustom.<>f__mg$cache392;
			int num916 = 915;
			if (BindCustom.<>f__mg$cache393 == null)
			{
				BindCustom.<>f__mg$cache393 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GoddessDialogUIController.reg);
			}
			array[num916] = BindCustom.<>f__mg$cache393;
			int num917 = 916;
			if (BindCustom.<>f__mg$cache394 == null)
			{
				BindCustom.<>f__mg$cache394 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GoddessDialogBoxUIController.reg);
			}
			array[num917] = BindCustom.<>f__mg$cache394;
			int num918 = 917;
			if (BindCustom.<>f__mg$cache395 == null)
			{
				BindCustom.<>f__mg$cache395 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GoddessDialogChoiceButton.reg);
			}
			array[num918] = BindCustom.<>f__mg$cache395;
			int num919 = 918;
			if (BindCustom.<>f__mg$cache396 == null)
			{
				BindCustom.<>f__mg$cache396 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.reg);
			}
			array[num919] = BindCustom.<>f__mg$cache396;
			int num920 = 919;
			if (BindCustom.<>f__mg$cache397 == null)
			{
				BindCustom.<>f__mg$cache397 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask.reg);
			}
			array[num920] = BindCustom.<>f__mg$cache397;
			int num921 = 920;
			if (BindCustom.<>f__mg$cache398 == null)
			{
				BindCustom.<>f__mg$cache398 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GoddessDialogUITask_JobChoiceValue.reg);
			}
			array[num921] = BindCustom.<>f__mg$cache398;
			int num922 = 921;
			if (BindCustom.<>f__mg$cache399 == null)
			{
				BindCustom.<>f__mg$cache399 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildInfoUIController.reg);
			}
			array[num922] = BindCustom.<>f__mg$cache399;
			int num923 = 922;
			if (BindCustom.<>f__mg$cache39A == null)
			{
				BindCustom.<>f__mg$cache39A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildListUIController.reg);
			}
			array[num923] = BindCustom.<>f__mg$cache39A;
			int num924 = 923;
			if (BindCustom.<>f__mg$cache39B == null)
			{
				BindCustom.<>f__mg$cache39B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BeforeJoinSingleGuildUIController.reg);
			}
			array[num924] = BindCustom.<>f__mg$cache39B;
			int num925 = 924;
			if (BindCustom.<>f__mg$cache39C == null)
			{
				BindCustom.<>f__mg$cache39C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildMsgUIController.reg);
			}
			array[num925] = BindCustom.<>f__mg$cache39C;
			int num926 = 925;
			if (BindCustom.<>f__mg$cache39D == null)
			{
				BindCustom.<>f__mg$cache39D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildInviteItemUIController.reg);
			}
			array[num926] = BindCustom.<>f__mg$cache39D;
			int num927 = 926;
			if (BindCustom.<>f__mg$cache39E == null)
			{
				BindCustom.<>f__mg$cache39E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BeforeJoinGuildUIController.reg);
			}
			array[num927] = BindCustom.<>f__mg$cache39E;
			int num928 = 927;
			if (BindCustom.<>f__mg$cache39F == null)
			{
				BindCustom.<>f__mg$cache39F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CreateGuildUIController.reg);
			}
			array[num928] = BindCustom.<>f__mg$cache39F;
			int num929 = 928;
			if (BindCustom.<>f__mg$cache3A0 == null)
			{
				BindCustom.<>f__mg$cache3A0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildGameListUIController.reg);
			}
			array[num929] = BindCustom.<>f__mg$cache3A0;
			int num930 = 929;
			if (BindCustom.<>f__mg$cache3A1 == null)
			{
				BindCustom.<>f__mg$cache3A1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildGameListItemUIController.reg);
			}
			array[num930] = BindCustom.<>f__mg$cache3A1;
			int num931 = 930;
			if (BindCustom.<>f__mg$cache3A2 == null)
			{
				BindCustom.<>f__mg$cache3A2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildGameListUITask.reg);
			}
			array[num931] = BindCustom.<>f__mg$cache3A2;
			int num932 = 931;
			if (BindCustom.<>f__mg$cache3A3 == null)
			{
				BindCustom.<>f__mg$cache3A3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildJoinInvitation.reg);
			}
			array[num932] = BindCustom.<>f__mg$cache3A3;
			int num933 = 932;
			if (BindCustom.<>f__mg$cache3A4 == null)
			{
				BindCustom.<>f__mg$cache3A4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildListUIController.reg);
			}
			array[num933] = BindCustom.<>f__mg$cache3A4;
			int num934 = 933;
			if (BindCustom.<>f__mg$cache3A5 == null)
			{
				BindCustom.<>f__mg$cache3A5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildManagementUIController.reg);
			}
			array[num934] = BindCustom.<>f__mg$cache3A5;
			int num935 = 934;
			if (BindCustom.<>f__mg$cache3A6 == null)
			{
				BindCustom.<>f__mg$cache3A6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildMemberInfoItemUIController.reg);
			}
			array[num935] = BindCustom.<>f__mg$cache3A6;
			int num936 = 935;
			if (BindCustom.<>f__mg$cache3A7 == null)
			{
				BindCustom.<>f__mg$cache3A7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.reg);
			}
			array[num936] = BindCustom.<>f__mg$cache3A7;
			int num937 = 936;
			if (BindCustom.<>f__mg$cache3A8 == null)
			{
				BindCustom.<>f__mg$cache3A8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildJournalItemUIController.reg);
			}
			array[num937] = BindCustom.<>f__mg$cache3A8;
			int num938 = 937;
			if (BindCustom.<>f__mg$cache3A9 == null)
			{
				BindCustom.<>f__mg$cache3A9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildInviteMemberInfoItemUIController.reg);
			}
			array[num938] = BindCustom.<>f__mg$cache3A9;
			int num939 = 938;
			if (BindCustom.<>f__mg$cache3AA == null)
			{
				BindCustom.<>f__mg$cache3AA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildManagementUITask.reg);
			}
			array[num939] = BindCustom.<>f__mg$cache3AA;
			int num940 = 939;
			if (BindCustom.<>f__mg$cache3AB == null)
			{
				BindCustom.<>f__mg$cache3AB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUIController.reg);
			}
			array[num940] = BindCustom.<>f__mg$cache3AB;
			int num941 = 940;
			if (BindCustom.<>f__mg$cache3AC == null)
			{
				BindCustom.<>f__mg$cache3AC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStrongHoldUIController.reg);
			}
			array[num941] = BindCustom.<>f__mg$cache3AC;
			int num942 = 941;
			if (BindCustom.<>f__mg$cache3AD == null)
			{
				BindCustom.<>f__mg$cache3AD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatLastHeroUIController.reg);
			}
			array[num942] = BindCustom.<>f__mg$cache3AD;
			int num943 = 942;
			if (BindCustom.<>f__mg$cache3AE == null)
			{
				BindCustom.<>f__mg$cache3AE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatUITask.reg);
			}
			array[num943] = BindCustom.<>f__mg$cache3AE;
			int num944 = 943;
			if (BindCustom.<>f__mg$cache3AF == null)
			{
				BindCustom.<>f__mg$cache3AF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildCreateReqNetTask.reg);
			}
			array[num944] = BindCustom.<>f__mg$cache3AF;
			int num945 = 944;
			if (BindCustom.<>f__mg$cache3B0 == null)
			{
				BindCustom.<>f__mg$cache3B0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildJoinApplyReqNetTask.reg);
			}
			array[num945] = BindCustom.<>f__mg$cache3B0;
			int num946 = 945;
			if (BindCustom.<>f__mg$cache3B1 == null)
			{
				BindCustom.<>f__mg$cache3B1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildJoinAdminConfirmReqNetTask.reg);
			}
			array[num946] = BindCustom.<>f__mg$cache3B1;
			int num947 = 946;
			if (BindCustom.<>f__mg$cache3B2 == null)
			{
				BindCustom.<>f__mg$cache3B2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildJoinAdminRefuseReqNetTask.reg);
			}
			array[num947] = BindCustom.<>f__mg$cache3B2;
			int num948 = 947;
			if (BindCustom.<>f__mg$cache3B3 == null)
			{
				BindCustom.<>f__mg$cache3B3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildJoinPlayerConfirmReqNetTask.reg);
			}
			array[num948] = BindCustom.<>f__mg$cache3B3;
			int num949 = 948;
			if (BindCustom.<>f__mg$cache3B4 == null)
			{
				BindCustom.<>f__mg$cache3B4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildRandomListReqNetTask.reg);
			}
			array[num949] = BindCustom.<>f__mg$cache3B4;
			int num950 = 949;
			if (BindCustom.<>f__mg$cache3B5 == null)
			{
				BindCustom.<>f__mg$cache3B5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildSearchReqNetTask.reg);
			}
			array[num950] = BindCustom.<>f__mg$cache3B5;
			int num951 = 950;
			if (BindCustom.<>f__mg$cache3B6 == null)
			{
				BindCustom.<>f__mg$cache3B6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildQuitReqNetTask.reg);
			}
			array[num951] = BindCustom.<>f__mg$cache3B6;
			int num952 = 951;
			if (BindCustom.<>f__mg$cache3B7 == null)
			{
				BindCustom.<>f__mg$cache3B7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildInvitePlayerListReqNetTask.reg);
			}
			array[num952] = BindCustom.<>f__mg$cache3B7;
			int num953 = 952;
			if (BindCustom.<>f__mg$cache3B8 == null)
			{
				BindCustom.<>f__mg$cache3B8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildHiringDeclarationSetReqNetTask.reg);
			}
			array[num953] = BindCustom.<>f__mg$cache3B8;
			int num954 = 953;
			if (BindCustom.<>f__mg$cache3B9 == null)
			{
				BindCustom.<>f__mg$cache3B9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildJoinInvitationGetReqNetTask.reg);
			}
			array[num954] = BindCustom.<>f__mg$cache3B9;
			int num955 = 954;
			if (BindCustom.<>f__mg$cache3BA == null)
			{
				BindCustom.<>f__mg$cache3BA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildJoinInvitationRefuseReqNetTask.reg);
			}
			array[num955] = BindCustom.<>f__mg$cache3BA;
			int num956 = 955;
			if (BindCustom.<>f__mg$cache3BB == null)
			{
				BindCustom.<>f__mg$cache3BB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AllGuildJoinInvitationRefuseReqNetTask.reg);
			}
			array[num956] = BindCustom.<>f__mg$cache3BB;
			int num957 = 956;
			if (BindCustom.<>f__mg$cache3BC == null)
			{
				BindCustom.<>f__mg$cache3BC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildGetReqNetTask.reg);
			}
			array[num957] = BindCustom.<>f__mg$cache3BC;
			int num958 = 957;
			if (BindCustom.<>f__mg$cache3BD == null)
			{
				BindCustom.<>f__mg$cache3BD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.reg);
			}
			array[num958] = BindCustom.<>f__mg$cache3BD;
			int num959 = 958;
			if (BindCustom.<>f__mg$cache3BE == null)
			{
				BindCustom.<>f__mg$cache3BE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildAnnouncementSetReqNetTask.reg);
			}
			array[num959] = BindCustom.<>f__mg$cache3BE;
			int num960 = 959;
			if (BindCustom.<>f__mg$cache3BF == null)
			{
				BindCustom.<>f__mg$cache3BF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildJoinApplyGetReqNetTask.reg);
			}
			array[num960] = BindCustom.<>f__mg$cache3BF;
			int num961 = 960;
			if (BindCustom.<>f__mg$cache3C0 == null)
			{
				BindCustom.<>f__mg$cache3C0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildNameChangeReqNetTask.reg);
			}
			array[num961] = BindCustom.<>f__mg$cache3C0;
			int num962 = 961;
			if (BindCustom.<>f__mg$cache3C1 == null)
			{
				BindCustom.<>f__mg$cache3C1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildLogGetReqNetTask.reg);
			}
			array[num962] = BindCustom.<>f__mg$cache3C1;
			int num963 = 962;
			if (BindCustom.<>f__mg$cache3C2 == null)
			{
				BindCustom.<>f__mg$cache3C2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildJoinInviteReqNetTask.reg);
			}
			array[num963] = BindCustom.<>f__mg$cache3C2;
			int num964 = 963;
			if (BindCustom.<>f__mg$cache3C3 == null)
			{
				BindCustom.<>f__mg$cache3C3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildVicePresidentAppointReqNetTask.reg);
			}
			array[num964] = BindCustom.<>f__mg$cache3C3;
			int num965 = 964;
			if (BindCustom.<>f__mg$cache3C4 == null)
			{
				BindCustom.<>f__mg$cache3C4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildKickOutReqNetTask.reg);
			}
			array[num965] = BindCustom.<>f__mg$cache3C4;
			int num966 = 965;
			if (BindCustom.<>f__mg$cache3C5 == null)
			{
				BindCustom.<>f__mg$cache3C5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildPresidentRelieveReqNetTask.reg);
			}
			array[num966] = BindCustom.<>f__mg$cache3C5;
			int num967 = 966;
			if (BindCustom.<>f__mg$cache3C6 == null)
			{
				BindCustom.<>f__mg$cache3C6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildPresidentAppointReqNetTask.reg);
			}
			array[num967] = BindCustom.<>f__mg$cache3C6;
			int num968 = 967;
			if (BindCustom.<>f__mg$cache3C7 == null)
			{
				BindCustom.<>f__mg$cache3C7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AllGuildJoinApplyRefuseReqNetTask.reg);
			}
			array[num968] = BindCustom.<>f__mg$cache3C7;
			int num969 = 968;
			if (BindCustom.<>f__mg$cache3C8 == null)
			{
				BindCustom.<>f__mg$cache3C8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatAttackNetTask.reg);
			}
			array[num969] = BindCustom.<>f__mg$cache3C8;
			int num970 = 969;
			if (BindCustom.<>f__mg$cache3C9 == null)
			{
				BindCustom.<>f__mg$cache3C9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSinglePVEBattleEndNetTask.reg);
			}
			array[num970] = BindCustom.<>f__mg$cache3C9;
			int num971 = 970;
			if (BindCustom.<>f__mg$cache3CA == null)
			{
				BindCustom.<>f__mg$cache3CA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatStartNetTask.reg);
			}
			array[num971] = BindCustom.<>f__mg$cache3CA;
			int num972 = 971;
			if (BindCustom.<>f__mg$cache3CB == null)
			{
				BindCustom.<>f__mg$cache3CB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildMassiveCombatSurrenderNetTask.reg);
			}
			array[num972] = BindCustom.<>f__mg$cache3CB;
			int num973 = 972;
			if (BindCustom.<>f__mg$cache3CC == null)
			{
				BindCustom.<>f__mg$cache3CC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildRaidUIController.reg);
			}
			array[num973] = BindCustom.<>f__mg$cache3CC;
			int num974 = 973;
			if (BindCustom.<>f__mg$cache3CD == null)
			{
				BindCustom.<>f__mg$cache3CD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildRaidListItemUIController.reg);
			}
			array[num974] = BindCustom.<>f__mg$cache3CD;
			int num975 = 974;
			if (BindCustom.<>f__mg$cache3CE == null)
			{
				BindCustom.<>f__mg$cache3CE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildRaidUITask.reg);
			}
			array[num975] = BindCustom.<>f__mg$cache3CE;
			int num976 = 975;
			if (BindCustom.<>f__mg$cache3CF == null)
			{
				BindCustom.<>f__mg$cache3CF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GuildUITask.reg);
			}
			array[num976] = BindCustom.<>f__mg$cache3CF;
			int num977 = 976;
			if (BindCustom.<>f__mg$cache3D0 == null)
			{
				BindCustom.<>f__mg$cache3D0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentDepotUIController.reg);
			}
			array[num977] = BindCustom.<>f__mg$cache3D0;
			int num978 = 977;
			if (BindCustom.<>f__mg$cache3D1 == null)
			{
				BindCustom.<>f__mg$cache3D1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentDepotListItemUIController.reg);
			}
			array[num978] = BindCustom.<>f__mg$cache3D1;
			int num979 = 978;
			if (BindCustom.<>f__mg$cache3D2 == null)
			{
				BindCustom.<>f__mg$cache3D2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentSortItemUIController.reg);
			}
			array[num979] = BindCustom.<>f__mg$cache3D2;
			int num980 = 979;
			if (BindCustom.<>f__mg$cache3D3 == null)
			{
				BindCustom.<>f__mg$cache3D3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentDepotUITask.reg);
			}
			array[num980] = BindCustom.<>f__mg$cache3D3;
			int num981 = 980;
			if (BindCustom.<>f__mg$cache3D4 == null)
			{
				BindCustom.<>f__mg$cache3D4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentForgeUIController.reg);
			}
			array[num981] = BindCustom.<>f__mg$cache3D4;
			int num982 = 981;
			if (BindCustom.<>f__mg$cache3D5 == null)
			{
				BindCustom.<>f__mg$cache3D5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentBreakNeedItemUIController.reg);
			}
			array[num982] = BindCustom.<>f__mg$cache3D5;
			int num983 = 982;
			if (BindCustom.<>f__mg$cache3D6 == null)
			{
				BindCustom.<>f__mg$cache3D6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentForgeUITask.reg);
			}
			array[num983] = BindCustom.<>f__mg$cache3D6;
			int num984 = 983;
			if (BindCustom.<>f__mg$cache3D7 == null)
			{
				BindCustom.<>f__mg$cache3D7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.reg);
			}
			array[num984] = BindCustom.<>f__mg$cache3D7;
			int num985 = 984;
			if (BindCustom.<>f__mg$cache3D8 == null)
			{
				BindCustom.<>f__mg$cache3D8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUITask.reg);
			}
			array[num985] = BindCustom.<>f__mg$cache3D8;
			int num986 = 985;
			if (BindCustom.<>f__mg$cache3D9 == null)
			{
				BindCustom.<>f__mg$cache3D9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUIController.reg);
			}
			array[num986] = BindCustom.<>f__mg$cache3D9;
			int num987 = 986;
			if (BindCustom.<>f__mg$cache3DA == null)
			{
				BindCustom.<>f__mg$cache3DA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroBreakRarityUpUITask.reg);
			}
			array[num987] = BindCustom.<>f__mg$cache3DA;
			int num988 = 987;
			if (BindCustom.<>f__mg$cache3DB == null)
			{
				BindCustom.<>f__mg$cache3DB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroCharUIController.reg);
			}
			array[num988] = BindCustom.<>f__mg$cache3DB;
			int num989 = 988;
			if (BindCustom.<>f__mg$cache3DC == null)
			{
				BindCustom.<>f__mg$cache3DC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroCommentUIController.reg);
			}
			array[num989] = BindCustom.<>f__mg$cache3DC;
			int num990 = 989;
			if (BindCustom.<>f__mg$cache3DD == null)
			{
				BindCustom.<>f__mg$cache3DD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerHeroSkillUIController.reg);
			}
			array[num990] = BindCustom.<>f__mg$cache3DD;
			int num991 = 990;
			if (BindCustom.<>f__mg$cache3DE == null)
			{
				BindCustom.<>f__mg$cache3DE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.reg);
			}
			array[num991] = BindCustom.<>f__mg$cache3DE;
			int num992 = 991;
			if (BindCustom.<>f__mg$cache3DF == null)
			{
				BindCustom.<>f__mg$cache3DF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroCommentUITask.reg);
			}
			array[num992] = BindCustom.<>f__mg$cache3DF;
			int num993 = 992;
			if (BindCustom.<>f__mg$cache3E0 == null)
			{
				BindCustom.<>f__mg$cache3E0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDetailAddExpUIController.reg);
			}
			array[num993] = BindCustom.<>f__mg$cache3E0;
			int num994 = 993;
			if (BindCustom.<>f__mg$cache3E1 == null)
			{
				BindCustom.<>f__mg$cache3E1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroExpItemUIController.reg);
			}
			array[num994] = BindCustom.<>f__mg$cache3E1;
			int num995 = 994;
			if (BindCustom.<>f__mg$cache3E2 == null)
			{
				BindCustom.<>f__mg$cache3E2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDetailEquipmentUIController.reg);
			}
			array[num995] = BindCustom.<>f__mg$cache3E2;
			int num996 = 995;
			if (BindCustom.<>f__mg$cache3E3 == null)
			{
				BindCustom.<>f__mg$cache3E3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroEquipItemUIController.reg);
			}
			array[num996] = BindCustom.<>f__mg$cache3E3;
			int num997 = 996;
			if (BindCustom.<>f__mg$cache3E4 == null)
			{
				BindCustom.<>f__mg$cache3E4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.reg);
			}
			array[num997] = BindCustom.<>f__mg$cache3E4;
			int num998 = 997;
			if (BindCustom.<>f__mg$cache3E5 == null)
			{
				BindCustom.<>f__mg$cache3E5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.reg);
			}
			array[num998] = BindCustom.<>f__mg$cache3E5;
			int num999 = 998;
			if (BindCustom.<>f__mg$cache3E6 == null)
			{
				BindCustom.<>f__mg$cache3E6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.reg);
			}
			array[num999] = BindCustom.<>f__mg$cache3E6;
			int num1000 = 999;
			if (BindCustom.<>f__mg$cache3E7 == null)
			{
				BindCustom.<>f__mg$cache3E7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDetailJobUIController.reg);
			}
			array[num1000] = BindCustom.<>f__mg$cache3E7;
			int num1001 = 1000;
			if (BindCustom.<>f__mg$cache3E8 == null)
			{
				BindCustom.<>f__mg$cache3E8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.reg);
			}
			array[num1001] = BindCustom.<>f__mg$cache3E8;
			int num1002 = 1001;
			if (BindCustom.<>f__mg$cache3E9 == null)
			{
				BindCustom.<>f__mg$cache3E9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDetailLifeUIController.reg);
			}
			array[num1002] = BindCustom.<>f__mg$cache3E9;
			int num1003 = 1002;
			if (BindCustom.<>f__mg$cache3EA == null)
			{
				BindCustom.<>f__mg$cache3EA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDetailSelectSkillUIController.reg);
			}
			array[num1003] = BindCustom.<>f__mg$cache3EA;
			int num1004 = 1003;
			if (BindCustom.<>f__mg$cache3EB == null)
			{
				BindCustom.<>f__mg$cache3EB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDetailSoldierUIController.reg);
			}
			array[num1004] = BindCustom.<>f__mg$cache3EB;
			int num1005 = 1004;
			if (BindCustom.<>f__mg$cache3EC == null)
			{
				BindCustom.<>f__mg$cache3EC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SoldierItemUIController.reg);
			}
			array[num1005] = BindCustom.<>f__mg$cache3EC;
			int num1006 = 1005;
			if (BindCustom.<>f__mg$cache3ED == null)
			{
				BindCustom.<>f__mg$cache3ED = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.reg);
			}
			array[num1006] = BindCustom.<>f__mg$cache3ED;
			int num1007 = 1006;
			if (BindCustom.<>f__mg$cache3EE == null)
			{
				BindCustom.<>f__mg$cache3EE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroItemUIController.reg);
			}
			array[num1007] = BindCustom.<>f__mg$cache3EE;
			int num1008 = 1007;
			if (BindCustom.<>f__mg$cache3EF == null)
			{
				BindCustom.<>f__mg$cache3EF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.reg);
			}
			array[num1008] = BindCustom.<>f__mg$cache3EF;
			int num1009 = 1008;
			if (BindCustom.<>f__mg$cache3F0 == null)
			{
				BindCustom.<>f__mg$cache3F0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroJobTransferUIController.reg);
			}
			array[num1009] = BindCustom.<>f__mg$cache3F0;
			int num1010 = 1009;
			if (BindCustom.<>f__mg$cache3F1 == null)
			{
				BindCustom.<>f__mg$cache3F1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.reg);
			}
			array[num1010] = BindCustom.<>f__mg$cache3F1;
			int num1011 = 1010;
			if (BindCustom.<>f__mg$cache3F2 == null)
			{
				BindCustom.<>f__mg$cache3F2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroJobTransferSoldierItemUIController.reg);
			}
			array[num1011] = BindCustom.<>f__mg$cache3F2;
			int num1012 = 1011;
			if (BindCustom.<>f__mg$cache3F3 == null)
			{
				BindCustom.<>f__mg$cache3F3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroJobTransferConditionItemUIController.reg);
			}
			array[num1012] = BindCustom.<>f__mg$cache3F3;
			int num1013 = 1012;
			if (BindCustom.<>f__mg$cache3F4 == null)
			{
				BindCustom.<>f__mg$cache3F4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.reg);
			}
			array[num1013] = BindCustom.<>f__mg$cache3F4;
			int num1014 = 1013;
			if (BindCustom.<>f__mg$cache3F5 == null)
			{
				BindCustom.<>f__mg$cache3F5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroJobTransferUITask.reg);
			}
			array[num1014] = BindCustom.<>f__mg$cache3F5;
			int num1015 = 1014;
			if (BindCustom.<>f__mg$cache3F6 == null)
			{
				BindCustom.<>f__mg$cache3F6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroListUIController.reg);
			}
			array[num1015] = BindCustom.<>f__mg$cache3F6;
			int num1016 = 1015;
			if (BindCustom.<>f__mg$cache3F7 == null)
			{
				BindCustom.<>f__mg$cache3F7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroListUITask.reg);
			}
			array[num1016] = BindCustom.<>f__mg$cache3F7;
			int num1017 = 1016;
			if (BindCustom.<>f__mg$cache3F8 == null)
			{
				BindCustom.<>f__mg$cache3F8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroStarLevelUpNetTask.reg);
			}
			array[num1017] = BindCustom.<>f__mg$cache3F8;
			int num1018 = 1017;
			if (BindCustom.<>f__mg$cache3F9 == null)
			{
				BindCustom.<>f__mg$cache3F9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroJobLevelUpNetTask.reg);
			}
			array[num1018] = BindCustom.<>f__mg$cache3F9;
			int num1019 = 1018;
			if (BindCustom.<>f__mg$cache3FA == null)
			{
				BindCustom.<>f__mg$cache3FA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroAddExpNetTask.reg);
			}
			array[num1019] = BindCustom.<>f__mg$cache3FA;
			int num1020 = 1019;
			if (BindCustom.<>f__mg$cache3FB == null)
			{
				BindCustom.<>f__mg$cache3FB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroSkillsSelectNetTask.reg);
			}
			array[num1020] = BindCustom.<>f__mg$cache3FB;
			int num1021 = 1020;
			if (BindCustom.<>f__mg$cache3FC == null)
			{
				BindCustom.<>f__mg$cache3FC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroSoldierSelectNetTask.reg);
			}
			array[num1021] = BindCustom.<>f__mg$cache3FC;
			int num1022 = 1021;
			if (BindCustom.<>f__mg$cache3FD == null)
			{
				BindCustom.<>f__mg$cache3FD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroJobTransferNetTask.reg);
			}
			array[num1022] = BindCustom.<>f__mg$cache3FD;
			int num1023 = 1022;
			if (BindCustom.<>f__mg$cache3FE == null)
			{
				BindCustom.<>f__mg$cache3FE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroComposeNetTask.reg);
			}
			array[num1023] = BindCustom.<>f__mg$cache3FE;
			int num1024 = 1023;
			if (BindCustom.<>f__mg$cache3FF == null)
			{
				BindCustom.<>f__mg$cache3FF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroCommentSendNetTask.reg);
			}
			array[num1024] = BindCustom.<>f__mg$cache3FF;
			int num1025 = 1024;
			if (BindCustom.<>f__mg$cache400 == null)
			{
				BindCustom.<>f__mg$cache400 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroCommentGetNetTask.reg);
			}
			array[num1025] = BindCustom.<>f__mg$cache400;
			int num1026 = 1025;
			if (BindCustom.<>f__mg$cache401 == null)
			{
				BindCustom.<>f__mg$cache401 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroCommentPraisedNetTask.reg);
			}
			array[num1026] = BindCustom.<>f__mg$cache401;
			int num1027 = 1026;
			if (BindCustom.<>f__mg$cache402 == null)
			{
				BindCustom.<>f__mg$cache402 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ViewCommenterHeroNetTask.reg);
			}
			array[num1027] = BindCustom.<>f__mg$cache402;
			int num1028 = 1027;
			if (BindCustom.<>f__mg$cache403 == null)
			{
				BindCustom.<>f__mg$cache403 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroJobUnlockNetTask.reg);
			}
			array[num1028] = BindCustom.<>f__mg$cache403;
			int num1029 = 1028;
			if (BindCustom.<>f__mg$cache404 == null)
			{
				BindCustom.<>f__mg$cache404 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentWearNetTask.reg);
			}
			array[num1029] = BindCustom.<>f__mg$cache404;
			int num1030 = 1029;
			if (BindCustom.<>f__mg$cache405 == null)
			{
				BindCustom.<>f__mg$cache405 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentTakeOffNetTask.reg);
			}
			array[num1030] = BindCustom.<>f__mg$cache405;
			int num1031 = 1030;
			if (BindCustom.<>f__mg$cache406 == null)
			{
				BindCustom.<>f__mg$cache406 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentLockAndUnLockNetTask.reg);
			}
			array[num1031] = BindCustom.<>f__mg$cache406;
			int num1032 = 1031;
			if (BindCustom.<>f__mg$cache407 == null)
			{
				BindCustom.<>f__mg$cache407 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentEnhanceNetTask.reg);
			}
			array[num1032] = BindCustom.<>f__mg$cache407;
			int num1033 = 1032;
			if (BindCustom.<>f__mg$cache408 == null)
			{
				BindCustom.<>f__mg$cache408 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentStarLevelUpNetTask.reg);
			}
			array[num1033] = BindCustom.<>f__mg$cache408;
			int num1034 = 1033;
			if (BindCustom.<>f__mg$cache409 == null)
			{
				BindCustom.<>f__mg$cache409 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AutoEquipNetTask.reg);
			}
			array[num1034] = BindCustom.<>f__mg$cache409;
			int num1035 = 1034;
			if (BindCustom.<>f__mg$cache40A == null)
			{
				BindCustom.<>f__mg$cache40A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_AutoRemoveEquipmentNetTask.reg);
			}
			array[num1035] = BindCustom.<>f__mg$cache40A;
			int num1036 = 1035;
			if (BindCustom.<>f__mg$cache40B == null)
			{
				BindCustom.<>f__mg$cache40B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.reg);
			}
			array[num1036] = BindCustom.<>f__mg$cache40B;
			int num1037 = 1036;
			if (BindCustom.<>f__mg$cache40C == null)
			{
				BindCustom.<>f__mg$cache40C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.reg);
			}
			array[num1037] = BindCustom.<>f__mg$cache40C;
			int num1038 = 1037;
			if (BindCustom.<>f__mg$cache40D == null)
			{
				BindCustom.<>f__mg$cache40D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CharSkinWearNetTask.reg);
			}
			array[num1038] = BindCustom.<>f__mg$cache40D;
			int num1039 = 1038;
			if (BindCustom.<>f__mg$cache40E == null)
			{
				BindCustom.<>f__mg$cache40E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CharSkinTakeOffNetTask.reg);
			}
			array[num1039] = BindCustom.<>f__mg$cache40E;
			int num1040 = 1039;
			if (BindCustom.<>f__mg$cache40F == null)
			{
				BindCustom.<>f__mg$cache40F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ModelSkinWearNetTask.reg);
			}
			array[num1040] = BindCustom.<>f__mg$cache40F;
			int num1041 = 1040;
			if (BindCustom.<>f__mg$cache410 == null)
			{
				BindCustom.<>f__mg$cache410 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ModelSkinTakeOffNetTask.reg);
			}
			array[num1041] = BindCustom.<>f__mg$cache410;
			int num1042 = 1041;
			if (BindCustom.<>f__mg$cache411 == null)
			{
				BindCustom.<>f__mg$cache411 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SoldierSkinWearNetTask.reg);
			}
			array[num1042] = BindCustom.<>f__mg$cache411;
			int num1043 = 1042;
			if (BindCustom.<>f__mg$cache412 == null)
			{
				BindCustom.<>f__mg$cache412 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SoldierSkinTakeOffNetTask.reg);
			}
			array[num1043] = BindCustom.<>f__mg$cache412;
			int num1044 = 1043;
			if (BindCustom.<>f__mg$cache413 == null)
			{
				BindCustom.<>f__mg$cache413 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.reg);
			}
			array[num1044] = BindCustom.<>f__mg$cache413;
			int num1045 = 1044;
			if (BindCustom.<>f__mg$cache414 == null)
			{
				BindCustom.<>f__mg$cache414 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUIController.reg);
			}
			array[num1045] = BindCustom.<>f__mg$cache414;
			int num1046 = 1045;
			if (BindCustom.<>f__mg$cache415 == null)
			{
				BindCustom.<>f__mg$cache415 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroCharSkinItemUIController.reg);
			}
			array[num1046] = BindCustom.<>f__mg$cache415;
			int num1047 = 1046;
			if (BindCustom.<>f__mg$cache416 == null)
			{
				BindCustom.<>f__mg$cache416 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.reg);
			}
			array[num1047] = BindCustom.<>f__mg$cache416;
			int num1048 = 1047;
			if (BindCustom.<>f__mg$cache417 == null)
			{
				BindCustom.<>f__mg$cache417 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUIController.reg);
			}
			array[num1048] = BindCustom.<>f__mg$cache417;
			int num1049 = 1048;
			if (BindCustom.<>f__mg$cache418 == null)
			{
				BindCustom.<>f__mg$cache418 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroOrSoliderSkinUIController.reg);
			}
			array[num1049] = BindCustom.<>f__mg$cache418;
			int num1050 = 1049;
			if (BindCustom.<>f__mg$cache419 == null)
			{
				BindCustom.<>f__mg$cache419 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroSkinJobUIController.reg);
			}
			array[num1050] = BindCustom.<>f__mg$cache419;
			int num1051 = 1050;
			if (BindCustom.<>f__mg$cache41A == null)
			{
				BindCustom.<>f__mg$cache41A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroSoldierSkinUITask.reg);
			}
			array[num1051] = BindCustom.<>f__mg$cache41A;
			int num1052 = 1051;
			if (BindCustom.<>f__mg$cache41B == null)
			{
				BindCustom.<>f__mg$cache41B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelAttackNetTask.reg);
			}
			array[num1052] = BindCustom.<>f__mg$cache41B;
			int num1053 = 1052;
			if (BindCustom.<>f__mg$cache41C == null)
			{
				BindCustom.<>f__mg$cache41C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelBattleFinishedNetTask.reg);
			}
			array[num1053] = BindCustom.<>f__mg$cache41C;
			int num1054 = 1053;
			if (BindCustom.<>f__mg$cache41D == null)
			{
				BindCustom.<>f__mg$cache41D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelRaidNetTask.reg);
			}
			array[num1054] = BindCustom.<>f__mg$cache41D;
			int num1055 = 1054;
			if (BindCustom.<>f__mg$cache41E == null)
			{
				BindCustom.<>f__mg$cache41E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDungeonRewardGainNetTask.reg);
			}
			array[num1055] = BindCustom.<>f__mg$cache41E;
			int num1056 = 1055;
			if (BindCustom.<>f__mg$cache41F == null)
			{
				BindCustom.<>f__mg$cache41F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.reg);
			}
			array[num1056] = BindCustom.<>f__mg$cache41F;
			int num1057 = 1056;
			if (BindCustom.<>f__mg$cache420 == null)
			{
				BindCustom.<>f__mg$cache420 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelListItemUIController.reg);
			}
			array[num1057] = BindCustom.<>f__mg$cache420;
			int num1058 = 1057;
			if (BindCustom.<>f__mg$cache421 == null)
			{
				BindCustom.<>f__mg$cache421 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroDungeonUITask.reg);
			}
			array[num1058] = BindCustom.<>f__mg$cache421;
			int num1059 = 1058;
			if (BindCustom.<>f__mg$cache422 == null)
			{
				BindCustom.<>f__mg$cache422 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelAttackNetTask.reg);
			}
			array[num1059] = BindCustom.<>f__mg$cache422;
			int num1060 = 1059;
			if (BindCustom.<>f__mg$cache423 == null)
			{
				BindCustom.<>f__mg$cache423 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.reg);
			}
			array[num1060] = BindCustom.<>f__mg$cache423;
			int num1061 = 1060;
			if (BindCustom.<>f__mg$cache424 == null)
			{
				BindCustom.<>f__mg$cache424 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.reg);
			}
			array[num1061] = BindCustom.<>f__mg$cache424;
			int num1062 = 1061;
			if (BindCustom.<>f__mg$cache425 == null)
			{
				BindCustom.<>f__mg$cache425 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelListItemUIController.reg);
			}
			array[num1062] = BindCustom.<>f__mg$cache425;
			int num1063 = 1062;
			if (BindCustom.<>f__mg$cache426 == null)
			{
				BindCustom.<>f__mg$cache426 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroPhantomUITask.reg);
			}
			array[num1063] = BindCustom.<>f__mg$cache426;
			int num1064 = 1063;
			if (BindCustom.<>f__mg$cache427 == null)
			{
				BindCustom.<>f__mg$cache427 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroTrainningLevelAttackNetTask.reg);
			}
			array[num1064] = BindCustom.<>f__mg$cache427;
			int num1065 = 1064;
			if (BindCustom.<>f__mg$cache428 == null)
			{
				BindCustom.<>f__mg$cache428 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroTrainningLevelBattleFinishedNetTask.reg);
			}
			array[num1065] = BindCustom.<>f__mg$cache428;
			int num1066 = 1065;
			if (BindCustom.<>f__mg$cache429 == null)
			{
				BindCustom.<>f__mg$cache429 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroTrainningUIController.reg);
			}
			array[num1066] = BindCustom.<>f__mg$cache429;
			int num1067 = 1066;
			if (BindCustom.<>f__mg$cache42A == null)
			{
				BindCustom.<>f__mg$cache42A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroTrainningLevelListItemUIController.reg);
			}
			array[num1067] = BindCustom.<>f__mg$cache42A;
			int num1068 = 1067;
			if (BindCustom.<>f__mg$cache42B == null)
			{
				BindCustom.<>f__mg$cache42B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroTrainningUITask.reg);
			}
			array[num1068] = BindCustom.<>f__mg$cache42B;
			int num1069 = 1068;
			if (BindCustom.<>f__mg$cache42C == null)
			{
				BindCustom.<>f__mg$cache42C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.reg);
			}
			array[num1069] = BindCustom.<>f__mg$cache42C;
			int num1070 = 1069;
			if (BindCustom.<>f__mg$cache42D == null)
			{
				BindCustom.<>f__mg$cache42D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CreateCharacterUIController.reg);
			}
			array[num1070] = BindCustom.<>f__mg$cache42D;
			int num1071 = 1070;
			if (BindCustom.<>f__mg$cache42E == null)
			{
				BindCustom.<>f__mg$cache42E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LoginCommonUIController.reg);
			}
			array[num1071] = BindCustom.<>f__mg$cache42E;
			int num1072 = 1071;
			if (BindCustom.<>f__mg$cache42F == null)
			{
				BindCustom.<>f__mg$cache42F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerInfoInitNetTask.reg);
			}
			array[num1072] = BindCustom.<>f__mg$cache42F;
			int num1073 = 1072;
			if (BindCustom.<>f__mg$cache430 == null)
			{
				BindCustom.<>f__mg$cache430 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CreateCharacterNetTask.reg);
			}
			array[num1073] = BindCustom.<>f__mg$cache430;
			int num1074 = 1073;
			if (BindCustom.<>f__mg$cache431 == null)
			{
				BindCustom.<>f__mg$cache431 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LoginUIController.reg);
			}
			array[num1074] = BindCustom.<>f__mg$cache431;
			int num1075 = 1074;
			if (BindCustom.<>f__mg$cache432 == null)
			{
				BindCustom.<>f__mg$cache432 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LoginAnnouncement.reg);
			}
			array[num1075] = BindCustom.<>f__mg$cache432;
			int num1076 = 1075;
			if (BindCustom.<>f__mg$cache433 == null)
			{
				BindCustom.<>f__mg$cache433 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LoginUITask.reg);
			}
			array[num1076] = BindCustom.<>f__mg$cache433;
			int num1077 = 1076;
			if (BindCustom.<>f__mg$cache434 == null)
			{
				BindCustom.<>f__mg$cache434 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LoginUITask_ExistCharInfo.reg);
			}
			array[num1077] = BindCustom.<>f__mg$cache434;
			int num1078 = 1077;
			if (BindCustom.<>f__mg$cache435 == null)
			{
				BindCustom.<>f__mg$cache435 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LoginUITask_ServerInfo.reg);
			}
			array[num1078] = BindCustom.<>f__mg$cache435;
			int num1079 = 1078;
			if (BindCustom.<>f__mg$cache436 == null)
			{
				BindCustom.<>f__mg$cache436 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnixTimeStamp.reg);
			}
			array[num1079] = BindCustom.<>f__mg$cache436;
			int num1080 = 1079;
			if (BindCustom.<>f__mg$cache437 == null)
			{
				BindCustom.<>f__mg$cache437 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ReloginUIController.reg);
			}
			array[num1080] = BindCustom.<>f__mg$cache437;
			int num1081 = 1080;
			if (BindCustom.<>f__mg$cache438 == null)
			{
				BindCustom.<>f__mg$cache438 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ReloginUITask.reg);
			}
			array[num1081] = BindCustom.<>f__mg$cache438;
			int num1082 = 1081;
			if (BindCustom.<>f__mg$cache439 == null)
			{
				BindCustom.<>f__mg$cache439 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ServerListUIController.reg);
			}
			array[num1082] = BindCustom.<>f__mg$cache439;
			int num1083 = 1082;
			if (BindCustom.<>f__mg$cache43A == null)
			{
				BindCustom.<>f__mg$cache43A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MailDetailUIController.reg);
			}
			array[num1083] = BindCustom.<>f__mg$cache43A;
			int num1084 = 1083;
			if (BindCustom.<>f__mg$cache43B == null)
			{
				BindCustom.<>f__mg$cache43B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MailItemUIController.reg);
			}
			array[num1084] = BindCustom.<>f__mg$cache43B;
			int num1085 = 1084;
			if (BindCustom.<>f__mg$cache43C == null)
			{
				BindCustom.<>f__mg$cache43C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MailListUIController.reg);
			}
			array[num1085] = BindCustom.<>f__mg$cache43C;
			int num1086 = 1085;
			if (BindCustom.<>f__mg$cache43D == null)
			{
				BindCustom.<>f__mg$cache43D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MailsGetNetTask.reg);
			}
			array[num1086] = BindCustom.<>f__mg$cache43D;
			int num1087 = 1086;
			if (BindCustom.<>f__mg$cache43E == null)
			{
				BindCustom.<>f__mg$cache43E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MailReadNetTask.reg);
			}
			array[num1087] = BindCustom.<>f__mg$cache43E;
			int num1088 = 1087;
			if (BindCustom.<>f__mg$cache43F == null)
			{
				BindCustom.<>f__mg$cache43F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MailAttachmentsGetNetTask.reg);
			}
			array[num1088] = BindCustom.<>f__mg$cache43F;
			int num1089 = 1088;
			if (BindCustom.<>f__mg$cache440 == null)
			{
				BindCustom.<>f__mg$cache440 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MailAttachmentsAutoGetNetTask.reg);
			}
			array[num1089] = BindCustom.<>f__mg$cache440;
			int num1090 = 1089;
			if (BindCustom.<>f__mg$cache441 == null)
			{
				BindCustom.<>f__mg$cache441 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MailUITask.reg);
			}
			array[num1090] = BindCustom.<>f__mg$cache441;
			int num1091 = 1090;
			if (BindCustom.<>f__mg$cache442 == null)
			{
				BindCustom.<>f__mg$cache442 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelAttackNetTask.reg);
			}
			array[num1091] = BindCustom.<>f__mg$cache442;
			int num1092 = 1091;
			if (BindCustom.<>f__mg$cache443 == null)
			{
				BindCustom.<>f__mg$cache443 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelBattleFinishedNetTask.reg);
			}
			array[num1092] = BindCustom.<>f__mg$cache443;
			int num1093 = 1092;
			if (BindCustom.<>f__mg$cache444 == null)
			{
				BindCustom.<>f__mg$cache444 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MemoryCorridorUIController.reg);
			}
			array[num1093] = BindCustom.<>f__mg$cache444;
			int num1094 = 1093;
			if (BindCustom.<>f__mg$cache445 == null)
			{
				BindCustom.<>f__mg$cache445 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.reg);
			}
			array[num1094] = BindCustom.<>f__mg$cache445;
			int num1095 = 1094;
			if (BindCustom.<>f__mg$cache446 == null)
			{
				BindCustom.<>f__mg$cache446 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MemoryCorridorUITask.reg);
			}
			array[num1095] = BindCustom.<>f__mg$cache446;
			int num1096 = 1095;
			if (BindCustom.<>f__mg$cache447 == null)
			{
				BindCustom.<>f__mg$cache447 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.reg);
			}
			array[num1096] = BindCustom.<>f__mg$cache447;
			int num1097 = 1096;
			if (BindCustom.<>f__mg$cache448 == null)
			{
				BindCustom.<>f__mg$cache448 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MissionUIController.reg);
			}
			array[num1097] = BindCustom.<>f__mg$cache448;
			int num1098 = 1097;
			if (BindCustom.<>f__mg$cache449 == null)
			{
				BindCustom.<>f__mg$cache449 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MissionItemUIController.reg);
			}
			array[num1098] = BindCustom.<>f__mg$cache449;
			int num1099 = 1098;
			if (BindCustom.<>f__mg$cache44A == null)
			{
				BindCustom.<>f__mg$cache44A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MissionUITask.reg);
			}
			array[num1099] = BindCustom.<>f__mg$cache44A;
			int num1100 = 1099;
			if (BindCustom.<>f__mg$cache44B == null)
			{
				BindCustom.<>f__mg$cache44B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_NoticeUIController.reg);
			}
			array[num1100] = BindCustom.<>f__mg$cache44B;
			int num1101 = 1100;
			if (BindCustom.<>f__mg$cache44C == null)
			{
				BindCustom.<>f__mg$cache44C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_NoticeUITask.reg);
			}
			array[num1101] = BindCustom.<>f__mg$cache44C;
			int num1102 = 1101;
			if (BindCustom.<>f__mg$cache44D == null)
			{
				BindCustom.<>f__mg$cache44D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.reg);
			}
			array[num1102] = BindCustom.<>f__mg$cache44D;
			int num1103 = 1102;
			if (BindCustom.<>f__mg$cache44E == null)
			{
				BindCustom.<>f__mg$cache44E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.reg);
			}
			array[num1103] = BindCustom.<>f__mg$cache44E;
			int num1104 = 1103;
			if (BindCustom.<>f__mg$cache44F == null)
			{
				BindCustom.<>f__mg$cache44F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.reg);
			}
			array[num1104] = BindCustom.<>f__mg$cache44F;
			int num1105 = 1104;
			if (BindCustom.<>f__mg$cache450 == null)
			{
				BindCustom.<>f__mg$cache450 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChangeHeadPortraitAndHeadFrameNetTask.reg);
			}
			array[num1105] = BindCustom.<>f__mg$cache450;
			int num1106 = 1105;
			if (BindCustom.<>f__mg$cache451 == null)
			{
				BindCustom.<>f__mg$cache451 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ChangePlayerNameNetTask.reg);
			}
			array[num1106] = BindCustom.<>f__mg$cache451;
			int num1107 = 1106;
			if (BindCustom.<>f__mg$cache452 == null)
			{
				BindCustom.<>f__mg$cache452 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UseRedemptionCodeNetTask.reg);
			}
			array[num1107] = BindCustom.<>f__mg$cache452;
			int num1108 = 1107;
			if (BindCustom.<>f__mg$cache453 == null)
			{
				BindCustom.<>f__mg$cache453 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_OpenSurveyNetTask.reg);
			}
			array[num1108] = BindCustom.<>f__mg$cache453;
			int num1109 = 1108;
			if (BindCustom.<>f__mg$cache454 == null)
			{
				BindCustom.<>f__mg$cache454 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GetSurveyRewardNetTask.reg);
			}
			array[num1109] = BindCustom.<>f__mg$cache454;
			int num1110 = 1109;
			if (BindCustom.<>f__mg$cache455 == null)
			{
				BindCustom.<>f__mg$cache455 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CheckOnlineNetTask.reg);
			}
			array[num1110] = BindCustom.<>f__mg$cache455;
			int num1111 = 1110;
			if (BindCustom.<>f__mg$cache456 == null)
			{
				BindCustom.<>f__mg$cache456 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.reg);
			}
			array[num1111] = BindCustom.<>f__mg$cache456;
			int num1112 = 1111;
			if (BindCustom.<>f__mg$cache457 == null)
			{
				BindCustom.<>f__mg$cache457 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PlayerInfoUITask.reg);
			}
			array[num1112] = BindCustom.<>f__mg$cache457;
			int num1113 = 1112;
			if (BindCustom.<>f__mg$cache458 == null)
			{
				BindCustom.<>f__mg$cache458 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PreloadUIController.reg);
			}
			array[num1113] = BindCustom.<>f__mg$cache458;
			int num1114 = 1113;
			if (BindCustom.<>f__mg$cache459 == null)
			{
				BindCustom.<>f__mg$cache459 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PreloadUITask.reg);
			}
			array[num1114] = BindCustom.<>f__mg$cache459;
			int num1115 = 1114;
			if (BindCustom.<>f__mg$cache45A == null)
			{
				BindCustom.<>f__mg$cache45A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UIGroup.reg);
			}
			array[num1115] = BindCustom.<>f__mg$cache45A;
			int num1116 = 1115;
			if (BindCustom.<>f__mg$cache45B == null)
			{
				BindCustom.<>f__mg$cache45B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.reg);
			}
			array[num1116] = BindCustom.<>f__mg$cache45B;
			int num1117 = 1116;
			if (BindCustom.<>f__mg$cache45C == null)
			{
				BindCustom.<>f__mg$cache45C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_Raffle3DUIController.reg);
			}
			array[num1117] = BindCustom.<>f__mg$cache45C;
			int num1118 = 1117;
			if (BindCustom.<>f__mg$cache45D == null)
			{
				BindCustom.<>f__mg$cache45D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.reg);
			}
			array[num1118] = BindCustom.<>f__mg$cache45D;
			int num1119 = 1118;
			if (BindCustom.<>f__mg$cache45E == null)
			{
				BindCustom.<>f__mg$cache45E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RaffleRewardItemUIController.reg);
			}
			array[num1119] = BindCustom.<>f__mg$cache45E;
			int num1120 = 1119;
			if (BindCustom.<>f__mg$cache45F == null)
			{
				BindCustom.<>f__mg$cache45F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RaffleRewardUIController.reg);
			}
			array[num1120] = BindCustom.<>f__mg$cache45F;
			int num1121 = 1120;
			if (BindCustom.<>f__mg$cache460 == null)
			{
				BindCustom.<>f__mg$cache460 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RaffleUIController.reg);
			}
			array[num1121] = BindCustom.<>f__mg$cache460;
			int num1122 = 1121;
			if (BindCustom.<>f__mg$cache461 == null)
			{
				BindCustom.<>f__mg$cache461 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RaffleUITask.reg);
			}
			array[num1122] = BindCustom.<>f__mg$cache461;
			int num1123 = 1122;
			if (BindCustom.<>f__mg$cache462 == null)
			{
				BindCustom.<>f__mg$cache462 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.reg);
			}
			array[num1123] = BindCustom.<>f__mg$cache462;
			int num1124 = 1123;
			if (BindCustom.<>f__mg$cache463 == null)
			{
				BindCustom.<>f__mg$cache463 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RankingListUIController.reg);
			}
			array[num1124] = BindCustom.<>f__mg$cache463;
			int num1125 = 1124;
			if (BindCustom.<>f__mg$cache464 == null)
			{
				BindCustom.<>f__mg$cache464 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RankingNetTask.reg);
			}
			array[num1125] = BindCustom.<>f__mg$cache464;
			int num1126 = 1125;
			if (BindCustom.<>f__mg$cache465 == null)
			{
				BindCustom.<>f__mg$cache465 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RankingSubMenuUIController.reg);
			}
			array[num1126] = BindCustom.<>f__mg$cache465;
			int num1127 = 1126;
			if (BindCustom.<>f__mg$cache466 == null)
			{
				BindCustom.<>f__mg$cache466 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RankingUIController.reg);
			}
			array[num1127] = BindCustom.<>f__mg$cache466;
			int num1128 = 1127;
			if (BindCustom.<>f__mg$cache467 == null)
			{
				BindCustom.<>f__mg$cache467 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RankingUITask.reg);
			}
			array[num1128] = BindCustom.<>f__mg$cache467;
			int num1129 = 1128;
			if (BindCustom.<>f__mg$cache468 == null)
			{
				BindCustom.<>f__mg$cache468 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.reg);
			}
			array[num1129] = BindCustom.<>f__mg$cache468;
			int num1130 = 1129;
			if (BindCustom.<>f__mg$cache469 == null)
			{
				BindCustom.<>f__mg$cache469 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUIController.reg);
			}
			array[num1130] = BindCustom.<>f__mg$cache469;
			int num1131 = 1130;
			if (BindCustom.<>f__mg$cache46A == null)
			{
				BindCustom.<>f__mg$cache46A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BattleLevelInfoUITask.reg);
			}
			array[num1131] = BindCustom.<>f__mg$cache46A;
			int num1132 = 1131;
			if (BindCustom.<>f__mg$cache46B == null)
			{
				BindCustom.<>f__mg$cache46B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RaidLevelUIController.reg);
			}
			array[num1132] = BindCustom.<>f__mg$cache46B;
			int num1133 = 1132;
			if (BindCustom.<>f__mg$cache46C == null)
			{
				BindCustom.<>f__mg$cache46C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RaidLevelUITask.reg);
			}
			array[num1133] = BindCustom.<>f__mg$cache46C;
			int num1134 = 1133;
			if (BindCustom.<>f__mg$cache46D == null)
			{
				BindCustom.<>f__mg$cache46D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftBackgroundUIController.reg);
			}
			array[num1134] = BindCustom.<>f__mg$cache46D;
			int num1135 = 1134;
			if (BindCustom.<>f__mg$cache46E == null)
			{
				BindCustom.<>f__mg$cache46E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftChapterUIController.reg);
			}
			array[num1135] = BindCustom.<>f__mg$cache46E;
			int num1136 = 1135;
			if (BindCustom.<>f__mg$cache46F == null)
			{
				BindCustom.<>f__mg$cache46F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftChapterButton.reg);
			}
			array[num1136] = BindCustom.<>f__mg$cache46F;
			int num1137 = 1136;
			if (BindCustom.<>f__mg$cache470 == null)
			{
				BindCustom.<>f__mg$cache470 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftChapterUnlockConditionItemUIController.reg);
			}
			array[num1137] = BindCustom.<>f__mg$cache470;
			int num1138 = 1137;
			if (BindCustom.<>f__mg$cache471 == null)
			{
				BindCustom.<>f__mg$cache471 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftLevelUIController.reg);
			}
			array[num1138] = BindCustom.<>f__mg$cache471;
			int num1139 = 1138;
			if (BindCustom.<>f__mg$cache472 == null)
			{
				BindCustom.<>f__mg$cache472 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftLevelButton.reg);
			}
			array[num1139] = BindCustom.<>f__mg$cache472;
			int num1140 = 1139;
			if (BindCustom.<>f__mg$cache473 == null)
			{
				BindCustom.<>f__mg$cache473 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.reg);
			}
			array[num1140] = BindCustom.<>f__mg$cache473;
			int num1141 = 1140;
			if (BindCustom.<>f__mg$cache474 == null)
			{
				BindCustom.<>f__mg$cache474 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GainRewardButton.reg);
			}
			array[num1141] = BindCustom.<>f__mg$cache474;
			int num1142 = 1141;
			if (BindCustom.<>f__mg$cache475 == null)
			{
				BindCustom.<>f__mg$cache475 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftLevelUnlockConditionItemUIController.reg);
			}
			array[num1142] = BindCustom.<>f__mg$cache475;
			int num1143 = 1142;
			if (BindCustom.<>f__mg$cache476 == null)
			{
				BindCustom.<>f__mg$cache476 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftLevelAttackNetTask.reg);
			}
			array[num1143] = BindCustom.<>f__mg$cache476;
			int num1144 = 1143;
			if (BindCustom.<>f__mg$cache477 == null)
			{
				BindCustom.<>f__mg$cache477 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.reg);
			}
			array[num1144] = BindCustom.<>f__mg$cache477;
			int num1145 = 1144;
			if (BindCustom.<>f__mg$cache478 == null)
			{
				BindCustom.<>f__mg$cache478 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftLevelRaidNetTask.reg);
			}
			array[num1145] = BindCustom.<>f__mg$cache478;
			int num1146 = 1145;
			if (BindCustom.<>f__mg$cache479 == null)
			{
				BindCustom.<>f__mg$cache479 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftChapterRewardGainNetTask.reg);
			}
			array[num1146] = BindCustom.<>f__mg$cache479;
			int num1147 = 1146;
			if (BindCustom.<>f__mg$cache47A == null)
			{
				BindCustom.<>f__mg$cache47A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RiftUITask.reg);
			}
			array[num1147] = BindCustom.<>f__mg$cache47A;
			int num1148 = 1147;
			if (BindCustom.<>f__mg$cache47B == null)
			{
				BindCustom.<>f__mg$cache47B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CardSelectNetTask.reg);
			}
			array[num1148] = BindCustom.<>f__mg$cache47B;
			int num1149 = 1148;
			if (BindCustom.<>f__mg$cache47C == null)
			{
				BindCustom.<>f__mg$cache47C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SelectCardUIController.reg);
			}
			array[num1149] = BindCustom.<>f__mg$cache47C;
			int num1150 = 1149;
			if (BindCustom.<>f__mg$cache47D == null)
			{
				BindCustom.<>f__mg$cache47D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.reg);
			}
			array[num1150] = BindCustom.<>f__mg$cache47D;
			int num1151 = 1150;
			if (BindCustom.<>f__mg$cache47E == null)
			{
				BindCustom.<>f__mg$cache47E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.reg);
			}
			array[num1151] = BindCustom.<>f__mg$cache47E;
			int num1152 = 1151;
			if (BindCustom.<>f__mg$cache47F == null)
			{
				BindCustom.<>f__mg$cache47F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SelectCardBackground3DController.reg);
			}
			array[num1152] = BindCustom.<>f__mg$cache47F;
			int num1153 = 1152;
			if (BindCustom.<>f__mg$cache480 == null)
			{
				BindCustom.<>f__mg$cache480 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SummonToggleUIController.reg);
			}
			array[num1153] = BindCustom.<>f__mg$cache480;
			int num1154 = 1153;
			if (BindCustom.<>f__mg$cache481 == null)
			{
				BindCustom.<>f__mg$cache481 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SelectCardUITask.reg);
			}
			array[num1154] = BindCustom.<>f__mg$cache481;
			int num1155 = 1154;
			if (BindCustom.<>f__mg$cache482 == null)
			{
				BindCustom.<>f__mg$cache482 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.reg);
			}
			array[num1155] = BindCustom.<>f__mg$cache482;
			int num1156 = 1155;
			if (BindCustom.<>f__mg$cache483 == null)
			{
				BindCustom.<>f__mg$cache483 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ShareNetTask.reg);
			}
			array[num1156] = BindCustom.<>f__mg$cache483;
			int num1157 = 1156;
			if (BindCustom.<>f__mg$cache484 == null)
			{
				BindCustom.<>f__mg$cache484 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EverydaySignNetTask.reg);
			}
			array[num1157] = BindCustom.<>f__mg$cache484;
			int num1158 = 1157;
			if (BindCustom.<>f__mg$cache485 == null)
			{
				BindCustom.<>f__mg$cache485 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SignRewardItemUIController.reg);
			}
			array[num1158] = BindCustom.<>f__mg$cache485;
			int num1159 = 1158;
			if (BindCustom.<>f__mg$cache486 == null)
			{
				BindCustom.<>f__mg$cache486 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SignRewardListUIController.reg);
			}
			array[num1159] = BindCustom.<>f__mg$cache486;
			int num1160 = 1159;
			if (BindCustom.<>f__mg$cache487 == null)
			{
				BindCustom.<>f__mg$cache487 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SignUITask.reg);
			}
			array[num1160] = BindCustom.<>f__mg$cache487;
			int num1161 = 1160;
			if (BindCustom.<>f__mg$cache488 == null)
			{
				BindCustom.<>f__mg$cache488 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BoxItemInfoUIController.reg);
			}
			array[num1161] = BindCustom.<>f__mg$cache488;
			int num1162 = 1161;
			if (BindCustom.<>f__mg$cache489 == null)
			{
				BindCustom.<>f__mg$cache489 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_StoreHeroSkinItemUIController.reg);
			}
			array[num1162] = BindCustom.<>f__mg$cache489;
			int num1163 = 1162;
			if (BindCustom.<>f__mg$cache48A == null)
			{
				BindCustom.<>f__mg$cache48A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_StoreItemUIController.reg);
			}
			array[num1163] = BindCustom.<>f__mg$cache48A;
			int num1164 = 1163;
			if (BindCustom.<>f__mg$cache48B == null)
			{
				BindCustom.<>f__mg$cache48B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_StoreListUIController.reg);
			}
			array[num1164] = BindCustom.<>f__mg$cache48B;
			int num1165 = 1164;
			if (BindCustom.<>f__mg$cache48C == null)
			{
				BindCustom.<>f__mg$cache48C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_MemoryStoreHeroFragmentItemUIController.reg);
			}
			array[num1165] = BindCustom.<>f__mg$cache48C;
			int num1166 = 1165;
			if (BindCustom.<>f__mg$cache48D == null)
			{
				BindCustom.<>f__mg$cache48D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_FixedStoreBuyStoreItemNetTask.reg);
			}
			array[num1166] = BindCustom.<>f__mg$cache48D;
			int num1167 = 1166;
			if (BindCustom.<>f__mg$cache48E == null)
			{
				BindCustom.<>f__mg$cache48E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ExchangeHeroFragementNetTask.reg);
			}
			array[num1167] = BindCustom.<>f__mg$cache48E;
			int num1168 = 1167;
			if (BindCustom.<>f__mg$cache48F == null)
			{
				BindCustom.<>f__mg$cache48F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SendOpenMemoryStoreNetTask.reg);
			}
			array[num1168] = BindCustom.<>f__mg$cache48F;
			int num1169 = 1168;
			if (BindCustom.<>f__mg$cache490 == null)
			{
				BindCustom.<>f__mg$cache490 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GetRandomStoreItemListNetTask.reg);
			}
			array[num1169] = BindCustom.<>f__mg$cache490;
			int num1170 = 1169;
			if (BindCustom.<>f__mg$cache491 == null)
			{
				BindCustom.<>f__mg$cache491 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RandomStoreFlushNetTask.reg);
			}
			array[num1170] = BindCustom.<>f__mg$cache491;
			int num1171 = 1170;
			if (BindCustom.<>f__mg$cache492 == null)
			{
				BindCustom.<>f__mg$cache492 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RandomStoreBuyStoreItemNetTask.reg);
			}
			array[num1171] = BindCustom.<>f__mg$cache492;
			int num1172 = 1171;
			if (BindCustom.<>f__mg$cache493 == null)
			{
				BindCustom.<>f__mg$cache493 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GiftStoreBuyStoreItemNetTask.reg);
			}
			array[num1172] = BindCustom.<>f__mg$cache493;
			int num1173 = 1172;
			if (BindCustom.<>f__mg$cache494 == null)
			{
				BindCustom.<>f__mg$cache494 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GiftStoreAppleSubscribeNetTask.reg);
			}
			array[num1173] = BindCustom.<>f__mg$cache494;
			int num1174 = 1173;
			if (BindCustom.<>f__mg$cache495 == null)
			{
				BindCustom.<>f__mg$cache495 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GiftStoreCancelBuyNetTask.reg);
			}
			array[num1174] = BindCustom.<>f__mg$cache495;
			int num1175 = 1174;
			if (BindCustom.<>f__mg$cache496 == null)
			{
				BindCustom.<>f__mg$cache496 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.reg);
			}
			array[num1175] = BindCustom.<>f__mg$cache496;
			int num1176 = 1175;
			if (BindCustom.<>f__mg$cache497 == null)
			{
				BindCustom.<>f__mg$cache497 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RechargeStoreBuyStoreItemNetTask.reg);
			}
			array[num1176] = BindCustom.<>f__mg$cache497;
			int num1177 = 1176;
			if (BindCustom.<>f__mg$cache498 == null)
			{
				BindCustom.<>f__mg$cache498 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_RechargeStoreCancelBuyNetTask.reg);
			}
			array[num1177] = BindCustom.<>f__mg$cache498;
			int num1178 = 1177;
			if (BindCustom.<>f__mg$cache499 == null)
			{
				BindCustom.<>f__mg$cache499 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.reg);
			}
			array[num1178] = BindCustom.<>f__mg$cache499;
			int num1179 = 1178;
			if (BindCustom.<>f__mg$cache49A == null)
			{
				BindCustom.<>f__mg$cache49A = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SoldierShowItemController.reg);
			}
			array[num1179] = BindCustom.<>f__mg$cache49A;
			int num1180 = 1179;
			if (BindCustom.<>f__mg$cache49B == null)
			{
				BindCustom.<>f__mg$cache49B = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUITask.reg);
			}
			array[num1180] = BindCustom.<>f__mg$cache49B;
			int num1181 = 1180;
			if (BindCustom.<>f__mg$cache49C == null)
			{
				BindCustom.<>f__mg$cache49C = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.reg);
			}
			array[num1181] = BindCustom.<>f__mg$cache49C;
			int num1182 = 1181;
			if (BindCustom.<>f__mg$cache49D == null)
			{
				BindCustom.<>f__mg$cache49D = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_StoreUITask.reg);
			}
			array[num1182] = BindCustom.<>f__mg$cache49D;
			int num1183 = 1182;
			if (BindCustom.<>f__mg$cache49E == null)
			{
				BindCustom.<>f__mg$cache49E = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CreateTeamRoomUIController.reg);
			}
			array[num1183] = BindCustom.<>f__mg$cache49E;
			int num1184 = 1183;
			if (BindCustom.<>f__mg$cache49F == null)
			{
				BindCustom.<>f__mg$cache49F = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomInfoListItemUIController.reg);
			}
			array[num1184] = BindCustom.<>f__mg$cache49F;
			int num1185 = 1184;
			if (BindCustom.<>f__mg$cache4A0 == null)
			{
				BindCustom.<>f__mg$cache4A0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomCreateNetTask.reg);
			}
			array[num1185] = BindCustom.<>f__mg$cache4A0;
			int num1186 = 1185;
			if (BindCustom.<>f__mg$cache4A1 == null)
			{
				BindCustom.<>f__mg$cache4A1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomViewNetTask.reg);
			}
			array[num1186] = BindCustom.<>f__mg$cache4A1;
			int num1187 = 1186;
			if (BindCustom.<>f__mg$cache4A2 == null)
			{
				BindCustom.<>f__mg$cache4A2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchNetTaskNetTask.reg);
			}
			array[num1187] = BindCustom.<>f__mg$cache4A2;
			int num1188 = 1187;
			if (BindCustom.<>f__mg$cache4A3 == null)
			{
				BindCustom.<>f__mg$cache4A3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomAutoMatchCancelNetTask.reg);
			}
			array[num1188] = BindCustom.<>f__mg$cache4A3;
			int num1189 = 1188;
			if (BindCustom.<>f__mg$cache4A4 == null)
			{
				BindCustom.<>f__mg$cache4A4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomAuthorityChangeNetTask.reg);
			}
			array[num1189] = BindCustom.<>f__mg$cache4A4;
			int num1190 = 1189;
			if (BindCustom.<>f__mg$cache4A5 == null)
			{
				BindCustom.<>f__mg$cache4A5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomJoinNetTask.reg);
			}
			array[num1190] = BindCustom.<>f__mg$cache4A5;
			int num1191 = 1190;
			if (BindCustom.<>f__mg$cache4A6 == null)
			{
				BindCustom.<>f__mg$cache4A6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomQuitNetTask.reg);
			}
			array[num1191] = BindCustom.<>f__mg$cache4A6;
			int num1192 = 1191;
			if (BindCustom.<>f__mg$cache4A7 == null)
			{
				BindCustom.<>f__mg$cache4A7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomGetNetTask.reg);
			}
			array[num1192] = BindCustom.<>f__mg$cache4A7;
			int num1193 = 1192;
			if (BindCustom.<>f__mg$cache4A8 == null)
			{
				BindCustom.<>f__mg$cache4A8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomInviteNetTask.reg);
			}
			array[num1193] = BindCustom.<>f__mg$cache4A8;
			int num1194 = 1193;
			if (BindCustom.<>f__mg$cache4A9 == null)
			{
				BindCustom.<>f__mg$cache4A9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomInvitationRefusedNetTask.reg);
			}
			array[num1194] = BindCustom.<>f__mg$cache4A9;
			int num1195 = 1194;
			if (BindCustom.<>f__mg$cache4AA == null)
			{
				BindCustom.<>f__mg$cache4AA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamBattleRoomCreateNetTask.reg);
			}
			array[num1195] = BindCustom.<>f__mg$cache4AA;
			int num1196 = 1195;
			if (BindCustom.<>f__mg$cache4AB == null)
			{
				BindCustom.<>f__mg$cache4AB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomInviteeInfoGetNetTask.reg);
			}
			array[num1196] = BindCustom.<>f__mg$cache4AB;
			int num1197 = 1196;
			if (BindCustom.<>f__mg$cache4AC == null)
			{
				BindCustom.<>f__mg$cache4AC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerPositionChangeNetTask.reg);
			}
			array[num1197] = BindCustom.<>f__mg$cache4AC;
			int num1198 = 1197;
			if (BindCustom.<>f__mg$cache4AD == null)
			{
				BindCustom.<>f__mg$cache4AD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUIController.reg);
			}
			array[num1198] = BindCustom.<>f__mg$cache4AD;
			int num1199 = 1198;
			if (BindCustom.<>f__mg$cache4AE == null)
			{
				BindCustom.<>f__mg$cache4AE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomPlayerInfoUIController.reg);
			}
			array[num1199] = BindCustom.<>f__mg$cache4AE;
			int num1200 = 1199;
			if (BindCustom.<>f__mg$cache4AF == null)
			{
				BindCustom.<>f__mg$cache4AF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomInfoUITask.reg);
			}
			array[num1200] = BindCustom.<>f__mg$cache4AF;
			int num1201 = 1200;
			if (BindCustom.<>f__mg$cache4B0 == null)
			{
				BindCustom.<>f__mg$cache4B0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUIController.reg);
			}
			array[num1201] = BindCustom.<>f__mg$cache4B0;
			int num1202 = 1201;
			if (BindCustom.<>f__mg$cache4B1 == null)
			{
				BindCustom.<>f__mg$cache4B1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomInvitePlayerListItemUIController.reg);
			}
			array[num1202] = BindCustom.<>f__mg$cache4B1;
			int num1203 = 1202;
			if (BindCustom.<>f__mg$cache4B2 == null)
			{
				BindCustom.<>f__mg$cache4B2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask.reg);
			}
			array[num1203] = BindCustom.<>f__mg$cache4B2;
			int num1204 = 1203;
			if (BindCustom.<>f__mg$cache4B3 == null)
			{
				BindCustom.<>f__mg$cache4B3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.reg);
			}
			array[num1204] = BindCustom.<>f__mg$cache4B3;
			int num1205 = 1204;
			if (BindCustom.<>f__mg$cache4B4 == null)
			{
				BindCustom.<>f__mg$cache4B4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamUIController.reg);
			}
			array[num1205] = BindCustom.<>f__mg$cache4B4;
			int num1206 = 1205;
			if (BindCustom.<>f__mg$cache4B5 == null)
			{
				BindCustom.<>f__mg$cache4B5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamGameFunctionTypeListItemUIController.reg);
			}
			array[num1206] = BindCustom.<>f__mg$cache4B5;
			int num1207 = 1206;
			if (BindCustom.<>f__mg$cache4B6 == null)
			{
				BindCustom.<>f__mg$cache4B6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamLocationListItemUIController.reg);
			}
			array[num1207] = BindCustom.<>f__mg$cache4B6;
			int num1208 = 1207;
			if (BindCustom.<>f__mg$cache4B7 == null)
			{
				BindCustom.<>f__mg$cache4B7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.reg);
			}
			array[num1208] = BindCustom.<>f__mg$cache4B7;
			int num1209 = 1208;
			if (BindCustom.<>f__mg$cache4B8 == null)
			{
				BindCustom.<>f__mg$cache4B8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TeamUITask.reg);
			}
			array[num1209] = BindCustom.<>f__mg$cache4B8;
			int num1210 = 1209;
			if (BindCustom.<>f__mg$cache4B9 == null)
			{
				BindCustom.<>f__mg$cache4B9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_Misc_CLZF.reg);
			}
			array[num1210] = BindCustom.<>f__mg$cache4B9;
			int num1211 = 1210;
			if (BindCustom.<>f__mg$cache4BA == null)
			{
				BindCustom.<>f__mg$cache4BA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TestUI.reg);
			}
			array[num1211] = BindCustom.<>f__mg$cache4BA;
			int num1212 = 1211;
			if (BindCustom.<>f__mg$cache4BB == null)
			{
				BindCustom.<>f__mg$cache4BB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TestUIController.reg);
			}
			array[num1212] = BindCustom.<>f__mg$cache4BB;
			int num1213 = 1212;
			if (BindCustom.<>f__mg$cache4BC == null)
			{
				BindCustom.<>f__mg$cache4BC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TestListItemUIController.reg);
			}
			array[num1213] = BindCustom.<>f__mg$cache4BC;
			int num1214 = 1213;
			if (BindCustom.<>f__mg$cache4BD == null)
			{
				BindCustom.<>f__mg$cache4BD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TestUITask.reg);
			}
			array[num1214] = BindCustom.<>f__mg$cache4BD;
			int num1215 = 1214;
			if (BindCustom.<>f__mg$cache4BE == null)
			{
				BindCustom.<>f__mg$cache4BE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ThearchyLevelAttackNetTask.reg);
			}
			array[num1215] = BindCustom.<>f__mg$cache4BE;
			int num1216 = 1215;
			if (BindCustom.<>f__mg$cache4BF == null)
			{
				BindCustom.<>f__mg$cache4BF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ThearchyLevelBattleFinishedNetTask.reg);
			}
			array[num1216] = BindCustom.<>f__mg$cache4BF;
			int num1217 = 1216;
			if (BindCustom.<>f__mg$cache4C0 == null)
			{
				BindCustom.<>f__mg$cache4C0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ThearchyUIController.reg);
			}
			array[num1217] = BindCustom.<>f__mg$cache4C0;
			int num1218 = 1217;
			if (BindCustom.<>f__mg$cache4C1 == null)
			{
				BindCustom.<>f__mg$cache4C1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ThearchyLevelListItemUIController.reg);
			}
			array[num1218] = BindCustom.<>f__mg$cache4C1;
			int num1219 = 1218;
			if (BindCustom.<>f__mg$cache4C2 == null)
			{
				BindCustom.<>f__mg$cache4C2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ThearchyUITask.reg);
			}
			array[num1219] = BindCustom.<>f__mg$cache4C2;
			int num1220 = 1219;
			if (BindCustom.<>f__mg$cache4C3 == null)
			{
				BindCustom.<>f__mg$cache4C3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TreasureLevelUINetTask.reg);
			}
			array[num1220] = BindCustom.<>f__mg$cache4C3;
			int num1221 = 1220;
			if (BindCustom.<>f__mg$cache4C4 == null)
			{
				BindCustom.<>f__mg$cache4C4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TreasureLevelBattleFinishedNetTask.reg);
			}
			array[num1221] = BindCustom.<>f__mg$cache4C4;
			int num1222 = 1221;
			if (BindCustom.<>f__mg$cache4C5 == null)
			{
				BindCustom.<>f__mg$cache4C5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TreasureMapUIController.reg);
			}
			array[num1222] = BindCustom.<>f__mg$cache4C5;
			int num1223 = 1222;
			if (BindCustom.<>f__mg$cache4C6 == null)
			{
				BindCustom.<>f__mg$cache4C6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.reg);
			}
			array[num1223] = BindCustom.<>f__mg$cache4C6;
			int num1224 = 1223;
			if (BindCustom.<>f__mg$cache4C7 == null)
			{
				BindCustom.<>f__mg$cache4C7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TreasureLevelListItemUIController.reg);
			}
			array[num1224] = BindCustom.<>f__mg$cache4C7;
			int num1225 = 1224;
			if (BindCustom.<>f__mg$cache4C8 == null)
			{
				BindCustom.<>f__mg$cache4C8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_TreasureMapUITask.reg);
			}
			array[num1225] = BindCustom.<>f__mg$cache4C8;
			int num1226 = 1225;
			if (BindCustom.<>f__mg$cache4C9 == null)
			{
				BindCustom.<>f__mg$cache4C9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UIAsset.reg);
			}
			array[num1226] = BindCustom.<>f__mg$cache4C9;
			int num1227 = 1226;
			if (BindCustom.<>f__mg$cache4CA == null)
			{
				BindCustom.<>f__mg$cache4CA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_SpineCharAnim.reg);
			}
			array[num1227] = BindCustom.<>f__mg$cache4CA;
			int num1228 = 1227;
			if (BindCustom.<>f__mg$cache4CB == null)
			{
				BindCustom.<>f__mg$cache4CB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_ActorFx.reg);
			}
			array[num1228] = BindCustom.<>f__mg$cache4CB;
			int num1229 = 1228;
			if (BindCustom.<>f__mg$cache4CC == null)
			{
				BindCustom.<>f__mg$cache4CC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UIUtility.reg);
			}
			array[num1229] = BindCustom.<>f__mg$cache4CC;
			int num1230 = 1229;
			if (BindCustom.<>f__mg$cache4CD == null)
			{
				BindCustom.<>f__mg$cache4CD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedUIController.reg);
			}
			array[num1230] = BindCustom.<>f__mg$cache4CD;
			int num1231 = 1230;
			if (BindCustom.<>f__mg$cache4CE == null)
			{
				BindCustom.<>f__mg$cache4CE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_HeroPhantomButton.reg);
			}
			array[num1231] = BindCustom.<>f__mg$cache4CE;
			int num1232 = 1231;
			if (BindCustom.<>f__mg$cache4CF == null)
			{
				BindCustom.<>f__mg$cache4CF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_CooperateBattleButton.reg);
			}
			array[num1232] = BindCustom.<>f__mg$cache4CF;
			int num1233 = 1232;
			if (BindCustom.<>f__mg$cache4D0 == null)
			{
				BindCustom.<>f__mg$cache4D0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedScoreButton.reg);
			}
			array[num1233] = BindCustom.<>f__mg$cache4D0;
			int num1234 = 1233;
			if (BindCustom.<>f__mg$cache4D1 == null)
			{
				BindCustom.<>f__mg$cache4D1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedUITask.reg);
			}
			array[num1234] = BindCustom.<>f__mg$cache4D1;
			int num1235 = 1234;
			if (BindCustom.<>f__mg$cache4D2 == null)
			{
				BindCustom.<>f__mg$cache4D2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelAttackNetTask.reg);
			}
			array[num1235] = BindCustom.<>f__mg$cache4D2;
			int num1236 = 1235;
			if (BindCustom.<>f__mg$cache4D3 == null)
			{
				BindCustom.<>f__mg$cache4D3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelBattleFinishedNetTask.reg);
			}
			array[num1236] = BindCustom.<>f__mg$cache4D3;
			int num1237 = 1236;
			if (BindCustom.<>f__mg$cache4D4 == null)
			{
				BindCustom.<>f__mg$cache4D4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelAttackNetTask.reg);
			}
			array[num1237] = BindCustom.<>f__mg$cache4D4;
			int num1238 = 1237;
			if (BindCustom.<>f__mg$cache4D5 == null)
			{
				BindCustom.<>f__mg$cache4D5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelBattleFinishedNetTask.reg);
			}
			array[num1238] = BindCustom.<>f__mg$cache4D5;
			int num1239 = 1238;
			if (BindCustom.<>f__mg$cache4D6 == null)
			{
				BindCustom.<>f__mg$cache4D6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedScoreUIController.reg);
			}
			array[num1239] = BindCustom.<>f__mg$cache4D6;
			int num1240 = 1239;
			if (BindCustom.<>f__mg$cache4D7 == null)
			{
				BindCustom.<>f__mg$cache4D7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedScoreLevelListItemUIController.reg);
			}
			array[num1240] = BindCustom.<>f__mg$cache4D7;
			int num1241 = 1240;
			if (BindCustom.<>f__mg$cache4D8 == null)
			{
				BindCustom.<>f__mg$cache4D8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.reg);
			}
			array[num1241] = BindCustom.<>f__mg$cache4D8;
			int num1242 = 1241;
			if (BindCustom.<>f__mg$cache4D9 == null)
			{
				BindCustom.<>f__mg$cache4D9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.reg);
			}
			array[num1242] = BindCustom.<>f__mg$cache4D9;
			int num1243 = 1242;
			if (BindCustom.<>f__mg$cache4DA == null)
			{
				BindCustom.<>f__mg$cache4DA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UnchartedScoreUITask.reg);
			}
			array[num1243] = BindCustom.<>f__mg$cache4DA;
			int num1244 = 1243;
			if (BindCustom.<>f__mg$cache4DB == null)
			{
				BindCustom.<>f__mg$cache4DB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UserGuideDialogUITask.reg);
			}
			array[num1244] = BindCustom.<>f__mg$cache4DB;
			int num1245 = 1244;
			if (BindCustom.<>f__mg$cache4DC == null)
			{
				BindCustom.<>f__mg$cache4DC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UserGuideDialogUIController.reg);
			}
			array[num1245] = BindCustom.<>f__mg$cache4DC;
			int num1246 = 1245;
			if (BindCustom.<>f__mg$cache4DD == null)
			{
				BindCustom.<>f__mg$cache4DD = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UserGuideDialogBoxUIController.reg);
			}
			array[num1246] = BindCustom.<>f__mg$cache4DD;
			int num1247 = 1246;
			if (BindCustom.<>f__mg$cache4DE == null)
			{
				BindCustom.<>f__mg$cache4DE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UserGuideSetNetTask.reg);
			}
			array[num1247] = BindCustom.<>f__mg$cache4DE;
			int num1248 = 1247;
			if (BindCustom.<>f__mg$cache4DF == null)
			{
				BindCustom.<>f__mg$cache4DF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UserGuideUIController.reg);
			}
			array[num1248] = BindCustom.<>f__mg$cache4DF;
			int num1249 = 1248;
			if (BindCustom.<>f__mg$cache4E0 == null)
			{
				BindCustom.<>f__mg$cache4E0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_UserGuideUITask.reg);
			}
			array[num1249] = BindCustom.<>f__mg$cache4E0;
			int num1250 = 1249;
			if (BindCustom.<>f__mg$cache4E1 == null)
			{
				BindCustom.<>f__mg$cache4E1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.reg);
			}
			array[num1250] = BindCustom.<>f__mg$cache4E1;
			int num1251 = 1250;
			if (BindCustom.<>f__mg$cache4E2 == null)
			{
				BindCustom.<>f__mg$cache4E2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BuyEnergyUITask.reg);
			}
			array[num1251] = BindCustom.<>f__mg$cache4E2;
			int num1252 = 1251;
			if (BindCustom.<>f__mg$cache4E3 == null)
			{
				BindCustom.<>f__mg$cache4E3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EnergyStatusUIController.reg);
			}
			array[num1252] = BindCustom.<>f__mg$cache4E3;
			int num1253 = 1252;
			if (BindCustom.<>f__mg$cache4E4 == null)
			{
				BindCustom.<>f__mg$cache4E4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_EnergyStatusUITask.reg);
			}
			array[num1253] = BindCustom.<>f__mg$cache4E4;
			int num1254 = 1253;
			if (BindCustom.<>f__mg$cache4E5 == null)
			{
				BindCustom.<>f__mg$cache4E5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldEventActorUIController.reg);
			}
			array[num1254] = BindCustom.<>f__mg$cache4E5;
			int num1255 = 1254;
			if (BindCustom.<>f__mg$cache4E6 == null)
			{
				BindCustom.<>f__mg$cache4E6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.reg);
			}
			array[num1255] = BindCustom.<>f__mg$cache4E6;
			int num1256 = 1255;
			if (BindCustom.<>f__mg$cache4E7 == null)
			{
				BindCustom.<>f__mg$cache4E7 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldEventMissionUITask.reg);
			}
			array[num1256] = BindCustom.<>f__mg$cache4E7;
			int num1257 = 1256;
			if (BindCustom.<>f__mg$cache4E8 == null)
			{
				BindCustom.<>f__mg$cache4E8 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldMapUIController.reg);
			}
			array[num1257] = BindCustom.<>f__mg$cache4E8;
			int num1258 = 1257;
			if (BindCustom.<>f__mg$cache4E9 == null)
			{
				BindCustom.<>f__mg$cache4E9 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldMonthCardItemUIController.reg);
			}
			array[num1258] = BindCustom.<>f__mg$cache4E9;
			int num1259 = 1258;
			if (BindCustom.<>f__mg$cache4EA == null)
			{
				BindCustom.<>f__mg$cache4EA = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_GmCommandNetTask.reg);
			}
			array[num1259] = BindCustom.<>f__mg$cache4EA;
			int num1260 = 1259;
			if (BindCustom.<>f__mg$cache4EB == null)
			{
				BindCustom.<>f__mg$cache4EB = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LevelWayPointMoveNetTask.reg);
			}
			array[num1260] = BindCustom.<>f__mg$cache4EB;
			int num1261 = 1260;
			if (BindCustom.<>f__mg$cache4EC == null)
			{
				BindCustom.<>f__mg$cache4EC = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LevelScenarioHandleNetTask.reg);
			}
			array[num1261] = BindCustom.<>f__mg$cache4EC;
			int num1262 = 1261;
			if (BindCustom.<>f__mg$cache4ED == null)
			{
				BindCustom.<>f__mg$cache4ED = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_LevelWayPointBattleFinishNetTask.reg);
			}
			array[num1262] = BindCustom.<>f__mg$cache4ED;
			int num1263 = 1262;
			if (BindCustom.<>f__mg$cache4EE == null)
			{
				BindCustom.<>f__mg$cache4EE = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_BuyEnergyNetTask.reg);
			}
			array[num1263] = BindCustom.<>f__mg$cache4EE;
			int num1264 = 1263;
			if (BindCustom.<>f__mg$cache4EF == null)
			{
				BindCustom.<>f__mg$cache4EF = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldPlayerActorUIController.reg);
			}
			array[num1264] = BindCustom.<>f__mg$cache4EF;
			int num1265 = 1264;
			if (BindCustom.<>f__mg$cache4F0 == null)
			{
				BindCustom.<>f__mg$cache4F0 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldScenarioUIController.reg);
			}
			array[num1265] = BindCustom.<>f__mg$cache4F0;
			int num1266 = 1265;
			if (BindCustom.<>f__mg$cache4F1 == null)
			{
				BindCustom.<>f__mg$cache4F1 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldUIController.reg);
			}
			array[num1266] = BindCustom.<>f__mg$cache4F1;
			int num1267 = 1266;
			if (BindCustom.<>f__mg$cache4F2 == null)
			{
				BindCustom.<>f__mg$cache4F2 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldEventListItemUIController.reg);
			}
			array[num1267] = BindCustom.<>f__mg$cache4F2;
			int num1268 = 1267;
			if (BindCustom.<>f__mg$cache4F3 == null)
			{
				BindCustom.<>f__mg$cache4F3 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_PastScenarioListItemUIController.reg);
			}
			array[num1268] = BindCustom.<>f__mg$cache4F3;
			int num1269 = 1268;
			if (BindCustom.<>f__mg$cache4F4 == null)
			{
				BindCustom.<>f__mg$cache4F4 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldUITask.reg);
			}
			array[num1269] = BindCustom.<>f__mg$cache4F4;
			int num1270 = 1269;
			if (BindCustom.<>f__mg$cache4F5 == null)
			{
				BindCustom.<>f__mg$cache4F5 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_NeedGoods.reg);
			}
			array[num1270] = BindCustom.<>f__mg$cache4F5;
			int num1271 = 1270;
			if (BindCustom.<>f__mg$cache4F6 == null)
			{
				BindCustom.<>f__mg$cache4F6 = new Action<IntPtr>(Lua_BlackJack_ProjectL_UI_WorldWaypointUIController.reg);
			}
			array[num1271] = BindCustom.<>f__mg$cache4F6;
			int num1272 = 1271;
			if (BindCustom.<>f__mg$cache4F7 == null)
			{
				BindCustom.<>f__mg$cache4F7 = new Action<IntPtr>(Lua_PD_SDK_PDSDK.reg);
			}
			array[num1272] = BindCustom.<>f__mg$cache4F7;
			int num1273 = 1272;
			if (BindCustom.<>f__mg$cache4F8 == null)
			{
				BindCustom.<>f__mg$cache4F8 = new Action<IntPtr>(Lua_PD_SDK_LoginSuccessMsg.reg);
			}
			array[num1273] = BindCustom.<>f__mg$cache4F8;
			int num1274 = 1273;
			if (BindCustom.<>f__mg$cache4F9 == null)
			{
				BindCustom.<>f__mg$cache4F9 = new Action<IntPtr>(Lua_BlackJack_ProjectLBasic_DefaultServerAddress.reg);
			}
			array[num1274] = BindCustom.<>f__mg$cache4F9;
			int num1275 = 1274;
			if (BindCustom.<>f__mg$cache4FA == null)
			{
				BindCustom.<>f__mg$cache4FA = new Action<IntPtr>(Lua_BlackJack_ProjectLBasic_DialogBox.reg);
			}
			array[num1275] = BindCustom.<>f__mg$cache4FA;
			int num1276 = 1275;
			if (BindCustom.<>f__mg$cache4FB == null)
			{
				BindCustom.<>f__mg$cache4FB = new Action<IntPtr>(Lua_BlackJack_ProjectLBasic_ShowHideEvent.reg);
			}
			array[num1276] = BindCustom.<>f__mg$cache4FB;
			int num1277 = 1276;
			if (BindCustom.<>f__mg$cache4FC == null)
			{
				BindCustom.<>f__mg$cache4FC = new Action<IntPtr>(Lua_BlackJack_ProjectLBasic_StringTable.reg);
			}
			array[num1277] = BindCustom.<>f__mg$cache4FC;
			int num1278 = 1277;
			if (BindCustom.<>f__mg$cache4FD == null)
			{
				BindCustom.<>f__mg$cache4FD = new Action<IntPtr>(Lua_BlackJack_ProjectLBasic_Utility.reg);
			}
			array[num1278] = BindCustom.<>f__mg$cache4FD;
			int num1279 = 1278;
			if (BindCustom.<>f__mg$cache4FE == null)
			{
				BindCustom.<>f__mg$cache4FE = new Action<IntPtr>(Lua_System_Collections_Generic_List_1_int.reg);
			}
			array[num1279] = BindCustom.<>f__mg$cache4FE;
			int num1280 = 1279;
			if (BindCustom.<>f__mg$cache4FF == null)
			{
				BindCustom.<>f__mg$cache4FF = new Action<IntPtr>(Lua_System_Collections_Generic_List_1_string.reg);
			}
			array[num1280] = BindCustom.<>f__mg$cache4FF;
			int num1281 = 1280;
			if (BindCustom.<>f__mg$cache500 == null)
			{
				BindCustom.<>f__mg$cache500 = new Action<IntPtr>(Lua_System_Collections_Generic_Dictionary_2_int_string.reg);
			}
			array[num1281] = BindCustom.<>f__mg$cache500;
			int num1282 = 1281;
			if (BindCustom.<>f__mg$cache501 == null)
			{
				BindCustom.<>f__mg$cache501 = new Action<IntPtr>(Lua_System_String.reg);
			}
			array[num1282] = BindCustom.<>f__mg$cache501;
			int num1283 = 1282;
			if (BindCustom.<>f__mg$cache502 == null)
			{
				BindCustom.<>f__mg$cache502 = new Action<IntPtr>(Lua_System_TimeSpan.reg);
			}
			array[num1283] = BindCustom.<>f__mg$cache502;
			int num1284 = 1283;
			if (BindCustom.<>f__mg$cache503 == null)
			{
				BindCustom.<>f__mg$cache503 = new Action<IntPtr>(Lua_System_DateTime.reg);
			}
			array[num1284] = BindCustom.<>f__mg$cache503;
			return array;
		}

		// Token: 0x0400BD35 RID: 48437
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache0;

		// Token: 0x0400BD36 RID: 48438
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1;

		// Token: 0x0400BD37 RID: 48439
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2;

		// Token: 0x0400BD38 RID: 48440
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3;

		// Token: 0x0400BD39 RID: 48441
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4;

		// Token: 0x0400BD3A RID: 48442
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5;

		// Token: 0x0400BD3B RID: 48443
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6;

		// Token: 0x0400BD3C RID: 48444
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7;

		// Token: 0x0400BD3D RID: 48445
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8;

		// Token: 0x0400BD3E RID: 48446
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9;

		// Token: 0x0400BD3F RID: 48447
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA;

		// Token: 0x0400BD40 RID: 48448
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB;

		// Token: 0x0400BD41 RID: 48449
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC;

		// Token: 0x0400BD42 RID: 48450
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD;

		// Token: 0x0400BD43 RID: 48451
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE;

		// Token: 0x0400BD44 RID: 48452
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF;

		// Token: 0x0400BD45 RID: 48453
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10;

		// Token: 0x0400BD46 RID: 48454
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11;

		// Token: 0x0400BD47 RID: 48455
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12;

		// Token: 0x0400BD48 RID: 48456
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13;

		// Token: 0x0400BD49 RID: 48457
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14;

		// Token: 0x0400BD4A RID: 48458
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15;

		// Token: 0x0400BD4B RID: 48459
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16;

		// Token: 0x0400BD4C RID: 48460
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17;

		// Token: 0x0400BD4D RID: 48461
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18;

		// Token: 0x0400BD4E RID: 48462
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19;

		// Token: 0x0400BD4F RID: 48463
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A;

		// Token: 0x0400BD50 RID: 48464
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B;

		// Token: 0x0400BD51 RID: 48465
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C;

		// Token: 0x0400BD52 RID: 48466
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D;

		// Token: 0x0400BD53 RID: 48467
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E;

		// Token: 0x0400BD54 RID: 48468
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F;

		// Token: 0x0400BD55 RID: 48469
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20;

		// Token: 0x0400BD56 RID: 48470
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21;

		// Token: 0x0400BD57 RID: 48471
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22;

		// Token: 0x0400BD58 RID: 48472
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23;

		// Token: 0x0400BD59 RID: 48473
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24;

		// Token: 0x0400BD5A RID: 48474
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25;

		// Token: 0x0400BD5B RID: 48475
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26;

		// Token: 0x0400BD5C RID: 48476
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache27;

		// Token: 0x0400BD5D RID: 48477
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache28;

		// Token: 0x0400BD5E RID: 48478
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache29;

		// Token: 0x0400BD5F RID: 48479
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A;

		// Token: 0x0400BD60 RID: 48480
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B;

		// Token: 0x0400BD61 RID: 48481
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C;

		// Token: 0x0400BD62 RID: 48482
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D;

		// Token: 0x0400BD63 RID: 48483
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E;

		// Token: 0x0400BD64 RID: 48484
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F;

		// Token: 0x0400BD65 RID: 48485
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache30;

		// Token: 0x0400BD66 RID: 48486
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache31;

		// Token: 0x0400BD67 RID: 48487
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache32;

		// Token: 0x0400BD68 RID: 48488
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache33;

		// Token: 0x0400BD69 RID: 48489
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache34;

		// Token: 0x0400BD6A RID: 48490
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache35;

		// Token: 0x0400BD6B RID: 48491
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache36;

		// Token: 0x0400BD6C RID: 48492
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache37;

		// Token: 0x0400BD6D RID: 48493
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache38;

		// Token: 0x0400BD6E RID: 48494
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache39;

		// Token: 0x0400BD6F RID: 48495
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A;

		// Token: 0x0400BD70 RID: 48496
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B;

		// Token: 0x0400BD71 RID: 48497
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C;

		// Token: 0x0400BD72 RID: 48498
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D;

		// Token: 0x0400BD73 RID: 48499
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E;

		// Token: 0x0400BD74 RID: 48500
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F;

		// Token: 0x0400BD75 RID: 48501
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache40;

		// Token: 0x0400BD76 RID: 48502
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache41;

		// Token: 0x0400BD77 RID: 48503
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache42;

		// Token: 0x0400BD78 RID: 48504
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache43;

		// Token: 0x0400BD79 RID: 48505
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache44;

		// Token: 0x0400BD7A RID: 48506
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache45;

		// Token: 0x0400BD7B RID: 48507
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache46;

		// Token: 0x0400BD7C RID: 48508
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache47;

		// Token: 0x0400BD7D RID: 48509
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache48;

		// Token: 0x0400BD7E RID: 48510
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache49;

		// Token: 0x0400BD7F RID: 48511
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A;

		// Token: 0x0400BD80 RID: 48512
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B;

		// Token: 0x0400BD81 RID: 48513
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C;

		// Token: 0x0400BD82 RID: 48514
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D;

		// Token: 0x0400BD83 RID: 48515
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E;

		// Token: 0x0400BD84 RID: 48516
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F;

		// Token: 0x0400BD85 RID: 48517
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache50;

		// Token: 0x0400BD86 RID: 48518
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache51;

		// Token: 0x0400BD87 RID: 48519
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache52;

		// Token: 0x0400BD88 RID: 48520
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache53;

		// Token: 0x0400BD89 RID: 48521
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache54;

		// Token: 0x0400BD8A RID: 48522
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache55;

		// Token: 0x0400BD8B RID: 48523
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache56;

		// Token: 0x0400BD8C RID: 48524
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache57;

		// Token: 0x0400BD8D RID: 48525
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache58;

		// Token: 0x0400BD8E RID: 48526
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache59;

		// Token: 0x0400BD8F RID: 48527
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5A;

		// Token: 0x0400BD90 RID: 48528
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5B;

		// Token: 0x0400BD91 RID: 48529
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5C;

		// Token: 0x0400BD92 RID: 48530
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5D;

		// Token: 0x0400BD93 RID: 48531
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5E;

		// Token: 0x0400BD94 RID: 48532
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache5F;

		// Token: 0x0400BD95 RID: 48533
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache60;

		// Token: 0x0400BD96 RID: 48534
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache61;

		// Token: 0x0400BD97 RID: 48535
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache62;

		// Token: 0x0400BD98 RID: 48536
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache63;

		// Token: 0x0400BD99 RID: 48537
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache64;

		// Token: 0x0400BD9A RID: 48538
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache65;

		// Token: 0x0400BD9B RID: 48539
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache66;

		// Token: 0x0400BD9C RID: 48540
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache67;

		// Token: 0x0400BD9D RID: 48541
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache68;

		// Token: 0x0400BD9E RID: 48542
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache69;

		// Token: 0x0400BD9F RID: 48543
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6A;

		// Token: 0x0400BDA0 RID: 48544
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6B;

		// Token: 0x0400BDA1 RID: 48545
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6C;

		// Token: 0x0400BDA2 RID: 48546
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6D;

		// Token: 0x0400BDA3 RID: 48547
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6E;

		// Token: 0x0400BDA4 RID: 48548
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache6F;

		// Token: 0x0400BDA5 RID: 48549
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache70;

		// Token: 0x0400BDA6 RID: 48550
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache71;

		// Token: 0x0400BDA7 RID: 48551
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache72;

		// Token: 0x0400BDA8 RID: 48552
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache73;

		// Token: 0x0400BDA9 RID: 48553
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache74;

		// Token: 0x0400BDAA RID: 48554
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache75;

		// Token: 0x0400BDAB RID: 48555
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache76;

		// Token: 0x0400BDAC RID: 48556
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache77;

		// Token: 0x0400BDAD RID: 48557
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache78;

		// Token: 0x0400BDAE RID: 48558
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache79;

		// Token: 0x0400BDAF RID: 48559
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7A;

		// Token: 0x0400BDB0 RID: 48560
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7B;

		// Token: 0x0400BDB1 RID: 48561
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7C;

		// Token: 0x0400BDB2 RID: 48562
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7D;

		// Token: 0x0400BDB3 RID: 48563
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7E;

		// Token: 0x0400BDB4 RID: 48564
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache7F;

		// Token: 0x0400BDB5 RID: 48565
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache80;

		// Token: 0x0400BDB6 RID: 48566
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache81;

		// Token: 0x0400BDB7 RID: 48567
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache82;

		// Token: 0x0400BDB8 RID: 48568
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache83;

		// Token: 0x0400BDB9 RID: 48569
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache84;

		// Token: 0x0400BDBA RID: 48570
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache85;

		// Token: 0x0400BDBB RID: 48571
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache86;

		// Token: 0x0400BDBC RID: 48572
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache87;

		// Token: 0x0400BDBD RID: 48573
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache88;

		// Token: 0x0400BDBE RID: 48574
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache89;

		// Token: 0x0400BDBF RID: 48575
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8A;

		// Token: 0x0400BDC0 RID: 48576
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8B;

		// Token: 0x0400BDC1 RID: 48577
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8C;

		// Token: 0x0400BDC2 RID: 48578
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8D;

		// Token: 0x0400BDC3 RID: 48579
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8E;

		// Token: 0x0400BDC4 RID: 48580
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache8F;

		// Token: 0x0400BDC5 RID: 48581
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache90;

		// Token: 0x0400BDC6 RID: 48582
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache91;

		// Token: 0x0400BDC7 RID: 48583
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache92;

		// Token: 0x0400BDC8 RID: 48584
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache93;

		// Token: 0x0400BDC9 RID: 48585
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache94;

		// Token: 0x0400BDCA RID: 48586
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache95;

		// Token: 0x0400BDCB RID: 48587
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache96;

		// Token: 0x0400BDCC RID: 48588
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache97;

		// Token: 0x0400BDCD RID: 48589
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache98;

		// Token: 0x0400BDCE RID: 48590
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache99;

		// Token: 0x0400BDCF RID: 48591
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9A;

		// Token: 0x0400BDD0 RID: 48592
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9B;

		// Token: 0x0400BDD1 RID: 48593
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9C;

		// Token: 0x0400BDD2 RID: 48594
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9D;

		// Token: 0x0400BDD3 RID: 48595
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9E;

		// Token: 0x0400BDD4 RID: 48596
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache9F;

		// Token: 0x0400BDD5 RID: 48597
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA0;

		// Token: 0x0400BDD6 RID: 48598
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA1;

		// Token: 0x0400BDD7 RID: 48599
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA2;

		// Token: 0x0400BDD8 RID: 48600
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA3;

		// Token: 0x0400BDD9 RID: 48601
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA4;

		// Token: 0x0400BDDA RID: 48602
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA5;

		// Token: 0x0400BDDB RID: 48603
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA6;

		// Token: 0x0400BDDC RID: 48604
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA7;

		// Token: 0x0400BDDD RID: 48605
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA8;

		// Token: 0x0400BDDE RID: 48606
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheA9;

		// Token: 0x0400BDDF RID: 48607
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAA;

		// Token: 0x0400BDE0 RID: 48608
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAB;

		// Token: 0x0400BDE1 RID: 48609
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAC;

		// Token: 0x0400BDE2 RID: 48610
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAD;

		// Token: 0x0400BDE3 RID: 48611
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAE;

		// Token: 0x0400BDE4 RID: 48612
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheAF;

		// Token: 0x0400BDE5 RID: 48613
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB0;

		// Token: 0x0400BDE6 RID: 48614
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB1;

		// Token: 0x0400BDE7 RID: 48615
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB2;

		// Token: 0x0400BDE8 RID: 48616
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB3;

		// Token: 0x0400BDE9 RID: 48617
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB4;

		// Token: 0x0400BDEA RID: 48618
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB5;

		// Token: 0x0400BDEB RID: 48619
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB6;

		// Token: 0x0400BDEC RID: 48620
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB7;

		// Token: 0x0400BDED RID: 48621
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB8;

		// Token: 0x0400BDEE RID: 48622
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheB9;

		// Token: 0x0400BDEF RID: 48623
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBA;

		// Token: 0x0400BDF0 RID: 48624
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBB;

		// Token: 0x0400BDF1 RID: 48625
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBC;

		// Token: 0x0400BDF2 RID: 48626
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBD;

		// Token: 0x0400BDF3 RID: 48627
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBE;

		// Token: 0x0400BDF4 RID: 48628
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheBF;

		// Token: 0x0400BDF5 RID: 48629
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC0;

		// Token: 0x0400BDF6 RID: 48630
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC1;

		// Token: 0x0400BDF7 RID: 48631
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC2;

		// Token: 0x0400BDF8 RID: 48632
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC3;

		// Token: 0x0400BDF9 RID: 48633
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC4;

		// Token: 0x0400BDFA RID: 48634
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC5;

		// Token: 0x0400BDFB RID: 48635
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC6;

		// Token: 0x0400BDFC RID: 48636
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC7;

		// Token: 0x0400BDFD RID: 48637
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC8;

		// Token: 0x0400BDFE RID: 48638
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheC9;

		// Token: 0x0400BDFF RID: 48639
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCA;

		// Token: 0x0400BE00 RID: 48640
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCB;

		// Token: 0x0400BE01 RID: 48641
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCC;

		// Token: 0x0400BE02 RID: 48642
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCD;

		// Token: 0x0400BE03 RID: 48643
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCE;

		// Token: 0x0400BE04 RID: 48644
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheCF;

		// Token: 0x0400BE05 RID: 48645
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD0;

		// Token: 0x0400BE06 RID: 48646
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD1;

		// Token: 0x0400BE07 RID: 48647
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD2;

		// Token: 0x0400BE08 RID: 48648
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD3;

		// Token: 0x0400BE09 RID: 48649
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD4;

		// Token: 0x0400BE0A RID: 48650
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD5;

		// Token: 0x0400BE0B RID: 48651
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD6;

		// Token: 0x0400BE0C RID: 48652
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD7;

		// Token: 0x0400BE0D RID: 48653
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD8;

		// Token: 0x0400BE0E RID: 48654
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheD9;

		// Token: 0x0400BE0F RID: 48655
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDA;

		// Token: 0x0400BE10 RID: 48656
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDB;

		// Token: 0x0400BE11 RID: 48657
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDC;

		// Token: 0x0400BE12 RID: 48658
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDD;

		// Token: 0x0400BE13 RID: 48659
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDE;

		// Token: 0x0400BE14 RID: 48660
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheDF;

		// Token: 0x0400BE15 RID: 48661
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE0;

		// Token: 0x0400BE16 RID: 48662
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE1;

		// Token: 0x0400BE17 RID: 48663
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE2;

		// Token: 0x0400BE18 RID: 48664
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE3;

		// Token: 0x0400BE19 RID: 48665
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE4;

		// Token: 0x0400BE1A RID: 48666
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE5;

		// Token: 0x0400BE1B RID: 48667
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE6;

		// Token: 0x0400BE1C RID: 48668
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE7;

		// Token: 0x0400BE1D RID: 48669
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE8;

		// Token: 0x0400BE1E RID: 48670
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheE9;

		// Token: 0x0400BE1F RID: 48671
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheEA;

		// Token: 0x0400BE20 RID: 48672
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheEB;

		// Token: 0x0400BE21 RID: 48673
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheEC;

		// Token: 0x0400BE22 RID: 48674
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheED;

		// Token: 0x0400BE23 RID: 48675
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheEE;

		// Token: 0x0400BE24 RID: 48676
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheEF;

		// Token: 0x0400BE25 RID: 48677
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF0;

		// Token: 0x0400BE26 RID: 48678
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF1;

		// Token: 0x0400BE27 RID: 48679
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF2;

		// Token: 0x0400BE28 RID: 48680
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF3;

		// Token: 0x0400BE29 RID: 48681
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF4;

		// Token: 0x0400BE2A RID: 48682
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF5;

		// Token: 0x0400BE2B RID: 48683
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF6;

		// Token: 0x0400BE2C RID: 48684
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF7;

		// Token: 0x0400BE2D RID: 48685
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF8;

		// Token: 0x0400BE2E RID: 48686
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheF9;

		// Token: 0x0400BE2F RID: 48687
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFA;

		// Token: 0x0400BE30 RID: 48688
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFB;

		// Token: 0x0400BE31 RID: 48689
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFC;

		// Token: 0x0400BE32 RID: 48690
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFD;

		// Token: 0x0400BE33 RID: 48691
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFE;

		// Token: 0x0400BE34 RID: 48692
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cacheFF;

		// Token: 0x0400BE35 RID: 48693
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache100;

		// Token: 0x0400BE36 RID: 48694
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache101;

		// Token: 0x0400BE37 RID: 48695
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache102;

		// Token: 0x0400BE38 RID: 48696
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache103;

		// Token: 0x0400BE39 RID: 48697
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache104;

		// Token: 0x0400BE3A RID: 48698
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache105;

		// Token: 0x0400BE3B RID: 48699
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache106;

		// Token: 0x0400BE3C RID: 48700
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache107;

		// Token: 0x0400BE3D RID: 48701
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache108;

		// Token: 0x0400BE3E RID: 48702
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache109;

		// Token: 0x0400BE3F RID: 48703
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10A;

		// Token: 0x0400BE40 RID: 48704
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10B;

		// Token: 0x0400BE41 RID: 48705
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10C;

		// Token: 0x0400BE42 RID: 48706
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10D;

		// Token: 0x0400BE43 RID: 48707
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10E;

		// Token: 0x0400BE44 RID: 48708
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache10F;

		// Token: 0x0400BE45 RID: 48709
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache110;

		// Token: 0x0400BE46 RID: 48710
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache111;

		// Token: 0x0400BE47 RID: 48711
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache112;

		// Token: 0x0400BE48 RID: 48712
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache113;

		// Token: 0x0400BE49 RID: 48713
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache114;

		// Token: 0x0400BE4A RID: 48714
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache115;

		// Token: 0x0400BE4B RID: 48715
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache116;

		// Token: 0x0400BE4C RID: 48716
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache117;

		// Token: 0x0400BE4D RID: 48717
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache118;

		// Token: 0x0400BE4E RID: 48718
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache119;

		// Token: 0x0400BE4F RID: 48719
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11A;

		// Token: 0x0400BE50 RID: 48720
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11B;

		// Token: 0x0400BE51 RID: 48721
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11C;

		// Token: 0x0400BE52 RID: 48722
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11D;

		// Token: 0x0400BE53 RID: 48723
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11E;

		// Token: 0x0400BE54 RID: 48724
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache11F;

		// Token: 0x0400BE55 RID: 48725
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache120;

		// Token: 0x0400BE56 RID: 48726
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache121;

		// Token: 0x0400BE57 RID: 48727
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache122;

		// Token: 0x0400BE58 RID: 48728
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache123;

		// Token: 0x0400BE59 RID: 48729
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache124;

		// Token: 0x0400BE5A RID: 48730
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache125;

		// Token: 0x0400BE5B RID: 48731
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache126;

		// Token: 0x0400BE5C RID: 48732
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache127;

		// Token: 0x0400BE5D RID: 48733
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache128;

		// Token: 0x0400BE5E RID: 48734
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache129;

		// Token: 0x0400BE5F RID: 48735
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12A;

		// Token: 0x0400BE60 RID: 48736
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12B;

		// Token: 0x0400BE61 RID: 48737
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12C;

		// Token: 0x0400BE62 RID: 48738
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12D;

		// Token: 0x0400BE63 RID: 48739
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12E;

		// Token: 0x0400BE64 RID: 48740
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache12F;

		// Token: 0x0400BE65 RID: 48741
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache130;

		// Token: 0x0400BE66 RID: 48742
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache131;

		// Token: 0x0400BE67 RID: 48743
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache132;

		// Token: 0x0400BE68 RID: 48744
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache133;

		// Token: 0x0400BE69 RID: 48745
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache134;

		// Token: 0x0400BE6A RID: 48746
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache135;

		// Token: 0x0400BE6B RID: 48747
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache136;

		// Token: 0x0400BE6C RID: 48748
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache137;

		// Token: 0x0400BE6D RID: 48749
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache138;

		// Token: 0x0400BE6E RID: 48750
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache139;

		// Token: 0x0400BE6F RID: 48751
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13A;

		// Token: 0x0400BE70 RID: 48752
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13B;

		// Token: 0x0400BE71 RID: 48753
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13C;

		// Token: 0x0400BE72 RID: 48754
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13D;

		// Token: 0x0400BE73 RID: 48755
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13E;

		// Token: 0x0400BE74 RID: 48756
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache13F;

		// Token: 0x0400BE75 RID: 48757
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache140;

		// Token: 0x0400BE76 RID: 48758
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache141;

		// Token: 0x0400BE77 RID: 48759
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache142;

		// Token: 0x0400BE78 RID: 48760
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache143;

		// Token: 0x0400BE79 RID: 48761
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache144;

		// Token: 0x0400BE7A RID: 48762
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache145;

		// Token: 0x0400BE7B RID: 48763
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache146;

		// Token: 0x0400BE7C RID: 48764
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache147;

		// Token: 0x0400BE7D RID: 48765
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache148;

		// Token: 0x0400BE7E RID: 48766
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache149;

		// Token: 0x0400BE7F RID: 48767
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14A;

		// Token: 0x0400BE80 RID: 48768
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14B;

		// Token: 0x0400BE81 RID: 48769
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14C;

		// Token: 0x0400BE82 RID: 48770
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14D;

		// Token: 0x0400BE83 RID: 48771
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14E;

		// Token: 0x0400BE84 RID: 48772
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache14F;

		// Token: 0x0400BE85 RID: 48773
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache150;

		// Token: 0x0400BE86 RID: 48774
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache151;

		// Token: 0x0400BE87 RID: 48775
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache152;

		// Token: 0x0400BE88 RID: 48776
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache153;

		// Token: 0x0400BE89 RID: 48777
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache154;

		// Token: 0x0400BE8A RID: 48778
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache155;

		// Token: 0x0400BE8B RID: 48779
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache156;

		// Token: 0x0400BE8C RID: 48780
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache157;

		// Token: 0x0400BE8D RID: 48781
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache158;

		// Token: 0x0400BE8E RID: 48782
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache159;

		// Token: 0x0400BE8F RID: 48783
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15A;

		// Token: 0x0400BE90 RID: 48784
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15B;

		// Token: 0x0400BE91 RID: 48785
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15C;

		// Token: 0x0400BE92 RID: 48786
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15D;

		// Token: 0x0400BE93 RID: 48787
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15E;

		// Token: 0x0400BE94 RID: 48788
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache15F;

		// Token: 0x0400BE95 RID: 48789
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache160;

		// Token: 0x0400BE96 RID: 48790
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache161;

		// Token: 0x0400BE97 RID: 48791
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache162;

		// Token: 0x0400BE98 RID: 48792
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache163;

		// Token: 0x0400BE99 RID: 48793
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache164;

		// Token: 0x0400BE9A RID: 48794
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache165;

		// Token: 0x0400BE9B RID: 48795
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache166;

		// Token: 0x0400BE9C RID: 48796
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache167;

		// Token: 0x0400BE9D RID: 48797
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache168;

		// Token: 0x0400BE9E RID: 48798
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache169;

		// Token: 0x0400BE9F RID: 48799
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16A;

		// Token: 0x0400BEA0 RID: 48800
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16B;

		// Token: 0x0400BEA1 RID: 48801
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16C;

		// Token: 0x0400BEA2 RID: 48802
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16D;

		// Token: 0x0400BEA3 RID: 48803
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16E;

		// Token: 0x0400BEA4 RID: 48804
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache16F;

		// Token: 0x0400BEA5 RID: 48805
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache170;

		// Token: 0x0400BEA6 RID: 48806
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache171;

		// Token: 0x0400BEA7 RID: 48807
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache172;

		// Token: 0x0400BEA8 RID: 48808
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache173;

		// Token: 0x0400BEA9 RID: 48809
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache174;

		// Token: 0x0400BEAA RID: 48810
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache175;

		// Token: 0x0400BEAB RID: 48811
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache176;

		// Token: 0x0400BEAC RID: 48812
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache177;

		// Token: 0x0400BEAD RID: 48813
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache178;

		// Token: 0x0400BEAE RID: 48814
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache179;

		// Token: 0x0400BEAF RID: 48815
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17A;

		// Token: 0x0400BEB0 RID: 48816
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17B;

		// Token: 0x0400BEB1 RID: 48817
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17C;

		// Token: 0x0400BEB2 RID: 48818
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17D;

		// Token: 0x0400BEB3 RID: 48819
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17E;

		// Token: 0x0400BEB4 RID: 48820
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache17F;

		// Token: 0x0400BEB5 RID: 48821
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache180;

		// Token: 0x0400BEB6 RID: 48822
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache181;

		// Token: 0x0400BEB7 RID: 48823
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache182;

		// Token: 0x0400BEB8 RID: 48824
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache183;

		// Token: 0x0400BEB9 RID: 48825
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache184;

		// Token: 0x0400BEBA RID: 48826
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache185;

		// Token: 0x0400BEBB RID: 48827
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache186;

		// Token: 0x0400BEBC RID: 48828
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache187;

		// Token: 0x0400BEBD RID: 48829
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache188;

		// Token: 0x0400BEBE RID: 48830
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache189;

		// Token: 0x0400BEBF RID: 48831
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18A;

		// Token: 0x0400BEC0 RID: 48832
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18B;

		// Token: 0x0400BEC1 RID: 48833
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18C;

		// Token: 0x0400BEC2 RID: 48834
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18D;

		// Token: 0x0400BEC3 RID: 48835
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18E;

		// Token: 0x0400BEC4 RID: 48836
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache18F;

		// Token: 0x0400BEC5 RID: 48837
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache190;

		// Token: 0x0400BEC6 RID: 48838
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache191;

		// Token: 0x0400BEC7 RID: 48839
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache192;

		// Token: 0x0400BEC8 RID: 48840
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache193;

		// Token: 0x0400BEC9 RID: 48841
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache194;

		// Token: 0x0400BECA RID: 48842
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache195;

		// Token: 0x0400BECB RID: 48843
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache196;

		// Token: 0x0400BECC RID: 48844
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache197;

		// Token: 0x0400BECD RID: 48845
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache198;

		// Token: 0x0400BECE RID: 48846
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache199;

		// Token: 0x0400BECF RID: 48847
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19A;

		// Token: 0x0400BED0 RID: 48848
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19B;

		// Token: 0x0400BED1 RID: 48849
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19C;

		// Token: 0x0400BED2 RID: 48850
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19D;

		// Token: 0x0400BED3 RID: 48851
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19E;

		// Token: 0x0400BED4 RID: 48852
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache19F;

		// Token: 0x0400BED5 RID: 48853
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A0;

		// Token: 0x0400BED6 RID: 48854
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A1;

		// Token: 0x0400BED7 RID: 48855
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A2;

		// Token: 0x0400BED8 RID: 48856
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A3;

		// Token: 0x0400BED9 RID: 48857
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A4;

		// Token: 0x0400BEDA RID: 48858
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A5;

		// Token: 0x0400BEDB RID: 48859
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A6;

		// Token: 0x0400BEDC RID: 48860
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A7;

		// Token: 0x0400BEDD RID: 48861
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A8;

		// Token: 0x0400BEDE RID: 48862
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1A9;

		// Token: 0x0400BEDF RID: 48863
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AA;

		// Token: 0x0400BEE0 RID: 48864
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AB;

		// Token: 0x0400BEE1 RID: 48865
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AC;

		// Token: 0x0400BEE2 RID: 48866
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AD;

		// Token: 0x0400BEE3 RID: 48867
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AE;

		// Token: 0x0400BEE4 RID: 48868
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1AF;

		// Token: 0x0400BEE5 RID: 48869
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B0;

		// Token: 0x0400BEE6 RID: 48870
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B1;

		// Token: 0x0400BEE7 RID: 48871
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B2;

		// Token: 0x0400BEE8 RID: 48872
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B3;

		// Token: 0x0400BEE9 RID: 48873
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B4;

		// Token: 0x0400BEEA RID: 48874
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B5;

		// Token: 0x0400BEEB RID: 48875
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B6;

		// Token: 0x0400BEEC RID: 48876
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B7;

		// Token: 0x0400BEED RID: 48877
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B8;

		// Token: 0x0400BEEE RID: 48878
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1B9;

		// Token: 0x0400BEEF RID: 48879
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BA;

		// Token: 0x0400BEF0 RID: 48880
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BB;

		// Token: 0x0400BEF1 RID: 48881
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BC;

		// Token: 0x0400BEF2 RID: 48882
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BD;

		// Token: 0x0400BEF3 RID: 48883
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BE;

		// Token: 0x0400BEF4 RID: 48884
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1BF;

		// Token: 0x0400BEF5 RID: 48885
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C0;

		// Token: 0x0400BEF6 RID: 48886
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C1;

		// Token: 0x0400BEF7 RID: 48887
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C2;

		// Token: 0x0400BEF8 RID: 48888
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C3;

		// Token: 0x0400BEF9 RID: 48889
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C4;

		// Token: 0x0400BEFA RID: 48890
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C5;

		// Token: 0x0400BEFB RID: 48891
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C6;

		// Token: 0x0400BEFC RID: 48892
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C7;

		// Token: 0x0400BEFD RID: 48893
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C8;

		// Token: 0x0400BEFE RID: 48894
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1C9;

		// Token: 0x0400BEFF RID: 48895
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CA;

		// Token: 0x0400BF00 RID: 48896
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CB;

		// Token: 0x0400BF01 RID: 48897
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CC;

		// Token: 0x0400BF02 RID: 48898
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CD;

		// Token: 0x0400BF03 RID: 48899
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CE;

		// Token: 0x0400BF04 RID: 48900
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1CF;

		// Token: 0x0400BF05 RID: 48901
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D0;

		// Token: 0x0400BF06 RID: 48902
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D1;

		// Token: 0x0400BF07 RID: 48903
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D2;

		// Token: 0x0400BF08 RID: 48904
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D3;

		// Token: 0x0400BF09 RID: 48905
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D4;

		// Token: 0x0400BF0A RID: 48906
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D5;

		// Token: 0x0400BF0B RID: 48907
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D6;

		// Token: 0x0400BF0C RID: 48908
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D7;

		// Token: 0x0400BF0D RID: 48909
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D8;

		// Token: 0x0400BF0E RID: 48910
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1D9;

		// Token: 0x0400BF0F RID: 48911
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DA;

		// Token: 0x0400BF10 RID: 48912
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DB;

		// Token: 0x0400BF11 RID: 48913
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DC;

		// Token: 0x0400BF12 RID: 48914
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DD;

		// Token: 0x0400BF13 RID: 48915
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DE;

		// Token: 0x0400BF14 RID: 48916
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1DF;

		// Token: 0x0400BF15 RID: 48917
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E0;

		// Token: 0x0400BF16 RID: 48918
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E1;

		// Token: 0x0400BF17 RID: 48919
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E2;

		// Token: 0x0400BF18 RID: 48920
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E3;

		// Token: 0x0400BF19 RID: 48921
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E4;

		// Token: 0x0400BF1A RID: 48922
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E5;

		// Token: 0x0400BF1B RID: 48923
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E6;

		// Token: 0x0400BF1C RID: 48924
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E7;

		// Token: 0x0400BF1D RID: 48925
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E8;

		// Token: 0x0400BF1E RID: 48926
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1E9;

		// Token: 0x0400BF1F RID: 48927
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1EA;

		// Token: 0x0400BF20 RID: 48928
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1EB;

		// Token: 0x0400BF21 RID: 48929
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1EC;

		// Token: 0x0400BF22 RID: 48930
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1ED;

		// Token: 0x0400BF23 RID: 48931
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1EE;

		// Token: 0x0400BF24 RID: 48932
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1EF;

		// Token: 0x0400BF25 RID: 48933
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F0;

		// Token: 0x0400BF26 RID: 48934
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F1;

		// Token: 0x0400BF27 RID: 48935
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F2;

		// Token: 0x0400BF28 RID: 48936
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F3;

		// Token: 0x0400BF29 RID: 48937
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F4;

		// Token: 0x0400BF2A RID: 48938
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F5;

		// Token: 0x0400BF2B RID: 48939
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F6;

		// Token: 0x0400BF2C RID: 48940
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F7;

		// Token: 0x0400BF2D RID: 48941
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F8;

		// Token: 0x0400BF2E RID: 48942
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1F9;

		// Token: 0x0400BF2F RID: 48943
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FA;

		// Token: 0x0400BF30 RID: 48944
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FB;

		// Token: 0x0400BF31 RID: 48945
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FC;

		// Token: 0x0400BF32 RID: 48946
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FD;

		// Token: 0x0400BF33 RID: 48947
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FE;

		// Token: 0x0400BF34 RID: 48948
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache1FF;

		// Token: 0x0400BF35 RID: 48949
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache200;

		// Token: 0x0400BF36 RID: 48950
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache201;

		// Token: 0x0400BF37 RID: 48951
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache202;

		// Token: 0x0400BF38 RID: 48952
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache203;

		// Token: 0x0400BF39 RID: 48953
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache204;

		// Token: 0x0400BF3A RID: 48954
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache205;

		// Token: 0x0400BF3B RID: 48955
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache206;

		// Token: 0x0400BF3C RID: 48956
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache207;

		// Token: 0x0400BF3D RID: 48957
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache208;

		// Token: 0x0400BF3E RID: 48958
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache209;

		// Token: 0x0400BF3F RID: 48959
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20A;

		// Token: 0x0400BF40 RID: 48960
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20B;

		// Token: 0x0400BF41 RID: 48961
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20C;

		// Token: 0x0400BF42 RID: 48962
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20D;

		// Token: 0x0400BF43 RID: 48963
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20E;

		// Token: 0x0400BF44 RID: 48964
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache20F;

		// Token: 0x0400BF45 RID: 48965
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache210;

		// Token: 0x0400BF46 RID: 48966
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache211;

		// Token: 0x0400BF47 RID: 48967
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache212;

		// Token: 0x0400BF48 RID: 48968
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache213;

		// Token: 0x0400BF49 RID: 48969
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache214;

		// Token: 0x0400BF4A RID: 48970
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache215;

		// Token: 0x0400BF4B RID: 48971
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache216;

		// Token: 0x0400BF4C RID: 48972
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache217;

		// Token: 0x0400BF4D RID: 48973
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache218;

		// Token: 0x0400BF4E RID: 48974
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache219;

		// Token: 0x0400BF4F RID: 48975
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21A;

		// Token: 0x0400BF50 RID: 48976
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21B;

		// Token: 0x0400BF51 RID: 48977
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21C;

		// Token: 0x0400BF52 RID: 48978
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21D;

		// Token: 0x0400BF53 RID: 48979
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21E;

		// Token: 0x0400BF54 RID: 48980
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache21F;

		// Token: 0x0400BF55 RID: 48981
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache220;

		// Token: 0x0400BF56 RID: 48982
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache221;

		// Token: 0x0400BF57 RID: 48983
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache222;

		// Token: 0x0400BF58 RID: 48984
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache223;

		// Token: 0x0400BF59 RID: 48985
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache224;

		// Token: 0x0400BF5A RID: 48986
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache225;

		// Token: 0x0400BF5B RID: 48987
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache226;

		// Token: 0x0400BF5C RID: 48988
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache227;

		// Token: 0x0400BF5D RID: 48989
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache228;

		// Token: 0x0400BF5E RID: 48990
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache229;

		// Token: 0x0400BF5F RID: 48991
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22A;

		// Token: 0x0400BF60 RID: 48992
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22B;

		// Token: 0x0400BF61 RID: 48993
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22C;

		// Token: 0x0400BF62 RID: 48994
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22D;

		// Token: 0x0400BF63 RID: 48995
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22E;

		// Token: 0x0400BF64 RID: 48996
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache22F;

		// Token: 0x0400BF65 RID: 48997
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache230;

		// Token: 0x0400BF66 RID: 48998
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache231;

		// Token: 0x0400BF67 RID: 48999
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache232;

		// Token: 0x0400BF68 RID: 49000
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache233;

		// Token: 0x0400BF69 RID: 49001
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache234;

		// Token: 0x0400BF6A RID: 49002
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache235;

		// Token: 0x0400BF6B RID: 49003
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache236;

		// Token: 0x0400BF6C RID: 49004
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache237;

		// Token: 0x0400BF6D RID: 49005
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache238;

		// Token: 0x0400BF6E RID: 49006
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache239;

		// Token: 0x0400BF6F RID: 49007
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23A;

		// Token: 0x0400BF70 RID: 49008
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23B;

		// Token: 0x0400BF71 RID: 49009
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23C;

		// Token: 0x0400BF72 RID: 49010
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23D;

		// Token: 0x0400BF73 RID: 49011
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23E;

		// Token: 0x0400BF74 RID: 49012
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache23F;

		// Token: 0x0400BF75 RID: 49013
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache240;

		// Token: 0x0400BF76 RID: 49014
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache241;

		// Token: 0x0400BF77 RID: 49015
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache242;

		// Token: 0x0400BF78 RID: 49016
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache243;

		// Token: 0x0400BF79 RID: 49017
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache244;

		// Token: 0x0400BF7A RID: 49018
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache245;

		// Token: 0x0400BF7B RID: 49019
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache246;

		// Token: 0x0400BF7C RID: 49020
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache247;

		// Token: 0x0400BF7D RID: 49021
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache248;

		// Token: 0x0400BF7E RID: 49022
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache249;

		// Token: 0x0400BF7F RID: 49023
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24A;

		// Token: 0x0400BF80 RID: 49024
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24B;

		// Token: 0x0400BF81 RID: 49025
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24C;

		// Token: 0x0400BF82 RID: 49026
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24D;

		// Token: 0x0400BF83 RID: 49027
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24E;

		// Token: 0x0400BF84 RID: 49028
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache24F;

		// Token: 0x0400BF85 RID: 49029
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache250;

		// Token: 0x0400BF86 RID: 49030
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache251;

		// Token: 0x0400BF87 RID: 49031
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache252;

		// Token: 0x0400BF88 RID: 49032
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache253;

		// Token: 0x0400BF89 RID: 49033
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache254;

		// Token: 0x0400BF8A RID: 49034
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache255;

		// Token: 0x0400BF8B RID: 49035
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache256;

		// Token: 0x0400BF8C RID: 49036
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache257;

		// Token: 0x0400BF8D RID: 49037
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache258;

		// Token: 0x0400BF8E RID: 49038
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache259;

		// Token: 0x0400BF8F RID: 49039
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25A;

		// Token: 0x0400BF90 RID: 49040
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25B;

		// Token: 0x0400BF91 RID: 49041
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25C;

		// Token: 0x0400BF92 RID: 49042
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25D;

		// Token: 0x0400BF93 RID: 49043
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25E;

		// Token: 0x0400BF94 RID: 49044
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache25F;

		// Token: 0x0400BF95 RID: 49045
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache260;

		// Token: 0x0400BF96 RID: 49046
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache261;

		// Token: 0x0400BF97 RID: 49047
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache262;

		// Token: 0x0400BF98 RID: 49048
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache263;

		// Token: 0x0400BF99 RID: 49049
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache264;

		// Token: 0x0400BF9A RID: 49050
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache265;

		// Token: 0x0400BF9B RID: 49051
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache266;

		// Token: 0x0400BF9C RID: 49052
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache267;

		// Token: 0x0400BF9D RID: 49053
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache268;

		// Token: 0x0400BF9E RID: 49054
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache269;

		// Token: 0x0400BF9F RID: 49055
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26A;

		// Token: 0x0400BFA0 RID: 49056
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26B;

		// Token: 0x0400BFA1 RID: 49057
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26C;

		// Token: 0x0400BFA2 RID: 49058
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26D;

		// Token: 0x0400BFA3 RID: 49059
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26E;

		// Token: 0x0400BFA4 RID: 49060
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache26F;

		// Token: 0x0400BFA5 RID: 49061
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache270;

		// Token: 0x0400BFA6 RID: 49062
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache271;

		// Token: 0x0400BFA7 RID: 49063
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache272;

		// Token: 0x0400BFA8 RID: 49064
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache273;

		// Token: 0x0400BFA9 RID: 49065
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache274;

		// Token: 0x0400BFAA RID: 49066
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache275;

		// Token: 0x0400BFAB RID: 49067
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache276;

		// Token: 0x0400BFAC RID: 49068
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache277;

		// Token: 0x0400BFAD RID: 49069
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache278;

		// Token: 0x0400BFAE RID: 49070
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache279;

		// Token: 0x0400BFAF RID: 49071
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache27A;

		// Token: 0x0400BFB0 RID: 49072
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache27B;

		// Token: 0x0400BFB1 RID: 49073
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache27C;

		// Token: 0x0400BFB2 RID: 49074
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache27D;

		// Token: 0x0400BFB3 RID: 49075
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache27E;

		// Token: 0x0400BFB4 RID: 49076
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache27F;

		// Token: 0x0400BFB5 RID: 49077
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache280;

		// Token: 0x0400BFB6 RID: 49078
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache281;

		// Token: 0x0400BFB7 RID: 49079
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache282;

		// Token: 0x0400BFB8 RID: 49080
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache283;

		// Token: 0x0400BFB9 RID: 49081
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache284;

		// Token: 0x0400BFBA RID: 49082
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache285;

		// Token: 0x0400BFBB RID: 49083
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache286;

		// Token: 0x0400BFBC RID: 49084
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache287;

		// Token: 0x0400BFBD RID: 49085
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache288;

		// Token: 0x0400BFBE RID: 49086
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache289;

		// Token: 0x0400BFBF RID: 49087
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache28A;

		// Token: 0x0400BFC0 RID: 49088
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache28B;

		// Token: 0x0400BFC1 RID: 49089
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache28C;

		// Token: 0x0400BFC2 RID: 49090
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache28D;

		// Token: 0x0400BFC3 RID: 49091
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache28E;

		// Token: 0x0400BFC4 RID: 49092
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache28F;

		// Token: 0x0400BFC5 RID: 49093
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache290;

		// Token: 0x0400BFC6 RID: 49094
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache291;

		// Token: 0x0400BFC7 RID: 49095
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache292;

		// Token: 0x0400BFC8 RID: 49096
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache293;

		// Token: 0x0400BFC9 RID: 49097
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache294;

		// Token: 0x0400BFCA RID: 49098
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache295;

		// Token: 0x0400BFCB RID: 49099
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache296;

		// Token: 0x0400BFCC RID: 49100
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache297;

		// Token: 0x0400BFCD RID: 49101
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache298;

		// Token: 0x0400BFCE RID: 49102
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache299;

		// Token: 0x0400BFCF RID: 49103
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache29A;

		// Token: 0x0400BFD0 RID: 49104
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache29B;

		// Token: 0x0400BFD1 RID: 49105
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache29C;

		// Token: 0x0400BFD2 RID: 49106
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache29D;

		// Token: 0x0400BFD3 RID: 49107
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache29E;

		// Token: 0x0400BFD4 RID: 49108
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache29F;

		// Token: 0x0400BFD5 RID: 49109
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A0;

		// Token: 0x0400BFD6 RID: 49110
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A1;

		// Token: 0x0400BFD7 RID: 49111
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A2;

		// Token: 0x0400BFD8 RID: 49112
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A3;

		// Token: 0x0400BFD9 RID: 49113
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A4;

		// Token: 0x0400BFDA RID: 49114
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A5;

		// Token: 0x0400BFDB RID: 49115
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A6;

		// Token: 0x0400BFDC RID: 49116
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A7;

		// Token: 0x0400BFDD RID: 49117
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A8;

		// Token: 0x0400BFDE RID: 49118
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2A9;

		// Token: 0x0400BFDF RID: 49119
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2AA;

		// Token: 0x0400BFE0 RID: 49120
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2AB;

		// Token: 0x0400BFE1 RID: 49121
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2AC;

		// Token: 0x0400BFE2 RID: 49122
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2AD;

		// Token: 0x0400BFE3 RID: 49123
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2AE;

		// Token: 0x0400BFE4 RID: 49124
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2AF;

		// Token: 0x0400BFE5 RID: 49125
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B0;

		// Token: 0x0400BFE6 RID: 49126
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B1;

		// Token: 0x0400BFE7 RID: 49127
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B2;

		// Token: 0x0400BFE8 RID: 49128
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B3;

		// Token: 0x0400BFE9 RID: 49129
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B4;

		// Token: 0x0400BFEA RID: 49130
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B5;

		// Token: 0x0400BFEB RID: 49131
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B6;

		// Token: 0x0400BFEC RID: 49132
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B7;

		// Token: 0x0400BFED RID: 49133
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B8;

		// Token: 0x0400BFEE RID: 49134
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2B9;

		// Token: 0x0400BFEF RID: 49135
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2BA;

		// Token: 0x0400BFF0 RID: 49136
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2BB;

		// Token: 0x0400BFF1 RID: 49137
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2BC;

		// Token: 0x0400BFF2 RID: 49138
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2BD;

		// Token: 0x0400BFF3 RID: 49139
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2BE;

		// Token: 0x0400BFF4 RID: 49140
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2BF;

		// Token: 0x0400BFF5 RID: 49141
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C0;

		// Token: 0x0400BFF6 RID: 49142
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C1;

		// Token: 0x0400BFF7 RID: 49143
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C2;

		// Token: 0x0400BFF8 RID: 49144
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C3;

		// Token: 0x0400BFF9 RID: 49145
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C4;

		// Token: 0x0400BFFA RID: 49146
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C5;

		// Token: 0x0400BFFB RID: 49147
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C6;

		// Token: 0x0400BFFC RID: 49148
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C7;

		// Token: 0x0400BFFD RID: 49149
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C8;

		// Token: 0x0400BFFE RID: 49150
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2C9;

		// Token: 0x0400BFFF RID: 49151
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2CA;

		// Token: 0x0400C000 RID: 49152
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2CB;

		// Token: 0x0400C001 RID: 49153
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2CC;

		// Token: 0x0400C002 RID: 49154
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2CD;

		// Token: 0x0400C003 RID: 49155
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2CE;

		// Token: 0x0400C004 RID: 49156
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2CF;

		// Token: 0x0400C005 RID: 49157
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D0;

		// Token: 0x0400C006 RID: 49158
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D1;

		// Token: 0x0400C007 RID: 49159
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D2;

		// Token: 0x0400C008 RID: 49160
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D3;

		// Token: 0x0400C009 RID: 49161
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D4;

		// Token: 0x0400C00A RID: 49162
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D5;

		// Token: 0x0400C00B RID: 49163
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D6;

		// Token: 0x0400C00C RID: 49164
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D7;

		// Token: 0x0400C00D RID: 49165
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D8;

		// Token: 0x0400C00E RID: 49166
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2D9;

		// Token: 0x0400C00F RID: 49167
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2DA;

		// Token: 0x0400C010 RID: 49168
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2DB;

		// Token: 0x0400C011 RID: 49169
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2DC;

		// Token: 0x0400C012 RID: 49170
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2DD;

		// Token: 0x0400C013 RID: 49171
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2DE;

		// Token: 0x0400C014 RID: 49172
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2DF;

		// Token: 0x0400C015 RID: 49173
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E0;

		// Token: 0x0400C016 RID: 49174
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E1;

		// Token: 0x0400C017 RID: 49175
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E2;

		// Token: 0x0400C018 RID: 49176
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E3;

		// Token: 0x0400C019 RID: 49177
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E4;

		// Token: 0x0400C01A RID: 49178
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E5;

		// Token: 0x0400C01B RID: 49179
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E6;

		// Token: 0x0400C01C RID: 49180
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E7;

		// Token: 0x0400C01D RID: 49181
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E8;

		// Token: 0x0400C01E RID: 49182
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2E9;

		// Token: 0x0400C01F RID: 49183
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2EA;

		// Token: 0x0400C020 RID: 49184
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2EB;

		// Token: 0x0400C021 RID: 49185
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2EC;

		// Token: 0x0400C022 RID: 49186
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2ED;

		// Token: 0x0400C023 RID: 49187
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2EE;

		// Token: 0x0400C024 RID: 49188
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2EF;

		// Token: 0x0400C025 RID: 49189
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F0;

		// Token: 0x0400C026 RID: 49190
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F1;

		// Token: 0x0400C027 RID: 49191
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F2;

		// Token: 0x0400C028 RID: 49192
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F3;

		// Token: 0x0400C029 RID: 49193
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F4;

		// Token: 0x0400C02A RID: 49194
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F5;

		// Token: 0x0400C02B RID: 49195
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F6;

		// Token: 0x0400C02C RID: 49196
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F7;

		// Token: 0x0400C02D RID: 49197
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F8;

		// Token: 0x0400C02E RID: 49198
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2F9;

		// Token: 0x0400C02F RID: 49199
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2FA;

		// Token: 0x0400C030 RID: 49200
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2FB;

		// Token: 0x0400C031 RID: 49201
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2FC;

		// Token: 0x0400C032 RID: 49202
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2FD;

		// Token: 0x0400C033 RID: 49203
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2FE;

		// Token: 0x0400C034 RID: 49204
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache2FF;

		// Token: 0x0400C035 RID: 49205
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache300;

		// Token: 0x0400C036 RID: 49206
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache301;

		// Token: 0x0400C037 RID: 49207
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache302;

		// Token: 0x0400C038 RID: 49208
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache303;

		// Token: 0x0400C039 RID: 49209
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache304;

		// Token: 0x0400C03A RID: 49210
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache305;

		// Token: 0x0400C03B RID: 49211
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache306;

		// Token: 0x0400C03C RID: 49212
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache307;

		// Token: 0x0400C03D RID: 49213
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache308;

		// Token: 0x0400C03E RID: 49214
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache309;

		// Token: 0x0400C03F RID: 49215
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache30A;

		// Token: 0x0400C040 RID: 49216
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache30B;

		// Token: 0x0400C041 RID: 49217
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache30C;

		// Token: 0x0400C042 RID: 49218
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache30D;

		// Token: 0x0400C043 RID: 49219
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache30E;

		// Token: 0x0400C044 RID: 49220
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache30F;

		// Token: 0x0400C045 RID: 49221
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache310;

		// Token: 0x0400C046 RID: 49222
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache311;

		// Token: 0x0400C047 RID: 49223
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache312;

		// Token: 0x0400C048 RID: 49224
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache313;

		// Token: 0x0400C049 RID: 49225
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache314;

		// Token: 0x0400C04A RID: 49226
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache315;

		// Token: 0x0400C04B RID: 49227
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache316;

		// Token: 0x0400C04C RID: 49228
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache317;

		// Token: 0x0400C04D RID: 49229
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache318;

		// Token: 0x0400C04E RID: 49230
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache319;

		// Token: 0x0400C04F RID: 49231
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache31A;

		// Token: 0x0400C050 RID: 49232
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache31B;

		// Token: 0x0400C051 RID: 49233
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache31C;

		// Token: 0x0400C052 RID: 49234
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache31D;

		// Token: 0x0400C053 RID: 49235
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache31E;

		// Token: 0x0400C054 RID: 49236
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache31F;

		// Token: 0x0400C055 RID: 49237
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache320;

		// Token: 0x0400C056 RID: 49238
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache321;

		// Token: 0x0400C057 RID: 49239
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache322;

		// Token: 0x0400C058 RID: 49240
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache323;

		// Token: 0x0400C059 RID: 49241
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache324;

		// Token: 0x0400C05A RID: 49242
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache325;

		// Token: 0x0400C05B RID: 49243
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache326;

		// Token: 0x0400C05C RID: 49244
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache327;

		// Token: 0x0400C05D RID: 49245
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache328;

		// Token: 0x0400C05E RID: 49246
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache329;

		// Token: 0x0400C05F RID: 49247
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache32A;

		// Token: 0x0400C060 RID: 49248
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache32B;

		// Token: 0x0400C061 RID: 49249
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache32C;

		// Token: 0x0400C062 RID: 49250
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache32D;

		// Token: 0x0400C063 RID: 49251
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache32E;

		// Token: 0x0400C064 RID: 49252
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache32F;

		// Token: 0x0400C065 RID: 49253
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache330;

		// Token: 0x0400C066 RID: 49254
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache331;

		// Token: 0x0400C067 RID: 49255
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache332;

		// Token: 0x0400C068 RID: 49256
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache333;

		// Token: 0x0400C069 RID: 49257
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache334;

		// Token: 0x0400C06A RID: 49258
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache335;

		// Token: 0x0400C06B RID: 49259
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache336;

		// Token: 0x0400C06C RID: 49260
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache337;

		// Token: 0x0400C06D RID: 49261
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache338;

		// Token: 0x0400C06E RID: 49262
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache339;

		// Token: 0x0400C06F RID: 49263
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache33A;

		// Token: 0x0400C070 RID: 49264
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache33B;

		// Token: 0x0400C071 RID: 49265
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache33C;

		// Token: 0x0400C072 RID: 49266
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache33D;

		// Token: 0x0400C073 RID: 49267
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache33E;

		// Token: 0x0400C074 RID: 49268
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache33F;

		// Token: 0x0400C075 RID: 49269
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache340;

		// Token: 0x0400C076 RID: 49270
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache341;

		// Token: 0x0400C077 RID: 49271
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache342;

		// Token: 0x0400C078 RID: 49272
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache343;

		// Token: 0x0400C079 RID: 49273
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache344;

		// Token: 0x0400C07A RID: 49274
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache345;

		// Token: 0x0400C07B RID: 49275
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache346;

		// Token: 0x0400C07C RID: 49276
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache347;

		// Token: 0x0400C07D RID: 49277
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache348;

		// Token: 0x0400C07E RID: 49278
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache349;

		// Token: 0x0400C07F RID: 49279
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache34A;

		// Token: 0x0400C080 RID: 49280
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache34B;

		// Token: 0x0400C081 RID: 49281
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache34C;

		// Token: 0x0400C082 RID: 49282
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache34D;

		// Token: 0x0400C083 RID: 49283
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache34E;

		// Token: 0x0400C084 RID: 49284
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache34F;

		// Token: 0x0400C085 RID: 49285
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache350;

		// Token: 0x0400C086 RID: 49286
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache351;

		// Token: 0x0400C087 RID: 49287
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache352;

		// Token: 0x0400C088 RID: 49288
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache353;

		// Token: 0x0400C089 RID: 49289
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache354;

		// Token: 0x0400C08A RID: 49290
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache355;

		// Token: 0x0400C08B RID: 49291
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache356;

		// Token: 0x0400C08C RID: 49292
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache357;

		// Token: 0x0400C08D RID: 49293
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache358;

		// Token: 0x0400C08E RID: 49294
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache359;

		// Token: 0x0400C08F RID: 49295
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache35A;

		// Token: 0x0400C090 RID: 49296
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache35B;

		// Token: 0x0400C091 RID: 49297
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache35C;

		// Token: 0x0400C092 RID: 49298
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache35D;

		// Token: 0x0400C093 RID: 49299
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache35E;

		// Token: 0x0400C094 RID: 49300
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache35F;

		// Token: 0x0400C095 RID: 49301
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache360;

		// Token: 0x0400C096 RID: 49302
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache361;

		// Token: 0x0400C097 RID: 49303
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache362;

		// Token: 0x0400C098 RID: 49304
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache363;

		// Token: 0x0400C099 RID: 49305
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache364;

		// Token: 0x0400C09A RID: 49306
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache365;

		// Token: 0x0400C09B RID: 49307
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache366;

		// Token: 0x0400C09C RID: 49308
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache367;

		// Token: 0x0400C09D RID: 49309
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache368;

		// Token: 0x0400C09E RID: 49310
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache369;

		// Token: 0x0400C09F RID: 49311
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache36A;

		// Token: 0x0400C0A0 RID: 49312
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache36B;

		// Token: 0x0400C0A1 RID: 49313
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache36C;

		// Token: 0x0400C0A2 RID: 49314
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache36D;

		// Token: 0x0400C0A3 RID: 49315
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache36E;

		// Token: 0x0400C0A4 RID: 49316
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache36F;

		// Token: 0x0400C0A5 RID: 49317
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache370;

		// Token: 0x0400C0A6 RID: 49318
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache371;

		// Token: 0x0400C0A7 RID: 49319
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache372;

		// Token: 0x0400C0A8 RID: 49320
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache373;

		// Token: 0x0400C0A9 RID: 49321
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache374;

		// Token: 0x0400C0AA RID: 49322
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache375;

		// Token: 0x0400C0AB RID: 49323
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache376;

		// Token: 0x0400C0AC RID: 49324
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache377;

		// Token: 0x0400C0AD RID: 49325
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache378;

		// Token: 0x0400C0AE RID: 49326
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache379;

		// Token: 0x0400C0AF RID: 49327
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache37A;

		// Token: 0x0400C0B0 RID: 49328
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache37B;

		// Token: 0x0400C0B1 RID: 49329
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache37C;

		// Token: 0x0400C0B2 RID: 49330
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache37D;

		// Token: 0x0400C0B3 RID: 49331
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache37E;

		// Token: 0x0400C0B4 RID: 49332
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache37F;

		// Token: 0x0400C0B5 RID: 49333
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache380;

		// Token: 0x0400C0B6 RID: 49334
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache381;

		// Token: 0x0400C0B7 RID: 49335
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache382;

		// Token: 0x0400C0B8 RID: 49336
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache383;

		// Token: 0x0400C0B9 RID: 49337
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache384;

		// Token: 0x0400C0BA RID: 49338
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache385;

		// Token: 0x0400C0BB RID: 49339
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache386;

		// Token: 0x0400C0BC RID: 49340
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache387;

		// Token: 0x0400C0BD RID: 49341
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache388;

		// Token: 0x0400C0BE RID: 49342
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache389;

		// Token: 0x0400C0BF RID: 49343
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache38A;

		// Token: 0x0400C0C0 RID: 49344
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache38B;

		// Token: 0x0400C0C1 RID: 49345
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache38C;

		// Token: 0x0400C0C2 RID: 49346
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache38D;

		// Token: 0x0400C0C3 RID: 49347
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache38E;

		// Token: 0x0400C0C4 RID: 49348
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache38F;

		// Token: 0x0400C0C5 RID: 49349
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache390;

		// Token: 0x0400C0C6 RID: 49350
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache391;

		// Token: 0x0400C0C7 RID: 49351
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache392;

		// Token: 0x0400C0C8 RID: 49352
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache393;

		// Token: 0x0400C0C9 RID: 49353
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache394;

		// Token: 0x0400C0CA RID: 49354
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache395;

		// Token: 0x0400C0CB RID: 49355
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache396;

		// Token: 0x0400C0CC RID: 49356
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache397;

		// Token: 0x0400C0CD RID: 49357
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache398;

		// Token: 0x0400C0CE RID: 49358
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache399;

		// Token: 0x0400C0CF RID: 49359
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache39A;

		// Token: 0x0400C0D0 RID: 49360
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache39B;

		// Token: 0x0400C0D1 RID: 49361
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache39C;

		// Token: 0x0400C0D2 RID: 49362
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache39D;

		// Token: 0x0400C0D3 RID: 49363
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache39E;

		// Token: 0x0400C0D4 RID: 49364
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache39F;

		// Token: 0x0400C0D5 RID: 49365
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A0;

		// Token: 0x0400C0D6 RID: 49366
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A1;

		// Token: 0x0400C0D7 RID: 49367
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A2;

		// Token: 0x0400C0D8 RID: 49368
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A3;

		// Token: 0x0400C0D9 RID: 49369
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A4;

		// Token: 0x0400C0DA RID: 49370
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A5;

		// Token: 0x0400C0DB RID: 49371
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A6;

		// Token: 0x0400C0DC RID: 49372
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A7;

		// Token: 0x0400C0DD RID: 49373
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A8;

		// Token: 0x0400C0DE RID: 49374
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3A9;

		// Token: 0x0400C0DF RID: 49375
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3AA;

		// Token: 0x0400C0E0 RID: 49376
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3AB;

		// Token: 0x0400C0E1 RID: 49377
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3AC;

		// Token: 0x0400C0E2 RID: 49378
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3AD;

		// Token: 0x0400C0E3 RID: 49379
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3AE;

		// Token: 0x0400C0E4 RID: 49380
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3AF;

		// Token: 0x0400C0E5 RID: 49381
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B0;

		// Token: 0x0400C0E6 RID: 49382
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B1;

		// Token: 0x0400C0E7 RID: 49383
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B2;

		// Token: 0x0400C0E8 RID: 49384
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B3;

		// Token: 0x0400C0E9 RID: 49385
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B4;

		// Token: 0x0400C0EA RID: 49386
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B5;

		// Token: 0x0400C0EB RID: 49387
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B6;

		// Token: 0x0400C0EC RID: 49388
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B7;

		// Token: 0x0400C0ED RID: 49389
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B8;

		// Token: 0x0400C0EE RID: 49390
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3B9;

		// Token: 0x0400C0EF RID: 49391
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3BA;

		// Token: 0x0400C0F0 RID: 49392
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3BB;

		// Token: 0x0400C0F1 RID: 49393
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3BC;

		// Token: 0x0400C0F2 RID: 49394
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3BD;

		// Token: 0x0400C0F3 RID: 49395
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3BE;

		// Token: 0x0400C0F4 RID: 49396
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3BF;

		// Token: 0x0400C0F5 RID: 49397
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C0;

		// Token: 0x0400C0F6 RID: 49398
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C1;

		// Token: 0x0400C0F7 RID: 49399
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C2;

		// Token: 0x0400C0F8 RID: 49400
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C3;

		// Token: 0x0400C0F9 RID: 49401
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C4;

		// Token: 0x0400C0FA RID: 49402
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C5;

		// Token: 0x0400C0FB RID: 49403
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C6;

		// Token: 0x0400C0FC RID: 49404
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C7;

		// Token: 0x0400C0FD RID: 49405
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C8;

		// Token: 0x0400C0FE RID: 49406
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3C9;

		// Token: 0x0400C0FF RID: 49407
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3CA;

		// Token: 0x0400C100 RID: 49408
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3CB;

		// Token: 0x0400C101 RID: 49409
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3CC;

		// Token: 0x0400C102 RID: 49410
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3CD;

		// Token: 0x0400C103 RID: 49411
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3CE;

		// Token: 0x0400C104 RID: 49412
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3CF;

		// Token: 0x0400C105 RID: 49413
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D0;

		// Token: 0x0400C106 RID: 49414
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D1;

		// Token: 0x0400C107 RID: 49415
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D2;

		// Token: 0x0400C108 RID: 49416
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D3;

		// Token: 0x0400C109 RID: 49417
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D4;

		// Token: 0x0400C10A RID: 49418
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D5;

		// Token: 0x0400C10B RID: 49419
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D6;

		// Token: 0x0400C10C RID: 49420
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D7;

		// Token: 0x0400C10D RID: 49421
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D8;

		// Token: 0x0400C10E RID: 49422
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3D9;

		// Token: 0x0400C10F RID: 49423
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3DA;

		// Token: 0x0400C110 RID: 49424
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3DB;

		// Token: 0x0400C111 RID: 49425
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3DC;

		// Token: 0x0400C112 RID: 49426
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3DD;

		// Token: 0x0400C113 RID: 49427
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3DE;

		// Token: 0x0400C114 RID: 49428
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3DF;

		// Token: 0x0400C115 RID: 49429
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E0;

		// Token: 0x0400C116 RID: 49430
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E1;

		// Token: 0x0400C117 RID: 49431
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E2;

		// Token: 0x0400C118 RID: 49432
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E3;

		// Token: 0x0400C119 RID: 49433
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E4;

		// Token: 0x0400C11A RID: 49434
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E5;

		// Token: 0x0400C11B RID: 49435
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E6;

		// Token: 0x0400C11C RID: 49436
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E7;

		// Token: 0x0400C11D RID: 49437
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E8;

		// Token: 0x0400C11E RID: 49438
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3E9;

		// Token: 0x0400C11F RID: 49439
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3EA;

		// Token: 0x0400C120 RID: 49440
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3EB;

		// Token: 0x0400C121 RID: 49441
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3EC;

		// Token: 0x0400C122 RID: 49442
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3ED;

		// Token: 0x0400C123 RID: 49443
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3EE;

		// Token: 0x0400C124 RID: 49444
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3EF;

		// Token: 0x0400C125 RID: 49445
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F0;

		// Token: 0x0400C126 RID: 49446
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F1;

		// Token: 0x0400C127 RID: 49447
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F2;

		// Token: 0x0400C128 RID: 49448
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F3;

		// Token: 0x0400C129 RID: 49449
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F4;

		// Token: 0x0400C12A RID: 49450
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F5;

		// Token: 0x0400C12B RID: 49451
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F6;

		// Token: 0x0400C12C RID: 49452
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F7;

		// Token: 0x0400C12D RID: 49453
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F8;

		// Token: 0x0400C12E RID: 49454
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3F9;

		// Token: 0x0400C12F RID: 49455
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3FA;

		// Token: 0x0400C130 RID: 49456
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3FB;

		// Token: 0x0400C131 RID: 49457
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3FC;

		// Token: 0x0400C132 RID: 49458
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3FD;

		// Token: 0x0400C133 RID: 49459
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3FE;

		// Token: 0x0400C134 RID: 49460
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache3FF;

		// Token: 0x0400C135 RID: 49461
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache400;

		// Token: 0x0400C136 RID: 49462
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache401;

		// Token: 0x0400C137 RID: 49463
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache402;

		// Token: 0x0400C138 RID: 49464
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache403;

		// Token: 0x0400C139 RID: 49465
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache404;

		// Token: 0x0400C13A RID: 49466
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache405;

		// Token: 0x0400C13B RID: 49467
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache406;

		// Token: 0x0400C13C RID: 49468
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache407;

		// Token: 0x0400C13D RID: 49469
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache408;

		// Token: 0x0400C13E RID: 49470
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache409;

		// Token: 0x0400C13F RID: 49471
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache40A;

		// Token: 0x0400C140 RID: 49472
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache40B;

		// Token: 0x0400C141 RID: 49473
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache40C;

		// Token: 0x0400C142 RID: 49474
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache40D;

		// Token: 0x0400C143 RID: 49475
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache40E;

		// Token: 0x0400C144 RID: 49476
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache40F;

		// Token: 0x0400C145 RID: 49477
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache410;

		// Token: 0x0400C146 RID: 49478
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache411;

		// Token: 0x0400C147 RID: 49479
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache412;

		// Token: 0x0400C148 RID: 49480
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache413;

		// Token: 0x0400C149 RID: 49481
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache414;

		// Token: 0x0400C14A RID: 49482
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache415;

		// Token: 0x0400C14B RID: 49483
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache416;

		// Token: 0x0400C14C RID: 49484
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache417;

		// Token: 0x0400C14D RID: 49485
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache418;

		// Token: 0x0400C14E RID: 49486
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache419;

		// Token: 0x0400C14F RID: 49487
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache41A;

		// Token: 0x0400C150 RID: 49488
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache41B;

		// Token: 0x0400C151 RID: 49489
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache41C;

		// Token: 0x0400C152 RID: 49490
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache41D;

		// Token: 0x0400C153 RID: 49491
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache41E;

		// Token: 0x0400C154 RID: 49492
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache41F;

		// Token: 0x0400C155 RID: 49493
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache420;

		// Token: 0x0400C156 RID: 49494
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache421;

		// Token: 0x0400C157 RID: 49495
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache422;

		// Token: 0x0400C158 RID: 49496
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache423;

		// Token: 0x0400C159 RID: 49497
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache424;

		// Token: 0x0400C15A RID: 49498
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache425;

		// Token: 0x0400C15B RID: 49499
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache426;

		// Token: 0x0400C15C RID: 49500
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache427;

		// Token: 0x0400C15D RID: 49501
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache428;

		// Token: 0x0400C15E RID: 49502
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache429;

		// Token: 0x0400C15F RID: 49503
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache42A;

		// Token: 0x0400C160 RID: 49504
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache42B;

		// Token: 0x0400C161 RID: 49505
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache42C;

		// Token: 0x0400C162 RID: 49506
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache42D;

		// Token: 0x0400C163 RID: 49507
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache42E;

		// Token: 0x0400C164 RID: 49508
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache42F;

		// Token: 0x0400C165 RID: 49509
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache430;

		// Token: 0x0400C166 RID: 49510
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache431;

		// Token: 0x0400C167 RID: 49511
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache432;

		// Token: 0x0400C168 RID: 49512
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache433;

		// Token: 0x0400C169 RID: 49513
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache434;

		// Token: 0x0400C16A RID: 49514
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache435;

		// Token: 0x0400C16B RID: 49515
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache436;

		// Token: 0x0400C16C RID: 49516
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache437;

		// Token: 0x0400C16D RID: 49517
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache438;

		// Token: 0x0400C16E RID: 49518
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache439;

		// Token: 0x0400C16F RID: 49519
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache43A;

		// Token: 0x0400C170 RID: 49520
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache43B;

		// Token: 0x0400C171 RID: 49521
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache43C;

		// Token: 0x0400C172 RID: 49522
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache43D;

		// Token: 0x0400C173 RID: 49523
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache43E;

		// Token: 0x0400C174 RID: 49524
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache43F;

		// Token: 0x0400C175 RID: 49525
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache440;

		// Token: 0x0400C176 RID: 49526
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache441;

		// Token: 0x0400C177 RID: 49527
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache442;

		// Token: 0x0400C178 RID: 49528
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache443;

		// Token: 0x0400C179 RID: 49529
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache444;

		// Token: 0x0400C17A RID: 49530
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache445;

		// Token: 0x0400C17B RID: 49531
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache446;

		// Token: 0x0400C17C RID: 49532
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache447;

		// Token: 0x0400C17D RID: 49533
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache448;

		// Token: 0x0400C17E RID: 49534
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache449;

		// Token: 0x0400C17F RID: 49535
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache44A;

		// Token: 0x0400C180 RID: 49536
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache44B;

		// Token: 0x0400C181 RID: 49537
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache44C;

		// Token: 0x0400C182 RID: 49538
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache44D;

		// Token: 0x0400C183 RID: 49539
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache44E;

		// Token: 0x0400C184 RID: 49540
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache44F;

		// Token: 0x0400C185 RID: 49541
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache450;

		// Token: 0x0400C186 RID: 49542
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache451;

		// Token: 0x0400C187 RID: 49543
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache452;

		// Token: 0x0400C188 RID: 49544
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache453;

		// Token: 0x0400C189 RID: 49545
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache454;

		// Token: 0x0400C18A RID: 49546
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache455;

		// Token: 0x0400C18B RID: 49547
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache456;

		// Token: 0x0400C18C RID: 49548
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache457;

		// Token: 0x0400C18D RID: 49549
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache458;

		// Token: 0x0400C18E RID: 49550
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache459;

		// Token: 0x0400C18F RID: 49551
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache45A;

		// Token: 0x0400C190 RID: 49552
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache45B;

		// Token: 0x0400C191 RID: 49553
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache45C;

		// Token: 0x0400C192 RID: 49554
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache45D;

		// Token: 0x0400C193 RID: 49555
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache45E;

		// Token: 0x0400C194 RID: 49556
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache45F;

		// Token: 0x0400C195 RID: 49557
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache460;

		// Token: 0x0400C196 RID: 49558
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache461;

		// Token: 0x0400C197 RID: 49559
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache462;

		// Token: 0x0400C198 RID: 49560
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache463;

		// Token: 0x0400C199 RID: 49561
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache464;

		// Token: 0x0400C19A RID: 49562
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache465;

		// Token: 0x0400C19B RID: 49563
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache466;

		// Token: 0x0400C19C RID: 49564
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache467;

		// Token: 0x0400C19D RID: 49565
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache468;

		// Token: 0x0400C19E RID: 49566
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache469;

		// Token: 0x0400C19F RID: 49567
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache46A;

		// Token: 0x0400C1A0 RID: 49568
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache46B;

		// Token: 0x0400C1A1 RID: 49569
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache46C;

		// Token: 0x0400C1A2 RID: 49570
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache46D;

		// Token: 0x0400C1A3 RID: 49571
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache46E;

		// Token: 0x0400C1A4 RID: 49572
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache46F;

		// Token: 0x0400C1A5 RID: 49573
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache470;

		// Token: 0x0400C1A6 RID: 49574
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache471;

		// Token: 0x0400C1A7 RID: 49575
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache472;

		// Token: 0x0400C1A8 RID: 49576
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache473;

		// Token: 0x0400C1A9 RID: 49577
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache474;

		// Token: 0x0400C1AA RID: 49578
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache475;

		// Token: 0x0400C1AB RID: 49579
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache476;

		// Token: 0x0400C1AC RID: 49580
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache477;

		// Token: 0x0400C1AD RID: 49581
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache478;

		// Token: 0x0400C1AE RID: 49582
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache479;

		// Token: 0x0400C1AF RID: 49583
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache47A;

		// Token: 0x0400C1B0 RID: 49584
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache47B;

		// Token: 0x0400C1B1 RID: 49585
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache47C;

		// Token: 0x0400C1B2 RID: 49586
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache47D;

		// Token: 0x0400C1B3 RID: 49587
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache47E;

		// Token: 0x0400C1B4 RID: 49588
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache47F;

		// Token: 0x0400C1B5 RID: 49589
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache480;

		// Token: 0x0400C1B6 RID: 49590
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache481;

		// Token: 0x0400C1B7 RID: 49591
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache482;

		// Token: 0x0400C1B8 RID: 49592
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache483;

		// Token: 0x0400C1B9 RID: 49593
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache484;

		// Token: 0x0400C1BA RID: 49594
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache485;

		// Token: 0x0400C1BB RID: 49595
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache486;

		// Token: 0x0400C1BC RID: 49596
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache487;

		// Token: 0x0400C1BD RID: 49597
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache488;

		// Token: 0x0400C1BE RID: 49598
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache489;

		// Token: 0x0400C1BF RID: 49599
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache48A;

		// Token: 0x0400C1C0 RID: 49600
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache48B;

		// Token: 0x0400C1C1 RID: 49601
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache48C;

		// Token: 0x0400C1C2 RID: 49602
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache48D;

		// Token: 0x0400C1C3 RID: 49603
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache48E;

		// Token: 0x0400C1C4 RID: 49604
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache48F;

		// Token: 0x0400C1C5 RID: 49605
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache490;

		// Token: 0x0400C1C6 RID: 49606
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache491;

		// Token: 0x0400C1C7 RID: 49607
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache492;

		// Token: 0x0400C1C8 RID: 49608
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache493;

		// Token: 0x0400C1C9 RID: 49609
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache494;

		// Token: 0x0400C1CA RID: 49610
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache495;

		// Token: 0x0400C1CB RID: 49611
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache496;

		// Token: 0x0400C1CC RID: 49612
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache497;

		// Token: 0x0400C1CD RID: 49613
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache498;

		// Token: 0x0400C1CE RID: 49614
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache499;

		// Token: 0x0400C1CF RID: 49615
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache49A;

		// Token: 0x0400C1D0 RID: 49616
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache49B;

		// Token: 0x0400C1D1 RID: 49617
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache49C;

		// Token: 0x0400C1D2 RID: 49618
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache49D;

		// Token: 0x0400C1D3 RID: 49619
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache49E;

		// Token: 0x0400C1D4 RID: 49620
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache49F;

		// Token: 0x0400C1D5 RID: 49621
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A0;

		// Token: 0x0400C1D6 RID: 49622
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A1;

		// Token: 0x0400C1D7 RID: 49623
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A2;

		// Token: 0x0400C1D8 RID: 49624
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A3;

		// Token: 0x0400C1D9 RID: 49625
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A4;

		// Token: 0x0400C1DA RID: 49626
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A5;

		// Token: 0x0400C1DB RID: 49627
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A6;

		// Token: 0x0400C1DC RID: 49628
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A7;

		// Token: 0x0400C1DD RID: 49629
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A8;

		// Token: 0x0400C1DE RID: 49630
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4A9;

		// Token: 0x0400C1DF RID: 49631
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4AA;

		// Token: 0x0400C1E0 RID: 49632
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4AB;

		// Token: 0x0400C1E1 RID: 49633
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4AC;

		// Token: 0x0400C1E2 RID: 49634
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4AD;

		// Token: 0x0400C1E3 RID: 49635
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4AE;

		// Token: 0x0400C1E4 RID: 49636
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4AF;

		// Token: 0x0400C1E5 RID: 49637
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B0;

		// Token: 0x0400C1E6 RID: 49638
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B1;

		// Token: 0x0400C1E7 RID: 49639
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B2;

		// Token: 0x0400C1E8 RID: 49640
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B3;

		// Token: 0x0400C1E9 RID: 49641
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B4;

		// Token: 0x0400C1EA RID: 49642
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B5;

		// Token: 0x0400C1EB RID: 49643
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B6;

		// Token: 0x0400C1EC RID: 49644
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B7;

		// Token: 0x0400C1ED RID: 49645
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B8;

		// Token: 0x0400C1EE RID: 49646
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4B9;

		// Token: 0x0400C1EF RID: 49647
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4BA;

		// Token: 0x0400C1F0 RID: 49648
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4BB;

		// Token: 0x0400C1F1 RID: 49649
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4BC;

		// Token: 0x0400C1F2 RID: 49650
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4BD;

		// Token: 0x0400C1F3 RID: 49651
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4BE;

		// Token: 0x0400C1F4 RID: 49652
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4BF;

		// Token: 0x0400C1F5 RID: 49653
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C0;

		// Token: 0x0400C1F6 RID: 49654
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C1;

		// Token: 0x0400C1F7 RID: 49655
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C2;

		// Token: 0x0400C1F8 RID: 49656
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C3;

		// Token: 0x0400C1F9 RID: 49657
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C4;

		// Token: 0x0400C1FA RID: 49658
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C5;

		// Token: 0x0400C1FB RID: 49659
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C6;

		// Token: 0x0400C1FC RID: 49660
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C7;

		// Token: 0x0400C1FD RID: 49661
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C8;

		// Token: 0x0400C1FE RID: 49662
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4C9;

		// Token: 0x0400C1FF RID: 49663
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4CA;

		// Token: 0x0400C200 RID: 49664
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4CB;

		// Token: 0x0400C201 RID: 49665
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4CC;

		// Token: 0x0400C202 RID: 49666
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4CD;

		// Token: 0x0400C203 RID: 49667
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4CE;

		// Token: 0x0400C204 RID: 49668
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4CF;

		// Token: 0x0400C205 RID: 49669
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D0;

		// Token: 0x0400C206 RID: 49670
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D1;

		// Token: 0x0400C207 RID: 49671
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D2;

		// Token: 0x0400C208 RID: 49672
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D3;

		// Token: 0x0400C209 RID: 49673
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D4;

		// Token: 0x0400C20A RID: 49674
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D5;

		// Token: 0x0400C20B RID: 49675
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D6;

		// Token: 0x0400C20C RID: 49676
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D7;

		// Token: 0x0400C20D RID: 49677
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D8;

		// Token: 0x0400C20E RID: 49678
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4D9;

		// Token: 0x0400C20F RID: 49679
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4DA;

		// Token: 0x0400C210 RID: 49680
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4DB;

		// Token: 0x0400C211 RID: 49681
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4DC;

		// Token: 0x0400C212 RID: 49682
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4DD;

		// Token: 0x0400C213 RID: 49683
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4DE;

		// Token: 0x0400C214 RID: 49684
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4DF;

		// Token: 0x0400C215 RID: 49685
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E0;

		// Token: 0x0400C216 RID: 49686
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E1;

		// Token: 0x0400C217 RID: 49687
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E2;

		// Token: 0x0400C218 RID: 49688
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E3;

		// Token: 0x0400C219 RID: 49689
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E4;

		// Token: 0x0400C21A RID: 49690
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E5;

		// Token: 0x0400C21B RID: 49691
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E6;

		// Token: 0x0400C21C RID: 49692
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E7;

		// Token: 0x0400C21D RID: 49693
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E8;

		// Token: 0x0400C21E RID: 49694
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4E9;

		// Token: 0x0400C21F RID: 49695
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4EA;

		// Token: 0x0400C220 RID: 49696
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4EB;

		// Token: 0x0400C221 RID: 49697
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4EC;

		// Token: 0x0400C222 RID: 49698
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4ED;

		// Token: 0x0400C223 RID: 49699
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4EE;

		// Token: 0x0400C224 RID: 49700
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4EF;

		// Token: 0x0400C225 RID: 49701
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F0;

		// Token: 0x0400C226 RID: 49702
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F1;

		// Token: 0x0400C227 RID: 49703
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F2;

		// Token: 0x0400C228 RID: 49704
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F3;

		// Token: 0x0400C229 RID: 49705
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F4;

		// Token: 0x0400C22A RID: 49706
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F5;

		// Token: 0x0400C22B RID: 49707
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F6;

		// Token: 0x0400C22C RID: 49708
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F7;

		// Token: 0x0400C22D RID: 49709
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F8;

		// Token: 0x0400C22E RID: 49710
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4F9;

		// Token: 0x0400C22F RID: 49711
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4FA;

		// Token: 0x0400C230 RID: 49712
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4FB;

		// Token: 0x0400C231 RID: 49713
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4FC;

		// Token: 0x0400C232 RID: 49714
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4FD;

		// Token: 0x0400C233 RID: 49715
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4FE;

		// Token: 0x0400C234 RID: 49716
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache4FF;

		// Token: 0x0400C235 RID: 49717
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache500;

		// Token: 0x0400C236 RID: 49718
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache501;

		// Token: 0x0400C237 RID: 49719
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache502;

		// Token: 0x0400C238 RID: 49720
		[CompilerGenerated]
		private static Action<IntPtr> <>f__mg$cache503;
	}
}
