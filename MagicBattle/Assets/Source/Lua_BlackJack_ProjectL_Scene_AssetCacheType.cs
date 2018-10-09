using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012EA RID: 4842
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_AssetCacheType : LuaObject
{
	// Token: 0x0601A143 RID: 106819 RVA: 0x007A9A00 File Offset: 0x007A7C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AssetCacheType o = new AssetCacheType();
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

	// Token: 0x0601A144 RID: 106820 RVA: 0x007A9A48 File Offset: 0x007A7C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Hero0(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A145 RID: 106821 RVA: 0x007A9A8C File Offset: 0x007A7C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Hero1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A146 RID: 106822 RVA: 0x007A9AD0 File Offset: 0x007A7CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Soldier0(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A147 RID: 106823 RVA: 0x007A9B14 File Offset: 0x007A7D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Soldier1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A148 RID: 106824 RVA: 0x007A9B58 File Offset: 0x007A7D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Fx(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A149 RID: 106825 RVA: 0x007A9B9C File Offset: 0x007A7D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TerrainBackground(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 6);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A14A RID: 106826 RVA: 0x007A9BE0 File Offset: 0x007A7DE0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.AssetCacheType");
		string name = "Hero0";
		if (Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_AssetCacheType.get_Hero0);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache0, null, false);
		string name2 = "Hero1";
		if (Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_AssetCacheType.get_Hero1);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache1, null, false);
		string name3 = "Soldier0";
		if (Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_AssetCacheType.get_Soldier0);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache2, null, false);
		string name4 = "Soldier1";
		if (Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_AssetCacheType.get_Soldier1);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache3, null, false);
		string name5 = "Fx";
		if (Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_AssetCacheType.get_Fx);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache4, null, false);
		string name6 = "TerrainBackground";
		if (Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_AssetCacheType.get_TerrainBackground);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache5, null, false);
		if (Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_AssetCacheType.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_AssetCacheType.<>f__mg$cache6, typeof(AssetCacheType));
	}

	// Token: 0x04010551 RID: 66897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010552 RID: 66898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010553 RID: 66899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010554 RID: 66900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010555 RID: 66901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010556 RID: 66902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010557 RID: 66903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
