using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A66 RID: 2662
	[HotFix]
	public class BattleCommonUIController : UIControllerBase
	{
		// Token: 0x0600A6EB RID: 42731 RVA: 0x002EC7AC File Offset: 0x002EA9AC
		private BattleCommonUIController()
		{
		}

		// Token: 0x0600A6EC RID: 42732 RVA: 0x002EC7B4 File Offset: 0x002EA9B4
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
			this.m_screenEffectGameObject.SetActive(false);
		}

		// Token: 0x0600A6ED RID: 42733 RVA: 0x002EC828 File Offset: 0x002EAA28
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
			if (this.m_screenEffectGameObject.activeSelf && this.m_screenEffectAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
			{
				this.m_screenEffectGameObject.SetActive(false);
			}
		}

		// Token: 0x0600A6EE RID: 42734 RVA: 0x002EC8C8 File Offset: 0x002EAAC8
		public void PlayScreenEffect(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayScreenEffectString_hotfix != null)
			{
				this.m_PlayScreenEffectString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			this.m_screenEffectGameObject.SetActive(true);
			this.m_screenEffectAnimator.Play(name, -1, 0f);
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x0600A6EF RID: 42735 RVA: 0x002EC964 File Offset: 0x002EAB64
		// (set) Token: 0x0600A6F0 RID: 42736 RVA: 0x002EC984 File Offset: 0x002EAB84
		[DoNotToLua]
		public new BattleCommonUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleCommonUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x002EC990 File Offset: 0x002EAB90
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x002EC99C File Offset: 0x002EAB9C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A6F3 RID: 42739 RVA: 0x002EC9A4 File Offset: 0x002EABA4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A6F4 RID: 42740 RVA: 0x002EC9AC File Offset: 0x002EABAC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A6F5 RID: 42741 RVA: 0x002EC9C0 File Offset: 0x002EABC0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x002EC9C8 File Offset: 0x002EABC8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A6F7 RID: 42743 RVA: 0x002EC9D4 File Offset: 0x002EABD4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A6F8 RID: 42744 RVA: 0x002EC9E0 File Offset: 0x002EABE0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A6F9 RID: 42745 RVA: 0x002EC9EC File Offset: 0x002EABEC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A6FA RID: 42746 RVA: 0x002EC9F8 File Offset: 0x002EABF8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A6FB RID: 42747 RVA: 0x002ECA04 File Offset: 0x002EAC04
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A6FC RID: 42748 RVA: 0x002ECA10 File Offset: 0x002EAC10
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A6FD RID: 42749 RVA: 0x002ECA1C File Offset: 0x002EAC1C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A6FE RID: 42750 RVA: 0x002ECA28 File Offset: 0x002EAC28
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A6FF RID: 42751 RVA: 0x002ECA34 File Offset: 0x002EAC34
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A700 RID: 42752 RVA: 0x002ECA3C File Offset: 0x002EAC3C
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
					this.m_Update_hotfix = (luaObj.RawGet("Update") as LuaFunction);
					this.m_PlayScreenEffectString_hotfix = (luaObj.RawGet("PlayScreenEffect") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A701 RID: 42753 RVA: 0x002ECB3C File Offset: 0x002EAD3C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleCommonUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006EAC RID: 28332
		[AutoBind("./ScreenEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_screenEffectGameObject;

		// Token: 0x04006EAD RID: 28333
		[AutoBind("./ScreenEffect", AutoBindAttribute.InitState.NotInit, false)]
		private Animator m_screenEffectAnimator;

		// Token: 0x04006EAE RID: 28334
		[DoNotToLua]
		private BattleCommonUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006EAF RID: 28335
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006EB0 RID: 28336
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006EB1 RID: 28337
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006EB2 RID: 28338
		private LuaFunction m_Update_hotfix;

		// Token: 0x04006EB3 RID: 28339
		private LuaFunction m_PlayScreenEffectString_hotfix;

		// Token: 0x02000A67 RID: 2663
		public new class LuaExportHelper
		{
			// Token: 0x0600A702 RID: 42754 RVA: 0x002ECBA4 File Offset: 0x002EADA4
			public LuaExportHelper(BattleCommonUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A703 RID: 42755 RVA: 0x002ECBB4 File Offset: 0x002EADB4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A704 RID: 42756 RVA: 0x002ECBC4 File Offset: 0x002EADC4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A705 RID: 42757 RVA: 0x002ECBD4 File Offset: 0x002EADD4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A706 RID: 42758 RVA: 0x002ECBE4 File Offset: 0x002EADE4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A707 RID: 42759 RVA: 0x002ECBFC File Offset: 0x002EADFC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A708 RID: 42760 RVA: 0x002ECC0C File Offset: 0x002EAE0C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A709 RID: 42761 RVA: 0x002ECC1C File Offset: 0x002EAE1C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A70A RID: 42762 RVA: 0x002ECC2C File Offset: 0x002EAE2C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A70B RID: 42763 RVA: 0x002ECC3C File Offset: 0x002EAE3C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A70C RID: 42764 RVA: 0x002ECC4C File Offset: 0x002EAE4C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A70D RID: 42765 RVA: 0x002ECC5C File Offset: 0x002EAE5C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A70E RID: 42766 RVA: 0x002ECC6C File Offset: 0x002EAE6C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A70F RID: 42767 RVA: 0x002ECC7C File Offset: 0x002EAE7C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A710 RID: 42768 RVA: 0x002ECC8C File Offset: 0x002EAE8C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A711 RID: 42769 RVA: 0x002ECC9C File Offset: 0x002EAE9C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170021F3 RID: 8691
			// (get) Token: 0x0600A712 RID: 42770 RVA: 0x002ECCAC File Offset: 0x002EAEAC
			// (set) Token: 0x0600A713 RID: 42771 RVA: 0x002ECCBC File Offset: 0x002EAEBC
			public GameObject m_screenEffectGameObject
			{
				get
				{
					return this.m_owner.m_screenEffectGameObject;
				}
				set
				{
					this.m_owner.m_screenEffectGameObject = value;
				}
			}

			// Token: 0x170021F4 RID: 8692
			// (get) Token: 0x0600A714 RID: 42772 RVA: 0x002ECCCC File Offset: 0x002EAECC
			// (set) Token: 0x0600A715 RID: 42773 RVA: 0x002ECCDC File Offset: 0x002EAEDC
			public Animator m_screenEffectAnimator
			{
				get
				{
					return this.m_owner.m_screenEffectAnimator;
				}
				set
				{
					this.m_owner.m_screenEffectAnimator = value;
				}
			}

			// Token: 0x0600A716 RID: 42774 RVA: 0x002ECCEC File Offset: 0x002EAEEC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600A717 RID: 42775 RVA: 0x002ECCFC File Offset: 0x002EAEFC
			public void Update()
			{
				this.m_owner.Update();
			}

			// Token: 0x04006EB4 RID: 28340
			private BattleCommonUIController m_owner;
		}
	}
}
