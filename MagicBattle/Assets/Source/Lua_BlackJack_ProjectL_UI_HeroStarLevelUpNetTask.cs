using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014E8 RID: 5352
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroStarLevelUpNetTask : LuaObject
{
	// Token: 0x0601F946 RID: 129350 RVA: 0x00A61BDC File Offset: 0x00A5FDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int id;
			LuaObject.checkType(l, 2, out id);
			HeroStarLevelUpNetTask o = new HeroStarLevelUpNetTask(id);
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

	// Token: 0x0601F947 RID: 129351 RVA: 0x00A61C30 File Offset: 0x00A5FE30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroStarLevelUpNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroStarLevelUpNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroStarLevelUpNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroStarLevelUpNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroStarLevelUpNetTask.<>f__mg$cache0, typeof(HeroStarLevelUpNetTask), typeof(UINetTask));
	}

	// Token: 0x04015958 RID: 88408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
