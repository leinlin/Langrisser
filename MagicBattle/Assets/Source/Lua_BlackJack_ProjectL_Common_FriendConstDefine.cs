using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001221 RID: 4641
[Preserve]
public class Lua_BlackJack_ProjectL_Common_FriendConstDefine : LuaObject
{
	// Token: 0x0601813A RID: 98618 RVA: 0x006AF92C File Offset: 0x006ADB2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FriendConstDefine o = new FriendConstDefine();
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

	// Token: 0x0601813B RID: 98619 RVA: 0x006AF974 File Offset: 0x006ADB74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.FriendConstDefine");
		if (Lua_BlackJack_ProjectL_Common_FriendConstDefine.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendConstDefine.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendConstDefine.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_FriendConstDefine.<>f__mg$cache0, typeof(FriendConstDefine));
	}

	// Token: 0x0400E6DA RID: 59098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
