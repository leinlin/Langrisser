using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001429 RID: 5161
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentEnhanceNetTask : LuaObject
{
	// Token: 0x0601D780 RID: 120704 RVA: 0x009551A0 File Offset: 0x009533A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			List<ulong> materialIds;
			LuaObject.checkType<List<ulong>>(l, 3, out materialIds);
			EquipmentEnhanceNetTask o = new EquipmentEnhanceNetTask(instanceId, materialIds);
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

	// Token: 0x0601D781 RID: 120705 RVA: 0x00955200 File Offset: 0x00953400
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentEnhanceNetTask");
		if (Lua_BlackJack_ProjectL_UI_EquipmentEnhanceNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentEnhanceNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentEnhanceNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EquipmentEnhanceNetTask.<>f__mg$cache0, typeof(EquipmentEnhanceNetTask), typeof(UINetTask));
	}

	// Token: 0x04013910 RID: 80144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
