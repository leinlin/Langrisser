using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001658 RID: 5720
[Preserve]
public class Lua_UnityEngine_CharacterInfo : LuaObject
{
	// Token: 0x06022E0A RID: 142858 RVA: 0x00C0E4A8 File Offset: 0x00C0C6A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo = default(CharacterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E0B RID: 142859 RVA: 0x00C0E4F8 File Offset: 0x00C0C6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_index(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E0C RID: 142860 RVA: 0x00C0E54C File Offset: 0x00C0C74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_index(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			int index;
			LuaObject.checkType(l, 2, out index);
			characterInfo.index = index;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E0D RID: 142861 RVA: 0x00C0E5B0 File Offset: 0x00C0C7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E0E RID: 142862 RVA: 0x00C0E604 File Offset: 0x00C0C804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			int size;
			LuaObject.checkType(l, 2, out size);
			characterInfo.size = size;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E0F RID: 142863 RVA: 0x00C0E668 File Offset: 0x00C0C868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_style(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)characterInfo.style);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E10 RID: 142864 RVA: 0x00C0E6BC File Offset: 0x00C0C8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_style(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			FontStyle style;
			LuaObject.checkEnum<FontStyle>(l, 2, out style);
			characterInfo.style = style;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E11 RID: 142865 RVA: 0x00C0E720 File Offset: 0x00C0C920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_advance(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.advance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E12 RID: 142866 RVA: 0x00C0E774 File Offset: 0x00C0C974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_advance(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			int advance;
			LuaObject.checkType(l, 2, out advance);
			characterInfo.advance = advance;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E13 RID: 142867 RVA: 0x00C0E7D8 File Offset: 0x00C0C9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_glyphWidth(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.glyphWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E14 RID: 142868 RVA: 0x00C0E82C File Offset: 0x00C0CA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_glyphWidth(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			int glyphWidth;
			LuaObject.checkType(l, 2, out glyphWidth);
			characterInfo.glyphWidth = glyphWidth;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E15 RID: 142869 RVA: 0x00C0E890 File Offset: 0x00C0CA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_glyphHeight(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.glyphHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E16 RID: 142870 RVA: 0x00C0E8E4 File Offset: 0x00C0CAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_glyphHeight(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			int glyphHeight;
			LuaObject.checkType(l, 2, out glyphHeight);
			characterInfo.glyphHeight = glyphHeight;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E17 RID: 142871 RVA: 0x00C0E948 File Offset: 0x00C0CB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bearing(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.bearing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E18 RID: 142872 RVA: 0x00C0E99C File Offset: 0x00C0CB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bearing(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			int bearing;
			LuaObject.checkType(l, 2, out bearing);
			characterInfo.bearing = bearing;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E19 RID: 142873 RVA: 0x00C0EA00 File Offset: 0x00C0CC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minY(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.minY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E1A RID: 142874 RVA: 0x00C0EA54 File Offset: 0x00C0CC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_minY(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			int minY;
			LuaObject.checkType(l, 2, out minY);
			characterInfo.minY = minY;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E1B RID: 142875 RVA: 0x00C0EAB8 File Offset: 0x00C0CCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxY(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.maxY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E1C RID: 142876 RVA: 0x00C0EB0C File Offset: 0x00C0CD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxY(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			int maxY;
			LuaObject.checkType(l, 2, out maxY);
			characterInfo.maxY = maxY;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E1D RID: 142877 RVA: 0x00C0EB70 File Offset: 0x00C0CD70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minX(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.minX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E1E RID: 142878 RVA: 0x00C0EBC4 File Offset: 0x00C0CDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_minX(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			int minX;
			LuaObject.checkType(l, 2, out minX);
			characterInfo.minX = minX;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E1F RID: 142879 RVA: 0x00C0EC28 File Offset: 0x00C0CE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxX(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.maxX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E20 RID: 142880 RVA: 0x00C0EC7C File Offset: 0x00C0CE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxX(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			int maxX;
			LuaObject.checkType(l, 2, out maxX);
			characterInfo.maxX = maxX;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E21 RID: 142881 RVA: 0x00C0ECE0 File Offset: 0x00C0CEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uvBottomLeft(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.uvBottomLeft);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E22 RID: 142882 RVA: 0x00C0ED34 File Offset: 0x00C0CF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uvBottomLeft(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			Vector2 uvBottomLeft;
			LuaObject.checkType(l, 2, out uvBottomLeft);
			characterInfo.uvBottomLeft = uvBottomLeft;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E23 RID: 142883 RVA: 0x00C0ED98 File Offset: 0x00C0CF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uvBottomRight(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.uvBottomRight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E24 RID: 142884 RVA: 0x00C0EDEC File Offset: 0x00C0CFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uvBottomRight(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			Vector2 uvBottomRight;
			LuaObject.checkType(l, 2, out uvBottomRight);
			characterInfo.uvBottomRight = uvBottomRight;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E25 RID: 142885 RVA: 0x00C0EE50 File Offset: 0x00C0D050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uvTopRight(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.uvTopRight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E26 RID: 142886 RVA: 0x00C0EEA4 File Offset: 0x00C0D0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uvTopRight(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			Vector2 uvTopRight;
			LuaObject.checkType(l, 2, out uvTopRight);
			characterInfo.uvTopRight = uvTopRight;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E27 RID: 142887 RVA: 0x00C0EF08 File Offset: 0x00C0D108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uvTopLeft(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterInfo.uvTopLeft);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E28 RID: 142888 RVA: 0x00C0EF5C File Offset: 0x00C0D15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uvTopLeft(IntPtr l)
	{
		int result;
		try
		{
			CharacterInfo characterInfo;
			LuaObject.checkValueType<CharacterInfo>(l, 1, out characterInfo);
			Vector2 uvTopLeft;
			LuaObject.checkType(l, 2, out uvTopLeft);
			characterInfo.uvTopLeft = uvTopLeft;
			LuaObject.setBack(l, characterInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E29 RID: 142889 RVA: 0x00C0EFC0 File Offset: 0x00C0D1C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CharacterInfo");
		string name = "index";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_index);
		}
		LuaCSFunction get = Lua_UnityEngine_CharacterInfo.<>f__mg$cache0;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_index);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CharacterInfo.<>f__mg$cache1, true);
		string name2 = "size";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_size);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache2;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_size);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CharacterInfo.<>f__mg$cache3, true);
		string name3 = "style";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_style);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache4;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_style);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_CharacterInfo.<>f__mg$cache5, true);
		string name4 = "advance";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_advance);
		}
		LuaCSFunction get4 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache6;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_advance);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_CharacterInfo.<>f__mg$cache7, true);
		string name5 = "glyphWidth";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_glyphWidth);
		}
		LuaCSFunction get5 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache8;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_glyphWidth);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_CharacterInfo.<>f__mg$cache9, true);
		string name6 = "glyphHeight";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_glyphHeight);
		}
		LuaCSFunction get6 = Lua_UnityEngine_CharacterInfo.<>f__mg$cacheA;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_glyphHeight);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_CharacterInfo.<>f__mg$cacheB, true);
		string name7 = "bearing";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_bearing);
		}
		LuaCSFunction get7 = Lua_UnityEngine_CharacterInfo.<>f__mg$cacheC;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_bearing);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_CharacterInfo.<>f__mg$cacheD, true);
		string name8 = "minY";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_minY);
		}
		LuaCSFunction get8 = Lua_UnityEngine_CharacterInfo.<>f__mg$cacheE;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_minY);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_CharacterInfo.<>f__mg$cacheF, true);
		string name9 = "maxY";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_maxY);
		}
		LuaCSFunction get9 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache10;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_maxY);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_CharacterInfo.<>f__mg$cache11, true);
		string name10 = "minX";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_minX);
		}
		LuaCSFunction get10 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache12;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_minX);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_CharacterInfo.<>f__mg$cache13, true);
		string name11 = "maxX";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_maxX);
		}
		LuaCSFunction get11 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache14;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_maxX);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_CharacterInfo.<>f__mg$cache15, true);
		string name12 = "uvBottomLeft";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_uvBottomLeft);
		}
		LuaCSFunction get12 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache16;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_uvBottomLeft);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_CharacterInfo.<>f__mg$cache17, true);
		string name13 = "uvBottomRight";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_uvBottomRight);
		}
		LuaCSFunction get13 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache18;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_uvBottomRight);
		}
		LuaObject.addMember(l, name13, get13, Lua_UnityEngine_CharacterInfo.<>f__mg$cache19, true);
		string name14 = "uvTopRight";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_uvTopRight);
		}
		LuaCSFunction get14 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache1A;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_uvTopRight);
		}
		LuaObject.addMember(l, name14, get14, Lua_UnityEngine_CharacterInfo.<>f__mg$cache1B, true);
		string name15 = "uvTopLeft";
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.get_uvTopLeft);
		}
		LuaCSFunction get15 = Lua_UnityEngine_CharacterInfo.<>f__mg$cache1C;
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.set_uvTopLeft);
		}
		LuaObject.addMember(l, name15, get15, Lua_UnityEngine_CharacterInfo.<>f__mg$cache1D, true);
		if (Lua_UnityEngine_CharacterInfo.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_CharacterInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_CharacterInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_CharacterInfo.<>f__mg$cache1E, typeof(CharacterInfo), typeof(ValueType));
	}

	// Token: 0x04018DB8 RID: 101816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018DB9 RID: 101817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018DBA RID: 101818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018DBB RID: 101819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018DBC RID: 101820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018DBD RID: 101821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018DBE RID: 101822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018DBF RID: 101823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018DC0 RID: 101824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018DC1 RID: 101825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018DC2 RID: 101826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018DC3 RID: 101827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018DC4 RID: 101828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018DC5 RID: 101829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018DC6 RID: 101830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018DC7 RID: 101831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018DC8 RID: 101832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018DC9 RID: 101833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018DCA RID: 101834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018DCB RID: 101835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018DCC RID: 101836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018DCD RID: 101837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018DCE RID: 101838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018DCF RID: 101839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018DD0 RID: 101840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018DD1 RID: 101841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018DD2 RID: 101842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018DD3 RID: 101843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018DD4 RID: 101844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018DD5 RID: 101845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018DD6 RID: 101846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;
}
