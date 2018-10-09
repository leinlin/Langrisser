using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003A7 RID: 935
	[HotFix]
	public class BattlePlayer
	{
		// Token: 0x0600370C RID: 14092 RVA: 0x000F524C File Offset: 0x000F344C
		public BattlePlayer()
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

		// Token: 0x0600370D RID: 14093 RVA: 0x000F52B4 File Offset: 0x000F34B4
		public List<ConfigDataSkillInfo> GetTrainingTechSoldierSkillInfos(IConfigDataLoader configDataLoader, ConfigDataSoldierInfo soldierInfo, out int soldierSkillLevelUp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTrainingTechSoldierSkillInfosIConfigDataLoaderConfigDataSoldierInfoInt32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Battle_BattlePlayer_GetTrainingTechSoldierSkillInfos_IConfigDataLoader_ConfigDataSoldierInfo_Int32(this, this.m_GetTrainingTechSoldierSkillInfosIConfigDataLoaderConfigDataSoldierInfoInt32__hotfix, configDataLoader, soldierInfo, out soldierSkillLevelUp);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataSkillInfo> list = new List<ConfigDataSkillInfo>();
			soldierSkillLevelUp = 0;
			if (this.TrainingTechs == null || soldierInfo == null)
			{
				return list;
			}
			foreach (BattlePlayerTrainingTech battlePlayerTrainingTech in this.TrainingTechs)
			{
				ConfigDataTrainingTechInfo trainingTechInfo = battlePlayerTrainingTech.TrainingTechInfo;
				if (!trainingTechInfo.IsSummon)
				{
					if (trainingTechInfo.SoldierIDRelated.Contains(soldierInfo.ID) || trainingTechInfo.ArmyIDRelated.Contains(soldierInfo.Army_ID))
					{
						int num = 0;
						int num2 = 0;
						while (num2 < battlePlayerTrainingTech.Level && num2 < trainingTechInfo.m_techLevelupInfo.Count)
						{
							ConfigDataTrainingTechLevelInfo configDataTrainingTechLevelInfo = trainingTechInfo.m_techLevelupInfo[num2];
							if (configDataTrainingTechLevelInfo.SoldierSkillID != 0)
							{
								num = configDataTrainingTechLevelInfo.SoldierSkillID;
							}
							if (configDataTrainingTechLevelInfo.SoldierSkillLevelup > soldierSkillLevelUp)
							{
								soldierSkillLevelUp = configDataTrainingTechLevelInfo.SoldierSkillLevelup;
							}
							num2++;
						}
						if (num != 0)
						{
							ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(num);
							if (configDataSkillInfo != null)
							{
								list.Add(configDataSkillInfo);
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x000F5424 File Offset: 0x000F3624
		public List<ConfigDataSkillInfo> GetTrainingTechSummonSkills(IConfigDataLoader configDataLoader, ConfigDataHeroInfo heroInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTrainingTechSummonSkillsIConfigDataLoaderConfigDataHeroInfo_hotfix != null)
			{
				return (List<ConfigDataSkillInfo>)this.m_GetTrainingTechSummonSkillsIConfigDataLoaderConfigDataHeroInfo_hotfix.call(new object[]
				{
					this,
					configDataLoader,
					heroInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ConfigDataSkillInfo> list = new List<ConfigDataSkillInfo>();
			if (this.TrainingTechs == null || heroInfo == null)
			{
				return list;
			}
			foreach (BattlePlayerTrainingTech battlePlayerTrainingTech in this.TrainingTechs)
			{
				ConfigDataTrainingTechInfo trainingTechInfo = battlePlayerTrainingTech.TrainingTechInfo;
				if (trainingTechInfo.IsSummon)
				{
					if (trainingTechInfo.SoldierIDRelated.Contains(heroInfo.ID) || trainingTechInfo.ArmyIDRelated.Contains(heroInfo.m_jobConnectionInfo.m_jobInfo.Army_ID))
					{
						int num = 0;
						int num2 = 0;
						while (num2 < battlePlayerTrainingTech.Level && num2 < trainingTechInfo.m_techLevelupInfo.Count)
						{
							ConfigDataTrainingTechLevelInfo configDataTrainingTechLevelInfo = trainingTechInfo.m_techLevelupInfo[num2];
							if (configDataTrainingTechLevelInfo.SoldierSkillID != 0)
							{
								num = configDataTrainingTechLevelInfo.SoldierSkillID;
							}
							num2++;
						}
						if (num != 0)
						{
							ConfigDataSkillInfo configDataSkillInfo = configDataLoader.GetConfigDataSkillInfo(num);
							if (configDataSkillInfo != null)
							{
								list.Add(configDataSkillInfo);
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x0600370F RID: 14095 RVA: 0x000F55B0 File Offset: 0x000F37B0
		// (set) Token: 0x06003710 RID: 14096 RVA: 0x000F55D0 File Offset: 0x000F37D0
		[DoNotToLua]
		public BattlePlayer.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattlePlayer.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x000F55DC File Offset: 0x000F37DC
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
					this.m_GetTrainingTechSoldierSkillInfosIConfigDataLoaderConfigDataSoldierInfoInt32__hotfix = (luaObj.RawGet("GetTrainingTechSoldierSkillInfos") as LuaFunction);
					this.m_GetTrainingTechSummonSkillsIConfigDataLoaderConfigDataHeroInfo_hotfix = (luaObj.RawGet("GetTrainingTechSummonSkills") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x000F56DC File Offset: 0x000F38DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePlayer));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002A4E RID: 10830
		public ulong SessionId;

		// Token: 0x04002A4F RID: 10831
		public int PlayerLevel;

		// Token: 0x04002A50 RID: 10832
		public BattlePlayerTrainingTech[] TrainingTechs;

		// Token: 0x04002A51 RID: 10833
		[DoNotToLua]
		private BattlePlayer.LuaExportHelper luaExportHelper;

		// Token: 0x04002A52 RID: 10834
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002A53 RID: 10835
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002A54 RID: 10836
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002A55 RID: 10837
		private LuaFunction m_GetTrainingTechSoldierSkillInfosIConfigDataLoaderConfigDataSoldierInfoInt32__hotfix;

		// Token: 0x04002A56 RID: 10838
		private LuaFunction m_GetTrainingTechSummonSkillsIConfigDataLoaderConfigDataHeroInfo_hotfix;

		// Token: 0x020003A8 RID: 936
		public class LuaExportHelper
		{
			// Token: 0x06003713 RID: 14099 RVA: 0x000F5744 File Offset: 0x000F3944
			public LuaExportHelper(BattlePlayer owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002A57 RID: 10839
			private BattlePlayer m_owner;
		}
	}
}
