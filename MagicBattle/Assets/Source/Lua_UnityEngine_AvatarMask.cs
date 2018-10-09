using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200163A RID: 5690
[Preserve]
public class Lua_UnityEngine_AvatarMask : LuaObject
{
	// Token: 0x06022C28 RID: 142376 RVA: 0x00C001D4 File Offset: 0x00BFE3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AvatarMask o = new AvatarMask();
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

	// Token: 0x06022C29 RID: 142377 RVA: 0x00C0021C File Offset: 0x00BFE41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHumanoidBodyPartActive(IntPtr l)
	{
		int result;
		try
		{
			AvatarMask avatarMask = (AvatarMask)LuaObject.checkSelf(l);
			AvatarMaskBodyPart index;
			LuaObject.checkEnum<AvatarMaskBodyPart>(l, 2, out index);
			bool humanoidBodyPartActive = avatarMask.GetHumanoidBodyPartActive(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanoidBodyPartActive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C2A RID: 142378 RVA: 0x00C00280 File Offset: 0x00BFE480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHumanoidBodyPartActive(IntPtr l)
	{
		int result;
		try
		{
			AvatarMask avatarMask = (AvatarMask)LuaObject.checkSelf(l);
			AvatarMaskBodyPart index;
			LuaObject.checkEnum<AvatarMaskBodyPart>(l, 2, out index);
			bool value;
			LuaObject.checkType(l, 3, out value);
			avatarMask.SetHumanoidBodyPartActive(index, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C2B RID: 142379 RVA: 0x00C002E4 File Offset: 0x00BFE4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTransformPath(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				AvatarMask avatarMask = (AvatarMask)LuaObject.checkSelf(l);
				Transform transform;
				LuaObject.checkType<Transform>(l, 2, out transform);
				avatarMask.AddTransformPath(transform);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				AvatarMask avatarMask2 = (AvatarMask)LuaObject.checkSelf(l);
				Transform transform2;
				LuaObject.checkType<Transform>(l, 2, out transform2);
				bool recursive;
				LuaObject.checkType(l, 3, out recursive);
				avatarMask2.AddTransformPath(transform2, recursive);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddTransformPath to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C2C RID: 142380 RVA: 0x00C003A8 File Offset: 0x00BFE5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveTransformPath(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				AvatarMask avatarMask = (AvatarMask)LuaObject.checkSelf(l);
				Transform transform;
				LuaObject.checkType<Transform>(l, 2, out transform);
				avatarMask.RemoveTransformPath(transform);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				AvatarMask avatarMask2 = (AvatarMask)LuaObject.checkSelf(l);
				Transform transform2;
				LuaObject.checkType<Transform>(l, 2, out transform2);
				bool recursive;
				LuaObject.checkType(l, 3, out recursive);
				avatarMask2.RemoveTransformPath(transform2, recursive);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RemoveTransformPath to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C2D RID: 142381 RVA: 0x00C0046C File Offset: 0x00BFE66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTransformPath(IntPtr l)
	{
		int result;
		try
		{
			AvatarMask avatarMask = (AvatarMask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			string transformPath = avatarMask.GetTransformPath(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transformPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C2E RID: 142382 RVA: 0x00C004D0 File Offset: 0x00BFE6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTransformPath(IntPtr l)
	{
		int result;
		try
		{
			AvatarMask avatarMask = (AvatarMask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			string path;
			LuaObject.checkType(l, 3, out path);
			avatarMask.SetTransformPath(index, path);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C2F RID: 142383 RVA: 0x00C00534 File Offset: 0x00BFE734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTransformActive(IntPtr l)
	{
		int result;
		try
		{
			AvatarMask avatarMask = (AvatarMask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			bool transformActive = avatarMask.GetTransformActive(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, transformActive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C30 RID: 142384 RVA: 0x00C00598 File Offset: 0x00BFE798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTransformActive(IntPtr l)
	{
		int result;
		try
		{
			AvatarMask avatarMask = (AvatarMask)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			bool value;
			LuaObject.checkType(l, 3, out value);
			avatarMask.SetTransformActive(index, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C31 RID: 142385 RVA: 0x00C005FC File Offset: 0x00BFE7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transformCount(IntPtr l)
	{
		int result;
		try
		{
			AvatarMask avatarMask = (AvatarMask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, avatarMask.transformCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C32 RID: 142386 RVA: 0x00C00650 File Offset: 0x00BFE850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_transformCount(IntPtr l)
	{
		int result;
		try
		{
			AvatarMask avatarMask = (AvatarMask)LuaObject.checkSelf(l);
			int transformCount;
			LuaObject.checkType(l, 2, out transformCount);
			avatarMask.transformCount = transformCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C33 RID: 142387 RVA: 0x00C006A8 File Offset: 0x00BFE8A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AvatarMask");
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AvatarMask.GetHumanoidBodyPartActive);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AvatarMask.<>f__mg$cache0);
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AvatarMask.SetHumanoidBodyPartActive);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AvatarMask.<>f__mg$cache1);
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AvatarMask.AddTransformPath);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AvatarMask.<>f__mg$cache2);
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AvatarMask.RemoveTransformPath);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AvatarMask.<>f__mg$cache3);
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AvatarMask.GetTransformPath);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AvatarMask.<>f__mg$cache4);
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AvatarMask.SetTransformPath);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AvatarMask.<>f__mg$cache5);
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AvatarMask.GetTransformActive);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AvatarMask.<>f__mg$cache6);
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AvatarMask.SetTransformActive);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AvatarMask.<>f__mg$cache7);
		string name = "transformCount";
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_AvatarMask.get_transformCount);
		}
		LuaCSFunction get = Lua_UnityEngine_AvatarMask.<>f__mg$cache8;
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_AvatarMask.set_transformCount);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_AvatarMask.<>f__mg$cache9, true);
		if (Lua_UnityEngine_AvatarMask.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_AvatarMask.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_AvatarMask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AvatarMask.<>f__mg$cacheA, typeof(AvatarMask), typeof(UnityEngine.Object));
	}

	// Token: 0x04018C12 RID: 101394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C13 RID: 101395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C14 RID: 101396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C15 RID: 101397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C16 RID: 101398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018C17 RID: 101399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018C18 RID: 101400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018C19 RID: 101401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018C1A RID: 101402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018C1B RID: 101403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018C1C RID: 101404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
