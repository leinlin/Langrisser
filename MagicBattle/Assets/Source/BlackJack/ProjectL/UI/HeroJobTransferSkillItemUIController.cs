using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DC4 RID: 3524
	[HotFix]
	public class HeroJobTransferSkillItemUIController : UIControllerBase
	{
		// Token: 0x06010D42 RID: 68930 RVA: 0x0045CB90 File Offset: 0x0045AD90
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
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnSkillItemClick));
		}

		// Token: 0x06010D43 RID: 68931 RVA: 0x0045CC24 File Offset: 0x0045AE24
		public void InitSkillItem(ConfigDataSkillInfo skillInfo, GameObject descParent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSkillItemConfigDataSkillInfoGameObject_hotfix != null)
			{
				this.m_InitSkillItemConfigDataSkillInfoGameObject_hotfix.call(new object[]
				{
					this,
					skillInfo,
					descParent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_skillInfo = skillInfo;
			this.m_descParent = descParent;
			this.m_skillIconImg.sprite = AssetUtility.Instance.GetSprite(this.m_skillInfo.Icon);
			this.m_passiveSkillIconObj.SetActive(skillInfo.IsPassiveSkill());
		}

		// Token: 0x06010D44 RID: 68932 RVA: 0x0045CCE4 File Offset: 0x0045AEE4
		private void OnSkillItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkillItemClick_hotfix != null)
			{
				this.m_OnSkillItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			SkillDescUIController skillDescUIController = null;
			bool flag = false;
			for (int i = 0; i < this.m_descParent.transform.childCount; i++)
			{
				Transform child = this.m_descParent.transform.GetChild(i);
				if (child.name == "CommonSkillDesc")
				{
					flag = true;
					skillDescUIController = child.gameObject.GetComponent<SkillDescUIController>();
					break;
				}
			}
			if (!flag)
			{
				GameObject assetInContainer = base.GetAssetInContainer<GameObject>("commonSkillDesc");
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(assetInContainer);
				PrefabControllerCreater.CreateAllControllers(gameObject);
				skillDescUIController = gameObject.GetComponent<SkillDescUIController>();
				gameObject.transform.SetParent(this.m_descParent.transform, false);
				gameObject.name = "CommonSkillDesc";
			}
			skillDescUIController.InitSkillDesc(this.m_skillInfo);
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x06010D45 RID: 68933 RVA: 0x0045CE00 File Offset: 0x0045B000
		// (set) Token: 0x06010D46 RID: 68934 RVA: 0x0045CE20 File Offset: 0x0045B020
		[DoNotToLua]
		public new HeroJobTransferSkillItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroJobTransferSkillItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010D47 RID: 68935 RVA: 0x0045CE2C File Offset: 0x0045B02C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010D48 RID: 68936 RVA: 0x0045CE38 File Offset: 0x0045B038
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010D49 RID: 68937 RVA: 0x0045CE40 File Offset: 0x0045B040
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010D4A RID: 68938 RVA: 0x0045CE48 File Offset: 0x0045B048
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010D4B RID: 68939 RVA: 0x0045CE5C File Offset: 0x0045B05C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010D4C RID: 68940 RVA: 0x0045CE64 File Offset: 0x0045B064
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010D4D RID: 68941 RVA: 0x0045CE70 File Offset: 0x0045B070
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010D4E RID: 68942 RVA: 0x0045CE7C File Offset: 0x0045B07C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010D4F RID: 68943 RVA: 0x0045CE88 File Offset: 0x0045B088
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010D50 RID: 68944 RVA: 0x0045CE94 File Offset: 0x0045B094
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010D51 RID: 68945 RVA: 0x0045CEA0 File Offset: 0x0045B0A0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010D52 RID: 68946 RVA: 0x0045CEAC File Offset: 0x0045B0AC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010D53 RID: 68947 RVA: 0x0045CEB8 File Offset: 0x0045B0B8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010D54 RID: 68948 RVA: 0x0045CEC4 File Offset: 0x0045B0C4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010D55 RID: 68949 RVA: 0x0045CED0 File Offset: 0x0045B0D0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010D56 RID: 68950 RVA: 0x0045CED8 File Offset: 0x0045B0D8
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
					this.m_InitSkillItemConfigDataSkillInfoGameObject_hotfix = (luaObj.RawGet("InitSkillItem") as LuaFunction);
					this.m_OnSkillItemClick_hotfix = (luaObj.RawGet("OnSkillItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010D57 RID: 68951 RVA: 0x0045CFD8 File Offset: 0x0045B1D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobTransferSkillItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009B4A RID: 39754
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillIconImg;

		// Token: 0x04009B4B RID: 39755
		[AutoBind("./Image", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_passiveSkillIconObj;

		// Token: 0x04009B4C RID: 39756
		private GameObject m_descParent;

		// Token: 0x04009B4D RID: 39757
		public ConfigDataSkillInfo m_skillInfo;

		// Token: 0x04009B4E RID: 39758
		[DoNotToLua]
		private HeroJobTransferSkillItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009B4F RID: 39759
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009B50 RID: 39760
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009B51 RID: 39761
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009B52 RID: 39762
		private LuaFunction m_InitSkillItemConfigDataSkillInfoGameObject_hotfix;

		// Token: 0x04009B53 RID: 39763
		private LuaFunction m_OnSkillItemClick_hotfix;

		// Token: 0x02000DC5 RID: 3525
		public new class LuaExportHelper
		{
			// Token: 0x06010D58 RID: 68952 RVA: 0x0045D040 File Offset: 0x0045B240
			public LuaExportHelper(HeroJobTransferSkillItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010D59 RID: 68953 RVA: 0x0045D050 File Offset: 0x0045B250
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010D5A RID: 68954 RVA: 0x0045D060 File Offset: 0x0045B260
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010D5B RID: 68955 RVA: 0x0045D070 File Offset: 0x0045B270
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010D5C RID: 68956 RVA: 0x0045D080 File Offset: 0x0045B280
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010D5D RID: 68957 RVA: 0x0045D098 File Offset: 0x0045B298
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010D5E RID: 68958 RVA: 0x0045D0A8 File Offset: 0x0045B2A8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010D5F RID: 68959 RVA: 0x0045D0B8 File Offset: 0x0045B2B8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010D60 RID: 68960 RVA: 0x0045D0C8 File Offset: 0x0045B2C8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010D61 RID: 68961 RVA: 0x0045D0D8 File Offset: 0x0045B2D8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010D62 RID: 68962 RVA: 0x0045D0E8 File Offset: 0x0045B2E8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010D63 RID: 68963 RVA: 0x0045D0F8 File Offset: 0x0045B2F8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010D64 RID: 68964 RVA: 0x0045D108 File Offset: 0x0045B308
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010D65 RID: 68965 RVA: 0x0045D118 File Offset: 0x0045B318
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010D66 RID: 68966 RVA: 0x0045D128 File Offset: 0x0045B328
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010D67 RID: 68967 RVA: 0x0045D138 File Offset: 0x0045B338
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700343B RID: 13371
			// (get) Token: 0x06010D68 RID: 68968 RVA: 0x0045D148 File Offset: 0x0045B348
			// (set) Token: 0x06010D69 RID: 68969 RVA: 0x0045D158 File Offset: 0x0045B358
			public Image m_skillIconImg
			{
				get
				{
					return this.m_owner.m_skillIconImg;
				}
				set
				{
					this.m_owner.m_skillIconImg = value;
				}
			}

			// Token: 0x1700343C RID: 13372
			// (get) Token: 0x06010D6A RID: 68970 RVA: 0x0045D168 File Offset: 0x0045B368
			// (set) Token: 0x06010D6B RID: 68971 RVA: 0x0045D178 File Offset: 0x0045B378
			public GameObject m_passiveSkillIconObj
			{
				get
				{
					return this.m_owner.m_passiveSkillIconObj;
				}
				set
				{
					this.m_owner.m_passiveSkillIconObj = value;
				}
			}

			// Token: 0x1700343D RID: 13373
			// (get) Token: 0x06010D6C RID: 68972 RVA: 0x0045D188 File Offset: 0x0045B388
			// (set) Token: 0x06010D6D RID: 68973 RVA: 0x0045D198 File Offset: 0x0045B398
			public GameObject m_descParent
			{
				get
				{
					return this.m_owner.m_descParent;
				}
				set
				{
					this.m_owner.m_descParent = value;
				}
			}

			// Token: 0x06010D6E RID: 68974 RVA: 0x0045D1A8 File Offset: 0x0045B3A8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010D6F RID: 68975 RVA: 0x0045D1B8 File Offset: 0x0045B3B8
			public void OnSkillItemClick()
			{
				this.m_owner.OnSkillItemClick();
			}

			// Token: 0x04009B54 RID: 39764
			private HeroJobTransferSkillItemUIController m_owner;
		}
	}
}
