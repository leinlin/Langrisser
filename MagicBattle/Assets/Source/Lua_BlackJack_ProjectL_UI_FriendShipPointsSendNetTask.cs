using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001455 RID: 5205
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendShipPointsSendNetTask : LuaObject
{
	// Token: 0x0601DF34 RID: 122676 RVA: 0x009921C8 File Offset: 0x009903C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<string> userIDList;
			LuaObject.checkType<List<string>>(l, 2, out userIDList);
			FriendShipPointsSendNetTask o = new FriendShipPointsSendNetTask(userIDList);
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

	// Token: 0x0601DF35 RID: 122677 RVA: 0x0099221C File Offset: 0x0099041C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendShipPointsSendNetTask");
		if (Lua_BlackJack_ProjectL_UI_FriendShipPointsSendNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendShipPointsSendNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendShipPointsSendNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FriendShipPointsSendNetTask.<>f__mg$cache0, typeof(FriendShipPointsSendNetTask), typeof(UINetTask));
	}

	// Token: 0x0401406C RID: 82028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
