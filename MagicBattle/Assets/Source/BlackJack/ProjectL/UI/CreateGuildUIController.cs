using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CE5 RID: 3301
	[HotFix]
	public class CreateGuildUIController : UIControllerBase
	{
		// Token: 0x0600F153 RID: 61779 RVA: 0x004023EC File Offset: 0x004005EC
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_guildUITask = (UIUtility.FindUITaskWithType(typeof(GuildUITask)) as GuildUITask);
			this.m_createButton.onClick.AddListener(new UnityAction(this.OnCreateGuildClick));
			this.m_colseButton.onClick.AddListener(new UnityAction(this.OnCloseClick));
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnBGClick));
			this.m_forwardLevelButton.onClick.AddListener(new UnityAction(this.OnForwardLevelClick));
			this.m_backwardLevelButton.onClick.AddListener(new UnityAction(this.OnBackwardLevelClick));
			this.m_levelInputField.onEndEdit.AddListener(new UnityAction<string>(this.OnLevelInputFiledEndEdit));
			this.m_guildDeclarationInputField.onEndEdit.AddListener(new UnityAction<string>(this.OnGuildDeclaratioInputFiledEndEdit));
			ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(this.m_configDataLoader.ConfigableConstId_GuildCreateItemId);
			this.m_requireItemIamge.sprite = AssetUtility.Instance.GetSprite(configDataItemInfo.Icon);
			this.m_requireLevel = 1;
			this.RefreshLevelDisplay();
			string text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DefaultGuildHiringDeclaration);
			this.m_guildDeclarationInputField.text = text;
		}

		// Token: 0x0600F154 RID: 61780 RVA: 0x004025B8 File Offset: 0x004007B8
		private void CreateGuild()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateGuild_hotfix != null)
			{
				this.m_CreateGuild_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool isOn = this.m_approveAutoToggle.isOn;
			string announcement = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DefaultGuildAnnouncement);
			GuildCreateReqNetTask guildCreateReqNetTask = new GuildCreateReqNetTask(this.m_guildNameInputField.text, this.m_guildDeclarationInputField.text, announcement, isOn, this.m_requireLevel);
			guildCreateReqNetTask.EventOnStop += delegate(Task task)
			{
				GuildCreateReqNetTask guildCreateReqNetTask2 = task as GuildCreateReqNetTask;
				if (guildCreateReqNetTask2.Result == 0)
				{
					this.m_playerContext.RemoveBagItemByType(GoodsType.GoodsType_Item, this.m_configDataLoader.ConfigableConstId_GuildCreateItemId, 1, GameFunctionType.GameFunctionType_None, null);
					this.m_guildUITask.Stop();
					UIIntent prevTaskIntent = (this.m_guildUITask.CurrentIntent as UIIntentReturnable).PrevTaskIntent;
					UIIntent intent = prevTaskIntent;
					GuildManagementUITask.StartUITask(null, intent);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildCreateReqNetTask2.Result, 2f, null, true);
				}
			};
			guildCreateReqNetTask.Start(null);
		}

		// Token: 0x0600F155 RID: 61781 RVA: 0x00402674 File Offset: 0x00400874
		private void RefreshLevelDisplay()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshLevelDisplay_hotfix != null)
			{
				this.m_RefreshLevelDisplay_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int value = this.m_configDataLoader.GetConfigDataConfigableConst(270).Value;
			int configableConstId_PlayerLevelMaxLevel = this.m_configDataLoader.ConfigableConstId_PlayerLevelMaxLevel;
			this.m_requireLevel = Mathf.Clamp(this.m_requireLevel, value, configableConstId_PlayerLevelMaxLevel);
			this.m_levelInputField.text = this.m_requireLevel.ToString();
		}

		// Token: 0x0600F156 RID: 61782 RVA: 0x00402728 File Offset: 0x00400928
		private void OnCreateGuildClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCreateGuildClick_hotfix != null)
			{
				this.m_OnCreateGuildClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CheckGuildCreateCondition(this.m_guildNameInputField.text, this.m_guildDeclarationInputField.text, this.m_requireLevel);
			if (num == 0)
			{
				string value = this.m_configDataLoader.GetConfigDataStringTable(14002).Value;
				CommonUIController.Instance.ShowDialogBox(string.Format(value, this.m_guildNameInputField.text), delegate(DialogBoxResult result)
				{
					if (result == DialogBoxResult.Ok)
					{
						this.CreateGuild();
					}
				}, string.Empty, null);
				return;
			}
			if (num == -501)
			{
				ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(this.m_configDataLoader.ConfigableConstId_GuildCreateItemId);
				string value2 = this.m_configDataLoader.GetConfigDataStringTable(14001).Value;
				CommonUIController.Instance.ShowDialogBox(string.Format(value2, configDataItemInfo.Name), delegate(DialogBoxResult result)
				{
					if (result == DialogBoxResult.Ok)
					{
						StoreUITask.StartUITask(this.m_guildUITask.CurrentIntent, StoreId.StoreId_Gift, null, false);
					}
				}, string.Empty, null);
				return;
			}
			CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
		}

		// Token: 0x0600F157 RID: 61783 RVA: 0x00402870 File Offset: 0x00400A70
		public void Show()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Show_hotfix != null)
			{
				this.m_Show_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.m_createGuildPanelAnimation.SetToUIState("Show", false, true);
		}

		// Token: 0x0600F158 RID: 61784 RVA: 0x004028F0 File Offset: 0x00400AF0
		private void OnCloseClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCloseClick_hotfix != null)
			{
				this.m_OnCloseClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_createGuildPanelAnimation, "Close", delegate
			{
				base.gameObject.SetActive(false);
			}, false, true);
		}

		// Token: 0x0600F159 RID: 61785 RVA: 0x00402970 File Offset: 0x00400B70
		private void OnForwardLevelClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnForwardLevelClick_hotfix != null)
			{
				this.m_OnForwardLevelClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_requireLevel--;
			this.RefreshLevelDisplay();
		}

		// Token: 0x0600F15A RID: 61786 RVA: 0x004029E4 File Offset: 0x00400BE4
		private void OnBackwardLevelClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackwardLevelClick_hotfix != null)
			{
				this.m_OnBackwardLevelClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_requireLevel++;
			this.RefreshLevelDisplay();
		}

		// Token: 0x0600F15B RID: 61787 RVA: 0x00402A58 File Offset: 0x00400C58
		private void OnBGClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBGClick_hotfix != null)
			{
				this.m_OnBGClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_createGuildPanelAnimation, "Close", delegate
			{
				base.gameObject.SetActive(false);
			}, false, true);
		}

		// Token: 0x0600F15C RID: 61788 RVA: 0x00402AD8 File Offset: 0x00400CD8
		private void OnLevelInputFiledEndEdit(string content)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLevelInputFiledEndEditString_hotfix != null)
			{
				this.m_OnLevelInputFiledEndEditString_hotfix.call(new object[]
				{
					this,
					content
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int requireLevel = 1;
			if (!string.IsNullOrEmpty(content))
			{
				requireLevel = int.Parse(content);
			}
			this.m_requireLevel = requireLevel;
			this.RefreshLevelDisplay();
		}

		// Token: 0x0600F15D RID: 61789 RVA: 0x00402B6C File Offset: 0x00400D6C
		private void OnGuildDeclaratioInputFiledEndEdit(string content)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGuildDeclaratioInputFiledEndEditString_hotfix != null)
			{
				this.m_OnGuildDeclaratioInputFiledEndEditString_hotfix.call(new object[]
				{
					this,
					content
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(content, '*');
			this.m_guildDeclarationInputField.text = text;
		}

		// Token: 0x17002E69 RID: 11881
		// (get) Token: 0x0600F15E RID: 61790 RVA: 0x00402BFC File Offset: 0x00400DFC
		// (set) Token: 0x0600F15F RID: 61791 RVA: 0x00402C1C File Offset: 0x00400E1C
		[DoNotToLua]
		public new CreateGuildUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CreateGuildUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F160 RID: 61792 RVA: 0x00402C28 File Offset: 0x00400E28
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F161 RID: 61793 RVA: 0x00402C34 File Offset: 0x00400E34
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F162 RID: 61794 RVA: 0x00402C3C File Offset: 0x00400E3C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F163 RID: 61795 RVA: 0x00402C44 File Offset: 0x00400E44
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F164 RID: 61796 RVA: 0x00402C58 File Offset: 0x00400E58
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F165 RID: 61797 RVA: 0x00402C60 File Offset: 0x00400E60
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F166 RID: 61798 RVA: 0x00402C6C File Offset: 0x00400E6C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F167 RID: 61799 RVA: 0x00402C78 File Offset: 0x00400E78
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F168 RID: 61800 RVA: 0x00402C84 File Offset: 0x00400E84
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F169 RID: 61801 RVA: 0x00402C90 File Offset: 0x00400E90
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F16A RID: 61802 RVA: 0x00402C9C File Offset: 0x00400E9C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F16B RID: 61803 RVA: 0x00402CA8 File Offset: 0x00400EA8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F16C RID: 61804 RVA: 0x00402CB4 File Offset: 0x00400EB4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F16D RID: 61805 RVA: 0x00402CC0 File Offset: 0x00400EC0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F16E RID: 61806 RVA: 0x00402CCC File Offset: 0x00400ECC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F174 RID: 61812 RVA: 0x00402DB8 File Offset: 0x00400FB8
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
					this.m_CreateGuild_hotfix = (luaObj.RawGet("CreateGuild") as LuaFunction);
					this.m_RefreshLevelDisplay_hotfix = (luaObj.RawGet("RefreshLevelDisplay") as LuaFunction);
					this.m_OnCreateGuildClick_hotfix = (luaObj.RawGet("OnCreateGuildClick") as LuaFunction);
					this.m_Show_hotfix = (luaObj.RawGet("Show") as LuaFunction);
					this.m_OnCloseClick_hotfix = (luaObj.RawGet("OnCloseClick") as LuaFunction);
					this.m_OnForwardLevelClick_hotfix = (luaObj.RawGet("OnForwardLevelClick") as LuaFunction);
					this.m_OnBackwardLevelClick_hotfix = (luaObj.RawGet("OnBackwardLevelClick") as LuaFunction);
					this.m_OnBGClick_hotfix = (luaObj.RawGet("OnBGClick") as LuaFunction);
					this.m_OnLevelInputFiledEndEditString_hotfix = (luaObj.RawGet("OnLevelInputFiledEndEdit") as LuaFunction);
					this.m_OnGuildDeclaratioInputFiledEndEditString_hotfix = (luaObj.RawGet("OnGuildDeclaratioInputFiledEndEdit") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F175 RID: 61813 RVA: 0x00402F80 File Offset: 0x00401180
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CreateGuildUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008F61 RID: 36705
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_createGuildPanelAnimation;

		// Token: 0x04008F62 RID: 36706
		[AutoBind("./Detail/SociatyNameInputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_guildNameInputField;

		// Token: 0x04008F63 RID: 36707
		[AutoBind("./Detail/SociatyDeclarationInputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_guildDeclarationInputField;

		// Token: 0x04008F64 RID: 36708
		[AutoBind("./Detail/LevelInputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_levelInputField;

		// Token: 0x04008F65 RID: 36709
		[AutoBind("./Detail/LevelInputField/PreButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_forwardLevelButton;

		// Token: 0x04008F66 RID: 36710
		[AutoBind("./Detail/LevelInputField/AftButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backwardLevelButton;

		// Token: 0x04008F67 RID: 36711
		[AutoBind("./Detail/ValueGroup/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_requireItemIamge;

		// Token: 0x04008F68 RID: 36712
		[AutoBind("./Detail/ApproveGroup/AutoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_approveAutoToggle;

		// Token: 0x04008F69 RID: 36713
		[AutoBind("./Detail/ApproveGroup/ChairmanButton", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_approveChairmanToggle;

		// Token: 0x04008F6A RID: 36714
		[AutoBind("./Detail/GreatButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_createButton;

		// Token: 0x04008F6B RID: 36715
		[AutoBind("./Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_colseButton;

		// Token: 0x04008F6C RID: 36716
		[AutoBind("./BackBGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x04008F6D RID: 36717
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008F6E RID: 36718
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008F6F RID: 36719
		private int m_requireLevel;

		// Token: 0x04008F70 RID: 36720
		private GuildUITask m_guildUITask;

		// Token: 0x04008F71 RID: 36721
		[DoNotToLua]
		private CreateGuildUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008F72 RID: 36722
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008F73 RID: 36723
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008F74 RID: 36724
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008F75 RID: 36725
		private LuaFunction m_CreateGuild_hotfix;

		// Token: 0x04008F76 RID: 36726
		private LuaFunction m_RefreshLevelDisplay_hotfix;

		// Token: 0x04008F77 RID: 36727
		private LuaFunction m_OnCreateGuildClick_hotfix;

		// Token: 0x04008F78 RID: 36728
		private LuaFunction m_Show_hotfix;

		// Token: 0x04008F79 RID: 36729
		private LuaFunction m_OnCloseClick_hotfix;

		// Token: 0x04008F7A RID: 36730
		private LuaFunction m_OnForwardLevelClick_hotfix;

		// Token: 0x04008F7B RID: 36731
		private LuaFunction m_OnBackwardLevelClick_hotfix;

		// Token: 0x04008F7C RID: 36732
		private LuaFunction m_OnBGClick_hotfix;

		// Token: 0x04008F7D RID: 36733
		private LuaFunction m_OnLevelInputFiledEndEditString_hotfix;

		// Token: 0x04008F7E RID: 36734
		private LuaFunction m_OnGuildDeclaratioInputFiledEndEditString_hotfix;

		// Token: 0x02000CE6 RID: 3302
		public new class LuaExportHelper
		{
			// Token: 0x0600F176 RID: 61814 RVA: 0x00402FE8 File Offset: 0x004011E8
			public LuaExportHelper(CreateGuildUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F177 RID: 61815 RVA: 0x00402FF8 File Offset: 0x004011F8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F178 RID: 61816 RVA: 0x00403008 File Offset: 0x00401208
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F179 RID: 61817 RVA: 0x00403018 File Offset: 0x00401218
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F17A RID: 61818 RVA: 0x00403028 File Offset: 0x00401228
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F17B RID: 61819 RVA: 0x00403040 File Offset: 0x00401240
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F17C RID: 61820 RVA: 0x00403050 File Offset: 0x00401250
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F17D RID: 61821 RVA: 0x00403060 File Offset: 0x00401260
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F17E RID: 61822 RVA: 0x00403070 File Offset: 0x00401270
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F17F RID: 61823 RVA: 0x00403080 File Offset: 0x00401280
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F180 RID: 61824 RVA: 0x00403090 File Offset: 0x00401290
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F181 RID: 61825 RVA: 0x004030A0 File Offset: 0x004012A0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F182 RID: 61826 RVA: 0x004030B0 File Offset: 0x004012B0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F183 RID: 61827 RVA: 0x004030C0 File Offset: 0x004012C0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F184 RID: 61828 RVA: 0x004030D0 File Offset: 0x004012D0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F185 RID: 61829 RVA: 0x004030E0 File Offset: 0x004012E0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002E6A RID: 11882
			// (get) Token: 0x0600F186 RID: 61830 RVA: 0x004030F0 File Offset: 0x004012F0
			// (set) Token: 0x0600F187 RID: 61831 RVA: 0x00403100 File Offset: 0x00401300
			public CommonUIStateController m_createGuildPanelAnimation
			{
				get
				{
					return this.m_owner.m_createGuildPanelAnimation;
				}
				set
				{
					this.m_owner.m_createGuildPanelAnimation = value;
				}
			}

			// Token: 0x17002E6B RID: 11883
			// (get) Token: 0x0600F188 RID: 61832 RVA: 0x00403110 File Offset: 0x00401310
			// (set) Token: 0x0600F189 RID: 61833 RVA: 0x00403120 File Offset: 0x00401320
			public InputField m_guildNameInputField
			{
				get
				{
					return this.m_owner.m_guildNameInputField;
				}
				set
				{
					this.m_owner.m_guildNameInputField = value;
				}
			}

			// Token: 0x17002E6C RID: 11884
			// (get) Token: 0x0600F18A RID: 61834 RVA: 0x00403130 File Offset: 0x00401330
			// (set) Token: 0x0600F18B RID: 61835 RVA: 0x00403140 File Offset: 0x00401340
			public InputField m_guildDeclarationInputField
			{
				get
				{
					return this.m_owner.m_guildDeclarationInputField;
				}
				set
				{
					this.m_owner.m_guildDeclarationInputField = value;
				}
			}

			// Token: 0x17002E6D RID: 11885
			// (get) Token: 0x0600F18C RID: 61836 RVA: 0x00403150 File Offset: 0x00401350
			// (set) Token: 0x0600F18D RID: 61837 RVA: 0x00403160 File Offset: 0x00401360
			public InputField m_levelInputField
			{
				get
				{
					return this.m_owner.m_levelInputField;
				}
				set
				{
					this.m_owner.m_levelInputField = value;
				}
			}

			// Token: 0x17002E6E RID: 11886
			// (get) Token: 0x0600F18E RID: 61838 RVA: 0x00403170 File Offset: 0x00401370
			// (set) Token: 0x0600F18F RID: 61839 RVA: 0x00403180 File Offset: 0x00401380
			public Button m_forwardLevelButton
			{
				get
				{
					return this.m_owner.m_forwardLevelButton;
				}
				set
				{
					this.m_owner.m_forwardLevelButton = value;
				}
			}

			// Token: 0x17002E6F RID: 11887
			// (get) Token: 0x0600F190 RID: 61840 RVA: 0x00403190 File Offset: 0x00401390
			// (set) Token: 0x0600F191 RID: 61841 RVA: 0x004031A0 File Offset: 0x004013A0
			public Button m_backwardLevelButton
			{
				get
				{
					return this.m_owner.m_backwardLevelButton;
				}
				set
				{
					this.m_owner.m_backwardLevelButton = value;
				}
			}

			// Token: 0x17002E70 RID: 11888
			// (get) Token: 0x0600F192 RID: 61842 RVA: 0x004031B0 File Offset: 0x004013B0
			// (set) Token: 0x0600F193 RID: 61843 RVA: 0x004031C0 File Offset: 0x004013C0
			public Image m_requireItemIamge
			{
				get
				{
					return this.m_owner.m_requireItemIamge;
				}
				set
				{
					this.m_owner.m_requireItemIamge = value;
				}
			}

			// Token: 0x17002E71 RID: 11889
			// (get) Token: 0x0600F194 RID: 61844 RVA: 0x004031D0 File Offset: 0x004013D0
			// (set) Token: 0x0600F195 RID: 61845 RVA: 0x004031E0 File Offset: 0x004013E0
			public Toggle m_approveAutoToggle
			{
				get
				{
					return this.m_owner.m_approveAutoToggle;
				}
				set
				{
					this.m_owner.m_approveAutoToggle = value;
				}
			}

			// Token: 0x17002E72 RID: 11890
			// (get) Token: 0x0600F196 RID: 61846 RVA: 0x004031F0 File Offset: 0x004013F0
			// (set) Token: 0x0600F197 RID: 61847 RVA: 0x00403200 File Offset: 0x00401400
			public Toggle m_approveChairmanToggle
			{
				get
				{
					return this.m_owner.m_approveChairmanToggle;
				}
				set
				{
					this.m_owner.m_approveChairmanToggle = value;
				}
			}

			// Token: 0x17002E73 RID: 11891
			// (get) Token: 0x0600F198 RID: 61848 RVA: 0x00403210 File Offset: 0x00401410
			// (set) Token: 0x0600F199 RID: 61849 RVA: 0x00403220 File Offset: 0x00401420
			public Button m_createButton
			{
				get
				{
					return this.m_owner.m_createButton;
				}
				set
				{
					this.m_owner.m_createButton = value;
				}
			}

			// Token: 0x17002E74 RID: 11892
			// (get) Token: 0x0600F19A RID: 61850 RVA: 0x00403230 File Offset: 0x00401430
			// (set) Token: 0x0600F19B RID: 61851 RVA: 0x00403240 File Offset: 0x00401440
			public Button m_colseButton
			{
				get
				{
					return this.m_owner.m_colseButton;
				}
				set
				{
					this.m_owner.m_colseButton = value;
				}
			}

			// Token: 0x17002E75 RID: 11893
			// (get) Token: 0x0600F19C RID: 61852 RVA: 0x00403250 File Offset: 0x00401450
			// (set) Token: 0x0600F19D RID: 61853 RVA: 0x00403260 File Offset: 0x00401460
			public Button m_bgButton
			{
				get
				{
					return this.m_owner.m_bgButton;
				}
				set
				{
					this.m_owner.m_bgButton = value;
				}
			}

			// Token: 0x17002E76 RID: 11894
			// (get) Token: 0x0600F19E RID: 61854 RVA: 0x00403270 File Offset: 0x00401470
			// (set) Token: 0x0600F19F RID: 61855 RVA: 0x00403280 File Offset: 0x00401480
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17002E77 RID: 11895
			// (get) Token: 0x0600F1A0 RID: 61856 RVA: 0x00403290 File Offset: 0x00401490
			// (set) Token: 0x0600F1A1 RID: 61857 RVA: 0x004032A0 File Offset: 0x004014A0
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17002E78 RID: 11896
			// (get) Token: 0x0600F1A2 RID: 61858 RVA: 0x004032B0 File Offset: 0x004014B0
			// (set) Token: 0x0600F1A3 RID: 61859 RVA: 0x004032C0 File Offset: 0x004014C0
			public int m_requireLevel
			{
				get
				{
					return this.m_owner.m_requireLevel;
				}
				set
				{
					this.m_owner.m_requireLevel = value;
				}
			}

			// Token: 0x17002E79 RID: 11897
			// (get) Token: 0x0600F1A4 RID: 61860 RVA: 0x004032D0 File Offset: 0x004014D0
			// (set) Token: 0x0600F1A5 RID: 61861 RVA: 0x004032E0 File Offset: 0x004014E0
			public GuildUITask m_guildUITask
			{
				get
				{
					return this.m_owner.m_guildUITask;
				}
				set
				{
					this.m_owner.m_guildUITask = value;
				}
			}

			// Token: 0x0600F1A6 RID: 61862 RVA: 0x004032F0 File Offset: 0x004014F0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F1A7 RID: 61863 RVA: 0x00403300 File Offset: 0x00401500
			public void CreateGuild()
			{
				this.m_owner.CreateGuild();
			}

			// Token: 0x0600F1A8 RID: 61864 RVA: 0x00403310 File Offset: 0x00401510
			public void RefreshLevelDisplay()
			{
				this.m_owner.RefreshLevelDisplay();
			}

			// Token: 0x0600F1A9 RID: 61865 RVA: 0x00403320 File Offset: 0x00401520
			public void OnCreateGuildClick()
			{
				this.m_owner.OnCreateGuildClick();
			}

			// Token: 0x0600F1AA RID: 61866 RVA: 0x00403330 File Offset: 0x00401530
			public void OnCloseClick()
			{
				this.m_owner.OnCloseClick();
			}

			// Token: 0x0600F1AB RID: 61867 RVA: 0x00403340 File Offset: 0x00401540
			public void OnForwardLevelClick()
			{
				this.m_owner.OnForwardLevelClick();
			}

			// Token: 0x0600F1AC RID: 61868 RVA: 0x00403350 File Offset: 0x00401550
			public void OnBackwardLevelClick()
			{
				this.m_owner.OnBackwardLevelClick();
			}

			// Token: 0x0600F1AD RID: 61869 RVA: 0x00403360 File Offset: 0x00401560
			public void OnBGClick()
			{
				this.m_owner.OnBGClick();
			}

			// Token: 0x0600F1AE RID: 61870 RVA: 0x00403370 File Offset: 0x00401570
			public void OnLevelInputFiledEndEdit(string content)
			{
				this.m_owner.OnLevelInputFiledEndEdit(content);
			}

			// Token: 0x0600F1AF RID: 61871 RVA: 0x00403380 File Offset: 0x00401580
			public void OnGuildDeclaratioInputFiledEndEdit(string content)
			{
				this.m_owner.OnGuildDeclaratioInputFiledEndEdit(content);
			}

			// Token: 0x04008F7F RID: 36735
			private CreateGuildUIController m_owner;
		}
	}
}
