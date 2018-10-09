using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B97 RID: 2967
	[HotFix]
	public class ClimbTowerRewardListItemUIController : UIControllerBase
	{
		// Token: 0x0600CAE5 RID: 51941 RVA: 0x0037EC74 File Offset: 0x0037CE74
		public void SetReward(List<Goods> rewardList, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRewardList`1String_hotfix != null)
			{
				this.m_SetRewardList`1String_hotfix.call(new object[]
				{
					this,
					rewardList,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = name;
			GameObjectUtility.DestroyChildren(this.m_rewardGroupTransform.gameObject);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			RewardGoodsUIController.CreateRewardGoodsList(rewardList, this.m_rewardGroupTransform, assetInContainer, null, true, 0, true);
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x0600CAE6 RID: 51942 RVA: 0x0037ED30 File Offset: 0x0037CF30
		// (set) Token: 0x0600CAE7 RID: 51943 RVA: 0x0037ED50 File Offset: 0x0037CF50
		[DoNotToLua]
		public new ClimbTowerRewardListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ClimbTowerRewardListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CAE8 RID: 51944 RVA: 0x0037ED5C File Offset: 0x0037CF5C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600CAE9 RID: 51945 RVA: 0x0037ED68 File Offset: 0x0037CF68
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600CAEA RID: 51946 RVA: 0x0037ED70 File Offset: 0x0037CF70
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600CAEB RID: 51947 RVA: 0x0037ED78 File Offset: 0x0037CF78
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600CAEC RID: 51948 RVA: 0x0037ED8C File Offset: 0x0037CF8C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600CAED RID: 51949 RVA: 0x0037ED94 File Offset: 0x0037CF94
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600CAEE RID: 51950 RVA: 0x0037EDA0 File Offset: 0x0037CFA0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600CAEF RID: 51951 RVA: 0x0037EDAC File Offset: 0x0037CFAC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600CAF0 RID: 51952 RVA: 0x0037EDB8 File Offset: 0x0037CFB8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600CAF1 RID: 51953 RVA: 0x0037EDC4 File Offset: 0x0037CFC4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600CAF2 RID: 51954 RVA: 0x0037EDD0 File Offset: 0x0037CFD0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600CAF3 RID: 51955 RVA: 0x0037EDDC File Offset: 0x0037CFDC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600CAF4 RID: 51956 RVA: 0x0037EDE8 File Offset: 0x0037CFE8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600CAF5 RID: 51957 RVA: 0x0037EDF4 File Offset: 0x0037CFF4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600CAF6 RID: 51958 RVA: 0x0037EE00 File Offset: 0x0037D000
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600CAF7 RID: 51959 RVA: 0x0037EE08 File Offset: 0x0037D008
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
					this.m_SetRewardList`1String_hotfix = (luaObj.RawGet("SetReward") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CAF8 RID: 51960 RVA: 0x0037EED4 File Offset: 0x0037D0D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerRewardListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007F98 RID: 32664
		[AutoBind("./Image/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04007F99 RID: 32665
		[AutoBind("./ItemGroup", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_rewardGroupTransform;

		// Token: 0x04007F9A RID: 32666
		[DoNotToLua]
		private ClimbTowerRewardListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007F9B RID: 32667
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007F9C RID: 32668
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007F9D RID: 32669
		private LuaFunction m_SetRewardList;

		// Token: 0x02000B98 RID: 2968
		public new class LuaExportHelper
		{
			// Token: 0x0600CAF9 RID: 51961 RVA: 0x0037EF3C File Offset: 0x0037D13C
			public LuaExportHelper(ClimbTowerRewardListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CAFA RID: 51962 RVA: 0x0037EF4C File Offset: 0x0037D14C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600CAFB RID: 51963 RVA: 0x0037EF5C File Offset: 0x0037D15C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600CAFC RID: 51964 RVA: 0x0037EF6C File Offset: 0x0037D16C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600CAFD RID: 51965 RVA: 0x0037EF7C File Offset: 0x0037D17C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600CAFE RID: 51966 RVA: 0x0037EF94 File Offset: 0x0037D194
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600CAFF RID: 51967 RVA: 0x0037EFA4 File Offset: 0x0037D1A4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600CB00 RID: 51968 RVA: 0x0037EFB4 File Offset: 0x0037D1B4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600CB01 RID: 51969 RVA: 0x0037EFC4 File Offset: 0x0037D1C4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600CB02 RID: 51970 RVA: 0x0037EFD4 File Offset: 0x0037D1D4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600CB03 RID: 51971 RVA: 0x0037EFE4 File Offset: 0x0037D1E4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600CB04 RID: 51972 RVA: 0x0037EFF4 File Offset: 0x0037D1F4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600CB05 RID: 51973 RVA: 0x0037F004 File Offset: 0x0037D204
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600CB06 RID: 51974 RVA: 0x0037F014 File Offset: 0x0037D214
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600CB07 RID: 51975 RVA: 0x0037F024 File Offset: 0x0037D224
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600CB08 RID: 51976 RVA: 0x0037F034 File Offset: 0x0037D234
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700283F RID: 10303
			// (get) Token: 0x0600CB09 RID: 51977 RVA: 0x0037F044 File Offset: 0x0037D244
			// (set) Token: 0x0600CB0A RID: 51978 RVA: 0x0037F054 File Offset: 0x0037D254
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

			// Token: 0x17002840 RID: 10304
			// (get) Token: 0x0600CB0B RID: 51979 RVA: 0x0037F064 File Offset: 0x0037D264
			// (set) Token: 0x0600CB0C RID: 51980 RVA: 0x0037F074 File Offset: 0x0037D274
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

			// Token: 0x04007F9E RID: 32670
			private ClimbTowerRewardListItemUIController m_owner;
		}
	}
}
