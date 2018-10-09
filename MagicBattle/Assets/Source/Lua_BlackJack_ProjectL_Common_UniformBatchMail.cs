using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001292 RID: 4754
[Preserve]
public class Lua_BlackJack_ProjectL_Common_UniformBatchMail : LuaObject
{
	// Token: 0x06018C86 RID: 101510 RVA: 0x00704370 File Offset: 0x00702570
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UniformBatchMail o = new UniformBatchMail();
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

	// Token: 0x06018C87 RID: 101511 RVA: 0x007043B8 File Offset: 0x007025B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserIds(IntPtr l)
	{
		int result;
		try
		{
			UniformBatchMail uniformBatchMail = (UniformBatchMail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uniformBatchMail.UserIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C88 RID: 101512 RVA: 0x0070440C File Offset: 0x0070260C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UserIds(IntPtr l)
	{
		int result;
		try
		{
			UniformBatchMail uniformBatchMail = (UniformBatchMail)LuaObject.checkSelf(l);
			LinkedList<string> userIds;
			LuaObject.checkType<LinkedList<string>>(l, 2, out userIds);
			uniformBatchMail.UserIds = userIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C89 RID: 101513 RVA: 0x00704464 File Offset: 0x00702664
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UniformMail(IntPtr l)
	{
		int result;
		try
		{
			UniformBatchMail uniformBatchMail = (UniformBatchMail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uniformBatchMail.UniformMail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C8A RID: 101514 RVA: 0x007044B8 File Offset: 0x007026B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UniformMail(IntPtr l)
	{
		int result;
		try
		{
			UniformBatchMail uniformBatchMail = (UniformBatchMail)LuaObject.checkSelf(l);
			Mail uniformMail;
			LuaObject.checkType<Mail>(l, 2, out uniformMail);
			uniformBatchMail.UniformMail = uniformMail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C8B RID: 101515 RVA: 0x00704510 File Offset: 0x00702710
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.UniformBatchMail");
		string name = "UserIds";
		if (Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UniformBatchMail.get_UserIds);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UniformBatchMail.set_UserIds);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache1, true);
		string name2 = "UniformMail";
		if (Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UniformBatchMail.get_UniformMail);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UniformBatchMail.set_UniformMail);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UniformBatchMail.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_UniformBatchMail.<>f__mg$cache4, typeof(UniformBatchMail));
	}

	// Token: 0x0400F144 RID: 61764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F145 RID: 61765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F146 RID: 61766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F147 RID: 61767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F148 RID: 61768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
