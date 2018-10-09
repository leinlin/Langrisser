using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200124F RID: 4687
[Preserve]
public class Lua_BlackJack_ProjectL_Common_Marquee : LuaObject
{
	// Token: 0x060185F5 RID: 99829 RVA: 0x006D3610 File Offset: 0x006D1810
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Marquee o = new Marquee();
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

	// Token: 0x060185F6 RID: 99830 RVA: 0x006D3658 File Offset: 0x006D1858
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBToMarquee_s(IntPtr l)
	{
		int result;
		try
		{
			ProMarquee pbMarquee;
			LuaObject.checkType<ProMarquee>(l, 1, out pbMarquee);
			Marquee o = Marquee.PBToMarquee(pbMarquee);
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

	// Token: 0x060185F7 RID: 99831 RVA: 0x006D36AC File Offset: 0x006D18AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPBMarquee_s(IntPtr l)
	{
		int result;
		try
		{
			Marquee marquee;
			LuaObject.checkType<Marquee>(l, 1, out marquee);
			ProMarquee o = Marquee.ToPBMarquee(marquee);
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

	// Token: 0x060185F8 RID: 99832 RVA: 0x006D3700 File Offset: 0x006D1900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SendTime(IntPtr l)
	{
		int result;
		try
		{
			Marquee marquee = (Marquee)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, marquee.SendTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185F9 RID: 99833 RVA: 0x006D3758 File Offset: 0x006D1958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SendTime(IntPtr l)
	{
		int result;
		try
		{
			Marquee marquee = (Marquee)LuaObject.checkSelf(l);
			DateTime sendTime;
			LuaObject.checkValueType<DateTime>(l, 2, out sendTime);
			marquee.SendTime = sendTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185FA RID: 99834 RVA: 0x006D37B0 File Offset: 0x006D19B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Title(IntPtr l)
	{
		int result;
		try
		{
			Marquee marquee = (Marquee)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, marquee.Title);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185FB RID: 99835 RVA: 0x006D3804 File Offset: 0x006D1A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Title(IntPtr l)
	{
		int result;
		try
		{
			Marquee marquee = (Marquee)LuaObject.checkSelf(l);
			string title;
			LuaObject.checkType(l, 2, out title);
			marquee.Title = title;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185FC RID: 99836 RVA: 0x006D385C File Offset: 0x006D1A5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Content(IntPtr l)
	{
		int result;
		try
		{
			Marquee marquee = (Marquee)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, marquee.Content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185FD RID: 99837 RVA: 0x006D38B0 File Offset: 0x006D1AB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Content(IntPtr l)
	{
		int result;
		try
		{
			Marquee marquee = (Marquee)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			marquee.Content = content;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185FE RID: 99838 RVA: 0x006D3908 File Offset: 0x006D1B08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.Marquee");
		if (Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Marquee.PBToMarquee_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Marquee.ToPBMarquee_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache1);
		string name = "SendTime";
		if (Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Marquee.get_SendTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Marquee.set_SendTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache3, true);
		string name2 = "Title";
		if (Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Marquee.get_Title);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Marquee.set_Title);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache5, true);
		string name3 = "Content";
		if (Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Marquee.get_Content);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Marquee.set_Content);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Marquee.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_Marquee.<>f__mg$cache8, typeof(Marquee));
	}

	// Token: 0x0400EB39 RID: 60217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EB3A RID: 60218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EB3B RID: 60219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EB3C RID: 60220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EB3D RID: 60221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EB3E RID: 60222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EB3F RID: 60223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EB40 RID: 60224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EB41 RID: 60225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
