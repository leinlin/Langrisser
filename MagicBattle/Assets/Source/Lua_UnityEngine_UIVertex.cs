using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200186E RID: 6254
[Preserve]
public class Lua_UnityEngine_UIVertex : LuaObject
{
	// Token: 0x06024335 RID: 148277 RVA: 0x00CB7A70 File Offset: 0x00CB5C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex = default(UIVertex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uivertex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024336 RID: 148278 RVA: 0x00CB7AC0 File Offset: 0x00CB5CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uivertex.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024337 RID: 148279 RVA: 0x00CB7B14 File Offset: 0x00CB5D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			uivertex.position = position;
			LuaObject.setBack(l, uivertex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024338 RID: 148280 RVA: 0x00CB7B78 File Offset: 0x00CB5D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normal(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uivertex.normal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024339 RID: 148281 RVA: 0x00CB7BCC File Offset: 0x00CB5DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_normal(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			Vector3 normal;
			LuaObject.checkType(l, 2, out normal);
			uivertex.normal = normal;
			LuaObject.setBack(l, uivertex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602433A RID: 148282 RVA: 0x00CB7C30 File Offset: 0x00CB5E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_color(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uivertex.color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602433B RID: 148283 RVA: 0x00CB7C84 File Offset: 0x00CB5E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_color(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			Color32 color;
			LuaObject.checkValueType<Color32>(l, 2, out color);
			uivertex.color = color;
			LuaObject.setBack(l, uivertex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602433C RID: 148284 RVA: 0x00CB7CE8 File Offset: 0x00CB5EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uv0(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uivertex.uv0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602433D RID: 148285 RVA: 0x00CB7D3C File Offset: 0x00CB5F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uv0(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			Vector2 uv;
			LuaObject.checkType(l, 2, out uv);
			uivertex.uv0 = uv;
			LuaObject.setBack(l, uivertex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602433E RID: 148286 RVA: 0x00CB7DA0 File Offset: 0x00CB5FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uv1(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uivertex.uv1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602433F RID: 148287 RVA: 0x00CB7DF4 File Offset: 0x00CB5FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uv1(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			Vector2 uv;
			LuaObject.checkType(l, 2, out uv);
			uivertex.uv1 = uv;
			LuaObject.setBack(l, uivertex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024340 RID: 148288 RVA: 0x00CB7E58 File Offset: 0x00CB6058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uv2(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uivertex.uv2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024341 RID: 148289 RVA: 0x00CB7EAC File Offset: 0x00CB60AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_uv2(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			Vector2 uv;
			LuaObject.checkType(l, 2, out uv);
			uivertex.uv2 = uv;
			LuaObject.setBack(l, uivertex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024342 RID: 148290 RVA: 0x00CB7F10 File Offset: 0x00CB6110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uv3(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uivertex.uv3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024343 RID: 148291 RVA: 0x00CB7F64 File Offset: 0x00CB6164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uv3(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			Vector2 uv;
			LuaObject.checkType(l, 2, out uv);
			uivertex.uv3 = uv;
			LuaObject.setBack(l, uivertex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024344 RID: 148292 RVA: 0x00CB7FC8 File Offset: 0x00CB61C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tangent(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uivertex.tangent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024345 RID: 148293 RVA: 0x00CB801C File Offset: 0x00CB621C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_tangent(IntPtr l)
	{
		int result;
		try
		{
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 1, out uivertex);
			Vector4 tangent;
			LuaObject.checkType(l, 2, out tangent);
			uivertex.tangent = tangent;
			LuaObject.setBack(l, uivertex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024346 RID: 148294 RVA: 0x00CB8080 File Offset: 0x00CB6280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_simpleVert(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIVertex.simpleVert);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024347 RID: 148295 RVA: 0x00CB80CC File Offset: 0x00CB62CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_simpleVert(IntPtr l)
	{
		int result;
		try
		{
			UIVertex simpleVert;
			LuaObject.checkValueType<UIVertex>(l, 2, out simpleVert);
			UIVertex.simpleVert = simpleVert;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024348 RID: 148296 RVA: 0x00CB8118 File Offset: 0x00CB6318
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UIVertex");
		string name = "position";
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UIVertex.get_position);
		}
		LuaCSFunction get = Lua_UnityEngine_UIVertex.<>f__mg$cache0;
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UIVertex.set_position);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UIVertex.<>f__mg$cache1, true);
		string name2 = "normal";
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UIVertex.get_normal);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UIVertex.<>f__mg$cache2;
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UIVertex.set_normal);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UIVertex.<>f__mg$cache3, true);
		string name3 = "color";
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UIVertex.get_color);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UIVertex.<>f__mg$cache4;
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UIVertex.set_color);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UIVertex.<>f__mg$cache5, true);
		string name4 = "uv0";
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UIVertex.get_uv0);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UIVertex.<>f__mg$cache6;
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UIVertex.set_uv0);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UIVertex.<>f__mg$cache7, true);
		string name5 = "uv1";
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UIVertex.get_uv1);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UIVertex.<>f__mg$cache8;
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UIVertex.set_uv1);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UIVertex.<>f__mg$cache9, true);
		string name6 = "uv2";
		if (Lua_UnityEngine_UIVertex.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UIVertex.get_uv2);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UIVertex.<>f__mg$cacheA;
		if (Lua_UnityEngine_UIVertex.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UIVertex.set_uv2);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UIVertex.<>f__mg$cacheB, true);
		string name7 = "uv3";
		if (Lua_UnityEngine_UIVertex.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UIVertex.get_uv3);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UIVertex.<>f__mg$cacheC;
		if (Lua_UnityEngine_UIVertex.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UIVertex.set_uv3);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_UIVertex.<>f__mg$cacheD, true);
		string name8 = "tangent";
		if (Lua_UnityEngine_UIVertex.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UIVertex.get_tangent);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UIVertex.<>f__mg$cacheE;
		if (Lua_UnityEngine_UIVertex.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UIVertex.set_tangent);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_UIVertex.<>f__mg$cacheF, true);
		string name9 = "simpleVert";
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UIVertex.get_simpleVert);
		}
		LuaCSFunction get9 = Lua_UnityEngine_UIVertex.<>f__mg$cache10;
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UIVertex.set_simpleVert);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_UIVertex.<>f__mg$cache11, false);
		if (Lua_UnityEngine_UIVertex.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UIVertex.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UIVertex.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UIVertex.<>f__mg$cache12, typeof(UIVertex), typeof(ValueType));
	}

	// Token: 0x04019EB7 RID: 106167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019EB8 RID: 106168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019EB9 RID: 106169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019EBA RID: 106170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019EBB RID: 106171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019EBC RID: 106172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019EBD RID: 106173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019EBE RID: 106174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019EBF RID: 106175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019EC0 RID: 106176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019EC1 RID: 106177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019EC2 RID: 106178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019EC3 RID: 106179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019EC4 RID: 106180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019EC5 RID: 106181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019EC6 RID: 106182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019EC7 RID: 106183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019EC8 RID: 106184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019EC9 RID: 106185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
