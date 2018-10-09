using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001680 RID: 5760
[Preserve]
public class Lua_UnityEngine_CustomRenderTexture : LuaObject
{
	// Token: 0x0602300F RID: 143375 RVA: 0x00C1E808 File Offset: 0x00C1CA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				int width;
				LuaObject.checkType(l, 2, out width);
				int height;
				LuaObject.checkType(l, 3, out height);
				RenderTextureFormat format;
				LuaObject.checkEnum<RenderTextureFormat>(l, 4, out format);
				RenderTextureReadWrite readWrite;
				LuaObject.checkEnum<RenderTextureReadWrite>(l, 5, out readWrite);
				CustomRenderTexture o = new CustomRenderTexture(width, height, format, readWrite);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				int width2;
				LuaObject.checkType(l, 2, out width2);
				int height2;
				LuaObject.checkType(l, 3, out height2);
				RenderTextureFormat format2;
				LuaObject.checkEnum<RenderTextureFormat>(l, 4, out format2);
				CustomRenderTexture o = new CustomRenderTexture(width2, height2, format2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				int width3;
				LuaObject.checkType(l, 2, out width3);
				int height3;
				LuaObject.checkType(l, 3, out height3);
				CustomRenderTexture o = new CustomRenderTexture(width3, height3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023010 RID: 143376 RVA: 0x00C1E924 File Offset: 0x00C1CB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
				int count;
				LuaObject.checkType(l, 2, out count);
				customRenderTexture.Update(count);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				CustomRenderTexture customRenderTexture2 = (CustomRenderTexture)LuaObject.checkSelf(l);
				customRenderTexture2.Update();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Update to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023011 RID: 143377 RVA: 0x00C1E9D0 File Offset: 0x00C1CBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			customRenderTexture.Initialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023012 RID: 143378 RVA: 0x00C1EA1C File Offset: 0x00C1CC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearUpdateZones(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			customRenderTexture.ClearUpdateZones();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023013 RID: 143379 RVA: 0x00C1EA68 File Offset: 0x00C1CC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUpdateZones(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			List<CustomRenderTextureUpdateZone> updateZones;
			LuaObject.checkType<List<CustomRenderTextureUpdateZone>>(l, 2, out updateZones);
			customRenderTexture.GetUpdateZones(updateZones);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023014 RID: 143380 RVA: 0x00C1EAC0 File Offset: 0x00C1CCC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUpdateZones(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			CustomRenderTextureUpdateZone[] updateZones;
			LuaObject.checkArray<CustomRenderTextureUpdateZone>(l, 2, out updateZones);
			customRenderTexture.SetUpdateZones(updateZones);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023015 RID: 143381 RVA: 0x00C1EB18 File Offset: 0x00C1CD18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_material(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTexture.material);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023016 RID: 143382 RVA: 0x00C1EB6C File Offset: 0x00C1CD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_material(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			Material material;
			LuaObject.checkType<Material>(l, 2, out material);
			customRenderTexture.material = material;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023017 RID: 143383 RVA: 0x00C1EBC4 File Offset: 0x00C1CDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_initializationMaterial(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTexture.initializationMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023018 RID: 143384 RVA: 0x00C1EC18 File Offset: 0x00C1CE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_initializationMaterial(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			Material initializationMaterial;
			LuaObject.checkType<Material>(l, 2, out initializationMaterial);
			customRenderTexture.initializationMaterial = initializationMaterial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023019 RID: 143385 RVA: 0x00C1EC70 File Offset: 0x00C1CE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_initializationTexture(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTexture.initializationTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602301A RID: 143386 RVA: 0x00C1ECC4 File Offset: 0x00C1CEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_initializationTexture(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			Texture initializationTexture;
			LuaObject.checkType<Texture>(l, 2, out initializationTexture);
			customRenderTexture.initializationTexture = initializationTexture;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602301B RID: 143387 RVA: 0x00C1ED1C File Offset: 0x00C1CF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_initializationSource(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)customRenderTexture.initializationSource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602301C RID: 143388 RVA: 0x00C1ED70 File Offset: 0x00C1CF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_initializationSource(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			CustomRenderTextureInitializationSource initializationSource;
			LuaObject.checkEnum<CustomRenderTextureInitializationSource>(l, 2, out initializationSource);
			customRenderTexture.initializationSource = initializationSource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602301D RID: 143389 RVA: 0x00C1EDC8 File Offset: 0x00C1CFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_initializationColor(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTexture.initializationColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602301E RID: 143390 RVA: 0x00C1EE1C File Offset: 0x00C1D01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_initializationColor(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			Color initializationColor;
			LuaObject.checkType(l, 2, out initializationColor);
			customRenderTexture.initializationColor = initializationColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602301F RID: 143391 RVA: 0x00C1EE74 File Offset: 0x00C1D074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateMode(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)customRenderTexture.updateMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023020 RID: 143392 RVA: 0x00C1EEC8 File Offset: 0x00C1D0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_updateMode(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			CustomRenderTextureUpdateMode updateMode;
			LuaObject.checkEnum<CustomRenderTextureUpdateMode>(l, 2, out updateMode);
			customRenderTexture.updateMode = updateMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023021 RID: 143393 RVA: 0x00C1EF20 File Offset: 0x00C1D120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_initializationMode(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)customRenderTexture.initializationMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023022 RID: 143394 RVA: 0x00C1EF74 File Offset: 0x00C1D174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_initializationMode(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			CustomRenderTextureUpdateMode initializationMode;
			LuaObject.checkEnum<CustomRenderTextureUpdateMode>(l, 2, out initializationMode);
			customRenderTexture.initializationMode = initializationMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023023 RID: 143395 RVA: 0x00C1EFCC File Offset: 0x00C1D1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateZoneSpace(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)customRenderTexture.updateZoneSpace);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023024 RID: 143396 RVA: 0x00C1F020 File Offset: 0x00C1D220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_updateZoneSpace(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			CustomRenderTextureUpdateZoneSpace updateZoneSpace;
			LuaObject.checkEnum<CustomRenderTextureUpdateZoneSpace>(l, 2, out updateZoneSpace);
			customRenderTexture.updateZoneSpace = updateZoneSpace;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023025 RID: 143397 RVA: 0x00C1F078 File Offset: 0x00C1D278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shaderPass(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTexture.shaderPass);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023026 RID: 143398 RVA: 0x00C1F0CC File Offset: 0x00C1D2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shaderPass(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			int shaderPass;
			LuaObject.checkType(l, 2, out shaderPass);
			customRenderTexture.shaderPass = shaderPass;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023027 RID: 143399 RVA: 0x00C1F124 File Offset: 0x00C1D324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cubemapFaceMask(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTexture.cubemapFaceMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023028 RID: 143400 RVA: 0x00C1F178 File Offset: 0x00C1D378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cubemapFaceMask(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			uint cubemapFaceMask;
			LuaObject.checkType(l, 2, out cubemapFaceMask);
			customRenderTexture.cubemapFaceMask = cubemapFaceMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023029 RID: 143401 RVA: 0x00C1F1D0 File Offset: 0x00C1D3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_doubleBuffered(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTexture.doubleBuffered);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602302A RID: 143402 RVA: 0x00C1F224 File Offset: 0x00C1D424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_doubleBuffered(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			bool doubleBuffered;
			LuaObject.checkType(l, 2, out doubleBuffered);
			customRenderTexture.doubleBuffered = doubleBuffered;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602302B RID: 143403 RVA: 0x00C1F27C File Offset: 0x00C1D47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wrapUpdateZones(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customRenderTexture.wrapUpdateZones);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602302C RID: 143404 RVA: 0x00C1F2D0 File Offset: 0x00C1D4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_wrapUpdateZones(IntPtr l)
	{
		int result;
		try
		{
			CustomRenderTexture customRenderTexture = (CustomRenderTexture)LuaObject.checkSelf(l);
			bool wrapUpdateZones;
			LuaObject.checkType(l, 2, out wrapUpdateZones);
			customRenderTexture.wrapUpdateZones = wrapUpdateZones;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602302D RID: 143405 RVA: 0x00C1F328 File Offset: 0x00C1D528
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CustomRenderTexture");
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.Update);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache0);
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.Initialize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1);
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.ClearUpdateZones);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache2);
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.GetUpdateZones);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache3);
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.SetUpdateZones);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache4);
		string name = "material";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_material);
		}
		LuaCSFunction get = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache5;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_material);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache6, true);
		string name2 = "initializationMaterial";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_initializationMaterial);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache7;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_initializationMaterial);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache8, true);
		string name3 = "initializationTexture";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_initializationTexture);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache9;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_initializationTexture);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheA, true);
		string name4 = "initializationSource";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_initializationSource);
		}
		LuaCSFunction get4 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheB;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_initializationSource);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheC, true);
		string name5 = "initializationColor";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_initializationColor);
		}
		LuaCSFunction get5 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheD;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_initializationColor);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheE, true);
		string name6 = "updateMode";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_updateMode);
		}
		LuaCSFunction get6 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cacheF;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_updateMode);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache10, true);
		string name7 = "initializationMode";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_initializationMode);
		}
		LuaCSFunction get7 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache11;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_initializationMode);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache12, true);
		string name8 = "updateZoneSpace";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_updateZoneSpace);
		}
		LuaCSFunction get8 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache13;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_updateZoneSpace);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache14, true);
		string name9 = "shaderPass";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_shaderPass);
		}
		LuaCSFunction get9 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache15;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_shaderPass);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache16, true);
		string name10 = "cubemapFaceMask";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_cubemapFaceMask);
		}
		LuaCSFunction get10 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache17;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_cubemapFaceMask);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache18, true);
		string name11 = "doubleBuffered";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_doubleBuffered);
		}
		LuaCSFunction get11 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache19;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_doubleBuffered);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1A, true);
		string name12 = "wrapUpdateZones";
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.get_wrapUpdateZones);
		}
		LuaCSFunction get12 = Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1B;
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.set_wrapUpdateZones);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1C, true);
		if (Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_CustomRenderTexture.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_CustomRenderTexture.<>f__mg$cache1D, typeof(CustomRenderTexture), typeof(RenderTexture));
	}

	// Token: 0x04018F6D RID: 102253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F6E RID: 102254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F6F RID: 102255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F70 RID: 102256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F71 RID: 102257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F72 RID: 102258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018F73 RID: 102259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018F74 RID: 102260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018F75 RID: 102261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018F76 RID: 102262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018F77 RID: 102263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018F78 RID: 102264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018F79 RID: 102265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018F7A RID: 102266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018F7B RID: 102267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018F7C RID: 102268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018F7D RID: 102269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018F7E RID: 102270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018F7F RID: 102271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018F80 RID: 102272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018F81 RID: 102273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018F82 RID: 102274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018F83 RID: 102275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018F84 RID: 102276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018F85 RID: 102277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018F86 RID: 102278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018F87 RID: 102279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018F88 RID: 102280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018F89 RID: 102281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018F8A RID: 102282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;
}
