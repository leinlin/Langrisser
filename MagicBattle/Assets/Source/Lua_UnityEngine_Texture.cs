using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x020017F8 RID: 6136
[Preserve]
public class Lua_UnityEngine_Texture : LuaObject
{
	// Token: 0x06023E84 RID: 147076 RVA: 0x00C9735C File Offset: 0x00C9555C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Texture o = new Texture();
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

	// Token: 0x06023E85 RID: 147077 RVA: 0x00C973A4 File Offset: 0x00C955A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNativeTexturePtr(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			IntPtr nativeTexturePtr = texture.GetNativeTexturePtr();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nativeTexturePtr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E86 RID: 147078 RVA: 0x00C97400 File Offset: 0x00C95600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGlobalAnisotropicFilteringLimits_s(IntPtr l)
	{
		int result;
		try
		{
			int forcedMin;
			LuaObject.checkType(l, 1, out forcedMin);
			int globalMax;
			LuaObject.checkType(l, 2, out globalMax);
			Texture.SetGlobalAnisotropicFilteringLimits(forcedMin, globalMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E87 RID: 147079 RVA: 0x00C97458 File Offset: 0x00C95658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_masterTextureLimit(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Texture.masterTextureLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E88 RID: 147080 RVA: 0x00C974A0 File Offset: 0x00C956A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_masterTextureLimit(IntPtr l)
	{
		int result;
		try
		{
			int masterTextureLimit;
			LuaObject.checkType(l, 2, out masterTextureLimit);
			Texture.masterTextureLimit = masterTextureLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E89 RID: 147081 RVA: 0x00C974EC File Offset: 0x00C956EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_anisotropicFiltering(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Texture.anisotropicFiltering);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E8A RID: 147082 RVA: 0x00C97534 File Offset: 0x00C95734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_anisotropicFiltering(IntPtr l)
	{
		int result;
		try
		{
			AnisotropicFiltering anisotropicFiltering;
			LuaObject.checkEnum<AnisotropicFiltering>(l, 2, out anisotropicFiltering);
			Texture.anisotropicFiltering = anisotropicFiltering;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E8B RID: 147083 RVA: 0x00C97580 File Offset: 0x00C95780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_width(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, texture.width);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E8C RID: 147084 RVA: 0x00C975D4 File Offset: 0x00C957D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_width(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			int width;
			LuaObject.checkType(l, 2, out width);
			texture.width = width;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E8D RID: 147085 RVA: 0x00C9762C File Offset: 0x00C9582C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, texture.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E8E RID: 147086 RVA: 0x00C97680 File Offset: 0x00C95880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_height(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			int height;
			LuaObject.checkType(l, 2, out height);
			texture.height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E8F RID: 147087 RVA: 0x00C976D8 File Offset: 0x00C958D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dimension(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)texture.dimension);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E90 RID: 147088 RVA: 0x00C9772C File Offset: 0x00C9592C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_dimension(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			TextureDimension dimension;
			LuaObject.checkEnum<TextureDimension>(l, 2, out dimension);
			texture.dimension = dimension;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E91 RID: 147089 RVA: 0x00C97784 File Offset: 0x00C95984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_filterMode(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)texture.filterMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E92 RID: 147090 RVA: 0x00C977D8 File Offset: 0x00C959D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_filterMode(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			FilterMode filterMode;
			LuaObject.checkEnum<FilterMode>(l, 2, out filterMode);
			texture.filterMode = filterMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E93 RID: 147091 RVA: 0x00C97830 File Offset: 0x00C95A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_anisoLevel(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, texture.anisoLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E94 RID: 147092 RVA: 0x00C97884 File Offset: 0x00C95A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_anisoLevel(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			int anisoLevel;
			LuaObject.checkType(l, 2, out anisoLevel);
			texture.anisoLevel = anisoLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E95 RID: 147093 RVA: 0x00C978DC File Offset: 0x00C95ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wrapMode(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)texture.wrapMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E96 RID: 147094 RVA: 0x00C97930 File Offset: 0x00C95B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_wrapMode(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			TextureWrapMode wrapMode;
			LuaObject.checkEnum<TextureWrapMode>(l, 2, out wrapMode);
			texture.wrapMode = wrapMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E97 RID: 147095 RVA: 0x00C97988 File Offset: 0x00C95B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wrapModeU(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)texture.wrapModeU);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E98 RID: 147096 RVA: 0x00C979DC File Offset: 0x00C95BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_wrapModeU(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			TextureWrapMode wrapModeU;
			LuaObject.checkEnum<TextureWrapMode>(l, 2, out wrapModeU);
			texture.wrapModeU = wrapModeU;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E99 RID: 147097 RVA: 0x00C97A34 File Offset: 0x00C95C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wrapModeV(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)texture.wrapModeV);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E9A RID: 147098 RVA: 0x00C97A88 File Offset: 0x00C95C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_wrapModeV(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			TextureWrapMode wrapModeV;
			LuaObject.checkEnum<TextureWrapMode>(l, 2, out wrapModeV);
			texture.wrapModeV = wrapModeV;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E9B RID: 147099 RVA: 0x00C97AE0 File Offset: 0x00C95CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wrapModeW(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)texture.wrapModeW);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E9C RID: 147100 RVA: 0x00C97B34 File Offset: 0x00C95D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_wrapModeW(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			TextureWrapMode wrapModeW;
			LuaObject.checkEnum<TextureWrapMode>(l, 2, out wrapModeW);
			texture.wrapModeW = wrapModeW;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E9D RID: 147101 RVA: 0x00C97B8C File Offset: 0x00C95D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mipMapBias(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, texture.mipMapBias);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E9E RID: 147102 RVA: 0x00C97BE0 File Offset: 0x00C95DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mipMapBias(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			float mipMapBias;
			LuaObject.checkType(l, 2, out mipMapBias);
			texture.mipMapBias = mipMapBias;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E9F RID: 147103 RVA: 0x00C97C38 File Offset: 0x00C95E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_texelSize(IntPtr l)
	{
		int result;
		try
		{
			Texture texture = (Texture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, texture.texelSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EA0 RID: 147104 RVA: 0x00C97C8C File Offset: 0x00C95E8C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Texture");
		if (Lua_UnityEngine_Texture.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Texture.GetNativeTexturePtr);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture.<>f__mg$cache0);
		if (Lua_UnityEngine_Texture.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Texture.SetGlobalAnisotropicFilteringLimits_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture.<>f__mg$cache1);
		string name = "masterTextureLimit";
		if (Lua_UnityEngine_Texture.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Texture.get_masterTextureLimit);
		}
		LuaCSFunction get = Lua_UnityEngine_Texture.<>f__mg$cache2;
		if (Lua_UnityEngine_Texture.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Texture.set_masterTextureLimit);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Texture.<>f__mg$cache3, false);
		string name2 = "anisotropicFiltering";
		if (Lua_UnityEngine_Texture.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Texture.get_anisotropicFiltering);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Texture.<>f__mg$cache4;
		if (Lua_UnityEngine_Texture.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Texture.set_anisotropicFiltering);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Texture.<>f__mg$cache5, false);
		string name3 = "width";
		if (Lua_UnityEngine_Texture.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Texture.get_width);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Texture.<>f__mg$cache6;
		if (Lua_UnityEngine_Texture.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Texture.set_width);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Texture.<>f__mg$cache7, true);
		string name4 = "height";
		if (Lua_UnityEngine_Texture.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Texture.get_height);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Texture.<>f__mg$cache8;
		if (Lua_UnityEngine_Texture.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Texture.set_height);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Texture.<>f__mg$cache9, true);
		string name5 = "dimension";
		if (Lua_UnityEngine_Texture.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Texture.get_dimension);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Texture.<>f__mg$cacheA;
		if (Lua_UnityEngine_Texture.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Texture.set_dimension);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Texture.<>f__mg$cacheB, true);
		string name6 = "filterMode";
		if (Lua_UnityEngine_Texture.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Texture.get_filterMode);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Texture.<>f__mg$cacheC;
		if (Lua_UnityEngine_Texture.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Texture.set_filterMode);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_Texture.<>f__mg$cacheD, true);
		string name7 = "anisoLevel";
		if (Lua_UnityEngine_Texture.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Texture.get_anisoLevel);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Texture.<>f__mg$cacheE;
		if (Lua_UnityEngine_Texture.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Texture.set_anisoLevel);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_Texture.<>f__mg$cacheF, true);
		string name8 = "wrapMode";
		if (Lua_UnityEngine_Texture.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Texture.get_wrapMode);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Texture.<>f__mg$cache10;
		if (Lua_UnityEngine_Texture.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Texture.set_wrapMode);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_Texture.<>f__mg$cache11, true);
		string name9 = "wrapModeU";
		if (Lua_UnityEngine_Texture.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Texture.get_wrapModeU);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Texture.<>f__mg$cache12;
		if (Lua_UnityEngine_Texture.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Texture.set_wrapModeU);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_Texture.<>f__mg$cache13, true);
		string name10 = "wrapModeV";
		if (Lua_UnityEngine_Texture.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Texture.get_wrapModeV);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Texture.<>f__mg$cache14;
		if (Lua_UnityEngine_Texture.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Texture.set_wrapModeV);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_Texture.<>f__mg$cache15, true);
		string name11 = "wrapModeW";
		if (Lua_UnityEngine_Texture.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Texture.get_wrapModeW);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Texture.<>f__mg$cache16;
		if (Lua_UnityEngine_Texture.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Texture.set_wrapModeW);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_Texture.<>f__mg$cache17, true);
		string name12 = "mipMapBias";
		if (Lua_UnityEngine_Texture.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Texture.get_mipMapBias);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Texture.<>f__mg$cache18;
		if (Lua_UnityEngine_Texture.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Texture.set_mipMapBias);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_Texture.<>f__mg$cache19, true);
		string name13 = "texelSize";
		if (Lua_UnityEngine_Texture.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Texture.get_texelSize);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Texture.<>f__mg$cache1A, null, true);
		if (Lua_UnityEngine_Texture.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Texture.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Texture.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Texture.<>f__mg$cache1B, typeof(Texture), typeof(UnityEngine.Object));
	}

	// Token: 0x04019AF2 RID: 105202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019AF3 RID: 105203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019AF4 RID: 105204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019AF5 RID: 105205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019AF6 RID: 105206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019AF7 RID: 105207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019AF8 RID: 105208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019AF9 RID: 105209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019AFA RID: 105210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019AFB RID: 105211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019AFC RID: 105212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019AFD RID: 105213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019AFE RID: 105214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019AFF RID: 105215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019B00 RID: 105216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019B01 RID: 105217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019B02 RID: 105218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019B03 RID: 105219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019B04 RID: 105220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019B05 RID: 105221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019B06 RID: 105222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019B07 RID: 105223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019B08 RID: 105224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019B09 RID: 105225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019B0A RID: 105226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019B0B RID: 105227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019B0C RID: 105228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019B0D RID: 105229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
