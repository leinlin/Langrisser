using System;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000429 RID: 1065
	public static class NameStringExtension
	{
		// Token: 0x06003D67 RID: 15719 RVA: 0x00114F6C File Offset: 0x0011316C
		public static int IsValidName(this string Name, IConfigDataLoader ConfigDataLoader)
		{
			if (string.IsNullOrEmpty(Name))
			{
				return -9;
			}
			if (!StringCheck.IsStringLegal(Name))
			{
				return -7;
			}
			if (ConfigDataLoader != null && ConfigDataLoader.UtilityGetSensitiveWords().IsSensitiveWord(Name))
			{
				return -7;
			}
			return 0;
		}
	}
}
