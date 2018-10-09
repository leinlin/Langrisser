using System;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015F5 RID: 5621
[Preserve]
public class Lua_BlackJack_UtilityTools_MoneyCaculate : LuaObject
{
	// Token: 0x060227E1 RID: 141281 RVA: 0x00BD3D3C File Offset: 0x00BD1F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MoneyCaculate o = new MoneyCaculate();
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

	// Token: 0x060227E2 RID: 141282 RVA: 0x00BD3D84 File Offset: 0x00BD1F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FenToYuan_s(IntPtr l)
	{
		int result;
		try
		{
			int fen;
			LuaObject.checkType(l, 1, out fen);
			double d = MoneyCaculate.FenToYuan(fen);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, d);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227E3 RID: 141283 RVA: 0x00BD3DD8 File Offset: 0x00BD1FD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int YuanToFen_s(IntPtr l)
	{
		int result;
		try
		{
			double yuan;
			LuaObject.checkType(l, 1, out yuan);
			int i = MoneyCaculate.YuanToFen(yuan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227E4 RID: 141284 RVA: 0x00BD3E2C File Offset: 0x00BD202C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.UtilityTools.MoneyCaculate");
		if (Lua_BlackJack_UtilityTools_MoneyCaculate.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_UtilityTools_MoneyCaculate.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_UtilityTools_MoneyCaculate.FenToYuan_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_MoneyCaculate.<>f__mg$cache0);
		if (Lua_BlackJack_UtilityTools_MoneyCaculate.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_UtilityTools_MoneyCaculate.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_UtilityTools_MoneyCaculate.YuanToFen_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_MoneyCaculate.<>f__mg$cache1);
		if (Lua_BlackJack_UtilityTools_MoneyCaculate.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_UtilityTools_MoneyCaculate.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_UtilityTools_MoneyCaculate.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_UtilityTools_MoneyCaculate.<>f__mg$cache2, typeof(MoneyCaculate));
	}

	// Token: 0x040185D9 RID: 99801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185DA RID: 99802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185DB RID: 99803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
