using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017CA RID: 6090
[Preserve]
public class Lua_UnityEngine_ScriptableObject : LuaObject
{
	// Token: 0x06023CDA RID: 146650 RVA: 0x00C8B22C File Offset: 0x00C8942C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ScriptableObject o = new ScriptableObject();
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

	// Token: 0x06023CDB RID: 146651 RVA: 0x00C8B274 File Offset: 0x00C89474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateInstance_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(string)))
			{
				string className;
				LuaObject.checkType(l, 1, out className);
				ScriptableObject o = ScriptableObject.CreateInstance(className);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Type)))
			{
				Type type;
				LuaObject.checkType(l, 1, out type);
				ScriptableObject o2 = ScriptableObject.CreateInstance(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 0)
			{
				ScriptableObject o3 = ScriptableObject.CreateInstance<ScriptableObject>();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CreateInstance to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CDC RID: 146652 RVA: 0x00C8B364 File Offset: 0x00C89564
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ScriptableObject");
		if (Lua_UnityEngine_ScriptableObject.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ScriptableObject.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ScriptableObject.CreateInstance_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ScriptableObject.<>f__mg$cache0);
		if (Lua_UnityEngine_ScriptableObject.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ScriptableObject.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ScriptableObject.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ScriptableObject.<>f__mg$cache1, typeof(ScriptableObject), typeof(UnityEngine.Object));
	}

	// Token: 0x040199A4 RID: 104868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040199A5 RID: 104869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
