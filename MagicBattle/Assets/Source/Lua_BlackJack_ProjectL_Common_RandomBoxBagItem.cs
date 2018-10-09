using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001262 RID: 4706
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RandomBoxBagItem : LuaObject
{
	// Token: 0x060188B1 RID: 100529 RVA: 0x006E8434 File Offset: 0x006E6634
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			ulong instanceId;
			LuaObject.checkType(l, 5, out instanceId);
			RandomBoxBagItem o = new RandomBoxBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x060188B2 RID: 100530 RVA: 0x006E84B0 File Offset: 0x006E66B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HaveEffect(IntPtr l)
	{
		int result;
		try
		{
			RandomBoxBagItem randomBoxBagItem = (RandomBoxBagItem)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			object[] param;
			LuaObject.checkParams<object>(l, 3, out param);
			int i = randomBoxBagItem.HaveEffect(owner, param);
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

	// Token: 0x060188B3 RID: 100531 RVA: 0x006E8520 File Offset: 0x006E6720
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RandomBoxBagItem");
		if (Lua_BlackJack_ProjectL_Common_RandomBoxBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomBoxBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomBoxBagItem.HaveEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomBoxBagItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RandomBoxBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomBoxBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomBoxBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RandomBoxBagItem.<>f__mg$cache1, typeof(RandomBoxBagItem), typeof(UseableBagItem));
	}

	// Token: 0x0400EDCF RID: 60879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EDD0 RID: 60880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
