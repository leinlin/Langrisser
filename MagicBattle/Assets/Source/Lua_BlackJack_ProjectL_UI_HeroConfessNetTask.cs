using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014B0 RID: 5296
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroConfessNetTask : LuaObject
{
	// Token: 0x0601EBE1 RID: 125921 RVA: 0x009F6144 File Offset: 0x009F4344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroConfessNetTask o = new HeroConfessNetTask(heroId);
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

	// Token: 0x0601EBE2 RID: 125922 RVA: 0x009F6198 File Offset: 0x009F4398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			HeroConfessNetTask heroConfessNetTask = (HeroConfessNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroConfessNetTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EBE3 RID: 125923 RVA: 0x009F61EC File Offset: 0x009F43EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroConfessNetTask");
		string name = "Rewards";
		if (Lua_BlackJack_ProjectL_UI_HeroConfessNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroConfessNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroConfessNetTask.get_Rewards);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_HeroConfessNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroConfessNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroConfessNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroConfessNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroConfessNetTask.<>f__mg$cache1, typeof(HeroConfessNetTask), typeof(UINetTask));
	}

	// Token: 0x04014C63 RID: 85091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014C64 RID: 85092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
