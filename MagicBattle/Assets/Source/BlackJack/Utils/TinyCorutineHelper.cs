using System;
using System.Collections;
using System.Collections.Generic;
using SLua;

namespace BlackJack.Utils
{
	// Token: 0x020000D7 RID: 215
	[CustomLuaClass]
	public class TinyCorutineHelper
	{
		// Token: 0x0600084B RID: 2123 RVA: 0x00024AC0 File Offset: 0x00022CC0
		public void StartCorutine(Func<IEnumerator> corutine)
		{
			this.m_corutineList.AddLast(corutine());
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00024AD4 File Offset: 0x00022CD4
		public void StartCorutine(IEnumerator corutine)
		{
			this.m_corutineList.AddLast(corutine);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00024AE4 File Offset: 0x00022CE4
		public void StartLuaCoroutine(LuaFunction func)
		{
			this.StartCorutine(this.LuaCoroutine(func));
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00024AF4 File Offset: 0x00022CF4
		internal IEnumerator LuaCoroutine(LuaFunction func)
		{
			LuaThreadWrapper thread = new LuaThreadWrapper(func);
			object obj;
			while (thread.Resume(out obj))
			{
				yield return obj;
			}
			yield break;
			yield break;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00024B10 File Offset: 0x00022D10
		public void CancelAll()
		{
			this.m_cancel = true;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00024B1C File Offset: 0x00022D1C
		public void Tick()
		{
			if (this.m_corutineList.Count == 0)
			{
				return;
			}
			LinkedListNode<IEnumerator> next;
			for (LinkedListNode<IEnumerator> linkedListNode = this.m_corutineList.First; linkedListNode != null; linkedListNode = next)
			{
				if (this.m_cancel)
				{
					break;
				}
				bool flag = TinyCorutineHelper.MoveNext(linkedListNode.Value);
				next = linkedListNode.Next;
				if (!flag)
				{
					this.m_corutineList.Remove(linkedListNode);
				}
			}
			if (this.m_cancel)
			{
				this.m_corutineList.Clear();
				this.m_cancel = false;
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00024BA8 File Offset: 0x00022DA8
		public static bool MoveNext(IEnumerator iter)
		{
			if (iter == null)
			{
				return false;
			}
			if (iter.Current != null)
			{
				IEnumerator iter2 = iter.Current as IEnumerator;
				if (TinyCorutineHelper.MoveNext(iter2))
				{
					return true;
				}
			}
			return iter.MoveNext();
		}

		// Token: 0x04000533 RID: 1331
		private LinkedList<IEnumerator> m_corutineList = new LinkedList<IEnumerator>();

		// Token: 0x04000534 RID: 1332
		private bool m_cancel;
	}
}
