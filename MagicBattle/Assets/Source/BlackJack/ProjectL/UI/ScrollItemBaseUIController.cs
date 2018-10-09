using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BFF RID: 3071
	[HotFix]
	public class ScrollItemBaseUIController : UIControllerBase
	{
		// Token: 0x0600D6FB RID: 55035 RVA: 0x003A87C4 File Offset: 0x003A69C4
		public void Init(UIControllerBase ownerCtrl, bool isCareItemClick = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitUIControllerBaseBoolean_hotfix != null)
			{
				this.m_InitUIControllerBaseBoolean_hotfix.call(new object[]
				{
					this,
					ownerCtrl,
					isCareItemClick
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_ownerCtrl = ownerCtrl;
			PoolObject component = base.GetComponent<PoolObject>();
			if (component != null)
			{
				component.EventOnScrollCellIndex += this.ScrollCellIndex;
			}
			Button component2 = base.GetComponent<Button>();
			if (component2 != null && isCareItemClick)
			{
				component2.enabled = true;
				component2.onClick.AddListener(new UnityAction(this.OnScrollItemClick));
				if (component2 as ButtonEx != null)
				{
					(component2 as ButtonEx).onDoubleClick.AddListener(new UnityAction(this.OnScrollItemDoubleClick));
				}
			}
			else if (component2 != null && !isCareItemClick)
			{
				component2.enabled = false;
			}
			this.m_3dTouchEventTrigger = base.GetComponent<ThreeDTouchEventListener>();
			if (this.m_3dTouchEventTrigger != null && isCareItemClick)
			{
				this.m_3dTouchEventTrigger.EventOnThreeDTouchTriggered += this.OnScrollItem3DTouch;
			}
		}

		// Token: 0x0600D6FC RID: 55036 RVA: 0x003A892C File Offset: 0x003A6B2C
		public void ScrollCellIndex(int itemIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ScrollCellIndexInt32_hotfix != null)
			{
				this.m_ScrollCellIndexInt32_hotfix.call(new object[]
				{
					this,
					itemIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_itemIndex = itemIndex;
			if (this.EventOnUIItemNeedFill != null)
			{
				this.EventOnUIItemNeedFill(this.m_ownerCtrl);
			}
		}

		// Token: 0x0600D6FD RID: 55037 RVA: 0x003A89C0 File Offset: 0x003A6BC0
		public void OnScrollItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScrollItemClick_hotfix != null)
			{
				this.m_OnScrollItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!UIControllerBase.CheckAndUpdateCurrFrameButtonClickStateInfo())
			{
				return;
			}
			if (this.m_3dTouchEventTrigger != null && this.m_3dTouchEventTrigger.IsThreeDTouchTriggered)
			{
				return;
			}
			if (this.EventOnUIItemClick != null)
			{
				this.EventOnUIItemClick(this.m_ownerCtrl);
			}
		}

		// Token: 0x0600D6FE RID: 55038 RVA: 0x003A8A6C File Offset: 0x003A6C6C
		public void OnScrollItemDoubleClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScrollItemDoubleClick_hotfix != null)
			{
				this.m_OnScrollItemDoubleClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_3dTouchEventTrigger != null && this.m_3dTouchEventTrigger.IsThreeDTouchTriggered)
			{
				return;
			}
			if (this.EventOnUIItemDoubleClick != null)
			{
				this.EventOnUIItemDoubleClick(this.m_ownerCtrl);
			}
		}

		// Token: 0x0600D6FF RID: 55039 RVA: 0x003A8B0C File Offset: 0x003A6D0C
		public void OnScrollItem3DTouch()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnScrollItem3DTouch_hotfix != null)
			{
				this.m_OnScrollItem3DTouch_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnUIItem3DTouch != null)
			{
				this.EventOnUIItem3DTouch(this.m_ownerCtrl);
			}
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x0600D700 RID: 55040 RVA: 0x003A8B88 File Offset: 0x003A6D88
		// (set) Token: 0x0600D701 RID: 55041 RVA: 0x003A8BFC File Offset: 0x003A6DFC
		public int ItemIndex
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ItemIndex_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_ItemIndex_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_itemIndex;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ItemIndexInt32_hotfix != null)
				{
					this.m_set_ItemIndexInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_itemIndex = value;
			}
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x0600D702 RID: 55042 RVA: 0x003A8C74 File Offset: 0x003A6E74
		// (set) Token: 0x0600D703 RID: 55043 RVA: 0x003A8C94 File Offset: 0x003A6E94
		[DoNotToLua]
		public new ScrollItemBaseUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ScrollItemBaseUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D704 RID: 55044 RVA: 0x003A8CA0 File Offset: 0x003A6EA0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D705 RID: 55045 RVA: 0x003A8CAC File Offset: 0x003A6EAC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D706 RID: 55046 RVA: 0x003A8CB4 File Offset: 0x003A6EB4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D707 RID: 55047 RVA: 0x003A8CBC File Offset: 0x003A6EBC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D708 RID: 55048 RVA: 0x003A8CD0 File Offset: 0x003A6ED0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D709 RID: 55049 RVA: 0x003A8CD8 File Offset: 0x003A6ED8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D70A RID: 55050 RVA: 0x003A8CE4 File Offset: 0x003A6EE4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D70B RID: 55051 RVA: 0x003A8CF0 File Offset: 0x003A6EF0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D70C RID: 55052 RVA: 0x003A8CFC File Offset: 0x003A6EFC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D70D RID: 55053 RVA: 0x003A8D08 File Offset: 0x003A6F08
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D70E RID: 55054 RVA: 0x003A8D14 File Offset: 0x003A6F14
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D70F RID: 55055 RVA: 0x003A8D20 File Offset: 0x003A6F20
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D710 RID: 55056 RVA: 0x003A8D2C File Offset: 0x003A6F2C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D711 RID: 55057 RVA: 0x003A8D38 File Offset: 0x003A6F38
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D712 RID: 55058 RVA: 0x003A8D44 File Offset: 0x003A6F44
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D713 RID: 55059 RVA: 0x003A8D4C File Offset: 0x003A6F4C
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
					this.m_InitUIControllerBaseBoolean_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_ScrollCellIndexInt32_hotfix = (luaObj.RawGet("ScrollCellIndex") as LuaFunction);
					this.m_OnScrollItemClick_hotfix = (luaObj.RawGet("OnScrollItemClick") as LuaFunction);
					this.m_OnScrollItemDoubleClick_hotfix = (luaObj.RawGet("OnScrollItemDoubleClick") as LuaFunction);
					this.m_OnScrollItem3DTouch_hotfix = (luaObj.RawGet("OnScrollItem3DTouch") as LuaFunction);
					this.m_get_ItemIndex_hotfix = (luaObj.RawGet("get_ItemIndex") as LuaFunction);
					this.m_set_ItemIndexInt32_hotfix = (luaObj.RawGet("set_ItemIndex") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D714 RID: 55060 RVA: 0x003A8EB0 File Offset: 0x003A70B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ScrollItemBaseUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008456 RID: 33878
		public Action<UIControllerBase> EventOnUIItemNeedFill;

		// Token: 0x04008457 RID: 33879
		public Action<UIControllerBase> EventOnUIItemClick;

		// Token: 0x04008458 RID: 33880
		public Action<UIControllerBase> EventOnUIItemDoubleClick;

		// Token: 0x04008459 RID: 33881
		public Action<UIControllerBase> EventOnUIItem3DTouch;

		// Token: 0x0400845A RID: 33882
		public int m_itemIndex;

		// Token: 0x0400845B RID: 33883
		public UIControllerBase m_ownerCtrl;

		// Token: 0x0400845C RID: 33884
		private ThreeDTouchEventListener m_3dTouchEventTrigger;

		// Token: 0x0400845D RID: 33885
		[DoNotToLua]
		private ScrollItemBaseUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400845E RID: 33886
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400845F RID: 33887
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008460 RID: 33888
		private LuaFunction m_InitUIControllerBaseBoolean_hotfix;

		// Token: 0x04008461 RID: 33889
		private LuaFunction m_ScrollCellIndexInt32_hotfix;

		// Token: 0x04008462 RID: 33890
		private LuaFunction m_OnScrollItemClick_hotfix;

		// Token: 0x04008463 RID: 33891
		private LuaFunction m_OnScrollItemDoubleClick_hotfix;

		// Token: 0x04008464 RID: 33892
		private LuaFunction m_OnScrollItem3DTouch_hotfix;

		// Token: 0x04008465 RID: 33893
		private LuaFunction m_get_ItemIndex_hotfix;

		// Token: 0x04008466 RID: 33894
		private LuaFunction m_set_ItemIndexInt32_hotfix;

		// Token: 0x02000C00 RID: 3072
		public new class LuaExportHelper
		{
			// Token: 0x0600D715 RID: 55061 RVA: 0x003A8F18 File Offset: 0x003A7118
			public LuaExportHelper(ScrollItemBaseUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D716 RID: 55062 RVA: 0x003A8F28 File Offset: 0x003A7128
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D717 RID: 55063 RVA: 0x003A8F38 File Offset: 0x003A7138
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D718 RID: 55064 RVA: 0x003A8F48 File Offset: 0x003A7148
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D719 RID: 55065 RVA: 0x003A8F58 File Offset: 0x003A7158
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D71A RID: 55066 RVA: 0x003A8F70 File Offset: 0x003A7170
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D71B RID: 55067 RVA: 0x003A8F80 File Offset: 0x003A7180
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D71C RID: 55068 RVA: 0x003A8F90 File Offset: 0x003A7190
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D71D RID: 55069 RVA: 0x003A8FA0 File Offset: 0x003A71A0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D71E RID: 55070 RVA: 0x003A8FB0 File Offset: 0x003A71B0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D71F RID: 55071 RVA: 0x003A8FC0 File Offset: 0x003A71C0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D720 RID: 55072 RVA: 0x003A8FD0 File Offset: 0x003A71D0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D721 RID: 55073 RVA: 0x003A8FE0 File Offset: 0x003A71E0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D722 RID: 55074 RVA: 0x003A8FF0 File Offset: 0x003A71F0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D723 RID: 55075 RVA: 0x003A9000 File Offset: 0x003A7200
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D724 RID: 55076 RVA: 0x003A9010 File Offset: 0x003A7210
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170029EE RID: 10734
			// (get) Token: 0x0600D725 RID: 55077 RVA: 0x003A9020 File Offset: 0x003A7220
			// (set) Token: 0x0600D726 RID: 55078 RVA: 0x003A9030 File Offset: 0x003A7230
			public ThreeDTouchEventListener m_3dTouchEventTrigger
			{
				get
				{
					return this.m_owner.m_3dTouchEventTrigger;
				}
				set
				{
					this.m_owner.m_3dTouchEventTrigger = value;
				}
			}

			// Token: 0x04008467 RID: 33895
			private ScrollItemBaseUIController m_owner;
		}
	}
}
