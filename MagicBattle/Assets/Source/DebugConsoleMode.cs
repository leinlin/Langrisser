using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEngine;

// Token: 0x0200107E RID: 4222
public class DebugConsoleMode : IConsoleMode
{
	// Token: 0x060155DE RID: 87518 RVA: 0x0056B838 File Offset: 0x00569A38
	private DebugConsoleMode()
	{
		DebugConsoleMode._instance = this;
	}

	// Token: 0x140004CD RID: 1229
	// (add) Token: 0x060155DF RID: 87519 RVA: 0x0056B868 File Offset: 0x00569A68
	// (remove) Token: 0x060155E0 RID: 87520 RVA: 0x0056B8A0 File Offset: 0x00569AA0
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event DebugConsoleMode.refreshDelegate refreshEvent;

	// Token: 0x060155E1 RID: 87521 RVA: 0x0056B8D8 File Offset: 0x00569AD8
	public void SetFilterString(List<string> includeStrings, List<string> excludeStrings)
	{
		if (includeStrings != null)
		{
			this._includeFilterStrings = includeStrings;
		}
		if (excludeStrings != null)
		{
			this._excludeFilterStrings = excludeStrings;
		}
	}

	// Token: 0x060155E2 RID: 87522 RVA: 0x0056B8F4 File Offset: 0x00569AF4
	public static DebugConsoleMode Create()
	{
		DebugConsoleMode debugConsoleMode = new DebugConsoleMode();
		debugConsoleMode._Init();
		return debugConsoleMode;
	}

	// Token: 0x060155E3 RID: 87523 RVA: 0x0056B910 File Offset: 0x00569B10
	private void _Init()
	{
		this._debugCmdManager = DebugCmdManager.Create(this);
		Application.logMessageReceived += this._LogCallback;
	}

	// Token: 0x060155E4 RID: 87524 RVA: 0x0056B930 File Offset: 0x00569B30
	public void _LogReceived(string log)
	{
		this.Log(log);
	}

	// Token: 0x060155E5 RID: 87525 RVA: 0x0056B93C File Offset: 0x00569B3C
	public void _LogCallback(string condition, string stackTrace, LogType type)
	{
		if (type == LogType.Error || type == LogType.Assert)
		{
			this.Log(string.Format("[E] {0}", condition));
		}
		else if (type == LogType.Warning)
		{
			this.Log(string.Format("[W] {0}", condition));
		}
		else
		{
			this.Log(string.Format("[D] {0}", condition));
		}
	}

	// Token: 0x060155E6 RID: 87526 RVA: 0x0056B99C File Offset: 0x00569B9C
	public void ClearLog()
	{
		this._removedLogText.Append(this._logText);
		this._logText.Remove(0, this._logText.Length);
		if (this.refreshEvent != null)
		{
			this.refreshEvent();
		}
	}

	// Token: 0x060155E7 RID: 87527 RVA: 0x0056B9EC File Offset: 0x00569BEC
	private void Log(string info)
	{
		if (this._includeFilterStrings != null && this._includeFilterStrings.Count > 0)
		{
			int num = 0;
			foreach (string value in this._includeFilterStrings)
			{
				if (info.IndexOf(value) >= 0)
				{
					num++;
				}
			}
			if (num == 0)
			{
				return;
			}
		}
		if (this._excludeFilterStrings != null && this._excludeFilterStrings.Count > 0)
		{
			foreach (string value2 in this._excludeFilterStrings)
			{
				if (info.IndexOf(value2) >= 0)
				{
					return;
				}
			}
		}
		if (this._logText != null && this._logText.Length > 10000)
		{
			int length = (int)((double)this._logText.Length * 0.2);
			this._removedLogText.Append(this._logText.ToString(0, length));
			this._logText.Remove(0, length);
		}
		this._logText.AppendLine(info);
		this.Log2File(info);
		if (this.refreshEvent != null)
		{
			this.refreshEvent();
		}
	}

