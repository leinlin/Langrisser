using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001862 RID: 6242
[Preserve]
public class Lua_UnityEngine_UI_StencilMaterial : LuaObject
{
	// Token: 0x060242B4 RID: 148148 RVA: 0x00CB440C File Offset: 0x00CB260C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Add_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				Material baseMat;
				LuaObject.checkType<Material>(l, 1, out baseMat);
				int stencilID;
				LuaObject.checkType(l, 2, out stencilID);
				StencilOp operation;
				LuaObject.checkEnum<StencilOp>(l, 3, out operation);
				CompareFunction compareFunction;
				LuaObject.checkEnum<CompareFunction>(l, 4, out compareFunction);
				ColorWriteMask colorWriteMask;
				LuaObject.checkEnum<ColorWriteMask>(l, 5, out colorWriteMask);
				Material o = StencilMaterial.Add(baseMat, stencilID, operation, compareFunction, colorWriteMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 7)
			{
				Material baseMat2;
				LuaObject.checkType<Material>(l, 1, out baseMat2);
				int stencilID2;
				LuaObject.checkType(l, 2, out stencilID2);
				StencilOp operation2;
				LuaObject.checkEnum<StencilOp>(l, 3, out operation2);
				CompareFunction compareFunction2;
				LuaObject.checkEnum<CompareFunction>(l, 4, out compareFunction2);
				ColorWriteMask colorWriteMask2;
				LuaObject.checkEnum<ColorWriteMask>(l, 5, out colorWriteMask2);
				int readMask;
				LuaObject.checkType(l, 6, out readMask);
				int writeMask;
				LuaObject.checkType(l, 7, out writeMask);
				Material o2 = StencilMaterial.Add(baseMat2, stencilID2, operation2, compareFunction2, colorWriteMask2, readMask, writeMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Add to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242B5 RID: 148149 RVA: 0x00CB4534 File Offset: 0x00CB2734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Remove_s(IntPtr l)
	{
		int result;
		try
		{
			Material customMat;
			LuaObject.checkType<Material>(l, 1, out customMat);
			StencilMaterial.Remove(customMat);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242B6 RID: 148150 RVA: 0x00CB4580 File Offset: 0x00CB2780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAll_s(IntPtr l)
	{
		int result;
		try
		{
			StencilMaterial.ClearAll();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242B7 RID: 148151 RVA: 0x00CB45C0 File Offset: 0x00CB27C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.StencilMaterial");
		if (Lua_UnityEngine_UI_StencilMaterial.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_StencilMaterial.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_StencilMaterial.Add_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_StencilMaterial.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_StencilMaterial.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_StencilMaterial.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_StencilMaterial.Remove_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_StencilMaterial.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_StencilMaterial.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_StencilMaterial.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_StencilMaterial.ClearAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_StencilMaterial.<>f__mg$cache2);
		LuaObject.createTypeMetatable(l, null, typeof(StencilMaterial));
	}

	// Token: 0x04019E4E RID: 106062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019E4F RID: 106063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019E50 RID: 106064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
