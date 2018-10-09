using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x02001705 RID: 5893
[Preserve]
public class Lua_UnityEngine_Light : LuaObject
{
	// Token: 0x0602346A RID: 144490 RVA: 0x00C3FE88 File Offset: 0x00C3E088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCommandBuffer(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Light light = (Light)LuaObject.checkSelf(l);
				LightEvent evt;
				LuaObject.checkEnum<LightEvent>(l, 2, out evt);
				CommandBuffer buffer;
				LuaObject.checkType<CommandBuffer>(l, 3, out buffer);
				light.AddCommandBuffer(evt, buffer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Light light2 = (Light)LuaObject.checkSelf(l);
				LightEvent evt2;
				LuaObject.checkEnum<LightEvent>(l, 2, out evt2);
				CommandBuffer buffer2;
				LuaObject.checkType<CommandBuffer>(l, 3, out buffer2);
				ShadowMapPass shadowPassMask;
				LuaObject.checkEnum<ShadowMapPass>(l, 4, out shadowPassMask);
				light2.AddCommandBuffer(evt2, buffer2, shadowPassMask);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddCommandBuffer to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602346B RID: 144491 RVA: 0x00C3FF68 File Offset: 0x00C3E168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveCommandBuffer(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LightEvent evt;
			LuaObject.checkEnum<LightEvent>(l, 2, out evt);
			CommandBuffer buffer;
			LuaObject.checkType<CommandBuffer>(l, 3, out buffer);
			light.RemoveCommandBuffer(evt, buffer);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602346C RID: 144492 RVA: 0x00C3FFCC File Offset: 0x00C3E1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveCommandBuffers(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LightEvent evt;
			LuaObject.checkEnum<LightEvent>(l, 2, out evt);
			light.RemoveCommandBuffers(evt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602346D RID: 144493 RVA: 0x00C40024 File Offset: 0x00C3E224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAllCommandBuffers(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			light.RemoveAllCommandBuffers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602346E RID: 144494 RVA: 0x00C40070 File Offset: 0x00C3E270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCommandBuffers(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LightEvent evt;
			LuaObject.checkEnum<LightEvent>(l, 2, out evt);
			CommandBuffer[] commandBuffers = light.GetCommandBuffers(evt);
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

	// Token: 0x0602346F RID: 144495 RVA: 0x00C400D4 File Offset: 0x00C3E2D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLights_s(IntPtr l)
	{
		int result;
		try
		{
			LightType type;
			LuaObject.checkEnum<LightType>(l, 1, out type);
			int layer;
			LuaObject.checkType(l, 2, out layer);
			Light[] lights = Light.GetLights(type, layer);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lights);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023470 RID: 144496 RVA: 0x00C40134 File Offset: 0x00C3E334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadows(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)light.shadows);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023471 RID: 144497 RVA: 0x00C40188 File Offset: 0x00C3E388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadows(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LightShadows shadows;
			LuaObject.checkEnum<LightShadows>(l, 2, out shadows);
			light.shadows = shadows;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023472 RID: 144498 RVA: 0x00C401E0 File Offset: 0x00C3E3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowStrength(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.shadowStrength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023473 RID: 144499 RVA: 0x00C40234 File Offset: 0x00C3E434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowStrength(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			float shadowStrength;
			LuaObject.checkType(l, 2, out shadowStrength);
			light.shadowStrength = shadowStrength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023474 RID: 144500 RVA: 0x00C4028C File Offset: 0x00C3E48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowResolution(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)light.shadowResolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023475 RID: 144501 RVA: 0x00C402E0 File Offset: 0x00C3E4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowResolution(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LightShadowResolution shadowResolution;
			LuaObject.checkEnum<LightShadowResolution>(l, 2, out shadowResolution);
			light.shadowResolution = shadowResolution;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023476 RID: 144502 RVA: 0x00C40338 File Offset: 0x00C3E538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cookieSize(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.cookieSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023477 RID: 144503 RVA: 0x00C4038C File Offset: 0x00C3E58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cookieSize(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			float cookieSize;
			LuaObject.checkType(l, 2, out cookieSize);
			light.cookieSize = cookieSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023478 RID: 144504 RVA: 0x00C403E4 File Offset: 0x00C3E5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cookie(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.cookie);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023479 RID: 144505 RVA: 0x00C40438 File Offset: 0x00C3E638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cookie(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			Texture cookie;
			LuaObject.checkType<Texture>(l, 2, out cookie);
			light.cookie = cookie;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602347A RID: 144506 RVA: 0x00C40490 File Offset: 0x00C3E690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderMode(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)light.renderMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602347B RID: 144507 RVA: 0x00C404E4 File Offset: 0x00C3E6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_renderMode(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LightRenderMode renderMode;
			LuaObject.checkEnum<LightRenderMode>(l, 2, out renderMode);
			light.renderMode = renderMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602347C RID: 144508 RVA: 0x00C4053C File Offset: 0x00C3E73C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_commandBufferCount(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.commandBufferCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602347D RID: 144509 RVA: 0x00C40590 File Offset: 0x00C3E790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_type(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)light.type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602347E RID: 144510 RVA: 0x00C405E4 File Offset: 0x00C3E7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_type(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LightType type;
			LuaObject.checkEnum<LightType>(l, 2, out type);
			light.type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602347F RID: 144511 RVA: 0x00C4063C File Offset: 0x00C3E83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_spotAngle(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.spotAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023480 RID: 144512 RVA: 0x00C40690 File Offset: 0x00C3E890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_spotAngle(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			float spotAngle;
			LuaObject.checkType(l, 2, out spotAngle);
			light.spotAngle = spotAngle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023481 RID: 144513 RVA: 0x00C406E8 File Offset: 0x00C3E8E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_color(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023482 RID: 144514 RVA: 0x00C4073C File Offset: 0x00C3E93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_color(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			Color color;
			LuaObject.checkType(l, 2, out color);
			light.color = color;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023483 RID: 144515 RVA: 0x00C40794 File Offset: 0x00C3E994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colorTemperature(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.colorTemperature);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023484 RID: 144516 RVA: 0x00C407E8 File Offset: 0x00C3E9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colorTemperature(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			float colorTemperature;
			LuaObject.checkType(l, 2, out colorTemperature);
			light.colorTemperature = colorTemperature;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023485 RID: 144517 RVA: 0x00C40840 File Offset: 0x00C3EA40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_intensity(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.intensity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023486 RID: 144518 RVA: 0x00C40894 File Offset: 0x00C3EA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_intensity(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			float intensity;
			LuaObject.checkType(l, 2, out intensity);
			light.intensity = intensity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023487 RID: 144519 RVA: 0x00C408EC File Offset: 0x00C3EAEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_bounceIntensity(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.bounceIntensity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023488 RID: 144520 RVA: 0x00C40940 File Offset: 0x00C3EB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bounceIntensity(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			float bounceIntensity;
			LuaObject.checkType(l, 2, out bounceIntensity);
			light.bounceIntensity = bounceIntensity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023489 RID: 144521 RVA: 0x00C40998 File Offset: 0x00C3EB98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_shadowCustomResolution(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.shadowCustomResolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602348A RID: 144522 RVA: 0x00C409EC File Offset: 0x00C3EBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowCustomResolution(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			int shadowCustomResolution;
			LuaObject.checkType(l, 2, out shadowCustomResolution);
			light.shadowCustomResolution = shadowCustomResolution;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602348B RID: 144523 RVA: 0x00C40A44 File Offset: 0x00C3EC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowBias(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.shadowBias);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602348C RID: 144524 RVA: 0x00C40A98 File Offset: 0x00C3EC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowBias(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			float shadowBias;
			LuaObject.checkType(l, 2, out shadowBias);
			light.shadowBias = shadowBias;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602348D RID: 144525 RVA: 0x00C40AF0 File Offset: 0x00C3ECF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowNormalBias(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.shadowNormalBias);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602348E RID: 144526 RVA: 0x00C40B44 File Offset: 0x00C3ED44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowNormalBias(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			float shadowNormalBias;
			LuaObject.checkType(l, 2, out shadowNormalBias);
			light.shadowNormalBias = shadowNormalBias;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602348F RID: 144527 RVA: 0x00C40B9C File Offset: 0x00C3ED9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shadowNearPlane(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.shadowNearPlane);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023490 RID: 144528 RVA: 0x00C40BF0 File Offset: 0x00C3EDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shadowNearPlane(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			float shadowNearPlane;
			LuaObject.checkType(l, 2, out shadowNearPlane);
			light.shadowNearPlane = shadowNearPlane;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023491 RID: 144529 RVA: 0x00C40C48 File Offset: 0x00C3EE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_range(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.range);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023492 RID: 144530 RVA: 0x00C40C9C File Offset: 0x00C3EE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_range(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			float range;
			LuaObject.checkType(l, 2, out range);
			light.range = range;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023493 RID: 144531 RVA: 0x00C40CF4 File Offset: 0x00C3EEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flare(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.flare);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023494 RID: 144532 RVA: 0x00C40D48 File Offset: 0x00C3EF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_flare(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			Flare flare;
			LuaObject.checkType<Flare>(l, 2, out flare);
			light.flare = flare;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023495 RID: 144533 RVA: 0x00C40DA0 File Offset: 0x00C3EFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bakingOutput(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.bakingOutput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023496 RID: 144534 RVA: 0x00C40DF8 File Offset: 0x00C3EFF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_bakingOutput(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LightBakingOutput bakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 2, out bakingOutput);
			light.bakingOutput = bakingOutput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023497 RID: 144535 RVA: 0x00C40E50 File Offset: 0x00C3F050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cullingMask(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, light.cullingMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023498 RID: 144536 RVA: 0x00C40EA4 File Offset: 0x00C3F0A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_cullingMask(IntPtr l)
	{
		int result;
		try
		{
			Light light = (Light)LuaObject.checkSelf(l);
			int cullingMask;
			LuaObject.checkType(l, 2, out cullingMask);
			light.cullingMask = cullingMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023499 RID: 144537 RVA: 0x00C40EFC File Offset: 0x00C3F0FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Light");
		if (Lua_UnityEngine_Light.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Light.AddCommandBuffer);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Light.<>f__mg$cache0);
		if (Lua_UnityEngine_Light.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Light.RemoveCommandBuffer);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Light.<>f__mg$cache1);
		if (Lua_UnityEngine_Light.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Light.RemoveCommandBuffers);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Light.<>f__mg$cache2);
		if (Lua_UnityEngine_Light.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Light.RemoveAllCommandBuffers);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Light.<>f__mg$cache3);
		if (Lua_UnityEngine_Light.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Light.GetCommandBuffers);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Light.<>f__mg$cache4);
		if (Lua_UnityEngine_Light.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Light.GetLights_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Light.<>f__mg$cache5);
		string name = "shadows";
		if (Lua_UnityEngine_Light.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Light.get_shadows);
		}
		LuaCSFunction get = Lua_UnityEngine_Light.<>f__mg$cache6;
		if (Lua_UnityEngine_Light.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Light.set_shadows);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Light.<>f__mg$cache7, true);
		string name2 = "shadowStrength";
		if (Lua_UnityEngine_Light.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Light.get_shadowStrength);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Light.<>f__mg$cache8;
		if (Lua_UnityEngine_Light.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Light.set_shadowStrength);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Light.<>f__mg$cache9, true);
		string name3 = "shadowResolution";
		if (Lua_UnityEngine_Light.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Light.get_shadowResolution);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Light.<>f__mg$cacheA;
		if (Lua_UnityEngine_Light.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Light.set_shadowResolution);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Light.<>f__mg$cacheB, true);
		string name4 = "cookieSize";
		if (Lua_UnityEngine_Light.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Light.get_cookieSize);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Light.<>f__mg$cacheC;
		if (Lua_UnityEngine_Light.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Light.set_cookieSize);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Light.<>f__mg$cacheD, true);
		string name5 = "cookie";
		if (Lua_UnityEngine_Light.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Light.get_cookie);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Light.<>f__mg$cacheE;
		if (Lua_UnityEngine_Light.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Light.set_cookie);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Light.<>f__mg$cacheF, true);
		string name6 = "renderMode";
		if (Lua_UnityEngine_Light.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Light.get_renderMode);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Light.<>f__mg$cache10;
		if (Lua_UnityEngine_Light.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Light.set_renderMode);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_Light.<>f__mg$cache11, true);
		string name7 = "commandBufferCount";
		if (Lua_UnityEngine_Light.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Light.get_commandBufferCount);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Light.<>f__mg$cache12, null, true);
		string name8 = "type";
		if (Lua_UnityEngine_Light.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Light.get_type);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Light.<>f__mg$cache13;
		if (Lua_UnityEngine_Light.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Light.set_type);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_Light.<>f__mg$cache14, true);
		string name9 = "spotAngle";
		if (Lua_UnityEngine_Light.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Light.get_spotAngle);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Light.<>f__mg$cache15;
		if (Lua_UnityEngine_Light.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Light.set_spotAngle);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_Light.<>f__mg$cache16, true);
		string name10 = "color";
		if (Lua_UnityEngine_Light.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Light.get_color);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Light.<>f__mg$cache17;
		if (Lua_UnityEngine_Light.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Light.set_color);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_Light.<>f__mg$cache18, true);
		string name11 = "colorTemperature";
		if (Lua_UnityEngine_Light.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Light.get_colorTemperature);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Light.<>f__mg$cache19;
		if (Lua_UnityEngine_Light.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Light.set_colorTemperature);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_Light.<>f__mg$cache1A, true);
		string name12 = "intensity";
		if (Lua_UnityEngine_Light.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Light.get_intensity);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Light.<>f__mg$cache1B;
		if (Lua_UnityEngine_Light.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Light.set_intensity);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_Light.<>f__mg$cache1C, true);
		string name13 = "bounceIntensity";
		if (Lua_UnityEngine_Light.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Light.get_bounceIntensity);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Light.<>f__mg$cache1D;
		if (Lua_UnityEngine_Light.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Light.set_bounceIntensity);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_Light.<>f__mg$cache1E, true);
		string name14 = "shadowCustomResolution";
		if (Lua_UnityEngine_Light.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Light.get_shadowCustomResolution);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Light.<>f__mg$cache1F;
		if (Lua_UnityEngine_Light.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Light.set_shadowCustomResolution);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_Light.<>f__mg$cache20, true);
		string name15 = "shadowBias";
		if (Lua_UnityEngine_Light.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Light.get_shadowBias);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Light.<>f__mg$cache21;
		if (Lua_UnityEngine_Light.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Light.set_shadowBias);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_Light.<>f__mg$cache22, true);
		string name16 = "shadowNormalBias";
		if (Lua_UnityEngine_Light.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Light.get_shadowNormalBias);
		}
		LuaCSFunction get15 = Lua_UnityEngine_Light.<>f__mg$cache23;
		if (Lua_UnityEngine_Light.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Light.set_shadowNormalBias);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_Light.<>f__mg$cache24, true);
		string name17 = "shadowNearPlane";
		if (Lua_UnityEngine_Light.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Light.get_shadowNearPlane);
		}
		LuaCSFunction get16 = Lua_UnityEngine_Light.<>f__mg$cache25;
		if (Lua_UnityEngine_Light.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Light.set_shadowNearPlane);
		}
		LuaObject.addMember(l, name17, get16, Lua_UnityEngine_Light.<>f__mg$cache26, true);
		string name18 = "range";
		if (Lua_UnityEngine_Light.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Light.get_range);
		}
		LuaCSFunction get17 = Lua_UnityEngine_Light.<>f__mg$cache27;
		if (Lua_UnityEngine_Light.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Light.set_range);
		}
		LuaObject.addMember(l, name18, get17, Lua_UnityEngine_Light.<>f__mg$cache28, true);
		string name19 = "flare";
		if (Lua_UnityEngine_Light.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Light.get_flare);
		}
		LuaCSFunction get18 = Lua_UnityEngine_Light.<>f__mg$cache29;
		if (Lua_UnityEngine_Light.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Light.set_flare);
		}
		LuaObject.addMember(l, name19, get18, Lua_UnityEngine_Light.<>f__mg$cache2A, true);
		string name20 = "bakingOutput";
		if (Lua_UnityEngine_Light.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Light.get_bakingOutput);
		}
		LuaCSFunction get19 = Lua_UnityEngine_Light.<>f__mg$cache2B;
		if (Lua_UnityEngine_Light.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Light.set_bakingOutput);
		}
		LuaObject.addMember(l, name20, get19, Lua_UnityEngine_Light.<>f__mg$cache2C, true);
		string name21 = "cullingMask";
		if (Lua_UnityEngine_Light.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Light.get_cullingMask);
		}
		LuaCSFunction get20 = Lua_UnityEngine_Light.<>f__mg$cache2D;
		if (Lua_UnityEngine_Light.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Light.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Light.set_cullingMask);
		}
		LuaObject.addMember(l, name21, get20, Lua_UnityEngine_Light.<>f__mg$cache2E, true);
		LuaObject.createTypeMetatable(l, null, typeof(Light), typeof(Behaviour));
	}

	// Token: 0x040192BE RID: 103102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040192BF RID: 103103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040192C0 RID: 103104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040192C1 RID: 103105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040192C2 RID: 103106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040192C3 RID: 103107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040192C4 RID: 103108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040192C5 RID: 103109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040192C6 RID: 103110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040192C7 RID: 103111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040192C8 RID: 103112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040192C9 RID: 103113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040192CA RID: 103114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040192CB RID: 103115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040192CC RID: 103116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040192CD RID: 103117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040192CE RID: 103118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040192CF RID: 103119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040192D0 RID: 103120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040192D1 RID: 103121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040192D2 RID: 103122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040192D3 RID: 103123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040192D4 RID: 103124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040192D5 RID: 103125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040192D6 RID: 103126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040192D7 RID: 103127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040192D8 RID: 103128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040192D9 RID: 103129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040192DA RID: 103130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040192DB RID: 103131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040192DC RID: 103132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040192DD RID: 103133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040192DE RID: 103134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040192DF RID: 103135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040192E0 RID: 103136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040192E1 RID: 103137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040192E2 RID: 103138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040192E3 RID: 103139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040192E4 RID: 103140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040192E5 RID: 103141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040192E6 RID: 103142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040192E7 RID: 103143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040192E8 RID: 103144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040192E9 RID: 103145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040192EA RID: 103146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040192EB RID: 103147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040192EC RID: 103148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
