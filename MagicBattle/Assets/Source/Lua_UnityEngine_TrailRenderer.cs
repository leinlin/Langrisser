using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001804 RID: 6148
[Preserve]
public class Lua_UnityEngine_TrailRenderer : LuaObject
{
	// Token: 0x06023F13 RID: 147219 RVA: 0x00C9C098 File Offset: 0x00C9A298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPositions(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			Vector3[] positions;
			LuaObject.checkArray<Vector3>(l, 2, out positions);
			int positions2 = trailRenderer.GetPositions(positions);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, positions2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F14 RID: 147220 RVA: 0x00C9C0FC File Offset: 0x00C9A2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPosition(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Vector3 position = trailRenderer.GetPosition(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F15 RID: 147221 RVA: 0x00C9C160 File Offset: 0x00C9A360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			trailRenderer.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F16 RID: 147222 RVA: 0x00C9C1AC File Offset: 0x00C9A3AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_widthCurve(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.widthCurve);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F17 RID: 147223 RVA: 0x00C9C200 File Offset: 0x00C9A400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_widthCurve(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			AnimationCurve widthCurve;
			LuaObject.checkType<AnimationCurve>(l, 2, out widthCurve);
			trailRenderer.widthCurve = widthCurve;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F18 RID: 147224 RVA: 0x00C9C258 File Offset: 0x00C9A458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colorGradient(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.colorGradient);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F19 RID: 147225 RVA: 0x00C9C2AC File Offset: 0x00C9A4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colorGradient(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			Gradient colorGradient;
			LuaObject.checkType<Gradient>(l, 2, out colorGradient);
			trailRenderer.colorGradient = colorGradient;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F1A RID: 147226 RVA: 0x00C9C304 File Offset: 0x00C9A504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_time(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F1B RID: 147227 RVA: 0x00C9C358 File Offset: 0x00C9A558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_time(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			trailRenderer.time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F1C RID: 147228 RVA: 0x00C9C3B0 File Offset: 0x00C9A5B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_startWidth(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.startWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F1D RID: 147229 RVA: 0x00C9C404 File Offset: 0x00C9A604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_startWidth(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			float startWidth;
			LuaObject.checkType(l, 2, out startWidth);
			trailRenderer.startWidth = startWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F1E RID: 147230 RVA: 0x00C9C45C File Offset: 0x00C9A65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_endWidth(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.endWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F1F RID: 147231 RVA: 0x00C9C4B0 File Offset: 0x00C9A6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_endWidth(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			float endWidth;
			LuaObject.checkType(l, 2, out endWidth);
			trailRenderer.endWidth = endWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F20 RID: 147232 RVA: 0x00C9C508 File Offset: 0x00C9A708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_widthMultiplier(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.widthMultiplier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F21 RID: 147233 RVA: 0x00C9C55C File Offset: 0x00C9A75C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_widthMultiplier(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			float widthMultiplier;
			LuaObject.checkType(l, 2, out widthMultiplier);
			trailRenderer.widthMultiplier = widthMultiplier;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F22 RID: 147234 RVA: 0x00C9C5B4 File Offset: 0x00C9A7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autodestruct(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.autodestruct);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F23 RID: 147235 RVA: 0x00C9C608 File Offset: 0x00C9A808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autodestruct(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			bool autodestruct;
			LuaObject.checkType(l, 2, out autodestruct);
			trailRenderer.autodestruct = autodestruct;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F24 RID: 147236 RVA: 0x00C9C660 File Offset: 0x00C9A860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_numCornerVertices(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.numCornerVertices);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F25 RID: 147237 RVA: 0x00C9C6B4 File Offset: 0x00C9A8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_numCornerVertices(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			int numCornerVertices;
			LuaObject.checkType(l, 2, out numCornerVertices);
			trailRenderer.numCornerVertices = numCornerVertices;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F26 RID: 147238 RVA: 0x00C9C70C File Offset: 0x00C9A90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_numCapVertices(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.numCapVertices);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F27 RID: 147239 RVA: 0x00C9C760 File Offset: 0x00C9A960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_numCapVertices(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			int numCapVertices;
			LuaObject.checkType(l, 2, out numCapVertices);
			trailRenderer.numCapVertices = numCapVertices;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F28 RID: 147240 RVA: 0x00C9C7B8 File Offset: 0x00C9A9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minVertexDistance(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.minVertexDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F29 RID: 147241 RVA: 0x00C9C80C File Offset: 0x00C9AA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_minVertexDistance(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			float minVertexDistance;
			LuaObject.checkType(l, 2, out minVertexDistance);
			trailRenderer.minVertexDistance = minVertexDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F2A RID: 147242 RVA: 0x00C9C864 File Offset: 0x00C9AA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_startColor(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.startColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F2B RID: 147243 RVA: 0x00C9C8B8 File Offset: 0x00C9AAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_startColor(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			Color startColor;
			LuaObject.checkType(l, 2, out startColor);
			trailRenderer.startColor = startColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F2C RID: 147244 RVA: 0x00C9C910 File Offset: 0x00C9AB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_endColor(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.endColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F2D RID: 147245 RVA: 0x00C9C964 File Offset: 0x00C9AB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_endColor(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			Color endColor;
			LuaObject.checkType(l, 2, out endColor);
			trailRenderer.endColor = endColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F2E RID: 147246 RVA: 0x00C9C9BC File Offset: 0x00C9ABBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_positionCount(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.positionCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F2F RID: 147247 RVA: 0x00C9CA10 File Offset: 0x00C9AC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_generateLightingData(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trailRenderer.generateLightingData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F30 RID: 147248 RVA: 0x00C9CA64 File Offset: 0x00C9AC64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_generateLightingData(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			bool generateLightingData;
			LuaObject.checkType(l, 2, out generateLightingData);
			trailRenderer.generateLightingData = generateLightingData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F31 RID: 147249 RVA: 0x00C9CABC File Offset: 0x00C9ACBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_textureMode(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)trailRenderer.textureMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F32 RID: 147250 RVA: 0x00C9CB10 File Offset: 0x00C9AD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_textureMode(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LineTextureMode textureMode;
			LuaObject.checkEnum<LineTextureMode>(l, 2, out textureMode);
			trailRenderer.textureMode = textureMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F33 RID: 147251 RVA: 0x00C9CB68 File Offset: 0x00C9AD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alignment(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)trailRenderer.alignment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F34 RID: 147252 RVA: 0x00C9CBBC File Offset: 0x00C9ADBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alignment(IntPtr l)
	{
		int result;
		try
		{
			TrailRenderer trailRenderer = (TrailRenderer)LuaObject.checkSelf(l);
			LineAlignment alignment;
			LuaObject.checkEnum<LineAlignment>(l, 2, out alignment);
			trailRenderer.alignment = alignment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F35 RID: 147253 RVA: 0x00C9CC14 File Offset: 0x00C9AE14
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.TrailRenderer");
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.GetPositions);
		}
		LuaObject.addMember(l, Lua_UnityEngine_TrailRenderer.<>f__mg$cache0);
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.GetPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_TrailRenderer.<>f__mg$cache1);
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.Clear);
		}
		LuaObject.addMember(l, Lua_UnityEngine_TrailRenderer.<>f__mg$cache2);
		string name = "widthCurve";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_widthCurve);
		}
		LuaCSFunction get = Lua_UnityEngine_TrailRenderer.<>f__mg$cache3;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_widthCurve);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_TrailRenderer.<>f__mg$cache4, true);
		string name2 = "colorGradient";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_colorGradient);
		}
		LuaCSFunction get2 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache5;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_colorGradient);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_TrailRenderer.<>f__mg$cache6, true);
		string name3 = "time";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_time);
		}
		LuaCSFunction get3 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache7;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_time);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_TrailRenderer.<>f__mg$cache8, true);
		string name4 = "startWidth";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_startWidth);
		}
		LuaCSFunction get4 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache9;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_startWidth);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_TrailRenderer.<>f__mg$cacheA, true);
		string name5 = "endWidth";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_endWidth);
		}
		LuaCSFunction get5 = Lua_UnityEngine_TrailRenderer.<>f__mg$cacheB;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_endWidth);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_TrailRenderer.<>f__mg$cacheC, true);
		string name6 = "widthMultiplier";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_widthMultiplier);
		}
		LuaCSFunction get6 = Lua_UnityEngine_TrailRenderer.<>f__mg$cacheD;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_widthMultiplier);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_TrailRenderer.<>f__mg$cacheE, true);
		string name7 = "autodestruct";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_autodestruct);
		}
		LuaCSFunction get7 = Lua_UnityEngine_TrailRenderer.<>f__mg$cacheF;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_autodestruct);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_TrailRenderer.<>f__mg$cache10, true);
		string name8 = "numCornerVertices";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_numCornerVertices);
		}
		LuaCSFunction get8 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache11;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_numCornerVertices);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_TrailRenderer.<>f__mg$cache12, true);
		string name9 = "numCapVertices";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_numCapVertices);
		}
		LuaCSFunction get9 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache13;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_numCapVertices);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_TrailRenderer.<>f__mg$cache14, true);
		string name10 = "minVertexDistance";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_minVertexDistance);
		}
		LuaCSFunction get10 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache15;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_minVertexDistance);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_TrailRenderer.<>f__mg$cache16, true);
		string name11 = "startColor";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_startColor);
		}
		LuaCSFunction get11 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache17;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_startColor);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_TrailRenderer.<>f__mg$cache18, true);
		string name12 = "endColor";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_endColor);
		}
		LuaCSFunction get12 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache19;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_endColor);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_TrailRenderer.<>f__mg$cache1A, true);
		string name13 = "positionCount";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_positionCount);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_TrailRenderer.<>f__mg$cache1B, null, true);
		string name14 = "generateLightingData";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_generateLightingData);
		}
		LuaCSFunction get13 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache1C;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_generateLightingData);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_TrailRenderer.<>f__mg$cache1D, true);
		string name15 = "textureMode";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_textureMode);
		}
		LuaCSFunction get14 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache1E;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_textureMode);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_TrailRenderer.<>f__mg$cache1F, true);
		string name16 = "alignment";
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.get_alignment);
		}
		LuaCSFunction get15 = Lua_UnityEngine_TrailRenderer.<>f__mg$cache20;
		if (Lua_UnityEngine_TrailRenderer.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_TrailRenderer.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_TrailRenderer.set_alignment);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_TrailRenderer.<>f__mg$cache21, true);
		LuaObject.createTypeMetatable(l, null, typeof(TrailRenderer), typeof(Renderer));
	}

	// Token: 0x04019B69 RID: 105321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019B6A RID: 105322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019B6B RID: 105323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019B6C RID: 105324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019B6D RID: 105325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019B6E RID: 105326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019B6F RID: 105327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019B70 RID: 105328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019B71 RID: 105329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019B72 RID: 105330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019B73 RID: 105331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019B74 RID: 105332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019B75 RID: 105333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019B76 RID: 105334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019B77 RID: 105335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019B78 RID: 105336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019B79 RID: 105337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019B7A RID: 105338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019B7B RID: 105339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019B7C RID: 105340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019B7D RID: 105341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019B7E RID: 105342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019B7F RID: 105343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019B80 RID: 105344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019B81 RID: 105345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019B82 RID: 105346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019B83 RID: 105347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019B84 RID: 105348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019B85 RID: 105349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019B86 RID: 105350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019B87 RID: 105351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019B88 RID: 105352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019B89 RID: 105353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019B8A RID: 105354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
