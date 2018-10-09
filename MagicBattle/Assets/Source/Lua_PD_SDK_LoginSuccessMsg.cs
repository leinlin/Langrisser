using System;
using System.Runtime.CompilerServices;
using PD.SDK;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015FF RID: 5631
[Preserve]
public class Lua_PD_SDK_LoginSuccessMsg : LuaObject
{
	// Token: 0x06022843 RID: 141379 RVA: 0x00BD6814 File Offset: 0x00BD4A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string d;
			LuaObject.checkType(l, 2, out d);
			string o;
			LuaObject.checkType(l, 3, out o);
			string ch;
			LuaObject.checkType(l, 4, out ch);
			string cu;
			LuaObject.checkType(l, 5, out cu);
			LoginSuccessMsg loginSuccessMsg = new LoginSuccessMsg(d, o, ch, cu);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginSuccessMsg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022844 RID: 141380 RVA: 0x00BD6894 File Offset: 0x00BD4A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Parse_s(IntPtr l)
	{
		int result;
		try
		{
			string msg;
			LuaObject.checkType(l, 1, out msg);
			LoginSuccessMsg loginSuccessMsg = LoginSuccessMsg.Parse(msg);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginSuccessMsg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022845 RID: 141381 RVA: 0x00BD68EC File Offset: 0x00BD4AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_data(IntPtr l)
	{
		int result;
		try
		{
			LoginSuccessMsg loginSuccessMsg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 1, out loginSuccessMsg);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginSuccessMsg.data);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022846 RID: 141382 RVA: 0x00BD6940 File Offset: 0x00BD4B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_data(IntPtr l)
	{
		int result;
		try
		{
			LoginSuccessMsg loginSuccessMsg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 1, out loginSuccessMsg);
			string data;
			LuaObject.checkType(l, 2, out data);
			loginSuccessMsg.data = data;
			LuaObject.setBack(l, loginSuccessMsg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022847 RID: 141383 RVA: 0x00BD69A4 File Offset: 0x00BD4BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_opcode(IntPtr l)
	{
		int result;
		try
		{
			LoginSuccessMsg loginSuccessMsg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 1, out loginSuccessMsg);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginSuccessMsg.opcode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022848 RID: 141384 RVA: 0x00BD69F8 File Offset: 0x00BD4BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_opcode(IntPtr l)
	{
		int result;
		try
		{
			LoginSuccessMsg loginSuccessMsg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 1, out loginSuccessMsg);
			string opcode;
			LuaObject.checkType(l, 2, out opcode);
			loginSuccessMsg.opcode = opcode;
			LuaObject.setBack(l, loginSuccessMsg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022849 RID: 141385 RVA: 0x00BD6A5C File Offset: 0x00BD4C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_channel_id(IntPtr l)
	{
		int result;
		try
		{
			LoginSuccessMsg loginSuccessMsg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 1, out loginSuccessMsg);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginSuccessMsg.channel_id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602284A RID: 141386 RVA: 0x00BD6AB0 File Offset: 0x00BD4CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_channel_id(IntPtr l)
	{
		int result;
		try
		{
			LoginSuccessMsg loginSuccessMsg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 1, out loginSuccessMsg);
			string channel_id;
			LuaObject.checkType(l, 2, out channel_id);
			loginSuccessMsg.channel_id = channel_id;
			LuaObject.setBack(l, loginSuccessMsg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602284B RID: 141387 RVA: 0x00BD6B14 File Offset: 0x00BD4D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_customparams(IntPtr l)
	{
		int result;
		try
		{
			LoginSuccessMsg loginSuccessMsg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 1, out loginSuccessMsg);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginSuccessMsg.customparams);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602284C RID: 141388 RVA: 0x00BD6B68 File Offset: 0x00BD4D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_customparams(IntPtr l)
	{
		int result;
		try
		{
			LoginSuccessMsg loginSuccessMsg;
			LuaObject.checkValueType<LoginSuccessMsg>(l, 1, out loginSuccessMsg);
			string customparams;
			LuaObject.checkType(l, 2, out customparams);
			loginSuccessMsg.customparams = customparams;
			LuaObject.setBack(l, loginSuccessMsg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602284D RID: 141389 RVA: 0x00BD6BCC File Offset: 0x00BD4DCC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "PD.SDK.LoginSuccessMsg");
		if (Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache0 == null)
		{
			Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache0 = new LuaCSFunction(Lua_PD_SDK_LoginSuccessMsg.Parse_s);
		}
		LuaObject.addMember(l, Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache0);
		string name = "data";
		if (Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache1 == null)
		{
			Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache1 = new LuaCSFunction(Lua_PD_SDK_LoginSuccessMsg.get_data);
		}
		LuaCSFunction get = Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache1;
		if (Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache2 == null)
		{
			Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache2 = new LuaCSFunction(Lua_PD_SDK_LoginSuccessMsg.set_data);
		}
		LuaObject.addMember(l, name, get, Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache2, true);
		string name2 = "opcode";
		if (Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache3 == null)
		{
			Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache3 = new LuaCSFunction(Lua_PD_SDK_LoginSuccessMsg.get_opcode);
		}
		LuaCSFunction get2 = Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache3;
		if (Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache4 == null)
		{
			Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache4 = new LuaCSFunction(Lua_PD_SDK_LoginSuccessMsg.set_opcode);
		}
		LuaObject.addMember(l, name2, get2, Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache4, true);
		string name3 = "channel_id";
		if (Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache5 == null)
		{
			Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache5 = new LuaCSFunction(Lua_PD_SDK_LoginSuccessMsg.get_channel_id);
		}
		LuaCSFunction get3 = Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache5;
		if (Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache6 == null)
		{
			Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache6 = new LuaCSFunction(Lua_PD_SDK_LoginSuccessMsg.set_channel_id);
		}
		LuaObject.addMember(l, name3, get3, Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache6, true);
		string name4 = "customparams";
		if (Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache7 == null)
		{
			Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache7 = new LuaCSFunction(Lua_PD_SDK_LoginSuccessMsg.get_customparams);
		}
		LuaCSFunction get4 = Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache7;
		if (Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache8 == null)
		{
			Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache8 = new LuaCSFunction(Lua_PD_SDK_LoginSuccessMsg.set_customparams);
		}
		LuaObject.addMember(l, name4, get4, Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache8, true);
		if (Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache9 == null)
		{
			Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache9 = new LuaCSFunction(Lua_PD_SDK_LoginSuccessMsg.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_PD_SDK_LoginSuccessMsg.<>f__mg$cache9, typeof(LoginSuccessMsg), typeof(ValueType));
	}

	// Token: 0x04018627 RID: 99879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018628 RID: 99880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018629 RID: 99881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401862A RID: 99882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401862B RID: 99883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401862C RID: 99884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401862D RID: 99885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401862E RID: 99886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401862F RID: 99887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018630 RID: 99888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
