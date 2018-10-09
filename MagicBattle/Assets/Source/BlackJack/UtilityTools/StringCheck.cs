using System;
using SLua;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000591 RID: 1425
	[CustomLuaClass]
	public class StringCheck
	{
		// Token: 0x06005200 RID: 20992 RVA: 0x0018589C File Offset: 0x00183A9C
		public static bool IsStringLegal(string checkingString)
		{
			foreach (char c in checkingString)
			{
				if (!StringCheck.IsDigitChar(c) && !StringCheck.IsEnglishChar(c) && !StringCheck.IsChineseChar(c) && !StringCheck.IsJapaneseChar(c))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x00185900 File Offset: 0x00183B00
		public static bool IsDigitChar(char c)
		{
			return c >= '0' && c <= '9';
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x00185918 File Offset: 0x00183B18
		public static bool IsEnglishChar(char c)
		{
			return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x00185940 File Offset: 0x00183B40
		public static bool IsChineseChar(char c)
		{
			return c >= '一' && c <= '龥';
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x0018595C File Offset: 0x00183B5C
		public static bool IsJapaneseChar(char c)
		{
			return (c >= '぀' && c <= 'ゟ') || (c >= '゠' && c <= 'ヿ');
		}
	}
}
