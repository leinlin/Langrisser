using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001280 RID: 4736
[Preserve]
public class Lua_BlackJack_ProjectL_Common_StopwatchManager : LuaObject
{
	// Token: 0x06018AB9 RID: 101049 RVA: 0x006F6D34 File Offset: 0x006F4F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			StopwatchManager o = new StopwatchManager();
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

	// Token: 0x06018ABA RID: 101050 RVA: 0x006F6D7C File Offset: 0x006F4F7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Start_s(IntPtr l)
	{
		int result;
		try
		{
			int watchID;
			LuaObject.checkType(l, 1, out watchID);
			StopwatchManager.Start(watchID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ABB RID: 101051 RVA: 0x006F6DC8 File Offset: 0x006F4FC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Stop_s(IntPtr l)
	{
		int result;
		try
		{
			int watchID;
			LuaObject.checkType(l, 1, out watchID);
			string msg;
			LuaObject.checkType(l, 2, out msg);
			StopwatchManager.Stop(watchID, msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ABC RID: 101052 RVA: 0x006F6E20 File Offset: 0x006F5020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogAllMessage_s(IntPtr l)
	{
		int result;
		try
		{
			StopwatchManager.LogAllMessage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ABD RID: 101053 RVA: 0x006F6E60 File Offset: 0x006F5060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Enable_s(IntPtr l)
	{
		int result;
		try
		{
			bool bEnable;
			LuaObject.checkType(l, 1, out bEnable);
			StopwatchManager.Enable(bEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ABE RID: 101054 RVA: 0x006F6EAC File Offset: 0x006F50AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.StopwatchManager");
		if (Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_StopwatchManager.Start_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_StopwatchManager.Stop_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_StopwatchManager.LogAllMessage_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_StopwatchManager.Enable_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_StopwatchManager.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_StopwatchManager.<>f__mg$cache4, typeof(StopwatchManager));
	}

	// Token: 0x0400EF9B RID: 61339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EF9C RID: 61340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EF9D RID: 61341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EF9E RID: 61342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EF9F RID: 61343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
