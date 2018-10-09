using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E32 RID: 3634
	[HotFix]
	public class LoginCommonUIController : UIControllerBase
	{
		// Token: 0x0601193D RID: 71997 RVA: 0x0048C434 File Offset: 0x0048A634
		private LoginCommonUIController()
		{
		}

		// Token: 0x0601193E RID: 71998 RVA: 0x0048C43C File Offset: 0x0048A63C
		protected override void Finalize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Finalize_hotfix != null)
			{
				this.m_Finalize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			try
			{
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x0601193F RID: 71999 RVA: 0x0048C4B8 File Offset: 0x0048A6B8
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
			this.m_fadeImage.gameObject.SetActive(false);
			this.m_disableInputGameObject.SetActive(false);
			this.m_screenFade = new ScreenFade();
			this.m_screenFade.Setup(this.m_fadeImage);
		}

		// Token: 0x06011940 RID: 72000 RVA: 0x0048C558 File Offset: 0x0048A758
		public void InitTouchFx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTouchFx_hotfix != null)
			{
				this.m_InitTouchFx_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_touchFx != null)
			{
				return;
			}
			this.m_touchFx = new TouchFx();
			Camera componentInParent = base.GetComponentInParent<Camera>();
			Transform transform = componentInParent.transform.Find("TouchFx");
			if (transform == null)
			{
				transform = new GameObject("TouchFx").transform;
				transform.transform.localPosition = new Vector3(0f, 0f, 10f);
				transform.transform.SetParent(componentInParent.transform, false);
			}
			this.m_touchFx.Init(transform.gameObject, componentInParent);
			this.m_touchFx.SetHitFxName("FX/UI_ABS/UI_Fx/U_click_down.prefab");
			this.m_touchFx.SetLoopFxName("FX/UI_ABS/UI_Fx/U_click.prefab");
			this.m_touchFx.SetDisableInputGameObject(this.m_disableInputGameObject);
		}

		// Token: 0x06011941 RID: 72001 RVA: 0x0048C678 File Offset: 0x0048A878
		public void DisposeTouchFx()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DisposeTouchFx_hotfix != null)
			{
				this.m_DisposeTouchFx_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_touchFx != null)
			{
				this.m_touchFx.Dispose();
				this.m_touchFx = null;
			}
		}

		// Token: 0x06011942 RID: 72002 RVA: 0x0048C6F8 File Offset: 0x0048A8F8
		private void Update()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Update_hotfix != null)
			{
				this.m_Update_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float deltaTime = Time.deltaTime;
			if (this.m_screenFade != null)
			{
				this.m_screenFade.Update(deltaTime);
			}
			if (this.m_touchFx != null)
			{
				this.m_touchFx.Tick(deltaTime);
			}
		}

		// Token: 0x06011943 RID: 72003 RVA: 0x0048C78C File Offset: 0x0048A98C
		public void EnableInput(bool enable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableInputBoolean_hotfix != null)
			{
				this.m_EnableInputBoolean_hotfix.call(new object[]
				{
					this,
					enable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_disableInputGameObject.SetActive(!enable);
		}

		// Token: 0x06011944 RID: 72004 RVA: 0x0048C80C File Offset: 0x0048AA0C
		public void FadeIn(float time, Color color, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FadeInSingleColorAction_hotfix != null)
			{
				this.m_FadeInSingleColorAction_hotfix.call(new object[]
				{
					this,
					time,
					color,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_screenFade.FadeIn(time, color, onEnd);
		}

		// Token: 0x06011945 RID: 72005 RVA: 0x0048C8AC File Offset: 0x0048AAAC
		public void FadeOut(float time, Color color, Action onEnd = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FadeOutSingleColorAction_hotfix != null)
			{
				this.m_FadeOutSingleColorAction_hotfix.call(new object[]
				{
					this,
					time,
					color,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_screenFade.FadeOut(time, color, onEnd);
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x06011946 RID: 72006 RVA: 0x0048C94C File Offset: 0x0048AB4C
		// (set) Token: 0x06011947 RID: 72007 RVA: 0x0048C96C File Offset: 0x0048AB6C
		[DoNotToLua]
		public new LoginCommonUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new LoginCommonUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011948 RID: 72008 RVA: 0x0048C978 File Offset: 0x0048AB78
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011949 RID: 72009 RVA: 0x0048C984 File Offset: 0x0048AB84
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601194A RID: 72010 RVA: 0x0048C98C File Offset: 0x0048AB8C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601194B RID: 72011 RVA: 0x0048C994 File Offset: 0x0048AB94
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601194C RID: 72012 RVA: 0x0048C9A8 File Offset: 0x0048ABA8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601194D RID: 72013 RVA: 0x0048C9B0 File Offset: 0x0048ABB0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601194E RID: 72014 RVA: 0x0048C9BC File Offset: 0x0048ABBC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601194F RID: 72015 RVA: 0x0048C9C8 File Offset: 0x0048ABC8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011950 RID: 72016 RVA: 0x0048C9D4 File Offset: 0x0048ABD4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011951 RID: 72017 RVA: 0x0048C9E0 File Offset: 0x0048ABE0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011952 RID: 72018 RVA: 0x0048C9EC File Offset: 0x0048ABEC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011953 RID: 72019 RVA: 0x0048C9F8 File Offset: 0x0048ABF8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011954 RID: 72020 RVA: 0x0048CA04 File Offset: 0x0048AC04
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06011955 RID: 72021 RVA: 0x0048CA10 File Offset: 0x0048AC10
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06011956 RID: 72022 RVA: 0x0048CA1C File Offset: 0x0048AC1C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06011957 RID: 72023 RVA: 0x0048CA24 File Offset: 0x0048AC24
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
					this.m_Finalize_hotfix = (luaObj.RawGet("Finalize") as LuaFunction);
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_InitTouchFx_hotfix = (luaObj.RawGet("InitTouchFx") as LuaFunction);
					this.m_DisposeTouchFx_hotfix = (luaObj.RawGet("DisposeTouchFx") as LuaFunction);
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_EnableInputBoolean_hotfix = (luaObj.RawGet("EnableInput") as LuaFunction);
					this.m_FadeInSingleColorAction_hotfix = (luaObj.RawGet("FadeIn") as LuaFunction);
					this.m_FadeOutSingleColorAction_hotfix = (luaObj.RawGet("FadeOut") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06011958 RID: 72024 RVA: 0x0048CBA0 File Offset: 0x0048ADA0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LoginCommonUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A02B RID: 41003
		[AutoBind("./Fade", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_fadeImage;

		// Token: 0x0400A02C RID: 41004
		[AutoBind("./DisableInput", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_disableInputGameObject;

		// Token: 0x0400A02D RID: 41005
		private ScreenFade m_screenFade;

		// Token: 0x0400A02E RID: 41006
		private TouchFx m_touchFx;

		// Token: 0x0400A02F RID: 41007
		[DoNotToLua]
		private LoginCommonUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A030 RID: 41008
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A031 RID: 41009
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A032 RID: 41010
		private LuaFunction m_Finalize_hotfix;

		// Token: 0x0400A033 RID: 41011
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A034 RID: 41012
		private LuaFunction m_InitTouchFx_hotfix;

		// Token: 0x0400A035 RID: 41013
		private LuaFunction m_DisposeTouchFx_hotfix;

		// Token: 0x0400A036 RID: 41014
		private LuaFunction m_Update_hotfix;

		// Token: 0x0400A037 RID: 41015
		private LuaFunction m_EnableInputBoolean_hotfix;

		// Token: 0x0400A038 RID: 41016
		private LuaFunction m_FadeInSingleColorAction_hotfix;

		// Token: 0x0400A039 RID: 41017
		private LuaFunction m_FadeOutSingleColorAction_hotfix;

		// Token: 0x02000E33 RID: 3635
		public new class LuaExportHelper
		{
			// Token: 0x06011959 RID: 72025 RVA: 0x0048CC08 File Offset: 0x0048AE08
			public LuaExportHelper(LoginCommonUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601195A RID: 72026 RVA: 0x0048CC18 File Offset: 0x0048AE18
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601195B RID: 72027 RVA: 0x0048CC28 File Offset: 0x0048AE28
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601195C RID: 72028 RVA: 0x0048CC38 File Offset: 0x0048AE38
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601195D RID: 72029 RVA: 0x0048CC48 File Offset: 0x0048AE48
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601195E RID: 72030 RVA: 0x0048CC60 File Offset: 0x0048AE60
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601195F RID: 72031 RVA: 0x0048CC70 File Offset: 0x0048AE70
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011960 RID: 72032 RVA: 0x0048CC80 File Offset: 0x0048AE80
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011961 RID: 72033 RVA: 0x0048CC90 File Offset: 0x0048AE90
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011962 RID: 72034 RVA: 0x0048CCA0 File Offset: 0x0048AEA0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011963 RID: 72035 RVA: 0x0048CCB0 File Offset: 0x0048AEB0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06011964 RID: 72036 RVA: 0x0048CCC0 File Offset: 0x0048AEC0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06011965 RID: 72037 RVA: 0x0048CCD0 File Offset: 0x0048AED0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06011966 RID: 72038 RVA: 0x0048CCE0 File Offset: 0x0048AEE0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06011967 RID: 72039 RVA: 0x0048CCF0 File Offset: 0x0048AEF0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06011968 RID: 72040 RVA: 0x0048CD00 File Offset: 0x0048AF00
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170035FC RID: 13820
			// (get) Token: 0x06011969 RID: 72041 RVA: 0x0048CD10 File Offset: 0x0048AF10
			// (set) Token: 0x0601196A RID: 72042 RVA: 0x0048CD20 File Offset: 0x0048AF20
			public Image m_fadeImage
			{
				get
				{
					return this.m_owner.m_fadeImage;
				}
				set
				{
					this.m_owner.m_fadeImage = value;
				}
			}

			// Token: 0x170035FD RID: 13821
			// (get) Token: 0x0601196B RID: 72043 RVA: 0x0048CD30 File Offset: 0x0048AF30
			// (set) Token: 0x0601196C RID: 72044 RVA: 0x0048CD40 File Offset: 0x0048AF40
			public GameObject m_disableInputGameObject
			{
				get
				{
					return this.m_owner.m_disableInputGameObject;
				}
				set
				{
					this.m_owner.m_disableInputGameObject = value;
				}
			}

			// Token: 0x170035FE RID: 13822
			// (get) Token: 0x0601196D RID: 72045 RVA: 0x0048CD50 File Offset: 0x0048AF50
			// (set) Token: 0x0601196E RID: 72046 RVA: 0x0048CD60 File Offset: 0x0048AF60
			public ScreenFade m_screenFade
			{
				get
				{
					return this.m_owner.m_screenFade;
				}
				set
				{
					this.m_owner.m_screenFade = value;
				}
			}

			// Token: 0x170035FF RID: 13823
			// (get) Token: 0x0601196F RID: 72047 RVA: 0x0048CD70 File Offset: 0x0048AF70
			// (set) Token: 0x06011970 RID: 72048 RVA: 0x0048CD80 File Offset: 0x0048AF80
			public TouchFx m_touchFx
			{
				get
				{
					return this.m_owner.m_touchFx;
				}
				set
				{
					this.m_owner.m_touchFx = value;
				}
			}

			// Token: 0x06011971 RID: 72049 RVA: 0x0048CD90 File Offset: 0x0048AF90
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06011972 RID: 72050 RVA: 0x0048CDA0 File Offset: 0x0048AFA0
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x0400A03A RID: 41018
			private LoginCommonUIController m_owner;
		}
	}
}
