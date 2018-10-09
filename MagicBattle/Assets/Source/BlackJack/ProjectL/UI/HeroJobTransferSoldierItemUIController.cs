using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DC6 RID: 3526
	[HotFix]
	public class HeroJobTransferSoldierItemUIController : UIControllerBase
	{
		// Token: 0x06010D71 RID: 68977 RVA: 0x0045D1D0 File Offset: 0x0045B3D0
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
			base.gameObject.SetActive(true);
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnSoldierItemClick));
		}

		// Token: 0x06010D72 RID: 68978 RVA: 0x0045D264 File Offset: 0x0045B464
		public void InitSoldierItem(ConfigDataSoldierInfo soldierInfo, Hero hero, GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSoldierItemConfigDataSoldierInfoHeroGameObject_hotfix != null)
			{
				this.m_InitSoldierItemConfigDataSoldierInfoHeroGameObject_hotfix.call(new object[]
				{
					this,
					soldierInfo,
					hero,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_descGo = go;
			this.m_soldierInfo = soldierInfo;
		}

		// Token: 0x06010D73 RID: 68979 RVA: 0x0045D30C File Offset: 0x0045B50C
		private void OnSoldierItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSoldierItemClick_hotfix != null)
			{
				this.m_OnSoldierItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_soldierInfo == null)
			{
				return;
			}
			SoldierDescUIController soldierDescUIController = null;
			bool flag = false;
			for (int i = 0; i < this.m_descGo.transform.childCount; i++)
			{
				Transform child = this.m_descGo.transform.GetChild(i);
				if (child.name == "CommonSoldierDesc")
				{
					flag = true;
					soldierDescUIController = child.gameObject.GetComponent<SoldierDescUIController>();
					break;
				}
			}
			if (!flag)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("commonSoldierDesc");
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				soldierDescUIController = gameObject.GetComponent<SoldierDescUIController>();
				gameObject.transform.SetParent(this.m_descGo.transform, false);
				gameObject.name = "CommonSoldierDesc";
			}
			soldierDescUIController.InitSoldierDesc(this.m_soldierInfo, this.m_hero);
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x06010D74 RID: 68980 RVA: 0x0045D43C File Offset: 0x0045B63C
		// (set) Token: 0x06010D75 RID: 68981 RVA: 0x0045D45C File Offset: 0x0045B65C
		[DoNotToLua]
		public new HeroJobTransferSoldierItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroJobTransferSoldierItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010D76 RID: 68982 RVA: 0x0045D468 File Offset: 0x0045B668
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010D77 RID: 68983 RVA: 0x0045D474 File Offset: 0x0045B674
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010D78 RID: 68984 RVA: 0x0045D47C File Offset: 0x0045B67C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010D79 RID: 68985 RVA: 0x0045D484 File Offset: 0x0045B684
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010D7A RID: 68986 RVA: 0x0045D498 File Offset: 0x0045B698
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010D7B RID: 68987 RVA: 0x0045D4A0 File Offset: 0x0045B6A0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010D7C RID: 68988 RVA: 0x0045D4AC File Offset: 0x0045B6AC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010D7D RID: 68989 RVA: 0x0045D4B8 File Offset: 0x0045B6B8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010D7E RID: 68990 RVA: 0x0045D4C4 File Offset: 0x0045B6C4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010D7F RID: 68991 RVA: 0x0045D4D0 File Offset: 0x0045B6D0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010D80 RID: 68992 RVA: 0x0045D4DC File Offset: 0x0045B6DC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010D81 RID: 68993 RVA: 0x0045D4E8 File Offset: 0x0045B6E8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010D82 RID: 68994 RVA: 0x0045D4F4 File Offset: 0x0045B6F4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010D83 RID: 68995 RVA: 0x0045D500 File Offset: 0x0045B700
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010D84 RID: 68996 RVA: 0x0045D50C File Offset: 0x0045B70C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010D85 RID: 68997 RVA: 0x0045D514 File Offset: 0x0045B714
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
					this.m_InitSoldierItemConfigDataSoldierInfoHeroGameObject_hotfix = (luaObj.RawGet("InitSoldierItem") as LuaFunction);
					this.m_OnSoldierItemClick_hotfix = (luaObj.RawGet("OnSoldierItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010D86 RID: 68998 RVA: 0x0045D614 File Offset: 0x0045B814
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobTransferSoldierItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009B55 RID: 39765
		private Hero m_hero;

		// Token: 0x04009B56 RID: 39766
		private GameObject m_descGo;

		// Token: 0x04009B57 RID: 39767
		public ConfigDataSoldierInfo m_soldierInfo;

		// Token: 0x04009B58 RID: 39768
		[DoNotToLua]
		private HeroJobTransferSoldierItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009B59 RID: 39769
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009B5A RID: 39770
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009B5B RID: 39771
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009B5C RID: 39772
		private LuaFunction m_InitSoldierItemConfigDataSoldierInfoHeroGameObject_hotfix;

		// Token: 0x04009B5D RID: 39773
		private LuaFunction m_OnSoldierItemClick_hotfix;

		// Token: 0x02000DC7 RID: 3527
		public new class LuaExportHelper
		{
			// Token: 0x06010D87 RID: 68999 RVA: 0x0045D67C File Offset: 0x0045B87C
			public LuaExportHelper(HeroJobTransferSoldierItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010D88 RID: 69000 RVA: 0x0045D68C File Offset: 0x0045B88C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010D89 RID: 69001 RVA: 0x0045D69C File Offset: 0x0045B89C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010D8A RID: 69002 RVA: 0x0045D6AC File Offset: 0x0045B8AC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010D8B RID: 69003 RVA: 0x0045D6BC File Offset: 0x0045B8BC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010D8C RID: 69004 RVA: 0x0045D6D4 File Offset: 0x0045B8D4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010D8D RID: 69005 RVA: 0x0045D6E4 File Offset: 0x0045B8E4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010D8E RID: 69006 RVA: 0x0045D6F4 File Offset: 0x0045B8F4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010D8F RID: 69007 RVA: 0x0045D704 File Offset: 0x0045B904
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010D90 RID: 69008 RVA: 0x0045D714 File Offset: 0x0045B914
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010D91 RID: 69009 RVA: 0x0045D724 File Offset: 0x0045B924
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010D92 RID: 69010 RVA: 0x0045D734 File Offset: 0x0045B934
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010D93 RID: 69011 RVA: 0x0045D744 File Offset: 0x0045B944
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010D94 RID: 69012 RVA: 0x0045D754 File Offset: 0x0045B954
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010D95 RID: 69013 RVA: 0x0045D764 File Offset: 0x0045B964
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010D96 RID: 69014 RVA: 0x0045D774 File Offset: 0x0045B974
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700343F RID: 13375
			// (get) Token: 0x06010D97 RID: 69015 RVA: 0x0045D784 File Offset: 0x0045B984
			// (set) Token: 0x06010D98 RID: 69016 RVA: 0x0045D794 File Offset: 0x0045B994
			public Hero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17003440 RID: 13376
			// (get) Token: 0x06010D99 RID: 69017 RVA: 0x0045D7A4 File Offset: 0x0045B9A4
			// (set) Token: 0x06010D9A RID: 69018 RVA: 0x0045D7B4 File Offset: 0x0045B9B4
			public GameObject m_descGo
			{
				get
				{
					return this.m_owner.m_descGo;
				}
				set
				{
					this.m_owner.m_descGo = value;
				}
			}

			// Token: 0x06010D9B RID: 69019 RVA: 0x0045D7C4 File Offset: 0x0045B9C4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010D9C RID: 69020 RVA: 0x0045D7D4 File Offset: 0x0045B9D4
			public void OnSoldierItemClick()
			{
				this.m_owner.OnSoldierItemClick();
			}

			// Token: 0x04009B5E RID: 39774
			private HeroJobTransferSoldierItemUIController m_owner;
		}
	}
}
