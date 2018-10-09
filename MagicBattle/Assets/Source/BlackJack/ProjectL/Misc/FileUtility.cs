using System;
using System.IO;
using System.Text;
using SLua;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000870 RID: 2160
	[CustomLuaClass]
	public class FileUtility
	{
		// Token: 0x06006B43 RID: 27459 RVA: 0x001E16E8 File Offset: 0x001DF8E8
		public static string ReadText(string fname)
		{
			if (string.IsNullOrEmpty(fname))
			{
				return string.Empty;
			}
			try
			{
				string text = File.ReadAllText(fname, Encoding.UTF8);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			catch (Exception arg)
			{
				Debug.LogError("FileUtility.ReadText Error: " + arg);
			}
			return string.Empty;
		}

		// Token: 0x06006B44 RID: 27460 RVA: 0x001E1758 File Offset: 0x001DF958
		public static bool WriteText(string fname, string txt)
		{
			if (string.IsNullOrEmpty(fname))
			{
				return false;
			}
			try
			{
				File.WriteAllText(fname, txt, Encoding.UTF8);
				return true;
			}
			catch (Exception arg)
			{
				Debug.LogError("FileUtility.WriteText Error: " + arg);
			}
			return false;
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x001E17B0 File Offset: 0x001DF9B0
		public static byte[] ReadBytes(string fname)
		{
			if (string.IsNullOrEmpty(fname))
			{
				return null;
			}
			try
			{
				return File.ReadAllBytes(fname);
			}
			catch (Exception arg)
			{
				Debug.LogError("FileUtility.ReadBytes Error: " + arg);
			}
			return null;
		}

		// Token: 0x06006B46 RID: 27462 RVA: 0x001E1800 File Offset: 0x001DFA00
		public static bool WriteBytes(string fname, byte[] bytes)
		{
			if (string.IsNullOrEmpty(fname))
			{
				return false;
			}
			if (bytes == null || bytes.Length <= 0)
			{
				return false;
			}
			try
			{
				File.WriteAllBytes(fname, bytes);
				return true;
			}
			catch (Exception arg)
			{
				Debug.LogError("FileUtility.WriteBytes Error: " + arg);
			}
			return false;
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x001E1864 File Offset: 0x001DFA64
		public static bool DeleteFile(string fname)
		{
			if (string.IsNullOrEmpty(fname))
			{
				return false;
			}
			try
			{
				File.Delete(fname);
				return true;
			}
			catch (Exception arg)
			{
				Debug.LogError("FileUtility.DeleteFile Error: " + arg);
			}
			return false;
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x001E18B4 File Offset: 0x001DFAB4
		public static bool IsFileExist(string fname)
		{
			if (string.IsNullOrEmpty(fname))
			{
				return false;
			}
			try
			{
				FileInfo fileInfo = new FileInfo(fname);
				return fileInfo.Exists;
			}
			catch (Exception arg)
			{
				Debug.LogError("FileUtility.IsFileExist Error: " + arg);
			}
			return false;
		}
	}
}
