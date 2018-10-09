using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000451 RID: 1105
	[HotFix]
	public class DanmakuComponentCommon : IComponentBase
	{
		// Token: 0x06004033 RID: 16435 RVA: 0x0012A3B4 File Offset: 0x001285B4
		public DanmakuComponentCommon()
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

		// Token: 0x06004034 RID: 16436 RVA: 0x0012A41C File Offset: 0x0012861C
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "Danmaku";
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x0012A490 File Offset: 0x00128690
		public virtual void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x0012A4F0 File Offset: 0x001286F0
		public virtual void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x0012A550 File Offset: 0x00128750
		public virtual void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x0012A5B0 File Offset: 0x001287B0
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x0012A620 File Offset: 0x00128820
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x0012A6A0 File Offset: 0x001288A0
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x0012A710 File Offset: 0x00128910
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600403C RID: 16444 RVA: 0x0012A770 File Offset: 0x00128970
		// (set) Token: 0x0600403D RID: 16445 RVA: 0x0012A7E4 File Offset: 0x001289E4
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x0012A85C File Offset: 0x00128A5C
		public int CanGetLevelDanmaku(int gameFunctionTypeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGetLevelDanmakuInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGetLevelDanmakuInt32Int32_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId,
					locationId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (gameFunctionTypeId)
			{
			case 9:
				if (this.m_configDataLoader.GetConfigDataRiftLevelInfo(locationId) == null)
				{
					return -2701;
				}
				break;
			case 10:
				if (this.m_configDataLoader.GetConfigDataScenarioInfo(locationId) == null)
				{
					return -2701;
				}
				break;
			case 11:
				if (this.m_configDataLoader.GetConfigDataEventInfo(locationId) == null)
				{
					return -2701;
				}
				break;
			case 12:
				if (this.m_configDataLoader.GetConfigDataAnikiLevelInfo(locationId) == null)
				{
					return -2701;
				}
				break;
			case 13:
				if (this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(locationId) == null)
				{
					return -2701;
				}
				break;
			default:
				if (gameFunctionTypeId != 41)
				{
					if (gameFunctionTypeId != 42)
					{
						if (gameFunctionTypeId != 56)
						{
							if (gameFunctionTypeId != 57)
							{
								if (gameFunctionTypeId != 79)
								{
									if (gameFunctionTypeId != 80)
									{
										if (gameFunctionTypeId != 28)
										{
											if (gameFunctionTypeId != 51)
											{
												return -2700;
											}
											if (this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(locationId) == null)
											{
												return -2701;
											}
										}
										else if (this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(locationId) == null)
										{
											return -2701;
										}
									}
									else if (this.m_configDataLoader.GetConfigDataScoreLevelInfo(locationId) == null)
									{
										return -2701;
									}
								}
								else if (this.m_configDataLoader.GetConfigDataChallengeLevelInfo(locationId) == null)
								{
									return -2701;
								}
							}
							else if (this.m_configDataLoader.GetConfigDataCooperateBattleLevelInfo(locationId) == null)
							{
								return -2701;
							}
						}
						else if (this.m_configDataLoader.GetConfigDataHeroPhantomLevelInfo(locationId) == null)
						{
							return -2701;
						}
					}
					else if (this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(locationId) == null)
					{
						return -2701;
					}
				}
				else if (this.m_configDataLoader.GetConfigDataTreasureLevelInfo(locationId) == null)
				{
					return -2701;
				}
				break;
			}
			return 0;
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x0012AAF0 File Offset: 0x00128CF0
		public int CanPostLevelDanmaku(int gameFunctionTypeId, int locationId, List<PostDanmakuEntry> entries)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanPostLevelDanmakuInt32Int32List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanPostLevelDanmakuInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId,
					locationId,
					entries
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int battle_ID;
			switch (gameFunctionTypeId)
			{
			case 9:
			{
				ConfigDataRiftLevelInfo configDataRiftLevelInfo = this.m_configDataLoader.GetConfigDataRiftLevelInfo(locationId);
				if (configDataRiftLevelInfo == null)
				{
					return -2701;
				}
				battle_ID = configDataRiftLevelInfo.Battle_ID;
				break;
			}
			case 10:
			{
				ConfigDataScenarioInfo configDataScenarioInfo = this.m_configDataLoader.GetConfigDataScenarioInfo(locationId);
				if (configDataScenarioInfo == null)
				{
					return -2701;
				}
				battle_ID = configDataScenarioInfo.Battle_ID;
				break;
			}
			case 11:
			{
				ConfigDataEventInfo configDataEventInfo = this.m_configDataLoader.GetConfigDataEventInfo(locationId);
				if (configDataEventInfo == null)
				{
					return -2701;
				}
				battle_ID = configDataEventInfo.Battle_ID;
				break;
			}
			case 12:
			{
				ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = this.m_configDataLoader.GetConfigDataAnikiLevelInfo(locationId);
				if (configDataAnikiLevelInfo == null)
				{
					return -2701;
				}
				battle_ID = configDataAnikiLevelInfo.Battle_ID;
				break;
			}
			case 13:
			{
				ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(locationId);
				if (configDataThearchyTrialLevelInfo == null)
				{
					return -2701;
				}
				battle_ID = configDataThearchyTrialLevelInfo.Battle_ID;
				break;
			}
			default:
				if (gameFunctionTypeId != 41)
				{
					if (gameFunctionTypeId != 42)
					{
						if (gameFunctionTypeId != 56)
						{
							if (gameFunctionTypeId != 57)
							{
								if (gameFunctionTypeId != 79)
								{
									if (gameFunctionTypeId != 80)
									{
										if (gameFunctionTypeId != 28)
										{
											if (gameFunctionTypeId != 51)
											{
												return -2700;
											}
											ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(locationId);
											if (configDataHeroTrainningLevelInfo == null)
											{
												return -2701;
											}
											battle_ID = configDataHeroTrainningLevelInfo.Battle_ID;
										}
										else
										{
											ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(locationId);
											if (configDataHeroDungeonLevelInfo == null)
											{
												return -2701;
											}
											battle_ID = configDataHeroDungeonLevelInfo.Battle_ID;
										}
									}
									else
									{
										ConfigDataScoreLevelInfo configDataScoreLevelInfo = this.m_configDataLoader.GetConfigDataScoreLevelInfo(locationId);
										if (configDataScoreLevelInfo == null)
										{
											return -2701;
										}
										battle_ID = configDataScoreLevelInfo.Battle_ID;
									}
								}
								else
								{
									ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = this.m_configDataLoader.GetConfigDataChallengeLevelInfo(locationId);
									if (configDataChallengeLevelInfo == null)
									{
										return -2701;
									}
									battle_ID = configDataChallengeLevelInfo.Battle_ID;
								}
							}
							else
							{
								ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = this.m_configDataLoader.GetConfigDataCooperateBattleLevelInfo(locationId);
								if (configDataCooperateBattleLevelInfo == null)
								{
									return -2701;
								}
								battle_ID = configDataCooperateBattleLevelInfo.Battle_ID;
							}
						}
						else
						{
							ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = this.m_configDataLoader.GetConfigDataHeroPhantomLevelInfo(locationId);
							if (configDataHeroPhantomLevelInfo == null)
							{
								return -2701;
							}
							battle_ID = configDataHeroPhantomLevelInfo.Battle_ID;
						}
					}
					else
					{
						ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(locationId);
						if (configDataMemoryCorridorLevelInfo == null)
						{
							return -2701;
						}
						battle_ID = configDataMemoryCorridorLevelInfo.Battle_ID;
					}
				}
				else
				{
					ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = this.m_configDataLoader.GetConfigDataTreasureLevelInfo(locationId);
					if (configDataTreasureLevelInfo == null)
					{
						return -2701;
					}
					battle_ID = configDataTreasureLevelInfo.Battle_ID;
				}
				break;
			}
			ConfigDataBattleInfo configDataBattleInfo = this.m_configDataLoader.GetConfigDataBattleInfo(battle_ID);
			int num = 0;
			foreach (PostDanmakuEntry postDanmakuEntry in entries)
			{
				if (postDanmakuEntry.Turn > configDataBattleInfo.TurnMax)
				{
					return -2702;
				}
				if (postDanmakuEntry.Turn <= num)
				{
					return -2703;
				}
				num = postDanmakuEntry.Turn;
			}
			return 0;
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x0012AE9C File Offset: 0x0012909C
		public string CombineLevelDanmakuKey(int gameFunctionTypeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombineLevelDanmakuKeyInt32Int32_hotfix != null)
			{
				return (string)this.m_CombineLevelDanmakuKeyInt32Int32_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId,
					locationId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return CombineStringTools.BuildParam(new object[]
			{
				gameFunctionTypeId,
				locationId
			});
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x0012AF48 File Offset: 0x00129148
		protected void TruncateDanmakuOrNot(PostDanmakuEntry entry)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TruncateDanmakuOrNotPostDanmakuEntry_hotfix != null)
			{
				this.m_TruncateDanmakuOrNotPostDanmakuEntry_hotfix.call(new object[]
				{
					this,
					entry
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (entry.Content.Length > this.m_configDataLoader.ConfigableConstId_MaxLevelDanmakuEntryLength)
			{
				entry.Content = entry.Content.Substring(0, this.m_configDataLoader.ConfigableConstId_ChatMessageMaxLength);
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06004042 RID: 16450 RVA: 0x0012AFF0 File Offset: 0x001291F0
		// (set) Token: 0x06004043 RID: 16451 RVA: 0x0012B010 File Offset: 0x00129210
		[DoNotToLua]
		public DanmakuComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DanmakuComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x0012B01C File Offset: 0x0012921C
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_CanGetLevelDanmakuInt32Int32_hotfix = (luaObj.RawGet("CanGetLevelDanmaku") as LuaFunction);
					this.m_CanPostLevelDanmakuInt32Int32List`1_hotfix = (luaObj.RawGet("CanPostLevelDanmaku") as LuaFunction);
					this.m_CombineLevelDanmakuKeyInt32Int32_hotfix = (luaObj.RawGet("CombineLevelDanmakuKey") as LuaFunction);
					this.m_TruncateDanmakuOrNotPostDanmakuEntry_hotfix = (luaObj.RawGet("TruncateDanmakuOrNot") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x0012B248 File Offset: 0x00129448
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DanmakuComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040030F0 RID: 12528
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x040030F1 RID: 12529
		[DoNotToLua]
		private DanmakuComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040030F2 RID: 12530
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040030F3 RID: 12531
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040030F4 RID: 12532
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040030F5 RID: 12533
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040030F6 RID: 12534
		private LuaFunction m_Init_hotfix;

		// Token: 0x040030F7 RID: 12535
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040030F8 RID: 12536
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040030F9 RID: 12537
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040030FA RID: 12538
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040030FB RID: 12539
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040030FC RID: 12540
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040030FD RID: 12541
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040030FE RID: 12542
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040030FF RID: 12543
		private LuaFunction m_CanGetLevelDanmakuInt32Int32_hotfix;

		// Token: 0x04003100 RID: 12544
		private LuaFunction m_CanPostLevelDanmakuInt32Int32List;

		// Token: 0x04003101 RID: 12545
		private LuaFunction m_CombineLevelDanmakuKeyInt32Int32_hotfix;

		// Token: 0x04003102 RID: 12546
		private LuaFunction m_TruncateDanmakuOrNotPostDanmakuEntry_hotfix;

		// Token: 0x02000452 RID: 1106
		public class LuaExportHelper
		{
			// Token: 0x06004046 RID: 16454 RVA: 0x0012B2B0 File Offset: 0x001294B0
			public LuaExportHelper(DanmakuComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001123 RID: 4387
			// (get) Token: 0x06004047 RID: 16455 RVA: 0x0012B2C0 File Offset: 0x001294C0
			// (set) Token: 0x06004048 RID: 16456 RVA: 0x0012B2D0 File Offset: 0x001294D0
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x06004049 RID: 16457 RVA: 0x0012B2E0 File Offset: 0x001294E0
			public void TruncateDanmakuOrNot(PostDanmakuEntry entry)
			{
				this.m_owner.TruncateDanmakuOrNot(entry);
			}

			// Token: 0x04003103 RID: 12547
			private DanmakuComponentCommon m_owner;
		}
	}
}
