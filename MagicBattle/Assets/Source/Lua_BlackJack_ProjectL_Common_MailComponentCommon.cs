using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200124E RID: 4686
[Preserve]
public class Lua_BlackJack_ProjectL_Common_MailComponentCommon : LuaObject
{
	// Token: 0x060185C7 RID: 99783 RVA: 0x006D1FE8 File Offset: 0x006D01E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon o = new MailComponentCommon();
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

	// Token: 0x060185C8 RID: 99784 RVA: 0x006D2030 File Offset: 0x006D0230
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			string name = mailComponentCommon.GetName();
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

	// Token: 0x060185C9 RID: 99785 RVA: 0x006D2084 File Offset: 0x006D0284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			mailComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185CA RID: 99786 RVA: 0x006D20D0 File Offset: 0x006D02D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			mailComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185CB RID: 99787 RVA: 0x006D211C File Offset: 0x006D031C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			mailComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185CC RID: 99788 RVA: 0x006D2168 File Offset: 0x006D0368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			mailComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185CD RID: 99789 RVA: 0x006D21C0 File Offset: 0x006D03C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			mailComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185CE RID: 99790 RVA: 0x006D220C File Offset: 0x006D040C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMails(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			List<Mail> mails = mailComponentCommon.GetMails();
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

	// Token: 0x060185CF RID: 99791 RVA: 0x006D2260 File Offset: 0x006D0460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Find(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			Mail o = mailComponentCommon.Find(instanceId);
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

	// Token: 0x060185D0 RID: 99792 RVA: 0x006D22C4 File Offset: 0x006D04C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTemplateMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponentCommon.IsTemplateMail(mail);
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

