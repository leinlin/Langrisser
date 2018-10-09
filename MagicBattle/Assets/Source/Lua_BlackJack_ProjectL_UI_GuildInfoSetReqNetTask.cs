using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001476 RID: 5238
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask : LuaObject
{
	// Token: 0x0601E46A RID: 124010 RVA: 0x009BB970 File Offset: 0x009B9B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			bool autoJoin;
			LuaObject.checkType(l, 2, out autoJoin);
			int joinLevel;
			LuaObject.checkType(l, 3, out joinLevel);
			string hiringDeclaration;
			LuaObject.checkType(l, 4, out hiringDeclaration);
			GuildInfoSetReqNetTask o = new GuildInfoSetReqNetTask(autoJoin, joinLevel, hiringDeclaration);
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

	// Token: 0x0601E46B RID: 124011 RVA: 0x009BB9E0 File Offset: 0x009B9BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HiringDeclaration(IntPtr l)
	{
		int result;
		try
		{
			GuildInfoSetReqNetTask guildInfoSetReqNetTask = (GuildInfoSetReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInfoSetReqNetTask.HiringDeclaration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E46C RID: 124012 RVA: 0x009BBA34 File Offset: 0x009B9C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AutoJoin(IntPtr l)
	{
		int result;
		try
		{
			GuildInfoSetReqNetTask guildInfoSetReqNetTask = (GuildInfoSetReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInfoSetReqNetTask.AutoJoin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E46D RID: 124013 RVA: 0x009BBA88 File Offset: 0x009B9C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JoinLevel(IntPtr l)
	{
		int result;
		try
		{
			GuildInfoSetReqNetTask guildInfoSetReqNetTask = (GuildInfoSetReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildInfoSetReqNetTask.JoinLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E46E RID: 124014 RVA: 0x009BBADC File Offset: 0x009B9CDC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildInfoSetReqNetTask");
		string name = "HiringDeclaration";
		if (Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.get_HiringDeclaration);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache0, null, true);
		string name2 = "AutoJoin";
		if (Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.get_AutoJoin);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache1, null, true);
		string name3 = "JoinLevel";
		if (Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.get_JoinLevel);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache2, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildInfoSetReqNetTask.<>f__mg$cache3, typeof(GuildInfoSetReqNetTask), typeof(UINetTask));
	}

	// Token: 0x04014560 RID: 83296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014561 RID: 83297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014562 RID: 83298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014563 RID: 83299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
