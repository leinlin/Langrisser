using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013F5 RID: 5109
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ClimbTowerLevelAttackNetTask : LuaObject
{
	// Token: 0x0601CB49 RID: 117577 RVA: 0x008F3454 File Offset: 0x008F1654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int floorId;
			LuaObject.checkType(l, 2, out floorId);
			ClimbTowerLevelAttackNetTask o = new ClimbTowerLevelAttackNetTask(floorId);
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

	// Token: 0x0601CB4A RID: 117578 RVA: 0x008F34A8 File Offset: 0x008F16A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ClimbTowerLevelAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_ClimbTowerLevelAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ClimbTowerLevelAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ClimbTowerLevelAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ClimbTowerLevelAttackNetTask.<>f__mg$cache0, typeof(ClimbTowerLevelAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x04012D41 RID: 77121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
