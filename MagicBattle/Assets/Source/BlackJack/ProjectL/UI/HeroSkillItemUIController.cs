using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D9F RID: 3487
	[HotFix]
	public class HeroSkillItemUIController : UIControllerBase, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x060106D8 RID: 67288 RVA: 0x00448100 File Offset: 0x00446300
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
		}

		// Token: 0x060106D9 RID: 67289 RVA: 0x00448174 File Offset: 0x00446374
		public void InitSkillItem(ConfigDataSkillInfo skillInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitSkillItemConfigDataSkillInfo_hotfix != null)
			{
				this.m_InitSkillItemConfigDataSkillInfo_hotfix.call(new object[]
				{
					this,
					skillInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_skillInfo = skillInfo;
			this.m_skillIconImg.sprite = AssetUtility.Instance.GetSprite(this.m_skillInfo.Icon);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_skillCost, this.m_skillInfo.SkillCost);
			UIUtility.SetGameObjectChildrenActiveCount(this.m_skillCostBg, this.m_skillInfo.SkillCost);
			this.m_passivityText.SetActive(skillInfo.IsPassiveSkill());
		}

		// Token: 0x060106DA RID: 67290 RVA: 0x00448248 File Offset: 0x00446448
		public void SetSelectPanelActive(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectPanelActiveBoolean_hotfix != null)
			{
				this.m_SetSelectPanelActiveBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_infoSelectPanel.SetActive(isShow);
		}

		// Token: 0x060106DB RID: 67291 RVA: 0x004482C4 File Offset: 0x004464C4
		public void SetChoosenImageActive(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetChoosenImageActiveBoolean_hotfix != null)
			{
				this.m_SetChoosenImageActiveBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_choosenImage.SetActive(isShow);
		}

		// Token: 0x060106DC RID: 67292 RVA: 0x00448340 File Offset: 0x00446540
		public void SetLimitTagObjActive(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLimitTagObjActiveBoolean_hotfix != null)
			{
				this.m_SetLimitTagObjActiveBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isSkillLimited = isShow;
			this.m_limitTagObj.SetActive(isShow);
		}

		// Token: 0x060106DD RID: 67293 RVA: 0x004483C4 File Offset: 0x004465C4
		public void SetCostPanelActive(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCostPanelActiveBoolean_hotfix != null)
			{
				this.m_SetCostPanelActiveBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_skillCost.SetActive(isShow);
			this.m_skillCostBg.SetActive(isShow);
		}

		// Token: 0x060106DE RID: 67294 RVA: 0x0044844C File Offset: 0x0044664C
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isSkillLimited)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_JobCantEquipSkill, 2f, null, true);
				return;
			}
			if (this.EventOnShowDesc != null)
			{
				this.EventOnShowDesc(this);
			}
		}

		// Token: 0x1400037B RID: 891
		// (add) Token: 0x060106DF RID: 67295 RVA: 0x004484F8 File Offset: 0x004466F8
		// (remove) Token: 0x060106E0 RID: 67296 RVA: 0x00448594 File Offset: 0x00446794
		public event Action<HeroSkillItemUIController> EventOnShowDesc
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowDescAction`1_hotfix != null)
				{
					this.m_add_EventOnShowDescAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroSkillItemUIController> action = this.EventOnShowDesc;
				Action<HeroSkillItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroSkillItemUIController>>(ref this.EventOnShowDesc, (Action<HeroSkillItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowDescAction`1_hotfix != null)
				{
					this.m_remove_EventOnShowDescAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroSkillItemUIController> action = this.EventOnShowDesc;
				Action<HeroSkillItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroSkillItemUIController>>(ref this.EventOnShowDesc, (Action<HeroSkillItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x060106E1 RID: 67297 RVA: 0x00448630 File Offset: 0x00446830
		// (set) Token: 0x060106E2 RID: 67298 RVA: 0x00448650 File Offset: 0x00446850
		[DoNotToLua]
		public new HeroSkillItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroSkillItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060106E3 RID: 67299 RVA: 0x0044865C File Offset: 0x0044685C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060106E4 RID: 67300 RVA: 0x00448668 File Offset: 0x00446868
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060106E5 RID: 67301 RVA: 0x00448670 File Offset: 0x00446870
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060106E6 RID: 67302 RVA: 0x00448678 File Offset: 0x00446878
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060106E7 RID: 67303 RVA: 0x0044868C File Offset: 0x0044688C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060106E8 RID: 67304 RVA: 0x00448694 File Offset: 0x00446894
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060106E9 RID: 67305 RVA: 0x004486A0 File Offset: 0x004468A0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060106EA RID: 67306 RVA: 0x004486AC File Offset: 0x004468AC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060106EB RID: 67307 RVA: 0x004486B8 File Offset: 0x004468B8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060106EC RID: 67308 RVA: 0x004486C4 File Offset: 0x004468C4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060106ED RID: 67309 RVA: 0x004486D0 File Offset: 0x004468D0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060106EE RID: 67310 RVA: 0x004486DC File Offset: 0x004468DC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060106EF RID: 67311 RVA: 0x004486E8 File Offset: 0x004468E8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060106F0 RID: 67312 RVA: 0x004486F4 File Offset: 0x004468F4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060106F1 RID: 67313 RVA: 0x00448700 File Offset: 0x00446900
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060106F2 RID: 67314 RVA: 0x00448708 File Offset: 0x00446908
		private void __callDele_EventOnShowDesc(HeroSkillItemUIController obj)
		{
			Action<HeroSkillItemUIController> eventOnShowDesc = this.EventOnShowDesc;
			if (eventOnShowDesc != null)
			{
				eventOnShowDesc(obj);
			}
		}

		// Token: 0x060106F3 RID: 67315 RVA: 0x0044872C File Offset: 0x0044692C
		private void __clearDele_EventOnShowDesc(HeroSkillItemUIController obj)
		{
			this.EventOnShowDesc = null;
		}

		// Token: 0x060106F4 RID: 67316 RVA: 0x00448738 File Offset: 0x00446938
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
					this.m_InitSkillItemConfigDataSkillInfo_hotfix = (luaObj.RawGet("InitSkillItem") as LuaFunction);
					this.m_SetSelectPanelActiveBoolean_hotfix = (luaObj.RawGet("SetSelectPanelActive") as LuaFunction);
					this.m_SetChoosenImageActiveBoolean_hotfix = (luaObj.RawGet("SetChoosenImageActive") as LuaFunction);
					this.m_SetLimitTagObjActiveBoolean_hotfix = (luaObj.RawGet("SetLimitTagObjActive") as LuaFunction);
					this.m_SetCostPanelActiveBoolean_hotfix = (luaObj.RawGet("SetCostPanelActive") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_add_EventOnShowDescAction`1_hotfix = (luaObj.RawGet("add_EventOnShowDesc") as LuaFunction);
					this.m_remove_EventOnShowDescAction`1_hotfix = (luaObj.RawGet("remove_EventOnShowDesc") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060106F5 RID: 67317 RVA: 0x004488CC File Offset: 0x00446ACC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSkillItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009880 RID: 39040
		[AutoBind("./Costs", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillCost;

		// Token: 0x04009881 RID: 39041
		[AutoBind("./CostsBg", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_skillCostBg;

		// Token: 0x04009882 RID: 39042
		[AutoBind("./Select", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_infoSelectPanel;

		// Token: 0x04009883 RID: 39043
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillIconImg;

		// Token: 0x04009884 RID: 39044
		[AutoBind("./LimitTag", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_limitTagObj;

		// Token: 0x04009885 RID: 39045
		[AutoBind("./PassivityText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_passivityText;

		// Token: 0x04009886 RID: 39046
		[AutoBind("./ChoosenImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_choosenImage;

		// Token: 0x04009887 RID: 39047
		public ConfigDataSkillInfo m_skillInfo;

		// Token: 0x04009888 RID: 39048
		private bool m_isSkillLimited;

		// Token: 0x04009889 RID: 39049
		[DoNotToLua]
		private HeroSkillItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400988A RID: 39050
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400988B RID: 39051
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400988C RID: 39052
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400988D RID: 39053
		private LuaFunction m_InitSkillItemConfigDataSkillInfo_hotfix;

		// Token: 0x0400988E RID: 39054
		private LuaFunction m_SetSelectPanelActiveBoolean_hotfix;

		// Token: 0x0400988F RID: 39055
		private LuaFunction m_SetChoosenImageActiveBoolean_hotfix;

		// Token: 0x04009890 RID: 39056
		private LuaFunction m_SetLimitTagObjActiveBoolean_hotfix;

		// Token: 0x04009891 RID: 39057
		private LuaFunction m_SetCostPanelActiveBoolean_hotfix;

		// Token: 0x04009892 RID: 39058
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x04009893 RID: 39059
		private LuaFunction m_add_EventOnShowDescAction;

		// Token: 0x04009894 RID: 39060
		private LuaFunction m_remove_EventOnShowDescAction;

		// Token: 0x02000DA0 RID: 3488
		public new class LuaExportHelper
		{
			// Token: 0x060106F6 RID: 67318 RVA: 0x00448934 File Offset: 0x00446B34
			public LuaExportHelper(HeroSkillItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060106F7 RID: 67319 RVA: 0x00448944 File Offset: 0x00446B44
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060106F8 RID: 67320 RVA: 0x00448954 File Offset: 0x00446B54
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060106F9 RID: 67321 RVA: 0x00448964 File Offset: 0x00446B64
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060106FA RID: 67322 RVA: 0x00448974 File Offset: 0x00446B74
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060106FB RID: 67323 RVA: 0x0044898C File Offset: 0x00446B8C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060106FC RID: 67324 RVA: 0x0044899C File Offset: 0x00446B9C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060106FD RID: 67325 RVA: 0x004489AC File Offset: 0x00446BAC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060106FE RID: 67326 RVA: 0x004489BC File Offset: 0x00446BBC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060106FF RID: 67327 RVA: 0x004489CC File Offset: 0x00446BCC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010700 RID: 67328 RVA: 0x004489DC File Offset: 0x00446BDC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010701 RID: 67329 RVA: 0x004489EC File Offset: 0x00446BEC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010702 RID: 67330 RVA: 0x004489FC File Offset: 0x00446BFC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010703 RID: 67331 RVA: 0x00448A0C File Offset: 0x00446C0C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010704 RID: 67332 RVA: 0x00448A1C File Offset: 0x00446C1C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010705 RID: 67333 RVA: 0x00448A2C File Offset: 0x00446C2C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06010706 RID: 67334 RVA: 0x00448A3C File Offset: 0x00446C3C
			public void __callDele_EventOnShowDesc(HeroSkillItemUIController obj)
			{
				this.m_owner.__callDele_EventOnShowDesc(obj);
			}

			// Token: 0x06010707 RID: 67335 RVA: 0x00448A4C File Offset: 0x00446C4C
			public void __clearDele_EventOnShowDesc(HeroSkillItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnShowDesc(obj);
			}

			// Token: 0x170032B8 RID: 12984
			// (get) Token: 0x06010708 RID: 67336 RVA: 0x00448A5C File Offset: 0x00446C5C
			// (set) Token: 0x06010709 RID: 67337 RVA: 0x00448A6C File Offset: 0x00446C6C
			public GameObject m_skillCost
			{
				get
				{
					return this.m_owner.m_skillCost;
				}
				set
				{
					this.m_owner.m_skillCost = value;
				}
			}

			// Token: 0x170032B9 RID: 12985
			// (get) Token: 0x0601070A RID: 67338 RVA: 0x00448A7C File Offset: 0x00446C7C
			// (set) Token: 0x0601070B RID: 67339 RVA: 0x00448A8C File Offset: 0x00446C8C
			public GameObject m_skillCostBg
			{
				get
				{
					return this.m_owner.m_skillCostBg;
				}
				set
				{
					this.m_owner.m_skillCostBg = value;
				}
			}

			// Token: 0x170032BA RID: 12986
			// (get) Token: 0x0601070C RID: 67340 RVA: 0x00448A9C File Offset: 0x00446C9C
			// (set) Token: 0x0601070D RID: 67341 RVA: 0x00448AAC File Offset: 0x00446CAC
			public GameObject m_infoSelectPanel
			{
				get
				{
					return this.m_owner.m_infoSelectPanel;
				}
				set
				{
					this.m_owner.m_infoSelectPanel = value;
				}
			}

			// Token: 0x170032BB RID: 12987
			// (get) Token: 0x0601070E RID: 67342 RVA: 0x00448ABC File Offset: 0x00446CBC
			// (set) Token: 0x0601070F RID: 67343 RVA: 0x00448ACC File Offset: 0x00446CCC
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

			// Token: 0x170032BC RID: 12988
			// (get) Token: 0x06010710 RID: 67344 RVA: 0x00448ADC File Offset: 0x00446CDC
			// (set) Token: 0x06010711 RID: 67345 RVA: 0x00448AEC File Offset: 0x00446CEC
			public GameObject m_limitTagObj
			{
				get
				{
					return this.m_owner.m_limitTagObj;
				}
				set
				{
					this.m_owner.m_limitTagObj = value;
				}
			}

			// Token: 0x170032BD RID: 12989
			// (get) Token: 0x06010712 RID: 67346 RVA: 0x00448AFC File Offset: 0x00446CFC
			// (set) Token: 0x06010713 RID: 67347 RVA: 0x00448B0C File Offset: 0x00446D0C
			public GameObject m_passivityText
			{
				get
				{
					return this.m_owner.m_passivityText;
				}
				set
				{
					this.m_owner.m_passivityText = value;
				}
			}

			// Token: 0x170032BE RID: 12990
			// (get) Token: 0x06010714 RID: 67348 RVA: 0x00448B1C File Offset: 0x00446D1C
			// (set) Token: 0x06010715 RID: 67349 RVA: 0x00448B2C File Offset: 0x00446D2C
			public GameObject m_choosenImage
			{
				get
				{
					return this.m_owner.m_choosenImage;
				}
				set
				{
					this.m_owner.m_choosenImage = value;
				}
			}

			// Token: 0x170032BF RID: 12991
			// (get) Token: 0x06010716 RID: 67350 RVA: 0x00448B3C File Offset: 0x00446D3C
			// (set) Token: 0x06010717 RID: 67351 RVA: 0x00448B4C File Offset: 0x00446D4C
			public bool m_isSkillLimited
			{
				get
				{
					return this.m_owner.m_isSkillLimited;
				}
				set
				{
					this.m_owner.m_isSkillLimited = value;
				}
			}

			// Token: 0x06010718 RID: 67352 RVA: 0x00448B5C File Offset: 0x00446D5C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04009895 RID: 39061
			private HeroSkillItemUIController m_owner;
		}
	}
}
