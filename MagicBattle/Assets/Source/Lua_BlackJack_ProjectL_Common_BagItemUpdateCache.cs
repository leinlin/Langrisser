using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011C7 RID: 4551
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BagItemUpdateCache : LuaObject
{
	// Token: 0x06017976 RID: 96630 RVA: 0x006779B0 File Offset: 0x00675BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BagItemUpdateCache o = new BagItemUpdateCache();
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

	// Token: 0x06017977 RID: 96631 RVA: 0x006779F8 File Offset: 0x00675BF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BagItemUpdateCache");
		if (Lua_BlackJack_ProjectL_Common_BagItemUpdateCache.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BagItemUpdateCache.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BagItemUpdateCache.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BagItemUpdateCache.<>f__mg$cache0, typeof(BagItemUpdateCache), typeof(UpdateCacheList<BagItemBase>));
	}

	// Token: 0x0400DFCA RID: 57290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
