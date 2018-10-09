using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017B5 RID: 6069
[Preserve]
public class Lua_UnityEngine_Resources : LuaObject
{
	// Token: 0x06023BED RID: 146413 RVA: 0x00C83A54 File Offset: 0x00C81C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Resources o = new Resources();
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

	// Token: 0x06023BEE RID: 146414 RVA: 0x00C83A9C File Offset: 0x00C81C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindObjectsOfTypeAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Type type;
				LuaObject.checkType(l, 1, out type);
				UnityEngine.Object[] a = Resources.FindObjectsOfTypeAll(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 0)
			{
				UnityEngine.Object[] a2 = Resources.FindObjectsOfTypeAll<UnityEngine.Object>();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindObjectsOfTypeAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BEF RID: 146415 RVA: 0x00C83B3C File Offset: 0x00C81D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Load_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(string)))
			{
				string path;
				LuaObject.checkType(l, 1, out path);
				UnityEngine.Object o = Resources.Load(path);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string)))
			{
				string path2;
				LuaObject.checkType(l, 1, out path2);
				UnityEngine.Object o2 = Resources.Load<UnityEngine.Object>(path2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 2)
			{
				string path3;
				LuaObject.checkType(l, 1, out path3);
				Type systemTypeInstance;
				LuaObject.checkType(l, 2, out systemTypeInstance);
				UnityEngine.Object o3 = Resources.Load(path3, systemTypeInstance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Load to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BF0 RID: 146416 RVA: 0x00C83C44 File Offset: 0x00C81E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadAsync_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(string)))
			{
				string path;
				LuaObject.checkType(l, 1, out path);
				ResourceRequest o = Resources.LoadAsync(path);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string)))
			{
				string path2;
				LuaObject.checkType(l, 1, out path2);
				ResourceRequest o2 = Resources.LoadAsync<UnityEngine.Object>(path2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 2)
			{
				string path3;
				LuaObject.checkType(l, 1, out path3);
				Type type;
				LuaObject.checkType(l, 2, out type);
				ResourceRequest o3 = Resources.LoadAsync(path3, type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadAsync to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BF1 RID: 146417 RVA: 0x00C83D4C File Offset: 0x00C81F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string path;
				LuaObject.checkType(l, 1, out path);
				Type systemTypeInstance;
				LuaObject.checkType(l, 2, out systemTypeInstance);
				UnityEngine.Object[] a = Resources.LoadAll(path, systemTypeInstance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string)))
			{
				string path2;
				LuaObject.checkType(l, 1, out path2);
				UnityEngine.Object[] a2 = Resources.LoadAll(path2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(string)))
			{
				string path3;
				LuaObject.checkType(l, 1, out path3);
				UnityEngine.Object[] a3 = Resources.LoadAll<UnityEngine.Object>(path3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BF2 RID: 146418 RVA: 0x00C83E58 File Offset: 0x00C82058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBuiltinResource_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string path;
				LuaObject.checkType(l, 1, out path);
				UnityEngine.Object builtinResource = Resources.GetBuiltinResource<UnityEngine.Object>(path);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, builtinResource);
				result = 2;
			}
			else if (num == 2)
			{
				Type type;
				LuaObject.checkType(l, 1, out type);
				string path2;
				LuaObject.checkType(l, 2, out path2);
				UnityEngine.Object builtinResource2 = Resources.GetBuiltinResource(type, path2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, builtinResource2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetBuiltinResource to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BF3 RID: 146419 RVA: 0x00C83F10 File Offset: 0x00C82110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UnloadAsset_s(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object assetToUnload;
			LuaObject.checkType<UnityEngine.Object>(l, 1, out assetToUnload);
			Resources.UnloadAsset(assetToUnload);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BF4 RID: 146420 RVA: 0x00C83F5C File Offset: 0x00C8215C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnloadUnusedAssets_s(IntPtr l)
	{
		int result;
		try
		{
			AsyncOperation o = Resources.UnloadUnusedAssets();
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

	// Token: 0x06023BF5 RID: 146421 RVA: 0x00C83FA4 File Offset: 0x00C821A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Resources");
		if (Lua_UnityEngine_Resources.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Resources.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Resources.FindObjectsOfTypeAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Resources.<>f__mg$cache0);
		if (Lua_UnityEngine_Resources.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Resources.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Resources.Load_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Resources.<>f__mg$cache1);
		if (Lua_UnityEngine_Resources.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Resources.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Resources.LoadAsync_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Resources.<>f__mg$cache2);
		if (Lua_UnityEngine_Resources.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Resources.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Resources.LoadAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Resources.<>f__mg$cache3);
		if (Lua_UnityEngine_Resources.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Resources.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Resources.GetBuiltinResource_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Resources.<>f__mg$cache4);
		if (Lua_UnityEngine_Resources.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Resources.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Resources.UnloadAsset_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Resources.<>f__mg$cache5);
		if (Lua_UnityEngine_Resources.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Resources.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Resources.UnloadUnusedAssets_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Resources.<>f__mg$cache6);
		if (Lua_UnityEngine_Resources.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Resources.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Resources.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Resources.<>f__mg$cache7, typeof(Resources));
	}

	// Token: 0x040198E1 RID: 104673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040198E2 RID: 104674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040198E3 RID: 104675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040198E4 RID: 104676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040198E5 RID: 104677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040198E6 RID: 104678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040198E7 RID: 104679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040198E8 RID: 104680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
