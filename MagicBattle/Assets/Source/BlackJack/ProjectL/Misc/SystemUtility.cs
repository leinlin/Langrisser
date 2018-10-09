using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000882 RID: 2178
	[CustomLuaClass]
	public class SystemUtility
	{
		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06006BE0 RID: 27616 RVA: 0x001E3808 File Offset: 0x001E1A08
		// (set) Token: 0x06006BE1 RID: 27617 RVA: 0x001E381C File Offset: 0x001E1A1C
		public static float TimeScale
		{
			get
			{
				return (float)(SystemUtility._timeScale ^ SystemUtility._timeScaleMask) / 10000f;
			}
			set
			{
				SystemUtility._timeScale = ((int)(value * 10000f) ^ SystemUtility._timeScaleMask);
			}
		}

		// Token: 0x06006BE2 RID: 27618 RVA: 0x001E3834 File Offset: 0x001E1A34
		public static void SetTimeScale(float scale)
		{
			SystemUtility.TimeScale = scale;
			Time.timeScale = scale;
		}

		// Token: 0x06006BE3 RID: 27619 RVA: 0x001E3844 File Offset: 0x001E1A44
		public static ConfigDataDeviceSetting GetConfigDataDeviceSetting()
		{
			if (SystemUtility.s_needUpdateDeviceSetting)
			{
				SystemUtility.s_needUpdateDeviceSetting = false;
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				string text = SystemInfo.deviceModel.ToLower();
				foreach (KeyValuePair<int, ConfigDataDeviceSetting> keyValuePair in configDataLoader.GetAllConfigDataDeviceSetting())
				{
					ConfigDataDeviceSetting value = keyValuePair.Value;
					if (text.Contains(value.DeviceModel.ToLower()))
					{
						SystemUtility.s_deviceSetting = value;
						break;
					}
				}
			}
			return SystemUtility.s_deviceSetting;
		}

		// Token: 0x06006BE4 RID: 27620 RVA: 0x001E38F4 File Offset: 0x001E1AF4
		public static bool IsiPhoneX()
		{
			string text = SystemInfo.deviceModel.ToLower();
			return text.Contains("iphone10,3") || text.Contains("iphone10,6");
		}

		// Token: 0x06006BE5 RID: 27621 RVA: 0x001E392C File Offset: 0x001E1B2C
		public static bool IsLowSystemMemory()
		{
			return SystemInfo.systemMemorySize <= 1100;
		}

		// Token: 0x06006BE6 RID: 27622 RVA: 0x001E3940 File Offset: 0x001E1B40
		public static bool IsLargeSystemMemory()
		{
			return SystemInfo.systemMemorySize > 4000;
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x001E3950 File Offset: 0x001E1B50
		public static BatteryStatus GetBatteryStatus()
		{
			return SystemInfo.batteryStatus;
		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x001E3958 File Offset: 0x001E1B58
		public static float GetBatteryLevel()
		{
			return SystemInfo.batteryLevel;
		}

		// Token: 0x06006BE9 RID: 27625 RVA: 0x001E3960 File Offset: 0x001E1B60
		public static void LogBatteryStatus()
		{
			global::Debug.Log(string.Format("Battery Level {0:f2}, Status {1}", SystemUtility.GetBatteryLevel(), SystemUtility.GetBatteryStatus()));
		}

		// Token: 0x040052FA RID: 21242
		private static readonly System.Random _random = new System.Random();

		// Token: 0x040052FB RID: 21243
		private static int _timeScale = (int)(Time.timeScale * 10000f);

		// Token: 0x040052FC RID: 21244
		private static readonly int _timeScaleMask = SystemUtility._random.Next(int.MinValue, int.MaxValue);

		// Token: 0x040052FD RID: 21245
		private static ConfigDataDeviceSetting s_deviceSetting = null;

		// Token: 0x040052FE RID: 21246
		private static bool s_needUpdateDeviceSetting = true;
	}
}
