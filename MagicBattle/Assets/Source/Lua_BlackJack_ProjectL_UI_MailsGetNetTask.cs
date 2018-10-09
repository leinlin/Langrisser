using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001506 RID: 5382
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MailsGetNetTask : LuaObject
{
	// Token: 0x0601FDEB RID: 130539 RVA: 0x00A86134 File Offset: 0x00A84334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MailsGetNetTask o = new MailsGetNetTask();
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

	// Token: 0x0601FDEC RID: 130540 RVA: 0x00A8617C File Offset: 0x00A8437C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MailsGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_MailsGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailsGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailsGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MailsGetNetTask.<>f__mg$cache0, typeof(MailsGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04015DC1 RID: 89537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
