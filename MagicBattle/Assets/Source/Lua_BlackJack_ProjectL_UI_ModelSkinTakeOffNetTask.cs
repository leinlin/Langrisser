using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001513 RID: 5395
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ModelSkinTakeOffNetTask : LuaObject
{
	// Token: 0x0601FFDB RID: 131035 RVA: 0x00A95818 File Offset: 0x00A93A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			ModelSkinTakeOffNetTask o = new ModelSkinTakeOffNetTask(heroId, jobRelatedId);
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

	// Token: 0x0601FFDC RID: 131036 RVA: 0x00A95878 File Offset: 0x00A93A78
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ModelSkinTakeOffNetTask");
		if (Lua_BlackJack_ProjectL_UI_ModelSkinTakeOffNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ModelSkinTakeOffNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ModelSkinTakeOffNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ModelSkinTakeOffNetTask.<>f__mg$cache0, typeof(ModelSkinTakeOffNetTask), typeof(UINetTask));
	}

	// Token: 0x04015F97 RID: 90007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
