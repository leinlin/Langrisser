using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000358 RID: 856
	[CustomLuaClass]
	public class BattleActorLogInfo
	{
		// Token: 0x040025C0 RID: 9664
		public int heroId;

		// Token: 0x040025C1 RID: 9665
		public int killEnemies;

		// Token: 0x040025C2 RID: 9666
		public int useSkills;

		// Token: 0x040025C3 RID: 9667
		public int deadTurn;

		// Token: 0x040025C4 RID: 9668
		public int killerId;
	}
}
