using System;
using System.Collections.Generic;
using System.Text;
using SLua;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000590 RID: 1424
	[CustomLuaClass]
	public class SensitiveWords
	{
		// Token: 0x060051FA RID: 20986 RVA: 0x0018557C File Offset: 0x0018377C
		public void InitSensitiveWord(string word)
		{
			if (word == null || word.Length <= 0)
			{
				return;
			}
			char key = word[0];
			LinkedList<string> linkedList;
			if (!this.m_initialChar2Word.TryGetValue(key, out linkedList))
			{
				linkedList = new LinkedList<string>();
				this.m_initialChar2Word.Add(key, linkedList);
			}
			this.InsertWordByLength(linkedList, word);
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x001855D4 File Offset: 0x001837D4
		private void InsertWordByLength(LinkedList<string> words, string word)
		{
			LinkedListNode<string> linkedListNode;
			for (linkedListNode = words.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				if (word.Length >= linkedListNode.Value.Length)
				{
					break;
				}
			}
			if (linkedListNode != null)
			{
				words.AddBefore(linkedListNode, word);
			}
			else
			{
				words.AddLast(word);
			}
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x00185634 File Offset: 0x00183834
		public bool IsSensitiveWord(string sentence)
		{
			if (sentence == null)
			{
				return true;
			}
			HashSet<char> hashSet = new HashSet<char>();
			foreach (char c in sentence)
			{
				if (!hashSet.Contains(c))
				{
					LinkedList<string> linkedList;
					if (!this.m_initialChar2Word.TryGetValue(c, out linkedList))
					{
						hashSet.Add(c);
					}
					else
					{
						foreach (string value in linkedList)
						{
							if (sentence.Contains(value))
							{
								return true;
							}
						}
						hashSet.Add(c);
					}
				}
			}
			return false;
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00185708 File Offset: 0x00183908
		public string ReplaceSensitiveWord(string sentence, char replaceChar = '*')
		{
			if (sentence == null)
			{
				return sentence;
			}
			HashSet<char> hashSet = new HashSet<char>();
			StringBuilder stringBuilder = new StringBuilder(sentence);
			bool flag = false;
			int length = sentence.Length;
			for (int i = 0; i < length; i++)
			{
				char c = stringBuilder[i];
				if (c != replaceChar)
				{
					if (!hashSet.Contains(c))
					{
						LinkedList<string> linkedList;
						if (!this.m_initialChar2Word.TryGetValue(c, out linkedList))
						{
							hashSet.Add(c);
						}
						else
						{
							int num = 0;
							bool flag2 = false;
							foreach (string text in linkedList)
							{
								if (sentence.Contains(text))
								{
									int length2 = text.Length;
									if (!flag2)
									{
										num = length2 - 1;
										flag2 = true;
									}
									else if (num < length2 - 1)
									{
										num = length2 - 1;
									}
									flag = true;
									string newValue = this.CombineReplaceChar(replaceChar, length2);
									stringBuilder.Replace(text, newValue, i, length - i);
								}
							}
							hashSet.Add(c);
							if (flag2)
							{
								i += num;
							}
						}
					}
				}
			}
			return (!flag) ? sentence : stringBuilder.ToString();
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x00185860 File Offset: 0x00183A60
		private string CombineReplaceChar(char replaceChar, int nums)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < nums; i++)
			{
				stringBuilder.Append(replaceChar);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04003AB3 RID: 15027
		private Dictionary<char, LinkedList<string>> m_initialChar2Word = new Dictionary<char, LinkedList<string>>();
	}
}
