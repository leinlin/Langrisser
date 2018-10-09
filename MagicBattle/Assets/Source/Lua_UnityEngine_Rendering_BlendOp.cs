using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200177B RID: 6011
[Preserve]
public class Lua_UnityEngine_Rendering_BlendOp : LuaObject
{
	// Token: 0x06023A71 RID: 146033 RVA: 0x00C76680 File Offset: 0x00C74880
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.BlendOp");
		LuaObject.addMember(l, 0, "Add");
		LuaObject.addMember(l, 1, "Subtract");
		LuaObject.addMember(l, 2, "ReverseSubtract");
		LuaObject.addMember(l, 3, "Min");
		LuaObject.addMember(l, 4, "Max");
		LuaObject.addMember(l, 5, "LogicalClear");
		LuaObject.addMember(l, 6, "LogicalSet");
		LuaObject.addMember(l, 7, "LogicalCopy");
		LuaObject.addMember(l, 8, "LogicalCopyInverted");
		LuaObject.addMember(l, 9, "LogicalNoop");
		LuaObject.addMember(l, 10, "LogicalInvert");
		LuaObject.addMember(l, 11, "LogicalAnd");
		LuaObject.addMember(l, 12, "LogicalNand");
		LuaObject.addMember(l, 13, "LogicalOr");
		LuaObject.addMember(l, 14, "LogicalNor");
		LuaObject.addMember(l, 15, "LogicalXor");
		LuaObject.addMember(l, 16, "LogicalEquivalence");
		LuaObject.addMember(l, 17, "LogicalAndReverse");
		LuaObject.addMember(l, 18, "LogicalAndInverted");
		LuaObject.addMember(l, 19, "LogicalOrReverse");
		LuaObject.addMember(l, 20, "LogicalOrInverted");
		LuaObject.addMember(l, 21, "Multiply");
		LuaObject.addMember(l, 22, "Screen");
		LuaObject.addMember(l, 23, "Overlay");
		LuaObject.addMember(l, 24, "Darken");
		LuaObject.addMember(l, 25, "Lighten");
		LuaObject.addMember(l, 26, "ColorDodge");
		LuaObject.addMember(l, 27, "ColorBurn");
		LuaObject.addMember(l, 28, "HardLight");
		LuaObject.addMember(l, 29, "SoftLight");
		LuaObject.addMember(l, 30, "Difference");
		LuaObject.addMember(l, 31, "Exclusion");
		LuaObject.addMember(l, 32, "HSLHue");
		LuaObject.addMember(l, 33, "HSLSaturation");
		LuaObject.addMember(l, 34, "HSLColor");
		LuaObject.addMember(l, 35, "HSLLuminosity");
		LuaDLL.lua_pop(l, 1);
	}
}
