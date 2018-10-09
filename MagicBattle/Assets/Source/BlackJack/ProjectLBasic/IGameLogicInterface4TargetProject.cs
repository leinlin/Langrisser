using System;
using BlackJack.BJFramework.Runtime.PlayerContext;

namespace BlackJack.ProjectLBasic
{
	// Token: 0x020010B5 RID: 4277
	public interface IGameLogicInterface4TargetProject
	{
		// Token: 0x060158A8 RID: 88232
		IPlayerContextNetworkClient CreateNetWorkClient();

		// Token: 0x060158A9 RID: 88233
		void OnApplicationQuit();

		// Token: 0x060158AA RID: 88234
		void OnInitialize();
	}
}
