using System;
using System.Collections.Generic;
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
	// Token: 0x02000DAB RID: 3499
	[HotFix]
	public class HeroDetailSelectSkillUIController : UIControllerBase
	{
		// Token: 0x06010909 RID: 67849 RVA: 0x0044E368 File Offset: 0x0044C568
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
			this.m_infoSkillDescLoadButton.onClick.AddListener(new UnityAction(this.OnLoadOrUnLoadButtonClick));
			this.m_infoSkillDescUnLoadButton.onClick.AddListener(new UnityAction(this.OnLoadOrUnLoadButtonClick));
			this.m_infoCloseSelectSkillButton.onClick.AddListener(new UnityAction(this.OnSaveSelectSkillsButtonClick));
			this.m_infoSaveSelectSkillsButton.onClick.AddListener(new UnityAction(this.OnSaveSelectSkillsButtonClick));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
		}

		// Token: 0x0601090A RID: 67850 RVA: 0x0044E474 File Offset: 0x0044C674
		public void UpdateViewInSelectSkillState(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInSelectSkillStateHero_hotfix != null)
			{
				this.m_UpdateViewInSelectSkillStateHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.ShowSelectSkillContent();
		}

		// Token: 0x0601090B RID: 67851 RVA: 0x0044E4F4 File Offset: 0x0044C6F4
		private void ShowSelectSkillContent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectSkillContent_hotfix != null)
			{
				this.m_ShowSelectSkillContent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_infoAllSkillsContent);
			GameObjectUtility.DestroyChildren(this.m_infoSelectSkillsContent);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("skillItem");
			List<int> skillIds = this.m_hero.SkillIds;
			List<int> selectedSkills = this.m_hero.SelectedSkills;
			this.m_curSelectSkillIds = new List<int>();
			this.m_curSelectSkillIds.AddRange(selectedSkills);
			foreach (int key in skillIds)
			{
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(key);
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				HeroSkillItemUIController component = gameObject.GetComponent<HeroSkillItemUIController>();
				component.EventOnShowDesc += this.OnSkillItemClick;
				component.InitSkillItem(configDataSkillInfo);
				bool limitTagObjActive = this.m_playerContext.IsSkillLimitToHeroJob(this.m_hero.ActiveHeroJobRelatedId, configDataSkillInfo.ID);
				component.SetLimitTagObjActive(limitTagObjActive);
				gameObject.transform.SetParent(this.m_infoAllSkillsContent.transform, false);
				if (selectedSkills.Contains(configDataSkillInfo.ID))
				{
					component.SetSelectPanelActive(true);
				}
			}
			foreach (int key2 in skillIds)
			{
				ConfigDataSkillInfo configDataSkillInfo2 = this.m_configDataLoader.GetConfigDataSkillInfo(key2);
				if (selectedSkills.Contains(configDataSkillInfo2.ID))
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject2);
					HeroSkillItemUIController component2 = gameObject2.GetComponent<HeroSkillItemUIController>();
					component2.EventOnShowDesc += this.OnSkillItemClick;
					component2.InitSkillItem(configDataSkillInfo2);
					gameObject2.transform.SetParent(this.m_infoSelectSkillsContent.transform, false);
				}
			}
			UIUtility.SetGameObjectChildrenActiveCount(this.m_infoSelectSkillsCost, this.CalcTotalCostFromSkillList(selectedSkills));
			CommonUIStateController component3 = this.m_infoSelectSkillPanel.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateOpen(component3, "Show", null, false, true);
		}

		// Token: 0x0601090C RID: 67852 RVA: 0x0044E768 File Offset: 0x0044C968
		private void OnSkillItemClick(HeroSkillItemUIController skillCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkillItemClickHeroSkillItemUIController_hotfix != null)
			{
				this.m_OnSkillItemClickHeroSkillItemUIController_hotfix.call(new object[]
				{
					this,
					skillCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SkillDescUIController component = this.m_infoSkillDescGo.GetComponent<SkillDescUIController>();
			if (component == null)
			{
				PrefabControllerCreater.CreateAllControllers(this.m_infoSkillDescGo);
				component = this.m_infoSkillDescGo.GetComponent<SkillDescUIController>();
				component.EventOnClose += this.CloseSkillDesc;
			}
			component.InitSkillDesc(skillCtrl.m_skillInfo);
			if (this.m_curSelectedSkillCtrl != null)
			{
				this.m_curSelectedSkillCtrl.SetChoosenImageActive(false);
			}
			skillCtrl.SetChoosenImageActive(true);
			this.m_curSelectedSkillCtrl = skillCtrl;
			if (this.m_infoSkillDescGo.activeSelf)
			{
				bool flag = this.m_curSelectSkillIds.Contains(skillCtrl.m_skillInfo.ID);
				this.m_infoSkillDescLoadButton.gameObject.SetActive(!flag);
				this.m_infoSkillDescUnLoadButton.gameObject.SetActive(flag);
			}
		}

		// Token: 0x0601090D RID: 67853 RVA: 0x0044E8A0 File Offset: 0x0044CAA0
		private void OnLoadOrUnLoadButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoadOrUnLoadButtonClick_hotfix != null)
			{
				this.m_OnLoadOrUnLoadButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroSkillItemUIController curSelectedSkillCtrl = this.m_curSelectedSkillCtrl;
			ConfigDataSkillInfo skillInfo = curSelectedSkillCtrl.m_skillInfo;
			Transform parent = curSelectedSkillCtrl.gameObject.transform.parent;
			if (parent.gameObject == this.m_infoAllSkillsContent)
			{
				if (!this.m_curSelectSkillIds.Contains(skillInfo.ID))
				{
					if (this.m_curSelectSkillIds.Count == 3)
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_SkillEquipNumMax, 2f, null, true);
						return;
					}
					this.m_curSelectSkillIds.Add(skillInfo.ID);
					int num = this.CalcTotalCostFromSkillList(this.m_curSelectSkillIds);
					int heroSkillPointMax = this.m_playerContext.GetHeroSkillPointMax(this.m_hero.Level);
					if (num > heroSkillPointMax)
					{
						CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_SkillPointNotEnough, 2f, null, true);
						this.m_curSelectSkillIds.Remove(skillInfo.ID);
						return;
					}
					curSelectedSkillCtrl.SetSelectPanelActive(true);
					GameObject assetInContainer = base.GetAssetInContainer<GameObject>("skillItem");
					GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
					PrefabControllerCreater.CreateAllControllers(gameObject);
					HeroSkillItemUIController component = gameObject.GetComponent<HeroSkillItemUIController>();
					component.EventOnShowDesc += this.OnSkillItemClick;
					component.InitSkillItem(skillInfo);
					gameObject.transform.SetParent(this.m_infoSelectSkillsContent.transform, false);
				}
				else
				{
					curSelectedSkillCtrl.SetSelectPanelActive(false);
					for (int i = 0; i < this.m_infoSelectSkillsContent.transform.childCount; i++)
					{
						HeroSkillItemUIController component2 = this.m_infoSelectSkillsContent.transform.GetChild(i).GetComponent<HeroSkillItemUIController>();
						if (component2.m_skillInfo == skillInfo)
						{
							this.m_curSelectSkillIds.Remove(component2.m_skillInfo.ID);
							UnityEngine.Object.Destroy(this.m_infoSelectSkillsContent.transform.GetChild(i).gameObject);
						}
					}
				}
			}
			else if (parent.gameObject == this.m_infoSelectSkillsContent)
			{
				for (int j = 0; j < this.m_infoAllSkillsContent.transform.childCount; j++)
				{
					HeroSkillItemUIController component3 = this.m_infoAllSkillsContent.transform.GetChild(j).GetComponent<HeroSkillItemUIController>();
					if (component3.m_skillInfo == skillInfo)
					{
						component3.SetSelectPanelActive(false);
						this.m_curSelectSkillIds.Remove(component3.m_skillInfo.ID);
					}
				}
				UnityEngine.Object.Destroy(curSelectedSkillCtrl.gameObject);
			}
			this.m_infoSkillDescUnLoadButton.gameObject.SetActive(this.m_curSelectSkillIds.Contains(skillInfo.ID));
			UIUtility.SetGameObjectChildrenActiveCount(this.m_infoSelectSkillsCost, this.CalcTotalCostFromSkillList(this.m_curSelectSkillIds));
			this.CloseSkillDesc();
		}

		// Token: 0x0601090E RID: 67854 RVA: 0x0044EB98 File Offset: 0x0044CD98
		private void OnSaveSelectSkillsButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSaveSelectSkillsButtonClick_hotfix != null)
			{
				this.m_OnSaveSelectSkillsButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool isSelectSkillsChanged = false;
			if (this.m_curSelectSkillIds.Count == this.m_hero.SelectedSkills.Count)
			{
				for (int i = 0; i < this.m_curSelectSkillIds.Count; i++)
				{
					if (!this.m_hero.SelectedSkills.Contains(this.m_curSelectSkillIds[i]))
					{
						isSelectSkillsChanged = true;
						break;
					}
				}
			}
			else
			{
				isSelectSkillsChanged = true;
			}
			this.CloseSelectSkillPanel(delegate
			{
				if (this.EventOnHeroSkillsSelect != null)
				{
					this.EventOnHeroSkillsSelect(this.m_hero.HeroId, this.m_curSelectSkillIds, isSelectSkillsChanged);
				}
			});
		}

		// Token: 0x0601090F RID: 67855 RVA: 0x0044EC94 File Offset: 0x0044CE94
		private void CloseSkillDesc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseSkillDesc_hotfix != null)
			{
				this.m_CloseSkillDesc_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = this.m_infoSkillDescGo.GetComponent<CommonUIStateController>();
			component.SetActionForUIStateFinshed("Close", delegate
			{
				this.m_infoSkillDescGo.SetActive(false);
				this.m_infoSkillDescLoadButton.gameObject.SetActive(false);
				this.m_infoSkillDescUnLoadButton.gameObject.SetActive(false);
			});
			component.SetToUIState("Close", false, true);
		}

		// Token: 0x06010910 RID: 67856 RVA: 0x0044ED28 File Offset: 0x0044CF28
		private void CloseSelectSkillPanel(Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CloseSelectSkillPanelAction_hotfix != null)
			{
				this.m_CloseSelectSkillPanelAction_hotfix.call(new object[]
				{
					this,
					onEnd2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action onEnd = onEnd2;
			HeroDetailSelectSkillUIController $this = this;
			CommonUIStateController component = this.m_infoSelectSkillPanel.GetComponent<CommonUIStateController>();
			UIUtility.SetUIStateClose(component, "Close", delegate
			{
				onEnd();
				$this.CloseSkillDesc();
			}, false, true);
		}

		// Token: 0x06010911 RID: 67857 RVA: 0x0044EDD4 File Offset: 0x0044CFD4
		private int CalcTotalCostFromSkillList(List<int> skillIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcTotalCostFromSkillListList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CalcTotalCostFromSkillListList`1_hotfix.call(new object[]
				{
					this,
					skillIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (int key in skillIds)
			{
				ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(key);
				num += configDataSkillInfo.SkillCost;
			}
			return num;
		}

		// Token: 0x14000381 RID: 897
		// (add) Token: 0x06010912 RID: 67858 RVA: 0x0044EEAC File Offset: 0x0044D0AC
		// (remove) Token: 0x06010913 RID: 67859 RVA: 0x0044EF48 File Offset: 0x0044D148
		public event Action<int, List<int>, bool> EventOnHeroSkillsSelect
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroSkillsSelectAction`3_hotfix != null)
				{
					this.m_add_EventOnHeroSkillsSelectAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, List<int>, bool> action = this.EventOnHeroSkillsSelect;
				Action<int, List<int>, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, List<int>, bool>>(ref this.EventOnHeroSkillsSelect, (Action<int, List<int>, bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroSkillsSelectAction`3_hotfix != null)
				{
					this.m_remove_EventOnHeroSkillsSelectAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, List<int>, bool> action = this.EventOnHeroSkillsSelect;
				Action<int, List<int>, bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, List<int>, bool>>(ref this.EventOnHeroSkillsSelect, (Action<int, List<int>, bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x06010914 RID: 67860 RVA: 0x0044EFE4 File Offset: 0x0044D1E4
		// (set) Token: 0x06010915 RID: 67861 RVA: 0x0044F004 File Offset: 0x0044D204
		[DoNotToLua]
		public new HeroDetailSelectSkillUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDetailSelectSkillUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010916 RID: 67862 RVA: 0x0044F010 File Offset: 0x0044D210
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010917 RID: 67863 RVA: 0x0044F01C File Offset: 0x0044D21C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010918 RID: 67864 RVA: 0x0044F024 File Offset: 0x0044D224
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010919 RID: 67865 RVA: 0x0044F02C File Offset: 0x0044D22C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601091A RID: 67866 RVA: 0x0044F040 File Offset: 0x0044D240
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601091B RID: 67867 RVA: 0x0044F048 File Offset: 0x0044D248
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601091C RID: 67868 RVA: 0x0044F054 File Offset: 0x0044D254
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601091D RID: 67869 RVA: 0x0044F060 File Offset: 0x0044D260
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601091E RID: 67870 RVA: 0x0044F06C File Offset: 0x0044D26C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601091F RID: 67871 RVA: 0x0044F078 File Offset: 0x0044D278
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010920 RID: 67872 RVA: 0x0044F084 File Offset: 0x0044D284
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010921 RID: 67873 RVA: 0x0044F090 File Offset: 0x0044D290
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010922 RID: 67874 RVA: 0x0044F09C File Offset: 0x0044D29C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010923 RID: 67875 RVA: 0x0044F0A8 File Offset: 0x0044D2A8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010924 RID: 67876 RVA: 0x0044F0B4 File Offset: 0x0044D2B4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010925 RID: 67877 RVA: 0x0044F0BC File Offset: 0x0044D2BC
		private void __callDele_EventOnHeroSkillsSelect(int arg1, List<int> arg2, bool arg3)
		{
			Action<int, List<int>, bool> eventOnHeroSkillsSelect = this.EventOnHeroSkillsSelect;
			if (eventOnHeroSkillsSelect != null)
			{
				eventOnHeroSkillsSelect(arg1, arg2, arg3);
			}
		}

		// Token: 0x06010926 RID: 67878 RVA: 0x0044F0E0 File Offset: 0x0044D2E0
		private void __clearDele_EventOnHeroSkillsSelect(int arg1, List<int> arg2, bool arg3)
		{
			this.EventOnHeroSkillsSelect = null;
		}

		// Token: 0x06010928 RID: 67880 RVA: 0x0044F11C File Offset: 0x0044D31C
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
					this.m_UpdateViewInSelectSkillStateHero_hotfix = (luaObj.RawGet("UpdateViewInSelectSkillState") as LuaFunction);
					this.m_ShowSelectSkillContent_hotfix = (luaObj.RawGet("ShowSelectSkillContent") as LuaFunction);
					this.m_OnSkillItemClickHeroSkillItemUIController_hotfix = (luaObj.RawGet("OnSkillItemClick") as LuaFunction);
					this.m_OnLoadOrUnLoadButtonClick_hotfix = (luaObj.RawGet("OnLoadOrUnLoadButtonClick") as LuaFunction);
					this.m_OnSaveSelectSkillsButtonClick_hotfix = (luaObj.RawGet("OnSaveSelectSkillsButtonClick") as LuaFunction);
					this.m_CloseSkillDesc_hotfix = (luaObj.RawGet("CloseSkillDesc") as LuaFunction);
					this.m_CloseSelectSkillPanelAction_hotfix = (luaObj.RawGet("CloseSelectSkillPanel") as LuaFunction);
					this.m_CalcTotalCostFromSkillListList`1_hotfix = (luaObj.RawGet("CalcTotalCostFromSkillList") as LuaFunction);
					this.m_add_EventOnHeroSkillsSelectAction`3_hotfix = (luaObj.RawGet("add_EventOnHeroSkillsSelect") as LuaFunction);
					this.m_remove_EventOnHeroSkillsSelectAction`3_hotfix = (luaObj.RawGet("remove_EventOnHeroSkillsSelect") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010929 RID: 67881 RVA: 0x0044F2E4 File Offset: 0x0044D4E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDetailSelectSkillUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009965 RID: 39269
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoSelectSkillPanel;

		// Token: 0x04009966 RID: 39270
		[AutoBind("./ReturnBgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoCloseSelectSkillButton;

		// Token: 0x04009967 RID: 39271
		[AutoBind("./SelectSkill/Costs", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoSelectSkillsCost;

		// Token: 0x04009968 RID: 39272
		[AutoBind("./SelectSkill/SkillContent", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoSelectSkillsContent;

		// Token: 0x04009969 RID: 39273
		[AutoBind("./SkillItemScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoAllSkillsContent;

		// Token: 0x0400996A RID: 39274
		[AutoBind("./SaveButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoSaveSelectSkillsButton;

		// Token: 0x0400996B RID: 39275
		[AutoBind("./SkillItemDetailPanel/CommonSkillDesc/Lay/FrameImage/LoadButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoSkillDescLoadButton;

		// Token: 0x0400996C RID: 39276
		[AutoBind("./SkillItemDetailPanel/CommonSkillDesc/Lay/FrameImage/UnLoadButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_infoSkillDescUnLoadButton;

		// Token: 0x0400996D RID: 39277
		[AutoBind("./SkillItemDetailPanel/CommonSkillDesc", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoSkillDescGo;

		// Token: 0x0400996F RID: 39279
		private Hero m_hero;

		// Token: 0x04009970 RID: 39280
		private List<int> m_curSelectSkillIds;

		// Token: 0x04009971 RID: 39281
		private HeroSkillItemUIController m_curSelectedSkillCtrl;

		// Token: 0x04009972 RID: 39282
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009973 RID: 39283
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009974 RID: 39284
		[DoNotToLua]
		private HeroDetailSelectSkillUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009975 RID: 39285
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009976 RID: 39286
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009977 RID: 39287
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009978 RID: 39288
		private LuaFunction m_UpdateViewInSelectSkillStateHero_hotfix;

		// Token: 0x04009979 RID: 39289
		private LuaFunction m_ShowSelectSkillContent_hotfix;

		// Token: 0x0400997A RID: 39290
		private LuaFunction m_OnSkillItemClickHeroSkillItemUIController_hotfix;

		// Token: 0x0400997B RID: 39291
		private LuaFunction m_OnLoadOrUnLoadButtonClick_hotfix;

		// Token: 0x0400997C RID: 39292
		private LuaFunction m_OnSaveSelectSkillsButtonClick_hotfix;

		// Token: 0x0400997D RID: 39293
		private LuaFunction m_CloseSkillDesc_hotfix;

		// Token: 0x0400997E RID: 39294
		private LuaFunction m_CloseSelectSkillPanelAction_hotfix;

		// Token: 0x0400997F RID: 39295
		private LuaFunction m_CalcTotalCostFromSkillListList;

		// Token: 0x04009980 RID: 39296
		private LuaFunction m_add_EventOnHeroSkillsSelectAction;

		// Token: 0x04009981 RID: 39297
		private LuaFunction m_remove_EventOnHeroSkillsSelectAction;

		// Token: 0x02000DAC RID: 3500
		public new class LuaExportHelper
		{
			// Token: 0x0601092A RID: 67882 RVA: 0x0044F34C File Offset: 0x0044D54C
			public LuaExportHelper(HeroDetailSelectSkillUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601092B RID: 67883 RVA: 0x0044F35C File Offset: 0x0044D55C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601092C RID: 67884 RVA: 0x0044F36C File Offset: 0x0044D56C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601092D RID: 67885 RVA: 0x0044F37C File Offset: 0x0044D57C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601092E RID: 67886 RVA: 0x0044F38C File Offset: 0x0044D58C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601092F RID: 67887 RVA: 0x0044F3A4 File Offset: 0x0044D5A4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010930 RID: 67888 RVA: 0x0044F3B4 File Offset: 0x0044D5B4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010931 RID: 67889 RVA: 0x0044F3C4 File Offset: 0x0044D5C4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010932 RID: 67890 RVA: 0x0044F3D4 File Offset: 0x0044D5D4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010933 RID: 67891 RVA: 0x0044F3E4 File Offset: 0x0044D5E4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010934 RID: 67892 RVA: 0x0044F3F4 File Offset: 0x0044D5F4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010935 RID: 67893 RVA: 0x0044F404 File Offset: 0x0044D604
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010936 RID: 67894 RVA: 0x0044F414 File Offset: 0x0044D614
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010937 RID: 67895 RVA: 0x0044F424 File Offset: 0x0044D624
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010938 RID: 67896 RVA: 0x0044F434 File Offset: 0x0044D634
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010939 RID: 67897 RVA: 0x0044F444 File Offset: 0x0044D644
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601093A RID: 67898 RVA: 0x0044F454 File Offset: 0x0044D654
			public void __callDele_EventOnHeroSkillsSelect(int arg1, List<int> arg2, bool arg3)
			{
				this.m_owner.__callDele_EventOnHeroSkillsSelect(arg1, arg2, arg3);
			}

			// Token: 0x0601093B RID: 67899 RVA: 0x0044F464 File Offset: 0x0044D664
			public void __clearDele_EventOnHeroSkillsSelect(int arg1, List<int> arg2, bool arg3)
			{
				this.m_owner.__clearDele_EventOnHeroSkillsSelect(arg1, arg2, arg3);
			}

			// Token: 0x1700333C RID: 13116
			// (get) Token: 0x0601093C RID: 67900 RVA: 0x0044F474 File Offset: 0x0044D674
			// (set) Token: 0x0601093D RID: 67901 RVA: 0x0044F484 File Offset: 0x0044D684
			public GameObject m_infoSelectSkillPanel
			{
				get
				{
					return this.m_owner.m_infoSelectSkillPanel;
				}
				set
				{
					this.m_owner.m_infoSelectSkillPanel = value;
				}
			}

			// Token: 0x1700333D RID: 13117
			// (get) Token: 0x0601093E RID: 67902 RVA: 0x0044F494 File Offset: 0x0044D694
			// (set) Token: 0x0601093F RID: 67903 RVA: 0x0044F4A4 File Offset: 0x0044D6A4
			public Button m_infoCloseSelectSkillButton
			{
				get
				{
					return this.m_owner.m_infoCloseSelectSkillButton;
				}
				set
				{
					this.m_owner.m_infoCloseSelectSkillButton = value;
				}
			}

			// Token: 0x1700333E RID: 13118
			// (get) Token: 0x06010940 RID: 67904 RVA: 0x0044F4B4 File Offset: 0x0044D6B4
			// (set) Token: 0x06010941 RID: 67905 RVA: 0x0044F4C4 File Offset: 0x0044D6C4
			public GameObject m_infoSelectSkillsCost
			{
				get
				{
					return this.m_owner.m_infoSelectSkillsCost;
				}
				set
				{
					this.m_owner.m_infoSelectSkillsCost = value;
				}
			}

			// Token: 0x1700333F RID: 13119
			// (get) Token: 0x06010942 RID: 67906 RVA: 0x0044F4D4 File Offset: 0x0044D6D4
			// (set) Token: 0x06010943 RID: 67907 RVA: 0x0044F4E4 File Offset: 0x0044D6E4
			public GameObject m_infoSelectSkillsContent
			{
				get
				{
					return this.m_owner.m_infoSelectSkillsContent;
				}
				set
				{
					this.m_owner.m_infoSelectSkillsContent = value;
				}
			}

			// Token: 0x17003340 RID: 13120
			// (get) Token: 0x06010944 RID: 67908 RVA: 0x0044F4F4 File Offset: 0x0044D6F4
			// (set) Token: 0x06010945 RID: 67909 RVA: 0x0044F504 File Offset: 0x0044D704
			public GameObject m_infoAllSkillsContent
			{
				get
				{
					return this.m_owner.m_infoAllSkillsContent;
				}
				set
				{
					this.m_owner.m_infoAllSkillsContent = value;
				}
			}

			// Token: 0x17003341 RID: 13121
			// (get) Token: 0x06010946 RID: 67910 RVA: 0x0044F514 File Offset: 0x0044D714
			// (set) Token: 0x06010947 RID: 67911 RVA: 0x0044F524 File Offset: 0x0044D724
			public Button m_infoSaveSelectSkillsButton
			{
				get
				{
					return this.m_owner.m_infoSaveSelectSkillsButton;
				}
				set
				{
					this.m_owner.m_infoSaveSelectSkillsButton = value;
				}
			}

			// Token: 0x17003342 RID: 13122
			// (get) Token: 0x06010948 RID: 67912 RVA: 0x0044F534 File Offset: 0x0044D734
			// (set) Token: 0x06010949 RID: 67913 RVA: 0x0044F544 File Offset: 0x0044D744
			public Button m_infoSkillDescLoadButton
			{
				get
				{
					return this.m_owner.m_infoSkillDescLoadButton;
				}
				set
				{
					this.m_owner.m_infoSkillDescLoadButton = value;
				}
			}

			// Token: 0x17003343 RID: 13123
			// (get) Token: 0x0601094A RID: 67914 RVA: 0x0044F554 File Offset: 0x0044D754
			// (set) Token: 0x0601094B RID: 67915 RVA: 0x0044F564 File Offset: 0x0044D764
			public Button m_infoSkillDescUnLoadButton
			{
				get
				{
					return this.m_owner.m_infoSkillDescUnLoadButton;
				}
				set
				{
					this.m_owner.m_infoSkillDescUnLoadButton = value;
				}
			}

			// Token: 0x17003344 RID: 13124
			// (get) Token: 0x0601094C RID: 67916 RVA: 0x0044F574 File Offset: 0x0044D774
			// (set) Token: 0x0601094D RID: 67917 RVA: 0x0044F584 File Offset: 0x0044D784
			public GameObject m_infoSkillDescGo
			{
				get
				{
					return this.m_owner.m_infoSkillDescGo;
				}
				set
				{
					this.m_owner.m_infoSkillDescGo = value;
				}
			}

			// Token: 0x17003345 RID: 13125
			// (get) Token: 0x0601094E RID: 67918 RVA: 0x0044F594 File Offset: 0x0044D794
			// (set) Token: 0x0601094F RID: 67919 RVA: 0x0044F5A4 File Offset: 0x0044D7A4
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

			// Token: 0x17003346 RID: 13126
			// (get) Token: 0x06010950 RID: 67920 RVA: 0x0044F5B4 File Offset: 0x0044D7B4
			// (set) Token: 0x06010951 RID: 67921 RVA: 0x0044F5C4 File Offset: 0x0044D7C4
			public List<int> m_curSelectSkillIds
			{
				get
				{
					return this.m_owner.m_curSelectSkillIds;
				}
				set
				{
					this.m_owner.m_curSelectSkillIds = value;
				}
			}

			// Token: 0x17003347 RID: 13127
			// (get) Token: 0x06010952 RID: 67922 RVA: 0x0044F5D4 File Offset: 0x0044D7D4
			// (set) Token: 0x06010953 RID: 67923 RVA: 0x0044F5E4 File Offset: 0x0044D7E4
			public HeroSkillItemUIController m_curSelectedSkillCtrl
			{
				get
				{
					return this.m_owner.m_curSelectedSkillCtrl;
				}
				set
				{
					this.m_owner.m_curSelectedSkillCtrl = value;
				}
			}

			// Token: 0x17003348 RID: 13128
			// (get) Token: 0x06010954 RID: 67924 RVA: 0x0044F5F4 File Offset: 0x0044D7F4
			// (set) Token: 0x06010955 RID: 67925 RVA: 0x0044F604 File Offset: 0x0044D804
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

			// Token: 0x17003349 RID: 13129
			// (get) Token: 0x06010956 RID: 67926 RVA: 0x0044F614 File Offset: 0x0044D814
			// (set) Token: 0x06010957 RID: 67927 RVA: 0x0044F624 File Offset: 0x0044D824
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

			// Token: 0x06010958 RID: 67928 RVA: 0x0044F634 File Offset: 0x0044D834
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010959 RID: 67929 RVA: 0x0044F644 File Offset: 0x0044D844
			public void ShowSelectSkillContent()
			{
				this.m_owner.ShowSelectSkillContent();
			}

			// Token: 0x0601095A RID: 67930 RVA: 0x0044F654 File Offset: 0x0044D854
			public void OnSkillItemClick(HeroSkillItemUIController skillCtrl)
			{
				this.m_owner.OnSkillItemClick(skillCtrl);
			}

			// Token: 0x0601095B RID: 67931 RVA: 0x0044F664 File Offset: 0x0044D864
			public void OnLoadOrUnLoadButtonClick()
			{
				this.m_owner.OnLoadOrUnLoadButtonClick();
			}

			// Token: 0x0601095C RID: 67932 RVA: 0x0044F674 File Offset: 0x0044D874
			public void OnSaveSelectSkillsButtonClick()
			{
				this.m_owner.OnSaveSelectSkillsButtonClick();
			}

			// Token: 0x0601095D RID: 67933 RVA: 0x0044F684 File Offset: 0x0044D884
			public void CloseSkillDesc()
			{
				this.m_owner.CloseSkillDesc();
			}

			// Token: 0x0601095E RID: 67934 RVA: 0x0044F694 File Offset: 0x0044D894
			public void CloseSelectSkillPanel(Action onEnd)
			{
				this.m_owner.CloseSelectSkillPanel(onEnd);
			}

			// Token: 0x0601095F RID: 67935 RVA: 0x0044F6A4 File Offset: 0x0044D8A4
			public int CalcTotalCostFromSkillList(List<int> skillIds)
			{
				return this.m_owner.CalcTotalCostFromSkillList(skillIds);
			}

			// Token: 0x04009982 RID: 39298
			private HeroDetailSelectSkillUIController m_owner;
		}
	}
}