	// Token: 0x060185D1 RID: 99793 RVA: 0x006D2328 File Offset: 0x006D0528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail newMail;
			LuaObject.checkType<Mail>(l, 2, out newMail);
			int i = mailComponentCommon.AddMail(newMail);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185D2 RID: 99794 RVA: 0x006D238C File Offset: 0x006D058C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMailBoxFull(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			bool b = mailComponentCommon.IsMailBoxFull();
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

	// Token: 0x060185D3 RID: 99795 RVA: 0x006D23E0 File Offset: 0x006D05E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int i = mailComponentCommon.RemoveMail(instanceId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185D4 RID: 99796 RVA: 0x006D2444 File Offset: 0x006D0644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReadMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int i = mailComponentCommon.ReadMail(instanceId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185D5 RID: 99797 RVA: 0x006D24A8 File Offset: 0x006D06A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMailAttachments(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			bool checkBag;
			LuaObject.checkType(l, 3, out checkBag);
			int mailAttachments = mailComponentCommon.GetMailAttachments(instanceId, checkBag);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailAttachments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185D6 RID: 99798 RVA: 0x006D2518 File Offset: 0x006D0718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoGetMailAttachment(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			bool checkBag;
			LuaObject.checkType(l, 2, out checkBag);
			int i = mailComponentCommon.AutoGetMailAttachment(checkBag);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185D7 RID: 99799 RVA: 0x006D257C File Offset: 0x006D077C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGetMailAttachment(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			ulong missioId;
			LuaObject.checkType(l, 2, out missioId);
			bool checkBag;
			LuaObject.checkType(l, 3, out checkBag);
			int i = mailComponentCommon.CanGetMailAttachment(missioId, checkBag);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185D8 RID: 99800 RVA: 0x006D25EC File Offset: 0x006D07EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMailExpired(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponentCommon.IsMailExpired(mail);
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

	// Token: 0x060185D9 RID: 99801 RVA: 0x006D2650 File Offset: 0x006D0850
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetMailExpiredTimeSpan(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			TimeSpan mailExpiredTimeSpan = mailComponentCommon.GetMailExpiredTimeSpan(mail);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailExpiredTimeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185DA RID: 99802 RVA: 0x006D26B8 File Offset: 0x006D08B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsMailReaded(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponentCommon.IsMailReaded(mail);
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

	// Token: 0x060185DB RID: 99803 RVA: 0x006D271C File Offset: 0x006D091C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasGotMailAttachments(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponentCommon.HasGotMailAttachments(mail);
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

	// Token: 0x060185DC RID: 99804 RVA: 0x006D2780 File Offset: 0x006D0980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsExistMailAttacments(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponentCommon.IsExistMailAttacments(mail);
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

	// Token: 0x060185DD RID: 99805 RVA: 0x006D27E4 File Offset: 0x006D09E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsMailInitCompleted(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponentCommon.m_luaExportHelper.IsMailInitCompleted(mail);
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

	// Token: 0x060185DE RID: 99806 RVA: 0x006D284C File Offset: 0x006D0A4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsTemplateMailInitCompleted(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponentCommon.m_luaExportHelper.IsTemplateMailInitCompleted(mail);
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

	// Token: 0x060185DF RID: 99807 RVA: 0x006D28B4 File Offset: 0x006D0AB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRealMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			Mail realMail = mailComponentCommon.m_luaExportHelper.GetRealMail(mail);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realMail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185E0 RID: 99808 RVA: 0x006D291C File Offset: 0x006D0B1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetContent(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			string content = mailComponentCommon.m_luaExportHelper.GetContent(mail);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185E1 RID: 99809 RVA: 0x006D2984 File Offset: 0x006D0B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTemplateMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			Mail o = mailComponentCommon.m_luaExportHelper.InitTemplateMail(mail);
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

	// Token: 0x060185E2 RID: 99810 RVA: 0x006D29EC File Offset: 0x006D0BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveEarliestMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			mailComponentCommon.m_luaExportHelper.RemoveEarliestMail();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185E3 RID: 99811 RVA: 0x006D2A40 File Offset: 0x006D0C40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllCanGetAttachmentMails(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			List<Mail> allCanGetAttachmentMails = mailComponentCommon.m_luaExportHelper.GetAllCanGetAttachmentMails();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allCanGetAttachmentMails);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185E4 RID: 99812 RVA: 0x006D2A9C File Offset: 0x006D0C9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGetMailAttachments(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			mailComponentCommon.m_luaExportHelper.OnGetMailAttachments(mail);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185E5 RID: 99813 RVA: 0x006D2AF8 File Offset: 0x006D0CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GenerateAttachmentRewards(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			mailComponentCommon.m_luaExportHelper.GenerateAttachmentRewards(mail);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185E6 RID: 99814 RVA: 0x006D2B54 File Offset: 0x006D0D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveExpiredMails(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			int i = mailComponentCommon.m_luaExportHelper.RemoveExpiredMails();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185E7 RID: 99815 RVA: 0x006D2BB0 File Offset: 0x006D0DB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185E8 RID: 99816 RVA: 0x006D2C08 File Offset: 0x006D0E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			mailComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185E9 RID: 99817 RVA: 0x006D2C64 File Offset: 0x006D0E64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_changedGoods(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailComponentCommon.m_luaExportHelper.m_changedGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185EA RID: 99818 RVA: 0x006D2CBC File Offset: 0x006D0EBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_changedGoods(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			List<BagItemBase> changedGoods;
			LuaObject.checkType<List<BagItemBase>>(l, 2, out changedGoods);
			mailComponentCommon.m_luaExportHelper.m_changedGoods = changedGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185EB RID: 99819 RVA: 0x006D2D18 File Offset: 0x006D0F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185EC RID: 99820 RVA: 0x006D2D70 File Offset: 0x006D0F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			mailComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185ED RID: 99821 RVA: 0x006D2DCC File Offset: 0x006D0FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185EE RID: 99822 RVA: 0x006D2E24 File Offset: 0x006D1024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			mailComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185EF RID: 99823 RVA: 0x006D2E80 File Offset: 0x006D1080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mailDS(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailComponentCommon.m_luaExportHelper.m_mailDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185F0 RID: 99824 RVA: 0x006D2ED8 File Offset: 0x006D10D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mailDS(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			DataSectionMail mailDS;
			LuaObject.checkType<DataSectionMail>(l, 2, out mailDS);
			mailComponentCommon.m_luaExportHelper.m_mailDS = mailDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185F1 RID: 99825 RVA: 0x006D2F34 File Offset: 0x006D1134
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185F2 RID: 99826 RVA: 0x006D2F88 File Offset: 0x006D1188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			MailComponentCommon mailComponentCommon = (MailComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			mailComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185F3 RID: 99827 RVA: 0x006D2FE0 File Offset: 0x006D11E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.MailComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.GetMails);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.Find);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.IsTemplateMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.AddMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.IsMailBoxFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.RemoveMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.ReadMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.GetMailAttachments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.AutoGetMailAttachment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.CanGetMailAttachment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.IsMailExpired);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.GetMailExpiredTimeSpan);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.IsMailReaded);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.HasGotMailAttachments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.IsExistMailAttacments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.IsMailInitCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.IsTemplateMailInitCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.GetRealMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.GetContent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.InitTemplateMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.RemoveEarliestMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.GetAllCanGetAttachmentMails);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.OnGetMailAttachments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.GenerateAttachmentRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.RemoveExpiredMails);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1E);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache20, true);
		string name2 = "m_changedGoods";
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.get_m_changedGoods);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.set_m_changedGoods);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache22, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache24, true);
		string name4 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.get_m_bag);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache26, true);
		string name5 = "m_mailDS";
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.get_m_mailDS);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.set_m_mailDS);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache28, true);
		string name6 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.get_Owner);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache2A, true);
		if (Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_MailComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_MailComponentCommon.<>f__mg$cache2B, typeof(MailComponentCommon));
	}

	// Token: 0x0400EB0D RID: 60173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EB0E RID: 60174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EB0F RID: 60175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EB10 RID: 60176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EB11 RID: 60177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EB12 RID: 60178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EB13 RID: 60179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EB14 RID: 60180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EB15 RID: 60181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EB16 RID: 60182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EB17 RID: 60183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EB18 RID: 60184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EB19 RID: 60185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EB1A RID: 60186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EB1B RID: 60187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EB1C RID: 60188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EB1D RID: 60189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EB1E RID: 60190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EB1F RID: 60191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EB20 RID: 60192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EB21 RID: 60193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EB22 RID: 60194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EB23 RID: 60195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EB24 RID: 60196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EB25 RID: 60197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EB26 RID: 60198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EB27 RID: 60199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EB28 RID: 60200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EB29 RID: 60201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EB2A RID: 60202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EB2B RID: 60203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EB2C RID: 60204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EB2D RID: 60205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EB2E RID: 60206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EB2F RID: 60207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EB30 RID: 60208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EB31 RID: 60209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EB32 RID: 60210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EB33 RID: 60211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EB34 RID: 60212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EB35 RID: 60213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EB36 RID: 60214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400EB37 RID: 60215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400EB38 RID: 60216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
