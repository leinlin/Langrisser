using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013E8 RID: 5096
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChatExpressionMessageSendNetTask : LuaObject
{
	// Token: 0x0601C8EE RID: 116974 RVA: 0x008E0B50 File Offset: 0x008DED50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			string content;
			LuaObject.checkType(l, 3, out content);
			ChatExpressionMessageSendNetTask o = new ChatExpressionMessageSendNetTask(channel, content);
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

	// Token: 0x0601C8EF RID: 116975 RVA: 0x008E0BB0 File Offset: 0x008DEDB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChatExpressionMessageSendNetTask");
		if (Lua_BlackJack_ProjectL_UI_ChatExpressionMessageSendNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatExpressionMessageSendNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatExpressionMessageSendNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ChatExpressionMessageSendNetTask.<>f__mg$cache0, typeof(ChatExpressionMessageSendNetTask), typeof(UINetTask));
	}

	// Token: 0x04012B00 RID: 76544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
