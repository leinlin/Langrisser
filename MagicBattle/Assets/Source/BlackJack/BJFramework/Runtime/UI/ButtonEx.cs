using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000DE RID: 222
	[AddComponentMenu("UIExtend/ButtonEx", 16)]
	public class ButtonEx : Button
	{
		// Token: 0x06000870 RID: 2160 RVA: 0x00024FE0 File Offset: 0x000231E0
		protected ButtonEx()
		{
			base.onClick.AddListener(new UnityAction(this.OnButtonClicked));
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00025058 File Offset: 0x00023258
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00025060 File Offset: 0x00023260
		public ButtonEx.ButtonDoubleClickedEvent onDoubleClick
		{
			get
			{
				return this.m_OnDoubleClick;
			}
			set
			{
				this.m_OnDoubleClick = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0002506C File Offset: 0x0002326C
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00025074 File Offset: 0x00023274
		public ButtonEx.ButtonLongPressStartEvent onLongPressStart
		{
			get
			{
				return this.m_OnLongPressStart;
			}
			set
			{
				this.m_OnLongPressStart = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00025080 File Offset: 0x00023280
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00025088 File Offset: 0x00023288
		public ButtonEx.ButtonLongPressingEvent onLongPressing
		{
			get
			{
				return this.m_OnLongPressing;
			}
			set
			{
				this.m_OnLongPressing = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00025094 File Offset: 0x00023294
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x0002509C File Offset: 0x0002329C
		public ButtonEx.ButtonLongPressEndEvent onLongPressEnd
		{
			get
			{
				return this.m_OnLongPressEnd;
			}
			set
			{
				this.m_OnLongPressEnd = value;
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x000250A8 File Offset: 0x000232A8
		protected void Update()
		{
			if (this.m_continueClickDelayLeftTime > 0f)
			{
				this.m_continueClickDelayLeftTime -= Time.deltaTime;
				if (this.m_continueClickDelayLeftTime < 0f)
				{
					this.m_continueClickDelayLeftTime = 0f;
					this.m_continueClickCount--;
				}
			}
			if (this.m_isPointerDown)
			{
				if (!this.m_isLongPressTriggered)
				{
					if (Time.time - this.m_timeFromPressStarted > this.m_longPressThreshhold)
					{
						this.m_isLongPressTriggered = true;
						this.m_timeFromLastPressingTrigger = 0f;
						this.m_OnLongPressStart.Invoke();
					}
				}
				else if (this.m_longPressingTriggerTimeGap <= 0f)
				{
					this.m_OnLongPressing.Invoke();
				}
				else
				{
					this.m_timeFromLastPressingTrigger += Time.deltaTime;
					if (this.m_timeFromLastPressingTrigger >= this.m_longPressingTriggerTimeGap)
					{
						this.m_OnLongPressing.Invoke();
						this.m_timeFromLastPressingTrigger -= this.m_longPressingTriggerTimeGap;
					}
				}
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000251B0 File Offset: 0x000233B0
		public void SetNormalState()
		{
			this.DoStateTransition(Selectable.SelectionState.Normal, false);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000251BC File Offset: 0x000233BC
		public void SetPressedState()
		{
			this.DoStateTransition(Selectable.SelectionState.Pressed, false);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000251C8 File Offset: 0x000233C8
		public void SetDisableState()
		{
			this.DoStateTransition(Selectable.SelectionState.Disabled, false);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000251D4 File Offset: 0x000233D4
		public override void OnPointerDown(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.m_isPointerDown = true;
			this.m_timeFromPressStarted = Time.time;
			this.m_isLongPressTriggered = false;
			this.PlayPointerDownTween(true);
			base.OnPointerDown(eventData);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0002520C File Offset: 0x0002340C
		public override void OnPointerUp(PointerEventData eventData)
		{
			if (eventData.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.m_isPointerDown = false;
			if (this.m_isPointerInside)
			{
				this.PlayPointerDownTween(false);
			}
			if (this.m_isLongPressTriggered)
			{
				this.m_OnLongPressEnd.Invoke();
			}
			base.OnPointerUp(eventData);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0002525C File Offset: 0x0002345C
		public override void OnPointerEnter(PointerEventData eventData)
		{
			this.m_isPointerInside = true;
			base.OnPointerEnter(eventData);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0002526C File Offset: 0x0002346C
		public override void OnPointerExit(PointerEventData eventData)
		{
			this.m_isPointerInside = false;
			if (this.m_isPointerDown)
			{
				this.PlayPointerDownTween(false);
				this.m_isPointerDown = false;
				if (this.m_isLongPressTriggered)
				{
					this.m_OnLongPressEnd.Invoke();
				}
			}
			this.ResetDoubleClickState();
			base.OnPointerExit(eventData);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x000252BC File Offset: 0x000234BC
		public virtual void SetBaseColorList(Dictionary<GameObject, Color> baseColorList)
		{
			this.m_baseColorList = baseColorList;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x000252C8 File Offset: 0x000234C8
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			base.DoStateTransition(state, instant);
			if (base.gameObject.activeInHierarchy)
			{
				switch (state)
				{
				case Selectable.SelectionState.Normal:
				case Selectable.SelectionState.Highlighted:
					if (this.m_baseColorList == null)
					{
						this.SetButtonComponentColor(this.m_normalStateColorList);
					}
					else
					{
						this.ResetButtonCompontentToBaseColor();
					}
					break;
				case Selectable.SelectionState.Pressed:
					this.SetButtonComponentColor(this.m_pressedStateColorList);
					break;
				case Selectable.SelectionState.Disabled:
					this.SetButtonComponentColor(this.m_disableStateColorList);
					break;
				}
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00025354 File Offset: 0x00023554
		protected override void InstantClearState()
		{
			base.InstantClearState();
			this.SetButtonComponentColor(this.m_disableStateColorList);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00025368 File Offset: 0x00023568
		protected void SetButtonComponentColor(List<Color> stateColorList)
		{
			if (stateColorList == null)
			{
				return;
			}
			for (int i = 0; i < this.m_buttonComponent.Count; i++)
			{
				if (i >= stateColorList.Count)
				{
					break;
				}
				GameObject gameObject = this.m_buttonComponent[i];
				if (!(gameObject == null))
				{
					this.SetGameObjectColor(gameObject, stateColorList[i]);
				}
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000253D8 File Offset: 0x000235D8
		protected void ResetButtonCompontentToBaseColor()
		{
			for (int i = 0; i < this.m_buttonComponent.Count; i++)
			{
				GameObject gameObject = this.m_buttonComponent[i];
				if (!(gameObject == null))
				{
					Color baseStateColor = this.GetBaseStateColor(gameObject, i);
					this.SetGameObjectColor(gameObject, baseStateColor);
				}
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00025430 File Offset: 0x00023630
		protected Color GetBaseStateColor(GameObject go, int index)
		{
			Color clear = Color.clear;
			if (this.m_baseColorList.TryGetValue(go, out clear))
			{
				return clear;
			}
			if (index >= this.m_normalStateColorList.Count)
			{
				return Color.clear;
			}
			return this.m_normalStateColorList[index];
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0002547C File Offset: 0x0002367C
		protected void PlayPointerDownTween(bool isforward)
		{
			foreach (TweenMain tweenMain in this.m_pointerDownTweenList)
			{
				if (tweenMain != null)
				{
					if (isforward)
					{
						tweenMain.PlayForward();
					}
					else
					{
						tweenMain.PlayReverse();
					}
				}
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000254F4 File Offset: 0x000236F4
		protected void SetGameObjectColor(GameObject go, Color color)
		{
			if (color == Color.clear)
			{
				return;
			}
			Image component = go.GetComponent<Image>();
			if (component != null)
			{
				component.color = color;
			}
			else
			{
				Text component2 = go.GetComponent<Text>();
				if (component2 != null)
				{
					component2.color = color;
				}
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0002554C File Offset: 0x0002374C
		protected void OnButtonClicked()
		{
			this.m_continueClickCount++;
			if (this.m_continueClickCount == 2)
			{
				this.ResetDoubleClickState();
				this.m_OnDoubleClick.Invoke();
			}
			else
			{
				this.m_continueClickDelayLeftTime = this.m_doubleClickDelayTime;
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0002558C File Offset: 0x0002378C
		protected void ResetDoubleClickState()
		{
			this.m_continueClickCount = 0;
			this.m_continueClickDelayLeftTime = 0f;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x000255A0 File Offset: 0x000237A0
		public AudioClip PressedAudioClip
		{
			get
			{
				return this.m_pressedAudioClip;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x000255A8 File Offset: 0x000237A8
		public string PressedAudioCRI
		{
			get
			{
				return this.m_pressedAudioCRI;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x000255B0 File Offset: 0x000237B0
		public bool ProhibitAudio
		{
			get
			{
				return this.m_prohibitAudio;
			}
		}

		// Token: 0x04000549 RID: 1353
		[FormerlySerializedAs("onDoubleClick")]
		[SerializeField]
		private ButtonEx.ButtonDoubleClickedEvent m_OnDoubleClick = new ButtonEx.ButtonDoubleClickedEvent();

		// Token: 0x0400054A RID: 1354
		[SerializeField]
		private ButtonEx.ButtonLongPressStartEvent m_OnLongPressStart = new ButtonEx.ButtonLongPressStartEvent();

		// Token: 0x0400054B RID: 1355
		[SerializeField]
		private ButtonEx.ButtonLongPressingEvent m_OnLongPressing = new ButtonEx.ButtonLongPressingEvent();

		// Token: 0x0400054C RID: 1356
		[SerializeField]
		private ButtonEx.ButtonLongPressEndEvent m_OnLongPressEnd = new ButtonEx.ButtonLongPressEndEvent();

		// Token: 0x0400054D RID: 1357
		private bool m_isPointerInside;

		// Token: 0x0400054E RID: 1358
		private bool m_isPointerDown;

		// Token: 0x0400054F RID: 1359
		private int m_continueClickCount;

		// Token: 0x04000550 RID: 1360
		private float m_continueClickDelayLeftTime;

		// Token: 0x04000551 RID: 1361
		public float m_doubleClickDelayTime = 0.3f;

		// Token: 0x04000552 RID: 1362
		public float m_longPressThreshhold = 0.5f;

		// Token: 0x04000553 RID: 1363
		public float m_longPressingTriggerTimeGap = -1f;

		// Token: 0x04000554 RID: 1364
		private float m_timeFromPressStarted;

		// Token: 0x04000555 RID: 1365
		private bool m_isLongPressTriggered;

		// Token: 0x04000556 RID: 1366
		private float m_timeFromLastPressingTrigger;

		// Token: 0x04000557 RID: 1367
		[Header("[按钮组件]")]
		[SerializeField]
		[FormerlySerializedAs("ButtonComponent")]
		protected List<GameObject> m_buttonComponent;

		// Token: 0x04000558 RID: 1368
		[SerializeField]
		[FormerlySerializedAs("NormalStateColorList")]
		protected List<Color> m_normalStateColorList;

		// Token: 0x04000559 RID: 1369
		[FormerlySerializedAs("PressedStateColorList")]
		[SerializeField]
		protected List<Color> m_pressedStateColorList;

		// Token: 0x0400055A RID: 1370
		[SerializeField]
		[FormerlySerializedAs("DisableStateColorList")]
		protected List<Color> m_disableStateColorList;

		// Token: 0x0400055B RID: 1371
		protected Dictionary<GameObject, Color> m_baseColorList;

		// Token: 0x0400055C RID: 1372
		[SerializeField]
		[FormerlySerializedAs("PressedAudioClip")]
		[Header("[Unity按下音效]")]
		protected AudioClip m_pressedAudioClip;

		// Token: 0x0400055D RID: 1373
		[Header("[CRI按下音效]")]
		[SerializeField]
		[FormerlySerializedAs("PressedAudioCRI")]
		protected string m_pressedAudioCRI;

		// Token: 0x0400055E RID: 1374
		[SerializeField]
		[Header("[是否禁止音效]")]
		protected bool m_prohibitAudio;

		// Token: 0x0400055F RID: 1375
		[Header("按下Tween列表")]
		[SerializeField]
		[FormerlySerializedAs("PointerDownTweenList")]
		protected List<TweenMain> m_pointerDownTweenList;

		// Token: 0x020000DF RID: 223
		[Serializable]
		public class ButtonDoubleClickedEvent : UnityEvent
		{
		}

		// Token: 0x020000E0 RID: 224
		[Serializable]
		public class ButtonLongPressStartEvent : UnityEvent
		{
		}

		// Token: 0x020000E1 RID: 225
		[Serializable]
		public class ButtonLongPressingEvent : UnityEvent
		{
		}

		// Token: 0x020000E2 RID: 226
		[Serializable]
		public class ButtonLongPressEndEvent : UnityEvent
		{
		}
	}
}
