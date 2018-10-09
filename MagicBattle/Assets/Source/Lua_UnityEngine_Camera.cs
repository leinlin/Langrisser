using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

// Token: 0x0200164C RID: 5708
[Preserve]
public class Lua_UnityEngine_Camera : LuaObject
{
	// Token: 0x06022CFF RID: 142591 RVA: 0x00C0660C File Offset: 0x00C0480C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTargetBuffers(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(RenderBuffer[]), typeof(RenderBuffer)))
			{
				Camera camera = (Camera)LuaObject.checkSelf(l);
				RenderBuffer[] colorBuffer;
				LuaObject.checkArray<RenderBuffer>(l, 2, out colorBuffer);
				RenderBuffer depthBuffer;
				LuaObject.checkValueType<RenderBuffer>(l, 3, out depthBuffer);
				camera.SetTargetBuffers(colorBuffer, depthBuffer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(RenderBuffer), typeof(RenderBuffer)))
			{
				Camera camera2 = (Camera)LuaObject.checkSelf(l);
				RenderBuffer colorBuffer2;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out colorBuffer2);
				RenderBuffer depthBuffer2;
				LuaObject.checkValueType<RenderBuffer>(l, 3, out depthBuffer2);
				camera2.SetTargetBuffers(colorBuffer2, depthBuffer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetTargetBuffers to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D00 RID: 142592 RVA: 0x00C06714 File Offset: 0x00C04914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetWorldToCameraMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.ResetWorldToCameraMatrix();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D01 RID: 142593 RVA: 0x00C06760 File Offset: 0x00C04960
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetProjectionMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.ResetProjectionMatrix();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D02 RID: 142594 RVA: 0x00C067AC File Offset: 0x00C049AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetAspect(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.ResetAspect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D03 RID: 142595 RVA: 0x00C067F8 File Offset: 0x00C049F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStereoViewMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Camera.StereoscopicEye eye;
			LuaObject.checkEnum<Camera.StereoscopicEye>(l, 2, out eye);
			Matrix4x4 stereoViewMatrix = camera.GetStereoViewMatrix(eye);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stereoViewMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D04 RID: 142596 RVA: 0x00C06860 File Offset: 0x00C04A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStereoViewMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Camera.StereoscopicEye eye;
			LuaObject.checkEnum<Camera.StereoscopicEye>(l, 2, out eye);
			Matrix4x4 matrix;
			LuaObject.checkValueType<Matrix4x4>(l, 3, out matrix);
			camera.SetStereoViewMatrix(eye, matrix);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D05 RID: 142597 RVA: 0x00C068C4 File Offset: 0x00C04AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetStereoViewMatrices(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.ResetStereoViewMatrices();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D06 RID: 142598 RVA: 0x00C06910 File Offset: 0x00C04B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStereoProjectionMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Camera.StereoscopicEye eye;
			LuaObject.checkEnum<Camera.StereoscopicEye>(l, 2, out eye);
			Matrix4x4 stereoProjectionMatrix = camera.GetStereoProjectionMatrix(eye);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stereoProjectionMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D07 RID: 142599 RVA: 0x00C06978 File Offset: 0x00C04B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetStereoProjectionMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Camera.StereoscopicEye eye;
			LuaObject.checkEnum<Camera.StereoscopicEye>(l, 2, out eye);
			Matrix4x4 matrix;
			LuaObject.checkValueType<Matrix4x4>(l, 3, out matrix);
			camera.SetStereoProjectionMatrix(eye, matrix);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D08 RID: 142600 RVA: 0x00C069DC File Offset: 0x00C04BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateFrustumCorners(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Rect viewport;
			LuaObject.checkValueType<Rect>(l, 2, out viewport);
			float z;
			LuaObject.checkType(l, 3, out z);
			Camera.MonoOrStereoscopicEye eye;
			LuaObject.checkEnum<Camera.MonoOrStereoscopicEye>(l, 4, out eye);
			Vector3[] outCorners;
			LuaObject.checkArray<Vector3>(l, 5, out outCorners);
			camera.CalculateFrustumCorners(viewport, z, eye, outCorners);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D09 RID: 142601 RVA: 0x00C06A5C File Offset: 0x00C04C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetStereoProjectionMatrices(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.ResetStereoProjectionMatrices();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D0A RID: 142602 RVA: 0x00C06AA8 File Offset: 0x00C04CA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetTransparencySortSettings(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.ResetTransparencySortSettings();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D0B RID: 142603 RVA: 0x00C06AF4 File Offset: 0x00C04CF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldToScreenPoint(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Vector3 o = camera.WorldToScreenPoint(position);
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

	// Token: 0x06022D0C RID: 142604 RVA: 0x00C06B58 File Offset: 0x00C04D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldToViewportPoint(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Vector3 o = camera.WorldToViewportPoint(position);
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

	// Token: 0x06022D0D RID: 142605 RVA: 0x00C06BBC File Offset: 0x00C04DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ViewportToWorldPoint(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Vector3 o = camera.ViewportToWorldPoint(position);
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

	// Token: 0x06022D0E RID: 142606 RVA: 0x00C06C20 File Offset: 0x00C04E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScreenToWorldPoint(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Vector3 o = camera.ScreenToWorldPoint(position);
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

	// Token: 0x06022D0F RID: 142607 RVA: 0x00C06C84 File Offset: 0x00C04E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScreenToViewportPoint(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Vector3 o = camera.ScreenToViewportPoint(position);
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

	// Token: 0x06022D10 RID: 142608 RVA: 0x00C06CE8 File Offset: 0x00C04EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ViewportToScreenPoint(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Vector3 o = camera.ViewportToScreenPoint(position);
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

	// Token: 0x06022D11 RID: 142609 RVA: 0x00C06D4C File Offset: 0x00C04F4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ViewportPointToRay(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Ray ray = camera.ViewportPointToRay(position);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D12 RID: 142610 RVA: 0x00C06DB4 File Offset: 0x00C04FB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ScreenPointToRay(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Ray ray = camera.ScreenPointToRay(position);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D13 RID: 142611 RVA: 0x00C06E1C File Offset: 0x00C0501C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Render(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.Render();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D14 RID: 142612 RVA: 0x00C06E68 File Offset: 0x00C05068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RenderWithShader(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Shader shader;
			LuaObject.checkType<Shader>(l, 2, out shader);
			string replacementTag;
			LuaObject.checkType(l, 3, out replacementTag);
			camera.RenderWithShader(shader, replacementTag);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D15 RID: 142613 RVA: 0x00C06ECC File Offset: 0x00C050CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetReplacementShader(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Shader shader;
			LuaObject.checkType<Shader>(l, 2, out shader);
			string replacementTag;
			LuaObject.checkType(l, 3, out replacementTag);
			camera.SetReplacementShader(shader, replacementTag);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D16 RID: 142614 RVA: 0x00C06F30 File Offset: 0x00C05130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetReplacementShader(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.ResetReplacementShader();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D17 RID: 142615 RVA: 0x00C06F7C File Offset: 0x00C0517C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetCullingMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.ResetCullingMatrix();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D18 RID: 142616 RVA: 0x00C06FC8 File Offset: 0x00C051C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RenderDontRestore(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.RenderDontRestore();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D19 RID: 142617 RVA: 0x00C07014 File Offset: 0x00C05214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RenderToCubemap(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Cubemap)))
			{
				Camera camera = (Camera)LuaObject.checkSelf(l);
				Cubemap cubemap;
				LuaObject.checkType<Cubemap>(l, 2, out cubemap);
				bool b = camera.RenderToCubemap(cubemap);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(RenderTexture)))
			{
				Camera camera2 = (Camera)LuaObject.checkSelf(l);
				RenderTexture cubemap2;
				LuaObject.checkType<RenderTexture>(l, 2, out cubemap2);
				bool b2 = camera2.RenderToCubemap(cubemap2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(RenderTexture), typeof(int)))
			{
				Camera camera3 = (Camera)LuaObject.checkSelf(l);
				RenderTexture cubemap3;
				LuaObject.checkType<RenderTexture>(l, 2, out cubemap3);
				int faceMask;
				LuaObject.checkType(l, 3, out faceMask);
				bool b3 = camera3.RenderToCubemap(cubemap3, faceMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Cubemap), typeof(int)))
			{
				Camera camera4 = (Camera)LuaObject.checkSelf(l);
				Cubemap cubemap4;
				LuaObject.checkType<Cubemap>(l, 2, out cubemap4);
				int faceMask2;
				LuaObject.checkType(l, 3, out faceMask2);
				bool b4 = camera4.RenderToCubemap(cubemap4, faceMask2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RenderToCubemap to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D1A RID: 142618 RVA: 0x00C071D8 File Offset: 0x00C053D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CopyFrom(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Camera other;
			LuaObject.checkType<Camera>(l, 2, out other);
			camera.CopyFrom(other);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D1B RID: 142619 RVA: 0x00C07230 File Offset: 0x00C05430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCommandBuffer(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			CameraEvent evt;
			LuaObject.checkEnum<CameraEvent>(l, 2, out evt);
			CommandBuffer buffer;
			LuaObject.checkType<CommandBuffer>(l, 3, out buffer);
			camera.AddCommandBuffer(evt, buffer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D1C RID: 142620 RVA: 0x00C07294 File Offset: 0x00C05494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveCommandBuffer(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			CameraEvent evt;
			LuaObject.checkEnum<CameraEvent>(l, 2, out evt);
			CommandBuffer buffer;
			LuaObject.checkType<CommandBuffer>(l, 3, out buffer);
			camera.RemoveCommandBuffer(evt, buffer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D1D RID: 142621 RVA: 0x00C072F8 File Offset: 0x00C054F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveCommandBuffers(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			CameraEvent evt;
			LuaObject.checkEnum<CameraEvent>(l, 2, out evt);
			camera.RemoveCommandBuffers(evt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D1E RID: 142622 RVA: 0x00C07350 File Offset: 0x00C05550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAllCommandBuffers(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			camera.RemoveAllCommandBuffers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D1F RID: 142623 RVA: 0x00C0739C File Offset: 0x00C0559C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCommandBuffers(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			CameraEvent evt;
			LuaObject.checkEnum<CameraEvent>(l, 2, out evt);
			CommandBuffer[] commandBuffers = camera.GetCommandBuffers(evt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commandBuffers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D20 RID: 142624 RVA: 0x00C07400 File Offset: 0x00C05600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateObliqueMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Vector4 clipPlane;
			LuaObject.checkType(l, 2, out clipPlane);
			Matrix4x4 matrix4x = camera.CalculateObliqueMatrix(clipPlane);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matrix4x);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D21 RID: 142625 RVA: 0x00C07468 File Offset: 0x00C05668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStereoNonJitteredProjectionMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Camera.StereoscopicEye eye;
			LuaObject.checkEnum<Camera.StereoscopicEye>(l, 2, out eye);
			Matrix4x4 stereoNonJitteredProjectionMatrix = camera.GetStereoNonJitteredProjectionMatrix(eye);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stereoNonJitteredProjectionMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D22 RID: 142626 RVA: 0x00C074D0 File Offset: 0x00C056D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CopyStereoDeviceProjectionMatrixToNonJittered(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Camera.StereoscopicEye eye;
			LuaObject.checkEnum<Camera.StereoscopicEye>(l, 2, out eye);
			camera.CopyStereoDeviceProjectionMatrixToNonJittered(eye);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D23 RID: 142627 RVA: 0x00C07528 File Offset: 0x00C05728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllCameras_s(IntPtr l)
	{
		int result;
		try
		{
			Camera[] cameras;
			LuaObject.checkArray<Camera>(l, 1, out cameras);
			int allCameras = Camera.GetAllCameras(cameras);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allCameras);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D24 RID: 142628 RVA: 0x00C0757C File Offset: 0x00C0577C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetupCurrent_s(IntPtr l)
	{
		int result;
		try
		{
			Camera cur;
			LuaObject.checkType<Camera>(l, 1, out cur);
			Camera.SetupCurrent(cur);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D25 RID: 142629 RVA: 0x00C075C8 File Offset: 0x00C057C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onPreCull(IntPtr l)
	{
		int result;
		try
		{
			Camera.CameraCallback cameraCallback;
			int num = LuaObject.checkDelegate<Camera.CameraCallback>(l, 2, out cameraCallback);
			if (num == 0)
			{
				Camera.onPreCull = cameraCallback;
			}
			else if (num == 1)
			{
				Camera.onPreCull = (Camera.CameraCallback)Delegate.Combine(Camera.onPreCull, cameraCallback);
			}
			else if (num == 2)
			{
				Camera.onPreCull = (Camera.CameraCallback)Delegate.Remove(Camera.onPreCull, cameraCallback);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D26 RID: 142630 RVA: 0x00C0765C File Offset: 0x00C0585C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onPreRender(IntPtr l)
	{
		int result;
		try
		{
			Camera.CameraCallback cameraCallback;
			int num = LuaObject.checkDelegate<Camera.CameraCallback>(l, 2, out cameraCallback);
			if (num == 0)
			{
				Camera.onPreRender = cameraCallback;
			}
			else if (num == 1)
			{
				Camera.onPreRender = (Camera.CameraCallback)Delegate.Combine(Camera.onPreRender, cameraCallback);
			}
			else if (num == 2)
			{
				Camera.onPreRender = (Camera.CameraCallback)Delegate.Remove(Camera.onPreRender, cameraCallback);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D27 RID: 142631 RVA: 0x00C076F0 File Offset: 0x00C058F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onPostRender(IntPtr l)
	{
		int result;
		try
		{
			Camera.CameraCallback cameraCallback;
			int num = LuaObject.checkDelegate<Camera.CameraCallback>(l, 2, out cameraCallback);
			if (num == 0)
			{
				Camera.onPostRender = cameraCallback;
			}
			else if (num == 1)
			{
				Camera.onPostRender = (Camera.CameraCallback)Delegate.Combine(Camera.onPostRender, cameraCallback);
			}
			else if (num == 2)
			{
				Camera.onPostRender = (Camera.CameraCallback)Delegate.Remove(Camera.onPostRender, cameraCallback);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D28 RID: 142632 RVA: 0x00C07784 File Offset: 0x00C05984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fieldOfView(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.fieldOfView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D29 RID: 142633 RVA: 0x00C077D8 File Offset: 0x00C059D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fieldOfView(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			float fieldOfView;
			LuaObject.checkType(l, 2, out fieldOfView);
			camera.fieldOfView = fieldOfView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D2A RID: 142634 RVA: 0x00C07830 File Offset: 0x00C05A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_nearClipPlane(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.nearClipPlane);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D2B RID: 142635 RVA: 0x00C07884 File Offset: 0x00C05A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_nearClipPlane(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			float nearClipPlane;
			LuaObject.checkType(l, 2, out nearClipPlane);
			camera.nearClipPlane = nearClipPlane;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D2C RID: 142636 RVA: 0x00C078DC File Offset: 0x00C05ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_farClipPlane(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.farClipPlane);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D2D RID: 142637 RVA: 0x00C07930 File Offset: 0x00C05B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_farClipPlane(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			float farClipPlane;
			LuaObject.checkType(l, 2, out farClipPlane);
			camera.farClipPlane = farClipPlane;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D2E RID: 142638 RVA: 0x00C07988 File Offset: 0x00C05B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderingPath(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)camera.renderingPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D2F RID: 142639 RVA: 0x00C079DC File Offset: 0x00C05BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_renderingPath(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			RenderingPath renderingPath;
			LuaObject.checkEnum<RenderingPath>(l, 2, out renderingPath);
			camera.renderingPath = renderingPath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D30 RID: 142640 RVA: 0x00C07A34 File Offset: 0x00C05C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_actualRenderingPath(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)camera.actualRenderingPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D31 RID: 142641 RVA: 0x00C07A88 File Offset: 0x00C05C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allowHDR(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.allowHDR);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D32 RID: 142642 RVA: 0x00C07ADC File Offset: 0x00C05CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_allowHDR(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			bool allowHDR;
			LuaObject.checkType(l, 2, out allowHDR);
			camera.allowHDR = allowHDR;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D33 RID: 142643 RVA: 0x00C07B34 File Offset: 0x00C05D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forceIntoRenderTexture(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.forceIntoRenderTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D34 RID: 142644 RVA: 0x00C07B88 File Offset: 0x00C05D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forceIntoRenderTexture(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			bool forceIntoRenderTexture;
			LuaObject.checkType(l, 2, out forceIntoRenderTexture);
			camera.forceIntoRenderTexture = forceIntoRenderTexture;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D35 RID: 142645 RVA: 0x00C07BE0 File Offset: 0x00C05DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allowMSAA(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.allowMSAA);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D36 RID: 142646 RVA: 0x00C07C34 File Offset: 0x00C05E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_allowMSAA(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			bool allowMSAA;
			LuaObject.checkType(l, 2, out allowMSAA);
			camera.allowMSAA = allowMSAA;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D37 RID: 142647 RVA: 0x00C07C8C File Offset: 0x00C05E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allowDynamicResolution(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.allowDynamicResolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D38 RID: 142648 RVA: 0x00C07CE0 File Offset: 0x00C05EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_allowDynamicResolution(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			bool allowDynamicResolution;
			LuaObject.checkType(l, 2, out allowDynamicResolution);
			camera.allowDynamicResolution = allowDynamicResolution;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D39 RID: 142649 RVA: 0x00C07D38 File Offset: 0x00C05F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_orthographicSize(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.orthographicSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D3A RID: 142650 RVA: 0x00C07D8C File Offset: 0x00C05F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_orthographicSize(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			float orthographicSize;
			LuaObject.checkType(l, 2, out orthographicSize);
			camera.orthographicSize = orthographicSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D3B RID: 142651 RVA: 0x00C07DE4 File Offset: 0x00C05FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_orthographic(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.orthographic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D3C RID: 142652 RVA: 0x00C07E38 File Offset: 0x00C06038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_orthographic(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			bool orthographic;
			LuaObject.checkType(l, 2, out orthographic);
			camera.orthographic = orthographic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D3D RID: 142653 RVA: 0x00C07E90 File Offset: 0x00C06090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_opaqueSortMode(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)camera.opaqueSortMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D3E RID: 142654 RVA: 0x00C07EE4 File Offset: 0x00C060E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_opaqueSortMode(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			OpaqueSortMode opaqueSortMode;
			LuaObject.checkEnum<OpaqueSortMode>(l, 2, out opaqueSortMode);
			camera.opaqueSortMode = opaqueSortMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D3F RID: 142655 RVA: 0x00C07F3C File Offset: 0x00C0613C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transparencySortMode(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)camera.transparencySortMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D40 RID: 142656 RVA: 0x00C07F90 File Offset: 0x00C06190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_transparencySortMode(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			TransparencySortMode transparencySortMode;
			LuaObject.checkEnum<TransparencySortMode>(l, 2, out transparencySortMode);
			camera.transparencySortMode = transparencySortMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D41 RID: 142657 RVA: 0x00C07FE8 File Offset: 0x00C061E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transparencySortAxis(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.transparencySortAxis);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D42 RID: 142658 RVA: 0x00C0803C File Offset: 0x00C0623C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_transparencySortAxis(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Vector3 transparencySortAxis;
			LuaObject.checkType(l, 2, out transparencySortAxis);
			camera.transparencySortAxis = transparencySortAxis;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D43 RID: 142659 RVA: 0x00C08094 File Offset: 0x00C06294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depth(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.depth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D44 RID: 142660 RVA: 0x00C080E8 File Offset: 0x00C062E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_depth(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			float depth;
			LuaObject.checkType(l, 2, out depth);
			camera.depth = depth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D45 RID: 142661 RVA: 0x00C08140 File Offset: 0x00C06340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_aspect(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.aspect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D46 RID: 142662 RVA: 0x00C08194 File Offset: 0x00C06394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_aspect(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			float aspect;
			LuaObject.checkType(l, 2, out aspect);
			camera.aspect = aspect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D47 RID: 142663 RVA: 0x00C081EC File Offset: 0x00C063EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cullingMask(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.cullingMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D48 RID: 142664 RVA: 0x00C08240 File Offset: 0x00C06440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cullingMask(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			int cullingMask;
			LuaObject.checkType(l, 2, out cullingMask);
			camera.cullingMask = cullingMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D49 RID: 142665 RVA: 0x00C08298 File Offset: 0x00C06498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_scene(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.scene);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D4A RID: 142666 RVA: 0x00C082F0 File Offset: 0x00C064F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_scene(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Scene scene;
			LuaObject.checkValueType<Scene>(l, 2, out scene);
			camera.scene = scene;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D4B RID: 142667 RVA: 0x00C08348 File Offset: 0x00C06548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_eventMask(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.eventMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D4C RID: 142668 RVA: 0x00C0839C File Offset: 0x00C0659C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_eventMask(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			int eventMask;
			LuaObject.checkType(l, 2, out eventMask);
			camera.eventMask = eventMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D4D RID: 142669 RVA: 0x00C083F4 File Offset: 0x00C065F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_backgroundColor(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.backgroundColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D4E RID: 142670 RVA: 0x00C08448 File Offset: 0x00C06648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_backgroundColor(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Color backgroundColor;
			LuaObject.checkType(l, 2, out backgroundColor);
			camera.backgroundColor = backgroundColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D4F RID: 142671 RVA: 0x00C084A0 File Offset: 0x00C066A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rect(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.rect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D50 RID: 142672 RVA: 0x00C084F8 File Offset: 0x00C066F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rect(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 2, out rect);
			camera.rect = rect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D51 RID: 142673 RVA: 0x00C08550 File Offset: 0x00C06750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pixelRect(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.pixelRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D52 RID: 142674 RVA: 0x00C085A8 File Offset: 0x00C067A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pixelRect(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Rect pixelRect;
			LuaObject.checkValueType<Rect>(l, 2, out pixelRect);
			camera.pixelRect = pixelRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D53 RID: 142675 RVA: 0x00C08600 File Offset: 0x00C06800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetTexture(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.targetTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D54 RID: 142676 RVA: 0x00C08654 File Offset: 0x00C06854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetTexture(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			RenderTexture targetTexture;
			LuaObject.checkType<RenderTexture>(l, 2, out targetTexture);
			camera.targetTexture = targetTexture;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D55 RID: 142677 RVA: 0x00C086AC File Offset: 0x00C068AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_activeTexture(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.activeTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D56 RID: 142678 RVA: 0x00C08700 File Offset: 0x00C06900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pixelWidth(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.pixelWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D57 RID: 142679 RVA: 0x00C08754 File Offset: 0x00C06954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pixelHeight(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.pixelHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D58 RID: 142680 RVA: 0x00C087A8 File Offset: 0x00C069A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_scaledPixelWidth(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.scaledPixelWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D59 RID: 142681 RVA: 0x00C087FC File Offset: 0x00C069FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_scaledPixelHeight(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.scaledPixelHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D5A RID: 142682 RVA: 0x00C08850 File Offset: 0x00C06A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cameraToWorldMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.cameraToWorldMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D5B RID: 142683 RVA: 0x00C088A8 File Offset: 0x00C06AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_worldToCameraMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.worldToCameraMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D5C RID: 142684 RVA: 0x00C08900 File Offset: 0x00C06B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_worldToCameraMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Matrix4x4 worldToCameraMatrix;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out worldToCameraMatrix);
			camera.worldToCameraMatrix = worldToCameraMatrix;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D5D RID: 142685 RVA: 0x00C08958 File Offset: 0x00C06B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_projectionMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.projectionMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D5E RID: 142686 RVA: 0x00C089B0 File Offset: 0x00C06BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_projectionMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Matrix4x4 projectionMatrix;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out projectionMatrix);
			camera.projectionMatrix = projectionMatrix;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D5F RID: 142687 RVA: 0x00C08A08 File Offset: 0x00C06C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_nonJitteredProjectionMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.nonJitteredProjectionMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D60 RID: 142688 RVA: 0x00C08A60 File Offset: 0x00C06C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_nonJitteredProjectionMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Matrix4x4 nonJitteredProjectionMatrix;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out nonJitteredProjectionMatrix);
			camera.nonJitteredProjectionMatrix = nonJitteredProjectionMatrix;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D61 RID: 142689 RVA: 0x00C08AB8 File Offset: 0x00C06CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useJitteredProjectionMatrixForTransparentRendering(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.useJitteredProjectionMatrixForTransparentRendering);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D62 RID: 142690 RVA: 0x00C08B0C File Offset: 0x00C06D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useJitteredProjectionMatrixForTransparentRendering(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			bool useJitteredProjectionMatrixForTransparentRendering;
			LuaObject.checkType(l, 2, out useJitteredProjectionMatrixForTransparentRendering);
			camera.useJitteredProjectionMatrixForTransparentRendering = useJitteredProjectionMatrixForTransparentRendering;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D63 RID: 142691 RVA: 0x00C08B64 File Offset: 0x00C06D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_previousViewProjectionMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.previousViewProjectionMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D64 RID: 142692 RVA: 0x00C08BBC File Offset: 0x00C06DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_velocity(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.velocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D65 RID: 142693 RVA: 0x00C08C10 File Offset: 0x00C06E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clearFlags(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)camera.clearFlags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D66 RID: 142694 RVA: 0x00C08C64 File Offset: 0x00C06E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_clearFlags(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			CameraClearFlags clearFlags;
			LuaObject.checkEnum<CameraClearFlags>(l, 2, out clearFlags);
			camera.clearFlags = clearFlags;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D67 RID: 142695 RVA: 0x00C08CBC File Offset: 0x00C06EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_stereoEnabled(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.stereoEnabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D68 RID: 142696 RVA: 0x00C08D10 File Offset: 0x00C06F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_stereoSeparation(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.stereoSeparation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D69 RID: 142697 RVA: 0x00C08D64 File Offset: 0x00C06F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_stereoSeparation(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			float stereoSeparation;
			LuaObject.checkType(l, 2, out stereoSeparation);
			camera.stereoSeparation = stereoSeparation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D6A RID: 142698 RVA: 0x00C08DBC File Offset: 0x00C06FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_stereoConvergence(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.stereoConvergence);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D6B RID: 142699 RVA: 0x00C08E10 File Offset: 0x00C07010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_stereoConvergence(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			float stereoConvergence;
			LuaObject.checkType(l, 2, out stereoConvergence);
			camera.stereoConvergence = stereoConvergence;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D6C RID: 142700 RVA: 0x00C08E68 File Offset: 0x00C07068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cameraType(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)camera.cameraType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D6D RID: 142701 RVA: 0x00C08EBC File Offset: 0x00C070BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cameraType(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			CameraType cameraType;
			LuaObject.checkEnum<CameraType>(l, 2, out cameraType);
			camera.cameraType = cameraType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D6E RID: 142702 RVA: 0x00C08F14 File Offset: 0x00C07114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_stereoTargetEye(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)camera.stereoTargetEye);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D6F RID: 142703 RVA: 0x00C08F68 File Offset: 0x00C07168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_stereoTargetEye(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			StereoTargetEyeMask stereoTargetEye;
			LuaObject.checkEnum<StereoTargetEyeMask>(l, 2, out stereoTargetEye);
			camera.stereoTargetEye = stereoTargetEye;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D70 RID: 142704 RVA: 0x00C08FC0 File Offset: 0x00C071C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_areVRStereoViewMatricesWithinSingleCullTolerance(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.areVRStereoViewMatricesWithinSingleCullTolerance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D71 RID: 142705 RVA: 0x00C09014 File Offset: 0x00C07214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_stereoActiveEye(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)camera.stereoActiveEye);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D72 RID: 142706 RVA: 0x00C09068 File Offset: 0x00C07268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetDisplay(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.targetDisplay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D73 RID: 142707 RVA: 0x00C090BC File Offset: 0x00C072BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetDisplay(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			int targetDisplay;
			LuaObject.checkType(l, 2, out targetDisplay);
			camera.targetDisplay = targetDisplay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D74 RID: 142708 RVA: 0x00C09114 File Offset: 0x00C07314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_main(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Camera.main);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D75 RID: 142709 RVA: 0x00C0915C File Offset: 0x00C0735C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_current(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Camera.current);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D76 RID: 142710 RVA: 0x00C091A4 File Offset: 0x00C073A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allCameras(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Camera.allCameras);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D77 RID: 142711 RVA: 0x00C091EC File Offset: 0x00C073EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allCamerasCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Camera.allCamerasCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D78 RID: 142712 RVA: 0x00C09234 File Offset: 0x00C07434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useOcclusionCulling(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.useOcclusionCulling);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D79 RID: 142713 RVA: 0x00C09288 File Offset: 0x00C07488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useOcclusionCulling(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			bool useOcclusionCulling;
			LuaObject.checkType(l, 2, out useOcclusionCulling);
			camera.useOcclusionCulling = useOcclusionCulling;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D7A RID: 142714 RVA: 0x00C092E0 File Offset: 0x00C074E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cullingMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.cullingMatrix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D7B RID: 142715 RVA: 0x00C09338 File Offset: 0x00C07538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cullingMatrix(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			Matrix4x4 cullingMatrix;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out cullingMatrix);
			camera.cullingMatrix = cullingMatrix;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D7C RID: 142716 RVA: 0x00C09390 File Offset: 0x00C07590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layerCullDistances(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.layerCullDistances);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D7D RID: 142717 RVA: 0x00C093E4 File Offset: 0x00C075E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_layerCullDistances(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			float[] layerCullDistances;
			LuaObject.checkArray<float>(l, 2, out layerCullDistances);
			camera.layerCullDistances = layerCullDistances;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D7E RID: 142718 RVA: 0x00C0943C File Offset: 0x00C0763C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layerCullSpherical(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.layerCullSpherical);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D7F RID: 142719 RVA: 0x00C09490 File Offset: 0x00C07690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_layerCullSpherical(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			bool layerCullSpherical;
			LuaObject.checkType(l, 2, out layerCullSpherical);
			camera.layerCullSpherical = layerCullSpherical;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D80 RID: 142720 RVA: 0x00C094E8 File Offset: 0x00C076E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depthTextureMode(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)camera.depthTextureMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D81 RID: 142721 RVA: 0x00C0953C File Offset: 0x00C0773C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_depthTextureMode(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			DepthTextureMode depthTextureMode;
			LuaObject.checkEnum<DepthTextureMode>(l, 2, out depthTextureMode);
			camera.depthTextureMode = depthTextureMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D82 RID: 142722 RVA: 0x00C09594 File Offset: 0x00C07794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clearStencilAfterLightingPass(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.clearStencilAfterLightingPass);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D83 RID: 142723 RVA: 0x00C095E8 File Offset: 0x00C077E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_clearStencilAfterLightingPass(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			bool clearStencilAfterLightingPass;
			LuaObject.checkType(l, 2, out clearStencilAfterLightingPass);
			camera.clearStencilAfterLightingPass = clearStencilAfterLightingPass;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D84 RID: 142724 RVA: 0x00C09640 File Offset: 0x00C07840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_commandBufferCount(IntPtr l)
	{
		int result;
		try
		{
			Camera camera = (Camera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, camera.commandBufferCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022D85 RID: 142725 RVA: 0x00C09694 File Offset: 0x00C07894
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Camera");
		if (Lua_UnityEngine_Camera.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Camera.SetTargetBuffers);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache0);
		if (Lua_UnityEngine_Camera.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Camera.ResetWorldToCameraMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache1);
		if (Lua_UnityEngine_Camera.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Camera.ResetProjectionMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache2);
		if (Lua_UnityEngine_Camera.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Camera.ResetAspect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache3);
		if (Lua_UnityEngine_Camera.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Camera.GetStereoViewMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache4);
		if (Lua_UnityEngine_Camera.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Camera.SetStereoViewMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache5);
		if (Lua_UnityEngine_Camera.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Camera.ResetStereoViewMatrices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache6);
		if (Lua_UnityEngine_Camera.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Camera.GetStereoProjectionMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache7);
		if (Lua_UnityEngine_Camera.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Camera.SetStereoProjectionMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache8);
		if (Lua_UnityEngine_Camera.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Camera.CalculateFrustumCorners);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache9);
		if (Lua_UnityEngine_Camera.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Camera.ResetStereoProjectionMatrices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cacheA);
		if (Lua_UnityEngine_Camera.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Camera.ResetTransparencySortSettings);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cacheB);
		if (Lua_UnityEngine_Camera.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Camera.WorldToScreenPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cacheC);
		if (Lua_UnityEngine_Camera.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Camera.WorldToViewportPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cacheD);
		if (Lua_UnityEngine_Camera.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Camera.ViewportToWorldPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cacheE);
		if (Lua_UnityEngine_Camera.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Camera.ScreenToWorldPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cacheF);
		if (Lua_UnityEngine_Camera.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Camera.ScreenToViewportPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache10);
		if (Lua_UnityEngine_Camera.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Camera.ViewportToScreenPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache11);
		if (Lua_UnityEngine_Camera.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Camera.ViewportPointToRay);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache12);
		if (Lua_UnityEngine_Camera.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Camera.ScreenPointToRay);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache13);
		if (Lua_UnityEngine_Camera.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Camera.Render);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache14);
		if (Lua_UnityEngine_Camera.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Camera.RenderWithShader);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache15);
		if (Lua_UnityEngine_Camera.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Camera.SetReplacementShader);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache16);
		if (Lua_UnityEngine_Camera.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Camera.ResetReplacementShader);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache17);
		if (Lua_UnityEngine_Camera.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Camera.ResetCullingMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache18);
		if (Lua_UnityEngine_Camera.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Camera.RenderDontRestore);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache19);
		if (Lua_UnityEngine_Camera.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Camera.RenderToCubemap);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache1A);
		if (Lua_UnityEngine_Camera.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Camera.CopyFrom);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache1B);
		if (Lua_UnityEngine_Camera.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Camera.AddCommandBuffer);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache1C);
		if (Lua_UnityEngine_Camera.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Camera.RemoveCommandBuffer);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache1D);
		if (Lua_UnityEngine_Camera.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Camera.RemoveCommandBuffers);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache1E);
		if (Lua_UnityEngine_Camera.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Camera.RemoveAllCommandBuffers);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache1F);
		if (Lua_UnityEngine_Camera.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Camera.GetCommandBuffers);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache20);
		if (Lua_UnityEngine_Camera.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Camera.CalculateObliqueMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache21);
		if (Lua_UnityEngine_Camera.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Camera.GetStereoNonJitteredProjectionMatrix);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache22);
		if (Lua_UnityEngine_Camera.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Camera.CopyStereoDeviceProjectionMatrixToNonJittered);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache23);
		if (Lua_UnityEngine_Camera.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Camera.GetAllCameras_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache24);
		if (Lua_UnityEngine_Camera.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Camera.SetupCurrent_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Camera.<>f__mg$cache25);
		string name = "onPreCull";
		LuaCSFunction get = null;
		if (Lua_UnityEngine_Camera.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Camera.set_onPreCull);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Camera.<>f__mg$cache26, false);
		string name2 = "onPreRender";
		LuaCSFunction get2 = null;
		if (Lua_UnityEngine_Camera.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Camera.set_onPreRender);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Camera.<>f__mg$cache27, false);
		string name3 = "onPostRender";
		LuaCSFunction get3 = null;
		if (Lua_UnityEngine_Camera.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Camera.set_onPostRender);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Camera.<>f__mg$cache28, false);
		string name4 = "fieldOfView";
		if (Lua_UnityEngine_Camera.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Camera.get_fieldOfView);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Camera.<>f__mg$cache29;
		if (Lua_UnityEngine_Camera.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Camera.set_fieldOfView);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Camera.<>f__mg$cache2A, true);
		string name5 = "nearClipPlane";
		if (Lua_UnityEngine_Camera.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Camera.get_nearClipPlane);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Camera.<>f__mg$cache2B;
		if (Lua_UnityEngine_Camera.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Camera.set_nearClipPlane);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Camera.<>f__mg$cache2C, true);
		string name6 = "farClipPlane";
		if (Lua_UnityEngine_Camera.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Camera.get_farClipPlane);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Camera.<>f__mg$cache2D;
		if (Lua_UnityEngine_Camera.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Camera.set_farClipPlane);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_Camera.<>f__mg$cache2E, true);
		string name7 = "renderingPath";
		if (Lua_UnityEngine_Camera.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Camera.get_renderingPath);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Camera.<>f__mg$cache2F;
		if (Lua_UnityEngine_Camera.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Camera.set_renderingPath);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_Camera.<>f__mg$cache30, true);
		string name8 = "actualRenderingPath";
		if (Lua_UnityEngine_Camera.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Camera.get_actualRenderingPath);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Camera.<>f__mg$cache31, null, true);
		string name9 = "allowHDR";
		if (Lua_UnityEngine_Camera.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Camera.get_allowHDR);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Camera.<>f__mg$cache32;
		if (Lua_UnityEngine_Camera.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Camera.set_allowHDR);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_Camera.<>f__mg$cache33, true);
		string name10 = "forceIntoRenderTexture";
		if (Lua_UnityEngine_Camera.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Camera.get_forceIntoRenderTexture);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Camera.<>f__mg$cache34;
		if (Lua_UnityEngine_Camera.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Camera.set_forceIntoRenderTexture);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_Camera.<>f__mg$cache35, true);
		string name11 = "allowMSAA";
		if (Lua_UnityEngine_Camera.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Camera.get_allowMSAA);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Camera.<>f__mg$cache36;
		if (Lua_UnityEngine_Camera.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Camera.set_allowMSAA);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_Camera.<>f__mg$cache37, true);
		string name12 = "allowDynamicResolution";
		if (Lua_UnityEngine_Camera.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Camera.get_allowDynamicResolution);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Camera.<>f__mg$cache38;
		if (Lua_UnityEngine_Camera.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_Camera.set_allowDynamicResolution);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_Camera.<>f__mg$cache39, true);
		string name13 = "orthographicSize";
		if (Lua_UnityEngine_Camera.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_Camera.get_orthographicSize);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Camera.<>f__mg$cache3A;
		if (Lua_UnityEngine_Camera.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_Camera.set_orthographicSize);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_Camera.<>f__mg$cache3B, true);
		string name14 = "orthographic";
		if (Lua_UnityEngine_Camera.<>f__mg$cache3C == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache3C = new LuaCSFunction(Lua_UnityEngine_Camera.get_orthographic);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Camera.<>f__mg$cache3C;
		if (Lua_UnityEngine_Camera.<>f__mg$cache3D == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache3D = new LuaCSFunction(Lua_UnityEngine_Camera.set_orthographic);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_Camera.<>f__mg$cache3D, true);
		string name15 = "opaqueSortMode";
		if (Lua_UnityEngine_Camera.<>f__mg$cache3E == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache3E = new LuaCSFunction(Lua_UnityEngine_Camera.get_opaqueSortMode);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Camera.<>f__mg$cache3E;
		if (Lua_UnityEngine_Camera.<>f__mg$cache3F == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache3F = new LuaCSFunction(Lua_UnityEngine_Camera.set_opaqueSortMode);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_Camera.<>f__mg$cache3F, true);
		string name16 = "transparencySortMode";
		if (Lua_UnityEngine_Camera.<>f__mg$cache40 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache40 = new LuaCSFunction(Lua_UnityEngine_Camera.get_transparencySortMode);
		}
		LuaCSFunction get15 = Lua_UnityEngine_Camera.<>f__mg$cache40;
		if (Lua_UnityEngine_Camera.<>f__mg$cache41 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache41 = new LuaCSFunction(Lua_UnityEngine_Camera.set_transparencySortMode);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_Camera.<>f__mg$cache41, true);
		string name17 = "transparencySortAxis";
		if (Lua_UnityEngine_Camera.<>f__mg$cache42 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache42 = new LuaCSFunction(Lua_UnityEngine_Camera.get_transparencySortAxis);
		}
		LuaCSFunction get16 = Lua_UnityEngine_Camera.<>f__mg$cache42;
		if (Lua_UnityEngine_Camera.<>f__mg$cache43 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache43 = new LuaCSFunction(Lua_UnityEngine_Camera.set_transparencySortAxis);
		}
		LuaObject.addMember(l, name17, get16, Lua_UnityEngine_Camera.<>f__mg$cache43, true);
		string name18 = "depth";
		if (Lua_UnityEngine_Camera.<>f__mg$cache44 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache44 = new LuaCSFunction(Lua_UnityEngine_Camera.get_depth);
		}
		LuaCSFunction get17 = Lua_UnityEngine_Camera.<>f__mg$cache44;
		if (Lua_UnityEngine_Camera.<>f__mg$cache45 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache45 = new LuaCSFunction(Lua_UnityEngine_Camera.set_depth);
		}
		LuaObject.addMember(l, name18, get17, Lua_UnityEngine_Camera.<>f__mg$cache45, true);
		string name19 = "aspect";
		if (Lua_UnityEngine_Camera.<>f__mg$cache46 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache46 = new LuaCSFunction(Lua_UnityEngine_Camera.get_aspect);
		}
		LuaCSFunction get18 = Lua_UnityEngine_Camera.<>f__mg$cache46;
		if (Lua_UnityEngine_Camera.<>f__mg$cache47 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache47 = new LuaCSFunction(Lua_UnityEngine_Camera.set_aspect);
		}
		LuaObject.addMember(l, name19, get18, Lua_UnityEngine_Camera.<>f__mg$cache47, true);
		string name20 = "cullingMask";
		if (Lua_UnityEngine_Camera.<>f__mg$cache48 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache48 = new LuaCSFunction(Lua_UnityEngine_Camera.get_cullingMask);
		}
		LuaCSFunction get19 = Lua_UnityEngine_Camera.<>f__mg$cache48;
		if (Lua_UnityEngine_Camera.<>f__mg$cache49 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache49 = new LuaCSFunction(Lua_UnityEngine_Camera.set_cullingMask);
		}
		LuaObject.addMember(l, name20, get19, Lua_UnityEngine_Camera.<>f__mg$cache49, true);
		string name21 = "scene";
		if (Lua_UnityEngine_Camera.<>f__mg$cache4A == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache4A = new LuaCSFunction(Lua_UnityEngine_Camera.get_scene);
		}
		LuaCSFunction get20 = Lua_UnityEngine_Camera.<>f__mg$cache4A;
		if (Lua_UnityEngine_Camera.<>f__mg$cache4B == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache4B = new LuaCSFunction(Lua_UnityEngine_Camera.set_scene);
		}
		LuaObject.addMember(l, name21, get20, Lua_UnityEngine_Camera.<>f__mg$cache4B, true);
		string name22 = "eventMask";
		if (Lua_UnityEngine_Camera.<>f__mg$cache4C == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache4C = new LuaCSFunction(Lua_UnityEngine_Camera.get_eventMask);
		}
		LuaCSFunction get21 = Lua_UnityEngine_Camera.<>f__mg$cache4C;
		if (Lua_UnityEngine_Camera.<>f__mg$cache4D == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache4D = new LuaCSFunction(Lua_UnityEngine_Camera.set_eventMask);
		}
		LuaObject.addMember(l, name22, get21, Lua_UnityEngine_Camera.<>f__mg$cache4D, true);
		string name23 = "backgroundColor";
		if (Lua_UnityEngine_Camera.<>f__mg$cache4E == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache4E = new LuaCSFunction(Lua_UnityEngine_Camera.get_backgroundColor);
		}
		LuaCSFunction get22 = Lua_UnityEngine_Camera.<>f__mg$cache4E;
		if (Lua_UnityEngine_Camera.<>f__mg$cache4F == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache4F = new LuaCSFunction(Lua_UnityEngine_Camera.set_backgroundColor);
		}
		LuaObject.addMember(l, name23, get22, Lua_UnityEngine_Camera.<>f__mg$cache4F, true);
		string name24 = "rect";
		if (Lua_UnityEngine_Camera.<>f__mg$cache50 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache50 = new LuaCSFunction(Lua_UnityEngine_Camera.get_rect);
		}
		LuaCSFunction get23 = Lua_UnityEngine_Camera.<>f__mg$cache50;
		if (Lua_UnityEngine_Camera.<>f__mg$cache51 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache51 = new LuaCSFunction(Lua_UnityEngine_Camera.set_rect);
		}
		LuaObject.addMember(l, name24, get23, Lua_UnityEngine_Camera.<>f__mg$cache51, true);
		string name25 = "pixelRect";
		if (Lua_UnityEngine_Camera.<>f__mg$cache52 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache52 = new LuaCSFunction(Lua_UnityEngine_Camera.get_pixelRect);
		}
		LuaCSFunction get24 = Lua_UnityEngine_Camera.<>f__mg$cache52;
		if (Lua_UnityEngine_Camera.<>f__mg$cache53 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache53 = new LuaCSFunction(Lua_UnityEngine_Camera.set_pixelRect);
		}
		LuaObject.addMember(l, name25, get24, Lua_UnityEngine_Camera.<>f__mg$cache53, true);
		string name26 = "targetTexture";
		if (Lua_UnityEngine_Camera.<>f__mg$cache54 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache54 = new LuaCSFunction(Lua_UnityEngine_Camera.get_targetTexture);
		}
		LuaCSFunction get25 = Lua_UnityEngine_Camera.<>f__mg$cache54;
		if (Lua_UnityEngine_Camera.<>f__mg$cache55 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache55 = new LuaCSFunction(Lua_UnityEngine_Camera.set_targetTexture);
		}
		LuaObject.addMember(l, name26, get25, Lua_UnityEngine_Camera.<>f__mg$cache55, true);
		string name27 = "activeTexture";
		if (Lua_UnityEngine_Camera.<>f__mg$cache56 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache56 = new LuaCSFunction(Lua_UnityEngine_Camera.get_activeTexture);
		}
		LuaObject.addMember(l, name27, Lua_UnityEngine_Camera.<>f__mg$cache56, null, true);
		string name28 = "pixelWidth";
		if (Lua_UnityEngine_Camera.<>f__mg$cache57 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache57 = new LuaCSFunction(Lua_UnityEngine_Camera.get_pixelWidth);
		}
		LuaObject.addMember(l, name28, Lua_UnityEngine_Camera.<>f__mg$cache57, null, true);
		string name29 = "pixelHeight";
		if (Lua_UnityEngine_Camera.<>f__mg$cache58 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache58 = new LuaCSFunction(Lua_UnityEngine_Camera.get_pixelHeight);
		}
		LuaObject.addMember(l, name29, Lua_UnityEngine_Camera.<>f__mg$cache58, null, true);
		string name30 = "scaledPixelWidth";
		if (Lua_UnityEngine_Camera.<>f__mg$cache59 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache59 = new LuaCSFunction(Lua_UnityEngine_Camera.get_scaledPixelWidth);
		}
		LuaObject.addMember(l, name30, Lua_UnityEngine_Camera.<>f__mg$cache59, null, true);
		string name31 = "scaledPixelHeight";
		if (Lua_UnityEngine_Camera.<>f__mg$cache5A == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache5A = new LuaCSFunction(Lua_UnityEngine_Camera.get_scaledPixelHeight);
		}
		LuaObject.addMember(l, name31, Lua_UnityEngine_Camera.<>f__mg$cache5A, null, true);
		string name32 = "cameraToWorldMatrix";
		if (Lua_UnityEngine_Camera.<>f__mg$cache5B == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache5B = new LuaCSFunction(Lua_UnityEngine_Camera.get_cameraToWorldMatrix);
		}
		LuaObject.addMember(l, name32, Lua_UnityEngine_Camera.<>f__mg$cache5B, null, true);
		string name33 = "worldToCameraMatrix";
		if (Lua_UnityEngine_Camera.<>f__mg$cache5C == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache5C = new LuaCSFunction(Lua_UnityEngine_Camera.get_worldToCameraMatrix);
		}
		LuaCSFunction get26 = Lua_UnityEngine_Camera.<>f__mg$cache5C;
		if (Lua_UnityEngine_Camera.<>f__mg$cache5D == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache5D = new LuaCSFunction(Lua_UnityEngine_Camera.set_worldToCameraMatrix);
		}
		LuaObject.addMember(l, name33, get26, Lua_UnityEngine_Camera.<>f__mg$cache5D, true);
		string name34 = "projectionMatrix";
		if (Lua_UnityEngine_Camera.<>f__mg$cache5E == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache5E = new LuaCSFunction(Lua_UnityEngine_Camera.get_projectionMatrix);
		}
		LuaCSFunction get27 = Lua_UnityEngine_Camera.<>f__mg$cache5E;
		if (Lua_UnityEngine_Camera.<>f__mg$cache5F == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache5F = new LuaCSFunction(Lua_UnityEngine_Camera.set_projectionMatrix);
		}
		LuaObject.addMember(l, name34, get27, Lua_UnityEngine_Camera.<>f__mg$cache5F, true);
		string name35 = "nonJitteredProjectionMatrix";
		if (Lua_UnityEngine_Camera.<>f__mg$cache60 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache60 = new LuaCSFunction(Lua_UnityEngine_Camera.get_nonJitteredProjectionMatrix);
		}
		LuaCSFunction get28 = Lua_UnityEngine_Camera.<>f__mg$cache60;
		if (Lua_UnityEngine_Camera.<>f__mg$cache61 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache61 = new LuaCSFunction(Lua_UnityEngine_Camera.set_nonJitteredProjectionMatrix);
		}
		LuaObject.addMember(l, name35, get28, Lua_UnityEngine_Camera.<>f__mg$cache61, true);
		string name36 = "useJitteredProjectionMatrixForTransparentRendering";
		if (Lua_UnityEngine_Camera.<>f__mg$cache62 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache62 = new LuaCSFunction(Lua_UnityEngine_Camera.get_useJitteredProjectionMatrixForTransparentRendering);
		}
		LuaCSFunction get29 = Lua_UnityEngine_Camera.<>f__mg$cache62;
		if (Lua_UnityEngine_Camera.<>f__mg$cache63 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache63 = new LuaCSFunction(Lua_UnityEngine_Camera.set_useJitteredProjectionMatrixForTransparentRendering);
		}
		LuaObject.addMember(l, name36, get29, Lua_UnityEngine_Camera.<>f__mg$cache63, true);
		string name37 = "previousViewProjectionMatrix";
		if (Lua_UnityEngine_Camera.<>f__mg$cache64 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache64 = new LuaCSFunction(Lua_UnityEngine_Camera.get_previousViewProjectionMatrix);
		}
		LuaObject.addMember(l, name37, Lua_UnityEngine_Camera.<>f__mg$cache64, null, true);
		string name38 = "velocity";
		if (Lua_UnityEngine_Camera.<>f__mg$cache65 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache65 = new LuaCSFunction(Lua_UnityEngine_Camera.get_velocity);
		}
		LuaObject.addMember(l, name38, Lua_UnityEngine_Camera.<>f__mg$cache65, null, true);
		string name39 = "clearFlags";
		if (Lua_UnityEngine_Camera.<>f__mg$cache66 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache66 = new LuaCSFunction(Lua_UnityEngine_Camera.get_clearFlags);
		}
		LuaCSFunction get30 = Lua_UnityEngine_Camera.<>f__mg$cache66;
		if (Lua_UnityEngine_Camera.<>f__mg$cache67 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache67 = new LuaCSFunction(Lua_UnityEngine_Camera.set_clearFlags);
		}
		LuaObject.addMember(l, name39, get30, Lua_UnityEngine_Camera.<>f__mg$cache67, true);
		string name40 = "stereoEnabled";
		if (Lua_UnityEngine_Camera.<>f__mg$cache68 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache68 = new LuaCSFunction(Lua_UnityEngine_Camera.get_stereoEnabled);
		}
		LuaObject.addMember(l, name40, Lua_UnityEngine_Camera.<>f__mg$cache68, null, true);
		string name41 = "stereoSeparation";
		if (Lua_UnityEngine_Camera.<>f__mg$cache69 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache69 = new LuaCSFunction(Lua_UnityEngine_Camera.get_stereoSeparation);
		}
		LuaCSFunction get31 = Lua_UnityEngine_Camera.<>f__mg$cache69;
		if (Lua_UnityEngine_Camera.<>f__mg$cache6A == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache6A = new LuaCSFunction(Lua_UnityEngine_Camera.set_stereoSeparation);
		}
		LuaObject.addMember(l, name41, get31, Lua_UnityEngine_Camera.<>f__mg$cache6A, true);
		string name42 = "stereoConvergence";
		if (Lua_UnityEngine_Camera.<>f__mg$cache6B == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache6B = new LuaCSFunction(Lua_UnityEngine_Camera.get_stereoConvergence);
		}
		LuaCSFunction get32 = Lua_UnityEngine_Camera.<>f__mg$cache6B;
		if (Lua_UnityEngine_Camera.<>f__mg$cache6C == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache6C = new LuaCSFunction(Lua_UnityEngine_Camera.set_stereoConvergence);
		}
		LuaObject.addMember(l, name42, get32, Lua_UnityEngine_Camera.<>f__mg$cache6C, true);
		string name43 = "cameraType";
		if (Lua_UnityEngine_Camera.<>f__mg$cache6D == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache6D = new LuaCSFunction(Lua_UnityEngine_Camera.get_cameraType);
		}
		LuaCSFunction get33 = Lua_UnityEngine_Camera.<>f__mg$cache6D;
		if (Lua_UnityEngine_Camera.<>f__mg$cache6E == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache6E = new LuaCSFunction(Lua_UnityEngine_Camera.set_cameraType);
		}
		LuaObject.addMember(l, name43, get33, Lua_UnityEngine_Camera.<>f__mg$cache6E, true);
		string name44 = "stereoTargetEye";
		if (Lua_UnityEngine_Camera.<>f__mg$cache6F == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache6F = new LuaCSFunction(Lua_UnityEngine_Camera.get_stereoTargetEye);
		}
		LuaCSFunction get34 = Lua_UnityEngine_Camera.<>f__mg$cache6F;
		if (Lua_UnityEngine_Camera.<>f__mg$cache70 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache70 = new LuaCSFunction(Lua_UnityEngine_Camera.set_stereoTargetEye);
		}
		LuaObject.addMember(l, name44, get34, Lua_UnityEngine_Camera.<>f__mg$cache70, true);
		string name45 = "areVRStereoViewMatricesWithinSingleCullTolerance";
		if (Lua_UnityEngine_Camera.<>f__mg$cache71 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache71 = new LuaCSFunction(Lua_UnityEngine_Camera.get_areVRStereoViewMatricesWithinSingleCullTolerance);
		}
		LuaObject.addMember(l, name45, Lua_UnityEngine_Camera.<>f__mg$cache71, null, true);
		string name46 = "stereoActiveEye";
		if (Lua_UnityEngine_Camera.<>f__mg$cache72 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache72 = new LuaCSFunction(Lua_UnityEngine_Camera.get_stereoActiveEye);
		}
		LuaObject.addMember(l, name46, Lua_UnityEngine_Camera.<>f__mg$cache72, null, true);
		string name47 = "targetDisplay";
		if (Lua_UnityEngine_Camera.<>f__mg$cache73 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache73 = new LuaCSFunction(Lua_UnityEngine_Camera.get_targetDisplay);
		}
		LuaCSFunction get35 = Lua_UnityEngine_Camera.<>f__mg$cache73;
		if (Lua_UnityEngine_Camera.<>f__mg$cache74 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache74 = new LuaCSFunction(Lua_UnityEngine_Camera.set_targetDisplay);
		}
		LuaObject.addMember(l, name47, get35, Lua_UnityEngine_Camera.<>f__mg$cache74, true);
		string name48 = "main";
		if (Lua_UnityEngine_Camera.<>f__mg$cache75 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache75 = new LuaCSFunction(Lua_UnityEngine_Camera.get_main);
		}
		LuaObject.addMember(l, name48, Lua_UnityEngine_Camera.<>f__mg$cache75, null, false);
		string name49 = "current";
		if (Lua_UnityEngine_Camera.<>f__mg$cache76 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache76 = new LuaCSFunction(Lua_UnityEngine_Camera.get_current);
		}
		LuaObject.addMember(l, name49, Lua_UnityEngine_Camera.<>f__mg$cache76, null, false);
		string name50 = "allCameras";
		if (Lua_UnityEngine_Camera.<>f__mg$cache77 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache77 = new LuaCSFunction(Lua_UnityEngine_Camera.get_allCameras);
		}
		LuaObject.addMember(l, name50, Lua_UnityEngine_Camera.<>f__mg$cache77, null, false);
		string name51 = "allCamerasCount";
		if (Lua_UnityEngine_Camera.<>f__mg$cache78 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache78 = new LuaCSFunction(Lua_UnityEngine_Camera.get_allCamerasCount);
		}
		LuaObject.addMember(l, name51, Lua_UnityEngine_Camera.<>f__mg$cache78, null, false);
		string name52 = "useOcclusionCulling";
		if (Lua_UnityEngine_Camera.<>f__mg$cache79 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache79 = new LuaCSFunction(Lua_UnityEngine_Camera.get_useOcclusionCulling);
		}
		LuaCSFunction get36 = Lua_UnityEngine_Camera.<>f__mg$cache79;
		if (Lua_UnityEngine_Camera.<>f__mg$cache7A == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache7A = new LuaCSFunction(Lua_UnityEngine_Camera.set_useOcclusionCulling);
		}
		LuaObject.addMember(l, name52, get36, Lua_UnityEngine_Camera.<>f__mg$cache7A, true);
		string name53 = "cullingMatrix";
		if (Lua_UnityEngine_Camera.<>f__mg$cache7B == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache7B = new LuaCSFunction(Lua_UnityEngine_Camera.get_cullingMatrix);
		}
		LuaCSFunction get37 = Lua_UnityEngine_Camera.<>f__mg$cache7B;
		if (Lua_UnityEngine_Camera.<>f__mg$cache7C == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache7C = new LuaCSFunction(Lua_UnityEngine_Camera.set_cullingMatrix);
		}
		LuaObject.addMember(l, name53, get37, Lua_UnityEngine_Camera.<>f__mg$cache7C, true);
		string name54 = "layerCullDistances";
		if (Lua_UnityEngine_Camera.<>f__mg$cache7D == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache7D = new LuaCSFunction(Lua_UnityEngine_Camera.get_layerCullDistances);
		}
		LuaCSFunction get38 = Lua_UnityEngine_Camera.<>f__mg$cache7D;
		if (Lua_UnityEngine_Camera.<>f__mg$cache7E == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache7E = new LuaCSFunction(Lua_UnityEngine_Camera.set_layerCullDistances);
		}
		LuaObject.addMember(l, name54, get38, Lua_UnityEngine_Camera.<>f__mg$cache7E, true);
		string name55 = "layerCullSpherical";
		if (Lua_UnityEngine_Camera.<>f__mg$cache7F == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache7F = new LuaCSFunction(Lua_UnityEngine_Camera.get_layerCullSpherical);
		}
		LuaCSFunction get39 = Lua_UnityEngine_Camera.<>f__mg$cache7F;
		if (Lua_UnityEngine_Camera.<>f__mg$cache80 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache80 = new LuaCSFunction(Lua_UnityEngine_Camera.set_layerCullSpherical);
		}
		LuaObject.addMember(l, name55, get39, Lua_UnityEngine_Camera.<>f__mg$cache80, true);
		string name56 = "depthTextureMode";
		if (Lua_UnityEngine_Camera.<>f__mg$cache81 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache81 = new LuaCSFunction(Lua_UnityEngine_Camera.get_depthTextureMode);
		}
		LuaCSFunction get40 = Lua_UnityEngine_Camera.<>f__mg$cache81;
		if (Lua_UnityEngine_Camera.<>f__mg$cache82 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache82 = new LuaCSFunction(Lua_UnityEngine_Camera.set_depthTextureMode);
		}
		LuaObject.addMember(l, name56, get40, Lua_UnityEngine_Camera.<>f__mg$cache82, true);
		string name57 = "clearStencilAfterLightingPass";
		if (Lua_UnityEngine_Camera.<>f__mg$cache83 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache83 = new LuaCSFunction(Lua_UnityEngine_Camera.get_clearStencilAfterLightingPass);
		}
		LuaCSFunction get41 = Lua_UnityEngine_Camera.<>f__mg$cache83;
		if (Lua_UnityEngine_Camera.<>f__mg$cache84 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache84 = new LuaCSFunction(Lua_UnityEngine_Camera.set_clearStencilAfterLightingPass);
		}
		LuaObject.addMember(l, name57, get41, Lua_UnityEngine_Camera.<>f__mg$cache84, true);
		string name58 = "commandBufferCount";
		if (Lua_UnityEngine_Camera.<>f__mg$cache85 == null)
		{
			Lua_UnityEngine_Camera.<>f__mg$cache85 = new LuaCSFunction(Lua_UnityEngine_Camera.get_commandBufferCount);
		}
		LuaObject.addMember(l, name58, Lua_UnityEngine_Camera.<>f__mg$cache85, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Camera), typeof(Behaviour));
	}

	// Token: 0x04018CC5 RID: 101573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018CC6 RID: 101574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018CC7 RID: 101575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018CC8 RID: 101576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018CC9 RID: 101577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018CCA RID: 101578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018CCB RID: 101579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018CCC RID: 101580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018CCD RID: 101581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018CCE RID: 101582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018CCF RID: 101583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018CD0 RID: 101584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018CD1 RID: 101585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018CD2 RID: 101586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018CD3 RID: 101587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018CD4 RID: 101588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018CD5 RID: 101589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018CD6 RID: 101590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018CD7 RID: 101591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018CD8 RID: 101592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018CD9 RID: 101593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018CDA RID: 101594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018CDB RID: 101595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018CDC RID: 101596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018CDD RID: 101597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018CDE RID: 101598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018CDF RID: 101599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018CE0 RID: 101600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018CE1 RID: 101601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018CE2 RID: 101602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018CE3 RID: 101603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018CE4 RID: 101604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018CE5 RID: 101605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018CE6 RID: 101606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018CE7 RID: 101607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018CE8 RID: 101608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04018CE9 RID: 101609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04018CEA RID: 101610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04018CEB RID: 101611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04018CEC RID: 101612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04018CED RID: 101613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04018CEE RID: 101614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04018CEF RID: 101615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04018CF0 RID: 101616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04018CF1 RID: 101617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04018CF2 RID: 101618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04018CF3 RID: 101619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04018CF4 RID: 101620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04018CF5 RID: 101621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04018CF6 RID: 101622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04018CF7 RID: 101623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04018CF8 RID: 101624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04018CF9 RID: 101625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04018CFA RID: 101626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04018CFB RID: 101627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04018CFC RID: 101628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04018CFD RID: 101629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04018CFE RID: 101630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04018CFF RID: 101631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04018D00 RID: 101632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04018D01 RID: 101633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04018D02 RID: 101634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04018D03 RID: 101635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04018D04 RID: 101636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04018D05 RID: 101637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04018D06 RID: 101638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04018D07 RID: 101639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04018D08 RID: 101640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04018D09 RID: 101641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04018D0A RID: 101642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04018D0B RID: 101643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04018D0C RID: 101644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04018D0D RID: 101645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04018D0E RID: 101646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04018D0F RID: 101647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04018D10 RID: 101648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04018D11 RID: 101649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04018D12 RID: 101650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04018D13 RID: 101651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04018D14 RID: 101652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04018D15 RID: 101653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04018D16 RID: 101654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04018D17 RID: 101655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04018D18 RID: 101656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04018D19 RID: 101657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04018D1A RID: 101658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04018D1B RID: 101659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04018D1C RID: 101660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04018D1D RID: 101661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04018D1E RID: 101662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04018D1F RID: 101663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04018D20 RID: 101664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04018D21 RID: 101665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04018D22 RID: 101666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04018D23 RID: 101667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04018D24 RID: 101668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04018D25 RID: 101669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04018D26 RID: 101670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04018D27 RID: 101671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04018D28 RID: 101672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04018D29 RID: 101673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04018D2A RID: 101674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04018D2B RID: 101675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04018D2C RID: 101676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04018D2D RID: 101677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04018D2E RID: 101678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04018D2F RID: 101679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04018D30 RID: 101680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04018D31 RID: 101681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04018D32 RID: 101682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04018D33 RID: 101683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04018D34 RID: 101684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04018D35 RID: 101685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04018D36 RID: 101686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04018D37 RID: 101687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04018D38 RID: 101688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04018D39 RID: 101689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04018D3A RID: 101690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04018D3B RID: 101691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04018D3C RID: 101692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04018D3D RID: 101693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04018D3E RID: 101694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04018D3F RID: 101695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04018D40 RID: 101696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04018D41 RID: 101697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04018D42 RID: 101698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04018D43 RID: 101699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04018D44 RID: 101700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04018D45 RID: 101701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04018D46 RID: 101702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04018D47 RID: 101703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04018D48 RID: 101704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04018D49 RID: 101705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04018D4A RID: 101706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;
}
