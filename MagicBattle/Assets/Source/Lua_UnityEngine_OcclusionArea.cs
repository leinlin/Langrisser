using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001734 RID: 5940
[Preserve]
public class Lua_UnityEngine_OcclusionArea : LuaObject
{
	// Token: 0x060236C6 RID: 145094 RVA: 0x00C54AA0 File Offset: 0x00C52CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			OcclusionArea occlusionArea = (OcclusionArea)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, occlusionArea.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236C7 RID: 145095 RVA: 0x00C54AF4 File Offset: 0x00C52CF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_center(IntPtr l)
	{
		int result;
		try
		{
			OcclusionArea occlusionArea = (OcclusionArea)LuaObject.checkSelf(l);
			Vector3 center;
			LuaObject.checkType(l, 2, out center);
			occlusionArea.center = center;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236C8 RID: 145096 RVA: 0x00C54B4C File Offset: 0x00C52D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			OcclusionArea occlusionArea = (OcclusionArea)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, occlusionArea.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236C9 RID: 145097 RVA: 0x00C54BA0 File Offset: 0x00C52DA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			OcclusionArea occlusionArea = (OcclusionArea)LuaObject.checkSelf(l);
			Vector3 size;
			LuaObject.checkType(l, 2, out size);
			occlusionArea.size = size;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236CA RID: 145098 RVA: 0x00C54BF8 File Offset: 0x00C52DF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.OcclusionArea");
		string name = "center";
		if (Lua_UnityEngine_OcclusionArea.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_OcclusionArea.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_OcclusionArea.get_center);
		}
		LuaCSFunction get = Lua_UnityEngine_OcclusionArea.<>f__mg$cache0;
		if (Lua_UnityEngine_OcclusionArea.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_OcclusionArea.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_OcclusionArea.set_center);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_OcclusionArea.<>f__mg$cache1, true);
		string name2 = "size";
		if (Lua_UnityEngine_OcclusionArea.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_OcclusionArea.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_OcclusionArea.get_size);
		}
		LuaCSFunction get2 = Lua_UnityEngine_OcclusionArea.<>f__mg$cache2;
		if (Lua_UnityEngine_OcclusionArea.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_OcclusionArea.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_OcclusionArea.set_size);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_OcclusionArea.<>f__mg$cache3, true);
		LuaObject.createTypeMetatable(l, null, typeof(OcclusionArea), typeof(Component));
	}

	// Token: 0x040194BC RID: 103612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040194BD RID: 103613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040194BE RID: 103614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040194BF RID: 103615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
