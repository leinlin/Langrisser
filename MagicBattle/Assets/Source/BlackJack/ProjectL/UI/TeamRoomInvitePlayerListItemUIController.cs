using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F74 RID: 3956
	[HotFix]
	public class TeamRoomInvitePlayerListItemUIController : UIControllerBase
	{
		// Token: 0x06013BD1 RID: 80849 RVA: 0x0050770C File Offset: 0x0050590C
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
			this.m_canNotInviteButton.onClick.AddListener(new UnityAction(this.OnCanNotInviteButtonClick));
		}

		// Token: 0x06013BD2 RID: 80850 RVA: 0x00507790 File Offset: 0x00505990
		public void SetUserId(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUserIdString_hotfix != null)
			{
				this.m_SetUserIdString_hotfix.call(new object[]
				{
					this,
					userId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_userId = userId;
		}

		// Token: 0x06013BD3 RID: 80851 RVA: 0x00507808 File Offset: 0x00505A08
		public string GetUserId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUserId_hotfix != null)
			{
				return (string)this.m_GetUserId_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_userId;
		}

		// Token: 0x06013BD4 RID: 80852 RVA: 0x0050787C File Offset: 0x00505A7C
		public void SetName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetNameString_hotfix != null)
			{
				this.m_SetNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = name;
		}

		// Token: 0x06013BD5 RID: 80853 RVA: 0x005078F8 File Offset: 0x00505AF8
		public void SetLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLevelInt32_hotfix != null)
			{
				this.m_SetLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelText.text = level.ToString();
		}

		// Token: 0x06013BD6 RID: 80854 RVA: 0x00507980 File Offset: 0x00505B80
		public void SetHeadIcon(int headIconId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeadIconInt32_hotfix != null)
			{
				this.m_SetHeadIconInt32_hotfix.call(new object[]
				{
					this,
					headIconId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Image headIconImage = this.m_headIconImage;
			Sprite sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(headIconId)));
			this.m_headIconImageGrey.sprite = sprite;
			headIconImage.sprite = sprite;
			UIUtility.SetPlayerHeadFrame(this.m_headFrameTransform, HeadIconTools.GetHeadFrame(headIconId), true, "Normal");
		}

		// Token: 0x06013BD7 RID: 80855 RVA: 0x00507A38 File Offset: 0x00505C38
		public void SetIsRecent(bool isRecent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIsRecentBoolean_hotfix != null)
			{
				this.m_SetIsRecentBoolean_hotfix.call(new object[]
				{
					this,
					isRecent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_recentUIStateController.SetToUIState((!isRecent) ? "None" : "RecentlyTeam", false, true);
		}

		// Token: 0x06013BD8 RID: 80856 RVA: 0x00507ACC File Offset: 0x00505CCC
		public void SetSelected(bool selected)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectedBoolean_hotfix != null)
			{
				this.m_SetSelectedBoolean_hotfix.call(new object[]
				{
					this,
					selected
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectToggle.isOn = selected;
		}

		// Token: 0x06013BD9 RID: 80857 RVA: 0x00507B48 File Offset: 0x00505D48
		public bool IsSelected()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSelected_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSelected_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_selectToggle.isOn;
		}

		// Token: 0x06013BDA RID: 80858 RVA: 0x00507BC0 File Offset: 0x00505DC0
		public void SetInviteState(TeamRoomPlayerInviteState inviteState)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetInviteStateTeamRoomPlayerInviteState_hotfix != null)
			{
				this.m_SetInviteStateTeamRoomPlayerInviteState_hotfix.call(new object[]
				{
					this,
					inviteState
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (inviteState == TeamRoomPlayerInviteState.CanInvite)
			{
				this.m_canNotInviteButton.gameObject.SetActive(false);
			}
			else
			{
				this.m_canNotInviteButton.gameObject.SetActive(true);
				if (this.IsSelected())
				{
					this.SetSelected(false);
				}
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				if (inviteState == TeamRoomPlayerInviteState.LevelNotOpen)
				{
					this.m_canNotInviteText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_PlayerLevelNotOpen);
				}
				else if (inviteState == TeamRoomPlayerInviteState.TodayHasNoHero)
				{
					this.m_canNotInviteText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Team_PlayerTodayHasNoHero);
				}
			}
		}

		// Token: 0x06013BDB RID: 80859 RVA: 0x00507CC0 File Offset: 0x00505EC0
		private void OnCanNotInviteButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCanNotInviteButtonClick_hotfix != null)
			{
				this.m_OnCanNotInviteButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(this.m_canNotInviteText.text, 2f, null, true);
		}

		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x06013BDC RID: 80860 RVA: 0x00507D3C File Offset: 0x00505F3C
		// (set) Token: 0x06013BDD RID: 80861 RVA: 0x00507D5C File Offset: 0x00505F5C
		[DoNotToLua]
		public new TeamRoomInvitePlayerListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamRoomInvitePlayerListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013BDE RID: 80862 RVA: 0x00507D68 File Offset: 0x00505F68
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013BDF RID: 80863 RVA: 0x00507D74 File Offset: 0x00505F74
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013BE0 RID: 80864 RVA: 0x00507D7C File Offset: 0x00505F7C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013BE1 RID: 80865 RVA: 0x00507D84 File Offset: 0x00505F84
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013BE2 RID: 80866 RVA: 0x00507D98 File Offset: 0x00505F98
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013BE3 RID: 80867 RVA: 0x00507DA0 File Offset: 0x00505FA0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013BE4 RID: 80868 RVA: 0x00507DAC File Offset: 0x00505FAC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013BE5 RID: 80869 RVA: 0x00507DB8 File Offset: 0x00505FB8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013BE6 RID: 80870 RVA: 0x00507DC4 File Offset: 0x00505FC4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013BE7 RID: 80871 RVA: 0x00507DD0 File Offset: 0x00505FD0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013BE8 RID: 80872 RVA: 0x00507DDC File Offset: 0x00505FDC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013BE9 RID: 80873 RVA: 0x00507DE8 File Offset: 0x00505FE8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013BEA RID: 80874 RVA: 0x00507DF4 File Offset: 0x00505FF4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013BEB RID: 80875 RVA: 0x00507E00 File Offset: 0x00506000
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013BEC RID: 80876 RVA: 0x00507E0C File Offset: 0x0050600C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013BED RID: 80877 RVA: 0x00507E14 File Offset: 0x00506014
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
					this.m_SetUserIdString_hotfix = (luaObj.RawGet("SetUserId") as LuaFunction);
					this.m_GetUserId_hotfix = (luaObj.RawGet("GetUserId") as LuaFunction);
					this.m_SetNameString_hotfix = (luaObj.RawGet("SetName") as LuaFunction);
					this.m_SetLevelInt32_hotfix = (luaObj.RawGet("SetLevel") as LuaFunction);
					this.m_SetHeadIconInt32_hotfix = (luaObj.RawGet("SetHeadIcon") as LuaFunction);
					this.m_SetIsRecentBoolean_hotfix = (luaObj.RawGet("SetIsRecent") as LuaFunction);
					this.m_SetSelectedBoolean_hotfix = (luaObj.RawGet("SetSelected") as LuaFunction);
					this.m_IsSelected_hotfix = (luaObj.RawGet("IsSelected") as LuaFunction);
					this.m_SetInviteStateTeamRoomPlayerInviteState_hotfix = (luaObj.RawGet("SetInviteState") as LuaFunction);
					this.m_OnCanNotInviteButtonClick_hotfix = (luaObj.RawGet("OnCanNotInviteButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013BEE RID: 80878 RVA: 0x00507FDC File Offset: 0x005061DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInvitePlayerListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AECC RID: 44748
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_recentUIStateController;

		// Token: 0x0400AECD RID: 44749
		[AutoBind("./PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x0400AECE RID: 44750
		[AutoBind("./LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400AECF RID: 44751
		[AutoBind("./PlayerIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIconImage;

		// Token: 0x0400AED0 RID: 44752
		[AutoBind("./PlayerIconImageGrey", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_headIconImageGrey;

		// Token: 0x0400AED1 RID: 44753
		[AutoBind("./PlayerIconImage/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_headFrameTransform;

		// Token: 0x0400AED2 RID: 44754
		[AutoBind("./SelectToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_selectToggle;

		// Token: 0x0400AED3 RID: 44755
		[AutoBind("./StageNotOpen", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_canNotInviteButton;

		// Token: 0x0400AED4 RID: 44756
		[AutoBind("./StageNotOpen/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_canNotInviteText;

		// Token: 0x0400AED5 RID: 44757
		private string m_userId;

		// Token: 0x0400AED6 RID: 44758
		[DoNotToLua]
		private TeamRoomInvitePlayerListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AED7 RID: 44759
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AED8 RID: 44760
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AED9 RID: 44761
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AEDA RID: 44762
		private LuaFunction m_SetUserIdString_hotfix;

		// Token: 0x0400AEDB RID: 44763
		private LuaFunction m_GetUserId_hotfix;

		// Token: 0x0400AEDC RID: 44764
		private LuaFunction m_SetNameString_hotfix;

		// Token: 0x0400AEDD RID: 44765
		private LuaFunction m_SetLevelInt32_hotfix;

		// Token: 0x0400AEDE RID: 44766
		private LuaFunction m_SetHeadIconInt32_hotfix;

		// Token: 0x0400AEDF RID: 44767
		private LuaFunction m_SetIsRecentBoolean_hotfix;

		// Token: 0x0400AEE0 RID: 44768
		private LuaFunction m_SetSelectedBoolean_hotfix;

		// Token: 0x0400AEE1 RID: 44769
		private LuaFunction m_IsSelected_hotfix;

		// Token: 0x0400AEE2 RID: 44770
		private LuaFunction m_SetInviteStateTeamRoomPlayerInviteState_hotfix;

		// Token: 0x0400AEE3 RID: 44771
		private LuaFunction m_OnCanNotInviteButtonClick_hotfix;

		// Token: 0x02000F75 RID: 3957
		public new class LuaExportHelper
		{
			// Token: 0x06013BEF RID: 80879 RVA: 0x00508044 File Offset: 0x00506244
			public LuaExportHelper(TeamRoomInvitePlayerListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013BF0 RID: 80880 RVA: 0x00508054 File Offset: 0x00506254
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013BF1 RID: 80881 RVA: 0x00508064 File Offset: 0x00506264
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013BF2 RID: 80882 RVA: 0x00508074 File Offset: 0x00506274
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013BF3 RID: 80883 RVA: 0x00508084 File Offset: 0x00506284
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013BF4 RID: 80884 RVA: 0x0050809C File Offset: 0x0050629C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013BF5 RID: 80885 RVA: 0x005080AC File Offset: 0x005062AC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013BF6 RID: 80886 RVA: 0x005080BC File Offset: 0x005062BC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013BF7 RID: 80887 RVA: 0x005080CC File Offset: 0x005062CC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013BF8 RID: 80888 RVA: 0x005080DC File Offset: 0x005062DC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013BF9 RID: 80889 RVA: 0x005080EC File Offset: 0x005062EC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013BFA RID: 80890 RVA: 0x005080FC File Offset: 0x005062FC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013BFB RID: 80891 RVA: 0x0050810C File Offset: 0x0050630C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013BFC RID: 80892 RVA: 0x0050811C File Offset: 0x0050631C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013BFD RID: 80893 RVA: 0x0050812C File Offset: 0x0050632C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013BFE RID: 80894 RVA: 0x0050813C File Offset: 0x0050633C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003B1A RID: 15130
			// (get) Token: 0x06013BFF RID: 80895 RVA: 0x0050814C File Offset: 0x0050634C
			// (set) Token: 0x06013C00 RID: 80896 RVA: 0x0050815C File Offset: 0x0050635C
			public CommonUIStateController m_recentUIStateController
			{
				get
				{
					return this.m_owner.m_recentUIStateController;
				}
				set
				{
					this.m_owner.m_recentUIStateController = value;
				}
			}

			// Token: 0x17003B1B RID: 15131
			// (get) Token: 0x06013C01 RID: 80897 RVA: 0x0050816C File Offset: 0x0050636C
			// (set) Token: 0x06013C02 RID: 80898 RVA: 0x0050817C File Offset: 0x0050637C
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

			// Token: 0x17003B1C RID: 15132
			// (get) Token: 0x06013C03 RID: 80899 RVA: 0x0050818C File Offset: 0x0050638C
			// (set) Token: 0x06013C04 RID: 80900 RVA: 0x0050819C File Offset: 0x0050639C
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x17003B1D RID: 15133
			// (get) Token: 0x06013C05 RID: 80901 RVA: 0x005081AC File Offset: 0x005063AC
			// (set) Token: 0x06013C06 RID: 80902 RVA: 0x005081BC File Offset: 0x005063BC
			public Image m_headIconImage
			{
				get
				{
					return this.m_owner.m_headIconImage;
				}
				set
				{
					this.m_owner.m_headIconImage = value;
				}
			}

			// Token: 0x17003B1E RID: 15134
			// (get) Token: 0x06013C07 RID: 80903 RVA: 0x005081CC File Offset: 0x005063CC
			// (set) Token: 0x06013C08 RID: 80904 RVA: 0x005081DC File Offset: 0x005063DC
			public Image m_headIconImageGrey
			{
				get
				{
					return this.m_owner.m_headIconImageGrey;
				}
				set
				{
					this.m_owner.m_headIconImageGrey = value;
				}
			}

			// Token: 0x17003B1F RID: 15135
			// (get) Token: 0x06013C09 RID: 80905 RVA: 0x005081EC File Offset: 0x005063EC
			// (set) Token: 0x06013C0A RID: 80906 RVA: 0x005081FC File Offset: 0x005063FC
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

			// Token: 0x17003B20 RID: 15136
			// (get) Token: 0x06013C0B RID: 80907 RVA: 0x0050820C File Offset: 0x0050640C
			// (set) Token: 0x06013C0C RID: 80908 RVA: 0x0050821C File Offset: 0x0050641C
			public Toggle m_selectToggle
			{
				get
				{
					return this.m_owner.m_selectToggle;
				}
				set
				{
					this.m_owner.m_selectToggle = value;
				}
			}

			// Token: 0x17003B21 RID: 15137
			// (get) Token: 0x06013C0D RID: 80909 RVA: 0x0050822C File Offset: 0x0050642C
			// (set) Token: 0x06013C0E RID: 80910 RVA: 0x0050823C File Offset: 0x0050643C
			public Button m_canNotInviteButton
			{
				get
				{
					return this.m_owner.m_canNotInviteButton;
				}
				set
				{
					this.m_owner.m_canNotInviteButton = value;
				}
			}

			// Token: 0x17003B22 RID: 15138
			// (get) Token: 0x06013C0F RID: 80911 RVA: 0x0050824C File Offset: 0x0050644C
			// (set) Token: 0x06013C10 RID: 80912 RVA: 0x0050825C File Offset: 0x0050645C
			public Text m_canNotInviteText
			{
				get
				{
					return this.m_owner.m_canNotInviteText;
				}
				set
				{
					this.m_owner.m_canNotInviteText = value;
				}
			}

			// Token: 0x17003B23 RID: 15139
			// (get) Token: 0x06013C11 RID: 80913 RVA: 0x0050826C File Offset: 0x0050646C
			// (set) Token: 0x06013C12 RID: 80914 RVA: 0x0050827C File Offset: 0x0050647C
			public string m_userId
			{
				get
				{
					return this.m_owner.m_userId;
				}
				set
				{
					this.m_owner.m_userId = value;
				}
			}

			// Token: 0x06013C13 RID: 80915 RVA: 0x0050828C File Offset: 0x0050648C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013C14 RID: 80916 RVA: 0x0050829C File Offset: 0x0050649C
			public void OnCanNotInviteButtonClick()
			{
				this.m_owner.OnCanNotInviteButtonClick();
			}

			// Token: 0x0400AEE4 RID: 44772
			private TeamRoomInvitePlayerListItemUIController m_owner;
		}
	}
}
