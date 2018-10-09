using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x0200178B RID: 6027
[Preserve]
public class Lua_UnityEngine_Rendering_GraphicsSettings : LuaObject
{
	// Token: 0x06023ACF RID: 146127 RVA: 0x00C7BF14 File Offset: 0x00C7A114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GraphicsSettings o = new GraphicsSettings();
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

	// Token: 0x06023AD0 RID: 146128 RVA: 0x00C7BF5C File Offset: 0x00C7A15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetShaderMode_s(IntPtr l)
	{
		int result;
		try
		{
			BuiltinShaderType type;
			LuaObject.checkEnum<BuiltinShaderType>(l, 1, out type);
			BuiltinShaderMode mode;
			LuaObject.checkEnum<BuiltinShaderMode>(l, 2, out mode);
			GraphicsSettings.SetShaderMode(type, mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AD1 RID: 146129 RVA: 0x00C7BFB4 File Offset: 0x00C7A1B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetShaderMode_s(IntPtr l)
	{
		int result;
		try
		{
			BuiltinShaderType type;
			LuaObject.checkEnum<BuiltinShaderType>(l, 1, out type);
			BuiltinShaderMode shaderMode = GraphicsSettings.GetShaderMode(type);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)shaderMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AD2 RID: 146130 RVA: 0x00C7C008 File Offset: 0x00C7A208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCustomShader_s(IntPtr l)
	{
		int result;
		try
		{
			BuiltinShaderType type;
			LuaObject.checkEnum<BuiltinShaderType>(l, 1, out type);
			Shader shader;
			LuaObject.checkType<Shader>(l, 2, out shader);
			GraphicsSettings.SetCustomShader(type, shader);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AD3 RID: 146131 RVA: 0x00C7C060 File Offset: 0x00C7A260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCustomShader_s(IntPtr l)
	{
		int result;
		try
		{
			BuiltinShaderType type;
			LuaObject.checkEnum<BuiltinShaderType>(l, 1, out type);
			Shader customShader = GraphicsSettings.GetCustomShader(type);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customShader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AD4 RID: 146132 RVA: 0x00C7C0B4 File Offset: 0x00C7A2B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasShaderDefine_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				BuiltinShaderDefine defineHash;
				LuaObject.checkEnum<BuiltinShaderDefine>(l, 1, out defineHash);
				bool b = GraphicsSettings.HasShaderDefine(defineHash);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				GraphicsTier tier;
				LuaObject.checkEnum<GraphicsTier>(l, 1, out tier);
				BuiltinShaderDefine defineHash2;
				LuaObject.checkEnum<BuiltinShaderDefine>(l, 2, out defineHash2);
				bool b2 = GraphicsSettings.HasShaderDefine(tier, defineHash2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function HasShaderDefine to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AD5 RID: 146133 RVA: 0x00C7C16C File Offset: 0x00C7A36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderPipelineAsset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GraphicsSettings.renderPipelineAsset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AD6 RID: 146134 RVA: 0x00C7C1B4 File Offset: 0x00C7A3B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_renderPipelineAsset(IntPtr l)
	{
		int result;
		try
		{
			RenderPipelineAsset renderPipelineAsset;
			LuaObject.checkType<RenderPipelineAsset>(l, 2, out renderPipelineAsset);
			GraphicsSettings.renderPipelineAsset = renderPipelineAsset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AD7 RID: 146135 RVA: 0x00C7C200 File Offset: 0x00C7A400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transparencySortMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)GraphicsSettings.transparencySortMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AD8 RID: 146136 RVA: 0x00C7C248 File Offset: 0x00C7A448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_transparencySortMode(IntPtr l)
	{
		int result;
		try
		{
			TransparencySortMode transparencySortMode;
			LuaObject.checkEnum<TransparencySortMode>(l, 2, out transparencySortMode);
			GraphicsSettings.transparencySortMode = transparencySortMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023AD9 RID: 146137 RVA: 0x00C7C294 File Offset: 0x00C7A494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transparencySortAxis(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GraphicsSettings.transparencySortAxis);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ADA RID: 146138 RVA: 0x00C7C2DC File Offset: 0x00C7A4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_transparencySortAxis(IntPtr l)
	{
		int result;
		try
		{
			Vector3 transparencySortAxis;
			LuaObject.checkType(l, 2, out transparencySortAxis);
			GraphicsSettings.transparencySortAxis = transparencySortAxis;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ADB RID: 146139 RVA: 0x00C7C328 File Offset: 0x00C7A528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lightsUseLinearIntensity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GraphicsSettings.lightsUseLinearIntensity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ADC RID: 146140 RVA: 0x00C7C370 File Offset: 0x00C7A570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightsUseLinearIntensity(IntPtr l)
	{
		int result;
		try
		{
			bool lightsUseLinearIntensity;
			LuaObject.checkType(l, 2, out lightsUseLinearIntensity);
			GraphicsSettings.lightsUseLinearIntensity = lightsUseLinearIntensity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ADD RID: 146141 RVA: 0x00C7C3BC File Offset: 0x00C7A5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lightsUseColorTemperature(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GraphicsSettings.lightsUseColorTemperature);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ADE RID: 146142 RVA: 0x00C7C404 File Offset: 0x00C7A604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightsUseColorTemperature(IntPtr l)
	{
		int result;
		try
		{
			bool lightsUseColorTemperature;
			LuaObject.checkType(l, 2, out lightsUseColorTemperature);
			GraphicsSettings.lightsUseColorTemperature = lightsUseColorTemperature;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ADF RID: 146143 RVA: 0x00C7C450 File Offset: 0x00C7A650
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rendering.GraphicsSettings");
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.SetShaderMode_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache0);
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.GetShaderMode_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache1);
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.SetCustomShader_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache2);
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.GetCustomShader_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache3);
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.HasShaderDefine_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache4);
		string name = "renderPipelineAsset";
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.get_renderPipelineAsset);
		}
		LuaCSFunction get = Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache5;
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.set_renderPipelineAsset);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache6, false);
		string name2 = "transparencySortMode";
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.get_transparencySortMode);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache7;
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.set_transparencySortMode);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache8, false);
		string name3 = "transparencySortAxis";
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.get_transparencySortAxis);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cache9;
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.set_transparencySortAxis);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheA, false);
		string name4 = "lightsUseLinearIntensity";
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.get_lightsUseLinearIntensity);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheB;
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.set_lightsUseLinearIntensity);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheC, false);
		string name5 = "lightsUseColorTemperature";
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.get_lightsUseColorTemperature);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheD;
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.set_lightsUseColorTemperature);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheE, false);
		if (Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Rendering_GraphicsSettings.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Rendering_GraphicsSettings.<>f__mg$cacheF, typeof(GraphicsSettings), typeof(UnityEngine.Object));
	}

	// Token: 0x04019817 RID: 104471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019818 RID: 104472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019819 RID: 104473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401981A RID: 104474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401981B RID: 104475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401981C RID: 104476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401981D RID: 104477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401981E RID: 104478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401981F RID: 104479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019820 RID: 104480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019821 RID: 104481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019822 RID: 104482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019823 RID: 104483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019824 RID: 104484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019825 RID: 104485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019826 RID: 104486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
