using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001563 RID: 5475
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftLevelAttackNetTask : LuaObject
{
	// Token: 0x06020C76 RID: 134262 RVA: 0x00AFA084 File Offset: 0x00AF8284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			RiftLevelAttackNetTask o = new RiftLevelAttackNetTask(levelId);
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

	// Token: 0x06020C77 RID: 134263 RVA: 0x00AFA0D8 File Offset: 0x00AF82D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftLevelAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_RiftLevelAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RiftLevelAttackNetTask.<>f__mg$cache0, typeof(RiftLevelAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x04016B92 RID: 93074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
