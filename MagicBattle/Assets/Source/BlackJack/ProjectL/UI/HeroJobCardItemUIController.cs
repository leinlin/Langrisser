using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DBB RID: 3515
	[HotFix]
	public class HeroJobCardItemUIController : UIControllerBase
	{
		// Token: 0x06010B3B RID: 68411 RVA: 0x00455988 File Offset: 0x00453B88
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnHeroJobCardItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x06010B3C RID: 68412 RVA: 0x00455A1C File Offset: 0x00453C1C
		public void InitHeroJobCardItem(Hero hero, ConfigDataJobConnectionInfo jobConnectionInfo, int rank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroJobCardItemHeroConfigDataJobConnectionInfoInt32_hotfix != null)
			{
				this.m_InitHeroJobCardItemHeroConfigDataJobConnectionInfoInt32_hotfix.call(new object[]
				{
					this,
					hero,
					jobConnectionInfo,
					rank
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.JobConnectionInfo = jobConnectionInfo;
			this.m_rank = rank;
			this.SetInfoByState();
		}

		// Token: 0x06010B3D RID: 68413 RVA: 0x00455AC8 File Offset: 0x00453CC8
		private void SetInfoByState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetInfoByState_hotfix != null)
			{
				this.m_SetInfoByState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_nameText.text = this.JobConnectionInfo.m_jobInfo.Name;
			this.m_curJobImg.SetActive(this.m_hero.GetActiveJob().JobConnectionInfo == this.JobConnectionInfo);
			this.m_icon.sprite = AssetUtility.Instance.GetSprite(this.JobConnectionInfo.m_jobInfo.JobIcon);
			if (this.m_hero.Jobs.Find((HeroJob a) => a.JobRelatedId == this.JobConnectionInfo.ID) != null)
			{
				this.m_icon.color = new Color(1f, 1f, 1f, 1f);
			}
			else
			{
				this.m_icon.color = new Color(1f, 1f, 1f, 0.5f);
			}
			this.IsNeedMagicStone = projectLPlayerContext.IsHeroJobNeedMagicStone(this.m_hero.HeroId, this.JobConnectionInfo.ID);
			this.m_magicStone.SetActive(this.IsNeedMagicStone);
			this.IsJobLocked = (this.JobConnectionInfo.m_unlockConditions.Count != 0);
			this.m_lockImg.SetActive(this.IsJobLocked);
			this.HaveRedIcon = (this.m_hero.Jobs.Find((HeroJob job) => job.JobConnectionInfo == this.JobConnectionInfo) == null && projectLPlayerContext.CanHeroJobTransfer(this.m_hero.HeroId, this.JobConnectionInfo.ID) == 0 && !this.IsNeedMagicStone);
			this.m_redIcon.SetActive(this.HaveRedIcon);
			this.m_masterIcon.SetActive(this.IsJobMaster());
		}

		// Token: 0x06010B3E RID: 68414 RVA: 0x00455CE0 File Offset: 0x00453EE0
		public void SetFrameImage(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetFrameImageBoolean_hotfix != null)
			{
				this.m_SetFrameImageBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_frameImg.SetActive(isShow);
		}

		// Token: 0x06010B3F RID: 68415 RVA: 0x00455D5C File Offset: 0x00453F5C
		public bool IsJobMaster()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsJobMaster_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsJobMaster_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroJob job = this.m_hero.GetJob(this.JobConnectionInfo.ID);
			if (job == null)
			{
				return false;
			}
			int jobLevel = job.JobLevel;
			int num = this.JobConnectionInfo.m_jobLevelInfos.Length - 1;
			return jobLevel == num;
		}

		// Token: 0x06010B40 RID: 68416 RVA: 0x00455E04 File Offset: 0x00454004
		private bool IsLight()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLight_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLight_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int rank = this.JobConnectionInfo.m_jobInfo.Rank;
			int canTransferMaxRank = this.m_hero.CanTransferMaxRank;
			return rank <= canTransferMaxRank;
		}

		// Token: 0x06010B41 RID: 68417 RVA: 0x00455E98 File Offset: 0x00454098
		private void OnHeroJobCardItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroJobCardItemClick_hotfix != null)
			{
				this.m_OnHeroJobCardItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnJobCardItemClick != null)
			{
				this.EventOnJobCardItemClick(this);
			}
		}

		// Token: 0x1400038D RID: 909
		// (add) Token: 0x06010B42 RID: 68418 RVA: 0x00455F10 File Offset: 0x00454110
		// (remove) Token: 0x06010B43 RID: 68419 RVA: 0x00455FAC File Offset: 0x004541AC
		public event Action<HeroJobCardItemUIController> EventOnJobCardItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnJobCardItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnJobCardItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroJobCardItemUIController> action = this.EventOnJobCardItemClick;
				Action<HeroJobCardItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroJobCardItemUIController>>(ref this.EventOnJobCardItemClick, (Action<HeroJobCardItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnJobCardItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnJobCardItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroJobCardItemUIController> action = this.EventOnJobCardItemClick;
				Action<HeroJobCardItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroJobCardItemUIController>>(ref this.EventOnJobCardItemClick, (Action<HeroJobCardItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x06010B45 RID: 68421 RVA: 0x004560C0 File Offset: 0x004542C0
		// (set) Token: 0x06010B44 RID: 68420 RVA: 0x00456048 File Offset: 0x00454248
		public ConfigDataJobConnectionInfo JobConnectionInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_JobConnectionInfo_hotfix != null)
				{
					return (ConfigDataJobConnectionInfo)this.m_get_JobConnectionInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<JobConnectionInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_JobConnectionInfoConfigDataJobConnectionInfo_hotfix != null)
				{
					this.m_set_JobConnectionInfoConfigDataJobConnectionInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<JobConnectionInfo>k__BackingField = value;
			}
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x06010B47 RID: 68423 RVA: 0x004561AC File Offset: 0x004543AC
		// (set) Token: 0x06010B46 RID: 68422 RVA: 0x00456134 File Offset: 0x00454334
		public bool IsNeedMagicStone
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsNeedMagicStone_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsNeedMagicStone_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsNeedMagicStone>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IsNeedMagicStoneBoolean_hotfix != null)
				{
					this.m_set_IsNeedMagicStoneBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsNeedMagicStone>k__BackingField = value;
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x06010B49 RID: 68425 RVA: 0x00456298 File Offset: 0x00454498
		// (set) Token: 0x06010B48 RID: 68424 RVA: 0x00456220 File Offset: 0x00454420
		public bool IsJobLocked
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsJobLocked_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsJobLocked_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsJobLocked>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IsJobLockedBoolean_hotfix != null)
				{
					this.m_set_IsJobLockedBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsJobLocked>k__BackingField = value;
			}
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x06010B4B RID: 68427 RVA: 0x00456384 File Offset: 0x00454584
		// (set) Token: 0x06010B4A RID: 68426 RVA: 0x0045630C File Offset: 0x0045450C
		public bool HaveRedIcon
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HaveRedIcon_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_HaveRedIcon_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HaveRedIcon>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HaveRedIconBoolean_hotfix != null)
				{
					this.m_set_HaveRedIconBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HaveRedIcon>k__BackingField = value;
			}
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x06010B4C RID: 68428 RVA: 0x004563F8 File Offset: 0x004545F8
		// (set) Token: 0x06010B4D RID: 68429 RVA: 0x00456418 File Offset: 0x00454618
		[DoNotToLua]
		public new HeroJobCardItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroJobCardItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010B4E RID: 68430 RVA: 0x00456424 File Offset: 0x00454624
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010B4F RID: 68431 RVA: 0x00456430 File Offset: 0x00454630
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010B50 RID: 68432 RVA: 0x00456438 File Offset: 0x00454638
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010B51 RID: 68433 RVA: 0x00456440 File Offset: 0x00454640
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010B52 RID: 68434 RVA: 0x00456454 File Offset: 0x00454654
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010B53 RID: 68435 RVA: 0x0045645C File Offset: 0x0045465C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010B54 RID: 68436 RVA: 0x00456468 File Offset: 0x00454668
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010B55 RID: 68437 RVA: 0x00456474 File Offset: 0x00454674
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010B56 RID: 68438 RVA: 0x00456480 File Offset: 0x00454680
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010B57 RID: 68439 RVA: 0x0045648C File Offset: 0x0045468C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010B58 RID: 68440 RVA: 0x00456498 File Offset: 0x00454698
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010B59 RID: 68441 RVA: 0x004564A4 File Offset: 0x004546A4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010B5A RID: 68442 RVA: 0x004564B0 File Offset: 0x004546B0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010B5B RID: 68443 RVA: 0x004564BC File Offset: 0x004546BC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010B5C RID: 68444 RVA: 0x004564C8 File Offset: 0x004546C8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010B5D RID: 68445 RVA: 0x004564D0 File Offset: 0x004546D0
		private void __callDele_EventOnJobCardItemClick(HeroJobCardItemUIController obj)
		{
			Action<HeroJobCardItemUIController> eventOnJobCardItemClick = this.EventOnJobCardItemClick;
			if (eventOnJobCardItemClick != null)
			{
				eventOnJobCardItemClick(obj);
			}
		}

		// Token: 0x06010B5E RID: 68446 RVA: 0x004564F4 File Offset: 0x004546F4
		private void __clearDele_EventOnJobCardItemClick(HeroJobCardItemUIController obj)
		{
			this.EventOnJobCardItemClick = null;
		}

		// Token: 0x06010B61 RID: 68449 RVA: 0x00456528 File Offset: 0x00454728
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_InitHeroJobCardItemHeroConfigDataJobConnectionInfoInt32_hotfix = (luaObj.RawGet("InitHeroJobCardItem") as LuaFunction);
					this.m_SetInfoByState_hotfix = (luaObj.RawGet("SetInfoByState") as LuaFunction);
					this.m_SetFrameImageBoolean_hotfix = (luaObj.RawGet("SetFrameImage") as LuaFunction);
					this.m_IsJobMaster_hotfix = (luaObj.RawGet("IsJobMaster") as LuaFunction);
					this.m_IsLight_hotfix = (luaObj.RawGet("IsLight") as LuaFunction);
					this.m_OnHeroJobCardItemClick_hotfix = (luaObj.RawGet("OnHeroJobCardItemClick") as LuaFunction);
					this.m_add_EventOnJobCardItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnJobCardItemClick") as LuaFunction);
					this.m_remove_EventOnJobCardItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnJobCardItemClick") as LuaFunction);
					this.m_set_JobConnectionInfoConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("set_JobConnectionInfo") as LuaFunction);
					this.m_get_JobConnectionInfo_hotfix = (luaObj.RawGet("get_JobConnectionInfo") as LuaFunction);
					this.m_set_IsNeedMagicStoneBoolean_hotfix = (luaObj.RawGet("set_IsNeedMagicStone") as LuaFunction);
					this.m_get_IsNeedMagicStone_hotfix = (luaObj.RawGet("get_IsNeedMagicStone") as LuaFunction);
					this.m_set_IsJobLockedBoolean_hotfix = (luaObj.RawGet("set_IsJobLocked") as LuaFunction);
					this.m_get_IsJobLocked_hotfix = (luaObj.RawGet("get_IsJobLocked") as LuaFunction);
					this.m_set_HaveRedIconBoolean_hotfix = (luaObj.RawGet("set_HaveRedIcon") as LuaFunction);
					this.m_get_HaveRedIcon_hotfix = (luaObj.RawGet("get_HaveRedIcon") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010B62 RID: 68450 RVA: 0x00456784 File Offset: 0x00454984
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobCardItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009A4F RID: 39503
		[AutoBind("./Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_icon;

		// Token: 0x04009A50 RID: 39504
		[AutoBind("./CurJobImg", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_curJobImg;

		// Token: 0x04009A51 RID: 39505
		[AutoBind("./MagicStone", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_magicStone;

		// Token: 0x04009A52 RID: 39506
		[AutoBind("./LockImg", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lockImg;

		// Token: 0x04009A53 RID: 39507
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04009A54 RID: 39508
		[AutoBind("./Frame", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_frameImg;

		// Token: 0x04009A55 RID: 39509
		[AutoBind("./RedIcon", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_redIcon;

		// Token: 0x04009A56 RID: 39510
		[AutoBind("./Master", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_masterIcon;

		// Token: 0x04009A5B RID: 39515
		private Hero m_hero;

		// Token: 0x04009A5C RID: 39516
		private int m_rank;

		// Token: 0x04009A5D RID: 39517
		[DoNotToLua]
		private HeroJobCardItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009A5E RID: 39518
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009A5F RID: 39519
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009A60 RID: 39520
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009A61 RID: 39521
		private LuaFunction m_InitHeroJobCardItemHeroConfigDataJobConnectionInfoInt32_hotfix;

		// Token: 0x04009A62 RID: 39522
		private LuaFunction m_SetInfoByState_hotfix;

		// Token: 0x04009A63 RID: 39523
		private LuaFunction m_SetFrameImageBoolean_hotfix;

		// Token: 0x04009A64 RID: 39524
		private LuaFunction m_IsJobMaster_hotfix;

		// Token: 0x04009A65 RID: 39525
		private LuaFunction m_IsLight_hotfix;

		// Token: 0x04009A66 RID: 39526
		private LuaFunction m_OnHeroJobCardItemClick_hotfix;

		// Token: 0x04009A67 RID: 39527
		private LuaFunction m_add_EventOnJobCardItemClickAction;

		// Token: 0x04009A68 RID: 39528
		private LuaFunction m_remove_EventOnJobCardItemClickAction;

		// Token: 0x04009A69 RID: 39529
		private LuaFunction m_set_JobConnectionInfoConfigDataJobConnectionInfo_hotfix;

		// Token: 0x04009A6A RID: 39530
		private LuaFunction m_get_JobConnectionInfo_hotfix;

		// Token: 0x04009A6B RID: 39531
		private LuaFunction m_set_IsNeedMagicStoneBoolean_hotfix;

		// Token: 0x04009A6C RID: 39532
		private LuaFunction m_get_IsNeedMagicStone_hotfix;

		// Token: 0x04009A6D RID: 39533
		private LuaFunction m_set_IsJobLockedBoolean_hotfix;

		// Token: 0x04009A6E RID: 39534
		private LuaFunction m_get_IsJobLocked_hotfix;

		// Token: 0x04009A6F RID: 39535
		private LuaFunction m_set_HaveRedIconBoolean_hotfix;

		// Token: 0x04009A70 RID: 39536
		private LuaFunction m_get_HaveRedIcon_hotfix;

		// Token: 0x02000DBC RID: 3516
		public new class LuaExportHelper
		{
			// Token: 0x06010B63 RID: 68451 RVA: 0x004567EC File Offset: 0x004549EC
			public LuaExportHelper(HeroJobCardItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010B64 RID: 68452 RVA: 0x004567FC File Offset: 0x004549FC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010B65 RID: 68453 RVA: 0x0045680C File Offset: 0x00454A0C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010B66 RID: 68454 RVA: 0x0045681C File Offset: 0x00454A1C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010B67 RID: 68455 RVA: 0x0045682C File Offset: 0x00454A2C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010B68 RID: 68456 RVA: 0x00456844 File Offset: 0x00454A44
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010B69 RID: 68457 RVA: 0x00456854 File Offset: 0x00454A54
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010B6A RID: 68458 RVA: 0x00456864 File Offset: 0x00454A64
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010B6B RID: 68459 RVA: 0x00456874 File Offset: 0x00454A74
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010B6C RID: 68460 RVA: 0x00456884 File Offset: 0x00454A84
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010B6D RID: 68461 RVA: 0x00456894 File Offset: 0x00454A94
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010B6E RID: 68462 RVA: 0x004568A4 File Offset: 0x00454AA4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010B6F RID: 68463 RVA: 0x004568B4 File Offset: 0x00454AB4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010B70 RID: 68464 RVA: 0x004568C4 File Offset: 0x00454AC4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010B71 RID: 68465 RVA: 0x004568D4 File Offset: 0x00454AD4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010B72 RID: 68466 RVA: 0x004568E4 File Offset: 0x00454AE4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010B73 RID: 68467 RVA: 0x004568F4 File Offset: 0x00454AF4
			public void __callDele_EventOnJobCardItemClick(HeroJobCardItemUIController obj)
			{
				this.m_owner.__callDele_EventOnJobCardItemClick(obj);
			}

			// Token: 0x06010B74 RID: 68468 RVA: 0x00456904 File Offset: 0x00454B04
			public void __clearDele_EventOnJobCardItemClick(HeroJobCardItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnJobCardItemClick(obj);
			}

			// Token: 0x170033A8 RID: 13224
			// (get) Token: 0x06010B75 RID: 68469 RVA: 0x00456914 File Offset: 0x00454B14
			// (set) Token: 0x06010B76 RID: 68470 RVA: 0x00456924 File Offset: 0x00454B24
			public Image m_icon
			{
				get
				{
					return this.m_owner.m_icon;
				}
				set
				{
					this.m_owner.m_icon = value;
				}
			}

			// Token: 0x170033A9 RID: 13225
			// (get) Token: 0x06010B77 RID: 68471 RVA: 0x00456934 File Offset: 0x00454B34
			// (set) Token: 0x06010B78 RID: 68472 RVA: 0x00456944 File Offset: 0x00454B44
			public GameObject m_curJobImg
			{
				get
				{
					return this.m_owner.m_curJobImg;
				}
				set
				{
					this.m_owner.m_curJobImg = value;
				}
			}

			// Token: 0x170033AA RID: 13226
			// (get) Token: 0x06010B79 RID: 68473 RVA: 0x00456954 File Offset: 0x00454B54
			// (set) Token: 0x06010B7A RID: 68474 RVA: 0x00456964 File Offset: 0x00454B64
			public GameObject m_magicStone
			{
				get
				{
					return this.m_owner.m_magicStone;
				}
				set
				{
					this.m_owner.m_magicStone = value;
				}
			}

			// Token: 0x170033AB RID: 13227
			// (get) Token: 0x06010B7B RID: 68475 RVA: 0x00456974 File Offset: 0x00454B74
			// (set) Token: 0x06010B7C RID: 68476 RVA: 0x00456984 File Offset: 0x00454B84
			public GameObject m_lockImg
			{
				get
				{
					return this.m_owner.m_lockImg;
				}
				set
				{
					this.m_owner.m_lockImg = value;
				}
			}

			// Token: 0x170033AC RID: 13228
			// (get) Token: 0x06010B7D RID: 68477 RVA: 0x00456994 File Offset: 0x00454B94
			// (set) Token: 0x06010B7E RID: 68478 RVA: 0x004569A4 File Offset: 0x00454BA4
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x170033AD RID: 13229
			// (get) Token: 0x06010B7F RID: 68479 RVA: 0x004569B4 File Offset: 0x00454BB4
			// (set) Token: 0x06010B80 RID: 68480 RVA: 0x004569C4 File Offset: 0x00454BC4
			public GameObject m_frameImg
			{
				get
				{
					return this.m_owner.m_frameImg;
				}
				set
				{
					this.m_owner.m_frameImg = value;
				}
			}

			// Token: 0x170033AE RID: 13230
			// (get) Token: 0x06010B81 RID: 68481 RVA: 0x004569D4 File Offset: 0x00454BD4
			// (set) Token: 0x06010B82 RID: 68482 RVA: 0x004569E4 File Offset: 0x00454BE4
			public GameObject m_redIcon
			{
				get
				{
					return this.m_owner.m_redIcon;
				}
				set
				{
					this.m_owner.m_redIcon = value;
				}
			}

			// Token: 0x170033AF RID: 13231
			// (get) Token: 0x06010B83 RID: 68483 RVA: 0x004569F4 File Offset: 0x00454BF4
			// (set) Token: 0x06010B84 RID: 68484 RVA: 0x00456A04 File Offset: 0x00454C04
			public GameObject m_masterIcon
			{
				get
				{
					return this.m_owner.m_masterIcon;
				}
				set
				{
					this.m_owner.m_masterIcon = value;
				}
			}

			// Token: 0x170033B0 RID: 13232
			// (get) Token: 0x06010B85 RID: 68485 RVA: 0x00456A14 File Offset: 0x00454C14
			// (set) Token: 0x06010B86 RID: 68486 RVA: 0x00456A24 File Offset: 0x00454C24
			public Hero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x170033B1 RID: 13233
			// (get) Token: 0x06010B87 RID: 68487 RVA: 0x00456A34 File Offset: 0x00454C34
			// (set) Token: 0x06010B88 RID: 68488 RVA: 0x00456A44 File Offset: 0x00454C44
			public int m_rank
			{
				get
				{
					return this.m_owner.m_rank;
				}
				set
				{
					this.m_owner.m_rank = value;
				}
			}

			// Token: 0x170033B2 RID: 13234
			// (set) Token: 0x06010B89 RID: 68489 RVA: 0x00456A54 File Offset: 0x00454C54
			public ConfigDataJobConnectionInfo JobConnectionInfo
			{
				set
				{
					this.m_owner.JobConnectionInfo = value;
				}
			}

			// Token: 0x170033B3 RID: 13235
			// (set) Token: 0x06010B8A RID: 68490 RVA: 0x00456A64 File Offset: 0x00454C64
			public bool IsNeedMagicStone
			{
				set
				{
					this.m_owner.IsNeedMagicStone = value;
				}
			}

			// Token: 0x170033B4 RID: 13236
			// (set) Token: 0x06010B8B RID: 68491 RVA: 0x00456A74 File Offset: 0x00454C74
			public bool IsJobLocked
			{
				set
				{
					this.m_owner.IsJobLocked = value;
				}
			}

			// Token: 0x170033B5 RID: 13237
			// (set) Token: 0x06010B8C RID: 68492 RVA: 0x00456A84 File Offset: 0x00454C84
			public bool HaveRedIcon
			{
				set
				{
					this.m_owner.HaveRedIcon = value;
				}
			}

			// Token: 0x06010B8D RID: 68493 RVA: 0x00456A94 File Offset: 0x00454C94
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010B8E RID: 68494 RVA: 0x00456AA4 File Offset: 0x00454CA4
			public void SetInfoByState()
			{
				this.m_owner.SetInfoByState();
			}

			// Token: 0x06010B8F RID: 68495 RVA: 0x00456AB4 File Offset: 0x00454CB4
			public bool IsLight()
			{
				return this.m_owner.IsLight();
			}

			// Token: 0x06010B90 RID: 68496 RVA: 0x00456AC4 File Offset: 0x00454CC4
			public void OnHeroJobCardItemClick()
			{
				this.m_owner.OnHeroJobCardItemClick();
			}

			// Token: 0x04009A71 RID: 39537
			private HeroJobCardItemUIController m_owner;
		}
	}
}
