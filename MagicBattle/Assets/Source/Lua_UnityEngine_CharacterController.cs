using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001657 RID: 5719
[Preserve]
public class Lua_UnityEngine_CharacterController : LuaObject
{
	// Token: 0x06022DF1 RID: 142833 RVA: 0x00C0D960 File Offset: 0x00C0BB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SimpleMove(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			Vector3 speed;
			LuaObject.checkType(l, 2, out speed);
			bool b = characterController.SimpleMove(speed);
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

	// Token: 0x06022DF2 RID: 142834 RVA: 0x00C0D9C4 File Offset: 0x00C0BBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Move(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			Vector3 motion;
			LuaObject.checkType(l, 2, out motion);
			CollisionFlags e = characterController.Move(motion);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)e);
			result = 2;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x06022DF3 RID: 142835 RVA: 0x00C0DA28 File Offset: 0x00C0BC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isGrounded(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.isGrounded);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DF4 RID: 142836 RVA: 0x00C0DA7C File Offset: 0x00C0BC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_velocity(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.velocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DF5 RID: 142837 RVA: 0x00C0DAD0 File Offset: 0x00C0BCD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_collisionFlags(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)characterController.collisionFlags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DF6 RID: 142838 RVA: 0x00C0DB24 File Offset: 0x00C0BD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_radius(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.radius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DF7 RID: 142839 RVA: 0x00C0DB78 File Offset: 0x00C0BD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_radius(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			float radius;
			LuaObject.checkType(l, 2, out radius);
			characterController.radius = radius;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DF8 RID: 142840 RVA: 0x00C0DBD0 File Offset: 0x00C0BDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DF9 RID: 142841 RVA: 0x00C0DC24 File Offset: 0x00C0BE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_height(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			float height;
			LuaObject.checkType(l, 2, out height);
			characterController.height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DFA RID: 142842 RVA: 0x00C0DC7C File Offset: 0x00C0BE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DFB RID: 142843 RVA: 0x00C0DCD0 File Offset: 0x00C0BED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_center(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			Vector3 center;
			LuaObject.checkType(l, 2, out center);
			characterController.center = center;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DFC RID: 142844 RVA: 0x00C0DD28 File Offset: 0x00C0BF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_slopeLimit(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.slopeLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DFD RID: 142845 RVA: 0x00C0DD7C File Offset: 0x00C0BF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_slopeLimit(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			float slopeLimit;
			LuaObject.checkType(l, 2, out slopeLimit);
			characterController.slopeLimit = slopeLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DFE RID: 142846 RVA: 0x00C0DDD4 File Offset: 0x00C0BFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_stepOffset(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.stepOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DFF RID: 142847 RVA: 0x00C0DE28 File Offset: 0x00C0C028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_stepOffset(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			float stepOffset;
			LuaObject.checkType(l, 2, out stepOffset);
			characterController.stepOffset = stepOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E00 RID: 142848 RVA: 0x00C0DE80 File Offset: 0x00C0C080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_skinWidth(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.skinWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E01 RID: 142849 RVA: 0x00C0DED4 File Offset: 0x00C0C0D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_skinWidth(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			float skinWidth;
			LuaObject.checkType(l, 2, out skinWidth);
			characterController.skinWidth = skinWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E02 RID: 142850 RVA: 0x00C0DF2C File Offset: 0x00C0C12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minMoveDistance(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.minMoveDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E03 RID: 142851 RVA: 0x00C0DF80 File Offset: 0x00C0C180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_minMoveDistance(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			float minMoveDistance;
			LuaObject.checkType(l, 2, out minMoveDistance);
			characterController.minMoveDistance = minMoveDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E04 RID: 142852 RVA: 0x00C0DFD8 File Offset: 0x00C0C1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_detectCollisions(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.detectCollisions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E05 RID: 142853 RVA: 0x00C0E02C File Offset: 0x00C0C22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_detectCollisions(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			bool detectCollisions;
			LuaObject.checkType(l, 2, out detectCollisions);
			characterController.detectCollisions = detectCollisions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E06 RID: 142854 RVA: 0x00C0E084 File Offset: 0x00C0C284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enableOverlapRecovery(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterController.enableOverlapRecovery);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E07 RID: 142855 RVA: 0x00C0E0D8 File Offset: 0x00C0C2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enableOverlapRecovery(IntPtr l)
	{
		int result;
		try
		{
			CharacterController characterController = (CharacterController)LuaObject.checkSelf(l);
			bool enableOverlapRecovery;
			LuaObject.checkType(l, 2, out enableOverlapRecovery);
			characterController.enableOverlapRecovery = enableOverlapRecovery;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E08 RID: 142856 RVA: 0x00C0E130 File Offset: 0x00C0C330
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CharacterController");
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CharacterController.SimpleMove);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CharacterController.<>f__mg$cache0);
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CharacterController.Move);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CharacterController.<>f__mg$cache1);
		string name = "isGrounded";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_isGrounded);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_CharacterController.<>f__mg$cache2, null, true);
		string name2 = "velocity";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_velocity);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_CharacterController.<>f__mg$cache3, null, true);
		string name3 = "collisionFlags";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_collisionFlags);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_CharacterController.<>f__mg$cache4, null, true);
		string name4 = "radius";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_radius);
		}
		LuaCSFunction get = Lua_UnityEngine_CharacterController.<>f__mg$cache5;
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CharacterController.set_radius);
		}
		LuaObject.addMember(l, name4, get, Lua_UnityEngine_CharacterController.<>f__mg$cache6, true);
		string name5 = "height";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_height);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CharacterController.<>f__mg$cache7;
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_CharacterController.set_height);
		}
		LuaObject.addMember(l, name5, get2, Lua_UnityEngine_CharacterController.<>f__mg$cache8, true);
		string name6 = "center";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_center);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CharacterController.<>f__mg$cache9;
		if (Lua_UnityEngine_CharacterController.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_CharacterController.set_center);
		}
		LuaObject.addMember(l, name6, get3, Lua_UnityEngine_CharacterController.<>f__mg$cacheA, true);
		string name7 = "slopeLimit";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_slopeLimit);
		}
		LuaCSFunction get4 = Lua_UnityEngine_CharacterController.<>f__mg$cacheB;
		if (Lua_UnityEngine_CharacterController.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_CharacterController.set_slopeLimit);
		}
		LuaObject.addMember(l, name7, get4, Lua_UnityEngine_CharacterController.<>f__mg$cacheC, true);
		string name8 = "stepOffset";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_stepOffset);
		}
		LuaCSFunction get5 = Lua_UnityEngine_CharacterController.<>f__mg$cacheD;
		if (Lua_UnityEngine_CharacterController.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_CharacterController.set_stepOffset);
		}
		LuaObject.addMember(l, name8, get5, Lua_UnityEngine_CharacterController.<>f__mg$cacheE, true);
		string name9 = "skinWidth";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_skinWidth);
		}
		LuaCSFunction get6 = Lua_UnityEngine_CharacterController.<>f__mg$cacheF;
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_CharacterController.set_skinWidth);
		}
		LuaObject.addMember(l, name9, get6, Lua_UnityEngine_CharacterController.<>f__mg$cache10, true);
		string name10 = "minMoveDistance";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_minMoveDistance);
		}
		LuaCSFunction get7 = Lua_UnityEngine_CharacterController.<>f__mg$cache11;
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_CharacterController.set_minMoveDistance);
		}
		LuaObject.addMember(l, name10, get7, Lua_UnityEngine_CharacterController.<>f__mg$cache12, true);
		string name11 = "detectCollisions";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_detectCollisions);
		}
		LuaCSFunction get8 = Lua_UnityEngine_CharacterController.<>f__mg$cache13;
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_CharacterController.set_detectCollisions);
		}
		LuaObject.addMember(l, name11, get8, Lua_UnityEngine_CharacterController.<>f__mg$cache14, true);
		string name12 = "enableOverlapRecovery";
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_CharacterController.get_enableOverlapRecovery);
		}
		LuaCSFunction get9 = Lua_UnityEngine_CharacterController.<>f__mg$cache15;
		if (Lua_UnityEngine_CharacterController.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_CharacterController.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_CharacterController.set_enableOverlapRecovery);
		}
		LuaObject.addMember(l, name12, get9, Lua_UnityEngine_CharacterController.<>f__mg$cache16, true);
		LuaObject.createTypeMetatable(l, null, typeof(CharacterController), typeof(Collider));
	}

	// Token: 0x04018DA1 RID: 101793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018DA2 RID: 101794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018DA3 RID: 101795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018DA4 RID: 101796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018DA5 RID: 101797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018DA6 RID: 101798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018DA7 RID: 101799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018DA8 RID: 101800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018DA9 RID: 101801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018DAA RID: 101802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018DAB RID: 101803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018DAC RID: 101804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018DAD RID: 101805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018DAE RID: 101806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018DAF RID: 101807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018DB0 RID: 101808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018DB1 RID: 101809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018DB2 RID: 101810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018DB3 RID: 101811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018DB4 RID: 101812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018DB5 RID: 101813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018DB6 RID: 101814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018DB7 RID: 101815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
