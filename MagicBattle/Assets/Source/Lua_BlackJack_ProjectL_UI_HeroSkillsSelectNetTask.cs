using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014E1 RID: 5345
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroSkillsSelectNetTask : LuaObject
{
	// Token: 0x0601F7C1 RID: 128961 RVA: 0x00A558D4 File Offset: 0x00A53AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			List<int> skillsId;
			LuaObject.checkType<List<int>>(l, 3, out skillsId);
			HeroSkillsSelectNetTask o = new HeroSkillsSelectNetTask(heroId, skillsId);
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

	// Token: 0x0601F7C2 RID: 128962 RVA: 0x00A55934 File Offset: 0x00A53B34
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroSkillsSelectNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroSkillsSelectNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillsSelectNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillsSelectNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroSkillsSelectNetTask.<>f__mg$cache0, typeof(HeroSkillsSelectNetTask), typeof(UINetTask));
	}

	// Token: 0x040157E1 RID: 88033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
