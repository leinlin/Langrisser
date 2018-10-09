using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001285 RID: 4741
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine : LuaObject
{
	// Token: 0x06018B41 RID: 101185 RVA: 0x006FAB70 File Offset: 0x006F8D70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomConstDefine o = new TeamRoomConstDefine();
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

	// Token: 0x06018B42 RID: 101186 RVA: 0x006FABB8 File Offset: 0x006F8DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MaxTeamMemberNums(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B43 RID: 101187 RVA: 0x006FABFC File Offset: 0x006F8DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AutoMatchNotifyDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B44 RID: 101188 RVA: 0x006FAC40 File Offset: 0x006F8E40
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TeamRoomConstDefine");
		string name = "MaxTeamMemberNums";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.get_MaxTeamMemberNums);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.<>f__mg$cache0, null, false);
		string name2 = "AutoMatchNotifyDeltaTime";
		if (Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.get_AutoMatchNotifyDeltaTime);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.<>f__mg$cache1, null, false);
		if (Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TeamRoomConstDefine.<>f__mg$cache2, typeof(TeamRoomConstDefine));
	}

	// Token: 0x0400F019 RID: 61465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F01A RID: 61466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F01B RID: 61467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
