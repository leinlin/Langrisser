using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013E3 RID: 5091
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChangeHeadPortraitAndHeadFrameNetTask : LuaObject
{
	// Token: 0x0601C8DE RID: 116958 RVA: 0x008E075C File Offset: 0x008DE95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			int headFrameId;
			LuaObject.checkType(l, 3, out headFrameId);
			ChangeHeadPortraitAndHeadFrameNetTask o = new ChangeHeadPortraitAndHeadFrameNetTask(headPortraitId, headFrameId);
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

	// Token: 0x0601C8DF RID: 116959 RVA: 0x008E07BC File Offset: 0x008DE9BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChangeHeadPortraitAndHeadFrameNetTask");
		if (Lua_BlackJack_ProjectL_UI_ChangeHeadPortraitAndHeadFrameNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChangeHeadPortraitAndHeadFrameNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChangeHeadPortraitAndHeadFrameNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ChangeHeadPortraitAndHeadFrameNetTask.<>f__mg$cache0, typeof(ChangeHeadPortraitAndHeadFrameNetTask), typeof(UINetTask));
	}

	// Token: 0x04012AFA RID: 76538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
