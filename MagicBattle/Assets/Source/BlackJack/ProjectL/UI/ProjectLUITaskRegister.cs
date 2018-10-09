using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Misc;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EA0 RID: 3744
	[HotFix]
	public class ProjectLUITaskRegister
	{
		// Token: 0x0601249E RID: 74910 RVA: 0x004B2BF4 File Offset: 0x004B0DF4
		public ProjectLUITaskRegister()
		{
			if (!SystemUtility.IsLowSystemMemory())
			{
				this.RegisterUITasksNormal();
			}
			else
			{
				this.RegisterUITasksForLowMem();
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
		}

		// Token: 0x0601249F RID: 74911 RVA: 0x004B2C78 File Offset: 0x004B0E78
		private void RegisterUITasksForLowMem()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterUITasksForLowMem_hotfix != null)
			{
				this.m_RegisterUITasksForLowMem_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("ProjectLUITaskRegister.RegisterUITasksForLowMem");
			ProjectLUITaskRegister.RegisterUITask("LoginUITask", UIGroup4LowMem.Login);
			ProjectLUITaskRegister.RegisterUITask("ReloginUITask", UIGroup4LowMem.ReLogin);
			ProjectLUITaskRegister.RegisterUITask("PreloadUITask", UIGroup4LowMem.Preload);
			ProjectLUITaskRegister.RegisterUITask("CommonUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("InviteNotifyUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("NoticeUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("ChatUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("UserGuideUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("UserGuideDialogUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("PlayerSettingUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("PlayerLevelUpUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("PlayerSimpleInfoUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("BusinessCardUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("ChestUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("GetRewardGoodsUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("InstructionUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("RewardGoodsDescUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("VoiceRecordUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("HeroSkinChangeUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("StoreSoldierSkinDetailUITask", UIGroup4LowMem.Common);
			ProjectLUITaskRegister.RegisterUITask("WorldUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("WorldEventMissionUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("BuyEnergyUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("EnergyStatusUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("GetPathUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("MonthCardInfoUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("DialogUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("GoddessDialogUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("HeroListUITask", UIGroup4LowMem.Hero);
			ProjectLUITaskRegister.RegisterUITask("HeroJobTransferUITask", UIGroup4LowMem.Hero);
			ProjectLUITaskRegister.RegisterUITask("HeroCommentUITask", UIGroup4LowMem.Hero);
			ProjectLUITaskRegister.RegisterUITask("EquipmentDepotUITask", UIGroup4LowMem.Hero);
			ProjectLUITaskRegister.RegisterUITask("EquipmentForgeUITask", UIGroup4LowMem.Hero);
			ProjectLUITaskRegister.RegisterUITask("BagListUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("BagFullUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("MissionUITask", UIGroup4LowMem.Mission);
			ProjectLUITaskRegister.RegisterUITask("SelectCardUITask", UIGroup4LowMem.SelectCard);
			ProjectLUITaskRegister.RegisterUITask("HeroBreakEffectUITask", UIGroup4LowMem.Hero);
			ProjectLUITaskRegister.RegisterUITask("HeroBreakRarityUpUITask", UIGroup4LowMem.Hero);
			ProjectLUITaskRegister.RegisterUITask("StoreUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("FriendUITask", UIGroup4LowMem.Friend);
			ProjectLUITaskRegister.RegisterUITask("FettersUITask", UIGroup4LowMem.Fetters);
			ProjectLUITaskRegister.RegisterUITask("DrillUITask", UIGroup4LowMem.Drill);
			ProjectLUITaskRegister.RegisterUITask("HeroSoldierSkinUITask", UIGroup4LowMem.Hero);
			ProjectLUITaskRegister.RegisterUITask("GuildUITask", UIGroup4LowMem.Guild);
			ProjectLUITaskRegister.RegisterUITask("GuildManagementUITask", UIGroup4LowMem.Guild);
			ProjectLUITaskRegister.RegisterUITask("GuildGameListUITask", UIGroup4LowMem.Guild);
			ProjectLUITaskRegister.RegisterUITask("GuildRaidUITask", UIGroup4LowMem.Guild);
			ProjectLUITaskRegister.RegisterUITask("GuildMassiveCombatUITask", UIGroup4LowMem.Guild);
			ProjectLUITaskRegister.RegisterUITask("GuildStoreUITask", UIGroup4LowMem.Guild);
			ProjectLUITaskRegister.RegisterUITask("NormalItemBuyUITask", UIGroup4LowMem.Guild);
			ProjectLUITaskRegister.RegisterUITask("RiftUITask", UIGroup4LowMem.Rift);
			ProjectLUITaskRegister.RegisterUITask("BattleLevelInfoUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("RaidLevelUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("HeroDungeonUITask", UIGroup4LowMem.Fetters);
			ProjectLUITaskRegister.RegisterUITask("UnchartedUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("ThearchyUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("AnikiUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("TreasureMapUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("MemoryCorridorUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("HeroTrainningUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("HeroPhantomUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("CooperateBattleUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("UnchartedScoreUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("ClimbTowerUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("ClimbTowerLevelInfoUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("ClimbTowerRaidUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("TeamUITask", UIGroup4LowMem.Uncharted);
			ProjectLUITaskRegister.RegisterUITask("TeamRoomInfoUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("TeamRoomInviteUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("ArenaSelectUITask", UIGroup4LowMem.Arena);
			ProjectLUITaskRegister.RegisterUITask("ArenaUITask", UIGroup4LowMem.Arena);
			ProjectLUITaskRegister.RegisterUITask("ArenaDefendUITask", UIGroup4LowMem.Arena);
			ProjectLUITaskRegister.RegisterUITask("OpenServiceActivityUITask", UIGroup4LowMem.Activity);
			ProjectLUITaskRegister.RegisterUITask("ActivityUITask", UIGroup4LowMem.Activity);
			ProjectLUITaskRegister.RegisterUITask("RaffleUITask", UIGroup4LowMem.Activity);
			ProjectLUITaskRegister.RegisterUITask("PlayerInfoUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("MailUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("WaitPVPInviteUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("RankingUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("SignUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("TestUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("ActivityNoticeUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("ARUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("ArchiveUITask", UIGroup4LowMem.World);
			ProjectLUITaskRegister.RegisterUITask("BattleUITask", UIGroup4LowMem.Battle);
			ProjectLUITaskRegister.RegisterUITask("BattleResultUITask", UIGroup4LowMem.Battle);
			ProjectLUITaskRegister.RegisterUITask("BattleResultScoreUITask", UIGroup4LowMem.Battle);
			ProjectLUITaskRegister.RegisterUITask("BattleLoseUITask", UIGroup4LowMem.Battle);
			ProjectLUITaskRegister.RegisterUITask("BattleReportEndUITask", UIGroup4LowMem.Battle);
			ProjectLUITaskRegister.RegisterUITask("BattleDialogUITask", UIGroup4LowMem.Battle);
			ProjectLUITaskRegister.RegisterUITask("AppScoreUITask", UIGroup4LowMem.Battle);
			ProjectLUITaskRegister.SetUITaskGroupConflict(UIGroup4LowMem.Login, UIGroup4LowMem.Common);
			ProjectLUITaskRegister.SetUITaskGroupConflict(UIGroup4LowMem.Login, UIGroup4LowMem.World);
			ProjectLUITaskRegister.SetUITaskGroupConflict(UIGroup4LowMem.Login, UIGroup4LowMem.Battle);
			ProjectLUITaskRegister.SetUITaskGroupConflict(UIGroup.World, UIGroup.Battle);
			UIGroup4LowMem[] array = new UIGroup4LowMem[]
			{
				UIGroup4LowMem.Hero,
				UIGroup4LowMem.SelectCard,
				UIGroup4LowMem.Mission,
				UIGroup4LowMem.Drill,
				UIGroup4LowMem.Fetters,
				UIGroup4LowMem.Rift,
				UIGroup4LowMem.Arena,
				UIGroup4LowMem.Uncharted,
				UIGroup4LowMem.Activity,
				UIGroup4LowMem.Friend
			};
			foreach (UIGroup4LowMem group in array)
			{
				ProjectLUITaskRegister.SetUITaskGroupConflict(UIGroup4LowMem.Battle, group);
			}
			for (int j = 0; j < array.Length; j++)
			{
				for (int k = 0; k < array.Length; k++)
				{
					if (array[j] != array[k])
					{
						ProjectLUITaskRegister.SetUITaskGroupConflict(array[j], array[k]);
					}
				}
			}
		}

		// Token: 0x060124A0 RID: 74912 RVA: 0x004B3190 File Offset: 0x004B1390
		private void RegisterUITasksNormal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterUITasksNormal_hotfix != null)
			{
				this.m_RegisterUITasksNormal_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log("ProjectLUITaskRegister.RegisterUITasksNormal");
			ProjectLUITaskRegister.RegisterUITask("LoginUITask", UIGroup.Login);
			ProjectLUITaskRegister.RegisterUITask("ReloginUITask", UIGroup.ReLogin);
			ProjectLUITaskRegister.RegisterUITask("PreloadUITask", UIGroup.Preload);
			ProjectLUITaskRegister.RegisterUITask("CommonUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("InviteNotifyUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("NoticeUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("ChatUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("UserGuideUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("UserGuideDialogUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("PlayerSettingUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("PlayerLevelUpUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("PlayerSimpleInfoUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("BusinessCardUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("ChestUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("GetRewardGoodsUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("InstructionUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("RewardGoodsDescUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("VoiceRecordUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("HeroSkinChangeUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("StoreSoldierSkinDetailUITask", UIGroup.Common);
			ProjectLUITaskRegister.RegisterUITask("WorldUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("WorldEventMissionUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("BuyEnergyUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("EnergyStatusUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("GetPathUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("MonthCardInfoUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("DialogUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("GoddessDialogUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("HeroListUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("HeroJobTransferUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("HeroCommentUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("EquipmentDepotUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("EquipmentForgeUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("BagListUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("BagFullUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("MissionUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("SelectCardUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("HeroBreakEffectUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("HeroBreakRarityUpUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("StoreUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("FriendUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("FettersUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("DrillUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("HeroSoldierSkinUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("GuildUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("GuildManagementUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("GuildRaidUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("GuildGameListUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("GuildStoreUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("NormalItemBuyUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("GuildMassiveCombatUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("RiftUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("BattleLevelInfoUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("RaidLevelUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("HeroDungeonUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("UnchartedUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ThearchyUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("AnikiUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("TreasureMapUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("MemoryCorridorUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("HeroTrainningUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("HeroPhantomUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("CooperateBattleUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("UnchartedScoreUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ClimbTowerUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ClimbTowerLevelInfoUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ClimbTowerRaidUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("TeamUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("TeamRoomInfoUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("TeamRoomInviteUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ArenaSelectUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ArenaUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ArenaDefendUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("OpenServiceActivityUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ActivityUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("RaffleUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("PlayerInfoUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("MailUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("WaitPVPInviteUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("RankingUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("SignUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("TestUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ActivityNoticeUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ARUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("ArchiveUITask", UIGroup.World);
			ProjectLUITaskRegister.RegisterUITask("BattleUITask", UIGroup.Battle);
			ProjectLUITaskRegister.RegisterUITask("BattleResultUITask", UIGroup.Battle);
			ProjectLUITaskRegister.RegisterUITask("BattleResultScoreUITask", UIGroup.Battle);
			ProjectLUITaskRegister.RegisterUITask("BattleLoseUITask", UIGroup.Battle);
			ProjectLUITaskRegister.RegisterUITask("BattleReportEndUITask", UIGroup.Battle);
			ProjectLUITaskRegister.RegisterUITask("BattleDialogUITask", UIGroup.Battle);
			ProjectLUITaskRegister.RegisterUITask("AppScoreUITask", UIGroup.Battle);
			ProjectLUITaskRegister.SetUITaskGroupConflict(UIGroup.Login, UIGroup.Common);
			ProjectLUITaskRegister.SetUITaskGroupConflict(UIGroup.Login, UIGroup.World);
			ProjectLUITaskRegister.SetUITaskGroupConflict(UIGroup.Login, UIGroup.Battle);
			ProjectLUITaskRegister.SetUITaskGroupConflict(UIGroup.World, UIGroup.Battle);
		}

		// Token: 0x060124A1 RID: 74913 RVA: 0x004B360C File Offset: 0x004B180C
		private static void RegisterUITask(string name, UIGroup group)
		{
			UIManager.Instance.RegisterUITaskWithGroup(name, new TypeDNName("BlackJack.ProjectL.UI." + name), (int)group, null);
		}

		// Token: 0x060124A2 RID: 74914 RVA: 0x004B362C File Offset: 0x004B182C
		private static void SetUITaskGroupConflict(UIGroup group1, UIGroup group2)
		{
			UIManager.Instance.SetUITaskGroupConflict((uint)group1, (uint)group2);
		}

		// Token: 0x060124A3 RID: 74915 RVA: 0x004B363C File Offset: 0x004B183C
		private static void RegisterUITask(string name, UIGroup4LowMem group)
		{
			UIManager.Instance.RegisterUITaskWithGroup(name, new TypeDNName("BlackJack.ProjectL.UI." + name), (int)group, null);
		}

		// Token: 0x060124A4 RID: 74916 RVA: 0x004B365C File Offset: 0x004B185C
		private static void SetUITaskGroupConflict(UIGroup4LowMem group1, UIGroup4LowMem group2)
		{
			UIManager.Instance.SetUITaskGroupConflict((uint)group1, (uint)group2);
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x060124A5 RID: 74917 RVA: 0x004B366C File Offset: 0x004B186C
		// (set) Token: 0x060124A6 RID: 74918 RVA: 0x004B368C File Offset: 0x004B188C
		[DoNotToLua]
		public ProjectLUITaskRegister.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ProjectLUITaskRegister.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060124A7 RID: 74919 RVA: 0x004B3698 File Offset: 0x004B1898
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
					this.m_RegisterUITasksForLowMem_hotfix = (luaObj.RawGet("RegisterUITasksForLowMem") as LuaFunction);
					this.m_RegisterUITasksNormal_hotfix = (luaObj.RawGet("RegisterUITasksNormal") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060124A8 RID: 74920 RVA: 0x004B3798 File Offset: 0x004B1998
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProjectLUITaskRegister));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A4D0 RID: 42192
		[DoNotToLua]
		private ProjectLUITaskRegister.LuaExportHelper luaExportHelper;

		// Token: 0x0400A4D1 RID: 42193
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A4D2 RID: 42194
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A4D3 RID: 42195
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400A4D4 RID: 42196
		private LuaFunction m_RegisterUITasksForLowMem_hotfix;

		// Token: 0x0400A4D5 RID: 42197
		private LuaFunction m_RegisterUITasksNormal_hotfix;

		// Token: 0x02000EA1 RID: 3745
		public class LuaExportHelper
		{
			// Token: 0x060124A9 RID: 74921 RVA: 0x004B3800 File Offset: 0x004B1A00
			public LuaExportHelper(ProjectLUITaskRegister owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060124AA RID: 74922 RVA: 0x004B3810 File Offset: 0x004B1A10
			public void RegisterUITasksForLowMem()
			{
				this.m_owner.RegisterUITasksForLowMem();
			}

			// Token: 0x060124AB RID: 74923 RVA: 0x004B3820 File Offset: 0x004B1A20
			public void RegisterUITasksNormal()
			{
				this.m_owner.RegisterUITasksNormal();
			}

			// Token: 0x060124AC RID: 74924 RVA: 0x004B3830 File Offset: 0x004B1A30
			public static void RegisterUITask(string name, UIGroup group)
			{
				ProjectLUITaskRegister.RegisterUITask(name, group);
			}

			// Token: 0x060124AD RID: 74925 RVA: 0x004B383C File Offset: 0x004B1A3C
			public static void SetUITaskGroupConflict(UIGroup group1, UIGroup group2)
			{
				ProjectLUITaskRegister.SetUITaskGroupConflict(group1, group2);
			}

			// Token: 0x060124AE RID: 74926 RVA: 0x004B3848 File Offset: 0x004B1A48
			public static void RegisterUITask(string name, UIGroup4LowMem group)
			{
				ProjectLUITaskRegister.RegisterUITask(name, group);
			}

			// Token: 0x060124AF RID: 74927 RVA: 0x004B3854 File Offset: 0x004B1A54
			public static void SetUITaskGroupConflict(UIGroup4LowMem group1, UIGroup4LowMem group2)
			{
				ProjectLUITaskRegister.SetUITaskGroupConflict(group1, group2);
			}

			// Token: 0x0400A4D6 RID: 42198
			private ProjectLUITaskRegister m_owner;
		}
	}
}
