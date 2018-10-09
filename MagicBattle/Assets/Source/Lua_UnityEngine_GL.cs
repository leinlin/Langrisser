using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016D6 RID: 5846
[Preserve]
public class Lua_UnityEngine_GL : LuaObject
{
	// Token: 0x06023296 RID: 144022 RVA: 0x00C2F46C File Offset: 0x00C2D66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GL o = new GL();
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

	// Token: 0x06023297 RID: 144023 RVA: 0x00C2F4B4 File Offset: 0x00C2D6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Vertex3_s(IntPtr l)
	{
		int result;
		try
		{
			float x;
			LuaObject.checkType(l, 1, out x);
			float y;
			LuaObject.checkType(l, 2, out y);
			float z;
			LuaObject.checkType(l, 3, out z);
			GL.Vertex3(x, y, z);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023298 RID: 144024 RVA: 0x00C2F518 File Offset: 0x00C2D718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Vertex_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
			LuaObject.checkType(l, 1, out v);
			GL.Vertex(v);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023299 RID: 144025 RVA: 0x00C2F564 File Offset: 0x00C2D764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TexCoord3_s(IntPtr l)
	{
		int result;
		try
		{
			float x;
			LuaObject.checkType(l, 1, out x);
			float y;
			LuaObject.checkType(l, 2, out y);
			float z;
			LuaObject.checkType(l, 3, out z);
			GL.TexCoord3(x, y, z);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602329A RID: 144026 RVA: 0x00C2F5C8 File Offset: 0x00C2D7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TexCoord_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 v;
			LuaObject.checkType(l, 1, out v);
			GL.TexCoord(v);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602329B RID: 144027 RVA: 0x00C2F614 File Offset: 0x00C2D814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TexCoord2_s(IntPtr l)
	{
		int result;
		try
		{
			float x;
			LuaObject.checkType(l, 1, out x);
			float y;
			LuaObject.checkType(l, 2, out y);
			GL.TexCoord2(x, y);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602329C RID: 144028 RVA: 0x00C2F66C File Offset: 0x00C2D86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MultiTexCoord3_s(IntPtr l)
	{
		int result;
		try
		{
			int unit;
			LuaObject.checkType(l, 1, out unit);
			float x;
			LuaObject.checkType(l, 2, out x);
			float y;
			LuaObject.checkType(l, 3, out y);
			float z;
			LuaObject.checkType(l, 4, out z);
			GL.MultiTexCoord3(unit, x, y, z);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602329D RID: 144029 RVA: 0x00C2F6DC File Offset: 0x00C2D8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MultiTexCoord_s(IntPtr l)
	{
		int result;
		try
		{
			int unit;
			LuaObject.checkType(l, 1, out unit);
			Vector3 v;
			LuaObject.checkType(l, 2, out v);
			GL.MultiTexCoord(unit, v);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602329E RID: 144030 RVA: 0x00C2F734 File Offset: 0x00C2D934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MultiTexCoord2_s(IntPtr l)
	{
		int result;
		try
		{
			int unit;
			LuaObject.checkType(l, 1, out unit);
			float x;
			LuaObject.checkType(l, 2, out x);
			float y;
			LuaObject.checkType(l, 3, out y);
			GL.MultiTexCoord2(unit, x, y);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602329F RID: 144031 RVA: 0x00C2F798 File Offset: 0x00C2D998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Color_s(IntPtr l)
	{
		int result;
		try
		{
			Color c;
			LuaObject.checkType(l, 1, out c);
			GL.Color(c);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232A0 RID: 144032 RVA: 0x00C2F7E4 File Offset: 0x00C2D9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Flush_s(IntPtr l)
	{
		int result;
		try
		{
			GL.Flush();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232A1 RID: 144033 RVA: 0x00C2F824 File Offset: 0x00C2DA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RenderTargetBarrier_s(IntPtr l)
	{
		int result;
		try
		{
			GL.RenderTargetBarrier();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232A2 RID: 144034 RVA: 0x00C2F864 File Offset: 0x00C2DA64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MultMatrix_s(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 m;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out m);
			GL.MultMatrix(m);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232A3 RID: 144035 RVA: 0x00C2F8B0 File Offset: 0x00C2DAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PushMatrix_s(IntPtr l)
	{
		int result;
		try
		{
			GL.PushMatrix();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232A4 RID: 144036 RVA: 0x00C2F8F0 File Offset: 0x00C2DAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PopMatrix_s(IntPtr l)
	{
		int result;
		try
		{
			GL.PopMatrix();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232A5 RID: 144037 RVA: 0x00C2F930 File Offset: 0x00C2DB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadIdentity_s(IntPtr l)
	{
		int result;
		try
		{
			GL.LoadIdentity();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232A6 RID: 144038 RVA: 0x00C2F970 File Offset: 0x00C2DB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadOrtho_s(IntPtr l)
	{
		int result;
		try
		{
			GL.LoadOrtho();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232A7 RID: 144039 RVA: 0x00C2F9B0 File Offset: 0x00C2DBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadPixelMatrix_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 0)
			{
				GL.LoadPixelMatrix();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				float left;
				LuaObject.checkType(l, 1, out left);
				float right;
				LuaObject.checkType(l, 2, out right);
				float bottom;
				LuaObject.checkType(l, 3, out bottom);
				float top;
				LuaObject.checkType(l, 4, out top);
				GL.LoadPixelMatrix(left, right, bottom, top);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadPixelMatrix to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232A8 RID: 144040 RVA: 0x00C2FA60 File Offset: 0x00C2DC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadProjectionMatrix_s(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 mat;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out mat);
			GL.LoadProjectionMatrix(mat);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232A9 RID: 144041 RVA: 0x00C2FAAC File Offset: 0x00C2DCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InvalidateState_s(IntPtr l)
	{
		int result;
		try
		{
			GL.InvalidateState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232AA RID: 144042 RVA: 0x00C2FAEC File Offset: 0x00C2DCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGPUProjectionMatrix_s(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 proj;
			LuaObject.checkValueType<Matrix4x4>(l, 1, out proj);
			bool renderIntoTexture;
			LuaObject.checkType(l, 2, out renderIntoTexture);
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(proj, renderIntoTexture);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gpuprojectionMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232AB RID: 144043 RVA: 0x00C2FB50 File Offset: 0x00C2DD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IssuePluginEvent_s(IntPtr l)
	{
		int result;
		try
		{
			IntPtr callback;
			LuaObject.checkType(l, 1, out callback);
			int eventID;
			LuaObject.checkType(l, 2, out eventID);
			GL.IssuePluginEvent(callback, eventID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232AC RID: 144044 RVA: 0x00C2FBA8 File Offset: 0x00C2DDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Begin_s(IntPtr l)
	{
		int result;
		try
		{
			int mode;
			LuaObject.checkType(l, 1, out mode);
			GL.Begin(mode);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232AD RID: 144045 RVA: 0x00C2FBF4 File Offset: 0x00C2DDF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int End_s(IntPtr l)
	{
		int result;
		try
		{
			GL.End();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232AE RID: 144046 RVA: 0x00C2FC34 File Offset: 0x00C2DE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				bool clearDepth;
				LuaObject.checkType(l, 1, out clearDepth);
				bool clearColor;
				LuaObject.checkType(l, 2, out clearColor);
				Color backgroundColor;
				LuaObject.checkType(l, 3, out backgroundColor);
				GL.Clear(clearDepth, clearColor, backgroundColor);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				bool clearDepth2;
				LuaObject.checkType(l, 1, out clearDepth2);
				bool clearColor2;
				LuaObject.checkType(l, 2, out clearColor2);
				Color backgroundColor2;
				LuaObject.checkType(l, 3, out backgroundColor2);
				float depth;
				LuaObject.checkType(l, 4, out depth);
				GL.Clear(clearDepth2, clearColor2, backgroundColor2, depth);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Clear to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232AF RID: 144047 RVA: 0x00C2FD0C File Offset: 0x00C2DF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Viewport_s(IntPtr l)
	{
		int result;
		try
		{
			Rect pixelRect;
			LuaObject.checkValueType<Rect>(l, 1, out pixelRect);
			GL.Viewport(pixelRect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232B0 RID: 144048 RVA: 0x00C2FD58 File Offset: 0x00C2DF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearWithSkybox_s(IntPtr l)
	{
		int result;
		try
		{
			bool clearDepth;
			LuaObject.checkType(l, 1, out clearDepth);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			GL.ClearWithSkybox(clearDepth, camera);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232B1 RID: 144049 RVA: 0x00C2FDB0 File Offset: 0x00C2DFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TRIANGLES(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232B2 RID: 144050 RVA: 0x00C2FDF4 File Offset: 0x00C2DFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TRIANGLE_STRIP(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232B3 RID: 144051 RVA: 0x00C2FE38 File Offset: 0x00C2E038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_QUADS(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 7);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232B4 RID: 144052 RVA: 0x00C2FE7C File Offset: 0x00C2E07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LINES(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232B5 RID: 144053 RVA: 0x00C2FEC0 File Offset: 0x00C2E0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LINE_STRIP(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232B6 RID: 144054 RVA: 0x00C2FF04 File Offset: 0x00C2E104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wireframe(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GL.wireframe);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232B7 RID: 144055 RVA: 0x00C2FF4C File Offset: 0x00C2E14C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_wireframe(IntPtr l)
	{
		int result;
		try
		{
			bool wireframe;
			LuaObject.checkType(l, 2, out wireframe);
			GL.wireframe = wireframe;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232B8 RID: 144056 RVA: 0x00C2FF98 File Offset: 0x00C2E198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sRGBWrite(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GL.sRGBWrite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232B9 RID: 144057 RVA: 0x00C2FFE0 File Offset: 0x00C2E1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sRGBWrite(IntPtr l)
	{
		int result;
		try
		{
			bool sRGBWrite;
			LuaObject.checkType(l, 2, out sRGBWrite);
			GL.sRGBWrite = sRGBWrite;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232BA RID: 144058 RVA: 0x00C3002C File Offset: 0x00C2E22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_invertCulling(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GL.invertCulling);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232BB RID: 144059 RVA: 0x00C30074 File Offset: 0x00C2E274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_invertCulling(IntPtr l)
	{
		int result;
		try
		{
			bool invertCulling;
			LuaObject.checkType(l, 2, out invertCulling);
			GL.invertCulling = invertCulling;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232BC RID: 144060 RVA: 0x00C300C0 File Offset: 0x00C2E2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_modelview(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, GL.modelview);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232BD RID: 144061 RVA: 0x00C3010C File Offset: 0x00C2E30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_modelview(IntPtr l)
	{
		int result;
		try
		{
			Matrix4x4 modelview;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out modelview);
			GL.modelview = modelview;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232BE RID: 144062 RVA: 0x00C30158 File Offset: 0x00C2E358
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.GL");
		if (Lua_UnityEngine_GL.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_GL.Vertex3_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache0);
		if (Lua_UnityEngine_GL.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_GL.Vertex_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache1);
		if (Lua_UnityEngine_GL.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_GL.TexCoord3_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache2);
		if (Lua_UnityEngine_GL.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_GL.TexCoord_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache3);
		if (Lua_UnityEngine_GL.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_GL.TexCoord2_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache4);
		if (Lua_UnityEngine_GL.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_GL.MultiTexCoord3_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache5);
		if (Lua_UnityEngine_GL.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_GL.MultiTexCoord_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache6);
		if (Lua_UnityEngine_GL.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_GL.MultiTexCoord2_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache7);
		if (Lua_UnityEngine_GL.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_GL.Color_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache8);
		if (Lua_UnityEngine_GL.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_GL.Flush_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache9);
		if (Lua_UnityEngine_GL.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_GL.RenderTargetBarrier_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cacheA);
		if (Lua_UnityEngine_GL.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_GL.MultMatrix_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cacheB);
		if (Lua_UnityEngine_GL.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_GL.PushMatrix_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cacheC);
		if (Lua_UnityEngine_GL.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_GL.PopMatrix_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cacheD);
		if (Lua_UnityEngine_GL.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_GL.LoadIdentity_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cacheE);
		if (Lua_UnityEngine_GL.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_GL.LoadOrtho_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cacheF);
		if (Lua_UnityEngine_GL.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_GL.LoadPixelMatrix_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache10);
		if (Lua_UnityEngine_GL.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_GL.LoadProjectionMatrix_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache11);
		if (Lua_UnityEngine_GL.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_GL.InvalidateState_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache12);
		if (Lua_UnityEngine_GL.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_GL.GetGPUProjectionMatrix_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache13);
		if (Lua_UnityEngine_GL.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_GL.IssuePluginEvent_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache14);
		if (Lua_UnityEngine_GL.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_GL.Begin_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache15);
		if (Lua_UnityEngine_GL.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_GL.End_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache16);
		if (Lua_UnityEngine_GL.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_GL.Clear_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache17);
		if (Lua_UnityEngine_GL.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_GL.Viewport_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache18);
		if (Lua_UnityEngine_GL.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_GL.ClearWithSkybox_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GL.<>f__mg$cache19);
		string name = "TRIANGLES";
		if (Lua_UnityEngine_GL.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_GL.get_TRIANGLES);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_GL.<>f__mg$cache1A, null, false);
		string name2 = "TRIANGLE_STRIP";
		if (Lua_UnityEngine_GL.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_GL.get_TRIANGLE_STRIP);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_GL.<>f__mg$cache1B, null, false);
		string name3 = "QUADS";
		if (Lua_UnityEngine_GL.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_GL.get_QUADS);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_GL.<>f__mg$cache1C, null, false);
		string name4 = "LINES";
		if (Lua_UnityEngine_GL.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_GL.get_LINES);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_GL.<>f__mg$cache1D, null, false);
		string name5 = "LINE_STRIP";
		if (Lua_UnityEngine_GL.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_GL.get_LINE_STRIP);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_GL.<>f__mg$cache1E, null, false);
		string name6 = "wireframe";
		if (Lua_UnityEngine_GL.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_GL.get_wireframe);
		}
		LuaCSFunction get = Lua_UnityEngine_GL.<>f__mg$cache1F;
		if (Lua_UnityEngine_GL.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_GL.set_wireframe);
		}
		LuaObject.addMember(l, name6, get, Lua_UnityEngine_GL.<>f__mg$cache20, false);
		string name7 = "sRGBWrite";
		if (Lua_UnityEngine_GL.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_GL.get_sRGBWrite);
		}
		LuaCSFunction get2 = Lua_UnityEngine_GL.<>f__mg$cache21;
		if (Lua_UnityEngine_GL.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_GL.set_sRGBWrite);
		}
		LuaObject.addMember(l, name7, get2, Lua_UnityEngine_GL.<>f__mg$cache22, false);
		string name8 = "invertCulling";
		if (Lua_UnityEngine_GL.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_GL.get_invertCulling);
		}
		LuaCSFunction get3 = Lua_UnityEngine_GL.<>f__mg$cache23;
		if (Lua_UnityEngine_GL.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_GL.set_invertCulling);
		}
		LuaObject.addMember(l, name8, get3, Lua_UnityEngine_GL.<>f__mg$cache24, false);
		string name9 = "modelview";
		if (Lua_UnityEngine_GL.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_GL.get_modelview);
		}
		LuaCSFunction get4 = Lua_UnityEngine_GL.<>f__mg$cache25;
		if (Lua_UnityEngine_GL.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_GL.set_modelview);
		}
		LuaObject.addMember(l, name9, get4, Lua_UnityEngine_GL.<>f__mg$cache26, false);
		if (Lua_UnityEngine_GL.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_GL.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_GL.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_GL.<>f__mg$cache27, typeof(GL));
	}

	// Token: 0x04019148 RID: 102728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019149 RID: 102729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401914A RID: 102730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401914B RID: 102731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401914C RID: 102732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401914D RID: 102733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401914E RID: 102734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401914F RID: 102735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019150 RID: 102736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019151 RID: 102737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019152 RID: 102738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019153 RID: 102739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019154 RID: 102740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019155 RID: 102741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019156 RID: 102742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019157 RID: 102743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019158 RID: 102744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019159 RID: 102745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401915A RID: 102746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401915B RID: 102747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401915C RID: 102748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401915D RID: 102749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401915E RID: 102750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401915F RID: 102751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019160 RID: 102752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019161 RID: 102753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019162 RID: 102754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019163 RID: 102755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019164 RID: 102756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019165 RID: 102757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019166 RID: 102758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019167 RID: 102759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019168 RID: 102760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019169 RID: 102761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401916A RID: 102762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401916B RID: 102763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401916C RID: 102764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401916D RID: 102765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401916E RID: 102766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401916F RID: 102767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
