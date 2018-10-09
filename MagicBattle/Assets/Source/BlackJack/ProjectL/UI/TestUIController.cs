using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F8F RID: 3983
	[HotFix]
	public class TestUIController : UIControllerBase
	{
		// Token: 0x06013F77 RID: 81783 RVA: 0x00516A20 File Offset: 0x00514C20
		private TestUIController()
		{
		}

		// Token: 0x06013F78 RID: 81784 RVA: 0x00516A48 File Offset: 0x00514C48
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
			this.m_TestIdInputField.onValueChanged.AddListener(new UnityAction<string>(this.OnTestIdInput));
			this.m_TestIdNextSearch.onClick.AddListener(new UnityAction(this.OnTestIdNextBtnClick));
			this.m_TestListHomeBtn.onClick.AddListener(new UnityAction(this.OnTestListHomeBtnClick));
			this.m_battleToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnBattleToggle));
			this.m_dialogToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnDialogToggle));
			this.m_battleDialogToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnBattleDialogToggle));
			this.m_userGuideDialogToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnUserGuideDialogToggle));
			this.m_startTestBattleButton.onClick.AddListener(new UnityAction(this.OnStartTestButtonClick));
			this.m_systemInfoButton.onClick.AddListener(new UnityAction(this.OnSystemInfoButtonClick));
			this.m_systemInfoBackgroundButton.onClick.AddListener(new UnityAction(this.OnSystemInfoBackgroundButtonClick));
			this.m_goddessDialogButton.onClick.AddListener(new UnityAction(this.OnGoddessDialogButtonClick));
			this.m_clearUserGuideButton.onClick.AddListener(new UnityAction(this.OnClearUserGuideButtonClick));
			this.m_completeUserGuideButton.onClick.AddListener(new UnityAction(this.OnCompleteUserGuideButtonClick));
			this.m_becomeStrongButton.onClick.AddListener(new UnityAction(this.OnBecomeStrongButtonClick));
			this.m_clearStageButton.onClick.AddListener(new UnityAction(this.OnClearStageButtonClick));
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnButtonClick));
			this.m_cancelReportBugButton.onClick.AddListener(new UnityAction(this.OnCancelReportBugButtonClick));
			this.m_reportBugButton.onClick.AddListener(new UnityAction(this.OnReportBugButtonClick));
			this.m_openReportBugPanelButton.onClick.AddListener(new UnityAction(this.OnOpenReportBugPanelButtonClick));
			this.m_closeReportBugPanelButton.onClick.AddListener(new UnityAction(this.OnCancelReportBugButtonClick));
			this.m_finishAllTasksButton.onClick.AddListener(new UnityAction(this.OnFinishAllTasksButtonClick));
			this.m_iPhoneXToggle.isOn = LocalConfig.Instance.Data.TestMarginFix;
			this.m_iPhoneXToggle.onValueChanged.AddListener(new UnityAction<bool>(this.OniPhoneXToggleValueChanged));
			this.OniPhoneXToggleValueChanged(this.m_iPhoneXToggle.isOn);
			this.m_becomeStrongPlayerLevelInput.text = LocalConfig.Instance.Data.LastBecomeStrongPlayerLevel;
			this.m_becomeStrongEquipmentLevelInput.text = LocalConfig.Instance.Data.LastBecomeStrongEquipmentLevel;
			this.m_becomeStrongHeroStarLevelInput.text = LocalConfig.Instance.Data.LastBecomeStrongHeroStarLevel;
			this.m_prefabsGameObject.SetActive(false);
			this.InitLoopScrollViewRect();
		}

		// Token: 0x06013F79 RID: 81785 RVA: 0x00516DA4 File Offset: 0x00514FA4
		public void SetTestListType(TestListType listType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTestListTypeTestListType_hotfix != null)
			{
				this.m_SetTestListTypeTestListType_hotfix.call(new object[]
				{
					this,
					listType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isIgnoreToggleEvent = true;
			this.m_battleToggle.isOn = (listType == TestListType.Battle);
			this.m_dialogToggle.isOn = (listType == TestListType.Dialog);
			this.m_battleDialogToggle.isOn = (listType == TestListType.BattleDialog);
			this.m_userGuideDialogToggle.isOn = (listType == TestListType.UserGuideDialog);
			this.m_monsterLevelGameObject.SetActive(listType == TestListType.Battle);
			this.m_isIgnoreToggleEvent = false;
		}

		// Token: 0x06013F7A RID: 81786 RVA: 0x00516E70 File Offset: 0x00515070
		public void AddTestListItem(int id, string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddTestListItemInt32String_hotfix != null)
			{
				this.m_AddTestListItemInt32String_hotfix.call(new object[]
				{
					this,
					id,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_CacheTestList.Add(new KeyValuePair<int, string>(id, name));
		}

		// Token: 0x06013F7B RID: 81787 RVA: 0x00516F04 File Offset: 0x00515104
		public void ClearTestList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearTestList_hotfix != null)
			{
				this.m_ClearTestList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_CacheTestList.Clear();
		}

		// Token: 0x06013F7C RID: 81788 RVA: 0x00516F70 File Offset: 0x00515170
		private static void ScrollToItem(ScrollRect scrollRect, int itemCount, int idx)
		{
			float num = 50f;
			Vector2 sizeDelta = scrollRect.content.sizeDelta;
			sizeDelta.y = (float)itemCount * num;
			scrollRect.content.sizeDelta = sizeDelta;
			float num2 = scrollRect.viewport.rect.height / num;
			float verticalNormalizedPosition = Mathf.Clamp01(1f - (float)idx / ((float)itemCount - num2));
			scrollRect.verticalNormalizedPosition = verticalNormalizedPosition;
		}

		// Token: 0x06013F7D RID: 81789 RVA: 0x00516FD8 File Offset: 0x005151D8
		private TestListItemUIController GetSelectedTestListItemUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSelectedTestListItemUIController_hotfix != null)
			{
				return (TestListItemUIController)this.m_GetSelectedTestListItemUIController_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (TestListItemUIController testListItemUIController in this.m_testListItemUIControllers)
			{
				if (testListItemUIController.IsSelected())
				{
					return testListItemUIController;
				}
			}
			return null;
		}

		// Token: 0x06013F7E RID: 81790 RVA: 0x005170A4 File Offset: 0x005152A4
		public void SetMonsterLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMonsterLevelInt32_hotfix != null)
			{
				this.m_SetMonsterLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_monsterLevelInputField.text = level.ToString();
		}

		// Token: 0x06013F7F RID: 81791 RVA: 0x0051712C File Offset: 0x0051532C
		public int GetMonsterLevel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMonsterLevel_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMonsterLevel_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			if (int.TryParse(this.m_monsterLevelInputField.text, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06013F80 RID: 81792 RVA: 0x005171B4 File Offset: 0x005153B4
		public void SetServerDataTime(DateTime dt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetServerDataTimeDateTime_hotfix != null)
			{
				this.m_SetServerDataTimeDateTime_hotfix.call(new object[]
				{
					this,
					dt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_serverDateTimeText.text = string.Format("Svr: {0}", dt.ToString("yyyy/MM/dd HH:mm:ss"));
		}

		// Token: 0x06013F81 RID: 81793 RVA: 0x00517248 File Offset: 0x00515448
		public void ShowSystemInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSystemInfo_hotfix != null)
			{
				this.m_ShowSystemInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_systemInfoGameObject.SetActive(true);
			this.m_systemInfoText.text = TestUIController.BuildSystemInfoText(true);
		}

		// Token: 0x06013F82 RID: 81794 RVA: 0x005172C8 File Offset: 0x005154C8
		public static string BuildSystemInfoText(bool textColor)
		{
			StringBuilder stringBuilder = new StringBuilder();
			TestUIController.AppendLine(stringBuilder, textColor, "SystemInfo", string.Empty);
			TestUIController.AppendLine(stringBuilder, textColor, "Quality Setting", QualitySettings.names[QualitySettings.GetQualityLevel()]);
			TestUIController.AppendLine(stringBuilder, textColor, "Resolution", string.Format("{0} x {1}", Screen.width, Screen.height));
			TestUIController.AppendLine(stringBuilder, textColor, "Refresh Rate", Screen.currentResolution.refreshRate.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "Safe Area", Screen.safeArea.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "BatteryLevel", SystemInfo.batteryLevel.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "BatteryStatus", SystemInfo.batteryStatus.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "CopyTextureSupport", SystemInfo.copyTextureSupport.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "DeviceModel", SystemInfo.deviceModel);
			TestUIController.AppendLine(stringBuilder, textColor, "DeviceName", SystemInfo.deviceName);
			TestUIController.AppendLine(stringBuilder, textColor, "DeviceType", SystemInfo.deviceType.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "DeviceUniqueIdentifier", SystemInfo.deviceUniqueIdentifier);
			TestUIController.AppendLine(stringBuilder, textColor, "GraphicsDeviceID", SystemInfo.graphicsDeviceID.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "GraphicsDeviceName", SystemInfo.graphicsDeviceName);
			TestUIController.AppendLine(stringBuilder, textColor, "GraphicsDeviceType", SystemInfo.graphicsDeviceType.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "GraphicsDeviceVendor", SystemInfo.graphicsDeviceVendor);
			TestUIController.AppendLine(stringBuilder, textColor, "GraphicsDeviceVendorID", SystemInfo.graphicsDeviceVendorID.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "GraphicsDeviceVersion", SystemInfo.graphicsDeviceVersion.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "GraphicsMemorySize", SystemInfo.graphicsMemorySize.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "GraphicsMultiThreaded", SystemInfo.graphicsMultiThreaded.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "GraphicsShaderLevel", SystemInfo.graphicsShaderLevel.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "GraphicsUVStartsAtTop", SystemInfo.graphicsUVStartsAtTop.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "MaxCubemapSize", SystemInfo.maxCubemapSize.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "MaxTextureSize", SystemInfo.maxTextureSize.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "NpotSupport", SystemInfo.npotSupport.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "OperatingSystem", SystemInfo.operatingSystem);
			TestUIController.AppendLine(stringBuilder, textColor, "OperatingSystemFamily", SystemInfo.operatingSystemFamily.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "ProcessorCount", SystemInfo.processorCount.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "ProcessorFrequency", SystemInfo.processorFrequency.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "ProcessorType", SystemInfo.processorType.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportedRenderTargetCount", SystemInfo.supportedRenderTargetCount.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "Supports2DArrayTextures", SystemInfo.supports2DArrayTextures.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "Supports3DTextures", SystemInfo.supports3DTextures.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "Supports3DRenderTextures", SystemInfo.supports3DRenderTextures.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsAcceleromete", SystemInfo.supportsAccelerometer.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsAsyncCompute", SystemInfo.supportsAsyncCompute.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsAudio", SystemInfo.supportsAudio.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsComputeShaders", SystemInfo.supportsComputeShaders.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsCubemapArrayTextures", SystemInfo.supportsCubemapArrayTextures.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsGPUFence", SystemInfo.supportsGPUFence.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsGyroscope", SystemInfo.supportsGyroscope.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsImageEffects", SystemInfo.supportsImageEffects.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsInstancing", SystemInfo.supportsInstancing.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsLocationService", SystemInfo.supportsLocationService.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsMotionVectors", SystemInfo.supportsMotionVectors.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsMultisampledTextures", SystemInfo.supportsMultisampledTextures.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsRawShadowDepthSampling", SystemInfo.supportsRawShadowDepthSampling.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsRenderToCubemap", SystemInfo.supportsRenderToCubemap.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsShadows", SystemInfo.supportsShadows.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsSparseTextures", SystemInfo.supportsSparseTextures.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsTextureWrapMirrorOnce", SystemInfo.supportsTextureWrapMirrorOnce.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SupportsVibration", SystemInfo.supportsVibration.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "SystemMemorySize", SystemInfo.systemMemorySize.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "UnsupportedIdentifie", "n/a");
			TestUIController.AppendLine(stringBuilder, textColor, "UsesReversedZBuffe", SystemInfo.usesReversedZBuffer.ToString());
			TestUIController.AppendLine(stringBuilder, textColor, "DataPath", Application.dataPath);
			TestUIController.AppendLine(stringBuilder, textColor, "PersistentDataPath", Application.persistentDataPath);
			TestUIController.AppendLine(stringBuilder, textColor, "StreamingAssetsPath", Application.streamingAssetsPath);
			TestUIController.AppendLine(stringBuilder, textColor, "TemporaryCachePath", Application.temporaryCachePath);
			return stringBuilder.ToString();
		}

		// Token: 0x06013F83 RID: 81795 RVA: 0x00517980 File Offset: 0x00515B80
		private static void AppendLine(StringBuilder sb, bool textColor, string name, string value)
		{
			if (sb.Length > 0)
			{
				sb.Append("\n");
			}
			if (textColor)
			{
				sb.Append(UIUtility.AddColorTag(name, new Color(1f, 0.5f, 0f)));
			}
			else
			{
				sb.Append(name);
			}
			sb.Append(": ");
			sb.Append(value);
		}

		// Token: 0x06013F84 RID: 81796 RVA: 0x005179F0 File Offset: 0x00515BF0
		public void HideSystemInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideSystemInfo_hotfix != null)
			{
				this.m_HideSystemInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_systemInfoGameObject.SetActive(false);
		}

		// Token: 0x06013F85 RID: 81797 RVA: 0x00517A5C File Offset: 0x00515C5C
		private void InitLoopScrollViewRect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitLoopScrollViewRect_hotfix != null)
			{
				this.m_InitLoopScrollViewRect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PrefabControllerCreater.CreateAllControllers(this.m_testListItemPrefab);
			PoolInfo poolInfoByName = this.m_ListItemPool.GetPoolInfoByName("TestListItem");
			poolInfoByName.prefab = this.m_testListItemPrefab;
			this.m_ListItemPool.CreatePools();
			foreach (PoolObject poolObject in this.m_ListItemPool.GetObjectPoolByName("TestListItem"))
			{
				TestListItemUIController component = poolObject.gameObject.GetComponent<TestListItemUIController>();
				if (component != null)
				{
					component.Init(new Action<UIControllerBase>(this.OnTestItemClick), new Action<UIControllerBase>(this.OnTestItemFill));
				}
			}
		}

		// Token: 0x06013F86 RID: 81798 RVA: 0x00517B7C File Offset: 0x00515D7C
		public void RefreshLoopVerticalScrollView(TestListType listType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshLoopVerticalScrollViewTestListType_hotfix != null)
			{
				this.m_RefreshLoopVerticalScrollViewTestListType_hotfix.call(new object[]
				{
					this,
					listType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nSearchTestListId = -1;
			this.m_TestIdInputField.text = string.Empty;
			int lastitemID = LocalConfig.Instance.GetTestUIId((int)listType);
			int a = 0;
			if (lastitemID >= 0)
			{
				a = this.m_CacheTestList.FindIndex((KeyValuePair<int, string> i) => i.Key == lastitemID);
			}
			this.m_LoopScroolRect.totalCount = this.m_CacheTestList.Count;
			this.m_LoopScroolRect.RefillCells(Mathf.Max(a, 0));
		}

		// Token: 0x06013F87 RID: 81799 RVA: 0x00517C68 File Offset: 0x00515E68
		private void OnTestItemFill(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTestItemFillUIControllerBase_hotfix != null)
			{
				this.m_OnTestItemFillUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TestListItemUIController testListItemUIController = ctrl as TestListItemUIController;
			if (testListItemUIController != null)
			{
				int itemIndex = testListItemUIController.ScrollItemBaseUICtrl.ItemIndex;
				if (itemIndex >= 0 && itemIndex < this.m_CacheTestList.Count)
				{
					testListItemUIController.SetId(this.m_CacheTestList[itemIndex].Key);
					testListItemUIController.SetName(this.m_CacheTestList[itemIndex].Value);
					if (this.m_nSearchTestListId >= 0)
					{
						if (testListItemUIController.GetId() == this.m_nSearchTestListId)
						{
							this.OnTestItemClick(testListItemUIController);
						}
						else
						{
							testListItemUIController.SetSelected(false);
						}
					}
					else if (testListItemUIController.GetId() == LocalConfig.Instance.GetTestUIId(LocalConfig.Instance.Data.TestListType))
					{
						this.OnTestItemClick(testListItemUIController);
					}
					else
					{
						testListItemUIController.SetSelected(false);
					}
				}
			}
		}

		// Token: 0x06013F88 RID: 81800 RVA: 0x00517DB0 File Offset: 0x00515FB0
		private void OnTestItemClick(UIControllerBase ctrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTestItemClickUIControllerBase_hotfix != null)
			{
				this.m_OnTestItemClickUIControllerBase_hotfix.call(new object[]
				{
					this,
					ctrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_CurrSelectCtrl != null)
			{
				this.m_CurrSelectCtrl.SetSelected(false);
				this.m_CurrSelectCtrl = null;
			}
			this.m_CurrSelectCtrl = (ctrl as TestListItemUIController);
			this.m_CurrSelectCtrl.SetSelected(true);
		}

		// Token: 0x06013F89 RID: 81801 RVA: 0x00517E5C File Offset: 0x0051605C
		private void DoToggle(bool on, TestListType listType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoToggleBooleanTestListType_hotfix != null)
			{
				this.m_DoToggleBooleanTestListType_hotfix.call(new object[]
				{
					this,
					on,
					listType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isIgnoreToggleEvent)
			{
				return;
			}
			if (on && this.EventOnChangeTestList != null)
			{
				this.EventOnChangeTestList(listType);
			}
		}

		// Token: 0x06013F8A RID: 81802 RVA: 0x00517F08 File Offset: 0x00516108
		private void OnBattleToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleToggleBoolean_hotfix != null)
			{
				this.m_OnBattleToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DoToggle(on, TestListType.Battle);
		}

		// Token: 0x06013F8B RID: 81803 RVA: 0x00517F80 File Offset: 0x00516180
		private void OnDialogToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDialogToggleBoolean_hotfix != null)
			{
				this.m_OnDialogToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DoToggle(on, TestListType.Dialog);
		}

		// Token: 0x06013F8C RID: 81804 RVA: 0x00517FF8 File Offset: 0x005161F8
		private void OnBattleDialogToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBattleDialogToggleBoolean_hotfix != null)
			{
				this.m_OnBattleDialogToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DoToggle(on, TestListType.BattleDialog);
		}

		// Token: 0x06013F8D RID: 81805 RVA: 0x00518070 File Offset: 0x00516270
		private void OnUserGuideDialogToggle(bool on)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnUserGuideDialogToggleBoolean_hotfix != null)
			{
				this.m_OnUserGuideDialogToggleBoolean_hotfix.call(new object[]
				{
					this,
					on
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DoToggle(on, TestListType.UserGuideDialog);
		}

		// Token: 0x06013F8E RID: 81806 RVA: 0x005180E8 File Offset: 0x005162E8
		private void OnTestListHomeBtnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTestListHomeBtnClick_hotfix != null)
			{
				this.m_OnTestListHomeBtnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nSearchTestListId = this.m_CacheTestList[0].Key;
			this.m_LoopScroolRect.RefillCells(0);
		}

		// Token: 0x06013F8F RID: 81807 RVA: 0x00518170 File Offset: 0x00516370
		private void OnTestIdNextBtnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTestIdNextBtnClick_hotfix != null)
			{
				this.m_OnTestIdNextBtnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnTestIdInput(this.m_TestIdInputField.text);
		}

		// Token: 0x06013F90 RID: 81808 RVA: 0x005181E4 File Offset: 0x005163E4
		private void OnTestIdInput(string value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTestIdInputString_hotfix != null)
			{
				this.m_OnTestIdInputString_hotfix.call(new object[]
				{
					this,
					value2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string value = value2;
			if (!string.IsNullOrEmpty(value))
			{
				int num = -1;
				if (this.m_CurrSelectCtrl != null)
				{
					num = this.m_CacheTestList.FindIndex(this.m_CurrSelectCtrl.ScrollItemBaseUICtrl.ItemIndex + 1, (KeyValuePair<int, string> i) => i.Key.ToString().Contains(value) || i.Value.Contains(value));
				}
				if (num < 0)
				{
					num = this.m_CacheTestList.FindIndex((KeyValuePair<int, string> i) => i.Key.ToString().Contains(value) || i.Value.Contains(value));
				}
				if (num >= 0)
				{
					this.m_nSearchTestListId = this.m_CacheTestList[num].Key;
					this.m_LoopScroolRect.RefillCells(num);
				}
			}
		}

		// Token: 0x06013F91 RID: 81809 RVA: 0x005182FC File Offset: 0x005164FC
		private void OnStartTestButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartTestButtonClick_hotfix != null)
			{
				this.m_OnStartTestButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartTest != null && this.m_CurrSelectCtrl != null && this.m_CurrSelectCtrl.IsSelected())
			{
				this.EventOnStartTest(this.m_CurrSelectCtrl.GetId());
			}
		}

		// Token: 0x06013F92 RID: 81810 RVA: 0x005183A0 File Offset: 0x005165A0
		private void OnReturnButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnButtonClick_hotfix != null)
			{
				this.m_OnReturnButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReturn != null)
			{
				this.EventOnReturn();
			}
		}

		// Token: 0x06013F93 RID: 81811 RVA: 0x00518418 File Offset: 0x00516618
		private void OnSystemInfoButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSystemInfoButtonClick_hotfix != null)
			{
				this.m_OnSystemInfoButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowSystemInfo != null)
			{
				this.EventOnShowSystemInfo();
			}
		}

		// Token: 0x06013F94 RID: 81812 RVA: 0x00518490 File Offset: 0x00516690
		private void OnGoddessDialogButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGoddessDialogButtonClick_hotfix != null)
			{
				this.m_OnGoddessDialogButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnShowGoddessDialog != null)
			{
				this.EventOnShowGoddessDialog();
			}
		}

		// Token: 0x06013F95 RID: 81813 RVA: 0x00518508 File Offset: 0x00516708
		private void OnClearUserGuideButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClearUserGuideButtonClick_hotfix != null)
			{
				this.m_OnClearUserGuideButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClearUserGuide != null)
			{
				this.EventOnClearUserGuide();
			}
		}

		// Token: 0x06013F96 RID: 81814 RVA: 0x00518580 File Offset: 0x00516780
		private void OnBecomeStrongButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBecomeStrongButtonClick_hotfix != null)
			{
				this.m_OnBecomeStrongButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(TestUIController.BecomeStrong(int.Parse(this.m_becomeStrongPlayerLevelInput.text), int.Parse(this.m_becomeStrongHeroStarLevelInput.text), int.Parse(this.m_becomeStrongEquipmentLevelInput.text)));
			LocalConfig.Instance.Data.LastBecomeStrongPlayerLevel = this.m_becomeStrongPlayerLevelInput.text;
			LocalConfig.Instance.Data.LastBecomeStrongEquipmentLevel = this.m_becomeStrongEquipmentLevelInput.text;
			LocalConfig.Instance.Data.LastBecomeStrongHeroStarLevel = this.m_becomeStrongHeroStarLevelInput.text;
			LocalConfig.Instance.Save();
		}

		// Token: 0x06013F97 RID: 81815 RVA: 0x00518678 File Offset: 0x00516878
		private void OnFinishAllTasksButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFinishAllTasksButtonClick_hotfix != null)
			{
				this.m_OnFinishAllTasksButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.FinishAllTasks());
		}

		// Token: 0x06013F98 RID: 81816 RVA: 0x005186E8 File Offset: 0x005168E8
		[DebuggerHidden]
		private IEnumerator FinishAllTasks()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishAllTasks_hotfix != null)
			{
				return (IEnumerator)this.m_FinishAllTasks_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new TestUIController.<FinishAllTasks>c__Iterator0();
		}

		// Token: 0x06013F99 RID: 81817 RVA: 0x0051875C File Offset: 0x0051695C
		private void OnCancelReportBugButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCancelReportBugButtonClick_hotfix != null)
			{
				this.m_OnCancelReportBugButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_reportBugPanelGameObject.SetActive(false);
		}

		// Token: 0x06013F9A RID: 81818 RVA: 0x005187C8 File Offset: 0x005169C8
		private void OniPhoneXToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OniPhoneXToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OniPhoneXToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.TestMarginFix = isOn;
			LocalConfig.Instance.Save();
			CommonUIController.Instance.ShowiPhoneXTest(isOn);
		}

		// Token: 0x06013F9B RID: 81819 RVA: 0x00518860 File Offset: 0x00516A60
		private void OnReportBugButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReportBugButtonClick_hotfix != null)
			{
				this.m_OnReportBugButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnReportBug != null)
			{
				this.EventOnReportBug(this.m_bugDescriptionInputField.text, this.GetReportBugLogHours());
			}
			this.m_reportBugPanelGameObject.SetActive(false);
		}

		// Token: 0x06013F9C RID: 81820 RVA: 0x005188F4 File Offset: 0x00516AF4
		private double GetReportBugLogHours()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetReportBugLogHours_hotfix != null)
			{
				return Convert.ToDouble(this.m_GetReportBugLogHours_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_oneHourLogTime.isOn)
			{
				return 1.0;
			}
			if (this.m_oneDayLogTime.isOn)
			{
				return 24.0;
			}
			if (this.m_oneWeekLogTime.isOn)
			{
				return 168.0;
			}
			return 0.0;
		}

		// Token: 0x06013F9D RID: 81821 RVA: 0x005189B8 File Offset: 0x00516BB8
		private void OnOpenReportBugPanelButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOpenReportBugPanelButtonClick_hotfix != null)
			{
				this.m_OnOpenReportBugPanelButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_bugDescriptionInputField.text = string.Empty;
			this.m_oneHourLogTime.isOn = true;
			this.m_reportBugPanelGameObject.SetActive(true);
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x06013F9E RID: 81822 RVA: 0x00518A40 File Offset: 0x00516C40
		public static int MaxPlayerLevel
		{
			get
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				int num = int.MinValue;
				foreach (KeyValuePair<int, ConfigDataPlayerLevelInfo> keyValuePair in configDataLoader.GetAllConfigDataPlayerLevelInfo())
				{
					if (keyValuePair.Key > num)
					{
						num = keyValuePair.Key;
					}
				}
				return num;
			}
		}

		// Token: 0x06013F9F RID: 81823 RVA: 0x00518AC0 File Offset: 0x00516CC0
		private static IEnumerator UpgradePlayerLevel(int targetPlayerLevel)
		{
			targetPlayerLevel = Math.Min(TestUIController.MaxPlayerLevel, targetPlayerLevel);
			ProjectLPlayerContext pc = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			while (pc.GetPlayerLevel() < targetPlayerLevel)
			{
				if (pc.GetBagItemCountByTypeAndID(GoodsType.GoodsType_Item, 3099) < 1)
				{
					yield return TestUIController.SendGMCommand("ADD_ITEM 6,3099,100");
				}
				yield return TestUIController.UseItem(GoodsType.GoodsType_Item, 3099, 1);
			}
			yield break;
		}

		// Token: 0x06013FA0 RID: 81824 RVA: 0x00518ADC File Offset: 0x00516CDC
		private static IEnumerator SpeedUpAllHeros(int targetHeroLevel, int targetStarLevel)
		{
			ProjectLPlayerContext pc = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			foreach (Hero h in pc.GetHeros())
			{
				yield return TestUIController.SpeedUpHero(h.HeroId, targetHeroLevel, targetStarLevel);
			}
			yield break;
		}

		// Token: 0x06013FA1 RID: 81825 RVA: 0x00518B00 File Offset: 0x00516D00
		public static IEnumerator SetEnchantProperty(ulong equipmentInstanceId, string values, Action onEnd = null)
		{
			if (!LoginUITask.IsGMUser)
			{
				yield break;
			}
			ProjectLPlayerContext pc = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			EquipmentBagItem i = pc.GetBagItemByInstanceId(equipmentInstanceId) as EquipmentBagItem;
			if (i == null)
			{
				yield break;
			}
			CommonUIController.Instance.EnableInput(false);
			yield return TestUIController.SendGMCommand(string.Format("SET_ENCHANTPROPERTY {0} {1}", equipmentInstanceId, values));
			CommonUIController.Instance.EnableInput(true);
			CommonUIController.Instance.ShowMessage(string.Format("{0} 附魔成功。但要重新登陆才能看到最新数值。", i.EquipmentInfo.Name), 2f, null, true);
			if (onEnd != null)
			{
				onEnd();
			}
			yield break;
		}

		// Token: 0x06013FA2 RID: 81826 RVA: 0x00518B2C File Offset: 0x00516D2C
		private static IEnumerator BecomeStrong(int targetPlayerLevel, int targetStarLevel, int targetEquipmentLevel)
		{
			if (!LoginUITask.IsGMUser)
			{
				yield break;
			}
			CommonUIController.Instance.EnableInput(false);
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_MakingBigAccount, 2000f, null, true);
			yield return TestUIController.UpgradePlayerLevel(targetPlayerLevel);
			yield return TestUIController.SendGMCommand("CLEAR_STAGE 0");
			yield return TestUIController.SendGMCommand("COMPLETE_ALLUSERGUIDE");
			yield return TestUIController.SendGMCommand("ADD_ITEM 2,0,600000");
			yield return TestUIController.SendGMCommand(string.Format("ADD_ITEM 1,0,{0}", 2147483646));
			yield return TestUIController.AddAllHeros();
			yield return TestUIController.SpeedUpAllHeros(Math.Min(targetPlayerLevel, TestUIController.MaxPlayerLevel), targetStarLevel);
			yield return TestUIController.AddAllTopRankEquipments();
			for (int i = 0; i < 4; i++)
			{
				yield return TestUIController.EnhanceAllTopRankEquipments(targetEquipmentLevel);
				yield return TestUIController.StarLevelUpTopRankEquipments(309, 307);
			}
			yield return TestUIController.EnhanceAllTopRankEquipments(targetEquipmentLevel);
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_MakeBigAccountFinished, 2f, null, true);
			yield return new WaitForSeconds(2f);
			CommonUIController.Instance.EnableInput(true);
			LoginUITask.Relogin();
			yield break;
		}

		// Token: 0x06013FA3 RID: 81827 RVA: 0x00518B58 File Offset: 0x00516D58
		public static IEnumerator TenLevelUpEquipment(ulong equipmentInstanceId, Action OnEnd = null)
		{
			if (!LoginUITask.IsGMUser)
			{
				yield break;
			}
			ProjectLPlayerContext pc = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			EquipmentBagItem equipment = pc.GetBagItemByInstanceId(equipmentInstanceId) as EquipmentBagItem;
			if (equipment == null)
			{
				yield break;
			}
			for (;;)
			{
				List<ulong> materialIds = new List<ulong>();
				while (materialIds.Count < 5)
				{
					foreach (BagItemBase bagItemBase in pc.GetBagItems())
					{
						if (bagItemBase.GoodsTypeId == GoodsType.GoodsType_Equipment && bagItemBase.ContentId == 303 && !materialIds.Contains(bagItemBase.InstanceId))
						{
							materialIds.Add(bagItemBase.InstanceId);
							if (materialIds.Count >= 5)
							{
								break;
							}
						}
					}
					if (materialIds.Count < 5)
					{
						yield return TestUIController.SendGMCommand("ADD_ITEM 7,303,5");
					}
				}
				if (pc.CanEnhanceEquipment(equipmentInstanceId, materialIds) != 0)
				{
					break;
				}
				yield return TestUIController.EnhanceEquipment(equipmentInstanceId, materialIds);
			}
			if (OnEnd != null)
			{
				OnEnd();
			}
			CommonUIController.Instance.ShowMessage(string.Format("装备{0}已升到{1}级", equipment.EquipmentInfo.Name, equipment.Level), 2f, null, true);
			yield break;
		}

		// Token: 0x06013FA4 RID: 81828 RVA: 0x00518B7C File Offset: 0x00516D7C
		public static IEnumerator SpeedUpHero(int heroID, int targetHeroLevel, int targetStarLevel)
		{
			if (!LoginUITask.IsGMUser)
			{
				yield break;
			}
			IConfigDataLoader cfg = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataHeroInfo hi = cfg.GetConfigDataHeroInfo(heroID);
			if (hi == null)
			{
				yield break;
			}
			ProjectLPlayerContext pc = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			Hero h = pc.GetHero(heroID);
			if (h == null)
			{
				yield break;
			}
			if (h.Level < targetHeroLevel)
			{
				ConfigDataItemInfo expItemInfo = cfg.GetConfigDataItemInfo(3002);
				int expPerItem = expItemInfo.FuncTypeParam1;
				int allNeedExp = 0;
				for (int i = h.Level; i < targetHeroLevel; i++)
				{
					ConfigDataHeroLevelInfo configDataHeroLevelInfo = cfg.GetConfigDataHeroLevelInfo(i);
					allNeedExp += configDataHeroLevelInfo.Exp;
				}
				int itemCount = (allNeedExp - h.Exp) / expPerItem + 1;
				yield return TestUIController.SendGMCommand("ADD_ITEM 6,3002," + itemCount.ToString());
				yield return TestUIController.AddHeroExp(heroID, GoodsType.GoodsType_Item, 3002, itemCount);
				List<int> jobConns = TestUIController.GetHeroJobConnSequence(heroID);
				foreach (int jobConn in jobConns)
				{
					if (h.GetActiveJob().JobConnectionInfo.ID != jobConn)
					{
						yield return TestUIController.TransferHeroJob(heroID, jobConn);
					}
					while (!h.GetActiveJob().IsLevelMax())
					{
						int preLevel = h.GetActiveJob().JobLevel;
						yield return TestUIController.UpgradeHeroJobLevel(h, jobConn);
						if (preLevel == h.GetActiveJob().JobLevel)
						{
							break;
						}
					}
				}
			}
			while (h.StarLevel < targetStarLevel)
			{
				yield return TestUIController.SendGMCommand(string.Format("ADD_ITEM 6,{0},200", hi.FragmentItem_ID));
				int preLevel2 = h.StarLevel;
				yield return TestUIController.HeroBreak(heroID);
				if (preLevel2 == h.StarLevel)
				{
					IL_3B9:
					HeroListUITask t = UIUtility.FindUITaskWithType(typeof(HeroListUITask)) as HeroListUITask;
					if (t != null && t.State == Task.TaskState.Running)
					{
						t.Pause();
						t.Resume(null);
					}
					CommonUIController.Instance.ShowMessage(string.Format("恭喜{0}大人光荣毕业！", hi.Name), 2f, null, true);
					yield break;
				}
			}
			goto IL_3B9;
		}

		// Token: 0x06013FA5 RID: 81829 RVA: 0x00518BA8 File Offset: 0x00516DA8
		public static IEnumerator ResetHero(int heroID)
		{
			yield return TestUIController.SendGMCommand("reset_heroJob " + heroID);
			CommonUIController.Instance.ShowMessage("重启生效", 2f, null, true);
			yield break;
		}

		// Token: 0x06013FA6 RID: 81830 RVA: 0x00518BC4 File Offset: 0x00516DC4
		private static List<int> GetHeroJobConnSequence(int heroID)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(heroID);
			if (configDataHeroInfo == null)
			{
				return null;
			}
			return TestUIController.GetJobSequence(configDataHeroInfo.JobConnection_ID);
		}

		// Token: 0x06013FA7 RID: 81831 RVA: 0x00518BFC File Offset: 0x00516DFC
		private static List<int> GetJobSequence(int rootJobConnectionID)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			list2.Add(rootJobConnectionID);
			list.Add(rootJobConnectionID);
			while (list.Count > 0)
			{
				foreach (KeyValuePair<int, ConfigDataJobConnectionInfo> keyValuePair in configDataLoader.GetAllConfigDataJobConnectionInfo())
				{
					if (keyValuePair.Value.PreJobConnectionList.Count != 0 && keyValuePair.Value.IsJobOpen && keyValuePair.Value.PreJobConnectionList[0] == list[0])
					{
						list2.Add(keyValuePair.Value.ID);
						list.Add(keyValuePair.Value.ID);
					}
				}
				list.RemoveAt(0);
			}
			return list2;
		}

		// Token: 0x06013FA8 RID: 81832 RVA: 0x00518D04 File Offset: 0x00516F04
		private static int GetEquipmentLevelLimit(int equipmentStarLevel)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataEquipmentLevelLimitInfo configDataEquipmentLevelLimitInfo = configDataLoader.GetConfigDataEquipmentLevelLimitInfo(equipmentStarLevel);
			if (configDataEquipmentLevelLimitInfo == null)
			{
				return int.MaxValue;
			}
			return configDataEquipmentLevelLimitInfo.LevelLimit;
		}

		// Token: 0x06013FA9 RID: 81833 RVA: 0x00518D3C File Offset: 0x00516F3C
		private static bool IsEquipismentMaxLevel(EquipmentBagItem equipment)
		{
			return equipment.Level == TestUIController.GetEquipmentLevelLimit(equipment.StarLevel);
		}

		// Token: 0x06013FAA RID: 81834 RVA: 0x00518D54 File Offset: 0x00516F54
		private static IEnumerator StarLevelUpTopRankEquipments(int ssrMaterialEquipmentId, int srMaterialEquipmentId)
		{
			IConfigDataLoader cfg = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext pc = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<BagItemBase> bagItems = pc.GetBagItems();
			if (bagItems.Count == 0)
			{
				yield break;
			}
			List<BagItemBase> topRankEquipments = bagItems.FindAll(delegate(BagItemBase i)
			{
				if (i.GoodsTypeId != GoodsType.GoodsType_Equipment)
				{
					return false;
				}
				EquipmentBagItem equipmentBagItem2 = (EquipmentBagItem)i;
				return equipmentBagItem2 != null && (equipmentBagItem2.EquipmentInfo.Rank >= 3 && equipmentBagItem2.ContentId != ssrMaterialEquipmentId && equipmentBagItem2.ContentId != srMaterialEquipmentId && equipmentBagItem2.StarLevel < cfg.ConfigableConstId_HeroStarLevelMax) && TestUIController.IsEquipismentMaxLevel(equipmentBagItem2);
			});
			int ssrCount = 0;
			int srCount = 0;
			foreach (BagItemBase bagItemBase in topRankEquipments)
			{
				EquipmentBagItem equipmentBagItem = (EquipmentBagItem)bagItemBase;
				if (equipmentBagItem.EquipmentInfo.Rank >= 4)
				{
					ssrCount++;
				}
				else if (equipmentBagItem.EquipmentInfo.Rank == 3)
				{
					srCount++;
				}
			}
			yield return TestUIController.SendGMCommand(string.Format("ADD_ITEM 7,{0},{1};7,{2},{3};", new object[]
			{
				ssrMaterialEquipmentId,
				ssrCount,
				srMaterialEquipmentId,
				srCount
			}));
			bagItems = pc.GetBagItems();
			List<BagItemBase> ssrMaterials = bagItems.FindAll(delegate(BagItemBase i)
			{
				if (i.GoodsTypeId != GoodsType.GoodsType_Equipment)
				{
					return false;
				}
				EquipmentBagItem equipmentBagItem2 = (EquipmentBagItem)i;
				return equipmentBagItem2 != null && equipmentBagItem2.ContentId == ssrMaterialEquipmentId;
			});
			List<BagItemBase> srMaterials = bagItems.FindAll(delegate(BagItemBase i)
			{
				if (i.GoodsTypeId != GoodsType.GoodsType_Equipment)
				{
					return false;
				}
				EquipmentBagItem equipmentBagItem2 = (EquipmentBagItem)i;
				return equipmentBagItem2 != null && equipmentBagItem2.ContentId == srMaterialEquipmentId;
			});
			foreach (BagItemBase j in topRankEquipments)
			{
				EquipmentBagItem e = (EquipmentBagItem)j;
				if (e.EquipmentInfo.Rank >= 4)
				{
					if (ssrMaterials.Count == 0)
					{
						global::Debug.LogError("TestUIController.EnhanceAllTopRankEquipments Error: not enough material.");
						break;
					}
					yield return TestUIController.AddItem4StarLevelUpEquipment(e.InstanceId);
					yield return TestUIController.StarLevelUpEquipment(e.InstanceId, ssrMaterials[0].InstanceId);
					ssrMaterials.RemoveRange(0, 1);
				}
				else if (e.EquipmentInfo.Rank == 3)
				{
					if (srMaterials.Count == 0)
					{
						global::Debug.LogError("TestUIController.EnhanceAllTopRankEquipments Error: not enough material.");
						break;
					}
					yield return TestUIController.AddItem4StarLevelUpEquipment(e.InstanceId);
					yield return TestUIController.StarLevelUpEquipment(e.InstanceId, srMaterials[0].InstanceId);
					srMaterials.RemoveRange(0, 1);
				}
			}
			yield break;
		}

		// Token: 0x06013FAB RID: 81835 RVA: 0x00518D78 File Offset: 0x00516F78
		private static IEnumerator AddItem4StarLevelUpEquipment(ulong instanceId)
		{
			ProjectLPlayerContext pc = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			EquipmentBagItem e = pc.GetBagItemByInstanceId(instanceId) as EquipmentBagItem;
			List<Goods>[] materials = new List<Goods>[]
			{
				e.EquipmentInfo.LevelUpGoods1,
				e.EquipmentInfo.LevelUpGoods2,
				e.EquipmentInfo.LevelUpGoods3,
				e.EquipmentInfo.LevelUpGoods4,
				e.EquipmentInfo.LevelUpGoods5
			};
			if (e.StarLevel > materials.Length)
			{
				yield break;
			}
			yield return TestUIController.AddGoods(materials[e.StarLevel - 1]);
			yield break;
		}

		// Token: 0x06013FAC RID: 81836 RVA: 0x00518D94 File Offset: 0x00516F94
		private static IEnumerator AddGoods(List<Goods> goods)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ADD_ITEM ");
			foreach (Goods goods2 in goods)
			{
				sb.Append(string.Format("{0},{1},{2};", (int)goods2.GoodsType, goods2.Id, goods2.Count));
			}
			yield return TestUIController.SendGMCommand(sb.ToString());
			yield break;
		}

		// Token: 0x06013FAD RID: 81837 RVA: 0x00518DB0 File Offset: 0x00516FB0
		private static IEnumerator StarLevelUpEquipment(ulong instanceId, ulong materialId)
		{
			EquipmentStarLevelUpNetTask netTask = new EquipmentStarLevelUpNetTask(instanceId, materialId);
			netTask.EventOnStop += delegate(Task task)
			{
				EquipmentStarLevelUpNetTask equipmentStarLevelUpNetTask = task as EquipmentStarLevelUpNetTask;
				if (equipmentStarLevelUpNetTask.Result != 0)
				{
					global::Debug.LogError(string.Format("EquipmentStarLevelUpNetTask failed. {0}", TestUIController.ErrorCodeToMessage(equipmentStarLevelUpNetTask.Result)));
				}
			};
			netTask.Start(null);
			yield return new WaitUntil(() => netTask.State != Task.TaskState.Running);
			yield break;
		}

		// Token: 0x06013FAE RID: 81838 RVA: 0x00518DD4 File Offset: 0x00516FD4
		private static IEnumerator EnhanceAllTopRankEquipments(int targetLevel)
		{
			ProjectLPlayerContext pc = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<BagItemBase> bagItems = pc.GetBagItems();
			if (bagItems.Count == 0)
			{
				yield break;
			}
			List<BagItemBase> topRankEquipments = bagItems.FindAll(delegate(BagItemBase i)
			{
				if (i.GoodsTypeId != GoodsType.GoodsType_Equipment)
				{
					return false;
				}
				EquipmentBagItem equipmentBagItem = (EquipmentBagItem)i;
				return equipmentBagItem != null && (equipmentBagItem.EquipmentInfo.Rank >= 3 && equipmentBagItem.Level < targetLevel && equipmentBagItem.EquipmentInfo.EquipmentType != EquipmentType.EquipmentType_Enhancement && equipmentBagItem.EquipmentInfo.EquipmentType != EquipmentType.EquipmentType_LevelUpStar) && !TestUIController.IsEquipismentMaxLevel(equipmentBagItem);
			});
			foreach (BagItemBase j in topRankEquipments)
			{
				EquipmentBagItem e = (EquipmentBagItem)j;
				yield return TestUIController.TenLevelUpEquipment(e.InstanceId, null);
			}
			yield break;
		}

		// Token: 0x06013FAF RID: 81839 RVA: 0x00518DF0 File Offset: 0x00516FF0
		private static IEnumerator EnhanceEquipment(ulong instanceId, List<ulong> materialIds)
		{
			EquipmentEnhanceNetTask netTask = new EquipmentEnhanceNetTask(instanceId, materialIds);
			netTask.EventOnStop += delegate(Task task)
			{
				EquipmentEnhanceNetTask equipmentEnhanceNetTask = task as EquipmentEnhanceNetTask;
				if (equipmentEnhanceNetTask.Result != 0)
				{
					global::Debug.LogError(string.Format("EquipmentEnhanceNetTask failed. {0}", TestUIController.ErrorCodeToMessage(equipmentEnhanceNetTask.Result)));
				}
			};
			netTask.Start(null);
			yield return new WaitUntil(() => netTask.State != Task.TaskState.Running);
			yield break;
		}

		// Token: 0x06013FB0 RID: 81840 RVA: 0x00518E14 File Offset: 0x00517014
		private static IEnumerator AddAllTopRankEquipments()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			List<KeyValuePair<int, ConfigDataEquipmentInfo>> infos = new List<KeyValuePair<int, ConfigDataEquipmentInfo>>(configDataLoader.GetAllConfigDataEquipmentInfo());
			if (infos.Count == 0)
			{
				yield break;
			}
			StringBuilder sb = new StringBuilder();
			sb.Append("ADD_ITEM ");
			sb.Append(string.Format("7,{0},1", infos[0].Value.ID));
			ProjectLPlayerContext pc = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			for (int i = 1; i < infos.Count; i++)
			{
				if (infos[i].Value.Rank >= 3)
				{
					if (pc.GetBagItemCountByTypeAndID(GoodsType.GoodsType_Equipment, infos[i].Value.ID) <= 0)
					{
						sb.Append(string.Format(";7,{0},1", infos[i].Value.ID));
					}
				}
			}
			yield return TestUIController.SendGMCommand(sb.ToString());
			yield break;
		}

		// Token: 0x06013FB1 RID: 81841 RVA: 0x00518E28 File Offset: 0x00517028
		private static IEnumerator AddAllHeros()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			List<int> heros = new List<int>();
			foreach (KeyValuePair<int, ConfigDataHeroInfo> keyValuePair in configDataLoader.GetAllConfigDataHeroInfo())
			{
				if (keyValuePair.Value.ID <= 150)
				{
					heros.Add(keyValuePair.Value.ID);
				}
			}
			yield return TestUIController.AddHero(heros);
			yield break;
		}

		// Token: 0x06013FB2 RID: 81842 RVA: 0x00518E3C File Offset: 0x0051703C
		private static IEnumerator AddHero(List<int> heros)
		{
			if (heros.Count == 0)
			{
				yield break;
			}
			StringBuilder sb = new StringBuilder();
			sb.Append("ADD_HERO ");
			sb.Append(heros[0].ToString());
			for (int i = 1; i < heros.Count; i++)
			{
				sb.AppendFormat(",{0}", heros[i]);
			}
			yield return TestUIController.SendGMCommand(sb.ToString());
			yield break;
		}

		// Token: 0x06013FB3 RID: 81843 RVA: 0x00518E58 File Offset: 0x00517058
		private static IEnumerator HeroBreak(int id)
		{
			HeroStarLevelUpNetTask netTask = new HeroStarLevelUpNetTask(id);
			netTask.EventOnStop += delegate(Task task)
			{
				HeroStarLevelUpNetTask heroStarLevelUpNetTask = task as HeroStarLevelUpNetTask;
				if (heroStarLevelUpNetTask.Result != 0)
				{
					global::Debug.LogError(string.Format("HeroStarLevelUpNetTask failed. {0}", TestUIController.ErrorCodeToMessage(heroStarLevelUpNetTask.Result)));
				}
			};
			netTask.Start(null);
			yield return new WaitUntil(() => netTask.State != Task.TaskState.Running);
			yield break;
		}

		// Token: 0x06013FB4 RID: 81844 RVA: 0x00518E74 File Offset: 0x00517074
		private static IEnumerator BuyFixedStoreItem(int fixedStoreID, int fixedStoreItemGoodsID, int count)
		{
			for (int i = 0; i < count; i++)
			{
				yield return TestUIController.BuyFixedStoreItem(fixedStoreID, fixedStoreItemGoodsID);
			}
			yield break;
		}

		// Token: 0x06013FB5 RID: 81845 RVA: 0x00518EA0 File Offset: 0x005170A0
		private static IEnumerator BuyFixedStoreItem(int fixedStoreID, int fixedStoreItemGoodsID)
		{
			FixedStoreBuyStoreItemNetTask netTask = new FixedStoreBuyStoreItemNetTask(fixedStoreID, fixedStoreItemGoodsID, -1);
			netTask.EventOnStop += delegate(Task task)
			{
				FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask = task as FixedStoreBuyStoreItemNetTask;
				if (fixedStoreBuyStoreItemNetTask.Result != 0)
				{
					global::Debug.LogError(string.Format("FixedStoreBuyStoreItemNetTask failed. {0}", TestUIController.ErrorCodeToMessage(fixedStoreBuyStoreItemNetTask.Result)));
				}
			};
			netTask.Start(null);
			yield return new WaitUntil(() => netTask.State != Task.TaskState.Running);
			yield break;
		}

		// Token: 0x06013FB6 RID: 81846 RVA: 0x00518EC4 File Offset: 0x005170C4
		private static IEnumerator TransferHeroJob(int heroId, int jobConnectionId)
		{
			yield return TestUIController.SendGMCommand("ADD_ITEM 6,3009,1");
			HeroJobTransferNetTask netTask = new HeroJobTransferNetTask(heroId, jobConnectionId);
			netTask.EventOnStop += delegate(Task task)
			{
				HeroJobTransferNetTask heroJobTransferNetTask = task as HeroJobTransferNetTask;
				if (heroJobTransferNetTask.Result != 0)
				{
					global::Debug.LogError(string.Format("HeroJobLevelUpNetTask failed. {0}", TestUIController.ErrorCodeToMessage(heroJobTransferNetTask.Result)));
				}
			};
			netTask.Start(null);
			yield return new WaitUntil(() => netTask.State != Task.TaskState.Running);
			yield break;
		}

		// Token: 0x06013FB7 RID: 81847 RVA: 0x00518EE8 File Offset: 0x005170E8
		private static IEnumerator AddAllItem(int count)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string cmd = "ADD_ITEM ";
			foreach (KeyValuePair<int, ConfigDataItemInfo> keyValuePair in configDataLoader.GetAllConfigDataItemInfo())
			{
				string text = cmd;
				cmd = string.Concat(new object[]
				{
					text,
					6,
					",",
					keyValuePair.Value.ID,
					",",
					count.ToString(),
					";"
				});
			}
			foreach (KeyValuePair<int, ConfigDataJobMaterialInfo> keyValuePair2 in configDataLoader.GetAllConfigDataJobMaterialInfo())
			{
				string text = cmd;
				cmd = string.Concat(new object[]
				{
					text,
					5,
					",",
					keyValuePair2.Value.ID,
					",",
					count.ToString(),
					";"
				});
			}
			foreach (KeyValuePair<int, ConfigDataEnchantStoneInfo> keyValuePair3 in configDataLoader.GetAllConfigDataEnchantStoneInfo())
			{
				string text = cmd;
				cmd = string.Concat(new object[]
				{
					text,
					13,
					",",
					keyValuePair3.Value.ID,
					",",
					count.ToString(),
					";"
				});
			}
			yield return TestUIController.SendGMCommand(cmd);
			yield break;
		}

		// Token: 0x06013FB8 RID: 81848 RVA: 0x00518F04 File Offset: 0x00517104
		private static IEnumerator UpgradeHeroJobLevel(Hero hero, int jobConnectionId)
		{
			ConfigDataJobLevelInfo jobLevelInfo = hero.GetActiveJob().JobConnectionInfo.m_jobLevelInfos[hero.GetActiveJob().JobLevel];
			yield return TestUIController.AddGoods(jobLevelInfo.Materials);
			HeroJobLevelUpNetTask netTask = new HeroJobLevelUpNetTask(hero.HeroId, jobConnectionId);
			netTask.EventOnStop += delegate(Task task)
			{
				HeroJobLevelUpNetTask heroJobLevelUpNetTask = task as HeroJobLevelUpNetTask;
				if (heroJobLevelUpNetTask.Result != 0)
				{
					global::Debug.LogError(string.Format("HeroJobLevelUpNetTask {0}_{1} failed. {2}", hero.HeroInfo.Name, jobConnectionId, TestUIController.ErrorCodeToMessage(heroJobLevelUpNetTask.Result)));
				}
			};
			netTask.Start(null);
			yield return new WaitUntil(() => netTask.State != Task.TaskState.Running);
			yield break;
		}

		// Token: 0x06013FB9 RID: 81849 RVA: 0x00518F28 File Offset: 0x00517128
		private static IEnumerator SendGMCommand(string cmd)
		{
			if (!LoginUITask.IsGMUser)
			{
				yield break;
			}
			if (string.IsNullOrEmpty(cmd))
			{
				yield break;
			}
			GmCommandNetTask netTask = new GmCommandNetTask(cmd);
			netTask.EventOnStop += delegate(Task task)
			{
				GmCommandNetTask gmCommandNetTask = task as GmCommandNetTask;
				if (gmCommandNetTask.Result != 0)
				{
					global::Debug.LogError(string.Format("GmCommandNetTask failed. {0}, {1}", TestUIController.ErrorCodeToMessage(gmCommandNetTask.Result), cmd));
				}
			};
			netTask.Start(null);
			yield return new WaitUntil(() => netTask.State != Task.TaskState.Running);
			yield break;
		}

		// Token: 0x06013FBA RID: 81850 RVA: 0x00518F44 File Offset: 0x00517144
		private static IEnumerator UseItem(GoodsType type, int id, int count)
		{
			BagItemUseNetTask netTask = new BagItemUseNetTask(type, id, count);
			netTask.EventOnStop += delegate(Task task)
			{
				BagItemUseNetTask bagItemUseNetTask = task as BagItemUseNetTask;
				if (bagItemUseNetTask.Result != 0)
				{
					global::Debug.LogError(string.Format("BagItemUseNetTask failed. {0}", TestUIController.ErrorCodeToMessage(bagItemUseNetTask.Result)));
				}
			};
			netTask.Start(null);
			yield return new WaitUntil(() => netTask.State != Task.TaskState.Running);
			yield break;
		}

		// Token: 0x06013FBB RID: 81851 RVA: 0x00518F70 File Offset: 0x00517170
		private static IEnumerator AddHeroExp(int heroId, GoodsType itemType, int itemID, int count)
		{
			HeroAddExpNetTask netTask = new HeroAddExpNetTask(heroId, itemType, itemID, count);
			netTask.EventOnStop += delegate(Task task)
			{
				HeroAddExpNetTask heroAddExpNetTask = task as HeroAddExpNetTask;
				if (heroAddExpNetTask.Result != 0)
				{
					global::Debug.LogError(string.Format("HeroAddExpNetTask failed. {0}", TestUIController.ErrorCodeToMessage(heroAddExpNetTask.Result)));
				}
			};
			netTask.Start(null);
			yield return new WaitUntil(() => netTask.State != Task.TaskState.Running);
			yield break;
		}

		// Token: 0x06013FBC RID: 81852 RVA: 0x00518FA0 File Offset: 0x005171A0
		private static string ErrorCodeToMessage(int code)
		{
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			string text = clientConfigDataLoader.UtilityGetErrorCodeString(code);
			if (text == null)
			{
				return string.Empty;
			}
			return text;
		}

		// Token: 0x06013FBD RID: 81853 RVA: 0x00518FD4 File Offset: 0x005171D4
		private void OnCompleteUserGuideButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnCompleteUserGuideButtonClick_hotfix != null)
			{
				this.m_OnCompleteUserGuideButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnCompleteUserGuide != null)
			{
				this.EventOnCompleteUserGuide();
			}
		}

		// Token: 0x06013FBE RID: 81854 RVA: 0x0051904C File Offset: 0x0051724C
		private void OnClearStageButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClearStageButtonClick_hotfix != null)
			{
				this.m_OnClearStageButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClearStage != null)
			{
				this.EventOnClearStage();
			}
		}

		// Token: 0x06013FBF RID: 81855 RVA: 0x005190C4 File Offset: 0x005172C4
		private void OnSystemInfoBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSystemInfoBackgroundButtonClick_hotfix != null)
			{
				this.m_OnSystemInfoBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnCloseSystemInfo != null)
			{
				this.EventOnCloseSystemInfo();
			}
		}

		// Token: 0x14000465 RID: 1125
		// (add) Token: 0x06013FC0 RID: 81856 RVA: 0x0051913C File Offset: 0x0051733C
		// (remove) Token: 0x06013FC1 RID: 81857 RVA: 0x005191D8 File Offset: 0x005173D8
		public event Action<TestListType> EventOnChangeTestList
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnChangeTestListAction`1_hotfix != null)
				{
					this.m_add_EventOnChangeTestListAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TestListType> action = this.EventOnChangeTestList;
				Action<TestListType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TestListType>>(ref this.EventOnChangeTestList, (Action<TestListType>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnChangeTestListAction`1_hotfix != null)
				{
					this.m_remove_EventOnChangeTestListAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TestListType> action = this.EventOnChangeTestList;
				Action<TestListType> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TestListType>>(ref this.EventOnChangeTestList, (Action<TestListType>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000466 RID: 1126
		// (add) Token: 0x06013FC2 RID: 81858 RVA: 0x00519274 File Offset: 0x00517474
		// (remove) Token: 0x06013FC3 RID: 81859 RVA: 0x00519310 File Offset: 0x00517510
		public event Action<int> EventOnStartTest
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartTestAction`1_hotfix != null)
				{
					this.m_add_EventOnStartTestAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnStartTest;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnStartTest, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartTestAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartTestAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnStartTest;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnStartTest, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000467 RID: 1127
		// (add) Token: 0x06013FC4 RID: 81860 RVA: 0x005193AC File Offset: 0x005175AC
		// (remove) Token: 0x06013FC5 RID: 81861 RVA: 0x00519448 File Offset: 0x00517648
		public event Action EventOnShowSystemInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowSystemInfoAction_hotfix != null)
				{
					this.m_add_EventOnShowSystemInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowSystemInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowSystemInfo, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowSystemInfoAction_hotfix != null)
				{
					this.m_remove_EventOnShowSystemInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowSystemInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowSystemInfo, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000468 RID: 1128
		// (add) Token: 0x06013FC6 RID: 81862 RVA: 0x005194E4 File Offset: 0x005176E4
		// (remove) Token: 0x06013FC7 RID: 81863 RVA: 0x00519580 File Offset: 0x00517780
		public event Action EventOnCloseSystemInfo
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseSystemInfoAction_hotfix != null)
				{
					this.m_add_EventOnCloseSystemInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseSystemInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseSystemInfo, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseSystemInfoAction_hotfix != null)
				{
					this.m_remove_EventOnCloseSystemInfoAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCloseSystemInfo;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCloseSystemInfo, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000469 RID: 1129
		// (add) Token: 0x06013FC8 RID: 81864 RVA: 0x0051961C File Offset: 0x0051781C
		// (remove) Token: 0x06013FC9 RID: 81865 RVA: 0x005196B8 File Offset: 0x005178B8
		public event Action EventOnShowGoddessDialog
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowGoddessDialogAction_hotfix != null)
				{
					this.m_add_EventOnShowGoddessDialogAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowGoddessDialog;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowGoddessDialog, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowGoddessDialogAction_hotfix != null)
				{
					this.m_remove_EventOnShowGoddessDialogAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnShowGoddessDialog;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnShowGoddessDialog, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400046A RID: 1130
		// (add) Token: 0x06013FCA RID: 81866 RVA: 0x00519754 File Offset: 0x00517954
		// (remove) Token: 0x06013FCB RID: 81867 RVA: 0x005197F0 File Offset: 0x005179F0
		public event Action EventOnClearUserGuide
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClearUserGuideAction_hotfix != null)
				{
					this.m_add_EventOnClearUserGuideAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClearUserGuide;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClearUserGuide, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClearUserGuideAction_hotfix != null)
				{
					this.m_remove_EventOnClearUserGuideAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClearUserGuide;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClearUserGuide, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400046B RID: 1131
		// (add) Token: 0x06013FCC RID: 81868 RVA: 0x0051988C File Offset: 0x00517A8C
		// (remove) Token: 0x06013FCD RID: 81869 RVA: 0x00519928 File Offset: 0x00517B28
		public event Action EventOnCompleteUserGuide
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCompleteUserGuideAction_hotfix != null)
				{
					this.m_add_EventOnCompleteUserGuideAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCompleteUserGuide;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCompleteUserGuide, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCompleteUserGuideAction_hotfix != null)
				{
					this.m_remove_EventOnCompleteUserGuideAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnCompleteUserGuide;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnCompleteUserGuide, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400046C RID: 1132
		// (add) Token: 0x06013FCE RID: 81870 RVA: 0x005199C4 File Offset: 0x00517BC4
		// (remove) Token: 0x06013FCF RID: 81871 RVA: 0x00519A60 File Offset: 0x00517C60
		public event Action EventOnClearStage
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClearStageAction_hotfix != null)
				{
					this.m_add_EventOnClearStageAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClearStage;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClearStage, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClearStageAction_hotfix != null)
				{
					this.m_remove_EventOnClearStageAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClearStage;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClearStage, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400046D RID: 1133
		// (add) Token: 0x06013FD0 RID: 81872 RVA: 0x00519AFC File Offset: 0x00517CFC
		// (remove) Token: 0x06013FD1 RID: 81873 RVA: 0x00519B98 File Offset: 0x00517D98
		public event Action EventOnReturn
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReturnAction_hotfix != null)
				{
					this.m_add_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReturnAction_hotfix != null)
				{
					this.m_remove_EventOnReturnAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnReturn;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnReturn, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400046E RID: 1134
		// (add) Token: 0x06013FD2 RID: 81874 RVA: 0x00519C34 File Offset: 0x00517E34
		// (remove) Token: 0x06013FD3 RID: 81875 RVA: 0x00519CD0 File Offset: 0x00517ED0
		public event Action<string, double> EventOnReportBug
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnReportBugAction`2_hotfix != null)
				{
					this.m_add_EventOnReportBugAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, double> action = this.EventOnReportBug;
				Action<string, double> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, double>>(ref this.EventOnReportBug, (Action<string, double>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnReportBugAction`2_hotfix != null)
				{
					this.m_remove_EventOnReportBugAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<string, double> action = this.EventOnReportBug;
				Action<string, double> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<string, double>>(ref this.EventOnReportBug, (Action<string, double>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x06013FD4 RID: 81876 RVA: 0x00519D6C File Offset: 0x00517F6C
		// (set) Token: 0x06013FD5 RID: 81877 RVA: 0x00519D8C File Offset: 0x00517F8C
		[DoNotToLua]
		public new TestUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TestUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013FD6 RID: 81878 RVA: 0x00519D98 File Offset: 0x00517F98
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013FD7 RID: 81879 RVA: 0x00519DA4 File Offset: 0x00517FA4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013FD8 RID: 81880 RVA: 0x00519DAC File Offset: 0x00517FAC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013FD9 RID: 81881 RVA: 0x00519DB4 File Offset: 0x00517FB4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013FDA RID: 81882 RVA: 0x00519DC8 File Offset: 0x00517FC8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013FDB RID: 81883 RVA: 0x00519DD0 File Offset: 0x00517FD0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06013FDC RID: 81884 RVA: 0x00519DDC File Offset: 0x00517FDC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06013FDD RID: 81885 RVA: 0x00519DE8 File Offset: 0x00517FE8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06013FDE RID: 81886 RVA: 0x00519DF4 File Offset: 0x00517FF4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06013FDF RID: 81887 RVA: 0x00519E00 File Offset: 0x00518000
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06013FE0 RID: 81888 RVA: 0x00519E0C File Offset: 0x0051800C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06013FE1 RID: 81889 RVA: 0x00519E18 File Offset: 0x00518018
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013FE2 RID: 81890 RVA: 0x00519E24 File Offset: 0x00518024
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013FE3 RID: 81891 RVA: 0x00519E30 File Offset: 0x00518030
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013FE4 RID: 81892 RVA: 0x00519E3C File Offset: 0x0051803C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013FE5 RID: 81893 RVA: 0x00519E44 File Offset: 0x00518044
		private void __callDele_EventOnChangeTestList(TestListType obj)
		{
			Action<TestListType> eventOnChangeTestList = this.EventOnChangeTestList;
			if (eventOnChangeTestList != null)
			{
				eventOnChangeTestList(obj);
			}
		}

		// Token: 0x06013FE6 RID: 81894 RVA: 0x00519E68 File Offset: 0x00518068
		private void __clearDele_EventOnChangeTestList(TestListType obj)
		{
			this.EventOnChangeTestList = null;
		}

		// Token: 0x06013FE7 RID: 81895 RVA: 0x00519E74 File Offset: 0x00518074
		private void __callDele_EventOnStartTest(int obj)
		{
			Action<int> eventOnStartTest = this.EventOnStartTest;
			if (eventOnStartTest != null)
			{
				eventOnStartTest(obj);
			}
		}

		// Token: 0x06013FE8 RID: 81896 RVA: 0x00519E98 File Offset: 0x00518098
		private void __clearDele_EventOnStartTest(int obj)
		{
			this.EventOnStartTest = null;
		}

		// Token: 0x06013FE9 RID: 81897 RVA: 0x00519EA4 File Offset: 0x005180A4
		private void __callDele_EventOnShowSystemInfo()
		{
			Action eventOnShowSystemInfo = this.EventOnShowSystemInfo;
			if (eventOnShowSystemInfo != null)
			{
				eventOnShowSystemInfo();
			}
		}

		// Token: 0x06013FEA RID: 81898 RVA: 0x00519EC4 File Offset: 0x005180C4
		private void __clearDele_EventOnShowSystemInfo()
		{
			this.EventOnShowSystemInfo = null;
		}

		// Token: 0x06013FEB RID: 81899 RVA: 0x00519ED0 File Offset: 0x005180D0
		private void __callDele_EventOnCloseSystemInfo()
		{
			Action eventOnCloseSystemInfo = this.EventOnCloseSystemInfo;
			if (eventOnCloseSystemInfo != null)
			{
				eventOnCloseSystemInfo();
			}
		}

		// Token: 0x06013FEC RID: 81900 RVA: 0x00519EF0 File Offset: 0x005180F0
		private void __clearDele_EventOnCloseSystemInfo()
		{
			this.EventOnCloseSystemInfo = null;
		}

		// Token: 0x06013FED RID: 81901 RVA: 0x00519EFC File Offset: 0x005180FC
		private void __callDele_EventOnShowGoddessDialog()
		{
			Action eventOnShowGoddessDialog = this.EventOnShowGoddessDialog;
			if (eventOnShowGoddessDialog != null)
			{
				eventOnShowGoddessDialog();
			}
		}

		// Token: 0x06013FEE RID: 81902 RVA: 0x00519F1C File Offset: 0x0051811C
		private void __clearDele_EventOnShowGoddessDialog()
		{
			this.EventOnShowGoddessDialog = null;
		}

		// Token: 0x06013FEF RID: 81903 RVA: 0x00519F28 File Offset: 0x00518128
		private void __callDele_EventOnClearUserGuide()
		{
			Action eventOnClearUserGuide = this.EventOnClearUserGuide;
			if (eventOnClearUserGuide != null)
			{
				eventOnClearUserGuide();
			}
		}

		// Token: 0x06013FF0 RID: 81904 RVA: 0x00519F48 File Offset: 0x00518148
		private void __clearDele_EventOnClearUserGuide()
		{
			this.EventOnClearUserGuide = null;
		}

		// Token: 0x06013FF1 RID: 81905 RVA: 0x00519F54 File Offset: 0x00518154
		private void __callDele_EventOnCompleteUserGuide()
		{
			Action eventOnCompleteUserGuide = this.EventOnCompleteUserGuide;
			if (eventOnCompleteUserGuide != null)
			{
				eventOnCompleteUserGuide();
			}
		}

		// Token: 0x06013FF2 RID: 81906 RVA: 0x00519F74 File Offset: 0x00518174
		private void __clearDele_EventOnCompleteUserGuide()
		{
			this.EventOnCompleteUserGuide = null;
		}

		// Token: 0x06013FF3 RID: 81907 RVA: 0x00519F80 File Offset: 0x00518180
		private void __callDele_EventOnClearStage()
		{
			Action eventOnClearStage = this.EventOnClearStage;
			if (eventOnClearStage != null)
			{
				eventOnClearStage();
			}
		}

		// Token: 0x06013FF4 RID: 81908 RVA: 0x00519FA0 File Offset: 0x005181A0
		private void __clearDele_EventOnClearStage()
		{
			this.EventOnClearStage = null;
		}

		// Token: 0x06013FF5 RID: 81909 RVA: 0x00519FAC File Offset: 0x005181AC
		private void __callDele_EventOnReturn()
		{
			Action eventOnReturn = this.EventOnReturn;
			if (eventOnReturn != null)
			{
				eventOnReturn();
			}
		}

		// Token: 0x06013FF6 RID: 81910 RVA: 0x00519FCC File Offset: 0x005181CC
		private void __clearDele_EventOnReturn()
		{
			this.EventOnReturn = null;
		}

		// Token: 0x06013FF7 RID: 81911 RVA: 0x00519FD8 File Offset: 0x005181D8
		private void __callDele_EventOnReportBug(string arg1, double arg2)
		{
			Action<string, double> eventOnReportBug = this.EventOnReportBug;
			if (eventOnReportBug != null)
			{
				eventOnReportBug(arg1, arg2);
			}
		}

		// Token: 0x06013FF8 RID: 81912 RVA: 0x00519FFC File Offset: 0x005181FC
		private void __clearDele_EventOnReportBug(string arg1, double arg2)
		{
			this.EventOnReportBug = null;
		}

		// Token: 0x06013FF9 RID: 81913 RVA: 0x0051A008 File Offset: 0x00518208
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
					this.m_SetTestListTypeTestListType_hotfix = (luaObj.RawGet("SetTestListType") as LuaFunction);
					this.m_AddTestListItemInt32String_hotfix = (luaObj.RawGet("AddTestListItem") as LuaFunction);
					this.m_ClearTestList_hotfix = (luaObj.RawGet("ClearTestList") as LuaFunction);
					this.m_GetSelectedTestListItemUIController_hotfix = (luaObj.RawGet("GetSelectedTestListItemUIController") as LuaFunction);
					this.m_SetMonsterLevelInt32_hotfix = (luaObj.RawGet("SetMonsterLevel") as LuaFunction);
					this.m_GetMonsterLevel_hotfix = (luaObj.RawGet("GetMonsterLevel") as LuaFunction);
					this.m_SetServerDataTimeDateTime_hotfix = (luaObj.RawGet("SetServerDataTime") as LuaFunction);
					this.m_ShowSystemInfo_hotfix = (luaObj.RawGet("ShowSystemInfo") as LuaFunction);
					this.m_HideSystemInfo_hotfix = (luaObj.RawGet("HideSystemInfo") as LuaFunction);
					this.m_InitLoopScrollViewRect_hotfix = (luaObj.RawGet("InitLoopScrollViewRect") as LuaFunction);
					this.m_RefreshLoopVerticalScrollViewTestListType_hotfix = (luaObj.RawGet("RefreshLoopVerticalScrollView") as LuaFunction);
					this.m_OnTestItemFillUIControllerBase_hotfix = (luaObj.RawGet("OnTestItemFill") as LuaFunction);
					this.m_OnTestItemClickUIControllerBase_hotfix = (luaObj.RawGet("OnTestItemClick") as LuaFunction);
					this.m_DoToggleBooleanTestListType_hotfix = (luaObj.RawGet("DoToggle") as LuaFunction);
					this.m_OnBattleToggleBoolean_hotfix = (luaObj.RawGet("OnBattleToggle") as LuaFunction);
					this.m_OnDialogToggleBoolean_hotfix = (luaObj.RawGet("OnDialogToggle") as LuaFunction);
					this.m_OnBattleDialogToggleBoolean_hotfix = (luaObj.RawGet("OnBattleDialogToggle") as LuaFunction);
					this.m_OnUserGuideDialogToggleBoolean_hotfix = (luaObj.RawGet("OnUserGuideDialogToggle") as LuaFunction);
					this.m_OnTestListHomeBtnClick_hotfix = (luaObj.RawGet("OnTestListHomeBtnClick") as LuaFunction);
					this.m_OnTestIdNextBtnClick_hotfix = (luaObj.RawGet("OnTestIdNextBtnClick") as LuaFunction);
					this.m_OnTestIdInputString_hotfix = (luaObj.RawGet("OnTestIdInput") as LuaFunction);
					this.m_OnStartTestButtonClick_hotfix = (luaObj.RawGet("OnStartTestButtonClick") as LuaFunction);
					this.m_OnReturnButtonClick_hotfix = (luaObj.RawGet("OnReturnButtonClick") as LuaFunction);
					this.m_OnSystemInfoButtonClick_hotfix = (luaObj.RawGet("OnSystemInfoButtonClick") as LuaFunction);
					this.m_OnGoddessDialogButtonClick_hotfix = (luaObj.RawGet("OnGoddessDialogButtonClick") as LuaFunction);
					this.m_OnClearUserGuideButtonClick_hotfix = (luaObj.RawGet("OnClearUserGuideButtonClick") as LuaFunction);
					this.m_OnBecomeStrongButtonClick_hotfix = (luaObj.RawGet("OnBecomeStrongButtonClick") as LuaFunction);
					this.m_OnFinishAllTasksButtonClick_hotfix = (luaObj.RawGet("OnFinishAllTasksButtonClick") as LuaFunction);
					this.m_FinishAllTasks_hotfix = (luaObj.RawGet("FinishAllTasks") as LuaFunction);
					this.m_OnCancelReportBugButtonClick_hotfix = (luaObj.RawGet("OnCancelReportBugButtonClick") as LuaFunction);
					this.m_OniPhoneXToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OniPhoneXToggleValueChanged") as LuaFunction);
					this.m_OnReportBugButtonClick_hotfix = (luaObj.RawGet("OnReportBugButtonClick") as LuaFunction);
					this.m_GetReportBugLogHours_hotfix = (luaObj.RawGet("GetReportBugLogHours") as LuaFunction);
					this.m_OnOpenReportBugPanelButtonClick_hotfix = (luaObj.RawGet("OnOpenReportBugPanelButtonClick") as LuaFunction);
					this.m_OnCompleteUserGuideButtonClick_hotfix = (luaObj.RawGet("OnCompleteUserGuideButtonClick") as LuaFunction);
					this.m_OnClearStageButtonClick_hotfix = (luaObj.RawGet("OnClearStageButtonClick") as LuaFunction);
					this.m_OnSystemInfoBackgroundButtonClick_hotfix = (luaObj.RawGet("OnSystemInfoBackgroundButtonClick") as LuaFunction);
					this.m_add_EventOnChangeTestListAction`1_hotfix = (luaObj.RawGet("add_EventOnChangeTestList") as LuaFunction);
					this.m_remove_EventOnChangeTestListAction`1_hotfix = (luaObj.RawGet("remove_EventOnChangeTestList") as LuaFunction);
					this.m_add_EventOnStartTestAction`1_hotfix = (luaObj.RawGet("add_EventOnStartTest") as LuaFunction);
					this.m_remove_EventOnStartTestAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartTest") as LuaFunction);
					this.m_add_EventOnShowSystemInfoAction_hotfix = (luaObj.RawGet("add_EventOnShowSystemInfo") as LuaFunction);
					this.m_remove_EventOnShowSystemInfoAction_hotfix = (luaObj.RawGet("remove_EventOnShowSystemInfo") as LuaFunction);
					this.m_add_EventOnCloseSystemInfoAction_hotfix = (luaObj.RawGet("add_EventOnCloseSystemInfo") as LuaFunction);
					this.m_remove_EventOnCloseSystemInfoAction_hotfix = (luaObj.RawGet("remove_EventOnCloseSystemInfo") as LuaFunction);
					this.m_add_EventOnShowGoddessDialogAction_hotfix = (luaObj.RawGet("add_EventOnShowGoddessDialog") as LuaFunction);
					this.m_remove_EventOnShowGoddessDialogAction_hotfix = (luaObj.RawGet("remove_EventOnShowGoddessDialog") as LuaFunction);
					this.m_add_EventOnClearUserGuideAction_hotfix = (luaObj.RawGet("add_EventOnClearUserGuide") as LuaFunction);
					this.m_remove_EventOnClearUserGuideAction_hotfix = (luaObj.RawGet("remove_EventOnClearUserGuide") as LuaFunction);
					this.m_add_EventOnCompleteUserGuideAction_hotfix = (luaObj.RawGet("add_EventOnCompleteUserGuide") as LuaFunction);
					this.m_remove_EventOnCompleteUserGuideAction_hotfix = (luaObj.RawGet("remove_EventOnCompleteUserGuide") as LuaFunction);
					this.m_add_EventOnClearStageAction_hotfix = (luaObj.RawGet("add_EventOnClearStage") as LuaFunction);
					this.m_remove_EventOnClearStageAction_hotfix = (luaObj.RawGet("remove_EventOnClearStage") as LuaFunction);
					this.m_add_EventOnReturnAction_hotfix = (luaObj.RawGet("add_EventOnReturn") as LuaFunction);
					this.m_remove_EventOnReturnAction_hotfix = (luaObj.RawGet("remove_EventOnReturn") as LuaFunction);
					this.m_add_EventOnReportBugAction`2_hotfix = (luaObj.RawGet("add_EventOnReportBug") as LuaFunction);
					this.m_remove_EventOnReportBugAction`2_hotfix = (luaObj.RawGet("remove_EventOnReportBug") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013FFA RID: 81914 RVA: 0x0051A664 File Offset: 0x00518864
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TestUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B064 RID: 45156
		[AutoBind("./ReturnButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x0400B065 RID: 45157
		[AutoBind("./SystemInfoButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_systemInfoButton;

		// Token: 0x0400B066 RID: 45158
		[AutoBind("./GoddessDialogButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_goddessDialogButton;

		// Token: 0x0400B067 RID: 45159
		[AutoBind("./ClearUserGuideButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_clearUserGuideButton;

		// Token: 0x0400B068 RID: 45160
		[AutoBind("./CompleteUserGuideButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_completeUserGuideButton;

		// Token: 0x0400B069 RID: 45161
		[AutoBind("./BecomeStrongButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_becomeStrongButton;

		// Token: 0x0400B06A RID: 45162
		[AutoBind("./BecomeStrongPlayerLevelInput", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_becomeStrongPlayerLevelInput;

		// Token: 0x0400B06B RID: 45163
		[AutoBind("./BecomeStrongHeroStarLevelInput", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_becomeStrongHeroStarLevelInput;

		// Token: 0x0400B06C RID: 45164
		[AutoBind("./BecomeStrongEquipmentLevelInput", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_becomeStrongEquipmentLevelInput;

		// Token: 0x0400B06D RID: 45165
		[AutoBind("./ClearStageButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_clearStageButton;

		// Token: 0x0400B06E RID: 45166
		[AutoBind("./ReportBugButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_openReportBugPanelButton;

		// Token: 0x0400B06F RID: 45167
		[AutoBind("./iPhoneXToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_iPhoneXToggle;

		// Token: 0x0400B070 RID: 45168
		[AutoBind("./TestToggles/BattleToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_battleToggle;

		// Token: 0x0400B071 RID: 45169
		[AutoBind("./TestToggles/DialogToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_dialogToggle;

		// Token: 0x0400B072 RID: 45170
		[AutoBind("./TestToggles/BattleDialogToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_battleDialogToggle;

		// Token: 0x0400B073 RID: 45171
		[AutoBind("./TestToggles/UserGuideDialogToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_userGuideDialogToggle;

		// Token: 0x0400B074 RID: 45172
		[AutoBind("./TestList/LoopVerticalScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private EasyObjectPool m_ListItemPool;

		// Token: 0x0400B075 RID: 45173
		[AutoBind("./TestList/LoopVerticalScrollView", AutoBindAttribute.InitState.NotInit, false)]
		private LoopVerticalScrollRect m_LoopScroolRect;

		// Token: 0x0400B076 RID: 45174
		[AutoBind("./MonsterLevel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_monsterLevelGameObject;

		// Token: 0x0400B077 RID: 45175
		[AutoBind("./MonsterLevel/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_monsterLevelInputField;

		// Token: 0x0400B078 RID: 45176
		[AutoBind("./StartTestButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startTestBattleButton;

		// Token: 0x0400B079 RID: 45177
		[AutoBind("./TestId/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_TestIdInputField;

		// Token: 0x0400B07A RID: 45178
		[AutoBind("./TestId/Next", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_TestIdNextSearch;

		// Token: 0x0400B07B RID: 45179
		[AutoBind("./TestId/Home", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_TestListHomeBtn;

		// Token: 0x0400B07C RID: 45180
		[AutoBind("./SystemInfo", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_systemInfoGameObject;

		// Token: 0x0400B07D RID: 45181
		[AutoBind("./SystemInfo/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_systemInfoBackgroundButton;

		// Token: 0x0400B07E RID: 45182
		[AutoBind("./SystemInfo/ScrollView/Viewport/Content/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_systemInfoText;

		// Token: 0x0400B07F RID: 45183
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x0400B080 RID: 45184
		[AutoBind("./Prefabs/TestListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_testListItemPrefab;

		// Token: 0x0400B081 RID: 45185
		[AutoBind("./ServerDateTime", AutoBindAttribute.InitState.Active, false)]
		private Text m_serverDateTimeText;

		// Token: 0x0400B082 RID: 45186
		[AutoBind("./ReportBugPanel/BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeReportBugPanelButton;

		// Token: 0x0400B083 RID: 45187
		[AutoBind("./ReportBugPanel", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_reportBugPanelGameObject;

		// Token: 0x0400B084 RID: 45188
		[AutoBind("./ReportBugPanel/Panel/LogTime/Selection/OneHour", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_oneHourLogTime;

		// Token: 0x0400B085 RID: 45189
		[AutoBind("./ReportBugPanel/Panel/LogTime/Selection/OneDay", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_oneDayLogTime;

		// Token: 0x0400B086 RID: 45190
		[AutoBind("./ReportBugPanel/Panel/LogTime/Selection/OneWeek", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_oneWeekLogTime;

		// Token: 0x0400B087 RID: 45191
		[AutoBind("./ReportBugPanel/Panel/Description/InputField", AutoBindAttribute.InitState.NotInit, false)]
		private InputField m_bugDescriptionInputField;

		// Token: 0x0400B088 RID: 45192
		[AutoBind("./ReportBugPanel/Panel/ReportButtons/Cancel", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_cancelReportBugButton;

		// Token: 0x0400B089 RID: 45193
		[AutoBind("./ReportBugPanel/Panel/ReportButtons/Submit", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_reportBugButton;

		// Token: 0x0400B08A RID: 45194
		[AutoBind("./FinishAllTasksButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_finishAllTasksButton;

		// Token: 0x0400B08B RID: 45195
		private List<TestListItemUIController> m_testListItemUIControllers = new List<TestListItemUIController>();

		// Token: 0x0400B08C RID: 45196
		private bool m_isIgnoreToggleEvent;

		// Token: 0x0400B08D RID: 45197
		private List<KeyValuePair<int, string>> m_CacheTestList = new List<KeyValuePair<int, string>>();

		// Token: 0x0400B08E RID: 45198
		private TestListItemUIController m_CurrSelectCtrl;

		// Token: 0x0400B08F RID: 45199
		private int m_nSearchTestListId = -1;

		// Token: 0x0400B090 RID: 45200
		[DoNotToLua]
		private TestUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B091 RID: 45201
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B092 RID: 45202
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B093 RID: 45203
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B094 RID: 45204
		private LuaFunction m_SetTestListTypeTestListType_hotfix;

		// Token: 0x0400B095 RID: 45205
		private LuaFunction m_AddTestListItemInt32String_hotfix;

		// Token: 0x0400B096 RID: 45206
		private LuaFunction m_ClearTestList_hotfix;

		// Token: 0x0400B097 RID: 45207
		private LuaFunction m_GetSelectedTestListItemUIController_hotfix;

		// Token: 0x0400B098 RID: 45208
		private LuaFunction m_SetMonsterLevelInt32_hotfix;

		// Token: 0x0400B099 RID: 45209
		private LuaFunction m_GetMonsterLevel_hotfix;

		// Token: 0x0400B09A RID: 45210
		private LuaFunction m_SetServerDataTimeDateTime_hotfix;

		// Token: 0x0400B09B RID: 45211
		private LuaFunction m_ShowSystemInfo_hotfix;

		// Token: 0x0400B09C RID: 45212
		private LuaFunction m_HideSystemInfo_hotfix;

		// Token: 0x0400B09D RID: 45213
		private LuaFunction m_InitLoopScrollViewRect_hotfix;

		// Token: 0x0400B09E RID: 45214
		private LuaFunction m_RefreshLoopVerticalScrollViewTestListType_hotfix;

		// Token: 0x0400B09F RID: 45215
		private LuaFunction m_OnTestItemFillUIControllerBase_hotfix;

		// Token: 0x0400B0A0 RID: 45216
		private LuaFunction m_OnTestItemClickUIControllerBase_hotfix;

		// Token: 0x0400B0A1 RID: 45217
		private LuaFunction m_DoToggleBooleanTestListType_hotfix;

		// Token: 0x0400B0A2 RID: 45218
		private LuaFunction m_OnBattleToggleBoolean_hotfix;

		// Token: 0x0400B0A3 RID: 45219
		private LuaFunction m_OnDialogToggleBoolean_hotfix;

		// Token: 0x0400B0A4 RID: 45220
		private LuaFunction m_OnBattleDialogToggleBoolean_hotfix;

		// Token: 0x0400B0A5 RID: 45221
		private LuaFunction m_OnUserGuideDialogToggleBoolean_hotfix;

		// Token: 0x0400B0A6 RID: 45222
		private LuaFunction m_OnTestListHomeBtnClick_hotfix;

		// Token: 0x0400B0A7 RID: 45223
		private LuaFunction m_OnTestIdNextBtnClick_hotfix;

		// Token: 0x0400B0A8 RID: 45224
		private LuaFunction m_OnTestIdInputString_hotfix;

		// Token: 0x0400B0A9 RID: 45225
		private LuaFunction m_OnStartTestButtonClick_hotfix;

		// Token: 0x0400B0AA RID: 45226
		private LuaFunction m_OnReturnButtonClick_hotfix;

		// Token: 0x0400B0AB RID: 45227
		private LuaFunction m_OnSystemInfoButtonClick_hotfix;

		// Token: 0x0400B0AC RID: 45228
		private LuaFunction m_OnGoddessDialogButtonClick_hotfix;

		// Token: 0x0400B0AD RID: 45229
		private LuaFunction m_OnClearUserGuideButtonClick_hotfix;

		// Token: 0x0400B0AE RID: 45230
		private LuaFunction m_OnBecomeStrongButtonClick_hotfix;

		// Token: 0x0400B0AF RID: 45231
		private LuaFunction m_OnFinishAllTasksButtonClick_hotfix;

		// Token: 0x0400B0B0 RID: 45232
		private LuaFunction m_FinishAllTasks_hotfix;

		// Token: 0x0400B0B1 RID: 45233
		private LuaFunction m_OnCancelReportBugButtonClick_hotfix;

		// Token: 0x0400B0B2 RID: 45234
		private LuaFunction m_OniPhoneXToggleValueChangedBoolean_hotfix;

		// Token: 0x0400B0B3 RID: 45235
		private LuaFunction m_OnReportBugButtonClick_hotfix;

		// Token: 0x0400B0B4 RID: 45236
		private LuaFunction m_GetReportBugLogHours_hotfix;

		// Token: 0x0400B0B5 RID: 45237
		private LuaFunction m_OnOpenReportBugPanelButtonClick_hotfix;

		// Token: 0x0400B0B6 RID: 45238
		private LuaFunction m_OnCompleteUserGuideButtonClick_hotfix;

		// Token: 0x0400B0B7 RID: 45239
		private LuaFunction m_OnClearStageButtonClick_hotfix;

		// Token: 0x0400B0B8 RID: 45240
		private LuaFunction m_OnSystemInfoBackgroundButtonClick_hotfix;

		// Token: 0x0400B0B9 RID: 45241
		private LuaFunction m_add_EventOnChangeTestListAction;

		// Token: 0x0400B0BA RID: 45242
		private LuaFunction m_remove_EventOnChangeTestListAction;

		// Token: 0x0400B0BB RID: 45243
		private LuaFunction m_add_EventOnStartTestAction;

		// Token: 0x0400B0BC RID: 45244
		private LuaFunction m_remove_EventOnStartTestAction;

		// Token: 0x0400B0BD RID: 45245
		private LuaFunction m_add_EventOnShowSystemInfoAction_hotfix;

		// Token: 0x0400B0BE RID: 45246
		private LuaFunction m_remove_EventOnShowSystemInfoAction_hotfix;

		// Token: 0x0400B0BF RID: 45247
		private LuaFunction m_add_EventOnCloseSystemInfoAction_hotfix;

		// Token: 0x0400B0C0 RID: 45248
		private LuaFunction m_remove_EventOnCloseSystemInfoAction_hotfix;

		// Token: 0x0400B0C1 RID: 45249
		private LuaFunction m_add_EventOnShowGoddessDialogAction_hotfix;

		// Token: 0x0400B0C2 RID: 45250
		private LuaFunction m_remove_EventOnShowGoddessDialogAction_hotfix;

		// Token: 0x0400B0C3 RID: 45251
		private LuaFunction m_add_EventOnClearUserGuideAction_hotfix;

		// Token: 0x0400B0C4 RID: 45252
		private LuaFunction m_remove_EventOnClearUserGuideAction_hotfix;

		// Token: 0x0400B0C5 RID: 45253
		private LuaFunction m_add_EventOnCompleteUserGuideAction_hotfix;

		// Token: 0x0400B0C6 RID: 45254
		private LuaFunction m_remove_EventOnCompleteUserGuideAction_hotfix;

		// Token: 0x0400B0C7 RID: 45255
		private LuaFunction m_add_EventOnClearStageAction_hotfix;

		// Token: 0x0400B0C8 RID: 45256
		private LuaFunction m_remove_EventOnClearStageAction_hotfix;

		// Token: 0x0400B0C9 RID: 45257
		private LuaFunction m_add_EventOnReturnAction_hotfix;

		// Token: 0x0400B0CA RID: 45258
		private LuaFunction m_remove_EventOnReturnAction_hotfix;

		// Token: 0x0400B0CB RID: 45259
		private LuaFunction m_add_EventOnReportBugAction;

		// Token: 0x0400B0CC RID: 45260
		private LuaFunction m_remove_EventOnReportBugAction;

		// Token: 0x02000F90 RID: 3984
		public new class LuaExportHelper
		{
			// Token: 0x06013FFB RID: 81915 RVA: 0x0051A6CC File Offset: 0x005188CC
			public LuaExportHelper(TestUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013FFC RID: 81916 RVA: 0x0051A6DC File Offset: 0x005188DC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013FFD RID: 81917 RVA: 0x0051A6EC File Offset: 0x005188EC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013FFE RID: 81918 RVA: 0x0051A6FC File Offset: 0x005188FC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013FFF RID: 81919 RVA: 0x0051A70C File Offset: 0x0051890C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014000 RID: 81920 RVA: 0x0051A724 File Offset: 0x00518924
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014001 RID: 81921 RVA: 0x0051A734 File Offset: 0x00518934
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014002 RID: 81922 RVA: 0x0051A744 File Offset: 0x00518944
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014003 RID: 81923 RVA: 0x0051A754 File Offset: 0x00518954
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014004 RID: 81924 RVA: 0x0051A764 File Offset: 0x00518964
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014005 RID: 81925 RVA: 0x0051A774 File Offset: 0x00518974
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014006 RID: 81926 RVA: 0x0051A784 File Offset: 0x00518984
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014007 RID: 81927 RVA: 0x0051A794 File Offset: 0x00518994
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014008 RID: 81928 RVA: 0x0051A7A4 File Offset: 0x005189A4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014009 RID: 81929 RVA: 0x0051A7B4 File Offset: 0x005189B4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601400A RID: 81930 RVA: 0x0051A7C4 File Offset: 0x005189C4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601400B RID: 81931 RVA: 0x0051A7D4 File Offset: 0x005189D4
			public void __callDele_EventOnChangeTestList(TestListType obj)
			{
				this.m_owner.__callDele_EventOnChangeTestList(obj);
			}

			// Token: 0x0601400C RID: 81932 RVA: 0x0051A7E4 File Offset: 0x005189E4
			public void __clearDele_EventOnChangeTestList(TestListType obj)
			{
				this.m_owner.__clearDele_EventOnChangeTestList(obj);
			}

			// Token: 0x0601400D RID: 81933 RVA: 0x0051A7F4 File Offset: 0x005189F4
			public void __callDele_EventOnStartTest(int obj)
			{
				this.m_owner.__callDele_EventOnStartTest(obj);
			}

			// Token: 0x0601400E RID: 81934 RVA: 0x0051A804 File Offset: 0x00518A04
			public void __clearDele_EventOnStartTest(int obj)
			{
				this.m_owner.__clearDele_EventOnStartTest(obj);
			}

			// Token: 0x0601400F RID: 81935 RVA: 0x0051A814 File Offset: 0x00518A14
			public void __callDele_EventOnShowSystemInfo()
			{
				this.m_owner.__callDele_EventOnShowSystemInfo();
			}

			// Token: 0x06014010 RID: 81936 RVA: 0x0051A824 File Offset: 0x00518A24
			public void __clearDele_EventOnShowSystemInfo()
			{
				this.m_owner.__clearDele_EventOnShowSystemInfo();
			}

			// Token: 0x06014011 RID: 81937 RVA: 0x0051A834 File Offset: 0x00518A34
			public void __callDele_EventOnCloseSystemInfo()
			{
				this.m_owner.__callDele_EventOnCloseSystemInfo();
			}

			// Token: 0x06014012 RID: 81938 RVA: 0x0051A844 File Offset: 0x00518A44
			public void __clearDele_EventOnCloseSystemInfo()
			{
				this.m_owner.__clearDele_EventOnCloseSystemInfo();
			}

			// Token: 0x06014013 RID: 81939 RVA: 0x0051A854 File Offset: 0x00518A54
			public void __callDele_EventOnShowGoddessDialog()
			{
				this.m_owner.__callDele_EventOnShowGoddessDialog();
			}

			// Token: 0x06014014 RID: 81940 RVA: 0x0051A864 File Offset: 0x00518A64
			public void __clearDele_EventOnShowGoddessDialog()
			{
				this.m_owner.__clearDele_EventOnShowGoddessDialog();
			}

			// Token: 0x06014015 RID: 81941 RVA: 0x0051A874 File Offset: 0x00518A74
			public void __callDele_EventOnClearUserGuide()
			{
				this.m_owner.__callDele_EventOnClearUserGuide();
			}

			// Token: 0x06014016 RID: 81942 RVA: 0x0051A884 File Offset: 0x00518A84
			public void __clearDele_EventOnClearUserGuide()
			{
				this.m_owner.__clearDele_EventOnClearUserGuide();
			}

			// Token: 0x06014017 RID: 81943 RVA: 0x0051A894 File Offset: 0x00518A94
			public void __callDele_EventOnCompleteUserGuide()
			{
				this.m_owner.__callDele_EventOnCompleteUserGuide();
			}

			// Token: 0x06014018 RID: 81944 RVA: 0x0051A8A4 File Offset: 0x00518AA4
			public void __clearDele_EventOnCompleteUserGuide()
			{
				this.m_owner.__clearDele_EventOnCompleteUserGuide();
			}

			// Token: 0x06014019 RID: 81945 RVA: 0x0051A8B4 File Offset: 0x00518AB4
			public void __callDele_EventOnClearStage()
			{
				this.m_owner.__callDele_EventOnClearStage();
			}

			// Token: 0x0601401A RID: 81946 RVA: 0x0051A8C4 File Offset: 0x00518AC4
			public void __clearDele_EventOnClearStage()
			{
				this.m_owner.__clearDele_EventOnClearStage();
			}

			// Token: 0x0601401B RID: 81947 RVA: 0x0051A8D4 File Offset: 0x00518AD4
			public void __callDele_EventOnReturn()
			{
				this.m_owner.__callDele_EventOnReturn();
			}

			// Token: 0x0601401C RID: 81948 RVA: 0x0051A8E4 File Offset: 0x00518AE4
			public void __clearDele_EventOnReturn()
			{
				this.m_owner.__clearDele_EventOnReturn();
			}

			// Token: 0x0601401D RID: 81949 RVA: 0x0051A8F4 File Offset: 0x00518AF4
			public void __callDele_EventOnReportBug(string arg1, double arg2)
			{
				this.m_owner.__callDele_EventOnReportBug(arg1, arg2);
			}

			// Token: 0x0601401E RID: 81950 RVA: 0x0051A904 File Offset: 0x00518B04
			public void __clearDele_EventOnReportBug(string arg1, double arg2)
			{
				this.m_owner.__clearDele_EventOnReportBug(arg1, arg2);
			}

			// Token: 0x17003B9C RID: 15260
			// (get) Token: 0x0601401F RID: 81951 RVA: 0x0051A914 File Offset: 0x00518B14
			// (set) Token: 0x06014020 RID: 81952 RVA: 0x0051A924 File Offset: 0x00518B24
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17003B9D RID: 15261
			// (get) Token: 0x06014021 RID: 81953 RVA: 0x0051A934 File Offset: 0x00518B34
			// (set) Token: 0x06014022 RID: 81954 RVA: 0x0051A944 File Offset: 0x00518B44
			public Button m_systemInfoButton
			{
				get
				{
					return this.m_owner.m_systemInfoButton;
				}
				set
				{
					this.m_owner.m_systemInfoButton = value;
				}
			}

			// Token: 0x17003B9E RID: 15262
			// (get) Token: 0x06014023 RID: 81955 RVA: 0x0051A954 File Offset: 0x00518B54
			// (set) Token: 0x06014024 RID: 81956 RVA: 0x0051A964 File Offset: 0x00518B64
			public Button m_goddessDialogButton
			{
				get
				{
					return this.m_owner.m_goddessDialogButton;
				}
				set
				{
					this.m_owner.m_goddessDialogButton = value;
				}
			}

			// Token: 0x17003B9F RID: 15263
			// (get) Token: 0x06014025 RID: 81957 RVA: 0x0051A974 File Offset: 0x00518B74
			// (set) Token: 0x06014026 RID: 81958 RVA: 0x0051A984 File Offset: 0x00518B84
			public Button m_clearUserGuideButton
			{
				get
				{
					return this.m_owner.m_clearUserGuideButton;
				}
				set
				{
					this.m_owner.m_clearUserGuideButton = value;
				}
			}

			// Token: 0x17003BA0 RID: 15264
			// (get) Token: 0x06014027 RID: 81959 RVA: 0x0051A994 File Offset: 0x00518B94
			// (set) Token: 0x06014028 RID: 81960 RVA: 0x0051A9A4 File Offset: 0x00518BA4
			public Button m_completeUserGuideButton
			{
				get
				{
					return this.m_owner.m_completeUserGuideButton;
				}
				set
				{
					this.m_owner.m_completeUserGuideButton = value;
				}
			}

			// Token: 0x17003BA1 RID: 15265
			// (get) Token: 0x06014029 RID: 81961 RVA: 0x0051A9B4 File Offset: 0x00518BB4
			// (set) Token: 0x0601402A RID: 81962 RVA: 0x0051A9C4 File Offset: 0x00518BC4
			public Button m_becomeStrongButton
			{
				get
				{
					return this.m_owner.m_becomeStrongButton;
				}
				set
				{
					this.m_owner.m_becomeStrongButton = value;
				}
			}

			// Token: 0x17003BA2 RID: 15266
			// (get) Token: 0x0601402B RID: 81963 RVA: 0x0051A9D4 File Offset: 0x00518BD4
			// (set) Token: 0x0601402C RID: 81964 RVA: 0x0051A9E4 File Offset: 0x00518BE4
			public InputField m_becomeStrongPlayerLevelInput
			{
				get
				{
					return this.m_owner.m_becomeStrongPlayerLevelInput;
				}
				set
				{
					this.m_owner.m_becomeStrongPlayerLevelInput = value;
				}
			}

			// Token: 0x17003BA3 RID: 15267
			// (get) Token: 0x0601402D RID: 81965 RVA: 0x0051A9F4 File Offset: 0x00518BF4
			// (set) Token: 0x0601402E RID: 81966 RVA: 0x0051AA04 File Offset: 0x00518C04
			public InputField m_becomeStrongHeroStarLevelInput
			{
				get
				{
					return this.m_owner.m_becomeStrongHeroStarLevelInput;
				}
				set
				{
					this.m_owner.m_becomeStrongHeroStarLevelInput = value;
				}
			}

			// Token: 0x17003BA4 RID: 15268
			// (get) Token: 0x0601402F RID: 81967 RVA: 0x0051AA14 File Offset: 0x00518C14
			// (set) Token: 0x06014030 RID: 81968 RVA: 0x0051AA24 File Offset: 0x00518C24
			public InputField m_becomeStrongEquipmentLevelInput
			{
				get
				{
					return this.m_owner.m_becomeStrongEquipmentLevelInput;
				}
				set
				{
					this.m_owner.m_becomeStrongEquipmentLevelInput = value;
				}
			}

			// Token: 0x17003BA5 RID: 15269
			// (get) Token: 0x06014031 RID: 81969 RVA: 0x0051AA34 File Offset: 0x00518C34
			// (set) Token: 0x06014032 RID: 81970 RVA: 0x0051AA44 File Offset: 0x00518C44
			public Button m_clearStageButton
			{
				get
				{
					return this.m_owner.m_clearStageButton;
				}
				set
				{
					this.m_owner.m_clearStageButton = value;
				}
			}

			// Token: 0x17003BA6 RID: 15270
			// (get) Token: 0x06014033 RID: 81971 RVA: 0x0051AA54 File Offset: 0x00518C54
			// (set) Token: 0x06014034 RID: 81972 RVA: 0x0051AA64 File Offset: 0x00518C64
			public Button m_openReportBugPanelButton
			{
				get
				{
					return this.m_owner.m_openReportBugPanelButton;
				}
				set
				{
					this.m_owner.m_openReportBugPanelButton = value;
				}
			}

			// Token: 0x17003BA7 RID: 15271
			// (get) Token: 0x06014035 RID: 81973 RVA: 0x0051AA74 File Offset: 0x00518C74
			// (set) Token: 0x06014036 RID: 81974 RVA: 0x0051AA84 File Offset: 0x00518C84
			public Toggle m_iPhoneXToggle
			{
				get
				{
					return this.m_owner.m_iPhoneXToggle;
				}
				set
				{
					this.m_owner.m_iPhoneXToggle = value;
				}
			}

			// Token: 0x17003BA8 RID: 15272
			// (get) Token: 0x06014037 RID: 81975 RVA: 0x0051AA94 File Offset: 0x00518C94
			// (set) Token: 0x06014038 RID: 81976 RVA: 0x0051AAA4 File Offset: 0x00518CA4
			public Toggle m_battleToggle
			{
				get
				{
					return this.m_owner.m_battleToggle;
				}
				set
				{
					this.m_owner.m_battleToggle = value;
				}
			}

			// Token: 0x17003BA9 RID: 15273
			// (get) Token: 0x06014039 RID: 81977 RVA: 0x0051AAB4 File Offset: 0x00518CB4
			// (set) Token: 0x0601403A RID: 81978 RVA: 0x0051AAC4 File Offset: 0x00518CC4
			public Toggle m_dialogToggle
			{
				get
				{
					return this.m_owner.m_dialogToggle;
				}
				set
				{
					this.m_owner.m_dialogToggle = value;
				}
			}

			// Token: 0x17003BAA RID: 15274
			// (get) Token: 0x0601403B RID: 81979 RVA: 0x0051AAD4 File Offset: 0x00518CD4
			// (set) Token: 0x0601403C RID: 81980 RVA: 0x0051AAE4 File Offset: 0x00518CE4
			public Toggle m_battleDialogToggle
			{
				get
				{
					return this.m_owner.m_battleDialogToggle;
				}
				set
				{
					this.m_owner.m_battleDialogToggle = value;
				}
			}

			// Token: 0x17003BAB RID: 15275
			// (get) Token: 0x0601403D RID: 81981 RVA: 0x0051AAF4 File Offset: 0x00518CF4
			// (set) Token: 0x0601403E RID: 81982 RVA: 0x0051AB04 File Offset: 0x00518D04
			public Toggle m_userGuideDialogToggle
			{
				get
				{
					return this.m_owner.m_userGuideDialogToggle;
				}
				set
				{
					this.m_owner.m_userGuideDialogToggle = value;
				}
			}

			// Token: 0x17003BAC RID: 15276
			// (get) Token: 0x0601403F RID: 81983 RVA: 0x0051AB14 File Offset: 0x00518D14
			// (set) Token: 0x06014040 RID: 81984 RVA: 0x0051AB24 File Offset: 0x00518D24
			public EasyObjectPool m_ListItemPool
			{
				get
				{
					return this.m_owner.m_ListItemPool;
				}
				set
				{
					this.m_owner.m_ListItemPool = value;
				}
			}

			// Token: 0x17003BAD RID: 15277
			// (get) Token: 0x06014041 RID: 81985 RVA: 0x0051AB34 File Offset: 0x00518D34
			// (set) Token: 0x06014042 RID: 81986 RVA: 0x0051AB44 File Offset: 0x00518D44
			public LoopVerticalScrollRect m_LoopScroolRect
			{
				get
				{
					return this.m_owner.m_LoopScroolRect;
				}
				set
				{
					this.m_owner.m_LoopScroolRect = value;
				}
			}

			// Token: 0x17003BAE RID: 15278
			// (get) Token: 0x06014043 RID: 81987 RVA: 0x0051AB54 File Offset: 0x00518D54
			// (set) Token: 0x06014044 RID: 81988 RVA: 0x0051AB64 File Offset: 0x00518D64
			public GameObject m_monsterLevelGameObject
			{
				get
				{
					return this.m_owner.m_monsterLevelGameObject;
				}
				set
				{
					this.m_owner.m_monsterLevelGameObject = value;
				}
			}

			// Token: 0x17003BAF RID: 15279
			// (get) Token: 0x06014045 RID: 81989 RVA: 0x0051AB74 File Offset: 0x00518D74
			// (set) Token: 0x06014046 RID: 81990 RVA: 0x0051AB84 File Offset: 0x00518D84
			public InputField m_monsterLevelInputField
			{
				get
				{
					return this.m_owner.m_monsterLevelInputField;
				}
				set
				{
					this.m_owner.m_monsterLevelInputField = value;
				}
			}

			// Token: 0x17003BB0 RID: 15280
			// (get) Token: 0x06014047 RID: 81991 RVA: 0x0051AB94 File Offset: 0x00518D94
			// (set) Token: 0x06014048 RID: 81992 RVA: 0x0051ABA4 File Offset: 0x00518DA4
			public Button m_startTestBattleButton
			{
				get
				{
					return this.m_owner.m_startTestBattleButton;
				}
				set
				{
					this.m_owner.m_startTestBattleButton = value;
				}
			}

			// Token: 0x17003BB1 RID: 15281
			// (get) Token: 0x06014049 RID: 81993 RVA: 0x0051ABB4 File Offset: 0x00518DB4
			// (set) Token: 0x0601404A RID: 81994 RVA: 0x0051ABC4 File Offset: 0x00518DC4
			public InputField m_TestIdInputField
			{
				get
				{
					return this.m_owner.m_TestIdInputField;
				}
				set
				{
					this.m_owner.m_TestIdInputField = value;
				}
			}

			// Token: 0x17003BB2 RID: 15282
			// (get) Token: 0x0601404B RID: 81995 RVA: 0x0051ABD4 File Offset: 0x00518DD4
			// (set) Token: 0x0601404C RID: 81996 RVA: 0x0051ABE4 File Offset: 0x00518DE4
			public Button m_TestIdNextSearch
			{
				get
				{
					return this.m_owner.m_TestIdNextSearch;
				}
				set
				{
					this.m_owner.m_TestIdNextSearch = value;
				}
			}

			// Token: 0x17003BB3 RID: 15283
			// (get) Token: 0x0601404D RID: 81997 RVA: 0x0051ABF4 File Offset: 0x00518DF4
			// (set) Token: 0x0601404E RID: 81998 RVA: 0x0051AC04 File Offset: 0x00518E04
			public Button m_TestListHomeBtn
			{
				get
				{
					return this.m_owner.m_TestListHomeBtn;
				}
				set
				{
					this.m_owner.m_TestListHomeBtn = value;
				}
			}

			// Token: 0x17003BB4 RID: 15284
			// (get) Token: 0x0601404F RID: 81999 RVA: 0x0051AC14 File Offset: 0x00518E14
			// (set) Token: 0x06014050 RID: 82000 RVA: 0x0051AC24 File Offset: 0x00518E24
			public GameObject m_systemInfoGameObject
			{
				get
				{
					return this.m_owner.m_systemInfoGameObject;
				}
				set
				{
					this.m_owner.m_systemInfoGameObject = value;
				}
			}

			// Token: 0x17003BB5 RID: 15285
			// (get) Token: 0x06014051 RID: 82001 RVA: 0x0051AC34 File Offset: 0x00518E34
			// (set) Token: 0x06014052 RID: 82002 RVA: 0x0051AC44 File Offset: 0x00518E44
			public Button m_systemInfoBackgroundButton
			{
				get
				{
					return this.m_owner.m_systemInfoBackgroundButton;
				}
				set
				{
					this.m_owner.m_systemInfoBackgroundButton = value;
				}
			}

			// Token: 0x17003BB6 RID: 15286
			// (get) Token: 0x06014053 RID: 82003 RVA: 0x0051AC54 File Offset: 0x00518E54
			// (set) Token: 0x06014054 RID: 82004 RVA: 0x0051AC64 File Offset: 0x00518E64
			public Text m_systemInfoText
			{
				get
				{
					return this.m_owner.m_systemInfoText;
				}
				set
				{
					this.m_owner.m_systemInfoText = value;
				}
			}

			// Token: 0x17003BB7 RID: 15287
			// (get) Token: 0x06014055 RID: 82005 RVA: 0x0051AC74 File Offset: 0x00518E74
			// (set) Token: 0x06014056 RID: 82006 RVA: 0x0051AC84 File Offset: 0x00518E84
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x17003BB8 RID: 15288
			// (get) Token: 0x06014057 RID: 82007 RVA: 0x0051AC94 File Offset: 0x00518E94
			// (set) Token: 0x06014058 RID: 82008 RVA: 0x0051ACA4 File Offset: 0x00518EA4
			public GameObject m_testListItemPrefab
			{
				get
				{
					return this.m_owner.m_testListItemPrefab;
				}
				set
				{
					this.m_owner.m_testListItemPrefab = value;
				}
			}

			// Token: 0x17003BB9 RID: 15289
			// (get) Token: 0x06014059 RID: 82009 RVA: 0x0051ACB4 File Offset: 0x00518EB4
			// (set) Token: 0x0601405A RID: 82010 RVA: 0x0051ACC4 File Offset: 0x00518EC4
			public Text m_serverDateTimeText
			{
				get
				{
					return this.m_owner.m_serverDateTimeText;
				}
				set
				{
					this.m_owner.m_serverDateTimeText = value;
				}
			}

			// Token: 0x17003BBA RID: 15290
			// (get) Token: 0x0601405B RID: 82011 RVA: 0x0051ACD4 File Offset: 0x00518ED4
			// (set) Token: 0x0601405C RID: 82012 RVA: 0x0051ACE4 File Offset: 0x00518EE4
			public Button m_closeReportBugPanelButton
			{
				get
				{
					return this.m_owner.m_closeReportBugPanelButton;
				}
				set
				{
					this.m_owner.m_closeReportBugPanelButton = value;
				}
			}

			// Token: 0x17003BBB RID: 15291
			// (get) Token: 0x0601405D RID: 82013 RVA: 0x0051ACF4 File Offset: 0x00518EF4
			// (set) Token: 0x0601405E RID: 82014 RVA: 0x0051AD04 File Offset: 0x00518F04
			public GameObject m_reportBugPanelGameObject
			{
				get
				{
					return this.m_owner.m_reportBugPanelGameObject;
				}
				set
				{
					this.m_owner.m_reportBugPanelGameObject = value;
				}
			}

			// Token: 0x17003BBC RID: 15292
			// (get) Token: 0x0601405F RID: 82015 RVA: 0x0051AD14 File Offset: 0x00518F14
			// (set) Token: 0x06014060 RID: 82016 RVA: 0x0051AD24 File Offset: 0x00518F24
			public Toggle m_oneHourLogTime
			{
				get
				{
					return this.m_owner.m_oneHourLogTime;
				}
				set
				{
					this.m_owner.m_oneHourLogTime = value;
				}
			}

			// Token: 0x17003BBD RID: 15293
			// (get) Token: 0x06014061 RID: 82017 RVA: 0x0051AD34 File Offset: 0x00518F34
			// (set) Token: 0x06014062 RID: 82018 RVA: 0x0051AD44 File Offset: 0x00518F44
			public Toggle m_oneDayLogTime
			{
				get
				{
					return this.m_owner.m_oneDayLogTime;
				}
				set
				{
					this.m_owner.m_oneDayLogTime = value;
				}
			}

			// Token: 0x17003BBE RID: 15294
			// (get) Token: 0x06014063 RID: 82019 RVA: 0x0051AD54 File Offset: 0x00518F54
			// (set) Token: 0x06014064 RID: 82020 RVA: 0x0051AD64 File Offset: 0x00518F64
			public Toggle m_oneWeekLogTime
			{
				get
				{
					return this.m_owner.m_oneWeekLogTime;
				}
				set
				{
					this.m_owner.m_oneWeekLogTime = value;
				}
			}

			// Token: 0x17003BBF RID: 15295
			// (get) Token: 0x06014065 RID: 82021 RVA: 0x0051AD74 File Offset: 0x00518F74
			// (set) Token: 0x06014066 RID: 82022 RVA: 0x0051AD84 File Offset: 0x00518F84
			public InputField m_bugDescriptionInputField
			{
				get
				{
					return this.m_owner.m_bugDescriptionInputField;
				}
				set
				{
					this.m_owner.m_bugDescriptionInputField = value;
				}
			}

			// Token: 0x17003BC0 RID: 15296
			// (get) Token: 0x06014067 RID: 82023 RVA: 0x0051AD94 File Offset: 0x00518F94
			// (set) Token: 0x06014068 RID: 82024 RVA: 0x0051ADA4 File Offset: 0x00518FA4
			public Button m_cancelReportBugButton
			{
				get
				{
					return this.m_owner.m_cancelReportBugButton;
				}
				set
				{
					this.m_owner.m_cancelReportBugButton = value;
				}
			}

			// Token: 0x17003BC1 RID: 15297
			// (get) Token: 0x06014069 RID: 82025 RVA: 0x0051ADB4 File Offset: 0x00518FB4
			// (set) Token: 0x0601406A RID: 82026 RVA: 0x0051ADC4 File Offset: 0x00518FC4
			public Button m_reportBugButton
			{
				get
				{
					return this.m_owner.m_reportBugButton;
				}
				set
				{
					this.m_owner.m_reportBugButton = value;
				}
			}

			// Token: 0x17003BC2 RID: 15298
			// (get) Token: 0x0601406B RID: 82027 RVA: 0x0051ADD4 File Offset: 0x00518FD4
			// (set) Token: 0x0601406C RID: 82028 RVA: 0x0051ADE4 File Offset: 0x00518FE4
			public Button m_finishAllTasksButton
			{
				get
				{
					return this.m_owner.m_finishAllTasksButton;
				}
				set
				{
					this.m_owner.m_finishAllTasksButton = value;
				}
			}

			// Token: 0x17003BC3 RID: 15299
			// (get) Token: 0x0601406D RID: 82029 RVA: 0x0051ADF4 File Offset: 0x00518FF4
			// (set) Token: 0x0601406E RID: 82030 RVA: 0x0051AE04 File Offset: 0x00519004
			public List<TestListItemUIController> m_testListItemUIControllers
			{
				get
				{
					return this.m_owner.m_testListItemUIControllers;
				}
				set
				{
					this.m_owner.m_testListItemUIControllers = value;
				}
			}

			// Token: 0x17003BC4 RID: 15300
			// (get) Token: 0x0601406F RID: 82031 RVA: 0x0051AE14 File Offset: 0x00519014
			// (set) Token: 0x06014070 RID: 82032 RVA: 0x0051AE24 File Offset: 0x00519024
			public bool m_isIgnoreToggleEvent
			{
				get
				{
					return this.m_owner.m_isIgnoreToggleEvent;
				}
				set
				{
					this.m_owner.m_isIgnoreToggleEvent = value;
				}
			}

			// Token: 0x17003BC5 RID: 15301
			// (get) Token: 0x06014071 RID: 82033 RVA: 0x0051AE34 File Offset: 0x00519034
			// (set) Token: 0x06014072 RID: 82034 RVA: 0x0051AE44 File Offset: 0x00519044
			public List<KeyValuePair<int, string>> m_CacheTestList
			{
				get
				{
					return this.m_owner.m_CacheTestList;
				}
				set
				{
					this.m_owner.m_CacheTestList = value;
				}
			}

			// Token: 0x17003BC6 RID: 15302
			// (get) Token: 0x06014073 RID: 82035 RVA: 0x0051AE54 File Offset: 0x00519054
			// (set) Token: 0x06014074 RID: 82036 RVA: 0x0051AE64 File Offset: 0x00519064
			public TestListItemUIController m_CurrSelectCtrl
			{
				get
				{
					return this.m_owner.m_CurrSelectCtrl;
				}
				set
				{
					this.m_owner.m_CurrSelectCtrl = value;
				}
			}

			// Token: 0x17003BC7 RID: 15303
			// (get) Token: 0x06014075 RID: 82037 RVA: 0x0051AE74 File Offset: 0x00519074
			// (set) Token: 0x06014076 RID: 82038 RVA: 0x0051AE84 File Offset: 0x00519084
			public int m_nSearchTestListId
			{
				get
				{
					return this.m_owner.m_nSearchTestListId;
				}
				set
				{
					this.m_owner.m_nSearchTestListId = value;
				}
			}

			// Token: 0x06014077 RID: 82039 RVA: 0x0051AE94 File Offset: 0x00519094
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014078 RID: 82040 RVA: 0x0051AEA4 File Offset: 0x005190A4
			public static void ScrollToItem(ScrollRect scrollRect, int itemCount, int idx)
			{
				TestUIController.ScrollToItem(scrollRect, itemCount, idx);
			}

			// Token: 0x06014079 RID: 82041 RVA: 0x0051AEB0 File Offset: 0x005190B0
			public TestListItemUIController GetSelectedTestListItemUIController()
			{
				return this.m_owner.GetSelectedTestListItemUIController();
			}

			// Token: 0x0601407A RID: 82042 RVA: 0x0051AEC0 File Offset: 0x005190C0
			public static void AppendLine(StringBuilder sb, bool textColor, string name, string value)
			{
				TestUIController.AppendLine(sb, textColor, name, value);
			}

			// Token: 0x0601407B RID: 82043 RVA: 0x0051AECC File Offset: 0x005190CC
			public void InitLoopScrollViewRect()
			{
				this.m_owner.InitLoopScrollViewRect();
			}

			// Token: 0x0601407C RID: 82044 RVA: 0x0051AEDC File Offset: 0x005190DC
			public void OnTestItemFill(UIControllerBase ctrl)
			{
				this.m_owner.OnTestItemFill(ctrl);
			}

			// Token: 0x0601407D RID: 82045 RVA: 0x0051AEEC File Offset: 0x005190EC
			public void OnTestItemClick(UIControllerBase ctrl)
			{
				this.m_owner.OnTestItemClick(ctrl);
			}

			// Token: 0x0601407E RID: 82046 RVA: 0x0051AEFC File Offset: 0x005190FC
			public void DoToggle(bool on, TestListType listType)
			{
				this.m_owner.DoToggle(on, listType);
			}

			// Token: 0x0601407F RID: 82047 RVA: 0x0051AF0C File Offset: 0x0051910C
			public void OnBattleToggle(bool on)
			{
				this.m_owner.OnBattleToggle(on);
			}

			// Token: 0x06014080 RID: 82048 RVA: 0x0051AF1C File Offset: 0x0051911C
			public void OnDialogToggle(bool on)
			{
				this.m_owner.OnDialogToggle(on);
			}

			// Token: 0x06014081 RID: 82049 RVA: 0x0051AF2C File Offset: 0x0051912C
			public void OnBattleDialogToggle(bool on)
			{
				this.m_owner.OnBattleDialogToggle(on);
			}

			// Token: 0x06014082 RID: 82050 RVA: 0x0051AF3C File Offset: 0x0051913C
			public void OnUserGuideDialogToggle(bool on)
			{
				this.m_owner.OnUserGuideDialogToggle(on);
			}

			// Token: 0x06014083 RID: 82051 RVA: 0x0051AF4C File Offset: 0x0051914C
			public void OnTestListHomeBtnClick()
			{
				this.m_owner.OnTestListHomeBtnClick();
			}

			// Token: 0x06014084 RID: 82052 RVA: 0x0051AF5C File Offset: 0x0051915C
			public void OnTestIdNextBtnClick()
			{
				this.m_owner.OnTestIdNextBtnClick();
			}

			// Token: 0x06014085 RID: 82053 RVA: 0x0051AF6C File Offset: 0x0051916C
			public void OnTestIdInput(string value)
			{
				this.m_owner.OnTestIdInput(value);
			}

			// Token: 0x06014086 RID: 82054 RVA: 0x0051AF7C File Offset: 0x0051917C
			public void OnStartTestButtonClick()
			{
				this.m_owner.OnStartTestButtonClick();
			}

			// Token: 0x06014087 RID: 82055 RVA: 0x0051AF8C File Offset: 0x0051918C
			public void OnReturnButtonClick()
			{
				this.m_owner.OnReturnButtonClick();
			}

			// Token: 0x06014088 RID: 82056 RVA: 0x0051AF9C File Offset: 0x0051919C
			public void OnSystemInfoButtonClick()
			{
				this.m_owner.OnSystemInfoButtonClick();
			}

			// Token: 0x06014089 RID: 82057 RVA: 0x0051AFAC File Offset: 0x005191AC
			public void OnGoddessDialogButtonClick()
			{
				this.m_owner.OnGoddessDialogButtonClick();
			}

			// Token: 0x0601408A RID: 82058 RVA: 0x0051AFBC File Offset: 0x005191BC
			public void OnClearUserGuideButtonClick()
			{
				this.m_owner.OnClearUserGuideButtonClick();
			}

			// Token: 0x0601408B RID: 82059 RVA: 0x0051AFCC File Offset: 0x005191CC
			public void OnBecomeStrongButtonClick()
			{
				this.m_owner.OnBecomeStrongButtonClick();
			}

			// Token: 0x0601408C RID: 82060 RVA: 0x0051AFDC File Offset: 0x005191DC
			public void OnFinishAllTasksButtonClick()
			{
				this.m_owner.OnFinishAllTasksButtonClick();
			}

			// Token: 0x0601408D RID: 82061 RVA: 0x0051AFEC File Offset: 0x005191EC
			public IEnumerator FinishAllTasks()
			{
				return this.m_owner.FinishAllTasks();
			}

			// Token: 0x0601408E RID: 82062 RVA: 0x0051AFFC File Offset: 0x005191FC
			public void OnCancelReportBugButtonClick()
			{
				this.m_owner.OnCancelReportBugButtonClick();
			}

			// Token: 0x0601408F RID: 82063 RVA: 0x0051B00C File Offset: 0x0051920C
			public void OniPhoneXToggleValueChanged(bool isOn)
			{
				this.m_owner.OniPhoneXToggleValueChanged(isOn);
			}

			// Token: 0x06014090 RID: 82064 RVA: 0x0051B01C File Offset: 0x0051921C
			public void OnReportBugButtonClick()
			{
				this.m_owner.OnReportBugButtonClick();
			}

			// Token: 0x06014091 RID: 82065 RVA: 0x0051B02C File Offset: 0x0051922C
			public double GetReportBugLogHours()
			{
				return this.m_owner.GetReportBugLogHours();
			}

			// Token: 0x06014092 RID: 82066 RVA: 0x0051B03C File Offset: 0x0051923C
			public void OnOpenReportBugPanelButtonClick()
			{
				this.m_owner.OnOpenReportBugPanelButtonClick();
			}

			// Token: 0x06014093 RID: 82067 RVA: 0x0051B04C File Offset: 0x0051924C
			public static IEnumerator UpgradePlayerLevel(int targetPlayerLevel)
			{
				return TestUIController.UpgradePlayerLevel(targetPlayerLevel);
			}

			// Token: 0x06014094 RID: 82068 RVA: 0x0051B054 File Offset: 0x00519254
			public static IEnumerator SpeedUpAllHeros(int targetHeroLevel, int targetStarLevel)
			{
				return TestUIController.SpeedUpAllHeros(targetHeroLevel, targetStarLevel);
			}

			// Token: 0x06014095 RID: 82069 RVA: 0x0051B060 File Offset: 0x00519260
			public static IEnumerator BecomeStrong(int targetPlayerLevel, int targetStarLevel, int targetEquipmentLevel)
			{
				return TestUIController.BecomeStrong(targetPlayerLevel, targetStarLevel, targetEquipmentLevel);
			}

			// Token: 0x06014096 RID: 82070 RVA: 0x0051B06C File Offset: 0x0051926C
			public static List<int> GetHeroJobConnSequence(int heroID)
			{
				return TestUIController.GetHeroJobConnSequence(heroID);
			}

			// Token: 0x06014097 RID: 82071 RVA: 0x0051B074 File Offset: 0x00519274
			public static List<int> GetJobSequence(int rootJobConnectionID)
			{
				return TestUIController.GetJobSequence(rootJobConnectionID);
			}

			// Token: 0x06014098 RID: 82072 RVA: 0x0051B07C File Offset: 0x0051927C
			public static int GetEquipmentLevelLimit(int equipmentStarLevel)
			{
				return TestUIController.GetEquipmentLevelLimit(equipmentStarLevel);
			}

			// Token: 0x06014099 RID: 82073 RVA: 0x0051B084 File Offset: 0x00519284
			public static bool IsEquipismentMaxLevel(EquipmentBagItem equipment)
			{
				return TestUIController.IsEquipismentMaxLevel(equipment);
			}

			// Token: 0x0601409A RID: 82074 RVA: 0x0051B08C File Offset: 0x0051928C
			public static IEnumerator StarLevelUpTopRankEquipments(int ssrMaterialEquipmentId, int srMaterialEquipmentId)
			{
				return TestUIController.StarLevelUpTopRankEquipments(ssrMaterialEquipmentId, srMaterialEquipmentId);
			}

			// Token: 0x0601409B RID: 82075 RVA: 0x0051B098 File Offset: 0x00519298
			public static IEnumerator AddItem4StarLevelUpEquipment(ulong instanceId)
			{
				return TestUIController.AddItem4StarLevelUpEquipment(instanceId);
			}

			// Token: 0x0601409C RID: 82076 RVA: 0x0051B0A0 File Offset: 0x005192A0
			public static IEnumerator AddGoods(List<Goods> goods)
			{
				return TestUIController.AddGoods(goods);
			}

			// Token: 0x0601409D RID: 82077 RVA: 0x0051B0A8 File Offset: 0x005192A8
			public static IEnumerator StarLevelUpEquipment(ulong instanceId, ulong materialId)
			{
				return TestUIController.StarLevelUpEquipment(instanceId, materialId);
			}

			// Token: 0x0601409E RID: 82078 RVA: 0x0051B0B4 File Offset: 0x005192B4
			public static IEnumerator EnhanceAllTopRankEquipments(int targetLevel)
			{
				return TestUIController.EnhanceAllTopRankEquipments(targetLevel);
			}

			// Token: 0x0601409F RID: 82079 RVA: 0x0051B0BC File Offset: 0x005192BC
			public static IEnumerator EnhanceEquipment(ulong instanceId, List<ulong> materialIds)
			{
				return TestUIController.EnhanceEquipment(instanceId, materialIds);
			}

			// Token: 0x060140A0 RID: 82080 RVA: 0x0051B0C8 File Offset: 0x005192C8
			public static IEnumerator AddAllTopRankEquipments()
			{
				return TestUIController.AddAllTopRankEquipments();
			}

			// Token: 0x060140A1 RID: 82081 RVA: 0x0051B0D0 File Offset: 0x005192D0
			public static IEnumerator AddAllHeros()
			{
				return TestUIController.AddAllHeros();
			}

			// Token: 0x060140A2 RID: 82082 RVA: 0x0051B0D8 File Offset: 0x005192D8
			public static IEnumerator AddHero(List<int> heros)
			{
				return TestUIController.AddHero(heros);
			}

			// Token: 0x060140A3 RID: 82083 RVA: 0x0051B0E0 File Offset: 0x005192E0
			public static IEnumerator HeroBreak(int id)
			{
				return TestUIController.HeroBreak(id);
			}

			// Token: 0x060140A4 RID: 82084 RVA: 0x0051B0E8 File Offset: 0x005192E8
			public static IEnumerator BuyFixedStoreItem(int fixedStoreID, int fixedStoreItemGoodsID, int count)
			{
				return TestUIController.BuyFixedStoreItem(fixedStoreID, fixedStoreItemGoodsID, count);
			}

			// Token: 0x060140A5 RID: 82085 RVA: 0x0051B0F4 File Offset: 0x005192F4
			public static IEnumerator BuyFixedStoreItem(int fixedStoreID, int fixedStoreItemGoodsID)
			{
				return TestUIController.BuyFixedStoreItem(fixedStoreID, fixedStoreItemGoodsID);
			}

			// Token: 0x060140A6 RID: 82086 RVA: 0x0051B100 File Offset: 0x00519300
			public static IEnumerator TransferHeroJob(int heroId, int jobConnectionId)
			{
				return TestUIController.TransferHeroJob(heroId, jobConnectionId);
			}

			// Token: 0x060140A7 RID: 82087 RVA: 0x0051B10C File Offset: 0x0051930C
			public static IEnumerator AddAllItem(int count)
			{
				return TestUIController.AddAllItem(count);
			}

			// Token: 0x060140A8 RID: 82088 RVA: 0x0051B114 File Offset: 0x00519314
			public static IEnumerator UpgradeHeroJobLevel(Hero hero, int jobConnectionId)
			{
				return TestUIController.UpgradeHeroJobLevel(hero, jobConnectionId);
			}

			// Token: 0x060140A9 RID: 82089 RVA: 0x0051B120 File Offset: 0x00519320
			public static IEnumerator SendGMCommand(string cmd)
			{
				return TestUIController.SendGMCommand(cmd);
			}

			// Token: 0x060140AA RID: 82090 RVA: 0x0051B128 File Offset: 0x00519328
			public static IEnumerator UseItem(GoodsType type, int id, int count)
			{
				return TestUIController.UseItem(type, id, count);
			}

			// Token: 0x060140AB RID: 82091 RVA: 0x0051B134 File Offset: 0x00519334
			public static IEnumerator AddHeroExp(int heroId, GoodsType itemType, int itemID, int count)
			{
				return TestUIController.AddHeroExp(heroId, itemType, itemID, count);
			}

			// Token: 0x060140AC RID: 82092 RVA: 0x0051B140 File Offset: 0x00519340
			public static string ErrorCodeToMessage(int code)
			{
				return TestUIController.ErrorCodeToMessage(code);
			}

			// Token: 0x060140AD RID: 82093 RVA: 0x0051B148 File Offset: 0x00519348
			public void OnCompleteUserGuideButtonClick()
			{
				this.m_owner.OnCompleteUserGuideButtonClick();
			}

			// Token: 0x060140AE RID: 82094 RVA: 0x0051B158 File Offset: 0x00519358
			public void OnClearStageButtonClick()
			{
				this.m_owner.OnClearStageButtonClick();
			}

			// Token: 0x060140AF RID: 82095 RVA: 0x0051B168 File Offset: 0x00519368
			public void OnSystemInfoBackgroundButtonClick()
			{
				this.m_owner.OnSystemInfoBackgroundButtonClick();
			}

			// Token: 0x0400B0CD RID: 45261
			private TestUIController m_owner;
		}
	}
}
