using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200161F RID: 5663
[Preserve]
public class Lua_UnityEngine_AnimatorControllerParameter : LuaObject
{
	// Token: 0x06022B4E RID: 142158 RVA: 0x00BFA104 File Offset: 0x00BF8304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerParameter o = new AnimatorControllerParameter();
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

	// Token: 0x06022B4F RID: 142159 RVA: 0x00BFA14C File Offset: 0x00BF834C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_nameHash(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerParameter animatorControllerParameter = (AnimatorControllerParameter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorControllerParameter.nameHash);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B50 RID: 142160 RVA: 0x00BFA1A0 File Offset: 0x00BF83A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_type(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerParameter animatorControllerParameter = (AnimatorControllerParameter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animatorControllerParameter.type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B51 RID: 142161 RVA: 0x00BFA1F4 File Offset: 0x00BF83F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_type(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerParameter animatorControllerParameter = (AnimatorControllerParameter)LuaObject.checkSelf(l);
			AnimatorControllerParameterType type;
			LuaObject.checkEnum<AnimatorControllerParameterType>(l, 2, out type);
			animatorControllerParameter.type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B52 RID: 142162 RVA: 0x00BFA24C File Offset: 0x00BF844C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultFloat(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerParameter animatorControllerParameter = (AnimatorControllerParameter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorControllerParameter.defaultFloat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B53 RID: 142163 RVA: 0x00BFA2A0 File Offset: 0x00BF84A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_defaultFloat(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerParameter animatorControllerParameter = (AnimatorControllerParameter)LuaObject.checkSelf(l);
			float defaultFloat;
			LuaObject.checkType(l, 2, out defaultFloat);
			animatorControllerParameter.defaultFloat = defaultFloat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B54 RID: 142164 RVA: 0x00BFA2F8 File Offset: 0x00BF84F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultInt(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerParameter animatorControllerParameter = (AnimatorControllerParameter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorControllerParameter.defaultInt);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B55 RID: 142165 RVA: 0x00BFA34C File Offset: 0x00BF854C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_defaultInt(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerParameter animatorControllerParameter = (AnimatorControllerParameter)LuaObject.checkSelf(l);
			int defaultInt;
			LuaObject.checkType(l, 2, out defaultInt);
			animatorControllerParameter.defaultInt = defaultInt;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B56 RID: 142166 RVA: 0x00BFA3A4 File Offset: 0x00BF85A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultBool(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerParameter animatorControllerParameter = (AnimatorControllerParameter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorControllerParameter.defaultBool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B57 RID: 142167 RVA: 0x00BFA3F8 File Offset: 0x00BF85F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_defaultBool(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerParameter animatorControllerParameter = (AnimatorControllerParameter)LuaObject.checkSelf(l);
			bool defaultBool;
			LuaObject.checkType(l, 2, out defaultBool);
			animatorControllerParameter.defaultBool = defaultBool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B58 RID: 142168 RVA: 0x00BFA450 File Offset: 0x00BF8650
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnimatorControllerParameter");
		string name = "nameHash";
		if (Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnimatorControllerParameter.get_nameHash);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache0, null, true);
		string name2 = "type";
		if (Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnimatorControllerParameter.get_type);
		}
		LuaCSFunction get = Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache1;
		if (Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnimatorControllerParameter.set_type);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache2, true);
		string name3 = "defaultFloat";
		if (Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AnimatorControllerParameter.get_defaultFloat);
		}
		LuaCSFunction get2 = Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache3;
		if (Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AnimatorControllerParameter.set_defaultFloat);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache4, true);
		string name4 = "defaultInt";
		if (Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AnimatorControllerParameter.get_defaultInt);
		}
		LuaCSFunction get3 = Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache5;
		if (Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AnimatorControllerParameter.set_defaultInt);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache6, true);
		string name5 = "defaultBool";
		if (Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AnimatorControllerParameter.get_defaultBool);
		}
		LuaCSFunction get4 = Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache7;
		if (Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_AnimatorControllerParameter.set_defaultBool);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache8, true);
		if (Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_AnimatorControllerParameter.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AnimatorControllerParameter.<>f__mg$cache9, typeof(AnimatorControllerParameter));
	}

	// Token: 0x04018B6E RID: 101230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018B6F RID: 101231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018B70 RID: 101232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018B71 RID: 101233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018B72 RID: 101234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018B73 RID: 101235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018B74 RID: 101236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018B75 RID: 101237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018B76 RID: 101238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018B77 RID: 101239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
