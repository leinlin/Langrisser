using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200173B RID: 5947
[Preserve]
public class Lua_UnityEngine_PhysicsMaterial2D : LuaObject
{
	// Token: 0x0602378D RID: 145293 RVA: 0x00C621F4 File Offset: 0x00C603F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				PhysicsMaterial2D o = new PhysicsMaterial2D();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				string name;
				LuaObject.checkType(l, 2, out name);
				PhysicsMaterial2D o = new PhysicsMaterial2D(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602378E RID: 145294 RVA: 0x00C6228C File Offset: 0x00C6048C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounciness(IntPtr l)
	{
		int result;
		try
		{
			PhysicsMaterial2D physicsMaterial2D = (PhysicsMaterial2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicsMaterial2D.bounciness);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602378F RID: 145295 RVA: 0x00C622E0 File Offset: 0x00C604E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bounciness(IntPtr l)
	{
		int result;
		try
		{
			PhysicsMaterial2D physicsMaterial2D = (PhysicsMaterial2D)LuaObject.checkSelf(l);
			float bounciness;
			LuaObject.checkType(l, 2, out bounciness);
			physicsMaterial2D.bounciness = bounciness;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023790 RID: 145296 RVA: 0x00C62338 File Offset: 0x00C60538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_friction(IntPtr l)
	{
		int result;
		try
		{
			PhysicsMaterial2D physicsMaterial2D = (PhysicsMaterial2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicsMaterial2D.friction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023791 RID: 145297 RVA: 0x00C6238C File Offset: 0x00C6058C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_friction(IntPtr l)
	{
		int result;
		try
		{
			PhysicsMaterial2D physicsMaterial2D = (PhysicsMaterial2D)LuaObject.checkSelf(l);
			float friction;
			LuaObject.checkType(l, 2, out friction);
			physicsMaterial2D.friction = friction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023792 RID: 145298 RVA: 0x00C623E4 File Offset: 0x00C605E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.PhysicsMaterial2D");
		string name = "bounciness";
		if (Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_PhysicsMaterial2D.get_bounciness);
		}
		LuaCSFunction get = Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache0;
		if (Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_PhysicsMaterial2D.set_bounciness);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache1, true);
		string name2 = "friction";
		if (Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_PhysicsMaterial2D.get_friction);
		}
		LuaCSFunction get2 = Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache2;
		if (Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_PhysicsMaterial2D.set_friction);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache3, true);
		if (Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_PhysicsMaterial2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_PhysicsMaterial2D.<>f__mg$cache4, typeof(PhysicsMaterial2D), typeof(UnityEngine.Object));
	}

	// Token: 0x04019575 RID: 103797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019576 RID: 103798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019577 RID: 103799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019578 RID: 103800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019579 RID: 103801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
