using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A9E RID: 2718
	[HotFix]
	public class HeroDragButton : UIControllerBase, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x0600AE4D RID: 44621 RVA: 0x00307DC8 File Offset: 0x00305FC8
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
			this.m_uiStateController = base.GetComponent<CommonUIStateController>();
			Transform transform = base.gameObject.transform.Find("ScoreUp");
			if (transform != null)
			{
				this.m_scoreBonusTagGameObject = transform.gameObject;
			}
			transform = base.gameObject.transform.Find("PowerUp");
			if (transform != null)
			{
				this.m_powerUpTagGameObject = transform.gameObject;
			}
			transform = base.gameObject.transform.Find("CampUp");
			if (transform != null)
			{
				this.m_campUpTagGameObject = transform.gameObject;
			}
		}

		// Token: 0x0600AE4E RID: 44622 RVA: 0x00307EC4 File Offset: 0x003060C4
		public void Destroy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Destroy_hotfix != null)
			{
				this.m_Destroy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnityEngine.Object.Destroy(base.gameObject);
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x00307F30 File Offset: 0x00306130
		public void SetHero(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroBattleHero_hotfix != null)
			{
				this.m_SetHeroBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			if (hero.HeroInfo != null)
			{
				ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
				if (charImageInfo != null)
				{
					this.m_headImage.sprite = AssetUtility.Instance.GetSprite(charImageInfo.RoundHeadImage);
				}
				ConfigDataArmyInfo armyInfo = hero.GetActiveJob().JobConnectionInfo.m_jobInfo.m_armyInfo;
				this.m_armyImage.sprite = AssetUtility.Instance.GetSprite(armyInfo.Icon);
				this.m_levelText.text = hero.Level.ToString();
			}
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x00308038 File Offset: 0x00306238
		public BattleHero GetHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHero_hotfix != null)
			{
				return (BattleHero)this.m_GetHero_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_hero;
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x003080AC File Offset: 0x003062AC
		public void SetPosition(GridPosition p)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPositionGridPosition_hotfix != null)
			{
				this.m_SetPositionGridPosition_hotfix.call(new object[]
				{
					this,
					p
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_position = p;
		}

		// Token: 0x0600AE52 RID: 44626 RVA: 0x00308124 File Offset: 0x00306324
		public GridPosition GetPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPosition_hotfix != null)
			{
				return (GridPosition)this.m_GetPosition_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_position;
		}

		// Token: 0x0600AE53 RID: 44627 RVA: 0x00308198 File Offset: 0x00306398
		public void DisableRaycastTarget()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DisableRaycastTarget_hotfix != null)
			{
				this.m_DisableRaycastTarget_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_headImage.raycastTarget = false;
			this.m_armyImage.raycastTarget = false;
		}

		// Token: 0x0600AE54 RID: 44628 RVA: 0x00308210 File Offset: 0x00306410
		public void SetEnabled(bool enabled)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnabledBoolean_hotfix != null)
			{
				this.m_SetEnabledBoolean_hotfix.call(new object[]
				{
					this,
					enabled
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isEnabled = enabled;
			if (this.m_uiStateController != null)
			{
				this.m_uiStateController.SetToUIState((!enabled) ? "Dark" : "Normal", false, true);
			}
		}

		// Token: 0x0600AE55 RID: 44629 RVA: 0x003082BC File Offset: 0x003064BC
		public bool IsEnabled()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEnabled_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEnabled_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isEnabled;
		}

		// Token: 0x0600AE56 RID: 44630 RVA: 0x00308330 File Offset: 0x00306530
		public void SetTagType(StageActorTagType tagType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTagTypeStageActorTagType_hotfix != null)
			{
				this.m_SetTagTypeStageActorTagType_hotfix.call(new object[]
				{
					this,
					tagType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_scoreBonusTagGameObject != null)
			{
				this.m_scoreBonusTagGameObject.SetActive(tagType == StageActorTagType.ScoreBonus);
			}
			if (this.m_powerUpTagGameObject != null)
			{
				this.m_powerUpTagGameObject.SetActive(tagType == StageActorTagType.PowerUp);
			}
			if (this.m_campUpTagGameObject != null)
			{
				this.m_campUpTagGameObject.SetActive(tagType == StageActorTagType.CampUp);
			}
		}

		// Token: 0x0600AE57 RID: 44631 RVA: 0x00308400 File Offset: 0x00306600
		public void OnPointerDown(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerDownPointerEventData_hotfix != null)
			{
				this.m_OnPointerDownPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_pointerDownId != -1000)
			{
				return;
			}
			this.m_pointerDownId = eventData.pointerId;
			this.m_isDetectingDrag = true;
			this.m_dragEventData = null;
			this.m_pointerDownPosition = eventData.position;
			EventSystem.current.pixelDragThreshold = 10000;
		}

		// Token: 0x0600AE58 RID: 44632 RVA: 0x003084B8 File Offset: 0x003066B8
		public void OnPointerUp(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerUpPointerEventData_hotfix != null)
			{
				this.m_OnPointerUpPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventData.pointerId != this.m_pointerDownId)
			{
				return;
			}
			this.m_pointerDownId = -1000;
			if (this.m_dragEventData != null)
			{
				this.m_dragEventData.position = eventData.position;
				if (eventData.pointerEnter != null && !eventData.pointerEnter.transform.IsChildOf(base.transform))
				{
					this.OnDrop(this.m_dragEventData);
				}
				this.OnEndDrag(this.m_dragEventData);
				this.m_dragEventData = null;
			}
			EventSystem.current.pixelDragThreshold = UIUtility.GetDefaultPixelDragThreshold();
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x003085BC File Offset: 0x003067BC
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_ignoreClick)
			{
				this.m_ignoreClick = false;
			}
			else if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x0600AE5A RID: 44634 RVA: 0x0030865C File Offset: 0x0030685C
		public void CancelDrag()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CancelDrag_hotfix != null)
			{
				this.m_CancelDrag_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_button.interactable = true;
			if (this.m_pointerDownId != -1000)
			{
				this.m_pointerDownId = -1000;
				EventSystem.current.pixelDragThreshold = UIUtility.GetDefaultPixelDragThreshold();
			}
		}

		// Token: 0x0600AE5B RID: 44635 RVA: 0x003086F4 File Offset: 0x003068F4
		private void OnBeginDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBeginDragPointerEventData_hotfix != null)
			{
				this.m_OnBeginDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_button.interactable = false;
			if (this.EventOnBeginDrag != null)
			{
				this.EventOnBeginDrag(this, eventData);
			}
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x00308788 File Offset: 0x00306988
		private void OnEndDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndDragPointerEventData_hotfix != null)
			{
				this.m_OnEndDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_button.interactable = true;
			if (this.EventOnEndDrag != null)
			{
				this.EventOnEndDrag(this, eventData);
			}
		}

		// Token: 0x0600AE5D RID: 44637 RVA: 0x0030881C File Offset: 0x00306A1C
		private void OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDragPointerEventData_hotfix != null)
			{
				this.m_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDrag != null)
			{
				this.EventOnDrag(eventData);
			}
		}

		// Token: 0x0600AE5E RID: 44638 RVA: 0x003088A4 File Offset: 0x00306AA4
		private void OnDrop(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDropPointerEventData_hotfix != null)
			{
				this.m_OnDropPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDrop != null)
			{
				this.EventOnDrop(eventData);
			}
		}

		// Token: 0x0600AE5F RID: 44639 RVA: 0x0030892C File Offset: 0x00306B2C
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_pointerDownId != -1000)
			{
				Vector2 position = Input.mousePosition;
				for (int i = 0; i < Input.touchCount; i++)
				{
					Touch touch = Input.GetTouch(i);
					if (touch.fingerId == this.m_pointerDownId)
					{
						position = touch.position;
						break;
					}
				}
				if (this.m_dragEventData != null)
				{
					this.m_dragEventData.position = position;
					this.OnDrag(this.m_dragEventData);
				}
				else if (this.m_isDetectingDrag)
				{
					Vector2 vector = new Vector2(position.x, position.y) - this.m_pointerDownPosition;
					if (vector.magnitude >= (float)Screen.width * 0.01f)
					{
						float num = Mathf.Atan2(vector.y, Mathf.Abs(vector.x)) * 57.29578f;
						if (num > 15f)
						{
							this.m_dragEventData = new PointerEventData(EventSystem.current);
							this.m_dragEventData.position = position;
							this.OnBeginDrag(this.m_dragEventData);
							this.OnDrag(this.m_dragEventData);
						}
						else
						{
							EventSystem.current.pixelDragThreshold = 0;
						}
						this.m_isDetectingDrag = false;
					}
				}
			}
		}

		// Token: 0x1400020F RID: 527
		// (add) Token: 0x0600AE60 RID: 44640 RVA: 0x00308AC4 File Offset: 0x00306CC4
		// (remove) Token: 0x0600AE61 RID: 44641 RVA: 0x00308B60 File Offset: 0x00306D60
		public event Action<HeroDragButton> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroDragButton> action = this.EventOnClick;
				Action<HeroDragButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroDragButton>>(ref this.EventOnClick, (Action<HeroDragButton>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroDragButton> action = this.EventOnClick;
				Action<HeroDragButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroDragButton>>(ref this.EventOnClick, (Action<HeroDragButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000210 RID: 528
		// (add) Token: 0x0600AE62 RID: 44642 RVA: 0x00308BFC File Offset: 0x00306DFC
		// (remove) Token: 0x0600AE63 RID: 44643 RVA: 0x00308C98 File Offset: 0x00306E98
		public event Action<HeroDragButton, PointerEventData> EventOnBeginDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBeginDragAction`2_hotfix != null)
				{
					this.m_add_EventOnBeginDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroDragButton, PointerEventData> action = this.EventOnBeginDrag;
				Action<HeroDragButton, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroDragButton, PointerEventData>>(ref this.EventOnBeginDrag, (Action<HeroDragButton, PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBeginDragAction`2_hotfix != null)
				{
					this.m_remove_EventOnBeginDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroDragButton, PointerEventData> action = this.EventOnBeginDrag;
				Action<HeroDragButton, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroDragButton, PointerEventData>>(ref this.EventOnBeginDrag, (Action<HeroDragButton, PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000211 RID: 529
		// (add) Token: 0x0600AE64 RID: 44644 RVA: 0x00308D34 File Offset: 0x00306F34
		// (remove) Token: 0x0600AE65 RID: 44645 RVA: 0x00308DD0 File Offset: 0x00306FD0
		public event Action<HeroDragButton, PointerEventData> EventOnEndDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndDragAction`2_hotfix != null)
				{
					this.m_add_EventOnEndDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroDragButton, PointerEventData> action = this.EventOnEndDrag;
				Action<HeroDragButton, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroDragButton, PointerEventData>>(ref this.EventOnEndDrag, (Action<HeroDragButton, PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndDragAction`2_hotfix != null)
				{
					this.m_remove_EventOnEndDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroDragButton, PointerEventData> action = this.EventOnEndDrag;
				Action<HeroDragButton, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroDragButton, PointerEventData>>(ref this.EventOnEndDrag, (Action<HeroDragButton, PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000212 RID: 530
		// (add) Token: 0x0600AE66 RID: 44646 RVA: 0x00308E6C File Offset: 0x0030706C
		// (remove) Token: 0x0600AE67 RID: 44647 RVA: 0x00308F08 File Offset: 0x00307108
		public event Action<PointerEventData> EventOnDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDragAction`1_hotfix != null)
				{
					this.m_add_EventOnDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrag, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDragAction`1_hotfix != null)
				{
					this.m_remove_EventOnDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrag, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000213 RID: 531
		// (add) Token: 0x0600AE68 RID: 44648 RVA: 0x00308FA4 File Offset: 0x003071A4
		// (remove) Token: 0x0600AE69 RID: 44649 RVA: 0x00309040 File Offset: 0x00307240
		public event Action<PointerEventData> EventOnDrop
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDropAction`1_hotfix != null)
				{
					this.m_add_EventOnDropAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrop;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrop, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDropAction`1_hotfix != null)
				{
					this.m_remove_EventOnDropAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrop;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrop, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x0600AE6A RID: 44650 RVA: 0x003090DC File Offset: 0x003072DC
		// (set) Token: 0x0600AE6B RID: 44651 RVA: 0x003090FC File Offset: 0x003072FC
		[DoNotToLua]
		public new HeroDragButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDragButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600AE6C RID: 44652 RVA: 0x00309108 File Offset: 0x00307308
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600AE6D RID: 44653 RVA: 0x00309114 File Offset: 0x00307314
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600AE6E RID: 44654 RVA: 0x0030911C File Offset: 0x0030731C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600AE6F RID: 44655 RVA: 0x00309124 File Offset: 0x00307324
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600AE70 RID: 44656 RVA: 0x00309138 File Offset: 0x00307338
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600AE71 RID: 44657 RVA: 0x00309140 File Offset: 0x00307340
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600AE72 RID: 44658 RVA: 0x0030914C File Offset: 0x0030734C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600AE73 RID: 44659 RVA: 0x00309158 File Offset: 0x00307358
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600AE74 RID: 44660 RVA: 0x00309164 File Offset: 0x00307364
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600AE75 RID: 44661 RVA: 0x00309170 File Offset: 0x00307370
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600AE76 RID: 44662 RVA: 0x0030917C File Offset: 0x0030737C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600AE77 RID: 44663 RVA: 0x00309188 File Offset: 0x00307388
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600AE78 RID: 44664 RVA: 0x00309194 File Offset: 0x00307394
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600AE79 RID: 44665 RVA: 0x003091A0 File Offset: 0x003073A0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600AE7A RID: 44666 RVA: 0x003091AC File Offset: 0x003073AC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600AE7B RID: 44667 RVA: 0x003091B4 File Offset: 0x003073B4
		private void __callDele_EventOnClick(HeroDragButton obj)
		{
			Action<HeroDragButton> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600AE7C RID: 44668 RVA: 0x003091D8 File Offset: 0x003073D8
		private void __clearDele_EventOnClick(HeroDragButton obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600AE7D RID: 44669 RVA: 0x003091E4 File Offset: 0x003073E4
		private void __callDele_EventOnBeginDrag(HeroDragButton arg1, PointerEventData arg2)
		{
			Action<HeroDragButton, PointerEventData> eventOnBeginDrag = this.EventOnBeginDrag;
			if (eventOnBeginDrag != null)
			{
				eventOnBeginDrag(arg1, arg2);
			}
		}

		// Token: 0x0600AE7E RID: 44670 RVA: 0x00309208 File Offset: 0x00307408
		private void __clearDele_EventOnBeginDrag(HeroDragButton arg1, PointerEventData arg2)
		{
			this.EventOnBeginDrag = null;
		}

		// Token: 0x0600AE7F RID: 44671 RVA: 0x00309214 File Offset: 0x00307414
		private void __callDele_EventOnEndDrag(HeroDragButton arg1, PointerEventData arg2)
		{
			Action<HeroDragButton, PointerEventData> eventOnEndDrag = this.EventOnEndDrag;
			if (eventOnEndDrag != null)
			{
				eventOnEndDrag(arg1, arg2);
			}
		}

		// Token: 0x0600AE80 RID: 44672 RVA: 0x00309238 File Offset: 0x00307438
		private void __clearDele_EventOnEndDrag(HeroDragButton arg1, PointerEventData arg2)
		{
			this.EventOnEndDrag = null;
		}

		// Token: 0x0600AE81 RID: 44673 RVA: 0x00309244 File Offset: 0x00307444
		private void __callDele_EventOnDrag(PointerEventData obj)
		{
			Action<PointerEventData> eventOnDrag = this.EventOnDrag;
			if (eventOnDrag != null)
			{
				eventOnDrag(obj);
			}
		}

		// Token: 0x0600AE82 RID: 44674 RVA: 0x00309268 File Offset: 0x00307468
		private void __clearDele_EventOnDrag(PointerEventData obj)
		{
			this.EventOnDrag = null;
		}

		// Token: 0x0600AE83 RID: 44675 RVA: 0x00309274 File Offset: 0x00307474
		private void __callDele_EventOnDrop(PointerEventData obj)
		{
			Action<PointerEventData> eventOnDrop = this.EventOnDrop;
			if (eventOnDrop != null)
			{
				eventOnDrop(obj);
			}
		}

		// Token: 0x0600AE84 RID: 44676 RVA: 0x00309298 File Offset: 0x00307498
		private void __clearDele_EventOnDrop(PointerEventData obj)
		{
			this.EventOnDrop = null;
		}

		// Token: 0x0600AE85 RID: 44677 RVA: 0x003092A4 File Offset: 0x003074A4
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
					this.m_Destroy_hotfix = (luaObj.RawGet("Destroy") as LuaFunction);
					this.m_SetHeroBattleHero_hotfix = (luaObj.RawGet("SetHero") as LuaFunction);
					this.m_GetHero_hotfix = (luaObj.RawGet("GetHero") as LuaFunction);
					this.m_SetPositionGridPosition_hotfix = (luaObj.RawGet("SetPosition") as LuaFunction);
					this.m_GetPosition_hotfix = (luaObj.RawGet("GetPosition") as LuaFunction);
					this.m_DisableRaycastTarget_hotfix = (luaObj.RawGet("DisableRaycastTarget") as LuaFunction);
					this.m_SetEnabledBoolean_hotfix = (luaObj.RawGet("SetEnabled") as LuaFunction);
					this.m_IsEnabled_hotfix = (luaObj.RawGet("IsEnabled") as LuaFunction);
					this.m_SetTagTypeStageActorTagType_hotfix = (luaObj.RawGet("SetTagType") as LuaFunction);
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_CancelDrag_hotfix = (luaObj.RawGet("CancelDrag") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_OnDragPointerEventData_hotfix = (luaObj.RawGet("OnDrag") as LuaFunction);
					this.m_OnDropPointerEventData_hotfix = (luaObj.RawGet("OnDrop") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					this.m_add_EventOnBeginDragAction`2_hotfix = (luaObj.RawGet("add_EventOnBeginDrag") as LuaFunction);
					this.m_remove_EventOnBeginDragAction`2_hotfix = (luaObj.RawGet("remove_EventOnBeginDrag") as LuaFunction);
					this.m_add_EventOnEndDragAction`2_hotfix = (luaObj.RawGet("add_EventOnEndDrag") as LuaFunction);
					this.m_remove_EventOnEndDragAction`2_hotfix = (luaObj.RawGet("remove_EventOnEndDrag") as LuaFunction);
					this.m_add_EventOnDragAction`1_hotfix = (luaObj.RawGet("add_EventOnDrag") as LuaFunction);
					this.m_remove_EventOnDragAction`1_hotfix = (luaObj.RawGet("remove_EventOnDrag") as LuaFunction);
					this.m_add_EventOnDropAction`1_hotfix = (luaObj.RawGet("add_EventOnDrop") as LuaFunction);
					this.m_remove_EventOnDropAction`1_hotfix = (luaObj.RawGet("remove_EventOnDrop") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600AE86 RID: 44678 RVA: 0x0030962C File Offset: 0x0030782C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDragButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007203 RID: 29187
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04007204 RID: 29188
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headImage;

		// Token: 0x04007205 RID: 29189
		[AutoBind("./ArmyIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_armyImage;

		// Token: 0x04007206 RID: 29190
		[AutoBind("./LvGroup/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x04007207 RID: 29191
		private GameObject m_scoreBonusTagGameObject;

		// Token: 0x04007208 RID: 29192
		private GameObject m_powerUpTagGameObject;

		// Token: 0x04007209 RID: 29193
		private GameObject m_campUpTagGameObject;

		// Token: 0x0400720A RID: 29194
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400720B RID: 29195
		private GridPosition m_position;

		// Token: 0x0400720C RID: 29196
		private BattleHero m_hero;

		// Token: 0x0400720D RID: 29197
		private bool m_isEnabled;

		// Token: 0x0400720E RID: 29198
		private const int InvalidPointerDownID = -1000;

		// Token: 0x0400720F RID: 29199
		private int m_pointerDownId = -1000;

		// Token: 0x04007210 RID: 29200
		private bool m_isDetectingDrag;

		// Token: 0x04007211 RID: 29201
		private bool m_ignoreClick;

		// Token: 0x04007212 RID: 29202
		private Vector2 m_pointerDownPosition;

		// Token: 0x04007213 RID: 29203
		private PointerEventData m_dragEventData;

		// Token: 0x04007214 RID: 29204
		[DoNotToLua]
		private HeroDragButton.LuaExportHelper luaExportHelper;

		// Token: 0x04007215 RID: 29205
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007216 RID: 29206
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007217 RID: 29207
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007218 RID: 29208
		private LuaFunction m_Destroy_hotfix;

		// Token: 0x04007219 RID: 29209
		private LuaFunction m_SetHeroBattleHero_hotfix;

		// Token: 0x0400721A RID: 29210
		private LuaFunction m_GetHero_hotfix;

		// Token: 0x0400721B RID: 29211
		private LuaFunction m_SetPositionGridPosition_hotfix;

		// Token: 0x0400721C RID: 29212
		private LuaFunction m_GetPosition_hotfix;

		// Token: 0x0400721D RID: 29213
		private LuaFunction m_DisableRaycastTarget_hotfix;

		// Token: 0x0400721E RID: 29214
		private LuaFunction m_SetEnabledBoolean_hotfix;

		// Token: 0x0400721F RID: 29215
		private LuaFunction m_IsEnabled_hotfix;

		// Token: 0x04007220 RID: 29216
		private LuaFunction m_SetTagTypeStageActorTagType_hotfix;

		// Token: 0x04007221 RID: 29217
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x04007222 RID: 29218
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x04007223 RID: 29219
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x04007224 RID: 29220
		private LuaFunction m_CancelDrag_hotfix;

		// Token: 0x04007225 RID: 29221
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x04007226 RID: 29222
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x04007227 RID: 29223
		private LuaFunction m_OnDragPointerEventData_hotfix;

		// Token: 0x04007228 RID: 29224
		private LuaFunction m_OnDropPointerEventData_hotfix;

		// Token: 0x04007229 RID: 29225
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400722A RID: 29226
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400722B RID: 29227
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x0400722C RID: 29228
		private LuaFunction m_add_EventOnBeginDragAction;

		// Token: 0x0400722D RID: 29229
		private LuaFunction m_remove_EventOnBeginDragAction;

		// Token: 0x0400722E RID: 29230
		private LuaFunction m_add_EventOnEndDragAction;

		// Token: 0x0400722F RID: 29231
		private LuaFunction m_remove_EventOnEndDragAction;

		// Token: 0x04007230 RID: 29232
		private LuaFunction m_add_EventOnDragAction;

		// Token: 0x04007231 RID: 29233
		private LuaFunction m_remove_EventOnDragAction;

		// Token: 0x04007232 RID: 29234
		private LuaFunction m_add_EventOnDropAction;

		// Token: 0x04007233 RID: 29235
		private LuaFunction m_remove_EventOnDropAction;

		// Token: 0x02000A9F RID: 2719
		public new class LuaExportHelper
		{
			// Token: 0x0600AE87 RID: 44679 RVA: 0x00309694 File Offset: 0x00307894
			public LuaExportHelper(HeroDragButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600AE88 RID: 44680 RVA: 0x003096A4 File Offset: 0x003078A4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600AE89 RID: 44681 RVA: 0x003096B4 File Offset: 0x003078B4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600AE8A RID: 44682 RVA: 0x003096C4 File Offset: 0x003078C4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600AE8B RID: 44683 RVA: 0x003096D4 File Offset: 0x003078D4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600AE8C RID: 44684 RVA: 0x003096EC File Offset: 0x003078EC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600AE8D RID: 44685 RVA: 0x003096FC File Offset: 0x003078FC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600AE8E RID: 44686 RVA: 0x0030970C File Offset: 0x0030790C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600AE8F RID: 44687 RVA: 0x0030971C File Offset: 0x0030791C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600AE90 RID: 44688 RVA: 0x0030972C File Offset: 0x0030792C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600AE91 RID: 44689 RVA: 0x0030973C File Offset: 0x0030793C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600AE92 RID: 44690 RVA: 0x0030974C File Offset: 0x0030794C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600AE93 RID: 44691 RVA: 0x0030975C File Offset: 0x0030795C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600AE94 RID: 44692 RVA: 0x0030976C File Offset: 0x0030796C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600AE95 RID: 44693 RVA: 0x0030977C File Offset: 0x0030797C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600AE96 RID: 44694 RVA: 0x0030978C File Offset: 0x0030798C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600AE97 RID: 44695 RVA: 0x0030979C File Offset: 0x0030799C
			public void __callDele_EventOnClick(HeroDragButton obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600AE98 RID: 44696 RVA: 0x003097AC File Offset: 0x003079AC
			public void __clearDele_EventOnClick(HeroDragButton obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x0600AE99 RID: 44697 RVA: 0x003097BC File Offset: 0x003079BC
			public void __callDele_EventOnBeginDrag(HeroDragButton arg1, PointerEventData arg2)
			{
				this.m_owner.__callDele_EventOnBeginDrag(arg1, arg2);
			}

			// Token: 0x0600AE9A RID: 44698 RVA: 0x003097CC File Offset: 0x003079CC
			public void __clearDele_EventOnBeginDrag(HeroDragButton arg1, PointerEventData arg2)
			{
				this.m_owner.__clearDele_EventOnBeginDrag(arg1, arg2);
			}

			// Token: 0x0600AE9B RID: 44699 RVA: 0x003097DC File Offset: 0x003079DC
			public void __callDele_EventOnEndDrag(HeroDragButton arg1, PointerEventData arg2)
			{
				this.m_owner.__callDele_EventOnEndDrag(arg1, arg2);
			}

			// Token: 0x0600AE9C RID: 44700 RVA: 0x003097EC File Offset: 0x003079EC
			public void __clearDele_EventOnEndDrag(HeroDragButton arg1, PointerEventData arg2)
			{
				this.m_owner.__clearDele_EventOnEndDrag(arg1, arg2);
			}

			// Token: 0x0600AE9D RID: 44701 RVA: 0x003097FC File Offset: 0x003079FC
			public void __callDele_EventOnDrag(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnDrag(obj);
			}

			// Token: 0x0600AE9E RID: 44702 RVA: 0x0030980C File Offset: 0x00307A0C
			public void __clearDele_EventOnDrag(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnDrag(obj);
			}

			// Token: 0x0600AE9F RID: 44703 RVA: 0x0030981C File Offset: 0x00307A1C
			public void __callDele_EventOnDrop(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnDrop(obj);
			}

			// Token: 0x0600AEA0 RID: 44704 RVA: 0x0030982C File Offset: 0x00307A2C
			public void __clearDele_EventOnDrop(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnDrop(obj);
			}

			// Token: 0x17002362 RID: 9058
			// (get) Token: 0x0600AEA1 RID: 44705 RVA: 0x0030983C File Offset: 0x00307A3C
			// (set) Token: 0x0600AEA2 RID: 44706 RVA: 0x0030984C File Offset: 0x00307A4C
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x17002363 RID: 9059
			// (get) Token: 0x0600AEA3 RID: 44707 RVA: 0x0030985C File Offset: 0x00307A5C
			// (set) Token: 0x0600AEA4 RID: 44708 RVA: 0x0030986C File Offset: 0x00307A6C
			public Image m_headImage
			{
				get
				{
					return this.m_owner.m_headImage;
				}
				set
				{
					this.m_owner.m_headImage = value;
				}
			}

			// Token: 0x17002364 RID: 9060
			// (get) Token: 0x0600AEA5 RID: 44709 RVA: 0x0030987C File Offset: 0x00307A7C
			// (set) Token: 0x0600AEA6 RID: 44710 RVA: 0x0030988C File Offset: 0x00307A8C
			public Image m_armyImage
			{
				get
				{
					return this.m_owner.m_armyImage;
				}
				set
				{
					this.m_owner.m_armyImage = value;
				}
			}

			// Token: 0x17002365 RID: 9061
			// (get) Token: 0x0600AEA7 RID: 44711 RVA: 0x0030989C File Offset: 0x00307A9C
			// (set) Token: 0x0600AEA8 RID: 44712 RVA: 0x003098AC File Offset: 0x00307AAC
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x17002366 RID: 9062
			// (get) Token: 0x0600AEA9 RID: 44713 RVA: 0x003098BC File Offset: 0x00307ABC
			// (set) Token: 0x0600AEAA RID: 44714 RVA: 0x003098CC File Offset: 0x00307ACC
			public GameObject m_scoreBonusTagGameObject
			{
				get
				{
					return this.m_owner.m_scoreBonusTagGameObject;
				}
				set
				{
					this.m_owner.m_scoreBonusTagGameObject = value;
				}
			}

			// Token: 0x17002367 RID: 9063
			// (get) Token: 0x0600AEAB RID: 44715 RVA: 0x003098DC File Offset: 0x00307ADC
			// (set) Token: 0x0600AEAC RID: 44716 RVA: 0x003098EC File Offset: 0x00307AEC
			public GameObject m_powerUpTagGameObject
			{
				get
				{
					return this.m_owner.m_powerUpTagGameObject;
				}
				set
				{
					this.m_owner.m_powerUpTagGameObject = value;
				}
			}

			// Token: 0x17002368 RID: 9064
			// (get) Token: 0x0600AEAD RID: 44717 RVA: 0x003098FC File Offset: 0x00307AFC
			// (set) Token: 0x0600AEAE RID: 44718 RVA: 0x0030990C File Offset: 0x00307B0C
			public GameObject m_campUpTagGameObject
			{
				get
				{
					return this.m_owner.m_campUpTagGameObject;
				}
				set
				{
					this.m_owner.m_campUpTagGameObject = value;
				}
			}

			// Token: 0x17002369 RID: 9065
			// (get) Token: 0x0600AEAF RID: 44719 RVA: 0x0030991C File Offset: 0x00307B1C
			// (set) Token: 0x0600AEB0 RID: 44720 RVA: 0x0030992C File Offset: 0x00307B2C
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x1700236A RID: 9066
			// (get) Token: 0x0600AEB1 RID: 44721 RVA: 0x0030993C File Offset: 0x00307B3C
			// (set) Token: 0x0600AEB2 RID: 44722 RVA: 0x0030994C File Offset: 0x00307B4C
			public GridPosition m_position
			{
				get
				{
					return this.m_owner.m_position;
				}
				set
				{
					this.m_owner.m_position = value;
				}
			}

			// Token: 0x1700236B RID: 9067
			// (get) Token: 0x0600AEB3 RID: 44723 RVA: 0x0030995C File Offset: 0x00307B5C
			// (set) Token: 0x0600AEB4 RID: 44724 RVA: 0x0030996C File Offset: 0x00307B6C
			public BattleHero m_hero
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

			// Token: 0x1700236C RID: 9068
			// (get) Token: 0x0600AEB5 RID: 44725 RVA: 0x0030997C File Offset: 0x00307B7C
			// (set) Token: 0x0600AEB6 RID: 44726 RVA: 0x0030998C File Offset: 0x00307B8C
			public bool m_isEnabled
			{
				get
				{
					return this.m_owner.m_isEnabled;
				}
				set
				{
					this.m_owner.m_isEnabled = value;
				}
			}

			// Token: 0x1700236D RID: 9069
			// (get) Token: 0x0600AEB7 RID: 44727 RVA: 0x0030999C File Offset: 0x00307B9C
			public static int InvalidPointerDownID
			{
				get
				{
					return -1000;
				}
			}

			// Token: 0x1700236E RID: 9070
			// (get) Token: 0x0600AEB8 RID: 44728 RVA: 0x003099A4 File Offset: 0x00307BA4
			// (set) Token: 0x0600AEB9 RID: 44729 RVA: 0x003099B4 File Offset: 0x00307BB4
			public int m_pointerDownId
			{
				get
				{
					return this.m_owner.m_pointerDownId;
				}
				set
				{
					this.m_owner.m_pointerDownId = value;
				}
			}

			// Token: 0x1700236F RID: 9071
			// (get) Token: 0x0600AEBA RID: 44730 RVA: 0x003099C4 File Offset: 0x00307BC4
			// (set) Token: 0x0600AEBB RID: 44731 RVA: 0x003099D4 File Offset: 0x00307BD4
			public bool m_isDetectingDrag
			{
				get
				{
					return this.m_owner.m_isDetectingDrag;
				}
				set
				{
					this.m_owner.m_isDetectingDrag = value;
				}
			}

			// Token: 0x17002370 RID: 9072
			// (get) Token: 0x0600AEBC RID: 44732 RVA: 0x003099E4 File Offset: 0x00307BE4
			// (set) Token: 0x0600AEBD RID: 44733 RVA: 0x003099F4 File Offset: 0x00307BF4
			public bool m_ignoreClick
			{
				get
				{
					return this.m_owner.m_ignoreClick;
				}
				set
				{
					this.m_owner.m_ignoreClick = value;
				}
			}

			// Token: 0x17002371 RID: 9073
			// (get) Token: 0x0600AEBE RID: 44734 RVA: 0x00309A04 File Offset: 0x00307C04
			// (set) Token: 0x0600AEBF RID: 44735 RVA: 0x00309A14 File Offset: 0x00307C14
			public Vector2 m_pointerDownPosition
			{
				get
				{
					return this.m_owner.m_pointerDownPosition;
				}
				set
				{
					this.m_owner.m_pointerDownPosition = value;
				}
			}

			// Token: 0x17002372 RID: 9074
			// (get) Token: 0x0600AEC0 RID: 44736 RVA: 0x00309A24 File Offset: 0x00307C24
			// (set) Token: 0x0600AEC1 RID: 44737 RVA: 0x00309A34 File Offset: 0x00307C34
			public PointerEventData m_dragEventData
			{
				get
				{
					return this.m_owner.m_dragEventData;
				}
				set
				{
					this.m_owner.m_dragEventData = value;
				}
			}

			// Token: 0x0600AEC2 RID: 44738 RVA: 0x00309A44 File Offset: 0x00307C44
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600AEC3 RID: 44739 RVA: 0x00309A54 File Offset: 0x00307C54
			public void OnBeginDrag(PointerEventData eventData)
			{
				this.m_owner.OnBeginDrag(eventData);
			}

			// Token: 0x0600AEC4 RID: 44740 RVA: 0x00309A64 File Offset: 0x00307C64
			public void OnEndDrag(PointerEventData eventData)
			{
				this.m_owner.OnEndDrag(eventData);
			}

			// Token: 0x0600AEC5 RID: 44741 RVA: 0x00309A74 File Offset: 0x00307C74
			public void OnDrag(PointerEventData eventData)
			{
				this.m_owner.OnDrag(eventData);
			}

			// Token: 0x0600AEC6 RID: 44742 RVA: 0x00309A84 File Offset: 0x00307C84
			public void OnDrop(PointerEventData eventData)
			{
				this.m_owner.OnDrop(eventData);
			}

			// Token: 0x0600AEC7 RID: 44743 RVA: 0x00309A94 File Offset: 0x00307C94
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x04007234 RID: 29236
			private HeroDragButton m_owner;
		}
	}
}
