using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F2C RID: 3884
	[HotFix]
	public class MemoryStoreHeroFragmentItemUIController : UIControllerBase
	{
		// Token: 0x06013623 RID: 79395 RVA: 0x004F1564 File Offset: 0x004EF764
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
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x06013624 RID: 79396 RVA: 0x004F15F8 File Offset: 0x004EF7F8
		public void InitHeroFragmentItem(HeroFragmentBagItem heroFragementBagItem)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroFragmentItemHeroFragmentBagItem_hotfix != null)
			{
				this.m_InitHeroFragmentItemHeroFragmentBagItem_hotfix.call(new object[]
				{
					this,
					heroFragementBagItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroFragementBagItem = heroFragementBagItem;
			this.m_iconImg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(GoodsType.GoodsType_Item, this.m_heroFragementBagItem.ContentId));
			this.m_iconImg.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(GoodsType.GoodsType_Item, this.m_heroFragementBagItem.ContentId));
			this.m_numberText.text = heroFragementBagItem.Nums.ToString();
			this.m_nameText.text = heroFragementBagItem.ItemInfo.Name;
		}

		// Token: 0x06013625 RID: 79397 RVA: 0x004F16F0 File Offset: 0x004EF8F0
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
			RewardGoodsDescUITask.StartUITask(this, GoodsType.GoodsType_Item, this.m_heroFragementBagItem.ContentId, 0, null, true);
		}

		// Token: 0x17003A85 RID: 14981
		// (get) Token: 0x06013626 RID: 79398 RVA: 0x004F1768 File Offset: 0x004EF968
		// (set) Token: 0x06013627 RID: 79399 RVA: 0x004F1788 File Offset: 0x004EF988
		[DoNotToLua]
		public new MemoryStoreHeroFragmentItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MemoryStoreHeroFragmentItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013628 RID: 79400 RVA: 0x004F1794 File Offset: 0x004EF994
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013629 RID: 79401 RVA: 0x004F17A0 File Offset: 0x004EF9A0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601362A RID: 79402 RVA: 0x004F17A8 File Offset: 0x004EF9A8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601362B RID: 79403 RVA: 0x004F17B0 File Offset: 0x004EF9B0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601362C RID: 79404 RVA: 0x004F17C4 File Offset: 0x004EF9C4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601362D RID: 79405 RVA: 0x004F17CC File Offset: 0x004EF9CC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601362E RID: 79406 RVA: 0x004F17D8 File Offset: 0x004EF9D8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601362F RID: 79407 RVA: 0x004F17E4 File Offset: 0x004EF9E4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013630 RID: 79408 RVA: 0x004F17F0 File Offset: 0x004EF9F0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013631 RID: 79409 RVA: 0x004F17FC File Offset: 0x004EF9FC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013632 RID: 79410 RVA: 0x004F1808 File Offset: 0x004EFA08
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013633 RID: 79411 RVA: 0x004F1814 File Offset: 0x004EFA14
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013634 RID: 79412 RVA: 0x004F1820 File Offset: 0x004EFA20
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013635 RID: 79413 RVA: 0x004F182C File Offset: 0x004EFA2C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013636 RID: 79414 RVA: 0x004F1838 File Offset: 0x004EFA38
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013637 RID: 79415 RVA: 0x004F1840 File Offset: 0x004EFA40
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
					this.m_InitHeroFragmentItemHeroFragmentBagItem_hotfix = (luaObj.RawGet("InitHeroFragmentItem") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013638 RID: 79416 RVA: 0x004F1940 File Offset: 0x004EFB40
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MemoryStoreHeroFragmentItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AC50 RID: 44112
		[AutoBind("./Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImg;

		// Token: 0x0400AC51 RID: 44113
		[AutoBind("./NumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_numberText;

		// Token: 0x0400AC52 RID: 44114
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400AC53 RID: 44115
		private HeroFragmentBagItem m_heroFragementBagItem;

		// Token: 0x0400AC54 RID: 44116
		[DoNotToLua]
		private MemoryStoreHeroFragmentItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AC55 RID: 44117
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AC56 RID: 44118
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AC57 RID: 44119
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AC58 RID: 44120
		private LuaFunction m_InitHeroFragmentItemHeroFragmentBagItem_hotfix;

		// Token: 0x0400AC59 RID: 44121
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x02000F2D RID: 3885
		public new class LuaExportHelper
		{
			// Token: 0x06013639 RID: 79417 RVA: 0x004F19A8 File Offset: 0x004EFBA8
			public LuaExportHelper(MemoryStoreHeroFragmentItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601363A RID: 79418 RVA: 0x004F19B8 File Offset: 0x004EFBB8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601363B RID: 79419 RVA: 0x004F19C8 File Offset: 0x004EFBC8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601363C RID: 79420 RVA: 0x004F19D8 File Offset: 0x004EFBD8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601363D RID: 79421 RVA: 0x004F19E8 File Offset: 0x004EFBE8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601363E RID: 79422 RVA: 0x004F1A00 File Offset: 0x004EFC00
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601363F RID: 79423 RVA: 0x004F1A10 File Offset: 0x004EFC10
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013640 RID: 79424 RVA: 0x004F1A20 File Offset: 0x004EFC20
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013641 RID: 79425 RVA: 0x004F1A30 File Offset: 0x004EFC30
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013642 RID: 79426 RVA: 0x004F1A40 File Offset: 0x004EFC40
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013643 RID: 79427 RVA: 0x004F1A50 File Offset: 0x004EFC50
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013644 RID: 79428 RVA: 0x004F1A60 File Offset: 0x004EFC60
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013645 RID: 79429 RVA: 0x004F1A70 File Offset: 0x004EFC70
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013646 RID: 79430 RVA: 0x004F1A80 File Offset: 0x004EFC80
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013647 RID: 79431 RVA: 0x004F1A90 File Offset: 0x004EFC90
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013648 RID: 79432 RVA: 0x004F1AA0 File Offset: 0x004EFCA0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003A86 RID: 14982
			// (get) Token: 0x06013649 RID: 79433 RVA: 0x004F1AB0 File Offset: 0x004EFCB0
			// (set) Token: 0x0601364A RID: 79434 RVA: 0x004F1AC0 File Offset: 0x004EFCC0
			public Image m_iconImg
			{
				get
				{
					return this.m_owner.m_iconImg;
				}
				set
				{
					this.m_owner.m_iconImg = value;
				}
			}

			// Token: 0x17003A87 RID: 14983
			// (get) Token: 0x0601364B RID: 79435 RVA: 0x004F1AD0 File Offset: 0x004EFCD0
			// (set) Token: 0x0601364C RID: 79436 RVA: 0x004F1AE0 File Offset: 0x004EFCE0
			public Text m_numberText
			{
				get
				{
					return this.m_owner.m_numberText;
				}
				set
				{
					this.m_owner.m_numberText = value;
				}
			}

			// Token: 0x17003A88 RID: 14984
			// (get) Token: 0x0601364D RID: 79437 RVA: 0x004F1AF0 File Offset: 0x004EFCF0
			// (set) Token: 0x0601364E RID: 79438 RVA: 0x004F1B00 File Offset: 0x004EFD00
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

			// Token: 0x17003A89 RID: 14985
			// (get) Token: 0x0601364F RID: 79439 RVA: 0x004F1B10 File Offset: 0x004EFD10
			// (set) Token: 0x06013650 RID: 79440 RVA: 0x004F1B20 File Offset: 0x004EFD20
			public HeroFragmentBagItem m_heroFragementBagItem
			{
				get
				{
					return this.m_owner.m_heroFragementBagItem;
				}
				set
				{
					this.m_owner.m_heroFragementBagItem = value;
				}
			}

			// Token: 0x06013651 RID: 79441 RVA: 0x004F1B30 File Offset: 0x004EFD30
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013652 RID: 79442 RVA: 0x004F1B40 File Offset: 0x004EFD40
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400AC5A RID: 44122
			private MemoryStoreHeroFragmentItemUIController m_owner;
		}
	}
}
