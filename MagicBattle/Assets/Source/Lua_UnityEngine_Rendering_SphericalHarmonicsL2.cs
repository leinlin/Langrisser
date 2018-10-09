using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x020017A4 RID: 6052
[Preserve]
public class Lua_UnityEngine_Rendering_SphericalHarmonicsL2 : LuaObject
{
	// Token: 0x06023B1F RID: 146207 RVA: 0x00C7D8B4 File Offset: 0x00C7BAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SphericalHarmonicsL2 sphericalHarmonicsL = default(SphericalHarmonicsL2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sphericalHarmonicsL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B20 RID: 146208 RVA: 0x00C7D904 File Offset: 0x00C7BB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			SphericalHarmonicsL2 sphericalHarmonicsL;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 1, out sphericalHarmonicsL);
			sphericalHarmonicsL.Clear();
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, sphericalHarmonicsL);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B21 RID: 146209 RVA: 0x00C7D95C File Offset: 0x00C7BB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAmbientLight(IntPtr l)
	{
		int result;
		try
		{
			SphericalHarmonicsL2 sphericalHarmonicsL;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 1, out sphericalHarmonicsL);
			Color color;
			LuaObject.checkType(l, 2, out color);
			sphericalHarmonicsL.AddAmbientLight(color);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, sphericalHarmonicsL);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B22 RID: 146210 RVA: 0x00C7D9C0 File Offset: 0x00C7BBC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDirectionalLight(IntPtr l)
	{
		int result;
		try
		{
			SphericalHarmonicsL2 sphericalHarmonicsL;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 1, out sphericalHarmonicsL);
			Vector3 direction;
			LuaObject.checkType(l, 2, out direction);
			Color color;
			LuaObject.checkType(l, 3, out color);
			float intensity;
			LuaObject.checkType(l, 4, out intensity);
			sphericalHarmonicsL.AddDirectionalLight(direction, color, intensity);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, sphericalHarmonicsL);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B23 RID: 146211 RVA: 0x00C7DA40 File Offset: 0x00C7BC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Evaluate(IntPtr l)
	{
		int result;
		try
		{
			SphericalHarmonicsL2 sphericalHarmonicsL;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 1, out sphericalHarmonicsL);
			Vector3[] directions;
			LuaObject.checkArray<Vector3>(l, 2, out directions);
			Color[] results;
			LuaObject.checkArray<Color>(l, 3, out results);
			sphericalHarmonicsL.Evaluate(directions, results);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, sphericalHarmonicsL);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B24 RID: 146212 RVA: 0x00C7DAB0 File Offset: 0x00C7BCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Multiply(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(float), typeof(SphericalHarmonicsL2)))
			{
				float lhs;
				LuaObject.checkType(l, 1, out lhs);
				SphericalHarmonicsL2 rhs;
				LuaObject.checkValueType<SphericalHarmonicsL2>(l, 2, out rhs);
				SphericalHarmonicsL2 sphericalHarmonicsL = lhs * rhs;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, sphericalHarmonicsL);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(SphericalHarmonicsL2), typeof(float)))
			{
				SphericalHarmonicsL2 lhs2;
				LuaObject.checkValueType<SphericalHarmonicsL2>(l, 1, out lhs2);
				float rhs2;
				LuaObject.checkType(l, 2, out rhs2);
				SphericalHarmonicsL2 sphericalHarmonicsL2 = lhs2 * rhs2;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, sphericalHarmonicsL2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function op_Multiply to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B25 RID: 146213 RVA: 0x00C7DBB8 File Offset: 0x00C7BDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Addition(IntPtr l)
	{
		int result;
		try
		{
			SphericalHarmonicsL2 lhs;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 1, out lhs);
			SphericalHarmonicsL2 rhs;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 2, out rhs);
			SphericalHarmonicsL2 sphericalHarmonicsL = lhs + rhs;
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sphericalHarmonicsL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B26 RID: 146214 RVA: 0x00C7DC1C File Offset: 0x00C7BE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			SphericalHarmonicsL2 lhs;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 1, out lhs);
			SphericalHarmonicsL2 rhs;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 2, out rhs);
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

	// Token: 0x06023B27 RID: 146215 RVA: 0x00C7DC7C File Offset: 0x00C7BE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			SphericalHarmonicsL2 lhs;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 1, out lhs);
			SphericalHarmonicsL2 rhs;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 2, out rhs);
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

	// Token: 0x06023B28 RID: 146216 RVA: 0x00C7DCDC File Offset: 0x00C7BEDC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rendering.SphericalHarmonicsL2");
		if (Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rendering_SphericalHarmonicsL2.Clear);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache0);
		if (Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rendering_SphericalHarmonicsL2.AddAmbientLight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache1);
		if (Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Rendering_SphericalHarmonicsL2.AddDirectionalLight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache2);
		if (Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Rendering_SphericalHarmonicsL2.Evaluate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache3);
		if (Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Rendering_SphericalHarmonicsL2.op_Multiply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache4);
		if (Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Rendering_SphericalHarmonicsL2.op_Addition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache5);
		if (Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Rendering_SphericalHarmonicsL2.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache6);
		if (Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Rendering_SphericalHarmonicsL2.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache7);
		if (Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Rendering_SphericalHarmonicsL2.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Rendering_SphericalHarmonicsL2.<>f__mg$cache8, typeof(SphericalHarmonicsL2), typeof(ValueType));
	}

	// Token: 0x04019835 RID: 104501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019836 RID: 104502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019837 RID: 104503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019838 RID: 104504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019839 RID: 104505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401983A RID: 104506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401983B RID: 104507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401983C RID: 104508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401983D RID: 104509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
