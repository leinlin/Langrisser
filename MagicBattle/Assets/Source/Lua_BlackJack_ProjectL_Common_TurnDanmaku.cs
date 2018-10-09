using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001290 RID: 4752
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TurnDanmaku : LuaObject
{
	// Token: 0x06018C3F RID: 101439 RVA: 0x00701F58 File Offset: 0x00700158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				TurnDanmaku o = new TurnDanmaku();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				TurnDanmaku other;
				LuaObject.checkType<TurnDanmaku>(l, 2, out other);
				TurnDanmaku o = new TurnDanmaku(other);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C40 RID: 101440 RVA: 0x00701FF0 File Offset: 0x007001F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBTurnDanmakuToTurnDanmaku_s(IntPtr l)
	{
		int result;
		try
		{
			ProTurnDanmaku pbTurnDanmaku;
			LuaObject.checkType<ProTurnDanmaku>(l, 1, out pbTurnDanmaku);
			TurnDanmaku o = TurnDanmaku.PBTurnDanmakuToTurnDanmaku(pbTurnDanmaku);
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

	// Token: 0x06018C41 RID: 101441 RVA: 0x00702044 File Offset: 0x00700244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TurnDanmakuToPBTurnDanmaku_s(IntPtr l)
	{
		int result;
		try
		{
			TurnDanmaku turnDanmaku;
			LuaObject.checkType<TurnDanmaku>(l, 1, out turnDanmaku);
			ProTurnDanmaku o = TurnDanmaku.TurnDanmakuToPBTurnDanmaku(turnDanmaku);
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

	// Token: 0x06018C42 RID: 101442 RVA: 0x00702098 File Offset: 0x00700298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Entries(IntPtr l)
	{
		int result;
		try
		{
			TurnDanmaku turnDanmaku = (TurnDanmaku)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, turnDanmaku.Entries);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C43 RID: 101443 RVA: 0x007020EC File Offset: 0x007002EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Entries(IntPtr l)
	{
		int result;
		try
		{
			TurnDanmaku turnDanmaku = (TurnDanmaku)LuaObject.checkSelf(l);
			List<DanmakuEntry> entries;
			LuaObject.checkType<List<DanmakuEntry>>(l, 2, out entries);
			turnDanmaku.Entries = entries;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C44 RID: 101444 RVA: 0x00702144 File Offset: 0x00700344
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Turn(IntPtr l)
	{
		int result;
		try
		{
			TurnDanmaku turnDanmaku = (TurnDanmaku)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, turnDanmaku.Turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C45 RID: 101445 RVA: 0x00702198 File Offset: 0x00700398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Turn(IntPtr l)
	{
		int result;
		try
		{
			TurnDanmaku turnDanmaku = (TurnDanmaku)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			turnDanmaku.Turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C46 RID: 101446 RVA: 0x007021F0 File Offset: 0x007003F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NextIndex(IntPtr l)
	{
		int result;
		try
		{
			TurnDanmaku turnDanmaku = (TurnDanmaku)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, turnDanmaku.NextIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C47 RID: 101447 RVA: 0x00702244 File Offset: 0x00700444
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NextIndex(IntPtr l)
	{
		int result;
		try
		{
			TurnDanmaku turnDanmaku = (TurnDanmaku)LuaObject.checkSelf(l);
			int nextIndex;
			LuaObject.checkType(l, 2, out nextIndex);
			turnDanmaku.NextIndex = nextIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C48 RID: 101448 RVA: 0x0070229C File Offset: 0x0070049C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TurnDanmaku");
		if (Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TurnDanmaku.PBTurnDanmakuToTurnDanmaku_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TurnDanmaku.TurnDanmakuToPBTurnDanmaku_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache1);
		string name = "Entries";
		if (Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TurnDanmaku.get_Entries);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TurnDanmaku.set_Entries);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache3, true);
		string name2 = "Turn";
		if (Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TurnDanmaku.get_Turn);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TurnDanmaku.set_Turn);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache5, true);
		string name3 = "NextIndex";
		if (Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TurnDanmaku.get_NextIndex);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TurnDanmaku.set_NextIndex);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TurnDanmaku.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TurnDanmaku.<>f__mg$cache8, typeof(TurnDanmaku));
	}

	// Token: 0x0400F101 RID: 61697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F102 RID: 61698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F103 RID: 61699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F104 RID: 61700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F105 RID: 61701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F106 RID: 61702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F107 RID: 61703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F108 RID: 61704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F109 RID: 61705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
