using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001596 RID: 5526
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomCreateNetTask : LuaObject
{
	// Token: 0x0602169B RID: 136859 RVA: 0x00B4B770 File Offset: 0x00B49970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomSetting setting;
			LuaObject.checkType<TeamRoomSetting>(l, 2, out setting);
			TeamRoomCreateNetTask o = new TeamRoomCreateNetTask(setting);
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

	// Token: 0x0602169C RID: 136860 RVA: 0x00B4B7C4 File Offset: 0x00B499C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomCreateNetTask");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomCreateNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomCreateNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomCreateNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomCreateNetTask.<>f__mg$cache0, typeof(TeamRoomCreateNetTask), typeof(UINetTask));
	}

	// Token: 0x04017551 RID: 95569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
