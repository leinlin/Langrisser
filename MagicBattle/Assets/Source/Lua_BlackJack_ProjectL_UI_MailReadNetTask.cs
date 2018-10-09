using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001505 RID: 5381
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MailReadNetTask : LuaObject
{
	// Token: 0x0601FDE6 RID: 130534 RVA: 0x00A85F94 File Offset: 0x00A84194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong instanceID;
			LuaObject.checkType(l, 2, out instanceID);
			MailReadNetTask o = new MailReadNetTask(instanceID);
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

	// Token: 0x0601FDE7 RID: 130535 RVA: 0x00A85FE8 File Offset: 0x00A841E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_instanceID(IntPtr l)
	{
		int result;
		try
		{
			MailReadNetTask mailReadNetTask = (MailReadNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailReadNetTask.m_instanceID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDE8 RID: 130536 RVA: 0x00A8603C File Offset: 0x00A8423C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_instanceID(IntPtr l)
	{
		int result;
		try
		{
			MailReadNetTask mailReadNetTask = (MailReadNetTask)LuaObject.checkSelf(l);
			ulong instanceID;
			LuaObject.checkType(l, 2, out instanceID);
			mailReadNetTask.m_instanceID = instanceID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FDE9 RID: 130537 RVA: 0x00A86094 File Offset: 0x00A84294
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MailReadNetTask");
		string name = "m_instanceID";
		if (Lua_BlackJack_ProjectL_UI_MailReadNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailReadNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailReadNetTask.get_m_instanceID);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_MailReadNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_MailReadNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailReadNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailReadNetTask.set_m_instanceID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MailReadNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_MailReadNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailReadNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailReadNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MailReadNetTask.<>f__mg$cache2, typeof(MailReadNetTask), typeof(UINetTask));
	}

	// Token: 0x04015DBE RID: 89534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015DBF RID: 89535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015DC0 RID: 89536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
