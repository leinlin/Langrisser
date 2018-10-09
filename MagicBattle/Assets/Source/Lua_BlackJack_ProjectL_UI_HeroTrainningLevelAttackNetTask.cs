using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014E9 RID: 5353
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroTrainningLevelAttackNetTask : LuaObject
{
	// Token: 0x0601F949 RID: 129353 RVA: 0x00A61C88 File Offset: 0x00A5FE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			HeroTrainningLevelAttackNetTask o = new HeroTrainningLevelAttackNetTask(levelId);
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

	// Token: 0x0601F94A RID: 129354 RVA: 0x00A61CDC File Offset: 0x00A5FEDC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroTrainningLevelAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroTrainningLevelAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroTrainningLevelAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroTrainningLevelAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroTrainningLevelAttackNetTask.<>f__mg$cache0, typeof(HeroTrainningLevelAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x04015959 RID: 88409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
