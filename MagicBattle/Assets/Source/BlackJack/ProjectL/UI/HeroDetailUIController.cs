using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
	// Token: 0x02000DB5 RID: 3509
	[HotFix]
	public class HeroDetailUIController : UIControllerBase
	{
		// Token: 0x06010A5E RID: 68190 RVA: 0x00452D84 File Offset: 0x00450F84
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
			this.m_leftButton.onClick.AddListener(new UnityAction(this.OnLeftButtonClick));
			this.m_rightButton.onClick.AddListener(new UnityAction(this.OnRightButtonClick));
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_jobToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnJobToggleValueChanged));
			this.m_infoToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnInfoToggleValueChanged));
			this.m_equipToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnEquipToggleValueChanged));
			this.m_soldierToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSoldierToggleValueChanged));
			this.m_lifeToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnLifeToggleValueChanged));
			this.m_jobTransferButton.onClick.AddListener(new UnityAction(this.OnJobTransferButtonClick));
			this.m_equipMaskButton.onClick.AddListener(new UnityAction(this.OnMaskButtonForUserGuideClick));
			base.gameObject.SetActive(true);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x06010A5F RID: 68191 RVA: 0x00452F44 File Offset: 0x00451144
		public void PassHeroInfo(List<Hero> hList, int num)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PassHeroInfoList`1Int32_hotfix != null)
			{
				this.m_PassHeroInfoList`1Int32_hotfix.call(new object[]
				{
					this,
					hList,
					num
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curHeroList != hList)
			{
				this.m_curHeroList.Clear();
				this.m_curHeroList.AddRange(hList);
			}
			if (this.m_curHeroNum != num)
			{
				this.m_curHeroNum = num;
			}
		}

		// Token: 0x06010A60 RID: 68192 RVA: 0x00452FFC File Offset: 0x004511FC
		public void UpdateViewInHeroDetail()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInHeroDetail_hotfix != null)
			{
				this.m_UpdateViewInHeroDetail_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curHeroList == null || this.m_curHeroList.Count == 0)
			{
				return;
			}
			this.m_hero = this.m_curHeroList[this.m_curHeroNum];
			bool active = this.m_playerContext.CanLevelUpHeroJobLevel(this.m_hero.HeroId, this.m_hero.ActiveHeroJobRelatedId) == 0;
			this.m_jobToggleClickRedMark.SetActive(active);
			this.m_jobToggleUnClickRedMark.SetActive(active);
			this.m_jobUpTip.gameObject.SetActive(this.m_playerContext.IsShowJobLevelCanUpTip(this.m_hero));
			bool active2 = this.m_playerContext.IsHeroHaveNewJobCanTransfer(this.m_hero.HeroId);
			this.m_jobTransferButtonRedIcon.SetActive(active2);
			this.m_jobTransferButtonReadyEffect.SetActive(active2);
			bool flag = this.m_playerContext.HasBetterEquipmentByHero(this.m_hero);
			bool flag2 = this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Equipment);
			this.m_equipToggleClickRedMark.SetActive(flag2 && flag);
			this.m_equipToggleUnClickRedMark.SetActive(flag2 && flag);
			this.m_equipMaskButton.gameObject.SetActive(!this.m_playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_Equipment));
			this.m_lifeToggleClickRedMark.SetActive(FettersInformationUIController.HaveNewInfomation(this.m_hero.HeroInfo.m_informationInfo));
			this.m_returnButton.interactable = true;
		}

		// Token: 0x06010A61 RID: 68193 RVA: 0x004531B4 File Offset: 0x004513B4
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReturn != null)
			{
				this.m_returnButton.interactable = false;
				base.StopAllCoroutines();
				this.EventOnReturn();
			}
		}

		// Token: 0x06010A62 RID: 68194 RVA: 0x0045323C File Offset: 0x0045143C
		private void OnLeftButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLeftButtonClick_hotfix != null)
			{
				this.m_OnLeftButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curHeroNum == 0)
			{
				this.m_curHeroNum = this.m_curHeroList.Count - 1;
			}
			else
			{
				this.m_curHeroNum--;
			}
			if (this.EventOnUpdateViewInListAndDetail != null)
			{
				this.EventOnUpdateViewInListAndDetail(this.m_curHeroNum, true, true, this.m_curHeroList[this.m_curHeroNum].HeroId);
			}
		}

		// Token: 0x06010A63 RID: 68195 RVA: 0x00453304 File Offset: 0x00451504
		private void OnRightButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRightButtonClick_hotfix != null)
			{
				this.m_OnRightButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curHeroNum == this.m_curHeroList.Count - 1)
			{
				this.m_curHeroNum = 0;
			}
			else
			{
				this.m_curHeroNum++;
			}
			if (this.EventOnUpdateViewInListAndDetail != null)
			{
				this.EventOnUpdateViewInListAndDetail(this.m_curHeroNum, true, true, this.m_curHeroList[this.m_curHeroNum].HeroId);
			}
		}

		// Token: 0x06010A64 RID: 68196 RVA: 0x004533CC File Offset: 0x004515CC
		private void OnJobTransferButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobTransferButtonClick_hotfix != null)
			{
				this.m_OnJobTransferButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.OnJobTransferButtonClickEffect());
		}

		// Token: 0x06010A65 RID: 68197 RVA: 0x0045343C File Offset: 0x0045163C
		[DebuggerHidden]
		private IEnumerator OnJobTransferButtonClickEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobTransferButtonClickEffect_hotfix != null)
			{
				return (IEnumerator)this.m_OnJobTransferButtonClickEffect_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroDetailUIController.<OnJobTransferButtonClickEffect>c__Iterator0 <OnJobTransferButtonClickEffect>c__Iterator = new HeroDetailUIController.<OnJobTransferButtonClickEffect>c__Iterator0();
			<OnJobTransferButtonClickEffect>c__Iterator.$this = this;
			return <OnJobTransferButtonClickEffect>c__Iterator;
		}

		// Token: 0x06010A66 RID: 68198 RVA: 0x004534B8 File Offset: 0x004516B8
		private void OnMaskButtonForUserGuideClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMaskButtonForUserGuideClick_hotfix != null)
			{
				this.m_OnMaskButtonForUserGuideClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(UIUtility.GetGameFunctionOpenMessage(GameFunctionType.GameFunctionType_Equipment), 2f, null, true);
		}

		// Token: 0x06010A67 RID: 68199 RVA: 0x00453530 File Offset: 0x00451730
		public bool HeroInfoToogleIsOn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroInfoToogleIsOn_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HeroInfoToogleIsOn_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_infoToggle.isOn;
		}

		// Token: 0x06010A68 RID: 68200 RVA: 0x004535A8 File Offset: 0x004517A8
		public bool HeroJobToggleIsOn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroJobToggleIsOn_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HeroJobToggleIsOn_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_jobToggle.isOn;
		}

		// Token: 0x06010A69 RID: 68201 RVA: 0x00453620 File Offset: 0x00451820
		public bool HeroEquipToggleIsOn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroEquipToggleIsOn_hotfix != null)
			{
				return Convert.ToBoolean(this.m_HeroEquipToggleIsOn_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_equipToggle.isOn;
		}

		// Token: 0x06010A6A RID: 68202 RVA: 0x00453698 File Offset: 0x00451898
		public void SetToggleToInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToggleToInfo_hotfix != null)
			{
				this.m_SetToggleToInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_infoToggle.isOn = true;
		}

		// Token: 0x06010A6B RID: 68203 RVA: 0x00453704 File Offset: 0x00451904
		public void SetToggleToJob()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToggleToJob_hotfix != null)
			{
				this.m_SetToggleToJob_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_jobToggle.isOn = true;
		}

		// Token: 0x06010A6C RID: 68204 RVA: 0x00453770 File Offset: 0x00451970
		public void SetToggleToSoldier()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToggleToSoldier_hotfix != null)
			{
				this.m_SetToggleToSoldier_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_soldierToggle.isOn = true;
		}

		// Token: 0x06010A6D RID: 68205 RVA: 0x004537DC File Offset: 0x004519DC
		public void SetToggleToEquip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToggleToEquip_hotfix != null)
			{
				this.m_SetToggleToEquip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_equipToggle.isOn = true;
		}

		// Token: 0x06010A6E RID: 68206 RVA: 0x00453848 File Offset: 0x00451A48
		public void SetToggleToLife()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetToggleToLife_hotfix != null)
			{
				this.m_SetToggleToLife_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lifeToggle.isOn = true;
		}

		// Token: 0x06010A6F RID: 68207 RVA: 0x004538B4 File Offset: 0x00451AB4
		public static void CreateSpineGraphic(ref UISpineGraphic graphic, string assetName, GameObject parent, int direction, Vector2 offset, float scale, List<ReplaceAnim> anims)
		{
			HeroDetailUIController.DestroySpineGraphic(ref graphic);
			graphic = new UISpineGraphic();
			graphic.Create(assetName);
			graphic.SetParent(parent);
			graphic.SetDirection(direction);
			graphic.SetPosition(offset);
			graphic.SetScale(scale);
			graphic.SetRectTransformSize(new Vector2(500f / scale, 500f / scale));
			graphic.SetReplaceAnimations(anims);
			graphic.PlayAnimation("idle", true, 0);
			graphic.ForceUpdate();
		}

		// Token: 0x06010A70 RID: 68208 RVA: 0x00453934 File Offset: 0x00451B34
		public static void DestroySpineGraphic(ref UISpineGraphic g)
		{
			if (g != null)
			{
				g.Destroy();
				g = null;
			}
		}

		// Token: 0x06010A71 RID: 68209 RVA: 0x00453948 File Offset: 0x00451B48
		private void OnInfoToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnInfoToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnInfoToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				this.EventOnSetDetailState("DetailInfo");
			}
		}

		// Token: 0x06010A72 RID: 68210 RVA: 0x004539D0 File Offset: 0x00451BD0
		private void OnJobToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnJobToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				this.EventOnSetDetailState("DetailJob");
			}
		}

		// Token: 0x06010A73 RID: 68211 RVA: 0x00453A58 File Offset: 0x00451C58
		private void OnSoldierToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSoldierToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				this.EventOnSetDetailState("DetailSoldier");
			}
		}

		// Token: 0x06010A74 RID: 68212 RVA: 0x00453AE0 File Offset: 0x00451CE0
		private void OnEquipToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEquipToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnEquipToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				this.EventOnSetDetailState("DetailEquipment");
			}
		}

		// Token: 0x06010A75 RID: 68213 RVA: 0x00453B68 File Offset: 0x00451D68
		private void OnLifeToggleValueChanged(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLifeToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnLifeToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (on)
			{
				this.EventOnSetDetailState("DetailLife");
			}
		}

		// Token: 0x14000388 RID: 904
		// (add) Token: 0x06010A76 RID: 68214 RVA: 0x00453BF0 File Offset: 0x00451DF0
		// (remove) Token: 0x06010A77 RID: 68215 RVA: 0x00453C8C File Offset: 0x00451E8C
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000389 RID: 905
		// (add) Token: 0x06010A78 RID: 68216 RVA: 0x00453D28 File Offset: 0x00451F28
		// (remove) Token: 0x06010A79 RID: 68217 RVA: 0x00453DC4 File Offset: 0x00451FC4
		public event Action EventOnJobTransfer
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnJobTransferAction_hotfix != null)
				{
					this.m_add_EventOnJobTransferAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnJobTransfer;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnJobTransfer, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnJobTransferAction_hotfix != null)
				{
					this.m_remove_EventOnJobTransferAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnJobTransfer;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnJobTransfer, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400038A RID: 906
		// (add) Token: 0x06010A7A RID: 68218 RVA: 0x00453E60 File Offset: 0x00452060
		// (remove) Token: 0x06010A7B RID: 68219 RVA: 0x00453EFC File Offset: 0x004520FC
		public event Action<string> EventOnSetDetailState
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSetDetailStateAction`1_hotfix != null)
				{
					this.m_add_EventOnSetDetailStateAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnSetDetailState;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnSetDetailState, (Action<string>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSetDetailStateAction`1_hotfix != null)
				{
					this.m_remove_EventOnSetDetailStateAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string> action = this.EventOnSetDetailState;
				Action<string> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string>>(ref this.EventOnSetDetailState, (Action<string>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400038B RID: 907
		// (add) Token: 0x06010A7C RID: 68220 RVA: 0x00453F98 File Offset: 0x00452198
		// (remove) Token: 0x06010A7D RID: 68221 RVA: 0x00454034 File Offset: 0x00452234
		public event Action<int, bool, bool, int> EventOnUpdateViewInListAndDetail
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUpdateViewInListAndDetailAction`4_hotfix != null)
				{
					this.m_add_EventOnUpdateViewInListAndDetailAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, bool, bool, int> action = this.EventOnUpdateViewInListAndDetail;
				Action<int, bool, bool, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, bool, bool, int>>(ref this.EventOnUpdateViewInListAndDetail, (Action<int, bool, bool, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUpdateViewInListAndDetailAction`4_hotfix != null)
				{
					this.m_remove_EventOnUpdateViewInListAndDetailAction`4_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, bool, bool, int> action = this.EventOnUpdateViewInListAndDetail;
				Action<int, bool, bool, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, bool, bool, int>>(ref this.EventOnUpdateViewInListAndDetail, (Action<int, bool, bool, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x06010A7E RID: 68222 RVA: 0x004540D0 File Offset: 0x004522D0
		// (set) Token: 0x06010A7F RID: 68223 RVA: 0x004540F0 File Offset: 0x004522F0
		[DoNotToLua]
		public new HeroDetailUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDetailUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010A80 RID: 68224 RVA: 0x004540FC File Offset: 0x004522FC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010A81 RID: 68225 RVA: 0x00454108 File Offset: 0x00452308
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010A82 RID: 68226 RVA: 0x00454110 File Offset: 0x00452310
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010A83 RID: 68227 RVA: 0x00454118 File Offset: 0x00452318
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010A84 RID: 68228 RVA: 0x0045412C File Offset: 0x0045232C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010A85 RID: 68229 RVA: 0x00454134 File Offset: 0x00452334
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010A86 RID: 68230 RVA: 0x00454140 File Offset: 0x00452340
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010A87 RID: 68231 RVA: 0x0045414C File Offset: 0x0045234C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010A88 RID: 68232 RVA: 0x00454158 File Offset: 0x00452358
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010A89 RID: 68233 RVA: 0x00454164 File Offset: 0x00452364
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010A8A RID: 68234 RVA: 0x00454170 File Offset: 0x00452370
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010A8B RID: 68235 RVA: 0x0045417C File Offset: 0x0045237C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010A8C RID: 68236 RVA: 0x00454188 File Offset: 0x00452388
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010A8D RID: 68237 RVA: 0x00454194 File Offset: 0x00452394
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010A8E RID: 68238 RVA: 0x004541A0 File Offset: 0x004523A0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010A8F RID: 68239 RVA: 0x004541A8 File Offset: 0x004523A8
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06010A90 RID: 68240 RVA: 0x004541C8 File Offset: 0x004523C8
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06010A91 RID: 68241 RVA: 0x004541D4 File Offset: 0x004523D4
		private void __callDele_EventOnJobTransfer()
		{
			Action eventOnJobTransfer = this.EventOnJobTransfer;
			if (eventOnJobTransfer != null)
			{
				eventOnJobTransfer();
			}
		}

		// Token: 0x06010A92 RID: 68242 RVA: 0x004541F4 File Offset: 0x004523F4
		private void __clearDele_EventOnJobTransfer()
		{
			this.EventOnJobTransfer = null;
		}

		// Token: 0x06010A93 RID: 68243 RVA: 0x00454200 File Offset: 0x00452400
		private void __callDele_EventOnSetDetailState(string obj)
		{
			Action<string> eventOnSetDetailState = this.EventOnSetDetailState;
			if (eventOnSetDetailState != null)
			{
				eventOnSetDetailState(obj);
			}
		}

		// Token: 0x06010A94 RID: 68244 RVA: 0x00454224 File Offset: 0x00452424
		private void __clearDele_EventOnSetDetailState(string obj)
		{
			this.EventOnSetDetailState = null;
		}

		// Token: 0x06010A95 RID: 68245 RVA: 0x00454230 File Offset: 0x00452430
		private void __callDele_EventOnUpdateViewInListAndDetail(int arg1, bool arg2, bool arg3, int arg4)
		{
			Action<int, bool, bool, int> eventOnUpdateViewInListAndDetail = this.EventOnUpdateViewInListAndDetail;
			if (eventOnUpdateViewInListAndDetail != null)
			{
				eventOnUpdateViewInListAndDetail(arg1, arg2, arg3, arg4);
			}
		}

		// Token: 0x06010A96 RID: 68246 RVA: 0x00454258 File Offset: 0x00452458
		private void __clearDele_EventOnUpdateViewInListAndDetail(int arg1, bool arg2, bool arg3, int arg4)
		{
			this.EventOnUpdateViewInListAndDetail = null;
		}

		// Token: 0x06010A97 RID: 68247 RVA: 0x00454264 File Offset: 0x00452464
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
					this.m_PassHeroInfoList`1Int32_hotfix = (luaObj.RawGet("PassHeroInfo") as LuaFunction);
					this.m_UpdateViewInHeroDetail_hotfix = (luaObj.RawGet("UpdateViewInHeroDetail") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnLeftButtonClick_hotfix = (luaObj.RawGet("OnLeftButtonClick") as LuaFunction);
					this.m_OnRightButtonClick_hotfix = (luaObj.RawGet("OnRightButtonClick") as LuaFunction);
					this.m_OnJobTransferButtonClick_hotfix = (luaObj.RawGet("OnJobTransferButtonClick") as LuaFunction);
					this.m_OnJobTransferButtonClickEffect_hotfix = (luaObj.RawGet("OnJobTransferButtonClickEffect") as LuaFunction);
					this.m_OnMaskButtonForUserGuideClick_hotfix = (luaObj.RawGet("OnMaskButtonForUserGuideClick") as LuaFunction);
					this.m_HeroInfoToogleIsOn_hotfix = (luaObj.RawGet("HeroInfoToogleIsOn") as LuaFunction);
					this.m_HeroJobToggleIsOn_hotfix = (luaObj.RawGet("HeroJobToggleIsOn") as LuaFunction);
					this.m_HeroEquipToggleIsOn_hotfix = (luaObj.RawGet("HeroEquipToggleIsOn") as LuaFunction);
					this.m_SetToggleToInfo_hotfix = (luaObj.RawGet("SetToggleToInfo") as LuaFunction);
					this.m_SetToggleToJob_hotfix = (luaObj.RawGet("SetToggleToJob") as LuaFunction);
					this.m_SetToggleToSoldier_hotfix = (luaObj.RawGet("SetToggleToSoldier") as LuaFunction);
					this.m_SetToggleToEquip_hotfix = (luaObj.RawGet("SetToggleToEquip") as LuaFunction);
					this.m_SetToggleToLife_hotfix = (luaObj.RawGet("SetToggleToLife") as LuaFunction);
					this.m_OnInfoToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnInfoToggleValueChanged") as LuaFunction);
					this.m_OnJobToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnJobToggleValueChanged") as LuaFunction);
					this.m_OnSoldierToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSoldierToggleValueChanged") as LuaFunction);
					this.m_OnEquipToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnEquipToggleValueChanged") as LuaFunction);
					this.m_OnLifeToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnLifeToggleValueChanged") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnJobTransferAction_hotfix = (luaObj.RawGet("add_EventOnJobTransfer") as LuaFunction);
					this.m_remove_EventOnJobTransferAction_hotfix = (luaObj.RawGet("remove_EventOnJobTransfer") as LuaFunction);
					this.m_add_EventOnSetDetailStateAction`1_hotfix = (luaObj.RawGet("add_EventOnSetDetailState") as LuaFunction);
					this.m_remove_EventOnSetDetailStateAction`1_hotfix = (luaObj.RawGet("remove_EventOnSetDetailState") as LuaFunction);
					this.m_add_EventOnUpdateViewInListAndDetailAction`4_hotfix = (luaObj.RawGet("add_EventOnUpdateViewInListAndDetail") as LuaFunction);
					this.m_remove_EventOnUpdateViewInListAndDetailAction`4_hotfix = (luaObj.RawGet("remove_EventOnUpdateViewInListAndDetail") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010A98 RID: 68248 RVA: 0x00454604 File Offset: 0x00452804
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDetailUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040099ED RID: 39405
		[AutoBind("./Margin", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x040099EE RID: 39406
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x040099EF RID: 39407
		[AutoBind("./Margin/LeftButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_leftButton;

		// Token: 0x040099F0 RID: 39408
		[AutoBind("./Margin/RightButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_rightButton;

		// Token: 0x040099F1 RID: 39409
		[AutoBind("./Margin/FilterToggles/Info", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_infoToggle;

		// Token: 0x040099F2 RID: 39410
		[AutoBind("./Margin/FilterToggles/Job", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_jobToggle;

		// Token: 0x040099F3 RID: 39411
		[AutoBind("./Margin/FilterToggles/Job/Click/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobToggleClickRedMark;

		// Token: 0x040099F4 RID: 39412
		[AutoBind("./Margin/FilterToggles/Job/UnClick/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobToggleUnClickRedMark;

		// Token: 0x040099F5 RID: 39413
		[AutoBind("./Margin/FilterToggles/Job/JobUpButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobUpTip;

		// Token: 0x040099F6 RID: 39414
		[AutoBind("./Margin/FilterToggles/Soldier", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_soldierToggle;

		// Token: 0x040099F7 RID: 39415
		[AutoBind("./Margin/FilterToggles/Equip", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_equipToggle;

		// Token: 0x040099F8 RID: 39416
		[AutoBind("./Margin/FilterToggles/Equip/Click/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipToggleClickRedMark;

		// Token: 0x040099F9 RID: 39417
		[AutoBind("./Margin/FilterToggles/Equip/UnClick/RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipToggleUnClickRedMark;

		// Token: 0x040099FA RID: 39418
		[AutoBind("./Life", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_lifeToggle;

		// Token: 0x040099FB RID: 39419
		[AutoBind("./Life/NewImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lifeToggleClickRedMark;

		// Token: 0x040099FC RID: 39420
		[AutoBind("./Margin/FilterToggles/Equip/EquipMask", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_equipMaskButton;

		// Token: 0x040099FD RID: 39421
		[AutoBind("./Margin/JobTransferButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_jobTransferButton;

		// Token: 0x040099FE RID: 39422
		[AutoBind("./Margin/JobTransferButton/RedIcon", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobTransferButtonRedIcon;

		// Token: 0x040099FF RID: 39423
		[AutoBind("./Margin/JobTransferButton/U_SummonButton_ Press", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobTransferButtonPressEffect;

		// Token: 0x04009A00 RID: 39424
		[AutoBind("./Margin/JobTransferButton/U_Button_ready", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_jobTransferButtonReadyEffect;

		// Token: 0x04009A05 RID: 39429
		private Hero m_hero;

		// Token: 0x04009A06 RID: 39430
		public int m_curHeroNum;

		// Token: 0x04009A07 RID: 39431
		public List<Hero> m_curHeroList = new List<Hero>();

		// Token: 0x04009A08 RID: 39432
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009A09 RID: 39433
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009A0A RID: 39434
		[DoNotToLua]
		private HeroDetailUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009A0B RID: 39435
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009A0C RID: 39436
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009A0D RID: 39437
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009A0E RID: 39438
		private LuaFunction m_PassHeroInfoList;

		// Token: 0x04009A0F RID: 39439
		private LuaFunction m_UpdateViewInHeroDetail_hotfix;

		// Token: 0x04009A10 RID: 39440
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x04009A11 RID: 39441
		private LuaFunction m_OnLeftButtonClick_hotfix;

		// Token: 0x04009A12 RID: 39442
		private LuaFunction m_OnRightButtonClick_hotfix;

		// Token: 0x04009A13 RID: 39443
		private LuaFunction m_OnJobTransferButtonClick_hotfix;

		// Token: 0x04009A14 RID: 39444
		private LuaFunction m_OnJobTransferButtonClickEffect_hotfix;

		// Token: 0x04009A15 RID: 39445
		private LuaFunction m_OnMaskButtonForUserGuideClick_hotfix;

		// Token: 0x04009A16 RID: 39446
		private LuaFunction m_HeroInfoToogleIsOn_hotfix;

		// Token: 0x04009A17 RID: 39447
		private LuaFunction m_HeroJobToggleIsOn_hotfix;

		// Token: 0x04009A18 RID: 39448
		private LuaFunction m_HeroEquipToggleIsOn_hotfix;

		// Token: 0x04009A19 RID: 39449
		private LuaFunction m_SetToggleToInfo_hotfix;

		// Token: 0x04009A1A RID: 39450
		private LuaFunction m_SetToggleToJob_hotfix;

		// Token: 0x04009A1B RID: 39451
		private LuaFunction m_SetToggleToSoldier_hotfix;

		// Token: 0x04009A1C RID: 39452
		private LuaFunction m_SetToggleToEquip_hotfix;

		// Token: 0x04009A1D RID: 39453
		private LuaFunction m_SetToggleToLife_hotfix;

		// Token: 0x04009A1E RID: 39454
		private LuaFunction m_OnInfoToggleValueChangedBoolean_hotfix;

		// Token: 0x04009A1F RID: 39455
		private LuaFunction m_OnJobToggleValueChangedBoolean_hotfix;

		// Token: 0x04009A20 RID: 39456
		private LuaFunction m_OnSoldierToggleValueChangedBoolean_hotfix;

		// Token: 0x04009A21 RID: 39457
		private LuaFunction m_OnEquipToggleValueChangedBoolean_hotfix;

		// Token: 0x04009A22 RID: 39458
		private LuaFunction m_OnLifeToggleValueChangedBoolean_hotfix;

		// Token: 0x04009A23 RID: 39459
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x04009A24 RID: 39460
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x04009A25 RID: 39461
		private LuaFunction m_add_EventOnJobTransferAction_hotfix;

		// Token: 0x04009A26 RID: 39462
		private LuaFunction m_remove_EventOnJobTransferAction_hotfix;

		// Token: 0x04009A27 RID: 39463
		private LuaFunction m_add_EventOnSetDetailStateAction;

		// Token: 0x04009A28 RID: 39464
		private LuaFunction m_remove_EventOnSetDetailStateAction;

		// Token: 0x04009A29 RID: 39465
		private LuaFunction m_add_EventOnUpdateViewInListAndDetailAction;

		// Token: 0x04009A2A RID: 39466
		private LuaFunction m_remove_EventOnUpdateViewInListAndDetailAction;

		// Token: 0x02000DB6 RID: 3510
		public new class LuaExportHelper
		{
			// Token: 0x06010A99 RID: 68249 RVA: 0x0045466C File Offset: 0x0045286C
			public LuaExportHelper(HeroDetailUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010A9A RID: 68250 RVA: 0x0045467C File Offset: 0x0045287C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010A9B RID: 68251 RVA: 0x0045468C File Offset: 0x0045288C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010A9C RID: 68252 RVA: 0x0045469C File Offset: 0x0045289C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010A9D RID: 68253 RVA: 0x004546AC File Offset: 0x004528AC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010A9E RID: 68254 RVA: 0x004546C4 File Offset: 0x004528C4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010A9F RID: 68255 RVA: 0x004546D4 File Offset: 0x004528D4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010AA0 RID: 68256 RVA: 0x004546E4 File Offset: 0x004528E4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010AA1 RID: 68257 RVA: 0x004546F4 File Offset: 0x004528F4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010AA2 RID: 68258 RVA: 0x00454704 File Offset: 0x00452904
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010AA3 RID: 68259 RVA: 0x00454714 File Offset: 0x00452914
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010AA4 RID: 68260 RVA: 0x00454724 File Offset: 0x00452924
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010AA5 RID: 68261 RVA: 0x00454734 File Offset: 0x00452934
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010AA6 RID: 68262 RVA: 0x00454744 File Offset: 0x00452944
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010AA7 RID: 68263 RVA: 0x00454754 File Offset: 0x00452954
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010AA8 RID: 68264 RVA: 0x00454764 File Offset: 0x00452964
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010AA9 RID: 68265 RVA: 0x00454774 File Offset: 0x00452974
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x06010AAA RID: 68266 RVA: 0x00454784 File Offset: 0x00452984
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x06010AAB RID: 68267 RVA: 0x00454794 File Offset: 0x00452994
			public void __callDele_EventOnJobTransfer()
			{
				this.m_owner.__callDele_EventOnJobTransfer();
			}

			// Token: 0x06010AAC RID: 68268 RVA: 0x004547A4 File Offset: 0x004529A4
			public void __clearDele_EventOnJobTransfer()
			{
				this.m_owner.__clearDele_EventOnJobTransfer();
			}

			// Token: 0x06010AAD RID: 68269 RVA: 0x004547B4 File Offset: 0x004529B4
			public void __callDele_EventOnSetDetailState(string obj)
			{
				this.m_owner.__callDele_EventOnSetDetailState(obj);
			}

			// Token: 0x06010AAE RID: 68270 RVA: 0x004547C4 File Offset: 0x004529C4
			public void __clearDele_EventOnSetDetailState(string obj)
			{
				this.m_owner.__clearDele_EventOnSetDetailState(obj);
			}

			// Token: 0x06010AAF RID: 68271 RVA: 0x004547D4 File Offset: 0x004529D4
			public void __callDele_EventOnUpdateViewInListAndDetail(int arg1, bool arg2, bool arg3, int arg4)
			{
				this.m_owner.__callDele_EventOnUpdateViewInListAndDetail(arg1, arg2, arg3, arg4);
			}

			// Token: 0x06010AB0 RID: 68272 RVA: 0x004547E8 File Offset: 0x004529E8
			public void __clearDele_EventOnUpdateViewInListAndDetail(int arg1, bool arg2, bool arg3, int arg4)
			{
				this.m_owner.__clearDele_EventOnUpdateViewInListAndDetail(arg1, arg2, arg3, arg4);
			}

			// Token: 0x1700337E RID: 13182
			// (get) Token: 0x06010AB1 RID: 68273 RVA: 0x004547FC File Offset: 0x004529FC
			// (set) Token: 0x06010AB2 RID: 68274 RVA: 0x0045480C File Offset: 0x00452A0C
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x1700337F RID: 13183
			// (get) Token: 0x06010AB3 RID: 68275 RVA: 0x0045481C File Offset: 0x00452A1C
			// (set) Token: 0x06010AB4 RID: 68276 RVA: 0x0045482C File Offset: 0x00452A2C
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17003380 RID: 13184
			// (get) Token: 0x06010AB5 RID: 68277 RVA: 0x0045483C File Offset: 0x00452A3C
			// (set) Token: 0x06010AB6 RID: 68278 RVA: 0x0045484C File Offset: 0x00452A4C
			public Button m_leftButton
			{
				get
				{
					return this.m_owner.m_leftButton;
				}
				set
				{
					this.m_owner.m_leftButton = value;
				}
			}

			// Token: 0x17003381 RID: 13185
			// (get) Token: 0x06010AB7 RID: 68279 RVA: 0x0045485C File Offset: 0x00452A5C
			// (set) Token: 0x06010AB8 RID: 68280 RVA: 0x0045486C File Offset: 0x00452A6C
			public Button m_rightButton
			{
				get
				{
					return this.m_owner.m_rightButton;
				}
				set
				{
					this.m_owner.m_rightButton = value;
				}
			}

			// Token: 0x17003382 RID: 13186
			// (get) Token: 0x06010AB9 RID: 68281 RVA: 0x0045487C File Offset: 0x00452A7C
			// (set) Token: 0x06010ABA RID: 68282 RVA: 0x0045488C File Offset: 0x00452A8C
			public Toggle m_infoToggle
			{
				get
				{
					return this.m_owner.m_infoToggle;
				}
				set
				{
					this.m_owner.m_infoToggle = value;
				}
			}

			// Token: 0x17003383 RID: 13187
			// (get) Token: 0x06010ABB RID: 68283 RVA: 0x0045489C File Offset: 0x00452A9C
			// (set) Token: 0x06010ABC RID: 68284 RVA: 0x004548AC File Offset: 0x00452AAC
			public Toggle m_jobToggle
			{
				get
				{
					return this.m_owner.m_jobToggle;
				}
				set
				{
					this.m_owner.m_jobToggle = value;
				}
			}

			// Token: 0x17003384 RID: 13188
			// (get) Token: 0x06010ABD RID: 68285 RVA: 0x004548BC File Offset: 0x00452ABC
			// (set) Token: 0x06010ABE RID: 68286 RVA: 0x004548CC File Offset: 0x00452ACC
			public GameObject m_jobToggleClickRedMark
			{
				get
				{
					return this.m_owner.m_jobToggleClickRedMark;
				}
				set
				{
					this.m_owner.m_jobToggleClickRedMark = value;
				}
			}

			// Token: 0x17003385 RID: 13189
			// (get) Token: 0x06010ABF RID: 68287 RVA: 0x004548DC File Offset: 0x00452ADC
			// (set) Token: 0x06010AC0 RID: 68288 RVA: 0x004548EC File Offset: 0x00452AEC
			public GameObject m_jobToggleUnClickRedMark
			{
				get
				{
					return this.m_owner.m_jobToggleUnClickRedMark;
				}
				set
				{
					this.m_owner.m_jobToggleUnClickRedMark = value;
				}
			}

			// Token: 0x17003386 RID: 13190
			// (get) Token: 0x06010AC1 RID: 68289 RVA: 0x004548FC File Offset: 0x00452AFC
			// (set) Token: 0x06010AC2 RID: 68290 RVA: 0x0045490C File Offset: 0x00452B0C
			public GameObject m_jobUpTip
			{
				get
				{
					return this.m_owner.m_jobUpTip;
				}
				set
				{
					this.m_owner.m_jobUpTip = value;
				}
			}

			// Token: 0x17003387 RID: 13191
			// (get) Token: 0x06010AC3 RID: 68291 RVA: 0x0045491C File Offset: 0x00452B1C
			// (set) Token: 0x06010AC4 RID: 68292 RVA: 0x0045492C File Offset: 0x00452B2C
			public Toggle m_soldierToggle
			{
				get
				{
					return this.m_owner.m_soldierToggle;
				}
				set
				{
					this.m_owner.m_soldierToggle = value;
				}
			}

			// Token: 0x17003388 RID: 13192
			// (get) Token: 0x06010AC5 RID: 68293 RVA: 0x0045493C File Offset: 0x00452B3C
			// (set) Token: 0x06010AC6 RID: 68294 RVA: 0x0045494C File Offset: 0x00452B4C
			public Toggle m_equipToggle
			{
				get
				{
					return this.m_owner.m_equipToggle;
				}
				set
				{
					this.m_owner.m_equipToggle = value;
				}
			}

			// Token: 0x17003389 RID: 13193
			// (get) Token: 0x06010AC7 RID: 68295 RVA: 0x0045495C File Offset: 0x00452B5C
			// (set) Token: 0x06010AC8 RID: 68296 RVA: 0x0045496C File Offset: 0x00452B6C
			public GameObject m_equipToggleClickRedMark
			{
				get
				{
					return this.m_owner.m_equipToggleClickRedMark;
				}
				set
				{
					this.m_owner.m_equipToggleClickRedMark = value;
				}
			}

			// Token: 0x1700338A RID: 13194
			// (get) Token: 0x06010AC9 RID: 68297 RVA: 0x0045497C File Offset: 0x00452B7C
			// (set) Token: 0x06010ACA RID: 68298 RVA: 0x0045498C File Offset: 0x00452B8C
			public GameObject m_equipToggleUnClickRedMark
			{
				get
				{
					return this.m_owner.m_equipToggleUnClickRedMark;
				}
				set
				{
					this.m_owner.m_equipToggleUnClickRedMark = value;
				}
			}

			// Token: 0x1700338B RID: 13195
			// (get) Token: 0x06010ACB RID: 68299 RVA: 0x0045499C File Offset: 0x00452B9C
			// (set) Token: 0x06010ACC RID: 68300 RVA: 0x004549AC File Offset: 0x00452BAC
			public Toggle m_lifeToggle
			{
				get
				{
					return this.m_owner.m_lifeToggle;
				}
				set
				{
					this.m_owner.m_lifeToggle = value;
				}
			}

			// Token: 0x1700338C RID: 13196
			// (get) Token: 0x06010ACD RID: 68301 RVA: 0x004549BC File Offset: 0x00452BBC
			// (set) Token: 0x06010ACE RID: 68302 RVA: 0x004549CC File Offset: 0x00452BCC
			public GameObject m_lifeToggleClickRedMark
			{
				get
				{
					return this.m_owner.m_lifeToggleClickRedMark;
				}
				set
				{
					this.m_owner.m_lifeToggleClickRedMark = value;
				}
			}

			// Token: 0x1700338D RID: 13197
			// (get) Token: 0x06010ACF RID: 68303 RVA: 0x004549DC File Offset: 0x00452BDC
			// (set) Token: 0x06010AD0 RID: 68304 RVA: 0x004549EC File Offset: 0x00452BEC
			public Button m_equipMaskButton
			{
				get
				{
					return this.m_owner.m_equipMaskButton;
				}
				set
				{
					this.m_owner.m_equipMaskButton = value;
				}
			}

			// Token: 0x1700338E RID: 13198
			// (get) Token: 0x06010AD1 RID: 68305 RVA: 0x004549FC File Offset: 0x00452BFC
			// (set) Token: 0x06010AD2 RID: 68306 RVA: 0x00454A0C File Offset: 0x00452C0C
			public Button m_jobTransferButton
			{
				get
				{
					return this.m_owner.m_jobTransferButton;
				}
				set
				{
					this.m_owner.m_jobTransferButton = value;
				}
			}

			// Token: 0x1700338F RID: 13199
			// (get) Token: 0x06010AD3 RID: 68307 RVA: 0x00454A1C File Offset: 0x00452C1C
			// (set) Token: 0x06010AD4 RID: 68308 RVA: 0x00454A2C File Offset: 0x00452C2C
			public GameObject m_jobTransferButtonRedIcon
			{
				get
				{
					return this.m_owner.m_jobTransferButtonRedIcon;
				}
				set
				{
					this.m_owner.m_jobTransferButtonRedIcon = value;
				}
			}

			// Token: 0x17003390 RID: 13200
			// (get) Token: 0x06010AD5 RID: 68309 RVA: 0x00454A3C File Offset: 0x00452C3C
			// (set) Token: 0x06010AD6 RID: 68310 RVA: 0x00454A4C File Offset: 0x00452C4C
			public GameObject m_jobTransferButtonPressEffect
			{
				get
				{
					return this.m_owner.m_jobTransferButtonPressEffect;
				}
				set
				{
					this.m_owner.m_jobTransferButtonPressEffect = value;
				}
			}

			// Token: 0x17003391 RID: 13201
			// (get) Token: 0x06010AD7 RID: 68311 RVA: 0x00454A5C File Offset: 0x00452C5C
			// (set) Token: 0x06010AD8 RID: 68312 RVA: 0x00454A6C File Offset: 0x00452C6C
			public GameObject m_jobTransferButtonReadyEffect
			{
				get
				{
					return this.m_owner.m_jobTransferButtonReadyEffect;
				}
				set
				{
					this.m_owner.m_jobTransferButtonReadyEffect = value;
				}
			}

			// Token: 0x17003392 RID: 13202
			// (get) Token: 0x06010AD9 RID: 68313 RVA: 0x00454A7C File Offset: 0x00452C7C
			// (set) Token: 0x06010ADA RID: 68314 RVA: 0x00454A8C File Offset: 0x00452C8C
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

			// Token: 0x17003393 RID: 13203
			// (get) Token: 0x06010ADB RID: 68315 RVA: 0x00454A9C File Offset: 0x00452C9C
			// (set) Token: 0x06010ADC RID: 68316 RVA: 0x00454AAC File Offset: 0x00452CAC
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

			// Token: 0x17003394 RID: 13204
			// (get) Token: 0x06010ADD RID: 68317 RVA: 0x00454ABC File Offset: 0x00452CBC
			// (set) Token: 0x06010ADE RID: 68318 RVA: 0x00454ACC File Offset: 0x00452CCC
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

			// Token: 0x06010ADF RID: 68319 RVA: 0x00454ADC File Offset: 0x00452CDC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010AE0 RID: 68320 RVA: 0x00454AEC File Offset: 0x00452CEC
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06010AE1 RID: 68321 RVA: 0x00454AFC File Offset: 0x00452CFC
			public void OnLeftButtonClick()
			{
				this.m_owner.OnLeftButtonClick();
			}

			// Token: 0x06010AE2 RID: 68322 RVA: 0x00454B0C File Offset: 0x00452D0C
			public void OnRightButtonClick()
			{
				this.m_owner.OnRightButtonClick();
			}

			// Token: 0x06010AE3 RID: 68323 RVA: 0x00454B1C File Offset: 0x00452D1C
			public void OnJobTransferButtonClick()
			{
				this.m_owner.OnJobTransferButtonClick();
			}

			// Token: 0x06010AE4 RID: 68324 RVA: 0x00454B2C File Offset: 0x00452D2C
			public IEnumerator OnJobTransferButtonClickEffect()
			{
				return this.m_owner.OnJobTransferButtonClickEffect();
			}

			// Token: 0x06010AE5 RID: 68325 RVA: 0x00454B3C File Offset: 0x00452D3C
			public void OnMaskButtonForUserGuideClick()
			{
				this.m_owner.OnMaskButtonForUserGuideClick();
			}

			// Token: 0x06010AE6 RID: 68326 RVA: 0x00454B4C File Offset: 0x00452D4C
			public void OnInfoToggleValueChanged(bool on)
			{
				this.m_owner.OnInfoToggleValueChanged(on);
			}

			// Token: 0x06010AE7 RID: 68327 RVA: 0x00454B5C File Offset: 0x00452D5C
			public void OnJobToggleValueChanged(bool on)
			{
				this.m_owner.OnJobToggleValueChanged(on);
			}

			// Token: 0x06010AE8 RID: 68328 RVA: 0x00454B6C File Offset: 0x00452D6C
			public void OnSoldierToggleValueChanged(bool on)
			{
				this.m_owner.OnSoldierToggleValueChanged(on);
			}

			// Token: 0x06010AE9 RID: 68329 RVA: 0x00454B7C File Offset: 0x00452D7C
			public void OnEquipToggleValueChanged(bool on)
			{
				this.m_owner.OnEquipToggleValueChanged(on);
			}

			// Token: 0x06010AEA RID: 68330 RVA: 0x00454B8C File Offset: 0x00452D8C
			public void OnLifeToggleValueChanged(bool on)
			{
				this.m_owner.OnLifeToggleValueChanged(on);
			}

			// Token: 0x04009A2B RID: 39467
			private HeroDetailUIController m_owner;
		}
	}
}
