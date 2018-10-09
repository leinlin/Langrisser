using System;

namespace BlackJack.ProjectL.CommonReflection
{
	// Token: 0x02000441 RID: 1089
	public interface IComponentOwner
	{
		// Token: 0x06003FCF RID: 16335
		T AddOwnerComponent<T>() where T : class, IComponentBase, new();

		// Token: 0x06003FD0 RID: 16336
		void RemoveOwnerComponent<T>() where T : class, IComponentBase;

		// Token: 0x06003FD1 RID: 16337
		T GetOwnerComponent<T>() where T : class, IComponentBase;

		// Token: 0x06003FD2 RID: 16338
		IComponentBase GetOwnerComponent(string componentName);
	}
}
