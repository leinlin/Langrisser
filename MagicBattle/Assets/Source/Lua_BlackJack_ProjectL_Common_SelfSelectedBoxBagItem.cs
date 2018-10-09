using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200127C RID: 4732
[Preserve]
public class Lua_BlackJack_ProjectL_Common_SelfSelectedBoxBagItem : LuaObject
{
	// Token: 0x06018A9F RID: 101023 RVA: 0x006F62A4 File Offset: 0x006F44A4
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
			SelfSelectedBoxBagItem o = new SelfSelectedBoxBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06018AA0 RID: 101024 RVA: 0x006F6320 File Offset: 0x006F4520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HaveEffect(IntPtr l)
	{
		int result;
		try
		{
			SelfSelectedBoxBagItem selfSelectedBoxBagItem = (SelfSelectedBoxBagItem)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			object[] param;
			LuaObject.checkParams<object>(l, 3, out param);
			int i = selfSelectedBoxBagItem.HaveEffect(owner, param);
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

	// Token: 0x06018AA1 RID: 101025 RVA: 0x006F6390 File Offset: 0x006F4590
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.SelfSelectedBoxBagItem");
		if (Lua_BlackJack_ProjectL_Common_SelfSelectedBoxBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelfSelectedBoxBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelfSelectedBoxBagItem.HaveEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SelfSelectedBoxBagItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_SelfSelectedBoxBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_SelfSelectedBoxBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SelfSelectedBoxBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_SelfSelectedBoxBagItem.<>f__mg$cache1, typeof(SelfSelectedBoxBagItem), typeof(UseableBagItem));
	}

	// Token: 0x0400EF89 RID: 61321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EF8A RID: 61322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
