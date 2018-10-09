using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200165E RID: 5726
[Preserve]
public class Lua_UnityEngine_Collider2D : LuaObject
{
	// Token: 0x06022E5A RID: 142938 RVA: 0x00C1075C File Offset: 0x00C0E95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapCollider(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			ContactFilter2D contactFilter;
			LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter);
			Collider2D[] results;
			LuaObject.checkArray<Collider2D>(l, 3, out results);
			int i = collider2D.OverlapCollider(contactFilter, results);
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

	// Token: 0x06022E5B RID: 142939 RVA: 0x00C107CC File Offset: 0x00C0E9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Raycast(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction;
				LuaObject.checkType(l, 2, out direction);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results);
				int i = collider2D.Raycast(direction, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector2), typeof(RaycastHit2D[]), typeof(float)))
			{
				Collider2D collider2D2 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction2;
				LuaObject.checkType(l, 2, out direction2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results2);
				float distance;
				LuaObject.checkType(l, 4, out distance);
				int i2 = collider2D2.Raycast(direction2, results2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[])))
			{
				Collider2D collider2D3 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction3;
				LuaObject.checkType(l, 2, out direction3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter);
				RaycastHit2D[] results3;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results3);
				int i3 = collider2D3.Raycast(direction3, contactFilter, results3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector2), typeof(RaycastHit2D[]), typeof(float), typeof(int)))
			{
				Collider2D collider2D4 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction4;
				LuaObject.checkType(l, 2, out direction4);
				RaycastHit2D[] results4;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results4);
				float distance2;
				LuaObject.checkType(l, 4, out distance2);
				int layerMask;
				LuaObject.checkType(l, 5, out layerMask);
				int i4 = collider2D4.Raycast(direction4, results4, distance2, layerMask);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[]), typeof(float)))
			{
				Collider2D collider2D5 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction5;
				LuaObject.checkType(l, 2, out direction5);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter2);
				RaycastHit2D[] results5;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results5);
				float distance3;
				LuaObject.checkType(l, 5, out distance3);
				int i5 = collider2D5.Raycast(direction5, contactFilter2, results5, distance3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else if (num == 6)
			{
				Collider2D collider2D6 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction6;
				LuaObject.checkType(l, 2, out direction6);
				RaycastHit2D[] results6;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results6);
				float distance4;
				LuaObject.checkType(l, 4, out distance4);
				int layerMask2;
				LuaObject.checkType(l, 5, out layerMask2);
				float minDepth;
				LuaObject.checkType(l, 6, out minDepth);
				int i6 = collider2D6.Raycast(direction6, results6, distance4, layerMask2, minDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i6);
				result = 2;
			}
			else if (num == 7)
			{
				Collider2D collider2D7 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction7;
				LuaObject.checkType(l, 2, out direction7);
				RaycastHit2D[] results7;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results7);
				float distance5;
				LuaObject.checkType(l, 4, out distance5);
				int layerMask3;
				LuaObject.checkType(l, 5, out layerMask3);
				float minDepth2;
				LuaObject.checkType(l, 6, out minDepth2);
				float maxDepth;
				LuaObject.checkType(l, 7, out maxDepth);
				int i7 = collider2D7.Raycast(direction7, results7, distance5, layerMask3, minDepth2, maxDepth);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i7);
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

	// Token: 0x06022E5C RID: 142940 RVA: 0x00C10B7C File Offset: 0x00C0ED7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Cast(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction;
				LuaObject.checkType(l, 2, out direction);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results);
				int i = collider2D.Cast(direction, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector2), typeof(RaycastHit2D[]), typeof(float)))
			{
				Collider2D collider2D2 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction2;
				LuaObject.checkType(l, 2, out direction2);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results2);
				float distance;
				LuaObject.checkType(l, 4, out distance);
				int i2 = collider2D2.Cast(direction2, results2, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[])))
			{
				Collider2D collider2D3 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction3;
				LuaObject.checkType(l, 2, out direction3);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter);
				RaycastHit2D[] results3;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results3);
				int i3 = collider2D3.Cast(direction3, contactFilter, results3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[]), typeof(float)))
			{
				Collider2D collider2D4 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction4;
				LuaObject.checkType(l, 2, out direction4);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter2);
				RaycastHit2D[] results4;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results4);
				float distance2;
				LuaObject.checkType(l, 5, out distance2);
				int i4 = collider2D4.Cast(direction4, contactFilter2, results4, distance2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector2), typeof(RaycastHit2D[]), typeof(float), typeof(bool)))
			{
				Collider2D collider2D5 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction5;
				LuaObject.checkType(l, 2, out direction5);
				RaycastHit2D[] results5;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results5);
				float distance3;
				LuaObject.checkType(l, 4, out distance3);
				bool ignoreSiblingColliders;
				LuaObject.checkType(l, 5, out ignoreSiblingColliders);
				int i5 = collider2D5.Cast(direction5, results5, distance3, ignoreSiblingColliders);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i5);
				result = 2;
			}
			else if (num == 6)
			{
				Collider2D collider2D6 = (Collider2D)LuaObject.checkSelf(l);
				Vector2 direction6;
				LuaObject.checkType(l, 2, out direction6);
				ContactFilter2D contactFilter3;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter3);
				RaycastHit2D[] results6;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results6);
				float distance4;
				LuaObject.checkType(l, 5, out distance4);
				bool ignoreSiblingColliders2;
				LuaObject.checkType(l, 6, out ignoreSiblingColliders2);
				int i6 = collider2D6.Cast(direction6, contactFilter3, results6, distance4, ignoreSiblingColliders2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i6);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Cast to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E5D RID: 142941 RVA: 0x00C10EB0 File Offset: 0x00C0F0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetContacts(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(ContactPoint2D[])))
			{
				Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
				ContactPoint2D[] contacts;
				LuaObject.checkArray<ContactPoint2D>(l, 2, out contacts);
				int contacts2 = collider2D.GetContacts(contacts);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Collider2D[])))
			{
				Collider2D collider2D2 = (Collider2D)LuaObject.checkSelf(l);
				Collider2D[] colliders;
				LuaObject.checkArray<Collider2D>(l, 2, out colliders);
				int contacts3 = collider2D2.GetContacts(colliders);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts3);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ContactFilter2D), typeof(Collider2D[])))
			{
				Collider2D collider2D3 = (Collider2D)LuaObject.checkSelf(l);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter);
				Collider2D[] colliders2;
				LuaObject.checkArray<Collider2D>(l, 3, out colliders2);
				int contacts4 = collider2D3.GetContacts(contactFilter, colliders2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts4);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ContactFilter2D), typeof(ContactPoint2D[])))
			{
				Collider2D collider2D4 = (Collider2D)LuaObject.checkSelf(l);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter2);
				ContactPoint2D[] contacts5;
				LuaObject.checkArray<ContactPoint2D>(l, 3, out contacts5);
				int contacts6 = collider2D4.GetContacts(contactFilter2, contacts5);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts6);
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

	// Token: 0x06022E5E RID: 142942 RVA: 0x00C11074 File Offset: 0x00C0F274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTouching(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(Collider2D)))
			{
				Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
				Collider2D collider;
				LuaObject.checkType<Collider2D>(l, 2, out collider);
				bool b = collider2D.IsTouching(collider);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(ContactFilter2D)))
			{
				Collider2D collider2D2 = (Collider2D)LuaObject.checkSelf(l);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter);
				bool b2 = collider2D2.IsTouching(contactFilter);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (num == 3)
			{
				Collider2D collider2D3 = (Collider2D)LuaObject.checkSelf(l);
				Collider2D collider2;
				LuaObject.checkType<Collider2D>(l, 2, out collider2);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter2);
				bool b3 = collider2D3.IsTouching(collider2, contactFilter2);
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

	// Token: 0x06022E5F RID: 142943 RVA: 0x00C111B8 File Offset: 0x00C0F3B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTouchingLayers(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
				bool b = collider2D.IsTouchingLayers();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				Collider2D collider2D2 = (Collider2D)LuaObject.checkSelf(l);
				int layerMask;
				LuaObject.checkType(l, 2, out layerMask);
				bool b2 = collider2D2.IsTouchingLayers(layerMask);
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

	// Token: 0x06022E60 RID: 142944 RVA: 0x00C11274 File Offset: 0x00C0F474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapPoint(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			Vector2 point;
			LuaObject.checkType(l, 2, out point);
			bool b = collider2D.OverlapPoint(point);
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

	// Token: 0x06022E61 RID: 142945 RVA: 0x00C112D8 File Offset: 0x00C0F4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Distance(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			Collider2D collider;
			LuaObject.checkType<Collider2D>(l, 2, out collider);
			ColliderDistance2D colliderDistance2D = collider2D.Distance(collider);
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

	// Token: 0x06022E62 RID: 142946 RVA: 0x00C11340 File Offset: 0x00C0F540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_density(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.density);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E63 RID: 142947 RVA: 0x00C11394 File Offset: 0x00C0F594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_density(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			float density;
			LuaObject.checkType(l, 2, out density);
			collider2D.density = density;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E64 RID: 142948 RVA: 0x00C113EC File Offset: 0x00C0F5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isTrigger(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.isTrigger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E65 RID: 142949 RVA: 0x00C11440 File Offset: 0x00C0F640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isTrigger(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			bool isTrigger;
			LuaObject.checkType(l, 2, out isTrigger);
			collider2D.isTrigger = isTrigger;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E66 RID: 142950 RVA: 0x00C11498 File Offset: 0x00C0F698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_usedByEffector(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.usedByEffector);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E67 RID: 142951 RVA: 0x00C114EC File Offset: 0x00C0F6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_usedByEffector(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			bool usedByEffector;
			LuaObject.checkType(l, 2, out usedByEffector);
			collider2D.usedByEffector = usedByEffector;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E68 RID: 142952 RVA: 0x00C11544 File Offset: 0x00C0F744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_usedByComposite(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.usedByComposite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E69 RID: 142953 RVA: 0x00C11598 File Offset: 0x00C0F798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_usedByComposite(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			bool usedByComposite;
			LuaObject.checkType(l, 2, out usedByComposite);
			collider2D.usedByComposite = usedByComposite;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E6A RID: 142954 RVA: 0x00C115F0 File Offset: 0x00C0F7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_composite(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.composite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E6B RID: 142955 RVA: 0x00C11644 File Offset: 0x00C0F844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_offset(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.offset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E6C RID: 142956 RVA: 0x00C11698 File Offset: 0x00C0F898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_offset(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			Vector2 offset;
			LuaObject.checkType(l, 2, out offset);
			collider2D.offset = offset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E6D RID: 142957 RVA: 0x00C116F0 File Offset: 0x00C0F8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_attachedRigidbody(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.attachedRigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E6E RID: 142958 RVA: 0x00C11744 File Offset: 0x00C0F944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shapeCount(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.shapeCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E6F RID: 142959 RVA: 0x00C11798 File Offset: 0x00C0F998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounds(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.bounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E70 RID: 142960 RVA: 0x00C117F0 File Offset: 0x00C0F9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sharedMaterial(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.sharedMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E71 RID: 142961 RVA: 0x00C11844 File Offset: 0x00C0FA44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sharedMaterial(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			PhysicsMaterial2D sharedMaterial;
			LuaObject.checkType<PhysicsMaterial2D>(l, 2, out sharedMaterial);
			collider2D.sharedMaterial = sharedMaterial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E72 RID: 142962 RVA: 0x00C1189C File Offset: 0x00C0FA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_friction(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.friction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E73 RID: 142963 RVA: 0x00C118F0 File Offset: 0x00C0FAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounciness(IntPtr l)
	{
		int result;
		try
		{
			Collider2D collider2D = (Collider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider2D.bounciness);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E74 RID: 142964 RVA: 0x00C11944 File Offset: 0x00C0FB44
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Collider2D");
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Collider2D.OverlapCollider);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider2D.<>f__mg$cache0);
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Collider2D.Raycast);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider2D.<>f__mg$cache1);
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Collider2D.Cast);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider2D.<>f__mg$cache2);
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Collider2D.GetContacts);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider2D.<>f__mg$cache3);
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Collider2D.IsTouching);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider2D.<>f__mg$cache4);
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Collider2D.IsTouchingLayers);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider2D.<>f__mg$cache5);
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Collider2D.OverlapPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider2D.<>f__mg$cache6);
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Collider2D.Distance);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider2D.<>f__mg$cache7);
		string name = "density";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_density);
		}
		LuaCSFunction get = Lua_UnityEngine_Collider2D.<>f__mg$cache8;
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Collider2D.set_density);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Collider2D.<>f__mg$cache9, true);
		string name2 = "isTrigger";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_isTrigger);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Collider2D.<>f__mg$cacheA;
		if (Lua_UnityEngine_Collider2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Collider2D.set_isTrigger);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Collider2D.<>f__mg$cacheB, true);
		string name3 = "usedByEffector";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_usedByEffector);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Collider2D.<>f__mg$cacheC;
		if (Lua_UnityEngine_Collider2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Collider2D.set_usedByEffector);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Collider2D.<>f__mg$cacheD, true);
		string name4 = "usedByComposite";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_usedByComposite);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Collider2D.<>f__mg$cacheE;
		if (Lua_UnityEngine_Collider2D.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Collider2D.set_usedByComposite);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Collider2D.<>f__mg$cacheF, true);
		string name5 = "composite";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_composite);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Collider2D.<>f__mg$cache10, null, true);
		string name6 = "offset";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_offset);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Collider2D.<>f__mg$cache11;
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Collider2D.set_offset);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_Collider2D.<>f__mg$cache12, true);
		string name7 = "attachedRigidbody";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_attachedRigidbody);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Collider2D.<>f__mg$cache13, null, true);
		string name8 = "shapeCount";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_shapeCount);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Collider2D.<>f__mg$cache14, null, true);
		string name9 = "bounds";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_bounds);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Collider2D.<>f__mg$cache15, null, true);
		string name10 = "sharedMaterial";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_sharedMaterial);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Collider2D.<>f__mg$cache16;
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Collider2D.set_sharedMaterial);
		}
		LuaObject.addMember(l, name10, get6, Lua_UnityEngine_Collider2D.<>f__mg$cache17, true);
		string name11 = "friction";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_friction);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Collider2D.<>f__mg$cache18, null, true);
		string name12 = "bounciness";
		if (Lua_UnityEngine_Collider2D.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Collider2D.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Collider2D.get_bounciness);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_Collider2D.<>f__mg$cache19, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Collider2D), typeof(Behaviour));
	}

	// Token: 0x04018DFC RID: 101884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018DFD RID: 101885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018DFE RID: 101886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018DFF RID: 101887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E00 RID: 101888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E01 RID: 101889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E02 RID: 101890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E03 RID: 101891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018E04 RID: 101892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018E05 RID: 101893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018E06 RID: 101894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018E07 RID: 101895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018E08 RID: 101896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018E09 RID: 101897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018E0A RID: 101898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018E0B RID: 101899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018E0C RID: 101900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018E0D RID: 101901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018E0E RID: 101902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018E0F RID: 101903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018E10 RID: 101904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018E11 RID: 101905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018E12 RID: 101906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018E13 RID: 101907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018E14 RID: 101908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018E15 RID: 101909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
