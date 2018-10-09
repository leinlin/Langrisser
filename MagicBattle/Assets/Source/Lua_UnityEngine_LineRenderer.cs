using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001717 RID: 5911
[Preserve]
public class Lua_UnityEngine_LineRenderer : LuaObject
{
	// Token: 0x060234F6 RID: 144630 RVA: 0x00C434A8 File Offset: 0x00C416A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPositions(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			Vector3[] positions;
			LuaObject.checkArray<Vector3>(l, 2, out positions);
			lineRenderer.SetPositions(positions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234F7 RID: 144631 RVA: 0x00C43500 File Offset: 0x00C41700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPositions(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			Vector3[] positions;
			LuaObject.checkArray<Vector3>(l, 2, out positions);
			int positions2 = lineRenderer.GetPositions(positions);
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

	// Token: 0x060234F8 RID: 144632 RVA: 0x00C43564 File Offset: 0x00C41764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPosition(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Vector3 position;
			LuaObject.checkType(l, 3, out position);
			lineRenderer.SetPosition(index, position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234F9 RID: 144633 RVA: 0x00C435C8 File Offset: 0x00C417C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPosition(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Vector3 position = lineRenderer.GetPosition(index);
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

	// Token: 0x060234FA RID: 144634 RVA: 0x00C4362C File Offset: 0x00C4182C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Simplify(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			float tolerance;
			LuaObject.checkType(l, 2, out tolerance);
			lineRenderer.Simplify(tolerance);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234FB RID: 144635 RVA: 0x00C43684 File Offset: 0x00C41884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_widthCurve(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.widthCurve);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234FC RID: 144636 RVA: 0x00C436D8 File Offset: 0x00C418D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_widthCurve(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			AnimationCurve widthCurve;
			LuaObject.checkType<AnimationCurve>(l, 2, out widthCurve);
			lineRenderer.widthCurve = widthCurve;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234FD RID: 144637 RVA: 0x00C43730 File Offset: 0x00C41930
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_colorGradient(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.colorGradient);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234FE RID: 144638 RVA: 0x00C43784 File Offset: 0x00C41984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colorGradient(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			Gradient colorGradient;
			LuaObject.checkType<Gradient>(l, 2, out colorGradient);
			lineRenderer.colorGradient = colorGradient;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234FF RID: 144639 RVA: 0x00C437DC File Offset: 0x00C419DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_startWidth(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.startWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023500 RID: 144640 RVA: 0x00C43830 File Offset: 0x00C41A30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_startWidth(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			float startWidth;
			LuaObject.checkType(l, 2, out startWidth);
			lineRenderer.startWidth = startWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023501 RID: 144641 RVA: 0x00C43888 File Offset: 0x00C41A88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_endWidth(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.endWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023502 RID: 144642 RVA: 0x00C438DC File Offset: 0x00C41ADC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_endWidth(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			float endWidth;
			LuaObject.checkType(l, 2, out endWidth);
			lineRenderer.endWidth = endWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023503 RID: 144643 RVA: 0x00C43934 File Offset: 0x00C41B34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_widthMultiplier(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.widthMultiplier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023504 RID: 144644 RVA: 0x00C43988 File Offset: 0x00C41B88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_widthMultiplier(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			float widthMultiplier;
			LuaObject.checkType(l, 2, out widthMultiplier);
			lineRenderer.widthMultiplier = widthMultiplier;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023505 RID: 144645 RVA: 0x00C439E0 File Offset: 0x00C41BE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_numCornerVertices(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.numCornerVertices);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023506 RID: 144646 RVA: 0x00C43A34 File Offset: 0x00C41C34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_numCornerVertices(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			int numCornerVertices;
			LuaObject.checkType(l, 2, out numCornerVertices);
			lineRenderer.numCornerVertices = numCornerVertices;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023507 RID: 144647 RVA: 0x00C43A8C File Offset: 0x00C41C8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_numCapVertices(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.numCapVertices);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023508 RID: 144648 RVA: 0x00C43AE0 File Offset: 0x00C41CE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_numCapVertices(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			int numCapVertices;
			LuaObject.checkType(l, 2, out numCapVertices);
			lineRenderer.numCapVertices = numCapVertices;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023509 RID: 144649 RVA: 0x00C43B38 File Offset: 0x00C41D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useWorldSpace(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.useWorldSpace);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602350A RID: 144650 RVA: 0x00C43B8C File Offset: 0x00C41D8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_useWorldSpace(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			bool useWorldSpace;
			LuaObject.checkType(l, 2, out useWorldSpace);
			lineRenderer.useWorldSpace = useWorldSpace;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602350B RID: 144651 RVA: 0x00C43BE4 File Offset: 0x00C41DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_loop(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.loop);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602350C RID: 144652 RVA: 0x00C43C38 File Offset: 0x00C41E38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_loop(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			bool loop;
			LuaObject.checkType(l, 2, out loop);
			lineRenderer.loop = loop;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602350D RID: 144653 RVA: 0x00C43C90 File Offset: 0x00C41E90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_startColor(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.startColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602350E RID: 144654 RVA: 0x00C43CE4 File Offset: 0x00C41EE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_startColor(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			Color startColor;
			LuaObject.checkType(l, 2, out startColor);
			lineRenderer.startColor = startColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602350F RID: 144655 RVA: 0x00C43D3C File Offset: 0x00C41F3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_endColor(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.endColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023510 RID: 144656 RVA: 0x00C43D90 File Offset: 0x00C41F90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_endColor(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			Color endColor;
			LuaObject.checkType(l, 2, out endColor);
			lineRenderer.endColor = endColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023511 RID: 144657 RVA: 0x00C43DE8 File Offset: 0x00C41FE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_positionCount(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.positionCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023512 RID: 144658 RVA: 0x00C43E3C File Offset: 0x00C4203C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_positionCount(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			int positionCount;
			LuaObject.checkType(l, 2, out positionCount);
			lineRenderer.positionCount = positionCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023513 RID: 144659 RVA: 0x00C43E94 File Offset: 0x00C42094
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_generateLightingData(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineRenderer.generateLightingData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023514 RID: 144660 RVA: 0x00C43EE8 File Offset: 0x00C420E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_generateLightingData(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			bool generateLightingData;
			LuaObject.checkType(l, 2, out generateLightingData);
			lineRenderer.generateLightingData = generateLightingData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023515 RID: 144661 RVA: 0x00C43F40 File Offset: 0x00C42140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_textureMode(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)lineRenderer.textureMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023516 RID: 144662 RVA: 0x00C43F94 File Offset: 0x00C42194
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_textureMode(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LineTextureMode textureMode;
			LuaObject.checkEnum<LineTextureMode>(l, 2, out textureMode);
			lineRenderer.textureMode = textureMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023517 RID: 144663 RVA: 0x00C43FEC File Offset: 0x00C421EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_alignment(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)lineRenderer.alignment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023518 RID: 144664 RVA: 0x00C44040 File Offset: 0x00C42240
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_alignment(IntPtr l)
	{
		int result;
		try
		{
			LineRenderer lineRenderer = (LineRenderer)LuaObject.checkSelf(l);
			LineAlignment alignment;
			LuaObject.checkEnum<LineAlignment>(l, 2, out alignment);
			lineRenderer.alignment = alignment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023519 RID: 144665 RVA: 0x00C44098 File Offset: 0x00C42298
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LineRenderer");
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.SetPositions);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LineRenderer.<>f__mg$cache0);
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.GetPositions);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LineRenderer.<>f__mg$cache1);
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.SetPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LineRenderer.<>f__mg$cache2);
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.GetPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LineRenderer.<>f__mg$cache3);
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.Simplify);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LineRenderer.<>f__mg$cache4);
		string name = "widthCurve";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_widthCurve);
		}
		LuaCSFunction get = Lua_UnityEngine_LineRenderer.<>f__mg$cache5;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_widthCurve);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_LineRenderer.<>f__mg$cache6, true);
		string name2 = "colorGradient";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_colorGradient);
		}
		LuaCSFunction get2 = Lua_UnityEngine_LineRenderer.<>f__mg$cache7;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_colorGradient);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_LineRenderer.<>f__mg$cache8, true);
		string name3 = "startWidth";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_startWidth);
		}
		LuaCSFunction get3 = Lua_UnityEngine_LineRenderer.<>f__mg$cache9;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_startWidth);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_LineRenderer.<>f__mg$cacheA, true);
		string name4 = "endWidth";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_endWidth);
		}
		LuaCSFunction get4 = Lua_UnityEngine_LineRenderer.<>f__mg$cacheB;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_endWidth);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_LineRenderer.<>f__mg$cacheC, true);
		string name5 = "widthMultiplier";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_widthMultiplier);
		}
		LuaCSFunction get5 = Lua_UnityEngine_LineRenderer.<>f__mg$cacheD;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_widthMultiplier);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_LineRenderer.<>f__mg$cacheE, true);
		string name6 = "numCornerVertices";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_numCornerVertices);
		}
		LuaCSFunction get6 = Lua_UnityEngine_LineRenderer.<>f__mg$cacheF;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_numCornerVertices);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_LineRenderer.<>f__mg$cache10, true);
		string name7 = "numCapVertices";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_numCapVertices);
		}
		LuaCSFunction get7 = Lua_UnityEngine_LineRenderer.<>f__mg$cache11;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_numCapVertices);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_LineRenderer.<>f__mg$cache12, true);
		string name8 = "useWorldSpace";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_useWorldSpace);
		}
		LuaCSFunction get8 = Lua_UnityEngine_LineRenderer.<>f__mg$cache13;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_useWorldSpace);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_LineRenderer.<>f__mg$cache14, true);
		string name9 = "loop";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_loop);
		}
		LuaCSFunction get9 = Lua_UnityEngine_LineRenderer.<>f__mg$cache15;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_loop);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_LineRenderer.<>f__mg$cache16, true);
		string name10 = "startColor";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_startColor);
		}
		LuaCSFunction get10 = Lua_UnityEngine_LineRenderer.<>f__mg$cache17;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_startColor);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_LineRenderer.<>f__mg$cache18, true);
		string name11 = "endColor";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_endColor);
		}
		LuaCSFunction get11 = Lua_UnityEngine_LineRenderer.<>f__mg$cache19;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_endColor);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_LineRenderer.<>f__mg$cache1A, true);
		string name12 = "positionCount";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_positionCount);
		}
		LuaCSFunction get12 = Lua_UnityEngine_LineRenderer.<>f__mg$cache1B;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_positionCount);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_LineRenderer.<>f__mg$cache1C, true);
		string name13 = "generateLightingData";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_generateLightingData);
		}
		LuaCSFunction get13 = Lua_UnityEngine_LineRenderer.<>f__mg$cache1D;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_generateLightingData);
		}
		LuaObject.addMember(l, name13, get13, Lua_UnityEngine_LineRenderer.<>f__mg$cache1E, true);
		string name14 = "textureMode";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_textureMode);
		}
		LuaCSFunction get14 = Lua_UnityEngine_LineRenderer.<>f__mg$cache1F;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_textureMode);
		}
		LuaObject.addMember(l, name14, get14, Lua_UnityEngine_LineRenderer.<>f__mg$cache20, true);
		string name15 = "alignment";
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.get_alignment);
		}
		LuaCSFunction get15 = Lua_UnityEngine_LineRenderer.<>f__mg$cache21;
		if (Lua_UnityEngine_LineRenderer.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_LineRenderer.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_LineRenderer.set_alignment);
		}
		LuaObject.addMember(l, name15, get15, Lua_UnityEngine_LineRenderer.<>f__mg$cache22, true);
		LuaObject.createTypeMetatable(l, null, typeof(LineRenderer), typeof(Renderer));
	}

	// Token: 0x04019326 RID: 103206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019327 RID: 103207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019328 RID: 103208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019329 RID: 103209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401932A RID: 103210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401932B RID: 103211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401932C RID: 103212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401932D RID: 103213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401932E RID: 103214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401932F RID: 103215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019330 RID: 103216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019331 RID: 103217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019332 RID: 103218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019333 RID: 103219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019334 RID: 103220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019335 RID: 103221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019336 RID: 103222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019337 RID: 103223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019338 RID: 103224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019339 RID: 103225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401933A RID: 103226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401933B RID: 103227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401933C RID: 103228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401933D RID: 103229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401933E RID: 103230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401933F RID: 103231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019340 RID: 103232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019341 RID: 103233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019342 RID: 103234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019343 RID: 103235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019344 RID: 103236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019345 RID: 103237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019346 RID: 103238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019347 RID: 103239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019348 RID: 103240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;
}
