using System;
using System.Security.Cryptography;
using System.Text;

namespace BlackJack.UtilityTools
{
	// Token: 0x02000595 RID: 1429
	public static class ZiLongSign
	{
		// Token: 0x06005217 RID: 21015 RVA: 0x00185D60 File Offset: 0x00183F60
		public static string GenerateMD5Signature(string plainString)
		{
			string result;
			using (MD5 md = new MD5CryptoServiceProvider())
			{
				StringBuilder stringBuilder = new StringBuilder();
				byte[] array = md.ComputeHash(Encoding.UTF8.GetBytes(plainString));
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("X2"));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}
	}
}
