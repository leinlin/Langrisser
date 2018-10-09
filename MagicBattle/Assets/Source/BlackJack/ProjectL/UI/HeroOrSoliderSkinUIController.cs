using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E0C RID: 3596
	[HotFix]
	public class HeroOrSoliderSkinUIController : UIControllerBase
	{
		// Token: 0x060113DC RID: 70620 RVA: 0x00479150 File Offset: 0x00477350
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
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x060113DD RID: 70621 RVA: 0x00479210 File Offset: 0x00477410
		public void InitHeroSkinItem(Hero hero, ConfigDataJobConnectionInfo jobConnectionInfo, int skinId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroSkinItemHeroConfigDataJobConnectionInfoInt32_hotfix != null)
			{
				this.m_InitHeroSkinItemHeroConfigDataJobConnectionInfoInt32_hotfix.call(new object[]
				{
					this,
					hero,
					jobConnectionInfo,
					skinId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.JobConnectionInfo = jobConnectionInfo;
			this.IsHeroSkin = true;
			this.IsDefaultSkin = false;
			this.HeroSkinInfo = this.m_configDataLoader.GetConfigDataHeroSkinInfo(skinId);
			if (this.HeroSkinInfo == null)
			{
				return;
			}
			this.m_nameText.text = this.HeroSkinInfo.Name;
			foreach (JobConnection2SkinResource jobConnection2SkinResource in this.HeroSkinInfo.SpecifiedModelSkinResource)
			{
				if (jobConnection2SkinResource.JobConnectionId == this.JobConnectionInfo.ID)
				{
					this.ModelSkinResourceInfo = this.m_configDataLoader.GetConfigDataModelSkinResourceInfo(jobConnection2SkinResource.SkinResourceId);
				}
			}
			if (this.ModelSkinResourceInfo == null)
			{
				return;
			}
			string model = this.ModelSkinResourceInfo.Model;
			float scale = (float)this.JobConnectionInfo.UI_ModelScale * 0.01f;
			Vector2 offset = new Vector2((float)this.JobConnectionInfo.UI_ModelOffsetX, (float)this.JobConnectionInfo.UI_ModelOffsetY) * 1f;
			List<ReplaceAnim> replaceAnims = this.JobConnectionInfo.ReplaceAnims;
			HeroDetailUIController.CreateSpineGraphic(ref this.m_playerHeroGraphic, model, this.m_charGameObject, 1, offset, scale, replaceAnims);
			if (this.m_playerContext.HasOwn(GoodsType.GoodsType_HeroSkin, skinId))
			{
				if (hero.GetActiveJob().ModelSkinId != skinId)
				{
					int jobRelatedId = hero.GetActiveJob().JobRelatedId;
					bool flag = false;
					foreach (JobConnection2SkinResource jobConnection2SkinResource2 in this.HeroSkinInfo.SpecifiedModelSkinResource)
					{
						if (jobConnection2SkinResource2.JobConnectionId == jobRelatedId)
						{
							flag = true;
						}
					}
					if (flag)
					{
						this.m_stateCtrl.SetToUIState("Normal", false, true);
					}
					else
					{
						this.m_stateCtrl.SetToUIState("Unavailable", false, true);
					}
				}
				else
				{
					this.m_stateCtrl.SetToUIState("InUse", false, true);
				}
			}
			else
			{
				this.m_stateCtrl.SetToUIState("Lock", false, true);
			}
		}

		// Token: 0x060113DE RID: 70622 RVA: 0x004794D8 File Offset: 0x004776D8
		public void InitDefaultHeroSkinItem(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDefaultHeroSkinItemHero_hotfix != null)
			{
				this.m_InitDefaultHeroSkinItemHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.JobConnectionInfo = hero.GetActiveJob().JobConnectionInfo;
			this.IsHeroSkin = true;
			this.IsDefaultSkin = true;
			this.HeroSkinInfo = null;
			this.m_nameText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DefaultName);
			string model = this.JobConnectionInfo.Model;
			float scale = (float)this.JobConnectionInfo.UI_ModelScale * 0.01f;
			Vector2 offset = new Vector2((float)this.JobConnectionInfo.UI_ModelOffsetX, (float)this.JobConnectionInfo.UI_ModelOffsetY) * 1f;
			List<ReplaceAnim> replaceAnims = this.JobConnectionInfo.ReplaceAnims;
			HeroDetailUIController.CreateSpineGraphic(ref this.m_playerHeroGraphic, model, this.m_charGameObject, 1, offset, scale, replaceAnims);
			if (hero.GetActiveJob().ModelSkinId != 0)
			{
				this.m_stateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_stateCtrl.SetToUIState("InUse", false, true);
			}
		}

		// Token: 0x060113DF RID: 70623 RVA: 0x00479634 File Offset: 0x00477834
		public void InitSoldierSkinItem(Soldier2SkinResource item, ConfigDataSoldierSkinInfo soldierSkinInfo, Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSoldierSkinItemSoldier2SkinResourceConfigDataSoldierSkinInfoHero_hotfix != null)
			{
				this.m_InitSoldierSkinItemSoldier2SkinResourceConfigDataSoldierSkinInfoHero_hotfix.call(new object[]
				{
					this,
					item,
					soldierSkinInfo,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.IsHeroSkin = false;
			this.IsDefaultSkin = false;
			this.m_stateCtrl.SetToUIState("Normal", false, true);
			this.ModelSkinResourceInfo = this.m_configDataLoader.GetConfigDataModelSkinResourceInfo(item.SkinResourceId);
			this.SoldierInfo = this.m_configDataLoader.GetConfigDataSoldierInfo(item.SoldierId);
			this.SoldierSkinInfo = soldierSkinInfo;
			this.m_nameText.text = soldierSkinInfo.Name;
			float scale = (float)this.SoldierInfo.UI_ModelScale * 0.013f;
			Vector2 offset = new Vector2((float)this.SoldierInfo.UI_ModelOffsetX, (float)this.SoldierInfo.UI_ModelOffsetY) * 1.5f;
			HeroDetailUIController.CreateSpineGraphic(ref this.m_soldierInfoGraphic, this.ModelSkinResourceInfo.Model, this.m_charGameObject, 1, offset, scale, this.SoldierInfo.ReplaceAnims);
			if (this.m_playerContext.HasOwn(GoodsType.GoodsType_SoldierSkin, soldierSkinInfo.ID))
			{
				if (hero.GetSoldierSkinId(this.SoldierInfo.ID) == soldierSkinInfo.ID && this.SoldierInfo.ID == item.SoldierId)
				{
					this.m_stateCtrl.SetToUIState("InUse", false, true);
				}
				else
				{
					this.m_stateCtrl.SetToUIState("Normal", false, true);
				}
			}
			else
			{
				this.m_stateCtrl.SetToUIState("Lock", false, true);
			}
		}

		// Token: 0x060113E0 RID: 70624 RVA: 0x00479820 File Offset: 0x00477A20
		public void InitDefaultSoldierSkinItem(Hero hero, ConfigDataSoldierInfo soldierInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDefaultSoldierSkinItemHeroConfigDataSoldierInfo_hotfix != null)
			{
				this.m_InitDefaultSoldierSkinItemHeroConfigDataSoldierInfo_hotfix.call(new object[]
				{
					this,
					hero,
					soldierInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.IsHeroSkin = false;
			this.IsDefaultSkin = true;
			this.SoldierSkinInfo = null;
			this.SoldierInfo = soldierInfo;
			this.m_nameText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DefaultName);
			float scale = (float)this.SoldierInfo.UI_ModelScale * 0.013f;
			Vector2 offset = new Vector2((float)this.SoldierInfo.UI_ModelOffsetX, (float)this.SoldierInfo.UI_ModelOffsetY) * 1.5f;
			HeroDetailUIController.CreateSpineGraphic(ref this.m_soldierInfoGraphic, this.SoldierInfo.Model, this.m_charGameObject, 1, offset, scale, this.SoldierInfo.ReplaceAnims);
			if (hero.GetSoldierSkinId(this.SoldierInfo.ID) != 0)
			{
				this.m_stateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_stateCtrl.SetToUIState("InUse", false, true);
			}
		}

		// Token: 0x060113E1 RID: 70625 RVA: 0x00479984 File Offset: 0x00477B84
		public void ShowSelectImage(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectImageBoolean_hotfix != null)
			{
				this.m_ShowSelectImageBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectImage.SetActive(isShow);
		}

		// Token: 0x060113E2 RID: 70626 RVA: 0x00479A00 File Offset: 0x00477C00
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
			if (this.EventOnItemClick != null)
			{
				this.EventOnItemClick(this);
			}
		}

		// Token: 0x060113E3 RID: 70627 RVA: 0x00479A78 File Offset: 0x00477C78
		public void SetLimitTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLimitTime_hotfix != null)
			{
				this.m_SetLimitTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsDefaultSkin)
			{
				this.m_timeGo.SetActive(false);
				return;
			}
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo;
			if (this.IsHeroSkin)
			{
				if (this.HeroSkinInfo == null)
				{
					return;
				}
				if (this.m_playerContext.HasOwn(GoodsType.GoodsType_HeroSkin, this.HeroSkinInfo.ID))
				{
					this.m_timeGo.SetActive(false);
					return;
				}
				configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(this.HeroSkinInfo.FixedStoreItemId);
				if (configDataFixedStoreItemInfo == null)
				{
					return;
				}
			}
			else
			{
				if (this.SoldierSkinInfo == null)
				{
					return;
				}
				if (this.m_playerContext.HasOwn(GoodsType.GoodsType_SoldierSkin, this.SoldierSkinInfo.ID))
				{
					this.m_timeGo.SetActive(false);
					return;
				}
				configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(this.SoldierSkinInfo.FixedStoreItemId);
				if (configDataFixedStoreItemInfo == null)
				{
					return;
				}
			}
			if (configDataFixedStoreItemInfo == null)
			{
				return;
			}
			DateTime dateTime = DateTime.Parse(configDataFixedStoreItemInfo.ShowEndTime);
			if (dateTime == DateTime.Parse(DateTime.MaxValue.ToString()))
			{
				this.m_timeGo.SetActive(false);
				return;
			}
			this.m_timeGo.SetActive(true);
			TimeSpan timeSpan = dateTime - this.m_playerContext.GetServerTime();
			if (timeSpan.Days >= 1)
			{
				string arg = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Day);
				this.m_timeValueText.text = timeSpan.Days + arg;
			}
			else
			{
				this.m_timeValueText.text = UIUtility.TimeSpanToString2(timeSpan);
				if (dateTime < this.m_playerContext.GetServerTime())
				{
					this.m_timeGo.SetActive(false);
				}
			}
			DateTime t = DateTime.Parse(configDataFixedStoreItemInfo.ShowStartTime);
			DateTime serverTime = this.m_playerContext.GetServerTime();
			this.m_timeGo.SetActive(dateTime > serverTime && t < serverTime);
		}

		// Token: 0x140003B6 RID: 950
		// (add) Token: 0x060113E4 RID: 70628 RVA: 0x00479CC0 File Offset: 0x00477EC0
		// (remove) Token: 0x060113E5 RID: 70629 RVA: 0x00479D5C File Offset: 0x00477F5C
		public event Action<HeroOrSoliderSkinUIController> EventOnItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroOrSoliderSkinUIController> action = this.EventOnItemClick;
				Action<HeroOrSoliderSkinUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroOrSoliderSkinUIController>>(ref this.EventOnItemClick, (Action<HeroOrSoliderSkinUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroOrSoliderSkinUIController> action = this.EventOnItemClick;
				Action<HeroOrSoliderSkinUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroOrSoliderSkinUIController>>(ref this.EventOnItemClick, (Action<HeroOrSoliderSkinUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x060113E7 RID: 70631 RVA: 0x00479E70 File Offset: 0x00478070
		// (set) Token: 0x060113E6 RID: 70630 RVA: 0x00479DF8 File Offset: 0x00477FF8
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

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x060113E9 RID: 70633 RVA: 0x00479F5C File Offset: 0x0047815C
		// (set) Token: 0x060113E8 RID: 70632 RVA: 0x00479EE4 File Offset: 0x004780E4
		public ConfigDataHeroSkinInfo HeroSkinInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroSkinInfo_hotfix != null)
				{
					return (ConfigDataHeroSkinInfo)this.m_get_HeroSkinInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HeroSkinInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HeroSkinInfoConfigDataHeroSkinInfo_hotfix != null)
				{
					this.m_set_HeroSkinInfoConfigDataHeroSkinInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HeroSkinInfo>k__BackingField = value;
			}
		}

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x060113EB RID: 70635 RVA: 0x0047A048 File Offset: 0x00478248
		// (set) Token: 0x060113EA RID: 70634 RVA: 0x00479FD0 File Offset: 0x004781D0
		public ConfigDataModelSkinResourceInfo ModelSkinResourceInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ModelSkinResourceInfo_hotfix != null)
				{
					return (ConfigDataModelSkinResourceInfo)this.m_get_ModelSkinResourceInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<ModelSkinResourceInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ModelSkinResourceInfoConfigDataModelSkinResourceInfo_hotfix != null)
				{
					this.m_set_ModelSkinResourceInfoConfigDataModelSkinResourceInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<ModelSkinResourceInfo>k__BackingField = value;
			}
		}

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x060113EC RID: 70636 RVA: 0x0047A0BC File Offset: 0x004782BC
		// (set) Token: 0x060113ED RID: 70637 RVA: 0x0047A130 File Offset: 0x00478330
		public ConfigDataSoldierInfo SoldierInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierInfo_hotfix != null)
				{
					return (ConfigDataSoldierInfo)this.m_get_SoldierInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<SoldierInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_SoldierInfoConfigDataSoldierInfo_hotfix != null)
				{
					this.m_set_SoldierInfoConfigDataSoldierInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<SoldierInfo>k__BackingField = value;
			}
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x060113EE RID: 70638 RVA: 0x0047A1A8 File Offset: 0x004783A8
		// (set) Token: 0x060113EF RID: 70639 RVA: 0x0047A21C File Offset: 0x0047841C
		public ConfigDataSoldierSkinInfo SoldierSkinInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SoldierSkinInfo_hotfix != null)
				{
					return (ConfigDataSoldierSkinInfo)this.m_get_SoldierSkinInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<SoldierSkinInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_SoldierSkinInfoConfigDataSoldierSkinInfo_hotfix != null)
				{
					this.m_set_SoldierSkinInfoConfigDataSoldierSkinInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<SoldierSkinInfo>k__BackingField = value;
			}
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x060113F1 RID: 70641 RVA: 0x0047A30C File Offset: 0x0047850C
		// (set) Token: 0x060113F0 RID: 70640 RVA: 0x0047A294 File Offset: 0x00478494
		public bool IsHeroSkin
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsHeroSkin_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsHeroSkin_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsHeroSkin>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IsHeroSkinBoolean_hotfix != null)
				{
					this.m_set_IsHeroSkinBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsHeroSkin>k__BackingField = value;
			}
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x060113F3 RID: 70643 RVA: 0x0047A3F8 File Offset: 0x004785F8
		// (set) Token: 0x060113F2 RID: 70642 RVA: 0x0047A380 File Offset: 0x00478580
		public bool IsDefaultSkin
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsDefaultSkin_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsDefaultSkin_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsDefaultSkin>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IsDefaultSkinBoolean_hotfix != null)
				{
					this.m_set_IsDefaultSkinBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsDefaultSkin>k__BackingField = value;
			}
		}

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x060113F4 RID: 70644 RVA: 0x0047A46C File Offset: 0x0047866C
		// (set) Token: 0x060113F5 RID: 70645 RVA: 0x0047A48C File Offset: 0x0047868C
		[DoNotToLua]
		public new HeroOrSoliderSkinUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroOrSoliderSkinUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060113F6 RID: 70646 RVA: 0x0047A498 File Offset: 0x00478698
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060113F7 RID: 70647 RVA: 0x0047A4A4 File Offset: 0x004786A4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060113F8 RID: 70648 RVA: 0x0047A4AC File Offset: 0x004786AC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060113F9 RID: 70649 RVA: 0x0047A4B4 File Offset: 0x004786B4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060113FA RID: 70650 RVA: 0x0047A4C8 File Offset: 0x004786C8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060113FB RID: 70651 RVA: 0x0047A4D0 File Offset: 0x004786D0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060113FC RID: 70652 RVA: 0x0047A4DC File Offset: 0x004786DC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060113FD RID: 70653 RVA: 0x0047A4E8 File Offset: 0x004786E8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060113FE RID: 70654 RVA: 0x0047A4F4 File Offset: 0x004786F4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060113FF RID: 70655 RVA: 0x0047A500 File Offset: 0x00478700
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011400 RID: 70656 RVA: 0x0047A50C File Offset: 0x0047870C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011401 RID: 70657 RVA: 0x0047A518 File Offset: 0x00478718
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011402 RID: 70658 RVA: 0x0047A524 File Offset: 0x00478724
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06011403 RID: 70659 RVA: 0x0047A530 File Offset: 0x00478730
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011404 RID: 70660 RVA: 0x0047A53C File Offset: 0x0047873C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011405 RID: 70661 RVA: 0x0047A544 File Offset: 0x00478744
		private void __callDele_EventOnItemClick(HeroOrSoliderSkinUIController obj)
		{
			Action<HeroOrSoliderSkinUIController> eventOnItemClick = this.EventOnItemClick;
			if (eventOnItemClick != null)
			{
				eventOnItemClick(obj);
			}
		}

		// Token: 0x06011406 RID: 70662 RVA: 0x0047A568 File Offset: 0x00478768
		private void __clearDele_EventOnItemClick(HeroOrSoliderSkinUIController obj)
		{
			this.EventOnItemClick = null;
		}

		// Token: 0x06011407 RID: 70663 RVA: 0x0047A574 File Offset: 0x00478774
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
					this.m_InitHeroSkinItemHeroConfigDataJobConnectionInfoInt32_hotfix = (luaObj.RawGet("InitHeroSkinItem") as LuaFunction);
					this.m_InitDefaultHeroSkinItemHero_hotfix = (luaObj.RawGet("InitDefaultHeroSkinItem") as LuaFunction);
					this.m_InitSoldierSkinItemSoldier2SkinResourceConfigDataSoldierSkinInfoHero_hotfix = (luaObj.RawGet("InitSoldierSkinItem") as LuaFunction);
					this.m_InitDefaultSoldierSkinItemHeroConfigDataSoldierInfo_hotfix = (luaObj.RawGet("InitDefaultSoldierSkinItem") as LuaFunction);
					this.m_ShowSelectImageBoolean_hotfix = (luaObj.RawGet("ShowSelectImage") as LuaFunction);
					this.m_OnHeroJobCardItemClick_hotfix = (luaObj.RawGet("OnHeroJobCardItemClick") as LuaFunction);
					this.m_SetLimitTime_hotfix = (luaObj.RawGet("SetLimitTime") as LuaFunction);
					this.m_add_EventOnItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnItemClick") as LuaFunction);
					this.m_remove_EventOnItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnItemClick") as LuaFunction);
					this.m_set_JobConnectionInfoConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("set_JobConnectionInfo") as LuaFunction);
					this.m_get_JobConnectionInfo_hotfix = (luaObj.RawGet("get_JobConnectionInfo") as LuaFunction);
					this.m_set_HeroSkinInfoConfigDataHeroSkinInfo_hotfix = (luaObj.RawGet("set_HeroSkinInfo") as LuaFunction);
					this.m_get_HeroSkinInfo_hotfix = (luaObj.RawGet("get_HeroSkinInfo") as LuaFunction);
					this.m_set_ModelSkinResourceInfoConfigDataModelSkinResourceInfo_hotfix = (luaObj.RawGet("set_ModelSkinResourceInfo") as LuaFunction);
					this.m_get_ModelSkinResourceInfo_hotfix = (luaObj.RawGet("get_ModelSkinResourceInfo") as LuaFunction);
					this.m_get_SoldierInfo_hotfix = (luaObj.RawGet("get_SoldierInfo") as LuaFunction);
					this.m_set_SoldierInfoConfigDataSoldierInfo_hotfix = (luaObj.RawGet("set_SoldierInfo") as LuaFunction);
					this.m_get_SoldierSkinInfo_hotfix = (luaObj.RawGet("get_SoldierSkinInfo") as LuaFunction);
					this.m_set_SoldierSkinInfoConfigDataSoldierSkinInfo_hotfix = (luaObj.RawGet("set_SoldierSkinInfo") as LuaFunction);
					this.m_set_IsHeroSkinBoolean_hotfix = (luaObj.RawGet("set_IsHeroSkin") as LuaFunction);
					this.m_get_IsHeroSkin_hotfix = (luaObj.RawGet("get_IsHeroSkin") as LuaFunction);
					this.m_set_IsDefaultSkinBoolean_hotfix = (luaObj.RawGet("set_IsDefaultSkin") as LuaFunction);
					this.m_get_IsDefaultSkin_hotfix = (luaObj.RawGet("get_IsDefaultSkin") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011408 RID: 70664 RVA: 0x0047A880 File Offset: 0x00478A80
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroOrSoliderSkinUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009E32 RID: 40498
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04009E33 RID: 40499
		[AutoBind("./Select", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectImage;

		// Token: 0x04009E34 RID: 40500
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04009E35 RID: 40501
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_charGameObject;

		// Token: 0x04009E36 RID: 40502
		[AutoBind("./LimitTime", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_timeGo;

		// Token: 0x04009E37 RID: 40503
		[AutoBind("./LimitTime/TimeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeValueText;

		// Token: 0x04009E38 RID: 40504
		private UISpineGraphic m_playerHeroGraphic;

		// Token: 0x04009E39 RID: 40505
		private UISpineGraphic m_soldierInfoGraphic;

		// Token: 0x04009E41 RID: 40513
		private Hero m_hero;

		// Token: 0x04009E42 RID: 40514
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009E43 RID: 40515
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009E44 RID: 40516
		[DoNotToLua]
		private HeroOrSoliderSkinUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009E45 RID: 40517
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009E46 RID: 40518
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009E47 RID: 40519
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009E48 RID: 40520
		private LuaFunction m_InitHeroSkinItemHeroConfigDataJobConnectionInfoInt32_hotfix;

		// Token: 0x04009E49 RID: 40521
		private LuaFunction m_InitDefaultHeroSkinItemHero_hotfix;

		// Token: 0x04009E4A RID: 40522
		private LuaFunction m_InitSoldierSkinItemSoldier2SkinResourceConfigDataSoldierSkinInfoHero_hotfix;

		// Token: 0x04009E4B RID: 40523
		private LuaFunction m_InitDefaultSoldierSkinItemHeroConfigDataSoldierInfo_hotfix;

		// Token: 0x04009E4C RID: 40524
		private LuaFunction m_ShowSelectImageBoolean_hotfix;

		// Token: 0x04009E4D RID: 40525
		private LuaFunction m_OnHeroJobCardItemClick_hotfix;

		// Token: 0x04009E4E RID: 40526
		private LuaFunction m_SetLimitTime_hotfix;

		// Token: 0x04009E4F RID: 40527
		private LuaFunction m_add_EventOnItemClickAction;

		// Token: 0x04009E50 RID: 40528
		private LuaFunction m_remove_EventOnItemClickAction;

		// Token: 0x04009E51 RID: 40529
		private LuaFunction m_set_JobConnectionInfoConfigDataJobConnectionInfo_hotfix;

		// Token: 0x04009E52 RID: 40530
		private LuaFunction m_get_JobConnectionInfo_hotfix;

		// Token: 0x04009E53 RID: 40531
		private LuaFunction m_set_HeroSkinInfoConfigDataHeroSkinInfo_hotfix;

		// Token: 0x04009E54 RID: 40532
		private LuaFunction m_get_HeroSkinInfo_hotfix;

		// Token: 0x04009E55 RID: 40533
		private LuaFunction m_set_ModelSkinResourceInfoConfigDataModelSkinResourceInfo_hotfix;

		// Token: 0x04009E56 RID: 40534
		private LuaFunction m_get_ModelSkinResourceInfo_hotfix;

		// Token: 0x04009E57 RID: 40535
		private LuaFunction m_get_SoldierInfo_hotfix;

		// Token: 0x04009E58 RID: 40536
		private LuaFunction m_set_SoldierInfoConfigDataSoldierInfo_hotfix;

		// Token: 0x04009E59 RID: 40537
		private LuaFunction m_get_SoldierSkinInfo_hotfix;

		// Token: 0x04009E5A RID: 40538
		private LuaFunction m_set_SoldierSkinInfoConfigDataSoldierSkinInfo_hotfix;

		// Token: 0x04009E5B RID: 40539
		private LuaFunction m_set_IsHeroSkinBoolean_hotfix;

		// Token: 0x04009E5C RID: 40540
		private LuaFunction m_get_IsHeroSkin_hotfix;

		// Token: 0x04009E5D RID: 40541
		private LuaFunction m_set_IsDefaultSkinBoolean_hotfix;

		// Token: 0x04009E5E RID: 40542
		private LuaFunction m_get_IsDefaultSkin_hotfix;

		// Token: 0x02000E0D RID: 3597
		public new class LuaExportHelper
		{
			// Token: 0x06011409 RID: 70665 RVA: 0x0047A8E8 File Offset: 0x00478AE8
			public LuaExportHelper(HeroOrSoliderSkinUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601140A RID: 70666 RVA: 0x0047A8F8 File Offset: 0x00478AF8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601140B RID: 70667 RVA: 0x0047A908 File Offset: 0x00478B08
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601140C RID: 70668 RVA: 0x0047A918 File Offset: 0x00478B18
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601140D RID: 70669 RVA: 0x0047A928 File Offset: 0x00478B28
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601140E RID: 70670 RVA: 0x0047A940 File Offset: 0x00478B40
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601140F RID: 70671 RVA: 0x0047A950 File Offset: 0x00478B50
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011410 RID: 70672 RVA: 0x0047A960 File Offset: 0x00478B60
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011411 RID: 70673 RVA: 0x0047A970 File Offset: 0x00478B70
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011412 RID: 70674 RVA: 0x0047A980 File Offset: 0x00478B80
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011413 RID: 70675 RVA: 0x0047A990 File Offset: 0x00478B90
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011414 RID: 70676 RVA: 0x0047A9A0 File Offset: 0x00478BA0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011415 RID: 70677 RVA: 0x0047A9B0 File Offset: 0x00478BB0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011416 RID: 70678 RVA: 0x0047A9C0 File Offset: 0x00478BC0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011417 RID: 70679 RVA: 0x0047A9D0 File Offset: 0x00478BD0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011418 RID: 70680 RVA: 0x0047A9E0 File Offset: 0x00478BE0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06011419 RID: 70681 RVA: 0x0047A9F0 File Offset: 0x00478BF0
			public void __callDele_EventOnItemClick(HeroOrSoliderSkinUIController obj)
			{
				this.m_owner.__callDele_EventOnItemClick(obj);
			}

			// Token: 0x0601141A RID: 70682 RVA: 0x0047AA00 File Offset: 0x00478C00
			public void __clearDele_EventOnItemClick(HeroOrSoliderSkinUIController obj)
			{
				this.m_owner.__clearDele_EventOnItemClick(obj);
			}

			// Token: 0x1700352A RID: 13610
			// (get) Token: 0x0601141B RID: 70683 RVA: 0x0047AA10 File Offset: 0x00478C10
			// (set) Token: 0x0601141C RID: 70684 RVA: 0x0047AA20 File Offset: 0x00478C20
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x1700352B RID: 13611
			// (get) Token: 0x0601141D RID: 70685 RVA: 0x0047AA30 File Offset: 0x00478C30
			// (set) Token: 0x0601141E RID: 70686 RVA: 0x0047AA40 File Offset: 0x00478C40
			public GameObject m_selectImage
			{
				get
				{
					return this.m_owner.m_selectImage;
				}
				set
				{
					this.m_owner.m_selectImage = value;
				}
			}

			// Token: 0x1700352C RID: 13612
			// (get) Token: 0x0601141F RID: 70687 RVA: 0x0047AA50 File Offset: 0x00478C50
			// (set) Token: 0x06011420 RID: 70688 RVA: 0x0047AA60 File Offset: 0x00478C60
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

			// Token: 0x1700352D RID: 13613
			// (get) Token: 0x06011421 RID: 70689 RVA: 0x0047AA70 File Offset: 0x00478C70
			// (set) Token: 0x06011422 RID: 70690 RVA: 0x0047AA80 File Offset: 0x00478C80
			public GameObject m_charGameObject
			{
				get
				{
					return this.m_owner.m_charGameObject;
				}
				set
				{
					this.m_owner.m_charGameObject = value;
				}
			}

			// Token: 0x1700352E RID: 13614
			// (get) Token: 0x06011423 RID: 70691 RVA: 0x0047AA90 File Offset: 0x00478C90
			// (set) Token: 0x06011424 RID: 70692 RVA: 0x0047AAA0 File Offset: 0x00478CA0
			public GameObject m_timeGo
			{
				get
				{
					return this.m_owner.m_timeGo;
				}
				set
				{
					this.m_owner.m_timeGo = value;
				}
			}

			// Token: 0x1700352F RID: 13615
			// (get) Token: 0x06011425 RID: 70693 RVA: 0x0047AAB0 File Offset: 0x00478CB0
			// (set) Token: 0x06011426 RID: 70694 RVA: 0x0047AAC0 File Offset: 0x00478CC0
			public Text m_timeValueText
			{
				get
				{
					return this.m_owner.m_timeValueText;
				}
				set
				{
					this.m_owner.m_timeValueText = value;
				}
			}

			// Token: 0x17003530 RID: 13616
			// (get) Token: 0x06011427 RID: 70695 RVA: 0x0047AAD0 File Offset: 0x00478CD0
			// (set) Token: 0x06011428 RID: 70696 RVA: 0x0047AAE0 File Offset: 0x00478CE0
			public UISpineGraphic m_playerHeroGraphic
			{
				get
				{
					return this.m_owner.m_playerHeroGraphic;
				}
				set
				{
					this.m_owner.m_playerHeroGraphic = value;
				}
			}

			// Token: 0x17003531 RID: 13617
			// (get) Token: 0x06011429 RID: 70697 RVA: 0x0047AAF0 File Offset: 0x00478CF0
			// (set) Token: 0x0601142A RID: 70698 RVA: 0x0047AB00 File Offset: 0x00478D00
			public UISpineGraphic m_soldierInfoGraphic
			{
				get
				{
					return this.m_owner.m_soldierInfoGraphic;
				}
				set
				{
					this.m_owner.m_soldierInfoGraphic = value;
				}
			}

			// Token: 0x17003532 RID: 13618
			// (get) Token: 0x0601142B RID: 70699 RVA: 0x0047AB10 File Offset: 0x00478D10
			// (set) Token: 0x0601142C RID: 70700 RVA: 0x0047AB20 File Offset: 0x00478D20
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

			// Token: 0x17003533 RID: 13619
			// (get) Token: 0x0601142D RID: 70701 RVA: 0x0047AB30 File Offset: 0x00478D30
			// (set) Token: 0x0601142E RID: 70702 RVA: 0x0047AB40 File Offset: 0x00478D40
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17003534 RID: 13620
			// (get) Token: 0x0601142F RID: 70703 RVA: 0x0047AB50 File Offset: 0x00478D50
			// (set) Token: 0x06011430 RID: 70704 RVA: 0x0047AB60 File Offset: 0x00478D60
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

			// Token: 0x17003535 RID: 13621
			// (set) Token: 0x06011431 RID: 70705 RVA: 0x0047AB70 File Offset: 0x00478D70
			public ConfigDataJobConnectionInfo JobConnectionInfo
			{
				set
				{
					this.m_owner.JobConnectionInfo = value;
				}
			}

			// Token: 0x17003536 RID: 13622
			// (set) Token: 0x06011432 RID: 70706 RVA: 0x0047AB80 File Offset: 0x00478D80
			public ConfigDataHeroSkinInfo HeroSkinInfo
			{
				set
				{
					this.m_owner.HeroSkinInfo = value;
				}
			}

			// Token: 0x17003537 RID: 13623
			// (set) Token: 0x06011433 RID: 70707 RVA: 0x0047AB90 File Offset: 0x00478D90
			public ConfigDataModelSkinResourceInfo ModelSkinResourceInfo
			{
				set
				{
					this.m_owner.ModelSkinResourceInfo = value;
				}
			}

			// Token: 0x17003538 RID: 13624
			// (set) Token: 0x06011434 RID: 70708 RVA: 0x0047ABA0 File Offset: 0x00478DA0
			public ConfigDataSoldierInfo SoldierInfo
			{
				set
				{
					this.m_owner.SoldierInfo = value;
				}
			}

			// Token: 0x17003539 RID: 13625
			// (set) Token: 0x06011435 RID: 70709 RVA: 0x0047ABB0 File Offset: 0x00478DB0
			public ConfigDataSoldierSkinInfo SoldierSkinInfo
			{
				set
				{
					this.m_owner.SoldierSkinInfo = value;
				}
			}

			// Token: 0x1700353A RID: 13626
			// (set) Token: 0x06011436 RID: 70710 RVA: 0x0047ABC0 File Offset: 0x00478DC0
			public bool IsHeroSkin
			{
				set
				{
					this.m_owner.IsHeroSkin = value;
				}
			}

			// Token: 0x1700353B RID: 13627
			// (set) Token: 0x06011437 RID: 70711 RVA: 0x0047ABD0 File Offset: 0x00478DD0
			public bool IsDefaultSkin
			{
				set
				{
					this.m_owner.IsDefaultSkin = value;
				}
			}

			// Token: 0x06011438 RID: 70712 RVA: 0x0047ABE0 File Offset: 0x00478DE0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011439 RID: 70713 RVA: 0x0047ABF0 File Offset: 0x00478DF0
			public void OnHeroJobCardItemClick()
			{
				this.m_owner.OnHeroJobCardItemClick();
			}

			// Token: 0x04009E5F RID: 40543
			private HeroOrSoliderSkinUIController m_owner;
		}
	}
}
