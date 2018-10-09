using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001395 RID: 5013
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BagItemUseNetTask : LuaObject
{
	// Token: 0x0601B56D RID: 111981 RVA: 0x008458A0 File Offset: 0x00843AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int itemId;
			LuaObject.checkType(l, 3, out itemId);
			int count;
			LuaObject.checkType(l, 4, out count);
			BagItemUseNetTask o = new BagItemUseNetTask(goodsType, itemId, count);
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

	// Token: 0x0601B56E RID: 111982 RVA: 0x00845910 File Offset: 0x00843B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoodsType(IntPtr l)
	{
		int result;
		try
		{
			BagItemUseNetTask bagItemUseNetTask = (BagItemUseNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)bagItemUseNetTask.GoodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B56F RID: 111983 RVA: 0x00845964 File Offset: 0x00843B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemID(IntPtr l)
	{
		int result;
		try
		{
			BagItemUseNetTask bagItemUseNetTask = (BagItemUseNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUseNetTask.ItemID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B570 RID: 111984 RVA: 0x008459B8 File Offset: 0x00843BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Count(IntPtr l)
	{
		int result;
		try
		{
			BagItemUseNetTask bagItemUseNetTask = (BagItemUseNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUseNetTask.Count);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B571 RID: 111985 RVA: 0x00845A0C File Offset: 0x00843C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			BagItemUseNetTask bagItemUseNetTask = (BagItemUseNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUseNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B572 RID: 111986 RVA: 0x00845A60 File Offset: 0x00843C60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BagItemUseNetTask");
		string name = "GoodsType";
		if (Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.get_GoodsType);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache0, null, true);
		string name2 = "ItemID";
		if (Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.get_ItemID);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache1, null, true);
		string name3 = "Count";
		if (Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.get_Count);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache2, null, true);
		string name4 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.get_Reward);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache3, null, true);
		if (Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BagItemUseNetTask.<>f__mg$cache4, typeof(BagItemUseNetTask), typeof(UINetTask));
	}

	// Token: 0x04011825 RID: 71717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011826 RID: 71718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011827 RID: 71719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011828 RID: 71720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011829 RID: 71721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
