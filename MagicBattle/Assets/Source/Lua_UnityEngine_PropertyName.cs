using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001761 RID: 5985
[Preserve]
public class Lua_UnityEngine_PropertyName : LuaObject
{
	// Token: 0x060238BD RID: 145597 RVA: 0x00C69CFC File Offset: 0x00C67EFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 2, out name);
				PropertyName propertyName = new PropertyName(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, propertyName);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(PropertyName)))
			{
				PropertyName other;
				LuaObject.checkValueType<PropertyName>(l, 2, out other);
				PropertyName propertyName = new PropertyName(other);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, propertyName);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int)))
			{
				int id;
				LuaObject.checkType(l, 2, out id);
				PropertyName propertyName = new PropertyName(id);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, propertyName);
				result = 2;
			}
			else if (num == 0)
			{
				PropertyName propertyName = default(PropertyName);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, propertyName);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238BE RID: 145598 RVA: 0x00C69E44 File Offset: 0x00C68044
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNullOrEmpty_s(IntPtr l)
	{
		int result;
		try
		{
			PropertyName prop;
			LuaObject.checkValueType<PropertyName>(l, 1, out prop);
			bool b = PropertyName.IsNullOrEmpty(prop);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238BF RID: 145599 RVA: 0x00C69E98 File Offset: 0x00C68098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			PropertyName lhs;
			LuaObject.checkValueType<PropertyName>(l, 1, out lhs);
			PropertyName rhs;
			LuaObject.checkValueType<PropertyName>(l, 2, out rhs);
			bool b = lhs == rhs;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238C0 RID: 145600 RVA: 0x00C69EF8 File Offset: 0x00C680F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			PropertyName lhs;
			LuaObject.checkValueType<PropertyName>(l, 1, out lhs);
			PropertyName rhs;
			LuaObject.checkValueType<PropertyName>(l, 2, out rhs);
			bool b = lhs != rhs;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238C1 RID: 145601 RVA: 0x00C69F58 File Offset: 0x00C68158
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.PropertyName");
		if (Lua_UnityEngine_PropertyName.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_PropertyName.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_PropertyName.IsNullOrEmpty_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PropertyName.<>f__mg$cache0);
		if (Lua_UnityEngine_PropertyName.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_PropertyName.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_PropertyName.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PropertyName.<>f__mg$cache1);
		if (Lua_UnityEngine_PropertyName.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_PropertyName.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_PropertyName.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_PropertyName.<>f__mg$cache2);
		if (Lua_UnityEngine_PropertyName.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_PropertyName.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_PropertyName.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_PropertyName.<>f__mg$cache3, typeof(PropertyName), typeof(ValueType));
	}

	// Token: 0x04019659 RID: 104025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401965A RID: 104026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401965B RID: 104027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401965C RID: 104028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
