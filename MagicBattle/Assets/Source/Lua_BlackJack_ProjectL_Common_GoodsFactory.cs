using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001229 RID: 4649
[Preserve]
public class Lua_BlackJack_ProjectL_Common_GoodsFactory : LuaObject
{
	// Token: 0x060181B2 RID: 98738 RVA: 0x006B2CF0 File Offset: 0x006B0EF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GoodsFactory o = new GoodsFactory();
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

	// Token: 0x060181B3 RID: 98739 RVA: 0x006B2D38 File Offset: 0x006B0F38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateGoods_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 2, out contentId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			Goods o = GoodsFactory.CreateGoods(goodsTypeId, contentId, nums);
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

	// Token: 0x060181B4 RID: 98740 RVA: 0x006B2DA8 File Offset: 0x006B0FA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CloneGoods_s(IntPtr l)
	{
		int result;
		try
		{
			List<Goods> goods;
			LuaObject.checkType<List<Goods>>(l, 1, out goods);
			List<Goods> o = GoodsFactory.CloneGoods(goods);
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

	// Token: 0x060181B5 RID: 98741 RVA: 0x006B2DFC File Offset: 0x006B0FFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.GoodsFactory");
		if (Lua_BlackJack_ProjectL_Common_GoodsFactory.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_GoodsFactory.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GoodsFactory.CreateGoods_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GoodsFactory.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_GoodsFactory.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_GoodsFactory.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GoodsFactory.CloneGoods_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_GoodsFactory.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_GoodsFactory.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_GoodsFactory.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_GoodsFactory.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_GoodsFactory.<>f__mg$cache2, typeof(GoodsFactory));
	}

	// Token: 0x0400E742 RID: 59202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E743 RID: 59203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E744 RID: 59204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
