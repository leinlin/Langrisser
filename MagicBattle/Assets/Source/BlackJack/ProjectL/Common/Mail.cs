using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000557 RID: 1367
	[CustomLuaClass]
	public class Mail
	{
		// Token: 0x06005015 RID: 20501 RVA: 0x001802DC File Offset: 0x0017E4DC
		public Mail()
		{
			this.InstanceId = 0UL;
			this.TemplateId = 0;
			this.Status = 0;
			this.Title = null;
			this.Content = null;
			this.SendTime = DateTime.Now;
			this.ExpiredTime = 0u;
			this.ReadedExpiredTime = 0;
			this.GotDeleted = false;
			this.TemplateMailConfig = null;
			this.ReadedOrGotAttachmentTime = DateTime.MinValue;
			this.MailTypeId = MailType.Normal;
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x00180364 File Offset: 0x0017E564
		public Mail(Mail sourceMail)
		{
			this.TemplateId = sourceMail.TemplateId;
			this.InstanceId = sourceMail.InstanceId;
			this.Status = sourceMail.Status;
			this.Title = sourceMail.Title;
			this.Content = sourceMail.Content;
			this.Attachments.AddRange(sourceMail.Attachments);
			this.TemplateAttachments.AddRange(sourceMail.TemplateAttachments);
			this.SendTime = sourceMail.SendTime;
			this.ReadedOrGotAttachmentTime = sourceMail.ReadedOrGotAttachmentTime;
			this.ExpiredTime = sourceMail.ExpiredTime;
			this.ReadedExpiredTime = sourceMail.ReadedExpiredTime;
			this.GotDeleted = sourceMail.GotDeleted;
			this.TemplateMailConfig = sourceMail.TemplateMailConfig;
			this.MailTypeId = sourceMail.MailTypeId;
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x06005017 RID: 20503 RVA: 0x00180440 File Offset: 0x0017E640
		// (set) Token: 0x06005018 RID: 20504 RVA: 0x00180448 File Offset: 0x0017E648
		public int TemplateId { get; set; }

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06005019 RID: 20505 RVA: 0x00180454 File Offset: 0x0017E654
		// (set) Token: 0x0600501A RID: 20506 RVA: 0x0018045C File Offset: 0x0017E65C
		public MailType MailTypeId { get; set; }

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x0600501B RID: 20507 RVA: 0x00180468 File Offset: 0x0017E668
		// (set) Token: 0x0600501C RID: 20508 RVA: 0x00180470 File Offset: 0x0017E670
		public ulong InstanceId { get; set; }

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x0600501D RID: 20509 RVA: 0x0018047C File Offset: 0x0017E67C
		// (set) Token: 0x0600501E RID: 20510 RVA: 0x00180484 File Offset: 0x0017E684
		public int Status { get; set; }

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x0600501F RID: 20511 RVA: 0x00180490 File Offset: 0x0017E690
		// (set) Token: 0x06005020 RID: 20512 RVA: 0x00180498 File Offset: 0x0017E698
		public string Title { get; set; }

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06005021 RID: 20513 RVA: 0x001804A4 File Offset: 0x0017E6A4
		// (set) Token: 0x06005022 RID: 20514 RVA: 0x001804AC File Offset: 0x0017E6AC
		public string Content { get; set; }

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x001804B8 File Offset: 0x0017E6B8
		// (set) Token: 0x06005024 RID: 20516 RVA: 0x001804C0 File Offset: 0x0017E6C0
		public DateTime SendTime { get; set; }

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06005025 RID: 20517 RVA: 0x001804CC File Offset: 0x0017E6CC
		// (set) Token: 0x06005026 RID: 20518 RVA: 0x001804D4 File Offset: 0x0017E6D4
		public DateTime ReadedOrGotAttachmentTime { get; set; }

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06005027 RID: 20519 RVA: 0x001804E0 File Offset: 0x0017E6E0
		// (set) Token: 0x06005028 RID: 20520 RVA: 0x001804E8 File Offset: 0x0017E6E8
		public uint ExpiredTime { get; set; }

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06005029 RID: 20521 RVA: 0x001804F4 File Offset: 0x0017E6F4
		// (set) Token: 0x0600502A RID: 20522 RVA: 0x001804FC File Offset: 0x0017E6FC
		public int ReadedExpiredTime { get; set; }

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x0600502B RID: 20523 RVA: 0x00180508 File Offset: 0x0017E708
		// (set) Token: 0x0600502C RID: 20524 RVA: 0x00180510 File Offset: 0x0017E710
		public bool GotDeleted { get; set; }

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x0600502D RID: 20525 RVA: 0x0018051C File Offset: 0x0017E71C
		// (set) Token: 0x0600502E RID: 20526 RVA: 0x00180524 File Offset: 0x0017E724
		public ConfigDataMailInfo TemplateMailConfig { get; set; }

		// Token: 0x0600502F RID: 20527 RVA: 0x00180530 File Offset: 0x0017E730
		public static ProMail MailToPBMail(Mail mail)
		{
			ProMail proMail = new ProMail();
			proMail.TemplateId = mail.TemplateId;
			proMail.InstanceId = mail.InstanceId;
			proMail.Status = mail.Status;
			proMail.SendTime = mail.SendTime.Ticks;
			proMail.ReadedOrGotAttachmentTime = mail.ReadedOrGotAttachmentTime.Ticks;
			proMail.MailTypeId = (int)mail.MailTypeId;
			proMail.Content = mail.Content;
			if (mail.TemplateMailConfig == null)
			{
				proMail.Title = mail.Title;
				proMail.ExpiredTime = mail.ExpiredTime;
				proMail.ReadedExpiredTime = mail.ReadedExpiredTime;
				proMail.GotDeleted = mail.GotDeleted;
			}
			proMail.Attachments.AddRange(BagItemBase.GoodsListToPBGoodsList(mail.Attachments));
			return proMail;
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x001805FC File Offset: 0x0017E7FC
		public static List<ProMail> MailsToPBMails(List<Mail> mails)
		{
			List<ProMail> list = new List<ProMail>();
			foreach (Mail mail in mails)
			{
				list.Add(Mail.MailToPBMail(mail));
			}
			return list;
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x00180660 File Offset: 0x0017E860
		public static Mail PBMailToMail(ProMail pbMail)
		{
			Mail mail = new Mail();
			mail.InstanceId = pbMail.InstanceId;
			mail.TemplateId = pbMail.TemplateId;
			mail.Status = pbMail.Status;
			mail.SendTime = new DateTime(pbMail.SendTime);
			mail.ReadedOrGotAttachmentTime = new DateTime(pbMail.ReadedOrGotAttachmentTime);
			mail.Content = pbMail.Content;
			mail.MailTypeId = (MailType)pbMail.MailTypeId;
			if (pbMail.TemplateId == 0)
			{
				mail.Title = pbMail.Title;
				mail.ExpiredTime = pbMail.ExpiredTime;
				mail.ReadedExpiredTime = pbMail.ReadedExpiredTime;
				mail.GotDeleted = pbMail.GotDeleted;
			}
			mail.Attachments.AddRange(BagItemBase.PBGoodsListToGoodsList(pbMail.Attachments));
			return mail;
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x00180724 File Offset: 0x0017E924
		public static List<Mail> PBMailsToMails(List<ProMail> pbMails)
		{
			List<Mail> list = new List<Mail>();
			foreach (ProMail pbMail in pbMails)
			{
				list.Add(Mail.PBMailToMail(pbMail));
			}
			return list;
		}

		// Token: 0x04003A00 RID: 14848
		public List<Goods> Attachments = new List<Goods>();

		// Token: 0x04003A01 RID: 14849
		public List<Goods> TemplateAttachments = new List<Goods>();
	}
}
