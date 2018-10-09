using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001500 RID: 5376
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MailAttachmentsAutoGetNetTask : LuaObject
{
	// Token: 0x0601FD4A RID: 130378 RVA: 0x00A81094 File Offset: 0x00A7F294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MailAttachmentsAutoGetNetTask o = new MailAttachmentsAutoGetNetTask();
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

	// Token: 0x0601FD4B RID: 130379 RVA: 0x00A810DC File Offset: 0x00A7F2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			MailAttachmentsAutoGetNetTask mailAttachmentsAutoGetNetTask = (MailAttachmentsAutoGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailAttachmentsAutoGetNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FD4C RID: 130380 RVA: 0x00A81130 File Offset: 0x00A7F330
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MailAttachmentsAutoGetNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_MailAttachmentsAutoGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailAttachmentsAutoGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailAttachmentsAutoGetNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_MailAttachmentsAutoGetNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_MailAttachmentsAutoGetNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MailAttachmentsAutoGetNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MailAttachmentsAutoGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MailAttachmentsAutoGetNetTask.<>f__mg$cache1, typeof(MailAttachmentsAutoGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04015D2C RID: 89388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015D2D RID: 89389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
