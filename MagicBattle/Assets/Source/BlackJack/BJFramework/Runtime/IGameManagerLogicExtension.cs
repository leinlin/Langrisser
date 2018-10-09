using System;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200004F RID: 79
	public interface IGameManagerLogicExtension
	{
		// Token: 0x060003AB RID: 939
		void OnLoadConfigDataEnd(Action<bool> onEnd);

		// Token: 0x060003AC RID: 940
		void OnLoadDynamicAssemblyEnd();

		// Token: 0x060003AD RID: 941
		void OnClear4Relogin();

		// Token: 0x060003AE RID: 942
		void Tick();
	}
}
