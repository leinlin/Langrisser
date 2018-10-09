using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017F1 RID: 6129
[Preserve]
public class Lua_UnityEngine_SystemLanguage : LuaObject
{
	// Token: 0x06023E2A RID: 146986 RVA: 0x00C94A60 File Offset: 0x00C92C60
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SystemLanguage");
		LuaObject.addMember(l, 0, "Afrikaans");
		LuaObject.addMember(l, 1, "Arabic");
		LuaObject.addMember(l, 2, "Basque");
		LuaObject.addMember(l, 3, "Belarusian");
		LuaObject.addMember(l, 4, "Bulgarian");
		LuaObject.addMember(l, 5, "Catalan");
		LuaObject.addMember(l, 6, "Chinese");
		LuaObject.addMember(l, 7, "Czech");
		LuaObject.addMember(l, 8, "Danish");
		LuaObject.addMember(l, 9, "Dutch");
		LuaObject.addMember(l, 10, "English");
		LuaObject.addMember(l, 11, "Estonian");
		LuaObject.addMember(l, 12, "Faroese");
		LuaObject.addMember(l, 13, "Finnish");
		LuaObject.addMember(l, 14, "French");
		LuaObject.addMember(l, 15, "German");
		LuaObject.addMember(l, 16, "Greek");
		LuaObject.addMember(l, 17, "Hebrew");
		LuaObject.addMember(l, 18, "Hungarian");
		LuaObject.addMember(l, 18, "Hugarian");
		LuaObject.addMember(l, 19, "Icelandic");
		LuaObject.addMember(l, 20, "Indonesian");
		LuaObject.addMember(l, 21, "Italian");
		LuaObject.addMember(l, 22, "Japanese");
		LuaObject.addMember(l, 23, "Korean");
		LuaObject.addMember(l, 24, "Latvian");
		LuaObject.addMember(l, 25, "Lithuanian");
		LuaObject.addMember(l, 26, "Norwegian");
		LuaObject.addMember(l, 27, "Polish");
		LuaObject.addMember(l, 28, "Portuguese");
		LuaObject.addMember(l, 29, "Romanian");
		LuaObject.addMember(l, 30, "Russian");
		LuaObject.addMember(l, 31, "SerboCroatian");
		LuaObject.addMember(l, 32, "Slovak");
		LuaObject.addMember(l, 33, "Slovenian");
		LuaObject.addMember(l, 34, "Spanish");
		LuaObject.addMember(l, 35, "Swedish");
		LuaObject.addMember(l, 36, "Thai");
		LuaObject.addMember(l, 37, "Turkish");
		LuaObject.addMember(l, 38, "Ukrainian");
		LuaObject.addMember(l, 39, "Vietnamese");
		LuaObject.addMember(l, 40, "ChineseSimplified");
		LuaObject.addMember(l, 41, "ChineseTraditional");
		LuaObject.addMember(l, 42, "Unknown");
		LuaDLL.lua_pop(l, 1);
	}
}
