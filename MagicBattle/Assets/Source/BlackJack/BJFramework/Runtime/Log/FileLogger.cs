using System;
using System.Diagnostics;
using System.IO;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Log
{
	// Token: 0x02000054 RID: 84
	public class FileLogger
	{
		// Token: 0x060003CA RID: 970 RVA: 0x00011EB8 File Offset: 0x000100B8
		public FileLogger(string logFileRoot, string logName)
		{
			if (!Directory.Exists(logFileRoot))
			{
				try
				{
					Directory.CreateDirectory(logFileRoot);
				}
				catch (Exception ex)
				{
					UnityEngine.Debug.Log("Create log directory fail " + ex.ToString());
					return;
				}
			}
			this._logFileRoot = logFileRoot;
			this._logName = logName;
			this._logFileFullPath = this.GetNewFileFullPath();
			this._logStreamWriter = new StreamWriter(this._logFileFullPath);
			UnityEngine.Debug.Log("Create Log File " + this._logFileFullPath);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00011F50 File Offset: 0x00010150
		private string GetNewFileFullPath()
		{
			return this._logFileRoot + this._logName + DateTime.Now.ToString("yyyy_MMdd_HHmm_ss") + ".txt";
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00011F88 File Offset: 0x00010188
		public void WriteLog(string msg, string level)
		{
			if (this._logStreamWriter == null)
			{
				return;
			}
			object logStreamWriter = this._logStreamWriter;
			lock (logStreamWriter)
			{
				try
				{
					string text = string.Format("[{0}][{1}] {2}", level, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), msg);
					this._logStreamWriter.WriteLine(text);
					this._logStreamWriter.Flush();
					if (this.EventOnLog != null)
					{
						this.EventOnLog(text);
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00012030 File Offset: 0x00010230
		public void Close()
		{
			if (this._logStreamWriter == null)
			{
				return;
			}
			object logStreamWriter = this._logStreamWriter;
			lock (logStreamWriter)
			{
				try
				{
					this._logStreamWriter.Close();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060003CE RID: 974 RVA: 0x00012094 File Offset: 0x00010294
		// (remove) Token: 0x060003CF RID: 975 RVA: 0x000120CC File Offset: 0x000102CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<string> EventOnLog;

		// Token: 0x040001AB RID: 427
		private string _logFileRoot;

		// Token: 0x040001AC RID: 428
		private string _logName;

		// Token: 0x040001AD RID: 429
		private string _logFileFullPath;

		// Token: 0x040001AE RID: 430
		private StreamWriter _logStreamWriter;
	}
}
