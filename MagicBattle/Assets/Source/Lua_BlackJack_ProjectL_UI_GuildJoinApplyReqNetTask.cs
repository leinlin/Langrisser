using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200147D RID: 5245
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildJoinApplyReqNetTask : LuaObject
{
	// Token: 0x0601E4DB RID: 124123 RVA: 0x009BEF8C File Offset: 0x009BD18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string guildID;
			LuaObject.checkType(l, 2, out guildID);
			GuildJoinApplyReqNetTask o = new GuildJoinApplyReqNetTask(guildID);
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

	// Token: 0x0601E4DC RID: 124124 RVA: 0x009BEFE0 File Offset: 0x009BD1E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildJoinApplyReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildJoinApplyReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinApplyReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinApplyReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildJoinApplyReqNetTask.<>f__mg$cache0, typeof(GuildJoinApplyReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145C3 RID: 83395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
