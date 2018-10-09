using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017B7 RID: 6071
[Preserve]
public class Lua_UnityEngine_Rigidbody2D : LuaObject
{
	// Token: 0x06023C39 RID: 146489 RVA: 0x00C86790 File Offset: 0x00C84990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAttachedColliders(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Collider2D[] results;
			LuaObject.checkArray<Collider2D>(l, 2, out results);
			int attachedColliders = rigidbody2D.GetAttachedColliders(results);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, attachedColliders);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C3A RID: 146490 RVA: 0x00C867F4 File Offset: 0x00C849F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapCollider(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			ContactFilter2D contactFilter;
			LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter);
			Collider2D[] results;
			LuaObject.checkArray<Collider2D>(l, 3, out results);
			int i = rigidbody2D.OverlapCollider(contactFilter, results);
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

	// Token: 0x06023C3B RID: 146491 RVA: 0x00C86864 File Offset: 0x00C84A64
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
				Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
				Vector2 direction;
				LuaObject.checkType(l, 2, out direction);
				RaycastHit2D[] results;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results);
				int i = rigidbody2D.Cast(direction, results);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector2), typeof(ContactFilter2D), typeof(RaycastHit2D[])))
			{
				Rigidbody2D rigidbody2D2 = (Rigidbody2D)LuaObject.checkSelf(l);
				Vector2 direction2;
				LuaObject.checkType(l, 2, out direction2);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter);
				RaycastHit2D[] results2;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results2);
				int i2 = rigidbody2D2.Cast(direction2, contactFilter, results2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Vector2), typeof(RaycastHit2D[]), typeof(float)))
			{
				Rigidbody2D rigidbody2D3 = (Rigidbody2D)LuaObject.checkSelf(l);
				Vector2 direction3;
				LuaObject.checkType(l, 2, out direction3);
				RaycastHit2D[] results3;
				LuaObject.checkArray<RaycastHit2D>(l, 3, out results3);
				float distance;
				LuaObject.checkType(l, 4, out distance);
				int i3 = rigidbody2D3.Cast(direction3, results3, distance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else if (num == 5)
			{
				Rigidbody2D rigidbody2D4 = (Rigidbody2D)LuaObject.checkSelf(l);
				Vector2 direction4;
				LuaObject.checkType(l, 2, out direction4);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter2);
				RaycastHit2D[] results4;
				LuaObject.checkArray<RaycastHit2D>(l, 4, out results4);
				float distance2;
				LuaObject.checkType(l, 5, out distance2);
				int i4 = rigidbody2D4.Cast(direction4, contactFilter2, results4, distance2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i4);
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

	// Token: 0x06023C3C RID: 146492 RVA: 0x00C86A68 File Offset: 0x00C84C68
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
				Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
				ContactPoint2D[] contacts;
				LuaObject.checkArray<ContactPoint2D>(l, 2, out contacts);
				int contacts2 = rigidbody2D.GetContacts(contacts);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Collider2D[])))
			{
				Rigidbody2D rigidbody2D2 = (Rigidbody2D)LuaObject.checkSelf(l);
				Collider2D[] colliders;
				LuaObject.checkArray<Collider2D>(l, 2, out colliders);
				int contacts3 = rigidbody2D2.GetContacts(colliders);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts3);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ContactFilter2D), typeof(Collider2D[])))
			{
				Rigidbody2D rigidbody2D3 = (Rigidbody2D)LuaObject.checkSelf(l);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter);
				Collider2D[] colliders2;
				LuaObject.checkArray<Collider2D>(l, 3, out colliders2);
				int contacts4 = rigidbody2D3.GetContacts(contactFilter, colliders2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, contacts4);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ContactFilter2D), typeof(ContactPoint2D[])))
			{
				Rigidbody2D rigidbody2D4 = (Rigidbody2D)LuaObject.checkSelf(l);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter2);
				ContactPoint2D[] contacts5;
				LuaObject.checkArray<ContactPoint2D>(l, 3, out contacts5);
				int contacts6 = rigidbody2D4.GetContacts(contactFilter2, contacts5);
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

	// Token: 0x06023C3D RID: 146493 RVA: 0x00C86C2C File Offset: 0x00C84E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MovePosition(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			rigidbody2D.MovePosition(position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C3E RID: 146494 RVA: 0x00C86C84 File Offset: 0x00C84E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveRotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			float angle;
			LuaObject.checkType(l, 2, out angle);
			rigidbody2D.MoveRotation(angle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C3F RID: 146495 RVA: 0x00C86CDC File Offset: 0x00C84EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSleeping(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			bool b = rigidbody2D.IsSleeping();
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

	// Token: 0x06023C40 RID: 146496 RVA: 0x00C86D30 File Offset: 0x00C84F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAwake(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			bool b = rigidbody2D.IsAwake();
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

	// Token: 0x06023C41 RID: 146497 RVA: 0x00C86D84 File Offset: 0x00C84F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Sleep(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			rigidbody2D.Sleep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C42 RID: 146498 RVA: 0x00C86DD0 File Offset: 0x00C84FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WakeUp(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			rigidbody2D.WakeUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C43 RID: 146499 RVA: 0x00C86E1C File Offset: 0x00C8501C
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
				Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
				Collider2D collider;
				LuaObject.checkType<Collider2D>(l, 2, out collider);
				bool b = rigidbody2D.IsTouching(collider);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(ContactFilter2D)))
			{
				Rigidbody2D rigidbody2D2 = (Rigidbody2D)LuaObject.checkSelf(l);
				ContactFilter2D contactFilter;
				LuaObject.checkValueType<ContactFilter2D>(l, 2, out contactFilter);
				bool b2 = rigidbody2D2.IsTouching(contactFilter);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else if (num == 3)
			{
				Rigidbody2D rigidbody2D3 = (Rigidbody2D)LuaObject.checkSelf(l);
				Collider2D collider2;
				LuaObject.checkType<Collider2D>(l, 2, out collider2);
				ContactFilter2D contactFilter2;
				LuaObject.checkValueType<ContactFilter2D>(l, 3, out contactFilter2);
				bool b3 = rigidbody2D3.IsTouching(collider2, contactFilter2);
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

	// Token: 0x06023C44 RID: 146500 RVA: 0x00C86F60 File Offset: 0x00C85160
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
				Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
				bool b = rigidbody2D.IsTouchingLayers();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				Rigidbody2D rigidbody2D2 = (Rigidbody2D)LuaObject.checkSelf(l);
				int layerMask;
				LuaObject.checkType(l, 2, out layerMask);
				bool b2 = rigidbody2D2.IsTouchingLayers(layerMask);
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

	// Token: 0x06023C45 RID: 146501 RVA: 0x00C8701C File Offset: 0x00C8521C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverlapPoint(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 point;
			LuaObject.checkType(l, 2, out point);
			bool b = rigidbody2D.OverlapPoint(point);
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

	// Token: 0x06023C46 RID: 146502 RVA: 0x00C87080 File Offset: 0x00C85280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Distance(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Collider2D collider;
			LuaObject.checkType<Collider2D>(l, 2, out collider);
			ColliderDistance2D colliderDistance2D = rigidbody2D.Distance(collider);
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

	// Token: 0x06023C47 RID: 146503 RVA: 0x00C870E8 File Offset: 0x00C852E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddForce(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
				Vector2 force;
				LuaObject.checkType(l, 2, out force);
				rigidbody2D.AddForce(force);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Rigidbody2D rigidbody2D2 = (Rigidbody2D)LuaObject.checkSelf(l);
				Vector2 force2;
				LuaObject.checkType(l, 2, out force2);
				ForceMode2D mode;
				LuaObject.checkEnum<ForceMode2D>(l, 3, out mode);
				rigidbody2D2.AddForce(force2, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddForce to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C48 RID: 146504 RVA: 0x00C871AC File Offset: 0x00C853AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRelativeForce(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
				Vector2 relativeForce;
				LuaObject.checkType(l, 2, out relativeForce);
				rigidbody2D.AddRelativeForce(relativeForce);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Rigidbody2D rigidbody2D2 = (Rigidbody2D)LuaObject.checkSelf(l);
				Vector2 relativeForce2;
				LuaObject.checkType(l, 2, out relativeForce2);
				ForceMode2D mode;
				LuaObject.checkEnum<ForceMode2D>(l, 3, out mode);
				rigidbody2D2.AddRelativeForce(relativeForce2, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddRelativeForce to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C49 RID: 146505 RVA: 0x00C87270 File Offset: 0x00C85470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddForceAtPosition(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
				Vector2 force;
				LuaObject.checkType(l, 2, out force);
				Vector2 position;
				LuaObject.checkType(l, 3, out position);
				rigidbody2D.AddForceAtPosition(force, position);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Rigidbody2D rigidbody2D2 = (Rigidbody2D)LuaObject.checkSelf(l);
				Vector2 force2;
				LuaObject.checkType(l, 2, out force2);
				Vector2 position2;
				LuaObject.checkType(l, 3, out position2);
				ForceMode2D mode;
				LuaObject.checkEnum<ForceMode2D>(l, 4, out mode);
				rigidbody2D2.AddForceAtPosition(force2, position2, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddForceAtPosition to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C4A RID: 146506 RVA: 0x00C87350 File Offset: 0x00C85550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTorque(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
				float torque;
				LuaObject.checkType(l, 2, out torque);
				rigidbody2D.AddTorque(torque);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Rigidbody2D rigidbody2D2 = (Rigidbody2D)LuaObject.checkSelf(l);
				float torque2;
				LuaObject.checkType(l, 2, out torque2);
				ForceMode2D mode;
				LuaObject.checkEnum<ForceMode2D>(l, 3, out mode);
				rigidbody2D2.AddTorque(torque2, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddTorque to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C4B RID: 146507 RVA: 0x00C87414 File Offset: 0x00C85614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPoint(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 point;
			LuaObject.checkType(l, 2, out point);
			Vector2 point2 = rigidbody2D.GetPoint(point);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, point2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C4C RID: 146508 RVA: 0x00C87478 File Offset: 0x00C85678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRelativePoint(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 relativePoint;
			LuaObject.checkType(l, 2, out relativePoint);
			Vector2 relativePoint2 = rigidbody2D.GetRelativePoint(relativePoint);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, relativePoint2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C4D RID: 146509 RVA: 0x00C874DC File Offset: 0x00C856DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetVector(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 vector;
			LuaObject.checkType(l, 2, out vector);
			Vector2 vector2 = rigidbody2D.GetVector(vector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vector2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C4E RID: 146510 RVA: 0x00C87540 File Offset: 0x00C85740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRelativeVector(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 relativeVector;
			LuaObject.checkType(l, 2, out relativeVector);
			Vector2 relativeVector2 = rigidbody2D.GetRelativeVector(relativeVector);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, relativeVector2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C4F RID: 146511 RVA: 0x00C875A4 File Offset: 0x00C857A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPointVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 point;
			LuaObject.checkType(l, 2, out point);
			Vector2 pointVelocity = rigidbody2D.GetPointVelocity(point);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C50 RID: 146512 RVA: 0x00C87608 File Offset: 0x00C85808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRelativePointVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 relativePoint;
			LuaObject.checkType(l, 2, out relativePoint);
			Vector2 relativePointVelocity = rigidbody2D.GetRelativePointVelocity(relativePoint);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, relativePointVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C51 RID: 146513 RVA: 0x00C8766C File Offset: 0x00C8586C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C52 RID: 146514 RVA: 0x00C876C0 File Offset: 0x00C858C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			rigidbody2D.position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C53 RID: 146515 RVA: 0x00C87718 File Offset: 0x00C85918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.rotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C54 RID: 146516 RVA: 0x00C8776C File Offset: 0x00C8596C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			float rotation;
			LuaObject.checkType(l, 2, out rotation);
			rigidbody2D.rotation = rotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C55 RID: 146517 RVA: 0x00C877C4 File Offset: 0x00C859C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_velocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.velocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C56 RID: 146518 RVA: 0x00C87818 File Offset: 0x00C85A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_velocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 velocity;
			LuaObject.checkType(l, 2, out velocity);
			rigidbody2D.velocity = velocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C57 RID: 146519 RVA: 0x00C87870 File Offset: 0x00C85A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.angularVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C58 RID: 146520 RVA: 0x00C878C4 File Offset: 0x00C85AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			float angularVelocity;
			LuaObject.checkType(l, 2, out angularVelocity);
			rigidbody2D.angularVelocity = angularVelocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C59 RID: 146521 RVA: 0x00C8791C File Offset: 0x00C85B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useAutoMass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.useAutoMass);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C5A RID: 146522 RVA: 0x00C87970 File Offset: 0x00C85B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useAutoMass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			bool useAutoMass;
			LuaObject.checkType(l, 2, out useAutoMass);
			rigidbody2D.useAutoMass = useAutoMass;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C5B RID: 146523 RVA: 0x00C879C8 File Offset: 0x00C85BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.mass);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C5C RID: 146524 RVA: 0x00C87A1C File Offset: 0x00C85C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			float mass;
			LuaObject.checkType(l, 2, out mass);
			rigidbody2D.mass = mass;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C5D RID: 146525 RVA: 0x00C87A74 File Offset: 0x00C85C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sharedMaterial(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.sharedMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C5E RID: 146526 RVA: 0x00C87AC8 File Offset: 0x00C85CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sharedMaterial(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			PhysicsMaterial2D sharedMaterial;
			LuaObject.checkType<PhysicsMaterial2D>(l, 2, out sharedMaterial);
			rigidbody2D.sharedMaterial = sharedMaterial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C5F RID: 146527 RVA: 0x00C87B20 File Offset: 0x00C85D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_centerOfMass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.centerOfMass);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C60 RID: 146528 RVA: 0x00C87B74 File Offset: 0x00C85D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_centerOfMass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			Vector2 centerOfMass;
			LuaObject.checkType(l, 2, out centerOfMass);
			rigidbody2D.centerOfMass = centerOfMass;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C61 RID: 146529 RVA: 0x00C87BCC File Offset: 0x00C85DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_worldCenterOfMass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.worldCenterOfMass);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C62 RID: 146530 RVA: 0x00C87C20 File Offset: 0x00C85E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inertia(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.inertia);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C63 RID: 146531 RVA: 0x00C87C74 File Offset: 0x00C85E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_inertia(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			float inertia;
			LuaObject.checkType(l, 2, out inertia);
			rigidbody2D.inertia = inertia;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C64 RID: 146532 RVA: 0x00C87CCC File Offset: 0x00C85ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_drag(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.drag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C65 RID: 146533 RVA: 0x00C87D20 File Offset: 0x00C85F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_drag(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			float drag;
			LuaObject.checkType(l, 2, out drag);
			rigidbody2D.drag = drag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C66 RID: 146534 RVA: 0x00C87D78 File Offset: 0x00C85F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularDrag(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.angularDrag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C67 RID: 146535 RVA: 0x00C87DCC File Offset: 0x00C85FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularDrag(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			float angularDrag;
			LuaObject.checkType(l, 2, out angularDrag);
			rigidbody2D.angularDrag = angularDrag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C68 RID: 146536 RVA: 0x00C87E24 File Offset: 0x00C86024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_gravityScale(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.gravityScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C69 RID: 146537 RVA: 0x00C87E78 File Offset: 0x00C86078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_gravityScale(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			float gravityScale;
			LuaObject.checkType(l, 2, out gravityScale);
			rigidbody2D.gravityScale = gravityScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C6A RID: 146538 RVA: 0x00C87ED0 File Offset: 0x00C860D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bodyType(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rigidbody2D.bodyType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C6B RID: 146539 RVA: 0x00C87F24 File Offset: 0x00C86124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bodyType(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			RigidbodyType2D bodyType;
			LuaObject.checkEnum<RigidbodyType2D>(l, 2, out bodyType);
			rigidbody2D.bodyType = bodyType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C6C RID: 146540 RVA: 0x00C87F7C File Offset: 0x00C8617C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useFullKinematicContacts(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.useFullKinematicContacts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C6D RID: 146541 RVA: 0x00C87FD0 File Offset: 0x00C861D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_useFullKinematicContacts(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			bool useFullKinematicContacts;
			LuaObject.checkType(l, 2, out useFullKinematicContacts);
			rigidbody2D.useFullKinematicContacts = useFullKinematicContacts;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C6E RID: 146542 RVA: 0x00C88028 File Offset: 0x00C86228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isKinematic(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.isKinematic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C6F RID: 146543 RVA: 0x00C8807C File Offset: 0x00C8627C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isKinematic(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			bool isKinematic;
			LuaObject.checkType(l, 2, out isKinematic);
			rigidbody2D.isKinematic = isKinematic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C70 RID: 146544 RVA: 0x00C880D4 File Offset: 0x00C862D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_freezeRotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.freezeRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C71 RID: 146545 RVA: 0x00C88128 File Offset: 0x00C86328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_freezeRotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			bool freezeRotation;
			LuaObject.checkType(l, 2, out freezeRotation);
			rigidbody2D.freezeRotation = freezeRotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C72 RID: 146546 RVA: 0x00C88180 File Offset: 0x00C86380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_constraints(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rigidbody2D.constraints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C73 RID: 146547 RVA: 0x00C881D4 File Offset: 0x00C863D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_constraints(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			RigidbodyConstraints2D constraints;
			LuaObject.checkEnum<RigidbodyConstraints2D>(l, 2, out constraints);
			rigidbody2D.constraints = constraints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C74 RID: 146548 RVA: 0x00C8822C File Offset: 0x00C8642C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_simulated(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.simulated);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C75 RID: 146549 RVA: 0x00C88280 File Offset: 0x00C86480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_simulated(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			bool simulated;
			LuaObject.checkType(l, 2, out simulated);
			rigidbody2D.simulated = simulated;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C76 RID: 146550 RVA: 0x00C882D8 File Offset: 0x00C864D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_interpolation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rigidbody2D.interpolation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C77 RID: 146551 RVA: 0x00C8832C File Offset: 0x00C8652C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_interpolation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			RigidbodyInterpolation2D interpolation;
			LuaObject.checkEnum<RigidbodyInterpolation2D>(l, 2, out interpolation);
			rigidbody2D.interpolation = interpolation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C78 RID: 146552 RVA: 0x00C88384 File Offset: 0x00C86584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sleepMode(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rigidbody2D.sleepMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C79 RID: 146553 RVA: 0x00C883D8 File Offset: 0x00C865D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sleepMode(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			RigidbodySleepMode2D sleepMode;
			LuaObject.checkEnum<RigidbodySleepMode2D>(l, 2, out sleepMode);
			rigidbody2D.sleepMode = sleepMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C7A RID: 146554 RVA: 0x00C88430 File Offset: 0x00C86630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_collisionDetectionMode(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rigidbody2D.collisionDetectionMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C7B RID: 146555 RVA: 0x00C88484 File Offset: 0x00C86684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_collisionDetectionMode(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			CollisionDetectionMode2D collisionDetectionMode;
			LuaObject.checkEnum<CollisionDetectionMode2D>(l, 2, out collisionDetectionMode);
			rigidbody2D.collisionDetectionMode = collisionDetectionMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C7C RID: 146556 RVA: 0x00C884DC File Offset: 0x00C866DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_attachedColliderCount(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody2D.attachedColliderCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C7D RID: 146557 RVA: 0x00C88530 File Offset: 0x00C86730
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rigidbody2D");
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.GetAttachedColliders);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache0);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.OverlapCollider);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.Cast);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.GetContacts);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.MovePosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache4);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.MoveRotation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache5);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.IsSleeping);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache6);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.IsAwake);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache7);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.Sleep);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache8);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.WakeUp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache9);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.IsTouching);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheA);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.IsTouchingLayers);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheB);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.OverlapPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheC);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.Distance);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheD);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.AddForce);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheE);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.AddRelativeForce);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cacheF);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.AddForceAtPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache10);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.AddTorque);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache11);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.GetPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache12);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.GetRelativePoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache13);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.GetVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache14);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.GetRelativeVector);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache15);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.GetPointVelocity);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache16);
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.GetRelativePointVelocity);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache17);
		string name = "position";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_position);
		}
		LuaCSFunction get = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache18;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_position);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache19, true);
		string name2 = "rotation";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_rotation);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1A;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_rotation);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1B, true);
		string name3 = "velocity";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_velocity);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1C;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_velocity);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1D, true);
		string name4 = "angularVelocity";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_angularVelocity);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1E;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_angularVelocity);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache1F, true);
		string name5 = "useAutoMass";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_useAutoMass);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache20;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_useAutoMass);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache21, true);
		string name6 = "mass";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_mass);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache22;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_mass);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache23, true);
		string name7 = "sharedMaterial";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_sharedMaterial);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache24;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_sharedMaterial);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache25, true);
		string name8 = "centerOfMass";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_centerOfMass);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache26;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_centerOfMass);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache27, true);
		string name9 = "worldCenterOfMass";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_worldCenterOfMass);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache28, null, true);
		string name10 = "inertia";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_inertia);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache29;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_inertia);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2A, true);
		string name11 = "drag";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_drag);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2B;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_drag);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2C, true);
		string name12 = "angularDrag";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_angularDrag);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2D;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_angularDrag);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2E, true);
		string name13 = "gravityScale";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_gravityScale);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache2F;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_gravityScale);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache30, true);
		string name14 = "bodyType";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_bodyType);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache31;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_bodyType);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache32, true);
		string name15 = "useFullKinematicContacts";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_useFullKinematicContacts);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache33;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_useFullKinematicContacts);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache34, true);
		string name16 = "isKinematic";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_isKinematic);
		}
		LuaCSFunction get15 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache35;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_isKinematic);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache36, true);
		string name17 = "freezeRotation";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_freezeRotation);
		}
		LuaCSFunction get16 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache37;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_freezeRotation);
		}
		LuaObject.addMember(l, name17, get16, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache38, true);
		string name18 = "constraints";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_constraints);
		}
		LuaCSFunction get17 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache39;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_constraints);
		}
		LuaObject.addMember(l, name18, get17, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3A, true);
		string name19 = "simulated";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_simulated);
		}
		LuaCSFunction get18 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3B;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3C == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3C = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_simulated);
		}
		LuaObject.addMember(l, name19, get18, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3C, true);
		string name20 = "interpolation";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3D == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3D = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_interpolation);
		}
		LuaCSFunction get19 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3D;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3E == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3E = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_interpolation);
		}
		LuaObject.addMember(l, name20, get19, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3E, true);
		string name21 = "sleepMode";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3F == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3F = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_sleepMode);
		}
		LuaCSFunction get20 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache3F;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache40 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache40 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_sleepMode);
		}
		LuaObject.addMember(l, name21, get20, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache40, true);
		string name22 = "collisionDetectionMode";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache41 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache41 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_collisionDetectionMode);
		}
		LuaCSFunction get21 = Lua_UnityEngine_Rigidbody2D.<>f__mg$cache41;
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache42 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache42 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.set_collisionDetectionMode);
		}
		LuaObject.addMember(l, name22, get21, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache42, true);
		string name23 = "attachedColliderCount";
		if (Lua_UnityEngine_Rigidbody2D.<>f__mg$cache43 == null)
		{
			Lua_UnityEngine_Rigidbody2D.<>f__mg$cache43 = new LuaCSFunction(Lua_UnityEngine_Rigidbody2D.get_attachedColliderCount);
		}
		LuaObject.addMember(l, name23, Lua_UnityEngine_Rigidbody2D.<>f__mg$cache43, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Rigidbody2D), typeof(Component));
	}

	// Token: 0x04019929 RID: 104745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401992A RID: 104746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401992B RID: 104747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401992C RID: 104748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401992D RID: 104749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401992E RID: 104750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401992F RID: 104751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019930 RID: 104752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019931 RID: 104753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019932 RID: 104754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019933 RID: 104755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019934 RID: 104756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019935 RID: 104757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019936 RID: 104758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019937 RID: 104759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019938 RID: 104760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019939 RID: 104761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401993A RID: 104762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401993B RID: 104763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401993C RID: 104764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401993D RID: 104765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401993E RID: 104766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401993F RID: 104767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019940 RID: 104768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019941 RID: 104769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019942 RID: 104770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019943 RID: 104771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019944 RID: 104772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019945 RID: 104773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019946 RID: 104774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019947 RID: 104775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019948 RID: 104776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019949 RID: 104777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401994A RID: 104778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401994B RID: 104779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401994C RID: 104780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401994D RID: 104781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401994E RID: 104782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401994F RID: 104783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019950 RID: 104784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019951 RID: 104785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019952 RID: 104786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019953 RID: 104787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019954 RID: 104788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019955 RID: 104789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019956 RID: 104790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019957 RID: 104791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019958 RID: 104792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019959 RID: 104793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401995A RID: 104794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401995B RID: 104795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401995C RID: 104796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401995D RID: 104797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401995E RID: 104798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401995F RID: 104799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04019960 RID: 104800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019961 RID: 104801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04019962 RID: 104802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04019963 RID: 104803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04019964 RID: 104804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04019965 RID: 104805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04019966 RID: 104806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04019967 RID: 104807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04019968 RID: 104808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04019969 RID: 104809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401996A RID: 104810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401996B RID: 104811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401996C RID: 104812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;
}
