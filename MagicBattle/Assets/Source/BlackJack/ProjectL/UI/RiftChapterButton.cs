using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000ED9 RID: 3801
	[HotFix]
	public class RiftChapterButton : UIControllerBase
	{
		// Token: 0x06012AB5 RID: 76469 RVA: 0x004C7E04 File Offset: 0x004C6004
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
			this.m_sizeUIStateController.SetToUIState("Big", false, true);
		}

		// Token: 0x06012AB6 RID: 76470 RVA: 0x004C7E98 File Offset: 0x004C6098
		public void SetChapter(ConfigDataRiftChapterInfo chapterInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChapterConfigDataRiftChapterInfo_hotfix != null)
			{
				this.m_SetChapterConfigDataRiftChapterInfo_hotfix.call(new object[]
				{
					this,
					chapterInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chapterInfo == null)
			{
				return;
			}
			this.m_chapterInfo = chapterInfo;
			this.m_image.sprite = AssetUtility.Instance.GetSprite(chapterInfo.Image);
		}

		// Token: 0x06012AB7 RID: 76471 RVA: 0x004C7F34 File Offset: 0x004C6134
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

		// Token: 0x06012AB8 RID: 76472 RVA: 0x004C7FAC File Offset: 0x004C61AC
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

		// Token: 0x06012AB9 RID: 76473 RVA: 0x004C8020 File Offset: 0x004C6220
		public ConfigDataRiftChapterInfo GetChapter()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChapter_hotfix != null)
			{
				return (ConfigDataRiftChapterInfo)this.m_GetChapter_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_chapterInfo;
		}

		// Token: 0x06012ABA RID: 76474 RVA: 0x004C8094 File Offset: 0x004C6294
		public void SetStatus(bool isLocked, bool isNew, bool isCenter)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStatusBooleanBooleanBoolean_hotfix != null)
			{
				this.m_SetStatusBooleanBooleanBoolean_hotfix.call(new object[]
				{
					this,
					isLocked,
					isNew,
					isCenter
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isLocked = isLocked;
			this.m_isNew = isNew;
			if (isLocked)
			{
				this.m_uiStateController.SetToUIState("RightLockState", false, true);
				this.m_titleObj.gameObject.SetActive(false);
			}
			else
			{
				if (isCenter)
				{
					this.m_uiStateController.SetToUIState("MiddleState", false, true);
				}
				else
				{
					this.m_uiStateController.SetToUIState("RightState", false, true);
				}
				for (int i = 0; i < this.m_titleObj.transform.childCount; i++)
				{
					this.m_titleObj.transform.GetChild(i).gameObject.SetActive(i == this.m_index);
				}
				this.m_titleObj.gameObject.SetActive(isCenter);
			}
		}

		// Token: 0x06012ABB RID: 76475 RVA: 0x004C81E8 File Offset: 0x004C63E8
		public bool IsLocked()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLocked_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLocked_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isLocked;
		}

		// Token: 0x06012ABC RID: 76476 RVA: 0x004C825C File Offset: 0x004C645C
		public bool IsNew()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNew_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNew_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isNew;
		}

		// Token: 0x06012ABD RID: 76477 RVA: 0x004C82D0 File Offset: 0x004C64D0
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x14000408 RID: 1032
		// (add) Token: 0x06012ABE RID: 76478 RVA: 0x004C8348 File Offset: 0x004C6548
		// (remove) Token: 0x06012ABF RID: 76479 RVA: 0x004C83E4 File Offset: 0x004C65E4
		public event Action<RiftChapterButton> EventOnClick
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
				Action<RiftChapterButton> action = this.EventOnClick;
				Action<RiftChapterButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<RiftChapterButton>>(ref this.EventOnClick, (Action<RiftChapterButton>)Delegate.Combine(action2, value), action);
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
				Action<RiftChapterButton> action = this.EventOnClick;
				Action<RiftChapterButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<RiftChapterButton>>(ref this.EventOnClick, (Action<RiftChapterButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x06012AC0 RID: 76480 RVA: 0x004C8480 File Offset: 0x004C6680
		// (set) Token: 0x06012AC1 RID: 76481 RVA: 0x004C84A0 File Offset: 0x004C66A0
		[DoNotToLua]
		public new RiftChapterButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RiftChapterButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012AC2 RID: 76482 RVA: 0x004C84AC File Offset: 0x004C66AC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012AC3 RID: 76483 RVA: 0x004C84B8 File Offset: 0x004C66B8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012AC4 RID: 76484 RVA: 0x004C84C0 File Offset: 0x004C66C0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012AC5 RID: 76485 RVA: 0x004C84C8 File Offset: 0x004C66C8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012AC6 RID: 76486 RVA: 0x004C84DC File Offset: 0x004C66DC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012AC7 RID: 76487 RVA: 0x004C84E4 File Offset: 0x004C66E4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012AC8 RID: 76488 RVA: 0x004C84F0 File Offset: 0x004C66F0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012AC9 RID: 76489 RVA: 0x004C84FC File Offset: 0x004C66FC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012ACA RID: 76490 RVA: 0x004C8508 File Offset: 0x004C6708
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012ACB RID: 76491 RVA: 0x004C8514 File Offset: 0x004C6714
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012ACC RID: 76492 RVA: 0x004C8520 File Offset: 0x004C6720
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012ACD RID: 76493 RVA: 0x004C852C File Offset: 0x004C672C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012ACE RID: 76494 RVA: 0x004C8538 File Offset: 0x004C6738
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012ACF RID: 76495 RVA: 0x004C8544 File Offset: 0x004C6744
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012AD0 RID: 76496 RVA: 0x004C8550 File Offset: 0x004C6750
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012AD1 RID: 76497 RVA: 0x004C8558 File Offset: 0x004C6758
		private void __callDele_EventOnClick(RiftChapterButton obj)
		{
			Action<RiftChapterButton> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x06012AD2 RID: 76498 RVA: 0x004C857C File Offset: 0x004C677C
		private void __clearDele_EventOnClick(RiftChapterButton obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x06012AD3 RID: 76499 RVA: 0x004C8588 File Offset: 0x004C6788
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
					this.m_SetChapterConfigDataRiftChapterInfo_hotfix = (luaObj.RawGet("SetChapter") as LuaFunction);
					this.m_SetIndexInt32_hotfix = (luaObj.RawGet("SetIndex") as LuaFunction);
					this.m_GetIndex_hotfix = (luaObj.RawGet("GetIndex") as LuaFunction);
					this.m_GetChapter_hotfix = (luaObj.RawGet("GetChapter") as LuaFunction);
					this.m_SetStatusBooleanBooleanBoolean_hotfix = (luaObj.RawGet("SetStatus") as LuaFunction);
					this.m_IsLocked_hotfix = (luaObj.RawGet("IsLocked") as LuaFunction);
					this.m_IsNew_hotfix = (luaObj.RawGet("IsNew") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012AD4 RID: 76500 RVA: 0x004C8750 File Offset: 0x004C6950
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftChapterButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A764 RID: 42852
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_sizeUIStateController;

		// Token: 0x0400A765 RID: 42853
		[AutoBind("./Item", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400A766 RID: 42854
		[AutoBind("./Item/ChapterImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400A767 RID: 42855
		[AutoBind("./Item/ChapterImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x0400A768 RID: 42856
		[AutoBind("./Item/Generation", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_titleObj;

		// Token: 0x0400A769 RID: 42857
		private ConfigDataRiftChapterInfo m_chapterInfo;

		// Token: 0x0400A76A RID: 42858
		private int m_index;

		// Token: 0x0400A76B RID: 42859
		private bool m_isLocked;

		// Token: 0x0400A76C RID: 42860
		private bool m_isNew;

		// Token: 0x0400A76D RID: 42861
		[DoNotToLua]
		private RiftChapterButton.LuaExportHelper luaExportHelper;

		// Token: 0x0400A76E RID: 42862
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A76F RID: 42863
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A770 RID: 42864
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A771 RID: 42865
		private LuaFunction m_SetChapterConfigDataRiftChapterInfo_hotfix;

		// Token: 0x0400A772 RID: 42866
		private LuaFunction m_SetIndexInt32_hotfix;

		// Token: 0x0400A773 RID: 42867
		private LuaFunction m_GetIndex_hotfix;

		// Token: 0x0400A774 RID: 42868
		private LuaFunction m_GetChapter_hotfix;

		// Token: 0x0400A775 RID: 42869
		private LuaFunction m_SetStatusBooleanBooleanBoolean_hotfix;

		// Token: 0x0400A776 RID: 42870
		private LuaFunction m_IsLocked_hotfix;

		// Token: 0x0400A777 RID: 42871
		private LuaFunction m_IsNew_hotfix;

		// Token: 0x0400A778 RID: 42872
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x0400A779 RID: 42873
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400A77A RID: 42874
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000EDA RID: 3802
		public new class LuaExportHelper
		{
			// Token: 0x06012AD5 RID: 76501 RVA: 0x004C87B8 File Offset: 0x004C69B8
			public LuaExportHelper(RiftChapterButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012AD6 RID: 76502 RVA: 0x004C87C8 File Offset: 0x004C69C8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012AD7 RID: 76503 RVA: 0x004C87D8 File Offset: 0x004C69D8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012AD8 RID: 76504 RVA: 0x004C87E8 File Offset: 0x004C69E8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012AD9 RID: 76505 RVA: 0x004C87F8 File Offset: 0x004C69F8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012ADA RID: 76506 RVA: 0x004C8810 File Offset: 0x004C6A10
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012ADB RID: 76507 RVA: 0x004C8820 File Offset: 0x004C6A20
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012ADC RID: 76508 RVA: 0x004C8830 File Offset: 0x004C6A30
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012ADD RID: 76509 RVA: 0x004C8840 File Offset: 0x004C6A40
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012ADE RID: 76510 RVA: 0x004C8850 File Offset: 0x004C6A50
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012ADF RID: 76511 RVA: 0x004C8860 File Offset: 0x004C6A60
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012AE0 RID: 76512 RVA: 0x004C8870 File Offset: 0x004C6A70
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012AE1 RID: 76513 RVA: 0x004C8880 File Offset: 0x004C6A80
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012AE2 RID: 76514 RVA: 0x004C8890 File Offset: 0x004C6A90
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012AE3 RID: 76515 RVA: 0x004C88A0 File Offset: 0x004C6AA0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012AE4 RID: 76516 RVA: 0x004C88B0 File Offset: 0x004C6AB0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012AE5 RID: 76517 RVA: 0x004C88C0 File Offset: 0x004C6AC0
			public void __callDele_EventOnClick(RiftChapterButton obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x06012AE6 RID: 76518 RVA: 0x004C88D0 File Offset: 0x004C6AD0
			public void __clearDele_EventOnClick(RiftChapterButton obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17003865 RID: 14437
			// (get) Token: 0x06012AE7 RID: 76519 RVA: 0x004C88E0 File Offset: 0x004C6AE0
			// (set) Token: 0x06012AE8 RID: 76520 RVA: 0x004C88F0 File Offset: 0x004C6AF0
			public CommonUIStateController m_sizeUIStateController
			{
				get
				{
					return this.m_owner.m_sizeUIStateController;
				}
				set
				{
					this.m_owner.m_sizeUIStateController = value;
				}
			}

			// Token: 0x17003866 RID: 14438
			// (get) Token: 0x06012AE9 RID: 76521 RVA: 0x004C8900 File Offset: 0x004C6B00
			// (set) Token: 0x06012AEA RID: 76522 RVA: 0x004C8910 File Offset: 0x004C6B10
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

			// Token: 0x17003867 RID: 14439
			// (get) Token: 0x06012AEB RID: 76523 RVA: 0x004C8920 File Offset: 0x004C6B20
			// (set) Token: 0x06012AEC RID: 76524 RVA: 0x004C8930 File Offset: 0x004C6B30
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

			// Token: 0x17003868 RID: 14440
			// (get) Token: 0x06012AED RID: 76525 RVA: 0x004C8940 File Offset: 0x004C6B40
			// (set) Token: 0x06012AEE RID: 76526 RVA: 0x004C8950 File Offset: 0x004C6B50
			public Image m_image
			{
				get
				{
					return this.m_owner.m_image;
				}
				set
				{
					this.m_owner.m_image = value;
				}
			}

			// Token: 0x17003869 RID: 14441
			// (get) Token: 0x06012AEF RID: 76527 RVA: 0x004C8960 File Offset: 0x004C6B60
			// (set) Token: 0x06012AF0 RID: 76528 RVA: 0x004C8970 File Offset: 0x004C6B70
			public GameObject m_titleObj
			{
				get
				{
					return this.m_owner.m_titleObj;
				}
				set
				{
					this.m_owner.m_titleObj = value;
				}
			}

			// Token: 0x1700386A RID: 14442
			// (get) Token: 0x06012AF1 RID: 76529 RVA: 0x004C8980 File Offset: 0x004C6B80
			// (set) Token: 0x06012AF2 RID: 76530 RVA: 0x004C8990 File Offset: 0x004C6B90
			public ConfigDataRiftChapterInfo m_chapterInfo
			{
				get
				{
					return this.m_owner.m_chapterInfo;
				}
				set
				{
					this.m_owner.m_chapterInfo = value;
				}
			}

			// Token: 0x1700386B RID: 14443
			// (get) Token: 0x06012AF3 RID: 76531 RVA: 0x004C89A0 File Offset: 0x004C6BA0
			// (set) Token: 0x06012AF4 RID: 76532 RVA: 0x004C89B0 File Offset: 0x004C6BB0
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

			// Token: 0x1700386C RID: 14444
			// (get) Token: 0x06012AF5 RID: 76533 RVA: 0x004C89C0 File Offset: 0x004C6BC0
			// (set) Token: 0x06012AF6 RID: 76534 RVA: 0x004C89D0 File Offset: 0x004C6BD0
			public bool m_isLocked
			{
				get
				{
					return this.m_owner.m_isLocked;
				}
				set
				{
					this.m_owner.m_isLocked = value;
				}
			}

			// Token: 0x1700386D RID: 14445
			// (get) Token: 0x06012AF7 RID: 76535 RVA: 0x004C89E0 File Offset: 0x004C6BE0
			// (set) Token: 0x06012AF8 RID: 76536 RVA: 0x004C89F0 File Offset: 0x004C6BF0
			public bool m_isNew
			{
				get
				{
					return this.m_owner.m_isNew;
				}
				set
				{
					this.m_owner.m_isNew = value;
				}
			}

			// Token: 0x06012AF9 RID: 76537 RVA: 0x004C8A00 File Offset: 0x004C6C00
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012AFA RID: 76538 RVA: 0x004C8A10 File Offset: 0x004C6C10
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400A77B RID: 42875
			private RiftChapterButton m_owner;
		}
	}
}
