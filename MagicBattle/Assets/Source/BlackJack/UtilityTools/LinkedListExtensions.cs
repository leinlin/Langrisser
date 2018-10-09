using System;
using System.Collections.Generic;

namespace BlackJack.UtilityTools
{
	// Token: 0x0200058F RID: 1423
	public static class LinkedListExtensions
	{
		// Token: 0x060051F5 RID: 20981 RVA: 0x00185458 File Offset: 0x00183658
		public static LinkedListNode<T> Find<T>(this LinkedList<T> list, Predicate<T> pred)
		{
			LinkedListNode<T> linkedListNode;
			for (linkedListNode = list.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				if (pred(linkedListNode.Value))
				{
					break;
				}
			}
			return linkedListNode;
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x00185498 File Offset: 0x00183698
		public static LinkedListNode<T> AddAfterFromLast<T>(this LinkedList<T> list, T element, Predicate<T> pred)
		{
			if (list == null)
			{
				return null;
			}
			return list.AddAfterFromSpecific(element, list.Last, pred);
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x001854B0 File Offset: 0x001836B0
		public static LinkedListNode<T> AddAfterFromSpecific<T>(this LinkedList<T> list, T element, LinkedListNode<T> specific, Predicate<T> pred)
		{
			if (list == null)
			{
				return null;
			}
			for (LinkedListNode<T> linkedListNode = specific; linkedListNode != null; linkedListNode = linkedListNode.Previous)
			{
				if (pred(linkedListNode.Value))
				{
					return list.AddAfter(linkedListNode, element);
				}
			}
			return list.AddFirst(element);
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x00185500 File Offset: 0x00183700
		public static void CorrectNode<T>(this LinkedList<T> list, LinkedListNode<T> correctNode, Predicate<T> pred)
		{
			LinkedListNode<T> previous = correctNode.Previous;
			if (previous == null)
			{
				return;
			}
			while (previous != null)
			{
				if (pred(previous.Value))
				{
					if (correctNode.Previous != previous)
					{
						list.Remove(correctNode);
						list.AddAfter(previous, correctNode);
					}
					return;
				}
				previous = previous.Previous;
			}
			list.Remove(correctNode);
			list.AddFirst(correctNode);
		}
	}
}
