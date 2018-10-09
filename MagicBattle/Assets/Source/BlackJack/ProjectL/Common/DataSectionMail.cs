using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004E4 RID: 1252
	[CustomLuaClass]
	public class DataSectionMail : DataSection
	{
		// Token: 0x06004BFD RID: 19453 RVA: 0x00177A5C File Offset: 0x00175C5C
		public DataSectionMail()
		{
			this.m_mails = new Dictionary<ulong, Mail>();
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x00177A70 File Offset: 0x00175C70
		public override object SerializeToClient()
		{
			DSMailNtf dsmailNtf = new DSMailNtf();
			dsmailNtf.Version = (uint)base.Version;
			int num = 0;
			foreach (KeyValuePair<ulong, Mail> keyValuePair in this.m_mails)
			{
				if (!this.IsMailReaded(keyValuePair.Value))
				{
					num++;
				}
			}
			dsmailNtf.UnreadMailNums = num;
			return dsmailNtf;
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x00177AF8 File Offset: 0x00175CF8
		public override void ClearInitedData()
		{
			this.m_mails.Clear();
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00177B08 File Offset: 0x00175D08
		public bool IsMailReaded(Mail mail)
		{
			return mail.Status >= 1;
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x00177B18 File Offset: 0x00175D18
		public Mail AddMail(Mail mail)
		{
			this.m_mails.Add(mail.InstanceId, mail);
			base.SetDirty(true);
			return mail;
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x00177B34 File Offset: 0x00175D34
		public void InitMail(Mail mail)
		{
			this.m_mails.Add(mail.InstanceId, mail);
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x00177B48 File Offset: 0x00175D48
		public void RemoveMail(Mail mail)
		{
			this.m_mails.Remove(mail.InstanceId);
			base.SetDirty(true);
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x00177B64 File Offset: 0x00175D64
		public void ClearMailBox()
		{
			this.m_mails.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x00177B78 File Offset: 0x00175D78
		public Mail FindMail(ulong instanceId)
		{
			Mail result;
			this.m_mails.TryGetValue(instanceId, out result);
			return result;
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x00177B98 File Offset: 0x00175D98
		public void ReadMail(Mail mail, DateTime current)
		{
			mail.Status = 1;
			mail.ReadedOrGotAttachmentTime = current;
			base.SetDirty(true);
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00177BB0 File Offset: 0x00175DB0
		public void SetGotAttachments(Mail mail, DateTime current)
		{
			mail.Status = 2;
			mail.ReadedOrGotAttachmentTime = current;
			base.SetDirty(true);
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x00177BC8 File Offset: 0x00175DC8
		public void InitGlobalMailId(int value)
		{
			this.m_globalMailId = value;
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00177BD4 File Offset: 0x00175DD4
		public void SetGlobalMailId(int value)
		{
			this.m_globalMailId = value;
			base.SetDirty(true);
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x00177BE4 File Offset: 0x00175DE4
		public int GlobalMailId
		{
			get
			{
				return this.m_globalMailId;
			}
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x00177BEC File Offset: 0x00175DEC
		public Mail GetFirstMail()
		{
			Mail mail = null;
			foreach (KeyValuePair<ulong, Mail> keyValuePair in this.m_mails)
			{
				if (mail == null)
				{
					mail = keyValuePair.Value;
				}
				else if (mail.SendTime > keyValuePair.Value.SendTime)
				{
					mail = keyValuePair.Value;
				}
			}
			return mail;
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x00177C7C File Offset: 0x00175E7C
		public int GetMailBoxSize()
		{
			return this.m_mails.Count;
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x00177C8C File Offset: 0x00175E8C
		public List<Mail> GetMails()
		{
			List<Mail> list = new List<Mail>();
			foreach (Mail item in this.m_mails.Values)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x04003889 RID: 14473
		private Dictionary<ulong, Mail> m_mails;

		// Token: 0x0400388A RID: 14474
		private int m_globalMailId;
	}
}
