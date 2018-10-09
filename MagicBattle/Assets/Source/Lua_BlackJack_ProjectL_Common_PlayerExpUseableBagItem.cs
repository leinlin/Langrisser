using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200125A RID: 4698
[Preserve]
public class Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem : LuaObject
{
	// Token: 0x06018835 RID: 100405 RVA: 0x006E4E68 File Offset: 0x006E3068
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
			PlayerExpUseableBagItem o = new PlayerExpUseableBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06018836 RID: 100406 RVA: 0x006E4EE4 File Offset: 0x006E30E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HaveEffect(IntPtr l)
	{
		int result;
		try
		{
			PlayerExpUseableBagItem playerExpUseableBagItem = (PlayerExpUseableBagItem)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			object[] param;
			LuaObject.checkParams<object>(l, 3, out param);
			int i = playerExpUseableBagItem.HaveEffect(owner, param);
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

	// Token: 0x06018837 RID: 100407 RVA: 0x006E4F54 File Offset: 0x006E3154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			PlayerExpUseableBagItem playerExpUseableBagItem = (PlayerExpUseableBagItem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerExpUseableBagItem.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018838 RID: 100408 RVA: 0x006E4FA8 File Offset: 0x006E31A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			PlayerExpUseableBagItem playerExpUseableBagItem = (PlayerExpUseableBagItem)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			playerExpUseableBagItem.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018839 RID: 100409 RVA: 0x006E5000 File Offset: 0x006E3200
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.PlayerExpUseableBagItem");
		if (Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.HaveEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache0);
		string name = "PlayerExp";
		if (Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.get_PlayerExp);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.set_PlayerExp);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache2, true);
		if (Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_PlayerExpUseableBagItem.<>f__mg$cache3, typeof(PlayerExpUseableBagItem), typeof(UseableBagItem));
	}

	// Token: 0x0400ED63 RID: 60771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400ED64 RID: 60772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400ED65 RID: 60773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400ED66 RID: 60774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
