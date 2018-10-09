using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016EA RID: 5866
[Preserve]
public class Lua_UnityEngine_IExposedPropertyTable : LuaObject
{
	// Token: 0x06023379 RID: 144249 RVA: 0x00C386F0 File Offset: 0x00C368F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetReferenceValue(IntPtr l)
	{
		int result;
		try
		{
			IExposedPropertyTable exposedPropertyTable = (IExposedPropertyTable)LuaObject.checkSelf(l);
			PropertyName id;
			LuaObject.checkValueType<PropertyName>(l, 2, out id);
			UnityEngine.Object value;
			LuaObject.checkType<UnityEngine.Object>(l, 3, out value);
			exposedPropertyTable.SetReferenceValue(id, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602337A RID: 144250 RVA: 0x00C38754 File Offset: 0x00C36954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetReferenceValue(IntPtr l)
	{
		int result;
		try
		{
			IExposedPropertyTable exposedPropertyTable = (IExposedPropertyTable)LuaObject.checkSelf(l);
			PropertyName id;
			LuaObject.checkValueType<PropertyName>(l, 2, out id);
			bool b;
			UnityEngine.Object referenceValue = exposedPropertyTable.GetReferenceValue(id, out b);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, referenceValue);
			LuaObject.pushValue(l, b);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602337B RID: 144251 RVA: 0x00C387C4 File Offset: 0x00C369C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearReferenceValue(IntPtr l)
	{
		int result;
		try
		{
			IExposedPropertyTable exposedPropertyTable = (IExposedPropertyTable)LuaObject.checkSelf(l);
			PropertyName id;
			LuaObject.checkValueType<PropertyName>(l, 2, out id);
			exposedPropertyTable.ClearReferenceValue(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602337C RID: 144252 RVA: 0x00C3881C File Offset: 0x00C36A1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.IExposedPropertyTable");
		if (Lua_UnityEngine_IExposedPropertyTable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_IExposedPropertyTable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_IExposedPropertyTable.SetReferenceValue);
		}
		LuaObject.addMember(l, Lua_UnityEngine_IExposedPropertyTable.<>f__mg$cache0);
		if (Lua_UnityEngine_IExposedPropertyTable.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_IExposedPropertyTable.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_IExposedPropertyTable.GetReferenceValue);
		}
		LuaObject.addMember(l, Lua_UnityEngine_IExposedPropertyTable.<>f__mg$cache1);
		if (Lua_UnityEngine_IExposedPropertyTable.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_IExposedPropertyTable.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_IExposedPropertyTable.ClearReferenceValue);
		}
		LuaObject.addMember(l, Lua_UnityEngine_IExposedPropertyTable.<>f__mg$cache2);
		LuaObject.createTypeMetatable(l, null, typeof(IExposedPropertyTable));
	}

	// Token: 0x04019203 RID: 102915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019204 RID: 102916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019205 RID: 102917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
