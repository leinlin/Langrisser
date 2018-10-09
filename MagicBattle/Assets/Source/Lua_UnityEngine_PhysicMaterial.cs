using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001737 RID: 5943
[Preserve]
public class Lua_UnityEngine_PhysicMaterial : LuaObject
{
	// Token: 0x060236D2 RID: 145106 RVA: 0x00C54E48 File Offset: 0x00C53048
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
				PhysicMaterial o = new PhysicMaterial();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				string name;
				LuaObject.checkType(l, 2, out name);
				PhysicMaterial o = new PhysicMaterial(name);
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

	// Token: 0x060236D3 RID: 145107 RVA: 0x00C54EE0 File Offset: 0x00C530E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_dynamicFriction(IntPtr l)
	{
		int result;
		try
		{
			PhysicMaterial physicMaterial = (PhysicMaterial)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicMaterial.dynamicFriction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236D4 RID: 145108 RVA: 0x00C54F34 File Offset: 0x00C53134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_dynamicFriction(IntPtr l)
	{
		int result;
		try
		{
			PhysicMaterial physicMaterial = (PhysicMaterial)LuaObject.checkSelf(l);
			float dynamicFriction;
			LuaObject.checkType(l, 2, out dynamicFriction);
			physicMaterial.dynamicFriction = dynamicFriction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236D5 RID: 145109 RVA: 0x00C54F8C File Offset: 0x00C5318C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_staticFriction(IntPtr l)
	{
		int result;
		try
		{
			PhysicMaterial physicMaterial = (PhysicMaterial)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicMaterial.staticFriction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236D6 RID: 145110 RVA: 0x00C54FE0 File Offset: 0x00C531E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_staticFriction(IntPtr l)
	{
		int result;
		try
		{
			PhysicMaterial physicMaterial = (PhysicMaterial)LuaObject.checkSelf(l);
			float staticFriction;
			LuaObject.checkType(l, 2, out staticFriction);
			physicMaterial.staticFriction = staticFriction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236D7 RID: 145111 RVA: 0x00C55038 File Offset: 0x00C53238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounciness(IntPtr l)
	{
		int result;
		try
		{
			PhysicMaterial physicMaterial = (PhysicMaterial)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicMaterial.bounciness);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236D8 RID: 145112 RVA: 0x00C5508C File Offset: 0x00C5328C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bounciness(IntPtr l)
	{
		int result;
		try
		{
			PhysicMaterial physicMaterial = (PhysicMaterial)LuaObject.checkSelf(l);
			float bounciness;
			LuaObject.checkType(l, 2, out bounciness);
			physicMaterial.bounciness = bounciness;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236D9 RID: 145113 RVA: 0x00C550E4 File Offset: 0x00C532E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_frictionCombine(IntPtr l)
	{
		int result;
		try
		{
			PhysicMaterial physicMaterial = (PhysicMaterial)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)physicMaterial.frictionCombine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236DA RID: 145114 RVA: 0x00C55138 File Offset: 0x00C53338
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_frictionCombine(IntPtr l)
	{
		int result;
		try
		{
			PhysicMaterial physicMaterial = (PhysicMaterial)LuaObject.checkSelf(l);
			PhysicMaterialCombine frictionCombine;
			LuaObject.checkEnum<PhysicMaterialCombine>(l, 2, out frictionCombine);
			physicMaterial.frictionCombine = frictionCombine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236DB RID: 145115 RVA: 0x00C55190 File Offset: 0x00C53390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_bounceCombine(IntPtr l)
	{
		int result;
		try
		{
			PhysicMaterial physicMaterial = (PhysicMaterial)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)physicMaterial.bounceCombine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236DC RID: 145116 RVA: 0x00C551E4 File Offset: 0x00C533E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bounceCombine(IntPtr l)
	{
		int result;
		try
		{
			PhysicMaterial physicMaterial = (PhysicMaterial)LuaObject.checkSelf(l);
			PhysicMaterialCombine bounceCombine;
			LuaObject.checkEnum<PhysicMaterialCombine>(l, 2, out bounceCombine);
			physicMaterial.bounceCombine = bounceCombine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236DD RID: 145117 RVA: 0x00C5523C File Offset: 0x00C5343C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.PhysicMaterial");
		string name = "dynamicFriction";
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.get_dynamicFriction);
		}
		LuaCSFunction get = Lua_UnityEngine_PhysicMaterial.<>f__mg$cache0;
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.set_dynamicFriction);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_PhysicMaterial.<>f__mg$cache1, true);
		string name2 = "staticFriction";
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.get_staticFriction);
		}
		LuaCSFunction get2 = Lua_UnityEngine_PhysicMaterial.<>f__mg$cache2;
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.set_staticFriction);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_PhysicMaterial.<>f__mg$cache3, true);
		string name3 = "bounciness";
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.get_bounciness);
		}
		LuaCSFunction get3 = Lua_UnityEngine_PhysicMaterial.<>f__mg$cache4;
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.set_bounciness);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_PhysicMaterial.<>f__mg$cache5, true);
		string name4 = "frictionCombine";
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.get_frictionCombine);
		}
		LuaCSFunction get4 = Lua_UnityEngine_PhysicMaterial.<>f__mg$cache6;
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.set_frictionCombine);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_PhysicMaterial.<>f__mg$cache7, true);
		string name5 = "bounceCombine";
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.get_bounceCombine);
		}
		LuaCSFunction get5 = Lua_UnityEngine_PhysicMaterial.<>f__mg$cache8;
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.set_bounceCombine);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_PhysicMaterial.<>f__mg$cache9, true);
		if (Lua_UnityEngine_PhysicMaterial.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_PhysicMaterial.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_PhysicMaterial.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_PhysicMaterial.<>f__mg$cacheA, typeof(PhysicMaterial), typeof(UnityEngine.Object));
	}

	// Token: 0x040194C2 RID: 103618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040194C3 RID: 103619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040194C4 RID: 103620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040194C5 RID: 103621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040194C6 RID: 103622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040194C7 RID: 103623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040194C8 RID: 103624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040194C9 RID: 103625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040194CA RID: 103626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040194CB RID: 103627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040194CC RID: 103628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
