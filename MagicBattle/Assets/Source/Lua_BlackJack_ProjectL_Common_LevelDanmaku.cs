using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200124B RID: 4683
[Preserve]
public class Lua_BlackJack_ProjectL_Common_LevelDanmaku : LuaObject
{
	// Token: 0x06018593 RID: 99731 RVA: 0x006D0880 File Offset: 0x006CEA80
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
				LevelDanmaku o = new LevelDanmaku();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				LevelDanmaku other;
				LuaObject.checkType<LevelDanmaku>(l, 2, out other);
				LevelDanmaku o = new LevelDanmaku(other);
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

	// Token: 0x06018594 RID: 99732 RVA: 0x006D0918 File Offset: 0x006CEB18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBLevelDanmakuToLevelDanmaku_s(IntPtr l)
	{
		int result;
		try
		{
			ProLevelDanmaku pbDanmaku;
			LuaObject.checkType<ProLevelDanmaku>(l, 1, out pbDanmaku);
			LevelDanmaku o = LevelDanmaku.PBLevelDanmakuToLevelDanmaku(pbDanmaku);
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

	// Token: 0x06018595 RID: 99733 RVA: 0x006D096C File Offset: 0x006CEB6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LevelDanmakuToPBLevelDanmaku_s(IntPtr l)
	{
		int result;
		try
		{
			LevelDanmaku danmaku;
			LuaObject.checkType<LevelDanmaku>(l, 1, out danmaku);
			ProLevelDanmaku o = LevelDanmaku.LevelDanmakuToPBLevelDanmaku(danmaku);
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

	// Token: 0x06018596 RID: 99734 RVA: 0x006D09C0 File Offset: 0x006CEBC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Turns(IntPtr l)
	{
		int result;
		try
		{
			LevelDanmaku levelDanmaku = (LevelDanmaku)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelDanmaku.Turns);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018597 RID: 99735 RVA: 0x006D0A14 File Offset: 0x006CEC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Turns(IntPtr l)
	{
		int result;
		try
		{
			LevelDanmaku levelDanmaku = (LevelDanmaku)LuaObject.checkSelf(l);
			List<TurnDanmaku> turns;
			LuaObject.checkType<List<TurnDanmaku>>(l, 2, out turns);
			levelDanmaku.Turns = turns;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018598 RID: 99736 RVA: 0x006D0A6C File Offset: 0x006CEC6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.LevelDanmaku");
		if (Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelDanmaku.PBLevelDanmakuToLevelDanmaku_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelDanmaku.LevelDanmakuToPBLevelDanmaku_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache1);
		string name = "Turns";
		if (Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelDanmaku.get_Turns);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelDanmaku.set_Turns);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LevelDanmaku.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_LevelDanmaku.<>f__mg$cache4, typeof(LevelDanmaku));
	}

	// Token: 0x0400EADF RID: 60127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EAE0 RID: 60128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EAE1 RID: 60129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EAE2 RID: 60130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EAE3 RID: 60131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
