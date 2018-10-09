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
	// Token: 0x02000E8C RID: 3724
	[HotFix]
	public class PlayerInfoHeadPortraitItemUIController : UIControllerBase
	{
		// Token: 0x06012277 RID: 74359 RVA: 0x004AC594 File Offset: 0x004AA794
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
			this.m_toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSelectToggleValueChanged));
		}

		// Token: 0x06012278 RID: 74360 RVA: 0x004AC618 File Offset: 0x004AA818
		public void UpdateItemInfo(int headPortraitId, string headPortraitName, bool isSelected)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateItemInfoInt32StringBoolean_hotfix != null)
			{
				this.m_UpdateItemInfoInt32StringBoolean_hotfix.call(new object[]
				{
					this,
					headPortraitId,
					headPortraitName,
					isSelected
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HeadPortraitId = headPortraitId;
			this.HeadPortraitName = headPortraitName;
			this.m_headPortraitImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(headPortraitId));
			this.m_toggle.isOn = isSelected;
		}

		// Token: 0x06012279 RID: 74361 RVA: 0x004AC6E0 File Offset: 0x004AA8E0
		private void OnSelectToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSelectToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSelectToggleValueChanged != null)
			{
				this.EventOnSelectToggleValueChanged(isOn, this);
			}
		}

		// Token: 0x140003E6 RID: 998
		// (add) Token: 0x0601227A RID: 74362 RVA: 0x004AC768 File Offset: 0x004AA968
		// (remove) Token: 0x0601227B RID: 74363 RVA: 0x004AC804 File Offset: 0x004AAA04
		public event Action<bool, PlayerInfoHeadPortraitItemUIController> EventOnSelectToggleValueChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectToggleValueChangedAction`2_hotfix != null)
				{
					this.m_add_EventOnSelectToggleValueChangedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, PlayerInfoHeadPortraitItemUIController> action = this.EventOnSelectToggleValueChanged;
				Action<bool, PlayerInfoHeadPortraitItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, PlayerInfoHeadPortraitItemUIController>>(ref this.EventOnSelectToggleValueChanged, (Action<bool, PlayerInfoHeadPortraitItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectToggleValueChangedAction`2_hotfix != null)
				{
					this.m_remove_EventOnSelectToggleValueChangedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, PlayerInfoHeadPortraitItemUIController> action = this.EventOnSelectToggleValueChanged;
				Action<bool, PlayerInfoHeadPortraitItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, PlayerInfoHeadPortraitItemUIController>>(ref this.EventOnSelectToggleValueChanged, (Action<bool, PlayerInfoHeadPortraitItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0601227C RID: 74364 RVA: 0x004AC8A0 File Offset: 0x004AAAA0
		// (set) Token: 0x0601227D RID: 74365 RVA: 0x004AC8C0 File Offset: 0x004AAAC0
		[DoNotToLua]
		public new PlayerInfoHeadPortraitItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerInfoHeadPortraitItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601227E RID: 74366 RVA: 0x004AC8CC File Offset: 0x004AAACC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601227F RID: 74367 RVA: 0x004AC8D8 File Offset: 0x004AAAD8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012280 RID: 74368 RVA: 0x004AC8E0 File Offset: 0x004AAAE0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012281 RID: 74369 RVA: 0x004AC8E8 File Offset: 0x004AAAE8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012282 RID: 74370 RVA: 0x004AC8FC File Offset: 0x004AAAFC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012283 RID: 74371 RVA: 0x004AC904 File Offset: 0x004AAB04
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012284 RID: 74372 RVA: 0x004AC910 File Offset: 0x004AAB10
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012285 RID: 74373 RVA: 0x004AC91C File Offset: 0x004AAB1C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012286 RID: 74374 RVA: 0x004AC928 File Offset: 0x004AAB28
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012287 RID: 74375 RVA: 0x004AC934 File Offset: 0x004AAB34
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012288 RID: 74376 RVA: 0x004AC940 File Offset: 0x004AAB40
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012289 RID: 74377 RVA: 0x004AC94C File Offset: 0x004AAB4C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601228A RID: 74378 RVA: 0x004AC958 File Offset: 0x004AAB58
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601228B RID: 74379 RVA: 0x004AC964 File Offset: 0x004AAB64
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601228C RID: 74380 RVA: 0x004AC970 File Offset: 0x004AAB70
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601228D RID: 74381 RVA: 0x004AC978 File Offset: 0x004AAB78
		private void __callDele_EventOnSelectToggleValueChanged(bool arg1, PlayerInfoHeadPortraitItemUIController arg2)
		{
			Action<bool, PlayerInfoHeadPortraitItemUIController> eventOnSelectToggleValueChanged = this.EventOnSelectToggleValueChanged;
			if (eventOnSelectToggleValueChanged != null)
			{
				eventOnSelectToggleValueChanged(arg1, arg2);
			}
		}

		// Token: 0x0601228E RID: 74382 RVA: 0x004AC99C File Offset: 0x004AAB9C
		private void __clearDele_EventOnSelectToggleValueChanged(bool arg1, PlayerInfoHeadPortraitItemUIController arg2)
		{
			this.EventOnSelectToggleValueChanged = null;
		}

		// Token: 0x0601228F RID: 74383 RVA: 0x004AC9A8 File Offset: 0x004AABA8
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
					this.m_UpdateItemInfoInt32StringBoolean_hotfix = (luaObj.RawGet("UpdateItemInfo") as LuaFunction);
					this.m_OnSelectToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSelectToggleValueChanged") as LuaFunction);
					this.m_add_EventOnSelectToggleValueChangedAction`2_hotfix = (luaObj.RawGet("add_EventOnSelectToggleValueChanged") as LuaFunction);
					this.m_remove_EventOnSelectToggleValueChangedAction`2_hotfix = (luaObj.RawGet("remove_EventOnSelectToggleValueChanged") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012290 RID: 74384 RVA: 0x004ACAD8 File Offset: 0x004AACD8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerInfoHeadPortraitItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A3FB RID: 41979
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_toggle;

		// Token: 0x0400A3FC RID: 41980
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headPortraitImage;

		// Token: 0x0400A3FD RID: 41981
		public int HeadPortraitId;

		// Token: 0x0400A3FE RID: 41982
		public string HeadPortraitName;

		// Token: 0x0400A3FF RID: 41983
		[DoNotToLua]
		private PlayerInfoHeadPortraitItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A400 RID: 41984
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A401 RID: 41985
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A402 RID: 41986
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A403 RID: 41987
		private LuaFunction m_UpdateItemInfoInt32StringBoolean_hotfix;

		// Token: 0x0400A404 RID: 41988
		private LuaFunction m_OnSelectToggleValueChangedBoolean_hotfix;

		// Token: 0x0400A405 RID: 41989
		private LuaFunction m_add_EventOnSelectToggleValueChangedAction;

		// Token: 0x0400A406 RID: 41990
		private LuaFunction m_remove_EventOnSelectToggleValueChangedAction;

		// Token: 0x02000E8D RID: 3725
		public new class LuaExportHelper
		{
			// Token: 0x06012291 RID: 74385 RVA: 0x004ACB40 File Offset: 0x004AAD40
			public LuaExportHelper(PlayerInfoHeadPortraitItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012292 RID: 74386 RVA: 0x004ACB50 File Offset: 0x004AAD50
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012293 RID: 74387 RVA: 0x004ACB60 File Offset: 0x004AAD60
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012294 RID: 74388 RVA: 0x004ACB70 File Offset: 0x004AAD70
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012295 RID: 74389 RVA: 0x004ACB80 File Offset: 0x004AAD80
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012296 RID: 74390 RVA: 0x004ACB98 File Offset: 0x004AAD98
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012297 RID: 74391 RVA: 0x004ACBA8 File Offset: 0x004AADA8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012298 RID: 74392 RVA: 0x004ACBB8 File Offset: 0x004AADB8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012299 RID: 74393 RVA: 0x004ACBC8 File Offset: 0x004AADC8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601229A RID: 74394 RVA: 0x004ACBD8 File Offset: 0x004AADD8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601229B RID: 74395 RVA: 0x004ACBE8 File Offset: 0x004AADE8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601229C RID: 74396 RVA: 0x004ACBF8 File Offset: 0x004AADF8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601229D RID: 74397 RVA: 0x004ACC08 File Offset: 0x004AAE08
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601229E RID: 74398 RVA: 0x004ACC18 File Offset: 0x004AAE18
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601229F RID: 74399 RVA: 0x004ACC28 File Offset: 0x004AAE28
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060122A0 RID: 74400 RVA: 0x004ACC38 File Offset: 0x004AAE38
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060122A1 RID: 74401 RVA: 0x004ACC48 File Offset: 0x004AAE48
			public void __callDele_EventOnSelectToggleValueChanged(bool arg1, PlayerInfoHeadPortraitItemUIController arg2)
			{
				this.m_owner.__callDele_EventOnSelectToggleValueChanged(arg1, arg2);
			}

			// Token: 0x060122A2 RID: 74402 RVA: 0x004ACC58 File Offset: 0x004AAE58
			public void __clearDele_EventOnSelectToggleValueChanged(bool arg1, PlayerInfoHeadPortraitItemUIController arg2)
			{
				this.m_owner.__clearDele_EventOnSelectToggleValueChanged(arg1, arg2);
			}

			// Token: 0x17003760 RID: 14176
			// (get) Token: 0x060122A3 RID: 74403 RVA: 0x004ACC68 File Offset: 0x004AAE68
			// (set) Token: 0x060122A4 RID: 74404 RVA: 0x004ACC78 File Offset: 0x004AAE78
			public Toggle m_toggle
			{
				get
				{
					return this.m_owner.m_toggle;
				}
				set
				{
					this.m_owner.m_toggle = value;
				}
			}

			// Token: 0x17003761 RID: 14177
			// (get) Token: 0x060122A5 RID: 74405 RVA: 0x004ACC88 File Offset: 0x004AAE88
			// (set) Token: 0x060122A6 RID: 74406 RVA: 0x004ACC98 File Offset: 0x004AAE98
			public Image m_headPortraitImage
			{
				get
				{
					return this.m_owner.m_headPortraitImage;
				}
				set
				{
					this.m_owner.m_headPortraitImage = value;
				}
			}

			// Token: 0x060122A7 RID: 74407 RVA: 0x004ACCA8 File Offset: 0x004AAEA8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060122A8 RID: 74408 RVA: 0x004ACCB8 File Offset: 0x004AAEB8
			public void OnSelectToggleValueChanged(bool isOn)
			{
				this.m_owner.OnSelectToggleValueChanged(isOn);
			}

			// Token: 0x0400A407 RID: 41991
			private PlayerInfoHeadPortraitItemUIController m_owner;
		}
	}
}
