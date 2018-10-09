using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014C9 RID: 5321
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroJobLevelUpNetTask : LuaObject
{
	// Token: 0x0601F228 RID: 127528 RVA: 0x00A28A3C File Offset: 0x00A26C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int id;
			LuaObject.checkType(l, 2, out id);
			int jobConnectionId;
			LuaObject.checkType(l, 3, out jobConnectionId);
			HeroJobLevelUpNetTask o = new HeroJobLevelUpNetTask(id, jobConnectionId);
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

	// Token: 0x0601F229 RID: 127529 RVA: 0x00A28A9C File Offset: 0x00A26C9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroJobLevelUpNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroJobLevelUpNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobLevelUpNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobLevelUpNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroJobLevelUpNetTask.<>f__mg$cache0, typeof(HeroJobLevelUpNetTask), typeof(UINetTask));
	}

	// Token: 0x04015278 RID: 86648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
