using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014F9 RID: 5369
[Preserve]
public class Lua_BlackJack_ProjectL_UI_LoginAnnouncement : LuaObject
{
	// Token: 0x0601FB3D RID: 129853 RVA: 0x00A71220 File Offset: 0x00A6F420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LoginAnnouncement.AnnounceType type;
			LuaObject.checkEnum<LoginAnnouncement.AnnounceType>(l, 2, out type);
			string title;
			LuaObject.checkType(l, 3, out title);
			string content;
			LuaObject.checkType(l, 4, out content);
			LoginAnnouncement o = new LoginAnnouncement(type, title, content);
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

	// Token: 0x0601FB3E RID: 129854 RVA: 0x00A71290 File Offset: 0x00A6F490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Title(IntPtr l)
	{
		int result;
		try
		{
			LoginAnnouncement loginAnnouncement = (LoginAnnouncement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginAnnouncement.Title);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB3F RID: 129855 RVA: 0x00A712E4 File Offset: 0x00A6F4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Title(IntPtr l)
	{
		int result;
		try
		{
			LoginAnnouncement loginAnnouncement = (LoginAnnouncement)LuaObject.checkSelf(l);
			string title;
			LuaObject.checkType(l, 2, out title);
			loginAnnouncement.Title = title;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB40 RID: 129856 RVA: 0x00A7133C File Offset: 0x00A6F53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Content(IntPtr l)
	{
		int result;
		try
		{
			LoginAnnouncement loginAnnouncement = (LoginAnnouncement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginAnnouncement.Content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB41 RID: 129857 RVA: 0x00A71390 File Offset: 0x00A6F590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Content(IntPtr l)
	{
		int result;
		try
		{
			LoginAnnouncement loginAnnouncement = (LoginAnnouncement)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			loginAnnouncement.Content = content;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB42 RID: 129858 RVA: 0x00A713E8 File Offset: 0x00A6F5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CurrentType(IntPtr l)
	{
		int result;
		try
		{
			LoginAnnouncement loginAnnouncement = (LoginAnnouncement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)loginAnnouncement.CurrentType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB43 RID: 129859 RVA: 0x00A7143C File Offset: 0x00A6F63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CurrentType(IntPtr l)
	{
		int result;
		try
		{
			LoginAnnouncement loginAnnouncement = (LoginAnnouncement)LuaObject.checkSelf(l);
			LoginAnnouncement.AnnounceType currentType;
			LuaObject.checkEnum<LoginAnnouncement.AnnounceType>(l, 2, out currentType);
			loginAnnouncement.CurrentType = currentType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB44 RID: 129860 RVA: 0x00A71494 File Offset: 0x00A6F694
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.LoginAnnouncement");
		string name = "Title";
		if (Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginAnnouncement.get_Title);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginAnnouncement.set_Title);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache1, true);
		string name2 = "Content";
		if (Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginAnnouncement.get_Content);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginAnnouncement.set_Content);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache3, true);
		string name3 = "CurrentType";
		if (Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginAnnouncement.get_CurrentType);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginAnnouncement.set_CurrentType);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_LoginAnnouncement.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_LoginAnnouncement.<>f__mg$cache6, typeof(LoginAnnouncement));
	}

	// Token: 0x04015B2D RID: 88877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015B2E RID: 88878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015B2F RID: 88879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015B30 RID: 88880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015B31 RID: 88881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015B32 RID: 88882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015B33 RID: 88883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
