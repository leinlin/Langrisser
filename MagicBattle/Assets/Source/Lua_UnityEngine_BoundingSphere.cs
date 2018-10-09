using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001643 RID: 5699
[Preserve]
public class Lua_UnityEngine_BoundingSphere : LuaObject
{
	// Token: 0x06022C6F RID: 142447 RVA: 0x00C0221C File Offset: 0x00C0041C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Vector3 pos;
				LuaObject.checkType(l, 2, out pos);
				float rad;
				LuaObject.checkType(l, 3, out rad);
				BoundingSphere boundingSphere = new BoundingSphere(pos, rad);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, boundingSphere);
				result = 2;
			}
			else if (num == 2)
			{
				Vector4 packedSphere;
				LuaObject.checkType(l, 2, out packedSphere);
				BoundingSphere boundingSphere = new BoundingSphere(packedSphere);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, boundingSphere);
				result = 2;
			}
			else if (num == 0)
			{
				BoundingSphere boundingSphere = default(BoundingSphere);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, boundingSphere);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C70 RID: 142448 RVA: 0x00C02304 File Offset: 0x00C00504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			BoundingSphere boundingSphere;
			LuaObject.checkValueType<BoundingSphere>(l, 1, out boundingSphere);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundingSphere.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C71 RID: 142449 RVA: 0x00C02358 File Offset: 0x00C00558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			BoundingSphere boundingSphere;
			LuaObject.checkValueType<BoundingSphere>(l, 1, out boundingSphere);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			boundingSphere.position = position;
			LuaObject.setBack(l, boundingSphere);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C72 RID: 142450 RVA: 0x00C023BC File Offset: 0x00C005BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_radius(IntPtr l)
	{
		int result;
		try
		{
			BoundingSphere boundingSphere;
			LuaObject.checkValueType<BoundingSphere>(l, 1, out boundingSphere);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boundingSphere.radius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C73 RID: 142451 RVA: 0x00C02410 File Offset: 0x00C00610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_radius(IntPtr l)
	{
		int result;
		try
		{
			BoundingSphere boundingSphere;
			LuaObject.checkValueType<BoundingSphere>(l, 1, out boundingSphere);
			float radius;
			LuaObject.checkType(l, 2, out radius);
			boundingSphere.radius = radius;
			LuaObject.setBack(l, boundingSphere);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C74 RID: 142452 RVA: 0x00C02474 File Offset: 0x00C00674
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.BoundingSphere");
		string name = "position";
		if (Lua_UnityEngine_BoundingSphere.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_BoundingSphere.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_BoundingSphere.get_position);
		}
		LuaCSFunction get = Lua_UnityEngine_BoundingSphere.<>f__mg$cache0;
		if (Lua_UnityEngine_BoundingSphere.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_BoundingSphere.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_BoundingSphere.set_position);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_BoundingSphere.<>f__mg$cache1, true);
		string name2 = "radius";
		if (Lua_UnityEngine_BoundingSphere.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_BoundingSphere.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_BoundingSphere.get_radius);
		}
		LuaCSFunction get2 = Lua_UnityEngine_BoundingSphere.<>f__mg$cache2;
		if (Lua_UnityEngine_BoundingSphere.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_BoundingSphere.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_BoundingSphere.set_radius);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_BoundingSphere.<>f__mg$cache3, true);
		if (Lua_UnityEngine_BoundingSphere.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_BoundingSphere.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_BoundingSphere.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_BoundingSphere.<>f__mg$cache4, typeof(BoundingSphere), typeof(ValueType));
	}

	// Token: 0x04018C47 RID: 101447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C48 RID: 101448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C49 RID: 101449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C4A RID: 101450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C4B RID: 101451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
