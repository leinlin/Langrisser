using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015AA RID: 5546
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TechLevelupNetTask : LuaObject
{
	// Token: 0x060219D0 RID: 137680 RVA: 0x00B64D2C File Offset: 0x00B62F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int techId;
			LuaObject.checkType(l, 2, out techId);
			TechLevelupNetTask o = new TechLevelupNetTask(techId);
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

	// Token: 0x060219D1 RID: 137681 RVA: 0x00B64D80 File Offset: 0x00B62F80
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TechLevelupNetTask");
		if (Lua_BlackJack_ProjectL_UI_TechLevelupNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TechLevelupNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TechLevelupNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TechLevelupNetTask.<>f__mg$cache0, typeof(TechLevelupNetTask), typeof(UINetTask));
	}

	// Token: 0x0401785E RID: 96350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
