using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.LibClient;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000872 RID: 2162
	[CustomLuaClass]
	public class GameLogic4TargetProject : IGameLogicInterface4TargetProject
	{
		// Token: 0x06006B4B RID: 27467 RVA: 0x001E191C File Offset: 0x001DFB1C
		public void OnInitialize()
		{
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x001E1920 File Offset: 0x001DFB20
		public void OnApplicationQuit()
		{
			StopwatchManager.LogAllMessage();
		}

		// Token: 0x06006B4D RID: 27469 RVA: 0x001E1928 File Offset: 0x001DFB28
		public IPlayerContextNetworkClient CreateNetWorkClient()
		{
			if (GameManager.Instance == null)
			{
				Debug.LogError("GameLogic4TargetProject.CreateNetWorkClinet GameManager.Instance is null.");
				return null;
			}
			if (GameManager.Instance.PlayerContext == null)
			{
				Debug.LogError("GameLogic4TargetProject.CreateNetWorkClinet GameManager.Instance.PlayerContext is null.");
				return null;
			}
			ProjectLPlayerContextWrapper handler = new ProjectLPlayerContextWrapper(GameManager.Instance.PlayerContext);
			return new NetWorkClient(ClientFactory.CreateClient(handler, null));
		}
	}
}
