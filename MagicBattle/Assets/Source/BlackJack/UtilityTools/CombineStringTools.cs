using System;
using System.Linq;
using System.Text;

namespace BlackJack.UtilityTools
{
	// Token: 0x0200059A RID: 1434
	public class CombineStringTools
	{
		// Token: 0x06005225 RID: 21029 RVA: 0x00185F30 File Offset: 0x00184130
		public static string ReplaceHasParamContent(string paramContent, string param)
		{
			string[] array = param.Split(new char[]
			{
				'|'
			});
			string text = paramContent;
			for (int i = 0; i < array.Length; i++)
			{
				string oldValue = string.Format("[{0}]", i);
				text = text.Replace(oldValue, array[i]);
			}
			return text;
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x00185F84 File Offset: 0x00184184
		public static string BuildParam(params object[] param)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = param.Count<object>();
			for (int i = 0; i < num; i++)
			{
				stringBuilder.Append(param[i]);
				if (i != num - 1)
				{
					stringBuilder.Append("|");
				}
			}
			return stringBuilder.ToString();
		}
	}
}
