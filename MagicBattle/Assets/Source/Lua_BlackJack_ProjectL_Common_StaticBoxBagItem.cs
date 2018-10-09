using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200127F RID: 4735
[Preserve]
public class Lua_BlackJack_ProjectL_Common_StaticBoxBagItem : LuaObject
{
	// Token: 0x06018AB5 RID: 101045 RVA: 0x006F6BCC File Offset: 0x006F4DCC
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
			StaticBoxBagItem o = new StaticBoxBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06018AB6 RID: 101046 RVA: 0x006F6C48 File Offset: 0x006F4E48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HaveEffect(IntPtr l)
	{
		int result;
		try
		{
			StaticBoxBagItem staticBoxBagItem = (StaticBoxBagItem)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			object[] param;
			LuaObject.checkParams<object>(l, 3, out param);
			int i = staticBoxBagItem.HaveEffect(owner, param);
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

	// Token: 0x06018AB7 RID: 101047 RVA: 0x006F6CB8 File Offset: 0x006F4EB8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.StaticBoxBagItem");
		if (Lua_BlackJack_ProjectL_Common_StaticBoxBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_StaticBoxBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_StaticBoxBagItem.HaveEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_StaticBoxBagItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_StaticBoxBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_StaticBoxBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_StaticBoxBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_StaticBoxBagItem.<>f__mg$cache1, typeof(StaticBoxBagItem), typeof(UseableBagItem));
	}

	// Token: 0x0400EF99 RID: 61337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EF9A RID: 61338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
