using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014AC RID: 5292
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroCommentSendNetTask : LuaObject
{
	// Token: 0x0601EAAA RID: 125610 RVA: 0x009EC794 File Offset: 0x009EA994
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			string content;
			LuaObject.checkType(l, 3, out content);
			HeroCommentSendNetTask o = new HeroCommentSendNetTask(heroId, content);
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

	// Token: 0x0601EAAB RID: 125611 RVA: 0x009EC7F4 File Offset: 0x009EA9F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroCommentSendNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroCommentSendNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentSendNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentSendNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroCommentSendNetTask.<>f__mg$cache0, typeof(HeroCommentSendNetTask), typeof(UINetTask));
	}

	// Token: 0x04014B34 RID: 84788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
