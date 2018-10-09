using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014CC RID: 5324
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroJobTransferNetTask : LuaObject
{
	// Token: 0x0601F274 RID: 127604 RVA: 0x00A2B160 File Offset: 0x00A29360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobConnectionId;
			LuaObject.checkType(l, 3, out jobConnectionId);
			HeroJobTransferNetTask o = new HeroJobTransferNetTask(heroId, jobConnectionId);
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

	// Token: 0x0601F275 RID: 127605 RVA: 0x00A2B1C0 File Offset: 0x00A293C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroJobTransferNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferNetTask.<>f__mg$cache0, typeof(HeroJobTransferNetTask), typeof(UINetTask));
	}

	// Token: 0x040152BE RID: 86718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
