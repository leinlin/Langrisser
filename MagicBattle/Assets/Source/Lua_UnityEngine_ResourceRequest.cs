using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017B4 RID: 6068
[Preserve]
public class Lua_UnityEngine_ResourceRequest : LuaObject
{
	// Token: 0x06023BE9 RID: 146409 RVA: 0x00C83934 File Offset: 0x00C81B34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ResourceRequest o = new ResourceRequest();
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

	// Token: 0x06023BEA RID: 146410 RVA: 0x00C8397C File Offset: 0x00C81B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_asset(IntPtr l)
	{
		int result;
		try
		{
			ResourceRequest resourceRequest = (ResourceRequest)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resourceRequest.asset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BEB RID: 146411 RVA: 0x00C839D0 File Offset: 0x00C81BD0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ResourceRequest");
		string name = "asset";
		if (Lua_UnityEngine_ResourceRequest.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ResourceRequest.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ResourceRequest.get_asset);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_ResourceRequest.<>f__mg$cache0, null, true);
		if (Lua_UnityEngine_ResourceRequest.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ResourceRequest.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ResourceRequest.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ResourceRequest.<>f__mg$cache1, typeof(ResourceRequest), typeof(AsyncOperation));
	}

	// Token: 0x040198DF RID: 104671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040198E0 RID: 104672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
