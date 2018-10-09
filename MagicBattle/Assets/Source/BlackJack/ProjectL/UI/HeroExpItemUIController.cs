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
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D95 RID: 3477
	[HotFix]
	public class HeroExpItemUIController : UIControllerBase, IPointerDownHandler, IPointerUpHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IEventSystemHandler
	{
		// Token: 0x06010459 RID: 66649 RVA: 0x0043FF40 File Offset: 0x0043E140
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
		}

		// Token: 0x0601045A RID: 66650 RVA: 0x0043FFA8 File Offset: 0x0043E1A8
		public void InitExpItem(BagItemBase bagItem, float delay, float interval, Action eventOnLongPress)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitExpItemBagItemBaseSingleSingleAction_hotfix != null)
			{
				this.m_InitExpItemBagItemBaseSingleSingleAction_hotfix.call(new object[]
				{
					this,
					bagItem,
					delay,
					interval,
					eventOnLongPress
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.BagItem = bagItem;
			ConfigDataItemInfo itemInfo = bagItem.ItemInfo;
			if (itemInfo != null)
			{
				this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(itemInfo.Icon);
				this.m_frameImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(itemInfo.Rank));
			}
			this.m_countText.text = bagItem.Nums.ToString();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.AddExpValue = projectLPlayerContext.GetAdditiveHeroAddExp(itemInfo.FuncTypeParam1);
			this.Interval = interval;
			this.Delay = delay;
			this.EventOnLongPress = eventOnLongPress;
		}

		// Token: 0x0601045B RID: 66651 RVA: 0x004400FC File Offset: 0x0043E2FC
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
			if (this.IsPointDown && !this.m_isDragging)
			{
				if ((this.m_delay -= Time.deltaTime) > 0f)
				{
					return;
				}
				if (this.m_startPressTime == 0f)
				{
					this.m_startPressTime = Time.time;
				}
				else if (Time.time - this.m_startPressTime >= 1f)
				{
					this.Interval /= 10f;
					this.m_startPressTime = float.MaxValue;
				}
				if (Time.time - this.m_lastInvokeTime > this.Interval)
				{
					if (this.EventOnLongPress != null)
					{
						this.EventOnLongPress();
						this.usedCount++;
						this.m_countText.text = (this.BagItem.Nums - this.usedCount).ToString();
						if (this.BagItem.Nums - this.usedCount <= 0 || !this.IsPointDown)
						{
							this.IsPointDown = false;
							return;
						}
					}
					this.m_lastInvokeTime = Time.time;
				}
			}
		}

		// Token: 0x0601045C RID: 66652 RVA: 0x00440284 File Offset: 0x0043E484
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
			this.IsPointDown = true;
			this.m_delay = this.Delay;
			this.usedCount = 0;
			this.m_startPressTime = 0f;
			if (this.OnItemPointDown != null)
			{
				this.OnItemPointDown(this);
			}
		}

		// Token: 0x0601045D RID: 66653 RVA: 0x00440330 File Offset: 0x0043E530
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
			this.IsPointDown = false;
			if (this.OnItemPointUp != null && !this.m_isDragging)
			{
				if (this.usedCount == 0)
				{
					this.OnItemPointUp(1);
				}
				else
				{
					this.OnItemPointUp(this.usedCount);
				}
			}
			this.m_startPressTime = 0f;
		}

		// Token: 0x0601045E RID: 66654 RVA: 0x004403F8 File Offset: 0x0043E5F8
		public void OnBeginDrag(PointerEventData eventData)
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
			if (this.usedCount == 0)
			{
				this.PassEvent<IBeginDragHandler>(eventData, ExecuteEvents.beginDragHandler);
			}
		}

		// Token: 0x0601045F RID: 66655 RVA: 0x00440480 File Offset: 0x0043E680
		public void OnDrag(PointerEventData eventData)
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
			if (this.usedCount == 0)
			{
				this.PassEvent<IDragHandler>(eventData, ExecuteEvents.dragHandler);
			}
		}

		// Token: 0x06010460 RID: 66656 RVA: 0x00440508 File Offset: 0x0043E708
		public void OnEndDrag(PointerEventData eventData)
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
			if (this.usedCount == 0)
			{
				this.PassEvent<IEndDragHandler>(eventData, ExecuteEvents.endDragHandler);
			}
		}

		// Token: 0x06010461 RID: 66657 RVA: 0x00440590 File Offset: 0x0043E790
		public void PassEvent<T>(PointerEventData data, ExecuteEvents.EventFunction<T> function) where T : IEventSystemHandler
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PassEventPointerEventDataEventFunction`1_hotfix != null)
			{
				this.m_PassEventPointerEventDataEventFunction`1_hotfix.call(new object[]
				{
					this,
					data,
					function
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<RaycastResult> list = new List<RaycastResult>();
			EventSystem.current.RaycastAll(data, list);
			GameObject gameObject = data.pointerCurrentRaycast.gameObject;
			if (gameObject == null && list.Count == 0 && this.m_draggingGo != null)
			{
				ExecuteEvents.ExecuteHierarchy<T>(this.m_draggingGo, data, function);
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				if (gameObject != list[i].gameObject)
				{
					if (!list[i].gameObject.transform.IsChildOf(base.gameObject.transform))
					{
						GameObject root;
						if (typeof(T) == typeof(IBeginDragHandler))
						{
							this.m_draggingGo = list[i].gameObject;
							root = this.m_draggingGo;
							this.m_isDragging = (this.m_draggingGo.GetComponentInParent<ScrollRect>() != null);
						}
						else if (typeof(T) == typeof(IDragHandler))
						{
							root = this.m_draggingGo;
						}
						else if (typeof(T) == typeof(IEndDragHandler))
						{
							this.m_isDragging = false;
							root = this.m_draggingGo;
							this.m_draggingGo = null;
						}
						else
						{
							root = list[i].gameObject;
						}
						ExecuteEvents.ExecuteHierarchy<T>(root, data, function);
						break;
					}
				}
			}
		}

		// Token: 0x1400036D RID: 877
		// (add) Token: 0x06010462 RID: 66658 RVA: 0x0044079C File Offset: 0x0043E99C
		// (remove) Token: 0x06010463 RID: 66659 RVA: 0x00440838 File Offset: 0x0043EA38
		public event Action<int> OnItemPointUp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_OnItemPointUpAction`1_hotfix != null)
				{
					this.m_add_OnItemPointUpAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.OnItemPointUp;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.OnItemPointUp, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_OnItemPointUpAction`1_hotfix != null)
				{
					this.m_remove_OnItemPointUpAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.OnItemPointUp;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.OnItemPointUp, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400036E RID: 878
		// (add) Token: 0x06010464 RID: 66660 RVA: 0x004408D4 File Offset: 0x0043EAD4
		// (remove) Token: 0x06010465 RID: 66661 RVA: 0x00440970 File Offset: 0x0043EB70
		public event Action<HeroExpItemUIController> OnItemPointDown
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_OnItemPointDownAction`1_hotfix != null)
				{
					this.m_add_OnItemPointDownAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroExpItemUIController> action = this.OnItemPointDown;
				Action<HeroExpItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroExpItemUIController>>(ref this.OnItemPointDown, (Action<HeroExpItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_OnItemPointDownAction`1_hotfix != null)
				{
					this.m_remove_OnItemPointDownAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroExpItemUIController> action = this.OnItemPointDown;
				Action<HeroExpItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroExpItemUIController>>(ref this.OnItemPointDown, (Action<HeroExpItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x06010467 RID: 66663 RVA: 0x00440A84 File Offset: 0x0043EC84
		// (set) Token: 0x06010466 RID: 66662 RVA: 0x00440A0C File Offset: 0x0043EC0C
		public BagItemBase BagItem
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_BagItem_hotfix != null)
				{
					return (BagItemBase)this.m_get_BagItem_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<BagItem>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_BagItemBagItemBase_hotfix != null)
				{
					this.m_set_BagItemBagItemBase_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<BagItem>k__BackingField = value;
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x06010469 RID: 66665 RVA: 0x00440B70 File Offset: 0x0043ED70
		// (set) Token: 0x06010468 RID: 66664 RVA: 0x00440AF8 File Offset: 0x0043ECF8
		public int AddExpValue
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_AddExpValue_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_AddExpValue_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<AddExpValue>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_AddExpValueInt32_hotfix != null)
				{
					this.m_set_AddExpValueInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<AddExpValue>k__BackingField = value;
			}
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0601046A RID: 66666 RVA: 0x00440BE4 File Offset: 0x0043EDE4
		// (set) Token: 0x0601046B RID: 66667 RVA: 0x00440C58 File Offset: 0x0043EE58
		public float Interval
		{
			[CompilerGenerated]
			private get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Interval_hotfix != null)
				{
					return Convert.ToSingle(this.m_get_Interval_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Interval>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IntervalSingle_hotfix != null)
				{
					this.m_set_IntervalSingle_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Interval>k__BackingField = value;
			}
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0601046C RID: 66668 RVA: 0x00440CD0 File Offset: 0x0043EED0
		// (set) Token: 0x0601046D RID: 66669 RVA: 0x00440D44 File Offset: 0x0043EF44
		public float Delay
		{
			[CompilerGenerated]
			private get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Delay_hotfix != null)
				{
					return Convert.ToSingle(this.m_get_Delay_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Delay>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_DelaySingle_hotfix != null)
				{
					this.m_set_DelaySingle_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Delay>k__BackingField = value;
			}
		}

		// Token: 0x1400036F RID: 879
		// (add) Token: 0x0601046E RID: 66670 RVA: 0x00440DBC File Offset: 0x0043EFBC
		// (remove) Token: 0x0601046F RID: 66671 RVA: 0x00440E58 File Offset: 0x0043F058
		public event Action EventOnLongPress
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnLongPressAction_hotfix != null)
				{
					this.m_add_EventOnLongPressAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnLongPress;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnLongPress, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnLongPressAction_hotfix != null)
				{
					this.m_remove_EventOnLongPressAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnLongPress;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnLongPress, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x06010470 RID: 66672 RVA: 0x00440EF4 File Offset: 0x0043F0F4
		// (set) Token: 0x06010471 RID: 66673 RVA: 0x00440F14 File Offset: 0x0043F114
		[DoNotToLua]
		public new HeroExpItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroExpItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010472 RID: 66674 RVA: 0x00440F20 File Offset: 0x0043F120
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010473 RID: 66675 RVA: 0x00440F2C File Offset: 0x0043F12C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010474 RID: 66676 RVA: 0x00440F34 File Offset: 0x0043F134
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010475 RID: 66677 RVA: 0x00440F3C File Offset: 0x0043F13C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010476 RID: 66678 RVA: 0x00440F50 File Offset: 0x0043F150
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010477 RID: 66679 RVA: 0x00440F58 File Offset: 0x0043F158
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010478 RID: 66680 RVA: 0x00440F64 File Offset: 0x0043F164
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010479 RID: 66681 RVA: 0x00440F70 File Offset: 0x0043F170
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601047A RID: 66682 RVA: 0x00440F7C File Offset: 0x0043F17C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601047B RID: 66683 RVA: 0x00440F88 File Offset: 0x0043F188
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601047C RID: 66684 RVA: 0x00440F94 File Offset: 0x0043F194
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601047D RID: 66685 RVA: 0x00440FA0 File Offset: 0x0043F1A0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601047E RID: 66686 RVA: 0x00440FAC File Offset: 0x0043F1AC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601047F RID: 66687 RVA: 0x00440FB8 File Offset: 0x0043F1B8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010480 RID: 66688 RVA: 0x00440FC4 File Offset: 0x0043F1C4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010481 RID: 66689 RVA: 0x00440FCC File Offset: 0x0043F1CC
		private void __callDele_OnItemPointUp(int obj)
		{
			Action<int> onItemPointUp = this.OnItemPointUp;
			if (onItemPointUp != null)
			{
				onItemPointUp(obj);
			}
		}

		// Token: 0x06010482 RID: 66690 RVA: 0x00440FF0 File Offset: 0x0043F1F0
		private void __clearDele_OnItemPointUp(int obj)
		{
			this.OnItemPointUp = null;
		}

		// Token: 0x06010483 RID: 66691 RVA: 0x00440FFC File Offset: 0x0043F1FC
		private void __callDele_OnItemPointDown(HeroExpItemUIController obj)
		{
			Action<HeroExpItemUIController> onItemPointDown = this.OnItemPointDown;
			if (onItemPointDown != null)
			{
				onItemPointDown(obj);
			}
		}

		// Token: 0x06010484 RID: 66692 RVA: 0x00441020 File Offset: 0x0043F220
		private void __clearDele_OnItemPointDown(HeroExpItemUIController obj)
		{
			this.OnItemPointDown = null;
		}

		// Token: 0x06010485 RID: 66693 RVA: 0x0044102C File Offset: 0x0043F22C
		private void __callDele_EventOnLongPress()
		{
			Action eventOnLongPress = this.EventOnLongPress;
			if (eventOnLongPress != null)
			{
				eventOnLongPress();
			}
		}

		// Token: 0x06010486 RID: 66694 RVA: 0x0044104C File Offset: 0x0043F24C
		private void __clearDele_EventOnLongPress()
		{
			this.EventOnLongPress = null;
		}

		// Token: 0x06010487 RID: 66695 RVA: 0x00441058 File Offset: 0x0043F258
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
					this.m_InitExpItemBagItemBaseSingleSingleAction_hotfix = (luaObj.RawGet("InitExpItem") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnDragPointerEventData_hotfix = (luaObj.RawGet("OnDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_PassEventPointerEventDataEventFunction`1_hotfix = (luaObj.RawGet("PassEvent") as LuaFunction);
					this.m_add_OnItemPointUpAction`1_hotfix = (luaObj.RawGet("add_OnItemPointUp") as LuaFunction);
					this.m_remove_OnItemPointUpAction`1_hotfix = (luaObj.RawGet("remove_OnItemPointUp") as LuaFunction);
					this.m_add_OnItemPointDownAction`1_hotfix = (luaObj.RawGet("add_OnItemPointDown") as LuaFunction);
					this.m_remove_OnItemPointDownAction`1_hotfix = (luaObj.RawGet("remove_OnItemPointDown") as LuaFunction);
					this.m_set_BagItemBagItemBase_hotfix = (luaObj.RawGet("set_BagItem") as LuaFunction);
					this.m_get_BagItem_hotfix = (luaObj.RawGet("get_BagItem") as LuaFunction);
					this.m_set_AddExpValueInt32_hotfix = (luaObj.RawGet("set_AddExpValue") as LuaFunction);
					this.m_get_AddExpValue_hotfix = (luaObj.RawGet("get_AddExpValue") as LuaFunction);
					this.m_get_Interval_hotfix = (luaObj.RawGet("get_Interval") as LuaFunction);
					this.m_set_IntervalSingle_hotfix = (luaObj.RawGet("set_Interval") as LuaFunction);
					this.m_get_Delay_hotfix = (luaObj.RawGet("get_Delay") as LuaFunction);
					this.m_set_DelaySingle_hotfix = (luaObj.RawGet("set_Delay") as LuaFunction);
					this.m_add_EventOnLongPressAction_hotfix = (luaObj.RawGet("add_EventOnLongPress") as LuaFunction);
					this.m_remove_EventOnLongPressAction_hotfix = (luaObj.RawGet("remove_EventOnLongPress") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010488 RID: 66696 RVA: 0x0044134C File Offset: 0x0043F54C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroExpItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400976B RID: 38763
		[AutoBind("./CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_countText;

		// Token: 0x0400976C RID: 38764
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x0400976D RID: 38765
		[AutoBind("./FrameImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_frameImage;

		// Token: 0x04009773 RID: 38771
		public bool IsPointDown;

		// Token: 0x04009774 RID: 38772
		private int usedCount;

		// Token: 0x04009775 RID: 38773
		private float m_delay;

		// Token: 0x04009776 RID: 38774
		private float m_lastInvokeTime;

		// Token: 0x04009777 RID: 38775
		private bool m_isDragging;

		// Token: 0x04009778 RID: 38776
		private GameObject m_draggingGo;

		// Token: 0x04009779 RID: 38777
		private float m_startPressTime;

		// Token: 0x0400977A RID: 38778
		[DoNotToLua]
		private HeroExpItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400977B RID: 38779
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400977C RID: 38780
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400977D RID: 38781
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400977E RID: 38782
		private LuaFunction m_InitExpItemBagItemBaseSingleSingleAction_hotfix;

		// Token: 0x0400977F RID: 38783
		private LuaFunction m_Update_hotfix;

		// Token: 0x04009780 RID: 38784
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x04009781 RID: 38785
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x04009782 RID: 38786
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x04009783 RID: 38787
		private LuaFunction m_OnDragPointerEventData_hotfix;

		// Token: 0x04009784 RID: 38788
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x04009785 RID: 38789
		private LuaFunction m_PassEventPointerEventDataEventFunction;

		// Token: 0x04009786 RID: 38790
		private LuaFunction m_add_OnItemPointUpAction;

		// Token: 0x04009787 RID: 38791
		private LuaFunction m_remove_OnItemPointUpAction;

		// Token: 0x04009788 RID: 38792
		private LuaFunction m_add_OnItemPointDownAction;

		// Token: 0x04009789 RID: 38793
		private LuaFunction m_remove_OnItemPointDownAction;

		// Token: 0x0400978A RID: 38794
		private LuaFunction m_set_BagItemBagItemBase_hotfix;

		// Token: 0x0400978B RID: 38795
		private LuaFunction m_get_BagItem_hotfix;

		// Token: 0x0400978C RID: 38796
		private LuaFunction m_set_AddExpValueInt32_hotfix;

		// Token: 0x0400978D RID: 38797
		private LuaFunction m_get_AddExpValue_hotfix;

		// Token: 0x0400978E RID: 38798
		private LuaFunction m_get_Interval_hotfix;

		// Token: 0x0400978F RID: 38799
		private LuaFunction m_set_IntervalSingle_hotfix;

		// Token: 0x04009790 RID: 38800
		private LuaFunction m_get_Delay_hotfix;

		// Token: 0x04009791 RID: 38801
		private LuaFunction m_set_DelaySingle_hotfix;

		// Token: 0x04009792 RID: 38802
		private LuaFunction m_add_EventOnLongPressAction_hotfix;

		// Token: 0x04009793 RID: 38803
		private LuaFunction m_remove_EventOnLongPressAction_hotfix;

		// Token: 0x02000D96 RID: 3478
		public new class LuaExportHelper
		{
			// Token: 0x06010489 RID: 66697 RVA: 0x004413B4 File Offset: 0x0043F5B4
			public LuaExportHelper(HeroExpItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601048A RID: 66698 RVA: 0x004413C4 File Offset: 0x0043F5C4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601048B RID: 66699 RVA: 0x004413D4 File Offset: 0x0043F5D4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601048C RID: 66700 RVA: 0x004413E4 File Offset: 0x0043F5E4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601048D RID: 66701 RVA: 0x004413F4 File Offset: 0x0043F5F4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601048E RID: 66702 RVA: 0x0044140C File Offset: 0x0043F60C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601048F RID: 66703 RVA: 0x0044141C File Offset: 0x0043F61C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010490 RID: 66704 RVA: 0x0044142C File Offset: 0x0043F62C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010491 RID: 66705 RVA: 0x0044143C File Offset: 0x0043F63C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010492 RID: 66706 RVA: 0x0044144C File Offset: 0x0043F64C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010493 RID: 66707 RVA: 0x0044145C File Offset: 0x0043F65C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010494 RID: 66708 RVA: 0x0044146C File Offset: 0x0043F66C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010495 RID: 66709 RVA: 0x0044147C File Offset: 0x0043F67C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010496 RID: 66710 RVA: 0x0044148C File Offset: 0x0043F68C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010497 RID: 66711 RVA: 0x0044149C File Offset: 0x0043F69C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010498 RID: 66712 RVA: 0x004414AC File Offset: 0x0043F6AC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010499 RID: 66713 RVA: 0x004414BC File Offset: 0x0043F6BC
			public void __callDele_OnItemPointUp(int obj)
			{
				this.m_owner.__callDele_OnItemPointUp(obj);
			}

			// Token: 0x0601049A RID: 66714 RVA: 0x004414CC File Offset: 0x0043F6CC
			public void __clearDele_OnItemPointUp(int obj)
			{
				this.m_owner.__clearDele_OnItemPointUp(obj);
			}

			// Token: 0x0601049B RID: 66715 RVA: 0x004414DC File Offset: 0x0043F6DC
			public void __callDele_OnItemPointDown(HeroExpItemUIController obj)
			{
				this.m_owner.__callDele_OnItemPointDown(obj);
			}

			// Token: 0x0601049C RID: 66716 RVA: 0x004414EC File Offset: 0x0043F6EC
			public void __clearDele_OnItemPointDown(HeroExpItemUIController obj)
			{
				this.m_owner.__clearDele_OnItemPointDown(obj);
			}

			// Token: 0x0601049D RID: 66717 RVA: 0x004414FC File Offset: 0x0043F6FC
			public void __callDele_EventOnLongPress()
			{
				this.m_owner.__callDele_EventOnLongPress();
			}

			// Token: 0x0601049E RID: 66718 RVA: 0x0044150C File Offset: 0x0043F70C
			public void __clearDele_EventOnLongPress()
			{
				this.m_owner.__clearDele_EventOnLongPress();
			}

			// Token: 0x1700321E RID: 12830
			// (get) Token: 0x0601049F RID: 66719 RVA: 0x0044151C File Offset: 0x0043F71C
			// (set) Token: 0x060104A0 RID: 66720 RVA: 0x0044152C File Offset: 0x0043F72C
			public Text m_countText
			{
				get
				{
					return this.m_owner.m_countText;
				}
				set
				{
					this.m_owner.m_countText = value;
				}
			}

			// Token: 0x1700321F RID: 12831
			// (get) Token: 0x060104A1 RID: 66721 RVA: 0x0044153C File Offset: 0x0043F73C
			// (set) Token: 0x060104A2 RID: 66722 RVA: 0x0044154C File Offset: 0x0043F74C
			public Image m_iconImage
			{
				get
				{
					return this.m_owner.m_iconImage;
				}
				set
				{
					this.m_owner.m_iconImage = value;
				}
			}

			// Token: 0x17003220 RID: 12832
			// (get) Token: 0x060104A3 RID: 66723 RVA: 0x0044155C File Offset: 0x0043F75C
			// (set) Token: 0x060104A4 RID: 66724 RVA: 0x0044156C File Offset: 0x0043F76C
			public Image m_frameImage
			{
				get
				{
					return this.m_owner.m_frameImage;
				}
				set
				{
					this.m_owner.m_frameImage = value;
				}
			}

			// Token: 0x17003221 RID: 12833
			// (get) Token: 0x060104A5 RID: 66725 RVA: 0x0044157C File Offset: 0x0043F77C
			// (set) Token: 0x060104A6 RID: 66726 RVA: 0x0044158C File Offset: 0x0043F78C
			public int usedCount
			{
				get
				{
					return this.m_owner.usedCount;
				}
				set
				{
					this.m_owner.usedCount = value;
				}
			}

			// Token: 0x17003222 RID: 12834
			// (get) Token: 0x060104A7 RID: 66727 RVA: 0x0044159C File Offset: 0x0043F79C
			// (set) Token: 0x060104A8 RID: 66728 RVA: 0x004415AC File Offset: 0x0043F7AC
			public float m_delay
			{
				get
				{
					return this.m_owner.m_delay;
				}
				set
				{
					this.m_owner.m_delay = value;
				}
			}

			// Token: 0x17003223 RID: 12835
			// (get) Token: 0x060104A9 RID: 66729 RVA: 0x004415BC File Offset: 0x0043F7BC
			// (set) Token: 0x060104AA RID: 66730 RVA: 0x004415CC File Offset: 0x0043F7CC
			public float m_lastInvokeTime
			{
				get
				{
					return this.m_owner.m_lastInvokeTime;
				}
				set
				{
					this.m_owner.m_lastInvokeTime = value;
				}
			}

			// Token: 0x17003224 RID: 12836
			// (get) Token: 0x060104AB RID: 66731 RVA: 0x004415DC File Offset: 0x0043F7DC
			// (set) Token: 0x060104AC RID: 66732 RVA: 0x004415EC File Offset: 0x0043F7EC
			public bool m_isDragging
			{
				get
				{
					return this.m_owner.m_isDragging;
				}
				set
				{
					this.m_owner.m_isDragging = value;
				}
			}

			// Token: 0x17003225 RID: 12837
			// (get) Token: 0x060104AD RID: 66733 RVA: 0x004415FC File Offset: 0x0043F7FC
			// (set) Token: 0x060104AE RID: 66734 RVA: 0x0044160C File Offset: 0x0043F80C
			public GameObject m_draggingGo
			{
				get
				{
					return this.m_owner.m_draggingGo;
				}
				set
				{
					this.m_owner.m_draggingGo = value;
				}
			}

			// Token: 0x17003226 RID: 12838
			// (get) Token: 0x060104AF RID: 66735 RVA: 0x0044161C File Offset: 0x0043F81C
			// (set) Token: 0x060104B0 RID: 66736 RVA: 0x0044162C File Offset: 0x0043F82C
			public float m_startPressTime
			{
				get
				{
					return this.m_owner.m_startPressTime;
				}
				set
				{
					this.m_owner.m_startPressTime = value;
				}
			}

			// Token: 0x17003227 RID: 12839
			// (set) Token: 0x060104B1 RID: 66737 RVA: 0x0044163C File Offset: 0x0043F83C
			public BagItemBase BagItem
			{
				set
				{
					this.m_owner.BagItem = value;
				}
			}

			// Token: 0x17003228 RID: 12840
			// (set) Token: 0x060104B2 RID: 66738 RVA: 0x0044164C File Offset: 0x0043F84C
			public int AddExpValue
			{
				set
				{
					this.m_owner.AddExpValue = value;
				}
			}

			// Token: 0x17003229 RID: 12841
			// (get) Token: 0x060104B3 RID: 66739 RVA: 0x0044165C File Offset: 0x0043F85C
			public float Interval
			{
				get
				{
					return this.m_owner.Interval;
				}
			}

			// Token: 0x1700322A RID: 12842
			// (get) Token: 0x060104B4 RID: 66740 RVA: 0x0044166C File Offset: 0x0043F86C
			public float Delay
			{
				get
				{
					return this.m_owner.Delay;
				}
			}

			// Token: 0x060104B5 RID: 66741 RVA: 0x0044167C File Offset: 0x0043F87C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060104B6 RID: 66742 RVA: 0x0044168C File Offset: 0x0043F88C
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x04009794 RID: 38804
			private HeroExpItemUIController m_owner;
		}
	}
}
