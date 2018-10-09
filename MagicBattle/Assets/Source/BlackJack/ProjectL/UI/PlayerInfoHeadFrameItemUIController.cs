using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E87 RID: 3719
	[HotFix]
	public class PlayerInfoHeadFrameItemUIController : UIControllerBase
	{
		// Token: 0x060121DD RID: 74205 RVA: 0x004AA8DC File Offset: 0x004A8ADC
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
			this.m_toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSelectToggleValueChanged));
		}

		// Token: 0x060121DE RID: 74206 RVA: 0x004AA960 File Offset: 0x004A8B60
		public void UpdateItemInfo(int headFrameId, bool isLock, bool isSelected)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateItemInfoInt32BooleanBoolean_hotfix != null)
			{
				this.m_UpdateItemInfoInt32BooleanBoolean_hotfix.call(new object[]
				{
					this,
					headFrameId,
					isLock,
					isSelected
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HeadFrameId = headFrameId;
			UIUtility.SetPlayerHeadFrame(this.m_headFrameTransform, headFrameId, false, (!isLock) ? "Normal" : "Lock");
			if (this.AutoInitLocalizedString && this.m_headFrameTransform.gameObject != null)
			{
				UIControllerBase.InitLocalizedString(this.m_headFrameTransform.gameObject);
			}
			this.m_toggle.isOn = isSelected;
		}

		// Token: 0x060121DF RID: 74207 RVA: 0x004AAA58 File Offset: 0x004A8C58
		private void OnSelectToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSelectToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSelectToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnSelectToggleValueChanged != null)
			{
				this.EventOnSelectToggleValueChanged(isOn, this);
			}
		}

		// Token: 0x140003E4 RID: 996
		// (add) Token: 0x060121E0 RID: 74208 RVA: 0x004AAAE0 File Offset: 0x004A8CE0
		// (remove) Token: 0x060121E1 RID: 74209 RVA: 0x004AAB7C File Offset: 0x004A8D7C
		public event Action<bool, PlayerInfoHeadFrameItemUIController> EventOnSelectToggleValueChanged
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSelectToggleValueChangedAction`2_hotfix != null)
				{
					this.m_add_EventOnSelectToggleValueChangedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, PlayerInfoHeadFrameItemUIController> action = this.EventOnSelectToggleValueChanged;
				Action<bool, PlayerInfoHeadFrameItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, PlayerInfoHeadFrameItemUIController>>(ref this.EventOnSelectToggleValueChanged, (Action<bool, PlayerInfoHeadFrameItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSelectToggleValueChangedAction`2_hotfix != null)
				{
					this.m_remove_EventOnSelectToggleValueChangedAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool, PlayerInfoHeadFrameItemUIController> action = this.EventOnSelectToggleValueChanged;
				Action<bool, PlayerInfoHeadFrameItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool, PlayerInfoHeadFrameItemUIController>>(ref this.EventOnSelectToggleValueChanged, (Action<bool, PlayerInfoHeadFrameItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x060121E2 RID: 74210 RVA: 0x004AAC18 File Offset: 0x004A8E18
		// (set) Token: 0x060121E3 RID: 74211 RVA: 0x004AAC38 File Offset: 0x004A8E38
		[DoNotToLua]
		public new PlayerInfoHeadFrameItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerInfoHeadFrameItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060121E4 RID: 74212 RVA: 0x004AAC44 File Offset: 0x004A8E44
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060121E5 RID: 74213 RVA: 0x004AAC50 File Offset: 0x004A8E50
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060121E6 RID: 74214 RVA: 0x004AAC58 File Offset: 0x004A8E58
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060121E7 RID: 74215 RVA: 0x004AAC60 File Offset: 0x004A8E60
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060121E8 RID: 74216 RVA: 0x004AAC74 File Offset: 0x004A8E74
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060121E9 RID: 74217 RVA: 0x004AAC7C File Offset: 0x004A8E7C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060121EA RID: 74218 RVA: 0x004AAC88 File Offset: 0x004A8E88
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060121EB RID: 74219 RVA: 0x004AAC94 File Offset: 0x004A8E94
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060121EC RID: 74220 RVA: 0x004AACA0 File Offset: 0x004A8EA0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060121ED RID: 74221 RVA: 0x004AACAC File Offset: 0x004A8EAC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060121EE RID: 74222 RVA: 0x004AACB8 File Offset: 0x004A8EB8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060121EF RID: 74223 RVA: 0x004AACC4 File Offset: 0x004A8EC4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060121F0 RID: 74224 RVA: 0x004AACD0 File Offset: 0x004A8ED0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060121F1 RID: 74225 RVA: 0x004AACDC File Offset: 0x004A8EDC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060121F2 RID: 74226 RVA: 0x004AACE8 File Offset: 0x004A8EE8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060121F3 RID: 74227 RVA: 0x004AACF0 File Offset: 0x004A8EF0
		private void __callDele_EventOnSelectToggleValueChanged(bool arg1, PlayerInfoHeadFrameItemUIController arg2)
		{
			Action<bool, PlayerInfoHeadFrameItemUIController> eventOnSelectToggleValueChanged = this.EventOnSelectToggleValueChanged;
			if (eventOnSelectToggleValueChanged != null)
			{
				eventOnSelectToggleValueChanged(arg1, arg2);
			}
		}

		// Token: 0x060121F4 RID: 74228 RVA: 0x004AAD14 File Offset: 0x004A8F14
		private void __clearDele_EventOnSelectToggleValueChanged(bool arg1, PlayerInfoHeadFrameItemUIController arg2)
		{
			this.EventOnSelectToggleValueChanged = null;
		}

		// Token: 0x060121F5 RID: 74229 RVA: 0x004AAD20 File Offset: 0x004A8F20
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
					this.m_UpdateItemInfoInt32BooleanBoolean_hotfix = (luaObj.RawGet("UpdateItemInfo") as LuaFunction);
					this.m_OnSelectToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSelectToggleValueChanged") as LuaFunction);
					this.m_add_EventOnSelectToggleValueChangedAction`2_hotfix = (luaObj.RawGet("add_EventOnSelectToggleValueChanged") as LuaFunction);
					this.m_remove_EventOnSelectToggleValueChangedAction`2_hotfix = (luaObj.RawGet("remove_EventOnSelectToggleValueChanged") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060121F6 RID: 74230 RVA: 0x004AAE50 File Offset: 0x004A9050
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerInfoHeadFrameItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A3C3 RID: 41923
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_toggle;

		// Token: 0x0400A3C4 RID: 41924
		[AutoBind("./HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_headFrameTransform;

		// Token: 0x0400A3C5 RID: 41925
		public int HeadFrameId;

		// Token: 0x0400A3C6 RID: 41926
		[DoNotToLua]
		private PlayerInfoHeadFrameItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A3C7 RID: 41927
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A3C8 RID: 41928
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A3C9 RID: 41929
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A3CA RID: 41930
		private LuaFunction m_UpdateItemInfoInt32BooleanBoolean_hotfix;

		// Token: 0x0400A3CB RID: 41931
		private LuaFunction m_OnSelectToggleValueChangedBoolean_hotfix;

		// Token: 0x0400A3CC RID: 41932
		private LuaFunction m_add_EventOnSelectToggleValueChangedAction;

		// Token: 0x0400A3CD RID: 41933
		private LuaFunction m_remove_EventOnSelectToggleValueChangedAction;

		// Token: 0x02000E88 RID: 3720
		public new class LuaExportHelper
		{
			// Token: 0x060121F7 RID: 74231 RVA: 0x004AAEB8 File Offset: 0x004A90B8
			public LuaExportHelper(PlayerInfoHeadFrameItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060121F8 RID: 74232 RVA: 0x004AAEC8 File Offset: 0x004A90C8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060121F9 RID: 74233 RVA: 0x004AAED8 File Offset: 0x004A90D8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060121FA RID: 74234 RVA: 0x004AAEE8 File Offset: 0x004A90E8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060121FB RID: 74235 RVA: 0x004AAEF8 File Offset: 0x004A90F8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060121FC RID: 74236 RVA: 0x004AAF10 File Offset: 0x004A9110
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060121FD RID: 74237 RVA: 0x004AAF20 File Offset: 0x004A9120
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060121FE RID: 74238 RVA: 0x004AAF30 File Offset: 0x004A9130
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060121FF RID: 74239 RVA: 0x004AAF40 File Offset: 0x004A9140
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012200 RID: 74240 RVA: 0x004AAF50 File Offset: 0x004A9150
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012201 RID: 74241 RVA: 0x004AAF60 File Offset: 0x004A9160
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012202 RID: 74242 RVA: 0x004AAF70 File Offset: 0x004A9170
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012203 RID: 74243 RVA: 0x004AAF80 File Offset: 0x004A9180
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012204 RID: 74244 RVA: 0x004AAF90 File Offset: 0x004A9190
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012205 RID: 74245 RVA: 0x004AAFA0 File Offset: 0x004A91A0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012206 RID: 74246 RVA: 0x004AAFB0 File Offset: 0x004A91B0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012207 RID: 74247 RVA: 0x004AAFC0 File Offset: 0x004A91C0
			public void __callDele_EventOnSelectToggleValueChanged(bool arg1, PlayerInfoHeadFrameItemUIController arg2)
			{
				this.m_owner.__callDele_EventOnSelectToggleValueChanged(arg1, arg2);
			}

			// Token: 0x06012208 RID: 74248 RVA: 0x004AAFD0 File Offset: 0x004A91D0
			public void __clearDele_EventOnSelectToggleValueChanged(bool arg1, PlayerInfoHeadFrameItemUIController arg2)
			{
				this.m_owner.__clearDele_EventOnSelectToggleValueChanged(arg1, arg2);
			}

			// Token: 0x17003748 RID: 14152
			// (get) Token: 0x06012209 RID: 74249 RVA: 0x004AAFE0 File Offset: 0x004A91E0
			// (set) Token: 0x0601220A RID: 74250 RVA: 0x004AAFF0 File Offset: 0x004A91F0
			public Toggle m_toggle
			{
				get
				{
					return this.m_owner.m_toggle;
				}
				set
				{
					this.m_owner.m_toggle = value;
				}
			}

			// Token: 0x17003749 RID: 14153
			// (get) Token: 0x0601220B RID: 74251 RVA: 0x004AB000 File Offset: 0x004A9200
			// (set) Token: 0x0601220C RID: 74252 RVA: 0x004AB010 File Offset: 0x004A9210
			public Transform m_headFrameTransform
			{
				get
				{
					return this.m_owner.m_headFrameTransform;
				}
				set
				{
					this.m_owner.m_headFrameTransform = value;
				}
			}

			// Token: 0x0601220D RID: 74253 RVA: 0x004AB020 File Offset: 0x004A9220
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601220E RID: 74254 RVA: 0x004AB030 File Offset: 0x004A9230
			public void OnSelectToggleValueChanged(bool isOn)
			{
				this.m_owner.OnSelectToggleValueChanged(isOn);
			}

			// Token: 0x0400A3CE RID: 41934
			private PlayerInfoHeadFrameItemUIController m_owner;
		}
	}
}
