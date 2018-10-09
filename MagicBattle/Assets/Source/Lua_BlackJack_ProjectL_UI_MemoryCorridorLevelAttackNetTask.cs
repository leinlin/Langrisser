using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001509 RID: 5385
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelAttackNetTask : LuaObject
{
	// Token: 0x0601FE4A RID: 130634 RVA: 0x00A88F84 File Offset: 0x00A87184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			MemoryCorridorLevelAttackNetTask o = new MemoryCorridorLevelAttackNetTask(levelId);
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

	// Token: 0x0601FE4B RID: 130635 RVA: 0x00A88FD8 File Offset: 0x00A871D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MemoryCorridorLevelAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelAttackNetTask.<>f__mg$cache0, typeof(MemoryCorridorLevelAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x04015E1A RID: 89626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
