using System;

namespace BlackJack.BJFramework.Runtime.PlayerContext
{
	// Token: 0x0200006F RID: 111
	public class PlayerContextStateMachine : StateMachine
	{
		// Token: 0x06000554 RID: 1364 RVA: 0x000178A0 File Offset: 0x00015AA0
		public PlayerContextStateMachine()
		{
			base.State = 0;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x000178B0 File Offset: 0x00015AB0
		public override int SetStateCheck(int commingEvent, int newState = -1, bool testOnly = false)
		{
			PlayerContextStateMachine.StateCode stateCode = PlayerContextStateMachine.StateCode.Invalid;
			switch (base.State)
			{
			case 1:
				switch (commingEvent)
				{
				case 2:
					stateCode = (PlayerContextStateMachine.StateCode)base.State;
					break;
				case 3:
					stateCode = PlayerContextStateMachine.StateCode.AuthLoginStarted;
					break;
				case 7:
					stateCode = PlayerContextStateMachine.StateCode.SessionLoginStarted;
					break;
				}
				break;
			case 2:
				switch (commingEvent)
				{
				case 1:
					stateCode = (PlayerContextStateMachine.StateCode)base.State;
					break;
				case 2:
					stateCode = PlayerContextStateMachine.StateCode.Disconnected;
					break;
				case 4:
					stateCode = PlayerContextStateMachine.StateCode.GameLoginDone;
					break;
				case 5:
					stateCode = PlayerContextStateMachine.StateCode.GameLoginDone;
					break;
				case 6:
					stateCode = PlayerContextStateMachine.StateCode.Disconnected;
					break;
				}
				break;
			case 3:
				if (commingEvent == 2)
				{
					stateCode = PlayerContextStateMachine.StateCode.Disconnected;
				}
				break;
			case 4:
				if (commingEvent != 1)
				{
					if (commingEvent != 2)
					{
						if (commingEvent != 8)
						{
							if (commingEvent == 9)
							{
								stateCode = PlayerContextStateMachine.StateCode.Disconnected;
							}
						}
						else
						{
							stateCode = PlayerContextStateMachine.StateCode.GameLoginDone;
						}
					}
					else
					{
						stateCode = PlayerContextStateMachine.StateCode.Disconnected;
					}
				}
				else
				{
					stateCode = (PlayerContextStateMachine.StateCode)base.State;
				}
				break;
			case 5:
				if (commingEvent != 2)
				{
					if (commingEvent == 11)
					{
						stateCode = PlayerContextStateMachine.StateCode.PlayerInitEnd;
					}
				}
				else
				{
					stateCode = PlayerContextStateMachine.StateCode.Disconnected;
				}
				break;
			case 6:
				if (commingEvent != 2)
				{
					if (commingEvent == 10)
					{
						stateCode = (PlayerContextStateMachine.StateCode)base.State;
					}
				}
				else
				{
					stateCode = PlayerContextStateMachine.StateCode.Disconnected;
				}
				break;
			}
			if (newState != -1 && stateCode != (PlayerContextStateMachine.StateCode)newState)
			{
				return -1;
			}
			if (!testOnly)
			{
				base.State = (int)stateCode;
			}
			return (int)stateCode;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00017A90 File Offset: 0x00015C90
		public PlayerContextStateMachine.StateCode SetStateCheck(PlayerContextStateMachine.EventCode commingEvent, PlayerContextStateMachine.StateCode newState = PlayerContextStateMachine.StateCode.Invalid, bool testOnly = false)
		{
			return (PlayerContextStateMachine.StateCode)this.SetStateCheck((int)commingEvent, (int)newState, testOnly);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00017A9C File Offset: 0x00015C9C
		public PlayerContextStateMachine.StateCode StateEnumValue
		{
			get
			{
				return (PlayerContextStateMachine.StateCode)base.State;
			}
		}

		// Token: 0x02000070 RID: 112
		public enum StateCode
		{
			// Token: 0x04000289 RID: 649
			Invalid = -1,
			// Token: 0x0400028A RID: 650
			None,
			// Token: 0x0400028B RID: 651
			Disconnected,
			// Token: 0x0400028C RID: 652
			AuthLoginStarted,
			// Token: 0x0400028D RID: 653
			RedirectWaitDisconnect,
			// Token: 0x0400028E RID: 654
			SessionLoginStarted,
			// Token: 0x0400028F RID: 655
			GameLoginDone,
			// Token: 0x04000290 RID: 656
			PlayerInitEnd
		}

		// Token: 0x02000071 RID: 113
		public enum EventCode
		{
			// Token: 0x04000292 RID: 658
			OnConnected = 1,
			// Token: 0x04000293 RID: 659
			OnDisconnected,
			// Token: 0x04000294 RID: 660
			OnAuthLoginStart,
			// Token: 0x04000295 RID: 661
			OnAuthLoginAckOk,
			// Token: 0x04000296 RID: 662
			OnAuthLoginAckOkRedirect,
			// Token: 0x04000297 RID: 663
			OnAuthLoginAckFail,
			// Token: 0x04000298 RID: 664
			OnSessionLoginStart,
			// Token: 0x04000299 RID: 665
			OnSessionLoginAckOk,
			// Token: 0x0400029A RID: 666
			OnSessionLoginAckFail,
			// Token: 0x0400029B RID: 667
			OnGameLogicMsgSend,
			// Token: 0x0400029C RID: 668
			OnPlayerInitEnd
		}
	}
}
