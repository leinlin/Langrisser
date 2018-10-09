using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200168E RID: 5774
[Preserve]
public class Lua_UnityEngine_DrivenRectTransformTracker : LuaObject
{
	// Token: 0x06023083 RID: 143491 RVA: 0x00C21DB4 File Offset: 0x00C1FFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DrivenRectTransformTracker drivenRectTransformTracker = default(DrivenRectTransformTracker);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, drivenRectTransformTracker);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023084 RID: 143492 RVA: 0x00C21E04 File Offset: 0x00C20004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Add(IntPtr l)
	{
		int result;
		try
		{
			DrivenRectTransformTracker drivenRectTransformTracker;
			LuaObject.checkValueType<DrivenRectTransformTracker>(l, 1, out drivenRectTransformTracker);
			UnityEngine.Object driver;
			LuaObject.checkType<UnityEngine.Object>(l, 2, out driver);
			RectTransform rectTransform;
			LuaObject.checkType<RectTransform>(l, 3, out rectTransform);
			DrivenTransformProperties drivenProperties;
			LuaObject.checkEnum<DrivenTransformProperties>(l, 4, out drivenProperties);
			drivenRectTransformTracker.Add(driver, rectTransform, drivenProperties);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, drivenRectTransformTracker);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023085 RID: 143493 RVA: 0x00C21E84 File Offset: 0x00C20084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			DrivenRectTransformTracker drivenRectTransformTracker;
			LuaObject.checkValueType<DrivenRectTransformTracker>(l, 1, out drivenRectTransformTracker);
			drivenRectTransformTracker.Clear();
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, drivenRectTransformTracker);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023086 RID: 143494 RVA: 0x00C21EDC File Offset: 0x00C200DC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.DrivenRectTransformTracker");
		if (Lua_UnityEngine_DrivenRectTransformTracker.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_DrivenRectTransformTracker.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_DrivenRectTransformTracker.Add);
		}
		LuaObject.addMember(l, Lua_UnityEngine_DrivenRectTransformTracker.<>f__mg$cache0);
		if (Lua_UnityEngine_DrivenRectTransformTracker.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_DrivenRectTransformTracker.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_DrivenRectTransformTracker.Clear);
		}
		LuaObject.addMember(l, Lua_UnityEngine_DrivenRectTransformTracker.<>f__mg$cache1);
		if (Lua_UnityEngine_DrivenRectTransformTracker.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_DrivenRectTransformTracker.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_DrivenRectTransformTracker.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_DrivenRectTransformTracker.<>f__mg$cache2, typeof(DrivenRectTransformTracker), typeof(ValueType));
	}

	// Token: 0x04018FC5 RID: 102341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018FC6 RID: 102342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018FC7 RID: 102343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
