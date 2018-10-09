using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001249 RID: 4681
[Preserve]
public class Lua_BlackJack_ProjectL_Common_JobMaterialBagItem : LuaObject
{
	// Token: 0x0601853F RID: 99647 RVA: 0x006CDE98 File Offset: 0x006CC098
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
			JobMaterialBagItem o = new JobMaterialBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06018540 RID: 99648 RVA: 0x006CDF14 File Offset: 0x006CC114
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.JobMaterialBagItem");
		if (Lua_BlackJack_ProjectL_Common_JobMaterialBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_JobMaterialBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_JobMaterialBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_JobMaterialBagItem.<>f__mg$cache0, typeof(JobMaterialBagItem), typeof(BagItemBase));
	}

	// Token: 0x0400EA8F RID: 60047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
