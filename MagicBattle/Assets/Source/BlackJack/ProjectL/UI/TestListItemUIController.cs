using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FB8 RID: 4024
	[HotFix]
	public class TestListItemUIController : UIControllerBase
	{
		// Token: 0x06014173 RID: 82291 RVA: 0x0051E1FC File Offset: 0x0051C3FC
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
			this.ScrollItemBaseUICtrl = base.gameObject.GetComponent<ScrollItemBaseUIController>();
		}

		// Token: 0x06014174 RID: 82292 RVA: 0x0051E274 File Offset: 0x0051C474
		public void Init(Action<UIControllerBase> clickEvent, Action<UIControllerBase> fillEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAction`1Action`1_hotfix != null)
			{
				this.m_InitAction`1Action`1_hotfix.call(new object[]
				{
					this,
					clickEvent,
					fillEvent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.BindFields();
			this.ScrollItemBaseUICtrl.Init(this, true);
			this.ScrollItemBaseUICtrl.EventOnUIItemClick = clickEvent;
			this.ScrollItemBaseUICtrl.EventOnUIItemNeedFill = fillEvent;
		}

		// Token: 0x06014175 RID: 82293 RVA: 0x0051E320 File Offset: 0x0051C520
		public void SetId(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIdInt32_hotfix != null)
			{
				this.m_SetIdInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_id = id;
		}

		// Token: 0x06014176 RID: 82294 RVA: 0x0051E398 File Offset: 0x0051C598
		public int GetId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_id;
		}

		// Token: 0x06014177 RID: 82295 RVA: 0x0051E40C File Offset: 0x0051C60C
		public void SetName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNameString_hotfix != null)
			{
				this.m_SetNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = UIUtility.AddColorTag(this.m_id.ToString(), new Color(1f, 0.5f, 0f)) + " " + name;
		}

		// Token: 0x06014178 RID: 82296 RVA: 0x0051E4BC File Offset: 0x0051C6BC
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
			this.m_selectedGameObject.SetActive(selected);
		}

		// Token: 0x06014179 RID: 82297 RVA: 0x0051E538 File Offset: 0x0051C738
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
			return this.m_selectedGameObject.activeSelf;
		}

		// Token: 0x0601417A RID: 82298 RVA: 0x0051E5B0 File Offset: 0x0051C7B0
		public void OnClick(UnityAction action)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClickUnityAction_hotfix != null)
			{
				this.m_OnClickUnityAction_hotfix.call(new object[]
				{
					this,
					action
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.GetComponent<Button>().onClick.AddListener(action);
		}

		// Token: 0x17003BFC RID: 15356
		// (get) Token: 0x0601417B RID: 82299 RVA: 0x0051E634 File Offset: 0x0051C834
		// (set) Token: 0x0601417C RID: 82300 RVA: 0x0051E654 File Offset: 0x0051C854
		[DoNotToLua]
		public new TestListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TestListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601417D RID: 82301 RVA: 0x0051E660 File Offset: 0x0051C860
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601417E RID: 82302 RVA: 0x0051E66C File Offset: 0x0051C86C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601417F RID: 82303 RVA: 0x0051E674 File Offset: 0x0051C874
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014180 RID: 82304 RVA: 0x0051E67C File Offset: 0x0051C87C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014181 RID: 82305 RVA: 0x0051E690 File Offset: 0x0051C890
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014182 RID: 82306 RVA: 0x0051E698 File Offset: 0x0051C898
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014183 RID: 82307 RVA: 0x0051E6A4 File Offset: 0x0051C8A4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014184 RID: 82308 RVA: 0x0051E6B0 File Offset: 0x0051C8B0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014185 RID: 82309 RVA: 0x0051E6BC File Offset: 0x0051C8BC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014186 RID: 82310 RVA: 0x0051E6C8 File Offset: 0x0051C8C8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014187 RID: 82311 RVA: 0x0051E6D4 File Offset: 0x0051C8D4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014188 RID: 82312 RVA: 0x0051E6E0 File Offset: 0x0051C8E0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014189 RID: 82313 RVA: 0x0051E6EC File Offset: 0x0051C8EC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601418A RID: 82314 RVA: 0x0051E6F8 File Offset: 0x0051C8F8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601418B RID: 82315 RVA: 0x0051E704 File Offset: 0x0051C904
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601418C RID: 82316 RVA: 0x0051E70C File Offset: 0x0051C90C
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
					this.m_InitAction`1Action`1_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_SetIdInt32_hotfix = (luaObj.RawGet("SetId") as LuaFunction);
					this.m_GetId_hotfix = (luaObj.RawGet("GetId") as LuaFunction);
					this.m_SetNameString_hotfix = (luaObj.RawGet("SetName") as LuaFunction);
					this.m_SetSelectedBoolean_hotfix = (luaObj.RawGet("SetSelected") as LuaFunction);
					this.m_IsSelected_hotfix = (luaObj.RawGet("IsSelected") as LuaFunction);
					this.m_OnClickUnityAction_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601418D RID: 82317 RVA: 0x0051E888 File Offset: 0x0051CA88
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TestListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B1AA RID: 45482
		[AutoBind("./Name", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400B1AB RID: 45483
		[AutoBind("./Selected", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectedGameObject;

		// Token: 0x0400B1AC RID: 45484
		public ScrollItemBaseUIController ScrollItemBaseUICtrl;

		// Token: 0x0400B1AD RID: 45485
		private int m_id;

		// Token: 0x0400B1AE RID: 45486
		[DoNotToLua]
		private TestListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B1AF RID: 45487
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B1B0 RID: 45488
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B1B1 RID: 45489
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B1B2 RID: 45490
		private LuaFunction m_InitAction`1Action;

		// Token: 0x0400B1B3 RID: 45491
		private LuaFunction m_SetIdInt32_hotfix;

		// Token: 0x0400B1B4 RID: 45492
		private LuaFunction m_GetId_hotfix;

		// Token: 0x0400B1B5 RID: 45493
		private LuaFunction m_SetNameString_hotfix;

		// Token: 0x0400B1B6 RID: 45494
		private LuaFunction m_SetSelectedBoolean_hotfix;

		// Token: 0x0400B1B7 RID: 45495
		private LuaFunction m_IsSelected_hotfix;

		// Token: 0x0400B1B8 RID: 45496
		private LuaFunction m_OnClickUnityAction_hotfix;

		// Token: 0x02000FB9 RID: 4025
		public new class LuaExportHelper
		{
			// Token: 0x0601418E RID: 82318 RVA: 0x0051E8F0 File Offset: 0x0051CAF0
			public LuaExportHelper(TestListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601418F RID: 82319 RVA: 0x0051E900 File Offset: 0x0051CB00
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014190 RID: 82320 RVA: 0x0051E910 File Offset: 0x0051CB10
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014191 RID: 82321 RVA: 0x0051E920 File Offset: 0x0051CB20
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014192 RID: 82322 RVA: 0x0051E930 File Offset: 0x0051CB30
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014193 RID: 82323 RVA: 0x0051E948 File Offset: 0x0051CB48
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014194 RID: 82324 RVA: 0x0051E958 File Offset: 0x0051CB58
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014195 RID: 82325 RVA: 0x0051E968 File Offset: 0x0051CB68
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014196 RID: 82326 RVA: 0x0051E978 File Offset: 0x0051CB78
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014197 RID: 82327 RVA: 0x0051E988 File Offset: 0x0051CB88
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014198 RID: 82328 RVA: 0x0051E998 File Offset: 0x0051CB98
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014199 RID: 82329 RVA: 0x0051E9A8 File Offset: 0x0051CBA8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601419A RID: 82330 RVA: 0x0051E9B8 File Offset: 0x0051CBB8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601419B RID: 82331 RVA: 0x0051E9C8 File Offset: 0x0051CBC8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601419C RID: 82332 RVA: 0x0051E9D8 File Offset: 0x0051CBD8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601419D RID: 82333 RVA: 0x0051E9E8 File Offset: 0x0051CBE8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003BFD RID: 15357
			// (get) Token: 0x0601419E RID: 82334 RVA: 0x0051E9F8 File Offset: 0x0051CBF8
			// (set) Token: 0x0601419F RID: 82335 RVA: 0x0051EA08 File Offset: 0x0051CC08
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x17003BFE RID: 15358
			// (get) Token: 0x060141A0 RID: 82336 RVA: 0x0051EA18 File Offset: 0x0051CC18
			// (set) Token: 0x060141A1 RID: 82337 RVA: 0x0051EA28 File Offset: 0x0051CC28
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

			// Token: 0x17003BFF RID: 15359
			// (get) Token: 0x060141A2 RID: 82338 RVA: 0x0051EA38 File Offset: 0x0051CC38
			// (set) Token: 0x060141A3 RID: 82339 RVA: 0x0051EA48 File Offset: 0x0051CC48
			public int m_id
			{
				get
				{
					return this.m_owner.m_id;
				}
				set
				{
					this.m_owner.m_id = value;
				}
			}

			// Token: 0x060141A4 RID: 82340 RVA: 0x0051EA58 File Offset: 0x0051CC58
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400B1B9 RID: 45497
			private TestListItemUIController m_owner;
		}
	}
}
