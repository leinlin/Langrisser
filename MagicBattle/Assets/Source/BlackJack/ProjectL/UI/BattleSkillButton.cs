using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AD6 RID: 2774
	[HotFix]
	public class BattleSkillButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x0600B6AB RID: 46763 RVA: 0x003257F4 File Offset: 0x003239F4
		private void Awake()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Awake_hotfix != null)
			{
				this.m_Awake_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_iconImage = Utility.FindChildComponent<Image>(base.gameObject, "IconImage", false);
			this.m_frameImage = Utility.FindChildComponent<Image>(base.gameObject, "FrameImage", false);
			this.m_cooldownGameObject = Utility.FindChildGameObject(base.gameObject, "Cooldown", false);
			this.m_cooldownText = Utility.FindChildComponent<Text>(this.m_cooldownGameObject, "Text", false);
			this.m_selectedGameObject = Utility.FindChildGameObject(base.gameObject, "Selected", false);
			this.m_costGameObject = Utility.FindChildGameObject(base.gameObject, "Cost", false);
			this.m_passiveGameObject = Utility.FindChildGameObject(base.gameObject, "Passive", false);
			this.m_banGameObject = Utility.FindChildGameObject(base.gameObject, "Ban", false);
			this.m_isHandleLongDown = true;
		}

		// Token: 0x0600B6AC RID: 46764 RVA: 0x00325914 File Offset: 0x00323B14
		public void SetIndex(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIndexInt32_hotfix != null)
			{
				this.m_SetIndexInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_index = index;
		}

		// Token: 0x0600B6AD RID: 46765 RVA: 0x0032598C File Offset: 0x00323B8C
		public int GetIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_index;
		}

		// Token: 0x0600B6AE RID: 46766 RVA: 0x00325A00 File Offset: 0x00323C00
		public void SetSkillInfo(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkillInfoConfigDataSkillInfo_hotfix != null)
			{
				this.m_SetSkillInfoConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			this.m_skillInfo = skillInfo;
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(skillInfo.Icon);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_costGameObject, skillInfo.SkillCost);
			this.m_passiveGameObject.SetActive(skillInfo.IsPassiveSkill());
		}

		// Token: 0x0600B6AF RID: 46767 RVA: 0x00325ABC File Offset: 0x00323CBC
		public ConfigDataSkillInfo GetSkillInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSkillInfo_hotfix != null)
			{
				return (ConfigDataSkillInfo)this.m_GetSkillInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_skillInfo;
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x00325B30 File Offset: 0x00323D30
		public void SetCooldown(int cd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCooldownInt32_hotfix != null)
			{
				this.m_SetCooldownInt32_hotfix.call(new object[]
				{
					this,
					cd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_cooldownGameObject != null)
			{
				this.m_cooldownGameObject.SetActive(cd > 0);
				if (cd > 0 && this.m_cooldownText != null)
				{
					this.m_cooldownText.text = cd.ToString();
				}
			}
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x00325BF0 File Offset: 0x00323DF0
		public void SetSelected(bool selected)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectedBoolean_hotfix != null)
			{
				this.m_SetSelectedBoolean_hotfix.call(new object[]
				{
					this,
					selected
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isSelected = selected;
			if (this.m_selectedGameObject != null)
			{
				this.m_selectedGameObject.SetActive(selected);
			}
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x00325C84 File Offset: 0x00323E84
		public bool IsSelected()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSelected_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSelected_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isSelected;
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x00325CF8 File Offset: 0x00323EF8
		public void ShowCost(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCostBoolean_hotfix != null)
			{
				this.m_ShowCostBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_costGameObject != null)
			{
				this.m_costGameObject.SetActive(isShow);
			}
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x00325D88 File Offset: 0x00323F88
		public void ShowFrame(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowFrameBoolean_hotfix != null)
			{
				this.m_ShowFrameBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_frameImage != null)
			{
				this.m_frameImage.gameObject.SetActive(isShow);
			}
		}

		// Token: 0x0600B6B5 RID: 46773 RVA: 0x00325E1C File Offset: 0x0032401C
		public void SetBanned(bool banned)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBannedBoolean_hotfix != null)
			{
				this.m_SetBannedBoolean_hotfix.call(new object[]
				{
					this,
					banned
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isBanned = banned;
			if (this.m_banGameObject != null)
			{
				this.m_banGameObject.SetActive(banned);
			}
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x00325EB0 File Offset: 0x003240B0
		public bool IsBanned()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBanned_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBanned_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isBanned;
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x00325F24 File Offset: 0x00324124
		public void SetHandleLongDown(bool h)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHandleLongDownBoolean_hotfix != null)
			{
				this.m_SetHandleLongDownBoolean_hotfix.call(new object[]
				{
					this,
					h
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isHandleLongDown = h;
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x00325F9C File Offset: 0x0032419C
		public void SetDescGameObject(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDescGameObjectGameObject_hotfix != null)
			{
				this.m_SetDescGameObjectGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_descGameObject = go;
			this.m_descStateCtrl = this.m_descGameObject.GetComponent<CommonUIStateController>();
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x00326024 File Offset: 0x00324224
		private void ShowDesc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDesc_hotfix != null)
			{
				this.m_ShowDesc_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_skillInfo == null)
			{
				return;
			}
			if (this.m_descGameObject == null)
			{
				return;
			}
			this.m_descGameObject.SetActive(true);
			if (this.m_descStateCtrl != null)
			{
				UIUtility.SetUIStateOpen(this.m_descStateCtrl, "Show", null, false, true);
			}
			else
			{
				UIUtility.ReplayTween(this.m_descGameObject, null);
			}
			Text text = Utility.FindChildComponent<Text>(this.m_descGameObject, "Lay/FrameImage/TOP/TitleNameText", false);
			text.text = this.m_skillInfo.Name;
			GameObject obj = Utility.FindChildGameObject(this.m_descGameObject, "Lay/FrameImage/TOP/Costs", false);
			UIUtility.SetGameObjectChildrenActiveCount(obj, this.m_skillInfo.SkillCost);
			Text text2 = Utility.FindChildComponent<Text>(this.m_descGameObject, "Lay/FrameImage/SkillType/ValueText", false);
			text2.text = this.m_skillInfo.Desc;
			Text text3 = Utility.FindChildComponent<Text>(this.m_descGameObject, "Lay/FrameImage/TOP/Type/ValueText", false);
			Text text4 = Utility.FindChildComponent<Text>(this.m_descGameObject, "Lay/FrameImage/TOP/CD/ValueText", false);
			Text text5 = Utility.FindChildComponent<Text>(this.m_descGameObject, "Lay/FrameImage/TOP/Distance/ValueText", false);
			Text text6 = Utility.FindChildComponent<Text>(this.m_descGameObject, "Lay/FrameImage/TOP/Range/ValueText", false);
			text3.text = this.m_skillInfo.TypeText;
			text4.text = this.m_skillInfo.CDText;
			text5.text = this.m_skillInfo.DistanceText;
			text6.text = this.m_skillInfo.RangeText;
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x003261E0 File Offset: 0x003243E0
		private void HideDesc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideDesc_hotfix != null)
			{
				this.m_HideDesc_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_descGameObject == null)
			{
				return;
			}
			if (!this.m_descGameObject.activeSelf)
			{
				return;
			}
			if (this.m_descStateCtrl != null)
			{
				UIUtility.SetUIStateClose(this.m_descStateCtrl, "Close", null, false, true);
			}
			else
			{
				UIUtility.ReversePlayTween(this.m_descGameObject, delegate
				{
					this.m_descGameObject.SetActive(false);
				});
			}
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x003262A4 File Offset: 0x003244A4
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
			this.m_isPointerLongDown = false;
			this.m_ignoreClick = false;
			if (this.m_isHandleLongDown)
			{
				this.m_pointerLongDownCountdown = 0.5f;
			}
			else
			{
				this.ShowDesc();
			}
		}

		// Token: 0x0600B6BC RID: 46780 RVA: 0x00326344 File Offset: 0x00324544
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
			this.m_pointerLongDownCountdown = 0f;
			if (this.m_isPointerLongDown)
			{
				this.m_isPointerLongDown = false;
				this.m_ignoreClick = true;
			}
			this.HideDesc();
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x003263E0 File Offset: 0x003245E0
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
				this.EventOnClick();
			}
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x00326480 File Offset: 0x00324680
		public bool InvokeClickEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InvokeClickEvent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_InvokeClickEvent_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick == null)
			{
				return false;
			}
			this.EventOnClick();
			return true;
		}

		// Token: 0x0600B6BF RID: 46783 RVA: 0x00326508 File Offset: 0x00324708
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
			if (this.m_pointerLongDownCountdown > 0f)
			{
				this.m_pointerLongDownCountdown -= Time.unscaledDeltaTime;
				if (this.m_pointerLongDownCountdown <= 0f)
				{
					this.m_pointerLongDownCountdown = 0f;
					this.m_isPointerLongDown = true;
					this.ShowDesc();
				}
			}
		}

		// Token: 0x14000241 RID: 577
		// (add) Token: 0x0600B6C0 RID: 46784 RVA: 0x003265B4 File Offset: 0x003247B4
		// (remove) Token: 0x0600B6C1 RID: 46785 RVA: 0x00326650 File Offset: 0x00324850
		public event Action EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction_hotfix != null)
				{
					this.m_add_EventOnClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction_hotfix != null)
				{
					this.m_remove_EventOnClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x0600B6C2 RID: 46786 RVA: 0x003266EC File Offset: 0x003248EC
		// (set) Token: 0x0600B6C3 RID: 46787 RVA: 0x0032670C File Offset: 0x0032490C
		[DoNotToLua]
		public BattleSkillButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleSkillButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x00326718 File Offset: 0x00324918
		private void __callDele_EventOnClick()
		{
			Action eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick();
			}
		}

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x00326738 File Offset: 0x00324938
		private void __clearDele_EventOnClick()
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x00326754 File Offset: 0x00324954
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
					this.m_Awake_hotfix = (luaObj.RawGet("Awake") as LuaFunction);
					this.m_SetIndexInt32_hotfix = (luaObj.RawGet("SetIndex") as LuaFunction);
					this.m_GetIndex_hotfix = (luaObj.RawGet("GetIndex") as LuaFunction);
					this.m_SetSkillInfoConfigDataSkillInfo_hotfix = (luaObj.RawGet("SetSkillInfo") as LuaFunction);
					this.m_GetSkillInfo_hotfix = (luaObj.RawGet("GetSkillInfo") as LuaFunction);
					this.m_SetCooldownInt32_hotfix = (luaObj.RawGet("SetCooldown") as LuaFunction);
					this.m_SetSelectedBoolean_hotfix = (luaObj.RawGet("SetSelected") as LuaFunction);
					this.m_IsSelected_hotfix = (luaObj.RawGet("IsSelected") as LuaFunction);
					this.m_ShowCostBoolean_hotfix = (luaObj.RawGet("ShowCost") as LuaFunction);
					this.m_ShowFrameBoolean_hotfix = (luaObj.RawGet("ShowFrame") as LuaFunction);
					this.m_SetBannedBoolean_hotfix = (luaObj.RawGet("SetBanned") as LuaFunction);
					this.m_IsBanned_hotfix = (luaObj.RawGet("IsBanned") as LuaFunction);
					this.m_SetHandleLongDownBoolean_hotfix = (luaObj.RawGet("SetHandleLongDown") as LuaFunction);
					this.m_SetDescGameObjectGameObject_hotfix = (luaObj.RawGet("SetDescGameObject") as LuaFunction);
					this.m_ShowDesc_hotfix = (luaObj.RawGet("ShowDesc") as LuaFunction);
					this.m_HideDesc_hotfix = (luaObj.RawGet("HideDesc") as LuaFunction);
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_InvokeClickEvent_hotfix = (luaObj.RawGet("InvokeClickEvent") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_add_EventOnClickAction_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x00326A48 File Offset: 0x00324C48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleSkillButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040075E8 RID: 30184
		private bool m_isPointerLongDown;

		// Token: 0x040075E9 RID: 30185
		private bool m_ignoreClick;

		// Token: 0x040075EA RID: 30186
		private float m_pointerLongDownCountdown;

		// Token: 0x040075EB RID: 30187
		private Text m_cooldownText;

		// Token: 0x040075EC RID: 30188
		private Image m_iconImage;

		// Token: 0x040075ED RID: 30189
		private Image m_frameImage;

		// Token: 0x040075EE RID: 30190
		private GameObject m_cooldownGameObject;

		// Token: 0x040075EF RID: 30191
		private GameObject m_selectedGameObject;

		// Token: 0x040075F0 RID: 30192
		private GameObject m_descGameObject;

		// Token: 0x040075F1 RID: 30193
		private GameObject m_costGameObject;

		// Token: 0x040075F2 RID: 30194
		private GameObject m_passiveGameObject;

		// Token: 0x040075F3 RID: 30195
		private GameObject m_banGameObject;

		// Token: 0x040075F4 RID: 30196
		private ConfigDataSkillInfo m_skillInfo;

		// Token: 0x040075F5 RID: 30197
		private int m_index;

		// Token: 0x040075F6 RID: 30198
		private bool m_isSelected;

		// Token: 0x040075F7 RID: 30199
		private bool m_isBanned;

		// Token: 0x040075F8 RID: 30200
		private bool m_isHandleLongDown;

		// Token: 0x040075FA RID: 30202
		private CommonUIStateController m_descStateCtrl;

		// Token: 0x040075FB RID: 30203
		[DoNotToLua]
		private BattleSkillButton.LuaExportHelper luaExportHelper;

		// Token: 0x040075FC RID: 30204
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040075FD RID: 30205
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040075FE RID: 30206
		private LuaFunction m_Awake_hotfix;

		// Token: 0x040075FF RID: 30207
		private LuaFunction m_SetIndexInt32_hotfix;

		// Token: 0x04007600 RID: 30208
		private LuaFunction m_GetIndex_hotfix;

		// Token: 0x04007601 RID: 30209
		private LuaFunction m_SetSkillInfoConfigDataSkillInfo_hotfix;

		// Token: 0x04007602 RID: 30210
		private LuaFunction m_GetSkillInfo_hotfix;

		// Token: 0x04007603 RID: 30211
		private LuaFunction m_SetCooldownInt32_hotfix;

		// Token: 0x04007604 RID: 30212
		private LuaFunction m_SetSelectedBoolean_hotfix;

		// Token: 0x04007605 RID: 30213
		private LuaFunction m_IsSelected_hotfix;

		// Token: 0x04007606 RID: 30214
		private LuaFunction m_ShowCostBoolean_hotfix;

		// Token: 0x04007607 RID: 30215
		private LuaFunction m_ShowFrameBoolean_hotfix;

		// Token: 0x04007608 RID: 30216
		private LuaFunction m_SetBannedBoolean_hotfix;

		// Token: 0x04007609 RID: 30217
		private LuaFunction m_IsBanned_hotfix;

		// Token: 0x0400760A RID: 30218
		private LuaFunction m_SetHandleLongDownBoolean_hotfix;

		// Token: 0x0400760B RID: 30219
		private LuaFunction m_SetDescGameObjectGameObject_hotfix;

		// Token: 0x0400760C RID: 30220
		private LuaFunction m_ShowDesc_hotfix;

		// Token: 0x0400760D RID: 30221
		private LuaFunction m_HideDesc_hotfix;

		// Token: 0x0400760E RID: 30222
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x0400760F RID: 30223
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x04007610 RID: 30224
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x04007611 RID: 30225
		private LuaFunction m_InvokeClickEvent_hotfix;

		// Token: 0x04007612 RID: 30226
		private LuaFunction m_Update_hotfix;

		// Token: 0x04007613 RID: 30227
		private LuaFunction m_add_EventOnClickAction_hotfix;

		// Token: 0x04007614 RID: 30228
		private LuaFunction m_remove_EventOnClickAction_hotfix;

		// Token: 0x02000AD7 RID: 2775
		public class LuaExportHelper
		{
			// Token: 0x0600B6C9 RID: 46793 RVA: 0x00326AB0 File Offset: 0x00324CB0
			public LuaExportHelper(BattleSkillButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B6CA RID: 46794 RVA: 0x00326AC0 File Offset: 0x00324CC0
			public void __callDele_EventOnClick()
			{
				this.m_owner.__callDele_EventOnClick();
			}

			// Token: 0x0600B6CB RID: 46795 RVA: 0x00326AD0 File Offset: 0x00324CD0
			public void __clearDele_EventOnClick()
			{
				this.m_owner.__clearDele_EventOnClick();
			}

			// Token: 0x170024F5 RID: 9461
			// (get) Token: 0x0600B6CC RID: 46796 RVA: 0x00326AE0 File Offset: 0x00324CE0
			// (set) Token: 0x0600B6CD RID: 46797 RVA: 0x00326AF0 File Offset: 0x00324CF0
			public bool m_isPointerLongDown
			{
				get
				{
					return this.m_owner.m_isPointerLongDown;
				}
				set
				{
					this.m_owner.m_isPointerLongDown = value;
				}
			}

			// Token: 0x170024F6 RID: 9462
			// (get) Token: 0x0600B6CE RID: 46798 RVA: 0x00326B00 File Offset: 0x00324D00
			// (set) Token: 0x0600B6CF RID: 46799 RVA: 0x00326B10 File Offset: 0x00324D10
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

			// Token: 0x170024F7 RID: 9463
			// (get) Token: 0x0600B6D0 RID: 46800 RVA: 0x00326B20 File Offset: 0x00324D20
			// (set) Token: 0x0600B6D1 RID: 46801 RVA: 0x00326B30 File Offset: 0x00324D30
			public float m_pointerLongDownCountdown
			{
				get
				{
					return this.m_owner.m_pointerLongDownCountdown;
				}
				set
				{
					this.m_owner.m_pointerLongDownCountdown = value;
				}
			}

			// Token: 0x170024F8 RID: 9464
			// (get) Token: 0x0600B6D2 RID: 46802 RVA: 0x00326B40 File Offset: 0x00324D40
			// (set) Token: 0x0600B6D3 RID: 46803 RVA: 0x00326B50 File Offset: 0x00324D50
			public Text m_cooldownText
			{
				get
				{
					return this.m_owner.m_cooldownText;
				}
				set
				{
					this.m_owner.m_cooldownText = value;
				}
			}

			// Token: 0x170024F9 RID: 9465
			// (get) Token: 0x0600B6D4 RID: 46804 RVA: 0x00326B60 File Offset: 0x00324D60
			// (set) Token: 0x0600B6D5 RID: 46805 RVA: 0x00326B70 File Offset: 0x00324D70
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

			// Token: 0x170024FA RID: 9466
			// (get) Token: 0x0600B6D6 RID: 46806 RVA: 0x00326B80 File Offset: 0x00324D80
			// (set) Token: 0x0600B6D7 RID: 46807 RVA: 0x00326B90 File Offset: 0x00324D90
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

			// Token: 0x170024FB RID: 9467
			// (get) Token: 0x0600B6D8 RID: 46808 RVA: 0x00326BA0 File Offset: 0x00324DA0
			// (set) Token: 0x0600B6D9 RID: 46809 RVA: 0x00326BB0 File Offset: 0x00324DB0
			public GameObject m_cooldownGameObject
			{
				get
				{
					return this.m_owner.m_cooldownGameObject;
				}
				set
				{
					this.m_owner.m_cooldownGameObject = value;
				}
			}

			// Token: 0x170024FC RID: 9468
			// (get) Token: 0x0600B6DA RID: 46810 RVA: 0x00326BC0 File Offset: 0x00324DC0
			// (set) Token: 0x0600B6DB RID: 46811 RVA: 0x00326BD0 File Offset: 0x00324DD0
			public GameObject m_selectedGameObject
			{
				get
				{
					return this.m_owner.m_selectedGameObject;
				}
				set
				{
					this.m_owner.m_selectedGameObject = value;
				}
			}

			// Token: 0x170024FD RID: 9469
			// (get) Token: 0x0600B6DC RID: 46812 RVA: 0x00326BE0 File Offset: 0x00324DE0
			// (set) Token: 0x0600B6DD RID: 46813 RVA: 0x00326BF0 File Offset: 0x00324DF0
			public GameObject m_descGameObject
			{
				get
				{
					return this.m_owner.m_descGameObject;
				}
				set
				{
					this.m_owner.m_descGameObject = value;
				}
			}

			// Token: 0x170024FE RID: 9470
			// (get) Token: 0x0600B6DE RID: 46814 RVA: 0x00326C00 File Offset: 0x00324E00
			// (set) Token: 0x0600B6DF RID: 46815 RVA: 0x00326C10 File Offset: 0x00324E10
			public GameObject m_costGameObject
			{
				get
				{
					return this.m_owner.m_costGameObject;
				}
				set
				{
					this.m_owner.m_costGameObject = value;
				}
			}

			// Token: 0x170024FF RID: 9471
			// (get) Token: 0x0600B6E0 RID: 46816 RVA: 0x00326C20 File Offset: 0x00324E20
			// (set) Token: 0x0600B6E1 RID: 46817 RVA: 0x00326C30 File Offset: 0x00324E30
			public GameObject m_passiveGameObject
			{
				get
				{
					return this.m_owner.m_passiveGameObject;
				}
				set
				{
					this.m_owner.m_passiveGameObject = value;
				}
			}

			// Token: 0x17002500 RID: 9472
			// (get) Token: 0x0600B6E2 RID: 46818 RVA: 0x00326C40 File Offset: 0x00324E40
			// (set) Token: 0x0600B6E3 RID: 46819 RVA: 0x00326C50 File Offset: 0x00324E50
			public GameObject m_banGameObject
			{
				get
				{
					return this.m_owner.m_banGameObject;
				}
				set
				{
					this.m_owner.m_banGameObject = value;
				}
			}

			// Token: 0x17002501 RID: 9473
			// (get) Token: 0x0600B6E4 RID: 46820 RVA: 0x00326C60 File Offset: 0x00324E60
			// (set) Token: 0x0600B6E5 RID: 46821 RVA: 0x00326C70 File Offset: 0x00324E70
			public ConfigDataSkillInfo m_skillInfo
			{
				get
				{
					return this.m_owner.m_skillInfo;
				}
				set
				{
					this.m_owner.m_skillInfo = value;
				}
			}

			// Token: 0x17002502 RID: 9474
			// (get) Token: 0x0600B6E6 RID: 46822 RVA: 0x00326C80 File Offset: 0x00324E80
			// (set) Token: 0x0600B6E7 RID: 46823 RVA: 0x00326C90 File Offset: 0x00324E90
			public int m_index
			{
				get
				{
					return this.m_owner.m_index;
				}
				set
				{
					this.m_owner.m_index = value;
				}
			}

			// Token: 0x17002503 RID: 9475
			// (get) Token: 0x0600B6E8 RID: 46824 RVA: 0x00326CA0 File Offset: 0x00324EA0
			// (set) Token: 0x0600B6E9 RID: 46825 RVA: 0x00326CB0 File Offset: 0x00324EB0
			public bool m_isSelected
			{
				get
				{
					return this.m_owner.m_isSelected;
				}
				set
				{
					this.m_owner.m_isSelected = value;
				}
			}

			// Token: 0x17002504 RID: 9476
			// (get) Token: 0x0600B6EA RID: 46826 RVA: 0x00326CC0 File Offset: 0x00324EC0
			// (set) Token: 0x0600B6EB RID: 46827 RVA: 0x00326CD0 File Offset: 0x00324ED0
			public bool m_isBanned
			{
				get
				{
					return this.m_owner.m_isBanned;
				}
				set
				{
					this.m_owner.m_isBanned = value;
				}
			}

			// Token: 0x17002505 RID: 9477
			// (get) Token: 0x0600B6EC RID: 46828 RVA: 0x00326CE0 File Offset: 0x00324EE0
			// (set) Token: 0x0600B6ED RID: 46829 RVA: 0x00326CF0 File Offset: 0x00324EF0
			public bool m_isHandleLongDown
			{
				get
				{
					return this.m_owner.m_isHandleLongDown;
				}
				set
				{
					this.m_owner.m_isHandleLongDown = value;
				}
			}

			// Token: 0x17002506 RID: 9478
			// (get) Token: 0x0600B6EE RID: 46830 RVA: 0x00326D00 File Offset: 0x00324F00
			// (set) Token: 0x0600B6EF RID: 46831 RVA: 0x00326D10 File Offset: 0x00324F10
			public CommonUIStateController m_descStateCtrl
			{
				get
				{
					return this.m_owner.m_descStateCtrl;
				}
				set
				{
					this.m_owner.m_descStateCtrl = value;
				}
			}

			// Token: 0x0600B6F0 RID: 46832 RVA: 0x00326D20 File Offset: 0x00324F20
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x0600B6F1 RID: 46833 RVA: 0x00326D30 File Offset: 0x00324F30
			public void ShowDesc()
			{
				this.m_owner.ShowDesc();
			}

			// Token: 0x0600B6F2 RID: 46834 RVA: 0x00326D40 File Offset: 0x00324F40
			public void HideDesc()
			{
				this.m_owner.HideDesc();
			}

			// Token: 0x0600B6F3 RID: 46835 RVA: 0x00326D50 File Offset: 0x00324F50
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x04007615 RID: 30229
			private BattleSkillButton m_owner;
		}
	}
}
