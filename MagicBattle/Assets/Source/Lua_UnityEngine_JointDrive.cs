using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016F8 RID: 5880
[Preserve]
public class Lua_UnityEngine_JointDrive : LuaObject
{
	// Token: 0x06023406 RID: 144390 RVA: 0x00C3C3AC File Offset: 0x00C3A5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			JointDrive jointDrive = default(JointDrive);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointDrive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023407 RID: 144391 RVA: 0x00C3C3FC File Offset: 0x00C3A5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_positionSpring(IntPtr l)
	{
		int result;
		try
		{
			JointDrive jointDrive;
			LuaObject.checkValueType<JointDrive>(l, 1, out jointDrive);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointDrive.positionSpring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023408 RID: 144392 RVA: 0x00C3C450 File Offset: 0x00C3A650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_positionSpring(IntPtr l)
	{
		int result;
		try
		{
			JointDrive jointDrive;
			LuaObject.checkValueType<JointDrive>(l, 1, out jointDrive);
			float positionSpring;
			LuaObject.checkType(l, 2, out positionSpring);
			jointDrive.positionSpring = positionSpring;
			LuaObject.setBack(l, jointDrive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023409 RID: 144393 RVA: 0x00C3C4B4 File Offset: 0x00C3A6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_positionDamper(IntPtr l)
	{
		int result;
		try
		{
			JointDrive jointDrive;
			LuaObject.checkValueType<JointDrive>(l, 1, out jointDrive);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointDrive.positionDamper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602340A RID: 144394 RVA: 0x00C3C508 File Offset: 0x00C3A708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_positionDamper(IntPtr l)
	{
		int result;
		try
		{
			JointDrive jointDrive;
			LuaObject.checkValueType<JointDrive>(l, 1, out jointDrive);
			float positionDamper;
			LuaObject.checkType(l, 2, out positionDamper);
			jointDrive.positionDamper = positionDamper;
			LuaObject.setBack(l, jointDrive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602340B RID: 144395 RVA: 0x00C3C56C File Offset: 0x00C3A76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maximumForce(IntPtr l)
	{
		int result;
		try
		{
			JointDrive jointDrive;
			LuaObject.checkValueType<JointDrive>(l, 1, out jointDrive);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jointDrive.maximumForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602340C RID: 144396 RVA: 0x00C3C5C0 File Offset: 0x00C3A7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maximumForce(IntPtr l)
	{
		int result;
		try
		{
			JointDrive jointDrive;
			LuaObject.checkValueType<JointDrive>(l, 1, out jointDrive);
			float maximumForce;
			LuaObject.checkType(l, 2, out maximumForce);
			jointDrive.maximumForce = maximumForce;
			LuaObject.setBack(l, jointDrive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602340D RID: 144397 RVA: 0x00C3C624 File Offset: 0x00C3A824
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.JointDrive");
		string name = "positionSpring";
		if (Lua_UnityEngine_JointDrive.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_JointDrive.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_JointDrive.get_positionSpring);
		}
		LuaCSFunction get = Lua_UnityEngine_JointDrive.<>f__mg$cache0;
		if (Lua_UnityEngine_JointDrive.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_JointDrive.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_JointDrive.set_positionSpring);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_JointDrive.<>f__mg$cache1, true);
		string name2 = "positionDamper";
		if (Lua_UnityEngine_JointDrive.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_JointDrive.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_JointDrive.get_positionDamper);
		}
		LuaCSFunction get2 = Lua_UnityEngine_JointDrive.<>f__mg$cache2;
		if (Lua_UnityEngine_JointDrive.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_JointDrive.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_JointDrive.set_positionDamper);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_JointDrive.<>f__mg$cache3, true);
		string name3 = "maximumForce";
		if (Lua_UnityEngine_JointDrive.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_JointDrive.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_JointDrive.get_maximumForce);
		}
		LuaCSFunction get3 = Lua_UnityEngine_JointDrive.<>f__mg$cache4;
		if (Lua_UnityEngine_JointDrive.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_JointDrive.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_JointDrive.set_maximumForce);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_JointDrive.<>f__mg$cache5, true);
		if (Lua_UnityEngine_JointDrive.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_JointDrive.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_JointDrive.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_JointDrive.<>f__mg$cache6, typeof(JointDrive), typeof(ValueType));
	}

	// Token: 0x04019274 RID: 103028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019275 RID: 103029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019276 RID: 103030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019277 RID: 103031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019278 RID: 103032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019279 RID: 103033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401927A RID: 103034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
