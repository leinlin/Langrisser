using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200108A RID: 4234
public class BuglyInit : MonoBehaviour
{
	// Token: 0x0601565A RID: 87642 RVA: 0x0056D9E8 File Offset: 0x0056BBE8
	private void Awake()
	{
		BuglyAgent.ConfigDebugMode(false);
		BuglyAgent.ConfigDefault(null, null, null, 0L);
		BuglyAgent.ConfigAutoReportLogLevel(LogSeverity.LogError);
		BuglyAgent.ConfigAutoQuitApplication(false);
		BuglyAgent.RegisterLogCallback(null);
		BuglyAgent.InitWithAppId("YOUR APP ID GOES HERE");
		BuglyAgent.EnableExceptionHandler();
		if (BuglyInit.<>f__mg$cache0 == null)
		{
			BuglyInit.<>f__mg$cache0 = new Func<Dictionary<string, string>>(BuglyInit.MyLogCallbackExtrasHandler);
		}
		BuglyAgent.SetLogCallbackExtrasHandler(BuglyInit.<>f__mg$cache0);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x0601565B RID: 87643 RVA: 0x0056DA50 File Offset: 0x0056BC50
	private static Dictionary<string, string> MyLogCallbackExtrasHandler()
	{
		BuglyAgent.PrintLog(LogSeverity.Log, "extra handler", new object[0]);
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("ScreenSolution", string.Format("{0}x{1}", Screen.width, Screen.height));
		dictionary.Add("deviceModel", SystemInfo.deviceModel);
		dictionary.Add("deviceName", SystemInfo.deviceName);
		dictionary.Add("deviceType", SystemInfo.deviceType.ToString());
		dictionary.Add("deviceUId", SystemInfo.deviceUniqueIdentifier);
		dictionary.Add("gDId", string.Format("{0}", SystemInfo.graphicsDeviceID));
		dictionary.Add("gDName", SystemInfo.graphicsDeviceName);
		dictionary.Add("gDVdr", SystemInfo.graphicsDeviceVendor);
		dictionary.Add("gDVer", SystemInfo.graphicsDeviceVersion);
		dictionary.Add("gDVdrID", string.Format("{0}", SystemInfo.graphicsDeviceVendorID));
		dictionary.Add("graphicsMemorySize", string.Format("{0}", SystemInfo.graphicsMemorySize));
		dictionary.Add("systemMemorySize", string.Format("{0}", SystemInfo.systemMemorySize));
		dictionary.Add("UnityVersion", Application.unityVersion);
		BuglyAgent.PrintLog(LogSeverity.LogInfo, "Package extra data", new object[0]);
		return dictionary;
	}

	// Token: 0x0400BAA0 RID: 47776
	private const string BuglyAppID = "YOUR APP ID GOES HERE";

	// Token: 0x0400BAA1 RID: 47777
	[CompilerGenerated]
	private static Func<Dictionary<string, string>> <>f__mg$cache0;
}
