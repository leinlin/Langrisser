using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001475 RID: 5237
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildHiringDeclarationSetReqNetTask : LuaObject
{
	// Token: 0x0601E466 RID: 124006 RVA: 0x009BB844 File Offset: 0x009B9A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string hiringDeclaration;
			LuaObject.checkType(l, 2, out hiringDeclaration);
			GuildHiringDeclarationSetReqNetTask o = new GuildHiringDeclarationSetReqNetTask(hiringDeclaration);
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

	// Token: 0x0601E467 RID: 124007 RVA: 0x009BB898 File Offset: 0x009B9A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HiringDeclaration(IntPtr l)
	{
		int result;
		try
		{
			GuildHiringDeclarationSetReqNetTask guildHiringDeclarationSetReqNetTask = (GuildHiringDeclarationSetReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildHiringDeclarationSetReqNetTask.HiringDeclaration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E468 RID: 124008 RVA: 0x009BB8EC File Offset: 0x009B9AEC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildHiringDeclarationSetReqNetTask");
		string name = "HiringDeclaration";
		if (Lua_BlackJack_ProjectL_UI_GuildHiringDeclarationSetReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildHiringDeclarationSetReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildHiringDeclarationSetReqNetTask.get_HiringDeclaration);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GuildHiringDeclarationSetReqNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_GuildHiringDeclarationSetReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildHiringDeclarationSetReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildHiringDeclarationSetReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GuildHiringDeclarationSetReqNetTask.<>f__mg$cache1, typeof(GuildHiringDeclarationSetReqNetTask), typeof(UINetTask));
	}

	// Token: 0x0401455E RID: 83294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401455F RID: 83295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
