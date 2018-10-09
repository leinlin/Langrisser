using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011AF RID: 4527
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_Pathfinder_Node : LuaObject
{
	// Token: 0x0601775A RID: 96090 RVA: 0x00667DD0 File Offset: 0x00665FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node o = new Pathfinder.Node();
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

	// Token: 0x0601775B RID: 96091 RVA: 0x00667E18 File Offset: 0x00666018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Reinitialize(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			node.Reinitialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601775C RID: 96092 RVA: 0x00667E64 File Offset: 0x00666064
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_parent(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, node.parent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601775D RID: 96093 RVA: 0x00667EB8 File Offset: 0x006660B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_parent(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			Pathfinder.Node parent;
			LuaObject.checkType<Pathfinder.Node>(l, 2, out parent);
			node.parent = parent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601775E RID: 96094 RVA: 0x00667F10 File Offset: 0x00666110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_child(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, node.child);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601775F RID: 96095 RVA: 0x00667F64 File Offset: 0x00666164
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_child(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			Pathfinder.Node child;
			LuaObject.checkType<Pathfinder.Node>(l, 2, out child);
			node.child = child;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017760 RID: 96096 RVA: 0x00667FBC File Offset: 0x006661BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_g(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, node.g);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017761 RID: 96097 RVA: 0x00668010 File Offset: 0x00666210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_g(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			int g;
			LuaObject.checkType(l, 2, out g);
			node.g = g;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017762 RID: 96098 RVA: 0x00668068 File Offset: 0x00666268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_h(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, node.h);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017763 RID: 96099 RVA: 0x006680BC File Offset: 0x006662BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_h(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			int h;
			LuaObject.checkType(l, 2, out h);
			node.h = h;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017764 RID: 96100 RVA: 0x00668114 File Offset: 0x00666314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_f(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, node.f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017765 RID: 96101 RVA: 0x00668168 File Offset: 0x00666368
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_f(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			int f;
			LuaObject.checkType(l, 2, out f);
			node.f = f;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017766 RID: 96102 RVA: 0x006681C0 File Offset: 0x006663C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_UserState(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, node.m_UserState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017767 RID: 96103 RVA: 0x00668214 File Offset: 0x00666414
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_UserState(IntPtr l)
	{
		int result;
		try
		{
			Pathfinder.Node node = (Pathfinder.Node)LuaObject.checkSelf(l);
			PathNode userState;
			LuaObject.checkType<PathNode>(l, 2, out userState);
			node.m_UserState = userState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017768 RID: 96104 RVA: 0x0066826C File Offset: 0x0066646C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.Pathfinder.Node");
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.Reinitialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache0);
		string name = "parent";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.get_parent);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.set_parent);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache2, true);
		string name2 = "child";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.get_child);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.set_child);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache4, true);
		string name3 = "g";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.get_g);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.set_g);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache6, true);
		string name4 = "h";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.get_h);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.set_h);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache8, true);
		string name5 = "f";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.get_f);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.set_f);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheA, true);
		string name6 = "m_UserState";
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.get_m_UserState);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.set_m_UserState);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheC, true);
		if (Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_Pathfinder_Node.<>f__mg$cacheD, typeof(Pathfinder.Node));
	}

	// Token: 0x0400DDDE RID: 56798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DDDF RID: 56799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DDE0 RID: 56800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DDE1 RID: 56801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DDE2 RID: 56802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DDE3 RID: 56803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DDE4 RID: 56804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DDE5 RID: 56805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DDE6 RID: 56806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DDE7 RID: 56807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DDE8 RID: 56808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DDE9 RID: 56809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DDEA RID: 56810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DDEB RID: 56811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
