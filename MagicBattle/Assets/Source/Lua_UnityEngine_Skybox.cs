using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017D5 RID: 6101
[Preserve]
public class Lua_UnityEngine_Skybox : LuaObject
{
	// Token: 0x06023D2F RID: 146735 RVA: 0x00C8E078 File Offset: 0x00C8C278
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_material(IntPtr l)
	{
		int result;
		try
		{
			Skybox skybox = (Skybox)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skybox.material);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D30 RID: 146736 RVA: 0x00C8E0CC File Offset: 0x00C8C2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_material(IntPtr l)
	{
		int result;
		try
		{
			Skybox skybox = (Skybox)LuaObject.checkSelf(l);
			Material material;
			LuaObject.checkType<Material>(l, 2, out material);
			skybox.material = material;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D31 RID: 146737 RVA: 0x00C8E124 File Offset: 0x00C8C324
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Skybox");
		string name = "material";
		if (Lua_UnityEngine_Skybox.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Skybox.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Skybox.get_material);
		}
		LuaCSFunction get = Lua_UnityEngine_Skybox.<>f__mg$cache0;
		if (Lua_UnityEngine_Skybox.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Skybox.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Skybox.set_material);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Skybox.<>f__mg$cache1, true);
		LuaObject.createTypeMetatable(l, null, typeof(Skybox), typeof(Behaviour));
	}

	// Token: 0x040199E3 RID: 104931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040199E4 RID: 104932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
