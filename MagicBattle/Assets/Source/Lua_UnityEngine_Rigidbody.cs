using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017B6 RID: 6070
[Preserve]
public class Lua_UnityEngine_Rigidbody : LuaObject
{
	// Token: 0x06023BF7 RID: 146423 RVA: 0x00C840E8 File Offset: 0x00C822E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDensity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			float density;
			LuaObject.checkType(l, 2, out density);
			rigidbody.SetDensity(density);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BF8 RID: 146424 RVA: 0x00C84140 File Offset: 0x00C82340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddForce(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 force;
				LuaObject.checkType(l, 2, out force);
				ForceMode mode;
				LuaObject.checkEnum<ForceMode>(l, 3, out mode);
				rigidbody.AddForce(force, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				Rigidbody rigidbody2 = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 force2;
				LuaObject.checkType(l, 2, out force2);
				rigidbody2.AddForce(force2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Rigidbody rigidbody3 = (Rigidbody)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				rigidbody3.AddForce(x, y, z);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Rigidbody rigidbody4 = (Rigidbody)LuaObject.checkSelf(l);
				float x2;
				LuaObject.checkType(l, 2, out x2);
				float y2;
				LuaObject.checkType(l, 3, out y2);
				float z2;
				LuaObject.checkType(l, 4, out z2);
				ForceMode mode2;
				LuaObject.checkEnum<ForceMode>(l, 5, out mode2);
				rigidbody4.AddForce(x2, y2, z2, mode2);
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

	// Token: 0x06023BF9 RID: 146425 RVA: 0x00C842BC File Offset: 0x00C824BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddRelativeForce(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 force;
				LuaObject.checkType(l, 2, out force);
				ForceMode mode;
				LuaObject.checkEnum<ForceMode>(l, 3, out mode);
				rigidbody.AddRelativeForce(force, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				Rigidbody rigidbody2 = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 force2;
				LuaObject.checkType(l, 2, out force2);
				rigidbody2.AddRelativeForce(force2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Rigidbody rigidbody3 = (Rigidbody)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				rigidbody3.AddRelativeForce(x, y, z);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Rigidbody rigidbody4 = (Rigidbody)LuaObject.checkSelf(l);
				float x2;
				LuaObject.checkType(l, 2, out x2);
				float y2;
				LuaObject.checkType(l, 3, out y2);
				float z2;
				LuaObject.checkType(l, 4, out z2);
				ForceMode mode2;
				LuaObject.checkEnum<ForceMode>(l, 5, out mode2);
				rigidbody4.AddRelativeForce(x2, y2, z2, mode2);
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

	// Token: 0x06023BFA RID: 146426 RVA: 0x00C84438 File Offset: 0x00C82638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTorque(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 torque;
				LuaObject.checkType(l, 2, out torque);
				ForceMode mode;
				LuaObject.checkEnum<ForceMode>(l, 3, out mode);
				rigidbody.AddTorque(torque, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				Rigidbody rigidbody2 = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 torque2;
				LuaObject.checkType(l, 2, out torque2);
				rigidbody2.AddTorque(torque2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Rigidbody rigidbody3 = (Rigidbody)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				rigidbody3.AddTorque(x, y, z);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Rigidbody rigidbody4 = (Rigidbody)LuaObject.checkSelf(l);
				float x2;
				LuaObject.checkType(l, 2, out x2);
				float y2;
				LuaObject.checkType(l, 3, out y2);
				float z2;
				LuaObject.checkType(l, 4, out z2);
				ForceMode mode2;
				LuaObject.checkEnum<ForceMode>(l, 5, out mode2);
				rigidbody4.AddTorque(x2, y2, z2, mode2);
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

	// Token: 0x06023BFB RID: 146427 RVA: 0x00C845B4 File Offset: 0x00C827B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRelativeTorque(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 torque;
				LuaObject.checkType(l, 2, out torque);
				ForceMode mode;
				LuaObject.checkEnum<ForceMode>(l, 3, out mode);
				rigidbody.AddRelativeTorque(torque, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				Rigidbody rigidbody2 = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 torque2;
				LuaObject.checkType(l, 2, out torque2);
				rigidbody2.AddRelativeTorque(torque2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Rigidbody rigidbody3 = (Rigidbody)LuaObject.checkSelf(l);
				float x;
				LuaObject.checkType(l, 2, out x);
				float y;
				LuaObject.checkType(l, 3, out y);
				float z;
				LuaObject.checkType(l, 4, out z);
				rigidbody3.AddRelativeTorque(x, y, z);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Rigidbody rigidbody4 = (Rigidbody)LuaObject.checkSelf(l);
				float x2;
				LuaObject.checkType(l, 2, out x2);
				float y2;
				LuaObject.checkType(l, 3, out y2);
				float z2;
				LuaObject.checkType(l, 4, out z2);
				ForceMode mode2;
				LuaObject.checkEnum<ForceMode>(l, 5, out mode2);
				rigidbody4.AddRelativeTorque(x2, y2, z2, mode2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddRelativeTorque to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BFC RID: 146428 RVA: 0x00C84730 File Offset: 0x00C82930
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddForceAtPosition(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 force;
				LuaObject.checkType(l, 2, out force);
				Vector3 position;
				LuaObject.checkType(l, 3, out position);
				rigidbody.AddForceAtPosition(force, position);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Rigidbody rigidbody2 = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 force2;
				LuaObject.checkType(l, 2, out force2);
				Vector3 position2;
				LuaObject.checkType(l, 3, out position2);
				ForceMode mode;
				LuaObject.checkEnum<ForceMode>(l, 4, out mode);
				rigidbody2.AddForceAtPosition(force2, position2, mode);
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

	// Token: 0x06023BFD RID: 146429 RVA: 0x00C84810 File Offset: 0x00C82A10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddExplosionForce(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
				float explosionForce;
				LuaObject.checkType(l, 2, out explosionForce);
				Vector3 explosionPosition;
				LuaObject.checkType(l, 3, out explosionPosition);
				float explosionRadius;
				LuaObject.checkType(l, 4, out explosionRadius);
				rigidbody.AddExplosionForce(explosionForce, explosionPosition, explosionRadius);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Rigidbody rigidbody2 = (Rigidbody)LuaObject.checkSelf(l);
				float explosionForce2;
				LuaObject.checkType(l, 2, out explosionForce2);
				Vector3 explosionPosition2;
				LuaObject.checkType(l, 3, out explosionPosition2);
				float explosionRadius2;
				LuaObject.checkType(l, 4, out explosionRadius2);
				float upwardsModifier;
				LuaObject.checkType(l, 5, out upwardsModifier);
				rigidbody2.AddExplosionForce(explosionForce2, explosionPosition2, explosionRadius2, upwardsModifier);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				Rigidbody rigidbody3 = (Rigidbody)LuaObject.checkSelf(l);
				float explosionForce3;
				LuaObject.checkType(l, 2, out explosionForce3);
				Vector3 explosionPosition3;
				LuaObject.checkType(l, 3, out explosionPosition3);
				float explosionRadius3;
				LuaObject.checkType(l, 4, out explosionRadius3);
				float upwardsModifier2;
				LuaObject.checkType(l, 5, out upwardsModifier2);
				ForceMode mode;
				LuaObject.checkEnum<ForceMode>(l, 6, out mode);
				rigidbody3.AddExplosionForce(explosionForce3, explosionPosition3, explosionRadius3, upwardsModifier2, mode);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddExplosionForce to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023BFE RID: 146430 RVA: 0x00C84978 File Offset: 0x00C82B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosestPointOnBounds(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Vector3 o = rigidbody.ClosestPointOnBounds(position);
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

	// Token: 0x06023BFF RID: 146431 RVA: 0x00C849DC File Offset: 0x00C82BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRelativePointVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Vector3 relativePoint;
			LuaObject.checkType(l, 2, out relativePoint);
			Vector3 relativePointVelocity = rigidbody.GetRelativePointVelocity(relativePoint);
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

	// Token: 0x06023C00 RID: 146432 RVA: 0x00C84A40 File Offset: 0x00C82C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPointVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Vector3 worldPoint;
			LuaObject.checkType(l, 2, out worldPoint);
			Vector3 pointVelocity = rigidbody.GetPointVelocity(worldPoint);
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

	// Token: 0x06023C01 RID: 146433 RVA: 0x00C84AA4 File Offset: 0x00C82CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MovePosition(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			rigidbody.MovePosition(position);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C02 RID: 146434 RVA: 0x00C84AFC File Offset: 0x00C82CFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MoveRotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Quaternion rot;
			LuaObject.checkType(l, 2, out rot);
			rigidbody.MoveRotation(rot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C03 RID: 146435 RVA: 0x00C84B54 File Offset: 0x00C82D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Sleep(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			rigidbody.Sleep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C04 RID: 146436 RVA: 0x00C84BA0 File Offset: 0x00C82DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSleeping(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			bool b = rigidbody.IsSleeping();
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

	// Token: 0x06023C05 RID: 146437 RVA: 0x00C84BF4 File Offset: 0x00C82DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WakeUp(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			rigidbody.WakeUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C06 RID: 146438 RVA: 0x00C84C40 File Offset: 0x00C82E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetCenterOfMass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			rigidbody.ResetCenterOfMass();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C07 RID: 146439 RVA: 0x00C84C8C File Offset: 0x00C82E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetInertiaTensor(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			rigidbody.ResetInertiaTensor();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C08 RID: 146440 RVA: 0x00C84CD8 File Offset: 0x00C82ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SweepTest(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 direction;
				LuaObject.checkType(l, 2, out direction);
				RaycastHit r;
				bool b = rigidbody.SweepTest(direction, out r);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				LuaObject.pushValue(l, r);
				result = 3;
			}
			else if (num == 4)
			{
				Rigidbody rigidbody2 = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 direction2;
				LuaObject.checkType(l, 2, out direction2);
				float maxDistance;
				LuaObject.checkType(l, 4, out maxDistance);
				RaycastHit r2;
				bool b2 = rigidbody2.SweepTest(direction2, out r2, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				LuaObject.pushValue(l, r2);
				result = 3;
			}
			else if (num == 5)
			{
				Rigidbody rigidbody3 = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 direction3;
				LuaObject.checkType(l, 2, out direction3);
				float maxDistance2;
				LuaObject.checkType(l, 4, out maxDistance2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 5, out queryTriggerInteraction);
				RaycastHit r3;
				bool b3 = rigidbody3.SweepTest(direction3, out r3, maxDistance2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b3);
				LuaObject.pushValue(l, r3);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SweepTest to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C09 RID: 146441 RVA: 0x00C84E34 File Offset: 0x00C83034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SweepTestAll(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 direction;
				LuaObject.checkType(l, 2, out direction);
				RaycastHit[] a = rigidbody.SweepTestAll(direction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 3)
			{
				Rigidbody rigidbody2 = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 direction2;
				LuaObject.checkType(l, 2, out direction2);
				float maxDistance;
				LuaObject.checkType(l, 3, out maxDistance);
				RaycastHit[] a2 = rigidbody2.SweepTestAll(direction2, maxDistance);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 4)
			{
				Rigidbody rigidbody3 = (Rigidbody)LuaObject.checkSelf(l);
				Vector3 direction3;
				LuaObject.checkType(l, 2, out direction3);
				float maxDistance2;
				LuaObject.checkType(l, 3, out maxDistance2);
				QueryTriggerInteraction queryTriggerInteraction;
				LuaObject.checkEnum<QueryTriggerInteraction>(l, 4, out queryTriggerInteraction);
				RaycastHit[] a3 = rigidbody3.SweepTestAll(direction3, maxDistance2, queryTriggerInteraction);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SweepTestAll to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C0A RID: 146442 RVA: 0x00C84F70 File Offset: 0x00C83170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_velocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.velocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C0B RID: 146443 RVA: 0x00C84FC4 File Offset: 0x00C831C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_velocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Vector3 velocity;
			LuaObject.checkType(l, 2, out velocity);
			rigidbody.velocity = velocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C0C RID: 146444 RVA: 0x00C8501C File Offset: 0x00C8321C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_angularVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.angularVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C0D RID: 146445 RVA: 0x00C85070 File Offset: 0x00C83270
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_angularVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Vector3 angularVelocity;
			LuaObject.checkType(l, 2, out angularVelocity);
			rigidbody.angularVelocity = angularVelocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C0E RID: 146446 RVA: 0x00C850C8 File Offset: 0x00C832C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_drag(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.drag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C0F RID: 146447 RVA: 0x00C8511C File Offset: 0x00C8331C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_drag(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			float drag;
			LuaObject.checkType(l, 2, out drag);
			rigidbody.drag = drag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C10 RID: 146448 RVA: 0x00C85174 File Offset: 0x00C83374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_angularDrag(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.angularDrag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C11 RID: 146449 RVA: 0x00C851C8 File Offset: 0x00C833C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_angularDrag(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			float angularDrag;
			LuaObject.checkType(l, 2, out angularDrag);
			rigidbody.angularDrag = angularDrag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C12 RID: 146450 RVA: 0x00C85220 File Offset: 0x00C83420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.mass);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C13 RID: 146451 RVA: 0x00C85274 File Offset: 0x00C83474
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_mass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			float mass;
			LuaObject.checkType(l, 2, out mass);
			rigidbody.mass = mass;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C14 RID: 146452 RVA: 0x00C852CC File Offset: 0x00C834CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_useGravity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.useGravity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C15 RID: 146453 RVA: 0x00C85320 File Offset: 0x00C83520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_useGravity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			bool useGravity;
			LuaObject.checkType(l, 2, out useGravity);
			rigidbody.useGravity = useGravity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C16 RID: 146454 RVA: 0x00C85378 File Offset: 0x00C83578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_maxDepenetrationVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.maxDepenetrationVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C17 RID: 146455 RVA: 0x00C853CC File Offset: 0x00C835CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_maxDepenetrationVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			float maxDepenetrationVelocity;
			LuaObject.checkType(l, 2, out maxDepenetrationVelocity);
			rigidbody.maxDepenetrationVelocity = maxDepenetrationVelocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C18 RID: 146456 RVA: 0x00C85424 File Offset: 0x00C83624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isKinematic(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.isKinematic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C19 RID: 146457 RVA: 0x00C85478 File Offset: 0x00C83678
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_isKinematic(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			bool isKinematic;
			LuaObject.checkType(l, 2, out isKinematic);
			rigidbody.isKinematic = isKinematic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C1A RID: 146458 RVA: 0x00C854D0 File Offset: 0x00C836D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_freezeRotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.freezeRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C1B RID: 146459 RVA: 0x00C85524 File Offset: 0x00C83724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_freezeRotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			bool freezeRotation;
			LuaObject.checkType(l, 2, out freezeRotation);
			rigidbody.freezeRotation = freezeRotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C1C RID: 146460 RVA: 0x00C8557C File Offset: 0x00C8377C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_constraints(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rigidbody.constraints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C1D RID: 146461 RVA: 0x00C855D0 File Offset: 0x00C837D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_constraints(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			RigidbodyConstraints constraints;
			LuaObject.checkEnum<RigidbodyConstraints>(l, 2, out constraints);
			rigidbody.constraints = constraints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C1E RID: 146462 RVA: 0x00C85628 File Offset: 0x00C83828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_collisionDetectionMode(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rigidbody.collisionDetectionMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C1F RID: 146463 RVA: 0x00C8567C File Offset: 0x00C8387C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_collisionDetectionMode(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			CollisionDetectionMode collisionDetectionMode;
			LuaObject.checkEnum<CollisionDetectionMode>(l, 2, out collisionDetectionMode);
			rigidbody.collisionDetectionMode = collisionDetectionMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C20 RID: 146464 RVA: 0x00C856D4 File Offset: 0x00C838D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_centerOfMass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.centerOfMass);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C21 RID: 146465 RVA: 0x00C85728 File Offset: 0x00C83928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_centerOfMass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Vector3 centerOfMass;
			LuaObject.checkType(l, 2, out centerOfMass);
			rigidbody.centerOfMass = centerOfMass;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C22 RID: 146466 RVA: 0x00C85780 File Offset: 0x00C83980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_worldCenterOfMass(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.worldCenterOfMass);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C23 RID: 146467 RVA: 0x00C857D4 File Offset: 0x00C839D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inertiaTensorRotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.inertiaTensorRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C24 RID: 146468 RVA: 0x00C85828 File Offset: 0x00C83A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_inertiaTensorRotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Quaternion inertiaTensorRotation;
			LuaObject.checkType(l, 2, out inertiaTensorRotation);
			rigidbody.inertiaTensorRotation = inertiaTensorRotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C25 RID: 146469 RVA: 0x00C85880 File Offset: 0x00C83A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inertiaTensor(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.inertiaTensor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C26 RID: 146470 RVA: 0x00C858D4 File Offset: 0x00C83AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_inertiaTensor(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Vector3 inertiaTensor;
			LuaObject.checkType(l, 2, out inertiaTensor);
			rigidbody.inertiaTensor = inertiaTensor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C27 RID: 146471 RVA: 0x00C8592C File Offset: 0x00C83B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_detectCollisions(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.detectCollisions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C28 RID: 146472 RVA: 0x00C85980 File Offset: 0x00C83B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_detectCollisions(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			bool detectCollisions;
			LuaObject.checkType(l, 2, out detectCollisions);
			rigidbody.detectCollisions = detectCollisions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C29 RID: 146473 RVA: 0x00C859D8 File Offset: 0x00C83BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C2A RID: 146474 RVA: 0x00C85A2C File Offset: 0x00C83C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			rigidbody.position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C2B RID: 146475 RVA: 0x00C85A84 File Offset: 0x00C83C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.rotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C2C RID: 146476 RVA: 0x00C85AD8 File Offset: 0x00C83CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rotation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			Quaternion rotation;
			LuaObject.checkType(l, 2, out rotation);
			rigidbody.rotation = rotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C2D RID: 146477 RVA: 0x00C85B30 File Offset: 0x00C83D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_interpolation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rigidbody.interpolation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C2E RID: 146478 RVA: 0x00C85B84 File Offset: 0x00C83D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_interpolation(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			RigidbodyInterpolation interpolation;
			LuaObject.checkEnum<RigidbodyInterpolation>(l, 2, out interpolation);
			rigidbody.interpolation = interpolation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C2F RID: 146479 RVA: 0x00C85BDC File Offset: 0x00C83DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_solverIterations(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.solverIterations);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C30 RID: 146480 RVA: 0x00C85C30 File Offset: 0x00C83E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_solverIterations(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			int solverIterations;
			LuaObject.checkType(l, 2, out solverIterations);
			rigidbody.solverIterations = solverIterations;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C31 RID: 146481 RVA: 0x00C85C88 File Offset: 0x00C83E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_solverVelocityIterations(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.solverVelocityIterations);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C32 RID: 146482 RVA: 0x00C85CDC File Offset: 0x00C83EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_solverVelocityIterations(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			int solverVelocityIterations;
			LuaObject.checkType(l, 2, out solverVelocityIterations);
			rigidbody.solverVelocityIterations = solverVelocityIterations;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C33 RID: 146483 RVA: 0x00C85D34 File Offset: 0x00C83F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sleepThreshold(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.sleepThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C34 RID: 146484 RVA: 0x00C85D88 File Offset: 0x00C83F88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_sleepThreshold(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			float sleepThreshold;
			LuaObject.checkType(l, 2, out sleepThreshold);
			rigidbody.sleepThreshold = sleepThreshold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C35 RID: 146485 RVA: 0x00C85DE0 File Offset: 0x00C83FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxAngularVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rigidbody.maxAngularVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C36 RID: 146486 RVA: 0x00C85E34 File Offset: 0x00C84034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxAngularVelocity(IntPtr l)
	{
		int result;
		try
		{
			Rigidbody rigidbody = (Rigidbody)LuaObject.checkSelf(l);
			float maxAngularVelocity;
			LuaObject.checkType(l, 2, out maxAngularVelocity);
			rigidbody.maxAngularVelocity = maxAngularVelocity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C37 RID: 146487 RVA: 0x00C85E8C File Offset: 0x00C8408C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rigidbody");
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.SetDensity);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache0);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.AddForce);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache1);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.AddRelativeForce);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache2);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.AddTorque);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache3);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.AddRelativeTorque);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache4);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.AddForceAtPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache5);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.AddExplosionForce);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache6);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.ClosestPointOnBounds);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache7);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.GetRelativePointVelocity);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache8);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.GetPointVelocity);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache9);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Rigidbody.MovePosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cacheA);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Rigidbody.MoveRotation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cacheB);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Rigidbody.Sleep);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cacheC);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Rigidbody.IsSleeping);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cacheD);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Rigidbody.WakeUp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cacheE);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Rigidbody.ResetCenterOfMass);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cacheF);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.ResetInertiaTensor);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache10);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.SweepTest);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache11);
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.SweepTestAll);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rigidbody.<>f__mg$cache12);
		string name = "velocity";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_velocity);
		}
		LuaCSFunction get = Lua_UnityEngine_Rigidbody.<>f__mg$cache13;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_velocity);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Rigidbody.<>f__mg$cache14, true);
		string name2 = "angularVelocity";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_angularVelocity);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Rigidbody.<>f__mg$cache15;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_angularVelocity);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Rigidbody.<>f__mg$cache16, true);
		string name3 = "drag";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_drag);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Rigidbody.<>f__mg$cache17;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_drag);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Rigidbody.<>f__mg$cache18, true);
		string name4 = "angularDrag";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_angularDrag);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Rigidbody.<>f__mg$cache19;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_angularDrag);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Rigidbody.<>f__mg$cache1A, true);
		string name5 = "mass";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_mass);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Rigidbody.<>f__mg$cache1B;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_mass);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Rigidbody.<>f__mg$cache1C, true);
		string name6 = "useGravity";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_useGravity);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Rigidbody.<>f__mg$cache1D;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_useGravity);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_Rigidbody.<>f__mg$cache1E, true);
		string name7 = "maxDepenetrationVelocity";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_maxDepenetrationVelocity);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Rigidbody.<>f__mg$cache1F;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_maxDepenetrationVelocity);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_Rigidbody.<>f__mg$cache20, true);
		string name8 = "isKinematic";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_isKinematic);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Rigidbody.<>f__mg$cache21;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_isKinematic);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_Rigidbody.<>f__mg$cache22, true);
		string name9 = "freezeRotation";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_freezeRotation);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Rigidbody.<>f__mg$cache23;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_freezeRotation);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_Rigidbody.<>f__mg$cache24, true);
		string name10 = "constraints";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_constraints);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Rigidbody.<>f__mg$cache25;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_constraints);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_Rigidbody.<>f__mg$cache26, true);
		string name11 = "collisionDetectionMode";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_collisionDetectionMode);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Rigidbody.<>f__mg$cache27;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_collisionDetectionMode);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_Rigidbody.<>f__mg$cache28, true);
		string name12 = "centerOfMass";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_centerOfMass);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Rigidbody.<>f__mg$cache29;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_centerOfMass);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_Rigidbody.<>f__mg$cache2A, true);
		string name13 = "worldCenterOfMass";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_worldCenterOfMass);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Rigidbody.<>f__mg$cache2B, null, true);
		string name14 = "inertiaTensorRotation";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_inertiaTensorRotation);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Rigidbody.<>f__mg$cache2C;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_inertiaTensorRotation);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_Rigidbody.<>f__mg$cache2D, true);
		string name15 = "inertiaTensor";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_inertiaTensor);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Rigidbody.<>f__mg$cache2E;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_inertiaTensor);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_Rigidbody.<>f__mg$cache2F, true);
		string name16 = "detectCollisions";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_detectCollisions);
		}
		LuaCSFunction get15 = Lua_UnityEngine_Rigidbody.<>f__mg$cache30;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_detectCollisions);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_Rigidbody.<>f__mg$cache31, true);
		string name17 = "position";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_position);
		}
		LuaCSFunction get16 = Lua_UnityEngine_Rigidbody.<>f__mg$cache32;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_position);
		}
		LuaObject.addMember(l, name17, get16, Lua_UnityEngine_Rigidbody.<>f__mg$cache33, true);
		string name18 = "rotation";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_rotation);
		}
		LuaCSFunction get17 = Lua_UnityEngine_Rigidbody.<>f__mg$cache34;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_rotation);
		}
		LuaObject.addMember(l, name18, get17, Lua_UnityEngine_Rigidbody.<>f__mg$cache35, true);
		string name19 = "interpolation";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_interpolation);
		}
		LuaCSFunction get18 = Lua_UnityEngine_Rigidbody.<>f__mg$cache36;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_interpolation);
		}
		LuaObject.addMember(l, name19, get18, Lua_UnityEngine_Rigidbody.<>f__mg$cache37, true);
		string name20 = "solverIterations";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_solverIterations);
		}
		LuaCSFunction get19 = Lua_UnityEngine_Rigidbody.<>f__mg$cache38;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_solverIterations);
		}
		LuaObject.addMember(l, name20, get19, Lua_UnityEngine_Rigidbody.<>f__mg$cache39, true);
		string name21 = "solverVelocityIterations";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_solverVelocityIterations);
		}
		LuaCSFunction get20 = Lua_UnityEngine_Rigidbody.<>f__mg$cache3A;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_solverVelocityIterations);
		}
		LuaObject.addMember(l, name21, get20, Lua_UnityEngine_Rigidbody.<>f__mg$cache3B, true);
		string name22 = "sleepThreshold";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache3C == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache3C = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_sleepThreshold);
		}
		LuaCSFunction get21 = Lua_UnityEngine_Rigidbody.<>f__mg$cache3C;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache3D == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache3D = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_sleepThreshold);
		}
		LuaObject.addMember(l, name22, get21, Lua_UnityEngine_Rigidbody.<>f__mg$cache3D, true);
		string name23 = "maxAngularVelocity";
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache3E == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache3E = new LuaCSFunction(Lua_UnityEngine_Rigidbody.get_maxAngularVelocity);
		}
		LuaCSFunction get22 = Lua_UnityEngine_Rigidbody.<>f__mg$cache3E;
		if (Lua_UnityEngine_Rigidbody.<>f__mg$cache3F == null)
		{
			Lua_UnityEngine_Rigidbody.<>f__mg$cache3F = new LuaCSFunction(Lua_UnityEngine_Rigidbody.set_maxAngularVelocity);
		}
		LuaObject.addMember(l, name23, get22, Lua_UnityEngine_Rigidbody.<>f__mg$cache3F, true);
		LuaObject.createTypeMetatable(l, null, typeof(Rigidbody), typeof(Component));
	}

	// Token: 0x040198E9 RID: 104681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040198EA RID: 104682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040198EB RID: 104683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040198EC RID: 104684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040198ED RID: 104685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040198EE RID: 104686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040198EF RID: 104687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040198F0 RID: 104688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040198F1 RID: 104689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040198F2 RID: 104690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040198F3 RID: 104691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040198F4 RID: 104692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040198F5 RID: 104693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040198F6 RID: 104694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040198F7 RID: 104695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040198F8 RID: 104696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040198F9 RID: 104697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040198FA RID: 104698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040198FB RID: 104699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040198FC RID: 104700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040198FD RID: 104701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040198FE RID: 104702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040198FF RID: 104703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019900 RID: 104704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019901 RID: 104705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019902 RID: 104706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019903 RID: 104707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019904 RID: 104708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019905 RID: 104709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019906 RID: 104710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019907 RID: 104711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019908 RID: 104712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019909 RID: 104713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401990A RID: 104714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401990B RID: 104715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401990C RID: 104716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401990D RID: 104717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401990E RID: 104718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401990F RID: 104719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019910 RID: 104720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019911 RID: 104721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019912 RID: 104722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019913 RID: 104723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019914 RID: 104724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019915 RID: 104725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019916 RID: 104726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019917 RID: 104727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019918 RID: 104728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019919 RID: 104729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401991A RID: 104730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401991B RID: 104731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401991C RID: 104732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401991D RID: 104733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401991E RID: 104734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401991F RID: 104735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04019920 RID: 104736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019921 RID: 104737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04019922 RID: 104738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04019923 RID: 104739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04019924 RID: 104740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04019925 RID: 104741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04019926 RID: 104742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04019927 RID: 104743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04019928 RID: 104744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;
}
