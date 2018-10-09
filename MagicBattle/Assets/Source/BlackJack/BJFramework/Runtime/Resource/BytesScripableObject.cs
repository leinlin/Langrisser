using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Resource
{
	// Token: 0x02000087 RID: 135
	public class BytesScripableObject : ScriptableObject
	{
		// Token: 0x060005B1 RID: 1457 RVA: 0x00019014 File Offset: 0x00017214
		public virtual void SetBytes(byte[] bytes)
		{
			this.m_bytes = bytes;
			this.m_size = bytes.Length;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00019028 File Offset: 0x00017228
		public byte[] GetBytes()
		{
			return this.m_bytes;
		}

		// Token: 0x040002F9 RID: 761
		public int m_size;

		// Token: 0x040002FA RID: 762
		[SerializeField]
		protected byte[] m_bytes;
	}
}
