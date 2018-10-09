using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using PD.SDK;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CD4 RID: 3284
	[HotFix]
	public class GoddessDialogUITask : UITask
	{
		// Token: 0x0600EEF7 RID: 61175 RVA: 0x003FBAD8 File Offset: 0x003F9CD8
		public GoddessDialogUITask(string name) : base(name)
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

		// Token: 0x0600EEF8 RID: 61176 RVA: 0x003FBBD4 File Offset: 0x003F9DD4
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			AudioUtility.PlaySound(configDataLoader.UtilityGetSound(SoundTableId.SoundTableId_GoddessDialogMusic));
			NoticeUIController.IsForceHide = true;
			return base.OnStart(intent);
		}

		// Token: 0x0600EEF9 RID: 61177 RVA: 0x003FBC7C File Offset: 0x003F9E7C
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			NoticeUIController.IsForceHide = false;
			base.OnStop();
		}

		// Token: 0x0600EEFA RID: 61178 RVA: 0x003FBCE8 File Offset: 0x003F9EE8
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAssetList();
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (this.m_goddessCharImageInfo == null)
			{
				int key = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_GoddessCharImageId);
				this.m_goddessCharImageInfo = configDataLoader.GetConfigDataCharImageInfo(key);
				if (this.m_goddessCharImageInfo != null)
				{
					base.CollectAsset(this.m_goddessCharImageInfo.Spine);
				}
			}
			if (this.m_heroInfo == null)
			{
				this.m_heroInfo = configDataLoader.GetConfigDataHeroInfo(configDataLoader.ConfigableConstId_ProtagonistHeroID);
				ConfigDataCharImageInfo charImageInfo = this.m_heroInfo.GetCharImageInfo(this.m_heroInfo.Star);
				if (charImageInfo != null)
				{
					base.CollectSpriteAsset(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
				}
			}
			if (this.m_startDialogId == 0)
			{
				this.InitDialogId();
				this.m_dialogInfo = configDataLoader.GetConfigDataGoddessDialogInfo(this.m_startDialogId);
				if (this.m_dialogInfo != null)
				{
				}
				this.InitJobChoiceValues();
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600EEFB RID: 61179 RVA: 0x003FBE34 File Offset: 0x003FA034
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
			this.InitGoddessDialogUIController();
			Utility.LogMemorySize("GoddessDialogUITask.InitAllUIControllers");
		}

		// Token: 0x0600EEFC RID: 61180 RVA: 0x003FBEAC File Offset: 0x003FA0AC
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
			this.UninitGoddessDialogUIController();
		}

		// Token: 0x0600EEFD RID: 61181 RVA: 0x003FBF18 File Offset: 0x003FA118
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
			if (this.m_dialogInfo != null)
			{
				this.m_goddessDialogUIController.CreateChar(this.m_goddessCharImageInfo);
				this.m_goddessDialogUIController.SetDialog(this.m_dialogInfo);
			}
		}

		// Token: 0x0600EEFE RID: 61182 RVA: 0x003FBFA8 File Offset: 0x003FA1A8
		private void InitGoddessDialogUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGoddessDialogUIController_hotfix != null)
			{
				this.m_InitGoddessDialogUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_goddessDialogUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_goddessDialogUIController = (this.m_uiCtrlArray[0] as GoddessDialogUIController);
				}
				if (!(this.m_goddessDialogUIController != null))
				{
					global::Debug.LogError("GoddessDialogUIController is null");
					return;
				}
				this.m_goddessDialogUIController.EventOnNext += this.GoddessDialogUIController_OnNext;
				this.m_goddessDialogUIController.EventOnClose += this.GoddessDialogUIController_OnClose;
				this.m_goddessDialogUIController.EventOnChoose += this.GoddessDialogUIController_OnChoose;
				this.m_goddessDialogUIController.EventOnShowJobInfo += this.GoddessDialogUIController_OnShowJobInfo;
				this.m_goddessDialogUIController.EventOnConfirmJob += this.GoddessDialogUIController_OnConfirmJob;
				this.m_goddessDialogUIController.EventOnRetry += this.GoddessDialogUIController_OnRetry;
				this.m_goddessDialogUIController.EventOnSelectJob += this.GoddessDialogUIController_OnSelectJob;
				this.m_goddessDialogUIController.EventOnPrevJob += this.GoddessDialogUIController_OnPrevJob;
				this.m_goddessDialogUIController.EventOnNextJob += this.GoddessDialogUIController_OnNextJob;
			}
		}

		// Token: 0x0600EEFF RID: 61183 RVA: 0x003FC12C File Offset: 0x003FA32C
		private void UninitGoddessDialogUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitGoddessDialogUIController_hotfix != null)
			{
				this.m_UninitGoddessDialogUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_goddessDialogUIController != null)
			{
				this.m_goddessDialogUIController.EventOnNext -= this.GoddessDialogUIController_OnNext;
				this.m_goddessDialogUIController.EventOnClose -= this.GoddessDialogUIController_OnClose;
				this.m_goddessDialogUIController.EventOnChoose -= this.GoddessDialogUIController_OnChoose;
				this.m_goddessDialogUIController.EventOnShowJobInfo -= this.GoddessDialogUIController_OnShowJobInfo;
				this.m_goddessDialogUIController.EventOnConfirmJob -= this.GoddessDialogUIController_OnConfirmJob;
				this.m_goddessDialogUIController.EventOnRetry -= this.GoddessDialogUIController_OnRetry;
				this.m_goddessDialogUIController.EventOnSelectJob -= this.GoddessDialogUIController_OnSelectJob;
				this.m_goddessDialogUIController.EventOnPrevJob -= this.GoddessDialogUIController_OnPrevJob;
				this.m_goddessDialogUIController.EventOnNextJob -= this.GoddessDialogUIController_OnNextJob;
				this.m_goddessDialogUIController = null;
			}
		}

		// Token: 0x0600EF00 RID: 61184 RVA: 0x003FC274 File Offset: 0x003FA474
		private void InitDialogId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDialogId_hotfix != null)
			{
				this.m_InitDialogId_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_startDialogId = 0;
			this.m_questionStartDialogId = 0;
			this.m_selectDialogId = 0;
			this.m_finalDialogId = 0;
			foreach (KeyValuePair<int, ConfigDataGoddessDialogInfo> keyValuePair in configDataLoader.GetAllConfigDataGoddessDialogInfo())
			{
				if (keyValuePair.Value.FunctionType == GoddessDialogFuncType.GoddessDialogFuncType_Start)
				{
					this.m_startDialogId = keyValuePair.Key;
				}
				else if (keyValuePair.Value.FunctionType == GoddessDialogFuncType.GoddessDialogFuncType_QuestionStart)
				{
					this.m_questionStartDialogId = keyValuePair.Key;
				}
				else if (keyValuePair.Value.FunctionType == GoddessDialogFuncType.GoddessDialogFuncType_Select)
				{
					this.m_selectDialogId = keyValuePair.Key;
				}
				else if (keyValuePair.Value.FunctionType == GoddessDialogFuncType.GoddessDialogFuncType_Final)
				{
					this.m_finalDialogId = keyValuePair.Key;
				}
			}
		}

		// Token: 0x0600EF01 RID: 61185 RVA: 0x003FC3D0 File Offset: 0x003FA5D0
		private void InitJobChoiceValues()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitJobChoiceValues_hotfix != null)
			{
				this.m_InitJobChoiceValues_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_jobChoiceValues.Clear();
			foreach (KeyValuePair<int, ConfigDataProtagonistInfo> keyValuePair in configDataLoader.GetAllConfigDataProtagonistInfo())
			{
				GoddessDialogUITask.JobChoiceValue item = new GoddessDialogUITask.JobChoiceValue
				{
					m_protagonistInfo = keyValuePair.Value,
					m_value = 0
				};
				this.m_jobChoiceValues.Add(item);
			}
		}

		// Token: 0x0600EF02 RID: 61186 RVA: 0x003FC4BC File Offset: 0x003FA6BC
		private void AppendChoiceValues(List<ChoiceValue> choiceValues)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppendChoiceValuesList`1_hotfix != null)
			{
				this.m_AppendChoiceValuesList`1_hotfix.call(new object[]
				{
					this,
					choiceValues
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ChoiceValue choiceValue in choiceValues)
			{
				foreach (GoddessDialogUITask.JobChoiceValue jobChoiceValue in this.m_jobChoiceValues)
				{
					if (jobChoiceValue.m_protagonistInfo.ID == choiceValue.Id)
					{
						jobChoiceValue.m_value += choiceValue.Value;
						break;
					}
				}
			}
		}

		// Token: 0x0600EF03 RID: 61187 RVA: 0x003FC5E4 File Offset: 0x003FA7E4
		private void ShowJobs(int idx, bool canSelect)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowJobsInt32Boolean_hotfix != null)
			{
				this.m_ShowJobsInt32Boolean_hotfix.call(new object[]
				{
					this,
					idx,
					canSelect
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (idx < 0 || idx >= this.m_jobChoiceValues.Count)
			{
				return;
			}
			base.ClearAssetList();
			ConfigDataProtagonistInfo protagonistInfo = this.m_jobChoiceValues[idx].m_protagonistInfo;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			List<ConfigDataJobConnectionInfo> jobConnectionInfos = new List<ConfigDataJobConnectionInfo>();
			foreach (int key in protagonistInfo.UseableJobConnections_ID)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(key);
				if (configDataJobConnectionInfo != null)
				{
					jobConnectionInfos.Add(configDataJobConnectionInfo);
					base.CollectAsset(configDataJobConnectionInfo.Model);
				}
			}
			bool hasPrev = false;
			bool hasNext = false;
			if (canSelect)
			{
				hasPrev = (idx > 0);
				hasNext = (idx < this.m_jobChoiceValues.Count - 1);
			}
			base.StartLoadCustomAssets(delegate
			{
				this.m_goddessDialogUIController.ShowJobs(this.m_heroInfo, jobConnectionInfos, hasPrev, hasNext);
			});
		}

		// Token: 0x0600EF04 RID: 61188 RVA: 0x003FC778 File Offset: 0x003FA978
		private void StartDialog(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartDialogInt32_hotfix != null)
			{
				this.m_StartDialogInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_dialogInfo = configDataLoader.GetConfigDataGoddessDialogInfo(id);
			if (this.m_dialogInfo != null)
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x0600EF05 RID: 61189 RVA: 0x003FC81C File Offset: 0x003FAA1C
		private void ShowResultJobs()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowResultJobs_hotfix != null)
			{
				this.m_ShowResultJobs_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = int.MinValue;
			int num2 = -1;
			for (int i = 0; i < this.m_jobChoiceValues.Count; i++)
			{
				int value = this.m_jobChoiceValues[i].m_value;
				if (value > num)
				{
					num2 = i;
					num = value;
				}
			}
			if (num2 >= 0)
			{
				this.m_curJobIndex = num2;
				this.ShowJobs(this.m_curJobIndex, false);
			}
		}

		// Token: 0x0600EF06 RID: 61190 RVA: 0x003FC8D8 File Offset: 0x003FAAD8
		private void GoddessDialogUIController_OnNext()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUIController_OnNext_hotfix != null)
			{
				this.m_GoddessDialogUIController_OnNext_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_dialogInfo != null && this.m_dialogInfo.m_nextDialogInfo != null)
			{
				if (this.m_dialogInfo.m_nextDialogInfo.FunctionType == GoddessDialogFuncType.GoddessDialogFuncType_Result)
				{
					this.ShowResultJobs();
				}
				this.StartDialog(this.m_dialogInfo.NextDialog_ID);
			}
			else
			{
				this.m_goddessDialogUIController.CloseDialog();
				CommonUIController.Instance.FadeOut(0.5f, Color.white, null);
			}
		}

		// Token: 0x0600EF07 RID: 61191 RVA: 0x003FC9A8 File Offset: 0x003FABA8
		private void GoddessDialogUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUIController_OnClose_hotfix != null)
			{
				this.m_GoddessDialogUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Stop();
			base.ReturnPrevUITask();
			CommonUIController.Instance.FadeIn(0.5f, Color.white, null);
			if (this.EventOnClose != null)
			{
				this.EventOnClose(this.m_protagonistId);
			}
		}

		// Token: 0x0600EF08 RID: 61192 RVA: 0x003FCA48 File Offset: 0x003FAC48
		private void GoddessDialogUIController_OnChoose(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUIController_OnChooseInt32_hotfix != null)
			{
				this.m_GoddessDialogUIController_OnChooseInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_dialogInfo == null)
			{
				return;
			}
			int num = 0;
			if (index == 0)
			{
				this.AppendChoiceValues(this.m_dialogInfo.Choice1Value);
				num = this.m_dialogInfo.Choice1NextDialog_ID;
			}
			else if (index == 1)
			{
				this.AppendChoiceValues(this.m_dialogInfo.Choice2Value);
				num = this.m_dialogInfo.Choice2NextDialog_ID;
			}
			else if (index == 2)
			{
				this.AppendChoiceValues(this.m_dialogInfo.Choice3Value);
				num = this.m_dialogInfo.Choice3NextDialog_ID;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataGoddessDialogInfo configDataGoddessDialogInfo = configDataLoader.GetConfigDataGoddessDialogInfo(num);
			if (configDataGoddessDialogInfo != null && configDataGoddessDialogInfo.FunctionType == GoddessDialogFuncType.GoddessDialogFuncType_Result)
			{
				this.ShowResultJobs();
			}
			this.StartDialog(num);
		}

		// Token: 0x0600EF09 RID: 61193 RVA: 0x003FCB74 File Offset: 0x003FAD74
		private void GoddessDialogUIController_OnShowJobInfo(ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUIController_OnShowJobInfoConfigDataJobConnectionInfo_hotfix != null)
			{
				this.m_GoddessDialogUIController_OnShowJobInfoConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600EF0A RID: 61194 RVA: 0x003FCBE4 File Offset: 0x003FADE4
		private void GoddessDialogUIController_OnConfirmJob()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUIController_OnConfirmJob_hotfix != null)
			{
				this.m_GoddessDialogUIController_OnConfirmJob_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.printGameEventLog("30", string.Empty);
			this.m_goddessDialogUIController.HideJobConnections();
			this.StartDialog(this.m_finalDialogId);
			this.m_protagonistId = this.m_jobChoiceValues[this.m_curJobIndex].m_protagonistInfo.ID;
		}

		// Token: 0x0600EF0B RID: 61195 RVA: 0x003FCC90 File Offset: 0x003FAE90
		private void GoddessDialogUIController_OnRetry()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUIController_OnRetry_hotfix != null)
			{
				this.m_GoddessDialogUIController_OnRetry_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PDSDK.Instance.printGameEventLog("31", string.Empty);
			this.InitJobChoiceValues();
			this.m_goddessDialogUIController.HideJobConnections();
			this.StartDialog(this.m_questionStartDialogId);
		}

		// Token: 0x0600EF0C RID: 61196 RVA: 0x003FCD24 File Offset: 0x003FAF24
		private void GoddessDialogUIController_OnSelectJob()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUIController_OnSelectJob_hotfix != null)
			{
				this.m_GoddessDialogUIController_OnSelectJob_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartDialog(this.m_selectDialogId);
			this.ShowJobs(this.m_curJobIndex, true);
		}

		// Token: 0x0600EF0D RID: 61197 RVA: 0x003FCDA0 File Offset: 0x003FAFA0
		private void GoddessDialogUIController_OnPrevJob()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUIController_OnPrevJob_hotfix != null)
			{
				this.m_GoddessDialogUIController_OnPrevJob_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curJobIndex > 0)
			{
				this.m_curJobIndex--;
				this.ShowJobs(this.m_curJobIndex, true);
			}
		}

		// Token: 0x0600EF0E RID: 61198 RVA: 0x003FCE28 File Offset: 0x003FB028
		private void GoddessDialogUIController_OnNextJob()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GoddessDialogUIController_OnNextJob_hotfix != null)
			{
				this.m_GoddessDialogUIController_OnNextJob_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_curJobIndex < this.m_jobChoiceValues.Count - 1)
			{
				this.m_curJobIndex++;
				this.ShowJobs(this.m_curJobIndex, true);
			}
		}

		// Token: 0x14000329 RID: 809
		// (add) Token: 0x0600EF0F RID: 61199 RVA: 0x003FCEBC File Offset: 0x003FB0BC
		// (remove) Token: 0x0600EF10 RID: 61200 RVA: 0x003FCF58 File Offset: 0x003FB158
		public event Action<int> EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction`1_hotfix != null)
				{
					this.m_add_EventOnCloseAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnClose;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnClose, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction`1_hotfix != null)
				{
					this.m_remove_EventOnCloseAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.EventOnClose;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.EventOnClose, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002E06 RID: 11782
		// (get) Token: 0x0600EF11 RID: 61201 RVA: 0x003FCFF4 File Offset: 0x003FB1F4
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

		// Token: 0x17002E07 RID: 11783
		// (get) Token: 0x0600EF12 RID: 61202 RVA: 0x003FD068 File Offset: 0x003FB268
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

		// Token: 0x17002E08 RID: 11784
		// (get) Token: 0x0600EF13 RID: 61203 RVA: 0x003FD0DC File Offset: 0x003FB2DC
		// (set) Token: 0x0600EF14 RID: 61204 RVA: 0x003FD0FC File Offset: 0x003FB2FC
		[DoNotToLua]
		public new GoddessDialogUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GoddessDialogUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600EF15 RID: 61205 RVA: 0x003FD108 File Offset: 0x003FB308
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600EF16 RID: 61206 RVA: 0x003FD114 File Offset: 0x003FB314
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600EF17 RID: 61207 RVA: 0x003FD11C File Offset: 0x003FB31C
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600EF18 RID: 61208 RVA: 0x003FD124 File Offset: 0x003FB324
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600EF19 RID: 61209 RVA: 0x003FD130 File Offset: 0x003FB330
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600EF1A RID: 61210 RVA: 0x003FD13C File Offset: 0x003FB33C
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600EF1B RID: 61211 RVA: 0x003FD148 File Offset: 0x003FB348
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600EF1C RID: 61212 RVA: 0x003FD150 File Offset: 0x003FB350
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600EF1D RID: 61213 RVA: 0x003FD158 File Offset: 0x003FB358
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600EF1E RID: 61214 RVA: 0x003FD160 File Offset: 0x003FB360
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600EF1F RID: 61215 RVA: 0x003FD168 File Offset: 0x003FB368
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600EF20 RID: 61216 RVA: 0x003FD170 File Offset: 0x003FB370
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600EF21 RID: 61217 RVA: 0x003FD178 File Offset: 0x003FB378
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600EF22 RID: 61218 RVA: 0x003FD180 File Offset: 0x003FB380
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600EF23 RID: 61219 RVA: 0x003FD18C File Offset: 0x003FB38C
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600EF24 RID: 61220 RVA: 0x003FD198 File Offset: 0x003FB398
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600EF25 RID: 61221 RVA: 0x003FD1A4 File Offset: 0x003FB3A4
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600EF26 RID: 61222 RVA: 0x003FD1B0 File Offset: 0x003FB3B0
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600EF27 RID: 61223 RVA: 0x003FD1B8 File Offset: 0x003FB3B8
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600EF28 RID: 61224 RVA: 0x003FD1C0 File Offset: 0x003FB3C0
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600EF29 RID: 61225 RVA: 0x003FD1C8 File Offset: 0x003FB3C8
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600EF2A RID: 61226 RVA: 0x003FD1D0 File Offset: 0x003FB3D0
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600EF2B RID: 61227 RVA: 0x003FD1D8 File Offset: 0x003FB3D8
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600EF2C RID: 61228 RVA: 0x003FD1E0 File Offset: 0x003FB3E0
		private void __callDele_EventOnClose(int obj)
		{
			Action<int> eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose(obj);
			}
		}

		// Token: 0x0600EF2D RID: 61229 RVA: 0x003FD204 File Offset: 0x003FB404
		private void __clearDele_EventOnClose(int obj)
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600EF2E RID: 61230 RVA: 0x003FD210 File Offset: 0x003FB410
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_InitGoddessDialogUIController_hotfix = (luaObj.RawGet("InitGoddessDialogUIController") as LuaFunction);
					this.m_UninitGoddessDialogUIController_hotfix = (luaObj.RawGet("UninitGoddessDialogUIController") as LuaFunction);
					this.m_InitDialogId_hotfix = (luaObj.RawGet("InitDialogId") as LuaFunction);
					this.m_InitJobChoiceValues_hotfix = (luaObj.RawGet("InitJobChoiceValues") as LuaFunction);
					this.m_AppendChoiceValuesList`1_hotfix = (luaObj.RawGet("AppendChoiceValues") as LuaFunction);
					this.m_ShowJobsInt32Boolean_hotfix = (luaObj.RawGet("ShowJobs") as LuaFunction);
					this.m_StartDialogInt32_hotfix = (luaObj.RawGet("StartDialog") as LuaFunction);
					this.m_ShowResultJobs_hotfix = (luaObj.RawGet("ShowResultJobs") as LuaFunction);
					this.m_GoddessDialogUIController_OnNext_hotfix = (luaObj.RawGet("GoddessDialogUIController_OnNext") as LuaFunction);
					this.m_GoddessDialogUIController_OnClose_hotfix = (luaObj.RawGet("GoddessDialogUIController_OnClose") as LuaFunction);
					this.m_GoddessDialogUIController_OnChooseInt32_hotfix = (luaObj.RawGet("GoddessDialogUIController_OnChoose") as LuaFunction);
					this.m_GoddessDialogUIController_OnShowJobInfoConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("GoddessDialogUIController_OnShowJobInfo") as LuaFunction);
					this.m_GoddessDialogUIController_OnConfirmJob_hotfix = (luaObj.RawGet("GoddessDialogUIController_OnConfirmJob") as LuaFunction);
					this.m_GoddessDialogUIController_OnRetry_hotfix = (luaObj.RawGet("GoddessDialogUIController_OnRetry") as LuaFunction);
					this.m_GoddessDialogUIController_OnSelectJob_hotfix = (luaObj.RawGet("GoddessDialogUIController_OnSelectJob") as LuaFunction);
					this.m_GoddessDialogUIController_OnPrevJob_hotfix = (luaObj.RawGet("GoddessDialogUIController_OnPrevJob") as LuaFunction);
					this.m_GoddessDialogUIController_OnNextJob_hotfix = (luaObj.RawGet("GoddessDialogUIController_OnNextJob") as LuaFunction);
					this.m_add_EventOnCloseAction`1_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction`1_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600EF2F RID: 61231 RVA: 0x003FD580 File Offset: 0x003FB780
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GoddessDialogUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008E91 RID: 36497
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "GoddessDialogUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/GoddessDialog_ABS/Prefab/GoddessDialogUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04008E92 RID: 36498
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "GoddessDialogUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.GoddessDialogUIController"),
				m_ctrlName = "GoddessDialogUIController"
			}
		};

		// Token: 0x04008E93 RID: 36499
		private GoddessDialogUIController m_goddessDialogUIController;

		// Token: 0x04008E94 RID: 36500
		private ConfigDataGoddessDialogInfo m_dialogInfo;

		// Token: 0x04008E95 RID: 36501
		private ConfigDataHeroInfo m_heroInfo;

		// Token: 0x04008E96 RID: 36502
		private int m_curJobIndex;

		// Token: 0x04008E97 RID: 36503
		private List<GoddessDialogUITask.JobChoiceValue> m_jobChoiceValues = new List<GoddessDialogUITask.JobChoiceValue>();

		// Token: 0x04008E98 RID: 36504
		private int m_startDialogId;

		// Token: 0x04008E99 RID: 36505
		private int m_questionStartDialogId;

		// Token: 0x04008E9A RID: 36506
		private int m_selectDialogId;

		// Token: 0x04008E9B RID: 36507
		private int m_finalDialogId;

		// Token: 0x04008E9C RID: 36508
		private int m_protagonistId;

		// Token: 0x04008E9D RID: 36509
		private ConfigDataCharImageInfo m_goddessCharImageInfo;

		// Token: 0x04008E9E RID: 36510
		[DoNotToLua]
		private GoddessDialogUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04008E9F RID: 36511
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008EA0 RID: 36512
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008EA1 RID: 36513
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04008EA2 RID: 36514
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04008EA3 RID: 36515
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x04008EA4 RID: 36516
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04008EA5 RID: 36517
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04008EA6 RID: 36518
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04008EA7 RID: 36519
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008EA8 RID: 36520
		private LuaFunction m_InitGoddessDialogUIController_hotfix;

		// Token: 0x04008EA9 RID: 36521
		private LuaFunction m_UninitGoddessDialogUIController_hotfix;

		// Token: 0x04008EAA RID: 36522
		private LuaFunction m_InitDialogId_hotfix;

		// Token: 0x04008EAB RID: 36523
		private LuaFunction m_InitJobChoiceValues_hotfix;

		// Token: 0x04008EAC RID: 36524
		private LuaFunction m_AppendChoiceValuesList;

		// Token: 0x04008EAD RID: 36525
		private LuaFunction m_ShowJobsInt32Boolean_hotfix;

		// Token: 0x04008EAE RID: 36526
		private LuaFunction m_StartDialogInt32_hotfix;

		// Token: 0x04008EAF RID: 36527
		private LuaFunction m_ShowResultJobs_hotfix;

		// Token: 0x04008EB0 RID: 36528
		private LuaFunction m_GoddessDialogUIController_OnNext_hotfix;

		// Token: 0x04008EB1 RID: 36529
		private LuaFunction m_GoddessDialogUIController_OnClose_hotfix;

		// Token: 0x04008EB2 RID: 36530
		private LuaFunction m_GoddessDialogUIController_OnChooseInt32_hotfix;

		// Token: 0x04008EB3 RID: 36531
		private LuaFunction m_GoddessDialogUIController_OnShowJobInfoConfigDataJobConnectionInfo_hotfix;

		// Token: 0x04008EB4 RID: 36532
		private LuaFunction m_GoddessDialogUIController_OnConfirmJob_hotfix;

		// Token: 0x04008EB5 RID: 36533
		private LuaFunction m_GoddessDialogUIController_OnRetry_hotfix;

		// Token: 0x04008EB6 RID: 36534
		private LuaFunction m_GoddessDialogUIController_OnSelectJob_hotfix;

		// Token: 0x04008EB7 RID: 36535
		private LuaFunction m_GoddessDialogUIController_OnPrevJob_hotfix;

		// Token: 0x04008EB8 RID: 36536
		private LuaFunction m_GoddessDialogUIController_OnNextJob_hotfix;

		// Token: 0x04008EB9 RID: 36537
		private LuaFunction m_add_EventOnCloseAction;

		// Token: 0x04008EBA RID: 36538
		private LuaFunction m_remove_EventOnCloseAction;

		// Token: 0x04008EBB RID: 36539
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04008EBC RID: 36540
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000CD5 RID: 3285
		[HotFix]
		public class JobChoiceValue
		{
			// Token: 0x04008EBD RID: 36541
			public ConfigDataProtagonistInfo m_protagonistInfo;

			// Token: 0x04008EBE RID: 36542
			public int m_value;
		}

		// Token: 0x02000CD6 RID: 3286
		public new class LuaExportHelper
		{
			// Token: 0x0600EF31 RID: 61233 RVA: 0x003FD5F0 File Offset: 0x003FB7F0
			public LuaExportHelper(GoddessDialogUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600EF32 RID: 61234 RVA: 0x003FD600 File Offset: 0x003FB800
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600EF33 RID: 61235 RVA: 0x003FD610 File Offset: 0x003FB810
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600EF34 RID: 61236 RVA: 0x003FD620 File Offset: 0x003FB820
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600EF35 RID: 61237 RVA: 0x003FD630 File Offset: 0x003FB830
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600EF36 RID: 61238 RVA: 0x003FD640 File Offset: 0x003FB840
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600EF37 RID: 61239 RVA: 0x003FD650 File Offset: 0x003FB850
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600EF38 RID: 61240 RVA: 0x003FD660 File Offset: 0x003FB860
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600EF39 RID: 61241 RVA: 0x003FD670 File Offset: 0x003FB870
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600EF3A RID: 61242 RVA: 0x003FD680 File Offset: 0x003FB880
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600EF3B RID: 61243 RVA: 0x003FD690 File Offset: 0x003FB890
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600EF3C RID: 61244 RVA: 0x003FD6A0 File Offset: 0x003FB8A0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600EF3D RID: 61245 RVA: 0x003FD6B0 File Offset: 0x003FB8B0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600EF3E RID: 61246 RVA: 0x003FD6C0 File Offset: 0x003FB8C0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600EF3F RID: 61247 RVA: 0x003FD6D0 File Offset: 0x003FB8D0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600EF40 RID: 61248 RVA: 0x003FD6E0 File Offset: 0x003FB8E0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600EF41 RID: 61249 RVA: 0x003FD6F0 File Offset: 0x003FB8F0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600EF42 RID: 61250 RVA: 0x003FD700 File Offset: 0x003FB900
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600EF43 RID: 61251 RVA: 0x003FD710 File Offset: 0x003FB910
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600EF44 RID: 61252 RVA: 0x003FD720 File Offset: 0x003FB920
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600EF45 RID: 61253 RVA: 0x003FD730 File Offset: 0x003FB930
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600EF46 RID: 61254 RVA: 0x003FD740 File Offset: 0x003FB940
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600EF47 RID: 61255 RVA: 0x003FD750 File Offset: 0x003FB950
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600EF48 RID: 61256 RVA: 0x003FD760 File Offset: 0x003FB960
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600EF49 RID: 61257 RVA: 0x003FD770 File Offset: 0x003FB970
			public void __callDele_EventOnClose(int obj)
			{
				this.m_owner.__callDele_EventOnClose(obj);
			}

			// Token: 0x0600EF4A RID: 61258 RVA: 0x003FD780 File Offset: 0x003FB980
			public void __clearDele_EventOnClose(int obj)
			{
				this.m_owner.__clearDele_EventOnClose(obj);
			}

			// Token: 0x17002E09 RID: 11785
			// (get) Token: 0x0600EF4B RID: 61259 RVA: 0x003FD790 File Offset: 0x003FB990
			// (set) Token: 0x0600EF4C RID: 61260 RVA: 0x003FD7A0 File Offset: 0x003FB9A0
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

			// Token: 0x17002E0A RID: 11786
			// (get) Token: 0x0600EF4D RID: 61261 RVA: 0x003FD7B0 File Offset: 0x003FB9B0
			// (set) Token: 0x0600EF4E RID: 61262 RVA: 0x003FD7C0 File Offset: 0x003FB9C0
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

			// Token: 0x17002E0B RID: 11787
			// (get) Token: 0x0600EF4F RID: 61263 RVA: 0x003FD7D0 File Offset: 0x003FB9D0
			// (set) Token: 0x0600EF50 RID: 61264 RVA: 0x003FD7E0 File Offset: 0x003FB9E0
			public GoddessDialogUIController m_goddessDialogUIController
			{
				get
				{
					return this.m_owner.m_goddessDialogUIController;
				}
				set
				{
					this.m_owner.m_goddessDialogUIController = value;
				}
			}

			// Token: 0x17002E0C RID: 11788
			// (get) Token: 0x0600EF51 RID: 61265 RVA: 0x003FD7F0 File Offset: 0x003FB9F0
			// (set) Token: 0x0600EF52 RID: 61266 RVA: 0x003FD800 File Offset: 0x003FBA00
			public ConfigDataGoddessDialogInfo m_dialogInfo
			{
				get
				{
					return this.m_owner.m_dialogInfo;
				}
				set
				{
					this.m_owner.m_dialogInfo = value;
				}
			}

			// Token: 0x17002E0D RID: 11789
			// (get) Token: 0x0600EF53 RID: 61267 RVA: 0x003FD810 File Offset: 0x003FBA10
			// (set) Token: 0x0600EF54 RID: 61268 RVA: 0x003FD820 File Offset: 0x003FBA20
			public ConfigDataHeroInfo m_heroInfo
			{
				get
				{
					return this.m_owner.m_heroInfo;
				}
				set
				{
					this.m_owner.m_heroInfo = value;
				}
			}

			// Token: 0x17002E0E RID: 11790
			// (get) Token: 0x0600EF55 RID: 61269 RVA: 0x003FD830 File Offset: 0x003FBA30
			// (set) Token: 0x0600EF56 RID: 61270 RVA: 0x003FD840 File Offset: 0x003FBA40
			public int m_curJobIndex
			{
				get
				{
					return this.m_owner.m_curJobIndex;
				}
				set
				{
					this.m_owner.m_curJobIndex = value;
				}
			}

			// Token: 0x17002E0F RID: 11791
			// (get) Token: 0x0600EF57 RID: 61271 RVA: 0x003FD850 File Offset: 0x003FBA50
			// (set) Token: 0x0600EF58 RID: 61272 RVA: 0x003FD860 File Offset: 0x003FBA60
			public List<GoddessDialogUITask.JobChoiceValue> m_jobChoiceValues
			{
				get
				{
					return this.m_owner.m_jobChoiceValues;
				}
				set
				{
					this.m_owner.m_jobChoiceValues = value;
				}
			}

			// Token: 0x17002E10 RID: 11792
			// (get) Token: 0x0600EF59 RID: 61273 RVA: 0x003FD870 File Offset: 0x003FBA70
			// (set) Token: 0x0600EF5A RID: 61274 RVA: 0x003FD880 File Offset: 0x003FBA80
			public int m_startDialogId
			{
				get
				{
					return this.m_owner.m_startDialogId;
				}
				set
				{
					this.m_owner.m_startDialogId = value;
				}
			}

			// Token: 0x17002E11 RID: 11793
			// (get) Token: 0x0600EF5B RID: 61275 RVA: 0x003FD890 File Offset: 0x003FBA90
			// (set) Token: 0x0600EF5C RID: 61276 RVA: 0x003FD8A0 File Offset: 0x003FBAA0
			public int m_questionStartDialogId
			{
				get
				{
					return this.m_owner.m_questionStartDialogId;
				}
				set
				{
					this.m_owner.m_questionStartDialogId = value;
				}
			}

			// Token: 0x17002E12 RID: 11794
			// (get) Token: 0x0600EF5D RID: 61277 RVA: 0x003FD8B0 File Offset: 0x003FBAB0
			// (set) Token: 0x0600EF5E RID: 61278 RVA: 0x003FD8C0 File Offset: 0x003FBAC0
			public int m_selectDialogId
			{
				get
				{
					return this.m_owner.m_selectDialogId;
				}
				set
				{
					this.m_owner.m_selectDialogId = value;
				}
			}

			// Token: 0x17002E13 RID: 11795
			// (get) Token: 0x0600EF5F RID: 61279 RVA: 0x003FD8D0 File Offset: 0x003FBAD0
			// (set) Token: 0x0600EF60 RID: 61280 RVA: 0x003FD8E0 File Offset: 0x003FBAE0
			public int m_finalDialogId
			{
				get
				{
					return this.m_owner.m_finalDialogId;
				}
				set
				{
					this.m_owner.m_finalDialogId = value;
				}
			}

			// Token: 0x17002E14 RID: 11796
			// (get) Token: 0x0600EF61 RID: 61281 RVA: 0x003FD8F0 File Offset: 0x003FBAF0
			// (set) Token: 0x0600EF62 RID: 61282 RVA: 0x003FD900 File Offset: 0x003FBB00
			public int m_protagonistId
			{
				get
				{
					return this.m_owner.m_protagonistId;
				}
				set
				{
					this.m_owner.m_protagonistId = value;
				}
			}

			// Token: 0x17002E15 RID: 11797
			// (get) Token: 0x0600EF63 RID: 61283 RVA: 0x003FD910 File Offset: 0x003FBB10
			// (set) Token: 0x0600EF64 RID: 61284 RVA: 0x003FD920 File Offset: 0x003FBB20
			public ConfigDataCharImageInfo m_goddessCharImageInfo
			{
				get
				{
					return this.m_owner.m_goddessCharImageInfo;
				}
				set
				{
					this.m_owner.m_goddessCharImageInfo = value;
				}
			}

			// Token: 0x17002E16 RID: 11798
			// (get) Token: 0x0600EF65 RID: 61285 RVA: 0x003FD930 File Offset: 0x003FBB30
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002E17 RID: 11799
			// (get) Token: 0x0600EF66 RID: 61286 RVA: 0x003FD940 File Offset: 0x003FBB40
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600EF67 RID: 61287 RVA: 0x003FD950 File Offset: 0x003FBB50
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600EF68 RID: 61288 RVA: 0x003FD960 File Offset: 0x003FBB60
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600EF69 RID: 61289 RVA: 0x003FD970 File Offset: 0x003FBB70
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600EF6A RID: 61290 RVA: 0x003FD980 File Offset: 0x003FBB80
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600EF6B RID: 61291 RVA: 0x003FD990 File Offset: 0x003FBB90
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600EF6C RID: 61292 RVA: 0x003FD9A0 File Offset: 0x003FBBA0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600EF6D RID: 61293 RVA: 0x003FD9B0 File Offset: 0x003FBBB0
			public void InitGoddessDialogUIController()
			{
				this.m_owner.InitGoddessDialogUIController();
			}

			// Token: 0x0600EF6E RID: 61294 RVA: 0x003FD9C0 File Offset: 0x003FBBC0
			public void UninitGoddessDialogUIController()
			{
				this.m_owner.UninitGoddessDialogUIController();
			}

			// Token: 0x0600EF6F RID: 61295 RVA: 0x003FD9D0 File Offset: 0x003FBBD0
			public void InitDialogId()
			{
				this.m_owner.InitDialogId();
			}

			// Token: 0x0600EF70 RID: 61296 RVA: 0x003FD9E0 File Offset: 0x003FBBE0
			public void InitJobChoiceValues()
			{
				this.m_owner.InitJobChoiceValues();
			}

			// Token: 0x0600EF71 RID: 61297 RVA: 0x003FD9F0 File Offset: 0x003FBBF0
			public void AppendChoiceValues(List<ChoiceValue> choiceValues)
			{
				this.m_owner.AppendChoiceValues(choiceValues);
			}

			// Token: 0x0600EF72 RID: 61298 RVA: 0x003FDA00 File Offset: 0x003FBC00
			public void ShowJobs(int idx, bool canSelect)
			{
				this.m_owner.ShowJobs(idx, canSelect);
			}

			// Token: 0x0600EF73 RID: 61299 RVA: 0x003FDA10 File Offset: 0x003FBC10
			public void StartDialog(int id)
			{
				this.m_owner.StartDialog(id);
			}

			// Token: 0x0600EF74 RID: 61300 RVA: 0x003FDA20 File Offset: 0x003FBC20
			public void ShowResultJobs()
			{
				this.m_owner.ShowResultJobs();
			}

			// Token: 0x0600EF75 RID: 61301 RVA: 0x003FDA30 File Offset: 0x003FBC30
			public void GoddessDialogUIController_OnNext()
			{
				this.m_owner.GoddessDialogUIController_OnNext();
			}

			// Token: 0x0600EF76 RID: 61302 RVA: 0x003FDA40 File Offset: 0x003FBC40
			public void GoddessDialogUIController_OnClose()
			{
				this.m_owner.GoddessDialogUIController_OnClose();
			}

			// Token: 0x0600EF77 RID: 61303 RVA: 0x003FDA50 File Offset: 0x003FBC50
			public void GoddessDialogUIController_OnChoose(int index)
			{
				this.m_owner.GoddessDialogUIController_OnChoose(index);
			}

			// Token: 0x0600EF78 RID: 61304 RVA: 0x003FDA60 File Offset: 0x003FBC60
			public void GoddessDialogUIController_OnShowJobInfo(ConfigDataJobConnectionInfo jobConnectionInfo)
			{
				this.m_owner.GoddessDialogUIController_OnShowJobInfo(jobConnectionInfo);
			}

			// Token: 0x0600EF79 RID: 61305 RVA: 0x003FDA70 File Offset: 0x003FBC70
			public void GoddessDialogUIController_OnConfirmJob()
			{
				this.m_owner.GoddessDialogUIController_OnConfirmJob();
			}

			// Token: 0x0600EF7A RID: 61306 RVA: 0x003FDA80 File Offset: 0x003FBC80
			public void GoddessDialogUIController_OnRetry()
			{
				this.m_owner.GoddessDialogUIController_OnRetry();
			}

			// Token: 0x0600EF7B RID: 61307 RVA: 0x003FDA90 File Offset: 0x003FBC90
			public void GoddessDialogUIController_OnSelectJob()
			{
				this.m_owner.GoddessDialogUIController_OnSelectJob();
			}

			// Token: 0x0600EF7C RID: 61308 RVA: 0x003FDAA0 File Offset: 0x003FBCA0
			public void GoddessDialogUIController_OnPrevJob()
			{
				this.m_owner.GoddessDialogUIController_OnPrevJob();
			}

			// Token: 0x0600EF7D RID: 61309 RVA: 0x003FDAB0 File Offset: 0x003FBCB0
			public void GoddessDialogUIController_OnNextJob()
			{
				this.m_owner.GoddessDialogUIController_OnNextJob();
			}

			// Token: 0x04008EBF RID: 36543
			private GoddessDialogUITask m_owner;
		}
	}
}
