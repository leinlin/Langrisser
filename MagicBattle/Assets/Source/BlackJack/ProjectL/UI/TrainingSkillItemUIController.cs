using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C49 RID: 3145
	[HotFix]
	public class TrainingSkillItemUIController : UIControllerBase
	{
		// Token: 0x0600DE0D RID: 56845 RVA: 0x003C0910 File Offset: 0x003BEB10
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnTrainingSkillItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600DE0E RID: 56846 RVA: 0x003C09A0 File Offset: 0x003BEBA0
		public void InitTrainingSkillItemInfo(TrainingTech tech)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTrainingSkillItemInfoTrainingTech_hotfix != null)
			{
				this.m_InitTrainingSkillItemInfoTrainingTech_hotfix.call(new object[]
				{
					this,
					tech
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.TrainingTech = tech;
			this.TechMaxLv = projectLPlayerContext.GetTechMaxLevel(tech.ConfigId);
			bool flag = tech.Config.TechType == TechDisplayType.TechDisplayType_SoldierLevelUp;
			if (flag)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataSoldierInfo configDataSoldierInfo = configDataLoader.GetConfigDataSoldierInfo(tech.Config.SoldierIDRelated[0]);
				if (configDataSoldierInfo != null)
				{
					this.m_soldierNameText.text = configDataSoldierInfo.Name;
				}
				float scale = (float)configDataSoldierInfo.UI_ModelScale * 0.012f;
				Vector2 offset = new Vector2((float)configDataSoldierInfo.UI_ModelOffsetX, (float)configDataSoldierInfo.UI_ModelOffsetY) * 1.5f;
				HeroDetailUIController.CreateSpineGraphic(ref this.m_soldierInfoGraphic, configDataSoldierInfo.Model, this.m_graphic, -1, offset, scale, configDataSoldierInfo.ReplaceAnims);
				if (projectLPlayerContext.IsTechLocked(tech.ConfigId))
				{
					this.m_soldierInfoGraphic.SetColor(UIUtility.MyGrayColor);
				}
				else
				{
					this.m_soldierInfoGraphic.SetColor(Color.white);
				}
			}
			else if (projectLPlayerContext.IsTechLocked(tech.ConfigId))
			{
				this.m_iconImageGrey.sprite = AssetUtility.Instance.GetSprite(this.TrainingTech.Config.Resource);
			}
			else
			{
				this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(this.TrainingTech.Config.Resource);
			}
			if (projectLPlayerContext.IsTechLocked(tech.ConfigId))
			{
				if (!flag)
				{
					this.m_stateCtrl.SetToUIState("SkillLock", false, true);
				}
				else
				{
					this.m_stateCtrl.SetToUIState("SoldierLock", false, true);
				}
				this.m_lvMaxText.SetActive(false);
			}
			else
			{
				if (!flag)
				{
					this.m_stateCtrl.SetToUIState("SkillNormal", false, true);
				}
				else
				{
					this.m_stateCtrl.SetToUIState("SoldierNormal", false, true);
				}
				this.m_lvValueText.text = tech.Level + "/" + this.TechMaxLv;
				this.m_lvValueText.gameObject.SetActive(tech.Level < this.TechMaxLv);
				this.m_lvMaxText.SetActive(tech.Level == this.TechMaxLv);
			}
			int num = projectLPlayerContext.CanTechLevelup(tech.ConfigId);
			this.m_redMark.SetActive(!projectLPlayerContext.IsTechLocked(tech.ConfigId) && num == 0);
		}

		// Token: 0x0600DE0F RID: 56847 RVA: 0x003C0C8C File Offset: 0x003BEE8C
		private void OnTrainingSkillItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTrainingSkillItemClick_hotfix != null)
			{
				this.m_OnTrainingSkillItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnTrainingSkillItemClick != null)
			{
				this.EventOnTrainingSkillItemClick(this);
			}
		}

		// Token: 0x140002C2 RID: 706
		// (add) Token: 0x0600DE10 RID: 56848 RVA: 0x003C0D04 File Offset: 0x003BEF04
		// (remove) Token: 0x0600DE11 RID: 56849 RVA: 0x003C0DA0 File Offset: 0x003BEFA0
		public event Action<TrainingSkillItemUIController> EventOnTrainingSkillItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTrainingSkillItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnTrainingSkillItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TrainingSkillItemUIController> action = this.EventOnTrainingSkillItemClick;
				Action<TrainingSkillItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TrainingSkillItemUIController>>(ref this.EventOnTrainingSkillItemClick, (Action<TrainingSkillItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTrainingSkillItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnTrainingSkillItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TrainingSkillItemUIController> action = this.EventOnTrainingSkillItemClick;
				Action<TrainingSkillItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TrainingSkillItemUIController>>(ref this.EventOnTrainingSkillItemClick, (Action<TrainingSkillItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x0600DE12 RID: 56850 RVA: 0x003C0E3C File Offset: 0x003BF03C
		// (set) Token: 0x0600DE13 RID: 56851 RVA: 0x003C0E5C File Offset: 0x003BF05C
		[DoNotToLua]
		public new TrainingSkillItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TrainingSkillItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DE14 RID: 56852 RVA: 0x003C0E68 File Offset: 0x003BF068
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600DE15 RID: 56853 RVA: 0x003C0E74 File Offset: 0x003BF074
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600DE16 RID: 56854 RVA: 0x003C0E7C File Offset: 0x003BF07C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600DE17 RID: 56855 RVA: 0x003C0E84 File Offset: 0x003BF084
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600DE18 RID: 56856 RVA: 0x003C0E98 File Offset: 0x003BF098
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DE19 RID: 56857 RVA: 0x003C0EA0 File Offset: 0x003BF0A0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600DE1A RID: 56858 RVA: 0x003C0EAC File Offset: 0x003BF0AC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600DE1B RID: 56859 RVA: 0x003C0EB8 File Offset: 0x003BF0B8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600DE1C RID: 56860 RVA: 0x003C0EC4 File Offset: 0x003BF0C4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600DE1D RID: 56861 RVA: 0x003C0ED0 File Offset: 0x003BF0D0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600DE1E RID: 56862 RVA: 0x003C0EDC File Offset: 0x003BF0DC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600DE1F RID: 56863 RVA: 0x003C0EE8 File Offset: 0x003BF0E8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600DE20 RID: 56864 RVA: 0x003C0EF4 File Offset: 0x003BF0F4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600DE21 RID: 56865 RVA: 0x003C0F00 File Offset: 0x003BF100
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600DE22 RID: 56866 RVA: 0x003C0F0C File Offset: 0x003BF10C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600DE23 RID: 56867 RVA: 0x003C0F14 File Offset: 0x003BF114
		private void __callDele_EventOnTrainingSkillItemClick(TrainingSkillItemUIController obj)
		{
			Action<TrainingSkillItemUIController> eventOnTrainingSkillItemClick = this.EventOnTrainingSkillItemClick;
			if (eventOnTrainingSkillItemClick != null)
			{
				eventOnTrainingSkillItemClick(obj);
			}
		}

		// Token: 0x0600DE24 RID: 56868 RVA: 0x003C0F38 File Offset: 0x003BF138
		private void __clearDele_EventOnTrainingSkillItemClick(TrainingSkillItemUIController obj)
		{
			this.EventOnTrainingSkillItemClick = null;
		}

		// Token: 0x0600DE25 RID: 56869 RVA: 0x003C0F44 File Offset: 0x003BF144
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
					this.m_InitTrainingSkillItemInfoTrainingTech_hotfix = (luaObj.RawGet("InitTrainingSkillItemInfo") as LuaFunction);
					this.m_OnTrainingSkillItemClick_hotfix = (luaObj.RawGet("OnTrainingSkillItemClick") as LuaFunction);
					this.m_add_EventOnTrainingSkillItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnTrainingSkillItemClick") as LuaFunction);
					this.m_remove_EventOnTrainingSkillItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnTrainingSkillItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DE26 RID: 56870 RVA: 0x003C1074 File Offset: 0x003BF274
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TrainingSkillItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008777 RID: 34679
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04008778 RID: 34680
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04008779 RID: 34681
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x0400877A RID: 34682
		[AutoBind("./IconImageGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImageGrey;

		// Token: 0x0400877B RID: 34683
		[AutoBind("./ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lvValueText;

		// Token: 0x0400877C RID: 34684
		[AutoBind("./MaxText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lvMaxText;

		// Token: 0x0400877D RID: 34685
		[AutoBind("./SoldierNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_soldierNameText;

		// Token: 0x0400877E RID: 34686
		[AutoBind("./Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_graphic;

		// Token: 0x0400877F RID: 34687
		[AutoBind("./RedMark", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_redMark;

		// Token: 0x04008780 RID: 34688
		private UISpineGraphic m_soldierInfoGraphic;

		// Token: 0x04008781 RID: 34689
		public TrainingTech TrainingTech;

		// Token: 0x04008782 RID: 34690
		public int TechMaxLv;

		// Token: 0x04008783 RID: 34691
		[DoNotToLua]
		private TrainingSkillItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008784 RID: 34692
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008785 RID: 34693
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008786 RID: 34694
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008787 RID: 34695
		private LuaFunction m_InitTrainingSkillItemInfoTrainingTech_hotfix;

		// Token: 0x04008788 RID: 34696
		private LuaFunction m_OnTrainingSkillItemClick_hotfix;

		// Token: 0x04008789 RID: 34697
		private LuaFunction m_add_EventOnTrainingSkillItemClickAction;

		// Token: 0x0400878A RID: 34698
		private LuaFunction m_remove_EventOnTrainingSkillItemClickAction;

		// Token: 0x02000C4A RID: 3146
		public new class LuaExportHelper
		{
			// Token: 0x0600DE27 RID: 56871 RVA: 0x003C10DC File Offset: 0x003BF2DC
			public LuaExportHelper(TrainingSkillItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DE28 RID: 56872 RVA: 0x003C10EC File Offset: 0x003BF2EC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600DE29 RID: 56873 RVA: 0x003C10FC File Offset: 0x003BF2FC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600DE2A RID: 56874 RVA: 0x003C110C File Offset: 0x003BF30C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600DE2B RID: 56875 RVA: 0x003C111C File Offset: 0x003BF31C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DE2C RID: 56876 RVA: 0x003C1134 File Offset: 0x003BF334
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DE2D RID: 56877 RVA: 0x003C1144 File Offset: 0x003BF344
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DE2E RID: 56878 RVA: 0x003C1154 File Offset: 0x003BF354
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DE2F RID: 56879 RVA: 0x003C1164 File Offset: 0x003BF364
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DE30 RID: 56880 RVA: 0x003C1174 File Offset: 0x003BF374
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DE31 RID: 56881 RVA: 0x003C1184 File Offset: 0x003BF384
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DE32 RID: 56882 RVA: 0x003C1194 File Offset: 0x003BF394
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DE33 RID: 56883 RVA: 0x003C11A4 File Offset: 0x003BF3A4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DE34 RID: 56884 RVA: 0x003C11B4 File Offset: 0x003BF3B4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DE35 RID: 56885 RVA: 0x003C11C4 File Offset: 0x003BF3C4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DE36 RID: 56886 RVA: 0x003C11D4 File Offset: 0x003BF3D4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600DE37 RID: 56887 RVA: 0x003C11E4 File Offset: 0x003BF3E4
			public void __callDele_EventOnTrainingSkillItemClick(TrainingSkillItemUIController obj)
			{
				this.m_owner.__callDele_EventOnTrainingSkillItemClick(obj);
			}

			// Token: 0x0600DE38 RID: 56888 RVA: 0x003C11F4 File Offset: 0x003BF3F4
			public void __clearDele_EventOnTrainingSkillItemClick(TrainingSkillItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnTrainingSkillItemClick(obj);
			}

			// Token: 0x17002B27 RID: 11047
			// (get) Token: 0x0600DE39 RID: 56889 RVA: 0x003C1204 File Offset: 0x003BF404
			// (set) Token: 0x0600DE3A RID: 56890 RVA: 0x003C1214 File Offset: 0x003BF414
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x17002B28 RID: 11048
			// (get) Token: 0x0600DE3B RID: 56891 RVA: 0x003C1224 File Offset: 0x003BF424
			// (set) Token: 0x0600DE3C RID: 56892 RVA: 0x003C1234 File Offset: 0x003BF434
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

			// Token: 0x17002B29 RID: 11049
			// (get) Token: 0x0600DE3D RID: 56893 RVA: 0x003C1244 File Offset: 0x003BF444
			// (set) Token: 0x0600DE3E RID: 56894 RVA: 0x003C1254 File Offset: 0x003BF454
			public Image m_iconImage
			{
				get
				{
					return this.m_owner.m_iconImage;
				}
				set
				{
					this.m_owner.m_iconImage = value;
				}
			}

			// Token: 0x17002B2A RID: 11050
			// (get) Token: 0x0600DE3F RID: 56895 RVA: 0x003C1264 File Offset: 0x003BF464
			// (set) Token: 0x0600DE40 RID: 56896 RVA: 0x003C1274 File Offset: 0x003BF474
			public Image m_iconImageGrey
			{
				get
				{
					return this.m_owner.m_iconImageGrey;
				}
				set
				{
					this.m_owner.m_iconImageGrey = value;
				}
			}

			// Token: 0x17002B2B RID: 11051
			// (get) Token: 0x0600DE41 RID: 56897 RVA: 0x003C1284 File Offset: 0x003BF484
			// (set) Token: 0x0600DE42 RID: 56898 RVA: 0x003C1294 File Offset: 0x003BF494
			public Text m_lvValueText
			{
				get
				{
					return this.m_owner.m_lvValueText;
				}
				set
				{
					this.m_owner.m_lvValueText = value;
				}
			}

			// Token: 0x17002B2C RID: 11052
			// (get) Token: 0x0600DE43 RID: 56899 RVA: 0x003C12A4 File Offset: 0x003BF4A4
			// (set) Token: 0x0600DE44 RID: 56900 RVA: 0x003C12B4 File Offset: 0x003BF4B4
			public GameObject m_lvMaxText
			{
				get
				{
					return this.m_owner.m_lvMaxText;
				}
				set
				{
					this.m_owner.m_lvMaxText = value;
				}
			}

			// Token: 0x17002B2D RID: 11053
			// (get) Token: 0x0600DE45 RID: 56901 RVA: 0x003C12C4 File Offset: 0x003BF4C4
			// (set) Token: 0x0600DE46 RID: 56902 RVA: 0x003C12D4 File Offset: 0x003BF4D4
			public Text m_soldierNameText
			{
				get
				{
					return this.m_owner.m_soldierNameText;
				}
				set
				{
					this.m_owner.m_soldierNameText = value;
				}
			}

			// Token: 0x17002B2E RID: 11054
			// (get) Token: 0x0600DE47 RID: 56903 RVA: 0x003C12E4 File Offset: 0x003BF4E4
			// (set) Token: 0x0600DE48 RID: 56904 RVA: 0x003C12F4 File Offset: 0x003BF4F4
			public GameObject m_graphic
			{
				get
				{
					return this.m_owner.m_graphic;
				}
				set
				{
					this.m_owner.m_graphic = value;
				}
			}

			// Token: 0x17002B2F RID: 11055
			// (get) Token: 0x0600DE49 RID: 56905 RVA: 0x003C1304 File Offset: 0x003BF504
			// (set) Token: 0x0600DE4A RID: 56906 RVA: 0x003C1314 File Offset: 0x003BF514
			public GameObject m_redMark
			{
				get
				{
					return this.m_owner.m_redMark;
				}
				set
				{
					this.m_owner.m_redMark = value;
				}
			}

			// Token: 0x17002B30 RID: 11056
			// (get) Token: 0x0600DE4B RID: 56907 RVA: 0x003C1324 File Offset: 0x003BF524
			// (set) Token: 0x0600DE4C RID: 56908 RVA: 0x003C1334 File Offset: 0x003BF534
			public UISpineGraphic m_soldierInfoGraphic
			{
				get
				{
					return this.m_owner.m_soldierInfoGraphic;
				}
				set
				{
					this.m_owner.m_soldierInfoGraphic = value;
				}
			}

			// Token: 0x0600DE4D RID: 56909 RVA: 0x003C1344 File Offset: 0x003BF544
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600DE4E RID: 56910 RVA: 0x003C1354 File Offset: 0x003BF554
			public void OnTrainingSkillItemClick()
			{
				this.m_owner.OnTrainingSkillItemClick();
			}

			// Token: 0x0400878B RID: 34699
			private TrainingSkillItemUIController m_owner;
		}
	}
}
