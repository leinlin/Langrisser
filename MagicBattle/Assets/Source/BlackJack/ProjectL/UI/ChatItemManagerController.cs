using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B46 RID: 2886
	[HotFix]
	public class ChatItemManagerController : UIControllerBase
	{
		// Token: 0x0600C42F RID: 50223 RVA: 0x0036555C File Offset: 0x0036375C
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

		// Token: 0x0600C430 RID: 50224 RVA: 0x003655C4 File Offset: 0x003637C4
		public bool IsHasNeedChatItemPrefab(string poolName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsHasNeedChatItemPrefabString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsHasNeedChatItemPrefabString_hotfix.call(new object[]
				{
					this,
					poolName
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return !string.IsNullOrEmpty(this.m_childPrefabPoolName) && poolName == this.m_childPrefabPoolName;
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x0600C431 RID: 50225 RVA: 0x00365664 File Offset: 0x00363864
		// (set) Token: 0x0600C432 RID: 50226 RVA: 0x00365684 File Offset: 0x00363884
		[DoNotToLua]
		public new ChatItemManagerController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatItemManagerController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C433 RID: 50227 RVA: 0x00365690 File Offset: 0x00363890
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C434 RID: 50228 RVA: 0x0036569C File Offset: 0x0036389C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C435 RID: 50229 RVA: 0x003656A4 File Offset: 0x003638A4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C436 RID: 50230 RVA: 0x003656AC File Offset: 0x003638AC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C437 RID: 50231 RVA: 0x003656C0 File Offset: 0x003638C0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C438 RID: 50232 RVA: 0x003656C8 File Offset: 0x003638C8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C439 RID: 50233 RVA: 0x003656D4 File Offset: 0x003638D4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C43A RID: 50234 RVA: 0x003656E0 File Offset: 0x003638E0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C43B RID: 50235 RVA: 0x003656EC File Offset: 0x003638EC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C43C RID: 50236 RVA: 0x003656F8 File Offset: 0x003638F8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C43D RID: 50237 RVA: 0x00365704 File Offset: 0x00363904
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C43E RID: 50238 RVA: 0x00365710 File Offset: 0x00363910
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C43F RID: 50239 RVA: 0x0036571C File Offset: 0x0036391C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C440 RID: 50240 RVA: 0x00365728 File Offset: 0x00363928
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C441 RID: 50241 RVA: 0x00365734 File Offset: 0x00363934
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C442 RID: 50242 RVA: 0x0036573C File Offset: 0x0036393C
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
					this.m_IsHasNeedChatItemPrefabString_hotfix = (luaObj.RawGet("IsHasNeedChatItemPrefab") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C443 RID: 50243 RVA: 0x00365820 File Offset: 0x00363A20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatItemManagerController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007C57 RID: 31831
		public string m_childPrefabPoolName = string.Empty;

		// Token: 0x04007C58 RID: 31832
		public GameObject m_childPrefab;

		// Token: 0x04007C59 RID: 31833
		[DoNotToLua]
		private ChatItemManagerController.LuaExportHelper luaExportHelper;

		// Token: 0x04007C5A RID: 31834
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007C5B RID: 31835
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007C5C RID: 31836
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007C5D RID: 31837
		private LuaFunction m_IsHasNeedChatItemPrefabString_hotfix;

		// Token: 0x02000B47 RID: 2887
		public new class LuaExportHelper
		{
			// Token: 0x0600C444 RID: 50244 RVA: 0x00365888 File Offset: 0x00363A88
			public LuaExportHelper(ChatItemManagerController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C445 RID: 50245 RVA: 0x00365898 File Offset: 0x00363A98
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C446 RID: 50246 RVA: 0x003658A8 File Offset: 0x00363AA8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C447 RID: 50247 RVA: 0x003658B8 File Offset: 0x00363AB8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C448 RID: 50248 RVA: 0x003658C8 File Offset: 0x00363AC8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C449 RID: 50249 RVA: 0x003658E0 File Offset: 0x00363AE0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C44A RID: 50250 RVA: 0x003658F0 File Offset: 0x00363AF0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C44B RID: 50251 RVA: 0x00365900 File Offset: 0x00363B00
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C44C RID: 50252 RVA: 0x00365910 File Offset: 0x00363B10
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C44D RID: 50253 RVA: 0x00365920 File Offset: 0x00363B20
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C44E RID: 50254 RVA: 0x00365930 File Offset: 0x00363B30
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C44F RID: 50255 RVA: 0x00365940 File Offset: 0x00363B40
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C450 RID: 50256 RVA: 0x00365950 File Offset: 0x00363B50
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C451 RID: 50257 RVA: 0x00365960 File Offset: 0x00363B60
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C452 RID: 50258 RVA: 0x00365970 File Offset: 0x00363B70
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C453 RID: 50259 RVA: 0x00365980 File Offset: 0x00363B80
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C454 RID: 50260 RVA: 0x00365990 File Offset: 0x00363B90
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04007C5E RID: 31838
			private ChatItemManagerController m_owner;
		}
	}
}
