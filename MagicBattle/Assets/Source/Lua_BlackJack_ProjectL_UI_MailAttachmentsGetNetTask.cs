using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001501 RID: 5377
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MailAttachmentsGetNetTask : LuaObject
{
	// Token: 0x0601FD4E RID: 130382 RVA: 0x00A811B4 File Offset: 0x00A7F3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong instanceID;
			LuaObject.checkType(l, 2, out instanceID);
			MailAttachmentsGetNetTask o = new MailAttachmentsGetNetTask(instanceID);
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

	// Token: 0x0601FD4F RID: 130383 RVA: 0x00A81208 File Offset: 0x00A7F408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			MailAttachmentsGetNetTask mailAttachmentsGetNetTask = (MailAttachmentsGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailAttachmentsGetNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD50 RID: 130384 RVA: 0x00A8125C File Offset: 0x00A7F45C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MailAttachmentsGetNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_MailAttachmentsGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailAttachmentsGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailAttachmentsGetNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_MailAttachmentsGetNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_MailAttachmentsGetNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailAttachmentsGetNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailAttachmentsGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MailAttachmentsGetNetTask.<>f__mg$cache1, typeof(MailAttachmentsGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04015D2E RID: 89390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015D2F RID: 89391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
