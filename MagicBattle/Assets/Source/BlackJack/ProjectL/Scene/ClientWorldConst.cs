using System;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x02000981 RID: 2433
	[CustomLuaClass]
	public class ClientWorldConst
	{
		// Token: 0x0400635A RID: 25434
		public const int TickRate = 30;

		// Token: 0x0400635B RID: 25435
		public const float TickTime = 0.0333333351f;

		// Token: 0x0400635C RID: 25436
		public const float CameraAngle = 20f;

		// Token: 0x0400635D RID: 25437
		public static Quaternion FaceCameraRotation = Quaternion.Euler(-20f, 0f, 0f);

		// Token: 0x0400635E RID: 25438
		public const int WorldActorSortingOrder = 2;

		// Token: 0x0400635F RID: 25439
		public const int WorldScenarioSortingOrder = 4;

		// Token: 0x04006360 RID: 25440
		public const float WaypointZOffset = 0f;

		// Token: 0x04006361 RID: 25441
		public const float EventActorZOffset = -0.04f;

		// Token: 0x04006362 RID: 25442
		public const float PlayerActorZOffset = -0.08f;

		// Token: 0x04006363 RID: 25443
		public const float WorldActorUIZOffset = -0.02f;
	}
}
