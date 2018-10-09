using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001141 RID: 4417
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData : LuaObject
{
	// Token: 0x060165DF RID: 91615 RVA: 0x005E5984 File Offset: 0x005E3B84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData o = new ConfigDataBehavior.ParamData();
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

	// Token: 0x060165E0 RID: 91616 RVA: 0x005E59CC File Offset: 0x005E3BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__float(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData paramData = (ConfigDataBehavior.ParamData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, paramData._float);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165E1 RID: 91617 RVA: 0x005E5A20 File Offset: 0x005E3C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__float(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData paramData = (ConfigDataBehavior.ParamData)LuaObject.checkSelf(l);
			float @float;
			LuaObject.checkType(l, 2, out @float);
			paramData._float = @float;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165E2 RID: 91618 RVA: 0x005E5A78 File Offset: 0x005E3C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__int(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData paramData = (ConfigDataBehavior.ParamData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, paramData._int);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165E3 RID: 91619 RVA: 0x005E5ACC File Offset: 0x005E3CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__int(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData paramData = (ConfigDataBehavior.ParamData)LuaObject.checkSelf(l);
			int @int;
			LuaObject.checkType(l, 2, out @int);
			paramData._int = @int;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165E4 RID: 91620 RVA: 0x005E5B24 File Offset: 0x005E3D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__GridPositions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData paramData = (ConfigDataBehavior.ParamData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, paramData._GridPositions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165E5 RID: 91621 RVA: 0x005E5B78 File Offset: 0x005E3D78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set__GridPositions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData paramData = (ConfigDataBehavior.ParamData)LuaObject.checkSelf(l);
			List<GridPosition> gridPositions;
			LuaObject.checkType<List<GridPosition>>(l, 2, out gridPositions);
			paramData._GridPositions = gridPositions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165E6 RID: 91622 RVA: 0x005E5BD0 File Offset: 0x005E3DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get__ints(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData paramData = (ConfigDataBehavior.ParamData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, paramData._ints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165E7 RID: 91623 RVA: 0x005E5C24 File Offset: 0x005E3E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__ints(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData paramData = (ConfigDataBehavior.ParamData)LuaObject.checkSelf(l);
			int[] ints;
			LuaObject.checkArray<int>(l, 2, out ints);
			paramData._ints = ints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165E8 RID: 91624 RVA: 0x005E5C7C File Offset: 0x005E3E7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get__ints2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData paramData = (ConfigDataBehavior.ParamData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, paramData._ints2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165E9 RID: 91625 RVA: 0x005E5CD0 File Offset: 0x005E3ED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set__ints2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior.ParamData paramData = (ConfigDataBehavior.ParamData)LuaObject.checkSelf(l);
			int[] ints;
			LuaObject.checkArray<int>(l, 2, out ints);
			paramData._ints2 = ints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165EA RID: 91626 RVA: 0x005E5D28 File Offset: 0x005E3F28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBehavior.ParamData");
		string name = "_float";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.get__float);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.set__float);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache1, true);
		string name2 = "_int";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.get__int);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.set__int);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache3, true);
		string name3 = "_GridPositions";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.get__GridPositions);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.set__GridPositions);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache5, true);
		string name4 = "_ints";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.get__ints);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.set__ints);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache7, true);
		string name5 = "_ints2";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.get__ints2);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.set__ints2);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cache9, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBehavior_ParamData.<>f__mg$cacheA, typeof(ConfigDataBehavior.ParamData));
	}

	// Token: 0x0400CD3F RID: 52543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CD40 RID: 52544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CD41 RID: 52545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CD42 RID: 52546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CD43 RID: 52547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CD44 RID: 52548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CD45 RID: 52549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CD46 RID: 52550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CD47 RID: 52551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CD48 RID: 52552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CD49 RID: 52553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
