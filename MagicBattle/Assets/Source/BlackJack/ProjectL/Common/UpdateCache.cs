using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000580 RID: 1408
	public class UpdateCache<T> : CacheObject where T : class
	{
		// Token: 0x0600517E RID: 20862 RVA: 0x001837D8 File Offset: 0x001819D8
		public UpdateCache(T data)
		{
			this.Data = data;
		}

		// Token: 0x0600517F RID: 20863 RVA: 0x001837E8 File Offset: 0x001819E8
		public bool IsValid()
		{
			return this.Data != null;
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x001837FC File Offset: 0x001819FC
		public void SetInvalid()
		{
			this.Data = (T)((object)null);
			base.Dirty = true;
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06005181 RID: 20865 RVA: 0x00183814 File Offset: 0x00181A14
		// (set) Token: 0x06005182 RID: 20866 RVA: 0x0018381C File Offset: 0x00181A1C
		public T Data { get; set; }
	}
}
