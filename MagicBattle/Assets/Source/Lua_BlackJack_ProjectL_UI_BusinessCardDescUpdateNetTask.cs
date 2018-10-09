using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013D4 RID: 5076
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardDescUpdateNetTask : LuaObject
{
	// Token: 0x0601C651 RID: 116305 RVA: 0x008CC548 File Offset: 0x008CA748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string desc;
			LuaObject.checkType(l, 2, out desc);
			BusinessCardDescUpdateNetTask o = new BusinessCardDescUpdateNetTask(desc);
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

	// Token: 0x0601C652 RID: 116306 RVA: 0x008CC59C File Offset: 0x008CA79C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardDescUpdateNetTask");
		if (Lua_BlackJack_ProjectL_UI_BusinessCardDescUpdateNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardDescUpdateNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardDescUpdateNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BusinessCardDescUpdateNetTask.<>f__mg$cache0, typeof(BusinessCardDescUpdateNetTask), typeof(UINetTask));
	}

	// Token: 0x0401288B RID: 75915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
