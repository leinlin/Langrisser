using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001179 RID: 4473
[Preserve]
public class Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo : LuaObject
{
	// Token: 0x06016F5F RID: 94047 RVA: 0x0062AC2C File Offset: 0x00628E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			EnchantPropertyProbabilityInfo o = new EnchantPropertyProbabilityInfo();
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

	// Token: 0x06016F60 RID: 94048 RVA: 0x0062AC74 File Offset: 0x00628E74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			EnchantPropertyProbabilityInfo enchantPropertyProbabilityInfo = (EnchantPropertyProbabilityInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)enchantPropertyProbabilityInfo.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F61 RID: 94049 RVA: 0x0062ACC8 File Offset: 0x00628EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			EnchantPropertyProbabilityInfo enchantPropertyProbabilityInfo = (EnchantPropertyProbabilityInfo)LuaObject.checkSelf(l);
			PropertyModifyType id;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out id);
			enchantPropertyProbabilityInfo.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F62 RID: 94050 RVA: 0x0062AD20 File Offset: 0x00628F20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PropertyValues(IntPtr l)
	{
		int result;
		try
		{
			EnchantPropertyProbabilityInfo enchantPropertyProbabilityInfo = (EnchantPropertyProbabilityInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enchantPropertyProbabilityInfo.PropertyValues);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F63 RID: 94051 RVA: 0x0062AD74 File Offset: 0x00628F74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PropertyValues(IntPtr l)
	{
		int result;
		try
		{
			EnchantPropertyProbabilityInfo enchantPropertyProbabilityInfo = (EnchantPropertyProbabilityInfo)LuaObject.checkSelf(l);
			List<EnchantPropertyValueInfo> propertyValues;
			LuaObject.checkType<List<EnchantPropertyValueInfo>>(l, 2, out propertyValues);
			enchantPropertyProbabilityInfo.PropertyValues = propertyValues;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F64 RID: 94052 RVA: 0x0062ADCC File Offset: 0x00628FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Weight(IntPtr l)
	{
		int result;
		try
		{
			EnchantPropertyProbabilityInfo enchantPropertyProbabilityInfo = (EnchantPropertyProbabilityInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enchantPropertyProbabilityInfo.Weight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F65 RID: 94053 RVA: 0x0062AE20 File Offset: 0x00629020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Weight(IntPtr l)
	{
		int result;
		try
		{
			EnchantPropertyProbabilityInfo enchantPropertyProbabilityInfo = (EnchantPropertyProbabilityInfo)LuaObject.checkSelf(l);
			int weight;
			LuaObject.checkType(l, 2, out weight);
			enchantPropertyProbabilityInfo.Weight = weight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F66 RID: 94054 RVA: 0x0062AE78 File Offset: 0x00629078
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.EnchantPropertyProbabilityInfo");
		string name = "Id";
		if (Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.get_Id);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.set_Id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache1, true);
		string name2 = "PropertyValues";
		if (Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.get_PropertyValues);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.set_PropertyValues);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache3, true);
		string name3 = "Weight";
		if (Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.get_Weight);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.set_Weight);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache5, true);
		if (Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_EnchantPropertyProbabilityInfo.<>f__mg$cache6, typeof(EnchantPropertyProbabilityInfo));
	}

	// Token: 0x0400D64F RID: 54863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D650 RID: 54864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D651 RID: 54865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D652 RID: 54866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D653 RID: 54867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D654 RID: 54868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D655 RID: 54869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
