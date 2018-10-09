using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012D0 RID: 4816
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_MailComponent : LuaObject
{
	// Token: 0x0601967A RID: 104058 RVA: 0x0074F548 File Offset: 0x0074D748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MailComponent o = new MailComponent();
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

	// Token: 0x0601967B RID: 104059 RVA: 0x0074F590 File Offset: 0x0074D790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			mailComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601967C RID: 104060 RVA: 0x0074F5DC File Offset: 0x0074D7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			mailComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601967D RID: 104061 RVA: 0x0074F628 File Offset: 0x0074D828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			mailComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601967E RID: 104062 RVA: 0x0074F674 File Offset: 0x0074D874
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			DSMailNtf msg;
			LuaObject.checkType<DSMailNtf>(l, 2, out msg);
			mailComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601967F RID: 104063 RVA: 0x0074F6CC File Offset: 0x0074D8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			ushort dsversion = mailComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019680 RID: 104064 RVA: 0x0074F720 File Offset: 0x0074D920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitMails(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			List<ProMail> pbMails;
			LuaObject.checkType<List<ProMail>>(l, 2, out pbMails);
			mailComponent.InitMails(pbMails);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019681 RID: 104065 RVA: 0x0074F778 File Offset: 0x0074D978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAutoGetMailAttachment(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			int i = mailComponent.CanAutoGetMailAttachment();
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

	// Token: 0x06019682 RID: 104066 RVA: 0x0074F7CC File Offset: 0x0074D9CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsOfficialMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponent.IsOfficialMail(mail);
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

	// Token: 0x06019683 RID: 104067 RVA: 0x0074F830 File Offset: 0x0074DA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRealMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			Mail realMail = mailComponent.m_luaExportHelper.GetRealMail(mail);
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

	// Token: 0x06019684 RID: 104068 RVA: 0x0074F898 File Offset: 0x0074DA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTemplateMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			Mail o = mailComponent.m_luaExportHelper.InitTemplateMail(mail);
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

	// Token: 0x06019685 RID: 104069 RVA: 0x0074F900 File Offset: 0x0074DB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			string s = mailComponent.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019686 RID: 104070 RVA: 0x0074F95C File Offset: 0x0074DB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			mailComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019687 RID: 104071 RVA: 0x0074F9B0 File Offset: 0x0074DBB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			mailComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019688 RID: 104072 RVA: 0x0074FA04 File Offset: 0x0074DC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			mailComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019689 RID: 104073 RVA: 0x0074FA58 File Offset: 0x0074DC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			mailComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601968A RID: 104074 RVA: 0x0074FAB4 File Offset: 0x0074DCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			mailComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601968B RID: 104075 RVA: 0x0074FB08 File Offset: 0x0074DD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetMails(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			List<Mail> o = mailComponent.m_luaExportHelper.__callBase_GetMails();
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

	// Token: 0x0601968C RID: 104076 RVA: 0x0074FB64 File Offset: 0x0074DD64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Find(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			Mail o = mailComponent.m_luaExportHelper.__callBase_Find(instanceId);
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

	// Token: 0x0601968D RID: 104077 RVA: 0x0074FBCC File Offset: 0x0074DDCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsMailInitCompleted(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponent.m_luaExportHelper.__callBase_IsMailInitCompleted(mail);
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

	// Token: 0x0601968E RID: 104078 RVA: 0x0074FC34 File Offset: 0x0074DE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetRealMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			Mail o = mailComponent.m_luaExportHelper.__callBase_GetRealMail(mail);
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

	// Token: 0x0601968F RID: 104079 RVA: 0x0074FC9C File Offset: 0x0074DE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetContent(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			string s = mailComponent.m_luaExportHelper.__callBase_GetContent(mail);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019690 RID: 104080 RVA: 0x0074FD04 File Offset: 0x0074DF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitTemplateMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			Mail o = mailComponent.m_luaExportHelper.__callBase_InitTemplateMail(mail);
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

	// Token: 0x06019691 RID: 104081 RVA: 0x0074FD6C File Offset: 0x0074DF6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsTemplateMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponent.m_luaExportHelper.__callBase_IsTemplateMail(mail);
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

	// Token: 0x06019692 RID: 104082 RVA: 0x0074FDD4 File Offset: 0x0074DFD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail newMail;
			LuaObject.checkType<Mail>(l, 2, out newMail);
			int i = mailComponent.m_luaExportHelper.__callBase_AddMail(newMail);
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

	// Token: 0x06019693 RID: 104083 RVA: 0x0074FE3C File Offset: 0x0074E03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsMailBoxFull(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			bool b = mailComponent.m_luaExportHelper.__callBase_IsMailBoxFull();
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

	// Token: 0x06019694 RID: 104084 RVA: 0x0074FE98 File Offset: 0x0074E098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int i = mailComponent.m_luaExportHelper.__callBase_RemoveMail(instanceId);
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

	// Token: 0x06019695 RID: 104085 RVA: 0x0074FF00 File Offset: 0x0074E100
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReadMail(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int i = mailComponent.m_luaExportHelper.__callBase_ReadMail(instanceId);
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

	// Token: 0x06019696 RID: 104086 RVA: 0x0074FF68 File Offset: 0x0074E168
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetMailAttachments(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			bool checkBag;
			LuaObject.checkType(l, 3, out checkBag);
			int i = mailComponent.m_luaExportHelper.__callBase_GetMailAttachments(instanceId, checkBag);
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

	// Token: 0x06019697 RID: 104087 RVA: 0x0074FFDC File Offset: 0x0074E1DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllCanGetAttachmentMails(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			List<Mail> o = mailComponent.m_luaExportHelper.__callBase_GetAllCanGetAttachmentMails();
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

	// Token: 0x06019698 RID: 104088 RVA: 0x00750038 File Offset: 0x0074E238
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AutoGetMailAttachment(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			bool checkBag;
			LuaObject.checkType(l, 2, out checkBag);
			int i = mailComponent.m_luaExportHelper.__callBase_AutoGetMailAttachment(checkBag);
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

	// Token: 0x06019699 RID: 104089 RVA: 0x007500A0 File Offset: 0x0074E2A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanGetMailAttachment(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			ulong missioId;
			LuaObject.checkType(l, 2, out missioId);
			bool checkBag;
			LuaObject.checkType(l, 3, out checkBag);
			int i = mailComponent.m_luaExportHelper.__callBase_CanGetMailAttachment(missioId, checkBag);
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

	// Token: 0x0601969A RID: 104090 RVA: 0x00750114 File Offset: 0x0074E314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnGetMailAttachments(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			mailComponent.m_luaExportHelper.__callBase_OnGetMailAttachments(mail);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601969B RID: 104091 RVA: 0x00750170 File Offset: 0x0074E370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GenerateAttachmentRewards(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			mailComponent.m_luaExportHelper.__callBase_GenerateAttachmentRewards(mail);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601969C RID: 104092 RVA: 0x007501CC File Offset: 0x0074E3CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsMailExpired(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponent.m_luaExportHelper.__callBase_IsMailExpired(mail);
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

	// Token: 0x0601969D RID: 104093 RVA: 0x00750234 File Offset: 0x0074E434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetMailExpiredTimeSpan(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			TimeSpan timeSpan = mailComponent.m_luaExportHelper.__callBase_GetMailExpiredTimeSpan(mail);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601969E RID: 104094 RVA: 0x007502A0 File Offset: 0x0074E4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveExpiredMails(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			int i = mailComponent.m_luaExportHelper.__callBase_RemoveExpiredMails();
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

	// Token: 0x0601969F RID: 104095 RVA: 0x007502FC File Offset: 0x0074E4FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsMailReaded(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponent.m_luaExportHelper.__callBase_IsMailReaded(mail);
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

	// Token: 0x060196A0 RID: 104096 RVA: 0x00750364 File Offset: 0x0074E564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasGotMailAttachments(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponent.m_luaExportHelper.__callBase_HasGotMailAttachments(mail);
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

	// Token: 0x060196A1 RID: 104097 RVA: 0x007503CC File Offset: 0x0074E5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsExistMailAttacments(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			Mail mail;
			LuaObject.checkType<Mail>(l, 2, out mail);
			bool b = mailComponent.m_luaExportHelper.__callBase_IsExistMailAttacments(mail);
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

	// Token: 0x060196A2 RID: 104098 RVA: 0x00750434 File Offset: 0x0074E634
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UnReadMailNums(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mailComponent.UnReadMailNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196A3 RID: 104099 RVA: 0x00750488 File Offset: 0x0074E688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UnReadMailNums(IntPtr l)
	{
		int result;
		try
		{
			MailComponent mailComponent = (MailComponent)LuaObject.checkSelf(l);
			int unReadMailNums;
			LuaObject.checkType(l, 2, out unReadMailNums);
			mailComponent.UnReadMailNums = unReadMailNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060196A4 RID: 104100 RVA: 0x007504E0 File Offset: 0x0074E6E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.MailComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.InitMails);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.CanAutoGetMailAttachment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.IsOfficialMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.GetRealMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.InitTemplateMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_GetMails);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_Find);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_IsMailInitCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_GetRealMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_GetContent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_InitTemplateMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_IsTemplateMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_AddMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_IsMailBoxFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_RemoveMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_ReadMail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_GetMailAttachments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_GetAllCanGetAttachmentMails);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_AutoGetMailAttachment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_CanGetMailAttachment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_OnGetMailAttachments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_GenerateAttachmentRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_IsMailExpired);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_GetMailExpiredTimeSpan);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_RemoveExpiredMails);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_IsMailReaded);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_HasGotMailAttachments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.__callBase_IsExistMailAttacments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache26);
		string name = "UnReadMailNums";
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.get_UnReadMailNums);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.set_UnReadMailNums);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache28, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_MailComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_MailComponent.<>f__mg$cache29, typeof(MailComponent), typeof(MailComponentCommon));
	}

	// Token: 0x0400FABC RID: 64188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FABD RID: 64189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FABE RID: 64190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FABF RID: 64191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FAC0 RID: 64192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FAC1 RID: 64193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FAC2 RID: 64194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FAC3 RID: 64195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400FAC4 RID: 64196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400FAC5 RID: 64197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400FAC6 RID: 64198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400FAC7 RID: 64199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400FAC8 RID: 64200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400FAC9 RID: 64201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400FACA RID: 64202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400FACB RID: 64203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400FACC RID: 64204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400FACD RID: 64205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400FACE RID: 64206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400FACF RID: 64207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400FAD0 RID: 64208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400FAD1 RID: 64209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400FAD2 RID: 64210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400FAD3 RID: 64211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400FAD4 RID: 64212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400FAD5 RID: 64213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400FAD6 RID: 64214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400FAD7 RID: 64215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400FAD8 RID: 64216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400FAD9 RID: 64217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400FADA RID: 64218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400FADB RID: 64219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400FADC RID: 64220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400FADD RID: 64221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400FADE RID: 64222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400FADF RID: 64223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400FAE0 RID: 64224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400FAE1 RID: 64225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400FAE2 RID: 64226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400FAE3 RID: 64227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400FAE4 RID: 64228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400FAE5 RID: 64229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
