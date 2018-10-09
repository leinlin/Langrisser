using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001655 RID: 5717
[Preserve]
public class Lua_UnityEngine_CapsuleCollider2D : LuaObject
{
	// Token: 0x06022DE9 RID: 142825 RVA: 0x00C0D70C File Offset: 0x00C0B90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider2D capsuleCollider2D = (CapsuleCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, capsuleCollider2D.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DEA RID: 142826 RVA: 0x00C0D760 File Offset: 0x00C0B960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider2D capsuleCollider2D = (CapsuleCollider2D)LuaObject.checkSelf(l);
			Vector2 size;
			LuaObject.checkType(l, 2, out size);
			capsuleCollider2D.size = size;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DEB RID: 142827 RVA: 0x00C0D7B8 File Offset: 0x00C0B9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_direction(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider2D capsuleCollider2D = (CapsuleCollider2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)capsuleCollider2D.direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DEC RID: 142828 RVA: 0x00C0D80C File Offset: 0x00C0BA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_direction(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider2D capsuleCollider2D = (CapsuleCollider2D)LuaObject.checkSelf(l);
			CapsuleDirection2D direction;
			LuaObject.checkEnum<CapsuleDirection2D>(l, 2, out direction);
			capsuleCollider2D.direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DED RID: 142829 RVA: 0x00C0D864 File Offset: 0x00C0BA64
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CapsuleCollider2D");
		string name = "size";
		if (Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider2D.get_size);
		}
		LuaCSFunction get = Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache0;
		if (Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider2D.set_size);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache1, true);
		string name2 = "direction";
		if (Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider2D.get_direction);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache2;
		if (Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider2D.set_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CapsuleCollider2D.<>f__mg$cache3, true);
		LuaObject.createTypeMetatable(l, null, typeof(CapsuleCollider2D), typeof(Collider2D));
	}

	// Token: 0x04018D9D RID: 101789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018D9E RID: 101790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018D9F RID: 101791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018DA0 RID: 101792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
