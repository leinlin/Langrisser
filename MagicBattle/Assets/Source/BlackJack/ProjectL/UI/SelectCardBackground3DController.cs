using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F00 RID: 3840
	[HotFix]
	public class SelectCardBackground3DController : UIControllerBase
	{
		// Token: 0x06013025 RID: 77861 RVA: 0x004DA9A8 File Offset: 0x004D8BA8
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
		}

		// Token: 0x06013026 RID: 77862 RVA: 0x004DAA10 File Offset: 0x004D8C10
		public void ShowClockEffect(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowClockEffectBoolean_hotfix != null)
			{
				this.m_ShowClockEffectBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!isShow)
			{
				this.m_clockEffectStateCtrl.SetToUIState("Init", false, true);
			}
			this.m_clockEffect.SetActive(isShow);
		}

		// Token: 0x06013027 RID: 77863 RVA: 0x004DAAA4 File Offset: 0x004D8CA4
		public void ShowLightEffect(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowLightEffectBoolean_hotfix != null)
			{
				this.m_ShowLightEffectBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lightEffect.SetActive(isShow);
		}

		// Token: 0x06013028 RID: 77864 RVA: 0x004DAB20 File Offset: 0x004D8D20
		public void ShowGetEffect(bool isShow, int rank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowGetEffectBooleanInt32_hotfix != null)
			{
				this.m_ShowGetEffectBooleanInt32_hotfix.call(new object[]
				{
					this,
					isShow,
					rank
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (rank)
			{
			case 1:
			case 2:
				this.m_getEffect.SetActive(isShow);
				break;
			case 3:
				this.m_getEffectSR.SetActive(isShow);
				break;
			case 4:
			case 5:
				this.m_getEffectSSR.SetActive(isShow);
				break;
			}
		}

		// Token: 0x06013029 RID: 77865 RVA: 0x004DABFC File Offset: 0x004D8DFC
		public void OnClockDrag(int rank, Action finishedEvent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClockDragInt32Action_hotfix != null)
			{
				this.m_OnClockDragInt32Action_hotfix.call(new object[]
				{
					this,
					rank,
					finishedEvent2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action finishedEvent = finishedEvent2;
			string stateName = string.Empty;
			switch (rank)
			{
			case 1:
			case 2:
				stateName = "GetR";
				break;
			case 3:
				stateName = "GetSR";
				break;
			case 4:
			case 5:
				stateName = "GetSSR";
				break;
			}
			this.m_clockEffectStateCtrl.SetActionForUIStateFinshed(stateName, delegate
			{
				finishedEvent();
			});
			this.m_clockEffectStateCtrl.SetToUIState(stateName, false, true);
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0601302A RID: 77866 RVA: 0x004DAD00 File Offset: 0x004D8F00
		// (set) Token: 0x0601302B RID: 77867 RVA: 0x004DAD20 File Offset: 0x004D8F20
		[DoNotToLua]
		public new SelectCardBackground3DController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SelectCardBackground3DController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601302C RID: 77868 RVA: 0x004DAD2C File Offset: 0x004D8F2C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601302D RID: 77869 RVA: 0x004DAD38 File Offset: 0x004D8F38
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601302E RID: 77870 RVA: 0x004DAD40 File Offset: 0x004D8F40
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601302F RID: 77871 RVA: 0x004DAD48 File Offset: 0x004D8F48
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013030 RID: 77872 RVA: 0x004DAD5C File Offset: 0x004D8F5C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013031 RID: 77873 RVA: 0x004DAD64 File Offset: 0x004D8F64
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013032 RID: 77874 RVA: 0x004DAD70 File Offset: 0x004D8F70
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013033 RID: 77875 RVA: 0x004DAD7C File Offset: 0x004D8F7C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013034 RID: 77876 RVA: 0x004DAD88 File Offset: 0x004D8F88
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013035 RID: 77877 RVA: 0x004DAD94 File Offset: 0x004D8F94
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013036 RID: 77878 RVA: 0x004DADA0 File Offset: 0x004D8FA0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013037 RID: 77879 RVA: 0x004DADAC File Offset: 0x004D8FAC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013038 RID: 77880 RVA: 0x004DADB8 File Offset: 0x004D8FB8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013039 RID: 77881 RVA: 0x004DADC4 File Offset: 0x004D8FC4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601303A RID: 77882 RVA: 0x004DADD0 File Offset: 0x004D8FD0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601303B RID: 77883 RVA: 0x004DADD8 File Offset: 0x004D8FD8
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
					this.m_ShowClockEffectBoolean_hotfix = (luaObj.RawGet("ShowClockEffect") as LuaFunction);
					this.m_ShowLightEffectBoolean_hotfix = (luaObj.RawGet("ShowLightEffect") as LuaFunction);
					this.m_ShowGetEffectBooleanInt32_hotfix = (luaObj.RawGet("ShowGetEffect") as LuaFunction);
					this.m_OnClockDragInt32Action_hotfix = (luaObj.RawGet("OnClockDrag") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601303C RID: 77884 RVA: 0x004DAF08 File Offset: 0x004D9108
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SelectCardBackground3DController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A9BD RID: 43453
		[AutoBind("/U_Click001_effect_light", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lightEffect;

		// Token: 0x0400A9BE RID: 43454
		[AutoBind("/Clock", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_clockEffect;

		// Token: 0x0400A9BF RID: 43455
		[AutoBind("/Clock/Mesh_FX_Clock", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_clockEffectStateCtrl;

		// Token: 0x0400A9C0 RID: 43456
		[AutoBind("/U_Click001_effect_get", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_getEffect;

		// Token: 0x0400A9C1 RID: 43457
		[AutoBind("/U_Click001_effect_get_SR", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_getEffectSR;

		// Token: 0x0400A9C2 RID: 43458
		[AutoBind("/U_Click001_effect_get_SSR", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_getEffectSSR;

		// Token: 0x0400A9C3 RID: 43459
		[DoNotToLua]
		private SelectCardBackground3DController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A9C4 RID: 43460
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A9C5 RID: 43461
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A9C6 RID: 43462
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A9C7 RID: 43463
		private LuaFunction m_ShowClockEffectBoolean_hotfix;

		// Token: 0x0400A9C8 RID: 43464
		private LuaFunction m_ShowLightEffectBoolean_hotfix;

		// Token: 0x0400A9C9 RID: 43465
		private LuaFunction m_ShowGetEffectBooleanInt32_hotfix;

		// Token: 0x0400A9CA RID: 43466
		private LuaFunction m_OnClockDragInt32Action_hotfix;

		// Token: 0x02000F01 RID: 3841
		public new class LuaExportHelper
		{
			// Token: 0x0601303D RID: 77885 RVA: 0x004DAF70 File Offset: 0x004D9170
			public LuaExportHelper(SelectCardBackground3DController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601303E RID: 77886 RVA: 0x004DAF80 File Offset: 0x004D9180
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601303F RID: 77887 RVA: 0x004DAF90 File Offset: 0x004D9190
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013040 RID: 77888 RVA: 0x004DAFA0 File Offset: 0x004D91A0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013041 RID: 77889 RVA: 0x004DAFB0 File Offset: 0x004D91B0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013042 RID: 77890 RVA: 0x004DAFC8 File Offset: 0x004D91C8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013043 RID: 77891 RVA: 0x004DAFD8 File Offset: 0x004D91D8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013044 RID: 77892 RVA: 0x004DAFE8 File Offset: 0x004D91E8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013045 RID: 77893 RVA: 0x004DAFF8 File Offset: 0x004D91F8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013046 RID: 77894 RVA: 0x004DB008 File Offset: 0x004D9208
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013047 RID: 77895 RVA: 0x004DB018 File Offset: 0x004D9218
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013048 RID: 77896 RVA: 0x004DB028 File Offset: 0x004D9228
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013049 RID: 77897 RVA: 0x004DB038 File Offset: 0x004D9238
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601304A RID: 77898 RVA: 0x004DB048 File Offset: 0x004D9248
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601304B RID: 77899 RVA: 0x004DB058 File Offset: 0x004D9258
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601304C RID: 77900 RVA: 0x004DB068 File Offset: 0x004D9268
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700396A RID: 14698
			// (get) Token: 0x0601304D RID: 77901 RVA: 0x004DB078 File Offset: 0x004D9278
			// (set) Token: 0x0601304E RID: 77902 RVA: 0x004DB088 File Offset: 0x004D9288
			public GameObject m_lightEffect
			{
				get
				{
					return this.m_owner.m_lightEffect;
				}
				set
				{
					this.m_owner.m_lightEffect = value;
				}
			}

			// Token: 0x1700396B RID: 14699
			// (get) Token: 0x0601304F RID: 77903 RVA: 0x004DB098 File Offset: 0x004D9298
			// (set) Token: 0x06013050 RID: 77904 RVA: 0x004DB0A8 File Offset: 0x004D92A8
			public GameObject m_clockEffect
			{
				get
				{
					return this.m_owner.m_clockEffect;
				}
				set
				{
					this.m_owner.m_clockEffect = value;
				}
			}

			// Token: 0x1700396C RID: 14700
			// (get) Token: 0x06013051 RID: 77905 RVA: 0x004DB0B8 File Offset: 0x004D92B8
			// (set) Token: 0x06013052 RID: 77906 RVA: 0x004DB0C8 File Offset: 0x004D92C8
			public CommonUIStateController m_clockEffectStateCtrl
			{
				get
				{
					return this.m_owner.m_clockEffectStateCtrl;
				}
				set
				{
					this.m_owner.m_clockEffectStateCtrl = value;
				}
			}

			// Token: 0x1700396D RID: 14701
			// (get) Token: 0x06013053 RID: 77907 RVA: 0x004DB0D8 File Offset: 0x004D92D8
			// (set) Token: 0x06013054 RID: 77908 RVA: 0x004DB0E8 File Offset: 0x004D92E8
			public GameObject m_getEffect
			{
				get
				{
					return this.m_owner.m_getEffect;
				}
				set
				{
					this.m_owner.m_getEffect = value;
				}
			}

			// Token: 0x1700396E RID: 14702
			// (get) Token: 0x06013055 RID: 77909 RVA: 0x004DB0F8 File Offset: 0x004D92F8
			// (set) Token: 0x06013056 RID: 77910 RVA: 0x004DB108 File Offset: 0x004D9308
			public GameObject m_getEffectSR
			{
				get
				{
					return this.m_owner.m_getEffectSR;
				}
				set
				{
					this.m_owner.m_getEffectSR = value;
				}
			}

			// Token: 0x1700396F RID: 14703
			// (get) Token: 0x06013057 RID: 77911 RVA: 0x004DB118 File Offset: 0x004D9318
			// (set) Token: 0x06013058 RID: 77912 RVA: 0x004DB128 File Offset: 0x004D9328
			public GameObject m_getEffectSSR
			{
				get
				{
					return this.m_owner.m_getEffectSSR;
				}
				set
				{
					this.m_owner.m_getEffectSSR = value;
				}
			}

			// Token: 0x06013059 RID: 77913 RVA: 0x004DB138 File Offset: 0x004D9338
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400A9CB RID: 43467
			private SelectCardBackground3DController m_owner;
		}
	}
}
