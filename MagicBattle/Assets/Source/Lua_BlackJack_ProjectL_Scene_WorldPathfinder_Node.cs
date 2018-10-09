using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200134D RID: 4941
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node : LuaObject
{
	// Token: 0x0601A8C2 RID: 108738 RVA: 0x007E0E58 File Offset: 0x007DF058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node o = new WorldPathfinder.Node();
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

	// Token: 0x0601A8C3 RID: 108739 RVA: 0x007E0EA0 File Offset: 0x007DF0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Reinitialize(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
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

	// Token: 0x0601A8C4 RID: 108740 RVA: 0x007E0EEC File Offset: 0x007DF0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_parent(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
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

	// Token: 0x0601A8C5 RID: 108741 RVA: 0x007E0F40 File Offset: 0x007DF140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_parent(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
			WorldPathfinder.Node parent;
			LuaObject.checkType<WorldPathfinder.Node>(l, 2, out parent);
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

	// Token: 0x0601A8C6 RID: 108742 RVA: 0x007E0F98 File Offset: 0x007DF198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_child(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
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

	// Token: 0x0601A8C7 RID: 108743 RVA: 0x007E0FEC File Offset: 0x007DF1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_child(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
			WorldPathfinder.Node child;
			LuaObject.checkType<WorldPathfinder.Node>(l, 2, out child);
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

	// Token: 0x0601A8C8 RID: 108744 RVA: 0x007E1044 File Offset: 0x007DF244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_g(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
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

	// Token: 0x0601A8C9 RID: 108745 RVA: 0x007E1098 File Offset: 0x007DF298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_g(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
			float g;
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

	// Token: 0x0601A8CA RID: 108746 RVA: 0x007E10F0 File Offset: 0x007DF2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_h(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
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

	// Token: 0x0601A8CB RID: 108747 RVA: 0x007E1144 File Offset: 0x007DF344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_h(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
			float h;
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

	// Token: 0x0601A8CC RID: 108748 RVA: 0x007E119C File Offset: 0x007DF39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_f(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
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

	// Token: 0x0601A8CD RID: 108749 RVA: 0x007E11F0 File Offset: 0x007DF3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_f(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
			float f;
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

	// Token: 0x0601A8CE RID: 108750 RVA: 0x007E1248 File Offset: 0x007DF448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_UserState(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
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

	// Token: 0x0601A8CF RID: 108751 RVA: 0x007E129C File Offset: 0x007DF49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_UserState(IntPtr l)
	{
		int result;
		try
		{
			WorldPathfinder.Node node = (WorldPathfinder.Node)LuaObject.checkSelf(l);
			WorldPathNode userState;
			LuaObject.checkType<WorldPathNode>(l, 2, out userState);
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

	// Token: 0x0601A8D0 RID: 108752 RVA: 0x007E12F4 File Offset: 0x007DF4F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.WorldPathfinder.Node");
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.Reinitialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache0);
		string name = "parent";
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.get_parent);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.set_parent);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache2, true);
		string name2 = "child";
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.get_child);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.set_child);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache4, true);
		string name3 = "g";
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.get_g);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.set_g);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache6, true);
		string name4 = "h";
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.get_h);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.set_h);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache8, true);
		string name5 = "f";
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.get_f);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.set_f);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheA, true);
		string name6 = "m_UserState";
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.get_m_UserState);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.set_m_UserState);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheC, true);
		if (Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_WorldPathfinder_Node.<>f__mg$cacheD, typeof(WorldPathfinder.Node));
	}

	// Token: 0x04010C0A RID: 68618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010C0B RID: 68619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010C0C RID: 68620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010C0D RID: 68621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010C0E RID: 68622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010C0F RID: 68623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010C10 RID: 68624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010C11 RID: 68625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010C12 RID: 68626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010C13 RID: 68627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010C14 RID: 68628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010C15 RID: 68629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010C16 RID: 68630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010C17 RID: 68631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
