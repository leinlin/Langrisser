using System;
using UnityEngine;

namespace BlackJack.BJFramework.Runtime.Log
{
	// Token: 0x02000055 RID: 85
	public class LogManager
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x00012104 File Offset: 0x00010304
		private LogManager()
		{
			Application.logMessageReceived += this.OnReceiveUnityEngineLog;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00012124 File Offset: 0x00010324
		private void OnReceiveUnityEngineLog(string log, string stackTrace, LogType type)
		{
			if (this.FileLogger == null)
			{
				return;
			}
			if (this.IsCallingEngineLog)
			{
				return;
			}
			if (this.NeedFileLog)
			{
				if (type == LogType.Log)
				{
					this.FileLogger.WriteLog(log, "D");
				}
				else if (type == LogType.Warning)
				{
					this.FileLogger.WriteLog(log, "W");
				}
				else
				{
					this.FileLogger.WriteLog(log, "E");
				}
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000121A0 File Offset: 0x000103A0
		public static LogManager CreateLogManager()
		{
			if (LogManager.m_instance == null)
			{
				LogManager.m_instance = new LogManager();
			}
			return LogManager.m_instance;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000121BC File Offset: 0x000103BC
		public bool Initlize(bool needEngineLog, bool needFileLog, string logFileRoot, string logName)
		{
			this.NeedEngineLog = needEngineLog;
			this.NeedFileLog = needFileLog;
			if (needFileLog && this.FileLogger == null)
			{
				this.FileLogger = new FileLogger(logFileRoot, logName);
			}
			return true;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000121EC File Offset: 0x000103EC
		public void Uninitlize()
		{
			if (this.FileLogger != null)
			{
				this.FileLogger.Close();
				this.FileLogger = null;
			}
			LogManager.m_instance = null;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00012214 File Offset: 0x00010414
		public static LogManager Instance
		{
			get
			{
				return LogManager.m_instance;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0001221C File Offset: 0x0001041C
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00012224 File Offset: 0x00010424
		public FileLogger FileLogger { get; private set; }

		// Token: 0x040001B0 RID: 432
		private static LogManager m_instance;

		// Token: 0x040001B2 RID: 434
		public bool NeedFileLog;

		// Token: 0x040001B3 RID: 435
		public bool NeedEngineLog = true;

		// Token: 0x040001B4 RID: 436
		public bool IsCallingEngineLog;
	}
}
