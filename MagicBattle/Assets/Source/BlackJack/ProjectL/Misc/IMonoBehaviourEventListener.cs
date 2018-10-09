using System;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x0200087F RID: 2175
	public interface IMonoBehaviourEventListener
	{
		// Token: 0x06006BD0 RID: 27600
		void OnStart(MonoBehaviourEvent e);

		// Token: 0x06006BD1 RID: 27601
		void OnDestroy(MonoBehaviourEvent e);

		// Token: 0x06006BD2 RID: 27602
		void OnUpdate(MonoBehaviourEvent e);

		// Token: 0x06006BD3 RID: 27603
		void OnLateUpdate(MonoBehaviourEvent e);

		// Token: 0x06006BD4 RID: 27604
		void OnRenderObject(MonoBehaviourEvent e);
	}
}
