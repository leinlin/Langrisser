using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200173A RID: 5946
[Preserve]
public class Lua_UnityEngine_Physics2D : LuaObject
{
	// Token: 0x0602371F RID: 145183 RVA: 0x00C5ABA0 File Offset: 0x00C58DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Physics2D o = new Physics2D();
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

	// Token: 0x06023720 RID: 145184 RVA: 0x00C5ABE8 File Offset: 0x00C58DE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Linecast_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector2 start;
				LuaObject.checkType(l, 1, out start);
				Vector2 end;
				LuaObject.checkType(l, 2, out end);
				RaycastHit2D r = Physics2D.Linecast(start, end);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 start2;
				LuaObject.checkType(l, 1, out start2);
				Vector2 end2;
				LuaObject.checkType(l, 2, out end2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				RaycastHit2D r2 = Physics2D.Linecast(start2, end2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[])))
			{
				Vector2 start3;
				LuaObject.checkType(l, 1, out start3);
				Vector2 end3;
				LuaObject.checkType(l, 2, out end3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results);
				int i = Physics2D.Linecast(start3, end3, contactFilter, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)))
			{
				Vector2 start4;
				LuaObject.checkType(l, 1, out start4);
				Vector2 end4;
				LuaObject.checkType(l, 2, out end4);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 4, out minDepth);
				RaycastHit2D r3 = Physics2D.Linecast(start4, end4, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r3);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 start5;
				LuaObject.checkType(l, 1, out start5);
				Vector2 end5;
				LuaObject.checkType(l, 2, out end5);
				int layerMask3;
				LuaObject.checkType(l, 3, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 4, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 5, out maxDepth);
				RaycastHit2D r4 = Physics2D.Linecast(start5, end5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Linecast to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023721 RID: 145185 RVA: 0x00C5AE30 File Offset: 0x00C59030
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LinecastAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector2 start;
				LuaObject.checkType(l, 1, out start);
				Vector2 end;
				LuaObject.checkType(l, 2, out end);
				RaycastHit2D[] a = Physics2D.LinecastAll(start, end);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 start2;
				LuaObject.checkType(l, 1, out start2);
				Vector2 end2;
				LuaObject.checkType(l, 2, out end2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				RaycastHit2D[] a2 = Physics2D.LinecastAll(start2, end2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 start3;
				LuaObject.checkType(l, 1, out start3);
				Vector2 end3;
				LuaObject.checkType(l, 2, out end3);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 4, out minDepth);
				RaycastHit2D[] a3 = Physics2D.LinecastAll(start3, end3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 start4;
				LuaObject.checkType(l, 1, out start4);
				Vector2 end4;
				LuaObject.checkType(l, 2, out end4);
				int layerMask3;
				LuaObject.checkType(l, 3, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 4, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 5, out maxDepth);
				RaycastHit2D[] a4 = Physics2D.LinecastAll(start4, end4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LinecastAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023722 RID: 145186 RVA: 0x00C5AFC8 File Offset: 0x00C591C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LinecastNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector2 start;
				LuaObject.checkType(l, 1, out start);
				Vector2 end;
				LuaObject.checkType(l, 2, out end);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results);
				int i = Physics2D.LinecastNonAlloc(start, end, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 start2;
				LuaObject.checkType(l, 1, out start2);
				Vector2 end2;
				LuaObject.checkType(l, 2, out end2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				int i2 = Physics2D.LinecastNonAlloc(start2, end2, results2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 start3;
				LuaObject.checkType(l, 1, out start3);
				Vector2 end3;
				LuaObject.checkType(l, 2, out end3);
				RaycastHit2D[] results3;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results3);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 5, out minDepth);
				int i3 = Physics2D.LinecastNonAlloc(start3, end3, results3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 start4;
				LuaObject.checkType(l, 1, out start4);
				Vector2 end4;
				LuaObject.checkType(l, 2, out end4);
				RaycastHit2D[] results4;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results4);
				int layerMask3;
				LuaObject.checkType(l, 4, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 5, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 6, out maxDepth);
				int i4 = Physics2D.LinecastNonAlloc(start4, end4, results4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LinecastNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023723 RID: 145187 RVA: 0x00C5B190 File Offset: 0x00C59390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Raycast_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector2 direction;
				LuaObject.checkType(l, 2, out direction);
				RaycastHit2D r = Physics2D.Raycast(origin, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector2 direction2;
				LuaObject.checkType(l, 2, out direction2);
				float distance;
				LuaObject.checkType(l, 3, out distance);
				RaycastHit2D r2 = Physics2D.Raycast(origin2, direction2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[])))
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector2 direction3;
				LuaObject.checkType(l, 2, out direction3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results);
				int i = Physics2D.Raycast(origin3, direction3, contactFilter, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(float), typeof(int)))
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector2 direction4;
				LuaObject.checkType(l, 2, out direction4);
				float distance2;
				LuaObject.checkType(l, 3, out distance2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				RaycastHit2D r3 = Physics2D.Raycast(origin4, direction4, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[]), typeof(float)))
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				Vector2 direction5;
				LuaObject.checkType(l, 2, out direction5);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results2);
				float distance3;
				LuaObject.checkType(l, 5, out distance3);
				int i2 = Physics2D.Raycast(origin5, direction5, contactFilter2, results2, distance3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(float), typeof(int), typeof(float)))
			{
				Vector2 origin6;
				LuaObject.checkType(l, 1, out origin6);
				Vector2 direction6;
				LuaObject.checkType(l, 2, out direction6);
				float distance4;
				LuaObject.checkType(l, 3, out distance4);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 5, out minDepth);
				RaycastHit2D r4 = Physics2D.Raycast(origin6, direction6, distance4, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r4);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 origin7;
				LuaObject.checkType(l, 1, out origin7);
				Vector2 direction7;
				LuaObject.checkType(l, 2, out direction7);
				float distance5;
				LuaObject.checkType(l, 3, out distance5);
				int layerMask3;
				LuaObject.checkType(l, 4, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 5, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 6, out maxDepth);
				RaycastHit2D r5 = Physics2D.Raycast(origin7, direction7, distance5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Raycast to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023724 RID: 145188 RVA: 0x00C5B514 File Offset: 0x00C59714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaycastAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector2 direction;
				LuaObject.checkType(l, 2, out direction);
				RaycastHit2D[] a = Physics2D.RaycastAll(origin, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector2 direction2;
				LuaObject.checkType(l, 2, out direction2);
				float distance;
				LuaObject.checkType(l, 3, out distance);
				RaycastHit2D[] a2 = Physics2D.RaycastAll(origin2, direction2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector2 direction3;
				LuaObject.checkType(l, 2, out direction3);
				float distance2;
				LuaObject.checkType(l, 3, out distance2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				RaycastHit2D[] a3 = Physics2D.RaycastAll(origin3, direction3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector2 direction4;
				LuaObject.checkType(l, 2, out direction4);
				float distance3;
				LuaObject.checkType(l, 3, out distance3);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 5, out minDepth);
				RaycastHit2D[] a4 = Physics2D.RaycastAll(origin4, direction4, distance3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				Vector2 direction5;
				LuaObject.checkType(l, 2, out direction5);
				float distance4;
				LuaObject.checkType(l, 3, out distance4);
				int layerMask3;
				LuaObject.checkType(l, 4, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 5, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 6, out maxDepth);
				RaycastHit2D[] a5 = Physics2D.RaycastAll(origin5, direction5, distance4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RaycastAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023725 RID: 145189 RVA: 0x00C5B718 File Offset: 0x00C59918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaycastNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector2 direction;
				LuaObject.checkType(l, 2, out direction);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results);
				int i = Physics2D.RaycastNonAlloc(origin, direction, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector2 direction2;
				LuaObject.checkType(l, 2, out direction2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results2);
				float distance;
				LuaObject.checkType(l, 4, out distance);
				int i2 = Physics2D.RaycastNonAlloc(origin2, direction2, results2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector2 direction3;
				LuaObject.checkType(l, 2, out direction3);
				RaycastHit2D[] results3;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results3);
				float distance2;
				LuaObject.checkType(l, 4, out distance2);
				int layerMask;
				LuaObject.checkType(l, 5, out layerMask);
				int i3 = Physics2D.RaycastNonAlloc(origin3, direction3, results3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector2 direction4;
				LuaObject.checkType(l, 2, out direction4);
				RaycastHit2D[] results4;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results4);
				float distance3;
				LuaObject.checkType(l, 4, out distance3);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 6, out minDepth);
				int i4 = Physics2D.RaycastNonAlloc(origin4, direction4, results4, distance3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				Vector2 direction5;
				LuaObject.checkType(l, 2, out direction5);
				RaycastHit2D[] results5;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results5);
				float distance4;
				LuaObject.checkType(l, 4, out distance4);
				int layerMask3;
				LuaObject.checkType(l, 5, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 6, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 7, out maxDepth);
				int i5 = Physics2D.RaycastNonAlloc(origin5, direction5, results5, distance4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RaycastNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023726 RID: 145190 RVA: 0x00C5B958 File Offset: 0x00C59B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CircleCast_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				Vector2 direction;
				LuaObject.checkType(l, 3, out direction);
				RaycastHit2D r = Physics2D.CircleCast(origin, radius, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				Vector2 direction2;
				LuaObject.checkType(l, 3, out direction2);
				float distance;
				LuaObject.checkType(l, 4, out distance);
				RaycastHit2D r2 = Physics2D.CircleCast(origin2, radius2, direction2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(float), typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[])))
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				Vector2 direction3;
				LuaObject.checkType(l, 3, out direction3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 4, out contactFilter);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 5, out results);
				int i = Physics2D.CircleCast(origin3, radius3, direction3, contactFilter, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(float), typeof(Vector2), typeof(float), typeof(int)))
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				float radius4;
				LuaObject.checkType(l, 2, out radius4);
				Vector2 direction4;
				LuaObject.checkType(l, 3, out direction4);
				float distance2;
				LuaObject.checkType(l, 4, out distance2);
				int layerMask;
				LuaObject.checkType(l, 5, out layerMask);
				RaycastHit2D r3 = Physics2D.CircleCast(origin4, radius4, direction4, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(float), typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[]), typeof(float)))
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				float radius5;
				LuaObject.checkType(l, 2, out radius5);
				Vector2 direction5;
				LuaObject.checkType(l, 3, out direction5);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 4, out contactFilter2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 5, out results2);
				float distance3;
				LuaObject.checkType(l, 6, out distance3);
				int i2 = Physics2D.CircleCast(origin5, radius5, direction5, contactFilter2, results2, distance3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(float), typeof(Vector2), typeof(float), typeof(int), typeof(float)))
			{
				Vector2 origin6;
				LuaObject.checkType(l, 1, out origin6);
				float radius6;
				LuaObject.checkType(l, 2, out radius6);
				Vector2 direction6;
				LuaObject.checkType(l, 3, out direction6);
				float distance4;
				LuaObject.checkType(l, 4, out distance4);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 6, out minDepth);
				RaycastHit2D r4 = Physics2D.CircleCast(origin6, radius6, direction6, distance4, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r4);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 origin7;
				LuaObject.checkType(l, 1, out origin7);
				float radius7;
				LuaObject.checkType(l, 2, out radius7);
				Vector2 direction7;
				LuaObject.checkType(l, 3, out direction7);
				float distance5;
				LuaObject.checkType(l, 4, out distance5);
				int layerMask3;
				LuaObject.checkType(l, 5, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 6, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 7, out maxDepth);
				RaycastHit2D r5 = Physics2D.CircleCast(origin7, radius7, direction7, distance5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CircleCast to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023727 RID: 145191 RVA: 0x00C5BD5C File Offset: 0x00C59F5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CircleCastAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				Vector2 direction;
				LuaObject.checkType(l, 3, out direction);
				RaycastHit2D[] a = Physics2D.CircleCastAll(origin, radius, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				Vector2 direction2;
				LuaObject.checkType(l, 3, out direction2);
				float distance;
				LuaObject.checkType(l, 4, out distance);
				RaycastHit2D[] a2 = Physics2D.CircleCastAll(origin2, radius2, direction2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				Vector2 direction3;
				LuaObject.checkType(l, 3, out direction3);
				float distance2;
				LuaObject.checkType(l, 4, out distance2);
				int layerMask;
				LuaObject.checkType(l, 5, out layerMask);
				RaycastHit2D[] a3 = Physics2D.CircleCastAll(origin3, radius3, direction3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				float radius4;
				LuaObject.checkType(l, 2, out radius4);
				Vector2 direction4;
				LuaObject.checkType(l, 3, out direction4);
				float distance3;
				LuaObject.checkType(l, 4, out distance3);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 6, out minDepth);
				RaycastHit2D[] a4 = Physics2D.CircleCastAll(origin4, radius4, direction4, distance3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				float radius5;
				LuaObject.checkType(l, 2, out radius5);
				Vector2 direction5;
				LuaObject.checkType(l, 3, out direction5);
				float distance4;
				LuaObject.checkType(l, 4, out distance4);
				int layerMask3;
				LuaObject.checkType(l, 5, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 6, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 7, out maxDepth);
				RaycastHit2D[] a5 = Physics2D.CircleCastAll(origin5, radius5, direction5, distance4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CircleCastAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023728 RID: 145192 RVA: 0x00C5BF9C File Offset: 0x00C5A19C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CircleCastNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				Vector2 direction;
				LuaObject.checkType(l, 3, out direction);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results);
				int i = Physics2D.CircleCastNonAlloc(origin, radius, direction, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				Vector2 direction2;
				LuaObject.checkType(l, 3, out direction2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results2);
				float distance;
				LuaObject.checkType(l, 5, out distance);
				int i2 = Physics2D.CircleCastNonAlloc(origin2, radius2, direction2, results2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				Vector2 direction3;
				LuaObject.checkType(l, 3, out direction3);
				RaycastHit2D[] results3;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results3);
				float distance2;
				LuaObject.checkType(l, 5, out distance2);
				int layerMask;
				LuaObject.checkType(l, 6, out layerMask);
				int i3 = Physics2D.CircleCastNonAlloc(origin3, radius3, direction3, results3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				float radius4;
				LuaObject.checkType(l, 2, out radius4);
				Vector2 direction4;
				LuaObject.checkType(l, 3, out direction4);
				RaycastHit2D[] results4;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results4);
				float distance3;
				LuaObject.checkType(l, 5, out distance3);
				int layerMask2;
				LuaObject.checkType(l, 6, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 7, out minDepth);
				int i4 = Physics2D.CircleCastNonAlloc(origin4, radius4, direction4, results4, distance3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (num == 8)
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				float radius5;
				LuaObject.checkType(l, 2, out radius5);
				Vector2 direction5;
				LuaObject.checkType(l, 3, out direction5);
				RaycastHit2D[] results5;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results5);
				float distance4;
				LuaObject.checkType(l, 5, out distance4);
				int layerMask3;
				LuaObject.checkType(l, 6, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 7, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 8, out maxDepth);
				int i5 = Physics2D.CircleCastNonAlloc(origin5, radius5, direction5, results5, distance4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CircleCastNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023729 RID: 145193 RVA: 0x00C5C218 File Offset: 0x00C5A418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BoxCast_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				float angle;
				LuaObject.checkType(l, 3, out angle);
				Vector2 direction;
				LuaObject.checkType(l, 4, out direction);
				RaycastHit2D r = Physics2D.BoxCast(origin, size, angle, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				float angle2;
				LuaObject.checkType(l, 3, out angle2);
				Vector2 direction2;
				LuaObject.checkType(l, 4, out direction2);
				float distance;
				LuaObject.checkType(l, 5, out distance);
				RaycastHit2D r2 = Physics2D.BoxCast(origin2, size2, angle2, direction2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(float), typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[])))
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				float angle3;
				LuaObject.checkType(l, 3, out angle3);
				Vector2 direction3;
				LuaObject.checkType(l, 4, out direction3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 5, out contactFilter);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 6, out results);
				int i = Physics2D.BoxCast(origin3, size3, angle3, direction3, contactFilter, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(float), typeof(Vector2), typeof(float), typeof(int)))
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				float angle4;
				LuaObject.checkType(l, 3, out angle4);
				Vector2 direction4;
				LuaObject.checkType(l, 4, out direction4);
				float distance2;
				LuaObject.checkType(l, 5, out distance2);
				int layerMask;
				LuaObject.checkType(l, 6, out layerMask);
				RaycastHit2D r3 = Physics2D.BoxCast(origin4, size4, angle4, direction4, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(float), typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[]), typeof(float)))
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				Vector2 size5;
				LuaObject.checkType(l, 2, out size5);
				float angle5;
				LuaObject.checkType(l, 3, out angle5);
				Vector2 direction5;
				LuaObject.checkType(l, 4, out direction5);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 5, out contactFilter2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 6, out results2);
				float distance3;
				LuaObject.checkType(l, 7, out distance3);
				int i2 = Physics2D.BoxCast(origin5, size5, angle5, direction5, contactFilter2, results2, distance3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(float), typeof(Vector2), typeof(float), typeof(int), typeof(float)))
			{
				Vector2 origin6;
				LuaObject.checkType(l, 1, out origin6);
				Vector2 size6;
				LuaObject.checkType(l, 2, out size6);
				float angle6;
				LuaObject.checkType(l, 3, out angle6);
				Vector2 direction6;
				LuaObject.checkType(l, 4, out direction6);
				float distance4;
				LuaObject.checkType(l, 5, out distance4);
				int layerMask2;
				LuaObject.checkType(l, 6, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 7, out minDepth);
				RaycastHit2D r4 = Physics2D.BoxCast(origin6, size6, angle6, direction6, distance4, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r4);
				result = 2;
			}
			else if (num == 8)
			{
				Vector2 origin7;
				LuaObject.checkType(l, 1, out origin7);
				Vector2 size7;
				LuaObject.checkType(l, 2, out size7);
				float angle7;
				LuaObject.checkType(l, 3, out angle7);
				Vector2 direction7;
				LuaObject.checkType(l, 4, out direction7);
				float distance5;
				LuaObject.checkType(l, 5, out distance5);
				int layerMask3;
				LuaObject.checkType(l, 6, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 7, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 8, out maxDepth);
				RaycastHit2D r5 = Physics2D.BoxCast(origin7, size7, angle7, direction7, distance5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function BoxCast to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602372A RID: 145194 RVA: 0x00C5C698 File Offset: 0x00C5A898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BoxCastAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				float angle;
				LuaObject.checkType(l, 3, out angle);
				Vector2 direction;
				LuaObject.checkType(l, 4, out direction);
				RaycastHit2D[] a = Physics2D.BoxCastAll(origin, size, angle, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				float angle2;
				LuaObject.checkType(l, 3, out angle2);
				Vector2 direction2;
				LuaObject.checkType(l, 4, out direction2);
				float distance;
				LuaObject.checkType(l, 5, out distance);
				RaycastHit2D[] a2 = Physics2D.BoxCastAll(origin2, size2, angle2, direction2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				float angle3;
				LuaObject.checkType(l, 3, out angle3);
				Vector2 direction3;
				LuaObject.checkType(l, 4, out direction3);
				float distance2;
				LuaObject.checkType(l, 5, out distance2);
				int layerMask;
				LuaObject.checkType(l, 6, out layerMask);
				RaycastHit2D[] a3 = Physics2D.BoxCastAll(origin3, size3, angle3, direction3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				float angle4;
				LuaObject.checkType(l, 3, out angle4);
				Vector2 direction4;
				LuaObject.checkType(l, 4, out direction4);
				float distance3;
				LuaObject.checkType(l, 5, out distance3);
				int layerMask2;
				LuaObject.checkType(l, 6, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 7, out minDepth);
				RaycastHit2D[] a4 = Physics2D.BoxCastAll(origin4, size4, angle4, direction4, distance3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else if (num == 8)
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				Vector2 size5;
				LuaObject.checkType(l, 2, out size5);
				float angle5;
				LuaObject.checkType(l, 3, out angle5);
				Vector2 direction5;
				LuaObject.checkType(l, 4, out direction5);
				float distance4;
				LuaObject.checkType(l, 5, out distance4);
				int layerMask3;
				LuaObject.checkType(l, 6, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 7, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 8, out maxDepth);
				RaycastHit2D[] a5 = Physics2D.BoxCastAll(origin5, size5, angle5, direction5, distance4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function BoxCastAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602372B RID: 145195 RVA: 0x00C5C914 File Offset: 0x00C5AB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BoxCastNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				float angle;
				LuaObject.checkType(l, 3, out angle);
				Vector2 direction;
				LuaObject.checkType(l, 4, out direction);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 5, out results);
				int i = Physics2D.BoxCastNonAlloc(origin, size, angle, direction, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				float angle2;
				LuaObject.checkType(l, 3, out angle2);
				Vector2 direction2;
				LuaObject.checkType(l, 4, out direction2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 5, out results2);
				float distance;
				LuaObject.checkType(l, 6, out distance);
				int i2 = Physics2D.BoxCastNonAlloc(origin2, size2, angle2, direction2, results2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				float angle3;
				LuaObject.checkType(l, 3, out angle3);
				Vector2 direction3;
				LuaObject.checkType(l, 4, out direction3);
				RaycastHit2D[] results3;
				LuaObject.checkArray<RaycastHit2D>(l, 5, out results3);
				float distance2;
				LuaObject.checkType(l, 6, out distance2);
				int layerMask;
				LuaObject.checkType(l, 7, out layerMask);
				int i3 = Physics2D.BoxCastNonAlloc(origin3, size3, angle3, direction3, results3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 8)
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				float angle4;
				LuaObject.checkType(l, 3, out angle4);
				Vector2 direction4;
				LuaObject.checkType(l, 4, out direction4);
				RaycastHit2D[] results4;
				LuaObject.checkArray<RaycastHit2D>(l, 5, out results4);
				float distance3;
				LuaObject.checkType(l, 6, out distance3);
				int layerMask2;
				LuaObject.checkType(l, 7, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 8, out minDepth);
				int i4 = Physics2D.BoxCastNonAlloc(origin4, size4, angle4, direction4, results4, distance3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (num == 9)
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				Vector2 size5;
				LuaObject.checkType(l, 2, out size5);
				float angle5;
				LuaObject.checkType(l, 3, out angle5);
				Vector2 direction5;
				LuaObject.checkType(l, 4, out direction5);
				RaycastHit2D[] results5;
				LuaObject.checkArray<RaycastHit2D>(l, 5, out results5);
				float distance4;
				LuaObject.checkType(l, 6, out distance4);
				int layerMask3;
				LuaObject.checkType(l, 7, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 8, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 9, out maxDepth);
				int i5 = Physics2D.BoxCastNonAlloc(origin5, size5, angle5, direction5, results5, distance4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function BoxCastNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602372C RID: 145196 RVA: 0x00C5CBD0 File Offset: 0x00C5ADD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CapsuleCast_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				CapsuleDirection2D capsuleDirection;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection);
				float angle;
				LuaObject.checkType(l, 4, out angle);
				Vector2 direction;
				LuaObject.checkType(l, 5, out direction);
				RaycastHit2D r = Physics2D.CapsuleCast(origin, size, capsuleDirection, angle, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				CapsuleDirection2D capsuleDirection2;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection2);
				float angle2;
				LuaObject.checkType(l, 4, out angle2);
				Vector2 direction2;
				LuaObject.checkType(l, 5, out direction2);
				float distance;
				LuaObject.checkType(l, 6, out distance);
				RaycastHit2D r2 = Physics2D.CapsuleCast(origin2, size2, capsuleDirection2, angle2, direction2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(CapsuleDirection2D), typeof(float), typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[])))
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				CapsuleDirection2D capsuleDirection3;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection3);
				float angle3;
				LuaObject.checkType(l, 4, out angle3);
				Vector2 direction3;
				LuaObject.checkType(l, 5, out direction3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 6, out contactFilter);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 7, out results);
				int i = Physics2D.CapsuleCast(origin3, size3, capsuleDirection3, angle3, direction3, contactFilter, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(CapsuleDirection2D), typeof(float), typeof(Vector2), typeof(float), typeof(int)))
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				CapsuleDirection2D capsuleDirection4;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection4);
				float angle4;
				LuaObject.checkType(l, 4, out angle4);
				Vector2 direction4;
				LuaObject.checkType(l, 5, out direction4);
				float distance2;
				LuaObject.checkType(l, 6, out distance2);
				int layerMask;
				LuaObject.checkType(l, 7, out layerMask);
				RaycastHit2D r3 = Physics2D.CapsuleCast(origin4, size4, capsuleDirection4, angle4, direction4, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(CapsuleDirection2D), typeof(float), typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[]), typeof(float)))
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				Vector2 size5;
				LuaObject.checkType(l, 2, out size5);
				CapsuleDirection2D capsuleDirection5;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection5);
				float angle5;
				LuaObject.checkType(l, 4, out angle5);
				Vector2 direction5;
				LuaObject.checkType(l, 5, out direction5);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 6, out contactFilter2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 7, out results2);
				float distance3;
				LuaObject.checkType(l, 8, out distance3);
				int i2 = Physics2D.CapsuleCast(origin5, size5, capsuleDirection5, angle5, direction5, contactFilter2, results2, distance3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(CapsuleDirection2D), typeof(float), typeof(Vector2), typeof(float), typeof(int), typeof(float)))
			{
				Vector2 origin6;
				LuaObject.checkType(l, 1, out origin6);
				Vector2 size6;
				LuaObject.checkType(l, 2, out size6);
				CapsuleDirection2D capsuleDirection6;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection6);
				float angle6;
				LuaObject.checkType(l, 4, out angle6);
				Vector2 direction6;
				LuaObject.checkType(l, 5, out direction6);
				float distance4;
				LuaObject.checkType(l, 6, out distance4);
				int layerMask2;
				LuaObject.checkType(l, 7, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 8, out minDepth);
				RaycastHit2D r4 = Physics2D.CapsuleCast(origin6, size6, capsuleDirection6, angle6, direction6, distance4, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r4);
				result = 2;
			}
			else if (num == 9)
			{
				Vector2 origin7;
				LuaObject.checkType(l, 1, out origin7);
				Vector2 size7;
				LuaObject.checkType(l, 2, out size7);
				CapsuleDirection2D capsuleDirection7;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection7);
				float angle7;
				LuaObject.checkType(l, 4, out angle7);
				Vector2 direction7;
				LuaObject.checkType(l, 5, out direction7);
				float distance5;
				LuaObject.checkType(l, 6, out distance5);
				int layerMask3;
				LuaObject.checkType(l, 7, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 8, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 9, out maxDepth);
				RaycastHit2D r5 = Physics2D.CapsuleCast(origin7, size7, capsuleDirection7, angle7, direction7, distance5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, r5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CapsuleCast to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602372D RID: 145197 RVA: 0x00C5D0CC File Offset: 0x00C5B2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CapsuleCastAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				CapsuleDirection2D capsuleDirection;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection);
				float angle;
				LuaObject.checkType(l, 4, out angle);
				Vector2 direction;
				LuaObject.checkType(l, 5, out direction);
				RaycastHit2D[] a = Physics2D.CapsuleCastAll(origin, size, capsuleDirection, angle, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				CapsuleDirection2D capsuleDirection2;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection2);
				float angle2;
				LuaObject.checkType(l, 4, out angle2);
				Vector2 direction2;
				LuaObject.checkType(l, 5, out direction2);
				float distance;
				LuaObject.checkType(l, 6, out distance);
				RaycastHit2D[] a2 = Physics2D.CapsuleCastAll(origin2, size2, capsuleDirection2, angle2, direction2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				CapsuleDirection2D capsuleDirection3;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection3);
				float angle3;
				LuaObject.checkType(l, 4, out angle3);
				Vector2 direction3;
				LuaObject.checkType(l, 5, out direction3);
				float distance2;
				LuaObject.checkType(l, 6, out distance2);
				int layerMask;
				LuaObject.checkType(l, 7, out layerMask);
				RaycastHit2D[] a3 = Physics2D.CapsuleCastAll(origin3, size3, capsuleDirection3, angle3, direction3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 8)
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				CapsuleDirection2D capsuleDirection4;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection4);
				float angle4;
				LuaObject.checkType(l, 4, out angle4);
				Vector2 direction4;
				LuaObject.checkType(l, 5, out direction4);
				float distance3;
				LuaObject.checkType(l, 6, out distance3);
				int layerMask2;
				LuaObject.checkType(l, 7, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 8, out minDepth);
				RaycastHit2D[] a4 = Physics2D.CapsuleCastAll(origin4, size4, capsuleDirection4, angle4, direction4, distance3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else if (num == 9)
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				Vector2 size5;
				LuaObject.checkType(l, 2, out size5);
				CapsuleDirection2D capsuleDirection5;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection5);
				float angle5;
				LuaObject.checkType(l, 4, out angle5);
				Vector2 direction5;
				LuaObject.checkType(l, 5, out direction5);
				float distance4;
				LuaObject.checkType(l, 6, out distance4);
				int layerMask3;
				LuaObject.checkType(l, 7, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 8, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 9, out maxDepth);
				RaycastHit2D[] a5 = Physics2D.CapsuleCastAll(origin5, size5, capsuleDirection5, angle5, direction5, distance4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CapsuleCastAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602372E RID: 145198 RVA: 0x00C5D388 File Offset: 0x00C5B588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CapsuleCastNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 6)
			{
				Vector2 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				CapsuleDirection2D capsuleDirection;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection);
				float angle;
				LuaObject.checkType(l, 4, out angle);
				Vector2 direction;
				LuaObject.checkType(l, 5, out direction);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 6, out results);
				int i = Physics2D.CapsuleCastNonAlloc(origin, size, capsuleDirection, angle, direction, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				CapsuleDirection2D capsuleDirection2;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection2);
				float angle2;
				LuaObject.checkType(l, 4, out angle2);
				Vector2 direction2;
				LuaObject.checkType(l, 5, out direction2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 6, out results2);
				float distance;
				LuaObject.checkType(l, 7, out distance);
				int i2 = Physics2D.CapsuleCastNonAlloc(origin2, size2, capsuleDirection2, angle2, direction2, results2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 8)
			{
				Vector2 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				CapsuleDirection2D capsuleDirection3;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection3);
				float angle3;
				LuaObject.checkType(l, 4, out angle3);
				Vector2 direction3;
				LuaObject.checkType(l, 5, out direction3);
				RaycastHit2D[] results3;
				LuaObject.checkArray<RaycastHit2D>(l, 6, out results3);
				float distance2;
				LuaObject.checkType(l, 7, out distance2);
				int layerMask;
				LuaObject.checkType(l, 8, out layerMask);
				int i3 = Physics2D.CapsuleCastNonAlloc(origin3, size3, capsuleDirection3, angle3, direction3, results3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 9)
			{
				Vector2 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				CapsuleDirection2D capsuleDirection4;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection4);
				float angle4;
				LuaObject.checkType(l, 4, out angle4);
				Vector2 direction4;
				LuaObject.checkType(l, 5, out direction4);
				RaycastHit2D[] results4;
				LuaObject.checkArray<RaycastHit2D>(l, 6, out results4);
				float distance3;
				LuaObject.checkType(l, 7, out distance3);
				int layerMask2;
				LuaObject.checkType(l, 8, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 9, out minDepth);
				int i4 = Physics2D.CapsuleCastNonAlloc(origin4, size4, capsuleDirection4, angle4, direction4, results4, distance3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (num == 10)
			{
				Vector2 origin5;
				LuaObject.checkType(l, 1, out origin5);
				Vector2 size5;
				LuaObject.checkType(l, 2, out size5);
				CapsuleDirection2D capsuleDirection5;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out capsuleDirection5);
				float angle5;
				LuaObject.checkType(l, 4, out angle5);
				Vector2 direction5;
				LuaObject.checkType(l, 5, out direction5);
				RaycastHit2D[] results5;
				LuaObject.checkArray<RaycastHit2D>(l, 6, out results5);
				float distance4;
				LuaObject.checkType(l, 7, out distance4);
				int layerMask3;
				LuaObject.checkType(l, 8, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 9, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 10, out maxDepth);
				int i5 = Physics2D.CapsuleCastNonAlloc(origin5, size5, capsuleDirection5, angle5, direction5, results5, distance4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CapsuleCastNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602372F RID: 145199 RVA: 0x00C5D680 File Offset: 0x00C5B880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRayIntersection_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Ray ray;
				LuaObject.checkValueType<Ray>(l, 1, out ray);
				float distance;
				LuaObject.checkType(l, 2, out distance);
				RaycastHit2D rayIntersection = Physics2D.GetRayIntersection(ray, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rayIntersection);
				result = 2;
			}
			else if (num == 1)
			{
				Ray ray2;
				LuaObject.checkValueType<Ray>(l, 1, out ray2);
				RaycastHit2D rayIntersection2 = Physics2D.GetRayIntersection(ray2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rayIntersection2);
				result = 2;
			}
			else if (num == 3)
			{
				Ray ray3;
				LuaObject.checkValueType<Ray>(l, 1, out ray3);
				float distance2;
				LuaObject.checkType(l, 2, out distance2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				RaycastHit2D rayIntersection3 = Physics2D.GetRayIntersection(ray3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rayIntersection3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetRayIntersection to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023730 RID: 145200 RVA: 0x00C5D784 File Offset: 0x00C5B984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRayIntersectionAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Ray ray;
				LuaObject.checkValueType<Ray>(l, 1, out ray);
				RaycastHit2D[] rayIntersectionAll = Physics2D.GetRayIntersectionAll(ray);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rayIntersectionAll);
				result = 2;
			}
			else if (num == 2)
			{
				Ray ray2;
				LuaObject.checkValueType<Ray>(l, 1, out ray2);
				float distance;
				LuaObject.checkType(l, 2, out distance);
				RaycastHit2D[] rayIntersectionAll2 = Physics2D.GetRayIntersectionAll(ray2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rayIntersectionAll2);
				result = 2;
			}
			else if (num == 3)
			{
				Ray ray3;
				LuaObject.checkValueType<Ray>(l, 1, out ray3);
				float distance2;
				LuaObject.checkType(l, 2, out distance2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				RaycastHit2D[] rayIntersectionAll3 = Physics2D.GetRayIntersectionAll(ray3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rayIntersectionAll3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetRayIntersectionAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023731 RID: 145201 RVA: 0x00C5D884 File Offset: 0x00C5BA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRayIntersectionNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Ray ray;
				LuaObject.checkValueType<Ray>(l, 1, out ray);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 2, out results);
				int rayIntersectionNonAlloc = Physics2D.GetRayIntersectionNonAlloc(ray, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rayIntersectionNonAlloc);
				result = 2;
			}
			else if (num == 3)
			{
				Ray ray2;
				LuaObject.checkValueType<Ray>(l, 1, out ray2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 2, out results2);
				float distance;
				LuaObject.checkType(l, 3, out distance);
				int rayIntersectionNonAlloc2 = Physics2D.GetRayIntersectionNonAlloc(ray2, results2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rayIntersectionNonAlloc2);
				result = 2;
			}
			else if (num == 4)
			{
				Ray ray3;
				LuaObject.checkValueType<Ray>(l, 1, out ray3);
				RaycastHit2D[] results3;
				LuaObject.checkArray<RaycastHit2D>(l, 2, out results3);
				float distance2;
				LuaObject.checkType(l, 3, out distance2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				int rayIntersectionNonAlloc3 = Physics2D.GetRayIntersectionNonAlloc(ray3, results3, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, rayIntersectionNonAlloc3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetRayIntersectionNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023732 RID: 145202 RVA: 0x00C5D9AC File Offset: 0x00C5BBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapPoint_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(int), typeof(float)))
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				int layerMask;
				LuaObject.checkType(l, 2, out layerMask);
				float minDepth;
				LuaObject.checkType(l, 3, out minDepth);
				Collider2D o = Physics2D.OverlapPoint(point, layerMask, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				int layerMask2;
				LuaObject.checkType(l, 2, out layerMask2);
				Collider2D o2 = Physics2D.OverlapPoint(point2, layerMask2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 1)
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				Collider2D o3 = Physics2D.OverlapPoint(point3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(ContactFilter2D), typeof(Collider2D[])))
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter);
				Collider2D[] results;
				LuaObject.checkArray<Collider2D>(l, 3, out results);
				int i = Physics2D.OverlapPoint(point4, contactFilter, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 point5;
				LuaObject.checkType(l, 1, out point5);
				int layerMask3;
				LuaObject.checkType(l, 2, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 3, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 4, out maxDepth);
				Collider2D o4 = Physics2D.OverlapPoint(point5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapPoint to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023733 RID: 145203 RVA: 0x00C5DBA4 File Offset: 0x00C5BDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapPointAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				Collider2D[] a = Physics2D.OverlapPointAll(point);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 2)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				int layerMask;
				LuaObject.checkType(l, 2, out layerMask);
				Collider2D[] a2 = Physics2D.OverlapPointAll(point2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				int layerMask2;
				LuaObject.checkType(l, 2, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 3, out minDepth);
				Collider2D[] a3 = Physics2D.OverlapPointAll(point3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				int layerMask3;
				LuaObject.checkType(l, 2, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 3, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 4, out maxDepth);
				Collider2D[] a4 = Physics2D.OverlapPointAll(point4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapPointAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023734 RID: 145204 RVA: 0x00C5DD04 File Offset: 0x00C5BF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapPointNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				Collider2D[] results;
				LuaObject.checkArray<Collider2D>(l, 2, out results);
				int i = Physics2D.OverlapPointNonAlloc(point, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				Collider2D[] results2;
				LuaObject.checkArray<Collider2D>(l, 2, out results2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				int i2 = Physics2D.OverlapPointNonAlloc(point2, results2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				Collider2D[] results3;
				LuaObject.checkArray<Collider2D>(l, 2, out results3);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 4, out minDepth);
				int i3 = Physics2D.OverlapPointNonAlloc(point3, results3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				Collider2D[] results4;
				LuaObject.checkArray<Collider2D>(l, 2, out results4);
				int layerMask3;
				LuaObject.checkType(l, 3, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 4, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 5, out maxDepth);
				int i4 = Physics2D.OverlapPointNonAlloc(point4, results4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapPointNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023735 RID: 145205 RVA: 0x00C5DE9C File Offset: 0x00C5C09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapCircle_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				Collider2D o = Physics2D.OverlapCircle(point, radius);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				Collider2D o2 = Physics2D.OverlapCircle(point2, radius2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(float), typeof(ContactFilter2D), typeof(Collider2D[])))
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter);
				Collider2D[] results;
				LuaObject.checkArray<Collider2D>(l, 4, out results);
				int i = Physics2D.OverlapCircle(point3, radius3, contactFilter, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(float), typeof(int), typeof(float)))
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				float radius4;
				LuaObject.checkType(l, 2, out radius4);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 4, out minDepth);
				Collider2D o3 = Physics2D.OverlapCircle(point4, radius4, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 point5;
				LuaObject.checkType(l, 1, out point5);
				float radius5;
				LuaObject.checkType(l, 2, out radius5);
				int layerMask3;
				LuaObject.checkType(l, 3, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 4, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 5, out maxDepth);
				Collider2D o4 = Physics2D.OverlapCircle(point5, radius5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapCircle to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023736 RID: 145206 RVA: 0x00C5E0E4 File Offset: 0x00C5C2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapCircleAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				Collider2D[] a = Physics2D.OverlapCircleAll(point, radius);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				Collider2D[] a2 = Physics2D.OverlapCircleAll(point2, radius2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 4, out minDepth);
				Collider2D[] a3 = Physics2D.OverlapCircleAll(point3, radius3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				float radius4;
				LuaObject.checkType(l, 2, out radius4);
				int layerMask3;
				LuaObject.checkType(l, 3, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 4, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 5, out maxDepth);
				Collider2D[] a4 = Physics2D.OverlapCircleAll(point4, radius4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapCircleAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023737 RID: 145207 RVA: 0x00C5E27C File Offset: 0x00C5C47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapCircleNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				Collider2D[] results;
				LuaObject.checkArray<Collider2D>(l, 3, out results);
				int i = Physics2D.OverlapCircleNonAlloc(point, radius, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				Collider2D[] results2;
				LuaObject.checkArray<Collider2D>(l, 3, out results2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				int i2 = Physics2D.OverlapCircleNonAlloc(point2, radius2, results2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				Collider2D[] results3;
				LuaObject.checkArray<Collider2D>(l, 3, out results3);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 5, out minDepth);
				int i3 = Physics2D.OverlapCircleNonAlloc(point3, radius3, results3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				float radius4;
				LuaObject.checkType(l, 2, out radius4);
				Collider2D[] results4;
				LuaObject.checkArray<Collider2D>(l, 3, out results4);
				int layerMask3;
				LuaObject.checkType(l, 4, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 5, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 6, out maxDepth);
				int i4 = Physics2D.OverlapCircleNonAlloc(point4, radius4, results4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapCircleNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023738 RID: 145208 RVA: 0x00C5E444 File Offset: 0x00C5C644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OverlapBox_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				float angle;
				LuaObject.checkType(l, 3, out angle);
				Collider2D o = Physics2D.OverlapBox(point, size, angle);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				float angle2;
				LuaObject.checkType(l, 3, out angle2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				Collider2D o2 = Physics2D.OverlapBox(point2, size2, angle2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(float), typeof(ContactFilter2D), typeof(Collider2D[])))
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				float angle3;
				LuaObject.checkType(l, 3, out angle3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 4, out contactFilter);
				Collider2D[] results;
				LuaObject.checkArray<Collider2D>(l, 5, out results);
				int i = Physics2D.OverlapBox(point3, size3, angle3, contactFilter, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(float), typeof(int), typeof(float)))
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				float angle4;
				LuaObject.checkType(l, 3, out angle4);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 5, out minDepth);
				Collider2D o3 = Physics2D.OverlapBox(point4, size4, angle4, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 point5;
				LuaObject.checkType(l, 1, out point5);
				Vector2 size5;
				LuaObject.checkType(l, 2, out size5);
				float angle5;
				LuaObject.checkType(l, 3, out angle5);
				int layerMask3;
				LuaObject.checkType(l, 4, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 5, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 6, out maxDepth);
				Collider2D o4 = Physics2D.OverlapBox(point5, size5, angle5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapBox to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023739 RID: 145209 RVA: 0x00C5E6DC File Offset: 0x00C5C8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapBoxAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				float angle;
				LuaObject.checkType(l, 3, out angle);
				Collider2D[] a = Physics2D.OverlapBoxAll(point, size, angle);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				float angle2;
				LuaObject.checkType(l, 3, out angle2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				Collider2D[] a2 = Physics2D.OverlapBoxAll(point2, size2, angle2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				float angle3;
				LuaObject.checkType(l, 3, out angle3);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 5, out minDepth);
				Collider2D[] a3 = Physics2D.OverlapBoxAll(point3, size3, angle3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				float angle4;
				LuaObject.checkType(l, 3, out angle4);
				int layerMask3;
				LuaObject.checkType(l, 4, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 5, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 6, out maxDepth);
				Collider2D[] a4 = Physics2D.OverlapBoxAll(point4, size4, angle4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapBoxAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602373A RID: 145210 RVA: 0x00C5E8A4 File Offset: 0x00C5CAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapBoxNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				float angle;
				LuaObject.checkType(l, 3, out angle);
				Collider2D[] results;
				LuaObject.checkArray<Collider2D>(l, 4, out results);
				int i = Physics2D.OverlapBoxNonAlloc(point, size, angle, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				float angle2;
				LuaObject.checkType(l, 3, out angle2);
				Collider2D[] results2;
				LuaObject.checkArray<Collider2D>(l, 4, out results2);
				int layerMask;
				LuaObject.checkType(l, 5, out layerMask);
				int i2 = Physics2D.OverlapBoxNonAlloc(point2, size2, angle2, results2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				float angle3;
				LuaObject.checkType(l, 3, out angle3);
				Collider2D[] results3;
				LuaObject.checkArray<Collider2D>(l, 4, out results3);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 6, out minDepth);
				int i3 = Physics2D.OverlapBoxNonAlloc(point3, size3, angle3, results3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				float angle4;
				LuaObject.checkType(l, 3, out angle4);
				Collider2D[] results4;
				LuaObject.checkArray<Collider2D>(l, 4, out results4);
				int layerMask3;
				LuaObject.checkType(l, 5, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 6, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 7, out maxDepth);
				int i4 = Physics2D.OverlapBoxNonAlloc(point4, size4, angle4, results4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapBoxNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602373B RID: 145211 RVA: 0x00C5EA9C File Offset: 0x00C5CC9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OverlapArea_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector2 pointA;
				LuaObject.checkType(l, 1, out pointA);
				Vector2 pointB;
				LuaObject.checkType(l, 2, out pointB);
				Collider2D o = Physics2D.OverlapArea(pointA, pointB);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 pointA2;
				LuaObject.checkType(l, 1, out pointA2);
				Vector2 pointB2;
				LuaObject.checkType(l, 2, out pointB2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				Collider2D o2 = Physics2D.OverlapArea(pointA2, pointB2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(ContactFilter2D), typeof(Collider2D[])))
			{
				Vector2 pointA3;
				LuaObject.checkType(l, 1, out pointA3);
				Vector2 pointB3;
				LuaObject.checkType(l, 2, out pointB3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter);
				Collider2D[] results;
				LuaObject.checkArray<Collider2D>(l, 4, out results);
				int i = Physics2D.OverlapArea(pointA3, pointB3, contactFilter, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(int), typeof(float)))
			{
				Vector2 pointA4;
				LuaObject.checkType(l, 1, out pointA4);
				Vector2 pointB4;
				LuaObject.checkType(l, 2, out pointB4);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 4, out minDepth);
				Collider2D o3 = Physics2D.OverlapArea(pointA4, pointB4, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 pointA5;
				LuaObject.checkType(l, 1, out pointA5);
				Vector2 pointB5;
				LuaObject.checkType(l, 2, out pointB5);
				int layerMask3;
				LuaObject.checkType(l, 3, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 4, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 5, out maxDepth);
				Collider2D o4 = Physics2D.OverlapArea(pointA5, pointB5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapArea to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602373C RID: 145212 RVA: 0x00C5ECE4 File Offset: 0x00C5CEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapAreaAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector2 pointA;
				LuaObject.checkType(l, 1, out pointA);
				Vector2 pointB;
				LuaObject.checkType(l, 2, out pointB);
				Collider2D[] a = Physics2D.OverlapAreaAll(pointA, pointB);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 3)
			{
				Vector2 pointA2;
				LuaObject.checkType(l, 1, out pointA2);
				Vector2 pointB2;
				LuaObject.checkType(l, 2, out pointB2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				Collider2D[] a2 = Physics2D.OverlapAreaAll(pointA2, pointB2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 pointA3;
				LuaObject.checkType(l, 1, out pointA3);
				Vector2 pointB3;
				LuaObject.checkType(l, 2, out pointB3);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 4, out minDepth);
				Collider2D[] a3 = Physics2D.OverlapAreaAll(pointA3, pointB3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 pointA4;
				LuaObject.checkType(l, 1, out pointA4);
				Vector2 pointB4;
				LuaObject.checkType(l, 2, out pointB4);
				int layerMask3;
				LuaObject.checkType(l, 3, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 4, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 5, out maxDepth);
				Collider2D[] a4 = Physics2D.OverlapAreaAll(pointA4, pointB4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapAreaAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602373D RID: 145213 RVA: 0x00C5EE7C File Offset: 0x00C5D07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapAreaNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector2 pointA;
				LuaObject.checkType(l, 1, out pointA);
				Vector2 pointB;
				LuaObject.checkType(l, 2, out pointB);
				Collider2D[] results;
				LuaObject.checkArray<Collider2D>(l, 3, out results);
				int i = Physics2D.OverlapAreaNonAlloc(pointA, pointB, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				Vector2 pointA2;
				LuaObject.checkType(l, 1, out pointA2);
				Vector2 pointB2;
				LuaObject.checkType(l, 2, out pointB2);
				Collider2D[] results2;
				LuaObject.checkArray<Collider2D>(l, 3, out results2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				int i2 = Physics2D.OverlapAreaNonAlloc(pointA2, pointB2, results2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 pointA3;
				LuaObject.checkType(l, 1, out pointA3);
				Vector2 pointB3;
				LuaObject.checkType(l, 2, out pointB3);
				Collider2D[] results3;
				LuaObject.checkArray<Collider2D>(l, 3, out results3);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 5, out minDepth);
				int i3 = Physics2D.OverlapAreaNonAlloc(pointA3, pointB3, results3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 pointA4;
				LuaObject.checkType(l, 1, out pointA4);
				Vector2 pointB4;
				LuaObject.checkType(l, 2, out pointB4);
				Collider2D[] results4;
				LuaObject.checkArray<Collider2D>(l, 3, out results4);
				int layerMask3;
				LuaObject.checkType(l, 4, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 5, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 6, out maxDepth);
				int i4 = Physics2D.OverlapAreaNonAlloc(pointA4, pointB4, results4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapAreaNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602373E RID: 145214 RVA: 0x00C5F044 File Offset: 0x00C5D244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapCapsule_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				CapsuleDirection2D direction;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction);
				float angle;
				LuaObject.checkType(l, 4, out angle);
				Collider2D o = Physics2D.OverlapCapsule(point, size, direction, angle);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				CapsuleDirection2D direction2;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction2);
				float angle2;
				LuaObject.checkType(l, 4, out angle2);
				int layerMask;
				LuaObject.checkType(l, 5, out layerMask);
				Collider2D o2 = Physics2D.OverlapCapsule(point2, size2, direction2, angle2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(CapsuleDirection2D), typeof(float), typeof(ContactFilter2D), typeof(Collider2D[])))
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				CapsuleDirection2D direction3;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction3);
				float angle3;
				LuaObject.checkType(l, 4, out angle3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 5, out contactFilter);
				Collider2D[] results;
				LuaObject.checkArray<Collider2D>(l, 6, out results);
				int i = Physics2D.OverlapCapsule(point3, size3, direction3, angle3, contactFilter, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector2), typeof(Vector2), typeof(CapsuleDirection2D), typeof(float), typeof(int), typeof(float)))
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				CapsuleDirection2D direction4;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction4);
				float angle4;
				LuaObject.checkType(l, 4, out angle4);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 6, out minDepth);
				Collider2D o3 = Physics2D.OverlapCapsule(point4, size4, direction4, angle4, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 point5;
				LuaObject.checkType(l, 1, out point5);
				Vector2 size5;
				LuaObject.checkType(l, 2, out size5);
				CapsuleDirection2D direction5;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction5);
				float angle5;
				LuaObject.checkType(l, 4, out angle5);
				int layerMask3;
				LuaObject.checkType(l, 5, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 6, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 7, out maxDepth);
				Collider2D o4 = Physics2D.OverlapCapsule(point5, size5, direction5, angle5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapCapsule to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602373F RID: 145215 RVA: 0x00C5F32C File Offset: 0x00C5D52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapCapsuleAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				CapsuleDirection2D direction;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction);
				float angle;
				LuaObject.checkType(l, 4, out angle);
				Collider2D[] a = Physics2D.OverlapCapsuleAll(point, size, direction, angle);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 5)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				CapsuleDirection2D direction2;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction2);
				float angle2;
				LuaObject.checkType(l, 4, out angle2);
				int layerMask;
				LuaObject.checkType(l, 5, out layerMask);
				Collider2D[] a2 = Physics2D.OverlapCapsuleAll(point2, size2, direction2, angle2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				CapsuleDirection2D direction3;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction3);
				float angle3;
				LuaObject.checkType(l, 4, out angle3);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 6, out minDepth);
				Collider2D[] a3 = Physics2D.OverlapCapsuleAll(point3, size3, direction3, angle3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				CapsuleDirection2D direction4;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction4);
				float angle4;
				LuaObject.checkType(l, 4, out angle4);
				int layerMask3;
				LuaObject.checkType(l, 5, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 6, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 7, out maxDepth);
				Collider2D[] a4 = Physics2D.OverlapCapsuleAll(point4, size4, direction4, angle4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapCapsuleAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023740 RID: 145216 RVA: 0x00C5F524 File Offset: 0x00C5D724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OverlapCapsuleNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				Vector2 point;
				LuaObject.checkType(l, 1, out point);
				Vector2 size;
				LuaObject.checkType(l, 2, out size);
				CapsuleDirection2D direction;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction);
				float angle;
				LuaObject.checkType(l, 4, out angle);
				Collider2D[] results;
				LuaObject.checkArray<Collider2D>(l, 5, out results);
				int i = Physics2D.OverlapCapsuleNonAlloc(point, size, direction, angle, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 6)
			{
				Vector2 point2;
				LuaObject.checkType(l, 1, out point2);
				Vector2 size2;
				LuaObject.checkType(l, 2, out size2);
				CapsuleDirection2D direction2;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction2);
				float angle2;
				LuaObject.checkType(l, 4, out angle2);
				Collider2D[] results2;
				LuaObject.checkArray<Collider2D>(l, 5, out results2);
				int layerMask;
				LuaObject.checkType(l, 6, out layerMask);
				int i2 = Physics2D.OverlapCapsuleNonAlloc(point2, size2, direction2, angle2, results2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 7)
			{
				Vector2 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector2 size3;
				LuaObject.checkType(l, 2, out size3);
				CapsuleDirection2D direction3;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction3);
				float angle3;
				LuaObject.checkType(l, 4, out angle3);
				Collider2D[] results3;
				LuaObject.checkArray<Collider2D>(l, 5, out results3);
				int layerMask2;
				LuaObject.checkType(l, 6, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 7, out minDepth);
				int i3 = Physics2D.OverlapCapsuleNonAlloc(point3, size3, direction3, angle3, results3, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 8)
			{
				Vector2 point4;
				LuaObject.checkType(l, 1, out point4);
				Vector2 size4;
				LuaObject.checkType(l, 2, out size4);
				CapsuleDirection2D direction4;
				LuaObject.checkEnum<CapsuleDirection2D>(l, 3, out direction4);
				float angle4;
				LuaObject.checkType(l, 4, out angle4);
				Collider2D[] results4;
				LuaObject.checkArray<Collider2D>(l, 5, out results4);
				int layerMask3;
				LuaObject.checkType(l, 6, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 7, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 8, out maxDepth);
				int i4 = Physics2D.OverlapCapsuleNonAlloc(point4, size4, direction4, angle4, results4, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapCapsuleNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023741 RID: 145217 RVA: 0x00C5F74C File Offset: 0x00C5D94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapCollider_s(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider;
			LuaObject.checkType<Collider2D>(l, 1, out collider);
			ContactFilter2D contactFilter;
			LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter);
			Collider2D[] results;
			LuaObject.checkArray<Collider2D>(l, 3, out results);
			int i = Physics2D.OverlapCollider(collider, contactFilter, results);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023742 RID: 145218 RVA: 0x00C5F7BC File Offset: 0x00C5D9BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetContacts_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(Collider2D), typeof(Collider2D[])))
			{
				Collider2D collider;
				LuaObject.checkType<Collider2D>(l, 1, out collider);
				Collider2D[] colliders;
				LuaObject.checkArray<Collider2D>(l, 2, out colliders);
				int contacts = Physics2D.GetContacts(collider, colliders);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rigidbody2D), typeof(ContactPoint2D[])))
			{
				Rigidbody2D rigidbody;
				LuaObject.checkType<Rigidbody2D>(l, 1, out rigidbody);
				ContactPoint2D[] contacts2;
				LuaObject.checkArray<ContactPoint2D>(l, 2, out contacts2);
				int contacts3 = Physics2D.GetContacts(rigidbody, contacts2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rigidbody2D), typeof(Collider2D[])))
			{
				Rigidbody2D rigidbody2;
				LuaObject.checkType<Rigidbody2D>(l, 1, out rigidbody2);
				Collider2D[] colliders2;
				LuaObject.checkArray<Collider2D>(l, 2, out colliders2);
				int contacts4 = Physics2D.GetContacts(rigidbody2, colliders2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Collider2D), typeof(ContactPoint2D[])))
			{
				Collider2D collider2;
				LuaObject.checkType<Collider2D>(l, 1, out collider2);
				ContactPoint2D[] contacts5;
				LuaObject.checkArray<ContactPoint2D>(l, 2, out contacts5);
				int contacts6 = Physics2D.GetContacts(collider2, contacts5);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts6);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rigidbody2D), typeof(ContactFilter2D), typeof(Collider2D[])))
			{
				Rigidbody2D rigidbody3;
				LuaObject.checkType<Rigidbody2D>(l, 1, out rigidbody3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter);
				Collider2D[] colliders3;
				LuaObject.checkArray<Collider2D>(l, 3, out colliders3);
				int contacts7 = Physics2D.GetContacts(rigidbody3, contactFilter, colliders3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts7);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Rigidbody2D), typeof(ContactFilter2D), typeof(ContactPoint2D[])))
			{
				Rigidbody2D rigidbody4;
				LuaObject.checkType<Rigidbody2D>(l, 1, out rigidbody4);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter2);
				ContactPoint2D[] contacts8;
				LuaObject.checkArray<ContactPoint2D>(l, 3, out contacts8);
				int contacts9 = Physics2D.GetContacts(rigidbody4, contactFilter2, contacts8);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts9);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Collider2D), typeof(ContactFilter2D), typeof(ContactPoint2D[])))
			{
				Collider2D collider3;
				LuaObject.checkType<Collider2D>(l, 1, out collider3);
				ContactFilter2D contactFilter3;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter3);
				ContactPoint2D[] contacts10;
				LuaObject.checkArray<ContactPoint2D>(l, 3, out contacts10);
				int contacts11 = Physics2D.GetContacts(collider3, contactFilter3, contacts10);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts11);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Collider2D), typeof(ContactFilter2D), typeof(Collider2D[])))
			{
				Collider2D collider4;
				LuaObject.checkType<Collider2D>(l, 1, out collider4);
				ContactFilter2D contactFilter4;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter4);
				Collider2D[] colliders4;
				LuaObject.checkArray<Collider2D>(l, 3, out colliders4);
				int contacts12 = Physics2D.GetContacts(collider4, contactFilter4, colliders4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts12);
				result = 2;
			}
			else if (num == 4)
			{
				Collider2D collider5;
				LuaObject.checkType<Collider2D>(l, 1, out collider5);
				Collider2D collider6;
				LuaObject.checkType<Collider2D>(l, 2, out collider6);
				ContactFilter2D contactFilter5;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter5);
				ContactPoint2D[] contacts13;
				LuaObject.checkArray<ContactPoint2D>(l, 4, out contacts13);
				int contacts14 = Physics2D.GetContacts(collider5, collider6, contactFilter5, contacts13);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts14);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetContacts to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023743 RID: 145219 RVA: 0x00C5FB7C File Offset: 0x00C5DD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Simulate_s(IntPtr l)
	{
		int result;
		try
		{
			float step;
			LuaObject.checkType(l, 1, out step);
			bool b = Physics2D.Simulate(step);
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

	// Token: 0x06023744 RID: 145220 RVA: 0x00C5FBD0 File Offset: 0x00C5DDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SyncTransforms_s(IntPtr l)
	{
		int result;
		try
		{
			Physics2D.SyncTransforms();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023745 RID: 145221 RVA: 0x00C5FC10 File Offset: 0x00C5DE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IgnoreCollision_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Collider2D collider;
				LuaObject.checkType<Collider2D>(l, 1, out collider);
				Collider2D collider2;
				LuaObject.checkType<Collider2D>(l, 2, out collider2);
				Physics2D.IgnoreCollision(collider, collider2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Collider2D collider3;
				LuaObject.checkType<Collider2D>(l, 1, out collider3);
				Collider2D collider4;
				LuaObject.checkType<Collider2D>(l, 2, out collider4);
				bool ignore;
				LuaObject.checkType(l, 3, out ignore);
				Physics2D.IgnoreCollision(collider3, collider4, ignore);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IgnoreCollision to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023746 RID: 145222 RVA: 0x00C5FCCC File Offset: 0x00C5DECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIgnoreCollision_s(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider;
			LuaObject.checkType<Collider2D>(l, 1, out collider);
			Collider2D collider2;
			LuaObject.checkType<Collider2D>(l, 2, out collider2);
			bool ignoreCollision = Physics2D.GetIgnoreCollision(collider, collider2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ignoreCollision);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023747 RID: 145223 RVA: 0x00C5FD2C File Offset: 0x00C5DF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IgnoreLayerCollision_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				int layer;
				LuaObject.checkType(l, 1, out layer);
				int layer2;
				LuaObject.checkType(l, 2, out layer2);
				Physics2D.IgnoreLayerCollision(layer, layer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				int layer3;
				LuaObject.checkType(l, 1, out layer3);
				int layer4;
				LuaObject.checkType(l, 2, out layer4);
				bool ignore;
				LuaObject.checkType(l, 3, out ignore);
				Physics2D.IgnoreLayerCollision(layer3, layer4, ignore);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IgnoreLayerCollision to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023748 RID: 145224 RVA: 0x00C5FDE8 File Offset: 0x00C5DFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIgnoreLayerCollision_s(IntPtr l)
	{
		int result;
		try
		{
			int layer;
			LuaObject.checkType(l, 1, out layer);
			int layer2;
			LuaObject.checkType(l, 2, out layer2);
			bool ignoreLayerCollision = Physics2D.GetIgnoreLayerCollision(layer, layer2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ignoreLayerCollision);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023749 RID: 145225 RVA: 0x00C5FE48 File Offset: 0x00C5E048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayerCollisionMask_s(IntPtr l)
	{
		int result;
		try
		{
			int layer;
			LuaObject.checkType(l, 1, out layer);
			int layerMask;
			LuaObject.checkType(l, 2, out layerMask);
			Physics2D.SetLayerCollisionMask(layer, layerMask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602374A RID: 145226 RVA: 0x00C5FEA0 File Offset: 0x00C5E0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerCollisionMask_s(IntPtr l)
	{
		int result;
		try
		{
			int layer;
			LuaObject.checkType(l, 1, out layer);
			int layerCollisionMask = Physics2D.GetLayerCollisionMask(layer);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerCollisionMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602374B RID: 145227 RVA: 0x00C5FEF4 File Offset: 0x00C5E0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTouching_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(Collider2D), typeof(ContactFilter2D)))
			{
				Collider2D collider;
				LuaObject.checkType<Collider2D>(l, 1, out collider);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter);
				bool b = Physics2D.IsTouching(collider, contactFilter);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Collider2D), typeof(Collider2D)))
			{
				Collider2D collider2;
				LuaObject.checkType<Collider2D>(l, 1, out collider2);
				Collider2D collider3;
				LuaObject.checkType<Collider2D>(l, 2, out collider3);
				bool b2 = Physics2D.IsTouching(collider2, collider3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (num == 3)
			{
				Collider2D collider4;
				LuaObject.checkType<Collider2D>(l, 1, out collider4);
				Collider2D collider5;
				LuaObject.checkType<Collider2D>(l, 2, out collider5);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter2);
				bool b3 = Physics2D.IsTouching(collider4, collider5, contactFilter2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsTouching to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602374C RID: 145228 RVA: 0x00C60044 File Offset: 0x00C5E244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTouchingLayers_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Collider2D collider;
				LuaObject.checkType<Collider2D>(l, 1, out collider);
				bool b = Physics2D.IsTouchingLayers(collider);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				Collider2D collider2;
				LuaObject.checkType<Collider2D>(l, 1, out collider2);
				int layerMask;
				LuaObject.checkType(l, 2, out layerMask);
				bool b2 = Physics2D.IsTouchingLayers(collider2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsTouchingLayers to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602374D RID: 145229 RVA: 0x00C600FC File Offset: 0x00C5E2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Distance_s(IntPtr l)
	{
		int result;
		try
		{
			Collider2D colliderA;
			LuaObject.checkType<Collider2D>(l, 1, out colliderA);
			Collider2D colliderB;
			LuaObject.checkType<Collider2D>(l, 2, out colliderB);
			ColliderDistance2D colliderDistance2D = Physics2D.Distance(colliderA, colliderB);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, colliderDistance2D);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602374E RID: 145230 RVA: 0x00C60160 File Offset: 0x00C5E360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IgnoreRaycastLayer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602374F RID: 145231 RVA: 0x00C601A4 File Offset: 0x00C5E3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefaultRaycastLayers(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023750 RID: 145232 RVA: 0x00C601E8 File Offset: 0x00C5E3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AllLayers(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023751 RID: 145233 RVA: 0x00C6022C File Offset: 0x00C5E42C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_velocityIterations(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.velocityIterations);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023752 RID: 145234 RVA: 0x00C60274 File Offset: 0x00C5E474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_velocityIterations(IntPtr l)
	{
		int result;
		try
		{
			int velocityIterations;
			LuaObject.checkType(l, 2, out velocityIterations);
			Physics2D.velocityIterations = velocityIterations;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023753 RID: 145235 RVA: 0x00C602C0 File Offset: 0x00C5E4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_positionIterations(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.positionIterations);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023754 RID: 145236 RVA: 0x00C60308 File Offset: 0x00C5E508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_positionIterations(IntPtr l)
	{
		int result;
		try
		{
			int positionIterations;
			LuaObject.checkType(l, 2, out positionIterations);
			Physics2D.positionIterations = positionIterations;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023755 RID: 145237 RVA: 0x00C60354 File Offset: 0x00C5E554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gravity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.gravity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023756 RID: 145238 RVA: 0x00C6039C File Offset: 0x00C5E59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_gravity(IntPtr l)
	{
		int result;
		try
		{
			Vector2 gravity;
			LuaObject.checkType(l, 2, out gravity);
			Physics2D.gravity = gravity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023757 RID: 145239 RVA: 0x00C603E8 File Offset: 0x00C5E5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_queriesHitTriggers(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.queriesHitTriggers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023758 RID: 145240 RVA: 0x00C60430 File Offset: 0x00C5E630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_queriesHitTriggers(IntPtr l)
	{
		int result;
		try
		{
			bool queriesHitTriggers;
			LuaObject.checkType(l, 2, out queriesHitTriggers);
			Physics2D.queriesHitTriggers = queriesHitTriggers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023759 RID: 145241 RVA: 0x00C6047C File Offset: 0x00C5E67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_queriesStartInColliders(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.queriesStartInColliders);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602375A RID: 145242 RVA: 0x00C604C4 File Offset: 0x00C5E6C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_queriesStartInColliders(IntPtr l)
	{
		int result;
		try
		{
			bool queriesStartInColliders;
			LuaObject.checkType(l, 2, out queriesStartInColliders);
			Physics2D.queriesStartInColliders = queriesStartInColliders;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602375B RID: 145243 RVA: 0x00C60510 File Offset: 0x00C5E710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_changeStopsCallbacks(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.changeStopsCallbacks);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602375C RID: 145244 RVA: 0x00C60558 File Offset: 0x00C5E758
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_changeStopsCallbacks(IntPtr l)
	{
		int result;
		try
		{
			bool changeStopsCallbacks;
			LuaObject.checkType(l, 2, out changeStopsCallbacks);
			Physics2D.changeStopsCallbacks = changeStopsCallbacks;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602375D RID: 145245 RVA: 0x00C605A4 File Offset: 0x00C5E7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_callbacksOnDisable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.callbacksOnDisable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602375E RID: 145246 RVA: 0x00C605EC File Offset: 0x00C5E7EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_callbacksOnDisable(IntPtr l)
	{
		int result;
		try
		{
			bool callbacksOnDisable;
			LuaObject.checkType(l, 2, out callbacksOnDisable);
			Physics2D.callbacksOnDisable = callbacksOnDisable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602375F RID: 145247 RVA: 0x00C60638 File Offset: 0x00C5E838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoSyncTransforms(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.autoSyncTransforms);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023760 RID: 145248 RVA: 0x00C60680 File Offset: 0x00C5E880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoSyncTransforms(IntPtr l)
	{
		int result;
		try
		{
			bool autoSyncTransforms;
			LuaObject.checkType(l, 2, out autoSyncTransforms);
			Physics2D.autoSyncTransforms = autoSyncTransforms;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023761 RID: 145249 RVA: 0x00C606CC File Offset: 0x00C5E8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoSimulation(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.autoSimulation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023762 RID: 145250 RVA: 0x00C60714 File Offset: 0x00C5E914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoSimulation(IntPtr l)
	{
		int result;
		try
		{
			bool autoSimulation;
			LuaObject.checkType(l, 2, out autoSimulation);
			Physics2D.autoSimulation = autoSimulation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023763 RID: 145251 RVA: 0x00C60760 File Offset: 0x00C5E960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_velocityThreshold(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.velocityThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023764 RID: 145252 RVA: 0x00C607A8 File Offset: 0x00C5E9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_velocityThreshold(IntPtr l)
	{
		int result;
		try
		{
			float velocityThreshold;
			LuaObject.checkType(l, 2, out velocityThreshold);
			Physics2D.velocityThreshold = velocityThreshold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023765 RID: 145253 RVA: 0x00C607F4 File Offset: 0x00C5E9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxLinearCorrection(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.maxLinearCorrection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023766 RID: 145254 RVA: 0x00C6083C File Offset: 0x00C5EA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxLinearCorrection(IntPtr l)
	{
		int result;
		try
		{
			float maxLinearCorrection;
			LuaObject.checkType(l, 2, out maxLinearCorrection);
			Physics2D.maxLinearCorrection = maxLinearCorrection;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023767 RID: 145255 RVA: 0x00C60888 File Offset: 0x00C5EA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxAngularCorrection(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.maxAngularCorrection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023768 RID: 145256 RVA: 0x00C608D0 File Offset: 0x00C5EAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxAngularCorrection(IntPtr l)
	{
		int result;
		try
		{
			float maxAngularCorrection;
			LuaObject.checkType(l, 2, out maxAngularCorrection);
			Physics2D.maxAngularCorrection = maxAngularCorrection;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023769 RID: 145257 RVA: 0x00C6091C File Offset: 0x00C5EB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxTranslationSpeed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.maxTranslationSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602376A RID: 145258 RVA: 0x00C60964 File Offset: 0x00C5EB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxTranslationSpeed(IntPtr l)
	{
		int result;
		try
		{
			float maxTranslationSpeed;
			LuaObject.checkType(l, 2, out maxTranslationSpeed);
			Physics2D.maxTranslationSpeed = maxTranslationSpeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602376B RID: 145259 RVA: 0x00C609B0 File Offset: 0x00C5EBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxRotationSpeed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.maxRotationSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602376C RID: 145260 RVA: 0x00C609F8 File Offset: 0x00C5EBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxRotationSpeed(IntPtr l)
	{
		int result;
		try
		{
			float maxRotationSpeed;
			LuaObject.checkType(l, 2, out maxRotationSpeed);
			Physics2D.maxRotationSpeed = maxRotationSpeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602376D RID: 145261 RVA: 0x00C60A44 File Offset: 0x00C5EC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultContactOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.defaultContactOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602376E RID: 145262 RVA: 0x00C60A8C File Offset: 0x00C5EC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_defaultContactOffset(IntPtr l)
	{
		int result;
		try
		{
			float defaultContactOffset;
			LuaObject.checkType(l, 2, out defaultContactOffset);
			Physics2D.defaultContactOffset = defaultContactOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602376F RID: 145263 RVA: 0x00C60AD8 File Offset: 0x00C5ECD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_baumgarteScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.baumgarteScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023770 RID: 145264 RVA: 0x00C60B20 File Offset: 0x00C5ED20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_baumgarteScale(IntPtr l)
	{
		int result;
		try
		{
			float baumgarteScale;
			LuaObject.checkType(l, 2, out baumgarteScale);
			Physics2D.baumgarteScale = baumgarteScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023771 RID: 145265 RVA: 0x00C60B6C File Offset: 0x00C5ED6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_baumgarteTOIScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.baumgarteTOIScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023772 RID: 145266 RVA: 0x00C60BB4 File Offset: 0x00C5EDB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_baumgarteTOIScale(IntPtr l)
	{
		int result;
		try
		{
			float baumgarteTOIScale;
			LuaObject.checkType(l, 2, out baumgarteTOIScale);
			Physics2D.baumgarteTOIScale = baumgarteTOIScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023773 RID: 145267 RVA: 0x00C60C00 File Offset: 0x00C5EE00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_timeToSleep(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.timeToSleep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023774 RID: 145268 RVA: 0x00C60C48 File Offset: 0x00C5EE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_timeToSleep(IntPtr l)
	{
		int result;
		try
		{
			float timeToSleep;
			LuaObject.checkType(l, 2, out timeToSleep);
			Physics2D.timeToSleep = timeToSleep;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023775 RID: 145269 RVA: 0x00C60C94 File Offset: 0x00C5EE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_linearSleepTolerance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.linearSleepTolerance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023776 RID: 145270 RVA: 0x00C60CDC File Offset: 0x00C5EEDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_linearSleepTolerance(IntPtr l)
	{
		int result;
		try
		{
			float linearSleepTolerance;
			LuaObject.checkType(l, 2, out linearSleepTolerance);
			Physics2D.linearSleepTolerance = linearSleepTolerance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023777 RID: 145271 RVA: 0x00C60D28 File Offset: 0x00C5EF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularSleepTolerance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.angularSleepTolerance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023778 RID: 145272 RVA: 0x00C60D70 File Offset: 0x00C5EF70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_angularSleepTolerance(IntPtr l)
	{
		int result;
		try
		{
			float angularSleepTolerance;
			LuaObject.checkType(l, 2, out angularSleepTolerance);
			Physics2D.angularSleepTolerance = angularSleepTolerance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023779 RID: 145273 RVA: 0x00C60DBC File Offset: 0x00C5EFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alwaysShowColliders(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.alwaysShowColliders);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602377A RID: 145274 RVA: 0x00C60E04 File Offset: 0x00C5F004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_alwaysShowColliders(IntPtr l)
	{
		int result;
		try
		{
			bool alwaysShowColliders;
			LuaObject.checkType(l, 2, out alwaysShowColliders);
			Physics2D.alwaysShowColliders = alwaysShowColliders;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602377B RID: 145275 RVA: 0x00C60E50 File Offset: 0x00C5F050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_showColliderSleep(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.showColliderSleep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602377C RID: 145276 RVA: 0x00C60E98 File Offset: 0x00C5F098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_showColliderSleep(IntPtr l)
	{
		int result;
		try
		{
			bool showColliderSleep;
			LuaObject.checkType(l, 2, out showColliderSleep);
			Physics2D.showColliderSleep = showColliderSleep;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602377D RID: 145277 RVA: 0x00C60EE4 File Offset: 0x00C5F0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_showColliderContacts(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.showColliderContacts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602377E RID: 145278 RVA: 0x00C60F2C File Offset: 0x00C5F12C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_showColliderContacts(IntPtr l)
	{
		int result;
		try
		{
			bool showColliderContacts;
			LuaObject.checkType(l, 2, out showColliderContacts);
			Physics2D.showColliderContacts = showColliderContacts;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602377F RID: 145279 RVA: 0x00C60F78 File Offset: 0x00C5F178
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_showColliderAABB(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.showColliderAABB);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023780 RID: 145280 RVA: 0x00C60FC0 File Offset: 0x00C5F1C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_showColliderAABB(IntPtr l)
	{
		int result;
		try
		{
			bool showColliderAABB;
			LuaObject.checkType(l, 2, out showColliderAABB);
			Physics2D.showColliderAABB = showColliderAABB;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023781 RID: 145281 RVA: 0x00C6100C File Offset: 0x00C5F20C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_contactArrowScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.contactArrowScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023782 RID: 145282 RVA: 0x00C61054 File Offset: 0x00C5F254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_contactArrowScale(IntPtr l)
	{
		int result;
		try
		{
			float contactArrowScale;
			LuaObject.checkType(l, 2, out contactArrowScale);
			Physics2D.contactArrowScale = contactArrowScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023783 RID: 145283 RVA: 0x00C610A0 File Offset: 0x00C5F2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colliderAwakeColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.colliderAwakeColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023784 RID: 145284 RVA: 0x00C610E8 File Offset: 0x00C5F2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colliderAwakeColor(IntPtr l)
	{
		int result;
		try
		{
			Color colliderAwakeColor;
			LuaObject.checkType(l, 2, out colliderAwakeColor);
			Physics2D.colliderAwakeColor = colliderAwakeColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023785 RID: 145285 RVA: 0x00C61134 File Offset: 0x00C5F334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colliderAsleepColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.colliderAsleepColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023786 RID: 145286 RVA: 0x00C6117C File Offset: 0x00C5F37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colliderAsleepColor(IntPtr l)
	{
		int result;
		try
		{
			Color colliderAsleepColor;
			LuaObject.checkType(l, 2, out colliderAsleepColor);
			Physics2D.colliderAsleepColor = colliderAsleepColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023787 RID: 145287 RVA: 0x00C611C8 File Offset: 0x00C5F3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colliderContactColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.colliderContactColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023788 RID: 145288 RVA: 0x00C61210 File Offset: 0x00C5F410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colliderContactColor(IntPtr l)
	{
		int result;
		try
		{
			Color colliderContactColor;
			LuaObject.checkType(l, 2, out colliderContactColor);
			Physics2D.colliderContactColor = colliderContactColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023789 RID: 145289 RVA: 0x00C6125C File Offset: 0x00C5F45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colliderAABBColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics2D.colliderAABBColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602378A RID: 145290 RVA: 0x00C612A4 File Offset: 0x00C5F4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colliderAABBColor(IntPtr l)
	{
		int result;
		try
		{
			Color colliderAABBColor;
			LuaObject.checkType(l, 2, out colliderAABBColor);
			Physics2D.colliderAABBColor = colliderAABBColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602378B RID: 145291 RVA: 0x00C612F0 File Offset: 0x00C5F4F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Physics2D");
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Physics2D.Linecast_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache0);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Physics2D.LinecastAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache1);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Physics2D.LinecastNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache2);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Physics2D.Raycast_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache3);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Physics2D.RaycastAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache4);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Physics2D.RaycastNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache5);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Physics2D.CircleCast_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache6);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Physics2D.CircleCastAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache7);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Physics2D.CircleCastNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache8);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Physics2D.BoxCast_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache9);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Physics2D.BoxCastAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cacheA);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Physics2D.BoxCastNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cacheB);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Physics2D.CapsuleCast_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cacheC);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Physics2D.CapsuleCastAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cacheD);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Physics2D.CapsuleCastNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cacheE);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Physics2D.GetRayIntersection_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cacheF);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Physics2D.GetRayIntersectionAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache10);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Physics2D.GetRayIntersectionNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache11);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapPoint_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache12);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapPointAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache13);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapPointNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache14);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapCircle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache15);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapCircleAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache16);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapCircleNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache17);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapBox_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache18);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapBoxAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache19);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapBoxNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache1A);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapArea_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache1B);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapAreaAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache1C);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapAreaNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache1D);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapCapsule_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache1E);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapCapsuleAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache1F);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapCapsuleNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache20);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Physics2D.OverlapCollider_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache21);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Physics2D.GetContacts_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache22);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Physics2D.Simulate_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache23);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Physics2D.SyncTransforms_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache24);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Physics2D.IgnoreCollision_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache25);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Physics2D.GetIgnoreCollision_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache26);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Physics2D.IgnoreLayerCollision_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache27);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Physics2D.GetIgnoreLayerCollision_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache28);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Physics2D.SetLayerCollisionMask_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache29);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Physics2D.GetLayerCollisionMask_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache2A);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Physics2D.IsTouching_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache2B);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Physics2D.IsTouchingLayers_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache2C);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Physics2D.Distance_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics2D.<>f__mg$cache2D);
		string name = "IgnoreRaycastLayer";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_IgnoreRaycastLayer);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Physics2D.<>f__mg$cache2E, null, false);
		string name2 = "DefaultRaycastLayers";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_DefaultRaycastLayers);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Physics2D.<>f__mg$cache2F, null, false);
		string name3 = "AllLayers";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_AllLayers);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Physics2D.<>f__mg$cache30, null, false);
		string name4 = "velocityIterations";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_velocityIterations);
		}
		LuaCSFunction get = Lua_UnityEngine_Physics2D.<>f__mg$cache31;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_velocityIterations);
		}
		LuaObject.addMember(l, name4, get, Lua_UnityEngine_Physics2D.<>f__mg$cache32, false);
		string name5 = "positionIterations";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_positionIterations);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Physics2D.<>f__mg$cache33;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_positionIterations);
		}
		LuaObject.addMember(l, name5, get2, Lua_UnityEngine_Physics2D.<>f__mg$cache34, false);
		string name6 = "gravity";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_gravity);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Physics2D.<>f__mg$cache35;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_gravity);
		}
		LuaObject.addMember(l, name6, get3, Lua_UnityEngine_Physics2D.<>f__mg$cache36, false);
		string name7 = "queriesHitTriggers";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_queriesHitTriggers);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Physics2D.<>f__mg$cache37;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_queriesHitTriggers);
		}
		LuaObject.addMember(l, name7, get4, Lua_UnityEngine_Physics2D.<>f__mg$cache38, false);
		string name8 = "queriesStartInColliders";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_queriesStartInColliders);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Physics2D.<>f__mg$cache39;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_queriesStartInColliders);
		}
		LuaObject.addMember(l, name8, get5, Lua_UnityEngine_Physics2D.<>f__mg$cache3A, false);
		string name9 = "changeStopsCallbacks";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_changeStopsCallbacks);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Physics2D.<>f__mg$cache3B;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache3C == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache3C = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_changeStopsCallbacks);
		}
		LuaObject.addMember(l, name9, get6, Lua_UnityEngine_Physics2D.<>f__mg$cache3C, false);
		string name10 = "callbacksOnDisable";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache3D == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache3D = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_callbacksOnDisable);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Physics2D.<>f__mg$cache3D;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache3E == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache3E = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_callbacksOnDisable);
		}
		LuaObject.addMember(l, name10, get7, Lua_UnityEngine_Physics2D.<>f__mg$cache3E, false);
		string name11 = "autoSyncTransforms";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache3F == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache3F = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_autoSyncTransforms);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Physics2D.<>f__mg$cache3F;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache40 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache40 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_autoSyncTransforms);
		}
		LuaObject.addMember(l, name11, get8, Lua_UnityEngine_Physics2D.<>f__mg$cache40, false);
		string name12 = "autoSimulation";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache41 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache41 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_autoSimulation);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Physics2D.<>f__mg$cache41;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache42 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache42 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_autoSimulation);
		}
		LuaObject.addMember(l, name12, get9, Lua_UnityEngine_Physics2D.<>f__mg$cache42, false);
		string name13 = "velocityThreshold";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache43 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache43 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_velocityThreshold);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Physics2D.<>f__mg$cache43;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache44 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache44 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_velocityThreshold);
		}
		LuaObject.addMember(l, name13, get10, Lua_UnityEngine_Physics2D.<>f__mg$cache44, false);
		string name14 = "maxLinearCorrection";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache45 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache45 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_maxLinearCorrection);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Physics2D.<>f__mg$cache45;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache46 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache46 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_maxLinearCorrection);
		}
		LuaObject.addMember(l, name14, get11, Lua_UnityEngine_Physics2D.<>f__mg$cache46, false);
		string name15 = "maxAngularCorrection";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache47 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache47 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_maxAngularCorrection);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Physics2D.<>f__mg$cache47;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache48 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache48 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_maxAngularCorrection);
		}
		LuaObject.addMember(l, name15, get12, Lua_UnityEngine_Physics2D.<>f__mg$cache48, false);
		string name16 = "maxTranslationSpeed";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache49 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache49 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_maxTranslationSpeed);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Physics2D.<>f__mg$cache49;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache4A == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache4A = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_maxTranslationSpeed);
		}
		LuaObject.addMember(l, name16, get13, Lua_UnityEngine_Physics2D.<>f__mg$cache4A, false);
		string name17 = "maxRotationSpeed";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache4B == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache4B = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_maxRotationSpeed);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Physics2D.<>f__mg$cache4B;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache4C == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache4C = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_maxRotationSpeed);
		}
		LuaObject.addMember(l, name17, get14, Lua_UnityEngine_Physics2D.<>f__mg$cache4C, false);
		string name18 = "defaultContactOffset";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache4D == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache4D = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_defaultContactOffset);
		}
		LuaCSFunction get15 = Lua_UnityEngine_Physics2D.<>f__mg$cache4D;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache4E == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache4E = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_defaultContactOffset);
		}
		LuaObject.addMember(l, name18, get15, Lua_UnityEngine_Physics2D.<>f__mg$cache4E, false);
		string name19 = "baumgarteScale";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache4F == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache4F = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_baumgarteScale);
		}
		LuaCSFunction get16 = Lua_UnityEngine_Physics2D.<>f__mg$cache4F;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache50 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache50 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_baumgarteScale);
		}
		LuaObject.addMember(l, name19, get16, Lua_UnityEngine_Physics2D.<>f__mg$cache50, false);
		string name20 = "baumgarteTOIScale";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache51 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache51 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_baumgarteTOIScale);
		}
		LuaCSFunction get17 = Lua_UnityEngine_Physics2D.<>f__mg$cache51;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache52 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache52 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_baumgarteTOIScale);
		}
		LuaObject.addMember(l, name20, get17, Lua_UnityEngine_Physics2D.<>f__mg$cache52, false);
		string name21 = "timeToSleep";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache53 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache53 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_timeToSleep);
		}
		LuaCSFunction get18 = Lua_UnityEngine_Physics2D.<>f__mg$cache53;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache54 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache54 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_timeToSleep);
		}
		LuaObject.addMember(l, name21, get18, Lua_UnityEngine_Physics2D.<>f__mg$cache54, false);
		string name22 = "linearSleepTolerance";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache55 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache55 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_linearSleepTolerance);
		}
		LuaCSFunction get19 = Lua_UnityEngine_Physics2D.<>f__mg$cache55;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache56 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache56 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_linearSleepTolerance);
		}
		LuaObject.addMember(l, name22, get19, Lua_UnityEngine_Physics2D.<>f__mg$cache56, false);
		string name23 = "angularSleepTolerance";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache57 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache57 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_angularSleepTolerance);
		}
		LuaCSFunction get20 = Lua_UnityEngine_Physics2D.<>f__mg$cache57;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache58 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache58 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_angularSleepTolerance);
		}
		LuaObject.addMember(l, name23, get20, Lua_UnityEngine_Physics2D.<>f__mg$cache58, false);
		string name24 = "alwaysShowColliders";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache59 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache59 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_alwaysShowColliders);
		}
		LuaCSFunction get21 = Lua_UnityEngine_Physics2D.<>f__mg$cache59;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache5A == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache5A = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_alwaysShowColliders);
		}
		LuaObject.addMember(l, name24, get21, Lua_UnityEngine_Physics2D.<>f__mg$cache5A, false);
		string name25 = "showColliderSleep";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache5B == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache5B = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_showColliderSleep);
		}
		LuaCSFunction get22 = Lua_UnityEngine_Physics2D.<>f__mg$cache5B;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache5C == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache5C = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_showColliderSleep);
		}
		LuaObject.addMember(l, name25, get22, Lua_UnityEngine_Physics2D.<>f__mg$cache5C, false);
		string name26 = "showColliderContacts";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache5D == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache5D = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_showColliderContacts);
		}
		LuaCSFunction get23 = Lua_UnityEngine_Physics2D.<>f__mg$cache5D;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache5E == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache5E = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_showColliderContacts);
		}
		LuaObject.addMember(l, name26, get23, Lua_UnityEngine_Physics2D.<>f__mg$cache5E, false);
		string name27 = "showColliderAABB";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache5F == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache5F = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_showColliderAABB);
		}
		LuaCSFunction get24 = Lua_UnityEngine_Physics2D.<>f__mg$cache5F;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache60 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache60 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_showColliderAABB);
		}
		LuaObject.addMember(l, name27, get24, Lua_UnityEngine_Physics2D.<>f__mg$cache60, false);
		string name28 = "contactArrowScale";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache61 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache61 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_contactArrowScale);
		}
		LuaCSFunction get25 = Lua_UnityEngine_Physics2D.<>f__mg$cache61;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache62 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache62 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_contactArrowScale);
		}
		LuaObject.addMember(l, name28, get25, Lua_UnityEngine_Physics2D.<>f__mg$cache62, false);
		string name29 = "colliderAwakeColor";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache63 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache63 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_colliderAwakeColor);
		}
		LuaCSFunction get26 = Lua_UnityEngine_Physics2D.<>f__mg$cache63;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache64 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache64 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_colliderAwakeColor);
		}
		LuaObject.addMember(l, name29, get26, Lua_UnityEngine_Physics2D.<>f__mg$cache64, false);
		string name30 = "colliderAsleepColor";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache65 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache65 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_colliderAsleepColor);
		}
		LuaCSFunction get27 = Lua_UnityEngine_Physics2D.<>f__mg$cache65;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache66 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache66 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_colliderAsleepColor);
		}
		LuaObject.addMember(l, name30, get27, Lua_UnityEngine_Physics2D.<>f__mg$cache66, false);
		string name31 = "colliderContactColor";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache67 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache67 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_colliderContactColor);
		}
		LuaCSFunction get28 = Lua_UnityEngine_Physics2D.<>f__mg$cache67;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache68 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache68 = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_colliderContactColor);
		}
		LuaObject.addMember(l, name31, get28, Lua_UnityEngine_Physics2D.<>f__mg$cache68, false);
		string name32 = "colliderAABBColor";
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache69 == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache69 = new LuaCSFunction(Lua_UnityEngine_Physics2D.get_colliderAABBColor);
		}
		LuaCSFunction get29 = Lua_UnityEngine_Physics2D.<>f__mg$cache69;
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache6A == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache6A = new LuaCSFunction(Lua_UnityEngine_Physics2D.set_colliderAABBColor);
		}
		LuaObject.addMember(l, name32, get29, Lua_UnityEngine_Physics2D.<>f__mg$cache6A, false);
		if (Lua_UnityEngine_Physics2D.<>f__mg$cache6B == null)
		{
			Lua_UnityEngine_Physics2D.<>f__mg$cache6B = new LuaCSFunction(Lua_UnityEngine_Physics2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Physics2D.<>f__mg$cache6B, typeof(Physics2D));
	}

	// Token: 0x04019509 RID: 103689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401950A RID: 103690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401950B RID: 103691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401950C RID: 103692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401950D RID: 103693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401950E RID: 103694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401950F RID: 103695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019510 RID: 103696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019511 RID: 103697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019512 RID: 103698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019513 RID: 103699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019514 RID: 103700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019515 RID: 103701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019516 RID: 103702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019517 RID: 103703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019518 RID: 103704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019519 RID: 103705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401951A RID: 103706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401951B RID: 103707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401951C RID: 103708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401951D RID: 103709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401951E RID: 103710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401951F RID: 103711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019520 RID: 103712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019521 RID: 103713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019522 RID: 103714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019523 RID: 103715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019524 RID: 103716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019525 RID: 103717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019526 RID: 103718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019527 RID: 103719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019528 RID: 103720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019529 RID: 103721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401952A RID: 103722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401952B RID: 103723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401952C RID: 103724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401952D RID: 103725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401952E RID: 103726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401952F RID: 103727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019530 RID: 103728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019531 RID: 103729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019532 RID: 103730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019533 RID: 103731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019534 RID: 103732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019535 RID: 103733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019536 RID: 103734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019537 RID: 103735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019538 RID: 103736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019539 RID: 103737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401953A RID: 103738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401953B RID: 103739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401953C RID: 103740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401953D RID: 103741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401953E RID: 103742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401953F RID: 103743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04019540 RID: 103744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019541 RID: 103745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04019542 RID: 103746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04019543 RID: 103747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04019544 RID: 103748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04019545 RID: 103749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04019546 RID: 103750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04019547 RID: 103751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04019548 RID: 103752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04019549 RID: 103753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401954A RID: 103754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401954B RID: 103755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401954C RID: 103756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401954D RID: 103757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401954E RID: 103758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401954F RID: 103759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04019550 RID: 103760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04019551 RID: 103761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04019552 RID: 103762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04019553 RID: 103763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04019554 RID: 103764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04019555 RID: 103765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04019556 RID: 103766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04019557 RID: 103767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04019558 RID: 103768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04019559 RID: 103769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401955A RID: 103770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0401955B RID: 103771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401955C RID: 103772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401955D RID: 103773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401955E RID: 103774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401955F RID: 103775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04019560 RID: 103776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04019561 RID: 103777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04019562 RID: 103778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04019563 RID: 103779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04019564 RID: 103780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04019565 RID: 103781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04019566 RID: 103782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04019567 RID: 103783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04019568 RID: 103784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04019569 RID: 103785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401956A RID: 103786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0401956B RID: 103787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401956C RID: 103788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0401956D RID: 103789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0401956E RID: 103790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0401956F RID: 103791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04019570 RID: 103792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04019571 RID: 103793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04019572 RID: 103794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04019573 RID: 103795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04019574 RID: 103796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;
}
