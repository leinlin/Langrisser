using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015CA RID: 5578
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelAttackNetTask : LuaObject
{
	// Token: 0x06021F50 RID: 139088 RVA: 0x00B90634 File Offset: 0x00B8E834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			int levelId;
			LuaObject.checkType(l, 3, out levelId);
			UnchartedScoreScoreLevelAttackNetTask o = new UnchartedScoreScoreLevelAttackNetTask(unchartedScoreId, levelId);
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

	// Token: 0x06021F51 RID: 139089 RVA: 0x00B90694 File Offset: 0x00B8E894
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedScoreScoreLevelAttackNetTask");
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelAttackNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelAttackNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelAttackNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreScoreLevelAttackNetTask.<>f__mg$cache0, typeof(UnchartedScoreScoreLevelAttackNetTask), typeof(UINetTask));
	}

	// Token: 0x04017D9E RID: 97694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
