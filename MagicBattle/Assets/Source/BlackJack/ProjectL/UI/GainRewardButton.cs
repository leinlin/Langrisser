using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EE4 RID: 3812
	[HotFix]
	public class GainRewardButton : UIControllerBase
	{
		// Token: 0x06012C79 RID: 76921 RVA: 0x004CD77C File Offset: 0x004CB97C
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

		// Token: 0x06012C7A RID: 76922 RVA: 0x004CD800 File Offset: 0x004CBA00
		public void SetId(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIdInt32_hotfix != null)
			{
				this.m_SetIdInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_id = id;
		}

		// Token: 0x06012C7B RID: 76923 RVA: 0x004CD878 File Offset: 0x004CBA78
		public int GetId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_id;
		}

		// Token: 0x06012C7C RID: 76924 RVA: 0x004CD8EC File Offset: 0x004CBAEC
		public void SetNum(int num)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNumInt32_hotfix != null)
			{
				this.m_SetNumInt32_hotfix.call(new object[]
				{
					this,
					num
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_num = num;
			this.m_numText.text = num.ToString();
		}

		// Token: 0x06012C7D RID: 76925 RVA: 0x004CD97C File Offset: 0x004CBB7C
		public int GetNum()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNum_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetNum_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_num;
		}

		// Token: 0x06012C7E RID: 76926 RVA: 0x004CD9F0 File Offset: 0x004CBBF0
		public void SetStatus(GainRewardStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStatusGainRewardStatus_hotfix != null)
			{
				this.m_SetStatusGainRewardStatus_hotfix.call(new object[]
				{
					this,
					status
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_status = status;
			this.m_openGameObject.SetActive(status == GainRewardStatus.Got);
			this.m_closeGameObject.SetActive(status == GainRewardStatus.CanNotGet || status == GainRewardStatus.CanGet);
		}

		// Token: 0x06012C7F RID: 76927 RVA: 0x004CDA90 File Offset: 0x004CBC90
		public GainRewardStatus GetStatus()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStatus_hotfix != null)
			{
				return (GainRewardStatus)this.m_GetStatus_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_status;
		}

		// Token: 0x06012C80 RID: 76928 RVA: 0x004CDB04 File Offset: 0x004CBD04
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
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x14000414 RID: 1044
		// (add) Token: 0x06012C81 RID: 76929 RVA: 0x004CDB7C File Offset: 0x004CBD7C
		// (remove) Token: 0x06012C82 RID: 76930 RVA: 0x004CDC18 File Offset: 0x004CBE18
		public event Action<GainRewardButton> EventOnClick
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
				Action<GainRewardButton> action = this.EventOnClick;
				Action<GainRewardButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GainRewardButton>>(ref this.EventOnClick, (Action<GainRewardButton>)Delegate.Combine(action2, value), action);
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
				Action<GainRewardButton> action = this.EventOnClick;
				Action<GainRewardButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GainRewardButton>>(ref this.EventOnClick, (Action<GainRewardButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x06012C83 RID: 76931 RVA: 0x004CDCB4 File Offset: 0x004CBEB4
		// (set) Token: 0x06012C84 RID: 76932 RVA: 0x004CDCD4 File Offset: 0x004CBED4
		[DoNotToLua]
		public new GainRewardButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GainRewardButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012C85 RID: 76933 RVA: 0x004CDCE0 File Offset: 0x004CBEE0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012C86 RID: 76934 RVA: 0x004CDCEC File Offset: 0x004CBEEC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012C87 RID: 76935 RVA: 0x004CDCF4 File Offset: 0x004CBEF4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012C88 RID: 76936 RVA: 0x004CDCFC File Offset: 0x004CBEFC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012C89 RID: 76937 RVA: 0x004CDD10 File Offset: 0x004CBF10
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012C8A RID: 76938 RVA: 0x004CDD18 File Offset: 0x004CBF18
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012C8B RID: 76939 RVA: 0x004CDD24 File Offset: 0x004CBF24
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012C8C RID: 76940 RVA: 0x004CDD30 File Offset: 0x004CBF30
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012C8D RID: 76941 RVA: 0x004CDD3C File Offset: 0x004CBF3C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012C8E RID: 76942 RVA: 0x004CDD48 File Offset: 0x004CBF48
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012C8F RID: 76943 RVA: 0x004CDD54 File Offset: 0x004CBF54
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012C90 RID: 76944 RVA: 0x004CDD60 File Offset: 0x004CBF60
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012C91 RID: 76945 RVA: 0x004CDD6C File Offset: 0x004CBF6C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012C92 RID: 76946 RVA: 0x004CDD78 File Offset: 0x004CBF78
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012C93 RID: 76947 RVA: 0x004CDD84 File Offset: 0x004CBF84
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012C94 RID: 76948 RVA: 0x004CDD8C File Offset: 0x004CBF8C
		private void __callDele_EventOnClick(GainRewardButton obj)
		{
			Action<GainRewardButton> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x06012C95 RID: 76949 RVA: 0x004CDDB0 File Offset: 0x004CBFB0
		private void __clearDele_EventOnClick(GainRewardButton obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x06012C96 RID: 76950 RVA: 0x004CDDBC File Offset: 0x004CBFBC
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
					this.m_SetIdInt32_hotfix = (luaObj.RawGet("SetId") as LuaFunction);
					this.m_GetId_hotfix = (luaObj.RawGet("GetId") as LuaFunction);
					this.m_SetNumInt32_hotfix = (luaObj.RawGet("SetNum") as LuaFunction);
					this.m_GetNum_hotfix = (luaObj.RawGet("GetNum") as LuaFunction);
					this.m_SetStatusGainRewardStatus_hotfix = (luaObj.RawGet("SetStatus") as LuaFunction);
					this.m_GetStatus_hotfix = (luaObj.RawGet("GetStatus") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012C97 RID: 76951 RVA: 0x004CDF68 File Offset: 0x004CC168
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GainRewardButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A812 RID: 43026
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400A813 RID: 43027
		[AutoBind("./NumText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_numText;

		// Token: 0x0400A814 RID: 43028
		[AutoBind("./ChestCloseIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_closeGameObject;

		// Token: 0x0400A815 RID: 43029
		[AutoBind("./ChestOpenIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_openGameObject;

		// Token: 0x0400A816 RID: 43030
		private int m_id;

		// Token: 0x0400A817 RID: 43031
		private int m_num;

		// Token: 0x0400A818 RID: 43032
		private GainRewardStatus m_status;

		// Token: 0x0400A819 RID: 43033
		[DoNotToLua]
		private GainRewardButton.LuaExportHelper luaExportHelper;

		// Token: 0x0400A81A RID: 43034
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A81B RID: 43035
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A81C RID: 43036
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A81D RID: 43037
		private LuaFunction m_SetIdInt32_hotfix;

		// Token: 0x0400A81E RID: 43038
		private LuaFunction m_GetId_hotfix;

		// Token: 0x0400A81F RID: 43039
		private LuaFunction m_SetNumInt32_hotfix;

		// Token: 0x0400A820 RID: 43040
		private LuaFunction m_GetNum_hotfix;

		// Token: 0x0400A821 RID: 43041
		private LuaFunction m_SetStatusGainRewardStatus_hotfix;

		// Token: 0x0400A822 RID: 43042
		private LuaFunction m_GetStatus_hotfix;

		// Token: 0x0400A823 RID: 43043
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x0400A824 RID: 43044
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400A825 RID: 43045
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000EE5 RID: 3813
		public new class LuaExportHelper
		{
			// Token: 0x06012C98 RID: 76952 RVA: 0x004CDFD0 File Offset: 0x004CC1D0
			public LuaExportHelper(GainRewardButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012C99 RID: 76953 RVA: 0x004CDFE0 File Offset: 0x004CC1E0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012C9A RID: 76954 RVA: 0x004CDFF0 File Offset: 0x004CC1F0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012C9B RID: 76955 RVA: 0x004CE000 File Offset: 0x004CC200
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012C9C RID: 76956 RVA: 0x004CE010 File Offset: 0x004CC210
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012C9D RID: 76957 RVA: 0x004CE028 File Offset: 0x004CC228
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012C9E RID: 76958 RVA: 0x004CE038 File Offset: 0x004CC238
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012C9F RID: 76959 RVA: 0x004CE048 File Offset: 0x004CC248
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012CA0 RID: 76960 RVA: 0x004CE058 File Offset: 0x004CC258
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012CA1 RID: 76961 RVA: 0x004CE068 File Offset: 0x004CC268
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012CA2 RID: 76962 RVA: 0x004CE078 File Offset: 0x004CC278
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012CA3 RID: 76963 RVA: 0x004CE088 File Offset: 0x004CC288
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012CA4 RID: 76964 RVA: 0x004CE098 File Offset: 0x004CC298
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012CA5 RID: 76965 RVA: 0x004CE0A8 File Offset: 0x004CC2A8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012CA6 RID: 76966 RVA: 0x004CE0B8 File Offset: 0x004CC2B8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012CA7 RID: 76967 RVA: 0x004CE0C8 File Offset: 0x004CC2C8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012CA8 RID: 76968 RVA: 0x004CE0D8 File Offset: 0x004CC2D8
			public void __callDele_EventOnClick(GainRewardButton obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x06012CA9 RID: 76969 RVA: 0x004CE0E8 File Offset: 0x004CC2E8
			public void __clearDele_EventOnClick(GainRewardButton obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x170038A9 RID: 14505
			// (get) Token: 0x06012CAA RID: 76970 RVA: 0x004CE0F8 File Offset: 0x004CC2F8
			// (set) Token: 0x06012CAB RID: 76971 RVA: 0x004CE108 File Offset: 0x004CC308
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

			// Token: 0x170038AA RID: 14506
			// (get) Token: 0x06012CAC RID: 76972 RVA: 0x004CE118 File Offset: 0x004CC318
			// (set) Token: 0x06012CAD RID: 76973 RVA: 0x004CE128 File Offset: 0x004CC328
			public Text m_numText
			{
				get
				{
					return this.m_owner.m_numText;
				}
				set
				{
					this.m_owner.m_numText = value;
				}
			}

			// Token: 0x170038AB RID: 14507
			// (get) Token: 0x06012CAE RID: 76974 RVA: 0x004CE138 File Offset: 0x004CC338
			// (set) Token: 0x06012CAF RID: 76975 RVA: 0x004CE148 File Offset: 0x004CC348
			public GameObject m_closeGameObject
			{
				get
				{
					return this.m_owner.m_closeGameObject;
				}
				set
				{
					this.m_owner.m_closeGameObject = value;
				}
			}

			// Token: 0x170038AC RID: 14508
			// (get) Token: 0x06012CB0 RID: 76976 RVA: 0x004CE158 File Offset: 0x004CC358
			// (set) Token: 0x06012CB1 RID: 76977 RVA: 0x004CE168 File Offset: 0x004CC368
			public GameObject m_openGameObject
			{
				get
				{
					return this.m_owner.m_openGameObject;
				}
				set
				{
					this.m_owner.m_openGameObject = value;
				}
			}

			// Token: 0x170038AD RID: 14509
			// (get) Token: 0x06012CB2 RID: 76978 RVA: 0x004CE178 File Offset: 0x004CC378
			// (set) Token: 0x06012CB3 RID: 76979 RVA: 0x004CE188 File Offset: 0x004CC388
			public int m_id
			{
				get
				{
					return this.m_owner.m_id;
				}
				set
				{
					this.m_owner.m_id = value;
				}
			}

			// Token: 0x170038AE RID: 14510
			// (get) Token: 0x06012CB4 RID: 76980 RVA: 0x004CE198 File Offset: 0x004CC398
			// (set) Token: 0x06012CB5 RID: 76981 RVA: 0x004CE1A8 File Offset: 0x004CC3A8
			public int m_num
			{
				get
				{
					return this.m_owner.m_num;
				}
				set
				{
					this.m_owner.m_num = value;
				}
			}

			// Token: 0x170038AF RID: 14511
			// (get) Token: 0x06012CB6 RID: 76982 RVA: 0x004CE1B8 File Offset: 0x004CC3B8
			// (set) Token: 0x06012CB7 RID: 76983 RVA: 0x004CE1C8 File Offset: 0x004CC3C8
			public GainRewardStatus m_status
			{
				get
				{
					return this.m_owner.m_status;
				}
				set
				{
					this.m_owner.m_status = value;
				}
			}

			// Token: 0x06012CB8 RID: 76984 RVA: 0x004CE1D8 File Offset: 0x004CC3D8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012CB9 RID: 76985 RVA: 0x004CE1E8 File Offset: 0x004CC3E8
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400A826 RID: 43046
			private GainRewardButton m_owner;
		}
	}
}
