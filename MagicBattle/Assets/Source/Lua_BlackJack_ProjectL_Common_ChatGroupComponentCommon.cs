using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011DE RID: 4574
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon : LuaObject
{
	// Token: 0x06017B7F RID: 97151 RVA: 0x00686594 File Offset: 0x00684794
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponentCommon o = new ChatGroupComponentCommon();
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

	// Token: 0x06017B80 RID: 97152 RVA: 0x006865DC File Offset: 0x006847DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponentCommon chatGroupComponentCommon = (ChatGroupComponentCommon)LuaObject.checkSelf(l);
			string name = chatGroupComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B81 RID: 97153 RVA: 0x00686630 File Offset: 0x00684830
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponentCommon chatGroupComponentCommon = (ChatGroupComponentCommon)LuaObject.checkSelf(l);
			chatGroupComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B82 RID: 97154 RVA: 0x0068667C File Offset: 0x0068487C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponentCommon chatGroupComponentCommon = (ChatGroupComponentCommon)LuaObject.checkSelf(l);
			chatGroupComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B83 RID: 97155 RVA: 0x006866C8 File Offset: 0x006848C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponentCommon chatGroupComponentCommon = (ChatGroupComponentCommon)LuaObject.checkSelf(l);
			chatGroupComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B84 RID: 97156 RVA: 0x00686714 File Offset: 0x00684914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponentCommon chatGroupComponentCommon = (ChatGroupComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			chatGroupComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B85 RID: 97157 RVA: 0x0068676C File Offset: 0x0068496C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponentCommon chatGroupComponentCommon = (ChatGroupComponentCommon)LuaObject.checkSelf(l);
			chatGroupComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B86 RID: 97158 RVA: 0x006867B8 File Offset: 0x006849B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponentCommon chatGroupComponentCommon = (ChatGroupComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B87 RID: 97159 RVA: 0x0068680C File Offset: 0x00684A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponentCommon chatGroupComponentCommon = (ChatGroupComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			chatGroupComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B88 RID: 97160 RVA: 0x00686864 File Offset: 0x00684A64
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ChatGroupComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache5);
		string name = "Owner";
		if (Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.get_Owner);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ChatGroupComponentCommon.<>f__mg$cache8, typeof(ChatGroupComponentCommon));
	}

	// Token: 0x0400E1A5 RID: 57765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E1A6 RID: 57766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E1A7 RID: 57767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E1A8 RID: 57768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E1A9 RID: 57769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E1AA RID: 57770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E1AB RID: 57771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E1AC RID: 57772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E1AD RID: 57773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
