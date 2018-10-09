using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200138F RID: 5007
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AutoRemoveEquipmentNetTask : LuaObject
{
	// Token: 0x0601B4C5 RID: 111813 RVA: 0x008407AC File Offset: 0x0083E9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			AutoRemoveEquipmentNetTask o = new AutoRemoveEquipmentNetTask(heroId);
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

	// Token: 0x0601B4C6 RID: 111814 RVA: 0x00840800 File Offset: 0x0083EA00
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AutoRemoveEquipmentNetTask");
		if (Lua_BlackJack_ProjectL_UI_AutoRemoveEquipmentNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AutoRemoveEquipmentNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AutoRemoveEquipmentNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_AutoRemoveEquipmentNetTask.<>f__mg$cache0, typeof(AutoRemoveEquipmentNetTask), typeof(UINetTask));
	}

	// Token: 0x04011789 RID: 71561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
