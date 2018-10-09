using System;
using SLua;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000589 RID: 1417
	[CustomLuaClass]
	public class ThreadSaftyRandom : Random
	{
		// Token: 0x060051D4 RID: 20948 RVA: 0x00184AA0 File Offset: 0x00182CA0
		public ThreadSaftyRandom()
		{
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x00184AB4 File Offset: 0x00182CB4
		public ThreadSaftyRandom(int Seed) : base(Seed)
		{
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x00184AC8 File Offset: 0x00182CC8
		public override int Next()
		{
			object lockToken = this.m_lockToken;
			int result;
			lock (lockToken)
			{
				result = base.Next();
			}
			return result;
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x00184B08 File Offset: 0x00182D08
		public override int Next(int maxValue)
		{
			object lockToken = this.m_lockToken;
			int result;
			lock (lockToken)
			{
				result = base.Next(maxValue);
			}
			return result;
		}

		// Token: 0x060051D8 RID: 20952 RVA: 0x00184B48 File Offset: 0x00182D48
		public override int Next(int minValue, int maxValue)
		{
			object lockToken = this.m_lockToken;
			int result;
			lock (lockToken)
			{
				result = base.Next(minValue, maxValue);
			}
			return result;
		}

		// Token: 0x060051D9 RID: 20953 RVA: 0x00184B88 File Offset: 0x00182D88
		public override double NextDouble()
		{
			object lockToken = this.m_lockToken;
			double result;
			lock (lockToken)
			{
				result = base.NextDouble();
			}
			return result;
		}

		// Token: 0x04003AAE RID: 15022
		private object m_lockToken = new object();
	}
}
