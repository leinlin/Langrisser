using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001584 RID: 5508
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SpineCharAnim : LuaObject
{
	// Token: 0x06021237 RID: 135735 RVA: 0x00B28304 File Offset: 0x00B26504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SpineCharAnim o = new SpineCharAnim();
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

	// Token: 0x06021238 RID: 135736 RVA: 0x00B2834C File Offset: 0x00B2654C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle_Normal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle_Normal");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021239 RID: 135737 RVA: 0x00B28394 File Offset: 0x00B26594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle_Angry(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle_Angry");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602123A RID: 135738 RVA: 0x00B283DC File Offset: 0x00B265DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle_Injury(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle_Injury");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602123B RID: 135739 RVA: 0x00B28424 File Offset: 0x00B26624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle_Sad(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle_Sad");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602123C RID: 135740 RVA: 0x00B2846C File Offset: 0x00B2666C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle_Shy(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle_Shy");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602123D RID: 135741 RVA: 0x00B284B4 File Offset: 0x00B266B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle_Sigh(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle_Sigh");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602123E RID: 135742 RVA: 0x00B284FC File Offset: 0x00B266FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle_Smile(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle_Smile");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602123F RID: 135743 RVA: 0x00B28544 File Offset: 0x00B26744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle_Battle_Normal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle_Battle_Normal");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021240 RID: 135744 RVA: 0x00B2858C File Offset: 0x00B2678C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle_Battle_Mighty(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle_Battle_Mighty");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021241 RID: 135745 RVA: 0x00B285D4 File Offset: 0x00B267D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle_Battle_Weak(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "idle_Battle_Weak");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021242 RID: 135746 RVA: 0x00B2861C File Offset: 0x00B2681C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SpineCharAnim");
		string name = "Idle_Normal";
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.get_Idle_Normal);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache0, null, false);
		string name2 = "Idle_Angry";
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.get_Idle_Angry);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache1, null, false);
		string name3 = "Idle_Injury";
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.get_Idle_Injury);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache2, null, false);
		string name4 = "Idle_Sad";
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.get_Idle_Sad);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache3, null, false);
		string name5 = "Idle_Shy";
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.get_Idle_Shy);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache4, null, false);
		string name6 = "Idle_Sigh";
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.get_Idle_Sigh);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache5, null, false);
		string name7 = "Idle_Smile";
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.get_Idle_Smile);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache6, null, false);
		string name8 = "Idle_Battle_Normal";
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.get_Idle_Battle_Normal);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache7, null, false);
		string name9 = "Idle_Battle_Mighty";
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.get_Idle_Battle_Mighty);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache8, null, false);
		string name10 = "Idle_Battle_Weak";
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.get_Idle_Battle_Weak);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cache9, null, false);
		if (Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SpineCharAnim.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_SpineCharAnim.<>f__mg$cacheA, typeof(SpineCharAnim));
	}

	// Token: 0x04017111 RID: 94481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017112 RID: 94482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017113 RID: 94483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017114 RID: 94484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017115 RID: 94485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017116 RID: 94486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017117 RID: 94487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017118 RID: 94488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017119 RID: 94489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401711A RID: 94490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401711B RID: 94491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
