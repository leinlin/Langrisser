using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200142C RID: 5164
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentLockAndUnLockNetTask : LuaObject
{
	// Token: 0x0601DA34 RID: 121396 RVA: 0x0096A810 File Offset: 0x00968A10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			EquipmentLockAndUnLockNetTask o = new EquipmentLockAndUnLockNetTask(instanceId);
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

	// Token: 0x0601DA35 RID: 121397 RVA: 0x0096A864 File Offset: 0x00968A64
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentLockAndUnLockNetTask");
		if (Lua_BlackJack_ProjectL_UI_EquipmentLockAndUnLockNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentLockAndUnLockNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentLockAndUnLockNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EquipmentLockAndUnLockNetTask.<>f__mg$cache0, typeof(EquipmentLockAndUnLockNetTask), typeof(UINetTask));
	}

	// Token: 0x04013BBE RID: 80830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
