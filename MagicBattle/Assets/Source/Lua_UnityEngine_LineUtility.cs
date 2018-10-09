using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001719 RID: 5913
[Preserve]
public class Lua_UnityEngine_LineUtility : LuaObject
{
	// Token: 0x0602351D RID: 144669 RVA: 0x00C445F4 File Offset: 0x00C427F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LineUtility o = new LineUtility();
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

	// Token: 0x0602351E RID: 144670 RVA: 0x00C4463C File Offset: 0x00C4283C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Simplify_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(List<Vector2>), typeof(float), typeof(List<int>)))
			{
				List<Vector2> points;
				LuaObject.checkType<List<Vector2>>(l, 1, out points);
				float tolerance;
				LuaObject.checkType(l, 2, out tolerance);
				List<int> pointsToKeep;
				LuaObject.checkType<List<int>>(l, 3, out pointsToKeep);
				LineUtility.Simplify(points, tolerance, pointsToKeep);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(List<Vector2>), typeof(float), typeof(List<Vector2>)))
			{
				List<Vector2> points2;
				LuaObject.checkType<List<Vector2>>(l, 1, out points2);
				float tolerance2;
				LuaObject.checkType(l, 2, out tolerance2);
				List<Vector2> simplifiedPoints;
				LuaObject.checkType<List<Vector2>>(l, 3, out simplifiedPoints);
				LineUtility.Simplify(points2, tolerance2, simplifiedPoints);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(List<Vector3>), typeof(float), typeof(List<int>)))
			{
				List<Vector3> points3;
				LuaObject.checkType<List<Vector3>>(l, 1, out points3);
				float tolerance3;
				LuaObject.checkType(l, 2, out tolerance3);
				List<int> pointsToKeep2;
				LuaObject.checkType<List<int>>(l, 3, out pointsToKeep2);
				LineUtility.Simplify(points3, tolerance3, pointsToKeep2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(List<Vector3>), typeof(float), typeof(List<Vector3>)))
			{
				List<Vector3> points4;
				LuaObject.checkType<List<Vector3>>(l, 1, out points4);
				float tolerance4;
				LuaObject.checkType(l, 2, out tolerance4);
				List<Vector3> simplifiedPoints2;
				LuaObject.checkType<List<Vector3>>(l, 3, out simplifiedPoints2);
				LineUtility.Simplify(points4, tolerance4, simplifiedPoints2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Simplify to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602351F RID: 144671 RVA: 0x00C44824 File Offset: 0x00C42A24
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LineUtility");
		if (Lua_UnityEngine_LineUtility.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LineUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LineUtility.Simplify_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LineUtility.<>f__mg$cache0);
		if (Lua_UnityEngine_LineUtility.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LineUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LineUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_LineUtility.<>f__mg$cache1, typeof(LineUtility));
	}

	// Token: 0x04019349 RID: 103241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401934A RID: 103242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