	// Token: 0x060155E8 RID: 87528 RVA: 0x0056BB78 File Offset: 0x00569D78
	public string GetLogText()
	{
		return this._logText.ToString();
	}

	// Token: 0x060155E9 RID: 87529 RVA: 0x0056BB88 File Offset: 0x00569D88
	public void ProcessCmd(string instruction)
	{
		this._debugCmdManager.RunInstruct(instruction);
	}

	// Token: 0x17003E58 RID: 15960
	// (get) Token: 0x060155EA RID: 87530 RVA: 0x0056BB98 File Offset: 0x00569D98
	public static DebugConsoleMode instance
	{
		get
		{
			return DebugConsoleMode._instance;
		}
	}

	// Token: 0x060155EB RID: 87531 RVA: 0x0056BBA0 File Offset: 0x00569DA0
	public void Save()
	{
		string text = string.Format("{0}{1}{2}_{3}{4:D2}{5:D2}_{6:D2}{7:D2}{8:D2}.log", new object[]
		{
			Application.persistentDataPath,
			Path.AltDirectorySeparatorChar,
			"DebugLog",
			DateTime.Now.Year,
			DateTime.Now.Month,
			DateTime.Now.Day,
			DateTime.Now.Hour,
			DateTime.Now.Minute,
			DateTime.Now.Second
		});
		StreamWriter streamWriter = new StreamWriter(text);
		streamWriter.Write(this._removedLogText);
		streamWriter.Write(this._logText);
		streamWriter.Close();
		this.Log(string.Format("【{0}】 saved.", text));
	}

	// Token: 0x060155EC RID: 87532 RVA: 0x0056BC98 File Offset: 0x00569E98
	private void Log2File(string log)
	{
		if (!this._enableRuntimeLogFile)
		{
			return;
		}
		this._runtimeLogWriter.WriteLine(log);
		this._runtimeLogWriter.Flush();
	}

	// Token: 0x060155ED RID: 87533 RVA: 0x0056BCC0 File Offset: 0x00569EC0
	public void EnableRuntimeLogFile(bool isEnable)
	{
		if (this._enableRuntimeLogFile == isEnable)
		{
			return;
		}
		this._enableRuntimeLogFile = isEnable;
		if (this._enableRuntimeLogFile)
		{
			string path = string.Format("{0}{1}{2}_{3}{4:D2}{5:D2}_{6:D2}{7:D2}{8:D2}.log", new object[]
			{
				Application.persistentDataPath,
				Path.AltDirectorySeparatorChar,
				"RuntimeLog",
				DateTime.Now.Year,
				DateTime.Now.Month,
				DateTime.Now.Day,
				DateTime.Now.Hour,
				DateTime.Now.Minute,
				DateTime.Now.Second
			});
			this._runtimeLogWriter = new StreamWriter(path);
		}
		else
		{
			this._runtimeLogWriter.Dispose();
			this._runtimeLogWriter = null;
		}
	}

	// Token: 0x0400BA4A RID: 47690
	private const int _maxLogLength = 10000;

	// Token: 0x0400BA4B RID: 47691
	private StringBuilder _logText = new StringBuilder(20000);

	// Token: 0x0400BA4C RID: 47692
	private StringBuilder _removedLogText = new StringBuilder(50000);

	// Token: 0x0400BA4D RID: 47693
	private DebugCmdManager _debugCmdManager;

	// Token: 0x0400BA4E RID: 47694
	private static DebugConsoleMode _instance;

	// Token: 0x0400BA4F RID: 47695
	private List<string> _includeFilterStrings;

	// Token: 0x0400BA50 RID: 47696
	private List<string> _excludeFilterStrings;

	// Token: 0x0400BA51 RID: 47697
	private bool _enableRuntimeLogFile;

	// Token: 0x0400BA52 RID: 47698
	private StreamWriter _runtimeLogWriter;

	// Token: 0x0200107F RID: 4223
	// (Invoke) Token: 0x060155EF RID: 87535
	public delegate void refreshDelegate();
}
