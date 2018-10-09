using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014C3 RID: 5315
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroFavorabilityExpAddNetTask : LuaObject
{
	// Token: 0x0601F190 RID: 127376 RVA: 0x00A23D70 File Offset: 0x00A21F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 3, out goodsType);
			int itemId;
			LuaObject.checkType(l, 4, out itemId);
			int count;
			LuaObject.checkType(l, 5, out count);
			HeroFavorabilityExpAddNetTask o = new HeroFavorabilityExpAddNetTask(heroId, goodsType, itemId, count);
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

	// Token: 0x0601F191 RID: 127377 RVA: 0x00A23DEC File Offset: 0x00A21FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			HeroFavorabilityExpAddNetTask heroFavorabilityExpAddNetTask = (HeroFavorabilityExpAddNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroFavorabilityExpAddNetTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F192 RID: 127378 RVA: 0x00A23E40 File Offset: 0x00A22040
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroFavorabilityExpAddNetTask");
		string name = "Rewards";
		if (Lua_BlackJack_ProjectL_UI_HeroFavorabilityExpAddNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroFavorabilityExpAddNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroFavorabilityExpAddNetTask.get_Rewards);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_HeroFavorabilityExpAddNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroFavorabilityExpAddNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroFavorabilityExpAddNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroFavorabilityExpAddNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroFavorabilityExpAddNetTask.<>f__mg$cache1, typeof(HeroFavorabilityExpAddNetTask), typeof(UINetTask));
	}

	// Token: 0x040151EC RID: 86508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040151ED RID: 86509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
