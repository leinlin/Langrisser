using System;

namespace BlackJack.ProjectL.CommonReflection
{
	// Token: 0x02000442 RID: 1090
	public interface IComponentBase
	{
		// Token: 0x06003FD3 RID: 16339
		string GetName();

		// Token: 0x06003FD4 RID: 16340
		void Init();

		// Token: 0x06003FD5 RID: 16341
		void PostInit();

		// Token: 0x06003FD6 RID: 16342
		void DeInit();

		// Token: 0x06003FD7 RID: 16343
		bool Serialize<T>(T dest);

		// Token: 0x06003FD8 RID: 16344
		void DeSerialize<T>(T source);

		// Token: 0x06003FD9 RID: 16345
		void PostDeSerialize();

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06003FDA RID: 16346
		// (set) Token: 0x06003FDB RID: 16347
		IComponentOwner Owner { get; set; }
	}
}
