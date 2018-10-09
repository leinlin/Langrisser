using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001629 RID: 5673
[Preserve]
public class Lua_UnityEngine_Application : LuaObject
{
	// Token: 0x06022B8C RID: 142220 RVA: 0x00BFB8F0 File Offset: 0x00BF9AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Application o = new Application();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B8D RID: 142221 RVA: 0x00BFB938 File Offset: 0x00BF9B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Quit_s(IntPtr l)
	{
		int result;
		try
		{
			Application.Quit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B8E RID: 142222 RVA: 0x00BFB978 File Offset: 0x00BF9B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CancelQuit_s(IntPtr l)
	{
		int result;
		try
		{
			Application.CancelQuit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B8F RID: 142223 RVA: 0x00BFB9B8 File Offset: 0x00BF9BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Unload_s(IntPtr l)
	{
		int result;
		try
		{
			Application.Unload();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B90 RID: 142224 RVA: 0x00BFB9F8 File Offset: 0x00BF9BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStreamProgressForLevel_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int levelIndex;
				LuaObject.checkType(l, 1, out levelIndex);
				float streamProgressForLevel = Application.GetStreamProgressForLevel(levelIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, streamProgressForLevel);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string levelName;
				LuaObject.checkType(l, 1, out levelName);
				float streamProgressForLevel2 = Application.GetStreamProgressForLevel(levelName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, streamProgressForLevel2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetStreamProgressForLevel to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B91 RID: 142225 RVA: 0x00BFBAC4 File Offset: 0x00BF9CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanStreamedLevelBeLoaded_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int levelIndex;
				LuaObject.checkType(l, 1, out levelIndex);
				bool b = Application.CanStreamedLevelBeLoaded(levelIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string levelName;
				LuaObject.checkType(l, 1, out levelName);
				bool b2 = Application.CanStreamedLevelBeLoaded(levelName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CanStreamedLevelBeLoaded to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B92 RID: 142226 RVA: 0x00BFBB90 File Offset: 0x00BF9D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBuildTags_s(IntPtr l)
	{
		int result;
		try
		{
			string[] buildTags = Application.GetBuildTags();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buildTags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B93 RID: 142227 RVA: 0x00BFBBD8 File Offset: 0x00BF9DD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBuildTags_s(IntPtr l)
	{
		int result;
		try
		{
			string[] buildTags;
			LuaObject.checkArray<string>(l, 1, out buildTags);
			Application.SetBuildTags(buildTags);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B94 RID: 142228 RVA: 0x00BFBC24 File Offset: 0x00BF9E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasProLicense_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = Application.HasProLicense();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B95 RID: 142229 RVA: 0x00BFBC6C File Offset: 0x00BF9E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RequestAdvertisingIdentifierAsync_s(IntPtr l)
	{
		int result;
		try
		{
			Application.AdvertisingIdentifierCallback delegateMethod;
			LuaObject.checkDelegate<Application.AdvertisingIdentifierCallback>(l, 1, out delegateMethod);
			bool b = Application.RequestAdvertisingIdentifierAsync(delegateMethod);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B96 RID: 142230 RVA: 0x00BFBCC0 File Offset: 0x00BF9EC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OpenURL_s(IntPtr l)
	{
		int result;
		try
		{
			string url;
			LuaObject.checkType(l, 1, out url);
			Application.OpenURL(url);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B97 RID: 142231 RVA: 0x00BFBD0C File Offset: 0x00BF9F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStackTraceLogType_s(IntPtr l)
	{
		int result;
		try
		{
			LogType logType;
			LuaObject.checkEnum<LogType>(l, 1, out logType);
			StackTraceLogType stackTraceLogType = Application.GetStackTraceLogType(logType);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)stackTraceLogType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B98 RID: 142232 RVA: 0x00BFBD60 File Offset: 0x00BF9F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStackTraceLogType_s(IntPtr l)
	{
		int result;
		try
		{
			LogType logType;
			LuaObject.checkEnum<LogType>(l, 1, out logType);
			StackTraceLogType stackTraceType;
			LuaObject.checkEnum<StackTraceLogType>(l, 2, out stackTraceType);
			Application.SetStackTraceLogType(logType, stackTraceType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B99 RID: 142233 RVA: 0x00BFBDB8 File Offset: 0x00BF9FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RequestUserAuthorization_s(IntPtr l)
	{
		int result;
		try
		{
			UserAuthorization mode;
			LuaObject.checkEnum<UserAuthorization>(l, 1, out mode);
			AsyncOperation o = Application.RequestUserAuthorization(mode);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B9A RID: 142234 RVA: 0x00BFBE0C File Offset: 0x00BFA00C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasUserAuthorization_s(IntPtr l)
	{
		int result;
		try
		{
			UserAuthorization mode;
			LuaObject.checkEnum<UserAuthorization>(l, 1, out mode);
			bool b = Application.HasUserAuthorization(mode);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B9B RID: 142235 RVA: 0x00BFBE60 File Offset: 0x00BFA060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_streamedBytes(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.streamedBytes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B9C RID: 142236 RVA: 0x00BFBEA8 File Offset: 0x00BFA0A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isPlaying(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.isPlaying);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B9D RID: 142237 RVA: 0x00BFBEF0 File Offset: 0x00BFA0F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isFocused(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.isFocused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B9E RID: 142238 RVA: 0x00BFBF38 File Offset: 0x00BFA138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isEditor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.isEditor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B9F RID: 142239 RVA: 0x00BFBF80 File Offset: 0x00BFA180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_platform(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Application.platform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BA0 RID: 142240 RVA: 0x00BFBFC8 File Offset: 0x00BFA1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_buildGUID(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.buildGUID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BA1 RID: 142241 RVA: 0x00BFC010 File Offset: 0x00BFA210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isMobilePlatform(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.isMobilePlatform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BA2 RID: 142242 RVA: 0x00BFC058 File Offset: 0x00BFA258
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isConsolePlatform(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.isConsolePlatform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BA3 RID: 142243 RVA: 0x00BFC0A0 File Offset: 0x00BFA2A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_runInBackground(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.runInBackground);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BA4 RID: 142244 RVA: 0x00BFC0E8 File Offset: 0x00BFA2E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_runInBackground(IntPtr l)
	{
		int result;
		try
		{
			bool runInBackground;
			LuaObject.checkType(l, 2, out runInBackground);
			Application.runInBackground = runInBackground;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BA5 RID: 142245 RVA: 0x00BFC134 File Offset: 0x00BFA334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dataPath(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.dataPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BA6 RID: 142246 RVA: 0x00BFC17C File Offset: 0x00BFA37C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_streamingAssetsPath(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.streamingAssetsPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BA7 RID: 142247 RVA: 0x00BFC1C4 File Offset: 0x00BFA3C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_persistentDataPath(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.persistentDataPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BA8 RID: 142248 RVA: 0x00BFC20C File Offset: 0x00BFA40C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_temporaryCachePath(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.temporaryCachePath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BA9 RID: 142249 RVA: 0x00BFC254 File Offset: 0x00BFA454
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_absoluteURL(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.absoluteURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BAA RID: 142250 RVA: 0x00BFC29C File Offset: 0x00BFA49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_unityVersion(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.unityVersion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BAB RID: 142251 RVA: 0x00BFC2E4 File Offset: 0x00BFA4E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_version(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.version);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BAC RID: 142252 RVA: 0x00BFC32C File Offset: 0x00BFA52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_installerName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.installerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BAD RID: 142253 RVA: 0x00BFC374 File Offset: 0x00BFA574
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_identifier(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.identifier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BAE RID: 142254 RVA: 0x00BFC3BC File Offset: 0x00BFA5BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_installMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Application.installMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BAF RID: 142255 RVA: 0x00BFC404 File Offset: 0x00BFA604
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_sandboxType(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Application.sandboxType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BB0 RID: 142256 RVA: 0x00BFC44C File Offset: 0x00BFA64C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_productName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.productName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BB1 RID: 142257 RVA: 0x00BFC494 File Offset: 0x00BFA694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_companyName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.companyName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BB2 RID: 142258 RVA: 0x00BFC4DC File Offset: 0x00BFA6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cloudProjectId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.cloudProjectId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BB3 RID: 142259 RVA: 0x00BFC524 File Offset: 0x00BFA724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_targetFrameRate(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.targetFrameRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BB4 RID: 142260 RVA: 0x00BFC56C File Offset: 0x00BFA76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetFrameRate(IntPtr l)
	{
		int result;
		try
		{
			int targetFrameRate;
			LuaObject.checkType(l, 2, out targetFrameRate);
			Application.targetFrameRate = targetFrameRate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BB5 RID: 142261 RVA: 0x00BFC5B8 File Offset: 0x00BFA7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_systemLanguage(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Application.systemLanguage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BB6 RID: 142262 RVA: 0x00BFC600 File Offset: 0x00BFA800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_backgroundLoadingPriority(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Application.backgroundLoadingPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BB7 RID: 142263 RVA: 0x00BFC648 File Offset: 0x00BFA848
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_backgroundLoadingPriority(IntPtr l)
	{
		int result;
		try
		{
			ThreadPriority backgroundLoadingPriority;
			LuaObject.checkEnum<ThreadPriority>(l, 2, out backgroundLoadingPriority);
			Application.backgroundLoadingPriority = backgroundLoadingPriority;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BB8 RID: 142264 RVA: 0x00BFC694 File Offset: 0x00BFA894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_internetReachability(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Application.internetReachability);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BB9 RID: 142265 RVA: 0x00BFC6DC File Offset: 0x00BFA8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_genuine(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.genuine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BBA RID: 142266 RVA: 0x00BFC724 File Offset: 0x00BFA924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_genuineCheckAvailable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Application.genuineCheckAvailable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BBB RID: 142267 RVA: 0x00BFC76C File Offset: 0x00BFA96C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Application");
		if (Lua_UnityEngine_Application.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Application.Quit_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cache0);
		if (Lua_UnityEngine_Application.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Application.CancelQuit_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cache1);
		if (Lua_UnityEngine_Application.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Application.Unload_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cache2);
		if (Lua_UnityEngine_Application.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Application.GetStreamProgressForLevel_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cache3);
		if (Lua_UnityEngine_Application.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Application.CanStreamedLevelBeLoaded_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cache4);
		if (Lua_UnityEngine_Application.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Application.GetBuildTags_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cache5);
		if (Lua_UnityEngine_Application.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Application.SetBuildTags_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cache6);
		if (Lua_UnityEngine_Application.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Application.HasProLicense_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cache7);
		if (Lua_UnityEngine_Application.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Application.RequestAdvertisingIdentifierAsync_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cache8);
		if (Lua_UnityEngine_Application.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Application.OpenURL_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cache9);
		if (Lua_UnityEngine_Application.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Application.GetStackTraceLogType_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cacheA);
		if (Lua_UnityEngine_Application.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Application.SetStackTraceLogType_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cacheB);
		if (Lua_UnityEngine_Application.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Application.RequestUserAuthorization_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cacheC);
		if (Lua_UnityEngine_Application.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Application.HasUserAuthorization_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Application.<>f__mg$cacheD);
		string name = "streamedBytes";
		if (Lua_UnityEngine_Application.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Application.get_streamedBytes);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Application.<>f__mg$cacheE, null, false);
		string name2 = "isPlaying";
		if (Lua_UnityEngine_Application.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Application.get_isPlaying);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Application.<>f__mg$cacheF, null, false);
		string name3 = "isFocused";
		if (Lua_UnityEngine_Application.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Application.get_isFocused);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Application.<>f__mg$cache10, null, false);
		string name4 = "isEditor";
		if (Lua_UnityEngine_Application.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Application.get_isEditor);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Application.<>f__mg$cache11, null, false);
		string name5 = "platform";
		if (Lua_UnityEngine_Application.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Application.get_platform);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Application.<>f__mg$cache12, null, false);
		string name6 = "buildGUID";
		if (Lua_UnityEngine_Application.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Application.get_buildGUID);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Application.<>f__mg$cache13, null, false);
		string name7 = "isMobilePlatform";
		if (Lua_UnityEngine_Application.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Application.get_isMobilePlatform);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Application.<>f__mg$cache14, null, false);
		string name8 = "isConsolePlatform";
		if (Lua_UnityEngine_Application.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Application.get_isConsolePlatform);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Application.<>f__mg$cache15, null, false);
		string name9 = "runInBackground";
		if (Lua_UnityEngine_Application.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Application.get_runInBackground);
		}
		LuaCSFunction get = Lua_UnityEngine_Application.<>f__mg$cache16;
		if (Lua_UnityEngine_Application.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Application.set_runInBackground);
		}
		LuaObject.addMember(l, name9, get, Lua_UnityEngine_Application.<>f__mg$cache17, false);
		string name10 = "dataPath";
		if (Lua_UnityEngine_Application.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Application.get_dataPath);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Application.<>f__mg$cache18, null, false);
		string name11 = "streamingAssetsPath";
		if (Lua_UnityEngine_Application.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Application.get_streamingAssetsPath);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Application.<>f__mg$cache19, null, false);
		string name12 = "persistentDataPath";
		if (Lua_UnityEngine_Application.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Application.get_persistentDataPath);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_Application.<>f__mg$cache1A, null, false);
		string name13 = "temporaryCachePath";
		if (Lua_UnityEngine_Application.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Application.get_temporaryCachePath);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Application.<>f__mg$cache1B, null, false);
		string name14 = "absoluteURL";
		if (Lua_UnityEngine_Application.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Application.get_absoluteURL);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_Application.<>f__mg$cache1C, null, false);
		string name15 = "unityVersion";
		if (Lua_UnityEngine_Application.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Application.get_unityVersion);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_Application.<>f__mg$cache1D, null, false);
		string name16 = "version";
		if (Lua_UnityEngine_Application.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Application.get_version);
		}
		LuaObject.addMember(l, name16, Lua_UnityEngine_Application.<>f__mg$cache1E, null, false);
		string name17 = "installerName";
		if (Lua_UnityEngine_Application.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Application.get_installerName);
		}
		LuaObject.addMember(l, name17, Lua_UnityEngine_Application.<>f__mg$cache1F, null, false);
		string name18 = "identifier";
		if (Lua_UnityEngine_Application.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Application.get_identifier);
		}
		LuaObject.addMember(l, name18, Lua_UnityEngine_Application.<>f__mg$cache20, null, false);
		string name19 = "installMode";
		if (Lua_UnityEngine_Application.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Application.get_installMode);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_Application.<>f__mg$cache21, null, false);
		string name20 = "sandboxType";
		if (Lua_UnityEngine_Application.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Application.get_sandboxType);
		}
		LuaObject.addMember(l, name20, Lua_UnityEngine_Application.<>f__mg$cache22, null, false);
		string name21 = "productName";
		if (Lua_UnityEngine_Application.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Application.get_productName);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_Application.<>f__mg$cache23, null, false);
		string name22 = "companyName";
		if (Lua_UnityEngine_Application.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Application.get_companyName);
		}
		LuaObject.addMember(l, name22, Lua_UnityEngine_Application.<>f__mg$cache24, null, false);
		string name23 = "cloudProjectId";
		if (Lua_UnityEngine_Application.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Application.get_cloudProjectId);
		}
		LuaObject.addMember(l, name23, Lua_UnityEngine_Application.<>f__mg$cache25, null, false);
		string name24 = "targetFrameRate";
		if (Lua_UnityEngine_Application.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Application.get_targetFrameRate);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Application.<>f__mg$cache26;
		if (Lua_UnityEngine_Application.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Application.set_targetFrameRate);
		}
		LuaObject.addMember(l, name24, get2, Lua_UnityEngine_Application.<>f__mg$cache27, false);
		string name25 = "systemLanguage";
		if (Lua_UnityEngine_Application.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Application.get_systemLanguage);
		}
		LuaObject.addMember(l, name25, Lua_UnityEngine_Application.<>f__mg$cache28, null, false);
		string name26 = "backgroundLoadingPriority";
		if (Lua_UnityEngine_Application.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Application.get_backgroundLoadingPriority);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Application.<>f__mg$cache29;
		if (Lua_UnityEngine_Application.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Application.set_backgroundLoadingPriority);
		}
		LuaObject.addMember(l, name26, get3, Lua_UnityEngine_Application.<>f__mg$cache2A, false);
		string name27 = "internetReachability";
		if (Lua_UnityEngine_Application.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Application.get_internetReachability);
		}
		LuaObject.addMember(l, name27, Lua_UnityEngine_Application.<>f__mg$cache2B, null, false);
		string name28 = "genuine";
		if (Lua_UnityEngine_Application.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Application.get_genuine);
		}
		LuaObject.addMember(l, name28, Lua_UnityEngine_Application.<>f__mg$cache2C, null, false);
		string name29 = "genuineCheckAvailable";
		if (Lua_UnityEngine_Application.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Application.get_genuineCheckAvailable);
		}
		LuaObject.addMember(l, name29, Lua_UnityEngine_Application.<>f__mg$cache2D, null, false);
		if (Lua_UnityEngine_Application.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Application.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Application.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Application.<>f__mg$cache2E, typeof(Application));
	}

	// Token: 0x04018B98 RID: 101272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018B99 RID: 101273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018B9A RID: 101274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018B9B RID: 101275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018B9C RID: 101276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018B9D RID: 101277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018B9E RID: 101278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018B9F RID: 101279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018BA0 RID: 101280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018BA1 RID: 101281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018BA2 RID: 101282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018BA3 RID: 101283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018BA4 RID: 101284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018BA5 RID: 101285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018BA6 RID: 101286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018BA7 RID: 101287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018BA8 RID: 101288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018BA9 RID: 101289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018BAA RID: 101290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018BAB RID: 101291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018BAC RID: 101292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018BAD RID: 101293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018BAE RID: 101294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018BAF RID: 101295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018BB0 RID: 101296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018BB1 RID: 101297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018BB2 RID: 101298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018BB3 RID: 101299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018BB4 RID: 101300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018BB5 RID: 101301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018BB6 RID: 101302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018BB7 RID: 101303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018BB8 RID: 101304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018BB9 RID: 101305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018BBA RID: 101306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018BBB RID: 101307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04018BBC RID: 101308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04018BBD RID: 101309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04018BBE RID: 101310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04018BBF RID: 101311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04018BC0 RID: 101312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04018BC1 RID: 101313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04018BC2 RID: 101314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04018BC3 RID: 101315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04018BC4 RID: 101316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04018BC5 RID: 101317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04018BC6 RID: 101318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
