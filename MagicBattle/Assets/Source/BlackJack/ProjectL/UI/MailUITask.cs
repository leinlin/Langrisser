using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E6A RID: 3690
	[HotFix]
	public class MailUITask : UITask
	{
		// Token: 0x06011E39 RID: 73273 RVA: 0x0049F128 File Offset: 0x0049D328
		public MailUITask(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06011E3A RID: 73274 RVA: 0x0049F23C File Offset: 0x0049D43C
		public override void PrepareForStartOrResume(UIIntent intent, Action<bool> onPrepareEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix != null)
			{
				this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix.call(new object[]
				{
					this,
					intent,
					onPrepareEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<bool> onPrepareEnd = onPrepareEnd2;
			if (!this.m_playerCtx.IsHaveMailList)
			{
				MailsGetNetTask mailsGetNetTask = new MailsGetNetTask();
				mailsGetNetTask.EventOnStop += delegate(Task task)
				{
					MailsGetNetTask mailsGetNetTask2 = task as MailsGetNetTask;
					if (mailsGetNetTask2.Result == 0)
					{
						onPrepareEnd(true);
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(mailsGetNetTask2.Result, 2f, null, true);
						onPrepareEnd(false);
					}
				};
				mailsGetNetTask.Start(null);
			}
			else
			{
				onPrepareEnd(true);
			}
		}

		// Token: 0x06011E3B RID: 73275 RVA: 0x0049F30C File Offset: 0x0049D50C
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPipeLineCtx = base.GetPipeLineCtx();
			this.EnablePipelineStateMask(MailUITask.PipeLineStateMaskType.AllRefresh);
			this.m_currentSelectedMail = null;
			bool flag = base.OnStart(intent);
			if (!flag)
			{
				Debug.LogError("MailStroeUITask base.OnStart fail");
				return flag;
			}
			return flag;
		}

		// Token: 0x06011E3C RID: 73276 RVA: 0x0049F3C0 File Offset: 0x0049D5C0
		protected override bool IsNeedUpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedUpdateDataCache_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedUpdateDataCache_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !this.IsPipelineStateMaskNeedUpdate(MailUITask.PipeLineStateMaskType.ForUIClick);
		}

		// Token: 0x06011E3D RID: 73277 RVA: 0x0049F43C File Offset: 0x0049D63C
		protected override void UpdateDataCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateDataCache_hotfix != null)
			{
				this.m_UpdateDataCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPipelineStateMaskNeedUpdate(MailUITask.PipeLineStateMaskType.IsReadGetMailAttachment))
			{
				List<Mail> list = new List<Mail>();
				List<Mail> list2 = new List<Mail>();
				foreach (Mail mail in this.m_playerCtx.GetMails())
				{
					if (this.m_playerCtx.IsMailReaded(mail))
					{
						list.Add(mail);
					}
					else
					{
						list2.Add(mail);
					}
				}
				list2.Sort(new Comparison<Mail>(this.MailCompare));
				list.Sort(new Comparison<Mail>(this.MailCompare));
				this.m_mailInfoCache.Clear();
				this.m_mailInfoCache.AddRange(list2);
				this.m_mailInfoCache.AddRange(list);
			}
		}

		// Token: 0x06011E3E RID: 73278 RVA: 0x0049F574 File Offset: 0x0049D774
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			foreach (Mail mail in this.m_mailInfoCache)
			{
				List<Goods> attachments = mail.Attachments;
				if (attachments != null && attachments.Count > 0)
				{
					foreach (Goods goods in attachments)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06011E3F RID: 73279 RVA: 0x0049F6A4 File Offset: 0x0049D8A4
		private int MailCompare(Mail mailA, Mail mailB)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MailCompareMailMail_hotfix != null)
			{
				return Convert.ToInt32(this.m_MailCompareMailMail_hotfix.call(new object[]
				{
					this,
					mailA,
					mailB
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = mailA.Attachments != null && mailA.Attachments.Count > 0;
			bool flag2 = mailB.Attachments != null && mailB.Attachments.Count > 0;
			if ((!flag && !flag2) || (flag && flag2))
			{
				long ticks = (mailB.SendTime - mailA.SendTime).Ticks;
				if (ticks == 0L)
				{
					return 0;
				}
				if (ticks > 0L)
				{
					return 1;
				}
				if (ticks < 0L)
				{
					return -1;
				}
			}
			else
			{
				if (flag)
				{
					return -1;
				}
				if (flag2)
				{
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x06011E40 RID: 73280 RVA: 0x0049F7D0 File Offset: 0x0049D9D0
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (this.m_mailListUICtrl == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_mailListUICtrl = (this.m_uiCtrlArray[0] as MailListUIController);
				}
				this.m_mailListUICtrl.EventOnMailItemButtonClick += this.MailListUIController_OnMailItemButtonClick;
				this.m_mailListUICtrl.EventOnCloseButtonClick += this.MailListUIController_OnCloseButtonClick;
				this.m_mailListUICtrl.EventOnGetAllAttachments += this.MailListUIController_OnGetAllAttachments;
				this.m_mailListUICtrl.m_mailDetailUICtrl.EventOnGetAttachmentButtonClick += this.MailDetailUIController_OnGetAttachmentButtonClick;
				this.m_mailListUICtrl.m_mailDetailUICtrl.EventOnGotoButtonClick += this.MailDetailUIController_OnGotoButtonClick;
				this.m_playerCtx.EventOnMailReadAck += this.OnMailReadAck;
				return;
			}
			Debug.LogError("MailListUIController is null");
		}

		// Token: 0x06011E41 RID: 73281 RVA: 0x0049F90C File Offset: 0x0049DB0C
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_mailListUICtrl != null)
			{
				this.m_mailListUICtrl.EventOnMailItemButtonClick -= this.MailListUIController_OnMailItemButtonClick;
				this.m_mailListUICtrl.EventOnCloseButtonClick -= this.MailListUIController_OnCloseButtonClick;
				this.m_mailListUICtrl.EventOnGetAllAttachments -= this.MailListUIController_OnGetAllAttachments;
				this.m_mailListUICtrl.m_mailDetailUICtrl.EventOnGetAttachmentButtonClick -= this.MailDetailUIController_OnGetAttachmentButtonClick;
				this.m_mailListUICtrl.m_mailDetailUICtrl.EventOnGotoButtonClick -= this.MailDetailUIController_OnGotoButtonClick;
				this.m_playerCtx.EventOnMailReadAck -= this.OnMailReadAck;
				this.m_mailListUICtrl = null;
			}
		}

		// Token: 0x06011E42 RID: 73282 RVA: 0x0049FA20 File Offset: 0x0049DC20
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.IsOpeningUI())
			{
				this.m_mailListUICtrl.Open();
			}
			this.m_mailListUICtrl.UpdateMailInfoList(this.m_mailInfoCache, this.m_currentSelectedMail, this.IsPipelineStateMaskNeedUpdate(MailUITask.PipeLineStateMaskType.AllRefresh));
			if (!this.m_mailInfoCache.Contains(this.m_currentSelectedMail))
			{
				this.m_currentSelectedMail = null;
			}
			this.m_mailListUICtrl.UpdateCurrentSelectedMailDetail(this.m_currentSelectedMail, this.m_mailInfoCache.Count <= 0);
		}

		// Token: 0x06011E43 RID: 73283 RVA: 0x0049FAF4 File Offset: 0x0049DCF4
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currentSelectedMail = null;
			this.EnablePipelineStateMask(MailUITask.PipeLineStateMaskType.AllRefresh);
			return base.OnResume(intent);
		}

		// Token: 0x06011E44 RID: 73284 RVA: 0x0049FB88 File Offset: 0x0049DD88
		private void MailListUIController_OnMailItemButtonClick(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MailListUIController_OnMailItemButtonClickMail_hotfix != null)
			{
				this.m_MailListUIController_OnMailItemButtonClickMail_hotfix.call(new object[]
				{
					this,
					mail
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currentSelectedMail = mail;
			this.EnablePipelineStateMask(MailUITask.PipeLineStateMaskType.ForUIClick);
			if (!this.m_playerCtx.IsMailReaded(mail))
			{
				MailReadNetTask mailReadNetTask = new MailReadNetTask(this.m_currentSelectedMail.InstanceId);
				mailReadNetTask.EventOnStop += delegate(Task task)
				{
					MailReadNetTask mailReadNetTask2 = task as MailReadNetTask;
					if (mailReadNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(mailReadNetTask2.Result, 2f, null, true);
					}
					else
					{
						this.m_currentSelectedMail.Status = 1;
					}
				};
				mailReadNetTask.Start(null);
			}
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06011E45 RID: 73285 RVA: 0x0049FC50 File Offset: 0x0049DE50
		private void MailListUIController_OnCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MailListUIController_OnCloseButtonClick_hotfix != null)
			{
				this.m_MailListUIController_OnCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			base.ReturnPrevUITask();
		}

		// Token: 0x06011E46 RID: 73286 RVA: 0x0049FCC0 File Offset: 0x0049DEC0
		private static void AppendGoodsToList(Goods goods, List<Goods> goodsList)
		{
			foreach (Goods goods2 in goodsList)
			{
				if (goods2.GoodsType == goods.GoodsType)
				{
					goods2.Count += goods.Count;
					return;
				}
			}
			goodsList.Add(goods);
		}

		// Token: 0x06011E47 RID: 73287 RVA: 0x0049FD40 File Offset: 0x0049DF40
		private void MailListUIController_OnGetAllAttachments()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MailListUIController_OnGetAllAttachments_hotfix != null)
			{
				this.m_MailListUIController_OnGetAllAttachments_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAutoGetMailAttachment();
			if (num == 0)
			{
				MailAttachmentsAutoGetNetTask mailAttachmentsAutoGetNetTask = new MailAttachmentsAutoGetNetTask();
				mailAttachmentsAutoGetNetTask.EventOnStop += delegate(Task task)
				{
					MailAttachmentsAutoGetNetTask mailAttachmentsAutoGetNetTask2 = task as MailAttachmentsAutoGetNetTask;
					if (mailAttachmentsAutoGetNetTask2.Result == 0)
					{
						GetRewardGoodsUITask.StartUITask(mailAttachmentsAutoGetNetTask2.Reward);
						if (this.m_currentSelectedMail != null && this.m_currentSelectedMail.GotDeleted)
						{
							this.m_currentSelectedMail = null;
						}
						for (int i = this.m_mailInfoCache.Count - 1; i >= 0; i--)
						{
							Mail mail = this.m_mailInfoCache[i];
							if (mail != null)
							{
								if (mail.GotDeleted)
								{
									this.m_mailInfoCache.Remove(mail);
								}
							}
							else
							{
								this.m_mailInfoCache.Remove(mail);
							}
						}
						this.EnablePipelineStateMask(MailUITask.PipeLineStateMaskType.IsReadGetMailAttachment);
						base.StartUpdatePipeLine(null, false, false, true);
					}
					else
					{
						this.HandleGetMailError(mailAttachmentsAutoGetNetTask2.Result);
					}
				};
				mailAttachmentsAutoGetNetTask.Start(null);
			}
			else
			{
				this.HandleGetMailError(num);
			}
		}

		// Token: 0x06011E48 RID: 73288 RVA: 0x0049FDEC File Offset: 0x0049DFEC
		private void MailDetailUIController_OnGotoButtonClick(Mail obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MailDetailUIController_OnGotoButtonClickMail_hotfix != null)
			{
				this.m_MailDetailUIController_OnGotoButtonClickMail_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06011E49 RID: 73289 RVA: 0x0049FE60 File Offset: 0x0049E060
		private void MailDetailUIController_OnGetAttachmentButtonClick(Mail mail)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MailDetailUIController_OnGetAttachmentButtonClickMail_hotfix != null)
			{
				this.m_MailDetailUIController_OnGetAttachmentButtonClickMail_hotfix.call(new object[]
				{
					this,
					mail3
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Mail mail = mail3;
			MailUITask $this = this;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanGetMailAttachment(mail.InstanceId);
			if (num == 0)
			{
				MailAttachmentsGetNetTask mailAttachmentsGetNetTask = new MailAttachmentsGetNetTask(this.m_currentSelectedMail.InstanceId);
				mailAttachmentsGetNetTask.EventOnStop += delegate(Task task)
				{
					MailAttachmentsGetNetTask mailAttachmentsGetNetTask2 = task as MailAttachmentsGetNetTask;
					if (mailAttachmentsGetNetTask2.Result == 0)
					{
						GetRewardGoodsUITask.StartUITask(mailAttachmentsGetNetTask2.Reward);
						$this.m_currentSelectedMail.Status = 2;
						if (mail.GotDeleted)
						{
							Mail mail2 = $this.m_mailInfoCache.Find((Mail m) => m == mail);
							if (mail2 != null)
							{
								$this.m_mailInfoCache.Remove(mail2);
							}
							$this.m_currentSelectedMail = null;
						}
						$this.EnablePipelineStateMask(MailUITask.PipeLineStateMaskType.IsReadGetMailAttachment);
						$this.StartUpdatePipeLine(null, false, false, true);
					}
					else
					{
						$this.HandleGetMailError(mailAttachmentsGetNetTask2.Result);
					}
				};
				mailAttachmentsGetNetTask.Start(null);
			}
			else
			{
				this.HandleGetMailError(num);
			}
		}

		// Token: 0x06011E4A RID: 73290 RVA: 0x0049FF44 File Offset: 0x0049E144
		private void HandleGetMailError(int result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleGetMailErrorInt32_hotfix != null)
			{
				this.m_HandleGetMailErrorInt32_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (result != 0)
			{
				if (result == -1004 || result == -1001)
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Mail_IsExpired, 2f, null, true);
				}
				else if (result == -1003)
				{
					CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Mail_AttachmentHadGot, 2f, null, true);
				}
				else if (result == -500)
				{
					BagFullUITask.StartUITask(this.m_currIntent);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
			}
		}

		// Token: 0x06011E4B RID: 73291 RVA: 0x004A0044 File Offset: 0x0049E244
		private void OnMailsChangedNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMailsChangedNtf_hotfix != null)
			{
				this.m_OnMailsChangedNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06011E4C RID: 73292 RVA: 0x004A00B0 File Offset: 0x0049E2B0
		private void OnMailReadAck(int result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMailReadAckInt32_hotfix != null)
			{
				this.m_OnMailReadAckInt32_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (result == 0)
			{
				this.EnablePipelineStateMask(MailUITask.PipeLineStateMaskType.IsReadGetMailAttachment);
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else
			{
				Debug.LogError("OnMailReadAck Result:" + result);
			}
		}

		// Token: 0x06011E4D RID: 73293 RVA: 0x004A0154 File Offset: 0x0049E354
		protected bool IsPipelineStateMaskNeedUpdate(MailUITask.PipeLineStateMaskType state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix.call(new object[]
				{
					this,
					state
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_currPipeLineCtx.IsNeedUpdate((int)state);
		}

		// Token: 0x06011E4E RID: 73294 RVA: 0x004A01DC File Offset: 0x0049E3DC
		protected void EnablePipelineStateMask(MailUITask.PipeLineStateMaskType state)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix != null)
			{
				this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix.call(new object[]
				{
					this,
					state
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPipeLineCtx.AddUpdateMask((int)state);
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x06011E4F RID: 73295 RVA: 0x004A0258 File Offset: 0x0049E458
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x06011E50 RID: 73296 RVA: 0x004A02CC File Offset: 0x0049E4CC
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x06011E51 RID: 73297 RVA: 0x004A0340 File Offset: 0x0049E540
		// (set) Token: 0x06011E52 RID: 73298 RVA: 0x004A0360 File Offset: 0x0049E560
		[DoNotToLua]
		public new MailUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MailUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011E53 RID: 73299 RVA: 0x004A036C File Offset: 0x0049E56C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06011E54 RID: 73300 RVA: 0x004A0378 File Offset: 0x0049E578
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06011E55 RID: 73301 RVA: 0x004A0380 File Offset: 0x0049E580
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06011E56 RID: 73302 RVA: 0x004A0388 File Offset: 0x0049E588
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06011E57 RID: 73303 RVA: 0x004A0394 File Offset: 0x0049E594
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06011E58 RID: 73304 RVA: 0x004A03A0 File Offset: 0x0049E5A0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06011E59 RID: 73305 RVA: 0x004A03AC File Offset: 0x0049E5AC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06011E5A RID: 73306 RVA: 0x004A03B4 File Offset: 0x0049E5B4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06011E5B RID: 73307 RVA: 0x004A03BC File Offset: 0x0049E5BC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06011E5C RID: 73308 RVA: 0x004A03C4 File Offset: 0x0049E5C4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06011E5D RID: 73309 RVA: 0x004A03CC File Offset: 0x0049E5CC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06011E5E RID: 73310 RVA: 0x004A03D4 File Offset: 0x0049E5D4
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06011E5F RID: 73311 RVA: 0x004A03DC File Offset: 0x0049E5DC
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06011E60 RID: 73312 RVA: 0x004A03E4 File Offset: 0x0049E5E4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06011E61 RID: 73313 RVA: 0x004A03F0 File Offset: 0x0049E5F0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06011E62 RID: 73314 RVA: 0x004A03FC File Offset: 0x0049E5FC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06011E63 RID: 73315 RVA: 0x004A0408 File Offset: 0x0049E608
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06011E64 RID: 73316 RVA: 0x004A0414 File Offset: 0x0049E614
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06011E65 RID: 73317 RVA: 0x004A041C File Offset: 0x0049E61C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06011E66 RID: 73318 RVA: 0x004A0424 File Offset: 0x0049E624
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06011E67 RID: 73319 RVA: 0x004A042C File Offset: 0x0049E62C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06011E68 RID: 73320 RVA: 0x004A0434 File Offset: 0x0049E634
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06011E69 RID: 73321 RVA: 0x004A043C File Offset: 0x0049E63C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06011E6C RID: 73324 RVA: 0x004A0558 File Offset: 0x0049E758
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_PrepareForStartOrResumeUIIntentAction`1_hotfix = (luaObj.RawGet("PrepareForStartOrResume") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_IsNeedUpdateDataCache_hotfix = (luaObj.RawGet("IsNeedUpdateDataCache") as LuaFunction);
					this.m_UpdateDataCache_hotfix = (luaObj.RawGet("UpdateDataCache") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_MailCompareMailMail_hotfix = (luaObj.RawGet("MailCompare") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_MailListUIController_OnMailItemButtonClickMail_hotfix = (luaObj.RawGet("MailListUIController_OnMailItemButtonClick") as LuaFunction);
					this.m_MailListUIController_OnCloseButtonClick_hotfix = (luaObj.RawGet("MailListUIController_OnCloseButtonClick") as LuaFunction);
					this.m_MailListUIController_OnGetAllAttachments_hotfix = (luaObj.RawGet("MailListUIController_OnGetAllAttachments") as LuaFunction);
					this.m_MailDetailUIController_OnGotoButtonClickMail_hotfix = (luaObj.RawGet("MailDetailUIController_OnGotoButtonClick") as LuaFunction);
					this.m_MailDetailUIController_OnGetAttachmentButtonClickMail_hotfix = (luaObj.RawGet("MailDetailUIController_OnGetAttachmentButtonClick") as LuaFunction);
					this.m_HandleGetMailErrorInt32_hotfix = (luaObj.RawGet("HandleGetMailError") as LuaFunction);
					this.m_OnMailsChangedNtf_hotfix = (luaObj.RawGet("OnMailsChangedNtf") as LuaFunction);
					this.m_OnMailReadAckInt32_hotfix = (luaObj.RawGet("OnMailReadAck") as LuaFunction);
					this.m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix = (luaObj.RawGet("IsPipelineStateMaskNeedUpdate") as LuaFunction);
					this.m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix = (luaObj.RawGet("EnablePipelineStateMask") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011E6D RID: 73325 RVA: 0x004A084C File Offset: 0x0049EA4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A277 RID: 41591
		private ProjectLPlayerContext m_playerCtx = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400A278 RID: 41592
		private MailListUIController m_mailListUICtrl;

		// Token: 0x0400A279 RID: 41593
		private List<Mail> m_mailInfoCache = new List<Mail>();

		// Token: 0x0400A27A RID: 41594
		private Mail m_currentSelectedMail;

		// Token: 0x0400A27B RID: 41595
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "MailListUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Mail_ABS/Prefab/MailListUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A27C RID: 41596
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "MailListUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.MailListUIController"),
				m_ctrlName = "MailListUIController"
			}
		};

		// Token: 0x0400A27D RID: 41597
		[DoNotToLua]
		private MailUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A27E RID: 41598
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A27F RID: 41599
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A280 RID: 41600
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A281 RID: 41601
		private LuaFunction m_PrepareForStartOrResumeUIIntentAction;

		// Token: 0x0400A282 RID: 41602
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A283 RID: 41603
		private LuaFunction m_IsNeedUpdateDataCache_hotfix;

		// Token: 0x0400A284 RID: 41604
		private LuaFunction m_UpdateDataCache_hotfix;

		// Token: 0x0400A285 RID: 41605
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400A286 RID: 41606
		private LuaFunction m_MailCompareMailMail_hotfix;

		// Token: 0x0400A287 RID: 41607
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A288 RID: 41608
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A289 RID: 41609
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A28A RID: 41610
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400A28B RID: 41611
		private LuaFunction m_MailListUIController_OnMailItemButtonClickMail_hotfix;

		// Token: 0x0400A28C RID: 41612
		private LuaFunction m_MailListUIController_OnCloseButtonClick_hotfix;

		// Token: 0x0400A28D RID: 41613
		private LuaFunction m_MailListUIController_OnGetAllAttachments_hotfix;

		// Token: 0x0400A28E RID: 41614
		private LuaFunction m_MailDetailUIController_OnGotoButtonClickMail_hotfix;

		// Token: 0x0400A28F RID: 41615
		private LuaFunction m_MailDetailUIController_OnGetAttachmentButtonClickMail_hotfix;

		// Token: 0x0400A290 RID: 41616
		private LuaFunction m_HandleGetMailErrorInt32_hotfix;

		// Token: 0x0400A291 RID: 41617
		private LuaFunction m_OnMailsChangedNtf_hotfix;

		// Token: 0x0400A292 RID: 41618
		private LuaFunction m_OnMailReadAckInt32_hotfix;

		// Token: 0x0400A293 RID: 41619
		private LuaFunction m_IsPipelineStateMaskNeedUpdatePipeLineStateMaskType_hotfix;

		// Token: 0x0400A294 RID: 41620
		private LuaFunction m_EnablePipelineStateMaskPipeLineStateMaskType_hotfix;

		// Token: 0x0400A295 RID: 41621
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A296 RID: 41622
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E6B RID: 3691
		public enum PipeLineStateMaskType
		{
			// Token: 0x0400A298 RID: 41624
			AllRefresh,
			// Token: 0x0400A299 RID: 41625
			ForUIClick,
			// Token: 0x0400A29A RID: 41626
			IsReadGetMailAttachment
		}

		// Token: 0x02000E6C RID: 3692
		public new class LuaExportHelper
		{
			// Token: 0x06011E6E RID: 73326 RVA: 0x004A08B4 File Offset: 0x0049EAB4
			public LuaExportHelper(MailUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011E6F RID: 73327 RVA: 0x004A08C4 File Offset: 0x0049EAC4
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06011E70 RID: 73328 RVA: 0x004A08D4 File Offset: 0x0049EAD4
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06011E71 RID: 73329 RVA: 0x004A08E4 File Offset: 0x0049EAE4
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06011E72 RID: 73330 RVA: 0x004A08F4 File Offset: 0x0049EAF4
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06011E73 RID: 73331 RVA: 0x004A0904 File Offset: 0x0049EB04
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06011E74 RID: 73332 RVA: 0x004A0914 File Offset: 0x0049EB14
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06011E75 RID: 73333 RVA: 0x004A0924 File Offset: 0x0049EB24
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06011E76 RID: 73334 RVA: 0x004A0934 File Offset: 0x0049EB34
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06011E77 RID: 73335 RVA: 0x004A0944 File Offset: 0x0049EB44
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06011E78 RID: 73336 RVA: 0x004A0954 File Offset: 0x0049EB54
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06011E79 RID: 73337 RVA: 0x004A0964 File Offset: 0x0049EB64
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06011E7A RID: 73338 RVA: 0x004A0974 File Offset: 0x0049EB74
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06011E7B RID: 73339 RVA: 0x004A0984 File Offset: 0x0049EB84
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06011E7C RID: 73340 RVA: 0x004A0994 File Offset: 0x0049EB94
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06011E7D RID: 73341 RVA: 0x004A09A4 File Offset: 0x0049EBA4
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06011E7E RID: 73342 RVA: 0x004A09B4 File Offset: 0x0049EBB4
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06011E7F RID: 73343 RVA: 0x004A09C4 File Offset: 0x0049EBC4
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06011E80 RID: 73344 RVA: 0x004A09D4 File Offset: 0x0049EBD4
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06011E81 RID: 73345 RVA: 0x004A09E4 File Offset: 0x0049EBE4
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06011E82 RID: 73346 RVA: 0x004A09F4 File Offset: 0x0049EBF4
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06011E83 RID: 73347 RVA: 0x004A0A04 File Offset: 0x0049EC04
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06011E84 RID: 73348 RVA: 0x004A0A14 File Offset: 0x0049EC14
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06011E85 RID: 73349 RVA: 0x004A0A24 File Offset: 0x0049EC24
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x170036C5 RID: 14021
			// (get) Token: 0x06011E86 RID: 73350 RVA: 0x004A0A34 File Offset: 0x0049EC34
			// (set) Token: 0x06011E87 RID: 73351 RVA: 0x004A0A44 File Offset: 0x0049EC44
			public ProjectLPlayerContext m_playerCtx
			{
				get
				{
					return this.m_owner.m_playerCtx;
				}
				set
				{
					this.m_owner.m_playerCtx = value;
				}
			}

			// Token: 0x170036C6 RID: 14022
			// (get) Token: 0x06011E88 RID: 73352 RVA: 0x004A0A54 File Offset: 0x0049EC54
			// (set) Token: 0x06011E89 RID: 73353 RVA: 0x004A0A64 File Offset: 0x0049EC64
			public MailListUIController m_mailListUICtrl
			{
				get
				{
					return this.m_owner.m_mailListUICtrl;
				}
				set
				{
					this.m_owner.m_mailListUICtrl = value;
				}
			}

			// Token: 0x170036C7 RID: 14023
			// (get) Token: 0x06011E8A RID: 73354 RVA: 0x004A0A74 File Offset: 0x0049EC74
			// (set) Token: 0x06011E8B RID: 73355 RVA: 0x004A0A84 File Offset: 0x0049EC84
			public List<Mail> m_mailInfoCache
			{
				get
				{
					return this.m_owner.m_mailInfoCache;
				}
				set
				{
					this.m_owner.m_mailInfoCache = value;
				}
			}

			// Token: 0x170036C8 RID: 14024
			// (get) Token: 0x06011E8C RID: 73356 RVA: 0x004A0A94 File Offset: 0x0049EC94
			// (set) Token: 0x06011E8D RID: 73357 RVA: 0x004A0AA4 File Offset: 0x0049ECA4
			public Mail m_currentSelectedMail
			{
				get
				{
					return this.m_owner.m_currentSelectedMail;
				}
				set
				{
					this.m_owner.m_currentSelectedMail = value;
				}
			}

			// Token: 0x170036C9 RID: 14025
			// (get) Token: 0x06011E8E RID: 73358 RVA: 0x004A0AB4 File Offset: 0x0049ECB4
			// (set) Token: 0x06011E8F RID: 73359 RVA: 0x004A0AC4 File Offset: 0x0049ECC4
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x170036CA RID: 14026
			// (get) Token: 0x06011E90 RID: 73360 RVA: 0x004A0AD4 File Offset: 0x0049ECD4
			// (set) Token: 0x06011E91 RID: 73361 RVA: 0x004A0AE4 File Offset: 0x0049ECE4
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x170036CB RID: 14027
			// (get) Token: 0x06011E92 RID: 73362 RVA: 0x004A0AF4 File Offset: 0x0049ECF4
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170036CC RID: 14028
			// (get) Token: 0x06011E93 RID: 73363 RVA: 0x004A0B04 File Offset: 0x0049ED04
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06011E94 RID: 73364 RVA: 0x004A0B14 File Offset: 0x0049ED14
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06011E95 RID: 73365 RVA: 0x004A0B24 File Offset: 0x0049ED24
			public bool IsNeedUpdateDataCache()
			{
				return this.m_owner.IsNeedUpdateDataCache();
			}

			// Token: 0x06011E96 RID: 73366 RVA: 0x004A0B34 File Offset: 0x0049ED34
			public void UpdateDataCache()
			{
				this.m_owner.UpdateDataCache();
			}

			// Token: 0x06011E97 RID: 73367 RVA: 0x004A0B44 File Offset: 0x0049ED44
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06011E98 RID: 73368 RVA: 0x004A0B54 File Offset: 0x0049ED54
			public int MailCompare(Mail mailA, Mail mailB)
			{
				return this.m_owner.MailCompare(mailA, mailB);
			}

			// Token: 0x06011E99 RID: 73369 RVA: 0x004A0B64 File Offset: 0x0049ED64
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06011E9A RID: 73370 RVA: 0x004A0B74 File Offset: 0x0049ED74
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06011E9B RID: 73371 RVA: 0x004A0B84 File Offset: 0x0049ED84
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06011E9C RID: 73372 RVA: 0x004A0B94 File Offset: 0x0049ED94
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06011E9D RID: 73373 RVA: 0x004A0BA4 File Offset: 0x0049EDA4
			public void MailListUIController_OnMailItemButtonClick(Mail mail)
			{
				this.m_owner.MailListUIController_OnMailItemButtonClick(mail);
			}

			// Token: 0x06011E9E RID: 73374 RVA: 0x004A0BB4 File Offset: 0x0049EDB4
			public void MailListUIController_OnCloseButtonClick()
			{
				this.m_owner.MailListUIController_OnCloseButtonClick();
			}

			// Token: 0x06011E9F RID: 73375 RVA: 0x004A0BC4 File Offset: 0x0049EDC4
			public static void AppendGoodsToList(Goods goods, List<Goods> goodsList)
			{
				MailUITask.AppendGoodsToList(goods, goodsList);
			}

			// Token: 0x06011EA0 RID: 73376 RVA: 0x004A0BD0 File Offset: 0x0049EDD0
			public void MailListUIController_OnGetAllAttachments()
			{
				this.m_owner.MailListUIController_OnGetAllAttachments();
			}

			// Token: 0x06011EA1 RID: 73377 RVA: 0x004A0BE0 File Offset: 0x0049EDE0
			public void MailDetailUIController_OnGotoButtonClick(Mail obj)
			{
				this.m_owner.MailDetailUIController_OnGotoButtonClick(obj);
			}

			// Token: 0x06011EA2 RID: 73378 RVA: 0x004A0BF0 File Offset: 0x0049EDF0
			public void MailDetailUIController_OnGetAttachmentButtonClick(Mail mail)
			{
				this.m_owner.MailDetailUIController_OnGetAttachmentButtonClick(mail);
			}

			// Token: 0x06011EA3 RID: 73379 RVA: 0x004A0C00 File Offset: 0x0049EE00
			public void HandleGetMailError(int result)
			{
				this.m_owner.HandleGetMailError(result);
			}

			// Token: 0x06011EA4 RID: 73380 RVA: 0x004A0C10 File Offset: 0x0049EE10
			public void OnMailsChangedNtf()
			{
				this.m_owner.OnMailsChangedNtf();
			}

			// Token: 0x06011EA5 RID: 73381 RVA: 0x004A0C20 File Offset: 0x0049EE20
			public void OnMailReadAck(int result)
			{
				this.m_owner.OnMailReadAck(result);
			}

			// Token: 0x06011EA6 RID: 73382 RVA: 0x004A0C30 File Offset: 0x0049EE30
			public bool IsPipelineStateMaskNeedUpdate(MailUITask.PipeLineStateMaskType state)
			{
				return this.m_owner.IsPipelineStateMaskNeedUpdate(state);
			}

			// Token: 0x06011EA7 RID: 73383 RVA: 0x004A0C40 File Offset: 0x0049EE40
			public void EnablePipelineStateMask(MailUITask.PipeLineStateMaskType state)
			{
				this.m_owner.EnablePipelineStateMask(state);
			}

			// Token: 0x0400A29B RID: 41627
			private MailUITask m_owner;
		}
	}
}
