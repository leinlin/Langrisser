using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A12 RID: 2578
	[CustomLuaClass]
	public class ArenaBattleFinishedNetTask : UINetTask
	{
		// Token: 0x06009B21 RID: 39713 RVA: 0x002C3378 File Offset: 0x002C1578
		public ArenaBattleFinishedNetTask(ProBattleReport battleReport) : base(10f, null, true)
		{
			this.m_battleReport = battleReport;
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x002C3390 File Offset: 0x002C1590
		protected override void RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnArenaBattleFinishedAck += this.OnArenaBattleFinishedAck;
		}

		// Token: 0x06009B23 RID: 39715 RVA: 0x002C33C8 File Offset: 0x002C15C8
		protected override void UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnArenaBattleFinishedAck -= this.OnArenaBattleFinishedAck;
			}
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x002C3404 File Offset: 0x002C1604
		protected override bool StartNetWorking()
		{
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendArenaBattleFinishedReq(this.m_battleReport);
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x002C3434 File Offset: 0x002C1634
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

		// Token: 0x06009B26 RID: 39718 RVA: 0x002C3488 File Offset: 0x002C1688
		protected void OnArenaBattleFinishedAck(int result, BattleReward reward, bool isWin)
		{
			base.Result = result;
			this.IsWin = isWin;
			this.Reward = reward;
			this.OnTransactionComplete();
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x06009B28 RID: 39720 RVA: 0x002C34B4 File Offset: 0x002C16B4
		// (set) Token: 0x06009B27 RID: 39719 RVA: 0x002C34A8 File Offset: 0x002C16A8
		public bool IsWin { get; private set; }

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06009B2A RID: 39722 RVA: 0x002C34C8 File Offset: 0x002C16C8
		// (set) Token: 0x06009B29 RID: 39721 RVA: 0x002C34BC File Offset: 0x002C16BC
		public BattleReward Reward { get; private set; }

		// Token: 0x040069C3 RID: 27075
		private ProBattleReport m_battleReport;
	}
}
