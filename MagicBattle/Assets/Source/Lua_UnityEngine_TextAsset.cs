using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017F5 RID: 6133
[Preserve]
public class Lua_UnityEngine_TextAsset : LuaObject
{
	// Token: 0x06023E3E RID: 147006 RVA: 0x00C953A8 File Offset: 0x00C935A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TextAsset o = new TextAsset();
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

	// Token: 0x06023E3F RID: 147007 RVA: 0x00C953F0 File Offset: 0x00C935F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_text(IntPtr l)
	{
		int result;
		try
		{
			TextAsset textAsset = (TextAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textAsset.text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E40 RID: 147008 RVA: 0x00C95444 File Offset: 0x00C93644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bytes(IntPtr l)
	{
		int result;
		try
		{
			TextAsset textAsset = (TextAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, textAsset.bytes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E41 RID: 147009 RVA: 0x00C95498 File Offset: 0x00C93698
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.TextAsset");
		string name = "text";
		if (Lua_UnityEngine_TextAsset.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_TextAsset.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_TextAsset.get_text);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_TextAsset.<>f__mg$cache0, null, true);
		string name2 = "bytes";
		if (Lua_UnityEngine_TextAsset.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_TextAsset.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_TextAsset.get_bytes);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_TextAsset.<>f__mg$cache1, null, true);
		if (Lua_UnityEngine_TextAsset.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_TextAsset.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_TextAsset.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_TextAsset.<>f__mg$cache2, typeof(TextAsset), typeof(UnityEngine.Object));
	}

	// Token: 0x04019AB2 RID: 105138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019AB3 RID: 105139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019AB4 RID: 105140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
