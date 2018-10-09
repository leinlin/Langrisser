using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015AF RID: 5551
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ThearchyLevelAttackNetTask : LuaObject
{
	// Token: 0x06021B62 RID: 138082 RVA: 0x00B71680 File Offset: 0x00B6F880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			ThearchyLevelAttackNetTask o = new ThearchyLevelAttackNetTask(levelId);
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

	// Token: 0x06021B63 RID: 138083 RVA: 0x00B716D4 File Offset: 0x00B6F8D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ThearchyLevelAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_ThearchyLevelAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ThearchyLevelAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ThearchyLevelAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ThearchyLevelAttackNetTask.<>f__mg$cache0, typeof(ThearchyLevelAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x040179E6 RID: 96742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
