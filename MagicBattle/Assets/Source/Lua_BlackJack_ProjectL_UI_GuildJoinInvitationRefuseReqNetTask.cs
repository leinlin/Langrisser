using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001480 RID: 5248
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildJoinInvitationRefuseReqNetTask : LuaObject
{
	// Token: 0x0601E4F1 RID: 124145 RVA: 0x009BF794 File Offset: 0x009BD994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string guildID;
			LuaObject.checkType(l, 2, out guildID);
			GuildJoinInvitationRefuseReqNetTask o = new GuildJoinInvitationRefuseReqNetTask(guildID);
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

	// Token: 0x0601E4F2 RID: 124146 RVA: 0x009BF7E8 File Offset: 0x009BD9E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildJoinInvitationRefuseReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildJoinInvitationRefuseReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildJoinInvitationRefuseReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildJoinInvitationRefuseReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildJoinInvitationRefuseReqNetTask.<>f__mg$cache0, typeof(GuildJoinInvitationRefuseReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040145D3 RID: 83411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
