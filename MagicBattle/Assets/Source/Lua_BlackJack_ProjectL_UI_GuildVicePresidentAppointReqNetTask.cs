using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200149C RID: 5276
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildVicePresidentAppointReqNetTask : LuaObject
{
	// Token: 0x0601E8AF RID: 125103 RVA: 0x009DCDAC File Offset: 0x009DAFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool appoint;
			LuaObject.checkType(l, 3, out appoint);
			GuildVicePresidentAppointReqNetTask o = new GuildVicePresidentAppointReqNetTask(userId, appoint);
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

	// Token: 0x0601E8B0 RID: 125104 RVA: 0x009DCE0C File Offset: 0x009DB00C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildVicePresidentAppointReqNetTask");
		if (Lua_BlackJack_ProjectL_UI_GuildVicePresidentAppointReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildVicePresidentAppointReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildVicePresidentAppointReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildVicePresidentAppointReqNetTask.<>f__mg$cache0, typeof(GuildVicePresidentAppointReqNetTask), typeof(UINetTask));
	}

	// Token: 0x04014959 RID: 84313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
