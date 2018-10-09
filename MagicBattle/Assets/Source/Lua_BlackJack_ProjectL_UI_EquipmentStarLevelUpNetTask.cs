using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200142E RID: 5166
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentStarLevelUpNetTask : LuaObject
{
	// Token: 0x0601DA52 RID: 121426 RVA: 0x0096B780 File Offset: 0x00969980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			ulong materialId;
			LuaObject.checkType(l, 3, out materialId);
			EquipmentStarLevelUpNetTask o = new EquipmentStarLevelUpNetTask(instanceId, materialId);
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

	// Token: 0x0601DA53 RID: 121427 RVA: 0x0096B7E0 File Offset: 0x009699E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentStarLevelUpNetTask");
		if (Lua_BlackJack_ProjectL_UI_EquipmentStarLevelUpNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentStarLevelUpNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentStarLevelUpNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EquipmentStarLevelUpNetTask.<>f__mg$cache0, typeof(EquipmentStarLevelUpNetTask), typeof(UINetTask));
	}

	// Token: 0x04013BD8 RID: 80856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
