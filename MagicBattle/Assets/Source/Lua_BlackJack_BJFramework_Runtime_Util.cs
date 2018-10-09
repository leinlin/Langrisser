using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200112F RID: 4399
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Util : LuaObject
{
	// Token: 0x06015ED1 RID: 89809 RVA: 0x005AFDC4 File Offset: 0x005ADFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Util o = new Util();
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

	// Token: 0x06015ED2 RID: 89810 RVA: 0x005AFE0C File Offset: 0x005AE00C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DownloadHttpFile_s(IntPtr l)
	{
		int result;
		try
		{
			string url;
			LuaObject.checkType(l, 1, out url);
			Action<bool, WWW> onReceive;
			LuaObject.checkDelegate<Action<bool, WWW>>(l, 2, out onReceive);
			Action<WWW> onUpdate;
			LuaObject.checkDelegate<Action<WWW>>(l, 3, out onUpdate);
			IEnumerator o = Util.DownloadHttpFile(url, onReceive, onUpdate);
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

	// Token: 0x06015ED3 RID: 89811 RVA: 0x005AFE7C File Offset: 0x005AE07C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCurrentTargetPlatform_s(IntPtr l)
	{
		int result;
		try
		{
			string currentTargetPlatform = Util.GetCurrentTargetPlatform();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentTargetPlatform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ED4 RID: 89812 RVA: 0x005AFEC4 File Offset: 0x005AE0C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFilePersistentPath_s(IntPtr l)
	{
		int result;
		try
		{
			string assetPath;
			LuaObject.checkType(l, 1, out assetPath);
			string filePersistentPath = Util.GetFilePersistentPath(assetPath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, filePersistentPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ED5 RID: 89813 RVA: 0x005AFF18 File Offset: 0x005AE118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFileStreamingAssetsPath_s(IntPtr l)
	{
		int result;
		try
		{
			string assetPath;
			LuaObject.checkType(l, 1, out assetPath);
			string fileStreamingAssetsPath = Util.GetFileStreamingAssetsPath(assetPath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fileStreamingAssetsPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ED6 RID: 89814 RVA: 0x005AFF6C File Offset: 0x005AE16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFileStreamingAssetsPath4WWW_s(IntPtr l)
	{
		int result;
		try
		{
			string assetPath;
			LuaObject.checkType(l, 1, out assetPath);
			string fileStreamingAssetsPath4WWW = Util.GetFileStreamingAssetsPath4WWW(assetPath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fileStreamingAssetsPath4WWW);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ED7 RID: 89815 RVA: 0x005AFFC0 File Offset: 0x005AE1C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReformPathString_s(IntPtr l)
	{
		int result;
		try
		{
			string path;
			LuaObject.checkType(l, 1, out path);
			string s = Util.ReformPathString(path);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ED8 RID: 89816 RVA: 0x005B0014 File Offset: 0x005AE214
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAssetDNNameFromPath_s(IntPtr l)
	{
		int result;
		try
		{
			string path;
			LuaObject.checkType(l, 1, out path);
			string assetDNNameFromPath = Util.GetAssetDNNameFromPath(path);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assetDNNameFromPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015ED9 RID: 89817 RVA: 0x005B0068 File Offset: 0x005AE268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBundleNameByAssetPath_s(IntPtr l)
	{
		int result;
		try
		{
			string path;
			LuaObject.checkType(l, 1, out path);
			string bundleNameByAssetPath = Util.GetBundleNameByAssetPath(path);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bundleNameByAssetPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EDA RID: 89818 RVA: 0x005B00BC File Offset: 0x005AE2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFileSize_s(IntPtr l)
	{
		int result;
		try
		{
			string path;
			LuaObject.checkType(l, 1, out path);
			long fileSize = Util.GetFileSize(path);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fileSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EDB RID: 89819 RVA: 0x005B0110 File Offset: 0x005AE310
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveCloneFromGameObjectName_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			Util.RemoveCloneFromGameObjectName(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EDC RID: 89820 RVA: 0x005B015C File Offset: 0x005AE35C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTransformParent_s(IntPtr l)
	{
		int result;
		try
		{
			Transform child;
			LuaObject.checkType<Transform>(l, 1, out child);
			Transform parent;
			LuaObject.checkType<Transform>(l, 2, out parent);
			Util.SetTransformParent(child, parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EDD RID: 89821 RVA: 0x005B01B4 File Offset: 0x005AE3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllFilesSize_s(IntPtr l)
	{
		int result;
		try
		{
			List<string> fileList;
			LuaObject.checkType<List<string>>(l, 1, out fileList);
			List<long> allFilesSize = Util.GetAllFilesSize(fileList);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allFilesSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EDE RID: 89822 RVA: 0x005B0208 File Offset: 0x005AE408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMd5FromFileList_s(IntPtr l)
	{
		int result;
		try
		{
			List<string> fileList;
			LuaObject.checkType<List<string>>(l, 1, out fileList);
			List<string> o = Util.CreateMd5FromFileList(fileList);
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

	// Token: 0x06015EDF RID: 89823 RVA: 0x005B025C File Offset: 0x005AE45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMd5FromFile_s(IntPtr l)
	{
		int result;
		try
		{
			string filePath;
			LuaObject.checkType(l, 1, out filePath);
			string s = Util.CreateMd5FromFile(filePath);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EE0 RID: 89824 RVA: 0x005B02B0 File Offset: 0x005AE4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateMd5FromBytes_s(IntPtr l)
	{
		int result;
		try
		{
			byte[] bytes;
			LuaObject.checkArray<byte>(l, 1, out bytes);
			string s = Util.CreateMd5FromBytes(bytes);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EE1 RID: 89825 RVA: 0x005B0304 File Offset: 0x005AE504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TimeSpanToString_s(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			string s = Util.TimeSpanToString(timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EE2 RID: 89826 RVA: 0x005B0358 File Offset: 0x005AE558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTypeDefaultValueString_s(IntPtr l)
	{
		int result;
		try
		{
			Type type;
			LuaObject.checkType(l, 1, out type);
			string typeDefaultValueString = Util.GetTypeDefaultValueString(type);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, typeDefaultValueString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EE3 RID: 89827 RVA: 0x005B03AC File Offset: 0x005AE5AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindType_s(IntPtr l)
	{
		int result;
		try
		{
			string typeName;
			LuaObject.checkType(l, 1, out typeName);
			Type o = Util.FindType(typeName);
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

	// Token: 0x06015EE4 RID: 89828 RVA: 0x005B0400 File Offset: 0x005AE600
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTypeDefinitionString_s(IntPtr l)
	{
		int result;
		try
		{
			Type type;
			LuaObject.checkType(l, 1, out type);
			string typeDefinitionString = Util.GetTypeDefinitionString(type);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, typeDefinitionString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EE5 RID: 89829 RVA: 0x005B0454 File Offset: 0x005AE654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGenericTypeFriendlyName_s(IntPtr l)
	{
		int result;
		try
		{
			Type type;
			LuaObject.checkType(l, 1, out type);
			string genericTypeFriendlyName = Util.GetGenericTypeFriendlyName(type);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, genericTypeFriendlyName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EE6 RID: 89830 RVA: 0x005B04A8 File Offset: 0x005AE6A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GetCurrentTargetPlatformInEditor(IntPtr l)
	{
		int result;
		try
		{
			Func<string> func;
			int num = LuaObject.checkDelegate<Func<string>>(l, 2, out func);
			if (num == 0)
			{
				Util.GetCurrentTargetPlatformInEditor = func;
			}
			else if (num == 1)
			{
				Util.GetCurrentTargetPlatformInEditor = (Func<string>)Delegate.Combine(Util.GetCurrentTargetPlatformInEditor, func);
			}
			else if (num == 2)
			{
				Util.GetCurrentTargetPlatformInEditor = (Func<string>)Delegate.Remove(Util.GetCurrentTargetPlatformInEditor, func);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EE7 RID: 89831 RVA: 0x005B053C File Offset: 0x005AE73C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Util");
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.DownloadHttpFile_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetCurrentTargetPlatform_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetFilePersistentPath_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetFileStreamingAssetsPath_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetFileStreamingAssetsPath4WWW_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.ReformPathString_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetAssetDNNameFromPath_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetBundleNameByAssetPath_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetFileSize_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.RemoveCloneFromGameObjectName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.SetTransformParent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetAllFilesSize_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.CreateMd5FromFileList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.CreateMd5FromFile_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.CreateMd5FromBytes_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.TimeSpanToString_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetTypeDefaultValueString_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.FindType_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetTypeDefinitionString_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.GetGenericTypeFriendlyName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache13);
		string name = "GetCurrentTargetPlatformInEditor";
		LuaCSFunction get = null;
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.set_GetCurrentTargetPlatformInEditor);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache14, false);
		if (Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Util.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_Util.<>f__mg$cache15, typeof(Util));
	}

	// Token: 0x0400C655 RID: 50773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C656 RID: 50774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C657 RID: 50775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C658 RID: 50776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C659 RID: 50777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C65A RID: 50778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C65B RID: 50779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C65C RID: 50780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C65D RID: 50781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C65E RID: 50782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C65F RID: 50783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C660 RID: 50784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C661 RID: 50785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C662 RID: 50786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C663 RID: 50787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C664 RID: 50788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C665 RID: 50789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C666 RID: 50790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C667 RID: 50791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C668 RID: 50792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C669 RID: 50793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C66A RID: 50794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
