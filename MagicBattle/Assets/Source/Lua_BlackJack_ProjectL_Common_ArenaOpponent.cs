using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011BC RID: 4540
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaOpponent : LuaObject
{
	// Token: 0x0601785E RID: 96350 RVA: 0x0066F478 File Offset: 0x0066D678
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent o = new ArenaOpponent();
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

	// Token: 0x0601785F RID: 96351 RVA: 0x0066F4C0 File Offset: 0x0066D6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArenaOpponentToPBArenaOpponent_s(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent;
			LuaObject.checkType<ArenaOpponent>(l, 1, out arenaOpponent);
			ProArenaOpponent o = ArenaOpponent.ArenaOpponentToPBArenaOpponent(arenaOpponent);
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

	// Token: 0x06017860 RID: 96352 RVA: 0x0066F514 File Offset: 0x0066D714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBArenaOpponentToArenaOpponent_s(IntPtr l)
	{
		int result;
		try
		{
			ProArenaOpponent pbArenaOpponent;
			LuaObject.checkType<ProArenaOpponent>(l, 1, out pbArenaOpponent);
			ArenaOpponent o = ArenaOpponent.PBArenaOpponentToArenaOpponent(pbArenaOpponent);
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

	// Token: 0x06017861 RID: 96353 RVA: 0x0066F568 File Offset: 0x0066D768
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent = (ArenaOpponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponent.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017862 RID: 96354 RVA: 0x0066F5BC File Offset: 0x0066D7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent = (ArenaOpponent)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			arenaOpponent.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017863 RID: 96355 RVA: 0x0066F614 File Offset: 0x0066D814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent = (ArenaOpponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponent.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017864 RID: 96356 RVA: 0x0066F668 File Offset: 0x0066D868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent = (ArenaOpponent)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			arenaOpponent.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017865 RID: 96357 RVA: 0x0066F6C0 File Offset: 0x0066D8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent = (ArenaOpponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponent.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017866 RID: 96358 RVA: 0x0066F714 File Offset: 0x0066D914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent = (ArenaOpponent)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			arenaOpponent.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017867 RID: 96359 RVA: 0x0066F76C File Offset: 0x0066D96C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent = (ArenaOpponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponent.ArenaPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017868 RID: 96360 RVA: 0x0066F7C0 File Offset: 0x0066D9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent = (ArenaOpponent)LuaObject.checkSelf(l);
			ushort arenaPoints;
			LuaObject.checkType(l, 2, out arenaPoints);
			arenaOpponent.ArenaPoints = arenaPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017869 RID: 96361 RVA: 0x0066F818 File Offset: 0x0066DA18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent = (ArenaOpponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaOpponent.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601786A RID: 96362 RVA: 0x0066F86C File Offset: 0x0066DA6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			ArenaOpponent arenaOpponent = (ArenaOpponent)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			arenaOpponent.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601786B RID: 96363 RVA: 0x0066F8C4 File Offset: 0x0066DAC4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaOpponent");
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.ArenaOpponentToPBArenaOpponent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.PBArenaOpponentToArenaOpponent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache1);
		string name = "UserId";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.get_UserId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.set_UserId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache3, true);
		string name2 = "Name";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.get_Name);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.set_Name);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache5, true);
		string name3 = "Level";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.get_Level);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.set_Level);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache7, true);
		string name4 = "ArenaPoints";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.get_ArenaPoints);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.set_ArenaPoints);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cache9, true);
		string name5 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.get_HeadIcon);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.set_HeadIcon);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaOpponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaOpponent.<>f__mg$cacheC, typeof(ArenaOpponent));
	}

	// Token: 0x0400DEC8 RID: 57032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DEC9 RID: 57033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DECA RID: 57034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DECB RID: 57035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DECC RID: 57036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DECD RID: 57037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DECE RID: 57038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DECF RID: 57039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DED0 RID: 57040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DED1 RID: 57041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DED2 RID: 57042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DED3 RID: 57043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DED4 RID: 57044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
