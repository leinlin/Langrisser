using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001693 RID: 5779
[Preserve]
public class Lua_UnityEngine_Effector2D : LuaObject
{
	// Token: 0x060230A2 RID: 143522 RVA: 0x00C229B4 File Offset: 0x00C20BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useColliderMask(IntPtr l)
	{
		int result;
		try
		{
			Effector2D effector2D = (Effector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, effector2D.useColliderMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230A3 RID: 143523 RVA: 0x00C22A08 File Offset: 0x00C20C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useColliderMask(IntPtr l)
	{
		int result;
		try
		{
			Effector2D effector2D = (Effector2D)LuaObject.checkSelf(l);
			bool useColliderMask;
			LuaObject.checkType(l, 2, out useColliderMask);
			effector2D.useColliderMask = useColliderMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230A4 RID: 143524 RVA: 0x00C22A60 File Offset: 0x00C20C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colliderMask(IntPtr l)
	{
		int result;
		try
		{
			Effector2D effector2D = (Effector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, effector2D.colliderMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230A5 RID: 143525 RVA: 0x00C22AB4 File Offset: 0x00C20CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colliderMask(IntPtr l)
	{
		int result;
		try
		{
			Effector2D effector2D = (Effector2D)LuaObject.checkSelf(l);
			int colliderMask;
			LuaObject.checkType(l, 2, out colliderMask);
			effector2D.colliderMask = colliderMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230A6 RID: 143526 RVA: 0x00C22B0C File Offset: 0x00C20D0C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Effector2D");
		string name = "useColliderMask";
		if (Lua_UnityEngine_Effector2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Effector2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Effector2D.get_useColliderMask);
		}
		LuaCSFunction get = Lua_UnityEngine_Effector2D.<>f__mg$cache0;
		if (Lua_UnityEngine_Effector2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Effector2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Effector2D.set_useColliderMask);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Effector2D.<>f__mg$cache1, true);
		string name2 = "colliderMask";
		if (Lua_UnityEngine_Effector2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Effector2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Effector2D.get_colliderMask);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Effector2D.<>f__mg$cache2;
		if (Lua_UnityEngine_Effector2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Effector2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Effector2D.set_colliderMask);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Effector2D.<>f__mg$cache3, true);
		LuaObject.createTypeMetatable(l, null, typeof(Effector2D), typeof(Behaviour));
	}

	// Token: 0x04018FDA RID: 102362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018FDB RID: 102363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018FDC RID: 102364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018FDD RID: 102365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
