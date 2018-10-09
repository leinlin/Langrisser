using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EC2 RID: 3778
	[HotFix]
	public class SelfRankingListItemUIController : RankingListItemUIController
	{
		// Token: 0x060127A8 RID: 75688 RVA: 0x004BDB74 File Offset: 0x004BBD74
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060127A9 RID: 75689 RVA: 0x004BDBDC File Offset: 0x004BBDDC
		public void UpdateCompareInfo(int lastRankLevel, int curRankLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateCompareInfoInt32Int32_hotfix != null)
			{
				this.m_UpdateCompareInfoInt32Int32_hotfix.call(new object[]
				{
					this,
					lastRankLevel,
					curRankLevel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string stateName = "NoChange";
			if (lastRankLevel != 2147483647 && curRankLevel != 2147483647)
			{
				int num = Math.Abs(curRankLevel - lastRankLevel);
				if (num > 999)
				{
					num = 999;
				}
				if (lastRankLevel > curRankLevel)
				{
					stateName = "Up";
				}
				else if (lastRankLevel < curRankLevel)
				{
					stateName = "Down";
				}
				this.LastRankLevelText.text = num.ToString();
			}
			else if (lastRankLevel == 2147483647 && curRankLevel != 2147483647)
			{
				stateName = "NoChange";
				this.LastRankLevelText.text = "0";
			}
			else if (lastRankLevel != 2147483647 && curRankLevel == 2147483647)
			{
				stateName = "Down";
				this.LastRankLevelText.text = "999";
			}
			else
			{
				this.LastRankLevelText.text = "0";
			}
			this.ComparePanelUIStateCtrl.SetToUIState(stateName, false, true);
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x060127AA RID: 75690 RVA: 0x004BDD50 File Offset: 0x004BBF50
		// (set) Token: 0x060127AB RID: 75691 RVA: 0x004BDD70 File Offset: 0x004BBF70
		[DoNotToLua]
		public new SelfRankingListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SelfRankingListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060127AC RID: 75692 RVA: 0x004BDD7C File Offset: 0x004BBF7C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060127AD RID: 75693 RVA: 0x004BDD84 File Offset: 0x004BBF84
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x060127AE RID: 75694 RVA: 0x004BDD8C File Offset: 0x004BBF8C
		private void __callBase_RegisterItemClickEvent(Action<UIControllerBase> action)
		{
			base.RegisterItemClickEvent(action);
		}

		// Token: 0x060127AF RID: 75695 RVA: 0x004BDD98 File Offset: 0x004BBF98
		private void __callBase_RegisterItemNeedFillEvent(Action<UIControllerBase> action)
		{
			base.RegisterItemNeedFillEvent(action);
		}

		// Token: 0x060127B0 RID: 75696 RVA: 0x004BDDA4 File Offset: 0x004BBFA4
		private int __callBase_GetItemIndex()
		{
			return base.GetItemIndex();
		}

		// Token: 0x060127B1 RID: 75697 RVA: 0x004BDDAC File Offset: 0x004BBFAC
		private void __callBase_UpdateItemInfo(RankingListType rankType, int headIconId, int rankLevel, int lv, string playerName, int score, string heroName)
		{
			base.UpdateItemInfo(rankType, headIconId, rankLevel, lv, playerName, score, heroName);
		}

		// Token: 0x060127B2 RID: 75698 RVA: 0x004BDDC0 File Offset: 0x004BBFC0
		private Sprite __callBase_GetRankLevelSprite(int rankLevel)
		{
			return base.GetRankLevelSprite(rankLevel);
		}

		// Token: 0x060127B3 RID: 75699 RVA: 0x004BDDCC File Offset: 0x004BBFCC
		private void __callBase_UpdateDetailInfo(RankingListType rankType, string heroName, int score)
		{
			base.UpdateDetailInfo(rankType, heroName, score);
		}

		// Token: 0x060127B4 RID: 75700 RVA: 0x004BDDD8 File Offset: 0x004BBFD8
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
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_UpdateCompareInfoInt32Int32_hotfix = (luaObj.RawGet("UpdateCompareInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060127B5 RID: 75701 RVA: 0x004BDEBC File Offset: 0x004BC0BC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SelfRankingListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A626 RID: 42534
		[AutoBind("./ComparePanel", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController ComparePanelUIStateCtrl;

		// Token: 0x0400A627 RID: 42535
		[AutoBind("./ComparePanel/LastRankLevelText", AutoBindAttribute.InitState.NotInit, false)]
		public Text LastRankLevelText;

		// Token: 0x0400A628 RID: 42536
		[DoNotToLua]
		private SelfRankingListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A629 RID: 42537
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A62A RID: 42538
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A62B RID: 42539
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A62C RID: 42540
		private LuaFunction m_UpdateCompareInfoInt32Int32_hotfix;

		// Token: 0x02000EC3 RID: 3779
		public new class LuaExportHelper
		{
			// Token: 0x060127B6 RID: 75702 RVA: 0x004BDF24 File Offset: 0x004BC124
			public LuaExportHelper(SelfRankingListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060127B7 RID: 75703 RVA: 0x004BDF34 File Offset: 0x004BC134
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060127B8 RID: 75704 RVA: 0x004BDF44 File Offset: 0x004BC144
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x060127B9 RID: 75705 RVA: 0x004BDF54 File Offset: 0x004BC154
			public void __callBase_RegisterItemClickEvent(Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_RegisterItemClickEvent(action);
			}

			// Token: 0x060127BA RID: 75706 RVA: 0x004BDF64 File Offset: 0x004BC164
			public void __callBase_RegisterItemNeedFillEvent(Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_RegisterItemNeedFillEvent(action);
			}

			// Token: 0x060127BB RID: 75707 RVA: 0x004BDF74 File Offset: 0x004BC174
			public int __callBase_GetItemIndex()
			{
				return this.m_owner.__callBase_GetItemIndex();
			}

			// Token: 0x060127BC RID: 75708 RVA: 0x004BDF84 File Offset: 0x004BC184
			public void __callBase_UpdateItemInfo(RankingListType rankType, int headIconId, int rankLevel, int lv, string playerName, int score, string heroName)
			{
				this.m_owner.__callBase_UpdateItemInfo(rankType, headIconId, rankLevel, lv, playerName, score, heroName);
			}

			// Token: 0x060127BD RID: 75709 RVA: 0x004BDF9C File Offset: 0x004BC19C
			public Sprite __callBase_GetRankLevelSprite(int rankLevel)
			{
				return this.m_owner.__callBase_GetRankLevelSprite(rankLevel);
			}

			// Token: 0x060127BE RID: 75710 RVA: 0x004BDFAC File Offset: 0x004BC1AC
			public void __callBase_UpdateDetailInfo(RankingListType rankType, string heroName, int score)
			{
				this.m_owner.__callBase_UpdateDetailInfo(rankType, heroName, score);
			}

			// Token: 0x060127BF RID: 75711 RVA: 0x004BDFBC File Offset: 0x004BC1BC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400A62D RID: 42541
			private SelfRankingListItemUIController m_owner;
		}
	}
}
