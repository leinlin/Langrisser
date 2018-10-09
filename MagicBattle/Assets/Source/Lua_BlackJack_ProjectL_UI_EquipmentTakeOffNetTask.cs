using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200142F RID: 5167
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentTakeOffNetTask : LuaObject
{
	// Token: 0x0601DA55 RID: 121429 RVA: 0x0096B838 File Offset: 0x00969A38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			EquipmentTakeOffNetTask o = new EquipmentTakeOffNetTask(heroId, slot);
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

	// Token: 0x0601DA56 RID: 121430 RVA: 0x0096B898 File Offset: 0x00969A98
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentTakeOffNetTask");
		if (Lua_BlackJack_ProjectL_UI_EquipmentTakeOffNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentTakeOffNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentTakeOffNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EquipmentTakeOffNetTask.<>f__mg$cache0, typeof(EquipmentTakeOffNetTask), typeof(UINetTask));
	}

	// Token: 0x04013BD9 RID: 80857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
