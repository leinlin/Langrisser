using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000EA RID: 234
	[AddComponentMenu("UIExtend/ToggleEx", 16)]
	public class ToggleEx : Toggle
	{
		// Token: 0x060008AF RID: 2223 RVA: 0x00026554 File Offset: 0x00024754
		protected override void Awake()
		{
			this.m_preIsOn = base.isOn;
			this.onValueChanged.AddListener(new UnityAction<bool>(this.OnValueChanged));
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0002657C File Offset: 0x0002477C
		public void SetNormalState()
		{
			this.DoStateTransition(Selectable.SelectionState.Normal, false);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00026588 File Offset: 0x00024788
		public void SetPressedState()
		{
			this.DoStateTransition(Selectable.SelectionState.Pressed, false);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00026594 File Offset: 0x00024794
		public void SetDisableState()
		{
			this.DoStateTransition(Selectable.SelectionState.Disabled, false);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000265A0 File Offset: 0x000247A0
		public void SetIsOn(bool ison)
		{
			this.m_preIsOn = !ison;
			this.OnValueChanged(ison);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000265B4 File Offset: 0x000247B4
		public virtual void SetBaseColorList(Dictionary<GameObject, Color> baseColorList)
		{
			this.m_baseColorList = baseColorList;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x000265C0 File Offset: 0x000247C0
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
						this.SetToggleComponentColor(this.m_normalStateColorList);
					}
					else
					{
						this.ResetToggleCompontentToBaseColor();
					}
					break;
				case Selectable.SelectionState.Pressed:
					this.SetToggleComponentColor(this.m_pressedStateColorList);
					break;
				case Selectable.SelectionState.Disabled:
					this.SetToggleComponentColor(this.m_disableStateColorList);
					break;
				}
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0002664C File Offset: 0x0002484C
		protected override void InstantClearState()
		{
			base.InstantClearState();
			this.SetToggleComponentColor(this.m_disableStateColorList);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00026660 File Offset: 0x00024860
		protected void SetToggleComponentColor(List<Color> stateColorList)
		{
			if (stateColorList == null)
			{
				return;
			}
			for (int i = 0; i < this.m_toggleComponent.Count; i++)
			{
				if (i >= stateColorList.Count)
				{
					break;
				}
				GameObject gameObject = this.m_toggleComponent[i];
				if (!(gameObject == null))
				{
					this.SetGameObjectColor(gameObject, stateColorList[i]);
				}
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000266D0 File Offset: 0x000248D0
		protected void ResetToggleCompontentToBaseColor()
		{
			for (int i = 0; i < this.m_toggleComponent.Count; i++)
			{
				GameObject gameObject = this.m_toggleComponent[i];
				if (!(gameObject == null))
				{
					Color baseStateColor = this.GetBaseStateColor(gameObject, i);
					this.SetGameObjectColor(gameObject, baseStateColor);
				}
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00026728 File Offset: 0x00024928
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

		// Token: 0x060008BA RID: 2234 RVA: 0x00026774 File Offset: 0x00024974
		protected void ShowOrHideObjectWhenIsOnChanged(bool isOn)
		{
			if (isOn)
			{
				if (this.m_offStateHideObjectList != null)
				{
					foreach (GameObject gameObject in this.m_offStateHideObjectList)
					{
						if (gameObject != null)
						{
							gameObject.SetActive(true);
						}
					}
				}
				if (this.m_onStateHideObjectList != null)
				{
					foreach (GameObject gameObject2 in this.m_onStateHideObjectList)
					{
						if (gameObject2 != null)
						{
							gameObject2.SetActive(false);
						}
					}
				}
			}
			else
			{
				if (this.m_onStateHideObjectList != null)
				{
					foreach (GameObject gameObject3 in this.m_onStateHideObjectList)
					{
						if (gameObject3 != null)
						{
							gameObject3.SetActive(true);
						}
					}
				}
				if (this.m_offStateHideObjectList != null)
				{
					foreach (GameObject gameObject4 in this.m_offStateHideObjectList)
					{
						if (gameObject4 != null)
						{
							gameObject4.SetActive(false);
						}
					}
				}
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00026920 File Offset: 0x00024B20
		protected void SetObjectColorWhenIsOnChanged(List<ToggleEx.ColorDesc> stateColorList)
		{
			if (stateColorList == null)
			{
				return;
			}
			Dictionary<GameObject, Color> dictionary = new Dictionary<GameObject, Color>();
			foreach (ToggleEx.ColorDesc colorDesc in stateColorList)
			{
				if (colorDesc.go != null)
				{
					this.SetGameObjectColor(colorDesc.go, colorDesc.color);
					dictionary[colorDesc.go] = colorDesc.color;
				}
			}
			this.SetBaseColorList(dictionary);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000269BC File Offset: 0x00024BBC
		protected void PlayTweenListWhenIsOnChanged(List<TweenMain> tweenList)
		{
			if (tweenList == null)
			{
				return;
			}
			foreach (TweenMain tweenMain in tweenList)
			{
				if (tweenMain != null)
				{
					tweenMain.ResetToBeginning();
					tweenMain.PlayForward();
				}
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00026A2C File Offset: 0x00024C2C
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

		// Token: 0x060008BE RID: 2238 RVA: 0x00026A84 File Offset: 0x00024C84
		protected void OnValueChanged(bool isOn)
		{
			if (this.m_preIsOn == isOn)
			{
				return;
			}
			this.m_preIsOn = isOn;
			this.ShowOrHideObjectWhenIsOnChanged(isOn);
			if (isOn)
			{
				this.SetObjectColorWhenIsOnChanged(this.m_onStateColorList);
				this.PlayTweenListWhenIsOnChanged(this.m_onStateTweenList);
			}
			else
			{
				this.SetObjectColorWhenIsOnChanged(this.m_offStateColorList);
				this.PlayTweenListWhenIsOnChanged(this.m_offStateTweenList);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00026AE8 File Offset: 0x00024CE8
		public AudioClip PressedAudioClip
		{
			get
			{
				return this.m_pressedAudioClip;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00026AF0 File Offset: 0x00024CF0
		public string PressedAudioCRI
		{
			get
			{
				return this.m_pressedAudioCRI;
			}
		}

		// Token: 0x0400057F RID: 1407
		[Header("[按钮组件]")]
		[SerializeField]
		[FormerlySerializedAs("ButtonComponent")]
		protected List<GameObject> m_toggleComponent;

		// Token: 0x04000580 RID: 1408
		[FormerlySerializedAs("NormalStateColorList")]
		[SerializeField]
		protected List<Color> m_normalStateColorList;

		// Token: 0x04000581 RID: 1409
		[SerializeField]
		[FormerlySerializedAs("PressedStateColorList")]
		protected List<Color> m_pressedStateColorList;

		// Token: 0x04000582 RID: 1410
		[SerializeField]
		[FormerlySerializedAs("DisableStateColorList")]
		protected List<Color> m_disableStateColorList;

		// Token: 0x04000583 RID: 1411
		protected Dictionary<GameObject, Color> m_baseColorList;

		// Token: 0x04000584 RID: 1412
		[Header("[Unity按下音效]")]
		[SerializeField]
		[FormerlySerializedAs("PressedAudioClip")]
		protected AudioClip m_pressedAudioClip;

		// Token: 0x04000585 RID: 1413
		[Header("[CRI按下音效]")]
		[FormerlySerializedAs("PressedAudioCRI")]
		[SerializeField]
		protected string m_pressedAudioCRI;

		// Token: 0x04000586 RID: 1414
		[FormerlySerializedAs("OnStateHideList")]
		[SerializeField]
		[Header("[On状态需要隐藏对象列表]")]
		protected List<GameObject> m_onStateHideObjectList;

		// Token: 0x04000587 RID: 1415
		[Header("[On状态颜色改变列表]")]
		[SerializeField]
		[FormerlySerializedAs("OnStateColorList")]
		protected List<ToggleEx.ColorDesc> m_onStateColorList;

		// Token: 0x04000588 RID: 1416
		[SerializeField]
		[Header("[On状态Tween列表]")]
		[FormerlySerializedAs("OnStateTweenList")]
		protected List<TweenMain> m_onStateTweenList;

		// Token: 0x04000589 RID: 1417
		[SerializeField]
		[FormerlySerializedAs("OffStateHideList")]
		[Header("[Off状态需要隐藏对象列表]")]
		protected List<GameObject> m_offStateHideObjectList;

		// Token: 0x0400058A RID: 1418
		[FormerlySerializedAs("OffStateColorList")]
		[Header("[Off状态颜色改变列表]")]
		[SerializeField]
		protected List<ToggleEx.ColorDesc> m_offStateColorList;

		// Token: 0x0400058B RID: 1419
		[FormerlySerializedAs("OffStateTweenList")]
		[Header("[Off状态Tween列表]")]
		[SerializeField]
		protected List<TweenMain> m_offStateTweenList;

		// Token: 0x0400058C RID: 1420
		protected bool m_preIsOn;

		// Token: 0x020000EB RID: 235
		[Serializable]
		public class ColorDesc
		{
			// Token: 0x0400058D RID: 1421
			public GameObject go;

			// Token: 0x0400058E RID: 1422
			public Color color;
		}
	}
}
