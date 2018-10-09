using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B95 RID: 2965
	[HotFix]
	public class ClimbTowerFloorItemUIController : UIControllerBase
	{
		// Token: 0x0600CAB1 RID: 51889 RVA: 0x0037E434 File Offset: 0x0037C634
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
			Button componentInChildren = base.GetComponentInChildren<Button>();
			if (componentInChildren != null)
			{
				componentInChildren.onClick.AddListener(new UnityAction(this.OnButtonClick));
			}
		}

		// Token: 0x0600CAB2 RID: 51890 RVA: 0x0037E4C4 File Offset: 0x0037C6C4
		public void SetTowerFloor(ConfigDataTowerFloorInfo floorInfo, ConfigDataTowerLevelInfo levelInfo, GameObject rewardGoodsPrefab)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTowerFloorConfigDataTowerFloorInfoConfigDataTowerLevelInfoGameObject_hotfix != null)
			{
				this.m_SetTowerFloorConfigDataTowerFloorInfoConfigDataTowerLevelInfoGameObject_hotfix.call(new object[]
				{
					this,
					floorInfo,
					levelInfo,
					rewardGoodsPrefab
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_rewardGroupTransform.gameObject);
			RewardGoodsUIController.CreateRewardGoodsList(floorInfo.RewardList, this.m_rewardGroupTransform, rewardGoodsPrefab, null, true, 0, true);
			this.CreateSpineGraphic(levelInfo.LevelRes);
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x0037E588 File Offset: 0x0037C788
		public void SetState(bool isCleared, bool isLocked, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStateBooleanBooleanAction_hotfix != null)
			{
				this.m_SetStateBooleanBooleanAction_hotfix.call(new object[]
				{
					this,
					isCleared,
					isLocked,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = string.Empty;
			if (isCleared)
			{
				text = "Clear";
			}
			else if (isLocked)
			{
				text = "Lock";
			}
			else
			{
				text = "Normal";
			}
			if (this.m_spineGraphic != null)
			{
				if (text != "Normal")
				{
					this.m_spineGraphic.SetAnimationSpeed(0f);
				}
				else
				{
					this.m_spineGraphic.SetAnimationSpeed(1f);
				}
			}
			UIUtility.SetUIStateOpen(this.m_uiStateController, text, onEnd, false, true);
		}

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x0037E698 File Offset: 0x0037C898
		public void CreateSpineGraphic(string assetName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicString_hotfix != null)
			{
				this.m_CreateSpineGraphicString_hotfix.call(new object[]
				{
					this,
					assetName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic();
			UISpineGraphic uispineGraphic = new UISpineGraphic();
			uispineGraphic.Create(assetName);
			uispineGraphic.SetParent(this.m_graphicGameObject);
			uispineGraphic.PlayAnimation("idle", true, 0);
			uispineGraphic.ForceUpdate();
			this.m_spineGraphic = uispineGraphic;
		}

		// Token: 0x0600CAB5 RID: 51893 RVA: 0x0037E744 File Offset: 0x0037C944
		public void DestroySpineGraphic()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroySpineGraphic_hotfix != null)
			{
				this.m_DestroySpineGraphic_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_spineGraphic != null)
			{
				this.m_spineGraphic.Destroy();
				this.m_spineGraphic = null;
			}
		}

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x0037E7C4 File Offset: 0x0037C9C4
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
				this.EventOnButtonClick(this);
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x0600CAB7 RID: 51895 RVA: 0x0037E83C File Offset: 0x0037CA3C
		// (set) Token: 0x0600CAB8 RID: 51896 RVA: 0x0037E85C File Offset: 0x0037CA5C
		[DoNotToLua]
		public new ClimbTowerFloorItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClimbTowerFloorItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CAB9 RID: 51897 RVA: 0x0037E868 File Offset: 0x0037CA68
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600CABA RID: 51898 RVA: 0x0037E874 File Offset: 0x0037CA74
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600CABB RID: 51899 RVA: 0x0037E87C File Offset: 0x0037CA7C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600CABC RID: 51900 RVA: 0x0037E884 File Offset: 0x0037CA84
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600CABD RID: 51901 RVA: 0x0037E898 File Offset: 0x0037CA98
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600CABE RID: 51902 RVA: 0x0037E8A0 File Offset: 0x0037CAA0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600CABF RID: 51903 RVA: 0x0037E8AC File Offset: 0x0037CAAC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600CAC0 RID: 51904 RVA: 0x0037E8B8 File Offset: 0x0037CAB8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600CAC1 RID: 51905 RVA: 0x0037E8C4 File Offset: 0x0037CAC4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600CAC2 RID: 51906 RVA: 0x0037E8D0 File Offset: 0x0037CAD0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600CAC3 RID: 51907 RVA: 0x0037E8DC File Offset: 0x0037CADC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600CAC4 RID: 51908 RVA: 0x0037E8E8 File Offset: 0x0037CAE8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600CAC5 RID: 51909 RVA: 0x0037E8F4 File Offset: 0x0037CAF4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600CAC6 RID: 51910 RVA: 0x0037E900 File Offset: 0x0037CB00
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600CAC7 RID: 51911 RVA: 0x0037E90C File Offset: 0x0037CB0C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600CAC8 RID: 51912 RVA: 0x0037E914 File Offset: 0x0037CB14
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
					this.m_SetTowerFloorConfigDataTowerFloorInfoConfigDataTowerLevelInfoGameObject_hotfix = (luaObj.RawGet("SetTowerFloor") as LuaFunction);
					this.m_SetStateBooleanBooleanAction_hotfix = (luaObj.RawGet("SetState") as LuaFunction);
					this.m_CreateSpineGraphicString_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphic_hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					this.m_OnButtonClick_hotfix = (luaObj.RawGet("OnButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CAC9 RID: 51913 RVA: 0x0037EA5C File Offset: 0x0037CC5C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerFloorItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007F89 RID: 32649
		public Action<ClimbTowerFloorItemUIController> EventOnButtonClick;

		// Token: 0x04007F8A RID: 32650
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04007F8B RID: 32651
		[AutoBind("./Char", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_graphicGameObject;

		// Token: 0x04007F8C RID: 32652
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_rewardGroupTransform;

		// Token: 0x04007F8D RID: 32653
		private UISpineGraphic m_spineGraphic;

		// Token: 0x04007F8E RID: 32654
		[DoNotToLua]
		private ClimbTowerFloorItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007F8F RID: 32655
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007F90 RID: 32656
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007F91 RID: 32657
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007F92 RID: 32658
		private LuaFunction m_SetTowerFloorConfigDataTowerFloorInfoConfigDataTowerLevelInfoGameObject_hotfix;

		// Token: 0x04007F93 RID: 32659
		private LuaFunction m_SetStateBooleanBooleanAction_hotfix;

		// Token: 0x04007F94 RID: 32660
		private LuaFunction m_CreateSpineGraphicString_hotfix;

		// Token: 0x04007F95 RID: 32661
		private LuaFunction m_DestroySpineGraphic_hotfix;

		// Token: 0x04007F96 RID: 32662
		private LuaFunction m_OnButtonClick_hotfix;

		// Token: 0x02000B96 RID: 2966
		public new class LuaExportHelper
		{
			// Token: 0x0600CACA RID: 51914 RVA: 0x0037EAC4 File Offset: 0x0037CCC4
			public LuaExportHelper(ClimbTowerFloorItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CACB RID: 51915 RVA: 0x0037EAD4 File Offset: 0x0037CCD4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600CACC RID: 51916 RVA: 0x0037EAE4 File Offset: 0x0037CCE4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600CACD RID: 51917 RVA: 0x0037EAF4 File Offset: 0x0037CCF4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600CACE RID: 51918 RVA: 0x0037EB04 File Offset: 0x0037CD04
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600CACF RID: 51919 RVA: 0x0037EB1C File Offset: 0x0037CD1C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600CAD0 RID: 51920 RVA: 0x0037EB2C File Offset: 0x0037CD2C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600CAD1 RID: 51921 RVA: 0x0037EB3C File Offset: 0x0037CD3C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600CAD2 RID: 51922 RVA: 0x0037EB4C File Offset: 0x0037CD4C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600CAD3 RID: 51923 RVA: 0x0037EB5C File Offset: 0x0037CD5C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600CAD4 RID: 51924 RVA: 0x0037EB6C File Offset: 0x0037CD6C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600CAD5 RID: 51925 RVA: 0x0037EB7C File Offset: 0x0037CD7C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600CAD6 RID: 51926 RVA: 0x0037EB8C File Offset: 0x0037CD8C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600CAD7 RID: 51927 RVA: 0x0037EB9C File Offset: 0x0037CD9C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600CAD8 RID: 51928 RVA: 0x0037EBAC File Offset: 0x0037CDAC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600CAD9 RID: 51929 RVA: 0x0037EBBC File Offset: 0x0037CDBC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700283A RID: 10298
			// (get) Token: 0x0600CADA RID: 51930 RVA: 0x0037EBCC File Offset: 0x0037CDCC
			// (set) Token: 0x0600CADB RID: 51931 RVA: 0x0037EBDC File Offset: 0x0037CDDC
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x1700283B RID: 10299
			// (get) Token: 0x0600CADC RID: 51932 RVA: 0x0037EBEC File Offset: 0x0037CDEC
			// (set) Token: 0x0600CADD RID: 51933 RVA: 0x0037EBFC File Offset: 0x0037CDFC
			public GameObject m_graphicGameObject
			{
				get
				{
					return this.m_owner.m_graphicGameObject;
				}
				set
				{
					this.m_owner.m_graphicGameObject = value;
				}
			}

			// Token: 0x1700283C RID: 10300
			// (get) Token: 0x0600CADE RID: 51934 RVA: 0x0037EC0C File Offset: 0x0037CE0C
			// (set) Token: 0x0600CADF RID: 51935 RVA: 0x0037EC1C File Offset: 0x0037CE1C
			public Transform m_rewardGroupTransform
			{
				get
				{
					return this.m_owner.m_rewardGroupTransform;
				}
				set
				{
					this.m_owner.m_rewardGroupTransform = value;
				}
			}

			// Token: 0x1700283D RID: 10301
			// (get) Token: 0x0600CAE0 RID: 51936 RVA: 0x0037EC2C File Offset: 0x0037CE2C
			// (set) Token: 0x0600CAE1 RID: 51937 RVA: 0x0037EC3C File Offset: 0x0037CE3C
			public UISpineGraphic m_spineGraphic
			{
				get
				{
					return this.m_owner.m_spineGraphic;
				}
				set
				{
					this.m_owner.m_spineGraphic = value;
				}
			}

			// Token: 0x0600CAE2 RID: 51938 RVA: 0x0037EC4C File Offset: 0x0037CE4C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600CAE3 RID: 51939 RVA: 0x0037EC5C File Offset: 0x0037CE5C
			public void OnButtonClick()
			{
				this.m_owner.OnButtonClick();
			}

			// Token: 0x04007F97 RID: 32663
			private ClimbTowerFloorItemUIController m_owner;
		}
	}
}
