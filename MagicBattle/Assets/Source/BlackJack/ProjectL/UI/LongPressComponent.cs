using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BD6 RID: 3030
	[HotFix]
	public class LongPressComponent : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler, IEventSystemHandler
	{
		// Token: 0x0600D102 RID: 53506 RVA: 0x00393988 File Offset: 0x00391B88
		public void SetBasicParam(float delay = 1f, float interval = 0.3f, Action eventOnLongPress = null, Action eventOnPointDown = null, Action eventOnPointUp = null, bool isNeedEventOnLongPressLoop = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBasicParamSingleSingleActionActionActionBoolean_hotfix != null)
			{
				this.m_SetBasicParamSingleSingleActionActionActionBoolean_hotfix.call(new object[]
				{
					this,
					delay,
					interval,
					eventOnLongPress,
					eventOnPointDown,
					eventOnPointUp,
					isNeedEventOnLongPressLoop
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Interval = interval;
			this.Delay = delay;
			this.EventOnLongPress = eventOnLongPress;
			this.EventOnPointDown = eventOnPointDown;
			this.EventOnPointUp = eventOnPointUp;
			this.IsNeedEventOnLongPressLoop = isNeedEventOnLongPressLoop;
		}

		// Token: 0x0600D103 RID: 53507 RVA: 0x00393A78 File Offset: 0x00391C78
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
			if (this.m_isPointDown)
			{
				if ((this.m_delay -= Time.deltaTime) > 0f)
				{
					return;
				}
				if (Time.time - this.m_lastInvokeTime > this.Interval && this.EventOnLongPress != null && !this.hasInvokeLongPressEvent)
				{
					this.EventOnLongPress();
					this.m_lastInvokeTime = Time.time;
					if (!this.IsNeedEventOnLongPressLoop)
					{
						this.hasInvokeLongPressEvent = true;
					}
				}
			}
		}

		// Token: 0x0600D104 RID: 53508 RVA: 0x00393B58 File Offset: 0x00391D58
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
			this.hasInvokeLongPressEvent = false;
			this.m_isPointDown = true;
			this.m_delay = this.Delay;
			if (this.EventOnPointDown != null)
			{
				this.EventOnPointDown();
			}
		}

		// Token: 0x0600D105 RID: 53509 RVA: 0x00393BF8 File Offset: 0x00391DF8
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
			this.m_isPointDown = false;
			if (this.EventOnPointUp != null)
			{
				this.EventOnPointUp();
			}
		}

		// Token: 0x0600D106 RID: 53510 RVA: 0x00393C88 File Offset: 0x00391E88
		public void OnPointerExit(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerExitPointerEventData_hotfix != null)
			{
				this.m_OnPointerExitPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isPointDown = false;
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x0600D107 RID: 53511 RVA: 0x00393D00 File Offset: 0x00391F00
		// (set) Token: 0x0600D108 RID: 53512 RVA: 0x00393D74 File Offset: 0x00391F74
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

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x0600D109 RID: 53513 RVA: 0x00393DEC File Offset: 0x00391FEC
		// (set) Token: 0x0600D10A RID: 53514 RVA: 0x00393E60 File Offset: 0x00392060
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

		// Token: 0x14000280 RID: 640
		// (add) Token: 0x0600D10B RID: 53515 RVA: 0x00393ED8 File Offset: 0x003920D8
		// (remove) Token: 0x0600D10C RID: 53516 RVA: 0x00393F74 File Offset: 0x00392174
		private event Action EventOnLongPress
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

		// Token: 0x14000281 RID: 641
		// (add) Token: 0x0600D10D RID: 53517 RVA: 0x00394010 File Offset: 0x00392210
		// (remove) Token: 0x0600D10E RID: 53518 RVA: 0x003940AC File Offset: 0x003922AC
		private event Action EventOnPointDown
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointDownAction_hotfix != null)
				{
					this.m_add_EventOnPointDownAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointDown;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointDown, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointDownAction_hotfix != null)
				{
					this.m_remove_EventOnPointDownAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointDown;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointDown, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000282 RID: 642
		// (add) Token: 0x0600D10F RID: 53519 RVA: 0x00394148 File Offset: 0x00392348
		// (remove) Token: 0x0600D110 RID: 53520 RVA: 0x003941E4 File Offset: 0x003923E4
		private event Action EventOnPointUp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointUpAction_hotfix != null)
				{
					this.m_add_EventOnPointUpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointUp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointUp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointUpAction_hotfix != null)
				{
					this.m_remove_EventOnPointUpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointUp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointUp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x0600D111 RID: 53521 RVA: 0x00394280 File Offset: 0x00392480
		// (set) Token: 0x0600D112 RID: 53522 RVA: 0x003942A0 File Offset: 0x003924A0
		[DoNotToLua]
		public LongPressComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LongPressComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D113 RID: 53523 RVA: 0x003942AC File Offset: 0x003924AC
		private void __callDele_EventOnLongPress()
		{
			Action eventOnLongPress = this.EventOnLongPress;
			if (eventOnLongPress != null)
			{
				eventOnLongPress();
			}
		}

		// Token: 0x0600D114 RID: 53524 RVA: 0x003942CC File Offset: 0x003924CC
		private void __clearDele_EventOnLongPress()
		{
			this.EventOnLongPress = null;
		}

		// Token: 0x0600D115 RID: 53525 RVA: 0x003942D8 File Offset: 0x003924D8
		private void __callDele_EventOnPointDown()
		{
			Action eventOnPointDown = this.EventOnPointDown;
			if (eventOnPointDown != null)
			{
				eventOnPointDown();
			}
		}

		// Token: 0x0600D116 RID: 53526 RVA: 0x003942F8 File Offset: 0x003924F8
		private void __clearDele_EventOnPointDown()
		{
			this.EventOnPointDown = null;
		}

		// Token: 0x0600D117 RID: 53527 RVA: 0x00394304 File Offset: 0x00392504
		private void __callDele_EventOnPointUp()
		{
			Action eventOnPointUp = this.EventOnPointUp;
			if (eventOnPointUp != null)
			{
				eventOnPointUp();
			}
		}

		// Token: 0x0600D118 RID: 53528 RVA: 0x00394324 File Offset: 0x00392524
		private void __clearDele_EventOnPointUp()
		{
			this.EventOnPointUp = null;
		}

		// Token: 0x0600D119 RID: 53529 RVA: 0x00394330 File Offset: 0x00392530
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
					this.m_SetBasicParamSingleSingleActionActionActionBoolean_hotfix = (luaObj.RawGet("SetBasicParam") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_OnPointerExitPointerEventData_hotfix = (luaObj.RawGet("OnPointerExit") as LuaFunction);
					this.m_get_Interval_hotfix = (luaObj.RawGet("get_Interval") as LuaFunction);
					this.m_set_IntervalSingle_hotfix = (luaObj.RawGet("set_Interval") as LuaFunction);
					this.m_get_Delay_hotfix = (luaObj.RawGet("get_Delay") as LuaFunction);
					this.m_set_DelaySingle_hotfix = (luaObj.RawGet("set_Delay") as LuaFunction);
					this.m_add_EventOnLongPressAction_hotfix = (luaObj.RawGet("add_EventOnLongPress") as LuaFunction);
					this.m_remove_EventOnLongPressAction_hotfix = (luaObj.RawGet("remove_EventOnLongPress") as LuaFunction);
					this.m_add_EventOnPointDownAction_hotfix = (luaObj.RawGet("add_EventOnPointDown") as LuaFunction);
					this.m_remove_EventOnPointDownAction_hotfix = (luaObj.RawGet("remove_EventOnPointDown") as LuaFunction);
					this.m_add_EventOnPointUpAction_hotfix = (luaObj.RawGet("add_EventOnPointUp") as LuaFunction);
					this.m_remove_EventOnPointUpAction_hotfix = (luaObj.RawGet("remove_EventOnPointUp") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D11A RID: 53530 RVA: 0x0039455C File Offset: 0x0039275C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LongPressComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040081F9 RID: 33273
		private bool hasInvokeLongPressEvent;

		// Token: 0x040081FA RID: 33274
		private bool IsNeedEventOnLongPressLoop;

		// Token: 0x040081FB RID: 33275
		private bool m_isPointDown;

		// Token: 0x040081FC RID: 33276
		private float m_lastInvokeTime;

		// Token: 0x040081FD RID: 33277
		private float m_delay;

		// Token: 0x040081FE RID: 33278
		[DoNotToLua]
		private LongPressComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040081FF RID: 33279
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008200 RID: 33280
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008201 RID: 33281
		private LuaFunction m_SetBasicParamSingleSingleActionActionActionBoolean_hotfix;

		// Token: 0x04008202 RID: 33282
		private LuaFunction m_Update_hotfix;

		// Token: 0x04008203 RID: 33283
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x04008204 RID: 33284
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x04008205 RID: 33285
		private LuaFunction m_OnPointerExitPointerEventData_hotfix;

		// Token: 0x04008206 RID: 33286
		private LuaFunction m_get_Interval_hotfix;

		// Token: 0x04008207 RID: 33287
		private LuaFunction m_set_IntervalSingle_hotfix;

		// Token: 0x04008208 RID: 33288
		private LuaFunction m_get_Delay_hotfix;

		// Token: 0x04008209 RID: 33289
		private LuaFunction m_set_DelaySingle_hotfix;

		// Token: 0x0400820A RID: 33290
		private LuaFunction m_add_EventOnLongPressAction_hotfix;

		// Token: 0x0400820B RID: 33291
		private LuaFunction m_remove_EventOnLongPressAction_hotfix;

		// Token: 0x0400820C RID: 33292
		private LuaFunction m_add_EventOnPointDownAction_hotfix;

		// Token: 0x0400820D RID: 33293
		private LuaFunction m_remove_EventOnPointDownAction_hotfix;

		// Token: 0x0400820E RID: 33294
		private LuaFunction m_add_EventOnPointUpAction_hotfix;

		// Token: 0x0400820F RID: 33295
		private LuaFunction m_remove_EventOnPointUpAction_hotfix;

		// Token: 0x02000BD7 RID: 3031
		public class LuaExportHelper
		{
			// Token: 0x0600D11B RID: 53531 RVA: 0x003945C4 File Offset: 0x003927C4
			public LuaExportHelper(LongPressComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D11C RID: 53532 RVA: 0x003945D4 File Offset: 0x003927D4
			public void __callDele_EventOnLongPress()
			{
				this.m_owner.__callDele_EventOnLongPress();
			}

			// Token: 0x0600D11D RID: 53533 RVA: 0x003945E4 File Offset: 0x003927E4
			public void __clearDele_EventOnLongPress()
			{
				this.m_owner.__clearDele_EventOnLongPress();
			}

			// Token: 0x0600D11E RID: 53534 RVA: 0x003945F4 File Offset: 0x003927F4
			public void __callDele_EventOnPointDown()
			{
				this.m_owner.__callDele_EventOnPointDown();
			}

			// Token: 0x0600D11F RID: 53535 RVA: 0x00394604 File Offset: 0x00392804
			public void __clearDele_EventOnPointDown()
			{
				this.m_owner.__clearDele_EventOnPointDown();
			}

			// Token: 0x0600D120 RID: 53536 RVA: 0x00394614 File Offset: 0x00392814
			public void __callDele_EventOnPointUp()
			{
				this.m_owner.__callDele_EventOnPointUp();
			}

			// Token: 0x0600D121 RID: 53537 RVA: 0x00394624 File Offset: 0x00392824
			public void __clearDele_EventOnPointUp()
			{
				this.m_owner.__clearDele_EventOnPointUp();
			}

			// Token: 0x17002923 RID: 10531
			// (get) Token: 0x0600D122 RID: 53538 RVA: 0x00394634 File Offset: 0x00392834
			// (set) Token: 0x0600D123 RID: 53539 RVA: 0x00394644 File Offset: 0x00392844
			public bool hasInvokeLongPressEvent
			{
				get
				{
					return this.m_owner.hasInvokeLongPressEvent;
				}
				set
				{
					this.m_owner.hasInvokeLongPressEvent = value;
				}
			}

			// Token: 0x17002924 RID: 10532
			// (get) Token: 0x0600D124 RID: 53540 RVA: 0x00394654 File Offset: 0x00392854
			// (set) Token: 0x0600D125 RID: 53541 RVA: 0x00394664 File Offset: 0x00392864
			public bool IsNeedEventOnLongPressLoop
			{
				get
				{
					return this.m_owner.IsNeedEventOnLongPressLoop;
				}
				set
				{
					this.m_owner.IsNeedEventOnLongPressLoop = value;
				}
			}

			// Token: 0x17002925 RID: 10533
			// (get) Token: 0x0600D126 RID: 53542 RVA: 0x00394674 File Offset: 0x00392874
			// (set) Token: 0x0600D127 RID: 53543 RVA: 0x00394684 File Offset: 0x00392884
			public bool m_isPointDown
			{
				get
				{
					return this.m_owner.m_isPointDown;
				}
				set
				{
					this.m_owner.m_isPointDown = value;
				}
			}

			// Token: 0x17002926 RID: 10534
			// (get) Token: 0x0600D128 RID: 53544 RVA: 0x00394694 File Offset: 0x00392894
			// (set) Token: 0x0600D129 RID: 53545 RVA: 0x003946A4 File Offset: 0x003928A4
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

			// Token: 0x17002927 RID: 10535
			// (get) Token: 0x0600D12A RID: 53546 RVA: 0x003946B4 File Offset: 0x003928B4
			// (set) Token: 0x0600D12B RID: 53547 RVA: 0x003946C4 File Offset: 0x003928C4
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

			// Token: 0x17002928 RID: 10536
			// (get) Token: 0x0600D12C RID: 53548 RVA: 0x003946D4 File Offset: 0x003928D4
			public float Interval
			{
				get
				{
					return this.m_owner.Interval;
				}
			}

			// Token: 0x17002929 RID: 10537
			// (get) Token: 0x0600D12D RID: 53549 RVA: 0x003946E4 File Offset: 0x003928E4
			public float Delay
			{
				get
				{
					return this.m_owner.Delay;
				}
			}

			// Token: 0x0600D12E RID: 53550 RVA: 0x003946F4 File Offset: 0x003928F4
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x14000283 RID: 643
			// (add) Token: 0x0600D12F RID: 53551 RVA: 0x00394704 File Offset: 0x00392904
			// (remove) Token: 0x0600D130 RID: 53552 RVA: 0x00394714 File Offset: 0x00392914
			public event Action EventOnLongPress
			{
				add
				{
					this.m_owner.EventOnLongPress += value;
				}
				remove
				{
					this.m_owner.EventOnLongPress += value;
				}
			}

			// Token: 0x14000284 RID: 644
			// (add) Token: 0x0600D131 RID: 53553 RVA: 0x00394724 File Offset: 0x00392924
			// (remove) Token: 0x0600D132 RID: 53554 RVA: 0x00394734 File Offset: 0x00392934
			public event Action EventOnPointDown
			{
				add
				{
					this.m_owner.EventOnPointDown += value;
				}
				remove
				{
					this.m_owner.EventOnPointDown += value;
				}
			}

			// Token: 0x14000285 RID: 645
			// (add) Token: 0x0600D133 RID: 53555 RVA: 0x00394744 File Offset: 0x00392944
			// (remove) Token: 0x0600D134 RID: 53556 RVA: 0x00394754 File Offset: 0x00392954
			public event Action EventOnPointUp
			{
				add
				{
					this.m_owner.EventOnPointUp += value;
				}
				remove
				{
					this.m_owner.EventOnPointUp += value;
				}
			}

			// Token: 0x04008210 RID: 33296
			private LongPressComponent m_owner;
		}
	}
}
