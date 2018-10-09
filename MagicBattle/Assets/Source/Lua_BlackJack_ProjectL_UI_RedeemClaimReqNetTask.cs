using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001556 RID: 5462
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask : LuaObject
{
	// Token: 0x06020A71 RID: 133745 RVA: 0x00AE9B3C File Offset: 0x00AE7D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RedeemClaimReqNetTask o = new RedeemClaimReqNetTask();
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

	// Token: 0x06020A72 RID: 133746 RVA: 0x00AE9B84 File Offset: 0x00AE7D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CrystalVal(IntPtr l)
	{
		int result;
		try
		{
			RedeemClaimReqNetTask redeemClaimReqNetTask = (RedeemClaimReqNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, redeemClaimReqNetTask.CrystalVal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A73 RID: 133747 RVA: 0x00AE9BD8 File Offset: 0x00AE7DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CrystalVal(IntPtr l)
	{
		int result;
		try
		{
			RedeemClaimReqNetTask redeemClaimReqNetTask = (RedeemClaimReqNetTask)LuaObject.checkSelf(l);
			int crystalVal;
			LuaObject.checkType(l, 2, out crystalVal);
			redeemClaimReqNetTask.CrystalVal = crystalVal;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A74 RID: 133748 RVA: 0x00AE9C30 File Offset: 0x00AE7E30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RedeemClaimReqNetTask");
		string name = "CrystalVal";
		if (Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.get_CrystalVal);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.set_CrystalVal);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RedeemClaimReqNetTask.<>f__mg$cache2, typeof(RedeemClaimReqNetTask), typeof(UINetTask));
	}

	// Token: 0x040169A7 RID: 92583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040169A8 RID: 92584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040169A9 RID: 92585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
