using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012A4 RID: 4772
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener : LuaObject
{
	// Token: 0x06019065 RID: 102501 RVA: 0x0071F598 File Offset: 0x0071D798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GlobalMonoBehaviourEventListener o = new GlobalMonoBehaviourEventListener();
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

	// Token: 0x06019066 RID: 102502 RVA: 0x0071F5E0 File Offset: 0x0071D7E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GlobalMonoBehaviourEventListener.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019067 RID: 102503 RVA: 0x0071F628 File Offset: 0x0071D828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Instance(IntPtr l)
	{
		int result;
		try
		{
			IMonoBehaviourEventListener instance;
			LuaObject.checkType<IMonoBehaviourEventListener>(l, 2, out instance);
			GlobalMonoBehaviourEventListener.Instance = instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019068 RID: 102504 RVA: 0x0071F674 File Offset: 0x0071D874
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.GlobalMonoBehaviourEventListener");
		string name = "Instance";
		if (Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.get_Instance);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.set_Instance);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.<>f__mg$cache1, false);
		if (Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_GlobalMonoBehaviourEventListener.<>f__mg$cache2, typeof(GlobalMonoBehaviourEventListener));
	}

	// Token: 0x0400F4FF RID: 62719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F500 RID: 62720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F501 RID: 62721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
