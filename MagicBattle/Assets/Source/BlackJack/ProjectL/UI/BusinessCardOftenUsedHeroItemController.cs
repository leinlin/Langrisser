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
	// Token: 0x02000B21 RID: 2849
	[HotFix]
	public class BusinessCardOftenUsedHeroItemController : UIControllerBase
	{
		// Token: 0x0600BFFD RID: 49149 RVA: 0x00357F2C File Offset: 0x0035612C
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnButtonClick));
		}

		// Token: 0x0600BFFE RID: 49150 RVA: 0x00357FB0 File Offset: 0x003561B0
		public void UpdateItemInfo(string headIconName, int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateItemInfoStringInt32_hotfix != null)
			{
				this.m_UpdateItemInfoStringInt32_hotfix.call(new object[]
				{
					this,
					headIconName,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HeadId = heroId;
			this.m_headIconImage.sprite = AssetUtility.Instance.GetSprite(headIconName);
		}

		// Token: 0x0600BFFF RID: 49151 RVA: 0x00358050 File Offset: 0x00356250
		private void OnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnButtonClick_hotfix != null)
			{
				this.m_OnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this.HeadId);
			}
		}

		// Token: 0x1400024A RID: 586
		// (add) Token: 0x0600C000 RID: 49152 RVA: 0x003580CC File Offset: 0x003562CC
		// (remove) Token: 0x0600C001 RID: 49153 RVA: 0x00358168 File Offset: 0x00356368
		public event Action<int> EventOnClick
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
				Action<int> action = this.EventOnClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnClick, (Action<int>)Delegate.Combine(action2, value), action);
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
				Action<int> action = this.EventOnClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x0600C002 RID: 49154 RVA: 0x00358204 File Offset: 0x00356404
		// (set) Token: 0x0600C003 RID: 49155 RVA: 0x00358224 File Offset: 0x00356424
		[DoNotToLua]
		public new BusinessCardOftenUsedHeroItemController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BusinessCardOftenUsedHeroItemController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C004 RID: 49156 RVA: 0x00358230 File Offset: 0x00356430
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C005 RID: 49157 RVA: 0x0035823C File Offset: 0x0035643C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C006 RID: 49158 RVA: 0x00358244 File Offset: 0x00356444
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C007 RID: 49159 RVA: 0x0035824C File Offset: 0x0035644C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C008 RID: 49160 RVA: 0x00358260 File Offset: 0x00356460
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C009 RID: 49161 RVA: 0x00358268 File Offset: 0x00356468
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C00A RID: 49162 RVA: 0x00358274 File Offset: 0x00356474
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C00B RID: 49163 RVA: 0x00358280 File Offset: 0x00356480
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C00C RID: 49164 RVA: 0x0035828C File Offset: 0x0035648C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C00D RID: 49165 RVA: 0x00358298 File Offset: 0x00356498
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C00E RID: 49166 RVA: 0x003582A4 File Offset: 0x003564A4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C00F RID: 49167 RVA: 0x003582B0 File Offset: 0x003564B0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C010 RID: 49168 RVA: 0x003582BC File Offset: 0x003564BC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C011 RID: 49169 RVA: 0x003582C8 File Offset: 0x003564C8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C012 RID: 49170 RVA: 0x003582D4 File Offset: 0x003564D4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C013 RID: 49171 RVA: 0x003582DC File Offset: 0x003564DC
		private void __callDele_EventOnClick(int obj)
		{
			Action<int> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600C014 RID: 49172 RVA: 0x00358300 File Offset: 0x00356500
		private void __clearDele_EventOnClick(int obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600C015 RID: 49173 RVA: 0x0035830C File Offset: 0x0035650C
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
					this.m_UpdateItemInfoStringInt32_hotfix = (luaObj.RawGet("UpdateItemInfo") as LuaFunction);
					this.m_OnButtonClick_hotfix = (luaObj.RawGet("OnButtonClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C016 RID: 49174 RVA: 0x0035843C File Offset: 0x0035663C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardOftenUsedHeroItemController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007A8A RID: 31370
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04007A8B RID: 31371
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIconImage;

		// Token: 0x04007A8D RID: 31373
		public int HeadId;

		// Token: 0x04007A8E RID: 31374
		[DoNotToLua]
		private BusinessCardOftenUsedHeroItemController.LuaExportHelper luaExportHelper;

		// Token: 0x04007A8F RID: 31375
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007A90 RID: 31376
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007A91 RID: 31377
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007A92 RID: 31378
		private LuaFunction m_UpdateItemInfoStringInt32_hotfix;

		// Token: 0x04007A93 RID: 31379
		private LuaFunction m_OnButtonClick_hotfix;

		// Token: 0x04007A94 RID: 31380
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04007A95 RID: 31381
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000B22 RID: 2850
		public new class LuaExportHelper
		{
			// Token: 0x0600C017 RID: 49175 RVA: 0x003584A4 File Offset: 0x003566A4
			public LuaExportHelper(BusinessCardOftenUsedHeroItemController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C018 RID: 49176 RVA: 0x003584B4 File Offset: 0x003566B4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C019 RID: 49177 RVA: 0x003584C4 File Offset: 0x003566C4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C01A RID: 49178 RVA: 0x003584D4 File Offset: 0x003566D4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C01B RID: 49179 RVA: 0x003584E4 File Offset: 0x003566E4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C01C RID: 49180 RVA: 0x003584FC File Offset: 0x003566FC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C01D RID: 49181 RVA: 0x0035850C File Offset: 0x0035670C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C01E RID: 49182 RVA: 0x0035851C File Offset: 0x0035671C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C01F RID: 49183 RVA: 0x0035852C File Offset: 0x0035672C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C020 RID: 49184 RVA: 0x0035853C File Offset: 0x0035673C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C021 RID: 49185 RVA: 0x0035854C File Offset: 0x0035674C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C022 RID: 49186 RVA: 0x0035855C File Offset: 0x0035675C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C023 RID: 49187 RVA: 0x0035856C File Offset: 0x0035676C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C024 RID: 49188 RVA: 0x0035857C File Offset: 0x0035677C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C025 RID: 49189 RVA: 0x0035858C File Offset: 0x0035678C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C026 RID: 49190 RVA: 0x0035859C File Offset: 0x0035679C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C027 RID: 49191 RVA: 0x003585AC File Offset: 0x003567AC
			public void __callDele_EventOnClick(int obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600C028 RID: 49192 RVA: 0x003585BC File Offset: 0x003567BC
			public void __clearDele_EventOnClick(int obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002684 RID: 9860
			// (get) Token: 0x0600C029 RID: 49193 RVA: 0x003585CC File Offset: 0x003567CC
			// (set) Token: 0x0600C02A RID: 49194 RVA: 0x003585DC File Offset: 0x003567DC
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

			// Token: 0x17002685 RID: 9861
			// (get) Token: 0x0600C02B RID: 49195 RVA: 0x003585EC File Offset: 0x003567EC
			// (set) Token: 0x0600C02C RID: 49196 RVA: 0x003585FC File Offset: 0x003567FC
			public Image m_headIconImage
			{
				get
				{
					return this.m_owner.m_headIconImage;
				}
				set
				{
					this.m_owner.m_headIconImage = value;
				}
			}

			// Token: 0x0600C02D RID: 49197 RVA: 0x0035860C File Offset: 0x0035680C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C02E RID: 49198 RVA: 0x0035861C File Offset: 0x0035681C
			public void OnButtonClick()
			{
				this.m_owner.OnButtonClick();
			}

			// Token: 0x04007A96 RID: 31382
			private BusinessCardOftenUsedHeroItemController m_owner;
		}
	}
}
