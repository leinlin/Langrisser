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
	// Token: 0x020009BC RID: 2492
	[HotFix]
	public class ActivityNoticeBigItemUIController : UIControllerBase
	{
		// Token: 0x060090B9 RID: 37049 RVA: 0x002A0170 File Offset: 0x0029E370
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

		// Token: 0x060090BA RID: 37050 RVA: 0x002A01F4 File Offset: 0x0029E3F4
		public void UpdateItemInfo(int activityId, string resName, int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateItemInfoInt32StringInt32_hotfix != null)
			{
				this.m_UpdateItemInfoInt32StringInt32_hotfix.call(new object[]
				{
					this,
					activityId,
					resName,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ActivityId = activityId;
			this.m_index = index;
			this.m_image.sprite = AssetUtility.Instance.GetSprite(resName);
		}

		// Token: 0x060090BB RID: 37051 RVA: 0x002A02A8 File Offset: 0x0029E4A8
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

		// Token: 0x060090BC RID: 37052 RVA: 0x002A031C File Offset: 0x0029E51C
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

		// Token: 0x14000193 RID: 403
		// (add) Token: 0x060090BD RID: 37053 RVA: 0x002A0398 File Offset: 0x0029E598
		// (remove) Token: 0x060090BE RID: 37054 RVA: 0x002A0434 File Offset: 0x0029E634
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

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x060090BF RID: 37055 RVA: 0x002A04D0 File Offset: 0x0029E6D0
		// (set) Token: 0x060090C0 RID: 37056 RVA: 0x002A04F0 File Offset: 0x0029E6F0
		[DoNotToLua]
		public new ActivityNoticeBigItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ActivityNoticeBigItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060090C1 RID: 37057 RVA: 0x002A04FC File Offset: 0x0029E6FC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060090C2 RID: 37058 RVA: 0x002A0508 File Offset: 0x0029E708
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x002A0510 File Offset: 0x0029E710
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060090C4 RID: 37060 RVA: 0x002A0518 File Offset: 0x0029E718
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060090C5 RID: 37061 RVA: 0x002A052C File Offset: 0x0029E72C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060090C6 RID: 37062 RVA: 0x002A0534 File Offset: 0x0029E734
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060090C7 RID: 37063 RVA: 0x002A0540 File Offset: 0x0029E740
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060090C8 RID: 37064 RVA: 0x002A054C File Offset: 0x0029E74C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060090C9 RID: 37065 RVA: 0x002A0558 File Offset: 0x0029E758
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060090CA RID: 37066 RVA: 0x002A0564 File Offset: 0x0029E764
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060090CB RID: 37067 RVA: 0x002A0570 File Offset: 0x0029E770
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x002A057C File Offset: 0x0029E77C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x002A0588 File Offset: 0x0029E788
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x002A0594 File Offset: 0x0029E794
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x002A05A0 File Offset: 0x0029E7A0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x002A05A8 File Offset: 0x0029E7A8
		private void __callDele_EventOnButtonClick(int obj)
		{
			Action<int> eventOnButtonClick = this.EventOnButtonClick;
			if (eventOnButtonClick != null)
			{
				eventOnButtonClick(obj);
			}
		}

		// Token: 0x060090D1 RID: 37073 RVA: 0x002A05CC File Offset: 0x0029E7CC
		private void __clearDele_EventOnButtonClick(int obj)
		{
			this.EventOnButtonClick = null;
		}

		// Token: 0x060090D2 RID: 37074 RVA: 0x002A05D8 File Offset: 0x0029E7D8
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
					this.m_UpdateItemInfoInt32StringInt32_hotfix = (luaObj.RawGet("UpdateItemInfo") as LuaFunction);
					this.m_GetIndex_hotfix = (luaObj.RawGet("GetIndex") as LuaFunction);
					this.m_OnButtonClick_hotfix = (luaObj.RawGet("OnButtonClick") as LuaFunction);
					this.m_add_EventOnButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnButtonClick") as LuaFunction);
					this.m_remove_EventOnButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x002A0720 File Offset: 0x0029E920
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActivityNoticeBigItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040065B7 RID: 26039
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_image;

		// Token: 0x040065B8 RID: 26040
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x040065BA RID: 26042
		public int ActivityId;

		// Token: 0x040065BB RID: 26043
		private int m_index;

		// Token: 0x040065BC RID: 26044
		[DoNotToLua]
		private ActivityNoticeBigItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040065BD RID: 26045
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040065BE RID: 26046
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040065BF RID: 26047
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040065C0 RID: 26048
		private LuaFunction m_UpdateItemInfoInt32StringInt32_hotfix;

		// Token: 0x040065C1 RID: 26049
		private LuaFunction m_GetIndex_hotfix;

		// Token: 0x040065C2 RID: 26050
		private LuaFunction m_OnButtonClick_hotfix;

		// Token: 0x040065C3 RID: 26051
		private LuaFunction m_add_EventOnButtonClickAction;

		// Token: 0x040065C4 RID: 26052
		private LuaFunction m_remove_EventOnButtonClickAction;

		// Token: 0x020009BD RID: 2493
		public new class LuaExportHelper
		{
			// Token: 0x060090D4 RID: 37076 RVA: 0x002A0788 File Offset: 0x0029E988
			public LuaExportHelper(ActivityNoticeBigItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060090D5 RID: 37077 RVA: 0x002A0798 File Offset: 0x0029E998
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060090D6 RID: 37078 RVA: 0x002A07A8 File Offset: 0x0029E9A8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060090D7 RID: 37079 RVA: 0x002A07B8 File Offset: 0x0029E9B8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060090D8 RID: 37080 RVA: 0x002A07C8 File Offset: 0x0029E9C8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060090D9 RID: 37081 RVA: 0x002A07E0 File Offset: 0x0029E9E0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060090DA RID: 37082 RVA: 0x002A07F0 File Offset: 0x0029E9F0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060090DB RID: 37083 RVA: 0x002A0800 File Offset: 0x0029EA00
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060090DC RID: 37084 RVA: 0x002A0810 File Offset: 0x0029EA10
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060090DD RID: 37085 RVA: 0x002A0820 File Offset: 0x0029EA20
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060090DE RID: 37086 RVA: 0x002A0830 File Offset: 0x0029EA30
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060090DF RID: 37087 RVA: 0x002A0840 File Offset: 0x0029EA40
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060090E0 RID: 37088 RVA: 0x002A0850 File Offset: 0x0029EA50
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060090E1 RID: 37089 RVA: 0x002A0860 File Offset: 0x0029EA60
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060090E2 RID: 37090 RVA: 0x002A0870 File Offset: 0x0029EA70
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060090E3 RID: 37091 RVA: 0x002A0880 File Offset: 0x0029EA80
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060090E4 RID: 37092 RVA: 0x002A0890 File Offset: 0x0029EA90
			public void __callDele_EventOnButtonClick(int obj)
			{
				this.m_owner.__callDele_EventOnButtonClick(obj);
			}

			// Token: 0x060090E5 RID: 37093 RVA: 0x002A08A0 File Offset: 0x0029EAA0
			public void __clearDele_EventOnButtonClick(int obj)
			{
				this.m_owner.__clearDele_EventOnButtonClick(obj);
			}

			// Token: 0x17001E1C RID: 7708
			// (get) Token: 0x060090E6 RID: 37094 RVA: 0x002A08B0 File Offset: 0x0029EAB0
			// (set) Token: 0x060090E7 RID: 37095 RVA: 0x002A08C0 File Offset: 0x0029EAC0
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

			// Token: 0x17001E1D RID: 7709
			// (get) Token: 0x060090E8 RID: 37096 RVA: 0x002A08D0 File Offset: 0x0029EAD0
			// (set) Token: 0x060090E9 RID: 37097 RVA: 0x002A08E0 File Offset: 0x0029EAE0
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

			// Token: 0x17001E1E RID: 7710
			// (get) Token: 0x060090EA RID: 37098 RVA: 0x002A08F0 File Offset: 0x0029EAF0
			// (set) Token: 0x060090EB RID: 37099 RVA: 0x002A0900 File Offset: 0x0029EB00
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

			// Token: 0x060090EC RID: 37100 RVA: 0x002A0910 File Offset: 0x0029EB10
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060090ED RID: 37101 RVA: 0x002A0920 File Offset: 0x0029EB20
			public void OnButtonClick()
			{
				this.m_owner.OnButtonClick();
			}

			// Token: 0x040065C5 RID: 26053
			private ActivityNoticeBigItemUIController m_owner;
		}
	}
}
