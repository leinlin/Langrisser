using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F84 RID: 3972
	[HotFix]
	public class TeamRoomListItemUIController : UIControllerBase
	{
		// Token: 0x06013DE7 RID: 81383 RVA: 0x0050F4D4 File Offset: 0x0050D6D4
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
			this.m_joinButton.onClick.AddListener(new UnityAction(this.OnJoinButtonClick));
		}

		// Token: 0x06013DE8 RID: 81384 RVA: 0x0050F558 File Offset: 0x0050D758
		public void SetGameFunctionTypeName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGameFunctionTypeNameString_hotfix != null)
			{
				this.m_SetGameFunctionTypeNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_gameFunctionTypeNameText.text = name;
		}

		// Token: 0x06013DE9 RID: 81385 RVA: 0x0050F5D4 File Offset: 0x0050D7D4
		public void SetLocationName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLocationNameString_hotfix != null)
			{
				this.m_SetLocationNameString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_locationNameText.text = name;
		}

		// Token: 0x06013DEA RID: 81386 RVA: 0x0050F650 File Offset: 0x0050D850
		public void SetRoomId(int roomId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRoomIdInt32_hotfix != null)
			{
				this.m_SetRoomIdInt32_hotfix.call(new object[]
				{
					this,
					roomId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_roomId = roomId;
		}

		// Token: 0x06013DEB RID: 81387 RVA: 0x0050F6C8 File Offset: 0x0050D8C8
		public int GetRoomId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRoomId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRoomId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_roomId;
		}

		// Token: 0x06013DEC RID: 81388 RVA: 0x0050F73C File Offset: 0x0050D93C
		public void SetGameFunctionType(GameFunctionType gameFunctionType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGameFunctionTypeGameFunctionType_hotfix != null)
			{
				this.m_SetGameFunctionTypeGameFunctionType_hotfix.call(new object[]
				{
					this,
					gameFunctionType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_gameFunctionType = gameFunctionType;
		}

		// Token: 0x06013DED RID: 81389 RVA: 0x0050F7B4 File Offset: 0x0050D9B4
		public GameFunctionType GetGameFunctionType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGameFunctionType_hotfix != null)
			{
				return (GameFunctionType)this.m_GetGameFunctionType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_gameFunctionType;
		}

		// Token: 0x06013DEE RID: 81390 RVA: 0x0050F828 File Offset: 0x0050DA28
		public void SetLocationId(int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLocationIdInt32_hotfix != null)
			{
				this.m_SetLocationIdInt32_hotfix.call(new object[]
				{
					this,
					locationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_locationId = locationId;
		}

		// Token: 0x06013DEF RID: 81391 RVA: 0x0050F8A0 File Offset: 0x0050DAA0
		public int GetLocationIdId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLocationIdId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLocationIdId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_locationId;
		}

		// Token: 0x06013DF0 RID: 81392 RVA: 0x0050F914 File Offset: 0x0050DB14
		public void SetPlayer(int index, int headIconId, int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerInt32Int32Int32_hotfix != null)
			{
				this.m_SetPlayerInt32Int32Int32_hotfix.call(new object[]
				{
					this,
					index,
					headIconId,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject playerInfoGameObject = this.GetPlayerInfoGameObject(index);
			if (playerInfoGameObject != null)
			{
				playerInfoGameObject.SetActive(true);
				Image component = playerInfoGameObject.transform.GetComponent<Image>();
				if (component != null)
				{
					component.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(headIconId)));
				}
				Transform parent = Utility.FindChildComponent<Transform>(playerInfoGameObject, "HeadFrameDummy", true);
				UIUtility.SetPlayerHeadFrame(parent, HeadIconTools.GetHeadFrame(headIconId), true, "Normal");
				Text text = Utility.FindChildComponent<Text>(playerInfoGameObject, "LevelText", true);
				if (text != null)
				{
					text.text = level.ToString();
				}
			}
		}

		// Token: 0x06013DF1 RID: 81393 RVA: 0x0050FA40 File Offset: 0x0050DC40
		public void SetPlayerOff(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerOffInt32_hotfix != null)
			{
				this.m_SetPlayerOffInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject playerInfoGameObject = this.GetPlayerInfoGameObject(index);
			if (playerInfoGameObject != null)
			{
				playerInfoGameObject.SetActive(false);
			}
		}

		// Token: 0x06013DF2 RID: 81394 RVA: 0x0050FACC File Offset: 0x0050DCCC
		private GameObject GetPlayerInfoGameObject(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerInfoGameObjectInt32_hotfix != null)
			{
				return (GameObject)this.m_GetPlayerInfoGameObjectInt32_hotfix.call(new object[]
				{
					this,
					index
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Transform transform = base.transform.Find(string.Format("Player{0}/PlayerInfoItem", index + 1));
			if (transform != null)
			{
				return transform.gameObject;
			}
			return null;
		}

		// Token: 0x06013DF3 RID: 81395 RVA: 0x0050FB7C File Offset: 0x0050DD7C
		public void SetPlayerLevelRange(int levelMin, int levelMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerLevelRangeInt32Int32_hotfix != null)
			{
				this.m_SetPlayerLevelRangeInt32Int32_hotfix.call(new object[]
				{
					this,
					levelMin,
					levelMax
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerLevelText.text = string.Format("{0} - {1}", levelMin, levelMax);
		}

		// Token: 0x06013DF4 RID: 81396 RVA: 0x0050FC20 File Offset: 0x0050DE20
		private void OnJoinButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJoinButtonClick_hotfix != null)
			{
				this.m_OnJoinButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnJoinButtonClick != null)
			{
				this.EventOnJoinButtonClick(this);
			}
		}

		// Token: 0x14000460 RID: 1120
		// (add) Token: 0x06013DF5 RID: 81397 RVA: 0x0050FC98 File Offset: 0x0050DE98
		// (remove) Token: 0x06013DF6 RID: 81398 RVA: 0x0050FD34 File Offset: 0x0050DF34
		public event Action<TeamRoomListItemUIController> EventOnJoinButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnJoinButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnJoinButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomListItemUIController> action = this.EventOnJoinButtonClick;
				Action<TeamRoomListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomListItemUIController>>(ref this.EventOnJoinButtonClick, (Action<TeamRoomListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnJoinButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnJoinButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TeamRoomListItemUIController> action = this.EventOnJoinButtonClick;
				Action<TeamRoomListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TeamRoomListItemUIController>>(ref this.EventOnJoinButtonClick, (Action<TeamRoomListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x06013DF7 RID: 81399 RVA: 0x0050FDD0 File Offset: 0x0050DFD0
		// (set) Token: 0x06013DF8 RID: 81400 RVA: 0x0050FDF0 File Offset: 0x0050DFF0
		[DoNotToLua]
		public new TeamRoomListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamRoomListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013DF9 RID: 81401 RVA: 0x0050FDFC File Offset: 0x0050DFFC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013DFA RID: 81402 RVA: 0x0050FE08 File Offset: 0x0050E008
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013DFB RID: 81403 RVA: 0x0050FE10 File Offset: 0x0050E010
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013DFC RID: 81404 RVA: 0x0050FE18 File Offset: 0x0050E018
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013DFD RID: 81405 RVA: 0x0050FE2C File Offset: 0x0050E02C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013DFE RID: 81406 RVA: 0x0050FE34 File Offset: 0x0050E034
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013DFF RID: 81407 RVA: 0x0050FE40 File Offset: 0x0050E040
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013E00 RID: 81408 RVA: 0x0050FE4C File Offset: 0x0050E04C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013E01 RID: 81409 RVA: 0x0050FE58 File Offset: 0x0050E058
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013E02 RID: 81410 RVA: 0x0050FE64 File Offset: 0x0050E064
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013E03 RID: 81411 RVA: 0x0050FE70 File Offset: 0x0050E070
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013E04 RID: 81412 RVA: 0x0050FE7C File Offset: 0x0050E07C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013E05 RID: 81413 RVA: 0x0050FE88 File Offset: 0x0050E088
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013E06 RID: 81414 RVA: 0x0050FE94 File Offset: 0x0050E094
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013E07 RID: 81415 RVA: 0x0050FEA0 File Offset: 0x0050E0A0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013E08 RID: 81416 RVA: 0x0050FEA8 File Offset: 0x0050E0A8
		private void __callDele_EventOnJoinButtonClick(TeamRoomListItemUIController obj)
		{
			Action<TeamRoomListItemUIController> eventOnJoinButtonClick = this.EventOnJoinButtonClick;
			if (eventOnJoinButtonClick != null)
			{
				eventOnJoinButtonClick(obj);
			}
		}

		// Token: 0x06013E09 RID: 81417 RVA: 0x0050FECC File Offset: 0x0050E0CC
		private void __clearDele_EventOnJoinButtonClick(TeamRoomListItemUIController obj)
		{
			this.EventOnJoinButtonClick = null;
		}

		// Token: 0x06013E0A RID: 81418 RVA: 0x0050FED8 File Offset: 0x0050E0D8
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
					this.m_SetGameFunctionTypeNameString_hotfix = (luaObj.RawGet("SetGameFunctionTypeName") as LuaFunction);
					this.m_SetLocationNameString_hotfix = (luaObj.RawGet("SetLocationName") as LuaFunction);
					this.m_SetRoomIdInt32_hotfix = (luaObj.RawGet("SetRoomId") as LuaFunction);
					this.m_GetRoomId_hotfix = (luaObj.RawGet("GetRoomId") as LuaFunction);
					this.m_SetGameFunctionTypeGameFunctionType_hotfix = (luaObj.RawGet("SetGameFunctionType") as LuaFunction);
					this.m_GetGameFunctionType_hotfix = (luaObj.RawGet("GetGameFunctionType") as LuaFunction);
					this.m_SetLocationIdInt32_hotfix = (luaObj.RawGet("SetLocationId") as LuaFunction);
					this.m_GetLocationIdId_hotfix = (luaObj.RawGet("GetLocationIdId") as LuaFunction);
					this.m_SetPlayerInt32Int32Int32_hotfix = (luaObj.RawGet("SetPlayer") as LuaFunction);
					this.m_SetPlayerOffInt32_hotfix = (luaObj.RawGet("SetPlayerOff") as LuaFunction);
					this.m_GetPlayerInfoGameObjectInt32_hotfix = (luaObj.RawGet("GetPlayerInfoGameObject") as LuaFunction);
					this.m_SetPlayerLevelRangeInt32Int32_hotfix = (luaObj.RawGet("SetPlayerLevelRange") as LuaFunction);
					this.m_OnJoinButtonClick_hotfix = (luaObj.RawGet("OnJoinButtonClick") as LuaFunction);
					this.m_add_EventOnJoinButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnJoinButtonClick") as LuaFunction);
					this.m_remove_EventOnJoinButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnJoinButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013E0B RID: 81419 RVA: 0x0051011C File Offset: 0x0050E31C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AFA8 RID: 44968
		[AutoBind("./JoinButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_joinButton;

		// Token: 0x0400AFA9 RID: 44969
		[AutoBind("./NameGroup/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_gameFunctionTypeNameText;

		// Token: 0x0400AFAA RID: 44970
		[AutoBind("./NameGroup/LevelValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_locationNameText;

		// Token: 0x0400AFAB RID: 44971
		[AutoBind("./LevelGroup/LevelValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLevelText;

		// Token: 0x0400AFAC RID: 44972
		private GameFunctionType m_gameFunctionType;

		// Token: 0x0400AFAD RID: 44973
		private int m_locationId;

		// Token: 0x0400AFAE RID: 44974
		private int m_roomId;

		// Token: 0x0400AFAF RID: 44975
		[DoNotToLua]
		private TeamRoomListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AFB0 RID: 44976
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AFB1 RID: 44977
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AFB2 RID: 44978
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AFB3 RID: 44979
		private LuaFunction m_SetGameFunctionTypeNameString_hotfix;

		// Token: 0x0400AFB4 RID: 44980
		private LuaFunction m_SetLocationNameString_hotfix;

		// Token: 0x0400AFB5 RID: 44981
		private LuaFunction m_SetRoomIdInt32_hotfix;

		// Token: 0x0400AFB6 RID: 44982
		private LuaFunction m_GetRoomId_hotfix;

		// Token: 0x0400AFB7 RID: 44983
		private LuaFunction m_SetGameFunctionTypeGameFunctionType_hotfix;

		// Token: 0x0400AFB8 RID: 44984
		private LuaFunction m_GetGameFunctionType_hotfix;

		// Token: 0x0400AFB9 RID: 44985
		private LuaFunction m_SetLocationIdInt32_hotfix;

		// Token: 0x0400AFBA RID: 44986
		private LuaFunction m_GetLocationIdId_hotfix;

		// Token: 0x0400AFBB RID: 44987
		private LuaFunction m_SetPlayerInt32Int32Int32_hotfix;

		// Token: 0x0400AFBC RID: 44988
		private LuaFunction m_SetPlayerOffInt32_hotfix;

		// Token: 0x0400AFBD RID: 44989
		private LuaFunction m_GetPlayerInfoGameObjectInt32_hotfix;

		// Token: 0x0400AFBE RID: 44990
		private LuaFunction m_SetPlayerLevelRangeInt32Int32_hotfix;

		// Token: 0x0400AFBF RID: 44991
		private LuaFunction m_OnJoinButtonClick_hotfix;

		// Token: 0x0400AFC0 RID: 44992
		private LuaFunction m_add_EventOnJoinButtonClickAction;

		// Token: 0x0400AFC1 RID: 44993
		private LuaFunction m_remove_EventOnJoinButtonClickAction;

		// Token: 0x02000F85 RID: 3973
		public new class LuaExportHelper
		{
			// Token: 0x06013E0C RID: 81420 RVA: 0x00510184 File Offset: 0x0050E384
			public LuaExportHelper(TeamRoomListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013E0D RID: 81421 RVA: 0x00510194 File Offset: 0x0050E394
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013E0E RID: 81422 RVA: 0x005101A4 File Offset: 0x0050E3A4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013E0F RID: 81423 RVA: 0x005101B4 File Offset: 0x0050E3B4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013E10 RID: 81424 RVA: 0x005101C4 File Offset: 0x0050E3C4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06013E11 RID: 81425 RVA: 0x005101DC File Offset: 0x0050E3DC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06013E12 RID: 81426 RVA: 0x005101EC File Offset: 0x0050E3EC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06013E13 RID: 81427 RVA: 0x005101FC File Offset: 0x0050E3FC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06013E14 RID: 81428 RVA: 0x0051020C File Offset: 0x0050E40C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06013E15 RID: 81429 RVA: 0x0051021C File Offset: 0x0050E41C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06013E16 RID: 81430 RVA: 0x0051022C File Offset: 0x0050E42C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013E17 RID: 81431 RVA: 0x0051023C File Offset: 0x0050E43C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013E18 RID: 81432 RVA: 0x0051024C File Offset: 0x0050E44C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013E19 RID: 81433 RVA: 0x0051025C File Offset: 0x0050E45C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013E1A RID: 81434 RVA: 0x0051026C File Offset: 0x0050E46C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013E1B RID: 81435 RVA: 0x0051027C File Offset: 0x0050E47C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06013E1C RID: 81436 RVA: 0x0051028C File Offset: 0x0050E48C
			public void __callDele_EventOnJoinButtonClick(TeamRoomListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnJoinButtonClick(obj);
			}

			// Token: 0x06013E1D RID: 81437 RVA: 0x0051029C File Offset: 0x0050E49C
			public void __clearDele_EventOnJoinButtonClick(TeamRoomListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnJoinButtonClick(obj);
			}

			// Token: 0x17003B64 RID: 15204
			// (get) Token: 0x06013E1E RID: 81438 RVA: 0x005102AC File Offset: 0x0050E4AC
			// (set) Token: 0x06013E1F RID: 81439 RVA: 0x005102BC File Offset: 0x0050E4BC
			public Button m_joinButton
			{
				get
				{
					return this.m_owner.m_joinButton;
				}
				set
				{
					this.m_owner.m_joinButton = value;
				}
			}

			// Token: 0x17003B65 RID: 15205
			// (get) Token: 0x06013E20 RID: 81440 RVA: 0x005102CC File Offset: 0x0050E4CC
			// (set) Token: 0x06013E21 RID: 81441 RVA: 0x005102DC File Offset: 0x0050E4DC
			public Text m_gameFunctionTypeNameText
			{
				get
				{
					return this.m_owner.m_gameFunctionTypeNameText;
				}
				set
				{
					this.m_owner.m_gameFunctionTypeNameText = value;
				}
			}

			// Token: 0x17003B66 RID: 15206
			// (get) Token: 0x06013E22 RID: 81442 RVA: 0x005102EC File Offset: 0x0050E4EC
			// (set) Token: 0x06013E23 RID: 81443 RVA: 0x005102FC File Offset: 0x0050E4FC
			public Text m_locationNameText
			{
				get
				{
					return this.m_owner.m_locationNameText;
				}
				set
				{
					this.m_owner.m_locationNameText = value;
				}
			}

			// Token: 0x17003B67 RID: 15207
			// (get) Token: 0x06013E24 RID: 81444 RVA: 0x0051030C File Offset: 0x0050E50C
			// (set) Token: 0x06013E25 RID: 81445 RVA: 0x0051031C File Offset: 0x0050E51C
			public Text m_playerLevelText
			{
				get
				{
					return this.m_owner.m_playerLevelText;
				}
				set
				{
					this.m_owner.m_playerLevelText = value;
				}
			}

			// Token: 0x17003B68 RID: 15208
			// (get) Token: 0x06013E26 RID: 81446 RVA: 0x0051032C File Offset: 0x0050E52C
			// (set) Token: 0x06013E27 RID: 81447 RVA: 0x0051033C File Offset: 0x0050E53C
			public GameFunctionType m_gameFunctionType
			{
				get
				{
					return this.m_owner.m_gameFunctionType;
				}
				set
				{
					this.m_owner.m_gameFunctionType = value;
				}
			}

			// Token: 0x17003B69 RID: 15209
			// (get) Token: 0x06013E28 RID: 81448 RVA: 0x0051034C File Offset: 0x0050E54C
			// (set) Token: 0x06013E29 RID: 81449 RVA: 0x0051035C File Offset: 0x0050E55C
			public int m_locationId
			{
				get
				{
					return this.m_owner.m_locationId;
				}
				set
				{
					this.m_owner.m_locationId = value;
				}
			}

			// Token: 0x17003B6A RID: 15210
			// (get) Token: 0x06013E2A RID: 81450 RVA: 0x0051036C File Offset: 0x0050E56C
			// (set) Token: 0x06013E2B RID: 81451 RVA: 0x0051037C File Offset: 0x0050E57C
			public int m_roomId
			{
				get
				{
					return this.m_owner.m_roomId;
				}
				set
				{
					this.m_owner.m_roomId = value;
				}
			}

			// Token: 0x06013E2C RID: 81452 RVA: 0x0051038C File Offset: 0x0050E58C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013E2D RID: 81453 RVA: 0x0051039C File Offset: 0x0050E59C
			public GameObject GetPlayerInfoGameObject(int index)
			{
				return this.m_owner.GetPlayerInfoGameObject(index);
			}

			// Token: 0x06013E2E RID: 81454 RVA: 0x005103AC File Offset: 0x0050E5AC
			public void OnJoinButtonClick()
			{
				this.m_owner.OnJoinButtonClick();
			}

			// Token: 0x0400AFC2 RID: 44994
			private TeamRoomListItemUIController m_owner;
		}
	}
}
