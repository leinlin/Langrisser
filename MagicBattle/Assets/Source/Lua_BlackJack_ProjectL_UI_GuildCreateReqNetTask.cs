using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001470 RID: 5232
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildCreateReqNetTask : LuaObject
{
	// Token: 0x0601E3ED RID: 123885 RVA: 0x009B7C90 File Offset: 0x009B5E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string guildName;
			LuaObject.checkType(l, 2, out guildName);
			string hiringDeclaration;
			LuaObject.checkType(l, 3, out hiringDeclaration);
			string announcement;
			LuaObject.checkType(l, 4, out announcement);
			bool autoJoin;
			LuaObject.checkType(l, 5, out autoJoin);
			int joinLevel;
			LuaObject.checkType(l, 6, out joinLevel);
			GuildCreateReqNetTask o = new GuildCreateReqNetTask(guildName, hiringDeclaration, announcement, autoJoin, joinLevel);
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

	// Token: 0x0601E3EE RID: 123886 RVA: 0x009B7D18 File Offset: 0x009B5F18
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildCreateReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildCreateReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildCreateReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildCreateReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildCreateReqNetTask.<>f__mg$cache0, typeof(GuildCreateReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040144EF RID: 83183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
