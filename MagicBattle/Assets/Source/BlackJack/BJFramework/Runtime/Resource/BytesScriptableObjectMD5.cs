using System;

namespace BlackJack.BJFramework.Runtime.Resource
{
	// Token: 0x02000088 RID: 136
	public class BytesScriptableObjectMD5 : BytesScripableObject
	{
		// Token: 0x060005B4 RID: 1460 RVA: 0x00019038 File Offset: 0x00017238
		public override void SetBytes(byte[] bytes)
		{
			base.SetBytes(bytes);
			this.m_MD5 = Util.CreateMd5FromBytes(this.m_bytes);
		}

		// Token: 0x040002FB RID: 763
		public string m_MD5;
	}
}
