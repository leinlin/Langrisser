using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x020000E3 RID: 227
	public class CommonUIStateController : MonoBehaviour
	{
		// Token: 0x06000893 RID: 2195 RVA: 0x00025618 File Offset: 0x00023818
		public void SetToUIState(string stateName, bool notPlayTweens = false, bool allowToRefreshSameState = true)
		{
			UIStateDesc uistateDescByName = this.GetUIStateDescByName(stateName);
			if (uistateDescByName == null)
			{
				global::Debug.LogError(string.Format("CommonUIStateController::SetToUIState UIState Find Fail:  GoName:{0}  stateName:{1}", base.gameObject.name, stateName));
				return;
			}
			if (this.m_currUIState != null && this.m_currUIState.StateName == stateName && !allowToRefreshSameState)
			{
				return;
			}
			this.m_currUIState = uistateDescByName;
			UIStateDesc currUIState = this.m_currUIState;
			bool flag = false;
			this.m_currUIState.TweenFinished = flag;
			currUIState.AnimationFinished = flag;
			if (!this.isGathed)
			{
				this.ReGatherDynamicGo();
			}
			foreach (GameObject gameObject in this.DisableGoList)
			{
				gameObject.SetActive(false);
			}
			foreach (UIStateDesc uistateDesc in this.UIStateDescList)
			{
				if (uistateDesc.StateName == stateName)
				{
					foreach (GameObject gameObject2 in uistateDesc.SetToShowGameObjectList)
					{
						if (gameObject2 != null)
						{
							gameObject2.SetActive(true);
						}
					}
					if (uistateDesc.StateColorSetIndex >= 0 && this.UIStateColorSetList.Count > 0 && uistateDesc.StateColorSetIndex < this.UIStateColorSetList.Count)
					{
						ColorSetDesc colorSetDesc = this.UIStateColorSetList[uistateDesc.StateColorSetIndex];
						this.ChangeToColor(colorSetDesc.UIStateColorDescList);
						this.NotifyColorChanged(colorSetDesc.UIStateColorDescList);
					}
					if (this.AnimationController == null)
					{
						this.OnStateExit(this.m_currUIState.StateName);
					}
					if (uistateDesc.TweenAnimationList.Count == 0 || notPlayTweens)
					{
						this.OnAllUIStateTweensFinished();
					}
					else
					{
						foreach (TweenMain tweenMain in uistateDesc.TweenAnimationList)
						{
							if (!(tweenMain == null))
							{
								tweenMain.gameObject.SetActive(true);
							}
						}
						foreach (TweenMain tweenMain2 in uistateDesc.TweenAnimationList)
						{
							if (!(tweenMain2 == null))
							{
								tweenMain2.ResetToBeginning();
								tweenMain2.PlayForward();
							}
						}
						foreach (TweenMain tweenMain3 in this.m_allTweens)
						{
							if (!(tweenMain3 == null))
							{
								if (!uistateDesc.TweenAnimationList.Contains(tweenMain3))
								{
									tweenMain3.enabled = false;
								}
							}
						}
					}
					if (this.AnimationController != null)
					{
						this.AnimationController.SetTrigger(uistateDesc.StateName);
						this.AnimationController.Update(0f);
					}
				}
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00025A10 File Offset: 0x00023C10
		private void ChangeToColor(List<UIStateColorDesc> colorDescList)
		{
			foreach (UIStateColorDesc uistateColorDesc in colorDescList)
			{
				foreach (Image image in uistateColorDesc.ChangeColorImageList)
				{
					image.color = uistateColorDesc.TargetColor;
				}
				foreach (Text text in uistateColorDesc.ChangeColorTextList)
				{
					text.color = uistateColorDesc.TargetColor;
				}
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00025B04 File Offset: 0x00023D04
		private void NotifyColorChanged(List<UIStateColorDesc> colorDescList)
		{
			Dictionary<GameObject, Color> dictionary = new Dictionary<GameObject, Color>();
			foreach (UIStateColorDesc uistateColorDesc in colorDescList)
			{
				if (uistateColorDesc != null && !(uistateColorDesc.ChangeColorGo == null))
				{
					dictionary[uistateColorDesc.ChangeColorGo] = uistateColorDesc.TargetColor;
				}
			}
			foreach (ButtonEx buttonEx in this.UIRelateButtonList)
			{
				buttonEx.SetBaseColorList(dictionary);
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00025BD4 File Offset: 0x00023DD4
		public void ShowNextState()
		{
			if (this.UIStateDescList.Count > 0)
			{
				this.LastStateIndex++;
				if (this.LastStateIndex >= this.UIStateDescList.Count)
				{
					this.LastStateIndex = 0;
				}
				string stateName = this.UIStateDescList[this.LastStateIndex].StateName;
				this.SetToUIState(stateName, false, true);
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00025C40 File Offset: 0x00023E40
		public void ReGatherDynamicGo()
		{
			this.DisableGoList.Clear();
			this.m_allTweens.Clear();
			foreach (UIStateDesc uistateDesc in this.UIStateDescList)
			{
				foreach (GameObject gameObject in uistateDesc.SetToShowGameObjectList)
				{
					if (gameObject != null && !this.DisableGoList.Contains(gameObject))
					{
						this.DisableGoList.Add(gameObject);
					}
				}
				foreach (TweenMain item in uistateDesc.TweenAnimationList)
				{
					if (!this.m_allTweens.Contains(item))
					{
						this.m_allTweens.Add(item);
					}
				}
			}
			this.ReGatherColorChangeImageAndText();
			foreach (UIStateDesc uistateDesc2 in this.UIStateDescList)
			{
				if (uistateDesc2.TweenAnimationList.Count != 0)
				{
					TweenMain tweenMain = null;
					float num = float.MinValue;
					foreach (TweenMain tweenMain2 in uistateDesc2.TweenAnimationList)
					{
						if (!(tweenMain2 == null))
						{
							if (tweenMain2.style == TweenMain.Style.Once && tweenMain2.duration + tweenMain2.delay > num)
							{
								num = tweenMain2.duration + tweenMain2.delay;
								tweenMain = tweenMain2;
							}
						}
					}
					if (tweenMain != null)
					{
						tweenMain.OnFinished.RemoveAllListeners();
						tweenMain.OnFinished.AddListener(new UnityAction(this.OnAllUIStateTweensFinished));
					}
				}
			}
			this.isGathed = true;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00025EB4 File Offset: 0x000240B4
		public void OnStateExit(string stateName)
		{
			UIStateDesc uistateDescByName = this.GetUIStateDescByName(stateName);
			if (uistateDescByName == null)
			{
				global::Debug.LogError(string.Format("OnStateExit() receive a unknown stateName: {0}.", stateName));
				return;
			}
			if (this.m_currUIState != uistateDescByName)
			{
				global::Debug.LogError(string.Format("Current state is not: {0}.", stateName));
				return;
			}
			uistateDescByName.AnimationFinished = true;
			if (uistateDescByName.TweenFinished && CommonUIStateController.m_onUIStateEndEvent != null)
			{
				CommonUIStateController.m_onUIStateEndEvent(base.gameObject, stateName);
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00025F2C File Offset: 0x0002412C
		public void OnPlaySound(string soundName)
		{
			if (string.IsNullOrEmpty(soundName))
			{
				return;
			}
			if (GameManager.Instance == null || GameManager.Instance.AudioManager == null)
			{
				return;
			}
			GameManager.Instance.AudioManager.PlaySound(soundName, 1f);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00025F6C File Offset: 0x0002416C
		public bool SetActionForUIStateFinshed(string stateName, Action action)
		{
			UIStateDesc uistateDescByName = this.GetUIStateDescByName(stateName);
			if (uistateDescByName == null)
			{
				return false;
			}
			uistateDescByName.m_eventFinished = action;
			return true;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00025F94 File Offset: 0x00024194
		public UIStateDesc GetUIStateDescByName(string name)
		{
			foreach (UIStateDesc uistateDesc in this.UIStateDescList)
			{
				if (uistateDesc.StateName == name)
				{
					return uistateDesc;
				}
			}
			return null;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00026004 File Offset: 0x00024204
		public UIStateDesc GetCurrentUIState()
		{
			return this.m_currUIState;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0002600C File Offset: 0x0002420C
		private void ReGatherColorChangeImageAndText()
		{
			foreach (ColorSetDesc colorSetDesc in this.UIStateColorSetList)
			{
				foreach (UIStateColorDesc uistateColorDesc in colorSetDesc.UIStateColorDescList)
				{
					uistateColorDesc.ChangeColorImageList.Clear();
					uistateColorDesc.ChangeColorTextList.Clear();
					if (uistateColorDesc.ChangeColorGo != null)
					{
						Image[] components = uistateColorDesc.ChangeColorGo.GetComponents<Image>();
						foreach (Image image in components)
						{
							if (image != null && !uistateColorDesc.ChangeColorImageList.Contains(image))
							{
								uistateColorDesc.ChangeColorImageList.Add(image);
							}
						}
						Text[] components2 = uistateColorDesc.ChangeColorGo.GetComponents<Text>();
						foreach (Text text in components2)
						{
							if (text != null && !uistateColorDesc.ChangeColorTextList.Contains(text))
							{
								uistateColorDesc.ChangeColorTextList.Add(text);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000261A0 File Offset: 0x000243A0
		private void OnAllUIStateTweensFinished()
		{
			if (this.m_currUIState == null)
			{
				return;
			}
			this.m_currUIState.TweenFinished = true;
			if (this.m_currUIState.AnimationFinished && CommonUIStateController.m_onUIStateEndEvent != null)
			{
				CommonUIStateController.m_onUIStateEndEvent(base.gameObject, this.m_currUIState.StateName);
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x0600089F RID: 2207 RVA: 0x000261FC File Offset: 0x000243FC
		// (remove) Token: 0x060008A0 RID: 2208 RVA: 0x00026230 File Offset: 0x00024430
		[HideInInspector]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<GameObject, string> m_onUIStateEndEvent;

		// Token: 0x04000560 RID: 1376
		public List<UIStateDesc> UIStateDescList = new List<UIStateDesc>();

		// Token: 0x04000561 RID: 1377
		public List<ColorSetDesc> UIStateColorSetList = new List<ColorSetDesc>();

		// Token: 0x04000562 RID: 1378
		public List<ButtonEx> UIRelateButtonList = new List<ButtonEx>();

		// Token: 0x04000563 RID: 1379
		public bool EnablePressColor;

		// Token: 0x04000564 RID: 1380
		public int PressColorIndex;

		// Token: 0x04000565 RID: 1381
		public Animator AnimationController;

		// Token: 0x04000566 RID: 1382
		[HideInInspector]
		public List<GameObject> DisableGoList = new List<GameObject>();

		// Token: 0x04000567 RID: 1383
		[HideInInspector]
		public int LastStateIndex;

		// Token: 0x04000568 RID: 1384
		private bool isGathed;

		// Token: 0x04000569 RID: 1385
		private UIStateDesc m_currUIState;

		// Token: 0x0400056A RID: 1386
		private List<TweenMain> m_allTweens = new List<TweenMain>();
	}
}
