using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013E7 RID: 5095
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChatEnterRoomNetTask : LuaObject
{
	// Token: 0x0601C8EA RID: 116970 RVA: 0x008E0A24 File Offset: 0x008DEC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			ChatEnterRoomNetTask o = new ChatEnterRoomNetTask(roomId);
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

	// Token: 0x0601C8EB RID: 116971 RVA: 0x008E0A78 File Offset: 0x008DEC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ResultRoomId(IntPtr l)
	{
		int result;
		try
		{
			ChatEnterRoomNetTask chatEnterRoomNetTask = (ChatEnterRoomNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatEnterRoomNetTask.ResultRoomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8EC RID: 116972 RVA: 0x008E0ACC File Offset: 0x008DECCC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChatEnterRoomNetTask");
		string name = "ResultRoomId";
		if (Lua_BlackJack_ProjectL_UI_ChatEnterRoomNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatEnterRoomNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatEnterRoomNetTask.get_ResultRoomId);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_ChatEnterRoomNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_ChatEnterRoomNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatEnterRoomNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatEnterRoomNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ChatEnterRoomNetTask.<>f__mg$cache1, typeof(ChatEnterRoomNetTask), typeof(UINetTask));
	}

	// Token: 0x04012AFE RID: 76542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012AFF RID: 76543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
