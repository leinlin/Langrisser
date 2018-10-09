using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016CD RID: 5837
[Preserve]
public class Lua_UnityEngine_Font : LuaObject
{
	// Token: 0x0602322C RID: 143916 RVA: 0x00C2BD28 File Offset: 0x00C29F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Font o = new Font();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				string name;
				LuaObject.checkType(l, 2, out name);
				Font o = new Font(name);
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

	// Token: 0x0602322D RID: 143917 RVA: 0x00C2BDC0 File Offset: 0x00C29FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasCharacter(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			char c;
			LuaObject.checkType(l, 2, out c);
			bool b = font.HasCharacter(c);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602322E RID: 143918 RVA: 0x00C2BE24 File Offset: 0x00C2A024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RequestCharactersInTexture(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Font font = (Font)LuaObject.checkSelf(l);
				string characters;
				LuaObject.checkType(l, 2, out characters);
				font.RequestCharactersInTexture(characters);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Font font2 = (Font)LuaObject.checkSelf(l);
				string characters2;
				LuaObject.checkType(l, 2, out characters2);
				int size;
				LuaObject.checkType(l, 3, out size);
				font2.RequestCharactersInTexture(characters2, size);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Font font3 = (Font)LuaObject.checkSelf(l);
				string characters3;
				LuaObject.checkType(l, 2, out characters3);
				int size2;
				LuaObject.checkType(l, 3, out size2);
				FontStyle style;
				LuaObject.checkEnum<FontStyle>(l, 4, out style);
				font3.RequestCharactersInTexture(characters3, size2, style);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RequestCharactersInTexture to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602322F RID: 143919 RVA: 0x00C2BF34 File Offset: 0x00C2A134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCharacterInfo(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Font font = (Font)LuaObject.checkSelf(l);
				char ch;
				LuaObject.checkType(l, 2, out ch);
				CharacterInfo characterInfo2;
				bool characterInfo = font.GetCharacterInfo(ch, out characterInfo2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, characterInfo);
				LuaObject.pushValue(l, characterInfo2);
				result = 3;
			}
			else if (num == 4)
			{
				Font font2 = (Font)LuaObject.checkSelf(l);
				char ch2;
				LuaObject.checkType(l, 2, out ch2);
				int size;
				LuaObject.checkType(l, 4, out size);
				CharacterInfo characterInfo4;
				bool characterInfo3 = font2.GetCharacterInfo(ch2, out characterInfo4, size);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, characterInfo3);
				LuaObject.pushValue(l, characterInfo4);
				result = 3;
			}
			else if (num == 5)
			{
				Font font3 = (Font)LuaObject.checkSelf(l);
				char ch3;
				LuaObject.checkType(l, 2, out ch3);
				int size2;
				LuaObject.checkType(l, 4, out size2);
				FontStyle style;
				LuaObject.checkEnum<FontStyle>(l, 5, out style);
				CharacterInfo characterInfo6;
				bool characterInfo5 = font3.GetCharacterInfo(ch3, out characterInfo6, size2, style);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, characterInfo5);
				LuaObject.pushValue(l, characterInfo6);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetCharacterInfo to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023230 RID: 143920 RVA: 0x00C2C0A0 File Offset: 0x00C2A2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOSInstalledFontNames_s(IntPtr l)
	{
		int result;
		try
		{
			string[] osinstalledFontNames = Font.GetOSInstalledFontNames();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, osinstalledFontNames);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023231 RID: 143921 RVA: 0x00C2C0E8 File Offset: 0x00C2A2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateDynamicFontFromOSFont_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string[]), typeof(int)))
			{
				string[] fontnames;
				LuaObject.checkArray<string>(l, 1, out fontnames);
				int size;
				LuaObject.checkType(l, 2, out size);
				Font o = Font.CreateDynamicFontFromOSFont(fontnames, size);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(string), typeof(int)))
			{
				string fontname;
				LuaObject.checkType(l, 1, out fontname);
				int size2;
				LuaObject.checkType(l, 2, out size2);
				Font o2 = Font.CreateDynamicFontFromOSFont(fontname, size2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CreateDynamicFontFromOSFont to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023232 RID: 143922 RVA: 0x00C2C1E4 File Offset: 0x00C2A3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMaxVertsForString_s(IntPtr l)
	{
		int result;
		try
		{
			string str;
			LuaObject.checkType(l, 1, out str);
			int maxVertsForString = Font.GetMaxVertsForString(str);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, maxVertsForString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023233 RID: 143923 RVA: 0x00C2C238 File Offset: 0x00C2A438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_material(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, font.material);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023234 RID: 143924 RVA: 0x00C2C28C File Offset: 0x00C2A48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_material(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			Material material;
			LuaObject.checkType<Material>(l, 2, out material);
			font.material = material;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023235 RID: 143925 RVA: 0x00C2C2E4 File Offset: 0x00C2A4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fontNames(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, font.fontNames);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023236 RID: 143926 RVA: 0x00C2C338 File Offset: 0x00C2A538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fontNames(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			string[] fontNames;
			LuaObject.checkArray<string>(l, 2, out fontNames);
			font.fontNames = fontNames;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023237 RID: 143927 RVA: 0x00C2C390 File Offset: 0x00C2A590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_characterInfo(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, font.characterInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023238 RID: 143928 RVA: 0x00C2C3E4 File Offset: 0x00C2A5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_characterInfo(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			CharacterInfo[] characterInfo;
			LuaObject.checkArray<CharacterInfo>(l, 2, out characterInfo);
			font.characterInfo = characterInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023239 RID: 143929 RVA: 0x00C2C43C File Offset: 0x00C2A63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dynamic(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, font.dynamic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602323A RID: 143930 RVA: 0x00C2C490 File Offset: 0x00C2A690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ascent(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, font.ascent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602323B RID: 143931 RVA: 0x00C2C4E4 File Offset: 0x00C2A6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lineHeight(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, font.lineHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602323C RID: 143932 RVA: 0x00C2C538 File Offset: 0x00C2A738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fontSize(IntPtr l)
	{
		int result;
		try
		{
			Font font = (Font)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, font.fontSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602323D RID: 143933 RVA: 0x00C2C58C File Offset: 0x00C2A78C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Font");
		if (Lua_UnityEngine_Font.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Font.HasCharacter);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Font.<>f__mg$cache0);
		if (Lua_UnityEngine_Font.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Font.RequestCharactersInTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Font.<>f__mg$cache1);
		if (Lua_UnityEngine_Font.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Font.GetCharacterInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Font.<>f__mg$cache2);
		if (Lua_UnityEngine_Font.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Font.GetOSInstalledFontNames_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Font.<>f__mg$cache3);
		if (Lua_UnityEngine_Font.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Font.CreateDynamicFontFromOSFont_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Font.<>f__mg$cache4);
		if (Lua_UnityEngine_Font.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Font.GetMaxVertsForString_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Font.<>f__mg$cache5);
		string name = "material";
		if (Lua_UnityEngine_Font.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Font.get_material);
		}
		LuaCSFunction get = Lua_UnityEngine_Font.<>f__mg$cache6;
		if (Lua_UnityEngine_Font.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Font.set_material);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Font.<>f__mg$cache7, true);
		string name2 = "fontNames";
		if (Lua_UnityEngine_Font.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Font.get_fontNames);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Font.<>f__mg$cache8;
		if (Lua_UnityEngine_Font.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Font.set_fontNames);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Font.<>f__mg$cache9, true);
		string name3 = "characterInfo";
		if (Lua_UnityEngine_Font.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Font.get_characterInfo);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Font.<>f__mg$cacheA;
		if (Lua_UnityEngine_Font.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Font.set_characterInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Font.<>f__mg$cacheB, true);
		string name4 = "dynamic";
		if (Lua_UnityEngine_Font.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Font.get_dynamic);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Font.<>f__mg$cacheC, null, true);
		string name5 = "ascent";
		if (Lua_UnityEngine_Font.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Font.get_ascent);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Font.<>f__mg$cacheD, null, true);
		string name6 = "lineHeight";
		if (Lua_UnityEngine_Font.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Font.get_lineHeight);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Font.<>f__mg$cacheE, null, true);
		string name7 = "fontSize";
		if (Lua_UnityEngine_Font.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Font.get_fontSize);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Font.<>f__mg$cacheF, null, true);
		if (Lua_UnityEngine_Font.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Font.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Font.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Font.<>f__mg$cache10, typeof(Font), typeof(UnityEngine.Object));
	}

	// Token: 0x040190F0 RID: 102640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040190F1 RID: 102641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040190F2 RID: 102642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040190F3 RID: 102643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040190F4 RID: 102644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040190F5 RID: 102645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040190F6 RID: 102646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040190F7 RID: 102647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040190F8 RID: 102648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040190F9 RID: 102649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040190FA RID: 102650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040190FB RID: 102651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040190FC RID: 102652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040190FD RID: 102653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040190FE RID: 102654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040190FF RID: 102655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019100 RID: 102656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
