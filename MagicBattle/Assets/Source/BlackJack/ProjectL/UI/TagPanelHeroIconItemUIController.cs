using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DA1 RID: 3489
	[HotFix]
	public class TagPanelHeroIconItemUIController : UIControllerBase
	{
		// Token: 0x0601071A RID: 67354 RVA: 0x00448B74 File Offset: 0x00446D74
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
		}

		// Token: 0x0601071B RID: 67355 RVA: 0x00448BF8 File Offset: 0x00446DF8
		public void InitTagHeroIconItem(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTagHeroIconItemInt32_hotfix != null)
			{
				this.m_InitTagHeroIconItemInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.m_heroId = heroId;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(heroId);
			this.m_iconImg.sprite = AssetUtility.Instance.GetSprite(configDataHeroInfo.m_charImageInfo.SmallHeadImage);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool flag = projectLPlayerContext.GetHero(heroId) != null;
			this.m_iconImg.color = ((!flag) ? Color.gray : Color.white);
		}

		// Token: 0x0601071C RID: 67356 RVA: 0x00448CF4 File Offset: 0x00446EF4
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
			RewardGoodsDescUITask.StartUITask(this, GoodsType.GoodsType_Hero, this.m_heroId, 0, null, true);
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0601071D RID: 67357 RVA: 0x00448D68 File Offset: 0x00446F68
		// (set) Token: 0x0601071E RID: 67358 RVA: 0x00448D88 File Offset: 0x00446F88
		[DoNotToLua]
		public new TagPanelHeroIconItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TagPanelHeroIconItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601071F RID: 67359 RVA: 0x00448D94 File Offset: 0x00446F94
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010720 RID: 67360 RVA: 0x00448DA0 File Offset: 0x00446FA0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010721 RID: 67361 RVA: 0x00448DA8 File Offset: 0x00446FA8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010722 RID: 67362 RVA: 0x00448DB0 File Offset: 0x00446FB0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010723 RID: 67363 RVA: 0x00448DC4 File Offset: 0x00446FC4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010724 RID: 67364 RVA: 0x00448DCC File Offset: 0x00446FCC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010725 RID: 67365 RVA: 0x00448DD8 File Offset: 0x00446FD8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010726 RID: 67366 RVA: 0x00448DE4 File Offset: 0x00446FE4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010727 RID: 67367 RVA: 0x00448DF0 File Offset: 0x00446FF0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010728 RID: 67368 RVA: 0x00448DFC File Offset: 0x00446FFC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010729 RID: 67369 RVA: 0x00448E08 File Offset: 0x00447008
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601072A RID: 67370 RVA: 0x00448E14 File Offset: 0x00447014
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601072B RID: 67371 RVA: 0x00448E20 File Offset: 0x00447020
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601072C RID: 67372 RVA: 0x00448E2C File Offset: 0x0044702C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601072D RID: 67373 RVA: 0x00448E38 File Offset: 0x00447038
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601072E RID: 67374 RVA: 0x00448E40 File Offset: 0x00447040
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
					this.m_InitTagHeroIconItemInt32_hotfix = (luaObj.RawGet("InitTagHeroIconItem") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601072F RID: 67375 RVA: 0x00448F40 File Offset: 0x00447140
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TagPanelHeroIconItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009896 RID: 39062
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04009897 RID: 39063
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImg;

		// Token: 0x04009898 RID: 39064
		private int m_heroId;

		// Token: 0x04009899 RID: 39065
		[DoNotToLua]
		private TagPanelHeroIconItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400989A RID: 39066
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400989B RID: 39067
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400989C RID: 39068
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400989D RID: 39069
		private LuaFunction m_InitTagHeroIconItemInt32_hotfix;

		// Token: 0x0400989E RID: 39070
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x02000DA2 RID: 3490
		public new class LuaExportHelper
		{
			// Token: 0x06010730 RID: 67376 RVA: 0x00448FA8 File Offset: 0x004471A8
			public LuaExportHelper(TagPanelHeroIconItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010731 RID: 67377 RVA: 0x00448FB8 File Offset: 0x004471B8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010732 RID: 67378 RVA: 0x00448FC8 File Offset: 0x004471C8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010733 RID: 67379 RVA: 0x00448FD8 File Offset: 0x004471D8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010734 RID: 67380 RVA: 0x00448FE8 File Offset: 0x004471E8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010735 RID: 67381 RVA: 0x00449000 File Offset: 0x00447200
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010736 RID: 67382 RVA: 0x00449010 File Offset: 0x00447210
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010737 RID: 67383 RVA: 0x00449020 File Offset: 0x00447220
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010738 RID: 67384 RVA: 0x00449030 File Offset: 0x00447230
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010739 RID: 67385 RVA: 0x00449040 File Offset: 0x00447240
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601073A RID: 67386 RVA: 0x00449050 File Offset: 0x00447250
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601073B RID: 67387 RVA: 0x00449060 File Offset: 0x00447260
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601073C RID: 67388 RVA: 0x00449070 File Offset: 0x00447270
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601073D RID: 67389 RVA: 0x00449080 File Offset: 0x00447280
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601073E RID: 67390 RVA: 0x00449090 File Offset: 0x00447290
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601073F RID: 67391 RVA: 0x004490A0 File Offset: 0x004472A0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170032C1 RID: 12993
			// (get) Token: 0x06010740 RID: 67392 RVA: 0x004490B0 File Offset: 0x004472B0
			// (set) Token: 0x06010741 RID: 67393 RVA: 0x004490C0 File Offset: 0x004472C0
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

			// Token: 0x170032C2 RID: 12994
			// (get) Token: 0x06010742 RID: 67394 RVA: 0x004490D0 File Offset: 0x004472D0
			// (set) Token: 0x06010743 RID: 67395 RVA: 0x004490E0 File Offset: 0x004472E0
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

			// Token: 0x170032C3 RID: 12995
			// (get) Token: 0x06010744 RID: 67396 RVA: 0x004490F0 File Offset: 0x004472F0
			// (set) Token: 0x06010745 RID: 67397 RVA: 0x00449100 File Offset: 0x00447300
			public int m_heroId
			{
				get
				{
					return this.m_owner.m_heroId;
				}
				set
				{
					this.m_owner.m_heroId = value;
				}
			}

			// Token: 0x06010746 RID: 67398 RVA: 0x00449110 File Offset: 0x00447310
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010747 RID: 67399 RVA: 0x00449120 File Offset: 0x00447320
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400989F RID: 39071
			private TagPanelHeroIconItemUIController m_owner;
		}
	}
}
