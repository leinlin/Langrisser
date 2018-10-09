using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F09 RID: 3849
	[HotFix]
	public class ShareNetTask : UINetTask
	{
		// Token: 0x06013146 RID: 78150 RVA: 0x004DDE4C File Offset: 0x004DC04C
		public ShareNetTask(int heroId, int archiveId) : base(10f, null, true)
		{
			this.m_heroId = heroId;
			this.m_archiveId = archiveId;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorInt32Int32_hotfix != null)
			{
				this.m_ctorInt32Int32_hotfix.call(new object[]
				{
					this,
					heroId,
					archiveId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06013147 RID: 78151 RVA: 0x004DDEE8 File Offset: 0x004DC0E8
		protected override void RegisterNetworkEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterNetworkEvent_hotfix != null)
			{
				this.m_RegisterNetworkEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnShareAck += this.OnShareAck;
		}

		// Token: 0x06013148 RID: 78152 RVA: 0x004DDF70 File Offset: 0x004DC170
		protected override void UnregisterNetworkEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnregisterNetworkEvent_hotfix != null)
			{
				this.m_UnregisterNetworkEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnShareAck -= this.OnShareAck;
			}
		}

		// Token: 0x06013149 RID: 78153 RVA: 0x004DE000 File Offset: 0x004DC200
		protected override bool StartNetWorking()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartNetWorking_hotfix != null)
			{
				return Convert.ToBoolean(this.m_StartNetWorking_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendShareReq(this.m_heroId, this.m_archiveId);
		}

		// Token: 0x0601314A RID: 78154 RVA: 0x004DE098 File Offset: 0x004DC298
		protected void OnShareAck()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnShareAck_hotfix != null)
			{
				this.m_OnShareAck_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Result = 0;
			this.OnTransactionComplete();
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0601314B RID: 78155 RVA: 0x004DE108 File Offset: 0x004DC308
		// (set) Token: 0x0601314C RID: 78156 RVA: 0x004DE128 File Offset: 0x004DC328
		[DoNotToLua]
		public new ShareNetTask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ShareNetTask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601314D RID: 78157 RVA: 0x004DE134 File Offset: 0x004DC334
		private bool __callBase_OnStart(object param)
		{
			return base.OnStart(param);
		}

		// Token: 0x0601314E RID: 78158 RVA: 0x004DE140 File Offset: 0x004DC340
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0601314F RID: 78159 RVA: 0x004DE148 File Offset: 0x004DC348
		private void __callBase_OnTimeOut()
		{
			base.OnTimeOut();
		}

		// Token: 0x06013150 RID: 78160 RVA: 0x004DE150 File Offset: 0x004DC350
		private void __callBase_OnReLoginSuccess()
		{
			base.OnReLoginSuccess();
		}

		// Token: 0x06013151 RID: 78161 RVA: 0x004DE158 File Offset: 0x004DC358
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
					this.m_ctorInt32Int32_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_RegisterNetworkEvent_hotfix = (luaObj.RawGet("RegisterNetworkEvent") as LuaFunction);
					this.m_UnregisterNetworkEvent_hotfix = (luaObj.RawGet("UnregisterNetworkEvent") as LuaFunction);
					this.m_StartNetWorking_hotfix = (luaObj.RawGet("StartNetWorking") as LuaFunction);
					this.m_OnShareAck_hotfix = (luaObj.RawGet("OnShareAck") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013152 RID: 78162 RVA: 0x004DE288 File Offset: 0x004DC488
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ShareNetTask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AA12 RID: 43538
		public int m_heroId;

		// Token: 0x0400AA13 RID: 43539
		public int m_archiveId;

		// Token: 0x0400AA14 RID: 43540
		[DoNotToLua]
		private ShareNetTask.LuaExportHelper luaExportHelper;

		// Token: 0x0400AA15 RID: 43541
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AA16 RID: 43542
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AA17 RID: 43543
		private LuaFunction m_ctorInt32Int32_hotfix;

		// Token: 0x0400AA18 RID: 43544
		private LuaFunction m_RegisterNetworkEvent_hotfix;

		// Token: 0x0400AA19 RID: 43545
		private LuaFunction m_UnregisterNetworkEvent_hotfix;

		// Token: 0x0400AA1A RID: 43546
		private LuaFunction m_StartNetWorking_hotfix;

		// Token: 0x0400AA1B RID: 43547
		private LuaFunction m_OnShareAck_hotfix;

		// Token: 0x02000F0A RID: 3850
		public new class LuaExportHelper
		{
			// Token: 0x06013153 RID: 78163 RVA: 0x004DE2F0 File Offset: 0x004DC4F0
			public LuaExportHelper(ShareNetTask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013154 RID: 78164 RVA: 0x004DE300 File Offset: 0x004DC500
			public bool __callBase_OnStart(object param)
			{
				return this.m_owner.__callBase_OnStart(param);
			}

			// Token: 0x06013155 RID: 78165 RVA: 0x004DE310 File Offset: 0x004DC510
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06013156 RID: 78166 RVA: 0x004DE320 File Offset: 0x004DC520
			public void __callBase_OnTimeOut()
			{
				this.m_owner.__callBase_OnTimeOut();
			}

			// Token: 0x06013157 RID: 78167 RVA: 0x004DE330 File Offset: 0x004DC530
			public void __callBase_OnReLoginSuccess()
			{
				this.m_owner.__callBase_OnReLoginSuccess();
			}

			// Token: 0x06013158 RID: 78168 RVA: 0x004DE340 File Offset: 0x004DC540
			public void RegisterNetworkEvent()
			{
				this.m_owner.RegisterNetworkEvent();
			}

			// Token: 0x06013159 RID: 78169 RVA: 0x004DE350 File Offset: 0x004DC550
			public void UnregisterNetworkEvent()
			{
				this.m_owner.UnregisterNetworkEvent();
			}

			// Token: 0x0601315A RID: 78170 RVA: 0x004DE360 File Offset: 0x004DC560
			public bool StartNetWorking()
			{
				return this.m_owner.StartNetWorking();
			}

			// Token: 0x0601315B RID: 78171 RVA: 0x004DE370 File Offset: 0x004DC570
			public void OnShareAck()
			{
				this.m_owner.OnShareAck();
			}

			// Token: 0x0400AA1C RID: 43548
			private ShareNetTask m_owner;
		}
	}
}
