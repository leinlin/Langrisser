using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015C5 RID: 5573
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelAttackNetTask : LuaObject
{
	// Token: 0x06021EE1 RID: 138977 RVA: 0x00B8CD2C File Offset: 0x00B8AF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			UnchartedScoreChallengeLevelAttackNetTask o = new UnchartedScoreChallengeLevelAttackNetTask(unchartedScoreId, levelId);
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

	// Token: 0x06021EE2 RID: 138978 RVA: 0x00B8CD8C File Offset: 0x00B8AF8C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedScoreChallengeLevelAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreChallengeLevelAttackNetTask.<>f__mg$cache0, typeof(UnchartedScoreChallengeLevelAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x04017D39 RID: 97593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
