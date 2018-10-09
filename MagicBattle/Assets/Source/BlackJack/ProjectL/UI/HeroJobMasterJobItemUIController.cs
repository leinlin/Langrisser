using System;
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
	// Token: 0x02000DCA RID: 3530
	[HotFix]
	public class HeroJobMasterJobItemUIController : UIControllerBase
	{
		// Token: 0x06010DCC RID: 69068 RVA: 0x0045DE74 File Offset: 0x0045C074
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

		// Token: 0x06010DCD RID: 69069 RVA: 0x0045DEE8 File Offset: 0x0045C0E8
		public void InitJobMasterItem(ConfigDataJobInfo jobInfo, bool isMaster)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitJobMasterItemConfigDataJobInfoBoolean_hotfix != null)
			{
				this.m_InitJobMasterItemConfigDataJobInfoBoolean_hotfix.call(new object[]
				{
					this,
					jobInfo,
					isMaster
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isMaster)
			{
				this.m_stateCtrl.SetToUIState("Master", false, true);
			}
			else
			{
				this.m_stateCtrl.SetToUIState("NotMaster", false, true);
			}
			this.m_icon.sprite = AssetUtility.Instance.GetSprite(jobInfo.JobIcon);
			this.m_nameText.text = jobInfo.Name;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_propertyContent, 0);
			this.SetMasterRewardProperty(jobInfo.Property1_ID, jobInfo.Property1_Value);
			this.SetMasterRewardProperty(jobInfo.Property2_ID, jobInfo.Property2_Value);
			this.SetMasterRewardProperty(jobInfo.Property3_ID, jobInfo.Property3_Value);
		}

		// Token: 0x06010DCE RID: 69070 RVA: 0x0045E008 File Offset: 0x0045C208
		private void SetMasterRewardProperty(PropertyModifyType type, int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMasterRewardPropertyPropertyModifyTypeInt32_hotfix != null)
			{
				this.m_SetMasterRewardPropertyPropertyModifyTypeInt32_hotfix.call(new object[]
				{
					this,
					type,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (type)
			{
			case PropertyModifyType.PropertyModifyType_Hero3_HPAdd:
				this.m_propertyHP.SetActive(true);
				this.m_propertyHPValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero3_ATAdd:
				this.m_propertyAT.SetActive(true);
				this.m_propertyATValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero3_DFAdd:
				this.m_propertyDF.SetActive(true);
				this.m_propertyDFValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero3_MagicAdd:
				this.m_propertyMagic.SetActive(true);
				this.m_propertyMagicValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero3_MagicDFAdd:
				this.m_propertyMagicDF.SetActive(true);
				this.m_propertyMagicDFValueText.text = "+" + value;
				break;
			case PropertyModifyType.PropertyModifyType_Hero3_DEXAdd:
				this.m_propertyDEX.SetActive(true);
				this.m_propertyDEXValueText.text = "+" + value;
				break;
			}
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x06010DCF RID: 69071 RVA: 0x0045E1BC File Offset: 0x0045C3BC
		// (set) Token: 0x06010DD0 RID: 69072 RVA: 0x0045E1DC File Offset: 0x0045C3DC
		[DoNotToLua]
		public new HeroJobMasterJobItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroJobMasterJobItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010DD1 RID: 69073 RVA: 0x0045E1E8 File Offset: 0x0045C3E8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010DD2 RID: 69074 RVA: 0x0045E1F4 File Offset: 0x0045C3F4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010DD3 RID: 69075 RVA: 0x0045E1FC File Offset: 0x0045C3FC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010DD4 RID: 69076 RVA: 0x0045E204 File Offset: 0x0045C404
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010DD5 RID: 69077 RVA: 0x0045E218 File Offset: 0x0045C418
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010DD6 RID: 69078 RVA: 0x0045E220 File Offset: 0x0045C420
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010DD7 RID: 69079 RVA: 0x0045E22C File Offset: 0x0045C42C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010DD8 RID: 69080 RVA: 0x0045E238 File Offset: 0x0045C438
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010DD9 RID: 69081 RVA: 0x0045E244 File Offset: 0x0045C444
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010DDA RID: 69082 RVA: 0x0045E250 File Offset: 0x0045C450
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010DDB RID: 69083 RVA: 0x0045E25C File Offset: 0x0045C45C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010DDC RID: 69084 RVA: 0x0045E268 File Offset: 0x0045C468
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010DDD RID: 69085 RVA: 0x0045E274 File Offset: 0x0045C474
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010DDE RID: 69086 RVA: 0x0045E280 File Offset: 0x0045C480
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010DDF RID: 69087 RVA: 0x0045E28C File Offset: 0x0045C48C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010DE0 RID: 69088 RVA: 0x0045E294 File Offset: 0x0045C494
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
					this.m_InitJobMasterItemConfigDataJobInfoBoolean_hotfix = (luaObj.RawGet("InitJobMasterItem") as LuaFunction);
					this.m_SetMasterRewardPropertyPropertyModifyTypeInt32_hotfix = (luaObj.RawGet("SetMasterRewardProperty") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010DE1 RID: 69089 RVA: 0x0045E394 File Offset: 0x0045C594
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobMasterJobItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009B6A RID: 39786
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04009B6B RID: 39787
		[AutoBind("./JobIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_icon;

		// Token: 0x04009B6C RID: 39788
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04009B6D RID: 39789
		[AutoBind("./Property", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propertyContent;

		// Token: 0x04009B6E RID: 39790
		[AutoBind("./Property/HP", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propertyHP;

		// Token: 0x04009B6F RID: 39791
		[AutoBind("./Property/HP/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propertyHPValueText;

		// Token: 0x04009B70 RID: 39792
		[AutoBind("./Property/AT", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propertyAT;

		// Token: 0x04009B71 RID: 39793
		[AutoBind("./Property/AT/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propertyATValueText;

		// Token: 0x04009B72 RID: 39794
		[AutoBind("./Property/DF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propertyDF;

		// Token: 0x04009B73 RID: 39795
		[AutoBind("./Property/DF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propertyDFValueText;

		// Token: 0x04009B74 RID: 39796
		[AutoBind("./Property/DEX", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propertyDEX;

		// Token: 0x04009B75 RID: 39797
		[AutoBind("./Property/DEX/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propertyDEXValueText;

		// Token: 0x04009B76 RID: 39798
		[AutoBind("./Property/MagicDF", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propertyMagicDF;

		// Token: 0x04009B77 RID: 39799
		[AutoBind("./Property/MagicDF/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propertyMagicDFValueText;

		// Token: 0x04009B78 RID: 39800
		[AutoBind("./Property/Magic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_propertyMagic;

		// Token: 0x04009B79 RID: 39801
		[AutoBind("./Property/Magic/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_propertyMagicValueText;

		// Token: 0x04009B7A RID: 39802
		[DoNotToLua]
		private HeroJobMasterJobItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009B7B RID: 39803
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009B7C RID: 39804
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009B7D RID: 39805
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009B7E RID: 39806
		private LuaFunction m_InitJobMasterItemConfigDataJobInfoBoolean_hotfix;

		// Token: 0x04009B7F RID: 39807
		private LuaFunction m_SetMasterRewardPropertyPropertyModifyTypeInt32_hotfix;

		// Token: 0x02000DCB RID: 3531
		public new class LuaExportHelper
		{
			// Token: 0x06010DE2 RID: 69090 RVA: 0x0045E3FC File Offset: 0x0045C5FC
			public LuaExportHelper(HeroJobMasterJobItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010DE3 RID: 69091 RVA: 0x0045E40C File Offset: 0x0045C60C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010DE4 RID: 69092 RVA: 0x0045E41C File Offset: 0x0045C61C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010DE5 RID: 69093 RVA: 0x0045E42C File Offset: 0x0045C62C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010DE6 RID: 69094 RVA: 0x0045E43C File Offset: 0x0045C63C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010DE7 RID: 69095 RVA: 0x0045E454 File Offset: 0x0045C654
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010DE8 RID: 69096 RVA: 0x0045E464 File Offset: 0x0045C664
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010DE9 RID: 69097 RVA: 0x0045E474 File Offset: 0x0045C674
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010DEA RID: 69098 RVA: 0x0045E484 File Offset: 0x0045C684
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010DEB RID: 69099 RVA: 0x0045E494 File Offset: 0x0045C694
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010DEC RID: 69100 RVA: 0x0045E4A4 File Offset: 0x0045C6A4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010DED RID: 69101 RVA: 0x0045E4B4 File Offset: 0x0045C6B4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010DEE RID: 69102 RVA: 0x0045E4C4 File Offset: 0x0045C6C4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010DEF RID: 69103 RVA: 0x0045E4D4 File Offset: 0x0045C6D4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010DF0 RID: 69104 RVA: 0x0045E4E4 File Offset: 0x0045C6E4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010DF1 RID: 69105 RVA: 0x0045E4F4 File Offset: 0x0045C6F4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003447 RID: 13383
			// (get) Token: 0x06010DF2 RID: 69106 RVA: 0x0045E504 File Offset: 0x0045C704
			// (set) Token: 0x06010DF3 RID: 69107 RVA: 0x0045E514 File Offset: 0x0045C714
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

			// Token: 0x17003448 RID: 13384
			// (get) Token: 0x06010DF4 RID: 69108 RVA: 0x0045E524 File Offset: 0x0045C724
			// (set) Token: 0x06010DF5 RID: 69109 RVA: 0x0045E534 File Offset: 0x0045C734
			public Image m_icon
			{
				get
				{
					return this.m_owner.m_icon;
				}
				set
				{
					this.m_owner.m_icon = value;
				}
			}

			// Token: 0x17003449 RID: 13385
			// (get) Token: 0x06010DF6 RID: 69110 RVA: 0x0045E544 File Offset: 0x0045C744
			// (set) Token: 0x06010DF7 RID: 69111 RVA: 0x0045E554 File Offset: 0x0045C754
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

			// Token: 0x1700344A RID: 13386
			// (get) Token: 0x06010DF8 RID: 69112 RVA: 0x0045E564 File Offset: 0x0045C764
			// (set) Token: 0x06010DF9 RID: 69113 RVA: 0x0045E574 File Offset: 0x0045C774
			public GameObject m_propertyContent
			{
				get
				{
					return this.m_owner.m_propertyContent;
				}
				set
				{
					this.m_owner.m_propertyContent = value;
				}
			}

			// Token: 0x1700344B RID: 13387
			// (get) Token: 0x06010DFA RID: 69114 RVA: 0x0045E584 File Offset: 0x0045C784
			// (set) Token: 0x06010DFB RID: 69115 RVA: 0x0045E594 File Offset: 0x0045C794
			public GameObject m_propertyHP
			{
				get
				{
					return this.m_owner.m_propertyHP;
				}
				set
				{
					this.m_owner.m_propertyHP = value;
				}
			}

			// Token: 0x1700344C RID: 13388
			// (get) Token: 0x06010DFC RID: 69116 RVA: 0x0045E5A4 File Offset: 0x0045C7A4
			// (set) Token: 0x06010DFD RID: 69117 RVA: 0x0045E5B4 File Offset: 0x0045C7B4
			public Text m_propertyHPValueText
			{
				get
				{
					return this.m_owner.m_propertyHPValueText;
				}
				set
				{
					this.m_owner.m_propertyHPValueText = value;
				}
			}

			// Token: 0x1700344D RID: 13389
			// (get) Token: 0x06010DFE RID: 69118 RVA: 0x0045E5C4 File Offset: 0x0045C7C4
			// (set) Token: 0x06010DFF RID: 69119 RVA: 0x0045E5D4 File Offset: 0x0045C7D4
			public GameObject m_propertyAT
			{
				get
				{
					return this.m_owner.m_propertyAT;
				}
				set
				{
					this.m_owner.m_propertyAT = value;
				}
			}

			// Token: 0x1700344E RID: 13390
			// (get) Token: 0x06010E00 RID: 69120 RVA: 0x0045E5E4 File Offset: 0x0045C7E4
			// (set) Token: 0x06010E01 RID: 69121 RVA: 0x0045E5F4 File Offset: 0x0045C7F4
			public Text m_propertyATValueText
			{
				get
				{
					return this.m_owner.m_propertyATValueText;
				}
				set
				{
					this.m_owner.m_propertyATValueText = value;
				}
			}

			// Token: 0x1700344F RID: 13391
			// (get) Token: 0x06010E02 RID: 69122 RVA: 0x0045E604 File Offset: 0x0045C804
			// (set) Token: 0x06010E03 RID: 69123 RVA: 0x0045E614 File Offset: 0x0045C814
			public GameObject m_propertyDF
			{
				get
				{
					return this.m_owner.m_propertyDF;
				}
				set
				{
					this.m_owner.m_propertyDF = value;
				}
			}

			// Token: 0x17003450 RID: 13392
			// (get) Token: 0x06010E04 RID: 69124 RVA: 0x0045E624 File Offset: 0x0045C824
			// (set) Token: 0x06010E05 RID: 69125 RVA: 0x0045E634 File Offset: 0x0045C834
			public Text m_propertyDFValueText
			{
				get
				{
					return this.m_owner.m_propertyDFValueText;
				}
				set
				{
					this.m_owner.m_propertyDFValueText = value;
				}
			}

			// Token: 0x17003451 RID: 13393
			// (get) Token: 0x06010E06 RID: 69126 RVA: 0x0045E644 File Offset: 0x0045C844
			// (set) Token: 0x06010E07 RID: 69127 RVA: 0x0045E654 File Offset: 0x0045C854
			public GameObject m_propertyDEX
			{
				get
				{
					return this.m_owner.m_propertyDEX;
				}
				set
				{
					this.m_owner.m_propertyDEX = value;
				}
			}

			// Token: 0x17003452 RID: 13394
			// (get) Token: 0x06010E08 RID: 69128 RVA: 0x0045E664 File Offset: 0x0045C864
			// (set) Token: 0x06010E09 RID: 69129 RVA: 0x0045E674 File Offset: 0x0045C874
			public Text m_propertyDEXValueText
			{
				get
				{
					return this.m_owner.m_propertyDEXValueText;
				}
				set
				{
					this.m_owner.m_propertyDEXValueText = value;
				}
			}

			// Token: 0x17003453 RID: 13395
			// (get) Token: 0x06010E0A RID: 69130 RVA: 0x0045E684 File Offset: 0x0045C884
			// (set) Token: 0x06010E0B RID: 69131 RVA: 0x0045E694 File Offset: 0x0045C894
			public GameObject m_propertyMagicDF
			{
				get
				{
					return this.m_owner.m_propertyMagicDF;
				}
				set
				{
					this.m_owner.m_propertyMagicDF = value;
				}
			}

			// Token: 0x17003454 RID: 13396
			// (get) Token: 0x06010E0C RID: 69132 RVA: 0x0045E6A4 File Offset: 0x0045C8A4
			// (set) Token: 0x06010E0D RID: 69133 RVA: 0x0045E6B4 File Offset: 0x0045C8B4
			public Text m_propertyMagicDFValueText
			{
				get
				{
					return this.m_owner.m_propertyMagicDFValueText;
				}
				set
				{
					this.m_owner.m_propertyMagicDFValueText = value;
				}
			}

			// Token: 0x17003455 RID: 13397
			// (get) Token: 0x06010E0E RID: 69134 RVA: 0x0045E6C4 File Offset: 0x0045C8C4
			// (set) Token: 0x06010E0F RID: 69135 RVA: 0x0045E6D4 File Offset: 0x0045C8D4
			public GameObject m_propertyMagic
			{
				get
				{
					return this.m_owner.m_propertyMagic;
				}
				set
				{
					this.m_owner.m_propertyMagic = value;
				}
			}

			// Token: 0x17003456 RID: 13398
			// (get) Token: 0x06010E10 RID: 69136 RVA: 0x0045E6E4 File Offset: 0x0045C8E4
			// (set) Token: 0x06010E11 RID: 69137 RVA: 0x0045E6F4 File Offset: 0x0045C8F4
			public Text m_propertyMagicValueText
			{
				get
				{
					return this.m_owner.m_propertyMagicValueText;
				}
				set
				{
					this.m_owner.m_propertyMagicValueText = value;
				}
			}

			// Token: 0x06010E12 RID: 69138 RVA: 0x0045E704 File Offset: 0x0045C904
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06010E13 RID: 69139 RVA: 0x0045E714 File Offset: 0x0045C914
			public void SetMasterRewardProperty(PropertyModifyType type, int value)
			{
				this.m_owner.SetMasterRewardProperty(type, value);
			}

			// Token: 0x04009B80 RID: 39808
			private HeroJobMasterJobItemUIController m_owner;
		}
	}
}
