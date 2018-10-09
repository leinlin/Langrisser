using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014C6 RID: 5318
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroInteractNetTask : LuaObject
{
	// Token: 0x0601F1BA RID: 127418 RVA: 0x00A251F0 File Offset: 0x00A233F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroInteractNetTask o = new HeroInteractNetTask(heroId);
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

	// Token: 0x0601F1BB RID: 127419 RVA: 0x00A25244 File Offset: 0x00A23444
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroPerformanceId(IntPtr l)
	{
		int result;
		try
		{
			HeroInteractNetTask heroInteractNetTask = (HeroInteractNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroInteractNetTask.HeroPerformanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1BC RID: 127420 RVA: 0x00A25298 File Offset: 0x00A23498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_InteractResult(IntPtr l)
	{
		int result;
		try
		{
			HeroInteractNetTask heroInteractNetTask = (HeroInteractNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)heroInteractNetTask.InteractResult);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1BD RID: 127421 RVA: 0x00A252EC File Offset: 0x00A234EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			HeroInteractNetTask heroInteractNetTask = (HeroInteractNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroInteractNetTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1BE RID: 127422 RVA: 0x00A25340 File Offset: 0x00A23540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AddFavoribilityExp(IntPtr l)
	{
		int result;
		try
		{
			HeroInteractNetTask heroInteractNetTask = (HeroInteractNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroInteractNetTask.AddFavoribilityExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1BF RID: 127423 RVA: 0x00A25394 File Offset: 0x00A23594
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroInteractNetTask");
		string name = "HeroPerformanceId";
		if (Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.get_HeroPerformanceId);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache0, null, true);
		string name2 = "InteractResult";
		if (Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.get_InteractResult);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache1, null, true);
		string name3 = "Rewards";
		if (Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.get_Rewards);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache2, null, true);
		string name4 = "AddFavoribilityExp";
		if (Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.get_AddFavoribilityExp);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache3, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroInteractNetTask.<>f__mg$cache4, typeof(HeroInteractNetTask), typeof(UINetTask));
	}

	// Token: 0x04015210 RID: 86544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015211 RID: 86545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015212 RID: 86546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015213 RID: 86547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015214 RID: 86548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
