using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016E2 RID: 5858
[Preserve]
public class Lua_UnityEngine_HumanBodyBones : LuaObject
{
	// Token: 0x0602332A RID: 144170 RVA: 0x00C363E0 File Offset: 0x00C345E0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.HumanBodyBones");
		LuaObject.addMember(l, 0, "Hips");
		LuaObject.addMember(l, 1, "LeftUpperLeg");
		LuaObject.addMember(l, 2, "RightUpperLeg");
		LuaObject.addMember(l, 3, "LeftLowerLeg");
		LuaObject.addMember(l, 4, "RightLowerLeg");
		LuaObject.addMember(l, 5, "LeftFoot");
		LuaObject.addMember(l, 6, "RightFoot");
		LuaObject.addMember(l, 7, "Spine");
		LuaObject.addMember(l, 8, "Chest");
		LuaObject.addMember(l, 9, "Neck");
		LuaObject.addMember(l, 10, "Head");
		LuaObject.addMember(l, 11, "LeftShoulder");
		LuaObject.addMember(l, 12, "RightShoulder");
		LuaObject.addMember(l, 13, "LeftUpperArm");
		LuaObject.addMember(l, 14, "RightUpperArm");
		LuaObject.addMember(l, 15, "LeftLowerArm");
		LuaObject.addMember(l, 16, "RightLowerArm");
		LuaObject.addMember(l, 17, "LeftHand");
		LuaObject.addMember(l, 18, "RightHand");
		LuaObject.addMember(l, 19, "LeftToes");
		LuaObject.addMember(l, 20, "RightToes");
		LuaObject.addMember(l, 21, "LeftEye");
		LuaObject.addMember(l, 22, "RightEye");
		LuaObject.addMember(l, 23, "Jaw");
		LuaObject.addMember(l, 24, "LeftThumbProximal");
		LuaObject.addMember(l, 25, "LeftThumbIntermediate");
		LuaObject.addMember(l, 26, "LeftThumbDistal");
		LuaObject.addMember(l, 27, "LeftIndexProximal");
		LuaObject.addMember(l, 28, "LeftIndexIntermediate");
		LuaObject.addMember(l, 29, "LeftIndexDistal");
		LuaObject.addMember(l, 30, "LeftMiddleProximal");
		LuaObject.addMember(l, 31, "LeftMiddleIntermediate");
		LuaObject.addMember(l, 32, "LeftMiddleDistal");
		LuaObject.addMember(l, 33, "LeftRingProximal");
		LuaObject.addMember(l, 34, "LeftRingIntermediate");
		LuaObject.addMember(l, 35, "LeftRingDistal");
		LuaObject.addMember(l, 36, "LeftLittleProximal");
		LuaObject.addMember(l, 37, "LeftLittleIntermediate");
		LuaObject.addMember(l, 38, "LeftLittleDistal");
		LuaObject.addMember(l, 39, "RightThumbProximal");
		LuaObject.addMember(l, 40, "RightThumbIntermediate");
		LuaObject.addMember(l, 41, "RightThumbDistal");
		LuaObject.addMember(l, 42, "RightIndexProximal");
		LuaObject.addMember(l, 43, "RightIndexIntermediate");
		LuaObject.addMember(l, 44, "RightIndexDistal");
		LuaObject.addMember(l, 45, "RightMiddleProximal");
		LuaObject.addMember(l, 46, "RightMiddleIntermediate");
		LuaObject.addMember(l, 47, "RightMiddleDistal");
		LuaObject.addMember(l, 48, "RightRingProximal");
		LuaObject.addMember(l, 49, "RightRingIntermediate");
		LuaObject.addMember(l, 50, "RightRingDistal");
		LuaObject.addMember(l, 51, "RightLittleProximal");
		LuaObject.addMember(l, 52, "RightLittleIntermediate");
		LuaObject.addMember(l, 53, "RightLittleDistal");
		LuaObject.addMember(l, 54, "UpperChest");
		LuaObject.addMember(l, 55, "LastBone");
		LuaDLL.lua_pop(l, 1);
	}
}
