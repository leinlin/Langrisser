using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200153C RID: 5436
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister : LuaObject
{
	// Token: 0x06020748 RID: 132936 RVA: 0x00AD0C04 File Offset: 0x00ACEE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ProjectLUITaskRegister o = new ProjectLUITaskRegister();
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

	// Token: 0x06020749 RID: 132937 RVA: 0x00AD0C4C File Offset: 0x00ACEE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterUITasksForLowMem(IntPtr l)
	{
		int result;
		try
		{
			ProjectLUITaskRegister projectLUITaskRegister = (ProjectLUITaskRegister)LuaObject.checkSelf(l);
			projectLUITaskRegister.m_luaExportHelper.RegisterUITasksForLowMem();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602074A RID: 132938 RVA: 0x00AD0CA0 File Offset: 0x00ACEEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterUITasksNormal(IntPtr l)
	{
		int result;
		try
		{
			ProjectLUITaskRegister projectLUITaskRegister = (ProjectLUITaskRegister)LuaObject.checkSelf(l);
			projectLUITaskRegister.m_luaExportHelper.RegisterUITasksNormal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602074B RID: 132939 RVA: 0x00AD0CF4 File Offset: 0x00ACEEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterUITask_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string), typeof(UIGroup4LowMem)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				UIGroup4LowMem group;
				LuaObject.checkEnum<UIGroup4LowMem>(l, 2, out group);
				ProjectLUITaskRegister.LuaExportHelper.RegisterUITask(name, group);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(UIGroup)))
			{
				string name2;
				LuaObject.checkType(l, 1, out name2);
				UIGroup group2;
				LuaObject.checkEnum<UIGroup>(l, 2, out group2);
				ProjectLUITaskRegister.LuaExportHelper.RegisterUITask(name2, group2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RegisterUITask to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602074C RID: 132940 RVA: 0x00AD0DD8 File Offset: 0x00ACEFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUITaskGroupConflict_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(UIGroup4LowMem), typeof(UIGroup4LowMem)))
			{
				UIGroup4LowMem group;
				LuaObject.checkEnum<UIGroup4LowMem>(l, 1, out group);
				UIGroup4LowMem group2;
				LuaObject.checkEnum<UIGroup4LowMem>(l, 2, out group2);
				ProjectLUITaskRegister.LuaExportHelper.SetUITaskGroupConflict(group, group2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(UIGroup), typeof(UIGroup)))
			{
				UIGroup group3;
				LuaObject.checkEnum<UIGroup>(l, 1, out group3);
				UIGroup group4;
				LuaObject.checkEnum<UIGroup>(l, 2, out group4);
				ProjectLUITaskRegister.LuaExportHelper.SetUITaskGroupConflict(group3, group4);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetUITaskGroupConflict to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602074D RID: 132941 RVA: 0x00AD0EBC File Offset: 0x00ACF0BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ProjectLUITaskRegister");
		if (Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.RegisterUITasksForLowMem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.RegisterUITasksNormal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.RegisterUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.SetUITaskGroupConflict_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ProjectLUITaskRegister.<>f__mg$cache4, typeof(ProjectLUITaskRegister));
	}

	// Token: 0x040166B2 RID: 91826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040166B3 RID: 91827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040166B4 RID: 91828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040166B5 RID: 91829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040166B6 RID: 91830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
