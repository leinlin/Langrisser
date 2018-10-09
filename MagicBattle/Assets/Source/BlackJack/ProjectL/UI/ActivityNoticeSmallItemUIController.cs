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
	// Token: 0x020009BE RID: 2494
	[HotFix]
	public class ActivityNoticeSmallItemUIController : UIControllerBase
	{
		// Token: 0x060090EF RID: 37103 RVA: 0x002A0938 File Offset: 0x0029EB38
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

		// Token: 0x060090F0 RID: 37104 RVA: 0x002A09BC File Offset: 0x0029EBBC
		public void UpdateItemInfo(int activityId, string resName, string desc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateItemInfoInt32StringString_hotfix != null)
			{
				this.m_UpdateItemInfoInt32StringString_hotfix.call(new object[]
				{
					this,
					activityId,
					resName,
					desc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ActivityId = activityId;
			this.m_image.sprite = AssetUtility.Instance.GetSprite(resName);
			this.m_descText.text = desc;
		}

		// Token: 0x060090F1 RID: 37105 RVA: 0x002A0A78 File Offset: 0x0029EC78
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
			if (this.EventOnButtonClick != null)
			{
				this.EventOnButtonClick(this.ActivityId);
			}
		}

		// Token: 0x14000194 RID: 404
		// (add) Token: 0x060090F2 RID: 37106 RVA: 0x002A0AF4 File Offset: 0x0029ECF4
		// (remove) Token: 0x060090F3 RID: 37107 RVA: 0x002A0B90 File Offset: 0x0029ED90
		public event Action<int> EventOnButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnButtonClick, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnButtonClick;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnButtonClick, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x060090F4 RID: 37108 RVA: 0x002A0C2C File Offset: 0x0029EE2C
		// (set) Token: 0x060090F5 RID: 37109 RVA: 0x002A0C4C File Offset: 0x0029EE4C
		[DoNotToLua]
		public new ActivityNoticeSmallItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ActivityNoticeSmallItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060090F6 RID: 37110 RVA: 0x002A0C58 File Offset: 0x0029EE58
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060090F7 RID: 37111 RVA: 0x002A0C64 File Offset: 0x0029EE64
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060090F8 RID: 37112 RVA: 0x002A0C6C File Offset: 0x0029EE6C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060090F9 RID: 37113 RVA: 0x002A0C74 File Offset: 0x0029EE74
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060090FA RID: 37114 RVA: 0x002A0C88 File Offset: 0x0029EE88
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060090FB RID: 37115 RVA: 0x002A0C90 File Offset: 0x0029EE90
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060090FC RID: 37116 RVA: 0x002A0C9C File Offset: 0x0029EE9C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060090FD RID: 37117 RVA: 0x002A0CA8 File Offset: 0x0029EEA8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060090FE RID: 37118 RVA: 0x002A0CB4 File Offset: 0x0029EEB4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060090FF RID: 37119 RVA: 0x002A0CC0 File Offset: 0x0029EEC0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x002A0CCC File Offset: 0x0029EECC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009101 RID: 37121 RVA: 0x002A0CD8 File Offset: 0x0029EED8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x002A0CE4 File Offset: 0x0029EEE4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x002A0CF0 File Offset: 0x0029EEF0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x002A0CFC File Offset: 0x0029EEFC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x002A0D04 File Offset: 0x0029EF04
		private void __callDele_EventOnButtonClick(int obj)
		{
			Action<int> eventOnButtonClick = this.EventOnButtonClick;
			if (eventOnButtonClick != null)
			{
				eventOnButtonClick(obj);
			}
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x002A0D28 File Offset: 0x0029EF28
		private void __clearDele_EventOnButtonClick(int obj)
		{
			this.EventOnButtonClick = null;
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x002A0D34 File Offset: 0x0029EF34
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
					this.m_UpdateItemInfoInt32StringString_hotfix = (luaObj.RawGet("UpdateItemInfo") as LuaFunction);
					this.m_OnButtonClick_hotfix = (luaObj.RawGet("OnButtonClick") as LuaFunction);
					this.m_add_EventOnButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnButtonClick") as LuaFunction);
					this.m_remove_EventOnButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x002A0E64 File Offset: 0x0029F064
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActivityNoticeSmallItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040065C6 RID: 26054
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x040065C7 RID: 26055
		[AutoBind("./Mask/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x040065C8 RID: 26056
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descText;

		// Token: 0x040065CA RID: 26058
		public int ActivityId;

		// Token: 0x040065CB RID: 26059
		[DoNotToLua]
		private ActivityNoticeSmallItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040065CC RID: 26060
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040065CD RID: 26061
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040065CE RID: 26062
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040065CF RID: 26063
		private LuaFunction m_UpdateItemInfoInt32StringString_hotfix;

		// Token: 0x040065D0 RID: 26064
		private LuaFunction m_OnButtonClick_hotfix;

		// Token: 0x040065D1 RID: 26065
		private LuaFunction m_add_EventOnButtonClickAction;

		// Token: 0x040065D2 RID: 26066
		private LuaFunction m_remove_EventOnButtonClickAction;

		// Token: 0x020009BF RID: 2495
		public new class LuaExportHelper
		{
			// Token: 0x06009109 RID: 37129 RVA: 0x002A0ECC File Offset: 0x0029F0CC
			public LuaExportHelper(ActivityNoticeSmallItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600910A RID: 37130 RVA: 0x002A0EDC File Offset: 0x0029F0DC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600910B RID: 37131 RVA: 0x002A0EEC File Offset: 0x0029F0EC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600910C RID: 37132 RVA: 0x002A0EFC File Offset: 0x0029F0FC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600910D RID: 37133 RVA: 0x002A0F0C File Offset: 0x0029F10C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600910E RID: 37134 RVA: 0x002A0F24 File Offset: 0x0029F124
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600910F RID: 37135 RVA: 0x002A0F34 File Offset: 0x0029F134
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009110 RID: 37136 RVA: 0x002A0F44 File Offset: 0x0029F144
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009111 RID: 37137 RVA: 0x002A0F54 File Offset: 0x0029F154
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009112 RID: 37138 RVA: 0x002A0F64 File Offset: 0x0029F164
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009113 RID: 37139 RVA: 0x002A0F74 File Offset: 0x0029F174
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009114 RID: 37140 RVA: 0x002A0F84 File Offset: 0x0029F184
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009115 RID: 37141 RVA: 0x002A0F94 File Offset: 0x0029F194
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009116 RID: 37142 RVA: 0x002A0FA4 File Offset: 0x0029F1A4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009117 RID: 37143 RVA: 0x002A0FB4 File Offset: 0x0029F1B4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009118 RID: 37144 RVA: 0x002A0FC4 File Offset: 0x0029F1C4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009119 RID: 37145 RVA: 0x002A0FD4 File Offset: 0x0029F1D4
			public void __callDele_EventOnButtonClick(int obj)
			{
				this.m_owner.__callDele_EventOnButtonClick(obj);
			}

			// Token: 0x0600911A RID: 37146 RVA: 0x002A0FE4 File Offset: 0x0029F1E4
			public void __clearDele_EventOnButtonClick(int obj)
			{
				this.m_owner.__clearDele_EventOnButtonClick(obj);
			}

			// Token: 0x17001E20 RID: 7712
			// (get) Token: 0x0600911B RID: 37147 RVA: 0x002A0FF4 File Offset: 0x0029F1F4
			// (set) Token: 0x0600911C RID: 37148 RVA: 0x002A1004 File Offset: 0x0029F204
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

			// Token: 0x17001E21 RID: 7713
			// (get) Token: 0x0600911D RID: 37149 RVA: 0x002A1014 File Offset: 0x0029F214
			// (set) Token: 0x0600911E RID: 37150 RVA: 0x002A1024 File Offset: 0x0029F224
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

			// Token: 0x17001E22 RID: 7714
			// (get) Token: 0x0600911F RID: 37151 RVA: 0x002A1034 File Offset: 0x0029F234
			// (set) Token: 0x06009120 RID: 37152 RVA: 0x002A1044 File Offset: 0x0029F244
			public Text m_descText
			{
				get
				{
					return this.m_owner.m_descText;
				}
				set
				{
					this.m_owner.m_descText = value;
				}
			}

			// Token: 0x06009121 RID: 37153 RVA: 0x002A1054 File Offset: 0x0029F254
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06009122 RID: 37154 RVA: 0x002A1064 File Offset: 0x0029F264
			public void OnButtonClick()
			{
				this.m_owner.OnButtonClick();
			}

			// Token: 0x040065D3 RID: 26067
			private ActivityNoticeSmallItemUIController m_owner;
		}
	}
}
