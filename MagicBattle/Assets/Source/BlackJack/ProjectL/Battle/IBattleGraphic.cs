using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using FixMath.NET;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003C5 RID: 965
	public interface IBattleGraphic
	{
		// Token: 0x06003989 RID: 14729
		void PlayAnimation(string name, bool loop);

		// Token: 0x0600398A RID: 14730
		void PlayDeathAnimation(int deathType);

		// Token: 0x0600398B RID: 14731
		void PlayFx(string name, int tag);

		// Token: 0x0600398C RID: 14732
		void SetCombatPosition(Vector2i pos, Fix64 z, int zoffset);

		// Token: 0x0600398D RID: 14733
		void SetCombatDirection(Vector2i front, Fix64 frontZ);

		// Token: 0x0600398E RID: 14734
		void SetCombatDirection(int dir);

		// Token: 0x0600398F RID: 14735
		void SetName(string name);

		// Token: 0x06003990 RID: 14736
		void SetReplaceAnimations(List<ReplaceAnim> replaceAnims);

		// Token: 0x06003991 RID: 14737
		void SetHeight(float height, float footHeight);

		// Token: 0x06003992 RID: 14738
		void SetVisible(bool visible);

		// Token: 0x06003993 RID: 14739
		void SetEffect(GraphicEffect e, float param1, float param2);

		// Token: 0x06003994 RID: 14740
		void ClearEffect(GraphicEffect e);

		// Token: 0x06003995 RID: 14741
		void ClearAttachFxs(int tagMask);

		// Token: 0x06003996 RID: 14742
		void Pause(bool pause);

		// Token: 0x06003997 RID: 14743
		void Tick(float dt);

		// Token: 0x06003998 RID: 14744
		void FxStop(bool fadeOut);
	}
}
