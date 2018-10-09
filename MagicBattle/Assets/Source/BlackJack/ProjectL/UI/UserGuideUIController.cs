using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001007 RID: 4103
	[HotFix]
	public class UserGuideUIController : UIControllerBase
	{
		// Token: 0x06014AA7 RID: 84647 RVA: 0x0053CA98 File Offset: 0x0053AC98
		private UserGuideUIController()
		{
		}

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x06014AA8 RID: 84648 RVA: 0x0053CAA0 File Offset: 0x0053ACA0
		// (set) Token: 0x06014AA9 RID: 84649 RVA: 0x0053CB1C File Offset: 0x0053AD1C
		public bool EnableBackgroundButton
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_EnableBackgroundButton_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_EnableBackgroundButton_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_backgroundButton.gameObject.activeSelf;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_EnableBackgroundButtonBoolean_hotfix != null)
				{
					this.m_set_EnableBackgroundButtonBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_backgroundButton.gameObject.SetActive(value);
				Image component = this.m_functionOpenGameObject.GetComponent<Image>();
				if (component != null)
				{
					component.enabled = value;
				}
			}
		}

		// Token: 0x06014AAA RID: 84650 RVA: 0x0053CBBC File Offset: 0x0053ADBC
		public void EnableInput(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableInputBoolean_hotfix != null)
			{
				this.m_EnableInputBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_disableInputObject.SetActive(!enable);
		}

		// Token: 0x06014AAB RID: 84651 RVA: 0x0053CC3C File Offset: 0x0053AE3C
		public bool IsDisableInputObject(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsDisableInputObjectGameObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsDisableInputObjectGameObject_hotfix.call(new object[]
				{
					this,
					obj
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_disableInputObject == obj;
		}

		// Token: 0x06014AAC RID: 84652 RVA: 0x0053CCC4 File Offset: 0x0053AEC4
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_nextPageButton.onClick.AddListener(new UnityAction(this.OnNextPageButtonClick));
			this.m_prevPageButton.onClick.AddListener(new UnityAction(this.OnPrevPageButtonClick));
			this.m_closePageButton.onClick.AddListener(new UnityAction(this.OnClosePageButtonClick));
			this.m_pageBackgroundButton.onClick.AddListener(new UnityAction(this.OnClosePageButtonClick));
			this.m_BtnSkipGuide.onClick.AddListener(new UnityAction(this.OnBtnSkipGuideClick));
			this.m_camera = base.GetComponentInParent<Camera>();
			this.m_maskTransform.gameObject.SetActive(false);
			this.HideIndicator();
			this.m_pagesGameObject.SetActive(false);
		}

		// Token: 0x06014AAD RID: 84653 RVA: 0x0053CE04 File Offset: 0x0053B004
		public void ShowFunctionOpen(string functionName, string animPrefabName, Action onAnimEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowFunctionOpenStringStringAction_hotfix != null)
			{
				this.m_ShowFunctionOpenStringStringAction_hotfix.call(new object[]
				{
					this,
					functionName,
					animPrefabName,
					onAnimEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_functionOpenGameObject.SetActive(true);
			if (this.m_functionOpenUIStateController != null)
			{
				UnityEngine.Object.Destroy(this.m_functionOpenUIStateController.gameObject);
				this.m_functionOpenUIStateController = null;
			}
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(animPrefabName);
			if (asset != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(asset, this.m_functionOpenGameObject.transform, false);
				string[] array = new string[]
				{
					"Detail/Text/Text1",
					"Detail/Text"
				};
				foreach (string text in array)
				{
					GameObject gameObject2 = GameObjectUtility.FindChildObject(gameObject, text.Split(new char[]
					{
						'/'
					}));
					Text text2 = null;
					if (gameObject2 != null)
					{
						text2 = gameObject2.GetComponent<Text>();
						if (text2 != null)
						{
							text2.text = functionName;
						}
					}
					if (!string.IsNullOrEmpty(functionName) && text2 == null)
					{
						global::Debug.LogError(string.Format("UserGuideUIController.ShowFunctionOpen Failed to find {0} from {1} to set functionName {2}", text, animPrefabName, functionName));
					}
				}
				this.m_functionOpenUIStateController = gameObject.GetComponent<CommonUIStateController>();
				UIUtility.SetUIStateOpen(this.m_functionOpenUIStateController, "Open", onAnimEnd, false, true);
				if (this.AutoInitLocalizedString && gameObject != null)
				{
					UIControllerBase.InitLocalizedString(gameObject);
				}
			}
		}

		// Token: 0x06014AAE RID: 84654 RVA: 0x0053CFDC File Offset: 0x0053B1DC
		public void HideFunctionOpen()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideFunctionOpen_hotfix != null)
			{
				this.m_HideFunctionOpen_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_functionOpenGameObject.SetActive(false);
		}

		// Token: 0x06014AAF RID: 84655 RVA: 0x0053D048 File Offset: 0x0053B248
		public void ShowUserGuideTips(string tipsText)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowUserGuideTipsString_hotfix != null)
			{
				this.m_ShowUserGuideTipsString_hotfix.call(new object[]
				{
					this,
					tipsText
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_userGuideTipsText.text = tipsText;
			this.m_userGuideTipsObject.SetActive(true);
		}

		// Token: 0x06014AB0 RID: 84656 RVA: 0x0053D0D0 File Offset: 0x0053B2D0
		public void HideUserGuideTips()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideUserGuideTips_hotfix != null)
			{
				this.m_HideUserGuideTips_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_userGuideTipsObject.SetActive(false);
		}

		// Token: 0x06014AB1 RID: 84657 RVA: 0x0053D13C File Offset: 0x0053B33C
		private void _ShowMask(Vector2 pos, Vector2 size)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m__ShowMaskVector2Vector2_hotfix != null)
			{
				this.m__ShowMaskVector2Vector2_hotfix.call(new object[]
				{
					this,
					pos,
					size
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_maskTransform.gameObject.SetActive(true);
			Vector2 vector = this.m_maskTransform.rect.size * 0.5f;
			UserGuideUIController.SetRectTransformWidth(this.m_maskLeftTransform, vector.x + pos.x - size.x * 0.5f);
			UserGuideUIController.SetRectTransformWidth(this.m_maskRightTransform, vector.x - pos.x - size.x * 0.5f);
			this.m_maskTopTransform.sizeDelta = new Vector2(size.x, vector.y - pos.y - size.y * 0.5f);
			this.m_maskTopTransform.anchoredPosition = new Vector2(pos.x, 0f);
			this.m_maskBottomTransform.sizeDelta = new Vector2(size.x, vector.y + pos.y - size.y * 0.5f);
			this.m_maskBottomTransform.anchoredPosition = new Vector2(pos.x, 0f);
		}

		// Token: 0x06014AB2 RID: 84658 RVA: 0x0053D2DC File Offset: 0x0053B4DC
		public void ShowClickMask(Vector2 screenPos, Vector2 screenSize)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowClickMaskVector2Vector2_hotfix != null)
			{
				this.m_ShowClickMaskVector2Vector2_hotfix.call(new object[]
				{
					this,
					screenPos,
					screenSize
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Vector2 vector = UIUtility.ScreenToLocalPosition(screenPos, this.m_maskTransform, this.m_camera);
			Vector2 a = UIUtility.ScreenToLocalPosition(screenPos + screenSize, this.m_maskTransform, this.m_camera);
			Vector2 size = a - vector;
			this._ShowMask(vector, size);
			this.ShowIndicator(screenPos);
			this.EnableBackgroundButton = true;
		}

		// Token: 0x06014AB3 RID: 84659 RVA: 0x0053D3A8 File Offset: 0x0053B5A8
		public void HideClickMask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideClickMask_hotfix != null)
			{
				this.m_HideClickMask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_maskTransform.gameObject.SetActive(false);
			this.HideIndicator();
		}

		// Token: 0x06014AB4 RID: 84660 RVA: 0x0053D420 File Offset: 0x0053B620
		public bool IsBgButtonObj(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBgButtonObjGameObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBgButtonObjGameObject_hotfix.call(new object[]
				{
					this,
					obj
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_backgroundButton.gameObject == obj;
		}

		// Token: 0x06014AB5 RID: 84661 RVA: 0x0053D4B0 File Offset: 0x0053B6B0
		private void ShowIndicator(Vector2 screenPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowIndicatorVector2_hotfix != null)
			{
				this.m_ShowIndicatorVector2_hotfix.call(new object[]
				{
					this,
					screenPos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HideIndicator();
			GameObject indicatorGameObject = this.GetIndicatorGameObject(screenPos);
			if (indicatorGameObject != null)
			{
				indicatorGameObject.SetActive(true);
				RectTransform rectTransform = indicatorGameObject.transform as RectTransform;
				rectTransform.anchoredPosition = UIUtility.ScreenToLocalPosition(screenPos, this.m_maskTransform, this.m_camera);
				UIUtility.ReplayTween(indicatorGameObject, null);
			}
		}

		// Token: 0x06014AB6 RID: 84662 RVA: 0x0053D56C File Offset: 0x0053B76C
		private void HideIndicator()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideIndicator_hotfix != null)
			{
				this.m_HideIndicator_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_indicatorToLeftUp.SetActive(false);
			this.m_indicatorToRightUp.SetActive(false);
			this.m_indicatorToLeftDown.SetActive(false);
			this.m_indicatorToRightDown.SetActive(false);
		}

		// Token: 0x06014AB7 RID: 84663 RVA: 0x0053D5FC File Offset: 0x0053B7FC
		private GameObject GetIndicatorGameObject(Vector2 indicateScreenPos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetIndicatorGameObjectVector2_hotfix != null)
			{
				return (GameObject)this.m_GetIndicatorGameObjectVector2_hotfix.call(new object[]
				{
					this,
					indicateScreenPos
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float num = 0.3f;
			float num2 = (float)Screen.width * num;
			float num3 = (float)Screen.height * (1f - num);
			if (indicateScreenPos.x < num2)
			{
				if (indicateScreenPos.y < num3)
				{
					return this.m_indicatorToLeftDown;
				}
				return this.m_indicatorToLeftUp;
			}
			else
			{
				if (indicateScreenPos.y < num3)
				{
					return this.m_indicatorToRightDown;
				}
				return this.m_indicatorToRightUp;
			}
		}

		// Token: 0x06014AB8 RID: 84664 RVA: 0x0053D6D8 File Offset: 0x0053B8D8
		public void PlayPageOpenTween()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayPageOpenTween_hotfix != null)
			{
				this.m_PlayPageOpenTween_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_pagesUIStateController, "Show", null, false, true);
		}

		// Token: 0x06014AB9 RID: 84665 RVA: 0x0053D74C File Offset: 0x0053B94C
		public void CreatePages(string pagesPrefab)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreatePagesString_hotfix != null)
			{
				this.m_CreatePagesString_hotfix.call(new object[]
				{
					this,
					pagesPrefab
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(pagesPrefab);
			if (asset != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(asset, this.m_pageDummyObject.transform, false);
				this.m_pagePanelObject = gameObject;
				UIUtility.LocalizedString(gameObject);
			}
		}

		// Token: 0x06014ABA RID: 84666 RVA: 0x0053D7F4 File Offset: 0x0053B9F4
		public int GetPagesCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPagesCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPagesCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_pagePanelObject.transform.childCount;
		}

		// Token: 0x06014ABB RID: 84667 RVA: 0x0053D870 File Offset: 0x0053BA70
		public void ShowPage(int index, bool hasNext, bool hasPrev)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPageInt32BooleanBoolean_hotfix != null)
			{
				this.m_ShowPageInt32BooleanBoolean_hotfix.call(new object[]
				{
					this,
					index,
					hasNext,
					hasPrev
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_pagePanelObject.transform.childCount; i++)
			{
				this.m_pagePanelObject.transform.GetChild(i).gameObject.SetActive(i == index);
			}
			this.m_nextPageButton.gameObject.SetActive(hasNext);
			this.m_prevPageButton.gameObject.SetActive(hasPrev);
		}

		// Token: 0x06014ABC RID: 84668 RVA: 0x0053D964 File Offset: 0x0053BB64
		public void HidePage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HidePage_hotfix != null)
			{
				this.m_HidePage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_pagesUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x06014ABD RID: 84669 RVA: 0x0053D9D8 File Offset: 0x0053BBD8
		public void EnableSkipButton(bool bEnable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableSkipButtonBoolean_hotfix != null)
			{
				this.m_EnableSkipButtonBoolean_hotfix.call(new object[]
				{
					this,
					bEnable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_BtnSkipGuide.gameObject.SetActive(bEnable);
		}

		// Token: 0x06014ABE RID: 84670 RVA: 0x0053DA5C File Offset: 0x0053BC5C
		private static void SetRectTransformWidth(RectTransform rt, float w)
		{
			Vector2 sizeDelta = rt.sizeDelta;
			sizeDelta.x = w;
			rt.sizeDelta = sizeDelta;
		}

		// Token: 0x06014ABF RID: 84671 RVA: 0x0053DA80 File Offset: 0x0053BC80
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnNext != null)
			{
				this.EventOnNext();
			}
		}

		// Token: 0x06014AC0 RID: 84672 RVA: 0x0053DAF8 File Offset: 0x0053BCF8
		private void OnNextPageButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNextPageButtonClick_hotfix != null)
			{
				this.m_OnNextPageButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnNextPage != null)
			{
				this.EventOnNextPage();
			}
		}

		// Token: 0x06014AC1 RID: 84673 RVA: 0x0053DB70 File Offset: 0x0053BD70
		private void OnPrevPageButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPrevPageButtonClick_hotfix != null)
			{
				this.m_OnPrevPageButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnPrevPage != null)
			{
				this.EventOnPrevPage();
			}
		}

		// Token: 0x06014AC2 RID: 84674 RVA: 0x0053DBE8 File Offset: 0x0053BDE8
		private void OnClosePageButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClosePageButtonClick_hotfix != null)
			{
				this.m_OnClosePageButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_pagesUIStateController, "Close", delegate
			{
				GameObjectUtility.DestroyChildren(this.m_pageDummyObject);
				if (this.EventOnNext != null)
				{
					this.EventOnNext();
				}
			}, false, true);
		}

		// Token: 0x06014AC3 RID: 84675 RVA: 0x0053DC68 File Offset: 0x0053BE68
		private void OnBtnSkipGuideClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBtnSkipGuideClick_hotfix != null)
			{
				this.m_OnBtnSkipGuideClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSkip != null)
			{
				this.EventOnSkip();
			}
		}

		// Token: 0x1400048E RID: 1166
		// (add) Token: 0x06014AC4 RID: 84676 RVA: 0x0053DCE0 File Offset: 0x0053BEE0
		// (remove) Token: 0x06014AC5 RID: 84677 RVA: 0x0053DD7C File Offset: 0x0053BF7C
		public event Action EventOnNext
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNextAction_hotfix != null)
				{
					this.m_add_EventOnNextAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNext;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNext, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNextAction_hotfix != null)
				{
					this.m_remove_EventOnNextAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNext;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNext, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400048F RID: 1167
		// (add) Token: 0x06014AC6 RID: 84678 RVA: 0x0053DE18 File Offset: 0x0053C018
		// (remove) Token: 0x06014AC7 RID: 84679 RVA: 0x0053DEB4 File Offset: 0x0053C0B4
		public event Action EventOnNextPage
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnNextPageAction_hotfix != null)
				{
					this.m_add_EventOnNextPageAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNextPage;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNextPage, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnNextPageAction_hotfix != null)
				{
					this.m_remove_EventOnNextPageAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnNextPage;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnNextPage, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000490 RID: 1168
		// (add) Token: 0x06014AC8 RID: 84680 RVA: 0x0053DF50 File Offset: 0x0053C150
		// (remove) Token: 0x06014AC9 RID: 84681 RVA: 0x0053DFEC File Offset: 0x0053C1EC
		public event Action EventOnPrevPage
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPrevPageAction_hotfix != null)
				{
					this.m_add_EventOnPrevPageAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPrevPage;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPrevPage, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPrevPageAction_hotfix != null)
				{
					this.m_remove_EventOnPrevPageAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPrevPage;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPrevPage, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000491 RID: 1169
		// (add) Token: 0x06014ACA RID: 84682 RVA: 0x0053E088 File Offset: 0x0053C288
		// (remove) Token: 0x06014ACB RID: 84683 RVA: 0x0053E124 File Offset: 0x0053C324
		public event Action EventOnSkip
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkipAction_hotfix != null)
				{
					this.m_add_EventOnSkipAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkip;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkip, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkipAction_hotfix != null)
				{
					this.m_remove_EventOnSkipAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSkip;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSkip, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x06014ACC RID: 84684 RVA: 0x0053E1C0 File Offset: 0x0053C3C0
		// (set) Token: 0x06014ACD RID: 84685 RVA: 0x0053E1E0 File Offset: 0x0053C3E0
		[DoNotToLua]
		public new UserGuideUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UserGuideUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014ACE RID: 84686 RVA: 0x0053E1EC File Offset: 0x0053C3EC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014ACF RID: 84687 RVA: 0x0053E1F8 File Offset: 0x0053C3F8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014AD0 RID: 84688 RVA: 0x0053E200 File Offset: 0x0053C400
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014AD1 RID: 84689 RVA: 0x0053E208 File Offset: 0x0053C408
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014AD2 RID: 84690 RVA: 0x0053E21C File Offset: 0x0053C41C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014AD3 RID: 84691 RVA: 0x0053E224 File Offset: 0x0053C424
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014AD4 RID: 84692 RVA: 0x0053E230 File Offset: 0x0053C430
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014AD5 RID: 84693 RVA: 0x0053E23C File Offset: 0x0053C43C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014AD6 RID: 84694 RVA: 0x0053E248 File Offset: 0x0053C448
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014AD7 RID: 84695 RVA: 0x0053E254 File Offset: 0x0053C454
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014AD8 RID: 84696 RVA: 0x0053E260 File Offset: 0x0053C460
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014AD9 RID: 84697 RVA: 0x0053E26C File Offset: 0x0053C46C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014ADA RID: 84698 RVA: 0x0053E278 File Offset: 0x0053C478
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014ADB RID: 84699 RVA: 0x0053E284 File Offset: 0x0053C484
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014ADC RID: 84700 RVA: 0x0053E290 File Offset: 0x0053C490
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014ADD RID: 84701 RVA: 0x0053E298 File Offset: 0x0053C498
		private void __callDele_EventOnNext()
		{
			Action eventOnNext = this.EventOnNext;
			if (eventOnNext != null)
			{
				eventOnNext();
			}
		}

		// Token: 0x06014ADE RID: 84702 RVA: 0x0053E2B8 File Offset: 0x0053C4B8
		private void __clearDele_EventOnNext()
		{
			this.EventOnNext = null;
		}

		// Token: 0x06014ADF RID: 84703 RVA: 0x0053E2C4 File Offset: 0x0053C4C4
		private void __callDele_EventOnNextPage()
		{
			Action eventOnNextPage = this.EventOnNextPage;
			if (eventOnNextPage != null)
			{
				eventOnNextPage();
			}
		}

		// Token: 0x06014AE0 RID: 84704 RVA: 0x0053E2E4 File Offset: 0x0053C4E4
		private void __clearDele_EventOnNextPage()
		{
			this.EventOnNextPage = null;
		}

		// Token: 0x06014AE1 RID: 84705 RVA: 0x0053E2F0 File Offset: 0x0053C4F0
		private void __callDele_EventOnPrevPage()
		{
			Action eventOnPrevPage = this.EventOnPrevPage;
			if (eventOnPrevPage != null)
			{
				eventOnPrevPage();
			}
		}

		// Token: 0x06014AE2 RID: 84706 RVA: 0x0053E310 File Offset: 0x0053C510
		private void __clearDele_EventOnPrevPage()
		{
			this.EventOnPrevPage = null;
		}

		// Token: 0x06014AE3 RID: 84707 RVA: 0x0053E31C File Offset: 0x0053C51C
		private void __callDele_EventOnSkip()
		{
			Action eventOnSkip = this.EventOnSkip;
			if (eventOnSkip != null)
			{
				eventOnSkip();
			}
		}

		// Token: 0x06014AE4 RID: 84708 RVA: 0x0053E33C File Offset: 0x0053C53C
		private void __clearDele_EventOnSkip()
		{
			this.EventOnSkip = null;
		}

		// Token: 0x06014AE6 RID: 84710 RVA: 0x0053E36C File Offset: 0x0053C56C
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
					this.m_get_EnableBackgroundButton_hotfix = (luaObj.RawGet("get_EnableBackgroundButton") as LuaFunction);
					this.m_set_EnableBackgroundButtonBoolean_hotfix = (luaObj.RawGet("set_EnableBackgroundButton") as LuaFunction);
					this.m_EnableInputBoolean_hotfix = (luaObj.RawGet("EnableInput") as LuaFunction);
					this.m_IsDisableInputObjectGameObject_hotfix = (luaObj.RawGet("IsDisableInputObject") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_ShowFunctionOpenStringStringAction_hotfix = (luaObj.RawGet("ShowFunctionOpen") as LuaFunction);
					this.m_HideFunctionOpen_hotfix = (luaObj.RawGet("HideFunctionOpen") as LuaFunction);
					this.m_ShowUserGuideTipsString_hotfix = (luaObj.RawGet("ShowUserGuideTips") as LuaFunction);
					this.m_HideUserGuideTips_hotfix = (luaObj.RawGet("HideUserGuideTips") as LuaFunction);
					this.m__ShowMaskVector2Vector2_hotfix = (luaObj.RawGet("_ShowMask") as LuaFunction);
					this.m_ShowClickMaskVector2Vector2_hotfix = (luaObj.RawGet("ShowClickMask") as LuaFunction);
					this.m_HideClickMask_hotfix = (luaObj.RawGet("HideClickMask") as LuaFunction);
					this.m_IsBgButtonObjGameObject_hotfix = (luaObj.RawGet("IsBgButtonObj") as LuaFunction);
					this.m_ShowIndicatorVector2_hotfix = (luaObj.RawGet("ShowIndicator") as LuaFunction);
					this.m_HideIndicator_hotfix = (luaObj.RawGet("HideIndicator") as LuaFunction);
					this.m_GetIndicatorGameObjectVector2_hotfix = (luaObj.RawGet("GetIndicatorGameObject") as LuaFunction);
					this.m_PlayPageOpenTween_hotfix = (luaObj.RawGet("PlayPageOpenTween") as LuaFunction);
					this.m_CreatePagesString_hotfix = (luaObj.RawGet("CreatePages") as LuaFunction);
					this.m_GetPagesCount_hotfix = (luaObj.RawGet("GetPagesCount") as LuaFunction);
					this.m_ShowPageInt32BooleanBoolean_hotfix = (luaObj.RawGet("ShowPage") as LuaFunction);
					this.m_HidePage_hotfix = (luaObj.RawGet("HidePage") as LuaFunction);
					this.m_EnableSkipButtonBoolean_hotfix = (luaObj.RawGet("EnableSkipButton") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnNextPageButtonClick_hotfix = (luaObj.RawGet("OnNextPageButtonClick") as LuaFunction);
					this.m_OnPrevPageButtonClick_hotfix = (luaObj.RawGet("OnPrevPageButtonClick") as LuaFunction);
					this.m_OnClosePageButtonClick_hotfix = (luaObj.RawGet("OnClosePageButtonClick") as LuaFunction);
					this.m_OnBtnSkipGuideClick_hotfix = (luaObj.RawGet("OnBtnSkipGuideClick") as LuaFunction);
					this.m_add_EventOnNextAction_hotfix = (luaObj.RawGet("add_EventOnNext") as LuaFunction);
					this.m_remove_EventOnNextAction_hotfix = (luaObj.RawGet("remove_EventOnNext") as LuaFunction);
					this.m_add_EventOnNextPageAction_hotfix = (luaObj.RawGet("add_EventOnNextPage") as LuaFunction);
					this.m_remove_EventOnNextPageAction_hotfix = (luaObj.RawGet("remove_EventOnNextPage") as LuaFunction);
					this.m_add_EventOnPrevPageAction_hotfix = (luaObj.RawGet("add_EventOnPrevPage") as LuaFunction);
					this.m_remove_EventOnPrevPageAction_hotfix = (luaObj.RawGet("remove_EventOnPrevPage") as LuaFunction);
					this.m_add_EventOnSkipAction_hotfix = (luaObj.RawGet("add_EventOnSkip") as LuaFunction);
					this.m_remove_EventOnSkipAction_hotfix = (luaObj.RawGet("remove_EventOnSkip") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014AE7 RID: 84711 RVA: 0x0053E78C File Offset: 0x0053C98C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UserGuideUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B555 RID: 46421
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x0400B556 RID: 46422
		[AutoBind("./DisableInputButton", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_disableInputObject;

		// Token: 0x0400B557 RID: 46423
		[AutoBind("./Mask", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_maskTransform;

		// Token: 0x0400B558 RID: 46424
		[AutoBind("./Mask/Left", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_maskLeftTransform;

		// Token: 0x0400B559 RID: 46425
		[AutoBind("./Mask/Right", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_maskRightTransform;

		// Token: 0x0400B55A RID: 46426
		[AutoBind("./Mask/Top", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_maskTopTransform;

		// Token: 0x0400B55B RID: 46427
		[AutoBind("./Mask/Bottom", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_maskBottomTransform;

		// Token: 0x0400B55C RID: 46428
		[AutoBind("./IndicatorToLeftDown", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_indicatorToLeftDown;

		// Token: 0x0400B55D RID: 46429
		[AutoBind("./IndicatorToRightDown", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_indicatorToRightDown;

		// Token: 0x0400B55E RID: 46430
		[AutoBind("./IndicatorToLeftUp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_indicatorToLeftUp;

		// Token: 0x0400B55F RID: 46431
		[AutoBind("./IndicatorToRightUp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_indicatorToRightUp;

		// Token: 0x0400B560 RID: 46432
		[AutoBind("./Pages", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_pagesUIStateController;

		// Token: 0x0400B561 RID: 46433
		[AutoBind("./Pages", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_pagesGameObject;

		// Token: 0x0400B562 RID: 46434
		[AutoBind("./Pages/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_pageBackgroundButton;

		// Token: 0x0400B563 RID: 46435
		[AutoBind("./Pages/UserGuidePanel/NextButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_nextPageButton;

		// Token: 0x0400B564 RID: 46436
		[AutoBind("./Pages/UserGuidePanel/PrevButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_prevPageButton;

		// Token: 0x0400B565 RID: 46437
		[AutoBind("./Pages/UserGuidePanel/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closePageButton;

		// Token: 0x0400B566 RID: 46438
		[AutoBind("./Pages/UserGuidePanel/PageDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_pageDummyObject;

		// Token: 0x0400B567 RID: 46439
		[AutoBind("./FunctionOpen", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_functionOpenGameObject;

		// Token: 0x0400B568 RID: 46440
		[AutoBind("./Tips", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_userGuideTipsObject;

		// Token: 0x0400B569 RID: 46441
		[AutoBind("./Tips/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_userGuideTipsText;

		// Token: 0x0400B56A RID: 46442
		[AutoBind("./BtnSkipGuide", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_BtnSkipGuide;

		// Token: 0x0400B56B RID: 46443
		private CommonUIStateController m_functionOpenUIStateController;

		// Token: 0x0400B56C RID: 46444
		private GameObject m_pagePanelObject;

		// Token: 0x0400B56D RID: 46445
		private Camera m_camera;

		// Token: 0x0400B56E RID: 46446
		[DoNotToLua]
		private UserGuideUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B56F RID: 46447
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B570 RID: 46448
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B571 RID: 46449
		private LuaFunction m_get_EnableBackgroundButton_hotfix;

		// Token: 0x0400B572 RID: 46450
		private LuaFunction m_set_EnableBackgroundButtonBoolean_hotfix;

		// Token: 0x0400B573 RID: 46451
		private LuaFunction m_EnableInputBoolean_hotfix;

		// Token: 0x0400B574 RID: 46452
		private LuaFunction m_IsDisableInputObjectGameObject_hotfix;

		// Token: 0x0400B575 RID: 46453
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B576 RID: 46454
		private LuaFunction m_ShowFunctionOpenStringStringAction_hotfix;

		// Token: 0x0400B577 RID: 46455
		private LuaFunction m_HideFunctionOpen_hotfix;

		// Token: 0x0400B578 RID: 46456
		private LuaFunction m_ShowUserGuideTipsString_hotfix;

		// Token: 0x0400B579 RID: 46457
		private LuaFunction m_HideUserGuideTips_hotfix;

		// Token: 0x0400B57A RID: 46458
		private LuaFunction m__ShowMaskVector2Vector2_hotfix;

		// Token: 0x0400B57B RID: 46459
		private LuaFunction m_ShowClickMaskVector2Vector2_hotfix;

		// Token: 0x0400B57C RID: 46460
		private LuaFunction m_HideClickMask_hotfix;

		// Token: 0x0400B57D RID: 46461
		private LuaFunction m_IsBgButtonObjGameObject_hotfix;

		// Token: 0x0400B57E RID: 46462
		private LuaFunction m_ShowIndicatorVector2_hotfix;

		// Token: 0x0400B57F RID: 46463
		private LuaFunction m_HideIndicator_hotfix;

		// Token: 0x0400B580 RID: 46464
		private LuaFunction m_GetIndicatorGameObjectVector2_hotfix;

		// Token: 0x0400B581 RID: 46465
		private LuaFunction m_PlayPageOpenTween_hotfix;

		// Token: 0x0400B582 RID: 46466
		private LuaFunction m_CreatePagesString_hotfix;

		// Token: 0x0400B583 RID: 46467
		private LuaFunction m_GetPagesCount_hotfix;

		// Token: 0x0400B584 RID: 46468
		private LuaFunction m_ShowPageInt32BooleanBoolean_hotfix;

		// Token: 0x0400B585 RID: 46469
		private LuaFunction m_HidePage_hotfix;

		// Token: 0x0400B586 RID: 46470
		private LuaFunction m_EnableSkipButtonBoolean_hotfix;

		// Token: 0x0400B587 RID: 46471
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x0400B588 RID: 46472
		private LuaFunction m_OnNextPageButtonClick_hotfix;

		// Token: 0x0400B589 RID: 46473
		private LuaFunction m_OnPrevPageButtonClick_hotfix;

		// Token: 0x0400B58A RID: 46474
		private LuaFunction m_OnClosePageButtonClick_hotfix;

		// Token: 0x0400B58B RID: 46475
		private LuaFunction m_OnBtnSkipGuideClick_hotfix;

		// Token: 0x0400B58C RID: 46476
		private LuaFunction m_add_EventOnNextAction_hotfix;

		// Token: 0x0400B58D RID: 46477
		private LuaFunction m_remove_EventOnNextAction_hotfix;

		// Token: 0x0400B58E RID: 46478
		private LuaFunction m_add_EventOnNextPageAction_hotfix;

		// Token: 0x0400B58F RID: 46479
		private LuaFunction m_remove_EventOnNextPageAction_hotfix;

		// Token: 0x0400B590 RID: 46480
		private LuaFunction m_add_EventOnPrevPageAction_hotfix;

		// Token: 0x0400B591 RID: 46481
		private LuaFunction m_remove_EventOnPrevPageAction_hotfix;

		// Token: 0x0400B592 RID: 46482
		private LuaFunction m_add_EventOnSkipAction_hotfix;

		// Token: 0x0400B593 RID: 46483
		private LuaFunction m_remove_EventOnSkipAction_hotfix;

		// Token: 0x02001008 RID: 4104
		public new class LuaExportHelper
		{
			// Token: 0x06014AE8 RID: 84712 RVA: 0x0053E7F4 File Offset: 0x0053C9F4
			public LuaExportHelper(UserGuideUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014AE9 RID: 84713 RVA: 0x0053E804 File Offset: 0x0053CA04
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014AEA RID: 84714 RVA: 0x0053E814 File Offset: 0x0053CA14
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014AEB RID: 84715 RVA: 0x0053E824 File Offset: 0x0053CA24
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014AEC RID: 84716 RVA: 0x0053E834 File Offset: 0x0053CA34
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014AED RID: 84717 RVA: 0x0053E84C File Offset: 0x0053CA4C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014AEE RID: 84718 RVA: 0x0053E85C File Offset: 0x0053CA5C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014AEF RID: 84719 RVA: 0x0053E86C File Offset: 0x0053CA6C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014AF0 RID: 84720 RVA: 0x0053E87C File Offset: 0x0053CA7C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014AF1 RID: 84721 RVA: 0x0053E88C File Offset: 0x0053CA8C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014AF2 RID: 84722 RVA: 0x0053E89C File Offset: 0x0053CA9C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014AF3 RID: 84723 RVA: 0x0053E8AC File Offset: 0x0053CAAC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014AF4 RID: 84724 RVA: 0x0053E8BC File Offset: 0x0053CABC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014AF5 RID: 84725 RVA: 0x0053E8CC File Offset: 0x0053CACC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014AF6 RID: 84726 RVA: 0x0053E8DC File Offset: 0x0053CADC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014AF7 RID: 84727 RVA: 0x0053E8EC File Offset: 0x0053CAEC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014AF8 RID: 84728 RVA: 0x0053E8FC File Offset: 0x0053CAFC
			public void __callDele_EventOnNext()
			{
				this.m_owner.__callDele_EventOnNext();
			}

			// Token: 0x06014AF9 RID: 84729 RVA: 0x0053E90C File Offset: 0x0053CB0C
			public void __clearDele_EventOnNext()
			{
				this.m_owner.__clearDele_EventOnNext();
			}

			// Token: 0x06014AFA RID: 84730 RVA: 0x0053E91C File Offset: 0x0053CB1C
			public void __callDele_EventOnNextPage()
			{
				this.m_owner.__callDele_EventOnNextPage();
			}

			// Token: 0x06014AFB RID: 84731 RVA: 0x0053E92C File Offset: 0x0053CB2C
			public void __clearDele_EventOnNextPage()
			{
				this.m_owner.__clearDele_EventOnNextPage();
			}

			// Token: 0x06014AFC RID: 84732 RVA: 0x0053E93C File Offset: 0x0053CB3C
			public void __callDele_EventOnPrevPage()
			{
				this.m_owner.__callDele_EventOnPrevPage();
			}

			// Token: 0x06014AFD RID: 84733 RVA: 0x0053E94C File Offset: 0x0053CB4C
			public void __clearDele_EventOnPrevPage()
			{
				this.m_owner.__clearDele_EventOnPrevPage();
			}

			// Token: 0x06014AFE RID: 84734 RVA: 0x0053E95C File Offset: 0x0053CB5C
			public void __callDele_EventOnSkip()
			{
				this.m_owner.__callDele_EventOnSkip();
			}

			// Token: 0x06014AFF RID: 84735 RVA: 0x0053E96C File Offset: 0x0053CB6C
			public void __clearDele_EventOnSkip()
			{
				this.m_owner.__clearDele_EventOnSkip();
			}

			// Token: 0x17003D1D RID: 15645
			// (get) Token: 0x06014B00 RID: 84736 RVA: 0x0053E97C File Offset: 0x0053CB7C
			// (set) Token: 0x06014B01 RID: 84737 RVA: 0x0053E98C File Offset: 0x0053CB8C
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x17003D1E RID: 15646
			// (get) Token: 0x06014B02 RID: 84738 RVA: 0x0053E99C File Offset: 0x0053CB9C
			// (set) Token: 0x06014B03 RID: 84739 RVA: 0x0053E9AC File Offset: 0x0053CBAC
			public GameObject m_disableInputObject
			{
				get
				{
					return this.m_owner.m_disableInputObject;
				}
				set
				{
					this.m_owner.m_disableInputObject = value;
				}
			}

			// Token: 0x17003D1F RID: 15647
			// (get) Token: 0x06014B04 RID: 84740 RVA: 0x0053E9BC File Offset: 0x0053CBBC
			// (set) Token: 0x06014B05 RID: 84741 RVA: 0x0053E9CC File Offset: 0x0053CBCC
			public RectTransform m_maskTransform
			{
				get
				{
					return this.m_owner.m_maskTransform;
				}
				set
				{
					this.m_owner.m_maskTransform = value;
				}
			}

			// Token: 0x17003D20 RID: 15648
			// (get) Token: 0x06014B06 RID: 84742 RVA: 0x0053E9DC File Offset: 0x0053CBDC
			// (set) Token: 0x06014B07 RID: 84743 RVA: 0x0053E9EC File Offset: 0x0053CBEC
			public RectTransform m_maskLeftTransform
			{
				get
				{
					return this.m_owner.m_maskLeftTransform;
				}
				set
				{
					this.m_owner.m_maskLeftTransform = value;
				}
			}

			// Token: 0x17003D21 RID: 15649
			// (get) Token: 0x06014B08 RID: 84744 RVA: 0x0053E9FC File Offset: 0x0053CBFC
			// (set) Token: 0x06014B09 RID: 84745 RVA: 0x0053EA0C File Offset: 0x0053CC0C
			public RectTransform m_maskRightTransform
			{
				get
				{
					return this.m_owner.m_maskRightTransform;
				}
				set
				{
					this.m_owner.m_maskRightTransform = value;
				}
			}

			// Token: 0x17003D22 RID: 15650
			// (get) Token: 0x06014B0A RID: 84746 RVA: 0x0053EA1C File Offset: 0x0053CC1C
			// (set) Token: 0x06014B0B RID: 84747 RVA: 0x0053EA2C File Offset: 0x0053CC2C
			public RectTransform m_maskTopTransform
			{
				get
				{
					return this.m_owner.m_maskTopTransform;
				}
				set
				{
					this.m_owner.m_maskTopTransform = value;
				}
			}

			// Token: 0x17003D23 RID: 15651
			// (get) Token: 0x06014B0C RID: 84748 RVA: 0x0053EA3C File Offset: 0x0053CC3C
			// (set) Token: 0x06014B0D RID: 84749 RVA: 0x0053EA4C File Offset: 0x0053CC4C
			public RectTransform m_maskBottomTransform
			{
				get
				{
					return this.m_owner.m_maskBottomTransform;
				}
				set
				{
					this.m_owner.m_maskBottomTransform = value;
				}
			}

			// Token: 0x17003D24 RID: 15652
			// (get) Token: 0x06014B0E RID: 84750 RVA: 0x0053EA5C File Offset: 0x0053CC5C
			// (set) Token: 0x06014B0F RID: 84751 RVA: 0x0053EA6C File Offset: 0x0053CC6C
			public GameObject m_indicatorToLeftDown
			{
				get
				{
					return this.m_owner.m_indicatorToLeftDown;
				}
				set
				{
					this.m_owner.m_indicatorToLeftDown = value;
				}
			}

			// Token: 0x17003D25 RID: 15653
			// (get) Token: 0x06014B10 RID: 84752 RVA: 0x0053EA7C File Offset: 0x0053CC7C
			// (set) Token: 0x06014B11 RID: 84753 RVA: 0x0053EA8C File Offset: 0x0053CC8C
			public GameObject m_indicatorToRightDown
			{
				get
				{
					return this.m_owner.m_indicatorToRightDown;
				}
				set
				{
					this.m_owner.m_indicatorToRightDown = value;
				}
			}

			// Token: 0x17003D26 RID: 15654
			// (get) Token: 0x06014B12 RID: 84754 RVA: 0x0053EA9C File Offset: 0x0053CC9C
			// (set) Token: 0x06014B13 RID: 84755 RVA: 0x0053EAAC File Offset: 0x0053CCAC
			public GameObject m_indicatorToLeftUp
			{
				get
				{
					return this.m_owner.m_indicatorToLeftUp;
				}
				set
				{
					this.m_owner.m_indicatorToLeftUp = value;
				}
			}

			// Token: 0x17003D27 RID: 15655
			// (get) Token: 0x06014B14 RID: 84756 RVA: 0x0053EABC File Offset: 0x0053CCBC
			// (set) Token: 0x06014B15 RID: 84757 RVA: 0x0053EACC File Offset: 0x0053CCCC
			public GameObject m_indicatorToRightUp
			{
				get
				{
					return this.m_owner.m_indicatorToRightUp;
				}
				set
				{
					this.m_owner.m_indicatorToRightUp = value;
				}
			}

			// Token: 0x17003D28 RID: 15656
			// (get) Token: 0x06014B16 RID: 84758 RVA: 0x0053EADC File Offset: 0x0053CCDC
			// (set) Token: 0x06014B17 RID: 84759 RVA: 0x0053EAEC File Offset: 0x0053CCEC
			public CommonUIStateController m_pagesUIStateController
			{
				get
				{
					return this.m_owner.m_pagesUIStateController;
				}
				set
				{
					this.m_owner.m_pagesUIStateController = value;
				}
			}

			// Token: 0x17003D29 RID: 15657
			// (get) Token: 0x06014B18 RID: 84760 RVA: 0x0053EAFC File Offset: 0x0053CCFC
			// (set) Token: 0x06014B19 RID: 84761 RVA: 0x0053EB0C File Offset: 0x0053CD0C
			public GameObject m_pagesGameObject
			{
				get
				{
					return this.m_owner.m_pagesGameObject;
				}
				set
				{
					this.m_owner.m_pagesGameObject = value;
				}
			}

			// Token: 0x17003D2A RID: 15658
			// (get) Token: 0x06014B1A RID: 84762 RVA: 0x0053EB1C File Offset: 0x0053CD1C
			// (set) Token: 0x06014B1B RID: 84763 RVA: 0x0053EB2C File Offset: 0x0053CD2C
			public Button m_pageBackgroundButton
			{
				get
				{
					return this.m_owner.m_pageBackgroundButton;
				}
				set
				{
					this.m_owner.m_pageBackgroundButton = value;
				}
			}

			// Token: 0x17003D2B RID: 15659
			// (get) Token: 0x06014B1C RID: 84764 RVA: 0x0053EB3C File Offset: 0x0053CD3C
			// (set) Token: 0x06014B1D RID: 84765 RVA: 0x0053EB4C File Offset: 0x0053CD4C
			public Button m_nextPageButton
			{
				get
				{
					return this.m_owner.m_nextPageButton;
				}
				set
				{
					this.m_owner.m_nextPageButton = value;
				}
			}

			// Token: 0x17003D2C RID: 15660
			// (get) Token: 0x06014B1E RID: 84766 RVA: 0x0053EB5C File Offset: 0x0053CD5C
			// (set) Token: 0x06014B1F RID: 84767 RVA: 0x0053EB6C File Offset: 0x0053CD6C
			public Button m_prevPageButton
			{
				get
				{
					return this.m_owner.m_prevPageButton;
				}
				set
				{
					this.m_owner.m_prevPageButton = value;
				}
			}

			// Token: 0x17003D2D RID: 15661
			// (get) Token: 0x06014B20 RID: 84768 RVA: 0x0053EB7C File Offset: 0x0053CD7C
			// (set) Token: 0x06014B21 RID: 84769 RVA: 0x0053EB8C File Offset: 0x0053CD8C
			public Button m_closePageButton
			{
				get
				{
					return this.m_owner.m_closePageButton;
				}
				set
				{
					this.m_owner.m_closePageButton = value;
				}
			}

			// Token: 0x17003D2E RID: 15662
			// (get) Token: 0x06014B22 RID: 84770 RVA: 0x0053EB9C File Offset: 0x0053CD9C
			// (set) Token: 0x06014B23 RID: 84771 RVA: 0x0053EBAC File Offset: 0x0053CDAC
			public GameObject m_pageDummyObject
			{
				get
				{
					return this.m_owner.m_pageDummyObject;
				}
				set
				{
					this.m_owner.m_pageDummyObject = value;
				}
			}

			// Token: 0x17003D2F RID: 15663
			// (get) Token: 0x06014B24 RID: 84772 RVA: 0x0053EBBC File Offset: 0x0053CDBC
			// (set) Token: 0x06014B25 RID: 84773 RVA: 0x0053EBCC File Offset: 0x0053CDCC
			public GameObject m_functionOpenGameObject
			{
				get
				{
					return this.m_owner.m_functionOpenGameObject;
				}
				set
				{
					this.m_owner.m_functionOpenGameObject = value;
				}
			}

			// Token: 0x17003D30 RID: 15664
			// (get) Token: 0x06014B26 RID: 84774 RVA: 0x0053EBDC File Offset: 0x0053CDDC
			// (set) Token: 0x06014B27 RID: 84775 RVA: 0x0053EBEC File Offset: 0x0053CDEC
			public GameObject m_userGuideTipsObject
			{
				get
				{
					return this.m_owner.m_userGuideTipsObject;
				}
				set
				{
					this.m_owner.m_userGuideTipsObject = value;
				}
			}

			// Token: 0x17003D31 RID: 15665
			// (get) Token: 0x06014B28 RID: 84776 RVA: 0x0053EBFC File Offset: 0x0053CDFC
			// (set) Token: 0x06014B29 RID: 84777 RVA: 0x0053EC0C File Offset: 0x0053CE0C
			public Text m_userGuideTipsText
			{
				get
				{
					return this.m_owner.m_userGuideTipsText;
				}
				set
				{
					this.m_owner.m_userGuideTipsText = value;
				}
			}

			// Token: 0x17003D32 RID: 15666
			// (get) Token: 0x06014B2A RID: 84778 RVA: 0x0053EC1C File Offset: 0x0053CE1C
			// (set) Token: 0x06014B2B RID: 84779 RVA: 0x0053EC2C File Offset: 0x0053CE2C
			public Button m_BtnSkipGuide
			{
				get
				{
					return this.m_owner.m_BtnSkipGuide;
				}
				set
				{
					this.m_owner.m_BtnSkipGuide = value;
				}
			}

			// Token: 0x17003D33 RID: 15667
			// (get) Token: 0x06014B2C RID: 84780 RVA: 0x0053EC3C File Offset: 0x0053CE3C
			// (set) Token: 0x06014B2D RID: 84781 RVA: 0x0053EC4C File Offset: 0x0053CE4C
			public CommonUIStateController m_functionOpenUIStateController
			{
				get
				{
					return this.m_owner.m_functionOpenUIStateController;
				}
				set
				{
					this.m_owner.m_functionOpenUIStateController = value;
				}
			}

			// Token: 0x17003D34 RID: 15668
			// (get) Token: 0x06014B2E RID: 84782 RVA: 0x0053EC5C File Offset: 0x0053CE5C
			// (set) Token: 0x06014B2F RID: 84783 RVA: 0x0053EC6C File Offset: 0x0053CE6C
			public GameObject m_pagePanelObject
			{
				get
				{
					return this.m_owner.m_pagePanelObject;
				}
				set
				{
					this.m_owner.m_pagePanelObject = value;
				}
			}

			// Token: 0x17003D35 RID: 15669
			// (get) Token: 0x06014B30 RID: 84784 RVA: 0x0053EC7C File Offset: 0x0053CE7C
			// (set) Token: 0x06014B31 RID: 84785 RVA: 0x0053EC8C File Offset: 0x0053CE8C
			public Camera m_camera
			{
				get
				{
					return this.m_owner.m_camera;
				}
				set
				{
					this.m_owner.m_camera = value;
				}
			}

			// Token: 0x06014B32 RID: 84786 RVA: 0x0053EC9C File Offset: 0x0053CE9C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014B33 RID: 84787 RVA: 0x0053ECAC File Offset: 0x0053CEAC
			public void _ShowMask(Vector2 pos, Vector2 size)
			{
				this.m_owner._ShowMask(pos, size);
			}

			// Token: 0x06014B34 RID: 84788 RVA: 0x0053ECBC File Offset: 0x0053CEBC
			public void ShowIndicator(Vector2 screenPos)
			{
				this.m_owner.ShowIndicator(screenPos);
			}

			// Token: 0x06014B35 RID: 84789 RVA: 0x0053ECCC File Offset: 0x0053CECC
			public void HideIndicator()
			{
				this.m_owner.HideIndicator();
			}

			// Token: 0x06014B36 RID: 84790 RVA: 0x0053ECDC File Offset: 0x0053CEDC
			public GameObject GetIndicatorGameObject(Vector2 indicateScreenPos)
			{
				return this.m_owner.GetIndicatorGameObject(indicateScreenPos);
			}

			// Token: 0x06014B37 RID: 84791 RVA: 0x0053ECEC File Offset: 0x0053CEEC
			public static void SetRectTransformWidth(RectTransform rt, float w)
			{
				UserGuideUIController.SetRectTransformWidth(rt, w);
			}

			// Token: 0x06014B38 RID: 84792 RVA: 0x0053ECF8 File Offset: 0x0053CEF8
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x06014B39 RID: 84793 RVA: 0x0053ED08 File Offset: 0x0053CF08
			public void OnNextPageButtonClick()
			{
				this.m_owner.OnNextPageButtonClick();
			}

			// Token: 0x06014B3A RID: 84794 RVA: 0x0053ED18 File Offset: 0x0053CF18
			public void OnPrevPageButtonClick()
			{
				this.m_owner.OnPrevPageButtonClick();
			}

			// Token: 0x06014B3B RID: 84795 RVA: 0x0053ED28 File Offset: 0x0053CF28
			public void OnClosePageButtonClick()
			{
				this.m_owner.OnClosePageButtonClick();
			}

			// Token: 0x06014B3C RID: 84796 RVA: 0x0053ED38 File Offset: 0x0053CF38
			public void OnBtnSkipGuideClick()
			{
				this.m_owner.OnBtnSkipGuideClick();
			}

			// Token: 0x0400B594 RID: 46484
			private UserGuideUIController m_owner;
		}
	}
}
