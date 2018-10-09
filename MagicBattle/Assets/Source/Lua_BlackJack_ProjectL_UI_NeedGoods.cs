using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001517 RID: 5399
[Preserve]
public class Lua_BlackJack_ProjectL_UI_NeedGoods : LuaObject
{
	// Token: 0x06020038 RID: 131128 RVA: 0x00A984FC File Offset: 0x00A966FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GoodsType gt;
			LuaObject.checkEnum<GoodsType>(l, 2, out gt);
			int gi;
			LuaObject.checkType(l, 3, out gi);
			int gc;
			LuaObject.checkType(l, 4, out gc);
			NeedGoods o = new NeedGoods(gt, gi, gc);
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

	// Token: 0x06020039 RID: 131129 RVA: 0x00A9856C File Offset: 0x00A9676C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_goodsType(IntPtr l)
	{
		int result;
		try
		{
			NeedGoods needGoods = (NeedGoods)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)needGoods.goodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602003A RID: 131130 RVA: 0x00A985C0 File Offset: 0x00A967C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_goodsType(IntPtr l)
	{
		int result;
		try
		{
			NeedGoods needGoods = (NeedGoods)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			needGoods.goodsType = goodsType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602003B RID: 131131 RVA: 0x00A98618 File Offset: 0x00A96818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_goodsID(IntPtr l)
	{
		int result;
		try
		{
			NeedGoods needGoods = (NeedGoods)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, needGoods.goodsID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602003C RID: 131132 RVA: 0x00A9866C File Offset: 0x00A9686C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_goodsID(IntPtr l)
	{
		int result;
		try
		{
			NeedGoods needGoods = (NeedGoods)LuaObject.checkSelf(l);
			int goodsID;
			LuaObject.checkType(l, 2, out goodsID);
			needGoods.goodsID = goodsID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602003D RID: 131133 RVA: 0x00A986C4 File Offset: 0x00A968C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_goodsNeedCount(IntPtr l)
	{
		int result;
		try
		{
			NeedGoods needGoods = (NeedGoods)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, needGoods.goodsNeedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602003E RID: 131134 RVA: 0x00A98718 File Offset: 0x00A96918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_goodsNeedCount(IntPtr l)
	{
		int result;
		try
		{
			NeedGoods needGoods = (NeedGoods)LuaObject.checkSelf(l);
			int goodsNeedCount;
			LuaObject.checkType(l, 2, out goodsNeedCount);
			needGoods.goodsNeedCount = goodsNeedCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602003F RID: 131135 RVA: 0x00A98770 File Offset: 0x00A96970
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.NeedGoods");
		string name = "goodsType";
		if (Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NeedGoods.get_goodsType);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NeedGoods.set_goodsType);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache1, true);
		string name2 = "goodsID";
		if (Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NeedGoods.get_goodsID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NeedGoods.set_goodsID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache3, true);
		string name3 = "goodsNeedCount";
		if (Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NeedGoods.get_goodsNeedCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NeedGoods.set_goodsNeedCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NeedGoods.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_NeedGoods.<>f__mg$cache6, typeof(NeedGoods));
	}

	// Token: 0x04015FEC RID: 90092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015FED RID: 90093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015FEE RID: 90094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015FEF RID: 90095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015FF0 RID: 90096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015FF1 RID: 90097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015FF2 RID: 90098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
