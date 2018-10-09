using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

// Token: 0x02001087 RID: 4231
public sealed class BuglyAgent
{
	// Token: 0x06015629 RID: 87593 RVA: 0x0056CCC8 File Offset: 0x0056AEC8
	public static void ConfigCrashReporter(int type, int logLevel)
	{
		BuglyAgent._SetCrashReporterType(type);
		BuglyAgent._SetCrashReporterLogLevel(logLevel);
	}

	// Token: 0x0601562A RID: 87594 RVA: 0x0056CCD8 File Offset: 0x0056AED8
	public static void InitWithAppId(string appId)
	{
		if (BuglyAgent.IsInitialized)
		{
			BuglyAgent.DebugLog(null, "BuglyAgent has already been initialized.", new object[0]);
			return;
		}
		if (string.IsNullOrEmpty(appId))
		{
			return;
		}
		BuglyAgent.InitBuglyAgent(appId);
		BuglyAgent.DebugLog(null, "Initialized with app id: {0}", new object[]
		{
			appId
		});
		BuglyAgent._RegisterExceptionHandler();
	}

	// Token: 0x0601562B RID: 87595 RVA: 0x0056CD30 File Offset: 0x0056AF30
	public static void EnableExceptionHandler()
	{
		if (BuglyAgent.IsInitialized)
		{
			BuglyAgent.DebugLog(null, "BuglyAgent has already been initialized.", new object[0]);
			return;
		}
		BuglyAgent.DebugLog(null, "Only enable the exception handler, please make sure you has initialized the sdk in the native code in associated Android or iOS project.", new object[0]);
		BuglyAgent._RegisterExceptionHandler();
	}

	// Token: 0x0601562C RID: 87596 RVA: 0x0056CD64 File Offset: 0x0056AF64
	public static void RegisterLogCallback(BuglyAgent.LogCallbackDelegate handler)
	{
		if (handler != null)
		{
			BuglyAgent.DebugLog(null, "Add log callback handler: {0}", new object[]
			{
				handler
			});
			BuglyAgent._LogCallbackEventHandler += handler;
		}
	}

