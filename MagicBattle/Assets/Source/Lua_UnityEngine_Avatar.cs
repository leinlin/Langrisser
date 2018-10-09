using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001636 RID: 5686
[Preserve]
public class Lua_UnityEngine_Avatar : LuaObject
{
	// Token: 0x06022C1B RID: 142363 RVA: 0x00BFFE50 File Offset: 0x00BFE050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isValid(IntPtr l)
	{
		int result;
		try
		{
			Avatar avatar = (Avatar)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, avatar.isValid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C1C RID: 142364 RVA: 0x00BFFEA4 File Offset: 0x00BFE0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isHuman(IntPtr l)
	{
		int result;
		try
		{
			Avatar avatar = (Avatar)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, avatar.isHuman);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C1D RID: 142365 RVA: 0x00BFFEF8 File Offset: 0x00BFE0F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Avatar");
		string name = "isValid";
		if (Lua_UnityEngine_Avatar.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Avatar.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Avatar.get_isValid);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Avatar.<>f__mg$cache0, null, true);
		string name2 = "isHuman";
		if (Lua_UnityEngine_Avatar.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Avatar.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Avatar.get_isHuman);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Avatar.<>f__mg$cache1, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Avatar), typeof(UnityEngine.Object));
	}

	// Token: 0x04018C0D RID: 101389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C0E RID: 101390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
