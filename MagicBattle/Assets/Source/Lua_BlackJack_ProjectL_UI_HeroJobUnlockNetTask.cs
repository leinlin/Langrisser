using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014D1 RID: 5329
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroJobUnlockNetTask : LuaObject
{
	// Token: 0x0601F41C RID: 128028 RVA: 0x00A3852C File Offset: 0x00A3672C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelateId;
			LuaObject.checkType(l, 3, out jobRelateId);
			HeroJobUnlockNetTask o = new HeroJobUnlockNetTask(heroId, jobRelateId);
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

	// Token: 0x0601F41D RID: 128029 RVA: 0x00A3858C File Offset: 0x00A3678C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroJobUnlockNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroJobUnlockNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobUnlockNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobUnlockNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroJobUnlockNetTask.<>f__mg$cache0, typeof(HeroJobUnlockNetTask), typeof(UINetTask));
	}

	// Token: 0x0401545C RID: 87132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