	// Token: 0x0601562D RID: 87597 RVA: 0x0056CD88 File Offset: 0x0056AF88
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> handler)
	{
		if (handler != null)
		{
			BuglyAgent._LogCallbackExtrasHandler = handler;
			BuglyAgent.DebugLog(null, "Add log callback extra data handler : {0}", new object[]
			{
				handler
			});
		}
	}

	// Token: 0x0601562E RID: 87598 RVA: 0x0056CDAC File Offset: 0x0056AFAC
	public static void ReportException(Exception e, string message)
	{
		if (!BuglyAgent.IsInitialized)
		{
			return;
		}
		BuglyAgent.DebugLog(null, "Report exception: {0}\n------------\n{1}\n------------", new object[]
		{
			message,
			e
		});
		BuglyAgent._HandleException(e, message, false);
	}

	// Token: 0x0601562F RID: 87599 RVA: 0x0056CDDC File Offset: 0x0056AFDC
	public static void ReportException(string name, string message, string stackTrace)
	{
		if (!BuglyAgent.IsInitialized)
		{
			return;
		}
		BuglyAgent.DebugLog(null, "Report exception: {0} {1} \n{2}", new object[]
		{
			name,
			message,
			stackTrace
		});
		BuglyAgent._HandleException(LogSeverity.LogException, name, message, stackTrace, false);
	}

	// Token: 0x06015630 RID: 87600 RVA: 0x0056CE10 File Offset: 0x0056B010
	public static void UnregisterLogCallback(BuglyAgent.LogCallbackDelegate handler)
	{
		if (handler != null)
		{
			BuglyAgent.DebugLog(null, "Remove log callback handler", new object[0]);
			BuglyAgent._LogCallbackEventHandler -= handler;
		}
	}

	// Token: 0x06015631 RID: 87601 RVA: 0x0056CE30 File Offset: 0x0056B030
	public static void SetUserId(string userId)
	{
		if (!BuglyAgent.IsInitialized)
		{
			return;
		}
		BuglyAgent.DebugLog(null, "Set user id: {0}", new object[]
		{
			userId
		});
		BuglyAgent.SetUserInfo(userId);
	}

	// Token: 0x06015632 RID: 87602 RVA: 0x0056CE58 File Offset: 0x0056B058
	public static void SetScene(int sceneId)
	{
		if (!BuglyAgent.IsInitialized)
		{
			return;
		}
		BuglyAgent.DebugLog(null, "Set scene: {0}", new object[]
		{
			sceneId
		});
		BuglyAgent.SetCurrentScene(sceneId);
	}

	// Token: 0x06015633 RID: 87603 RVA: 0x0056CE88 File Offset: 0x0056B088
	public static void AddSceneData(string key, string value)
	{
		if (!BuglyAgent.IsInitialized)
		{
			return;
		}
		BuglyAgent.DebugLog(null, "Add scene data: [{0}, {1}]", new object[]
		{
			key,
			value
		});
		BuglyAgent.AddKeyAndValueInScene(key, value);
	}

	// Token: 0x06015634 RID: 87604 RVA: 0x0056CEB8 File Offset: 0x0056B0B8
	public static void ConfigDebugMode(bool enable)
	{
		BuglyAgent.EnableDebugMode(enable);
		BuglyAgent.DebugLog(null, "{0} the log message print to console", new object[]
		{
			(!enable) ? "Disable" : "Enable"
		});
	}

	// Token: 0x06015635 RID: 87605 RVA: 0x0056CEEC File Offset: 0x0056B0EC
	public static void ConfigAutoQuitApplication(bool autoQuit)
	{
		BuglyAgent._autoQuitApplicationAfterReport = autoQuit;
	}

	// Token: 0x06015636 RID: 87606 RVA: 0x0056CEF4 File Offset: 0x0056B0F4
	public static void ConfigAutoReportLogLevel(LogSeverity level)
	{
		BuglyAgent._autoReportLogLevel = level;
	}

	// Token: 0x06015637 RID: 87607 RVA: 0x0056CEFC File Offset: 0x0056B0FC
	public static void ConfigDefault(string channel, string version, string user, long delay)
	{
		BuglyAgent.DebugLog(null, "Config default channel:{0}, version:{1}, user:{2}, delay:{3}", new object[]
		{
			channel,
			version,
			user,
			delay
		});
		BuglyAgent.ConfigDefaultBeforeInit(channel, version, user, delay);
	}

	// Token: 0x06015638 RID: 87608 RVA: 0x0056CF30 File Offset: 0x0056B130
	public static void DebugLog(string tag, string format, params object[] args)
	{
		if (!BuglyAgent._debugMode)
		{
			return;
		}
		if (string.IsNullOrEmpty(format))
		{
			return;
		}
		Console.WriteLine("[BuglyAgent] <Debug> - {0} : {1}", tag, string.Format(format, args));
	}

	// Token: 0x06015639 RID: 87609 RVA: 0x0056CF5C File Offset: 0x0056B15C
	public static void PrintLog(LogSeverity level, string format, params object[] args)
	{
		if (string.IsNullOrEmpty(format))
		{
			return;
		}
		BuglyAgent.LogRecord(level, string.Format(format, args));
	}

	// Token: 0x0601563A RID: 87610 RVA: 0x0056CF78 File Offset: 0x0056B178
	private static void InitBuglyAgent(string appId)
	{
	}

	// Token: 0x0601563B RID: 87611 RVA: 0x0056CF7C File Offset: 0x0056B17C
	private static void ConfigDefaultBeforeInit(string channel, string version, string user, long delay)
	{
	}

	// Token: 0x0601563C RID: 87612 RVA: 0x0056CF80 File Offset: 0x0056B180
	private static void EnableDebugMode(bool enable)
	{
	}

	// Token: 0x0601563D RID: 87613 RVA: 0x0056CF84 File Offset: 0x0056B184
	private static void SetUserInfo(string userInfo)
	{
	}

	// Token: 0x0601563E RID: 87614 RVA: 0x0056CF88 File Offset: 0x0056B188
	private static void ReportException(int type, string name, string message, string stackTrace, bool quitProgram)
	{
	}

	// Token: 0x0601563F RID: 87615 RVA: 0x0056CF8C File Offset: 0x0056B18C
	private static void SetCurrentScene(int sceneId)
	{
	}

	// Token: 0x06015640 RID: 87616 RVA: 0x0056CF90 File Offset: 0x0056B190
	private static void AddKeyAndValueInScene(string key, string value)
	{
	}

	// Token: 0x06015641 RID: 87617 RVA: 0x0056CF94 File Offset: 0x0056B194
	private static void AddExtraDataWithException(string key, string value)
	{
	}

	// Token: 0x06015642 RID: 87618 RVA: 0x0056CF98 File Offset: 0x0056B198
	private static void LogRecord(LogSeverity level, string message)
	{
	}

	// Token: 0x06015643 RID: 87619 RVA: 0x0056CF9C File Offset: 0x0056B19C
	private static void SetUnityVersion()
	{
	}

	// Token: 0x140004D0 RID: 1232
	// (add) Token: 0x06015644 RID: 87620 RVA: 0x0056CFA0 File Offset: 0x0056B1A0
	// (remove) Token: 0x06015645 RID: 87621 RVA: 0x0056CFD4 File Offset: 0x0056B1D4
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static event BuglyAgent.LogCallbackDelegate _LogCallbackEventHandler;

	// Token: 0x17003E67 RID: 15975
	// (get) Token: 0x06015646 RID: 87622 RVA: 0x0056D008 File Offset: 0x0056B208
	public static string PluginVersion
	{
		get
		{
			return BuglyAgent._pluginVersion;
		}
	}

	// Token: 0x17003E68 RID: 15976
	// (get) Token: 0x06015647 RID: 87623 RVA: 0x0056D010 File Offset: 0x0056B210
	public static bool IsInitialized
	{
		get
		{
			return BuglyAgent._isInitialized;
		}
	}

	// Token: 0x17003E69 RID: 15977
	// (get) Token: 0x06015648 RID: 87624 RVA: 0x0056D018 File Offset: 0x0056B218
	public static bool AutoQuitApplicationAfterReport
	{
		get
		{
			return BuglyAgent._autoQuitApplicationAfterReport;
		}
	}

	// Token: 0x06015649 RID: 87625 RVA: 0x0056D020 File Offset: 0x0056B220
	private static void _SetCrashReporterType(int type)
	{
		BuglyAgent._crashReporterType = type;
		if (BuglyAgent._crashReporterType == 2)
		{
		}
	}

	// Token: 0x0601564A RID: 87626 RVA: 0x0056D034 File Offset: 0x0056B234
	private static void _SetCrashReporterLogLevel(int logLevel)
	{
	}

	// Token: 0x0601564B RID: 87627 RVA: 0x0056D038 File Offset: 0x0056B238
	private static void _RegisterExceptionHandler()
	{
		try
		{
			if (BuglyAgent.<>f__mg$cache0 == null)
			{
				BuglyAgent.<>f__mg$cache0 = new Application.LogCallback(BuglyAgent._OnLogCallbackHandler);
			}
			Application.RegisterLogCallback(BuglyAgent.<>f__mg$cache0);
			AppDomain currentDomain = AppDomain.CurrentDomain;
			if (BuglyAgent.<>f__mg$cache1 == null)
			{
				BuglyAgent.<>f__mg$cache1 = new UnhandledExceptionEventHandler(BuglyAgent._OnUncaughtExceptionHandler);
			}
			currentDomain.UnhandledException += BuglyAgent.<>f__mg$cache1;
			BuglyAgent._isInitialized = true;
			BuglyAgent.DebugLog(null, "Register the log callback in Unity {0}", new object[]
			{
				Application.unityVersion
			});
		}
		catch
		{
		}
		BuglyAgent.SetUnityVersion();
	}

	// Token: 0x0601564C RID: 87628 RVA: 0x0056D0D0 File Offset: 0x0056B2D0
	private static void _UnregisterExceptionHandler()
	{
		try
		{
			Application.RegisterLogCallback(null);
			AppDomain currentDomain = AppDomain.CurrentDomain;
			if (BuglyAgent.<>f__mg$cache2 == null)
			{
				BuglyAgent.<>f__mg$cache2 = new UnhandledExceptionEventHandler(BuglyAgent._OnUncaughtExceptionHandler);
			}
			currentDomain.UnhandledException -= BuglyAgent.<>f__mg$cache2;
			BuglyAgent.DebugLog(null, "Unregister the log callback in unity {0}", new object[]
			{
				Application.unityVersion
			});
		}
		catch
		{
		}
	}

	// Token: 0x0601564D RID: 87629 RVA: 0x0056D140 File Offset: 0x0056B340
	private static void _OnLogCallbackHandler(string condition, string stackTrace, LogType type)
	{
		if (BuglyAgent._LogCallbackEventHandler != null)
		{
			BuglyAgent._LogCallbackEventHandler(condition, stackTrace, type);
		}
		if (!BuglyAgent.IsInitialized)
		{
			return;
		}
		if (!string.IsNullOrEmpty(condition) && condition.Contains("[BuglyAgent] <Log>"))
		{
			return;
		}
		if (BuglyAgent._uncaughtAutoReportOnce)
		{
			return;
		}
		LogSeverity logSeverity = LogSeverity.Log;
		switch (type)
		{
		case LogType.Error:
			logSeverity = LogSeverity.LogError;
			break;
		case LogType.Assert:
			logSeverity = LogSeverity.LogAssert;
			break;
		case LogType.Warning:
			logSeverity = LogSeverity.LogWarning;
			break;
		case LogType.Log:
			logSeverity = LogSeverity.LogDebug;
			break;
		case LogType.Exception:
			logSeverity = LogSeverity.LogException;
			break;
		}
		if (logSeverity == LogSeverity.Log)
		{
			return;
		}
		BuglyAgent._HandleException(logSeverity, null, condition, stackTrace, true);
	}

	// Token: 0x0601564E RID: 87630 RVA: 0x0056D1F0 File Offset: 0x0056B3F0
	private static void _OnUncaughtExceptionHandler(object sender, UnhandledExceptionEventArgs args)
	{
		if (args == null || args.ExceptionObject == null)
		{
			return;
		}
		try
		{
			if (args.ExceptionObject.GetType() != typeof(Exception))
			{
				return;
			}
		}
		catch
		{
			if (UnityEngine.Debug.isDebugBuild)
			{
				UnityEngine.Debug.Log("BuglyAgent: Failed to report uncaught exception");
			}
			return;
		}
		if (!BuglyAgent.IsInitialized)
		{
			return;
		}
		if (BuglyAgent._uncaughtAutoReportOnce)
		{
			return;
		}
		BuglyAgent._HandleException((Exception)args.ExceptionObject, null, true);
	}

	// Token: 0x0601564F RID: 87631 RVA: 0x0056D288 File Offset: 0x0056B488
	private static void _HandleException(Exception e, string message, bool uncaught)
	{
		if (e == null)
		{
			return;
		}
		if (!BuglyAgent.IsInitialized)
		{
			return;
		}
		string name = e.GetType().Name;
		string text = e.Message;
		if (!string.IsNullOrEmpty(message))
		{
			text = string.Format("{0}{1}***{2}", text, Environment.NewLine, message);
		}
		StringBuilder stringBuilder = new StringBuilder(string.Empty);
		StackTrace stackTrace = new StackTrace(e, true);
		int frameCount = stackTrace.FrameCount;
		for (int i = 0; i < frameCount; i++)
		{
			StackFrame frame = stackTrace.GetFrame(i);
			stringBuilder.AppendFormat("{0}.{1}", frame.GetMethod().DeclaringType.Name, frame.GetMethod().Name);
			ParameterInfo[] parameters = frame.GetMethod().GetParameters();
			if (parameters == null || parameters.Length == 0)
			{
				stringBuilder.Append(" () ");
			}
			else
			{
				stringBuilder.Append(" (");
				int num = parameters.Length;
				for (int j = 0; j < num; j++)
				{
					ParameterInfo parameterInfo = parameters[j];
					stringBuilder.AppendFormat("{0} {1}", parameterInfo.ParameterType.Name, parameterInfo.Name);
					if (j != num - 1)
					{
						stringBuilder.Append(", ");
					}
				}
				stringBuilder.Append(") ");
			}
			string text2 = frame.GetFileName();
			if (!string.IsNullOrEmpty(text2) && !text2.ToLower().Equals("unknown"))
			{
				text2 = text2.Replace("\\", "/");
				int num2 = text2.ToLower().IndexOf("/assets/");
				if (num2 < 0)
				{
					num2 = text2.ToLower().IndexOf("assets/");
				}
				if (num2 > 0)
				{
					text2 = text2.Substring(num2);
				}
				stringBuilder.AppendFormat("(at {0}:{1})", text2, frame.GetFileLineNumber());
			}
			stringBuilder.AppendLine();
		}
		BuglyAgent._reportException(uncaught, name, text, stringBuilder.ToString());
	}

	// Token: 0x06015650 RID: 87632 RVA: 0x0056D494 File Offset: 0x0056B694
	private static void _reportException(bool uncaught, string name, string reason, string stackTrace)
	{
		if (string.IsNullOrEmpty(name))
		{
			return;
		}
		if (string.IsNullOrEmpty(stackTrace))
		{
			stackTrace = StackTraceUtility.ExtractStackTrace();
		}
		if (string.IsNullOrEmpty(stackTrace))
		{
			stackTrace = "Empty";
		}
		else
		{
			try
			{
				string[] array = stackTrace.Split(new char[]
				{
					'\n'
				});
				if (array != null && array.Length > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					int num = array.Length;
					for (int i = 0; i < num; i++)
					{
						string text = array[i];
						if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text.Trim()))
						{
							text = text.Trim();
							if (!text.StartsWith("System.Collections.Generic.") && !text.StartsWith("ShimEnumerator"))
							{
								if (!text.StartsWith("Bugly"))
								{
									if (!text.Contains("..ctor"))
									{
										int num2 = text.ToLower().IndexOf("(at");
										int num3 = text.ToLower().IndexOf("/assets/");
										if (num2 > 0 && num3 > 0)
										{
											stringBuilder.AppendFormat("{0}(at {1}", text.Substring(0, num2).Replace(":", "."), text.Substring(num3));
										}
										else
										{
											stringBuilder.Append(text.Replace(":", "."));
										}
										stringBuilder.AppendLine();
									}
								}
							}
						}
					}
					stackTrace = stringBuilder.ToString();
				}
			}
			catch
			{
				BuglyAgent.PrintLog(LogSeverity.LogWarning, "{0}", new object[]
				{
					"Error to parse the stack trace"
				});
			}
		}
		BuglyAgent.PrintLog(LogSeverity.LogError, "ReportException: {0} {1}\n*********\n{2}\n*********", new object[]
		{
			name,
			reason,
			stackTrace
		});
		BuglyAgent._uncaughtAutoReportOnce = (uncaught && BuglyAgent._autoQuitApplicationAfterReport);
		BuglyAgent.ReportException((!uncaught) ? BuglyAgent.EXCEPTION_TYPE_CAUGHT : BuglyAgent.EXCEPTION_TYPE_UNCAUGHT, name, reason, stackTrace, uncaught && BuglyAgent._autoQuitApplicationAfterReport);
	}

	// Token: 0x06015651 RID: 87633 RVA: 0x0056D6BC File Offset: 0x0056B8BC
	private static void _HandleException(LogSeverity logLevel, string name, string message, string stackTrace, bool uncaught)
	{
		if (!BuglyAgent.IsInitialized)
		{
			BuglyAgent.DebugLog(null, "It has not been initialized.", new object[0]);
			return;
		}
		if (logLevel == LogSeverity.Log)
		{
			return;
		}
		if (uncaught && logLevel < BuglyAgent._autoReportLogLevel)
		{
			BuglyAgent.DebugLog(null, "Not report exception for level {0}", new object[]
			{
				logLevel.ToString()
			});
			return;
		}
		string text = null;
		string text2 = null;
		if (!string.IsNullOrEmpty(message))
		{
			try
			{
				if (logLevel == LogSeverity.LogException && message.Contains("Exception"))
				{
					Match match = new Regex("^(?<errorType>\\S+):\\s*(?<errorMessage>.*)", RegexOptions.Singleline).Match(message);
					if (match.Success)
					{
						text = match.Groups["errorType"].Value.Trim();
						text2 = match.Groups["errorMessage"].Value.Trim();
					}
				}
				else if (logLevel == LogSeverity.LogError && message.StartsWith("Unhandled Exception:"))
				{
					Match match2 = new Regex("^Unhandled\\s+Exception:\\s*(?<exceptionName>\\S+):\\s*(?<exceptionDetail>.*)", RegexOptions.Singleline).Match(message);
					if (match2.Success)
					{
						string text3 = match2.Groups["exceptionName"].Value.Trim();
						string text4 = match2.Groups["exceptionDetail"].Value.Trim();
						int num = text3.LastIndexOf(".");
						if (num > 0 && num != text3.Length)
						{
							text = text3.Substring(num + 1);
						}
						else
						{
							text = text3;
						}
						int num2 = text4.IndexOf(" at ");
						if (num2 > 0)
						{
							text2 = text4.Substring(0, num2);
							string text5 = text4.Substring(num2 + 3).Replace(" at ", "\n").Replace("in <filename unknown>:0", string.Empty).Replace("[0x00000]", string.Empty);
							stackTrace = string.Format("{0}\n{1}", stackTrace, text5.Trim());
						}
						else
						{
							text2 = text4;
						}
						if (text.Equals("LuaScriptException") && text4.Contains(".lua") && text4.Contains("stack traceback:"))
						{
							num2 = text4.IndexOf("stack traceback:");
							if (num2 > 0)
							{
								text2 = text4.Substring(0, num2);
								string text6 = text4.Substring(num2 + 16).Replace(" [", " \n[");
								stackTrace = string.Format("{0}\n{1}", stackTrace, text6.Trim());
							}
						}
					}
				}
			}
			catch
			{
			}
			if (string.IsNullOrEmpty(text2))
			{
				text2 = message;
			}
		}
		if (string.IsNullOrEmpty(name))
		{
			if (string.IsNullOrEmpty(text))
			{
				text = string.Format("Unity{0}", logLevel.ToString());
			}
		}
		else
		{
			text = name;
		}
		BuglyAgent._reportException(uncaught, text, text2, stackTrace);
	}

	// Token: 0x0400BA93 RID: 47763
	private static bool _isInitialized;

	// Token: 0x0400BA94 RID: 47764
	private static LogSeverity _autoReportLogLevel = LogSeverity.LogError;

	// Token: 0x0400BA95 RID: 47765
	private static int _crashReporterType = 1;

	// Token: 0x0400BA96 RID: 47766
	private static bool _debugMode;

	// Token: 0x0400BA97 RID: 47767
	private static bool _autoQuitApplicationAfterReport;

	// Token: 0x0400BA98 RID: 47768
	private static readonly int EXCEPTION_TYPE_UNCAUGHT = 1;

	// Token: 0x0400BA99 RID: 47769
	private static readonly int EXCEPTION_TYPE_CAUGHT = 2;

	// Token: 0x0400BA9A RID: 47770
	private static readonly string _pluginVersion = "1.5.1";

	// Token: 0x0400BA9B RID: 47771
	private static Func<Dictionary<string, string>> _LogCallbackExtrasHandler;

	// Token: 0x0400BA9C RID: 47772
	private static bool _uncaughtAutoReportOnce;

	// Token: 0x0400BA9D RID: 47773
	[CompilerGenerated]
	private static Application.LogCallback <>f__mg$cache0;

	// Token: 0x0400BA9E RID: 47774
	[CompilerGenerated]
	private static UnhandledExceptionEventHandler <>f__mg$cache1;

	// Token: 0x0400BA9F RID: 47775
	[CompilerGenerated]
	private static UnhandledExceptionEventHandler <>f__mg$cache2;

	// Token: 0x02001088 RID: 4232
	// (Invoke) Token: 0x06015654 RID: 87636
	public delegate void LogCallbackDelegate(string condition, string stackTrace, LogType type);
}
