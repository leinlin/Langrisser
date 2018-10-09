using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200043F RID: 1087
	public interface IComponentBase
	{
		// Token: 0x06003FB8 RID: 16312
		string GetName();

		// Token: 0x06003FB9 RID: 16313
		void Init();

		// Token: 0x06003FBA RID: 16314
		void PostInit();

		// Token: 0x06003FBB RID: 16315
		void DeInit();

		// Token: 0x06003FBC RID: 16316
		void Tick(uint deltaMillisecond);

		// Token: 0x06003FBD RID: 16317
		bool Serialize<T>(T dest);

		// Token: 0x06003FBE RID: 16318
		void DeSerialize<T>(T source);

		// Token: 0x06003FBF RID: 16319
		void PostDeSerialize();

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06003FC0 RID: 16320
		// (set) Token: 0x06003FC1 RID: 16321
		IComponentOwner Owner { get; set; }
	}
}
