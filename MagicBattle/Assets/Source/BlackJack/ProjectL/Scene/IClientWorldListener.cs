using System;
using BlackJack.ConfigData;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200098A RID: 2442
	public interface IClientWorldListener
	{
		// Token: 0x06008CAF RID: 36015
		void OnWaypointClick(ConfigDataWaypointInfo waypointInfo);

		// Token: 0x06008CB0 RID: 36016
		void OnScreenEffect(string name);
	}
}
