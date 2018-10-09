using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200168F RID: 5775
[Preserve]
public class Lua_UnityEngine_DrivenTransformProperties : LuaObject
{
	// Token: 0x06023088 RID: 143496 RVA: 0x00C21F7C File Offset: 0x00C2017C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.DrivenTransformProperties");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 2, "AnchoredPositionX");
		LuaObject.addMember(l, 4, "AnchoredPositionY");
		LuaObject.addMember(l, 6, "AnchoredPosition");
		LuaObject.addMember(l, 8, "AnchoredPositionZ");
		LuaObject.addMember(l, 14, "AnchoredPosition3D");
		LuaObject.addMember(l, 16, "Rotation");
		LuaObject.addMember(l, 32, "ScaleX");
		LuaObject.addMember(l, 64, "ScaleY");
		LuaObject.addMember(l, 128, "ScaleZ");
		LuaObject.addMember(l, 224, "Scale");
		LuaObject.addMember(l, 256, "AnchorMinX");
		LuaObject.addMember(l, 512, "AnchorMinY");
		LuaObject.addMember(l, 768, "AnchorMin");
		LuaObject.addMember(l, 1024, "AnchorMaxX");
		LuaObject.addMember(l, 2048, "AnchorMaxY");
		LuaObject.addMember(l, 3072, "AnchorMax");
		LuaObject.addMember(l, 3840, "Anchors");
		LuaObject.addMember(l, 4096, "SizeDeltaX");
		LuaObject.addMember(l, 8192, "SizeDeltaY");
		LuaObject.addMember(l, 12288, "SizeDelta");
		LuaObject.addMember(l, 16384, "PivotX");
		LuaObject.addMember(l, 32768, "PivotY");
		LuaObject.addMember(l, 49152, "Pivot");
		LuaObject.addMember(l, -1, "All");
		LuaDLL.lua_pop(l, 1);
	}
}
