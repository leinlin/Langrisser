using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014AB RID: 5291
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroCommentPraisedNetTask : LuaObject
{
	// Token: 0x0601EAA7 RID: 125607 RVA: 0x009EC6DC File Offset: 0x009EA8DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong instanceId;
			LuaObject.checkType(l, 3, out instanceId);
			HeroCommentPraisedNetTask o = new HeroCommentPraisedNetTask(heroId, instanceId);
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

	// Token: 0x0601EAA8 RID: 125608 RVA: 0x009EC73C File Offset: 0x009EA93C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroCommentPraisedNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroCommentPraisedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentPraisedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentPraisedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroCommentPraisedNetTask.<>f__mg$cache0, typeof(HeroCommentPraisedNetTask), typeof(UINetTask));
	}

	// Token: 0x04014B33 RID: 84787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
