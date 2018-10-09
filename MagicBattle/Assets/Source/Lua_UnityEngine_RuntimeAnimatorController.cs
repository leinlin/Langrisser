using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017BF RID: 6079
[Preserve]
public class Lua_UnityEngine_RuntimeAnimatorController : LuaObject
{
	// Token: 0x06023C8D RID: 146573 RVA: 0x00C89114 File Offset: 0x00C87314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RuntimeAnimatorController o = new RuntimeAnimatorController();
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

	// Token: 0x06023C8E RID: 146574 RVA: 0x00C8915C File Offset: 0x00C8735C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_animationClips(IntPtr l)
	{
		int result;
		try
		{
			RuntimeAnimatorController runtimeAnimatorController = (RuntimeAnimatorController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, runtimeAnimatorController.animationClips);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C8F RID: 146575 RVA: 0x00C891B0 File Offset: 0x00C873B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RuntimeAnimatorController");
		string name = "animationClips";
		if (Lua_UnityEngine_RuntimeAnimatorController.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RuntimeAnimatorController.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RuntimeAnimatorController.get_animationClips);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_RuntimeAnimatorController.<>f__mg$cache0, null, true);
		if (Lua_UnityEngine_RuntimeAnimatorController.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RuntimeAnimatorController.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RuntimeAnimatorController.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RuntimeAnimatorController.<>f__mg$cache1, typeof(RuntimeAnimatorController), typeof(UnityEngine.Object));
	}

	// Token: 0x0401996D RID: 104813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401996E RID: 104814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
