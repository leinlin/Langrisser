using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014D7 RID: 5335
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroPhantomLevelAttackNetTask : LuaObject
{
	// Token: 0x0601F62F RID: 128559 RVA: 0x00A48D28 File Offset: 0x00A46F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelID;
			LuaObject.checkType(l, 2, out levelID);
			HeroPhantomLevelAttackNetTask o = new HeroPhantomLevelAttackNetTask(levelID);
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

	// Token: 0x0601F630 RID: 128560 RVA: 0x00A48D7C File Offset: 0x00A46F7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroPhantomLevelAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelAttackNetTask.<>f__mg$cache0, typeof(HeroPhantomLevelAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x04015663 RID: 87651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
