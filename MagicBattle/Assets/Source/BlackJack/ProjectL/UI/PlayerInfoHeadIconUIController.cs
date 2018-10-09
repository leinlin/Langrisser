using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E89 RID: 3721
	[HotFix]
	public class PlayerInfoHeadIconUIController : UIControllerBase
	{
		// Token: 0x06012210 RID: 74256 RVA: 0x004AB080 File Offset: 0x004A9280
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
			this.m_headFrameToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnHeadFrameValueChanged));
			this.m_headPortraitToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnHeadPortraitValueChanged));
			this.m_changeIconPanelBGButton.onClick.AddListener(new UnityAction(this.OnChangeIconPanelCloseButtonClick));
			this.m_confirmChangeIconButton.onClick.AddListener(new UnityAction(this.OnConfirmChangeIconButtonClick));
		}

		// Token: 0x06012211 RID: 74257 RVA: 0x004AB158 File Offset: 0x004A9358
		public void ShowChangeHeadIconPanel(GameObject headPortraitItemPrefab, GameObject headFrameItemPrefab)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowChangeHeadIconPanelGameObjectGameObject_hotfix != null)
			{
				this.m_ShowChangeHeadIconPanelGameObjectGameObject_hotfix.call(new object[]
				{
					this,
					headPortraitItemPrefab,
					headFrameItemPrefab
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_changeIconStateCtrl, "Show", null, false, true);
			this.m_headPortraitItemPrefab = headPortraitItemPrefab;
			this.m_headFrameItemPrefab = headFrameItemPrefab;
			if (this.m_headPortraitToggle.isOn)
			{
				this.ChangeHeadIconTogglePanel(PlayerInfoHeadIconPanelType.HeadPortrait);
			}
			else
			{
				this.m_headPortraitToggle.isOn = true;
			}
			this.UpdateChangHeadIconPreview();
		}

		// Token: 0x06012212 RID: 74258 RVA: 0x004AB228 File Offset: 0x004A9428
		public void ChangeHeadIconTogglePanel(PlayerInfoHeadIconPanelType panelType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeHeadIconTogglePanelPlayerInfoHeadIconPanelType_hotfix != null)
			{
				this.m_ChangeHeadIconTogglePanelPlayerInfoHeadIconPanelType_hotfix.call(new object[]
				{
					this,
					panelType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (panelType == PlayerInfoHeadIconPanelType.HeadPortrait)
			{
				int childCount = this.m_changeHeadPortraitScrollViewContent.transform.childCount;
				for (int i = 0; i < childCount; i++)
				{
					this.m_changeHeadPortraitScrollViewContent.transform.GetChild(i).gameObject.SetActive(false);
				}
				this.m_heroList = this.m_playerContext.GetHeros();
				int count = this.m_heroList.Count;
				int num = (!(this.m_curSelectedHeadPortraitItem != null)) ? this.m_playerContext.GetPlayerHeadPortrait() : this.m_curSelectedHeadPortraitItem.HeadPortraitId;
				for (int j = 0; j < count; j++)
				{
					PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController;
					if (j >= childCount)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_headPortraitItemPrefab);
						playerInfoHeadPortraitItemUIController = GameObjectUtility.AddControllerToGameObject<PlayerInfoHeadPortraitItemUIController>(gameObject);
						playerInfoHeadPortraitItemUIController.EventOnSelectToggleValueChanged += new Action<bool, PlayerInfoHeadPortraitItemUIController>(this.OnHeadPortraitToggleValueChanged);
						gameObject.transform.SetParent(this.m_changeHeadPortraitScrollViewContent.transform, false);
					}
					else
					{
						playerInfoHeadPortraitItemUIController = this.m_changeHeadPortraitScrollViewContent.transform.GetChild(j).GetComponent<PlayerInfoHeadPortraitItemUIController>();
					}
					playerInfoHeadPortraitItemUIController.gameObject.SetActive(true);
					Hero hero = this.m_heroList[j];
					bool flag = hero.HeroId == num;
					if (flag)
					{
						this.m_curSelectedHeadPortraitItem = playerInfoHeadPortraitItemUIController;
					}
					playerInfoHeadPortraitItemUIController.UpdateItemInfo(hero.HeroId, (hero.HeroInfo == null) ? string.Empty : hero.HeroInfo.Name, flag);
				}
			}
			else if (panelType == PlayerInfoHeadIconPanelType.HeadFrame)
			{
				int childCount2 = this.m_changeHeadFrameScrollViewContent.transform.childCount;
				for (int k = 0; k < childCount2; k++)
				{
					this.m_changeHeadFrameScrollViewContent.transform.GetChild(k).gameObject.SetActive(false);
				}
				int num2 = 0;
				int num3 = (!(this.m_curSelectedHeadFrameItem != null)) ? this.m_playerContext.GetPlayerHeadFrame() : this.m_curSelectedHeadFrameItem.HeadFrameId;
				foreach (KeyValuePair<int, ConfigDataHeadFrameInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataHeadFrameInfo())
				{
					PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController;
					if (num2 >= childCount2)
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.m_headFrameItemPrefab);
						playerInfoHeadFrameItemUIController = GameObjectUtility.AddControllerToGameObject<PlayerInfoHeadFrameItemUIController>(gameObject2);
						playerInfoHeadFrameItemUIController.EventOnSelectToggleValueChanged += new Action<bool, PlayerInfoHeadFrameItemUIController>(this.OnHeadFrameToggleValueChanged);
						gameObject2.transform.SetParent(this.m_changeHeadFrameScrollViewContent.transform, false);
					}
					else
					{
						playerInfoHeadFrameItemUIController = this.m_changeHeadFrameScrollViewContent.transform.GetChild(num2).GetComponent<PlayerInfoHeadFrameItemUIController>();
					}
					playerInfoHeadFrameItemUIController.gameObject.SetActive(true);
					bool isLock = !this.m_playerContext.HasHeadFrameId(keyValuePair.Key);
					bool flag2 = keyValuePair.Key == num3;
					if (flag2)
					{
						this.m_curSelectedHeadFrameItem = playerInfoHeadFrameItemUIController;
					}
					playerInfoHeadFrameItemUIController.UpdateItemInfo(keyValuePair.Key, isLock, flag2);
					num2++;
				}
			}
		}

		// Token: 0x06012213 RID: 74259 RVA: 0x004AB5A8 File Offset: 0x004A97A8
		public void OnChangeIconPanelCloseButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnChangeIconPanelCloseButtonClick_hotfix != null)
			{
				this.m_OnChangeIconPanelCloseButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_changeIconStateCtrl, "Close", null, false, true);
			GameObjectUtility.DestroyChildren(this.m_changeHeadPortraitScrollViewContent);
			GameObjectUtility.DestroyChildren(this.m_changeHeadFrameScrollViewContent);
		}

		// Token: 0x06012214 RID: 74260 RVA: 0x004AB634 File Offset: 0x004A9834
		private void UpdateChangHeadIconPreview()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateChangHeadIconPreview_hotfix != null)
			{
				this.m_UpdateChangHeadIconPreview_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_previewLevelText.text = this.m_playerContext.GetPlayerLevel().ToString();
			this.m_previewFrameUnlockText.text = string.Empty;
			if (this.m_curSelectedHeadPortraitItem == null)
			{
				this.m_previewHeadPortraitImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(this.m_playerContext.GetPlayerHeadPortrait()));
				this.m_previewPortraitNameText.text = string.Empty;
			}
			else
			{
				this.m_previewHeadPortraitImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(this.m_curSelectedHeadPortraitItem.HeadPortraitId));
				this.m_previewPortraitNameText.text = this.m_curSelectedHeadPortraitItem.HeadPortraitName;
				this.m_previewFrameUnlockText.text = this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_PlayerInfo_PreviewHeadPortrait);
			}
			if (this.m_curSelectedHeadFrameItem == null)
			{
				UIUtility.SetPlayerHeadFrame(this.m_previewHeadFrameTransform, this.m_playerContext.GetPlayerHeadFrame(), true, "Normal");
			}
			else
			{
				UIUtility.SetPlayerHeadFrame(this.m_previewHeadFrameTransform, this.m_curSelectedHeadFrameItem.HeadFrameId, true, "Normal");
				ConfigDataHeadFrameInfo configDataHeadFrameInfo = this.m_configDataLoader.GetConfigDataHeadFrameInfo(this.m_curSelectedHeadFrameItem.HeadFrameId);
				if (configDataHeadFrameInfo != null)
				{
					this.m_previewFrameNameText.text = configDataHeadFrameInfo.Name;
					if (this.m_headFrameToggle.isOn)
					{
						this.m_previewFrameUnlockText.text = configDataHeadFrameInfo.Source;
					}
				}
			}
		}

		// Token: 0x06012215 RID: 74261 RVA: 0x004AB808 File Offset: 0x004A9A08
		private void OnConfirmChangeIconButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConfirmChangeIconButtonClick_hotfix != null)
			{
				this.m_OnConfirmChangeIconButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int arg = (!(this.m_curSelectedHeadPortraitItem != null)) ? this.m_playerContext.GetPlayerHeadPortrait() : this.m_curSelectedHeadPortraitItem.HeadPortraitId;
			int num = (!(this.m_curSelectedHeadFrameItem != null)) ? this.m_playerContext.GetPlayerHeadFrame() : this.m_curSelectedHeadFrameItem.HeadFrameId;
			if (!this.m_playerContext.HasHeadFrameId(num))
			{
				string headFrameSource = this.m_playerContext.GetHeadFrameSource(num);
				if (!string.IsNullOrEmpty(headFrameSource))
				{
					CommonUIController.Instance.ShowMessage(headFrameSource, 2f, null, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(-13, 2f, null, true);
				}
				return;
			}
			if (this.EventOnChangeHeadPortraitAndHeadFrame != null)
			{
				this.EventOnChangeHeadPortraitAndHeadFrame(arg, num);
			}
		}

		// Token: 0x06012216 RID: 74262 RVA: 0x004AB930 File Offset: 0x004A9B30
		private PlayerInfoHeadIconPanelType GetCurPanelType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurPanelType_hotfix != null)
			{
				return (PlayerInfoHeadIconPanelType)this.m_GetCurPanelType_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_headPortraitToggle.isOn)
			{
				return PlayerInfoHeadIconPanelType.HeadPortrait;
			}
			if (this.m_headFrameToggle.isOn)
			{
				return PlayerInfoHeadIconPanelType.HeadFrame;
			}
			return PlayerInfoHeadIconPanelType.None;
		}

		// Token: 0x06012217 RID: 74263 RVA: 0x004AB9C4 File Offset: 0x004A9BC4
		private void OnHeadPortraitToggleValueChanged(bool isOn, UIControllerBase itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeadPortraitToggleValueChangedBooleanUIControllerBase_hotfix != null)
			{
				this.m_OnHeadPortraitToggleValueChangedBooleanUIControllerBase_hotfix.call(new object[]
				{
					this,
					isOn,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curSelectedHeadPortraitItem = (itemCtrl as PlayerInfoHeadPortraitItemUIController);
				this.UpdateChangHeadIconPreview();
			}
		}

		// Token: 0x06012218 RID: 74264 RVA: 0x004ABA5C File Offset: 0x004A9C5C
		private void OnHeadFrameToggleValueChanged(bool isOn, UIControllerBase itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeadFrameToggleValueChangedBooleanUIControllerBase_hotfix != null)
			{
				this.m_OnHeadFrameToggleValueChangedBooleanUIControllerBase_hotfix.call(new object[]
				{
					this,
					isOn,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.m_curSelectedHeadFrameItem = (itemCtrl as PlayerInfoHeadFrameItemUIController);
				this.UpdateChangHeadIconPreview();
			}
		}

		// Token: 0x06012219 RID: 74265 RVA: 0x004ABAF4 File Offset: 0x004A9CF4
		private void OnHeadFrameValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeadFrameValueChangedBoolean_hotfix != null)
			{
				this.m_OnHeadFrameValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.ChangeHeadIconTogglePanel(PlayerInfoHeadIconPanelType.HeadFrame);
				this.UpdateChangHeadIconPreview();
			}
		}

		// Token: 0x0601221A RID: 74266 RVA: 0x004ABB78 File Offset: 0x004A9D78
		private void OnHeadPortraitValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeadPortraitValueChangedBoolean_hotfix != null)
			{
				this.m_OnHeadPortraitValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (isOn)
			{
				this.ChangeHeadIconTogglePanel(PlayerInfoHeadIconPanelType.HeadPortrait);
				this.CheckHeadFrameValid();
				this.UpdateChangHeadIconPreview();
			}
		}

		// Token: 0x0601221B RID: 74267 RVA: 0x004ABC04 File Offset: 0x004A9E04
		private void CheckHeadFrameValid()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckHeadFrameValid_hotfix != null)
			{
				this.m_CheckHeadFrameValid_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curSelectedHeadFrameItem == null)
			{
				return;
			}
			if (this.m_playerContext.HasHeadFrameId(this.m_curSelectedHeadFrameItem.HeadFrameId))
			{
				return;
			}
			this.m_curSelectedHeadFrameItem = null;
		}

		// Token: 0x140003E5 RID: 997
		// (add) Token: 0x0601221C RID: 74268 RVA: 0x004ABC9C File Offset: 0x004A9E9C
		// (remove) Token: 0x0601221D RID: 74269 RVA: 0x004ABD38 File Offset: 0x004A9F38
		public event Action<int, int> EventOnChangeHeadPortraitAndHeadFrame
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix != null)
				{
					this.m_add_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnChangeHeadPortraitAndHeadFrame;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnChangeHeadPortraitAndHeadFrame, (Action<int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix != null)
				{
					this.m_remove_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, int> action = this.EventOnChangeHeadPortraitAndHeadFrame;
				Action<int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, int>>(ref this.EventOnChangeHeadPortraitAndHeadFrame, (Action<int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x0601221E RID: 74270 RVA: 0x004ABDD4 File Offset: 0x004A9FD4
		// (set) Token: 0x0601221F RID: 74271 RVA: 0x004ABDF4 File Offset: 0x004A9FF4
		[DoNotToLua]
		public new PlayerInfoHeadIconUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerInfoHeadIconUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012220 RID: 74272 RVA: 0x004ABE00 File Offset: 0x004AA000
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012221 RID: 74273 RVA: 0x004ABE0C File Offset: 0x004AA00C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012222 RID: 74274 RVA: 0x004ABE14 File Offset: 0x004AA014
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012223 RID: 74275 RVA: 0x004ABE1C File Offset: 0x004AA01C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012224 RID: 74276 RVA: 0x004ABE30 File Offset: 0x004AA030
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012225 RID: 74277 RVA: 0x004ABE38 File Offset: 0x004AA038
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012226 RID: 74278 RVA: 0x004ABE44 File Offset: 0x004AA044
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012227 RID: 74279 RVA: 0x004ABE50 File Offset: 0x004AA050
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012228 RID: 74280 RVA: 0x004ABE5C File Offset: 0x004AA05C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012229 RID: 74281 RVA: 0x004ABE68 File Offset: 0x004AA068
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601222A RID: 74282 RVA: 0x004ABE74 File Offset: 0x004AA074
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601222B RID: 74283 RVA: 0x004ABE80 File Offset: 0x004AA080
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601222C RID: 74284 RVA: 0x004ABE8C File Offset: 0x004AA08C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601222D RID: 74285 RVA: 0x004ABE98 File Offset: 0x004AA098
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601222E RID: 74286 RVA: 0x004ABEA4 File Offset: 0x004AA0A4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601222F RID: 74287 RVA: 0x004ABEAC File Offset: 0x004AA0AC
		private void __callDele_EventOnChangeHeadPortraitAndHeadFrame(int arg1, int arg2)
		{
			Action<int, int> eventOnChangeHeadPortraitAndHeadFrame = this.EventOnChangeHeadPortraitAndHeadFrame;
			if (eventOnChangeHeadPortraitAndHeadFrame != null)
			{
				eventOnChangeHeadPortraitAndHeadFrame(arg1, arg2);
			}
		}

		// Token: 0x06012230 RID: 74288 RVA: 0x004ABED0 File Offset: 0x004AA0D0
		private void __clearDele_EventOnChangeHeadPortraitAndHeadFrame(int arg1, int arg2)
		{
			this.EventOnChangeHeadPortraitAndHeadFrame = null;
		}

		// Token: 0x06012231 RID: 74289 RVA: 0x004ABEDC File Offset: 0x004AA0DC
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
					this.m_ShowChangeHeadIconPanelGameObjectGameObject_hotfix = (luaObj.RawGet("ShowChangeHeadIconPanel") as LuaFunction);
					this.m_ChangeHeadIconTogglePanelPlayerInfoHeadIconPanelType_hotfix = (luaObj.RawGet("ChangeHeadIconTogglePanel") as LuaFunction);
					this.m_OnChangeIconPanelCloseButtonClick_hotfix = (luaObj.RawGet("OnChangeIconPanelCloseButtonClick") as LuaFunction);
					this.m_UpdateChangHeadIconPreview_hotfix = (luaObj.RawGet("UpdateChangHeadIconPreview") as LuaFunction);
					this.m_OnConfirmChangeIconButtonClick_hotfix = (luaObj.RawGet("OnConfirmChangeIconButtonClick") as LuaFunction);
					this.m_GetCurPanelType_hotfix = (luaObj.RawGet("GetCurPanelType") as LuaFunction);
					this.m_OnHeadPortraitToggleValueChangedBooleanUIControllerBase_hotfix = (luaObj.RawGet("OnHeadPortraitToggleValueChanged") as LuaFunction);
					this.m_OnHeadFrameToggleValueChangedBooleanUIControllerBase_hotfix = (luaObj.RawGet("OnHeadFrameToggleValueChanged") as LuaFunction);
					this.m_OnHeadFrameValueChangedBoolean_hotfix = (luaObj.RawGet("OnHeadFrameValueChanged") as LuaFunction);
					this.m_OnHeadPortraitValueChangedBoolean_hotfix = (luaObj.RawGet("OnHeadPortraitValueChanged") as LuaFunction);
					this.m_CheckHeadFrameValid_hotfix = (luaObj.RawGet("CheckHeadFrameValid") as LuaFunction);
					this.m_add_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix = (luaObj.RawGet("add_EventOnChangeHeadPortraitAndHeadFrame") as LuaFunction);
					this.m_remove_EventOnChangeHeadPortraitAndHeadFrameAction`2_hotfix = (luaObj.RawGet("remove_EventOnChangeHeadPortraitAndHeadFrame") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012232 RID: 74290 RVA: 0x004AC0EC File Offset: 0x004AA2EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerInfoHeadIconUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A3CF RID: 41935
		[AutoBind("./ListPanel/ToggleGroup/HeadFrameToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_headFrameToggle;

		// Token: 0x0400A3D0 RID: 41936
		[AutoBind("./ListPanel/ToggleGroup/HeadToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_headPortraitToggle;

		// Token: 0x0400A3D1 RID: 41937
		[AutoBind("./ListPanel/HeadListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_changeHeadPortraitScrollViewContent;

		// Token: 0x0400A3D2 RID: 41938
		[AutoBind("./ListPanel/HeadFrameListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_changeHeadFrameScrollViewContent;

		// Token: 0x0400A3D3 RID: 41939
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_changeIconStateCtrl;

		// Token: 0x0400A3D4 RID: 41940
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_changeIconPanelBGButton;

		// Token: 0x0400A3D5 RID: 41941
		[AutoBind("./ListPanel/ConfirmButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_confirmChangeIconButton;

		// Token: 0x0400A3D6 RID: 41942
		[AutoBind("./PreviewPanel/PlayerHeadImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_previewHeadPortraitImage;

		// Token: 0x0400A3D7 RID: 41943
		[AutoBind("./PreviewPanel/HeadFrameDummy", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_previewHeadFrameTransform;

		// Token: 0x0400A3D8 RID: 41944
		[AutoBind("./PreviewPanel/LevelText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_previewLevelText;

		// Token: 0x0400A3D9 RID: 41945
		[AutoBind("./PreviewPanel/GetCondition/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_previewFrameUnlockText;

		// Token: 0x0400A3DA RID: 41946
		[AutoBind("./PreviewPanel/TitleText1", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_previewPortraitNameText;

		// Token: 0x0400A3DB RID: 41947
		[AutoBind("./PreviewPanel/TitleText2", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_previewFrameNameText;

		// Token: 0x0400A3DD RID: 41949
		private GameObject m_headPortraitItemPrefab;

		// Token: 0x0400A3DE RID: 41950
		private GameObject m_headFrameItemPrefab;

		// Token: 0x0400A3DF RID: 41951
		private List<Hero> m_heroList = new List<Hero>();

		// Token: 0x0400A3E0 RID: 41952
		private PlayerInfoHeadPortraitItemUIController m_curSelectedHeadPortraitItem;

		// Token: 0x0400A3E1 RID: 41953
		private PlayerInfoHeadFrameItemUIController m_curSelectedHeadFrameItem;

		// Token: 0x0400A3E2 RID: 41954
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x0400A3E3 RID: 41955
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400A3E4 RID: 41956
		[DoNotToLua]
		private PlayerInfoHeadIconUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A3E5 RID: 41957
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A3E6 RID: 41958
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A3E7 RID: 41959
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A3E8 RID: 41960
		private LuaFunction m_ShowChangeHeadIconPanelGameObjectGameObject_hotfix;

		// Token: 0x0400A3E9 RID: 41961
		private LuaFunction m_ChangeHeadIconTogglePanelPlayerInfoHeadIconPanelType_hotfix;

		// Token: 0x0400A3EA RID: 41962
		private LuaFunction m_OnChangeIconPanelCloseButtonClick_hotfix;

		// Token: 0x0400A3EB RID: 41963
		private LuaFunction m_UpdateChangHeadIconPreview_hotfix;

		// Token: 0x0400A3EC RID: 41964
		private LuaFunction m_OnConfirmChangeIconButtonClick_hotfix;

		// Token: 0x0400A3ED RID: 41965
		private LuaFunction m_GetCurPanelType_hotfix;

		// Token: 0x0400A3EE RID: 41966
		private LuaFunction m_OnHeadPortraitToggleValueChangedBooleanUIControllerBase_hotfix;

		// Token: 0x0400A3EF RID: 41967
		private LuaFunction m_OnHeadFrameToggleValueChangedBooleanUIControllerBase_hotfix;

		// Token: 0x0400A3F0 RID: 41968
		private LuaFunction m_OnHeadFrameValueChangedBoolean_hotfix;

		// Token: 0x0400A3F1 RID: 41969
		private LuaFunction m_OnHeadPortraitValueChangedBoolean_hotfix;

		// Token: 0x0400A3F2 RID: 41970
		private LuaFunction m_CheckHeadFrameValid_hotfix;

		// Token: 0x0400A3F3 RID: 41971
		private LuaFunction m_add_EventOnChangeHeadPortraitAndHeadFrameAction;

		// Token: 0x0400A3F4 RID: 41972
		private LuaFunction m_remove_EventOnChangeHeadPortraitAndHeadFrameAction;

		// Token: 0x02000E8A RID: 3722
		public new class LuaExportHelper
		{
			// Token: 0x06012233 RID: 74291 RVA: 0x004AC154 File Offset: 0x004AA354
			public LuaExportHelper(PlayerInfoHeadIconUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012234 RID: 74292 RVA: 0x004AC164 File Offset: 0x004AA364
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012235 RID: 74293 RVA: 0x004AC174 File Offset: 0x004AA374
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012236 RID: 74294 RVA: 0x004AC184 File Offset: 0x004AA384
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012237 RID: 74295 RVA: 0x004AC194 File Offset: 0x004AA394
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012238 RID: 74296 RVA: 0x004AC1AC File Offset: 0x004AA3AC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012239 RID: 74297 RVA: 0x004AC1BC File Offset: 0x004AA3BC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601223A RID: 74298 RVA: 0x004AC1CC File Offset: 0x004AA3CC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601223B RID: 74299 RVA: 0x004AC1DC File Offset: 0x004AA3DC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601223C RID: 74300 RVA: 0x004AC1EC File Offset: 0x004AA3EC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601223D RID: 74301 RVA: 0x004AC1FC File Offset: 0x004AA3FC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601223E RID: 74302 RVA: 0x004AC20C File Offset: 0x004AA40C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601223F RID: 74303 RVA: 0x004AC21C File Offset: 0x004AA41C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012240 RID: 74304 RVA: 0x004AC22C File Offset: 0x004AA42C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012241 RID: 74305 RVA: 0x004AC23C File Offset: 0x004AA43C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012242 RID: 74306 RVA: 0x004AC24C File Offset: 0x004AA44C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06012243 RID: 74307 RVA: 0x004AC25C File Offset: 0x004AA45C
			public void __callDele_EventOnChangeHeadPortraitAndHeadFrame(int arg1, int arg2)
			{
				this.m_owner.__callDele_EventOnChangeHeadPortraitAndHeadFrame(arg1, arg2);
			}

			// Token: 0x06012244 RID: 74308 RVA: 0x004AC26C File Offset: 0x004AA46C
			public void __clearDele_EventOnChangeHeadPortraitAndHeadFrame(int arg1, int arg2)
			{
				this.m_owner.__clearDele_EventOnChangeHeadPortraitAndHeadFrame(arg1, arg2);
			}

			// Token: 0x1700374B RID: 14155
			// (get) Token: 0x06012245 RID: 74309 RVA: 0x004AC27C File Offset: 0x004AA47C
			// (set) Token: 0x06012246 RID: 74310 RVA: 0x004AC28C File Offset: 0x004AA48C
			public Toggle m_headFrameToggle
			{
				get
				{
					return this.m_owner.m_headFrameToggle;
				}
				set
				{
					this.m_owner.m_headFrameToggle = value;
				}
			}

			// Token: 0x1700374C RID: 14156
			// (get) Token: 0x06012247 RID: 74311 RVA: 0x004AC29C File Offset: 0x004AA49C
			// (set) Token: 0x06012248 RID: 74312 RVA: 0x004AC2AC File Offset: 0x004AA4AC
			public Toggle m_headPortraitToggle
			{
				get
				{
					return this.m_owner.m_headPortraitToggle;
				}
				set
				{
					this.m_owner.m_headPortraitToggle = value;
				}
			}

			// Token: 0x1700374D RID: 14157
			// (get) Token: 0x06012249 RID: 74313 RVA: 0x004AC2BC File Offset: 0x004AA4BC
			// (set) Token: 0x0601224A RID: 74314 RVA: 0x004AC2CC File Offset: 0x004AA4CC
			public GameObject m_changeHeadPortraitScrollViewContent
			{
				get
				{
					return this.m_owner.m_changeHeadPortraitScrollViewContent;
				}
				set
				{
					this.m_owner.m_changeHeadPortraitScrollViewContent = value;
				}
			}

			// Token: 0x1700374E RID: 14158
			// (get) Token: 0x0601224B RID: 74315 RVA: 0x004AC2DC File Offset: 0x004AA4DC
			// (set) Token: 0x0601224C RID: 74316 RVA: 0x004AC2EC File Offset: 0x004AA4EC
			public GameObject m_changeHeadFrameScrollViewContent
			{
				get
				{
					return this.m_owner.m_changeHeadFrameScrollViewContent;
				}
				set
				{
					this.m_owner.m_changeHeadFrameScrollViewContent = value;
				}
			}

			// Token: 0x1700374F RID: 14159
			// (get) Token: 0x0601224D RID: 74317 RVA: 0x004AC2FC File Offset: 0x004AA4FC
			// (set) Token: 0x0601224E RID: 74318 RVA: 0x004AC30C File Offset: 0x004AA50C
			public CommonUIStateController m_changeIconStateCtrl
			{
				get
				{
					return this.m_owner.m_changeIconStateCtrl;
				}
				set
				{
					this.m_owner.m_changeIconStateCtrl = value;
				}
			}

			// Token: 0x17003750 RID: 14160
			// (get) Token: 0x0601224F RID: 74319 RVA: 0x004AC31C File Offset: 0x004AA51C
			// (set) Token: 0x06012250 RID: 74320 RVA: 0x004AC32C File Offset: 0x004AA52C
			public Button m_changeIconPanelBGButton
			{
				get
				{
					return this.m_owner.m_changeIconPanelBGButton;
				}
				set
				{
					this.m_owner.m_changeIconPanelBGButton = value;
				}
			}

			// Token: 0x17003751 RID: 14161
			// (get) Token: 0x06012251 RID: 74321 RVA: 0x004AC33C File Offset: 0x004AA53C
			// (set) Token: 0x06012252 RID: 74322 RVA: 0x004AC34C File Offset: 0x004AA54C
			public Button m_confirmChangeIconButton
			{
				get
				{
					return this.m_owner.m_confirmChangeIconButton;
				}
				set
				{
					this.m_owner.m_confirmChangeIconButton = value;
				}
			}

			// Token: 0x17003752 RID: 14162
			// (get) Token: 0x06012253 RID: 74323 RVA: 0x004AC35C File Offset: 0x004AA55C
			// (set) Token: 0x06012254 RID: 74324 RVA: 0x004AC36C File Offset: 0x004AA56C
			public Image m_previewHeadPortraitImage
			{
				get
				{
					return this.m_owner.m_previewHeadPortraitImage;
				}
				set
				{
					this.m_owner.m_previewHeadPortraitImage = value;
				}
			}

			// Token: 0x17003753 RID: 14163
			// (get) Token: 0x06012255 RID: 74325 RVA: 0x004AC37C File Offset: 0x004AA57C
			// (set) Token: 0x06012256 RID: 74326 RVA: 0x004AC38C File Offset: 0x004AA58C
			public Transform m_previewHeadFrameTransform
			{
				get
				{
					return this.m_owner.m_previewHeadFrameTransform;
				}
				set
				{
					this.m_owner.m_previewHeadFrameTransform = value;
				}
			}

			// Token: 0x17003754 RID: 14164
			// (get) Token: 0x06012257 RID: 74327 RVA: 0x004AC39C File Offset: 0x004AA59C
			// (set) Token: 0x06012258 RID: 74328 RVA: 0x004AC3AC File Offset: 0x004AA5AC
			public Text m_previewLevelText
			{
				get
				{
					return this.m_owner.m_previewLevelText;
				}
				set
				{
					this.m_owner.m_previewLevelText = value;
				}
			}

			// Token: 0x17003755 RID: 14165
			// (get) Token: 0x06012259 RID: 74329 RVA: 0x004AC3BC File Offset: 0x004AA5BC
			// (set) Token: 0x0601225A RID: 74330 RVA: 0x004AC3CC File Offset: 0x004AA5CC
			public Text m_previewFrameUnlockText
			{
				get
				{
					return this.m_owner.m_previewFrameUnlockText;
				}
				set
				{
					this.m_owner.m_previewFrameUnlockText = value;
				}
			}

			// Token: 0x17003756 RID: 14166
			// (get) Token: 0x0601225B RID: 74331 RVA: 0x004AC3DC File Offset: 0x004AA5DC
			// (set) Token: 0x0601225C RID: 74332 RVA: 0x004AC3EC File Offset: 0x004AA5EC
			public Text m_previewPortraitNameText
			{
				get
				{
					return this.m_owner.m_previewPortraitNameText;
				}
				set
				{
					this.m_owner.m_previewPortraitNameText = value;
				}
			}

			// Token: 0x17003757 RID: 14167
			// (get) Token: 0x0601225D RID: 74333 RVA: 0x004AC3FC File Offset: 0x004AA5FC
			// (set) Token: 0x0601225E RID: 74334 RVA: 0x004AC40C File Offset: 0x004AA60C
			public Text m_previewFrameNameText
			{
				get
				{
					return this.m_owner.m_previewFrameNameText;
				}
				set
				{
					this.m_owner.m_previewFrameNameText = value;
				}
			}

			// Token: 0x17003758 RID: 14168
			// (get) Token: 0x0601225F RID: 74335 RVA: 0x004AC41C File Offset: 0x004AA61C
			// (set) Token: 0x06012260 RID: 74336 RVA: 0x004AC42C File Offset: 0x004AA62C
			public GameObject m_headPortraitItemPrefab
			{
				get
				{
					return this.m_owner.m_headPortraitItemPrefab;
				}
				set
				{
					this.m_owner.m_headPortraitItemPrefab = value;
				}
			}

			// Token: 0x17003759 RID: 14169
			// (get) Token: 0x06012261 RID: 74337 RVA: 0x004AC43C File Offset: 0x004AA63C
			// (set) Token: 0x06012262 RID: 74338 RVA: 0x004AC44C File Offset: 0x004AA64C
			public GameObject m_headFrameItemPrefab
			{
				get
				{
					return this.m_owner.m_headFrameItemPrefab;
				}
				set
				{
					this.m_owner.m_headFrameItemPrefab = value;
				}
			}

			// Token: 0x1700375A RID: 14170
			// (get) Token: 0x06012263 RID: 74339 RVA: 0x004AC45C File Offset: 0x004AA65C
			// (set) Token: 0x06012264 RID: 74340 RVA: 0x004AC46C File Offset: 0x004AA66C
			public List<Hero> m_heroList
			{
				get
				{
					return this.m_owner.m_heroList;
				}
				set
				{
					this.m_owner.m_heroList = value;
				}
			}

			// Token: 0x1700375B RID: 14171
			// (get) Token: 0x06012265 RID: 74341 RVA: 0x004AC47C File Offset: 0x004AA67C
			// (set) Token: 0x06012266 RID: 74342 RVA: 0x004AC48C File Offset: 0x004AA68C
			public PlayerInfoHeadPortraitItemUIController m_curSelectedHeadPortraitItem
			{
				get
				{
					return this.m_owner.m_curSelectedHeadPortraitItem;
				}
				set
				{
					this.m_owner.m_curSelectedHeadPortraitItem = value;
				}
			}

			// Token: 0x1700375C RID: 14172
			// (get) Token: 0x06012267 RID: 74343 RVA: 0x004AC49C File Offset: 0x004AA69C
			// (set) Token: 0x06012268 RID: 74344 RVA: 0x004AC4AC File Offset: 0x004AA6AC
			public PlayerInfoHeadFrameItemUIController m_curSelectedHeadFrameItem
			{
				get
				{
					return this.m_owner.m_curSelectedHeadFrameItem;
				}
				set
				{
					this.m_owner.m_curSelectedHeadFrameItem = value;
				}
			}

			// Token: 0x1700375D RID: 14173
			// (get) Token: 0x06012269 RID: 74345 RVA: 0x004AC4BC File Offset: 0x004AA6BC
			// (set) Token: 0x0601226A RID: 74346 RVA: 0x004AC4CC File Offset: 0x004AA6CC
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

			// Token: 0x1700375E RID: 14174
			// (get) Token: 0x0601226B RID: 74347 RVA: 0x004AC4DC File Offset: 0x004AA6DC
			// (set) Token: 0x0601226C RID: 74348 RVA: 0x004AC4EC File Offset: 0x004AA6EC
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

			// Token: 0x0601226D RID: 74349 RVA: 0x004AC4FC File Offset: 0x004AA6FC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0601226E RID: 74350 RVA: 0x004AC50C File Offset: 0x004AA70C
			public void UpdateChangHeadIconPreview()
			{
				this.m_owner.UpdateChangHeadIconPreview();
			}

			// Token: 0x0601226F RID: 74351 RVA: 0x004AC51C File Offset: 0x004AA71C
			public void OnConfirmChangeIconButtonClick()
			{
				this.m_owner.OnConfirmChangeIconButtonClick();
			}

			// Token: 0x06012270 RID: 74352 RVA: 0x004AC52C File Offset: 0x004AA72C
			public PlayerInfoHeadIconPanelType GetCurPanelType()
			{
				return this.m_owner.GetCurPanelType();
			}

			// Token: 0x06012271 RID: 74353 RVA: 0x004AC53C File Offset: 0x004AA73C
			public void OnHeadPortraitToggleValueChanged(bool isOn, UIControllerBase itemCtrl)
			{
				this.m_owner.OnHeadPortraitToggleValueChanged(isOn, itemCtrl);
			}

			// Token: 0x06012272 RID: 74354 RVA: 0x004AC54C File Offset: 0x004AA74C
			public void OnHeadFrameToggleValueChanged(bool isOn, UIControllerBase itemCtrl)
			{
				this.m_owner.OnHeadFrameToggleValueChanged(isOn, itemCtrl);
			}

			// Token: 0x06012273 RID: 74355 RVA: 0x004AC55C File Offset: 0x004AA75C
			public void OnHeadFrameValueChanged(bool isOn)
			{
				this.m_owner.OnHeadFrameValueChanged(isOn);
			}

			// Token: 0x06012274 RID: 74356 RVA: 0x004AC56C File Offset: 0x004AA76C
			public void OnHeadPortraitValueChanged(bool isOn)
			{
				this.m_owner.OnHeadPortraitValueChanged(isOn);
			}

			// Token: 0x06012275 RID: 74357 RVA: 0x004AC57C File Offset: 0x004AA77C
			public void CheckHeadFrameValid()
			{
				this.m_owner.CheckHeadFrameValid();
			}

			// Token: 0x0400A3F5 RID: 41973
			private PlayerInfoHeadIconUIController m_owner;
		}
	}
}
