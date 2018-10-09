using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011DB RID: 4571
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ChangeNameUsableBagItem : LuaObject
{
	// Token: 0x06017B5B RID: 97115 RVA: 0x0068569C File Offset: 0x0068389C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
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
			ChangeNameUsableBagItem o = new ChangeNameUsableBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06017B5C RID: 97116 RVA: 0x00685718 File Offset: 0x00683918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HaveEffect(IntPtr l)
	{
		int result;
		try
		{
			ChangeNameUsableBagItem changeNameUsableBagItem = (ChangeNameUsableBagItem)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			object[] param;
			LuaObject.checkParams<object>(l, 3, out param);
			int i = changeNameUsableBagItem.HaveEffect(owner, param);
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

	// Token: 0x06017B5D RID: 97117 RVA: 0x00685788 File Offset: 0x00683988
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ChangeNameUsableBagItem");
		if (Lua_BlackJack_ProjectL_Common_ChangeNameUsableBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChangeNameUsableBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChangeNameUsableBagItem.HaveEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChangeNameUsableBagItem.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ChangeNameUsableBagItem.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChangeNameUsableBagItem.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChangeNameUsableBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ChangeNameUsableBagItem.<>f__mg$cache1, typeof(ChangeNameUsableBagItem), typeof(UseableBagItem));
	}

	// Token: 0x0400E187 RID: 57735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E188 RID: 57736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
