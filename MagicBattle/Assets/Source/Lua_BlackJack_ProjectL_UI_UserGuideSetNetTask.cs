using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015D5 RID: 5589
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UserGuideSetNetTask : LuaObject
{
	// Token: 0x06022152 RID: 139602 RVA: 0x00BA02B8 File Offset: 0x00B9E4B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int step;
			LuaObject.checkType(l, 2, out step);
			UserGuideSetNetTask o = new UserGuideSetNetTask(step);
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

	// Token: 0x06022153 RID: 139603 RVA: 0x00BA030C File Offset: 0x00B9E50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUserGuideSetNetTask_s(IntPtr l)
	{
		int result;
		try
		{
			int step;
			LuaObject.checkType(l, 1, out step);
			UserGuideSetNetTask o = UserGuideSetNetTask.StartUserGuideSetNetTask(step);
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

	// Token: 0x06022154 RID: 139604 RVA: 0x00BA0360 File Offset: 0x00B9E560
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UserGuideSetNetTask");
		if (Lua_BlackJack_ProjectL_UI_UserGuideSetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideSetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideSetNetTask.StartUserGuideSetNetTask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideSetNetTask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UserGuideSetNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideSetNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideSetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UserGuideSetNetTask.<>f__mg$cache1, typeof(UserGuideSetNetTask), typeof(UINetTask));
	}

	// Token: 0x04017F8A RID: 98186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017F8B RID: 98187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
