using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A11 RID: 2577
	[CustomLuaClass]
	public class ArenaOpponentAttackFightingNetTask : UINetTask
	{
		// Token: 0x06009B19 RID: 39705 RVA: 0x002C3218 File Offset: 0x002C1418
		public ArenaOpponentAttackFightingNetTask() : base(10f, null, true)
		{
		}

		// Token: 0x06009B1A RID: 39706 RVA: 0x002C3228 File Offset: 0x002C1428
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaOpponentAttackFightingAck += this.OnArenaOpponentAttackFightingAck;
		}

		// Token: 0x06009B1B RID: 39707 RVA: 0x002C3260 File Offset: 0x002C1460
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaOpponentAttackFightingAck -= this.OnArenaOpponentAttackFightingAck;
			}
		}

		// Token: 0x06009B1C RID: 39708 RVA: 0x002C329C File Offset: 0x002C149C
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaOpponentAttackFightingReq();
		}

		// Token: 0x06009B1D RID: 39709 RVA: 0x002C32C8 File Offset: 0x002C14C8
		protected override void OnReLoginSuccess()
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.GetArenaBattleStatus() != ArenaBattleStatus.None)
			{
				ArenaBattleReconnectNetTask arenaBattleReconnectNetTask = new ArenaBattleReconnectNetTask();
				arenaBattleReconnectNetTask.EventOnStop += delegate(Task task)
				{
					ArenaBattleReconnectNetTask arenaBattleReconnectNetTask2 = task as ArenaBattleReconnectNetTask;
					if (arenaBattleReconnectNetTask2.Result != 0)
					{
						Debug.LogError("ArenaBattleReconnectNetTask error :" + arenaBattleReconnectNetTask2.Result);
					}
					this.<OnReLoginSuccess>__BaseCallProxy0();
				};
				arenaBattleReconnectNetTask.Start(null);
			}
			else
			{
				base.OnReLoginSuccess();
			}
		}

		// Token: 0x06009B1E RID: 39710 RVA: 0x002C331C File Offset: 0x002C151C
		protected void OnArenaOpponentAttackFightingAck(int result)
		{
			base.Result = result;
			this.OnTransactionComplete();
		}
	}
}
