using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200135E RID: 4958
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AnikiLevelAttackNetTask : LuaObject
{
	// Token: 0x0601AB64 RID: 109412 RVA: 0x007F5B7C File Offset: 0x007F3D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			AnikiLevelAttackNetTask o = new AnikiLevelAttackNetTask(levelId);
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

	// Token: 0x0601AB65 RID: 109413 RVA: 0x007F5BD0 File Offset: 0x007F3DD0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AnikiLevelAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_AnikiLevelAttackNetTask.<>f__mg$cache0, typeof(AnikiLevelAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x04010E8A RID: 69258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
