using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011E1 RID: 4577
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ChatTextMessage : LuaObject
{
	// Token: 0x06017BA6 RID: 97190 RVA: 0x0068755C File Offset: 0x0068575C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatTextMessage o = new ChatTextMessage();
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

	// Token: 0x06017BA7 RID: 97191 RVA: 0x006875A4 File Offset: 0x006857A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Text(IntPtr l)
	{
		int result;
		try
		{
			ChatTextMessage chatTextMessage = (ChatTextMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatTextMessage.Text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BA8 RID: 97192 RVA: 0x006875F8 File Offset: 0x006857F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Text(IntPtr l)
	{
		int result;
		try
		{
			ChatTextMessage chatTextMessage = (ChatTextMessage)LuaObject.checkSelf(l);
			string text;
			LuaObject.checkType(l, 2, out text);
			chatTextMessage.Text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BA9 RID: 97193 RVA: 0x00687650 File Offset: 0x00685850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SystemContentTemplateId(IntPtr l)
	{
		int result;
		try
		{
			ChatTextMessage chatTextMessage = (ChatTextMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatTextMessage.SystemContentTemplateId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BAA RID: 97194 RVA: 0x006876A4 File Offset: 0x006858A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SystemContentTemplateId(IntPtr l)
	{
		int result;
		try
		{
			ChatTextMessage chatTextMessage = (ChatTextMessage)LuaObject.checkSelf(l);
			int systemContentTemplateId;
			LuaObject.checkType(l, 2, out systemContentTemplateId);
			chatTextMessage.SystemContentTemplateId = systemContentTemplateId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BAB RID: 97195 RVA: 0x006876FC File Offset: 0x006858FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ChatTextMessage");
		string name = "Text";
		if (Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatTextMessage.get_Text);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatTextMessage.set_Text);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache1, true);
		string name2 = "SystemContentTemplateId";
		if (Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatTextMessage.get_SystemContentTemplateId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatTextMessage.set_SystemContentTemplateId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatTextMessage.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ChatTextMessage.<>f__mg$cache4, typeof(ChatTextMessage), typeof(ChatMessage));
	}

	// Token: 0x0400E1C6 RID: 57798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E1C7 RID: 57799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E1C8 RID: 57800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E1C9 RID: 57801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E1CA RID: 57802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
