using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x020017AB RID: 6059
[Preserve]
public class Lua_UnityEngine_RenderSettings : LuaObject
{
	// Token: 0x06023B3A RID: 146234 RVA: 0x00C7E204 File Offset: 0x00C7C404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RenderSettings o = new RenderSettings();
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

	// Token: 0x06023B3B RID: 146235 RVA: 0x00C7E24C File Offset: 0x00C7C44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ambientProbe(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.ambientProbe);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B3C RID: 146236 RVA: 0x00C7E298 File Offset: 0x00C7C498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ambientProbe(IntPtr l)
	{
		int result;
		try
		{
			SphericalHarmonicsL2 ambientProbe;
			LuaObject.checkValueType<SphericalHarmonicsL2>(l, 2, out ambientProbe);
			RenderSettings.ambientProbe = ambientProbe;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B3D RID: 146237 RVA: 0x00C7E2E4 File Offset: 0x00C7C4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_customReflection(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.customReflection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B3E RID: 146238 RVA: 0x00C7E32C File Offset: 0x00C7C52C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_customReflection(IntPtr l)
	{
		int result;
		try
		{
			Cubemap customReflection;
			LuaObject.checkType<Cubemap>(l, 2, out customReflection);
			RenderSettings.customReflection = customReflection;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B3F RID: 146239 RVA: 0x00C7E378 File Offset: 0x00C7C578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fog(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.fog);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B40 RID: 146240 RVA: 0x00C7E3C0 File Offset: 0x00C7C5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fog(IntPtr l)
	{
		int result;
		try
		{
			bool fog;
			LuaObject.checkType(l, 2, out fog);
			RenderSettings.fog = fog;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B41 RID: 146241 RVA: 0x00C7E40C File Offset: 0x00C7C60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fogStartDistance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.fogStartDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B42 RID: 146242 RVA: 0x00C7E454 File Offset: 0x00C7C654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fogStartDistance(IntPtr l)
	{
		int result;
		try
		{
			float fogStartDistance;
			LuaObject.checkType(l, 2, out fogStartDistance);
			RenderSettings.fogStartDistance = fogStartDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B43 RID: 146243 RVA: 0x00C7E4A0 File Offset: 0x00C7C6A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_fogEndDistance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.fogEndDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B44 RID: 146244 RVA: 0x00C7E4E8 File Offset: 0x00C7C6E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_fogEndDistance(IntPtr l)
	{
		int result;
		try
		{
			float fogEndDistance;
			LuaObject.checkType(l, 2, out fogEndDistance);
			RenderSettings.fogEndDistance = fogEndDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B45 RID: 146245 RVA: 0x00C7E534 File Offset: 0x00C7C734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fogMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)RenderSettings.fogMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B46 RID: 146246 RVA: 0x00C7E57C File Offset: 0x00C7C77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fogMode(IntPtr l)
	{
		int result;
		try
		{
			FogMode fogMode;
			LuaObject.checkEnum<FogMode>(l, 2, out fogMode);
			RenderSettings.fogMode = fogMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B47 RID: 146247 RVA: 0x00C7E5C8 File Offset: 0x00C7C7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fogColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.fogColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B48 RID: 146248 RVA: 0x00C7E610 File Offset: 0x00C7C810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fogColor(IntPtr l)
	{
		int result;
		try
		{
			Color fogColor;
			LuaObject.checkType(l, 2, out fogColor);
			RenderSettings.fogColor = fogColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B49 RID: 146249 RVA: 0x00C7E65C File Offset: 0x00C7C85C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fogDensity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.fogDensity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B4A RID: 146250 RVA: 0x00C7E6A4 File Offset: 0x00C7C8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fogDensity(IntPtr l)
	{
		int result;
		try
		{
			float fogDensity;
			LuaObject.checkType(l, 2, out fogDensity);
			RenderSettings.fogDensity = fogDensity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B4B RID: 146251 RVA: 0x00C7E6F0 File Offset: 0x00C7C8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ambientMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)RenderSettings.ambientMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B4C RID: 146252 RVA: 0x00C7E738 File Offset: 0x00C7C938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ambientMode(IntPtr l)
	{
		int result;
		try
		{
			AmbientMode ambientMode;
			LuaObject.checkEnum<AmbientMode>(l, 2, out ambientMode);
			RenderSettings.ambientMode = ambientMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B4D RID: 146253 RVA: 0x00C7E784 File Offset: 0x00C7C984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ambientSkyColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.ambientSkyColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B4E RID: 146254 RVA: 0x00C7E7CC File Offset: 0x00C7C9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ambientSkyColor(IntPtr l)
	{
		int result;
		try
		{
			Color ambientSkyColor;
			LuaObject.checkType(l, 2, out ambientSkyColor);
			RenderSettings.ambientSkyColor = ambientSkyColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B4F RID: 146255 RVA: 0x00C7E818 File Offset: 0x00C7CA18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ambientEquatorColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.ambientEquatorColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B50 RID: 146256 RVA: 0x00C7E860 File Offset: 0x00C7CA60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ambientEquatorColor(IntPtr l)
	{
		int result;
		try
		{
			Color ambientEquatorColor;
			LuaObject.checkType(l, 2, out ambientEquatorColor);
			RenderSettings.ambientEquatorColor = ambientEquatorColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B51 RID: 146257 RVA: 0x00C7E8AC File Offset: 0x00C7CAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ambientGroundColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.ambientGroundColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B52 RID: 146258 RVA: 0x00C7E8F4 File Offset: 0x00C7CAF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ambientGroundColor(IntPtr l)
	{
		int result;
		try
		{
			Color ambientGroundColor;
			LuaObject.checkType(l, 2, out ambientGroundColor);
			RenderSettings.ambientGroundColor = ambientGroundColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B53 RID: 146259 RVA: 0x00C7E940 File Offset: 0x00C7CB40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ambientIntensity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.ambientIntensity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B54 RID: 146260 RVA: 0x00C7E988 File Offset: 0x00C7CB88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ambientIntensity(IntPtr l)
	{
		int result;
		try
		{
			float ambientIntensity;
			LuaObject.checkType(l, 2, out ambientIntensity);
			RenderSettings.ambientIntensity = ambientIntensity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B55 RID: 146261 RVA: 0x00C7E9D4 File Offset: 0x00C7CBD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ambientLight(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.ambientLight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B56 RID: 146262 RVA: 0x00C7EA1C File Offset: 0x00C7CC1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ambientLight(IntPtr l)
	{
		int result;
		try
		{
			Color ambientLight;
			LuaObject.checkType(l, 2, out ambientLight);
			RenderSettings.ambientLight = ambientLight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B57 RID: 146263 RVA: 0x00C7EA68 File Offset: 0x00C7CC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_subtractiveShadowColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.subtractiveShadowColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B58 RID: 146264 RVA: 0x00C7EAB0 File Offset: 0x00C7CCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_subtractiveShadowColor(IntPtr l)
	{
		int result;
		try
		{
			Color subtractiveShadowColor;
			LuaObject.checkType(l, 2, out subtractiveShadowColor);
			RenderSettings.subtractiveShadowColor = subtractiveShadowColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B59 RID: 146265 RVA: 0x00C7EAFC File Offset: 0x00C7CCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_skybox(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.skybox);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B5A RID: 146266 RVA: 0x00C7EB44 File Offset: 0x00C7CD44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_skybox(IntPtr l)
	{
		int result;
		try
		{
			Material skybox;
			LuaObject.checkType<Material>(l, 2, out skybox);
			RenderSettings.skybox = skybox;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B5B RID: 146267 RVA: 0x00C7EB90 File Offset: 0x00C7CD90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sun(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.sun);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B5C RID: 146268 RVA: 0x00C7EBD8 File Offset: 0x00C7CDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sun(IntPtr l)
	{
		int result;
		try
		{
			Light sun;
			LuaObject.checkType<Light>(l, 2, out sun);
			RenderSettings.sun = sun;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B5D RID: 146269 RVA: 0x00C7EC24 File Offset: 0x00C7CE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_reflectionIntensity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.reflectionIntensity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B5E RID: 146270 RVA: 0x00C7EC6C File Offset: 0x00C7CE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_reflectionIntensity(IntPtr l)
	{
		int result;
		try
		{
			float reflectionIntensity;
			LuaObject.checkType(l, 2, out reflectionIntensity);
			RenderSettings.reflectionIntensity = reflectionIntensity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B5F RID: 146271 RVA: 0x00C7ECB8 File Offset: 0x00C7CEB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_reflectionBounces(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.reflectionBounces);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B60 RID: 146272 RVA: 0x00C7ED00 File Offset: 0x00C7CF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_reflectionBounces(IntPtr l)
	{
		int result;
		try
		{
			int reflectionBounces;
			LuaObject.checkType(l, 2, out reflectionBounces);
			RenderSettings.reflectionBounces = reflectionBounces;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B61 RID: 146273 RVA: 0x00C7ED4C File Offset: 0x00C7CF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultReflectionMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)RenderSettings.defaultReflectionMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B62 RID: 146274 RVA: 0x00C7ED94 File Offset: 0x00C7CF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_defaultReflectionMode(IntPtr l)
	{
		int result;
		try
		{
			DefaultReflectionMode defaultReflectionMode;
			LuaObject.checkEnum<DefaultReflectionMode>(l, 2, out defaultReflectionMode);
			RenderSettings.defaultReflectionMode = defaultReflectionMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B63 RID: 146275 RVA: 0x00C7EDE0 File Offset: 0x00C7CFE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultReflectionResolution(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.defaultReflectionResolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B64 RID: 146276 RVA: 0x00C7EE28 File Offset: 0x00C7D028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_defaultReflectionResolution(IntPtr l)
	{
		int result;
		try
		{
			int defaultReflectionResolution;
			LuaObject.checkType(l, 2, out defaultReflectionResolution);
			RenderSettings.defaultReflectionResolution = defaultReflectionResolution;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B65 RID: 146277 RVA: 0x00C7EE74 File Offset: 0x00C7D074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_haloStrength(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.haloStrength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B66 RID: 146278 RVA: 0x00C7EEBC File Offset: 0x00C7D0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_haloStrength(IntPtr l)
	{
		int result;
		try
		{
			float haloStrength;
			LuaObject.checkType(l, 2, out haloStrength);
			RenderSettings.haloStrength = haloStrength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B67 RID: 146279 RVA: 0x00C7EF08 File Offset: 0x00C7D108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flareStrength(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.flareStrength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B68 RID: 146280 RVA: 0x00C7EF50 File Offset: 0x00C7D150
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_flareStrength(IntPtr l)
	{
		int result;
		try
		{
			float flareStrength;
			LuaObject.checkType(l, 2, out flareStrength);
			RenderSettings.flareStrength = flareStrength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B69 RID: 146281 RVA: 0x00C7EF9C File Offset: 0x00C7D19C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_flareFadeSpeed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RenderSettings.flareFadeSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B6A RID: 146282 RVA: 0x00C7EFE4 File Offset: 0x00C7D1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_flareFadeSpeed(IntPtr l)
	{
		int result;
		try
		{
			float flareFadeSpeed;
			LuaObject.checkType(l, 2, out flareFadeSpeed);
			RenderSettings.flareFadeSpeed = flareFadeSpeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B6B RID: 146283 RVA: 0x00C7F030 File Offset: 0x00C7D230
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RenderSettings");
		string name = "ambientProbe";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_ambientProbe);
		}
		LuaCSFunction get = Lua_UnityEngine_RenderSettings.<>f__mg$cache0;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_ambientProbe);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_RenderSettings.<>f__mg$cache1, false);
		string name2 = "customReflection";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_customReflection);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RenderSettings.<>f__mg$cache2;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_customReflection);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_RenderSettings.<>f__mg$cache3, false);
		string name3 = "fog";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_fog);
		}
		LuaCSFunction get3 = Lua_UnityEngine_RenderSettings.<>f__mg$cache4;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_fog);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_RenderSettings.<>f__mg$cache5, false);
		string name4 = "fogStartDistance";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_fogStartDistance);
		}
		LuaCSFunction get4 = Lua_UnityEngine_RenderSettings.<>f__mg$cache6;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_fogStartDistance);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_RenderSettings.<>f__mg$cache7, false);
		string name5 = "fogEndDistance";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_fogEndDistance);
		}
		LuaCSFunction get5 = Lua_UnityEngine_RenderSettings.<>f__mg$cache8;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_fogEndDistance);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_RenderSettings.<>f__mg$cache9, false);
		string name6 = "fogMode";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_fogMode);
		}
		LuaCSFunction get6 = Lua_UnityEngine_RenderSettings.<>f__mg$cacheA;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_fogMode);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_RenderSettings.<>f__mg$cacheB, false);
		string name7 = "fogColor";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_fogColor);
		}
		LuaCSFunction get7 = Lua_UnityEngine_RenderSettings.<>f__mg$cacheC;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_fogColor);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_RenderSettings.<>f__mg$cacheD, false);
		string name8 = "fogDensity";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_fogDensity);
		}
		LuaCSFunction get8 = Lua_UnityEngine_RenderSettings.<>f__mg$cacheE;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_fogDensity);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_RenderSettings.<>f__mg$cacheF, false);
		string name9 = "ambientMode";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_ambientMode);
		}
		LuaCSFunction get9 = Lua_UnityEngine_RenderSettings.<>f__mg$cache10;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_ambientMode);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_RenderSettings.<>f__mg$cache11, false);
		string name10 = "ambientSkyColor";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_ambientSkyColor);
		}
		LuaCSFunction get10 = Lua_UnityEngine_RenderSettings.<>f__mg$cache12;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_ambientSkyColor);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_RenderSettings.<>f__mg$cache13, false);
		string name11 = "ambientEquatorColor";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_ambientEquatorColor);
		}
		LuaCSFunction get11 = Lua_UnityEngine_RenderSettings.<>f__mg$cache14;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_ambientEquatorColor);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_RenderSettings.<>f__mg$cache15, false);
		string name12 = "ambientGroundColor";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_ambientGroundColor);
		}
		LuaCSFunction get12 = Lua_UnityEngine_RenderSettings.<>f__mg$cache16;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_ambientGroundColor);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_RenderSettings.<>f__mg$cache17, false);
		string name13 = "ambientIntensity";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_ambientIntensity);
		}
		LuaCSFunction get13 = Lua_UnityEngine_RenderSettings.<>f__mg$cache18;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_ambientIntensity);
		}
		LuaObject.addMember(l, name13, get13, Lua_UnityEngine_RenderSettings.<>f__mg$cache19, false);
		string name14 = "ambientLight";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_ambientLight);
		}
		LuaCSFunction get14 = Lua_UnityEngine_RenderSettings.<>f__mg$cache1A;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_ambientLight);
		}
		LuaObject.addMember(l, name14, get14, Lua_UnityEngine_RenderSettings.<>f__mg$cache1B, false);
		string name15 = "subtractiveShadowColor";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_subtractiveShadowColor);
		}
		LuaCSFunction get15 = Lua_UnityEngine_RenderSettings.<>f__mg$cache1C;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_subtractiveShadowColor);
		}
		LuaObject.addMember(l, name15, get15, Lua_UnityEngine_RenderSettings.<>f__mg$cache1D, false);
		string name16 = "skybox";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_skybox);
		}
		LuaCSFunction get16 = Lua_UnityEngine_RenderSettings.<>f__mg$cache1E;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_skybox);
		}
		LuaObject.addMember(l, name16, get16, Lua_UnityEngine_RenderSettings.<>f__mg$cache1F, false);
		string name17 = "sun";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_sun);
		}
		LuaCSFunction get17 = Lua_UnityEngine_RenderSettings.<>f__mg$cache20;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_sun);
		}
		LuaObject.addMember(l, name17, get17, Lua_UnityEngine_RenderSettings.<>f__mg$cache21, false);
		string name18 = "reflectionIntensity";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_reflectionIntensity);
		}
		LuaCSFunction get18 = Lua_UnityEngine_RenderSettings.<>f__mg$cache22;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_reflectionIntensity);
		}
		LuaObject.addMember(l, name18, get18, Lua_UnityEngine_RenderSettings.<>f__mg$cache23, false);
		string name19 = "reflectionBounces";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_reflectionBounces);
		}
		LuaCSFunction get19 = Lua_UnityEngine_RenderSettings.<>f__mg$cache24;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_reflectionBounces);
		}
		LuaObject.addMember(l, name19, get19, Lua_UnityEngine_RenderSettings.<>f__mg$cache25, false);
		string name20 = "defaultReflectionMode";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_defaultReflectionMode);
		}
		LuaCSFunction get20 = Lua_UnityEngine_RenderSettings.<>f__mg$cache26;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_defaultReflectionMode);
		}
		LuaObject.addMember(l, name20, get20, Lua_UnityEngine_RenderSettings.<>f__mg$cache27, false);
		string name21 = "defaultReflectionResolution";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_defaultReflectionResolution);
		}
		LuaCSFunction get21 = Lua_UnityEngine_RenderSettings.<>f__mg$cache28;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_defaultReflectionResolution);
		}
		LuaObject.addMember(l, name21, get21, Lua_UnityEngine_RenderSettings.<>f__mg$cache29, false);
		string name22 = "haloStrength";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_haloStrength);
		}
		LuaCSFunction get22 = Lua_UnityEngine_RenderSettings.<>f__mg$cache2A;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_haloStrength);
		}
		LuaObject.addMember(l, name22, get22, Lua_UnityEngine_RenderSettings.<>f__mg$cache2B, false);
		string name23 = "flareStrength";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_flareStrength);
		}
		LuaCSFunction get23 = Lua_UnityEngine_RenderSettings.<>f__mg$cache2C;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_flareStrength);
		}
		LuaObject.addMember(l, name23, get23, Lua_UnityEngine_RenderSettings.<>f__mg$cache2D, false);
		string name24 = "flareFadeSpeed";
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_RenderSettings.get_flareFadeSpeed);
		}
		LuaCSFunction get24 = Lua_UnityEngine_RenderSettings.<>f__mg$cache2E;
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_RenderSettings.set_flareFadeSpeed);
		}
		LuaObject.addMember(l, name24, get24, Lua_UnityEngine_RenderSettings.<>f__mg$cache2F, false);
		if (Lua_UnityEngine_RenderSettings.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_RenderSettings.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_RenderSettings.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RenderSettings.<>f__mg$cache30, typeof(RenderSettings), typeof(UnityEngine.Object));
	}

	// Token: 0x04019842 RID: 104514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019843 RID: 104515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019844 RID: 104516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019845 RID: 104517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019846 RID: 104518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019847 RID: 104519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019848 RID: 104520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019849 RID: 104521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401984A RID: 104522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401984B RID: 104523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401984C RID: 104524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401984D RID: 104525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401984E RID: 104526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401984F RID: 104527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019850 RID: 104528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019851 RID: 104529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019852 RID: 104530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019853 RID: 104531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019854 RID: 104532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019855 RID: 104533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019856 RID: 104534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019857 RID: 104535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019858 RID: 104536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019859 RID: 104537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401985A RID: 104538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401985B RID: 104539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401985C RID: 104540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401985D RID: 104541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401985E RID: 104542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401985F RID: 104543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019860 RID: 104544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019861 RID: 104545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019862 RID: 104546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019863 RID: 104547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019864 RID: 104548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019865 RID: 104549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019866 RID: 104550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019867 RID: 104551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019868 RID: 104552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019869 RID: 104553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401986A RID: 104554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401986B RID: 104555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401986C RID: 104556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401986D RID: 104557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401986E RID: 104558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401986F RID: 104559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019870 RID: 104560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019871 RID: 104561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019872 RID: 104562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
