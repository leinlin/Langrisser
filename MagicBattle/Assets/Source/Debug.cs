using System;
using System.Text;
using System.Threading;
using BlackJack.BJFramework.Runtime.Log;
using SLua;
using UnityEngine;

// Token: 0x02000053 RID: 83
[CustomLuaClass]
public static class Debug
{
	// Token: 0x060003B4 RID: 948 RVA: 0x00011A80 File Offset: 0x0000FC80
	public static void Log(string str)
	{
		if (global::Debug.m_mainThread == null || LogManager.Instance == null)
		{
			UnityEngine.Debug.Log(str);
			return;
		}
		if (LogManager.Instance.NeedFileLog)
		{
			LogManager.Instance.FileLogger.WriteLog(str, "D");
		}
		if (Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		if (LogManager.Instance.NeedEngineLog)
		{
			LogManager.Instance.IsCallingEngineLog = true;
			UnityEngine.Debug.Log(str);
			LogManager.Instance.IsCallingEngineLog = false;
		}
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00011B08 File Offset: 0x0000FD08
	public static void Log(params object[] paramList)
	{
		string str = global::Debug.ParamListToString(paramList);
		global::Debug.Log(str);
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00011B24 File Offset: 0x0000FD24
	public static void LogWarning(string str)
	{
		if (global::Debug.m_mainThread == null || LogManager.Instance == null)
		{
			UnityEngine.Debug.LogWarning(str);
			return;
		}
		if (LogManager.Instance.NeedFileLog)
		{
			LogManager.Instance.FileLogger.WriteLog(str, "W");
		}
		if (Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		if (LogManager.Instance.NeedEngineLog)
		{
			LogManager.Instance.IsCallingEngineLog = true;
			UnityEngine.Debug.LogWarning(str);
			LogManager.Instance.IsCallingEngineLog = false;
		}
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00011BAC File Offset: 0x0000FDAC
	public static void LogWarning(params object[] paramList)
	{
		string str = global::Debug.ParamListToString(paramList);
		global::Debug.LogWarning(str);
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00011BC8 File Offset: 0x0000FDC8
	public static void LogError(string str)
	{
		if (global::Debug.m_mainThread == null || LogManager.Instance == null)
		{
			UnityEngine.Debug.LogError(str);
			return;
		}
		if (LogManager.Instance.NeedFileLog)
		{
			LogManager.Instance.FileLogger.WriteLog(str, "E");
		}
		if (Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		if (LogManager.Instance.NeedEngineLog)
		{
			LogManager.Instance.IsCallingEngineLog = true;
			UnityEngine.Debug.LogError(str);
			LogManager.Instance.IsCallingEngineLog = false;
		}
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00011C50 File Offset: 0x0000FE50
	public static void LogError(params object[] paramList)
	{
		string str = global::Debug.ParamListToString(paramList);
		global::Debug.LogError(str);
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00011C6C File Offset: 0x0000FE6C
	public static void Assert(bool value, string str)
	{
		if (!value)
		{
			if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
			{
				return;
			}
			global::Debug.LogError(str);
		}
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00011C94 File Offset: 0x0000FE94
	public static void Assert(bool value, params object[] paramList)
	{
		if (!value)
		{
			if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
			{
				return;
			}
			global::Debug.LogError(paramList);
		}
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00011CBC File Offset: 0x0000FEBC
	public static void WriteLine(string str)
	{
		global::Debug.Log(str);
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00011CC4 File Offset: 0x0000FEC4
	public static void WriteLine(params object[] paramList)
	{
		global::Debug.Log(paramList);
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00011CCC File Offset: 0x0000FECC
	public static void SystemLogException(params object[] paramList)
	{
		global::Debug.LogError(paramList);
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00011CD4 File Offset: 0x0000FED4
	public static void Break()
	{
		if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		UnityEngine.Debug.Break();
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00011CF8 File Offset: 0x0000FEF8
	private static string ParamListToString(object[] paramList)
	{
		if (paramList == null || paramList.Length == 0)
		{
			return string.Empty;
		}
		if (paramList.Length == 1)
		{
			return paramList[0].ToString();
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < paramList.Length; i++)
		{
			if (i != 0)
			{
				stringBuilder.Append(";\t");
			}
			object obj = paramList[i];
			if (obj != null)
			{
				stringBuilder.Append(paramList[i].ToString());
			}
			else
			{
				stringBuilder.Append("NULL_PARAM");
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00011D88 File Offset: 0x0000FF88
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
	{
		if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		UnityEngine.Debug.DrawLine(start, end, color, duration, depthTest);
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00011DB0 File Offset: 0x0000FFB0
	public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
	{
		if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		UnityEngine.Debug.DrawLine(start, end, color, duration);
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x00011DD8 File Offset: 0x0000FFD8
	public static void DrawLine(Vector3 start, Vector3 end, Color color)
	{
		if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		UnityEngine.Debug.DrawLine(start, end, color);
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00011DFC File Offset: 0x0000FFFC
	public static void DrawLine(Vector3 start, Vector3 end)
	{
		if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		UnityEngine.Debug.DrawLine(start, end);
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00011E20 File Offset: 0x00010020
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
	{
		if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		UnityEngine.Debug.DrawRay(start, dir, color, duration, depthTest);
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00011E48 File Offset: 0x00010048
	public static void DrawRay(Vector3 start, Vector3 dir, Color color)
	{
		if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		UnityEngine.Debug.DrawRay(start, dir, color);
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00011E6C File Offset: 0x0001006C
	public static void DrawRay(Vector3 start, Vector3 dir)
	{
		if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		UnityEngine.Debug.DrawRay(start, dir);
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00011E90 File Offset: 0x00010090
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
	{
		if (global::Debug.m_mainThread != null && Thread.CurrentThread != global::Debug.m_mainThread)
		{
			return;
		}
		UnityEngine.Debug.DrawRay(start, dir, color);
	}

	// Token: 0x040001AA RID: 426
	public static Thread m_mainThread;
}
