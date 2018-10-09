using System;
using BlackJack.ProjectL.Common;
using FixMath.NET;
using UnityEngine;

namespace BlackJack.ProjectL.Scene
{
	// Token: 0x0200097B RID: 2427
	public interface IGenericGraphicContainer
	{
		// Token: 0x06008AC5 RID: 35525
		Vector3 GetCameraPosition();

		// Token: 0x06008AC6 RID: 35526
		Vector3 CombatPositionToWorldPosition(Vector2i p, Fix64 z, bool computeZOffset);

		// Token: 0x06008AC7 RID: 35527
		bool IsCulled(Vector2 bmin, Vector2 bmax, bool isCombat);

		// Token: 0x06008AC8 RID: 35528
		bool IsCombatGraphicMirrorX();
	}
}
