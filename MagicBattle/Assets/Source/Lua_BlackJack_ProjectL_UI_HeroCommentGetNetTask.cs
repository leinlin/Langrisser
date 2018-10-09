using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014A9 RID: 5289
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroCommentGetNetTask : LuaObject
{
	// Token: 0x0601EA77 RID: 125559 RVA: 0x009EAE90 File Offset: 0x009E9090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroCommentGetNetTask o = new HeroCommentGetNetTask(heroId);
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

	// Token: 0x0601EA78 RID: 125560 RVA: 0x009EAEE4 File Offset: 0x009E90E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroCommentGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroCommentGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroCommentGetNetTask.<>f__mg$cache0, typeof(HeroCommentGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04014B07 RID: 84743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
