using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008C8 RID: 2248
	[HotFix]
	public class MailComponent : MailComponentCommon
	{
		// Token: 0x06007318 RID: 29464 RVA: 0x001FCFBC File Offset: 0x001FB1BC
		public MailComponent()
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

		// Token: 0x06007319 RID: 29465 RVA: 0x001FD024 File Offset: 0x001FB224
		public override void Init()
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x001FD0A0 File Offset: 0x001FB2A0
		public override void PostInit()
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
			base.PostInit();
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x001FD108 File Offset: 0x001FB308
		public override void DeInit()
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
			base.DeInit();
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x001FD170 File Offset: 0x001FB370
		public void DeSerialize(DSMailNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSMailNtf_hotfix != null)
			{
				this.m_DeSerializeDSMailNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UnReadMailNums = msg.UnreadMailNums;
			this.m_mailDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x001FD208 File Offset: 0x001FB408
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_mailDS.ClientVersion;
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x001FD280 File Offset: 0x001FB480
		public void InitMails(List<ProMail> pbMails)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitMailsList`1_hotfix != null)
			{
				this.m_InitMailsList`1_hotfix.call(new object[]
				{
					this,
					pbMails
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_mailDS.ClearInitedData();
			foreach (ProMail pbMail in pbMails)
			{
				Mail mail = Mail.PBMailToMail(pbMail);
				Mail mail2 = this.InitTemplateMail(mail);
				this.m_mailDS.InitMail(mail2);
			}
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x001FD35C File Offset: 0x001FB55C
		public int CanAutoGetMailAttachment()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAutoGetMailAttachment_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAutoGetMailAttachment_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Mail> allCanGetAttachmentMails = base.GetAllCanGetAttachmentMails();
			if (allCanGetAttachmentMails.Count == 0)
			{
				return -1006;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x001FD3F8 File Offset: 0x001FB5F8
		protected override Mail GetRealMail(Mail mail)
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
			if (base.IsMailInitCompleted(mail))
			{
				return mail;
			}
			Mail mail2 = new Mail(mail);
			mail2.Title = mail.TemplateMailConfig.Title;
			mail2.Content = this.GetContent(mail);
			mail2.ExpiredTime = mail.TemplateMailConfig.ExpiredTime;
			mail2.ReadedExpiredTime = mail.TemplateMailConfig.ReadedExpiredTime;
			mail2.GotDeleted = mail.TemplateMailConfig.GotDeleted;
			mail2.Attachments.AddRange(mail.TemplateMailConfig.Attachments);
			return mail2;
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x001FD4F4 File Offset: 0x001FB6F4
		public bool IsOfficialMail(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOfficialMailMail_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOfficialMailMail_hotfix.call(new object[]
				{
					this,
					mail
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return mail.TemplateId == 0;
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x001FD580 File Offset: 0x001FB780
		protected override Mail InitTemplateMail(Mail mail)
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
			if (mail.TemplateId == 0)
			{
				return mail;
			}
			mail.TemplateMailConfig = this.m_configDataLoader.GetConfigDataMailInfo(mail.TemplateId);
			return (mail.TemplateMailConfig != null) ? this.GetRealMail(mail) : null;
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x06007323 RID: 29475 RVA: 0x001FD638 File Offset: 0x001FB838
		// (set) Token: 0x06007324 RID: 29476 RVA: 0x001FD658 File Offset: 0x001FB858
		[DoNotToLua]
		public new MailComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MailComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x001FD664 File Offset: 0x001FB864
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007326 RID: 29478 RVA: 0x001FD66C File Offset: 0x001FB86C
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x001FD674 File Offset: 0x001FB874
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007328 RID: 29480 RVA: 0x001FD67C File Offset: 0x001FB87C
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007329 RID: 29481 RVA: 0x001FD684 File Offset: 0x001FB884
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x001FD690 File Offset: 0x001FB890
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x001FD698 File Offset: 0x001FB898
		private List<Mail> __callBase_GetMails()
		{
			return base.GetMails();
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x001FD6A0 File Offset: 0x001FB8A0
		private Mail __callBase_Find(ulong instanceId)
		{
			return base.Find(instanceId);
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x001FD6AC File Offset: 0x001FB8AC
		private bool __callBase_IsMailInitCompleted(Mail mail)
		{
			return base.IsMailInitCompleted(mail);
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x001FD6B8 File Offset: 0x001FB8B8
		private Mail __callBase_GetRealMail(Mail mail)
		{
			return base.GetRealMail(mail);
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x001FD6C4 File Offset: 0x001FB8C4
		private string __callBase_GetContent(Mail mail)
		{
			return base.GetContent(mail);
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x001FD6D0 File Offset: 0x001FB8D0
		private Mail __callBase_InitTemplateMail(Mail mail)
		{
			return base.InitTemplateMail(mail);
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x001FD6DC File Offset: 0x001FB8DC
		private bool __callBase_IsTemplateMail(Mail mail)
		{
			return base.IsTemplateMail(mail);
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x001FD6E8 File Offset: 0x001FB8E8
		private int __callBase_AddMail(Mail newMail)
		{
			return base.AddMail(newMail);
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x001FD6F4 File Offset: 0x001FB8F4
		private bool __callBase_IsMailBoxFull()
		{
			return base.IsMailBoxFull();
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x001FD6FC File Offset: 0x001FB8FC
		private int __callBase_RemoveMail(ulong instanceId)
		{
			return base.RemoveMail(instanceId);
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x001FD708 File Offset: 0x001FB908
		private int __callBase_ReadMail(ulong instanceId)
		{
			return base.ReadMail(instanceId);
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x001FD714 File Offset: 0x001FB914
		private int __callBase_GetMailAttachments(ulong instanceId, bool checkBag)
		{
			return base.GetMailAttachments(instanceId, checkBag);
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x001FD720 File Offset: 0x001FB920
		private List<Mail> __callBase_GetAllCanGetAttachmentMails()
		{
			return base.GetAllCanGetAttachmentMails();
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x001FD728 File Offset: 0x001FB928
		private int __callBase_AutoGetMailAttachment(bool checkBag)
		{
			return base.AutoGetMailAttachment(checkBag);
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x001FD734 File Offset: 0x001FB934
		private int __callBase_CanGetMailAttachment(ulong missioId, bool checkBag)
		{
			return base.CanGetMailAttachment(missioId, checkBag);
		}

		// Token: 0x0600733A RID: 29498 RVA: 0x001FD740 File Offset: 0x001FB940
		private void __callBase_OnGetMailAttachments(Mail mail)
		{
			base.OnGetMailAttachments(mail);
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x001FD74C File Offset: 0x001FB94C
		private void __callBase_GenerateAttachmentRewards(Mail mail)
		{
			base.GenerateAttachmentRewards(mail);
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x001FD758 File Offset: 0x001FB958
		private bool __callBase_IsMailExpired(Mail mail)
		{
			return base.IsMailExpired(mail);
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x001FD764 File Offset: 0x001FB964
		private TimeSpan __callBase_GetMailExpiredTimeSpan(Mail mail)
		{
			return base.GetMailExpiredTimeSpan(mail);
		}

		// Token: 0x0600733E RID: 29502 RVA: 0x001FD770 File Offset: 0x001FB970
		private int __callBase_RemoveExpiredMails()
		{
			return base.RemoveExpiredMails();
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x001FD778 File Offset: 0x001FB978
		private bool __callBase_IsMailReaded(Mail mail)
		{
			return base.IsMailReaded(mail);
		}

		// Token: 0x06007340 RID: 29504 RVA: 0x001FD784 File Offset: 0x001FB984
		private bool __callBase_HasGotMailAttachments(Mail mail)
		{
			return base.HasGotMailAttachments(mail);
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x001FD790 File Offset: 0x001FB990
		private bool __callBase_IsExistMailAttacments(Mail mail)
		{
			return base.IsExistMailAttacments(mail);
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x001FD79C File Offset: 0x001FB99C
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSMailNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_InitMailsList`1_hotfix = (luaObj.RawGet("InitMails") as LuaFunction);
					this.m_CanAutoGetMailAttachment_hotfix = (luaObj.RawGet("CanAutoGetMailAttachment") as LuaFunction);
					this.m_GetRealMailMail_hotfix = (luaObj.RawGet("GetRealMail") as LuaFunction);
					this.m_IsOfficialMailMail_hotfix = (luaObj.RawGet("IsOfficialMail") as LuaFunction);
					this.m_InitTemplateMailMail_hotfix = (luaObj.RawGet("InitTemplateMail") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x001FD964 File Offset: 0x001FBB64
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005561 RID: 21857
		public int UnReadMailNums;

		// Token: 0x04005562 RID: 21858
		[DoNotToLua]
		private MailComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005563 RID: 21859
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005564 RID: 21860
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005565 RID: 21861
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005566 RID: 21862
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005567 RID: 21863
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005568 RID: 21864
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005569 RID: 21865
		private LuaFunction m_DeSerializeDSMailNtf_hotfix;

		// Token: 0x0400556A RID: 21866
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x0400556B RID: 21867
		private LuaFunction m_InitMailsList;

		// Token: 0x0400556C RID: 21868
		private LuaFunction m_CanAutoGetMailAttachment_hotfix;

		// Token: 0x0400556D RID: 21869
		private LuaFunction m_GetRealMailMail_hotfix;

		// Token: 0x0400556E RID: 21870
		private LuaFunction m_IsOfficialMailMail_hotfix;

		// Token: 0x0400556F RID: 21871
		private LuaFunction m_InitTemplateMailMail_hotfix;

		// Token: 0x020008C9 RID: 2249
		public new class LuaExportHelper
		{
			// Token: 0x06007344 RID: 29508 RVA: 0x001FD9CC File Offset: 0x001FBBCC
			public LuaExportHelper(MailComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007345 RID: 29509 RVA: 0x001FD9DC File Offset: 0x001FBBDC
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007346 RID: 29510 RVA: 0x001FD9EC File Offset: 0x001FBBEC
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007347 RID: 29511 RVA: 0x001FD9FC File Offset: 0x001FBBFC
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06007348 RID: 29512 RVA: 0x001FDA0C File Offset: 0x001FBC0C
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007349 RID: 29513 RVA: 0x001FDA1C File Offset: 0x001FBC1C
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x0600734A RID: 29514 RVA: 0x001FDA2C File Offset: 0x001FBC2C
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600734B RID: 29515 RVA: 0x001FDA3C File Offset: 0x001FBC3C
			public List<Mail> __callBase_GetMails()
			{
				return this.m_owner.__callBase_GetMails();
			}

			// Token: 0x0600734C RID: 29516 RVA: 0x001FDA4C File Offset: 0x001FBC4C
			public Mail __callBase_Find(ulong instanceId)
			{
				return this.m_owner.__callBase_Find(instanceId);
			}

			// Token: 0x0600734D RID: 29517 RVA: 0x001FDA5C File Offset: 0x001FBC5C
			public bool __callBase_IsMailInitCompleted(Mail mail)
			{
				return this.m_owner.__callBase_IsMailInitCompleted(mail);
			}

			// Token: 0x0600734E RID: 29518 RVA: 0x001FDA6C File Offset: 0x001FBC6C
			public Mail __callBase_GetRealMail(Mail mail)
			{
				return this.m_owner.__callBase_GetRealMail(mail);
			}

			// Token: 0x0600734F RID: 29519 RVA: 0x001FDA7C File Offset: 0x001FBC7C
			public string __callBase_GetContent(Mail mail)
			{
				return this.m_owner.__callBase_GetContent(mail);
			}

			// Token: 0x06007350 RID: 29520 RVA: 0x001FDA8C File Offset: 0x001FBC8C
			public Mail __callBase_InitTemplateMail(Mail mail)
			{
				return this.m_owner.__callBase_InitTemplateMail(mail);
			}

			// Token: 0x06007351 RID: 29521 RVA: 0x001FDA9C File Offset: 0x001FBC9C
			public bool __callBase_IsTemplateMail(Mail mail)
			{
				return this.m_owner.__callBase_IsTemplateMail(mail);
			}

			// Token: 0x06007352 RID: 29522 RVA: 0x001FDAAC File Offset: 0x001FBCAC
			public int __callBase_AddMail(Mail newMail)
			{
				return this.m_owner.__callBase_AddMail(newMail);
			}

			// Token: 0x06007353 RID: 29523 RVA: 0x001FDABC File Offset: 0x001FBCBC
			public bool __callBase_IsMailBoxFull()
			{
				return this.m_owner.__callBase_IsMailBoxFull();
			}

			// Token: 0x06007354 RID: 29524 RVA: 0x001FDACC File Offset: 0x001FBCCC
			public int __callBase_RemoveMail(ulong instanceId)
			{
				return this.m_owner.__callBase_RemoveMail(instanceId);
			}

			// Token: 0x06007355 RID: 29525 RVA: 0x001FDADC File Offset: 0x001FBCDC
			public int __callBase_ReadMail(ulong instanceId)
			{
				return this.m_owner.__callBase_ReadMail(instanceId);
			}

			// Token: 0x06007356 RID: 29526 RVA: 0x001FDAEC File Offset: 0x001FBCEC
			public int __callBase_GetMailAttachments(ulong instanceId, bool checkBag)
			{
				return this.m_owner.__callBase_GetMailAttachments(instanceId, checkBag);
			}

			// Token: 0x06007357 RID: 29527 RVA: 0x001FDAFC File Offset: 0x001FBCFC
			public List<Mail> __callBase_GetAllCanGetAttachmentMails()
			{
				return this.m_owner.__callBase_GetAllCanGetAttachmentMails();
			}

			// Token: 0x06007358 RID: 29528 RVA: 0x001FDB0C File Offset: 0x001FBD0C
			public int __callBase_AutoGetMailAttachment(bool checkBag)
			{
				return this.m_owner.__callBase_AutoGetMailAttachment(checkBag);
			}

			// Token: 0x06007359 RID: 29529 RVA: 0x001FDB1C File Offset: 0x001FBD1C
			public int __callBase_CanGetMailAttachment(ulong missioId, bool checkBag)
			{
				return this.m_owner.__callBase_CanGetMailAttachment(missioId, checkBag);
			}

			// Token: 0x0600735A RID: 29530 RVA: 0x001FDB2C File Offset: 0x001FBD2C
			public void __callBase_OnGetMailAttachments(Mail mail)
			{
				this.m_owner.__callBase_OnGetMailAttachments(mail);
			}

			// Token: 0x0600735B RID: 29531 RVA: 0x001FDB3C File Offset: 0x001FBD3C
			public void __callBase_GenerateAttachmentRewards(Mail mail)
			{
				this.m_owner.__callBase_GenerateAttachmentRewards(mail);
			}

			// Token: 0x0600735C RID: 29532 RVA: 0x001FDB4C File Offset: 0x001FBD4C
			public bool __callBase_IsMailExpired(Mail mail)
			{
				return this.m_owner.__callBase_IsMailExpired(mail);
			}

			// Token: 0x0600735D RID: 29533 RVA: 0x001FDB5C File Offset: 0x001FBD5C
			public TimeSpan __callBase_GetMailExpiredTimeSpan(Mail mail)
			{
				return this.m_owner.__callBase_GetMailExpiredTimeSpan(mail);
			}

			// Token: 0x0600735E RID: 29534 RVA: 0x001FDB6C File Offset: 0x001FBD6C
			public int __callBase_RemoveExpiredMails()
			{
				return this.m_owner.__callBase_RemoveExpiredMails();
			}

			// Token: 0x0600735F RID: 29535 RVA: 0x001FDB7C File Offset: 0x001FBD7C
			public bool __callBase_IsMailReaded(Mail mail)
			{
				return this.m_owner.__callBase_IsMailReaded(mail);
			}

			// Token: 0x06007360 RID: 29536 RVA: 0x001FDB8C File Offset: 0x001FBD8C
			public bool __callBase_HasGotMailAttachments(Mail mail)
			{
				return this.m_owner.__callBase_HasGotMailAttachments(mail);
			}

			// Token: 0x06007361 RID: 29537 RVA: 0x001FDB9C File Offset: 0x001FBD9C
			public bool __callBase_IsExistMailAttacments(Mail mail)
			{
				return this.m_owner.__callBase_IsExistMailAttacments(mail);
			}

			// Token: 0x06007362 RID: 29538 RVA: 0x001FDBAC File Offset: 0x001FBDAC
			public Mail GetRealMail(Mail mail)
			{
				return this.m_owner.GetRealMail(mail);
			}

			// Token: 0x06007363 RID: 29539 RVA: 0x001FDBBC File Offset: 0x001FBDBC
			public Mail InitTemplateMail(Mail mail)
			{
				return this.m_owner.InitTemplateMail(mail);
			}

			// Token: 0x04005570 RID: 21872
			private MailComponent m_owner;
		}
	}
}
