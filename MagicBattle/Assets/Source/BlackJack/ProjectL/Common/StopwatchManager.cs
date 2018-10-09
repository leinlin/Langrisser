using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000585 RID: 1413
	[CustomLuaClass]
	public class StopwatchManager
	{
		// Token: 0x060051B4 RID: 20916 RVA: 0x00184098 File Offset: 0x00182298
		public static void Start(int watchID)
		{
			if (!StopwatchManager.isEnable)
			{
				return;
			}
			Stopwatch stopwatch;
			if (!StopwatchManager.mapStopwatch.TryGetValue(watchID, out stopwatch))
			{
				stopwatch = new Stopwatch();
				StopwatchManager.mapStopwatch.Add(watchID, stopwatch);
			}
			stopwatch.Reset();
			stopwatch.Start();
		}

		// Token: 0x060051B5 RID: 20917 RVA: 0x001840E0 File Offset: 0x001822E0
		public static void Stop(int watchID, string msg)
		{
			if (!StopwatchManager.isEnable)
			{
				return;
			}
			Stopwatch stopwatch;
			if (!StopwatchManager.mapStopwatch.TryGetValue(watchID, out stopwatch))
			{
				return;
			}
			stopwatch.Stop();
			StopwatchManager._results.Add(new StopwatchManager.Result(watchID, msg, stopwatch.Elapsed.TotalSeconds));
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x00184130 File Offset: 0x00182330
		private static int SortByTotalTime(StopwatchManager.StatisticResult left, StopwatchManager.StatisticResult right)
		{
			return (left._totalTime <= right._totalTime) ? 1 : -1;
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x0018414C File Offset: 0x0018234C
		public static void LogAllMessage()
		{
			if (!StopwatchManager.isEnable)
			{
				return;
			}
			if (StopwatchManager._results.Count == 0)
			{
				return;
			}
			Dictionary<string, List<double>> dictionary = new Dictionary<string, List<double>>();
			foreach (StopwatchManager.Result result in StopwatchManager._results)
			{
				string key = result.key;
				List<double> list;
				if (!dictionary.TryGetValue(key, out list))
				{
					list = new List<double>(10);
					dictionary.Add(key, list);
				}
				list.Add(result._time);
			}
			List<StopwatchManager.StatisticResult> list2 = new List<StopwatchManager.StatisticResult>(50);
			foreach (KeyValuePair<string, List<double>> keyValuePair in dictionary)
			{
				if (keyValuePair.Value.Count != 0)
				{
					double num = 0.0;
					foreach (double num2 in keyValuePair.Value)
					{
						double num3 = num2;
						num += num3;
					}
					list2.Add(new StopwatchManager.StatisticResult(keyValuePair.Key, num / (double)keyValuePair.Value.Count, keyValuePair.Value.Count, num));
				}
			}
			List<StopwatchManager.StatisticResult> list3 = list2;
			if (StopwatchManager.<>f__mg$cache0 == null)
			{
				StopwatchManager.<>f__mg$cache0 = new Comparison<StopwatchManager.StatisticResult>(StopwatchManager.SortByTotalTime);
			}
			list3.Sort(StopwatchManager.<>f__mg$cache0);
			string text = string.Format("[Device:] {0},{1},{2};\n[Processor:] {3},{4}MHz,{5}Cores;\n[Memory:]{6}MB;\n[MaxTextureSize:] {7};\n[OperatingSystem:] {8};\n[Graphic:] {9},{10},{11}MB", new object[]
			{
				SystemInfo.deviceName,
				SystemInfo.deviceModel,
				SystemInfo.deviceType,
				SystemInfo.processorType,
				SystemInfo.processorFrequency,
				SystemInfo.processorCount,
				SystemInfo.systemMemorySize,
				SystemInfo.maxTextureSize,
				SystemInfo.operatingSystem,
				SystemInfo.graphicsDeviceName,
				SystemInfo.graphicsDeviceType,
				SystemInfo.graphicsMemorySize
			});
			global::Debug.Log(text);
			if (StopwatchManager.<>f__mg$cache1 == null)
			{
				StopwatchManager.<>f__mg$cache1 = new Action<string>(global::Debug.Log);
			}
			StopwatchManager.WriteLog(StopwatchManager.<>f__mg$cache1, StopwatchManager._results, list2);
			string text2 = string.Format("{0}{1}{2}_{3}{4:D2}{5:D2}_{6:D2}{7:D2}{8:D2}.log", new object[]
			{
				Application.persistentDataPath,
				Path.AltDirectorySeparatorChar,
				"RunningTime",
				DateTime.Now.Year,
				DateTime.Now.Month,
				DateTime.Now.Day,
				DateTime.Now.Hour,
				DateTime.Now.Minute,
				DateTime.Now.Second
			});
			StreamWriter streamWriter = new StreamWriter(text2);
			streamWriter.WriteLine(text2);
			streamWriter.WriteLine(text);
			streamWriter.WriteLine();
			StopwatchManager.WriteLog(new Action<string>(streamWriter.WriteLine), StopwatchManager._results, list2);
			streamWriter.WriteLine();
			streamWriter.WriteLine("File closed.");
			streamWriter.Close();
			StopwatchManager._results.Clear();
		}

		// Token: 0x060051B8 RID: 20920 RVA: 0x001844E4 File Offset: 0x001826E4
		public static void Enable(bool bEnable = true)
		{
			StopwatchManager.isEnable = bEnable;
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x001844EC File Offset: 0x001826EC
		private static void WriteLog(Action<string> logFuc, List<StopwatchManager.Result> results, List<StopwatchManager.StatisticResult> statisticResults)
		{
			logFuc("--------------------- LOG ------------------------");
			foreach (StopwatchManager.Result result in results)
			{
				logFuc(result.log);
			}
			logFuc("--------------------- STATISTIC ------------------------");
			foreach (StopwatchManager.StatisticResult statisticResult in statisticResults)
			{
				logFuc(statisticResult.log);
			}
		}

		// Token: 0x04003A95 RID: 14997
		private static Dictionary<int, Stopwatch> mapStopwatch = new Dictionary<int, Stopwatch>(128);

		// Token: 0x04003A96 RID: 14998
		private static bool isEnable = false;

		// Token: 0x04003A97 RID: 14999
		private static List<StopwatchManager.Result> _results = new List<StopwatchManager.Result>(512);

		// Token: 0x04003A98 RID: 15000
		[CompilerGenerated]
		private static Comparison<StopwatchManager.StatisticResult> <>f__mg$cache0;

		// Token: 0x04003A99 RID: 15001
		[CompilerGenerated]
		private static Action<string> <>f__mg$cache1;

		// Token: 0x02000586 RID: 1414
		public struct StatisticResult
		{
			// Token: 0x060051BB RID: 20923 RVA: 0x001845D4 File Offset: 0x001827D4
			public StatisticResult(string msg, double averageTime, int count, double totalTime)
			{
				this._msg = msg;
				this._averageTime = averageTime;
				this._count = count;
				this._totalTime = totalTime;
			}

			// Token: 0x1700142C RID: 5164
			// (get) Token: 0x060051BC RID: 20924 RVA: 0x001845F4 File Offset: 0x001827F4
			public string log
			{
				get
				{
					return string.Format("{0} total: {1}, count: {2}, average: {3}", new object[]
					{
						this._msg,
						this._totalTime,
						this._count,
						this._averageTime
					});
				}
			}

			// Token: 0x04003A9A RID: 15002
			public string _msg;

			// Token: 0x04003A9B RID: 15003
			public double _averageTime;

			// Token: 0x04003A9C RID: 15004
			public int _count;

			// Token: 0x04003A9D RID: 15005
			public double _totalTime;
		}

		// Token: 0x02000587 RID: 1415
		public struct Result
		{
			// Token: 0x060051BD RID: 20925 RVA: 0x00184644 File Offset: 0x00182844
			public Result(int watchID, string msg, double time)
			{
				this._watchID = watchID;
				this._msg = msg;
				this._time = time;
			}

			// Token: 0x1700142D RID: 5165
			// (get) Token: 0x060051BE RID: 20926 RVA: 0x0018465C File Offset: 0x0018285C
			public string key
			{
				get
				{
					return string.Format("[RuningTime - {0:D2}] {1} ", this._watchID, this._msg);
				}
			}

			// Token: 0x1700142E RID: 5166
			// (get) Token: 0x060051BF RID: 20927 RVA: 0x0018467C File Offset: 0x0018287C
			public string log
			{
				get
				{
					return string.Format("[RuningTime - {0:D2}] {1} {2} ", this._watchID, this._msg, this._time);
				}
			}

			// Token: 0x04003A9E RID: 15006
			public int _watchID;

			// Token: 0x04003A9F RID: 15007
			public string _msg;

			// Token: 0x04003AA0 RID: 15008
			public double _time;
		}
	}
}
