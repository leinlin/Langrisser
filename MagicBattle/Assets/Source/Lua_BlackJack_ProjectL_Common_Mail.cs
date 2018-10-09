using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200124D RID: 4685
[Preserve]
public class Lua_BlackJack_ProjectL_Common_Mail : LuaObject
{
	// Token: 0x060185A4 RID: 99748 RVA: 0x006D0FE0 File Offset: 0x006CF1E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Mail o = new Mail();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				Mail sourceMail;
				LuaObject.checkType<Mail>(l, 2, out sourceMail);
				Mail o = new Mail(sourceMail);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185A5 RID: 99749 RVA: 0x006D1078 File Offset: 0x006CF278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MailToPBMail_s(IntPtr l)
	{
		int result;
		try
		{
			Mail mail;
			LuaObject.checkType<Mail>(l, 1, out mail);
			ProMail o = Mail.MailToPBMail(mail);
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

	// Token: 0x060185A6 RID: 99750 RVA: 0x006D10CC File Offset: 0x006CF2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MailsToPBMails_s(IntPtr l)
	{
		int result;
		try
		{
			List<Mail> mails;
			LuaObject.checkType<List<Mail>>(l, 1, out mails);
			List<ProMail> o = Mail.MailsToPBMails(mails);
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

	// Token: 0x060185A7 RID: 99751 RVA: 0x006D1120 File Offset: 0x006CF320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBMailToMail_s(IntPtr l)
	{
		int result;
		try
		{
			ProMail pbMail;
			LuaObject.checkType<ProMail>(l, 1, out pbMail);
			Mail o = Mail.PBMailToMail(pbMail);
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

	// Token: 0x060185A8 RID: 99752 RVA: 0x006D1174 File Offset: 0x006CF374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBMailsToMails_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProMail> pbMails;
			LuaObject.checkType<List<ProMail>>(l, 1, out pbMails);
			List<Mail> o = Mail.PBMailsToMails(pbMails);
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

	// Token: 0x060185A9 RID: 99753 RVA: 0x006D11C8 File Offset: 0x006CF3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Attachments(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.Attachments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185AA RID: 99754 RVA: 0x006D121C File Offset: 0x006CF41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Attachments(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			List<Goods> attachments;
			LuaObject.checkType<List<Goods>>(l, 2, out attachments);
			mail.Attachments = attachments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185AB RID: 99755 RVA: 0x006D1274 File Offset: 0x006CF474
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TemplateAttachments(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.TemplateAttachments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185AC RID: 99756 RVA: 0x006D12C8 File Offset: 0x006CF4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TemplateAttachments(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			List<Goods> templateAttachments;
			LuaObject.checkType<List<Goods>>(l, 2, out templateAttachments);
			mail.TemplateAttachments = templateAttachments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185AD RID: 99757 RVA: 0x006D1320 File Offset: 0x006CF520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TemplateId(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.TemplateId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185AE RID: 99758 RVA: 0x006D1374 File Offset: 0x006CF574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TemplateId(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			int templateId;
			LuaObject.checkType(l, 2, out templateId);
			mail.TemplateId = templateId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185AF RID: 99759 RVA: 0x006D13CC File Offset: 0x006CF5CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MailTypeId(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)mail.MailTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185B0 RID: 99760 RVA: 0x006D1420 File Offset: 0x006CF620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MailTypeId(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			MailType mailTypeId;
			LuaObject.checkEnum<MailType>(l, 2, out mailTypeId);
			mail.MailTypeId = mailTypeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185B1 RID: 99761 RVA: 0x006D1478 File Offset: 0x006CF678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.InstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185B2 RID: 99762 RVA: 0x006D14CC File Offset: 0x006CF6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			mail.InstanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185B3 RID: 99763 RVA: 0x006D1524 File Offset: 0x006CF724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Status(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.Status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185B4 RID: 99764 RVA: 0x006D1578 File Offset: 0x006CF778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Status(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			int status;
			LuaObject.checkType(l, 2, out status);
			mail.Status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185B5 RID: 99765 RVA: 0x006D15D0 File Offset: 0x006CF7D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Title(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.Title);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185B6 RID: 99766 RVA: 0x006D1624 File Offset: 0x006CF824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Title(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			string title;
			LuaObject.checkType(l, 2, out title);
			mail.Title = title;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185B7 RID: 99767 RVA: 0x006D167C File Offset: 0x006CF87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Content(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.Content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185B8 RID: 99768 RVA: 0x006D16D0 File Offset: 0x006CF8D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Content(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			mail.Content = content;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185B9 RID: 99769 RVA: 0x006D1728 File Offset: 0x006CF928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SendTime(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.SendTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185BA RID: 99770 RVA: 0x006D1780 File Offset: 0x006CF980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SendTime(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			DateTime sendTime;
			LuaObject.checkValueType<DateTime>(l, 2, out sendTime);
			mail.SendTime = sendTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185BB RID: 99771 RVA: 0x006D17D8 File Offset: 0x006CF9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReadedOrGotAttachmentTime(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.ReadedOrGotAttachmentTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185BC RID: 99772 RVA: 0x006D1830 File Offset: 0x006CFA30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ReadedOrGotAttachmentTime(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			DateTime readedOrGotAttachmentTime;
			LuaObject.checkValueType<DateTime>(l, 2, out readedOrGotAttachmentTime);
			mail.ReadedOrGotAttachmentTime = readedOrGotAttachmentTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185BD RID: 99773 RVA: 0x006D1888 File Offset: 0x006CFA88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.ExpiredTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185BE RID: 99774 RVA: 0x006D18DC File Offset: 0x006CFADC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			uint expiredTime;
			LuaObject.checkType(l, 2, out expiredTime);
			mail.ExpiredTime = expiredTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185BF RID: 99775 RVA: 0x006D1934 File Offset: 0x006CFB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReadedExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.ReadedExpiredTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185C0 RID: 99776 RVA: 0x006D1988 File Offset: 0x006CFB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ReadedExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			int readedExpiredTime;
			LuaObject.checkType(l, 2, out readedExpiredTime);
			mail.ReadedExpiredTime = readedExpiredTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185C1 RID: 99777 RVA: 0x006D19E0 File Offset: 0x006CFBE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GotDeleted(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.GotDeleted);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185C2 RID: 99778 RVA: 0x006D1A34 File Offset: 0x006CFC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GotDeleted(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			bool gotDeleted;
			LuaObject.checkType(l, 2, out gotDeleted);
			mail.GotDeleted = gotDeleted;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185C3 RID: 99779 RVA: 0x006D1A8C File Offset: 0x006CFC8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TemplateMailConfig(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mail.TemplateMailConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185C4 RID: 99780 RVA: 0x006D1AE0 File Offset: 0x006CFCE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TemplateMailConfig(IntPtr l)
	{
		int result;
		try
		{
			Mail mail = (Mail)LuaObject.checkSelf(l);
			ConfigDataMailInfo templateMailConfig;
			LuaObject.checkType<ConfigDataMailInfo>(l, 2, out templateMailConfig);
			mail.TemplateMailConfig = templateMailConfig;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185C5 RID: 99781 RVA: 0x006D1B38 File Offset: 0x006CFD38
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.Mail");
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.MailToPBMail_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.MailsToPBMails_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.PBMailToMail_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.PBMailsToMails_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache3);
		string name = "Attachments";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_Attachments);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_Attachments);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache5, true);
		string name2 = "TemplateAttachments";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_TemplateAttachments);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_TemplateAttachments);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache7, true);
		string name3 = "TemplateId";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_TemplateId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_TemplateId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache9, true);
		string name4 = "MailTypeId";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_MailTypeId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_MailTypeId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheB, true);
		string name5 = "InstanceId";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_InstanceId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_InstanceId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheD, true);
		string name6 = "Status";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_Status);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_Status);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cacheF, true);
		string name7 = "Title";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_Title);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_Title);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache11, true);
		string name8 = "Content";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_Content);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_Content);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache13, true);
		string name9 = "SendTime";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_SendTime);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_SendTime);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache15, true);
		string name10 = "ReadedOrGotAttachmentTime";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_ReadedOrGotAttachmentTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_ReadedOrGotAttachmentTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache17, true);
		string name11 = "ExpiredTime";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_ExpiredTime);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_ExpiredTime);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache19, true);
		string name12 = "ReadedExpiredTime";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_ReadedExpiredTime);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_ReadedExpiredTime);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1B, true);
		string name13 = "GotDeleted";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_GotDeleted);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_GotDeleted);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1D, true);
		string name14 = "TemplateMailConfig";
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.get_TemplateMailConfig);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.set_TemplateMailConfig);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache1F, true);
		if (Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Mail.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_Mail.<>f__mg$cache20, typeof(Mail));
	}

	// Token: 0x0400EAEC RID: 60140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EAED RID: 60141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EAEE RID: 60142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EAEF RID: 60143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EAF0 RID: 60144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EAF1 RID: 60145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EAF2 RID: 60146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EAF3 RID: 60147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EAF4 RID: 60148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EAF5 RID: 60149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EAF6 RID: 60150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EAF7 RID: 60151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EAF8 RID: 60152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EAF9 RID: 60153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EAFA RID: 60154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EAFB RID: 60155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EAFC RID: 60156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EAFD RID: 60157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EAFE RID: 60158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EAFF RID: 60159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EB00 RID: 60160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EB01 RID: 60161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EB02 RID: 60162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EB03 RID: 60163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EB04 RID: 60164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EB05 RID: 60165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EB06 RID: 60166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EB07 RID: 60167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EB08 RID: 60168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EB09 RID: 60169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EB0A RID: 60170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EB0B RID: 60171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EB0C RID: 60172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;
}
