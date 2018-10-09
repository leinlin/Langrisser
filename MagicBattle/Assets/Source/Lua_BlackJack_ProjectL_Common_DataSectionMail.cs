using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001205 RID: 4613
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionMail : LuaObject
{
	// Token: 0x06017EE8 RID: 98024 RVA: 0x0069ED84 File Offset: 0x0069CF84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail o = new DataSectionMail();
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

	// Token: 0x06017EE9 RID: 98025 RVA: 0x0069EDCC File Offset: 0x0069CFCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			object o = dataSectionMail.SerializeToClient();
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

	// Token: 0x06017EEA RID: 98026 RVA: 0x0069EE20 File Offset: 0x0069D020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			dataSectionMail.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EEB RID: 98027 RVA: 0x0069EE6C File Offset: 0x0069D06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMailReaded(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = dataSectionMail.IsMailReaded(mail);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EEC RID: 98028 RVA: 0x0069EED0 File Offset: 0x0069D0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMail(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			Mail o = dataSectionMail.AddMail(mail);
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

	// Token: 0x06017EED RID: 98029 RVA: 0x0069EF34 File Offset: 0x0069D134
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitMail(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			dataSectionMail.InitMail(mail);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EEE RID: 98030 RVA: 0x0069EF8C File Offset: 0x0069D18C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveMail(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			dataSectionMail.RemoveMail(mail);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EEF RID: 98031 RVA: 0x0069EFE4 File Offset: 0x0069D1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearMailBox(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			dataSectionMail.ClearMailBox();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EF0 RID: 98032 RVA: 0x0069F030 File Offset: 0x0069D230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindMail(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			Mail o = dataSectionMail.FindMail(instanceId);
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

	// Token: 0x06017EF1 RID: 98033 RVA: 0x0069F094 File Offset: 0x0069D294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReadMail(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			DateTime current;
			LuaObject.checkValueType<DateTime>(l, 3, out current);
			dataSectionMail.ReadMail(mail, current);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EF2 RID: 98034 RVA: 0x0069F0F8 File Offset: 0x0069D2F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGotAttachments(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			DateTime current;
			LuaObject.checkValueType<DateTime>(l, 3, out current);
			dataSectionMail.SetGotAttachments(mail, current);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EF3 RID: 98035 RVA: 0x0069F15C File Offset: 0x0069D35C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitGlobalMailId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			int value;
			LuaObject.checkType(l, 2, out value);
			dataSectionMail.InitGlobalMailId(value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EF4 RID: 98036 RVA: 0x0069F1B4 File Offset: 0x0069D3B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGlobalMailId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			int globalMailId;
			LuaObject.checkType(l, 2, out globalMailId);
			dataSectionMail.SetGlobalMailId(globalMailId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EF5 RID: 98037 RVA: 0x0069F20C File Offset: 0x0069D40C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFirstMail(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			Mail firstMail = dataSectionMail.GetFirstMail();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, firstMail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EF6 RID: 98038 RVA: 0x0069F260 File Offset: 0x0069D460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMailBoxSize(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			int mailBoxSize = dataSectionMail.GetMailBoxSize();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailBoxSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EF7 RID: 98039 RVA: 0x0069F2B4 File Offset: 0x0069D4B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMails(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			List<Mail> mails = dataSectionMail.GetMails();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mails);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EF8 RID: 98040 RVA: 0x0069F308 File Offset: 0x0069D508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GlobalMailId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMail dataSectionMail = (DataSectionMail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionMail.GlobalMailId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EF9 RID: 98041 RVA: 0x0069F35C File Offset: 0x0069D55C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionMail");
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.IsMailReaded);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.AddMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.InitMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.RemoveMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.ClearMailBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.FindMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.ReadMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.SetGotAttachments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.InitGlobalMailId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.SetGlobalMailId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.GetFirstMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.GetMailBoxSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.GetMails);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheE);
		string name = "GlobalMailId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.get_GlobalMailId);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cacheF, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMail.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionMail.<>f__mg$cache10, typeof(DataSectionMail), typeof(DataSection));
	}

	// Token: 0x0400E4C0 RID: 58560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E4C1 RID: 58561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E4C2 RID: 58562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E4C3 RID: 58563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E4C4 RID: 58564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E4C5 RID: 58565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E4C6 RID: 58566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E4C7 RID: 58567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E4C8 RID: 58568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E4C9 RID: 58569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E4CA RID: 58570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E4CB RID: 58571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E4CC RID: 58572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E4CD RID: 58573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E4CE RID: 58574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E4CF RID: 58575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E4D0 RID: 58576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
