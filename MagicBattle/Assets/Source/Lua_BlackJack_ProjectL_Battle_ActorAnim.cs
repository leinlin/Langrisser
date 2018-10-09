using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200118D RID: 4493
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_ActorAnim : LuaObject
{
	// Token: 0x0601700E RID: 94222 RVA: 0x0062EECC File Offset: 0x0062D0CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ActorAnim o = new ActorAnim();
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

	// Token: 0x0601700F RID: 94223 RVA: 0x0062EF14 File Offset: 0x0062D114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017010 RID: 94224 RVA: 0x0062EF5C File Offset: 0x0062D15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Walk(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "walk");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017011 RID: 94225 RVA: 0x0062EFA4 File Offset: 0x0062D1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Run(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "run");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017012 RID: 94226 RVA: 0x0062EFEC File Offset: 0x0062D1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Attack(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "attack1");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017013 RID: 94227 RVA: 0x0062F034 File Offset: 0x0062D234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SuperAttack(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "superattack");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017014 RID: 94228 RVA: 0x0062F07C File Offset: 0x0062D27C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Sing(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "sing");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017015 RID: 94229 RVA: 0x0062F0C4 File Offset: 0x0062D2C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Cast(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "cast");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017016 RID: 94230 RVA: 0x0062F10C File Offset: 0x0062D30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Hurt(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "hurt");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017017 RID: 94231 RVA: 0x0062F154 File Offset: 0x0062D354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Stun(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "stun");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017018 RID: 94232 RVA: 0x0062F19C File Offset: 0x0062D39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Die(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "death");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017019 RID: 94233 RVA: 0x0062F1E4 File Offset: 0x0062D3E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Die1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "death1");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601701A RID: 94234 RVA: 0x0062F22C File Offset: 0x0062D42C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Die2(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "death2");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601701B RID: 94235 RVA: 0x0062F274 File Offset: 0x0062D474
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.ActorAnim");
		string name = "Idle";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Idle);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache0, null, false);
		string name2 = "Walk";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Walk);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache1, null, false);
		string name3 = "Run";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Run);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache2, null, false);
		string name4 = "Attack";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Attack);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache3, null, false);
		string name5 = "SuperAttack";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_SuperAttack);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache4, null, false);
		string name6 = "Sing";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Sing);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache5, null, false);
		string name7 = "Cast";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Cast);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache6, null, false);
		string name8 = "Hurt";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Hurt);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache7, null, false);
		string name9 = "Stun";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Stun);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache8, null, false);
		string name10 = "Die";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Die);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cache9, null, false);
		string name11 = "Die1";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Die1);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cacheA, null, false);
		string name12 = "Die2";
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.get_Die2);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cacheB, null, false);
		if (Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_ActorAnim.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_ActorAnim.<>f__mg$cacheC, typeof(ActorAnim));
	}

	// Token: 0x0400D6D6 RID: 54998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D6D7 RID: 54999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D6D8 RID: 55000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D6D9 RID: 55001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D6DA RID: 55002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D6DB RID: 55003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D6DC RID: 55004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D6DD RID: 55005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D6DE RID: 55006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D6DF RID: 55007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D6E0 RID: 55008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D6E1 RID: 55009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D6E2 RID: 55010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
