using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008A1 RID: 2209
	[HotFix]
	public class CommentComponent : CommentComponentCommon
	{
		// Token: 0x06006EC6 RID: 28358 RVA: 0x001F02B8 File Offset: 0x001EE4B8
		public CommentComponent()
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

		// Token: 0x06006EC7 RID: 28359 RVA: 0x001F0320 File Offset: 0x001EE520
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
			this.m_heroComments = new Dictionary<int, HeroComment>();
			base.Init();
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x001F03A8 File Offset: 0x001EE5A8
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

		// Token: 0x06006EC9 RID: 28361 RVA: 0x001F0410 File Offset: 0x001EE610
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

		// Token: 0x06006ECA RID: 28362 RVA: 0x001F0478 File Offset: 0x001EE678
		public int GetHeroComment(int heroId, HeroComment heroComment, PlayerHeroCommentEntry playerCommentEntry)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroCommentInt32HeroCommentPlayerHeroCommentEntry_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroCommentInt32HeroCommentPlayerHeroCommentEntry_hotfix.call(new object[]
				{
					this,
					heroId,
					heroComment,
					playerCommentEntry
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.CanGetHeroComment(heroId);
			if (num != 0)
			{
				return num;
			}
			if (heroComment == null)
			{
				return 0;
			}
			HeroComment cacheHeroComment = this.FindHeroComment(heroId);
			this.InitPlayerHeroCommentEntry(cacheHeroComment, playerCommentEntry);
			this.AddHeroComment(heroId, cacheHeroComment, heroComment);
			return 0;
		}

		// Token: 0x06006ECB RID: 28363 RVA: 0x001F0548 File Offset: 0x001EE748
		private void InitPlayerHeroCommentEntry(HeroComment cacheHeroComment, PlayerHeroCommentEntry playerCommentEntry)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitPlayerHeroCommentEntryHeroCommentPlayerHeroCommentEntry_hotfix != null)
			{
				this.m_InitPlayerHeroCommentEntryHeroCommentPlayerHeroCommentEntry_hotfix.call(new object[]
				{
					this,
					cacheHeroComment,
					playerCommentEntry
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (cacheHeroComment == null && playerCommentEntry != null)
			{
				this.m_commentDS.InitPlayerHeroCommentEntry(playerCommentEntry);
			}
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x001F05E0 File Offset: 0x001EE7E0
		private void AddHeroComment(int heroId, HeroComment cacheHeroComment, HeroComment heroComment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddHeroCommentInt32HeroCommentHeroComment_hotfix != null)
			{
				this.m_AddHeroCommentInt32HeroCommentHeroComment_hotfix.call(new object[]
				{
					this,
					heroId,
					cacheHeroComment,
					heroComment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (cacheHeroComment != null && cacheHeroComment.LastUpdateTime == heroComment.LastUpdateTime)
			{
				return;
			}
			foreach (HeroCommentEntry heroCommentEntry in heroComment.CommentEntries)
			{
				heroCommentEntry.Content = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(heroCommentEntry.Content, '*');
			}
			this.m_heroComments[heroId] = heroComment;
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x001F06FC File Offset: 0x001EE8FC
		public HeroComment GetHeroComment(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroCommentInt32_hotfix != null)
			{
				return (HeroComment)this.m_GetHeroCommentInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroComment heroComment = this.FindHeroComment(heroId);
			if (heroComment == null)
			{
				heroComment = new HeroComment();
			}
			return heroComment;
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x001F0790 File Offset: 0x001EE990
		public int CommentHero(int heroId, HeroCommentEntry commentEntry, long lastUpdateTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CommentHeroInt32HeroCommentEntryInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_CommentHeroInt32HeroCommentEntryInt64_hotfix.call(new object[]
				{
					this,
					heroId,
					commentEntry,
					lastUpdateTime
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.CanCommentHero(heroId);
			if (num != 0)
			{
				return num;
			}
			HeroComment heroComment = this.FindHeroComment(heroId);
			if (heroComment == null)
			{
				heroComment = new HeroComment();
				this.AddHeroComment(heroId, null, heroComment);
			}
			heroComment.LastUpdateTime = lastUpdateTime;
			commentEntry.Content = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(commentEntry.Content, '*');
			heroComment.CommentEntries.Add(commentEntry);
			return 0;
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x001F088C File Offset: 0x001EEA8C
		public int PraiseHeroCommentEntry(int heroId, ulong entryInstanceId, long lastUpdateTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PraiseHeroCommentEntryInt32UInt64Int64_hotfix != null)
			{
				return Convert.ToInt32(this.m_PraiseHeroCommentEntryInt32UInt64Int64_hotfix.call(new object[]
				{
					this,
					heroId,
					entryInstanceId,
					lastUpdateTime
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.CanPraiseHeroCommentEntry(heroId, entryInstanceId);
			if (num != 0)
			{
				return num;
			}
			this.m_commentDS.PraiseHeroComment(heroId, entryInstanceId);
			HeroComment heroComment = this.FindHeroComment(heroId);
			foreach (HeroCommentEntry heroCommentEntry in heroComment.CommentEntries)
			{
				if (heroCommentEntry.InstanceId == entryInstanceId)
				{
					heroCommentEntry.PraiseNums++;
				}
			}
			heroComment.LastUpdateTime = lastUpdateTime;
			return 0;
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x001F09B8 File Offset: 0x001EEBB8
		private HeroComment FindHeroComment(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindHeroCommentInt32_hotfix != null)
			{
				return (HeroComment)this.m_FindHeroCommentInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroComment result;
			this.m_heroComments.TryGetValue(heroId, out result);
			return result;
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x001F0A44 File Offset: 0x001EEC44
		public List<HeroCommentEntry> GetHeroCommentEntries(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroCommentEntriesInt32_hotfix != null)
			{
				return (List<HeroCommentEntry>)this.m_GetHeroCommentEntriesInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<HeroCommentEntry> result = new List<HeroCommentEntry>();
			HeroComment heroComment = this.FindHeroComment(heroId);
			if (heroComment != null)
			{
				result = heroComment.CommentEntries;
			}
			return result;
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x001F0ADC File Offset: 0x001EECDC
		public long GetLastUpdateTime(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLastUpdateTimeInt32_hotfix != null)
			{
				return Convert.ToInt64(this.m_GetLastUpdateTimeInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroComment heroComment = this.FindHeroComment(heroId);
			return (heroComment != null) ? heroComment.LastUpdateTime : 0L;
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x001F0B74 File Offset: 0x001EED74
		public void ClearAllComment()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllComment_hotfix != null)
			{
				this.m_ClearAllComment_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroComments != null)
			{
				this.m_heroComments.Clear();
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06006ED4 RID: 28372 RVA: 0x001F0BEC File Offset: 0x001EEDEC
		// (set) Token: 0x06006ED5 RID: 28373 RVA: 0x001F0C0C File Offset: 0x001EEE0C
		[DoNotToLua]
		public new CommentComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CommentComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x001F0C18 File Offset: 0x001EEE18
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x001F0C20 File Offset: 0x001EEE20
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x001F0C28 File Offset: 0x001EEE28
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x001F0C30 File Offset: 0x001EEE30
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x001F0C38 File Offset: 0x001EEE38
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x001F0C44 File Offset: 0x001EEE44
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006EDC RID: 28380 RVA: 0x001F0C4C File Offset: 0x001EEE4C
		private int __callBase_CanCommentHero(int heroId)
		{
			return base.CanCommentHero(heroId);
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x001F0C58 File Offset: 0x001EEE58
		private int __callBase_CanPraiseHeroCommentEntry(int heroId, ulong entryInstanceId)
		{
			return base.CanPraiseHeroCommentEntry(heroId, entryInstanceId);
		}

		// Token: 0x06006EDE RID: 28382 RVA: 0x001F0C64 File Offset: 0x001EEE64
		private int __callBase_CanGetHeroComment(int heroId)
		{
			return base.CanGetHeroComment(heroId);
		}

		// Token: 0x06006EDF RID: 28383 RVA: 0x001F0C70 File Offset: 0x001EEE70
		private int __callBase_CanViewPlayerHero(int heroId)
		{
			return base.CanViewPlayerHero(heroId);
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x001F0C7C File Offset: 0x001EEE7C
		private bool __callBase_IsNeedTruncateHeroComment(string content)
		{
			return base.IsNeedTruncateHeroComment(content);
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x001F0C88 File Offset: 0x001EEE88
		private string __callBase_TruncateHeroComment(string content)
		{
			return base.TruncateHeroComment(content);
		}

		// Token: 0x06006EE2 RID: 28386 RVA: 0x001F0C94 File Offset: 0x001EEE94
		private PlayerHeroCommentEntry __callBase_FindPlayerHeroCommentEntry(int heroId)
		{
			return base.FindPlayerHeroCommentEntry(heroId);
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x001F0CA0 File Offset: 0x001EEEA0
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
					this.m_GetHeroCommentInt32HeroCommentPlayerHeroCommentEntry_hotfix = (luaObj.RawGet("GetHeroComment") as LuaFunction);
					this.m_InitPlayerHeroCommentEntryHeroCommentPlayerHeroCommentEntry_hotfix = (luaObj.RawGet("InitPlayerHeroCommentEntry") as LuaFunction);
					this.m_AddHeroCommentInt32HeroCommentHeroComment_hotfix = (luaObj.RawGet("AddHeroComment") as LuaFunction);
					this.m_GetHeroCommentInt32_hotfix = (luaObj.RawGet("GetHeroComment") as LuaFunction);
					this.m_CommentHeroInt32HeroCommentEntryInt64_hotfix = (luaObj.RawGet("CommentHero") as LuaFunction);
					this.m_PraiseHeroCommentEntryInt32UInt64Int64_hotfix = (luaObj.RawGet("PraiseHeroCommentEntry") as LuaFunction);
					this.m_FindHeroCommentInt32_hotfix = (luaObj.RawGet("FindHeroComment") as LuaFunction);
					this.m_GetHeroCommentEntriesInt32_hotfix = (luaObj.RawGet("GetHeroCommentEntries") as LuaFunction);
					this.m_GetLastUpdateTimeInt32_hotfix = (luaObj.RawGet("GetLastUpdateTime") as LuaFunction);
					this.m_ClearAllComment_hotfix = (luaObj.RawGet("ClearAllComment") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x001F0EB0 File Offset: 0x001EF0B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CommentComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400544B RID: 21579
		private Dictionary<int, HeroComment> m_heroComments;

		// Token: 0x0400544C RID: 21580
		[DoNotToLua]
		private CommentComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400544D RID: 21581
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400544E RID: 21582
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400544F RID: 21583
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005450 RID: 21584
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005451 RID: 21585
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005452 RID: 21586
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005453 RID: 21587
		private LuaFunction m_GetHeroCommentInt32HeroCommentPlayerHeroCommentEntry_hotfix;

		// Token: 0x04005454 RID: 21588
		private LuaFunction m_InitPlayerHeroCommentEntryHeroCommentPlayerHeroCommentEntry_hotfix;

		// Token: 0x04005455 RID: 21589
		private LuaFunction m_AddHeroCommentInt32HeroCommentHeroComment_hotfix;

		// Token: 0x04005456 RID: 21590
		private LuaFunction m_GetHeroCommentInt32_hotfix;

		// Token: 0x04005457 RID: 21591
		private LuaFunction m_CommentHeroInt32HeroCommentEntryInt64_hotfix;

		// Token: 0x04005458 RID: 21592
		private LuaFunction m_PraiseHeroCommentEntryInt32UInt64Int64_hotfix;

		// Token: 0x04005459 RID: 21593
		private LuaFunction m_FindHeroCommentInt32_hotfix;

		// Token: 0x0400545A RID: 21594
		private LuaFunction m_GetHeroCommentEntriesInt32_hotfix;

		// Token: 0x0400545B RID: 21595
		private LuaFunction m_GetLastUpdateTimeInt32_hotfix;

		// Token: 0x0400545C RID: 21596
		private LuaFunction m_ClearAllComment_hotfix;

		// Token: 0x020008A2 RID: 2210
		public new class LuaExportHelper
		{
			// Token: 0x06006EE5 RID: 28389 RVA: 0x001F0F18 File Offset: 0x001EF118
			public LuaExportHelper(CommentComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006EE6 RID: 28390 RVA: 0x001F0F28 File Offset: 0x001EF128
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006EE7 RID: 28391 RVA: 0x001F0F38 File Offset: 0x001EF138
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006EE8 RID: 28392 RVA: 0x001F0F48 File Offset: 0x001EF148
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006EE9 RID: 28393 RVA: 0x001F0F58 File Offset: 0x001EF158
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006EEA RID: 28394 RVA: 0x001F0F68 File Offset: 0x001EF168
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006EEB RID: 28395 RVA: 0x001F0F78 File Offset: 0x001EF178
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006EEC RID: 28396 RVA: 0x001F0F88 File Offset: 0x001EF188
			public int __callBase_CanCommentHero(int heroId)
			{
				return this.m_owner.__callBase_CanCommentHero(heroId);
			}

			// Token: 0x06006EED RID: 28397 RVA: 0x001F0F98 File Offset: 0x001EF198
			public int __callBase_CanPraiseHeroCommentEntry(int heroId, ulong entryInstanceId)
			{
				return this.m_owner.__callBase_CanPraiseHeroCommentEntry(heroId, entryInstanceId);
			}

			// Token: 0x06006EEE RID: 28398 RVA: 0x001F0FA8 File Offset: 0x001EF1A8
			public int __callBase_CanGetHeroComment(int heroId)
			{
				return this.m_owner.__callBase_CanGetHeroComment(heroId);
			}

			// Token: 0x06006EEF RID: 28399 RVA: 0x001F0FB8 File Offset: 0x001EF1B8
			public int __callBase_CanViewPlayerHero(int heroId)
			{
				return this.m_owner.__callBase_CanViewPlayerHero(heroId);
			}

			// Token: 0x06006EF0 RID: 28400 RVA: 0x001F0FC8 File Offset: 0x001EF1C8
			public bool __callBase_IsNeedTruncateHeroComment(string content)
			{
				return this.m_owner.__callBase_IsNeedTruncateHeroComment(content);
			}

			// Token: 0x06006EF1 RID: 28401 RVA: 0x001F0FD8 File Offset: 0x001EF1D8
			public string __callBase_TruncateHeroComment(string content)
			{
				return this.m_owner.__callBase_TruncateHeroComment(content);
			}

			// Token: 0x06006EF2 RID: 28402 RVA: 0x001F0FE8 File Offset: 0x001EF1E8
			public PlayerHeroCommentEntry __callBase_FindPlayerHeroCommentEntry(int heroId)
			{
				return this.m_owner.__callBase_FindPlayerHeroCommentEntry(heroId);
			}

			// Token: 0x17001BB6 RID: 7094
			// (get) Token: 0x06006EF3 RID: 28403 RVA: 0x001F0FF8 File Offset: 0x001EF1F8
			// (set) Token: 0x06006EF4 RID: 28404 RVA: 0x001F1008 File Offset: 0x001EF208
			public Dictionary<int, HeroComment> m_heroComments
			{
				get
				{
					return this.m_owner.m_heroComments;
				}
				set
				{
					this.m_owner.m_heroComments = value;
				}
			}

			// Token: 0x06006EF5 RID: 28405 RVA: 0x001F1018 File Offset: 0x001EF218
			public void InitPlayerHeroCommentEntry(HeroComment cacheHeroComment, PlayerHeroCommentEntry playerCommentEntry)
			{
				this.m_owner.InitPlayerHeroCommentEntry(cacheHeroComment, playerCommentEntry);
			}

			// Token: 0x06006EF6 RID: 28406 RVA: 0x001F1028 File Offset: 0x001EF228
			public void AddHeroComment(int heroId, HeroComment cacheHeroComment, HeroComment heroComment)
			{
				this.m_owner.AddHeroComment(heroId, cacheHeroComment, heroComment);
			}

			// Token: 0x06006EF7 RID: 28407 RVA: 0x001F1038 File Offset: 0x001EF238
			public HeroComment FindHeroComment(int heroId)
			{
				return this.m_owner.FindHeroComment(heroId);
			}

			// Token: 0x0400545D RID: 21597
			private CommentComponent m_owner;
		}
	}
}
