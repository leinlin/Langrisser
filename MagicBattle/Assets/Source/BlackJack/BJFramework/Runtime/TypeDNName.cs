using System;
using SLua;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200002C RID: 44
	[CustomLuaClass]
	[Serializable]
	public class TypeDNName
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		public TypeDNName(string typeDNName)
		{
			int num = typeDNName.IndexOf('@');
			if (num == -1)
			{
				this.m_assemblyName = "Assembly-CSharp";
				this.m_typeFullName = typeDNName;
			}
			else
			{
				this.m_assemblyName = typeDNName.Substring(0, num);
				this.m_typeFullName = typeDNName.Substring(num + 1);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000D8F8 File Offset: 0x0000BAF8
		public override string ToString()
		{
			return string.Format("{0}@{1}", this.m_assemblyName, this.m_typeFullName);
		}

		// Token: 0x040000B7 RID: 183
		public string m_assemblyName;

		// Token: 0x040000B8 RID: 184
		public string m_typeFullName;
	}
}
