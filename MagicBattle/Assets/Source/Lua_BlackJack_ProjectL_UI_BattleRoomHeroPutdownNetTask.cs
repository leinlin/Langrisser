using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013BB RID: 5051
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleRoomHeroPutdownNetTask : LuaObject
{
	// Token: 0x0601BEF3 RID: 114419 RVA: 0x008914F8 File Offset: 0x0088F6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int position;
			LuaObject.checkType(l, 2, out position);
			BattleRoomHeroPutdownNetTask o = new BattleRoomHeroPutdownNetTask(position);
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

	// Token: 0x0601BEF4 RID: 114420 RVA: 0x0089154C File Offset: 0x0088F74C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleRoomHeroPutdownNetTask");
		if (Lua_BlackJack_ProjectL_UI_BattleRoomHeroPutdownNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleRoomHeroPutdownNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleRoomHeroPutdownNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BattleRoomHeroPutdownNetTask.<>f__mg$cache0, typeof(BattleRoomHeroPutdownNetTask), typeof(UINetTask));
	}

	// Token: 0x0401215F RID: 74079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
