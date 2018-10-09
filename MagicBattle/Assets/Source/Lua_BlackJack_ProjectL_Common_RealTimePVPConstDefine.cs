using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001270 RID: 4720
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine : LuaObject
{
	// Token: 0x06018995 RID: 100757 RVA: 0x006EE7EC File Offset: 0x006EC9EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPConstDefine o = new RealTimePVPConstDefine();
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

	// Token: 0x06018996 RID: 100758 RVA: 0x006EE834 File Offset: 0x006ECA34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NoRank(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018997 RID: 100759 RVA: 0x006EE878 File Offset: 0x006ECA78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StartDayOfWeek(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, 1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018998 RID: 100760 RVA: 0x006EE8BC File Offset: 0x006ECABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankingRewardSingleOperationTimeThreshold(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018999 RID: 100761 RVA: 0x006EE904 File Offset: 0x006ECB04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RealTimePVPConstDefine");
		string name = "NoRank";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.get_NoRank);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache0, null, false);
		string name2 = "StartDayOfWeek";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.get_StartDayOfWeek);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache1, null, false);
		string name3 = "RankingRewardSingleOperationTimeThreshold";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.get_RankingRewardSingleOperationTimeThreshold);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache2, null, false);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RealTimePVPConstDefine.<>f__mg$cache3, typeof(RealTimePVPConstDefine));
	}

	// Token: 0x0400EE97 RID: 61079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EE98 RID: 61080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EE99 RID: 61081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EE9A RID: 61082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
