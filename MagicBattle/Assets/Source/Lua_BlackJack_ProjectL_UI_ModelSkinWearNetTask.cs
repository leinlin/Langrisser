using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001514 RID: 5396
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ModelSkinWearNetTask : LuaObject
{
	// Token: 0x0601FFDE RID: 131038 RVA: 0x00A958D0 File Offset: 0x00A93AD0
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
			int modelSkinId;
			LuaObject.checkType(l, 4, out modelSkinId);
			ModelSkinWearNetTask o = new ModelSkinWearNetTask(heroId, jobRelatedId, modelSkinId);
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

	// Token: 0x0601FFDF RID: 131039 RVA: 0x00A95940 File Offset: 0x00A93B40
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ModelSkinWearNetTask");
		if (Lua_BlackJack_ProjectL_UI_ModelSkinWearNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ModelSkinWearNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ModelSkinWearNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ModelSkinWearNetTask.<>f__mg$cache0, typeof(ModelSkinWearNetTask), typeof(UINetTask));
	}

	// Token: 0x04015F98 RID: 90008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
