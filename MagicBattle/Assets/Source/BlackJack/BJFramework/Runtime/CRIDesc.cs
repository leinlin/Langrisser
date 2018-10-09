using System;
using System.Collections.Generic;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200001F RID: 31
	public class CRIDesc
	{
		// Token: 0x04000097 RID: 151
		public string m_acfFullPath;

		// Token: 0x04000098 RID: 152
		public List<CRIDesc.SheetDesc> m_sheetList = new List<CRIDesc.SheetDesc>();

		// Token: 0x02000020 RID: 32
		public class SheetDesc
		{
			// Token: 0x04000099 RID: 153
			public string m_sheetName;

			// Token: 0x0400009A RID: 154
			public string m_acbFullPath;

			// Token: 0x0400009B RID: 155
			public string m_awbFullPath;
		}
	}
}
