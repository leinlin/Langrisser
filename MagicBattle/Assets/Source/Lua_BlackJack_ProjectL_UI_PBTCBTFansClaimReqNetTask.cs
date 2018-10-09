using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001523 RID: 5411
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask : LuaObject
{
	// Token: 0x06020215 RID: 131605 RVA: 0x00AA72F4 File Offset: 0x00AA54F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PBTCBTFansClaimReqNetTask o = new PBTCBTFansClaimReqNetTask();
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

	// Token: 0x06020216 RID: 131606 RVA: 0x00AA733C File Offset: 0x00AA553C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_goodsList(IntPtr l)
	{
		int result;
		try
		{
			PBTCBTFansClaimReqNetTask pbtcbtfansClaimReqNetTask = (PBTCBTFansClaimReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pbtcbtfansClaimReqNetTask.goodsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020217 RID: 131607 RVA: 0x00AA7390 File Offset: 0x00AA5590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_goodsList(IntPtr l)
	{
		int result;
		try
		{
			PBTCBTFansClaimReqNetTask pbtcbtfansClaimReqNetTask = (PBTCBTFansClaimReqNetTask)LuaObject.checkSelf(l);
			List<Goods> goodsList;
			LuaObject.checkType<List<Goods>>(l, 2, out goodsList);
			pbtcbtfansClaimReqNetTask.goodsList = goodsList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020218 RID: 131608 RVA: 0x00AA73E8 File Offset: 0x00AA55E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PBTCBTFansClaimReqNetTask");
		string name = "goodsList";
		if (Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.get_goodsList);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.set_goodsList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PBTCBTFansClaimReqNetTask.<>f__mg$cache2, typeof(PBTCBTFansClaimReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040161B1 RID: 90545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040161B2 RID: 90546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040161B3 RID: 90547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
