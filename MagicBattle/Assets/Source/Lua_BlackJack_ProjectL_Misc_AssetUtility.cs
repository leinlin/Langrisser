using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200129D RID: 4765
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_AssetUtility : LuaObject
{
	// Token: 0x06019008 RID: 102408 RVA: 0x0071CD78 File Offset: 0x0071AF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility o = new AssetUtility();
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

	// Token: 0x06019009 RID: 102409 RVA: 0x0071CDC0 File Offset: 0x0071AFC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegisterDynamicAssetProvider(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			IDynamicAssetProvider assetProvider;
			LuaObject.checkType<IDynamicAssetProvider>(l, 2, out assetProvider);
			assetUtility.RegisterDynamicAssetProvider(assetProvider);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601900A RID: 102410 RVA: 0x0071CE18 File Offset: 0x0071B018
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UnregisterDynamicAssetProvider(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			IDynamicAssetProvider assetProvider;
			LuaObject.checkType<IDynamicAssetProvider>(l, 2, out assetProvider);
			assetUtility.UnregisterDynamicAssetProvider(assetProvider);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601900B RID: 102411 RVA: 0x0071CE70 File Offset: 0x0071B070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegisterDynamicAssetCache(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			Dictionary<string, UnityEngine.Object> assetCache;
			LuaObject.checkType<Dictionary<string, UnityEngine.Object>>(l, 2, out assetCache);
			assetUtility.RegisterDynamicAssetCache(assetCache);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601900C RID: 102412 RVA: 0x0071CEC8 File Offset: 0x0071B0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterDynamicAssetCache(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			Dictionary<string, UnityEngine.Object> assetCache;
			LuaObject.checkType<Dictionary<string, UnityEngine.Object>>(l, 2, out assetCache);
			assetUtility.UnregisterDynamicAssetCache(assetCache);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601900D RID: 102413 RVA: 0x0071CF20 File Offset: 0x0071B120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAsset(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			UnityEngine.Object asset = assetUtility.GetAsset<UnityEngine.Object>(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, asset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601900E RID: 102414 RVA: 0x0071CF84 File Offset: 0x0071B184
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSprite(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			Sprite sprite = assetUtility.GetSprite(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601900F RID: 102415 RVA: 0x0071CFE8 File Offset: 0x0071B1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitLruAssetCache(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			int cacheType;
			LuaObject.checkType(l, 2, out cacheType);
			int maxCount;
			LuaObject.checkType(l, 3, out maxCount);
			assetUtility.InitLruAssetCache(cacheType, maxCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019010 RID: 102416 RVA: 0x0071D04C File Offset: 0x0071B24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitAllLruAssetCache(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			assetUtility.UninitAllLruAssetCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019011 RID: 102417 RVA: 0x0071D098 File Offset: 0x0071B298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddAssetToLruCache(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(UnityEngine.Object)))
			{
				AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
				int cacheType;
				LuaObject.checkType(l, 2, out cacheType);
				UnityEngine.Object a;
				LuaObject.checkType<UnityEngine.Object>(l, 3, out a);
				assetUtility.AddAssetToLruCache(cacheType, a);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(string)))
			{
				AssetUtility assetUtility2 = (AssetUtility)LuaObject.checkSelf(l);
				int cacheType2;
				LuaObject.checkType(l, 2, out cacheType2);
				string name;
				LuaObject.checkType(l, 3, out name);
				assetUtility2.AddAssetToLruCache(cacheType2, name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddAssetToLruCache to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019012 RID: 102418 RVA: 0x0071D1A0 File Offset: 0x0071B3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearLruCache(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			int cacheType;
			LuaObject.checkType(l, 2, out cacheType);
			assetUtility.ClearLruCache(cacheType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019013 RID: 102419 RVA: 0x0071D1F8 File Offset: 0x0071B3F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAllLruCache(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			assetUtility.ClearAllLruCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019014 RID: 102420 RVA: 0x0071D244 File Offset: 0x0071B444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TestMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility assetUtility = (AssetUtility)LuaObject.checkSelf(l);
			assetUtility.TestMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019015 RID: 102421 RVA: 0x0071D290 File Offset: 0x0071B490
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MakeSpriteAssetName_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				string s = AssetUtility.MakeSpriteAssetName(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s);
				result = 2;
			}
			else if (num == 2)
			{
				string name2;
				LuaObject.checkType(l, 1, out name2);
				string subName;
				LuaObject.checkType(l, 2, out subName);
				string s2 = AssetUtility.MakeSpriteAssetName(name2, subName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, s2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function MakeSpriteAssetName to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019016 RID: 102422 RVA: 0x0071D348 File Offset: 0x0071B548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAssetToList_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			List<string> list;
			LuaObject.checkType<List<string>>(l, 2, out list);
			AssetUtility.AddAssetToList(name, list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019017 RID: 102423 RVA: 0x0071D3A0 File Offset: 0x0071B5A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddSpriteAssetToList_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			List<string> list;
			LuaObject.checkType<List<string>>(l, 2, out list);
			AssetUtility.AddSpriteAssetToList(name, list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019018 RID: 102424 RVA: 0x0071D3F8 File Offset: 0x0071B5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DataPath(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Assets/GameProject/RuntimeAssets/");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019019 RID: 102425 RVA: 0x0071D440 File Offset: 0x0071B640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AssetUtility.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601901A RID: 102426 RVA: 0x0071D488 File Offset: 0x0071B688
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Instance(IntPtr l)
	{
		int result;
		try
		{
			AssetUtility instance;
			LuaObject.checkType<AssetUtility>(l, 2, out instance);
			AssetUtility.Instance = instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601901B RID: 102427 RVA: 0x0071D4D4 File Offset: 0x0071B6D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.AssetUtility");
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.RegisterDynamicAssetProvider);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.UnregisterDynamicAssetProvider);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.RegisterDynamicAssetCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.UnregisterDynamicAssetCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.GetAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.GetSprite);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.InitLruAssetCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.UninitAllLruAssetCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.AddAssetToLruCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.ClearLruCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.ClearAllLruCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.TestMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.MakeSpriteAssetName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.AddAssetToList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.AddSpriteAssetToList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheE);
		string name = "DataPath";
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.get_DataPath);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cacheF, null, false);
		string name2 = "Instance";
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.get_Instance);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.set_Instance);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache11, false);
		if (Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_AssetUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_AssetUtility.<>f__mg$cache12, typeof(AssetUtility));
	}

	// Token: 0x0400F4B0 RID: 62640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F4B1 RID: 62641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F4B2 RID: 62642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F4B3 RID: 62643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F4B4 RID: 62644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F4B5 RID: 62645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F4B6 RID: 62646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F4B7 RID: 62647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F4B8 RID: 62648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F4B9 RID: 62649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F4BA RID: 62650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F4BB RID: 62651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F4BC RID: 62652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F4BD RID: 62653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F4BE RID: 62654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F4BF RID: 62655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F4C0 RID: 62656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F4C1 RID: 62657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F4C2 RID: 62658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
