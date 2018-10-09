using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000481 RID: 1153
	[HotFix]
	public class MailComponentCommon : IComponentBase
	{
		// Token: 0x06004421 RID: 17441 RVA: 0x00148894 File Offset: 0x00146A94
		public MailComponentCommon()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004422 RID: 17442 RVA: 0x00148908 File Offset: 0x00146B08
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "Mail";
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x0014897C File Offset: 0x00146B7C
		public virtual void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_changedGoods = new List<BagItemBase>();
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x001489E8 File Offset: 0x00146BE8
		public virtual void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x00148A80 File Offset: 0x00146C80
		public virtual void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x00148AE0 File Offset: 0x00146CE0
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x00148B50 File Offset: 0x00146D50
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x00148BD0 File Offset: 0x00146DD0
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x00148C40 File Offset: 0x00146E40
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x00148CA0 File Offset: 0x00146EA0
		// (set) Token: 0x0600442B RID: 17451 RVA: 0x00148D14 File Offset: 0x00146F14
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x00148D8C File Offset: 0x00146F8C
		public List<Mail> GetMails()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMails_hotfix != null)
			{
				return (List<Mail>)this.m_GetMails_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.RemoveExpiredMails();
			return this.m_mailDS.GetMails();
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x00148E0C File Offset: 0x0014700C
		public Mail Find(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindUInt64_hotfix != null)
			{
				return (Mail)this.m_FindUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_mailDS.FindMail(instanceId);
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x00148E94 File Offset: 0x00147094
		protected bool IsMailInitCompleted(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMailInitCompletedMail_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMailInitCompletedMail_hotfix.call(new object[]
				{
					this,
					mail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return mail.TemplateMailConfig == null || this.IsTemplateMailInitCompleted(mail);
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x00148F28 File Offset: 0x00147128
		private bool IsTemplateMailInitCompleted(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTemplateMailInitCompletedMail_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTemplateMailInitCompletedMail_hotfix.call(new object[]
				{
					this,
					mail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return mail.TemplateMailConfig != null && mail.ExpiredTime != 0u;
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x00148FC0 File Offset: 0x001471C0
		protected virtual Mail GetRealMail(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRealMailMail_hotfix != null)
			{
				return (Mail)this.m_GetRealMailMail_hotfix.call(new object[]
				{
					this,
					mail
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return mail;
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x00149040 File Offset: 0x00147240
		protected virtual string GetContent(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetContentMail_hotfix != null)
			{
				return (string)this.m_GetContentMail_hotfix.call(new object[]
				{
					this,
					mail
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string content = mail.TemplateMailConfig.Content;
			if (mail.Content != null)
			{
				return CombineStringTools.ReplaceHasParamContent(content, mail.Content);
			}
			return content;
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x001490E4 File Offset: 0x001472E4
		protected virtual Mail InitTemplateMail(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTemplateMailMail_hotfix != null)
			{
				return (Mail)this.m_InitTemplateMailMail_hotfix.call(new object[]
				{
					this,
					mail
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsTemplateMail(mail))
			{
				mail.TemplateMailConfig = this.m_configDataLoader.GetConfigDataMailInfo(mail.TemplateId);
				if (mail.TemplateMailConfig == null)
				{
					return null;
				}
			}
			return mail;
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00149194 File Offset: 0x00147394
		public bool IsTemplateMail(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTemplateMailMail_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTemplateMailMail_hotfix.call(new object[]
				{
					this,
					mail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return mail.TemplateId != 0;
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x0014921C File Offset: 0x0014741C
		public virtual int AddMail(Mail newMail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMailMail_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddMailMail_hotfix.call(new object[]
				{
					this,
					newMail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Mail mail = this.Find(newMail.InstanceId);
			if (mail != null)
			{
				return -1000;
			}
			Mail mail2 = this.InitTemplateMail(newMail);
			if (mail2 == null)
			{
				return -1005;
			}
			if (this.IsMailExpired(mail2))
			{
				return -1004;
			}
			if (this.IsMailBoxFull())
			{
				this.RemoveEarliestMail();
			}
			this.m_mailDS.AddMail(mail2);
			return 0;
		}

		// Token: 0x06004435 RID: 17461 RVA: 0x001492F8 File Offset: 0x001474F8
		private void RemoveEarliestMail()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveEarliestMail_hotfix != null)
			{
				this.m_RemoveEarliestMail_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Mail firstMail = this.m_mailDS.GetFirstMail();
			this.m_mailDS.RemoveMail(firstMail);
		}

		// Token: 0x06004436 RID: 17462 RVA: 0x00149370 File Offset: 0x00147570
		public bool IsMailBoxFull()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMailBoxFull_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMailBoxFull_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_mailDS.GetMailBoxSize() == this.m_configDataLoader.ConfigableConstId_MailBoxMaxSize;
		}

		// Token: 0x06004437 RID: 17463 RVA: 0x001493F4 File Offset: 0x001475F4
		public int RemoveMail(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveMailUInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_RemoveMailUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Mail mail = this.m_mailDS.FindMail(instanceId);
			if (mail == null)
			{
				return -1001;
			}
			this.m_mailDS.RemoveMail(mail);
			return 0;
		}

		// Token: 0x06004438 RID: 17464 RVA: 0x00149498 File Offset: 0x00147698
		public int ReadMail(ulong instanceId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReadMailUInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_ReadMailUInt64_hotfix.call(new object[]
				{
					this,
					instanceId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Mail mail = this.m_mailDS.FindMail(instanceId);
			if (mail == null)
			{
				return -1001;
			}
			Mail realMail = this.GetRealMail(mail);
			if (this.IsMailExpired(realMail))
			{
				this.m_mailDS.RemoveMail(mail);
				return -1004;
			}
			if (this.IsMailReaded(realMail))
			{
				return -1002;
			}
			this.m_mailDS.ReadMail(mail, this.m_basicInfo.GetCurrentTime());
			if (!this.IsExistMailAttacments(realMail))
			{
				this.m_mailDS.SetGotAttachments(mail, this.m_basicInfo.GetCurrentTime());
			}
			return 0;
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x001495A0 File Offset: 0x001477A0
		public int GetMailAttachments(ulong instanceId, bool checkBag = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMailAttachmentsUInt64Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMailAttachmentsUInt64Boolean_hotfix.call(new object[]
				{
					this,
					instanceId,
					checkBag
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanGetMailAttachment(instanceId, checkBag);
			if (num != 0)
			{
				if (num == -1004)
				{
					Mail mail = this.m_mailDS.FindMail(instanceId);
					this.m_mailDS.RemoveMail(mail);
				}
				return num;
			}
			Mail mail2 = this.m_mailDS.FindMail(instanceId);
			this.OnGetMailAttachments(mail2);
			return 0;
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x00149678 File Offset: 0x00147878
		protected List<Mail> GetAllCanGetAttachmentMails()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllCanGetAttachmentMails_hotfix != null)
			{
				return (List<Mail>)this.m_GetAllCanGetAttachmentMails_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mail> list = new List<Mail>();
			foreach (Mail mail in this.m_mailDS.GetMails())
			{
				Mail realMail = this.GetRealMail(mail);
				if (!this.IsMailExpired(realMail) && this.IsExistMailAttacments(realMail) && !this.HasGotMailAttachments(realMail))
				{
					list.Add(mail);
				}
			}
			return list;
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x00149774 File Offset: 0x00147974
		public int AutoGetMailAttachment(bool checkBag = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoGetMailAttachmentBoolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_AutoGetMailAttachmentBoolean_hotfix.call(new object[]
				{
					this,
					checkBag
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mail> allCanGetAttachmentMails = this.GetAllCanGetAttachmentMails();
			if (allCanGetAttachmentMails.Count == 0)
			{
				return -1006;
			}
			if (checkBag && this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			foreach (Mail mail in allCanGetAttachmentMails)
			{
				this.OnGetMailAttachments(mail);
			}
			return 0;
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x00149870 File Offset: 0x00147A70
		public int CanGetMailAttachment(ulong missioId, bool checkBag = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGetMailAttachmentUInt64Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGetMailAttachmentUInt64Boolean_hotfix.call(new object[]
				{
					this,
					missioId,
					checkBag
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Mail mail = this.m_mailDS.FindMail(missioId);
			if (mail == null)
			{
				return -1001;
			}
			Mail realMail = this.GetRealMail(mail);
			if (this.IsMailExpired(realMail))
			{
				return -1004;
			}
			if (!this.IsExistMailAttacments(realMail))
			{
				return -1007;
			}
			if (this.HasGotMailAttachments(realMail))
			{
				return -1003;
			}
			if (checkBag && this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x00149970 File Offset: 0x00147B70
		protected void OnGetMailAttachments(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetMailAttachmentsMail_hotfix != null)
			{
				this.m_OnGetMailAttachmentsMail_hotfix.call(new object[]
				{
					this,
					mail
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Mail realMail = this.GetRealMail(mail);
			if (realMail.GotDeleted)
			{
				this.m_mailDS.RemoveMail(mail);
			}
			else
			{
				this.m_mailDS.SetGotAttachments(mail, this.m_basicInfo.GetCurrentTime());
			}
			this.GenerateAttachmentRewards(realMail);
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x00149A24 File Offset: 0x00147C24
		protected virtual void GenerateAttachmentRewards(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GenerateAttachmentRewardsMail_hotfix != null)
			{
				this.m_GenerateAttachmentRewardsMail_hotfix.call(new object[]
				{
					this,
					mail
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x00149A94 File Offset: 0x00147C94
		public bool IsMailExpired(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMailExpiredMail_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMailExpiredMail_hotfix.call(new object[]
				{
					this,
					mail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GetMailExpiredTimeSpan(mail).Ticks >= 0L;
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00149B28 File Offset: 0x00147D28
		public TimeSpan GetMailExpiredTimeSpan(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMailExpiredTimeSpanMail_hotfix != null)
			{
				return (TimeSpan)this.m_GetMailExpiredTimeSpanMail_hotfix.call(new object[]
				{
					this,
					mail
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime d = default(DateTime);
			Mail realMail = this.GetRealMail(mail);
			int status = realMail.Status;
			if (status != 0)
			{
				if (status != 1)
				{
					if (status == 2)
					{
						if (realMail.GotDeleted)
						{
							d = this.m_basicInfo.GetCurrentTime();
						}
						else
						{
							uint num = (realMail.ReadedExpiredTime <= 0) ? realMail.ExpiredTime : ((uint)realMail.ReadedExpiredTime);
							d = realMail.ReadedOrGotAttachmentTime.AddSeconds(num);
						}
					}
				}
				else
				{
					uint num2 = this.IsExistMailAttacments(realMail) ? realMail.ExpiredTime : ((uint)realMail.ReadedExpiredTime);
					d = realMail.ReadedOrGotAttachmentTime.AddSeconds(num2);
				}
			}
			else
			{
				d = realMail.SendTime.AddSeconds(realMail.ExpiredTime);
			}
			return this.m_basicInfo.GetCurrentTime() - d;
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00149C90 File Offset: 0x00147E90
		protected int RemoveExpiredMails()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RemoveExpiredMails_hotfix != null)
			{
				return Convert.ToInt32(this.m_RemoveExpiredMails_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (Mail mail in this.m_mailDS.GetMails())
			{
				if (this.IsMailExpired(mail))
				{
					this.m_mailDS.RemoveMail(mail);
					num++;
				}
			}
			return num;
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x00149D68 File Offset: 0x00147F68
		public bool IsMailReaded(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMailReadedMail_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMailReadedMail_hotfix.call(new object[]
				{
					this,
					mail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_mailDS.IsMailReaded(mail);
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x00149DF0 File Offset: 0x00147FF0
		public bool HasGotMailAttachments(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HasGotMailAttachmentsMail_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HasGotMailAttachmentsMail_hotfix.call(new object[]
				{
					this,
					mail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return mail.Status == 2;
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x00149E78 File Offset: 0x00148078
		public bool IsExistMailAttacments(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsExistMailAttacmentsMail_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsExistMailAttacmentsMail_hotfix.call(new object[]
				{
					this,
					mail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return mail.Attachments.Count != 0 || mail.TemplateAttachments.Count != 0;
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06004445 RID: 17477 RVA: 0x00149F18 File Offset: 0x00148118
		// (set) Token: 0x06004446 RID: 17478 RVA: 0x00149F38 File Offset: 0x00148138
		[DoNotToLua]
		public MailComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MailComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004447 RID: 17479 RVA: 0x00149F44 File Offset: 0x00148144
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_GetMails_hotfix = (luaObj.RawGet("GetMails") as LuaFunction);
					this.m_FindUInt64_hotfix = (luaObj.RawGet("Find") as LuaFunction);
					this.m_IsMailInitCompletedMail_hotfix = (luaObj.RawGet("IsMailInitCompleted") as LuaFunction);
					this.m_IsTemplateMailInitCompletedMail_hotfix = (luaObj.RawGet("IsTemplateMailInitCompleted") as LuaFunction);
					this.m_GetRealMailMail_hotfix = (luaObj.RawGet("GetRealMail") as LuaFunction);
					this.m_GetContentMail_hotfix = (luaObj.RawGet("GetContent") as LuaFunction);
					this.m_InitTemplateMailMail_hotfix = (luaObj.RawGet("InitTemplateMail") as LuaFunction);
					this.m_IsTemplateMailMail_hotfix = (luaObj.RawGet("IsTemplateMail") as LuaFunction);
					this.m_AddMailMail_hotfix = (luaObj.RawGet("AddMail") as LuaFunction);
					this.m_RemoveEarliestMail_hotfix = (luaObj.RawGet("RemoveEarliestMail") as LuaFunction);
					this.m_IsMailBoxFull_hotfix = (luaObj.RawGet("IsMailBoxFull") as LuaFunction);
					this.m_RemoveMailUInt64_hotfix = (luaObj.RawGet("RemoveMail") as LuaFunction);
					this.m_ReadMailUInt64_hotfix = (luaObj.RawGet("ReadMail") as LuaFunction);
					this.m_GetMailAttachmentsUInt64Boolean_hotfix = (luaObj.RawGet("GetMailAttachments") as LuaFunction);
					this.m_GetAllCanGetAttachmentMails_hotfix = (luaObj.RawGet("GetAllCanGetAttachmentMails") as LuaFunction);
					this.m_AutoGetMailAttachmentBoolean_hotfix = (luaObj.RawGet("AutoGetMailAttachment") as LuaFunction);
					this.m_CanGetMailAttachmentUInt64Boolean_hotfix = (luaObj.RawGet("CanGetMailAttachment") as LuaFunction);
					this.m_OnGetMailAttachmentsMail_hotfix = (luaObj.RawGet("OnGetMailAttachments") as LuaFunction);
					this.m_GenerateAttachmentRewardsMail_hotfix = (luaObj.RawGet("GenerateAttachmentRewards") as LuaFunction);
					this.m_IsMailExpiredMail_hotfix = (luaObj.RawGet("IsMailExpired") as LuaFunction);
					this.m_GetMailExpiredTimeSpanMail_hotfix = (luaObj.RawGet("GetMailExpiredTimeSpan") as LuaFunction);
					this.m_RemoveExpiredMails_hotfix = (luaObj.RawGet("RemoveExpiredMails") as LuaFunction);
					this.m_IsMailReadedMail_hotfix = (luaObj.RawGet("IsMailReaded") as LuaFunction);
					this.m_HasGotMailAttachmentsMail_hotfix = (luaObj.RawGet("HasGotMailAttachments") as LuaFunction);
					this.m_IsExistMailAttacmentsMail_hotfix = (luaObj.RawGet("IsExistMailAttacments") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x0014A37C File Offset: 0x0014857C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040033D1 RID: 13265
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x040033D2 RID: 13266
		protected List<BagItemBase> m_changedGoods;

		// Token: 0x040033D3 RID: 13267
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040033D4 RID: 13268
		protected BagComponentCommon m_bag;

		// Token: 0x040033D5 RID: 13269
		protected DataSectionMail m_mailDS = new DataSectionMail();

		// Token: 0x040033D6 RID: 13270
		[DoNotToLua]
		private MailComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040033D7 RID: 13271
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040033D8 RID: 13272
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040033D9 RID: 13273
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040033DA RID: 13274
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040033DB RID: 13275
		private LuaFunction m_Init_hotfix;

		// Token: 0x040033DC RID: 13276
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040033DD RID: 13277
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040033DE RID: 13278
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040033DF RID: 13279
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040033E0 RID: 13280
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040033E1 RID: 13281
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040033E2 RID: 13282
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040033E3 RID: 13283
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040033E4 RID: 13284
		private LuaFunction m_GetMails_hotfix;

		// Token: 0x040033E5 RID: 13285
		private LuaFunction m_FindUInt64_hotfix;

		// Token: 0x040033E6 RID: 13286
		private LuaFunction m_IsMailInitCompletedMail_hotfix;

		// Token: 0x040033E7 RID: 13287
		private LuaFunction m_IsTemplateMailInitCompletedMail_hotfix;

		// Token: 0x040033E8 RID: 13288
		private LuaFunction m_GetRealMailMail_hotfix;

		// Token: 0x040033E9 RID: 13289
		private LuaFunction m_GetContentMail_hotfix;

		// Token: 0x040033EA RID: 13290
		private LuaFunction m_InitTemplateMailMail_hotfix;

		// Token: 0x040033EB RID: 13291
		private LuaFunction m_IsTemplateMailMail_hotfix;

		// Token: 0x040033EC RID: 13292
		private LuaFunction m_AddMailMail_hotfix;

		// Token: 0x040033ED RID: 13293
		private LuaFunction m_RemoveEarliestMail_hotfix;

		// Token: 0x040033EE RID: 13294
		private LuaFunction m_IsMailBoxFull_hotfix;

		// Token: 0x040033EF RID: 13295
		private LuaFunction m_RemoveMailUInt64_hotfix;

		// Token: 0x040033F0 RID: 13296
		private LuaFunction m_ReadMailUInt64_hotfix;

		// Token: 0x040033F1 RID: 13297
		private LuaFunction m_GetMailAttachmentsUInt64Boolean_hotfix;

		// Token: 0x040033F2 RID: 13298
		private LuaFunction m_GetAllCanGetAttachmentMails_hotfix;

		// Token: 0x040033F3 RID: 13299
		private LuaFunction m_AutoGetMailAttachmentBoolean_hotfix;

		// Token: 0x040033F4 RID: 13300
		private LuaFunction m_CanGetMailAttachmentUInt64Boolean_hotfix;

		// Token: 0x040033F5 RID: 13301
		private LuaFunction m_OnGetMailAttachmentsMail_hotfix;

		// Token: 0x040033F6 RID: 13302
		private LuaFunction m_GenerateAttachmentRewardsMail_hotfix;

		// Token: 0x040033F7 RID: 13303
		private LuaFunction m_IsMailExpiredMail_hotfix;

		// Token: 0x040033F8 RID: 13304
		private LuaFunction m_GetMailExpiredTimeSpanMail_hotfix;

		// Token: 0x040033F9 RID: 13305
		private LuaFunction m_RemoveExpiredMails_hotfix;

		// Token: 0x040033FA RID: 13306
		private LuaFunction m_IsMailReadedMail_hotfix;

		// Token: 0x040033FB RID: 13307
		private LuaFunction m_HasGotMailAttachmentsMail_hotfix;

		// Token: 0x040033FC RID: 13308
		private LuaFunction m_IsExistMailAttacmentsMail_hotfix;

		// Token: 0x02000482 RID: 1154
		public class LuaExportHelper
		{
			// Token: 0x06004449 RID: 17481 RVA: 0x0014A3E4 File Offset: 0x001485E4
			public LuaExportHelper(MailComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001195 RID: 4501
			// (get) Token: 0x0600444A RID: 17482 RVA: 0x0014A3F4 File Offset: 0x001485F4
			// (set) Token: 0x0600444B RID: 17483 RVA: 0x0014A404 File Offset: 0x00148604
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17001196 RID: 4502
			// (get) Token: 0x0600444C RID: 17484 RVA: 0x0014A414 File Offset: 0x00148614
			// (set) Token: 0x0600444D RID: 17485 RVA: 0x0014A424 File Offset: 0x00148624
			public List<BagItemBase> m_changedGoods
			{
				get
				{
					return this.m_owner.m_changedGoods;
				}
				set
				{
					this.m_owner.m_changedGoods = value;
				}
			}

			// Token: 0x17001197 RID: 4503
			// (get) Token: 0x0600444E RID: 17486 RVA: 0x0014A434 File Offset: 0x00148634
			// (set) Token: 0x0600444F RID: 17487 RVA: 0x0014A444 File Offset: 0x00148644
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x17001198 RID: 4504
			// (get) Token: 0x06004450 RID: 17488 RVA: 0x0014A454 File Offset: 0x00148654
			// (set) Token: 0x06004451 RID: 17489 RVA: 0x0014A464 File Offset: 0x00148664
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x17001199 RID: 4505
			// (get) Token: 0x06004452 RID: 17490 RVA: 0x0014A474 File Offset: 0x00148674
			// (set) Token: 0x06004453 RID: 17491 RVA: 0x0014A484 File Offset: 0x00148684
			public DataSectionMail m_mailDS
			{
				get
				{
					return this.m_owner.m_mailDS;
				}
				set
				{
					this.m_owner.m_mailDS = value;
				}
			}

			// Token: 0x06004454 RID: 17492 RVA: 0x0014A494 File Offset: 0x00148694
			public bool IsMailInitCompleted(Mail mail)
			{
				return this.m_owner.IsMailInitCompleted(mail);
			}

			// Token: 0x06004455 RID: 17493 RVA: 0x0014A4A4 File Offset: 0x001486A4
			public bool IsTemplateMailInitCompleted(Mail mail)
			{
				return this.m_owner.IsTemplateMailInitCompleted(mail);
			}

			// Token: 0x06004456 RID: 17494 RVA: 0x0014A4B4 File Offset: 0x001486B4
			public Mail GetRealMail(Mail mail)
			{
				return this.m_owner.GetRealMail(mail);
			}

			// Token: 0x06004457 RID: 17495 RVA: 0x0014A4C4 File Offset: 0x001486C4
			public string GetContent(Mail mail)
			{
				return this.m_owner.GetContent(mail);
			}

			// Token: 0x06004458 RID: 17496 RVA: 0x0014A4D4 File Offset: 0x001486D4
			public Mail InitTemplateMail(Mail mail)
			{
				return this.m_owner.InitTemplateMail(mail);
			}

			// Token: 0x06004459 RID: 17497 RVA: 0x0014A4E4 File Offset: 0x001486E4
			public void RemoveEarliestMail()
			{
				this.m_owner.RemoveEarliestMail();
			}

			// Token: 0x0600445A RID: 17498 RVA: 0x0014A4F4 File Offset: 0x001486F4
			public List<Mail> GetAllCanGetAttachmentMails()
			{
				return this.m_owner.GetAllCanGetAttachmentMails();
			}

			// Token: 0x0600445B RID: 17499 RVA: 0x0014A504 File Offset: 0x00148704
			public void OnGetMailAttachments(Mail mail)
			{
				this.m_owner.OnGetMailAttachments(mail);
			}

			// Token: 0x0600445C RID: 17500 RVA: 0x0014A514 File Offset: 0x00148714
			public void GenerateAttachmentRewards(Mail mail)
			{
				this.m_owner.GenerateAttachmentRewards(mail);
			}

			// Token: 0x0600445D RID: 17501 RVA: 0x0014A524 File Offset: 0x00148724
			public int RemoveExpiredMails()
			{
				return this.m_owner.RemoveExpiredMails();
			}

			// Token: 0x040033FD RID: 13309
			private MailComponentCommon m_owner;
		}
	}
}
