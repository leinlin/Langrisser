using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001754 RID: 5972
[Preserve]
public class Lua_UnityEngine_PlayerPrefs : LuaObject
{
	// Token: 0x0602383F RID: 145471 RVA: 0x00C668B4 File Offset: 0x00C64AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayerPrefs o = new PlayerPrefs();
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

	// Token: 0x06023840 RID: 145472 RVA: 0x00C668FC File Offset: 0x00C64AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInt_s(IntPtr l)
	{
		int result;
		try
		{
			string key;
			LuaObject.checkType(l, 1, out key);
			int value;
			LuaObject.checkType(l, 2, out value);
			PlayerPrefs.SetInt(key, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023841 RID: 145473 RVA: 0x00C66954 File Offset: 0x00C64B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInt_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string key;
				LuaObject.checkType(l, 1, out key);
				int @int = PlayerPrefs.GetInt(key);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @int);
				result = 2;
			}
			else if (num == 2)
			{
				string key2;
				LuaObject.checkType(l, 1, out key2);
				int defaultValue;
				LuaObject.checkType(l, 2, out defaultValue);
				int int2 = PlayerPrefs.GetInt(key2, defaultValue);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, int2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetInt to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023842 RID: 145474 RVA: 0x00C66A0C File Offset: 0x00C64C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFloat_s(IntPtr l)
	{
		int result;
		try
		{
			string key;
			LuaObject.checkType(l, 1, out key);
			float value;
			LuaObject.checkType(l, 2, out value);
			PlayerPrefs.SetFloat(key, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023843 RID: 145475 RVA: 0x00C66A64 File Offset: 0x00C64C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFloat_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string key;
				LuaObject.checkType(l, 1, out key);
				float @float = PlayerPrefs.GetFloat(key);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @float);
				result = 2;
			}
			else if (num == 2)
			{
				string key2;
				LuaObject.checkType(l, 1, out key2);
				float defaultValue;
				LuaObject.checkType(l, 2, out defaultValue);
				float float2 = PlayerPrefs.GetFloat(key2, defaultValue);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, float2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetFloat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023844 RID: 145476 RVA: 0x00C66B1C File Offset: 0x00C64D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetString_s(IntPtr l)
	{
		int result;
		try
		{
			string key;
			LuaObject.checkType(l, 1, out key);
			string value;
			LuaObject.checkType(l, 2, out value);
			PlayerPrefs.SetString(key, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023845 RID: 145477 RVA: 0x00C66B74 File Offset: 0x00C64D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetString_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string key;
				LuaObject.checkType(l, 1, out key);
				string @string = PlayerPrefs.GetString(key);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @string);
				result = 2;
			}
			else if (num == 2)
			{
				string key2;
				LuaObject.checkType(l, 1, out key2);
				string defaultValue;
				LuaObject.checkType(l, 2, out defaultValue);
				string string2 = PlayerPrefs.GetString(key2, defaultValue);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, string2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetString to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023846 RID: 145478 RVA: 0x00C66C2C File Offset: 0x00C64E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasKey_s(IntPtr l)
	{
		int result;
		try
		{
			string key;
			LuaObject.checkType(l, 1, out key);
			bool b = PlayerPrefs.HasKey(key);
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

	// Token: 0x06023847 RID: 145479 RVA: 0x00C66C80 File Offset: 0x00C64E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeleteKey_s(IntPtr l)
	{
		int result;
		try
		{
			string key;
			LuaObject.checkType(l, 1, out key);
			PlayerPrefs.DeleteKey(key);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023848 RID: 145480 RVA: 0x00C66CCC File Offset: 0x00C64ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeleteAll_s(IntPtr l)
	{
		int result;
		try
		{
			PlayerPrefs.DeleteAll();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023849 RID: 145481 RVA: 0x00C66D0C File Offset: 0x00C64F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Save_s(IntPtr l)
	{
		int result;
		try
		{
			PlayerPrefs.Save();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602384A RID: 145482 RVA: 0x00C66D4C File Offset: 0x00C64F4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.PlayerPrefs");
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.SetInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cache0);
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.GetInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cache1);
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.SetFloat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cache2);
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.GetFloat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cache3);
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.SetString_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cache4);
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.GetString_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cache5);
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.HasKey_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cache6);
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.DeleteKey_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cache7);
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.DeleteAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cache8);
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.Save_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cache9);
		if (Lua_UnityEngine_PlayerPrefs.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_PlayerPrefs.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_PlayerPrefs.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_PlayerPrefs.<>f__mg$cacheA, typeof(PlayerPrefs));
	}

	// Token: 0x040195F5 RID: 103925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195F6 RID: 103926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195F7 RID: 103927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195F8 RID: 103928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040195F9 RID: 103929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040195FA RID: 103930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040195FB RID: 103931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040195FC RID: 103932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040195FD RID: 103933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040195FE RID: 103934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040195FF RID: 103935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
