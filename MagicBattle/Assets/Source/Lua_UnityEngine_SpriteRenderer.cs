using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017E7 RID: 6119
[Preserve]
public class Lua_UnityEngine_SpriteRenderer : LuaObject
{
	// Token: 0x06023DB2 RID: 146866 RVA: 0x00C91600 File Offset: 0x00C8F800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sprite(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteRenderer.sprite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DB3 RID: 146867 RVA: 0x00C91654 File Offset: 0x00C8F854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sprite(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			Sprite sprite;
			LuaObject.checkType<Sprite>(l, 2, out sprite);
			spriteRenderer.sprite = sprite;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DB4 RID: 146868 RVA: 0x00C916AC File Offset: 0x00C8F8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_drawMode(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)spriteRenderer.drawMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DB5 RID: 146869 RVA: 0x00C91700 File Offset: 0x00C8F900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_drawMode(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			SpriteDrawMode drawMode;
			LuaObject.checkEnum<SpriteDrawMode>(l, 2, out drawMode);
			spriteRenderer.drawMode = drawMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DB6 RID: 146870 RVA: 0x00C91758 File Offset: 0x00C8F958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteRenderer.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DB7 RID: 146871 RVA: 0x00C917AC File Offset: 0x00C8F9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			Vector2 size;
			LuaObject.checkType(l, 2, out size);
			spriteRenderer.size = size;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DB8 RID: 146872 RVA: 0x00C91804 File Offset: 0x00C8FA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_adaptiveModeThreshold(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteRenderer.adaptiveModeThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DB9 RID: 146873 RVA: 0x00C91858 File Offset: 0x00C8FA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_adaptiveModeThreshold(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			float adaptiveModeThreshold;
			LuaObject.checkType(l, 2, out adaptiveModeThreshold);
			spriteRenderer.adaptiveModeThreshold = adaptiveModeThreshold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DBA RID: 146874 RVA: 0x00C918B0 File Offset: 0x00C8FAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tileMode(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)spriteRenderer.tileMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DBB RID: 146875 RVA: 0x00C91904 File Offset: 0x00C8FB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_tileMode(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			SpriteTileMode tileMode;
			LuaObject.checkEnum<SpriteTileMode>(l, 2, out tileMode);
			spriteRenderer.tileMode = tileMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DBC RID: 146876 RVA: 0x00C9195C File Offset: 0x00C8FB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_color(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteRenderer.color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DBD RID: 146877 RVA: 0x00C919B0 File Offset: 0x00C8FBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_color(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			Color color;
			LuaObject.checkType(l, 2, out color);
			spriteRenderer.color = color;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DBE RID: 146878 RVA: 0x00C91A08 File Offset: 0x00C8FC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flipX(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteRenderer.flipX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DBF RID: 146879 RVA: 0x00C91A5C File Offset: 0x00C8FC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_flipX(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			bool flipX;
			LuaObject.checkType(l, 2, out flipX);
			spriteRenderer.flipX = flipX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DC0 RID: 146880 RVA: 0x00C91AB4 File Offset: 0x00C8FCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flipY(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteRenderer.flipY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DC1 RID: 146881 RVA: 0x00C91B08 File Offset: 0x00C8FD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_flipY(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			bool flipY;
			LuaObject.checkType(l, 2, out flipY);
			spriteRenderer.flipY = flipY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DC2 RID: 146882 RVA: 0x00C91B60 File Offset: 0x00C8FD60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maskInteraction(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)spriteRenderer.maskInteraction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DC3 RID: 146883 RVA: 0x00C91BB4 File Offset: 0x00C8FDB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maskInteraction(IntPtr l)
	{
		int result;
		try
		{
			SpriteRenderer spriteRenderer = (SpriteRenderer)LuaObject.checkSelf(l);
			SpriteMaskInteraction maskInteraction;
			LuaObject.checkEnum<SpriteMaskInteraction>(l, 2, out maskInteraction);
			spriteRenderer.maskInteraction = maskInteraction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DC4 RID: 146884 RVA: 0x00C91C0C File Offset: 0x00C8FE0C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SpriteRenderer");
		string name = "sprite";
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.get_sprite);
		}
		LuaCSFunction get = Lua_UnityEngine_SpriteRenderer.<>f__mg$cache0;
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.set_sprite);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_SpriteRenderer.<>f__mg$cache1, true);
		string name2 = "drawMode";
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.get_drawMode);
		}
		LuaCSFunction get2 = Lua_UnityEngine_SpriteRenderer.<>f__mg$cache2;
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.set_drawMode);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_SpriteRenderer.<>f__mg$cache3, true);
		string name3 = "size";
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.get_size);
		}
		LuaCSFunction get3 = Lua_UnityEngine_SpriteRenderer.<>f__mg$cache4;
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.set_size);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_SpriteRenderer.<>f__mg$cache5, true);
		string name4 = "adaptiveModeThreshold";
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.get_adaptiveModeThreshold);
		}
		LuaCSFunction get4 = Lua_UnityEngine_SpriteRenderer.<>f__mg$cache6;
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.set_adaptiveModeThreshold);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_SpriteRenderer.<>f__mg$cache7, true);
		string name5 = "tileMode";
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.get_tileMode);
		}
		LuaCSFunction get5 = Lua_UnityEngine_SpriteRenderer.<>f__mg$cache8;
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.set_tileMode);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_SpriteRenderer.<>f__mg$cache9, true);
		string name6 = "color";
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.get_color);
		}
		LuaCSFunction get6 = Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheA;
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.set_color);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheB, true);
		string name7 = "flipX";
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.get_flipX);
		}
		LuaCSFunction get7 = Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheC;
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.set_flipX);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheD, true);
		string name8 = "flipY";
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.get_flipY);
		}
		LuaCSFunction get8 = Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheE;
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.set_flipY);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_SpriteRenderer.<>f__mg$cacheF, true);
		string name9 = "maskInteraction";
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.get_maskInteraction);
		}
		LuaCSFunction get9 = Lua_UnityEngine_SpriteRenderer.<>f__mg$cache10;
		if (Lua_UnityEngine_SpriteRenderer.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_SpriteRenderer.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_SpriteRenderer.set_maskInteraction);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_SpriteRenderer.<>f__mg$cache11, true);
		LuaObject.createTypeMetatable(l, null, typeof(SpriteRenderer), typeof(Renderer));
	}

	// Token: 0x04019A42 RID: 105026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A43 RID: 105027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A44 RID: 105028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A45 RID: 105029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A46 RID: 105030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019A47 RID: 105031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019A48 RID: 105032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019A49 RID: 105033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019A4A RID: 105034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019A4B RID: 105035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019A4C RID: 105036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019A4D RID: 105037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019A4E RID: 105038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019A4F RID: 105039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019A50 RID: 105040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019A51 RID: 105041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019A52 RID: 105042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019A53 RID: 105043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
