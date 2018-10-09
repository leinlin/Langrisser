using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000ED1 RID: 3793
	[HotFix]
	public class RaidLevelUITask : UITask
	{
		// Token: 0x0601297B RID: 76155 RVA: 0x004C41C0 File Offset: 0x004C23C0
		public RaidLevelUITask(string name) : base(name)
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

		// Token: 0x0601297C RID: 76156 RVA: 0x004C42DC File Offset: 0x004C24DC
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
			this.InitDataFromUIIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x0601297D RID: 76157 RVA: 0x004C4368 File Offset: 0x004C2568
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
			this.InitDataFromUIIntent(intent);
			return base.OnResume(intent);
		}

		// Token: 0x0601297E RID: 76158 RVA: 0x004C43F4 File Offset: 0x004C25F4
		private void InitDataFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDataFromUIIntentUIIntent_hotfix != null)
			{
				this.m_InitDataFromUIIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleReward = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_battleReward = uiintentCustom.GetClassParam<BattleReward>("BattleReward");
				this.m_extraReward = uiintentCustom.GetClassParam<List<Goods>>("ExtraReward");
				this.m_riftLevelID = uiintentCustom.GetStructParam<int>("RiftLevelID");
				this.m_heroDungeonLevelID = uiintentCustom.GetStructParam<int>("HeroDungeonLevelID");
				this.m_battleType = uiintentCustom.GetStructParam<BattleType>("BattleType");
				this.m_needGoods = uiintentCustom.GetClassParam<NeedGoods>("RaidNeedGoods");
			}
		}

		// Token: 0x0601297F RID: 76159 RVA: 0x004C44E0 File Offset: 0x004C26E0
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (this.m_raidLevelUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_raidLevelUIController = (this.m_uiCtrlArray[0] as RaidLevelUIController);
				}
				if (!(this.m_raidLevelUIController != null))
				{
					Debug.LogError("RaidLevelUIController is null");
					return;
				}
				this.m_raidLevelUIController.EventOnClose += this.RaidLevelInfoUIController_OnClose;
				this.m_raidLevelUIController.EventOnRaidAgain += this.RaidLevelInfoUIController_RaidAgain;
			}
		}

		// Token: 0x06012980 RID: 76160 RVA: 0x004C45C8 File Offset: 0x004C27C8
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_raidLevelUIController != null)
			{
				this.m_raidLevelUIController.EventOnClose -= this.RaidLevelInfoUIController_OnClose;
				this.m_raidLevelUIController.EventOnRaidAgain -= this.RaidLevelInfoUIController_RaidAgain;
				this.m_raidLevelUIController = null;
			}
		}

		// Token: 0x06012981 RID: 76161 RVA: 0x004C4674 File Offset: 0x004C2874
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleReward != null)
			{
				this.m_raidLevelUIController.ShowReward(this.m_battleReward, this.m_extraReward);
				this.m_raidLevelUIController.SetNeedGoods(this.m_needGoods, this.m_battleReward, this.m_extraReward);
			}
			this.m_raidLevelUIController.SetRaidTicketCount(this.m_playerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, this.m_configDataLoader.ConfigableConstId_LevelRaidTicketID));
		}

		// Token: 0x06012982 RID: 76162 RVA: 0x004C4738 File Offset: 0x004C2938
		private void RaidLevelInfoUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RaidLevelInfoUIController_OnClose_hotfix != null)
			{
				this.m_RaidLevelInfoUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x06012983 RID: 76163 RVA: 0x004C47B4 File Offset: 0x004C29B4
		private void RaidLevelInfoUIController_RaidAgain()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RaidLevelInfoUIController_RaidAgain_hotfix != null)
			{
				this.m_RaidLevelInfoUIController_RaidAgain_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleType == BattleType.Rift)
			{
				int num = this.m_playerContext.CanRaidRiftLevel(this.m_riftLevelID);
				if (num == 0)
				{
					this.StartRiftLevelRaidNetTask(this.m_riftLevelID, 1);
				}
				else
				{
					WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
				}
			}
			else if (this.m_battleType == BattleType.HeroDungeon)
			{
				int num2 = this.m_playerContext.CanRaidHeroDungeonLevel(this.m_heroDungeonLevelID);
				if (num2 == 0)
				{
					this.StartHeroDungeonLevelRaidNetTask(this.m_heroDungeonLevelID, 1);
				}
				else
				{
					WorldUITask.HandleAttackFailResult(num2, this.m_currIntent);
				}
			}
		}

		// Token: 0x06012984 RID: 76164 RVA: 0x004C48A0 File Offset: 0x004C2AA0
		private void StartRiftLevelRaidNetTask(int levelID, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRiftLevelRaidNetTaskInt32Int32_hotfix != null)
			{
				this.m_StartRiftLevelRaidNetTaskInt32Int32_hotfix.call(new object[]
				{
					this,
					levelID2,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int levelID = levelID2;
			RaidLevelUITask $this = this;
			RiftLevelRaidNetTask riftLevelRaidNetTask = new RiftLevelRaidNetTask(levelID, count);
			riftLevelRaidNetTask.EventOnStop += delegate(Task task)
			{
				RiftLevelRaidNetTask riftLevelRaidNetTask2 = task as RiftLevelRaidNetTask;
				if (riftLevelRaidNetTask2.Result == 0)
				{
					$this.m_battleReward = riftLevelRaidNetTask2.Reward;
					$this.m_extraReward = riftLevelRaidNetTask2.ExtraReward;
					$this.UpdateView();
					if ($this.EventOnRiftRaidComplete != null)
					{
						$this.EventOnRiftRaidComplete(levelID);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(riftLevelRaidNetTask2.Result, 2f, null, true);
				}
			};
			riftLevelRaidNetTask.Start(null);
		}

		// Token: 0x06012985 RID: 76165 RVA: 0x004C495C File Offset: 0x004C2B5C
		private void StartHeroDungeonLevelRaidNetTask(int levelID, int count)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartHeroDungeonLevelRaidNetTaskInt32Int32_hotfix != null)
			{
				this.m_StartHeroDungeonLevelRaidNetTaskInt32Int32_hotfix.call(new object[]
				{
					this,
					levelID2,
					count
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int levelID = levelID2;
			RaidLevelUITask $this = this;
			HeroDungeonLevelRaidNetTask heroDungeonLevelRaidNetTask = new HeroDungeonLevelRaidNetTask(levelID, count);
			heroDungeonLevelRaidNetTask.EventOnStop += delegate(Task task)
			{
				HeroDungeonLevelRaidNetTask heroDungeonLevelRaidNetTask2 = task as HeroDungeonLevelRaidNetTask;
				if (heroDungeonLevelRaidNetTask2.Result == 0)
				{
					$this.m_battleReward = heroDungeonLevelRaidNetTask2.Reward;
					$this.m_extraReward = heroDungeonLevelRaidNetTask2.ExtraReward;
					$this.UpdateView();
					if ($this.EventOnHeroDungeonRaidComplete != null)
					{
						$this.EventOnHeroDungeonRaidComplete(levelID);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroDungeonLevelRaidNetTask2.Result, 2f, null, true);
				}
			};
			heroDungeonLevelRaidNetTask.Start(null);
		}

		// Token: 0x140003FF RID: 1023
		// (add) Token: 0x06012986 RID: 76166 RVA: 0x004C4A18 File Offset: 0x004C2C18
		// (remove) Token: 0x06012987 RID: 76167 RVA: 0x004C4AB4 File Offset: 0x004C2CB4
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000400 RID: 1024
		// (add) Token: 0x06012988 RID: 76168 RVA: 0x004C4B50 File Offset: 0x004C2D50
		// (remove) Token: 0x06012989 RID: 76169 RVA: 0x004C4BEC File Offset: 0x004C2DEC
		public event Action<int> EventOnRiftRaidComplete
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnRiftRaidCompleteAction`1_hotfix != null)
				{
					this.m_add_EventOnRiftRaidCompleteAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnRiftRaidComplete;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnRiftRaidComplete, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnRiftRaidCompleteAction`1_hotfix != null)
				{
					this.m_remove_EventOnRiftRaidCompleteAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnRiftRaidComplete;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnRiftRaidComplete, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000401 RID: 1025
		// (add) Token: 0x0601298A RID: 76170 RVA: 0x004C4C88 File Offset: 0x004C2E88
		// (remove) Token: 0x0601298B RID: 76171 RVA: 0x004C4D24 File Offset: 0x004C2F24
		public event Action<int> EventOnHeroDungeonRaidComplete
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroDungeonRaidCompleteAction`1_hotfix != null)
				{
					this.m_add_EventOnHeroDungeonRaidCompleteAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnHeroDungeonRaidComplete;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnHeroDungeonRaidComplete, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroDungeonRaidCompleteAction`1_hotfix != null)
				{
					this.m_remove_EventOnHeroDungeonRaidCompleteAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnHeroDungeonRaidComplete;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnHeroDungeonRaidComplete, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0601298C RID: 76172 RVA: 0x004C4DC0 File Offset: 0x004C2FC0
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0601298D RID: 76173 RVA: 0x004C4E34 File Offset: 0x004C3034
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0601298E RID: 76174 RVA: 0x004C4EA8 File Offset: 0x004C30A8
		// (set) Token: 0x0601298F RID: 76175 RVA: 0x004C4EC8 File Offset: 0x004C30C8
		[DoNotToLua]
		public new RaidLevelUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RaidLevelUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012990 RID: 76176 RVA: 0x004C4ED4 File Offset: 0x004C30D4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06012991 RID: 76177 RVA: 0x004C4EE0 File Offset: 0x004C30E0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06012992 RID: 76178 RVA: 0x004C4EE8 File Offset: 0x004C30E8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06012993 RID: 76179 RVA: 0x004C4EF0 File Offset: 0x004C30F0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06012994 RID: 76180 RVA: 0x004C4EFC File Offset: 0x004C30FC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06012995 RID: 76181 RVA: 0x004C4F08 File Offset: 0x004C3108
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06012996 RID: 76182 RVA: 0x004C4F14 File Offset: 0x004C3114
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06012997 RID: 76183 RVA: 0x004C4F1C File Offset: 0x004C311C
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06012998 RID: 76184 RVA: 0x004C4F24 File Offset: 0x004C3124
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06012999 RID: 76185 RVA: 0x004C4F2C File Offset: 0x004C312C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0601299A RID: 76186 RVA: 0x004C4F34 File Offset: 0x004C3134
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0601299B RID: 76187 RVA: 0x004C4F3C File Offset: 0x004C313C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0601299C RID: 76188 RVA: 0x004C4F44 File Offset: 0x004C3144
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0601299D RID: 76189 RVA: 0x004C4F4C File Offset: 0x004C314C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0601299E RID: 76190 RVA: 0x004C4F58 File Offset: 0x004C3158
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0601299F RID: 76191 RVA: 0x004C4F64 File Offset: 0x004C3164
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060129A0 RID: 76192 RVA: 0x004C4F70 File Offset: 0x004C3170
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060129A1 RID: 76193 RVA: 0x004C4F7C File Offset: 0x004C317C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060129A2 RID: 76194 RVA: 0x004C4F84 File Offset: 0x004C3184
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060129A3 RID: 76195 RVA: 0x004C4F8C File Offset: 0x004C318C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060129A4 RID: 76196 RVA: 0x004C4F94 File Offset: 0x004C3194
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060129A5 RID: 76197 RVA: 0x004C4F9C File Offset: 0x004C319C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060129A6 RID: 76198 RVA: 0x004C4FA4 File Offset: 0x004C31A4
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060129A7 RID: 76199 RVA: 0x004C4FAC File Offset: 0x004C31AC
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x060129A8 RID: 76200 RVA: 0x004C4FCC File Offset: 0x004C31CC
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x060129A9 RID: 76201 RVA: 0x004C4FD8 File Offset: 0x004C31D8
		private void __callDele_EventOnRiftRaidComplete(int obj)
		{
			Action<int> eventOnRiftRaidComplete = this.EventOnRiftRaidComplete;
			if (eventOnRiftRaidComplete != null)
			{
				eventOnRiftRaidComplete(obj);
			}
		}

		// Token: 0x060129AA RID: 76202 RVA: 0x004C4FFC File Offset: 0x004C31FC
		private void __clearDele_EventOnRiftRaidComplete(int obj)
		{
			this.EventOnRiftRaidComplete = null;
		}

		// Token: 0x060129AB RID: 76203 RVA: 0x004C5008 File Offset: 0x004C3208
		private void __callDele_EventOnHeroDungeonRaidComplete(int obj)
		{
			Action<int> eventOnHeroDungeonRaidComplete = this.EventOnHeroDungeonRaidComplete;
			if (eventOnHeroDungeonRaidComplete != null)
			{
				eventOnHeroDungeonRaidComplete(obj);
			}
		}

		// Token: 0x060129AC RID: 76204 RVA: 0x004C502C File Offset: 0x004C322C
		private void __clearDele_EventOnHeroDungeonRaidComplete(int obj)
		{
			this.EventOnHeroDungeonRaidComplete = null;
		}

		// Token: 0x060129AD RID: 76205 RVA: 0x004C5038 File Offset: 0x004C3238
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
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_RaidLevelInfoUIController_OnClose_hotfix = (luaObj.RawGet("RaidLevelInfoUIController_OnClose") as LuaFunction);
					this.m_RaidLevelInfoUIController_RaidAgain_hotfix = (luaObj.RawGet("RaidLevelInfoUIController_RaidAgain") as LuaFunction);
					this.m_StartRiftLevelRaidNetTaskInt32Int32_hotfix = (luaObj.RawGet("StartRiftLevelRaidNetTask") as LuaFunction);
					this.m_StartHeroDungeonLevelRaidNetTaskInt32Int32_hotfix = (luaObj.RawGet("StartHeroDungeonLevelRaidNetTask") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnRiftRaidCompleteAction`1_hotfix = (luaObj.RawGet("add_EventOnRiftRaidComplete") as LuaFunction);
					this.m_remove_EventOnRiftRaidCompleteAction`1_hotfix = (luaObj.RawGet("remove_EventOnRiftRaidComplete") as LuaFunction);
					this.m_add_EventOnHeroDungeonRaidCompleteAction`1_hotfix = (luaObj.RawGet("add_EventOnHeroDungeonRaidComplete") as LuaFunction);
					this.m_remove_EventOnHeroDungeonRaidCompleteAction`1_hotfix = (luaObj.RawGet("remove_EventOnHeroDungeonRaidComplete") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060129AE RID: 76206 RVA: 0x004C52C8 File Offset: 0x004C34C8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaidLevelUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A6F4 RID: 42740
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "RaidLevelUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Rift_ABS/Prefab/RaidLevelUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A6F5 RID: 42741
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "RaidLevelUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.RaidLevelUIController"),
				m_ctrlName = "RaidLevelUIController"
			}
		};

		// Token: 0x0400A6F6 RID: 42742
		private RaidLevelUIController m_raidLevelUIController;

		// Token: 0x0400A6F7 RID: 42743
		private BattleReward m_battleReward;

		// Token: 0x0400A6F8 RID: 42744
		private List<Goods> m_extraReward;

		// Token: 0x0400A6F9 RID: 42745
		private int m_riftLevelID;

		// Token: 0x0400A6FA RID: 42746
		private int m_heroDungeonLevelID;

		// Token: 0x0400A6FB RID: 42747
		private BattleType m_battleType;

		// Token: 0x0400A6FC RID: 42748
		private NeedGoods m_needGoods;

		// Token: 0x0400A6FD RID: 42749
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400A6FE RID: 42750
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400A6FF RID: 42751
		[DoNotToLua]
		private RaidLevelUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A700 RID: 42752
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A701 RID: 42753
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A702 RID: 42754
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A703 RID: 42755
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A704 RID: 42756
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400A705 RID: 42757
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400A706 RID: 42758
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A707 RID: 42759
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A708 RID: 42760
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A709 RID: 42761
		private LuaFunction m_RaidLevelInfoUIController_OnClose_hotfix;

		// Token: 0x0400A70A RID: 42762
		private LuaFunction m_RaidLevelInfoUIController_RaidAgain_hotfix;

		// Token: 0x0400A70B RID: 42763
		private LuaFunction m_StartRiftLevelRaidNetTaskInt32Int32_hotfix;

		// Token: 0x0400A70C RID: 42764
		private LuaFunction m_StartHeroDungeonLevelRaidNetTaskInt32Int32_hotfix;

		// Token: 0x0400A70D RID: 42765
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400A70E RID: 42766
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400A70F RID: 42767
		private LuaFunction m_add_EventOnRiftRaidCompleteAction;

		// Token: 0x0400A710 RID: 42768
		private LuaFunction m_remove_EventOnRiftRaidCompleteAction;

		// Token: 0x0400A711 RID: 42769
		private LuaFunction m_add_EventOnHeroDungeonRaidCompleteAction;

		// Token: 0x0400A712 RID: 42770
		private LuaFunction m_remove_EventOnHeroDungeonRaidCompleteAction;

		// Token: 0x0400A713 RID: 42771
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A714 RID: 42772
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000ED2 RID: 3794
		public new class LuaExportHelper
		{
			// Token: 0x060129AF RID: 76207 RVA: 0x004C5330 File Offset: 0x004C3530
			public LuaExportHelper(RaidLevelUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060129B0 RID: 76208 RVA: 0x004C5340 File Offset: 0x004C3540
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060129B1 RID: 76209 RVA: 0x004C5350 File Offset: 0x004C3550
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060129B2 RID: 76210 RVA: 0x004C5360 File Offset: 0x004C3560
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060129B3 RID: 76211 RVA: 0x004C5370 File Offset: 0x004C3570
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060129B4 RID: 76212 RVA: 0x004C5380 File Offset: 0x004C3580
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060129B5 RID: 76213 RVA: 0x004C5390 File Offset: 0x004C3590
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060129B6 RID: 76214 RVA: 0x004C53A0 File Offset: 0x004C35A0
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060129B7 RID: 76215 RVA: 0x004C53B0 File Offset: 0x004C35B0
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060129B8 RID: 76216 RVA: 0x004C53C0 File Offset: 0x004C35C0
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060129B9 RID: 76217 RVA: 0x004C53D0 File Offset: 0x004C35D0
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060129BA RID: 76218 RVA: 0x004C53E0 File Offset: 0x004C35E0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060129BB RID: 76219 RVA: 0x004C53F0 File Offset: 0x004C35F0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060129BC RID: 76220 RVA: 0x004C5400 File Offset: 0x004C3600
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060129BD RID: 76221 RVA: 0x004C5410 File Offset: 0x004C3610
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060129BE RID: 76222 RVA: 0x004C5420 File Offset: 0x004C3620
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060129BF RID: 76223 RVA: 0x004C5430 File Offset: 0x004C3630
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060129C0 RID: 76224 RVA: 0x004C5440 File Offset: 0x004C3640
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060129C1 RID: 76225 RVA: 0x004C5450 File Offset: 0x004C3650
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060129C2 RID: 76226 RVA: 0x004C5460 File Offset: 0x004C3660
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060129C3 RID: 76227 RVA: 0x004C5470 File Offset: 0x004C3670
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060129C4 RID: 76228 RVA: 0x004C5480 File Offset: 0x004C3680
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060129C5 RID: 76229 RVA: 0x004C5490 File Offset: 0x004C3690
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060129C6 RID: 76230 RVA: 0x004C54A0 File Offset: 0x004C36A0
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x060129C7 RID: 76231 RVA: 0x004C54B0 File Offset: 0x004C36B0
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x060129C8 RID: 76232 RVA: 0x004C54C0 File Offset: 0x004C36C0
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x060129C9 RID: 76233 RVA: 0x004C54D0 File Offset: 0x004C36D0
			public void __callDele_EventOnRiftRaidComplete(int obj)
			{
				this.m_owner.__callDele_EventOnRiftRaidComplete(obj);
			}

			// Token: 0x060129CA RID: 76234 RVA: 0x004C54E0 File Offset: 0x004C36E0
			public void __clearDele_EventOnRiftRaidComplete(int obj)
			{
				this.m_owner.__clearDele_EventOnRiftRaidComplete(obj);
			}

			// Token: 0x060129CB RID: 76235 RVA: 0x004C54F0 File Offset: 0x004C36F0
			public void __callDele_EventOnHeroDungeonRaidComplete(int obj)
			{
				this.m_owner.__callDele_EventOnHeroDungeonRaidComplete(obj);
			}

			// Token: 0x060129CC RID: 76236 RVA: 0x004C5500 File Offset: 0x004C3700
			public void __clearDele_EventOnHeroDungeonRaidComplete(int obj)
			{
				this.m_owner.__clearDele_EventOnHeroDungeonRaidComplete(obj);
			}

			// Token: 0x17003839 RID: 14393
			// (get) Token: 0x060129CD RID: 76237 RVA: 0x004C5510 File Offset: 0x004C3710
			// (set) Token: 0x060129CE RID: 76238 RVA: 0x004C5520 File Offset: 0x004C3720
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x1700383A RID: 14394
			// (get) Token: 0x060129CF RID: 76239 RVA: 0x004C5530 File Offset: 0x004C3730
			// (set) Token: 0x060129D0 RID: 76240 RVA: 0x004C5540 File Offset: 0x004C3740
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x1700383B RID: 14395
			// (get) Token: 0x060129D1 RID: 76241 RVA: 0x004C5550 File Offset: 0x004C3750
			// (set) Token: 0x060129D2 RID: 76242 RVA: 0x004C5560 File Offset: 0x004C3760
			public RaidLevelUIController m_raidLevelUIController
			{
				get
				{
					return this.m_owner.m_raidLevelUIController;
				}
				set
				{
					this.m_owner.m_raidLevelUIController = value;
				}
			}

			// Token: 0x1700383C RID: 14396
			// (get) Token: 0x060129D3 RID: 76243 RVA: 0x004C5570 File Offset: 0x004C3770
			// (set) Token: 0x060129D4 RID: 76244 RVA: 0x004C5580 File Offset: 0x004C3780
			public BattleReward m_battleReward
			{
				get
				{
					return this.m_owner.m_battleReward;
				}
				set
				{
					this.m_owner.m_battleReward = value;
				}
			}

			// Token: 0x1700383D RID: 14397
			// (get) Token: 0x060129D5 RID: 76245 RVA: 0x004C5590 File Offset: 0x004C3790
			// (set) Token: 0x060129D6 RID: 76246 RVA: 0x004C55A0 File Offset: 0x004C37A0
			public List<Goods> m_extraReward
			{
				get
				{
					return this.m_owner.m_extraReward;
				}
				set
				{
					this.m_owner.m_extraReward = value;
				}
			}

			// Token: 0x1700383E RID: 14398
			// (get) Token: 0x060129D7 RID: 76247 RVA: 0x004C55B0 File Offset: 0x004C37B0
			// (set) Token: 0x060129D8 RID: 76248 RVA: 0x004C55C0 File Offset: 0x004C37C0
			public int m_riftLevelID
			{
				get
				{
					return this.m_owner.m_riftLevelID;
				}
				set
				{
					this.m_owner.m_riftLevelID = value;
				}
			}

			// Token: 0x1700383F RID: 14399
			// (get) Token: 0x060129D9 RID: 76249 RVA: 0x004C55D0 File Offset: 0x004C37D0
			// (set) Token: 0x060129DA RID: 76250 RVA: 0x004C55E0 File Offset: 0x004C37E0
			public int m_heroDungeonLevelID
			{
				get
				{
					return this.m_owner.m_heroDungeonLevelID;
				}
				set
				{
					this.m_owner.m_heroDungeonLevelID = value;
				}
			}

			// Token: 0x17003840 RID: 14400
			// (get) Token: 0x060129DB RID: 76251 RVA: 0x004C55F0 File Offset: 0x004C37F0
			// (set) Token: 0x060129DC RID: 76252 RVA: 0x004C5600 File Offset: 0x004C3800
			public BattleType m_battleType
			{
				get
				{
					return this.m_owner.m_battleType;
				}
				set
				{
					this.m_owner.m_battleType = value;
				}
			}

			// Token: 0x17003841 RID: 14401
			// (get) Token: 0x060129DD RID: 76253 RVA: 0x004C5610 File Offset: 0x004C3810
			// (set) Token: 0x060129DE RID: 76254 RVA: 0x004C5620 File Offset: 0x004C3820
			public NeedGoods m_needGoods
			{
				get
				{
					return this.m_owner.m_needGoods;
				}
				set
				{
					this.m_owner.m_needGoods = value;
				}
			}

			// Token: 0x17003842 RID: 14402
			// (get) Token: 0x060129DF RID: 76255 RVA: 0x004C5630 File Offset: 0x004C3830
			// (set) Token: 0x060129E0 RID: 76256 RVA: 0x004C5640 File Offset: 0x004C3840
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17003843 RID: 14403
			// (get) Token: 0x060129E1 RID: 76257 RVA: 0x004C5650 File Offset: 0x004C3850
			// (set) Token: 0x060129E2 RID: 76258 RVA: 0x004C5660 File Offset: 0x004C3860
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

			// Token: 0x17003844 RID: 14404
			// (get) Token: 0x060129E3 RID: 76259 RVA: 0x004C5670 File Offset: 0x004C3870
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003845 RID: 14405
			// (get) Token: 0x060129E4 RID: 76260 RVA: 0x004C5680 File Offset: 0x004C3880
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060129E5 RID: 76261 RVA: 0x004C5690 File Offset: 0x004C3890
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x060129E6 RID: 76262 RVA: 0x004C56A0 File Offset: 0x004C38A0
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x060129E7 RID: 76263 RVA: 0x004C56B0 File Offset: 0x004C38B0
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x060129E8 RID: 76264 RVA: 0x004C56C0 File Offset: 0x004C38C0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060129E9 RID: 76265 RVA: 0x004C56D0 File Offset: 0x004C38D0
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060129EA RID: 76266 RVA: 0x004C56E0 File Offset: 0x004C38E0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060129EB RID: 76267 RVA: 0x004C56F0 File Offset: 0x004C38F0
			public void RaidLevelInfoUIController_OnClose()
			{
				this.m_owner.RaidLevelInfoUIController_OnClose();
			}

			// Token: 0x060129EC RID: 76268 RVA: 0x004C5700 File Offset: 0x004C3900
			public void RaidLevelInfoUIController_RaidAgain()
			{
				this.m_owner.RaidLevelInfoUIController_RaidAgain();
			}

			// Token: 0x060129ED RID: 76269 RVA: 0x004C5710 File Offset: 0x004C3910
			public void StartRiftLevelRaidNetTask(int levelID, int count)
			{
				this.m_owner.StartRiftLevelRaidNetTask(levelID, count);
			}

			// Token: 0x060129EE RID: 76270 RVA: 0x004C5720 File Offset: 0x004C3920
			public void StartHeroDungeonLevelRaidNetTask(int levelID, int count)
			{
				this.m_owner.StartHeroDungeonLevelRaidNetTask(levelID, count);
			}

			// Token: 0x0400A715 RID: 42773
			private RaidLevelUITask m_owner;
		}
	}
}
