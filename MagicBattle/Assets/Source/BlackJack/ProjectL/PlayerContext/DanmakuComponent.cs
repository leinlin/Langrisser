using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008A5 RID: 2213
	[HotFix]
	public class DanmakuComponent : DanmakuComponentCommon
	{
		// Token: 0x06006F2E RID: 28462 RVA: 0x001F1840 File Offset: 0x001EFA40
		public DanmakuComponent()
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

		// Token: 0x06006F2F RID: 28463 RVA: 0x001F18B4 File Offset: 0x001EFAB4
		public override void Init()
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
			this.m_postDanmakuEntries = new List<PostDanmakuEntry>();
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x001F193C File Offset: 0x001EFB3C
		public override void PostInit()
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
			base.PostInit();
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x001F19A4 File Offset: 0x001EFBA4
		public override void DeInit()
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
			base.DeInit();
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x001F1A0C File Offset: 0x001EFC0C
		public void SetLevelDanmaku(LevelDanmaku levelDanmaku)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLevelDanmakuLevelDanmaku_hotfix != null)
			{
				this.m_SetLevelDanmakuLevelDanmaku_hotfix.call(new object[]
				{
					this,
					levelDanmaku
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelDanmaku = this.BuildLevelDanmakuOrderByTime(levelDanmaku);
			this.FilterSensitiveWords();
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x001F1A90 File Offset: 0x001EFC90
		private void FilterSensitiveWords()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FilterSensitiveWords_hotfix != null)
			{
				this.m_FilterSensitiveWords_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (TurnDanmaku turnDanmaku in this.m_levelDanmaku.Turns)
			{
				foreach (DanmakuEntry danmakuEntry in turnDanmaku.Entries)
				{
					danmakuEntry.Content = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(danmakuEntry.Content, '*');
				}
			}
		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x001F1BA0 File Offset: 0x001EFDA0
		private LevelDanmaku BuildLevelDanmakuOrderByTime(LevelDanmaku source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuildLevelDanmakuOrderByTimeLevelDanmaku_hotfix != null)
			{
				return (LevelDanmaku)this.m_BuildLevelDanmakuOrderByTimeLevelDanmaku_hotfix.call(new object[]
				{
					this,
					source
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LevelDanmaku levelDanmaku = new LevelDanmaku();
			foreach (TurnDanmaku turnDanmaku in source.Turns)
			{
				TurnDanmaku turnDanmaku2 = new TurnDanmaku
				{
					Turn = turnDanmaku.Turn
				};
				levelDanmaku.Turns.Add(turnDanmaku2);
				if (turnDanmaku.Entries.Count > 0)
				{
					int num = turnDanmaku.NextIndex % turnDanmaku.Entries.Count;
					int num2 = num;
					while (num2 < turnDanmaku.Entries.Count && num2 < this.m_configDataLoader.ConfigableConstId_MaxLevelDanmakuEntryNumsPerTurn)
					{
						turnDanmaku2.Entries.Add(turnDanmaku.Entries[num2 % turnDanmaku.Entries.Count]);
						num2++;
					}
					for (int i = 0; i < num; i++)
					{
						turnDanmaku2.Entries.Add(turnDanmaku.Entries[i % turnDanmaku.Entries.Count]);
					}
				}
			}
			return levelDanmaku;
		}

		// Token: 0x06006F35 RID: 28469 RVA: 0x001F1D48 File Offset: 0x001EFF48
		public LevelDanmaku GetLevelDanmaku()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLevelDanmaku_hotfix != null)
			{
				return (LevelDanmaku)this.m_GetLevelDanmaku_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_levelDanmaku;
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x001F1DBC File Offset: 0x001EFFBC
		public void PostLevelDanmaku(PostDanmakuEntry entry)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostLevelDanmakuPostDanmakuEntry_hotfix != null)
			{
				this.m_PostLevelDanmakuPostDanmakuEntry_hotfix.call(new object[]
				{
					this,
					entry2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PostDanmakuEntry entry = entry2;
			PostDanmakuEntry postDanmakuEntry = this.m_postDanmakuEntries.Find((PostDanmakuEntry m) => m.Turn == entry.Turn);
			if (postDanmakuEntry != null)
			{
				postDanmakuEntry.Content = entry.Content;
			}
			else
			{
				this.m_postDanmakuEntries.Add(entry);
			}
			this.AddPostDanmakuEntryToLocalLevelDanmaku(entry);
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x001F1E8C File Offset: 0x001F008C
		private void AddPostDanmakuEntryToLocalLevelDanmaku(PostDanmakuEntry entry)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddPostDanmakuEntryToLocalLevelDanmakuPostDanmakuEntry_hotfix != null)
			{
				this.m_AddPostDanmakuEntryToLocalLevelDanmakuPostDanmakuEntry_hotfix.call(new object[]
				{
					this,
					entry2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PostDanmakuEntry entry = entry2;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_levelDanmaku != null)
			{
				TurnDanmaku turnDanmaku = this.m_levelDanmaku.Turns.Find((TurnDanmaku danmakuTurn) => danmakuTurn.Turn == entry.Turn);
				if (turnDanmaku == null)
				{
					this.AddTurnDanmakuToLevelDanmaku(entry);
				}
				else
				{
					List<DanmakuEntry> entries = turnDanmaku.Entries;
					entries.Reverse();
					DanmakuEntry danmakuEntry = entries.Find((DanmakuEntry danmaku) => playerContext.IsMe(danmaku.UserId));
					entries.Reverse();
					if (danmakuEntry != null && this.m_newSendDanmakuTurnList.Contains(turnDanmaku.Turn))
					{
						danmakuEntry.Content = entry.Content;
					}
					else
					{
						this.m_newSendDanmakuTurnList.Add(turnDanmaku.Turn);
						DanmakuEntry item = this.CreateDanmakuEntry(entry);
						entries.Add(item);
					}
				}
			}
			else
			{
				this.m_levelDanmaku = new LevelDanmaku();
				this.AddTurnDanmakuToLevelDanmaku(entry);
			}
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x001F1FF8 File Offset: 0x001F01F8
		private void AddTurnDanmakuToLevelDanmaku(PostDanmakuEntry entry)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddTurnDanmakuToLevelDanmakuPostDanmakuEntry_hotfix != null)
			{
				this.m_AddTurnDanmakuToLevelDanmakuPostDanmakuEntry_hotfix.call(new object[]
				{
					this,
					entry
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TurnDanmaku turnDanmaku = new TurnDanmaku();
			turnDanmaku.Turn = entry.Turn;
			DanmakuEntry item = this.CreateDanmakuEntry(entry);
			turnDanmaku.Entries.Add(item);
			this.m_levelDanmaku.Turns.Add(turnDanmaku);
			if (!this.m_newSendDanmakuTurnList.Contains(entry.Turn))
			{
				this.m_newSendDanmakuTurnList.Add(entry.Turn);
			}
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x001F20C8 File Offset: 0x001F02C8
		private DanmakuEntry CreateDanmakuEntry(PostDanmakuEntry entry)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateDanmakuEntryPostDanmakuEntry_hotfix != null)
			{
				return (DanmakuEntry)this.m_CreateDanmakuEntryPostDanmakuEntry_hotfix.call(new object[]
				{
					this,
					entry
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return new DanmakuEntry
			{
				Content = entry.Content,
				UserId = projectLPlayerContext.GetUserId()
			};
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x001F2174 File Offset: 0x001F0374
		public void ClearLevelDanmaku()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearLevelDanmaku_hotfix != null)
			{
				this.m_ClearLevelDanmaku_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_postDanmakuEntries.Clear();
			this.m_levelDanmaku = null;
		}

		// Token: 0x06006F3B RID: 28475 RVA: 0x001F21E8 File Offset: 0x001F03E8
		public List<PostDanmakuEntry> GetPostedLevelDanmaku()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPostedLevelDanmaku_hotfix != null)
			{
				return (List<PostDanmakuEntry>)this.m_GetPostedLevelDanmaku_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearNewSendDanmakuTurnList();
			return this.m_postDanmakuEntries;
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x001F2260 File Offset: 0x001F0460
		public void ClearNewSendDanmakuTurnList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearNewSendDanmakuTurnList_hotfix != null)
			{
				this.m_ClearNewSendDanmakuTurnList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_newSendDanmakuTurnList.Clear();
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06006F3D RID: 28477 RVA: 0x001F22CC File Offset: 0x001F04CC
		// (set) Token: 0x06006F3E RID: 28478 RVA: 0x001F22EC File Offset: 0x001F04EC
		[DoNotToLua]
		public new DanmakuComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DanmakuComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x001F22F8 File Offset: 0x001F04F8
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x001F2300 File Offset: 0x001F0500
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x001F2308 File Offset: 0x001F0508
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x001F2310 File Offset: 0x001F0510
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x001F2318 File Offset: 0x001F0518
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x001F2324 File Offset: 0x001F0524
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x001F232C File Offset: 0x001F052C
		private int __callBase_CanGetLevelDanmaku(int gameFunctionTypeId, int locationId)
		{
			return base.CanGetLevelDanmaku(gameFunctionTypeId, locationId);
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x001F2338 File Offset: 0x001F0538
		private int __callBase_CanPostLevelDanmaku(int gameFunctionTypeId, int locationId, List<PostDanmakuEntry> entries)
		{
			return base.CanPostLevelDanmaku(gameFunctionTypeId, locationId, entries);
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x001F2344 File Offset: 0x001F0544
		private string __callBase_CombineLevelDanmakuKey(int gameFunctionTypeId, int locationId)
		{
			return base.CombineLevelDanmakuKey(gameFunctionTypeId, locationId);
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x001F2350 File Offset: 0x001F0550
		private void __callBase_TruncateDanmakuOrNot(PostDanmakuEntry entry)
		{
			base.TruncateDanmakuOrNot(entry);
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x001F235C File Offset: 0x001F055C
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_SetLevelDanmakuLevelDanmaku_hotfix = (luaObj.RawGet("SetLevelDanmaku") as LuaFunction);
					this.m_FilterSensitiveWords_hotfix = (luaObj.RawGet("FilterSensitiveWords") as LuaFunction);
					this.m_BuildLevelDanmakuOrderByTimeLevelDanmaku_hotfix = (luaObj.RawGet("BuildLevelDanmakuOrderByTime") as LuaFunction);
					this.m_GetLevelDanmaku_hotfix = (luaObj.RawGet("GetLevelDanmaku") as LuaFunction);
					this.m_PostLevelDanmakuPostDanmakuEntry_hotfix = (luaObj.RawGet("PostLevelDanmaku") as LuaFunction);
					this.m_AddPostDanmakuEntryToLocalLevelDanmakuPostDanmakuEntry_hotfix = (luaObj.RawGet("AddPostDanmakuEntryToLocalLevelDanmaku") as LuaFunction);
					this.m_AddTurnDanmakuToLevelDanmakuPostDanmakuEntry_hotfix = (luaObj.RawGet("AddTurnDanmakuToLevelDanmaku") as LuaFunction);
					this.m_CreateDanmakuEntryPostDanmakuEntry_hotfix = (luaObj.RawGet("CreateDanmakuEntry") as LuaFunction);
					this.m_ClearLevelDanmaku_hotfix = (luaObj.RawGet("ClearLevelDanmaku") as LuaFunction);
					this.m_GetPostedLevelDanmaku_hotfix = (luaObj.RawGet("GetPostedLevelDanmaku") as LuaFunction);
					this.m_ClearNewSendDanmakuTurnList_hotfix = (luaObj.RawGet("ClearNewSendDanmakuTurnList") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x001F2588 File Offset: 0x001F0788
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DanmakuComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005469 RID: 21609
		private List<PostDanmakuEntry> m_postDanmakuEntries;

		// Token: 0x0400546A RID: 21610
		private LevelDanmaku m_levelDanmaku;

		// Token: 0x0400546B RID: 21611
		private List<int> m_newSendDanmakuTurnList = new List<int>();

		// Token: 0x0400546C RID: 21612
		[DoNotToLua]
		private DanmakuComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400546D RID: 21613
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400546E RID: 21614
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400546F RID: 21615
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005470 RID: 21616
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005471 RID: 21617
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005472 RID: 21618
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005473 RID: 21619
		private LuaFunction m_SetLevelDanmakuLevelDanmaku_hotfix;

		// Token: 0x04005474 RID: 21620
		private LuaFunction m_FilterSensitiveWords_hotfix;

		// Token: 0x04005475 RID: 21621
		private LuaFunction m_BuildLevelDanmakuOrderByTimeLevelDanmaku_hotfix;

		// Token: 0x04005476 RID: 21622
		private LuaFunction m_GetLevelDanmaku_hotfix;

		// Token: 0x04005477 RID: 21623
		private LuaFunction m_PostLevelDanmakuPostDanmakuEntry_hotfix;

		// Token: 0x04005478 RID: 21624
		private LuaFunction m_AddPostDanmakuEntryToLocalLevelDanmakuPostDanmakuEntry_hotfix;

		// Token: 0x04005479 RID: 21625
		private LuaFunction m_AddTurnDanmakuToLevelDanmakuPostDanmakuEntry_hotfix;

		// Token: 0x0400547A RID: 21626
		private LuaFunction m_CreateDanmakuEntryPostDanmakuEntry_hotfix;

		// Token: 0x0400547B RID: 21627
		private LuaFunction m_ClearLevelDanmaku_hotfix;

		// Token: 0x0400547C RID: 21628
		private LuaFunction m_GetPostedLevelDanmaku_hotfix;

		// Token: 0x0400547D RID: 21629
		private LuaFunction m_ClearNewSendDanmakuTurnList_hotfix;

		// Token: 0x020008A6 RID: 2214
		public new class LuaExportHelper
		{
			// Token: 0x06006F4B RID: 28491 RVA: 0x001F25F0 File Offset: 0x001F07F0
			public LuaExportHelper(DanmakuComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006F4C RID: 28492 RVA: 0x001F2600 File Offset: 0x001F0800
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006F4D RID: 28493 RVA: 0x001F2610 File Offset: 0x001F0810
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006F4E RID: 28494 RVA: 0x001F2620 File Offset: 0x001F0820
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006F4F RID: 28495 RVA: 0x001F2630 File Offset: 0x001F0830
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006F50 RID: 28496 RVA: 0x001F2640 File Offset: 0x001F0840
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006F51 RID: 28497 RVA: 0x001F2650 File Offset: 0x001F0850
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006F52 RID: 28498 RVA: 0x001F2660 File Offset: 0x001F0860
			public int __callBase_CanGetLevelDanmaku(int gameFunctionTypeId, int locationId)
			{
				return this.m_owner.__callBase_CanGetLevelDanmaku(gameFunctionTypeId, locationId);
			}

			// Token: 0x06006F53 RID: 28499 RVA: 0x001F2670 File Offset: 0x001F0870
			public int __callBase_CanPostLevelDanmaku(int gameFunctionTypeId, int locationId, List<PostDanmakuEntry> entries)
			{
				return this.m_owner.__callBase_CanPostLevelDanmaku(gameFunctionTypeId, locationId, entries);
			}

			// Token: 0x06006F54 RID: 28500 RVA: 0x001F2680 File Offset: 0x001F0880
			public string __callBase_CombineLevelDanmakuKey(int gameFunctionTypeId, int locationId)
			{
				return this.m_owner.__callBase_CombineLevelDanmakuKey(gameFunctionTypeId, locationId);
			}

			// Token: 0x06006F55 RID: 28501 RVA: 0x001F2690 File Offset: 0x001F0890
			public void __callBase_TruncateDanmakuOrNot(PostDanmakuEntry entry)
			{
				this.m_owner.__callBase_TruncateDanmakuOrNot(entry);
			}

			// Token: 0x17001BB9 RID: 7097
			// (get) Token: 0x06006F56 RID: 28502 RVA: 0x001F26A0 File Offset: 0x001F08A0
			// (set) Token: 0x06006F57 RID: 28503 RVA: 0x001F26B0 File Offset: 0x001F08B0
			public List<PostDanmakuEntry> m_postDanmakuEntries
			{
				get
				{
					return this.m_owner.m_postDanmakuEntries;
				}
				set
				{
					this.m_owner.m_postDanmakuEntries = value;
				}
			}

			// Token: 0x17001BBA RID: 7098
			// (get) Token: 0x06006F58 RID: 28504 RVA: 0x001F26C0 File Offset: 0x001F08C0
			// (set) Token: 0x06006F59 RID: 28505 RVA: 0x001F26D0 File Offset: 0x001F08D0
			public LevelDanmaku m_levelDanmaku
			{
				get
				{
					return this.m_owner.m_levelDanmaku;
				}
				set
				{
					this.m_owner.m_levelDanmaku = value;
				}
			}

			// Token: 0x17001BBB RID: 7099
			// (get) Token: 0x06006F5A RID: 28506 RVA: 0x001F26E0 File Offset: 0x001F08E0
			// (set) Token: 0x06006F5B RID: 28507 RVA: 0x001F26F0 File Offset: 0x001F08F0
			public List<int> m_newSendDanmakuTurnList
			{
				get
				{
					return this.m_owner.m_newSendDanmakuTurnList;
				}
				set
				{
					this.m_owner.m_newSendDanmakuTurnList = value;
				}
			}

			// Token: 0x06006F5C RID: 28508 RVA: 0x001F2700 File Offset: 0x001F0900
			public void FilterSensitiveWords()
			{
				this.m_owner.FilterSensitiveWords();
			}

			// Token: 0x06006F5D RID: 28509 RVA: 0x001F2710 File Offset: 0x001F0910
			public LevelDanmaku BuildLevelDanmakuOrderByTime(LevelDanmaku source)
			{
				return this.m_owner.BuildLevelDanmakuOrderByTime(source);
			}

			// Token: 0x06006F5E RID: 28510 RVA: 0x001F2720 File Offset: 0x001F0920
			public void AddPostDanmakuEntryToLocalLevelDanmaku(PostDanmakuEntry entry)
			{
				this.m_owner.AddPostDanmakuEntryToLocalLevelDanmaku(entry);
			}

			// Token: 0x06006F5F RID: 28511 RVA: 0x001F2730 File Offset: 0x001F0930
			public void AddTurnDanmakuToLevelDanmaku(PostDanmakuEntry entry)
			{
				this.m_owner.AddTurnDanmakuToLevelDanmaku(entry);
			}

			// Token: 0x06006F60 RID: 28512 RVA: 0x001F2740 File Offset: 0x001F0940
			public DanmakuEntry CreateDanmakuEntry(PostDanmakuEntry entry)
			{
				return this.m_owner.CreateDanmakuEntry(entry);
			}

			// Token: 0x0400547E RID: 21630
			private DanmakuComponent m_owner;
		}
	}
}
