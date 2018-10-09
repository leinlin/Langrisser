using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001739 RID: 5945
[Preserve]
public class Lua_UnityEngine_Physics : LuaObject
{
	// Token: 0x060236E1 RID: 145121 RVA: 0x00C5544C File Offset: 0x00C5364C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Physics o = new Physics();
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

	// Token: 0x060236E2 RID: 145122 RVA: 0x00C55494 File Offset: 0x00C53694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Raycast_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Ray ray;
				LuaObject.checkValueType<Ray>(l, 1, out ray);
				bool b = Physics.Raycast(ray);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(LuaOut)))
			{
				Ray ray2;
				LuaObject.checkValueType<Ray>(l, 1, out ray2);
				RaycastHit r;
				bool b2 = Physics.Raycast(ray2, out r);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				LuaObject.pushValue(l, r);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3)))
			{
				Vector3 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector3 direction;
				LuaObject.checkType(l, 2, out direction);
				bool b3 = Physics.Raycast(origin, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float)))
			{
				Ray ray3;
				LuaObject.checkValueType<Ray>(l, 1, out ray3);
				float maxDistance;
				LuaObject.checkType(l, 2, out maxDistance);
				bool b4 = Physics.Raycast(ray3, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(int)))
			{
				Ray ray4;
				LuaObject.checkValueType<Ray>(l, 1, out ray4);
				float maxDistance2;
				LuaObject.checkType(l, 2, out maxDistance2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				bool b5 = Physics.Raycast(ray4, maxDistance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b5);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(LuaOut)))
			{
				Vector3 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector3 direction2;
				LuaObject.checkType(l, 2, out direction2);
				RaycastHit r2;
				bool b6 = Physics.Raycast(origin2, direction2, out r2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b6);
				LuaObject.pushValue(l, r2);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float)))
			{
				Vector3 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector3 direction3;
				LuaObject.checkType(l, 2, out direction3);
				float maxDistance3;
				LuaObject.checkType(l, 3, out maxDistance3);
				bool b7 = Physics.Raycast(origin3, direction3, maxDistance3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b7);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(LuaOut), typeof(float)))
			{
				Ray ray5;
				LuaObject.checkValueType<Ray>(l, 1, out ray5);
				float maxDistance4;
				LuaObject.checkType(l, 3, out maxDistance4);
				RaycastHit r3;
				bool b8 = Physics.Raycast(ray5, out r3, maxDistance4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b8);
				LuaObject.pushValue(l, r3);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Ray ray6;
				LuaObject.checkValueType<Ray>(l, 1, out ray6);
				float maxDistance5;
				LuaObject.checkType(l, 2, out maxDistance5);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 4, out queryTriggerInteraction);
				bool b9 = Physics.Raycast(ray6, maxDistance5, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b9);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float), typeof(int)))
			{
				Vector3 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector3 direction4;
				LuaObject.checkType(l, 2, out direction4);
				float maxDistance6;
				LuaObject.checkType(l, 3, out maxDistance6);
				int layerMask3;
				LuaObject.checkType(l, 4, out layerMask3);
				bool b10 = Physics.Raycast(origin4, direction4, maxDistance6, layerMask3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b10);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(LuaOut), typeof(float)))
			{
				Vector3 origin5;
				LuaObject.checkType(l, 1, out origin5);
				Vector3 direction5;
				LuaObject.checkType(l, 2, out direction5);
				float maxDistance7;
				LuaObject.checkType(l, 4, out maxDistance7);
				RaycastHit r4;
				bool b11 = Physics.Raycast(origin5, direction5, out r4, maxDistance7);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b11);
				LuaObject.pushValue(l, r4);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(LuaOut), typeof(float), typeof(int)))
			{
				Ray ray7;
				LuaObject.checkValueType<Ray>(l, 1, out ray7);
				float maxDistance8;
				LuaObject.checkType(l, 3, out maxDistance8);
				int layerMask4;
				LuaObject.checkType(l, 4, out layerMask4);
				RaycastHit r5;
				bool b12 = Physics.Raycast(ray7, out r5, maxDistance8, layerMask4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b12);
				LuaObject.pushValue(l, r5);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Vector3 origin6;
				LuaObject.checkType(l, 1, out origin6);
				Vector3 direction6;
				LuaObject.checkType(l, 2, out direction6);
				float maxDistance9;
				LuaObject.checkType(l, 3, out maxDistance9);
				int layerMask5;
				LuaObject.checkType(l, 4, out layerMask5);
				QueryTriggerInteraction queryTriggerInteraction2;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction2);
				bool b13 = Physics.Raycast(origin6, direction6, maxDistance9, layerMask5, queryTriggerInteraction2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b13);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(LuaOut), typeof(float), typeof(int)))
			{
				Vector3 origin7;
				LuaObject.checkType(l, 1, out origin7);
				Vector3 direction7;
				LuaObject.checkType(l, 2, out direction7);
				float maxDistance10;
				LuaObject.checkType(l, 4, out maxDistance10);
				int layerMask6;
				LuaObject.checkType(l, 5, out layerMask6);
				RaycastHit r6;
				bool b14 = Physics.Raycast(origin7, direction7, out r6, maxDistance10, layerMask6);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b14);
				LuaObject.pushValue(l, r6);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(LuaOut), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Ray ray8;
				LuaObject.checkValueType<Ray>(l, 1, out ray8);
				float maxDistance11;
				LuaObject.checkType(l, 3, out maxDistance11);
				int layerMask7;
				LuaObject.checkType(l, 4, out layerMask7);
				QueryTriggerInteraction queryTriggerInteraction3;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction3);
				RaycastHit r7;
				bool b15 = Physics.Raycast(ray8, out r7, maxDistance11, layerMask7, queryTriggerInteraction3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b15);
				LuaObject.pushValue(l, r7);
				result = 3;
			}
			else if (num == 6)
			{
				Vector3 origin8;
				LuaObject.checkType(l, 1, out origin8);
				Vector3 direction8;
				LuaObject.checkType(l, 2, out direction8);
				float maxDistance12;
				LuaObject.checkType(l, 4, out maxDistance12);
				int layerMask8;
				LuaObject.checkType(l, 5, out layerMask8);
				QueryTriggerInteraction queryTriggerInteraction4;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 6, out queryTriggerInteraction4);
				RaycastHit r8;
				bool b16 = Physics.Raycast(origin8, direction8, out r8, maxDistance12, layerMask8, queryTriggerInteraction4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b16);
				LuaObject.pushValue(l, r8);
				result = 3;
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

	// Token: 0x060236E3 RID: 145123 RVA: 0x00C55BFC File Offset: 0x00C53DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaycastAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(int)))
			{
				Ray ray;
				LuaObject.checkValueType<Ray>(l, 1, out ray);
				float maxDistance;
				LuaObject.checkType(l, 2, out maxDistance);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				RaycastHit[] a = Physics.RaycastAll(ray, maxDistance, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float)))
			{
				Ray ray2;
				LuaObject.checkValueType<Ray>(l, 1, out ray2);
				float maxDistance2;
				LuaObject.checkType(l, 2, out maxDistance2);
				RaycastHit[] a2 = Physics.RaycastAll(ray2, maxDistance2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 1)
			{
				Ray ray3;
				LuaObject.checkValueType<Ray>(l, 1, out ray3);
				RaycastHit[] a3 = Physics.RaycastAll(ray3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3)))
			{
				Vector3 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector3 direction;
				LuaObject.checkType(l, 2, out direction);
				RaycastHit[] a4 = Physics.RaycastAll(origin, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float)))
			{
				Vector3 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector3 direction2;
				LuaObject.checkType(l, 2, out direction2);
				float maxDistance3;
				LuaObject.checkType(l, 3, out maxDistance3);
				RaycastHit[] a5 = Physics.RaycastAll(origin2, direction2, maxDistance3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a5);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float), typeof(int)))
			{
				Vector3 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector3 direction3;
				LuaObject.checkType(l, 2, out direction3);
				float maxDistance4;
				LuaObject.checkType(l, 3, out maxDistance4);
				int layermask;
				LuaObject.checkType(l, 4, out layermask);
				RaycastHit[] a6 = Physics.RaycastAll(origin3, direction3, maxDistance4, layermask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a6);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Ray ray4;
				LuaObject.checkValueType<Ray>(l, 1, out ray4);
				float maxDistance5;
				LuaObject.checkType(l, 2, out maxDistance5);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 4, out queryTriggerInteraction);
				RaycastHit[] a7 = Physics.RaycastAll(ray4, maxDistance5, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a7);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector3 direction4;
				LuaObject.checkType(l, 2, out direction4);
				float maxDistance6;
				LuaObject.checkType(l, 3, out maxDistance6);
				int layermask2;
				LuaObject.checkType(l, 4, out layermask2);
				QueryTriggerInteraction queryTriggerInteraction2;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction2);
				RaycastHit[] a8 = Physics.RaycastAll(origin4, direction4, maxDistance6, layermask2, queryTriggerInteraction2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a8);
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

	// Token: 0x060236E4 RID: 145124 RVA: 0x00C55F78 File Offset: 0x00C54178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaycastNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Ray ray;
				LuaObject.checkValueType<Ray>(l, 1, out ray);
				RaycastHit[] results;
				LuaObject.checkArray<RaycastHit>(l, 2, out results);
				int i = Physics.RaycastNonAlloc(ray, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(RaycastHit[])))
			{
				Vector3 origin;
				LuaObject.checkType(l, 1, out origin);
				Vector3 direction;
				LuaObject.checkType(l, 2, out direction);
				RaycastHit[] results2;
				LuaObject.checkArray<RaycastHit>(l, 3, out results2);
				int i2 = Physics.RaycastNonAlloc(origin, direction, results2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(RaycastHit[]), typeof(float)))
			{
				Ray ray2;
				LuaObject.checkValueType<Ray>(l, 1, out ray2);
				RaycastHit[] results3;
				LuaObject.checkArray<RaycastHit>(l, 2, out results3);
				float maxDistance;
				LuaObject.checkType(l, 3, out maxDistance);
				int i3 = Physics.RaycastNonAlloc(ray2, results3, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(RaycastHit[]), typeof(float)))
			{
				Vector3 origin2;
				LuaObject.checkType(l, 1, out origin2);
				Vector3 direction2;
				LuaObject.checkType(l, 2, out direction2);
				RaycastHit[] results4;
				LuaObject.checkArray<RaycastHit>(l, 3, out results4);
				float maxDistance2;
				LuaObject.checkType(l, 4, out maxDistance2);
				int i4 = Physics.RaycastNonAlloc(origin2, direction2, results4, maxDistance2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(RaycastHit[]), typeof(float), typeof(int)))
			{
				Ray ray3;
				LuaObject.checkValueType<Ray>(l, 1, out ray3);
				RaycastHit[] results5;
				LuaObject.checkArray<RaycastHit>(l, 2, out results5);
				float maxDistance3;
				LuaObject.checkType(l, 3, out maxDistance3);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				int i5 = Physics.RaycastNonAlloc(ray3, results5, maxDistance3, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(RaycastHit[]), typeof(float), typeof(int)))
			{
				Vector3 origin3;
				LuaObject.checkType(l, 1, out origin3);
				Vector3 direction3;
				LuaObject.checkType(l, 2, out direction3);
				RaycastHit[] results6;
				LuaObject.checkArray<RaycastHit>(l, 3, out results6);
				float maxDistance4;
				LuaObject.checkType(l, 4, out maxDistance4);
				int layermask;
				LuaObject.checkType(l, 5, out layermask);
				int i6 = Physics.RaycastNonAlloc(origin3, direction3, results6, maxDistance4, layermask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i6);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(RaycastHit[]), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Ray ray4;
				LuaObject.checkValueType<Ray>(l, 1, out ray4);
				RaycastHit[] results7;
				LuaObject.checkArray<RaycastHit>(l, 2, out results7);
				float maxDistance5;
				LuaObject.checkType(l, 3, out maxDistance5);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction);
				int i7 = Physics.RaycastNonAlloc(ray4, results7, maxDistance5, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i7);
				result = 2;
			}
			else if (num == 6)
			{
				Vector3 origin4;
				LuaObject.checkType(l, 1, out origin4);
				Vector3 direction4;
				LuaObject.checkType(l, 2, out direction4);
				RaycastHit[] results8;
				LuaObject.checkArray<RaycastHit>(l, 3, out results8);
				float maxDistance6;
				LuaObject.checkType(l, 4, out maxDistance6);
				int layermask2;
				LuaObject.checkType(l, 5, out layermask2);
				QueryTriggerInteraction queryTriggerInteraction2;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 6, out queryTriggerInteraction2);
				int i8 = Physics.RaycastNonAlloc(origin4, direction4, results8, maxDistance6, layermask2, queryTriggerInteraction2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i8);
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

	// Token: 0x060236E5 RID: 145125 RVA: 0x00C56390 File Offset: 0x00C54590
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
				Vector3 start;
				LuaObject.checkType(l, 1, out start);
				Vector3 end;
				LuaObject.checkType(l, 2, out end);
				bool b = Physics.Linecast(start, end);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(LuaOut)))
			{
				Vector3 start2;
				LuaObject.checkType(l, 1, out start2);
				Vector3 end2;
				LuaObject.checkType(l, 2, out end2);
				RaycastHit r;
				bool b2 = Physics.Linecast(start2, end2, out r);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				LuaObject.pushValue(l, r);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(int)))
			{
				Vector3 start3;
				LuaObject.checkType(l, 1, out start3);
				Vector3 end3;
				LuaObject.checkType(l, 2, out end3);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				bool b3 = Physics.Linecast(start3, end3, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(LuaOut), typeof(int)))
			{
				Vector3 start4;
				LuaObject.checkType(l, 1, out start4);
				Vector3 end4;
				LuaObject.checkType(l, 2, out end4);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				RaycastHit r2;
				bool b4 = Physics.Linecast(start4, end4, out r2, layerMask2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b4);
				LuaObject.pushValue(l, r2);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Vector3 start5;
				LuaObject.checkType(l, 1, out start5);
				Vector3 end5;
				LuaObject.checkType(l, 2, out end5);
				int layerMask3;
				LuaObject.checkType(l, 3, out layerMask3);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 4, out queryTriggerInteraction);
				bool b5 = Physics.Linecast(start5, end5, layerMask3, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b5);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 start6;
				LuaObject.checkType(l, 1, out start6);
				Vector3 end6;
				LuaObject.checkType(l, 2, out end6);
				int layerMask4;
				LuaObject.checkType(l, 4, out layerMask4);
				QueryTriggerInteraction queryTriggerInteraction2;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction2);
				RaycastHit r3;
				bool b6 = Physics.Linecast(start6, end6, out r3, layerMask4, queryTriggerInteraction2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b6);
				LuaObject.pushValue(l, r3);
				result = 3;
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

	// Token: 0x060236E6 RID: 145126 RVA: 0x00C56664 File Offset: 0x00C54864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapSphere_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector3 position;
				LuaObject.checkType(l, 1, out position);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				Collider[] a = Physics.OverlapSphere(position, radius);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 3)
			{
				Vector3 position2;
				LuaObject.checkType(l, 1, out position2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				Collider[] a2 = Physics.OverlapSphere(position2, radius2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 4)
			{
				Vector3 position3;
				LuaObject.checkType(l, 1, out position3);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 4, out queryTriggerInteraction);
				Collider[] a3 = Physics.OverlapSphere(position3, radius3, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapSphere to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236E7 RID: 145127 RVA: 0x00C5678C File Offset: 0x00C5498C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OverlapSphereNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector3 position;
				LuaObject.checkType(l, 1, out position);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				Collider[] results;
				LuaObject.checkArray<Collider>(l, 3, out results);
				int i = Physics.OverlapSphereNonAlloc(position, radius, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				Vector3 position2;
				LuaObject.checkType(l, 1, out position2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				Collider[] results2;
				LuaObject.checkArray<Collider>(l, 3, out results2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				int i2 = Physics.OverlapSphereNonAlloc(position2, radius2, results2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 position3;
				LuaObject.checkType(l, 1, out position3);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				Collider[] results3;
				LuaObject.checkArray<Collider>(l, 3, out results3);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction);
				int i3 = Physics.OverlapSphereNonAlloc(position3, radius3, results3, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OverlapSphereNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236E8 RID: 145128 RVA: 0x00C568E8 File Offset: 0x00C54AE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OverlapCapsule_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector3 point;
				LuaObject.checkType(l, 1, out point);
				Vector3 point2;
				LuaObject.checkType(l, 2, out point2);
				float radius;
				LuaObject.checkType(l, 3, out radius);
				Collider[] a = Physics.OverlapCapsule(point, point2, radius);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 4)
			{
				Vector3 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector3 point4;
				LuaObject.checkType(l, 2, out point4);
				float radius2;
				LuaObject.checkType(l, 3, out radius2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				Collider[] a2 = Physics.OverlapCapsule(point3, point4, radius2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 point5;
				LuaObject.checkType(l, 1, out point5);
				Vector3 point6;
				LuaObject.checkType(l, 2, out point6);
				float radius3;
				LuaObject.checkType(l, 3, out radius3);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction);
				Collider[] a3 = Physics.OverlapCapsule(point5, point6, radius3, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
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

	// Token: 0x060236E9 RID: 145129 RVA: 0x00C56A44 File Offset: 0x00C54C44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OverlapCapsuleNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector3 point;
				LuaObject.checkType(l, 1, out point);
				Vector3 point2;
				LuaObject.checkType(l, 2, out point2);
				float radius;
				LuaObject.checkType(l, 3, out radius);
				Collider[] results;
				LuaObject.checkArray<Collider>(l, 4, out results);
				int i = Physics.OverlapCapsuleNonAlloc(point, point2, radius, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector3 point4;
				LuaObject.checkType(l, 2, out point4);
				float radius2;
				LuaObject.checkType(l, 3, out radius2);
				Collider[] results2;
				LuaObject.checkArray<Collider>(l, 4, out results2);
				int layerMask;
				LuaObject.checkType(l, 5, out layerMask);
				int i2 = Physics.OverlapCapsuleNonAlloc(point3, point4, radius2, results2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 6)
			{
				Vector3 point5;
				LuaObject.checkType(l, 1, out point5);
				Vector3 point6;
				LuaObject.checkType(l, 2, out point6);
				float radius3;
				LuaObject.checkType(l, 3, out radius3);
				Collider[] results3;
				LuaObject.checkArray<Collider>(l, 4, out results3);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 6, out queryTriggerInteraction);
				int i3 = Physics.OverlapCapsuleNonAlloc(point5, point6, radius3, results3, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
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

	// Token: 0x060236EA RID: 145130 RVA: 0x00C56BC4 File Offset: 0x00C54DC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CapsuleCast_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector3 point;
				LuaObject.checkType(l, 1, out point);
				Vector3 point2;
				LuaObject.checkType(l, 2, out point2);
				float radius;
				LuaObject.checkType(l, 3, out radius);
				Vector3 direction;
				LuaObject.checkType(l, 4, out direction);
				bool b = Physics.CapsuleCast(point, point2, radius, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float), typeof(Vector3), typeof(LuaOut)))
			{
				Vector3 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector3 point4;
				LuaObject.checkType(l, 2, out point4);
				float radius2;
				LuaObject.checkType(l, 3, out radius2);
				Vector3 direction2;
				LuaObject.checkType(l, 4, out direction2);
				RaycastHit r;
				bool b2 = Physics.CapsuleCast(point3, point4, radius2, direction2, out r);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				LuaObject.pushValue(l, r);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float), typeof(Vector3), typeof(float)))
			{
				Vector3 point5;
				LuaObject.checkType(l, 1, out point5);
				Vector3 point6;
				LuaObject.checkType(l, 2, out point6);
				float radius3;
				LuaObject.checkType(l, 3, out radius3);
				Vector3 direction3;
				LuaObject.checkType(l, 4, out direction3);
				float maxDistance;
				LuaObject.checkType(l, 5, out maxDistance);
				bool b3 = Physics.CapsuleCast(point5, point6, radius3, direction3, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float), typeof(Vector3), typeof(LuaOut), typeof(float)))
			{
				Vector3 point7;
				LuaObject.checkType(l, 1, out point7);
				Vector3 point8;
				LuaObject.checkType(l, 2, out point8);
				float radius4;
				LuaObject.checkType(l, 3, out radius4);
				Vector3 direction4;
				LuaObject.checkType(l, 4, out direction4);
				float maxDistance2;
				LuaObject.checkType(l, 6, out maxDistance2);
				RaycastHit r2;
				bool b4 = Physics.CapsuleCast(point7, point8, radius4, direction4, out r2, maxDistance2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b4);
				LuaObject.pushValue(l, r2);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float), typeof(Vector3), typeof(float), typeof(int)))
			{
				Vector3 point9;
				LuaObject.checkType(l, 1, out point9);
				Vector3 point10;
				LuaObject.checkType(l, 2, out point10);
				float radius5;
				LuaObject.checkType(l, 3, out radius5);
				Vector3 direction5;
				LuaObject.checkType(l, 4, out direction5);
				float maxDistance3;
				LuaObject.checkType(l, 5, out maxDistance3);
				int layerMask;
				LuaObject.checkType(l, 6, out layerMask);
				bool b5 = Physics.CapsuleCast(point9, point10, radius5, direction5, maxDistance3, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b5);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float), typeof(Vector3), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Vector3 point11;
				LuaObject.checkType(l, 1, out point11);
				Vector3 point12;
				LuaObject.checkType(l, 2, out point12);
				float radius6;
				LuaObject.checkType(l, 3, out radius6);
				Vector3 direction6;
				LuaObject.checkType(l, 4, out direction6);
				float maxDistance4;
				LuaObject.checkType(l, 5, out maxDistance4);
				int layerMask2;
				LuaObject.checkType(l, 6, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 7, out queryTriggerInteraction);
				bool b6 = Physics.CapsuleCast(point11, point12, radius6, direction6, maxDistance4, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b6);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(float), typeof(Vector3), typeof(LuaOut), typeof(float), typeof(int)))
			{
				Vector3 point13;
				LuaObject.checkType(l, 1, out point13);
				Vector3 point14;
				LuaObject.checkType(l, 2, out point14);
				float radius7;
				LuaObject.checkType(l, 3, out radius7);
				Vector3 direction7;
				LuaObject.checkType(l, 4, out direction7);
				float maxDistance5;
				LuaObject.checkType(l, 6, out maxDistance5);
				int layerMask3;
				LuaObject.checkType(l, 7, out layerMask3);
				RaycastHit r3;
				bool b7 = Physics.CapsuleCast(point13, point14, radius7, direction7, out r3, maxDistance5, layerMask3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b7);
				LuaObject.pushValue(l, r3);
				result = 3;
			}
			else if (num == 8)
			{
				Vector3 point15;
				LuaObject.checkType(l, 1, out point15);
				Vector3 point16;
				LuaObject.checkType(l, 2, out point16);
				float radius8;
				LuaObject.checkType(l, 3, out radius8);
				Vector3 direction8;
				LuaObject.checkType(l, 4, out direction8);
				float maxDistance6;
				LuaObject.checkType(l, 6, out maxDistance6);
				int layerMask4;
				LuaObject.checkType(l, 7, out layerMask4);
				QueryTriggerInteraction queryTriggerInteraction2;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 8, out queryTriggerInteraction2);
				RaycastHit r4;
				bool b8 = Physics.CapsuleCast(point15, point16, radius8, direction8, out r4, maxDistance6, layerMask4, queryTriggerInteraction2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b8);
				LuaObject.pushValue(l, r4);
				result = 3;
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

	// Token: 0x060236EB RID: 145131 RVA: 0x00C5710C File Offset: 0x00C5530C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SphereCast_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Ray ray;
				LuaObject.checkValueType<Ray>(l, 1, out ray);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				bool b = Physics.SphereCast(ray, radius);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(float)))
			{
				Ray ray2;
				LuaObject.checkValueType<Ray>(l, 1, out ray2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				float maxDistance;
				LuaObject.checkType(l, 3, out maxDistance);
				bool b2 = Physics.SphereCast(ray2, radius2, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(LuaOut)))
			{
				Ray ray3;
				LuaObject.checkValueType<Ray>(l, 1, out ray3);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				RaycastHit r;
				bool b3 = Physics.SphereCast(ray3, radius3, out r);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				LuaObject.pushValue(l, r);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(float), typeof(Vector3), typeof(LuaOut)))
			{
				Vector3 origin;
				LuaObject.checkType(l, 1, out origin);
				float radius4;
				LuaObject.checkType(l, 2, out radius4);
				Vector3 direction;
				LuaObject.checkType(l, 3, out direction);
				RaycastHit r2;
				bool b4 = Physics.SphereCast(origin, radius4, direction, out r2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b4);
				LuaObject.pushValue(l, r2);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(float), typeof(int)))
			{
				Ray ray4;
				LuaObject.checkValueType<Ray>(l, 1, out ray4);
				float radius5;
				LuaObject.checkType(l, 2, out radius5);
				float maxDistance2;
				LuaObject.checkType(l, 3, out maxDistance2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				bool b5 = Physics.SphereCast(ray4, radius5, maxDistance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b5);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(LuaOut), typeof(float)))
			{
				Ray ray5;
				LuaObject.checkValueType<Ray>(l, 1, out ray5);
				float radius6;
				LuaObject.checkType(l, 2, out radius6);
				float maxDistance3;
				LuaObject.checkType(l, 4, out maxDistance3);
				RaycastHit r3;
				bool b6 = Physics.SphereCast(ray5, radius6, out r3, maxDistance3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b6);
				LuaObject.pushValue(l, r3);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(LuaOut), typeof(float), typeof(int)))
			{
				Ray ray6;
				LuaObject.checkValueType<Ray>(l, 1, out ray6);
				float radius7;
				LuaObject.checkType(l, 2, out radius7);
				float maxDistance4;
				LuaObject.checkType(l, 4, out maxDistance4);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				RaycastHit r4;
				bool b7 = Physics.SphereCast(ray6, radius7, out r4, maxDistance4, layerMask2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b7);
				LuaObject.pushValue(l, r4);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Ray ray7;
				LuaObject.checkValueType<Ray>(l, 1, out ray7);
				float radius8;
				LuaObject.checkType(l, 2, out radius8);
				float maxDistance5;
				LuaObject.checkType(l, 3, out maxDistance5);
				int layerMask3;
				LuaObject.checkType(l, 4, out layerMask3);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction);
				bool b8 = Physics.SphereCast(ray7, radius8, maxDistance5, layerMask3, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b8);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(float), typeof(Vector3), typeof(LuaOut), typeof(float)))
			{
				Vector3 origin2;
				LuaObject.checkType(l, 1, out origin2);
				float radius9;
				LuaObject.checkType(l, 2, out radius9);
				Vector3 direction2;
				LuaObject.checkType(l, 3, out direction2);
				float maxDistance6;
				LuaObject.checkType(l, 5, out maxDistance6);
				RaycastHit r5;
				bool b9 = Physics.SphereCast(origin2, radius9, direction2, out r5, maxDistance6);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b9);
				LuaObject.pushValue(l, r5);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(float), typeof(Vector3), typeof(LuaOut), typeof(float), typeof(int)))
			{
				Vector3 origin3;
				LuaObject.checkType(l, 1, out origin3);
				float radius10;
				LuaObject.checkType(l, 2, out radius10);
				Vector3 direction3;
				LuaObject.checkType(l, 3, out direction3);
				float maxDistance7;
				LuaObject.checkType(l, 5, out maxDistance7);
				int layerMask4;
				LuaObject.checkType(l, 6, out layerMask4);
				RaycastHit r6;
				bool b10 = Physics.SphereCast(origin3, radius10, direction3, out r6, maxDistance7, layerMask4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b10);
				LuaObject.pushValue(l, r6);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(LuaOut), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Ray ray8;
				LuaObject.checkValueType<Ray>(l, 1, out ray8);
				float radius11;
				LuaObject.checkType(l, 2, out radius11);
				float maxDistance8;
				LuaObject.checkType(l, 4, out maxDistance8);
				int layerMask5;
				LuaObject.checkType(l, 5, out layerMask5);
				QueryTriggerInteraction queryTriggerInteraction2;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 6, out queryTriggerInteraction2);
				RaycastHit r7;
				bool b11 = Physics.SphereCast(ray8, radius11, out r7, maxDistance8, layerMask5, queryTriggerInteraction2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b11);
				LuaObject.pushValue(l, r7);
				result = 3;
			}
			else if (num == 7)
			{
				Vector3 origin4;
				LuaObject.checkType(l, 1, out origin4);
				float radius12;
				LuaObject.checkType(l, 2, out radius12);
				Vector3 direction4;
				LuaObject.checkType(l, 3, out direction4);
				float maxDistance9;
				LuaObject.checkType(l, 5, out maxDistance9);
				int layerMask6;
				LuaObject.checkType(l, 6, out layerMask6);
				QueryTriggerInteraction queryTriggerInteraction3;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 7, out queryTriggerInteraction3);
				RaycastHit r8;
				bool b12 = Physics.SphereCast(origin4, radius12, direction4, out r8, maxDistance9, layerMask6, queryTriggerInteraction3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b12);
				LuaObject.pushValue(l, r8);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SphereCast to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236EC RID: 145132 RVA: 0x00C57798 File Offset: 0x00C55998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CapsuleCastAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector3 point;
				LuaObject.checkType(l, 1, out point);
				Vector3 point2;
				LuaObject.checkType(l, 2, out point2);
				float radius;
				LuaObject.checkType(l, 3, out radius);
				Vector3 direction;
				LuaObject.checkType(l, 4, out direction);
				RaycastHit[] a = Physics.CapsuleCastAll(point, point2, radius, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector3 point4;
				LuaObject.checkType(l, 2, out point4);
				float radius2;
				LuaObject.checkType(l, 3, out radius2);
				Vector3 direction2;
				LuaObject.checkType(l, 4, out direction2);
				float maxDistance;
				LuaObject.checkType(l, 5, out maxDistance);
				RaycastHit[] a2 = Physics.CapsuleCastAll(point3, point4, radius2, direction2, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 6)
			{
				Vector3 point5;
				LuaObject.checkType(l, 1, out point5);
				Vector3 point6;
				LuaObject.checkType(l, 2, out point6);
				float radius3;
				LuaObject.checkType(l, 3, out radius3);
				Vector3 direction3;
				LuaObject.checkType(l, 4, out direction3);
				float maxDistance2;
				LuaObject.checkType(l, 5, out maxDistance2);
				int layermask;
				LuaObject.checkType(l, 6, out layermask);
				RaycastHit[] a3 = Physics.CapsuleCastAll(point5, point6, radius3, direction3, maxDistance2, layermask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 7)
			{
				Vector3 point7;
				LuaObject.checkType(l, 1, out point7);
				Vector3 point8;
				LuaObject.checkType(l, 2, out point8);
				float radius4;
				LuaObject.checkType(l, 3, out radius4);
				Vector3 direction4;
				LuaObject.checkType(l, 4, out direction4);
				float maxDistance3;
				LuaObject.checkType(l, 5, out maxDistance3);
				int layermask2;
				LuaObject.checkType(l, 6, out layermask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 7, out queryTriggerInteraction);
				RaycastHit[] a4 = Physics.CapsuleCastAll(point7, point8, radius4, direction4, maxDistance3, layermask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
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

	// Token: 0x060236ED RID: 145133 RVA: 0x00C57990 File Offset: 0x00C55B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CapsuleCastNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				Vector3 point;
				LuaObject.checkType(l, 1, out point);
				Vector3 point2;
				LuaObject.checkType(l, 2, out point2);
				float radius;
				LuaObject.checkType(l, 3, out radius);
				Vector3 direction;
				LuaObject.checkType(l, 4, out direction);
				RaycastHit[] results;
				LuaObject.checkArray<RaycastHit>(l, 5, out results);
				int i = Physics.CapsuleCastNonAlloc(point, point2, radius, direction, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 6)
			{
				Vector3 point3;
				LuaObject.checkType(l, 1, out point3);
				Vector3 point4;
				LuaObject.checkType(l, 2, out point4);
				float radius2;
				LuaObject.checkType(l, 3, out radius2);
				Vector3 direction2;
				LuaObject.checkType(l, 4, out direction2);
				RaycastHit[] results2;
				LuaObject.checkArray<RaycastHit>(l, 5, out results2);
				float maxDistance;
				LuaObject.checkType(l, 6, out maxDistance);
				int i2 = Physics.CapsuleCastNonAlloc(point3, point4, radius2, direction2, results2, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 7)
			{
				Vector3 point5;
				LuaObject.checkType(l, 1, out point5);
				Vector3 point6;
				LuaObject.checkType(l, 2, out point6);
				float radius3;
				LuaObject.checkType(l, 3, out radius3);
				Vector3 direction3;
				LuaObject.checkType(l, 4, out direction3);
				RaycastHit[] results3;
				LuaObject.checkArray<RaycastHit>(l, 5, out results3);
				float maxDistance2;
				LuaObject.checkType(l, 6, out maxDistance2);
				int layermask;
				LuaObject.checkType(l, 7, out layermask);
				int i3 = Physics.CapsuleCastNonAlloc(point5, point6, radius3, direction3, results3, maxDistance2, layermask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 8)
			{
				Vector3 point7;
				LuaObject.checkType(l, 1, out point7);
				Vector3 point8;
				LuaObject.checkType(l, 2, out point8);
				float radius4;
				LuaObject.checkType(l, 3, out radius4);
				Vector3 direction4;
				LuaObject.checkType(l, 4, out direction4);
				RaycastHit[] results4;
				LuaObject.checkArray<RaycastHit>(l, 5, out results4);
				float maxDistance3;
				LuaObject.checkType(l, 6, out maxDistance3);
				int layermask2;
				LuaObject.checkType(l, 7, out layermask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 8, out queryTriggerInteraction);
				int i4 = Physics.CapsuleCastNonAlloc(point7, point8, radius4, direction4, results4, maxDistance3, layermask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
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

	// Token: 0x060236EE RID: 145134 RVA: 0x00C57BB8 File Offset: 0x00C55DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SphereCastAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Ray ray;
				LuaObject.checkValueType<Ray>(l, 1, out ray);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				RaycastHit[] a = Physics.SphereCastAll(ray, radius);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(float)))
			{
				Ray ray2;
				LuaObject.checkValueType<Ray>(l, 1, out ray2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				float maxDistance;
				LuaObject.checkType(l, 3, out maxDistance);
				RaycastHit[] a2 = Physics.SphereCastAll(ray2, radius2, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(float), typeof(Vector3)))
			{
				Vector3 origin;
				LuaObject.checkType(l, 1, out origin);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				Vector3 direction;
				LuaObject.checkType(l, 3, out direction);
				RaycastHit[] a3 = Physics.SphereCastAll(origin, radius3, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(float), typeof(int)))
			{
				Ray ray3;
				LuaObject.checkValueType<Ray>(l, 1, out ray3);
				float radius4;
				LuaObject.checkType(l, 2, out radius4);
				float maxDistance2;
				LuaObject.checkType(l, 3, out maxDistance2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				RaycastHit[] a4 = Physics.SphereCastAll(ray3, radius4, maxDistance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(float), typeof(Vector3), typeof(float)))
			{
				Vector3 origin2;
				LuaObject.checkType(l, 1, out origin2);
				float radius5;
				LuaObject.checkType(l, 2, out radius5);
				Vector3 direction2;
				LuaObject.checkType(l, 3, out direction2);
				float maxDistance3;
				LuaObject.checkType(l, 4, out maxDistance3);
				RaycastHit[] a5 = Physics.SphereCastAll(origin2, radius5, direction2, maxDistance3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a5);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(float), typeof(Vector3), typeof(float), typeof(int)))
			{
				Vector3 origin3;
				LuaObject.checkType(l, 1, out origin3);
				float radius6;
				LuaObject.checkType(l, 2, out radius6);
				Vector3 direction3;
				LuaObject.checkType(l, 3, out direction3);
				float maxDistance4;
				LuaObject.checkType(l, 4, out maxDistance4);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				RaycastHit[] a6 = Physics.SphereCastAll(origin3, radius6, direction3, maxDistance4, layerMask2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a6);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Ray ray4;
				LuaObject.checkValueType<Ray>(l, 1, out ray4);
				float radius7;
				LuaObject.checkType(l, 2, out radius7);
				float maxDistance5;
				LuaObject.checkType(l, 3, out maxDistance5);
				int layerMask3;
				LuaObject.checkType(l, 4, out layerMask3);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction);
				RaycastHit[] a7 = Physics.SphereCastAll(ray4, radius7, maxDistance5, layerMask3, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a7);
				result = 2;
			}
			else if (num == 6)
			{
				Vector3 origin4;
				LuaObject.checkType(l, 1, out origin4);
				float radius8;
				LuaObject.checkType(l, 2, out radius8);
				Vector3 direction4;
				LuaObject.checkType(l, 3, out direction4);
				float maxDistance6;
				LuaObject.checkType(l, 4, out maxDistance6);
				int layerMask4;
				LuaObject.checkType(l, 5, out layerMask4);
				QueryTriggerInteraction queryTriggerInteraction2;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 6, out queryTriggerInteraction2);
				RaycastHit[] a8 = Physics.SphereCastAll(origin4, radius8, direction4, maxDistance6, layerMask4, queryTriggerInteraction2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a8);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SphereCastAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236EF RID: 145135 RVA: 0x00C57FD0 File Offset: 0x00C561D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SphereCastNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Ray ray;
				LuaObject.checkValueType<Ray>(l, 1, out ray);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				RaycastHit[] results;
				LuaObject.checkArray<RaycastHit>(l, 3, out results);
				int i = Physics.SphereCastNonAlloc(ray, radius, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(RaycastHit[]), typeof(float)))
			{
				Ray ray2;
				LuaObject.checkValueType<Ray>(l, 1, out ray2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				RaycastHit[] results2;
				LuaObject.checkArray<RaycastHit>(l, 3, out results2);
				float maxDistance;
				LuaObject.checkType(l, 4, out maxDistance);
				int i2 = Physics.SphereCastNonAlloc(ray2, radius2, results2, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(float), typeof(Vector3), typeof(RaycastHit[])))
			{
				Vector3 origin;
				LuaObject.checkType(l, 1, out origin);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				Vector3 direction;
				LuaObject.checkType(l, 3, out direction);
				RaycastHit[] results3;
				LuaObject.checkArray<RaycastHit>(l, 4, out results3);
				int i3 = Physics.SphereCastNonAlloc(origin, radius3, direction, results3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(RaycastHit[]), typeof(float), typeof(int)))
			{
				Ray ray3;
				LuaObject.checkValueType<Ray>(l, 1, out ray3);
				float radius4;
				LuaObject.checkType(l, 2, out radius4);
				RaycastHit[] results4;
				LuaObject.checkArray<RaycastHit>(l, 3, out results4);
				float maxDistance2;
				LuaObject.checkType(l, 4, out maxDistance2);
				int layerMask;
				LuaObject.checkType(l, 5, out layerMask);
				int i4 = Physics.SphereCastNonAlloc(ray3, radius4, results4, maxDistance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(float), typeof(Vector3), typeof(RaycastHit[]), typeof(float)))
			{
				Vector3 origin2;
				LuaObject.checkType(l, 1, out origin2);
				float radius5;
				LuaObject.checkType(l, 2, out radius5);
				Vector3 direction2;
				LuaObject.checkType(l, 3, out direction2);
				RaycastHit[] results5;
				LuaObject.checkArray<RaycastHit>(l, 4, out results5);
				float maxDistance3;
				LuaObject.checkType(l, 5, out maxDistance3);
				int i5 = Physics.SphereCastNonAlloc(origin2, radius5, direction2, results5, maxDistance3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(float), typeof(Vector3), typeof(RaycastHit[]), typeof(float), typeof(int)))
			{
				Vector3 origin3;
				LuaObject.checkType(l, 1, out origin3);
				float radius6;
				LuaObject.checkType(l, 2, out radius6);
				Vector3 direction3;
				LuaObject.checkType(l, 3, out direction3);
				RaycastHit[] results6;
				LuaObject.checkArray<RaycastHit>(l, 4, out results6);
				float maxDistance4;
				LuaObject.checkType(l, 5, out maxDistance4);
				int layerMask2;
				LuaObject.checkType(l, 6, out layerMask2);
				int i6 = Physics.SphereCastNonAlloc(origin3, radius6, direction3, results6, maxDistance4, layerMask2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i6);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Ray), typeof(float), typeof(RaycastHit[]), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Ray ray4;
				LuaObject.checkValueType<Ray>(l, 1, out ray4);
				float radius7;
				LuaObject.checkType(l, 2, out radius7);
				RaycastHit[] results7;
				LuaObject.checkArray<RaycastHit>(l, 3, out results7);
				float maxDistance5;
				LuaObject.checkType(l, 4, out maxDistance5);
				int layerMask3;
				LuaObject.checkType(l, 5, out layerMask3);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 6, out queryTriggerInteraction);
				int i7 = Physics.SphereCastNonAlloc(ray4, radius7, results7, maxDistance5, layerMask3, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i7);
				result = 2;
			}
			else if (num == 7)
			{
				Vector3 origin4;
				LuaObject.checkType(l, 1, out origin4);
				float radius8;
				LuaObject.checkType(l, 2, out radius8);
				Vector3 direction4;
				LuaObject.checkType(l, 3, out direction4);
				RaycastHit[] results8;
				LuaObject.checkArray<RaycastHit>(l, 4, out results8);
				float maxDistance6;
				LuaObject.checkType(l, 5, out maxDistance6);
				int layerMask4;
				LuaObject.checkType(l, 6, out layerMask4);
				QueryTriggerInteraction queryTriggerInteraction2;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 7, out queryTriggerInteraction2);
				int i8 = Physics.SphereCastNonAlloc(origin4, radius8, direction4, results8, maxDistance6, layerMask4, queryTriggerInteraction2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i8);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SphereCastNonAlloc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236F0 RID: 145136 RVA: 0x00C58484 File Offset: 0x00C56684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckSphere_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector3 position;
				LuaObject.checkType(l, 1, out position);
				float radius;
				LuaObject.checkType(l, 2, out radius);
				bool b = Physics.CheckSphere(position, radius);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				Vector3 position2;
				LuaObject.checkType(l, 1, out position2);
				float radius2;
				LuaObject.checkType(l, 2, out radius2);
				int layerMask;
				LuaObject.checkType(l, 3, out layerMask);
				bool b2 = Physics.CheckSphere(position2, radius2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (num == 4)
			{
				Vector3 position3;
				LuaObject.checkType(l, 1, out position3);
				float radius3;
				LuaObject.checkType(l, 2, out radius3);
				int layerMask2;
				LuaObject.checkType(l, 3, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 4, out queryTriggerInteraction);
				bool b3 = Physics.CheckSphere(position3, radius3, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CheckSphere to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236F1 RID: 145137 RVA: 0x00C585AC File Offset: 0x00C567AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckCapsule_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector3 start;
				LuaObject.checkType(l, 1, out start);
				Vector3 end;
				LuaObject.checkType(l, 2, out end);
				float radius;
				LuaObject.checkType(l, 3, out radius);
				bool b = Physics.CheckCapsule(start, end, radius);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 4)
			{
				Vector3 start2;
				LuaObject.checkType(l, 1, out start2);
				Vector3 end2;
				LuaObject.checkType(l, 2, out end2);
				float radius2;
				LuaObject.checkType(l, 3, out radius2);
				int layermask;
				LuaObject.checkType(l, 4, out layermask);
				bool b2 = Physics.CheckCapsule(start2, end2, radius2, layermask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 start3;
				LuaObject.checkType(l, 1, out start3);
				Vector3 end3;
				LuaObject.checkType(l, 2, out end3);
				float radius3;
				LuaObject.checkType(l, 3, out radius3);
				int layermask2;
				LuaObject.checkType(l, 4, out layermask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction);
				bool b3 = Physics.CheckCapsule(start3, end3, radius3, layermask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CheckCapsule to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236F2 RID: 145138 RVA: 0x00C58708 File Offset: 0x00C56908
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckBox_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector3 center;
				LuaObject.checkType(l, 1, out center);
				Vector3 halfExtents;
				LuaObject.checkType(l, 2, out halfExtents);
				bool b = Physics.CheckBox(center, halfExtents);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				Vector3 center2;
				LuaObject.checkType(l, 1, out center2);
				Vector3 halfExtents2;
				LuaObject.checkType(l, 2, out halfExtents2);
				Quaternion orientation;
				LuaObject.checkType(l, 3, out orientation);
				bool b2 = Physics.CheckBox(center2, halfExtents2, orientation);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (num == 4)
			{
				Vector3 center3;
				LuaObject.checkType(l, 1, out center3);
				Vector3 halfExtents3;
				LuaObject.checkType(l, 2, out halfExtents3);
				Quaternion orientation2;
				LuaObject.checkType(l, 3, out orientation2);
				int layermask;
				LuaObject.checkType(l, 4, out layermask);
				bool b3 = Physics.CheckBox(center3, halfExtents3, orientation2, layermask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 center4;
				LuaObject.checkType(l, 1, out center4);
				Vector3 halfExtents4;
				LuaObject.checkType(l, 2, out halfExtents4);
				Quaternion orientation3;
				LuaObject.checkType(l, 3, out orientation3);
				int layermask2;
				LuaObject.checkType(l, 4, out layermask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction);
				bool b4 = Physics.CheckBox(center4, halfExtents4, orientation3, layermask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CheckBox to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236F3 RID: 145139 RVA: 0x00C588A0 File Offset: 0x00C56AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapBox_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Vector3 center;
				LuaObject.checkType(l, 1, out center);
				Vector3 halfExtents;
				LuaObject.checkType(l, 2, out halfExtents);
				Collider[] a = Physics.OverlapBox(center, halfExtents);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 3)
			{
				Vector3 center2;
				LuaObject.checkType(l, 1, out center2);
				Vector3 halfExtents2;
				LuaObject.checkType(l, 2, out halfExtents2);
				Quaternion orientation;
				LuaObject.checkType(l, 3, out orientation);
				Collider[] a2 = Physics.OverlapBox(center2, halfExtents2, orientation);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 4)
			{
				Vector3 center3;
				LuaObject.checkType(l, 1, out center3);
				Vector3 halfExtents3;
				LuaObject.checkType(l, 2, out halfExtents3);
				Quaternion orientation2;
				LuaObject.checkType(l, 3, out orientation2);
				int layerMask;
				LuaObject.checkType(l, 4, out layerMask);
				Collider[] a3 = Physics.OverlapBox(center3, halfExtents3, orientation2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 center4;
				LuaObject.checkType(l, 1, out center4);
				Vector3 halfExtents4;
				LuaObject.checkType(l, 2, out halfExtents4);
				Quaternion orientation3;
				LuaObject.checkType(l, 3, out orientation3);
				int layerMask2;
				LuaObject.checkType(l, 4, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction);
				Collider[] a4 = Physics.OverlapBox(center4, halfExtents4, orientation3, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
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

	// Token: 0x060236F4 RID: 145140 RVA: 0x00C58A38 File Offset: 0x00C56C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapBoxNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector3 center;
				LuaObject.checkType(l, 1, out center);
				Vector3 halfExtents;
				LuaObject.checkType(l, 2, out halfExtents);
				Collider[] results;
				LuaObject.checkArray<Collider>(l, 3, out results);
				int i = Physics.OverlapBoxNonAlloc(center, halfExtents, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				Vector3 center2;
				LuaObject.checkType(l, 1, out center2);
				Vector3 halfExtents2;
				LuaObject.checkType(l, 2, out halfExtents2);
				Collider[] results2;
				LuaObject.checkArray<Collider>(l, 3, out results2);
				Quaternion orientation;
				LuaObject.checkType(l, 4, out orientation);
				int i2 = Physics.OverlapBoxNonAlloc(center2, halfExtents2, results2, orientation);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 center3;
				LuaObject.checkType(l, 1, out center3);
				Vector3 halfExtents3;
				LuaObject.checkType(l, 2, out halfExtents3);
				Collider[] results3;
				LuaObject.checkArray<Collider>(l, 3, out results3);
				Quaternion orientation2;
				LuaObject.checkType(l, 4, out orientation2);
				int layerMask;
				LuaObject.checkType(l, 5, out layerMask);
				int i3 = Physics.OverlapBoxNonAlloc(center3, halfExtents3, results3, orientation2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 6)
			{
				Vector3 center4;
				LuaObject.checkType(l, 1, out center4);
				Vector3 halfExtents4;
				LuaObject.checkType(l, 2, out halfExtents4);
				Collider[] results4;
				LuaObject.checkArray<Collider>(l, 3, out results4);
				Quaternion orientation3;
				LuaObject.checkType(l, 4, out orientation3);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 6, out queryTriggerInteraction);
				int i4 = Physics.OverlapBoxNonAlloc(center4, halfExtents4, results4, orientation3, layerMask2, queryTriggerInteraction);
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

	// Token: 0x060236F5 RID: 145141 RVA: 0x00C58C00 File Offset: 0x00C56E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BoxCastAll_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector3 center;
				LuaObject.checkType(l, 1, out center);
				Vector3 halfExtents;
				LuaObject.checkType(l, 2, out halfExtents);
				Vector3 direction;
				LuaObject.checkType(l, 3, out direction);
				RaycastHit[] a = Physics.BoxCastAll(center, halfExtents, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 4)
			{
				Vector3 center2;
				LuaObject.checkType(l, 1, out center2);
				Vector3 halfExtents2;
				LuaObject.checkType(l, 2, out halfExtents2);
				Vector3 direction2;
				LuaObject.checkType(l, 3, out direction2);
				Quaternion orientation;
				LuaObject.checkType(l, 4, out orientation);
				RaycastHit[] a2 = Physics.BoxCastAll(center2, halfExtents2, direction2, orientation);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 center3;
				LuaObject.checkType(l, 1, out center3);
				Vector3 halfExtents3;
				LuaObject.checkType(l, 2, out halfExtents3);
				Vector3 direction3;
				LuaObject.checkType(l, 3, out direction3);
				Quaternion orientation2;
				LuaObject.checkType(l, 4, out orientation2);
				float maxDistance;
				LuaObject.checkType(l, 5, out maxDistance);
				RaycastHit[] a3 = Physics.BoxCastAll(center3, halfExtents3, direction3, orientation2, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else if (num == 6)
			{
				Vector3 center4;
				LuaObject.checkType(l, 1, out center4);
				Vector3 halfExtents4;
				LuaObject.checkType(l, 2, out halfExtents4);
				Vector3 direction4;
				LuaObject.checkType(l, 3, out direction4);
				Quaternion orientation3;
				LuaObject.checkType(l, 4, out orientation3);
				float maxDistance2;
				LuaObject.checkType(l, 5, out maxDistance2);
				int layermask;
				LuaObject.checkType(l, 6, out layermask);
				RaycastHit[] a4 = Physics.BoxCastAll(center4, halfExtents4, direction4, orientation3, maxDistance2, layermask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a4);
				result = 2;
			}
			else if (num == 7)
			{
				Vector3 center5;
				LuaObject.checkType(l, 1, out center5);
				Vector3 halfExtents5;
				LuaObject.checkType(l, 2, out halfExtents5);
				Vector3 direction5;
				LuaObject.checkType(l, 3, out direction5);
				Quaternion orientation4;
				LuaObject.checkType(l, 4, out orientation4);
				float maxDistance3;
				LuaObject.checkType(l, 5, out maxDistance3);
				int layermask2;
				LuaObject.checkType(l, 6, out layermask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 7, out queryTriggerInteraction);
				RaycastHit[] a5 = Physics.BoxCastAll(center5, halfExtents5, direction5, orientation4, maxDistance3, layermask2, queryTriggerInteraction);
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

	// Token: 0x060236F6 RID: 145142 RVA: 0x00C58E40 File Offset: 0x00C57040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BoxCastNonAlloc_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Vector3 center;
				LuaObject.checkType(l, 1, out center);
				Vector3 halfExtents;
				LuaObject.checkType(l, 2, out halfExtents);
				Vector3 direction;
				LuaObject.checkType(l, 3, out direction);
				RaycastHit[] results;
				LuaObject.checkArray<RaycastHit>(l, 4, out results);
				int i = Physics.BoxCastNonAlloc(center, halfExtents, direction, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 5)
			{
				Vector3 center2;
				LuaObject.checkType(l, 1, out center2);
				Vector3 halfExtents2;
				LuaObject.checkType(l, 2, out halfExtents2);
				Vector3 direction2;
				LuaObject.checkType(l, 3, out direction2);
				RaycastHit[] results2;
				LuaObject.checkArray<RaycastHit>(l, 4, out results2);
				Quaternion orientation;
				LuaObject.checkType(l, 5, out orientation);
				int i2 = Physics.BoxCastNonAlloc(center2, halfExtents2, direction2, results2, orientation);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 6)
			{
				Vector3 center3;
				LuaObject.checkType(l, 1, out center3);
				Vector3 halfExtents3;
				LuaObject.checkType(l, 2, out halfExtents3);
				Vector3 direction3;
				LuaObject.checkType(l, 3, out direction3);
				RaycastHit[] results3;
				LuaObject.checkArray<RaycastHit>(l, 4, out results3);
				Quaternion orientation2;
				LuaObject.checkType(l, 5, out orientation2);
				float maxDistance;
				LuaObject.checkType(l, 6, out maxDistance);
				int i3 = Physics.BoxCastNonAlloc(center3, halfExtents3, direction3, results3, orientation2, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 7)
			{
				Vector3 center4;
				LuaObject.checkType(l, 1, out center4);
				Vector3 halfExtents4;
				LuaObject.checkType(l, 2, out halfExtents4);
				Vector3 direction4;
				LuaObject.checkType(l, 3, out direction4);
				RaycastHit[] results4;
				LuaObject.checkArray<RaycastHit>(l, 4, out results4);
				Quaternion orientation3;
				LuaObject.checkType(l, 5, out orientation3);
				float maxDistance2;
				LuaObject.checkType(l, 6, out maxDistance2);
				int layermask;
				LuaObject.checkType(l, 7, out layermask);
				int i4 = Physics.BoxCastNonAlloc(center4, halfExtents4, direction4, results4, orientation3, maxDistance2, layermask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (num == 8)
			{
				Vector3 center5;
				LuaObject.checkType(l, 1, out center5);
				Vector3 halfExtents5;
				LuaObject.checkType(l, 2, out halfExtents5);
				Vector3 direction5;
				LuaObject.checkType(l, 3, out direction5);
				RaycastHit[] results5;
				LuaObject.checkArray<RaycastHit>(l, 4, out results5);
				Quaternion orientation4;
				LuaObject.checkType(l, 5, out orientation4);
				float maxDistance3;
				LuaObject.checkType(l, 6, out maxDistance3);
				int layermask2;
				LuaObject.checkType(l, 7, out layermask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 8, out queryTriggerInteraction);
				int i5 = Physics.BoxCastNonAlloc(center5, halfExtents5, direction5, results5, orientation4, maxDistance3, layermask2, queryTriggerInteraction);
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

	// Token: 0x060236F7 RID: 145143 RVA: 0x00C590BC File Offset: 0x00C572BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BoxCast_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector3 center;
				LuaObject.checkType(l, 1, out center);
				Vector3 halfExtents;
				LuaObject.checkType(l, 2, out halfExtents);
				Vector3 direction;
				LuaObject.checkType(l, 3, out direction);
				bool b = Physics.BoxCast(center, halfExtents, direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(LuaOut)))
			{
				Vector3 center2;
				LuaObject.checkType(l, 1, out center2);
				Vector3 halfExtents2;
				LuaObject.checkType(l, 2, out halfExtents2);
				Vector3 direction2;
				LuaObject.checkType(l, 3, out direction2);
				RaycastHit r;
				bool b2 = Physics.BoxCast(center2, halfExtents2, direction2, out r);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				LuaObject.pushValue(l, r);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion)))
			{
				Vector3 center3;
				LuaObject.checkType(l, 1, out center3);
				Vector3 halfExtents3;
				LuaObject.checkType(l, 2, out halfExtents3);
				Vector3 direction3;
				LuaObject.checkType(l, 3, out direction3);
				Quaternion orientation;
				LuaObject.checkType(l, 4, out orientation);
				bool b3 = Physics.BoxCast(center3, halfExtents3, direction3, orientation);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(float)))
			{
				Vector3 center4;
				LuaObject.checkType(l, 1, out center4);
				Vector3 halfExtents4;
				LuaObject.checkType(l, 2, out halfExtents4);
				Vector3 direction4;
				LuaObject.checkType(l, 3, out direction4);
				Quaternion orientation2;
				LuaObject.checkType(l, 4, out orientation2);
				float maxDistance;
				LuaObject.checkType(l, 5, out maxDistance);
				bool b4 = Physics.BoxCast(center4, halfExtents4, direction4, orientation2, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(LuaOut), typeof(Quaternion)))
			{
				Vector3 center5;
				LuaObject.checkType(l, 1, out center5);
				Vector3 halfExtents5;
				LuaObject.checkType(l, 2, out halfExtents5);
				Vector3 direction5;
				LuaObject.checkType(l, 3, out direction5);
				Quaternion orientation3;
				LuaObject.checkType(l, 5, out orientation3);
				RaycastHit r2;
				bool b5 = Physics.BoxCast(center5, halfExtents5, direction5, out r2, orientation3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b5);
				LuaObject.pushValue(l, r2);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(LuaOut), typeof(Quaternion), typeof(float)))
			{
				Vector3 center6;
				LuaObject.checkType(l, 1, out center6);
				Vector3 halfExtents6;
				LuaObject.checkType(l, 2, out halfExtents6);
				Vector3 direction6;
				LuaObject.checkType(l, 3, out direction6);
				Quaternion orientation4;
				LuaObject.checkType(l, 5, out orientation4);
				float maxDistance2;
				LuaObject.checkType(l, 6, out maxDistance2);
				RaycastHit r3;
				bool b6 = Physics.BoxCast(center6, halfExtents6, direction6, out r3, orientation4, maxDistance2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b6);
				LuaObject.pushValue(l, r3);
				result = 3;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(float), typeof(int)))
			{
				Vector3 center7;
				LuaObject.checkType(l, 1, out center7);
				Vector3 halfExtents7;
				LuaObject.checkType(l, 2, out halfExtents7);
				Vector3 direction7;
				LuaObject.checkType(l, 3, out direction7);
				Quaternion orientation5;
				LuaObject.checkType(l, 4, out orientation5);
				float maxDistance3;
				LuaObject.checkType(l, 5, out maxDistance3);
				int layerMask;
				LuaObject.checkType(l, 6, out layerMask);
				bool b7 = Physics.BoxCast(center7, halfExtents7, direction7, orientation5, maxDistance3, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b7);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(float), typeof(int), typeof(QueryTriggerInteraction)))
			{
				Vector3 center8;
				LuaObject.checkType(l, 1, out center8);
				Vector3 halfExtents8;
				LuaObject.checkType(l, 2, out halfExtents8);
				Vector3 direction8;
				LuaObject.checkType(l, 3, out direction8);
				Quaternion orientation6;
				LuaObject.checkType(l, 4, out orientation6);
				float maxDistance4;
				LuaObject.checkType(l, 5, out maxDistance4);
				int layerMask2;
				LuaObject.checkType(l, 6, out layerMask2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 7, out queryTriggerInteraction);
				bool b8 = Physics.BoxCast(center8, halfExtents8, direction8, orientation6, maxDistance4, layerMask2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b8);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(LuaOut), typeof(Quaternion), typeof(float), typeof(int)))
			{
				Vector3 center9;
				LuaObject.checkType(l, 1, out center9);
				Vector3 halfExtents9;
				LuaObject.checkType(l, 2, out halfExtents9);
				Vector3 direction9;
				LuaObject.checkType(l, 3, out direction9);
				Quaternion orientation7;
				LuaObject.checkType(l, 5, out orientation7);
				float maxDistance5;
				LuaObject.checkType(l, 6, out maxDistance5);
				int layerMask3;
				LuaObject.checkType(l, 7, out layerMask3);
				RaycastHit r4;
				bool b9 = Physics.BoxCast(center9, halfExtents9, direction9, out r4, orientation7, maxDistance5, layerMask3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b9);
				LuaObject.pushValue(l, r4);
				result = 3;
			}
			else if (num == 8)
			{
				Vector3 center10;
				LuaObject.checkType(l, 1, out center10);
				Vector3 halfExtents10;
				LuaObject.checkType(l, 2, out halfExtents10);
				Vector3 direction10;
				LuaObject.checkType(l, 3, out direction10);
				Quaternion orientation8;
				LuaObject.checkType(l, 5, out orientation8);
				float maxDistance6;
				LuaObject.checkType(l, 6, out maxDistance6);
				int layerMask4;
				LuaObject.checkType(l, 7, out layerMask4);
				QueryTriggerInteraction queryTriggerInteraction2;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 8, out queryTriggerInteraction2);
				RaycastHit r5;
				bool b10 = Physics.BoxCast(center10, halfExtents10, direction10, out r5, orientation8, maxDistance6, layerMask4, queryTriggerInteraction2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b10);
				LuaObject.pushValue(l, r5);
				result = 3;
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

	// Token: 0x060236F8 RID: 145144 RVA: 0x00C596FC File Offset: 0x00C578FC
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
				Collider collider;
				LuaObject.checkType<Collider>(l, 1, out collider);
				Collider collider2;
				LuaObject.checkType<Collider>(l, 2, out collider2);
				Physics.IgnoreCollision(collider, collider2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Collider collider3;
				LuaObject.checkType<Collider>(l, 1, out collider3);
				Collider collider4;
				LuaObject.checkType<Collider>(l, 2, out collider4);
				bool ignore;
				LuaObject.checkType(l, 3, out ignore);
				Physics.IgnoreCollision(collider3, collider4, ignore);
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

	// Token: 0x060236F9 RID: 145145 RVA: 0x00C597B8 File Offset: 0x00C579B8
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
				Physics.IgnoreLayerCollision(layer, layer2);
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
				Physics.IgnoreLayerCollision(layer3, layer4, ignore);
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

	// Token: 0x060236FA RID: 145146 RVA: 0x00C59874 File Offset: 0x00C57A74
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
			bool ignoreLayerCollision = Physics.GetIgnoreLayerCollision(layer, layer2);
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

	// Token: 0x060236FB RID: 145147 RVA: 0x00C598D4 File Offset: 0x00C57AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputePenetration_s(IntPtr l)
	{
		int result;
		try
		{
			Collider colliderA;
			LuaObject.checkType<Collider>(l, 1, out colliderA);
			Vector3 positionA;
			LuaObject.checkType(l, 2, out positionA);
			Quaternion rotationA;
			LuaObject.checkType(l, 3, out rotationA);
			Collider colliderB;
			LuaObject.checkType<Collider>(l, 4, out colliderB);
			Vector3 positionB;
			LuaObject.checkType(l, 5, out positionB);
			Quaternion rotationB;
			LuaObject.checkType(l, 6, out rotationB);
			Vector3 o;
			float o2;
			bool b = Physics.ComputePenetration(colliderA, positionA, rotationA, colliderB, positionB, rotationB, out o, out o2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, o2);
			result = 4;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236FC RID: 145148 RVA: 0x00C5997C File Offset: 0x00C57B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosestPoint_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 point;
			LuaObject.checkType(l, 1, out point);
			Collider collider;
			LuaObject.checkType<Collider>(l, 2, out collider);
			Vector3 position;
			LuaObject.checkType(l, 3, out position);
			Quaternion rotation;
			LuaObject.checkType(l, 4, out rotation);
			Vector3 o = Physics.ClosestPoint(point, collider, position, rotation);
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

	// Token: 0x060236FD RID: 145149 RVA: 0x00C599F8 File Offset: 0x00C57BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Simulate_s(IntPtr l)
	{
		int result;
		try
		{
			float step;
			LuaObject.checkType(l, 1, out step);
			Physics.Simulate(step);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236FE RID: 145150 RVA: 0x00C59A44 File Offset: 0x00C57C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SyncTransforms_s(IntPtr l)
	{
		int result;
		try
		{
			Physics.SyncTransforms();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236FF RID: 145151 RVA: 0x00C59A84 File Offset: 0x00C57C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RebuildBroadphaseRegions_s(IntPtr l)
	{
		int result;
		try
		{
			Bounds worldBounds;
			LuaObject.checkValueType<Bounds>(l, 1, out worldBounds);
			int subdivisions;
			LuaObject.checkType(l, 2, out subdivisions);
			Physics.RebuildBroadphaseRegions(worldBounds, subdivisions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023700 RID: 145152 RVA: 0x00C59ADC File Offset: 0x00C57CDC
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

	// Token: 0x06023701 RID: 145153 RVA: 0x00C59B20 File Offset: 0x00C57D20
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

	// Token: 0x06023702 RID: 145154 RVA: 0x00C59B64 File Offset: 0x00C57D64
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

	// Token: 0x06023703 RID: 145155 RVA: 0x00C59BA8 File Offset: 0x00C57DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gravity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.gravity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023704 RID: 145156 RVA: 0x00C59BF0 File Offset: 0x00C57DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_gravity(IntPtr l)
	{
		int result;
		try
		{
			Vector3 gravity;
			LuaObject.checkType(l, 2, out gravity);
			Physics.gravity = gravity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023705 RID: 145157 RVA: 0x00C59C3C File Offset: 0x00C57E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultContactOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.defaultContactOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023706 RID: 145158 RVA: 0x00C59C84 File Offset: 0x00C57E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_defaultContactOffset(IntPtr l)
	{
		int result;
		try
		{
			float defaultContactOffset;
			LuaObject.checkType(l, 2, out defaultContactOffset);
			Physics.defaultContactOffset = defaultContactOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023707 RID: 145159 RVA: 0x00C59CD0 File Offset: 0x00C57ED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_bounceThreshold(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.bounceThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023708 RID: 145160 RVA: 0x00C59D18 File Offset: 0x00C57F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bounceThreshold(IntPtr l)
	{
		int result;
		try
		{
			float bounceThreshold;
			LuaObject.checkType(l, 2, out bounceThreshold);
			Physics.bounceThreshold = bounceThreshold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023709 RID: 145161 RVA: 0x00C59D64 File Offset: 0x00C57F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultSolverIterations(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.defaultSolverIterations);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602370A RID: 145162 RVA: 0x00C59DAC File Offset: 0x00C57FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_defaultSolverIterations(IntPtr l)
	{
		int result;
		try
		{
			int defaultSolverIterations;
			LuaObject.checkType(l, 2, out defaultSolverIterations);
			Physics.defaultSolverIterations = defaultSolverIterations;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602370B RID: 145163 RVA: 0x00C59DF8 File Offset: 0x00C57FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultSolverVelocityIterations(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.defaultSolverVelocityIterations);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602370C RID: 145164 RVA: 0x00C59E40 File Offset: 0x00C58040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_defaultSolverVelocityIterations(IntPtr l)
	{
		int result;
		try
		{
			int defaultSolverVelocityIterations;
			LuaObject.checkType(l, 2, out defaultSolverVelocityIterations);
			Physics.defaultSolverVelocityIterations = defaultSolverVelocityIterations;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602370D RID: 145165 RVA: 0x00C59E8C File Offset: 0x00C5808C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_sleepThreshold(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.sleepThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602370E RID: 145166 RVA: 0x00C59ED4 File Offset: 0x00C580D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sleepThreshold(IntPtr l)
	{
		int result;
		try
		{
			float sleepThreshold;
			LuaObject.checkType(l, 2, out sleepThreshold);
			Physics.sleepThreshold = sleepThreshold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602370F RID: 145167 RVA: 0x00C59F20 File Offset: 0x00C58120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_queriesHitTriggers(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.queriesHitTriggers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023710 RID: 145168 RVA: 0x00C59F68 File Offset: 0x00C58168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_queriesHitTriggers(IntPtr l)
	{
		int result;
		try
		{
			bool queriesHitTriggers;
			LuaObject.checkType(l, 2, out queriesHitTriggers);
			Physics.queriesHitTriggers = queriesHitTriggers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023711 RID: 145169 RVA: 0x00C59FB4 File Offset: 0x00C581B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_queriesHitBackfaces(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.queriesHitBackfaces);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023712 RID: 145170 RVA: 0x00C59FFC File Offset: 0x00C581FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_queriesHitBackfaces(IntPtr l)
	{
		int result;
		try
		{
			bool queriesHitBackfaces;
			LuaObject.checkType(l, 2, out queriesHitBackfaces);
			Physics.queriesHitBackfaces = queriesHitBackfaces;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023713 RID: 145171 RVA: 0x00C5A048 File Offset: 0x00C58248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_interCollisionDistance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.interCollisionDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023714 RID: 145172 RVA: 0x00C5A090 File Offset: 0x00C58290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_interCollisionDistance(IntPtr l)
	{
		int result;
		try
		{
			float interCollisionDistance;
			LuaObject.checkType(l, 2, out interCollisionDistance);
			Physics.interCollisionDistance = interCollisionDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023715 RID: 145173 RVA: 0x00C5A0DC File Offset: 0x00C582DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_interCollisionStiffness(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.interCollisionStiffness);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023716 RID: 145174 RVA: 0x00C5A124 File Offset: 0x00C58324
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_interCollisionStiffness(IntPtr l)
	{
		int result;
		try
		{
			float interCollisionStiffness;
			LuaObject.checkType(l, 2, out interCollisionStiffness);
			Physics.interCollisionStiffness = interCollisionStiffness;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023717 RID: 145175 RVA: 0x00C5A170 File Offset: 0x00C58370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_interCollisionSettingsToggle(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.interCollisionSettingsToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023718 RID: 145176 RVA: 0x00C5A1B8 File Offset: 0x00C583B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_interCollisionSettingsToggle(IntPtr l)
	{
		int result;
		try
		{
			bool interCollisionSettingsToggle;
			LuaObject.checkType(l, 2, out interCollisionSettingsToggle);
			Physics.interCollisionSettingsToggle = interCollisionSettingsToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023719 RID: 145177 RVA: 0x00C5A204 File Offset: 0x00C58404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoSimulation(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.autoSimulation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602371A RID: 145178 RVA: 0x00C5A24C File Offset: 0x00C5844C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_autoSimulation(IntPtr l)
	{
		int result;
		try
		{
			bool autoSimulation;
			LuaObject.checkType(l, 2, out autoSimulation);
			Physics.autoSimulation = autoSimulation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602371B RID: 145179 RVA: 0x00C5A298 File Offset: 0x00C58498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoSyncTransforms(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Physics.autoSyncTransforms);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602371C RID: 145180 RVA: 0x00C5A2E0 File Offset: 0x00C584E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoSyncTransforms(IntPtr l)
	{
		int result;
		try
		{
			bool autoSyncTransforms;
			LuaObject.checkType(l, 2, out autoSyncTransforms);
			Physics.autoSyncTransforms = autoSyncTransforms;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602371D RID: 145181 RVA: 0x00C5A32C File Offset: 0x00C5852C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Physics");
		if (Lua_UnityEngine_Physics.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Physics.Raycast_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache0);
		if (Lua_UnityEngine_Physics.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Physics.RaycastAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache1);
		if (Lua_UnityEngine_Physics.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Physics.RaycastNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache2);
		if (Lua_UnityEngine_Physics.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Physics.Linecast_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache3);
		if (Lua_UnityEngine_Physics.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Physics.OverlapSphere_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache4);
		if (Lua_UnityEngine_Physics.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Physics.OverlapSphereNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache5);
		if (Lua_UnityEngine_Physics.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Physics.OverlapCapsule_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache6);
		if (Lua_UnityEngine_Physics.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Physics.OverlapCapsuleNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache7);
		if (Lua_UnityEngine_Physics.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Physics.CapsuleCast_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache8);
		if (Lua_UnityEngine_Physics.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Physics.SphereCast_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache9);
		if (Lua_UnityEngine_Physics.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Physics.CapsuleCastAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cacheA);
		if (Lua_UnityEngine_Physics.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Physics.CapsuleCastNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cacheB);
		if (Lua_UnityEngine_Physics.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Physics.SphereCastAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cacheC);
		if (Lua_UnityEngine_Physics.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Physics.SphereCastNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cacheD);
		if (Lua_UnityEngine_Physics.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Physics.CheckSphere_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cacheE);
		if (Lua_UnityEngine_Physics.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Physics.CheckCapsule_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cacheF);
		if (Lua_UnityEngine_Physics.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Physics.CheckBox_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache10);
		if (Lua_UnityEngine_Physics.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Physics.OverlapBox_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache11);
		if (Lua_UnityEngine_Physics.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Physics.OverlapBoxNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache12);
		if (Lua_UnityEngine_Physics.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Physics.BoxCastAll_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache13);
		if (Lua_UnityEngine_Physics.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Physics.BoxCastNonAlloc_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache14);
		if (Lua_UnityEngine_Physics.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Physics.BoxCast_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache15);
		if (Lua_UnityEngine_Physics.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Physics.IgnoreCollision_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache16);
		if (Lua_UnityEngine_Physics.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Physics.IgnoreLayerCollision_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache17);
		if (Lua_UnityEngine_Physics.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Physics.GetIgnoreLayerCollision_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache18);
		if (Lua_UnityEngine_Physics.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Physics.ComputePenetration_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache19);
		if (Lua_UnityEngine_Physics.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Physics.ClosestPoint_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache1A);
		if (Lua_UnityEngine_Physics.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Physics.Simulate_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache1B);
		if (Lua_UnityEngine_Physics.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Physics.SyncTransforms_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache1C);
		if (Lua_UnityEngine_Physics.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Physics.RebuildBroadphaseRegions_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Physics.<>f__mg$cache1D);
		string name = "IgnoreRaycastLayer";
		if (Lua_UnityEngine_Physics.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Physics.get_IgnoreRaycastLayer);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Physics.<>f__mg$cache1E, null, false);
		string name2 = "DefaultRaycastLayers";
		if (Lua_UnityEngine_Physics.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Physics.get_DefaultRaycastLayers);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Physics.<>f__mg$cache1F, null, false);
		string name3 = "AllLayers";
		if (Lua_UnityEngine_Physics.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Physics.get_AllLayers);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Physics.<>f__mg$cache20, null, false);
		string name4 = "gravity";
		if (Lua_UnityEngine_Physics.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Physics.get_gravity);
		}
		LuaCSFunction get = Lua_UnityEngine_Physics.<>f__mg$cache21;
		if (Lua_UnityEngine_Physics.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Physics.set_gravity);
		}
		LuaObject.addMember(l, name4, get, Lua_UnityEngine_Physics.<>f__mg$cache22, false);
		string name5 = "defaultContactOffset";
		if (Lua_UnityEngine_Physics.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Physics.get_defaultContactOffset);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Physics.<>f__mg$cache23;
		if (Lua_UnityEngine_Physics.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Physics.set_defaultContactOffset);
		}
		LuaObject.addMember(l, name5, get2, Lua_UnityEngine_Physics.<>f__mg$cache24, false);
		string name6 = "bounceThreshold";
		if (Lua_UnityEngine_Physics.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Physics.get_bounceThreshold);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Physics.<>f__mg$cache25;
		if (Lua_UnityEngine_Physics.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Physics.set_bounceThreshold);
		}
		LuaObject.addMember(l, name6, get3, Lua_UnityEngine_Physics.<>f__mg$cache26, false);
		string name7 = "defaultSolverIterations";
		if (Lua_UnityEngine_Physics.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Physics.get_defaultSolverIterations);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Physics.<>f__mg$cache27;
		if (Lua_UnityEngine_Physics.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Physics.set_defaultSolverIterations);
		}
		LuaObject.addMember(l, name7, get4, Lua_UnityEngine_Physics.<>f__mg$cache28, false);
		string name8 = "defaultSolverVelocityIterations";
		if (Lua_UnityEngine_Physics.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Physics.get_defaultSolverVelocityIterations);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Physics.<>f__mg$cache29;
		if (Lua_UnityEngine_Physics.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Physics.set_defaultSolverVelocityIterations);
		}
		LuaObject.addMember(l, name8, get5, Lua_UnityEngine_Physics.<>f__mg$cache2A, false);
		string name9 = "sleepThreshold";
		if (Lua_UnityEngine_Physics.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Physics.get_sleepThreshold);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Physics.<>f__mg$cache2B;
		if (Lua_UnityEngine_Physics.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Physics.set_sleepThreshold);
		}
		LuaObject.addMember(l, name9, get6, Lua_UnityEngine_Physics.<>f__mg$cache2C, false);
		string name10 = "queriesHitTriggers";
		if (Lua_UnityEngine_Physics.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Physics.get_queriesHitTriggers);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Physics.<>f__mg$cache2D;
		if (Lua_UnityEngine_Physics.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Physics.set_queriesHitTriggers);
		}
		LuaObject.addMember(l, name10, get7, Lua_UnityEngine_Physics.<>f__mg$cache2E, false);
		string name11 = "queriesHitBackfaces";
		if (Lua_UnityEngine_Physics.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Physics.get_queriesHitBackfaces);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Physics.<>f__mg$cache2F;
		if (Lua_UnityEngine_Physics.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Physics.set_queriesHitBackfaces);
		}
		LuaObject.addMember(l, name11, get8, Lua_UnityEngine_Physics.<>f__mg$cache30, false);
		string name12 = "interCollisionDistance";
		if (Lua_UnityEngine_Physics.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Physics.get_interCollisionDistance);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Physics.<>f__mg$cache31;
		if (Lua_UnityEngine_Physics.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Physics.set_interCollisionDistance);
		}
		LuaObject.addMember(l, name12, get9, Lua_UnityEngine_Physics.<>f__mg$cache32, false);
		string name13 = "interCollisionStiffness";
		if (Lua_UnityEngine_Physics.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Physics.get_interCollisionStiffness);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Physics.<>f__mg$cache33;
		if (Lua_UnityEngine_Physics.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Physics.set_interCollisionStiffness);
		}
		LuaObject.addMember(l, name13, get10, Lua_UnityEngine_Physics.<>f__mg$cache34, false);
		string name14 = "interCollisionSettingsToggle";
		if (Lua_UnityEngine_Physics.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Physics.get_interCollisionSettingsToggle);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Physics.<>f__mg$cache35;
		if (Lua_UnityEngine_Physics.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Physics.set_interCollisionSettingsToggle);
		}
		LuaObject.addMember(l, name14, get11, Lua_UnityEngine_Physics.<>f__mg$cache36, false);
		string name15 = "autoSimulation";
		if (Lua_UnityEngine_Physics.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Physics.get_autoSimulation);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Physics.<>f__mg$cache37;
		if (Lua_UnityEngine_Physics.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Physics.set_autoSimulation);
		}
		LuaObject.addMember(l, name15, get12, Lua_UnityEngine_Physics.<>f__mg$cache38, false);
		string name16 = "autoSyncTransforms";
		if (Lua_UnityEngine_Physics.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_Physics.get_autoSyncTransforms);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Physics.<>f__mg$cache39;
		if (Lua_UnityEngine_Physics.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_Physics.set_autoSyncTransforms);
		}
		LuaObject.addMember(l, name16, get13, Lua_UnityEngine_Physics.<>f__mg$cache3A, false);
		if (Lua_UnityEngine_Physics.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_Physics.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_Physics.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Physics.<>f__mg$cache3B, typeof(Physics));
	}

	// Token: 0x040194CD RID: 103629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040194CE RID: 103630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040194CF RID: 103631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040194D0 RID: 103632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040194D1 RID: 103633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040194D2 RID: 103634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040194D3 RID: 103635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040194D4 RID: 103636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040194D5 RID: 103637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040194D6 RID: 103638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040194D7 RID: 103639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040194D8 RID: 103640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040194D9 RID: 103641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040194DA RID: 103642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040194DB RID: 103643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040194DC RID: 103644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040194DD RID: 103645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040194DE RID: 103646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040194DF RID: 103647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040194E0 RID: 103648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040194E1 RID: 103649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040194E2 RID: 103650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040194E3 RID: 103651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040194E4 RID: 103652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040194E5 RID: 103653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040194E6 RID: 103654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040194E7 RID: 103655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040194E8 RID: 103656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040194E9 RID: 103657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040194EA RID: 103658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040194EB RID: 103659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040194EC RID: 103660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040194ED RID: 103661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040194EE RID: 103662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040194EF RID: 103663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040194F0 RID: 103664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040194F1 RID: 103665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040194F2 RID: 103666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040194F3 RID: 103667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040194F4 RID: 103668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040194F5 RID: 103669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040194F6 RID: 103670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040194F7 RID: 103671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040194F8 RID: 103672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040194F9 RID: 103673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040194FA RID: 103674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040194FB RID: 103675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040194FC RID: 103676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040194FD RID: 103677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040194FE RID: 103678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040194FF RID: 103679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04019500 RID: 103680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04019501 RID: 103681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04019502 RID: 103682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04019503 RID: 103683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04019504 RID: 103684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019505 RID: 103685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04019506 RID: 103686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04019507 RID: 103687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04019508 RID: 103688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;
}
