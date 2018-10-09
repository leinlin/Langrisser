using System;
using SLua;

namespace BlackJack.ProjectL.LibClient
{
	// Token: 0x020005AC RID: 1452
	[CustomLuaClass]
	public class LibClientStateMachine : StateMachine
	{
		// Token: 0x06005285 RID: 21125 RVA: 0x001874C0 File Offset: 0x001856C0
		public LibClientStateMachine()
		{
			base.State = 0;
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x001874D0 File Offset: 0x001856D0
		public override int SetStateCheck(int commingEvent, int newState = -1, bool testOnly = false)
		{
			int num = -1;
			int state = base.State;
			switch (state)
			{
			case 0:
				if (commingEvent != 1)
				{
					if (commingEvent != 8)
					{
						return -1;
					}
					num = 4;
				}
				else
				{
					num = 1;
				}
				break;
			case 1:
				if (commingEvent != 4)
				{
					if (commingEvent != 2)
					{
						return -1;
					}
					num = 2;
				}
				else
				{
					num = 100;
				}
				break;
			case 2:
				switch (commingEvent)
				{
				case 3:
					num = 99;
					break;
				case 4:
					num = 100;
					break;
				case 5:
					num = 6;
					break;
				case 6:
					num = 3;
					break;
				case 7:
					num = base.State;
					break;
				default:
					return -1;
				}
				break;
			case 3:
				switch (commingEvent)
				{
				case 3:
					num = 99;
					goto IL_164;
				case 4:
					num = 100;
					goto IL_164;
				case 8:
					num = 4;
					goto IL_164;
				}
				return -1;
				IL_164:
				break;
			case 4:
				if (commingEvent != 4)
				{
					if (commingEvent != 2)
					{
						return -1;
					}
					num = 5;
				}
				else
				{
					num = 100;
				}
				break;
			case 5:
				if (commingEvent != 3)
				{
					if (commingEvent != 4)
					{
						if (commingEvent != 9)
						{
							if (commingEvent == 10)
							{
								num = base.State;
							}
						}
						else
						{
							num = 6;
						}
					}
					else
					{
						num = 100;
					}
				}
				else
				{
					num = 99;
				}
				break;
			case 6:
				if (commingEvent != 3)
				{
					if (commingEvent != 4)
					{
						return -1;
					}
					num = 100;
				}
				else
				{
					num = 99;
				}
				break;
			default:
				if (state != 99)
				{
					if (state != 100)
					{
						return -1;
					}
					if (commingEvent != 1)
					{
						if (commingEvent != 8)
						{
							return -1;
						}
						num = 4;
					}
					else
					{
						num = 1;
					}
				}
				else
				{
					if (commingEvent != 4)
					{
						return -1;
					}
					num = 100;
				}
				break;
			}
			if (newState != -1 && num != newState)
			{
				return -1;
			}
			if (!testOnly)
			{
				base.State = num;
			}
			return num;
		}

		// Token: 0x04003DEE RID: 15854
		public const int STATE_IDLE = 0;

		// Token: 0x04003DEF RID: 15855
		public const int STATE_AUTHLOGIN_CONNECTING = 1;

		// Token: 0x04003DF0 RID: 15856
		public const int STATE_AUTHLOGIN_CONNECTED = 2;

		// Token: 0x04003DF1 RID: 15857
		public const int STATE_AUTHLOGIN_OK_NEED_REDIRECT = 3;

		// Token: 0x04003DF2 RID: 15858
		public const int STATE_SESSIONLOGIN_CONNECTING = 4;

		// Token: 0x04003DF3 RID: 15859
		public const int STATE_SESSIONLOGIN_CONNECTED = 5;

		// Token: 0x04003DF4 RID: 15860
		public const int STATE_LOGIN_OK = 6;

		// Token: 0x04003DF5 RID: 15861
		public const int STATE_DISCONNECTING = 99;

		// Token: 0x04003DF6 RID: 15862
		public const int STATE_DISCONNECTED = 100;

		// Token: 0x04003DF7 RID: 15863
		public const int EVENT_AUTHLOGIN_CONNECT = 1;

		// Token: 0x04003DF8 RID: 15864
		public const int EVENT_ONCONNECTED = 2;

		// Token: 0x04003DF9 RID: 15865
		public const int EVENT_DISCONNECT = 3;

		// Token: 0x04003DFA RID: 15866
		public const int EVENT_ONDISCONNECTED = 4;

		// Token: 0x04003DFB RID: 15867
		public const int EVENT_AUTHLOGIN_OK = 5;

		// Token: 0x04003DFC RID: 15868
		public const int EVENT_AUTHLOGIN_OK_REDRIECT = 6;

		// Token: 0x04003DFD RID: 15869
		public const int EVENT_AUTHLOGIN_FAIL = 7;

		// Token: 0x04003DFE RID: 15870
		public const int EVENT_SESSIONLOGIN_CONNECT = 8;

		// Token: 0x04003DFF RID: 15871
		public const int EVENT_SESSIONLOGIN_OK = 9;

		// Token: 0x04003E00 RID: 15872
		public const int EVENT_SESSIONLOGIN_FAIL = 10;
	}
}
