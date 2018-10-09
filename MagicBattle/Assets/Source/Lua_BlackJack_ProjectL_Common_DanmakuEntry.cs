using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011EF RID: 4591
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DanmakuEntry : LuaObject
{
	// Token: 0x06017CF0 RID: 97520 RVA: 0x00690980 File Offset: 0x0068EB80
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
				DanmakuEntry o = new DanmakuEntry();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				DanmakuEntry other;
				LuaObject.checkType<DanmakuEntry>(l, 2, out other);
				DanmakuEntry o = new DanmakuEntry(other);
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

	// Token: 0x06017CF1 RID: 97521 RVA: 0x00690A18 File Offset: 0x0068EC18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBLevelDanmakuToLevelDanmaku_s(IntPtr l)
	{
		int result;
		try
		{
			ProDanmakuEntry pbEntry;
			LuaObject.checkType<ProDanmakuEntry>(l, 1, out pbEntry);
			DanmakuEntry o = DanmakuEntry.PBLevelDanmakuToLevelDanmaku(pbEntry);
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

	// Token: 0x06017CF2 RID: 97522 RVA: 0x00690A6C File Offset: 0x0068EC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LevelDanmakuToPBLevelDanmaku_s(IntPtr l)
	{
		int result;
		try
		{
			DanmakuEntry entry;
			LuaObject.checkType<DanmakuEntry>(l, 1, out entry);
			ProDanmakuEntry o = DanmakuEntry.LevelDanmakuToPBLevelDanmaku(entry);
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

	// Token: 0x06017CF3 RID: 97523 RVA: 0x00690AC0 File Offset: 0x0068ECC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			DanmakuEntry danmakuEntry = (DanmakuEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuEntry.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CF4 RID: 97524 RVA: 0x00690B14 File Offset: 0x0068ED14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			DanmakuEntry danmakuEntry = (DanmakuEntry)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			danmakuEntry.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CF5 RID: 97525 RVA: 0x00690B6C File Offset: 0x0068ED6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Content(IntPtr l)
	{
		int result;
		try
		{
			DanmakuEntry danmakuEntry = (DanmakuEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, danmakuEntry.Content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CF6 RID: 97526 RVA: 0x00690BC0 File Offset: 0x0068EDC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Content(IntPtr l)
	{
		int result;
		try
		{
			DanmakuEntry danmakuEntry = (DanmakuEntry)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			danmakuEntry.Content = content;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CF7 RID: 97527 RVA: 0x00690C18 File Offset: 0x0068EE18
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DanmakuEntry");
		if (Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuEntry.PBLevelDanmakuToLevelDanmaku_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuEntry.LevelDanmakuToPBLevelDanmaku_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache1);
		string name = "UserId";
		if (Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuEntry.get_UserId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuEntry.set_UserId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache3, true);
		string name2 = "Content";
		if (Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuEntry.get_Content);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuEntry.set_Content);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DanmakuEntry.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DanmakuEntry.<>f__mg$cache6, typeof(DanmakuEntry));
	}

	// Token: 0x0400E2F4 RID: 58100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E2F5 RID: 58101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E2F6 RID: 58102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E2F7 RID: 58103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E2F8 RID: 58104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E2F9 RID: 58105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E2FA RID: 58106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
