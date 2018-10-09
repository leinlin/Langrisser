using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200043E RID: 1086
	public interface IComponentOwner
	{
		// Token: 0x06003FB4 RID: 16308
		T AddOwnerComponent<T>() where T : class, IComponentBase, new();

		// Token: 0x06003FB5 RID: 16309
		void RemoveOwnerComponent<T>() where T : class, IComponentBase;

		// Token: 0x06003FB6 RID: 16310
		T GetOwnerComponent<T>() where T : class, IComponentBase;

		// Token: 0x06003FB7 RID: 16311
		IComponentBase GetOwnerComponent(string componentName);
	}
}
