using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015D0 RID: 5584
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnixTimeStamp : LuaObject
{
	// Token: 0x060220A8 RID: 139432 RVA: 0x00B9AF34 File Offset: 0x00B99134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UnixTimeStamp o = new UnixTimeStamp();
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

	// Token: 0x060220A9 RID: 139433 RVA: 0x00B9AF7C File Offset: 0x00B9917C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int From_s(IntPtr l)
	{
		int result;
		try
		{
			DateTime t;
			LuaObject.checkValueType<DateTime>(l, 1, out t);
			long i = UnixTimeStamp.From(t);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220AA RID: 139434 RVA: 0x00B9AFD0 File Offset: 0x00B991D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_originTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnixTimeStamp.LuaExportHelper.originTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220AB RID: 139435 RVA: 0x00B9B01C File Offset: 0x00B9921C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_originTime(IntPtr l)
	{
		int result;
		try
		{
			DateTime originTime;
			LuaObject.checkValueType<DateTime>(l, 2, out originTime);
			UnixTimeStamp.LuaExportHelper.originTime = originTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220AC RID: 139436 RVA: 0x00B9B068 File Offset: 0x00B99268
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnixTimeStamp");
		if (Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnixTimeStamp.From_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache0);
		string name = "originTime";
		if (Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnixTimeStamp.get_originTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnixTimeStamp.set_originTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache2, false);
		if (Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnixTimeStamp.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UnixTimeStamp.<>f__mg$cache3, typeof(UnixTimeStamp));
	}

	// Token: 0x04017EEA RID: 98026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017EEB RID: 98027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017EEC RID: 98028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017EED RID: 98029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
