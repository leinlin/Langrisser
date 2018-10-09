using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014BA RID: 5306
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDungeonLevelAttackNetTask : LuaObject
{
	// Token: 0x0601F01B RID: 127003 RVA: 0x00A1833C File Offset: 0x00A1653C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelID;
			LuaObject.checkType(l, 2, out levelID);
			HeroDungeonLevelAttackNetTask o = new HeroDungeonLevelAttackNetTask(levelID);
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

	// Token: 0x0601F01C RID: 127004 RVA: 0x00A18390 File Offset: 0x00A16590
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDungeonLevelAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonLevelAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonLevelAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonLevelAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroDungeonLevelAttackNetTask.<>f__mg$cache0, typeof(HeroDungeonLevelAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x04015089 RID: 86153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
