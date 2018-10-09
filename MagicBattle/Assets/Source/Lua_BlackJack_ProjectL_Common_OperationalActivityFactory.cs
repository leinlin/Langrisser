using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001257 RID: 4695
[Preserve]
public class Lua_BlackJack_ProjectL_Common_OperationalActivityFactory : LuaObject
{
	// Token: 0x06018779 RID: 100217 RVA: 0x006DEFD8 File Offset: 0x006DD1D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityFactory o = new OperationalActivityFactory();
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

	// Token: 0x0601877A RID: 100218 RVA: 0x006DF020 File Offset: 0x006DD220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateOperationalActivity_s(IntPtr l)
	{
		int result;
		try
		{
			ulong instanceId;
			LuaObject.checkType(l, 1, out instanceId);
			int operationalActivityId;
			LuaObject.checkType(l, 2, out operationalActivityId);
			OperationalActivityType operationalActivityType;
			LuaObject.checkEnum<OperationalActivityType>(l, 3, out operationalActivityType);
			OperationalActivityBase o = OperationalActivityFactory.CreateOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
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

	// Token: 0x0601877B RID: 100219 RVA: 0x006DF090 File Offset: 0x006DD290
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.OperationalActivityFactory");
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityFactory.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityFactory.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityFactory.CreateOperationalActivity_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityFactory.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityFactory.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityFactory.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityFactory.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_OperationalActivityFactory.<>f__mg$cache1, typeof(OperationalActivityFactory));
	}

	// Token: 0x0400ECAD RID: 60589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400ECAE RID: 60590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
