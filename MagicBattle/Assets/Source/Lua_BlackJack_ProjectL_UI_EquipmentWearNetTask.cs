using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001430 RID: 5168
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentWearNetTask : LuaObject
{
	// Token: 0x0601DA58 RID: 121432 RVA: 0x0096B8F0 File Offset: 0x00969AF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong instanceId;
			LuaObject.checkType(l, 3, out instanceId);
			EquipmentWearNetTask o = new EquipmentWearNetTask(heroId, instanceId);
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

	// Token: 0x0601DA59 RID: 121433 RVA: 0x0096B950 File Offset: 0x00969B50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentWearNetTask");
		if (Lua_BlackJack_ProjectL_UI_EquipmentWearNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentWearNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentWearNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EquipmentWearNetTask.<>f__mg$cache0, typeof(EquipmentWearNetTask), typeof(UINetTask));
	}

	// Token: 0x04013BDA RID: 80858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
