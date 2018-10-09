using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000ED5 RID: 3797
	[HotFix]
	public class RiftBackgroundUIController : UIControllerBase
	{
		// Token: 0x060129F3 RID: 76275 RVA: 0x004C5860 File Offset: 0x004C3A60
		private RiftBackgroundUIController()
		{
		}

		// Token: 0x060129F4 RID: 76276 RVA: 0x004C5868 File Offset: 0x004C3A68
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

		// Token: 0x060129F5 RID: 76277 RVA: 0x004C58D0 File Offset: 0x004C3AD0
		public void SetHardMode(bool isHard)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHardModeBoolean_hotfix != null)
			{
				this.m_SetHardModeBoolean_hotfix.call(new object[]
				{
					this,
					isHard
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_animator.SetBool("UseRedScene", isHard);
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x060129F6 RID: 76278 RVA: 0x004C5954 File Offset: 0x004C3B54
		// (set) Token: 0x060129F7 RID: 76279 RVA: 0x004C5974 File Offset: 0x004C3B74
		[DoNotToLua]
		public new RiftBackgroundUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RiftBackgroundUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060129F8 RID: 76280 RVA: 0x004C5980 File Offset: 0x004C3B80
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060129F9 RID: 76281 RVA: 0x004C598C File Offset: 0x004C3B8C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060129FA RID: 76282 RVA: 0x004C5994 File Offset: 0x004C3B94
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060129FB RID: 76283 RVA: 0x004C599C File Offset: 0x004C3B9C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060129FC RID: 76284 RVA: 0x004C59B0 File Offset: 0x004C3BB0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060129FD RID: 76285 RVA: 0x004C59B8 File Offset: 0x004C3BB8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060129FE RID: 76286 RVA: 0x004C59C4 File Offset: 0x004C3BC4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060129FF RID: 76287 RVA: 0x004C59D0 File Offset: 0x004C3BD0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012A00 RID: 76288 RVA: 0x004C59DC File Offset: 0x004C3BDC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012A01 RID: 76289 RVA: 0x004C59E8 File Offset: 0x004C3BE8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012A02 RID: 76290 RVA: 0x004C59F4 File Offset: 0x004C3BF4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012A03 RID: 76291 RVA: 0x004C5A00 File Offset: 0x004C3C00
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012A04 RID: 76292 RVA: 0x004C5A0C File Offset: 0x004C3C0C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012A05 RID: 76293 RVA: 0x004C5A18 File Offset: 0x004C3C18
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012A06 RID: 76294 RVA: 0x004C5A24 File Offset: 0x004C3C24
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012A07 RID: 76295 RVA: 0x004C5A2C File Offset: 0x004C3C2C
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
					this.m_SetHardModeBoolean_hotfix = (luaObj.RawGet("SetHardMode") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012A08 RID: 76296 RVA: 0x004C5B10 File Offset: 0x004C3D10
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftBackgroundUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A71A RID: 42778
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Animator m_animator;

		// Token: 0x0400A71B RID: 42779
		[DoNotToLua]
		private RiftBackgroundUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A71C RID: 42780
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A71D RID: 42781
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A71E RID: 42782
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A71F RID: 42783
		private LuaFunction m_SetHardModeBoolean_hotfix;

		// Token: 0x02000ED6 RID: 3798
		public new class LuaExportHelper
		{
			// Token: 0x06012A09 RID: 76297 RVA: 0x004C5B78 File Offset: 0x004C3D78
			public LuaExportHelper(RiftBackgroundUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012A0A RID: 76298 RVA: 0x004C5B88 File Offset: 0x004C3D88
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012A0B RID: 76299 RVA: 0x004C5B98 File Offset: 0x004C3D98
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012A0C RID: 76300 RVA: 0x004C5BA8 File Offset: 0x004C3DA8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012A0D RID: 76301 RVA: 0x004C5BB8 File Offset: 0x004C3DB8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012A0E RID: 76302 RVA: 0x004C5BD0 File Offset: 0x004C3DD0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012A0F RID: 76303 RVA: 0x004C5BE0 File Offset: 0x004C3DE0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012A10 RID: 76304 RVA: 0x004C5BF0 File Offset: 0x004C3DF0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012A11 RID: 76305 RVA: 0x004C5C00 File Offset: 0x004C3E00
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012A12 RID: 76306 RVA: 0x004C5C10 File Offset: 0x004C3E10
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012A13 RID: 76307 RVA: 0x004C5C20 File Offset: 0x004C3E20
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012A14 RID: 76308 RVA: 0x004C5C30 File Offset: 0x004C3E30
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012A15 RID: 76309 RVA: 0x004C5C40 File Offset: 0x004C3E40
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012A16 RID: 76310 RVA: 0x004C5C50 File Offset: 0x004C3E50
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012A17 RID: 76311 RVA: 0x004C5C60 File Offset: 0x004C3E60
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012A18 RID: 76312 RVA: 0x004C5C70 File Offset: 0x004C3E70
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003847 RID: 14407
			// (get) Token: 0x06012A19 RID: 76313 RVA: 0x004C5C80 File Offset: 0x004C3E80
			// (set) Token: 0x06012A1A RID: 76314 RVA: 0x004C5C90 File Offset: 0x004C3E90
			public Animator m_animator
			{
				get
				{
					return this.m_owner.m_animator;
				}
				set
				{
					this.m_owner.m_animator = value;
				}
			}

			// Token: 0x06012A1B RID: 76315 RVA: 0x004C5CA0 File Offset: 0x004C3EA0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400A720 RID: 42784
			private RiftBackgroundUIController m_owner;
		}
	}
}
