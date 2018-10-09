using System;
using System.Runtime.CompilerServices;
using System.Threading;
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
	// Token: 0x02000C05 RID: 3077
	[HotFix]
	public class SkillDescUIController : UIControllerBase
	{
		// Token: 0x0600D75A RID: 55130 RVA: 0x003AA2A4 File Offset: 0x003A84A4
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
			PointDescComponent pointDescComponent = GameObjectUtility.AddControllerToGameObject<PointDescComponent>(base.gameObject);
			PointDescComponent pointDescComponent2 = pointDescComponent;
			GameObject gameObject = base.gameObject;
			bool isNeedExcuteEvent = true;
			GameObject boundaryGo = this.m_boundaryGo;
			pointDescComponent2.SetGameObject(gameObject, isNeedExcuteEvent, null, boundaryGo);
			pointDescComponent.EventOnClose += delegate()
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
				this.ClosePanel();
			};
		}

		// Token: 0x0600D75B RID: 55131 RVA: 0x003AA344 File Offset: 0x003A8544
		public void InitSkillDesc(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSkillDescConfigDataSkillInfo_hotfix != null)
			{
				this.m_InitSkillDescConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (skillInfo == null)
			{
				return;
			}
			this.ShowPanel();
			this.SkillInfo = skillInfo;
			this.m_nameText.text = skillInfo.Name;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_costObj, skillInfo.SkillCost);
			this.m_typeText.text = skillInfo.TypeText;
			this.m_cdText.text = skillInfo.CDText;
			this.m_distanceText.text = skillInfo.DistanceText;
			this.m_rangeText.text = skillInfo.RangeText;
			this.m_descText.text = skillInfo.Desc;
		}

		// Token: 0x0600D75C RID: 55132 RVA: 0x003AA440 File Offset: 0x003A8640
		private void ShowPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPanel_hotfix != null)
			{
				this.m_ShowPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			if (component != null)
			{
				component.SetToUIState("Show", false, true);
			}
		}

		// Token: 0x0600D75D RID: 55133 RVA: 0x003AA4D4 File Offset: 0x003A86D4
		private void ClosePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClosePanel_hotfix != null)
			{
				this.m_ClosePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			if (component != null)
			{
				component.SetActionForUIStateFinshed("Close", delegate
				{
					base.gameObject.SetActive(false);
				});
				component.SetToUIState("Close", false, true);
			}
			else
			{
				base.gameObject.SetActive(false);
			}
		}

		// Token: 0x140002AC RID: 684
		// (add) Token: 0x0600D75E RID: 55134 RVA: 0x003AA584 File Offset: 0x003A8784
		// (remove) Token: 0x0600D75F RID: 55135 RVA: 0x003AA620 File Offset: 0x003A8820
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x0600D761 RID: 55137 RVA: 0x003AA734 File Offset: 0x003A8934
		// (set) Token: 0x0600D760 RID: 55136 RVA: 0x003AA6BC File Offset: 0x003A88BC
		public ConfigDataSkillInfo SkillInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_SkillInfo_hotfix != null)
				{
					return (ConfigDataSkillInfo)this.m_get_SkillInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<SkillInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_SkillInfoConfigDataSkillInfo_hotfix != null)
				{
					this.m_set_SkillInfoConfigDataSkillInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<SkillInfo>k__BackingField = value;
			}
		}

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x0600D762 RID: 55138 RVA: 0x003AA7A8 File Offset: 0x003A89A8
		// (set) Token: 0x0600D763 RID: 55139 RVA: 0x003AA7C8 File Offset: 0x003A89C8
		[DoNotToLua]
		public new SkillDescUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SkillDescUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D764 RID: 55140 RVA: 0x003AA7D4 File Offset: 0x003A89D4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D765 RID: 55141 RVA: 0x003AA7E0 File Offset: 0x003A89E0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D766 RID: 55142 RVA: 0x003AA7E8 File Offset: 0x003A89E8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D767 RID: 55143 RVA: 0x003AA7F0 File Offset: 0x003A89F0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D768 RID: 55144 RVA: 0x003AA804 File Offset: 0x003A8A04
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D769 RID: 55145 RVA: 0x003AA80C File Offset: 0x003A8A0C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D76A RID: 55146 RVA: 0x003AA818 File Offset: 0x003A8A18
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D76B RID: 55147 RVA: 0x003AA824 File Offset: 0x003A8A24
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D76C RID: 55148 RVA: 0x003AA830 File Offset: 0x003A8A30
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D76D RID: 55149 RVA: 0x003AA83C File Offset: 0x003A8A3C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D76E RID: 55150 RVA: 0x003AA848 File Offset: 0x003A8A48
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D76F RID: 55151 RVA: 0x003AA854 File Offset: 0x003A8A54
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D770 RID: 55152 RVA: 0x003AA860 File Offset: 0x003A8A60
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D771 RID: 55153 RVA: 0x003AA86C File Offset: 0x003A8A6C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D772 RID: 55154 RVA: 0x003AA878 File Offset: 0x003A8A78
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D773 RID: 55155 RVA: 0x003AA880 File Offset: 0x003A8A80
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D774 RID: 55156 RVA: 0x003AA8A0 File Offset: 0x003A8AA0
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D777 RID: 55159 RVA: 0x003AA8DC File Offset: 0x003A8ADC
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
					this.m_InitSkillDescConfigDataSkillInfo_hotfix = (luaObj.RawGet("InitSkillDesc") as LuaFunction);
					this.m_ShowPanel_hotfix = (luaObj.RawGet("ShowPanel") as LuaFunction);
					this.m_ClosePanel_hotfix = (luaObj.RawGet("ClosePanel") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_set_SkillInfoConfigDataSkillInfo_hotfix = (luaObj.RawGet("set_SkillInfo") as LuaFunction);
					this.m_get_SkillInfo_hotfix = (luaObj.RawGet("get_SkillInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D778 RID: 55160 RVA: 0x003AAA58 File Offset: 0x003A8C58
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SkillDescUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008492 RID: 33938
		[AutoBind("./Lay/FrameImage/TOP/TitleNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04008493 RID: 33939
		[AutoBind("./Lay/FrameImage/TOP/Costs", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_costObj;

		// Token: 0x04008494 RID: 33940
		[AutoBind("./Lay/FrameImage/TOP/Type/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_typeText;

		// Token: 0x04008495 RID: 33941
		[AutoBind("./Lay/FrameImage/TOP/CD/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_cdText;

		// Token: 0x04008496 RID: 33942
		[AutoBind("./Lay/FrameImage/TOP/Distance/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_distanceText;

		// Token: 0x04008497 RID: 33943
		[AutoBind("./Lay/FrameImage/TOP/Range/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rangeText;

		// Token: 0x04008498 RID: 33944
		[AutoBind("./Lay/FrameImage/SkillType/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descText;

		// Token: 0x04008499 RID: 33945
		[AutoBind("./Lay", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_boundaryGo;

		// Token: 0x0400849A RID: 33946
		[DoNotToLua]
		private SkillDescUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400849B RID: 33947
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400849C RID: 33948
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400849D RID: 33949
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400849E RID: 33950
		private LuaFunction m_InitSkillDescConfigDataSkillInfo_hotfix;

		// Token: 0x0400849F RID: 33951
		private LuaFunction m_ShowPanel_hotfix;

		// Token: 0x040084A0 RID: 33952
		private LuaFunction m_ClosePanel_hotfix;

		// Token: 0x040084A1 RID: 33953
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040084A2 RID: 33954
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x040084A3 RID: 33955
		private LuaFunction m_set_SkillInfoConfigDataSkillInfo_hotfix;

		// Token: 0x040084A4 RID: 33956
		private LuaFunction m_get_SkillInfo_hotfix;

		// Token: 0x02000C06 RID: 3078
		public new class LuaExportHelper
		{
			// Token: 0x0600D779 RID: 55161 RVA: 0x003AAAC0 File Offset: 0x003A8CC0
			public LuaExportHelper(SkillDescUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D77A RID: 55162 RVA: 0x003AAAD0 File Offset: 0x003A8CD0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D77B RID: 55163 RVA: 0x003AAAE0 File Offset: 0x003A8CE0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D77C RID: 55164 RVA: 0x003AAAF0 File Offset: 0x003A8CF0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D77D RID: 55165 RVA: 0x003AAB00 File Offset: 0x003A8D00
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D77E RID: 55166 RVA: 0x003AAB18 File Offset: 0x003A8D18
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D77F RID: 55167 RVA: 0x003AAB28 File Offset: 0x003A8D28
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D780 RID: 55168 RVA: 0x003AAB38 File Offset: 0x003A8D38
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D781 RID: 55169 RVA: 0x003AAB48 File Offset: 0x003A8D48
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D782 RID: 55170 RVA: 0x003AAB58 File Offset: 0x003A8D58
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D783 RID: 55171 RVA: 0x003AAB68 File Offset: 0x003A8D68
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D784 RID: 55172 RVA: 0x003AAB78 File Offset: 0x003A8D78
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D785 RID: 55173 RVA: 0x003AAB88 File Offset: 0x003A8D88
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D786 RID: 55174 RVA: 0x003AAB98 File Offset: 0x003A8D98
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D787 RID: 55175 RVA: 0x003AABA8 File Offset: 0x003A8DA8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D788 RID: 55176 RVA: 0x003AABB8 File Offset: 0x003A8DB8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D789 RID: 55177 RVA: 0x003AABC8 File Offset: 0x003A8DC8
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D78A RID: 55178 RVA: 0x003AABD8 File Offset: 0x003A8DD8
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170029F9 RID: 10745
			// (get) Token: 0x0600D78B RID: 55179 RVA: 0x003AABE8 File Offset: 0x003A8DE8
			// (set) Token: 0x0600D78C RID: 55180 RVA: 0x003AABF8 File Offset: 0x003A8DF8
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

			// Token: 0x170029FA RID: 10746
			// (get) Token: 0x0600D78D RID: 55181 RVA: 0x003AAC08 File Offset: 0x003A8E08
			// (set) Token: 0x0600D78E RID: 55182 RVA: 0x003AAC18 File Offset: 0x003A8E18
			public GameObject m_costObj
			{
				get
				{
					return this.m_owner.m_costObj;
				}
				set
				{
					this.m_owner.m_costObj = value;
				}
			}

			// Token: 0x170029FB RID: 10747
			// (get) Token: 0x0600D78F RID: 55183 RVA: 0x003AAC28 File Offset: 0x003A8E28
			// (set) Token: 0x0600D790 RID: 55184 RVA: 0x003AAC38 File Offset: 0x003A8E38
			public Text m_typeText
			{
				get
				{
					return this.m_owner.m_typeText;
				}
				set
				{
					this.m_owner.m_typeText = value;
				}
			}

			// Token: 0x170029FC RID: 10748
			// (get) Token: 0x0600D791 RID: 55185 RVA: 0x003AAC48 File Offset: 0x003A8E48
			// (set) Token: 0x0600D792 RID: 55186 RVA: 0x003AAC58 File Offset: 0x003A8E58
			public Text m_cdText
			{
				get
				{
					return this.m_owner.m_cdText;
				}
				set
				{
					this.m_owner.m_cdText = value;
				}
			}

			// Token: 0x170029FD RID: 10749
			// (get) Token: 0x0600D793 RID: 55187 RVA: 0x003AAC68 File Offset: 0x003A8E68
			// (set) Token: 0x0600D794 RID: 55188 RVA: 0x003AAC78 File Offset: 0x003A8E78
			public Text m_distanceText
			{
				get
				{
					return this.m_owner.m_distanceText;
				}
				set
				{
					this.m_owner.m_distanceText = value;
				}
			}

			// Token: 0x170029FE RID: 10750
			// (get) Token: 0x0600D795 RID: 55189 RVA: 0x003AAC88 File Offset: 0x003A8E88
			// (set) Token: 0x0600D796 RID: 55190 RVA: 0x003AAC98 File Offset: 0x003A8E98
			public Text m_rangeText
			{
				get
				{
					return this.m_owner.m_rangeText;
				}
				set
				{
					this.m_owner.m_rangeText = value;
				}
			}

			// Token: 0x170029FF RID: 10751
			// (get) Token: 0x0600D797 RID: 55191 RVA: 0x003AACA8 File Offset: 0x003A8EA8
			// (set) Token: 0x0600D798 RID: 55192 RVA: 0x003AACB8 File Offset: 0x003A8EB8
			public Text m_descText
			{
				get
				{
					return this.m_owner.m_descText;
				}
				set
				{
					this.m_owner.m_descText = value;
				}
			}

			// Token: 0x17002A00 RID: 10752
			// (get) Token: 0x0600D799 RID: 55193 RVA: 0x003AACC8 File Offset: 0x003A8EC8
			// (set) Token: 0x0600D79A RID: 55194 RVA: 0x003AACD8 File Offset: 0x003A8ED8
			public GameObject m_boundaryGo
			{
				get
				{
					return this.m_owner.m_boundaryGo;
				}
				set
				{
					this.m_owner.m_boundaryGo = value;
				}
			}

			// Token: 0x17002A01 RID: 10753
			// (set) Token: 0x0600D79B RID: 55195 RVA: 0x003AACE8 File Offset: 0x003A8EE8
			public ConfigDataSkillInfo SkillInfo
			{
				set
				{
					this.m_owner.SkillInfo = value;
				}
			}

			// Token: 0x0600D79C RID: 55196 RVA: 0x003AACF8 File Offset: 0x003A8EF8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D79D RID: 55197 RVA: 0x003AAD08 File Offset: 0x003A8F08
			public void ShowPanel()
			{
				this.m_owner.ShowPanel();
			}

			// Token: 0x0600D79E RID: 55198 RVA: 0x003AAD18 File Offset: 0x003A8F18
			public void ClosePanel()
			{
				this.m_owner.ClosePanel();
			}

			// Token: 0x040084A5 RID: 33957
			private SkillDescUIController m_owner;
		}
	}
}
