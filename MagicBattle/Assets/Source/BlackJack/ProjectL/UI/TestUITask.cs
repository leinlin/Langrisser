using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FBA RID: 4026
	[HotFix]
	public class TestUITask : UITask
	{
		// Token: 0x060141A5 RID: 82341 RVA: 0x0051EA68 File Offset: 0x0051CC68
		public TestUITask(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060141A6 RID: 82342 RVA: 0x0051EB5C File Offset: 0x0051CD5C
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			if (this.m_testUIController == null)
			{
				return;
			}
			if ((int)Time.time > (int)(Time.time - Time.deltaTime) && this.m_testUIController != null)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (projectLPlayerContext != null)
				{
					this.m_testUIController.SetServerDataTime(projectLPlayerContext.GetServerTime());
				}
			}
		}

		// Token: 0x060141A7 RID: 82343 RVA: 0x0051EC24 File Offset: 0x0051CE24
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			this.InitTestUIController();
		}

		// Token: 0x060141A8 RID: 82344 RVA: 0x0051EC90 File Offset: 0x0051CE90
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			this.UninitTestUIController();
		}

		// Token: 0x060141A9 RID: 82345 RVA: 0x0051ECFC File Offset: 0x0051CEFC
		private void InitTestUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTestUIController_hotfix != null)
			{
				this.m_InitTestUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_testUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_testUIController = (this.m_uiCtrlArray[0] as TestUIController);
				}
				if (!(this.m_testUIController != null))
				{
					global::Debug.LogError("TestUIController is null");
					return;
				}
				this.m_testUIController.EventOnChangeTestList += this.TestUIController_OnChangeTestList;
				this.m_testUIController.EventOnStartTest += this.TestUIController_OnStartTest;
				this.m_testUIController.EventOnShowSystemInfo += this.TestUIController_OnShowSystemInfo;
				this.m_testUIController.EventOnCloseSystemInfo += this.TestUIController_OnCloseSystemInfo;
				this.m_testUIController.EventOnShowGoddessDialog += this.TestUIController_OnShowGoddessDialog;
				this.m_testUIController.EventOnClearUserGuide += this.TestUIController_OnClearUserGuide;
				this.m_testUIController.EventOnCompleteUserGuide += this.TestUIController_OnCompleteUserGuide;
				this.m_testUIController.EventOnClearStage += this.TestUIController_OnClearStage;
				this.m_testUIController.EventOnReturn += this.TestUIController_OnReturn;
				this.m_testUIController.EventOnReportBug += this.OnReportBug;
			}
		}

		// Token: 0x060141AA RID: 82346 RVA: 0x0051EE98 File Offset: 0x0051D098
		private void UninitTestUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitTestUIController_hotfix != null)
			{
				this.m_UninitTestUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_testUIController != null)
			{
				this.m_testUIController.EventOnChangeTestList -= this.TestUIController_OnChangeTestList;
				this.m_testUIController.EventOnStartTest -= this.TestUIController_OnStartTest;
				this.m_testUIController.EventOnShowSystemInfo -= this.TestUIController_OnShowSystemInfo;
				this.m_testUIController.EventOnCloseSystemInfo -= this.TestUIController_OnCloseSystemInfo;
				this.m_testUIController.EventOnShowGoddessDialog -= this.TestUIController_OnShowGoddessDialog;
				this.m_testUIController.EventOnClearUserGuide -= this.TestUIController_OnClearUserGuide;
				this.m_testUIController.EventOnCompleteUserGuide -= this.TestUIController_OnCompleteUserGuide;
				this.m_testUIController.EventOnClearStage -= this.TestUIController_OnClearStage;
				this.m_testUIController.EventOnReturn -= this.TestUIController_OnReturn;
				this.m_testUIController.EventOnReportBug -= this.OnReportBug;
				this.m_testUIController = null;
			}
		}

		// Token: 0x060141AB RID: 82347 RVA: 0x0051EFF8 File Offset: 0x0051D1F8
		private void OnReportBug(string bugDesc, double logFileHours)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReportBugStringDouble_hotfix != null)
			{
				this.m_OnReportBugStringDouble_hotfix.call(new object[]
				{
					this,
					bugDesc,
					logFileHours
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (CommonUIController.Instance == null && string.IsNullOrEmpty(bugDesc) && logFileHours < 0.0001)
			{
				return;
			}
			CommonUIController.Instance.StartCoroutine(TestUITask.ReportBug(bugDesc, logFileHours));
		}

		// Token: 0x060141AC RID: 82348 RVA: 0x0051F0B8 File Offset: 0x0051D2B8
		public static IEnumerator ReportBug(string bugDesc, double logFileHours)
		{
			ClientConfigDataLoader config = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			if (config == null)
			{
				yield break;
			}
			string playerName = "LoginUI";
			ProjectLPlayerContext pc = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (pc != null)
			{
				playerName = pc.GetPlayerName();
			}
			if (CommonUIController.Instance != null)
			{
				CommonUIController.Instance.EnableInput(false);
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_ReportingBug, 2000f, null, true);
			}
			string logFolder = Path.Combine(Application.persistentDataPath, "Log");
			DateTime minLogTime = DateTime.Now.AddHours(-logFileHours);
			string clientVersion = config.Version;
			foreach (string filePath in Directory.GetFiles(logFolder, "Log*.txt"))
			{
				FileInfo fi = new FileInfo(filePath);
				if (!(fi.LastWriteTime < minLogTime))
				{
					string tempFilePath = Path.Combine(logFolder, "temp");
					File.Delete(tempFilePath);
					File.Copy(filePath, tempFilePath);
					yield return TestUITask.UploadFile(tempFilePath, DefaultServerAddress.ReportBugURL, string.Format("{0}_{1}_{2}_{3}_{4}_{5}", new object[]
					{
						Application.platform,
						Application.version,
						clientVersion,
						LoginUITask.GetCurrentSelectServerInfo().m_id,
						playerName,
						fi.Name
					}));
				}
			}
			if (!string.IsNullOrEmpty(bugDesc))
			{
				string bugDescFilePath = Path.Combine(logFolder, "BugDesc.txt");
				File.WriteAllText(bugDescFilePath, bugDesc);
				yield return TestUITask.UploadFile(bugDescFilePath, DefaultServerAddress.ReportBugURL, string.Format("{0}_{1}_{2}_{3}_{4}_BugDesc{5}.txt", new object[]
				{
					Application.platform,
					Application.version,
					clientVersion,
					LoginUITask.GetCurrentSelectServerInfo().m_id,
					playerName,
					DateTime.Now.ToString("yyyy_MMdd_HHmm_ss")
				}));
			}
			if (CommonUIController.Instance != null)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_ReportBugFinished, 2f, null, true);
				CommonUIController.Instance.EnableInput(true);
			}
			else if (LoginUITask.FindAInstance != null && LoginUITask.FindAInstance.State == Task.TaskState.Running)
			{
				LoginUITask.FindAInstance.ShowDialogBox(StringTableId.StringTableId_ReportBugFinished);
			}
			yield break;
		}

		// Token: 0x060141AD RID: 82349 RVA: 0x0051F0DC File Offset: 0x0051D2DC
		private static IEnumerator UploadFile(string localFilepath, string uploadURL, string serverFilename)
		{
			byte[] compressData = CLZF.Compress(File.ReadAllBytes(localFilepath));
			if (compressData == null || compressData.Length == 0)
			{
				yield break;
			}
			WWWForm form = new WWWForm();
			Dictionary<string, string> headers = form.headers;
			headers.Add("FileName", WWW.EscapeURL(serverFilename));
			form.AddBinaryData("CompressedFile", TestUITask.Byte2HexByte(compressData));
			global::Debug.Log("compressed file lengh = " + compressData.Length);
			WWW www = new WWW(uploadURL, form.data, headers);
			yield return new WaitUntil(() => www.isDone);
			if (!string.IsNullOrEmpty(www.error))
			{
				global::Debug.LogError(string.Format("UploadFile {0} failed, error:{0}", www.error));
			}
			else
			{
				global::Debug.Log(string.Format("Response: {0}", www.text));
			}
			yield break;
		}

		// Token: 0x060141AE RID: 82350 RVA: 0x0051F108 File Offset: 0x0051D308
		private static byte[] Byte2HexByte(byte[] bytes)
		{
			byte[] array = new byte[bytes.Length * 2];
			for (int i = 0; i < bytes.Length; i++)
			{
				string text = bytes[i].ToString("X2");
				byte[] array2 = array;
				int num = i * 2;
				array2[num] += (byte)text[0];
				byte[] array3 = array;
				int num2 = i * 2 + 1;
				array3[num2] += (byte)text[1];
			}
			return array;
		}

		// Token: 0x060141AF RID: 82351 RVA: 0x0051F178 File Offset: 0x0051D378
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateTestList();
		}

		// Token: 0x060141B0 RID: 82352 RVA: 0x0051F1E0 File Offset: 0x0051D3E0
		private void UpdateTestList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTestList_hotfix != null)
			{
				this.m_UpdateTestList_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			LocalConfigData data = LocalConfig.Instance.Data;
			TestListType testListType = (TestListType)data.TestListType;
			this.m_testUIController.ClearTestList();
			this.m_testUIController.SetTestListType(testListType);
			if (testListType == TestListType.Battle)
			{
				foreach (KeyValuePair<int, ConfigDataBattleInfo> keyValuePair in configDataLoader.GetAllConfigDataBattleInfo())
				{
					this.m_testUIController.AddTestListItem(keyValuePair.Key, keyValuePair.Value.Name);
				}
				this.m_testUIController.SetMonsterLevel(data.TestMonsterLevel);
			}
			else if (testListType == TestListType.Dialog)
			{
				foreach (KeyValuePair<int, ConfigDataDialogInfo> keyValuePair2 in configDataLoader.GetAllConfigDataDialogInfo())
				{
					if (keyValuePair2.Value.m_prevDialogInfo == null)
					{
						this.m_testUIController.AddTestListItem(keyValuePair2.Key, keyValuePair2.Value.Name);
					}
				}
			}
			else if (testListType == TestListType.BattleDialog)
			{
				foreach (KeyValuePair<int, ConfigDataBattleDialogInfo> keyValuePair3 in configDataLoader.GetAllConfigDataBattleDialogInfo())
				{
					if (keyValuePair3.Value.m_prevDialogInfo == null)
					{
						this.m_testUIController.AddTestListItem(keyValuePair3.Key, keyValuePair3.Value.Name);
					}
				}
			}
			else if (testListType == TestListType.UserGuideDialog)
			{
				foreach (KeyValuePair<int, ConfigDataUserGuideDialogInfo> keyValuePair4 in configDataLoader.GetAllConfigDataUserGuideDialogInfo())
				{
					if (keyValuePair4.Value.m_prevDialogInfo == null)
					{
						this.m_testUIController.AddTestListItem(keyValuePair4.Key, keyValuePair4.Value.Name);
					}
				}
			}
			this.m_testUIController.RefreshLoopVerticalScrollView(testListType);
		}

		// Token: 0x060141B1 RID: 82353 RVA: 0x0051F49C File Offset: 0x0051D69C
		private void StartDialogUITask(ConfigDataDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartDialogUITaskConfigDataDialogInfo_hotfix != null)
			{
				this.m_StartDialogUITaskConfigDataDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (dialogInfo == null)
			{
				return;
			}
			base.Pause();
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(DialogUITask).Name, null);
			uiintentReturnable.SetParam("DialogInfo", dialogInfo);
			UIManager.Instance.StartUITask(uiintentReturnable, true, false, null);
		}

		// Token: 0x060141B2 RID: 82354 RVA: 0x0051F550 File Offset: 0x0051D750
		private void StartBattleDialogUITask(ConfigDataBattleDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleDialogUITaskConfigDataBattleDialogInfo_hotfix != null)
			{
				this.m_StartBattleDialogUITaskConfigDataBattleDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (dialogInfo == null)
			{
				return;
			}
			base.Pause();
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(BattleDialogUITask).Name, null);
			uiintentReturnable.SetParam("BattleDialogInfo", dialogInfo);
			UIManager.Instance.StartUITask(uiintentReturnable, true, false, null);
		}

		// Token: 0x060141B3 RID: 82355 RVA: 0x0051F604 File Offset: 0x0051D804
		private void StartUserGuideDialogUITask(ConfigDataUserGuideDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUserGuideDialogUITaskConfigDataUserGuideDialogInfo_hotfix != null)
			{
				this.m_StartUserGuideDialogUITaskConfigDataUserGuideDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (dialogInfo == null)
			{
				return;
			}
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(UserGuideDialogUITask).Name, null);
			uiintentReturnable.SetParam("UserGuideDialogInfo", dialogInfo);
			UIManager.Instance.StartUITask(uiintentReturnable, true, false, null);
		}

		// Token: 0x060141B4 RID: 82356 RVA: 0x0051F6B4 File Offset: 0x0051D8B4
		private void StartGoddessDialogUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartGoddessDialogUITask_hotfix != null)
			{
				this.m_StartGoddessDialogUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(GoddessDialogUITask).Name, null);
			UIManager.Instance.StartUITask(intent, true, false, null);
		}

		// Token: 0x060141B5 RID: 82357 RVA: 0x0051F748 File Offset: 0x0051D948
		private void TestUIController_OnChangeTestList(TestListType listType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUIController_OnChangeTestListTestListType_hotfix != null)
			{
				this.m_TestUIController_OnChangeTestListTestListType_hotfix.call(new object[]
				{
					this,
					listType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalConfig.Instance.Data.TestListType = (int)listType;
			this.UpdateView();
		}

		// Token: 0x060141B6 RID: 82358 RVA: 0x0051F7D0 File Offset: 0x0051D9D0
		private void TestUIController_OnStartTest(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUIController_OnStartTestInt32_hotfix != null)
			{
				this.m_TestUIController_OnStartTestInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int monsterLevel = this.m_testUIController.GetMonsterLevel();
			LocalConfigData data = LocalConfig.Instance.Data;
			LocalConfig.Instance.SetTestUIId(LocalConfig.Instance.Data.TestListType, id);
			data.TestMonsterLevel = monsterLevel;
			LocalConfig.Instance.Save();
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			TestListType testListType = (TestListType)data.TestListType;
			if (testListType == TestListType.Battle)
			{
				ConfigDataBattleInfo configDataBattleInfo = configDataLoader.GetConfigDataBattleInfo(id);
				if (configDataBattleInfo != null)
				{
					ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
					projectLPlayerContext.Happening.Clear();
					projectLPlayerContext.Happening.InitBattleAndDialog(BattleType.None, null, monsterLevel, null, null);
					if (this.EventOnStartBattle != null)
					{
						this.EventOnStartBattle(configDataBattleInfo);
					}
				}
			}
			else if (testListType == TestListType.Dialog)
			{
				ConfigDataDialogInfo configDataDialogInfo = configDataLoader.GetConfigDataDialogInfo(id);
				if (configDataDialogInfo != null)
				{
					this.StartDialogUITask(configDataDialogInfo);
				}
			}
			else if (testListType == TestListType.BattleDialog)
			{
				ConfigDataBattleDialogInfo configDataBattleDialogInfo = configDataLoader.GetConfigDataBattleDialogInfo(id);
				if (configDataBattleDialogInfo != null)
				{
					this.StartBattleDialogUITask(configDataBattleDialogInfo);
				}
			}
			else if (testListType == TestListType.UserGuideDialog)
			{
				ConfigDataUserGuideDialogInfo configDataUserGuideDialogInfo = configDataLoader.GetConfigDataUserGuideDialogInfo(id);
				if (configDataUserGuideDialogInfo != null)
				{
					this.StartUserGuideDialogUITask(configDataUserGuideDialogInfo);
				}
			}
		}

		// Token: 0x060141B7 RID: 82359 RVA: 0x0051F964 File Offset: 0x0051DB64
		private void TestUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUIController_OnReturn_hotfix != null)
			{
				this.m_TestUIController_OnReturn_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
			base.ReturnPrevUITask();
		}

		// Token: 0x060141B8 RID: 82360 RVA: 0x0051F9D4 File Offset: 0x0051DBD4
		private void TestUIController_OnShowSystemInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUIController_OnShowSystemInfo_hotfix != null)
			{
				this.m_TestUIController_OnShowSystemInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_testUIController.ShowSystemInfo();
		}

		// Token: 0x060141B9 RID: 82361 RVA: 0x0051FA40 File Offset: 0x0051DC40
		private void TestUIController_OnCloseSystemInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUIController_OnCloseSystemInfo_hotfix != null)
			{
				this.m_TestUIController_OnCloseSystemInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_testUIController.HideSystemInfo();
		}

		// Token: 0x060141BA RID: 82362 RVA: 0x0051FAAC File Offset: 0x0051DCAC
		private void TestUIController_OnClearUserGuide()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUIController_OnClearUserGuide_hotfix != null)
			{
				this.m_TestUIController_OnClearUserGuide_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.SendUserGuideClearReq();
		}

		// Token: 0x060141BB RID: 82363 RVA: 0x0051FB24 File Offset: 0x0051DD24
		private void TestUIController_OnCompleteUserGuide()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUIController_OnCompleteUserGuide_hotfix != null)
			{
				this.m_TestUIController_OnCompleteUserGuide_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TestUI.SendGMCommand("COMPLETE_ALLUSERGUIDE");
		}

		// Token: 0x060141BC RID: 82364 RVA: 0x0051FB90 File Offset: 0x0051DD90
		private void TestUIController_OnClearStage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUIController_OnClearStage_hotfix != null)
			{
				this.m_TestUIController_OnClearStage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			TestUI.SendGMCommand("CLEAR_STAGE 0");
		}

		// Token: 0x060141BD RID: 82365 RVA: 0x0051FBFC File Offset: 0x0051DDFC
		private void TestUIController_OnShowGoddessDialog()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TestUIController_OnShowGoddessDialog_hotfix != null)
			{
				this.m_TestUIController_OnShowGoddessDialog_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartGoddessDialogUITask();
		}

		// Token: 0x1400046F RID: 1135
		// (add) Token: 0x060141BE RID: 82366 RVA: 0x0051FC64 File Offset: 0x0051DE64
		// (remove) Token: 0x060141BF RID: 82367 RVA: 0x0051FD00 File Offset: 0x0051DF00
		public event Action<ConfigDataBattleInfo> EventOnStartBattle
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartBattleAction`1_hotfix != null)
				{
					this.m_add_EventOnStartBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataBattleInfo> action = this.EventOnStartBattle;
				Action<ConfigDataBattleInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataBattleInfo>>(ref this.EventOnStartBattle, (Action<ConfigDataBattleInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartBattleAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartBattleAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataBattleInfo> action = this.EventOnStartBattle;
				Action<ConfigDataBattleInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataBattleInfo>>(ref this.EventOnStartBattle, (Action<ConfigDataBattleInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003C00 RID: 15360
		// (get) Token: 0x060141C0 RID: 82368 RVA: 0x0051FD9C File Offset: 0x0051DF9C
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x17003C01 RID: 15361
		// (get) Token: 0x060141C1 RID: 82369 RVA: 0x0051FE10 File Offset: 0x0051E010
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x060141C2 RID: 82370 RVA: 0x0051FE84 File Offset: 0x0051E084
		// (set) Token: 0x060141C3 RID: 82371 RVA: 0x0051FEA4 File Offset: 0x0051E0A4
		[DoNotToLua]
		public new TestUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TestUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060141C4 RID: 82372 RVA: 0x0051FEB0 File Offset: 0x0051E0B0
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x060141C5 RID: 82373 RVA: 0x0051FEBC File Offset: 0x0051E0BC
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060141C6 RID: 82374 RVA: 0x0051FEC4 File Offset: 0x0051E0C4
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060141C7 RID: 82375 RVA: 0x0051FECC File Offset: 0x0051E0CC
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x060141C8 RID: 82376 RVA: 0x0051FED8 File Offset: 0x0051E0D8
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x060141C9 RID: 82377 RVA: 0x0051FEE4 File Offset: 0x0051E0E4
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x060141CA RID: 82378 RVA: 0x0051FEF0 File Offset: 0x0051E0F0
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060141CB RID: 82379 RVA: 0x0051FEF8 File Offset: 0x0051E0F8
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060141CC RID: 82380 RVA: 0x0051FF00 File Offset: 0x0051E100
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x060141CD RID: 82381 RVA: 0x0051FF08 File Offset: 0x0051E108
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x060141CE RID: 82382 RVA: 0x0051FF10 File Offset: 0x0051E110
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060141CF RID: 82383 RVA: 0x0051FF18 File Offset: 0x0051E118
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x060141D0 RID: 82384 RVA: 0x0051FF20 File Offset: 0x0051E120
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x060141D1 RID: 82385 RVA: 0x0051FF28 File Offset: 0x0051E128
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x060141D2 RID: 82386 RVA: 0x0051FF34 File Offset: 0x0051E134
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060141D3 RID: 82387 RVA: 0x0051FF40 File Offset: 0x0051E140
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060141D4 RID: 82388 RVA: 0x0051FF4C File Offset: 0x0051E14C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060141D5 RID: 82389 RVA: 0x0051FF58 File Offset: 0x0051E158
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060141D6 RID: 82390 RVA: 0x0051FF60 File Offset: 0x0051E160
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060141D7 RID: 82391 RVA: 0x0051FF68 File Offset: 0x0051E168
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060141D8 RID: 82392 RVA: 0x0051FF70 File Offset: 0x0051E170
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060141D9 RID: 82393 RVA: 0x0051FF78 File Offset: 0x0051E178
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060141DA RID: 82394 RVA: 0x0051FF80 File Offset: 0x0051E180
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060141DB RID: 82395 RVA: 0x0051FF88 File Offset: 0x0051E188
		private void __callDele_EventOnStartBattle(ConfigDataBattleInfo obj)
		{
			Action<ConfigDataBattleInfo> eventOnStartBattle = this.EventOnStartBattle;
			if (eventOnStartBattle != null)
			{
				eventOnStartBattle(obj);
			}
		}

		// Token: 0x060141DC RID: 82396 RVA: 0x0051FFAC File Offset: 0x0051E1AC
		private void __clearDele_EventOnStartBattle(ConfigDataBattleInfo obj)
		{
			this.EventOnStartBattle = null;
		}

		// Token: 0x060141DD RID: 82397 RVA: 0x0051FFB8 File Offset: 0x0051E1B8
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitTestUIController_hotfix = (luaObj.RawGet("InitTestUIController") as LuaFunction);
					this.m_UninitTestUIController_hotfix = (luaObj.RawGet("UninitTestUIController") as LuaFunction);
					this.m_OnReportBugStringDouble_hotfix = (luaObj.RawGet("OnReportBug") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdateTestList_hotfix = (luaObj.RawGet("UpdateTestList") as LuaFunction);
					this.m_StartDialogUITaskConfigDataDialogInfo_hotfix = (luaObj.RawGet("StartDialogUITask") as LuaFunction);
					this.m_StartBattleDialogUITaskConfigDataBattleDialogInfo_hotfix = (luaObj.RawGet("StartBattleDialogUITask") as LuaFunction);
					this.m_StartUserGuideDialogUITaskConfigDataUserGuideDialogInfo_hotfix = (luaObj.RawGet("StartUserGuideDialogUITask") as LuaFunction);
					this.m_StartGoddessDialogUITask_hotfix = (luaObj.RawGet("StartGoddessDialogUITask") as LuaFunction);
					this.m_TestUIController_OnChangeTestListTestListType_hotfix = (luaObj.RawGet("TestUIController_OnChangeTestList") as LuaFunction);
					this.m_TestUIController_OnStartTestInt32_hotfix = (luaObj.RawGet("TestUIController_OnStartTest") as LuaFunction);
					this.m_TestUIController_OnReturn_hotfix = (luaObj.RawGet("TestUIController_OnReturn") as LuaFunction);
					this.m_TestUIController_OnShowSystemInfo_hotfix = (luaObj.RawGet("TestUIController_OnShowSystemInfo") as LuaFunction);
					this.m_TestUIController_OnCloseSystemInfo_hotfix = (luaObj.RawGet("TestUIController_OnCloseSystemInfo") as LuaFunction);
					this.m_TestUIController_OnClearUserGuide_hotfix = (luaObj.RawGet("TestUIController_OnClearUserGuide") as LuaFunction);
					this.m_TestUIController_OnCompleteUserGuide_hotfix = (luaObj.RawGet("TestUIController_OnCompleteUserGuide") as LuaFunction);
					this.m_TestUIController_OnClearStage_hotfix = (luaObj.RawGet("TestUIController_OnClearStage") as LuaFunction);
					this.m_TestUIController_OnShowGoddessDialog_hotfix = (luaObj.RawGet("TestUIController_OnShowGoddessDialog") as LuaFunction);
					this.m_add_EventOnStartBattleAction`1_hotfix = (luaObj.RawGet("add_EventOnStartBattle") as LuaFunction);
					this.m_remove_EventOnStartBattleAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartBattle") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060141DE RID: 82398 RVA: 0x005202F4 File Offset: 0x0051E4F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TestUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B1BB RID: 45499
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "TestUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Test_ABS/Prefab/TestUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B1BC RID: 45500
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "TestUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.TestUIController"),
				m_ctrlName = "TestUIController"
			}
		};

		// Token: 0x0400B1BD RID: 45501
		private TestUIController m_testUIController;

		// Token: 0x0400B1BE RID: 45502
		[DoNotToLua]
		private TestUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B1BF RID: 45503
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B1C0 RID: 45504
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B1C1 RID: 45505
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B1C2 RID: 45506
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400B1C3 RID: 45507
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B1C4 RID: 45508
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B1C5 RID: 45509
		private LuaFunction m_InitTestUIController_hotfix;

		// Token: 0x0400B1C6 RID: 45510
		private LuaFunction m_UninitTestUIController_hotfix;

		// Token: 0x0400B1C7 RID: 45511
		private LuaFunction m_OnReportBugStringDouble_hotfix;

		// Token: 0x0400B1C8 RID: 45512
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B1C9 RID: 45513
		private LuaFunction m_UpdateTestList_hotfix;

		// Token: 0x0400B1CA RID: 45514
		private LuaFunction m_StartDialogUITaskConfigDataDialogInfo_hotfix;

		// Token: 0x0400B1CB RID: 45515
		private LuaFunction m_StartBattleDialogUITaskConfigDataBattleDialogInfo_hotfix;

		// Token: 0x0400B1CC RID: 45516
		private LuaFunction m_StartUserGuideDialogUITaskConfigDataUserGuideDialogInfo_hotfix;

		// Token: 0x0400B1CD RID: 45517
		private LuaFunction m_StartGoddessDialogUITask_hotfix;

		// Token: 0x0400B1CE RID: 45518
		private LuaFunction m_TestUIController_OnChangeTestListTestListType_hotfix;

		// Token: 0x0400B1CF RID: 45519
		private LuaFunction m_TestUIController_OnStartTestInt32_hotfix;

		// Token: 0x0400B1D0 RID: 45520
		private LuaFunction m_TestUIController_OnReturn_hotfix;

		// Token: 0x0400B1D1 RID: 45521
		private LuaFunction m_TestUIController_OnShowSystemInfo_hotfix;

		// Token: 0x0400B1D2 RID: 45522
		private LuaFunction m_TestUIController_OnCloseSystemInfo_hotfix;

		// Token: 0x0400B1D3 RID: 45523
		private LuaFunction m_TestUIController_OnClearUserGuide_hotfix;

		// Token: 0x0400B1D4 RID: 45524
		private LuaFunction m_TestUIController_OnCompleteUserGuide_hotfix;

		// Token: 0x0400B1D5 RID: 45525
		private LuaFunction m_TestUIController_OnClearStage_hotfix;

		// Token: 0x0400B1D6 RID: 45526
		private LuaFunction m_TestUIController_OnShowGoddessDialog_hotfix;

		// Token: 0x0400B1D7 RID: 45527
		private LuaFunction m_add_EventOnStartBattleAction;

		// Token: 0x0400B1D8 RID: 45528
		private LuaFunction m_remove_EventOnStartBattleAction;

		// Token: 0x0400B1D9 RID: 45529
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B1DA RID: 45530
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000FBB RID: 4027
		public new class LuaExportHelper
		{
			// Token: 0x060141DF RID: 82399 RVA: 0x0052035C File Offset: 0x0051E55C
			public LuaExportHelper(TestUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060141E0 RID: 82400 RVA: 0x0052036C File Offset: 0x0051E56C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060141E1 RID: 82401 RVA: 0x0052037C File Offset: 0x0051E57C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060141E2 RID: 82402 RVA: 0x0052038C File Offset: 0x0051E58C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060141E3 RID: 82403 RVA: 0x0052039C File Offset: 0x0051E59C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060141E4 RID: 82404 RVA: 0x005203AC File Offset: 0x0051E5AC
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060141E5 RID: 82405 RVA: 0x005203BC File Offset: 0x0051E5BC
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060141E6 RID: 82406 RVA: 0x005203CC File Offset: 0x0051E5CC
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060141E7 RID: 82407 RVA: 0x005203DC File Offset: 0x0051E5DC
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060141E8 RID: 82408 RVA: 0x005203EC File Offset: 0x0051E5EC
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060141E9 RID: 82409 RVA: 0x005203FC File Offset: 0x0051E5FC
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060141EA RID: 82410 RVA: 0x0052040C File Offset: 0x0051E60C
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060141EB RID: 82411 RVA: 0x0052041C File Offset: 0x0051E61C
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060141EC RID: 82412 RVA: 0x0052042C File Offset: 0x0051E62C
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060141ED RID: 82413 RVA: 0x0052043C File Offset: 0x0051E63C
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060141EE RID: 82414 RVA: 0x0052044C File Offset: 0x0051E64C
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060141EF RID: 82415 RVA: 0x0052045C File Offset: 0x0051E65C
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060141F0 RID: 82416 RVA: 0x0052046C File Offset: 0x0051E66C
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060141F1 RID: 82417 RVA: 0x0052047C File Offset: 0x0051E67C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060141F2 RID: 82418 RVA: 0x0052048C File Offset: 0x0051E68C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060141F3 RID: 82419 RVA: 0x0052049C File Offset: 0x0051E69C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060141F4 RID: 82420 RVA: 0x005204AC File Offset: 0x0051E6AC
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060141F5 RID: 82421 RVA: 0x005204BC File Offset: 0x0051E6BC
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060141F6 RID: 82422 RVA: 0x005204CC File Offset: 0x0051E6CC
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x060141F7 RID: 82423 RVA: 0x005204DC File Offset: 0x0051E6DC
			public void __callDele_EventOnStartBattle(ConfigDataBattleInfo obj)
			{
				this.m_owner.__callDele_EventOnStartBattle(obj);
			}

			// Token: 0x060141F8 RID: 82424 RVA: 0x005204EC File Offset: 0x0051E6EC
			public void __clearDele_EventOnStartBattle(ConfigDataBattleInfo obj)
			{
				this.m_owner.__clearDele_EventOnStartBattle(obj);
			}

			// Token: 0x17003C03 RID: 15363
			// (get) Token: 0x060141F9 RID: 82425 RVA: 0x005204FC File Offset: 0x0051E6FC
			// (set) Token: 0x060141FA RID: 82426 RVA: 0x0052050C File Offset: 0x0051E70C
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x17003C04 RID: 15364
			// (get) Token: 0x060141FB RID: 82427 RVA: 0x0052051C File Offset: 0x0051E71C
			// (set) Token: 0x060141FC RID: 82428 RVA: 0x0052052C File Offset: 0x0051E72C
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x17003C05 RID: 15365
			// (get) Token: 0x060141FD RID: 82429 RVA: 0x0052053C File Offset: 0x0051E73C
			// (set) Token: 0x060141FE RID: 82430 RVA: 0x0052054C File Offset: 0x0051E74C
			public TestUIController m_testUIController
			{
				get
				{
					return this.m_owner.m_testUIController;
				}
				set
				{
					this.m_owner.m_testUIController = value;
				}
			}

			// Token: 0x17003C06 RID: 15366
			// (get) Token: 0x060141FF RID: 82431 RVA: 0x0052055C File Offset: 0x0051E75C
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003C07 RID: 15367
			// (get) Token: 0x06014200 RID: 82432 RVA: 0x0052056C File Offset: 0x0051E76C
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06014201 RID: 82433 RVA: 0x0052057C File Offset: 0x0051E77C
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x06014202 RID: 82434 RVA: 0x0052058C File Offset: 0x0051E78C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06014203 RID: 82435 RVA: 0x0052059C File Offset: 0x0051E79C
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06014204 RID: 82436 RVA: 0x005205AC File Offset: 0x0051E7AC
			public void InitTestUIController()
			{
				this.m_owner.InitTestUIController();
			}

			// Token: 0x06014205 RID: 82437 RVA: 0x005205BC File Offset: 0x0051E7BC
			public void UninitTestUIController()
			{
				this.m_owner.UninitTestUIController();
			}

			// Token: 0x06014206 RID: 82438 RVA: 0x005205CC File Offset: 0x0051E7CC
			public void OnReportBug(string bugDesc, double logFileHours)
			{
				this.m_owner.OnReportBug(bugDesc, logFileHours);
			}

			// Token: 0x06014207 RID: 82439 RVA: 0x005205DC File Offset: 0x0051E7DC
			public static IEnumerator UploadFile(string localFilepath, string uploadURL, string serverFilename)
			{
				return TestUITask.UploadFile(localFilepath, uploadURL, serverFilename);
			}

			// Token: 0x06014208 RID: 82440 RVA: 0x005205E8 File Offset: 0x0051E7E8
			public static byte[] Byte2HexByte(byte[] bytes)
			{
				return TestUITask.Byte2HexByte(bytes);
			}

			// Token: 0x06014209 RID: 82441 RVA: 0x005205F0 File Offset: 0x0051E7F0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0601420A RID: 82442 RVA: 0x00520600 File Offset: 0x0051E800
			public void UpdateTestList()
			{
				this.m_owner.UpdateTestList();
			}

			// Token: 0x0601420B RID: 82443 RVA: 0x00520610 File Offset: 0x0051E810
			public void StartDialogUITask(ConfigDataDialogInfo dialogInfo)
			{
				this.m_owner.StartDialogUITask(dialogInfo);
			}

			// Token: 0x0601420C RID: 82444 RVA: 0x00520620 File Offset: 0x0051E820
			public void StartBattleDialogUITask(ConfigDataBattleDialogInfo dialogInfo)
			{
				this.m_owner.StartBattleDialogUITask(dialogInfo);
			}

			// Token: 0x0601420D RID: 82445 RVA: 0x00520630 File Offset: 0x0051E830
			public void StartUserGuideDialogUITask(ConfigDataUserGuideDialogInfo dialogInfo)
			{
				this.m_owner.StartUserGuideDialogUITask(dialogInfo);
			}

			// Token: 0x0601420E RID: 82446 RVA: 0x00520640 File Offset: 0x0051E840
			public void StartGoddessDialogUITask()
			{
				this.m_owner.StartGoddessDialogUITask();
			}

			// Token: 0x0601420F RID: 82447 RVA: 0x00520650 File Offset: 0x0051E850
			public void TestUIController_OnChangeTestList(TestListType listType)
			{
				this.m_owner.TestUIController_OnChangeTestList(listType);
			}

			// Token: 0x06014210 RID: 82448 RVA: 0x00520660 File Offset: 0x0051E860
			public void TestUIController_OnStartTest(int id)
			{
				this.m_owner.TestUIController_OnStartTest(id);
			}

			// Token: 0x06014211 RID: 82449 RVA: 0x00520670 File Offset: 0x0051E870
			public void TestUIController_OnReturn()
			{
				this.m_owner.TestUIController_OnReturn();
			}

			// Token: 0x06014212 RID: 82450 RVA: 0x00520680 File Offset: 0x0051E880
			public void TestUIController_OnShowSystemInfo()
			{
				this.m_owner.TestUIController_OnShowSystemInfo();
			}

			// Token: 0x06014213 RID: 82451 RVA: 0x00520690 File Offset: 0x0051E890
			public void TestUIController_OnCloseSystemInfo()
			{
				this.m_owner.TestUIController_OnCloseSystemInfo();
			}

			// Token: 0x06014214 RID: 82452 RVA: 0x005206A0 File Offset: 0x0051E8A0
			public void TestUIController_OnClearUserGuide()
			{
				this.m_owner.TestUIController_OnClearUserGuide();
			}

			// Token: 0x06014215 RID: 82453 RVA: 0x005206B0 File Offset: 0x0051E8B0
			public void TestUIController_OnCompleteUserGuide()
			{
				this.m_owner.TestUIController_OnCompleteUserGuide();
			}

			// Token: 0x06014216 RID: 82454 RVA: 0x005206C0 File Offset: 0x0051E8C0
			public void TestUIController_OnClearStage()
			{
				this.m_owner.TestUIController_OnClearStage();
			}

			// Token: 0x06014217 RID: 82455 RVA: 0x005206D0 File Offset: 0x0051E8D0
			public void TestUIController_OnShowGoddessDialog()
			{
				this.m_owner.TestUIController_OnShowGoddessDialog();
			}

			// Token: 0x0400B1DB RID: 45531
			private TestUITask m_owner;
		}
	}
}
