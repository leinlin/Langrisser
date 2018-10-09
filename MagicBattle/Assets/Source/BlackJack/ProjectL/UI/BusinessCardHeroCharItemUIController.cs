using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B32 RID: 2866
	[HotFix]
	public class BusinessCardHeroCharItemUIController : UIControllerBase
	{
		// Token: 0x0600C256 RID: 49750 RVA: 0x0035F34C File Offset: 0x0035D54C
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
			this.m_itemButton.onClick.AddListener(new UnityAction(this.OnButtonClick));
		}

		// Token: 0x0600C257 RID: 49751 RVA: 0x0035F3D0 File Offset: 0x0035D5D0
		public void SetHeroCharItem(BattleHero battleHero, int positionIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroCharItemBattleHeroInt32_hotfix != null)
			{
				this.m_SetHeroCharItemBattleHeroInt32_hotfix.call(new object[]
				{
					this,
					battleHero,
					positionIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleHero = battleHero;
			this.m_positionIndex = positionIndex;
			this.m_emptyGameObject.SetActive(false);
		}

		// Token: 0x0600C258 RID: 49752 RVA: 0x0035F46C File Offset: 0x0035D66C
		public void SetNoHeroChar(int positionIndex, bool isMe)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNoHeroCharInt32Boolean_hotfix != null)
			{
				this.m_SetNoHeroCharInt32Boolean_hotfix.call(new object[]
				{
					this,
					positionIndex,
					isMe
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_positionIndex = positionIndex;
			this.m_emptyGameObject.SetActive(isMe);
			this.m_itemButton.interactable = isMe;
		}

		// Token: 0x0600C259 RID: 49753 RVA: 0x0035F50C File Offset: 0x0035D70C
		public BattleHero GetBattleHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleHero_hotfix != null)
			{
				return (BattleHero)this.m_GetBattleHero_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleHero;
		}

		// Token: 0x0600C25A RID: 49754 RVA: 0x0035F580 File Offset: 0x0035D780
		public int GetPositionIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPositionIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPositionIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_positionIndex;
		}

		// Token: 0x0600C25B RID: 49755 RVA: 0x0035F5F4 File Offset: 0x0035D7F4
		public bool IsEmpty()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEmpty_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEmpty_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_emptyGameObject.activeSelf;
		}

		// Token: 0x0600C25C RID: 49756 RVA: 0x0035F66C File Offset: 0x0035D86C
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
				this.EventOnClick(this);
			}
		}

		// Token: 0x14000252 RID: 594
		// (add) Token: 0x0600C25D RID: 49757 RVA: 0x0035F6E4 File Offset: 0x0035D8E4
		// (remove) Token: 0x0600C25E RID: 49758 RVA: 0x0035F780 File Offset: 0x0035D980
		public event Action<BusinessCardHeroCharItemUIController> EventOnClick
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
				Action<BusinessCardHeroCharItemUIController> action = this.EventOnClick;
				Action<BusinessCardHeroCharItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BusinessCardHeroCharItemUIController>>(ref this.EventOnClick, (Action<BusinessCardHeroCharItemUIController>)Delegate.Combine(action2, value), action);
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
				Action<BusinessCardHeroCharItemUIController> action = this.EventOnClick;
				Action<BusinessCardHeroCharItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BusinessCardHeroCharItemUIController>>(ref this.EventOnClick, (Action<BusinessCardHeroCharItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x0600C25F RID: 49759 RVA: 0x0035F81C File Offset: 0x0035DA1C
		// (set) Token: 0x0600C260 RID: 49760 RVA: 0x0035F83C File Offset: 0x0035DA3C
		[DoNotToLua]
		public new BusinessCardHeroCharItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BusinessCardHeroCharItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C261 RID: 49761 RVA: 0x0035F848 File Offset: 0x0035DA48
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C262 RID: 49762 RVA: 0x0035F854 File Offset: 0x0035DA54
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C263 RID: 49763 RVA: 0x0035F85C File Offset: 0x0035DA5C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C264 RID: 49764 RVA: 0x0035F864 File Offset: 0x0035DA64
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C265 RID: 49765 RVA: 0x0035F878 File Offset: 0x0035DA78
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C266 RID: 49766 RVA: 0x0035F880 File Offset: 0x0035DA80
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C267 RID: 49767 RVA: 0x0035F88C File Offset: 0x0035DA8C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C268 RID: 49768 RVA: 0x0035F898 File Offset: 0x0035DA98
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x0035F8A4 File Offset: 0x0035DAA4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C26A RID: 49770 RVA: 0x0035F8B0 File Offset: 0x0035DAB0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C26B RID: 49771 RVA: 0x0035F8BC File Offset: 0x0035DABC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C26C RID: 49772 RVA: 0x0035F8C8 File Offset: 0x0035DAC8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C26D RID: 49773 RVA: 0x0035F8D4 File Offset: 0x0035DAD4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C26E RID: 49774 RVA: 0x0035F8E0 File Offset: 0x0035DAE0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C26F RID: 49775 RVA: 0x0035F8EC File Offset: 0x0035DAEC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C270 RID: 49776 RVA: 0x0035F8F4 File Offset: 0x0035DAF4
		private void __callDele_EventOnClick(BusinessCardHeroCharItemUIController obj)
		{
			Action<BusinessCardHeroCharItemUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600C271 RID: 49777 RVA: 0x0035F918 File Offset: 0x0035DB18
		private void __clearDele_EventOnClick(BusinessCardHeroCharItemUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600C272 RID: 49778 RVA: 0x0035F924 File Offset: 0x0035DB24
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
					this.m_SetHeroCharItemBattleHeroInt32_hotfix = (luaObj.RawGet("SetHeroCharItem") as LuaFunction);
					this.m_SetNoHeroCharInt32Boolean_hotfix = (luaObj.RawGet("SetNoHeroChar") as LuaFunction);
					this.m_GetBattleHero_hotfix = (luaObj.RawGet("GetBattleHero") as LuaFunction);
					this.m_GetPositionIndex_hotfix = (luaObj.RawGet("GetPositionIndex") as LuaFunction);
					this.m_IsEmpty_hotfix = (luaObj.RawGet("IsEmpty") as LuaFunction);
					this.m_OnButtonClick_hotfix = (luaObj.RawGet("OnButtonClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C273 RID: 49779 RVA: 0x0035FAB8 File Offset: 0x0035DCB8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardHeroCharItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007B89 RID: 31625
		[AutoBind("./Button", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_itemButton;

		// Token: 0x04007B8A RID: 31626
		[AutoBind("./Empty", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_emptyGameObject;

		// Token: 0x04007B8C RID: 31628
		private int m_positionIndex = -1;

		// Token: 0x04007B8D RID: 31629
		private BattleHero m_battleHero;

		// Token: 0x04007B8E RID: 31630
		[DoNotToLua]
		private BusinessCardHeroCharItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007B8F RID: 31631
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007B90 RID: 31632
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007B91 RID: 31633
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007B92 RID: 31634
		private LuaFunction m_SetHeroCharItemBattleHeroInt32_hotfix;

		// Token: 0x04007B93 RID: 31635
		private LuaFunction m_SetNoHeroCharInt32Boolean_hotfix;

		// Token: 0x04007B94 RID: 31636
		private LuaFunction m_GetBattleHero_hotfix;

		// Token: 0x04007B95 RID: 31637
		private LuaFunction m_GetPositionIndex_hotfix;

		// Token: 0x04007B96 RID: 31638
		private LuaFunction m_IsEmpty_hotfix;

		// Token: 0x04007B97 RID: 31639
		private LuaFunction m_OnButtonClick_hotfix;

		// Token: 0x04007B98 RID: 31640
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04007B99 RID: 31641
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000B33 RID: 2867
		public new class LuaExportHelper
		{
			// Token: 0x0600C274 RID: 49780 RVA: 0x0035FB20 File Offset: 0x0035DD20
			public LuaExportHelper(BusinessCardHeroCharItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C275 RID: 49781 RVA: 0x0035FB30 File Offset: 0x0035DD30
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C276 RID: 49782 RVA: 0x0035FB40 File Offset: 0x0035DD40
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C277 RID: 49783 RVA: 0x0035FB50 File Offset: 0x0035DD50
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C278 RID: 49784 RVA: 0x0035FB60 File Offset: 0x0035DD60
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C279 RID: 49785 RVA: 0x0035FB78 File Offset: 0x0035DD78
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C27A RID: 49786 RVA: 0x0035FB88 File Offset: 0x0035DD88
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C27B RID: 49787 RVA: 0x0035FB98 File Offset: 0x0035DD98
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C27C RID: 49788 RVA: 0x0035FBA8 File Offset: 0x0035DDA8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C27D RID: 49789 RVA: 0x0035FBB8 File Offset: 0x0035DDB8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C27E RID: 49790 RVA: 0x0035FBC8 File Offset: 0x0035DDC8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C27F RID: 49791 RVA: 0x0035FBD8 File Offset: 0x0035DDD8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C280 RID: 49792 RVA: 0x0035FBE8 File Offset: 0x0035DDE8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C281 RID: 49793 RVA: 0x0035FBF8 File Offset: 0x0035DDF8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C282 RID: 49794 RVA: 0x0035FC08 File Offset: 0x0035DE08
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C283 RID: 49795 RVA: 0x0035FC18 File Offset: 0x0035DE18
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C284 RID: 49796 RVA: 0x0035FC28 File Offset: 0x0035DE28
			public void __callDele_EventOnClick(BusinessCardHeroCharItemUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600C285 RID: 49797 RVA: 0x0035FC38 File Offset: 0x0035DE38
			public void __clearDele_EventOnClick(BusinessCardHeroCharItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002717 RID: 10007
			// (get) Token: 0x0600C286 RID: 49798 RVA: 0x0035FC48 File Offset: 0x0035DE48
			// (set) Token: 0x0600C287 RID: 49799 RVA: 0x0035FC58 File Offset: 0x0035DE58
			public Button m_itemButton
			{
				get
				{
					return this.m_owner.m_itemButton;
				}
				set
				{
					this.m_owner.m_itemButton = value;
				}
			}

			// Token: 0x17002718 RID: 10008
			// (get) Token: 0x0600C288 RID: 49800 RVA: 0x0035FC68 File Offset: 0x0035DE68
			// (set) Token: 0x0600C289 RID: 49801 RVA: 0x0035FC78 File Offset: 0x0035DE78
			public GameObject m_emptyGameObject
			{
				get
				{
					return this.m_owner.m_emptyGameObject;
				}
				set
				{
					this.m_owner.m_emptyGameObject = value;
				}
			}

			// Token: 0x17002719 RID: 10009
			// (get) Token: 0x0600C28A RID: 49802 RVA: 0x0035FC88 File Offset: 0x0035DE88
			// (set) Token: 0x0600C28B RID: 49803 RVA: 0x0035FC98 File Offset: 0x0035DE98
			public int m_positionIndex
			{
				get
				{
					return this.m_owner.m_positionIndex;
				}
				set
				{
					this.m_owner.m_positionIndex = value;
				}
			}

			// Token: 0x1700271A RID: 10010
			// (get) Token: 0x0600C28C RID: 49804 RVA: 0x0035FCA8 File Offset: 0x0035DEA8
			// (set) Token: 0x0600C28D RID: 49805 RVA: 0x0035FCB8 File Offset: 0x0035DEB8
			public BattleHero m_battleHero
			{
				get
				{
					return this.m_owner.m_battleHero;
				}
				set
				{
					this.m_owner.m_battleHero = value;
				}
			}

			// Token: 0x0600C28E RID: 49806 RVA: 0x0035FCC8 File Offset: 0x0035DEC8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C28F RID: 49807 RVA: 0x0035FCD8 File Offset: 0x0035DED8
			public void OnButtonClick()
			{
				this.m_owner.OnButtonClick();
			}

			// Token: 0x04007B9A RID: 31642
			private BusinessCardHeroCharItemUIController m_owner;
		}
	}
}
