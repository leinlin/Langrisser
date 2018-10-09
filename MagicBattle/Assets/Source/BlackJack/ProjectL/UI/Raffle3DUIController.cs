using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EA2 RID: 3746
	[HotFix]
	public class Raffle3DUIController : UIControllerBase
	{
		// Token: 0x060124B1 RID: 74929 RVA: 0x004B3868 File Offset: 0x004B1A68
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
			CommonUIStateController.m_onUIStateEndEvent += this.OnDrawAnimationEnd;
			this.ThreeDBgButton.onClick.AddListener(new UnityAction(this.On3DBgButtonClick));
		}

		// Token: 0x060124B2 RID: 74930 RVA: 0x004B38FC File Offset: 0x004B1AFC
		public override void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Clear();
			CommonUIStateController.m_onUIStateEndEvent -= this.OnDrawAnimationEnd;
		}

		// Token: 0x060124B3 RID: 74931 RVA: 0x004B3974 File Offset: 0x004B1B74
		public void ShowRaffle3DModel(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRaffle3DModelBoolean_hotfix != null)
			{
				this.m_ShowRaffle3DModelBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ThreeDViewCamera.enabled = isShow;
			this.ThreeDBgButton.gameObject.SetActive(isShow);
			this.ThreeDViewImage.enabled = !isShow;
			if (isShow)
			{
				this.ThreeDViewCamera.rect = this.CalcThreeDCameraViewRect();
			}
		}

		// Token: 0x060124B4 RID: 74932 RVA: 0x004B3A28 File Offset: 0x004B1C28
		public void ShowDrawIdleAnimation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowDrawIdleAnimation_hotfix != null)
			{
				this.m_ShowDrawIdleAnimation_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowRaffle3DModel(false);
			this.UIEffectStateCtrl.SetToUIState(Raffle3DUIController.AniParam_Init, false, true);
		}

		// Token: 0x060124B5 RID: 74933 RVA: 0x004B3AA4 File Offset: 0x004B1CA4
		public void ShowRaffeDrawingAnimation(int level, Action onEnd)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRaffeDrawingAnimationInt32Action_hotfix != null)
			{
				this.m_ShowRaffeDrawingAnimationInt32Action_hotfix.call(new object[]
				{
					this,
					level,
					onEnd
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowRaffle3DModel(true);
			this.m_onAnimationEnd = onEnd;
			string aniNameByLevel = this.GetAniNameByLevel(level);
			this.UIEffectStateCtrl.SetToUIState(aniNameByLevel, false, true);
		}

		// Token: 0x060124B6 RID: 74934 RVA: 0x004B3B48 File Offset: 0x004B1D48
		protected string GetAniNameByLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAniNameByLevelInt32_hotfix != null)
			{
				return (string)this.m_GetAniNameByLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (level)
			{
			case 0:
				return Raffle3DUIController.AniParam_Level0;
			case 1:
				return Raffle3DUIController.AniParam_Level1;
			case 2:
				return Raffle3DUIController.AniParam_Level2;
			case 3:
				return Raffle3DUIController.AniParam_Level3;
			default:
				return Raffle3DUIController.AniParam_Level3;
			}
		}

		// Token: 0x060124B7 RID: 74935 RVA: 0x004B3BFC File Offset: 0x004B1DFC
		protected void OnDrawAnimationEnd(GameObject go, string aniName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDrawAnimationEndGameObjectString_hotfix != null)
			{
				this.m_OnDrawAnimationEndGameObjectString_hotfix.call(new object[]
				{
					this,
					go,
					aniName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (go != this.UIEffectStateCtrl.gameObject)
			{
				return;
			}
			if (aniName == Raffle3DUIController.AniParam_Level0 || aniName == Raffle3DUIController.AniParam_Level1 || aniName == Raffle3DUIController.AniParam_Level2 || aniName == Raffle3DUIController.AniParam_Level3)
			{
				this.OnDrawAnimationEndImp();
			}
		}

		// Token: 0x060124B8 RID: 74936 RVA: 0x004B3CDC File Offset: 0x004B1EDC
		protected void OnDrawAnimationEndImp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDrawAnimationEndImp_hotfix != null)
			{
				this.m_OnDrawAnimationEndImp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowRaffle3DModel(false);
			if (this.m_onAnimationEnd != null)
			{
				this.m_onAnimationEnd();
			}
		}

		// Token: 0x060124B9 RID: 74937 RVA: 0x004B3D5C File Offset: 0x004B1F5C
		[DebuggerHidden]
		protected IEnumerator WaitForTime(Action action, float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WaitForTimeActionSingle_hotfix != null)
			{
				return (IEnumerator)this.m_WaitForTimeActionSingle_hotfix.call(new object[]
				{
					this,
					action,
					time
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Raffle3DUIController.<WaitForTime>c__Iterator0 <WaitForTime>c__Iterator = new Raffle3DUIController.<WaitForTime>c__Iterator0();
			<WaitForTime>c__Iterator.time = time;
			<WaitForTime>c__Iterator.action = action;
			return <WaitForTime>c__Iterator;
		}

		// Token: 0x060124BA RID: 74938 RVA: 0x004B3E00 File Offset: 0x004B2000
		protected void On3DBgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_On3DBgButtonClick_hotfix != null)
			{
				this.m_On3DBgButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UIEffectStateCtrl.SetToUIState(Raffle3DUIController.AniParam_Init, false, true);
			this.OnDrawAnimationEndImp();
		}

		// Token: 0x060124BB RID: 74939 RVA: 0x004B3E78 File Offset: 0x004B2078
		protected Rect CalcThreeDCameraViewRect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CalcThreeDCameraViewRect_hotfix != null)
			{
				return (Rect)this.m_CalcThreeDCameraViewRect_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RectTransform rectTransform = base.transform as RectTransform;
			Vector3[] array = new Vector3[4];
			rectTransform.GetWorldCorners(array);
			for (int i = 0; i < 4; i++)
			{
				array[i] = this.LayerCamera.WorldToViewportPoint(array[i]);
			}
			return new Rect(array[0].x, array[0].y, array[2].x - array[0].x, array[2].y - array[0].y);
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x060124BC RID: 74940 RVA: 0x004B3F84 File Offset: 0x004B2184
		// (set) Token: 0x060124BD RID: 74941 RVA: 0x004B3FF8 File Offset: 0x004B21F8
		public Camera LayerCamera
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerCamera_hotfix != null)
				{
					return (Camera)this.m_get_LayerCamera_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<LayerCamera>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_LayerCameraCamera_hotfix != null)
				{
					this.m_set_LayerCameraCamera_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<LayerCamera>k__BackingField = value;
			}
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x060124BE RID: 74942 RVA: 0x004B4070 File Offset: 0x004B2270
		// (set) Token: 0x060124BF RID: 74943 RVA: 0x004B4090 File Offset: 0x004B2290
		[DoNotToLua]
		public new Raffle3DUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new Raffle3DUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060124C0 RID: 74944 RVA: 0x004B409C File Offset: 0x004B229C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060124C1 RID: 74945 RVA: 0x004B40A8 File Offset: 0x004B22A8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060124C2 RID: 74946 RVA: 0x004B40B0 File Offset: 0x004B22B0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060124C3 RID: 74947 RVA: 0x004B40B8 File Offset: 0x004B22B8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060124C4 RID: 74948 RVA: 0x004B40CC File Offset: 0x004B22CC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060124C5 RID: 74949 RVA: 0x004B40D4 File Offset: 0x004B22D4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060124C6 RID: 74950 RVA: 0x004B40E0 File Offset: 0x004B22E0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060124C7 RID: 74951 RVA: 0x004B40EC File Offset: 0x004B22EC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060124C8 RID: 74952 RVA: 0x004B40F8 File Offset: 0x004B22F8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060124C9 RID: 74953 RVA: 0x004B4104 File Offset: 0x004B2304
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060124CA RID: 74954 RVA: 0x004B4110 File Offset: 0x004B2310
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060124CB RID: 74955 RVA: 0x004B411C File Offset: 0x004B231C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060124CC RID: 74956 RVA: 0x004B4128 File Offset: 0x004B2328
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060124CD RID: 74957 RVA: 0x004B4134 File Offset: 0x004B2334
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060124CE RID: 74958 RVA: 0x004B4140 File Offset: 0x004B2340
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060124CF RID: 74959 RVA: 0x004B4148 File Offset: 0x004B2348
		private void __callDele_m_onAnimationEnd()
		{
			Action onAnimationEnd = this.m_onAnimationEnd;
			if (onAnimationEnd != null)
			{
				onAnimationEnd();
			}
		}

		// Token: 0x060124D0 RID: 74960 RVA: 0x004B4168 File Offset: 0x004B2368
		private void __clearDele_m_onAnimationEnd()
		{
			this.m_onAnimationEnd = null;
		}

		// Token: 0x060124D2 RID: 74962 RVA: 0x004B41A8 File Offset: 0x004B23A8
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
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_ShowRaffle3DModelBoolean_hotfix = (luaObj.RawGet("ShowRaffle3DModel") as LuaFunction);
					this.m_ShowDrawIdleAnimation_hotfix = (luaObj.RawGet("ShowDrawIdleAnimation") as LuaFunction);
					this.m_ShowRaffeDrawingAnimationInt32Action_hotfix = (luaObj.RawGet("ShowRaffeDrawingAnimation") as LuaFunction);
					this.m_GetAniNameByLevelInt32_hotfix = (luaObj.RawGet("GetAniNameByLevel") as LuaFunction);
					this.m_OnDrawAnimationEndGameObjectString_hotfix = (luaObj.RawGet("OnDrawAnimationEnd") as LuaFunction);
					this.m_OnDrawAnimationEndImp_hotfix = (luaObj.RawGet("OnDrawAnimationEndImp") as LuaFunction);
					this.m_WaitForTimeActionSingle_hotfix = (luaObj.RawGet("WaitForTime") as LuaFunction);
					this.m_On3DBgButtonClick_hotfix = (luaObj.RawGet("On3DBgButtonClick") as LuaFunction);
					this.m_CalcThreeDCameraViewRect_hotfix = (luaObj.RawGet("CalcThreeDCameraViewRect") as LuaFunction);
					this.m_get_LayerCamera_hotfix = (luaObj.RawGet("get_LayerCamera") as LuaFunction);
					this.m_set_LayerCameraCamera_hotfix = (luaObj.RawGet("set_LayerCamera") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060124D3 RID: 74963 RVA: 0x004B43A0 File Offset: 0x004B25A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(Raffle3DUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A4D8 RID: 42200
		protected Action m_onAnimationEnd;

		// Token: 0x0400A4D9 RID: 42201
		protected static string AniParam_Init = "Init";

		// Token: 0x0400A4DA RID: 42202
		protected static string AniParam_Level0 = "GetColor";

		// Token: 0x0400A4DB RID: 42203
		protected static string AniParam_Level1 = "GetGold";

		// Token: 0x0400A4DC RID: 42204
		protected static string AniParam_Level2 = "GetSilver";

		// Token: 0x0400A4DD RID: 42205
		protected static string AniParam_Level3 = "GetCopper";

		// Token: 0x0400A4DE RID: 42206
		[AutoBind("./3DBgImage", AutoBindAttribute.InitState.NotInit, false)]
		public Button ThreeDBgButton;

		// Token: 0x0400A4DF RID: 42207
		[AutoBind("./3DViewImage", AutoBindAttribute.InitState.NotInit, false)]
		public Image ThreeDViewImage;

		// Token: 0x0400A4E0 RID: 42208
		[AutoBind("./3DCamera", AutoBindAttribute.InitState.NotInit, false)]
		public Camera ThreeDViewCamera;

		// Token: 0x0400A4E1 RID: 42209
		[AutoBind("./Mesh_FX_Xionggui", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController UIEffectStateCtrl;

		// Token: 0x0400A4E2 RID: 42210
		[DoNotToLua]
		private Raffle3DUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A4E3 RID: 42211
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A4E4 RID: 42212
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A4E5 RID: 42213
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A4E6 RID: 42214
		private LuaFunction m_Clear_hotfix;

		// Token: 0x0400A4E7 RID: 42215
		private LuaFunction m_ShowRaffle3DModelBoolean_hotfix;

		// Token: 0x0400A4E8 RID: 42216
		private LuaFunction m_ShowDrawIdleAnimation_hotfix;

		// Token: 0x0400A4E9 RID: 42217
		private LuaFunction m_ShowRaffeDrawingAnimationInt32Action_hotfix;

		// Token: 0x0400A4EA RID: 42218
		private LuaFunction m_GetAniNameByLevelInt32_hotfix;

		// Token: 0x0400A4EB RID: 42219
		private LuaFunction m_OnDrawAnimationEndGameObjectString_hotfix;

		// Token: 0x0400A4EC RID: 42220
		private LuaFunction m_OnDrawAnimationEndImp_hotfix;

		// Token: 0x0400A4ED RID: 42221
		private LuaFunction m_WaitForTimeActionSingle_hotfix;

		// Token: 0x0400A4EE RID: 42222
		private LuaFunction m_On3DBgButtonClick_hotfix;

		// Token: 0x0400A4EF RID: 42223
		private LuaFunction m_CalcThreeDCameraViewRect_hotfix;

		// Token: 0x0400A4F0 RID: 42224
		private LuaFunction m_get_LayerCamera_hotfix;

		// Token: 0x0400A4F1 RID: 42225
		private LuaFunction m_set_LayerCameraCamera_hotfix;

		// Token: 0x02000EA3 RID: 3747
		public new class LuaExportHelper
		{
			// Token: 0x060124D4 RID: 74964 RVA: 0x004B4408 File Offset: 0x004B2608
			public LuaExportHelper(Raffle3DUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060124D5 RID: 74965 RVA: 0x004B4418 File Offset: 0x004B2618
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060124D6 RID: 74966 RVA: 0x004B4428 File Offset: 0x004B2628
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060124D7 RID: 74967 RVA: 0x004B4438 File Offset: 0x004B2638
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060124D8 RID: 74968 RVA: 0x004B4448 File Offset: 0x004B2648
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060124D9 RID: 74969 RVA: 0x004B4460 File Offset: 0x004B2660
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060124DA RID: 74970 RVA: 0x004B4470 File Offset: 0x004B2670
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060124DB RID: 74971 RVA: 0x004B4480 File Offset: 0x004B2680
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060124DC RID: 74972 RVA: 0x004B4490 File Offset: 0x004B2690
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060124DD RID: 74973 RVA: 0x004B44A0 File Offset: 0x004B26A0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060124DE RID: 74974 RVA: 0x004B44B0 File Offset: 0x004B26B0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060124DF RID: 74975 RVA: 0x004B44C0 File Offset: 0x004B26C0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060124E0 RID: 74976 RVA: 0x004B44D0 File Offset: 0x004B26D0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060124E1 RID: 74977 RVA: 0x004B44E0 File Offset: 0x004B26E0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060124E2 RID: 74978 RVA: 0x004B44F0 File Offset: 0x004B26F0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060124E3 RID: 74979 RVA: 0x004B4500 File Offset: 0x004B2700
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060124E4 RID: 74980 RVA: 0x004B4510 File Offset: 0x004B2710
			public void __callDele_m_onAnimationEnd()
			{
				this.m_owner.__callDele_m_onAnimationEnd();
			}

			// Token: 0x060124E5 RID: 74981 RVA: 0x004B4520 File Offset: 0x004B2720
			public void __clearDele_m_onAnimationEnd()
			{
				this.m_owner.__clearDele_m_onAnimationEnd();
			}

			// Token: 0x170037A4 RID: 14244
			// (get) Token: 0x060124E6 RID: 74982 RVA: 0x004B4530 File Offset: 0x004B2730
			// (set) Token: 0x060124E7 RID: 74983 RVA: 0x004B4540 File Offset: 0x004B2740
			public Action m_onAnimationEnd
			{
				get
				{
					return this.m_owner.m_onAnimationEnd;
				}
				set
				{
					this.m_owner.m_onAnimationEnd = value;
				}
			}

			// Token: 0x170037A5 RID: 14245
			// (get) Token: 0x060124E8 RID: 74984 RVA: 0x004B4550 File Offset: 0x004B2750
			// (set) Token: 0x060124E9 RID: 74985 RVA: 0x004B4558 File Offset: 0x004B2758
			public static string AniParam_Init
			{
				get
				{
					return Raffle3DUIController.AniParam_Init;
				}
				set
				{
					Raffle3DUIController.AniParam_Init = value;
				}
			}

			// Token: 0x170037A6 RID: 14246
			// (get) Token: 0x060124EA RID: 74986 RVA: 0x004B4560 File Offset: 0x004B2760
			// (set) Token: 0x060124EB RID: 74987 RVA: 0x004B4568 File Offset: 0x004B2768
			public static string AniParam_Level0
			{
				get
				{
					return Raffle3DUIController.AniParam_Level0;
				}
				set
				{
					Raffle3DUIController.AniParam_Level0 = value;
				}
			}

			// Token: 0x170037A7 RID: 14247
			// (get) Token: 0x060124EC RID: 74988 RVA: 0x004B4570 File Offset: 0x004B2770
			// (set) Token: 0x060124ED RID: 74989 RVA: 0x004B4578 File Offset: 0x004B2778
			public static string AniParam_Level1
			{
				get
				{
					return Raffle3DUIController.AniParam_Level1;
				}
				set
				{
					Raffle3DUIController.AniParam_Level1 = value;
				}
			}

			// Token: 0x170037A8 RID: 14248
			// (get) Token: 0x060124EE RID: 74990 RVA: 0x004B4580 File Offset: 0x004B2780
			// (set) Token: 0x060124EF RID: 74991 RVA: 0x004B4588 File Offset: 0x004B2788
			public static string AniParam_Level2
			{
				get
				{
					return Raffle3DUIController.AniParam_Level2;
				}
				set
				{
					Raffle3DUIController.AniParam_Level2 = value;
				}
			}

			// Token: 0x170037A9 RID: 14249
			// (get) Token: 0x060124F0 RID: 74992 RVA: 0x004B4590 File Offset: 0x004B2790
			// (set) Token: 0x060124F1 RID: 74993 RVA: 0x004B4598 File Offset: 0x004B2798
			public static string AniParam_Level3
			{
				get
				{
					return Raffle3DUIController.AniParam_Level3;
				}
				set
				{
					Raffle3DUIController.AniParam_Level3 = value;
				}
			}

			// Token: 0x060124F2 RID: 74994 RVA: 0x004B45A0 File Offset: 0x004B27A0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060124F3 RID: 74995 RVA: 0x004B45B0 File Offset: 0x004B27B0
			public string GetAniNameByLevel(int level)
			{
				return this.m_owner.GetAniNameByLevel(level);
			}

			// Token: 0x060124F4 RID: 74996 RVA: 0x004B45C0 File Offset: 0x004B27C0
			public void OnDrawAnimationEnd(GameObject go, string aniName)
			{
				this.m_owner.OnDrawAnimationEnd(go, aniName);
			}

			// Token: 0x060124F5 RID: 74997 RVA: 0x004B45D0 File Offset: 0x004B27D0
			public void OnDrawAnimationEndImp()
			{
				this.m_owner.OnDrawAnimationEndImp();
			}

			// Token: 0x060124F6 RID: 74998 RVA: 0x004B45E0 File Offset: 0x004B27E0
			public IEnumerator WaitForTime(Action action, float time)
			{
				return this.m_owner.WaitForTime(action, time);
			}

			// Token: 0x060124F7 RID: 74999 RVA: 0x004B45F0 File Offset: 0x004B27F0
			public void On3DBgButtonClick()
			{
				this.m_owner.On3DBgButtonClick();
			}

			// Token: 0x060124F8 RID: 75000 RVA: 0x004B4600 File Offset: 0x004B2800
			public Rect CalcThreeDCameraViewRect()
			{
				return this.m_owner.CalcThreeDCameraViewRect();
			}

			// Token: 0x0400A4F2 RID: 42226
			private Raffle3DUIController m_owner;
		}
	}
}
