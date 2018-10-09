using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001457 RID: 5207
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendSuggestedNetTask : LuaObject
{
	// Token: 0x0601DF91 RID: 122769 RVA: 0x009950CC File Offset: 0x009932CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FriendSuggestedNetTask o = new FriendSuggestedNetTask();
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

	// Token: 0x0601DF92 RID: 122770 RVA: 0x00995114 File Offset: 0x00993314
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendSuggestedNetTask");
		if (Lua_BlackJack_ProjectL_UI_FriendSuggestedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSuggestedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSuggestedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendSuggestedNetTask.<>f__mg$cache0, typeof(FriendSuggestedNetTask), typeof(UINetTask));
	}

	// Token: 0x040140C5 RID: 82117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
