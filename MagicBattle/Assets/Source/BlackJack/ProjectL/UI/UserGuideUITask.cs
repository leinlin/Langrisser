using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001009 RID: 4105
	[HotFix]
	public class UserGuideUITask : UITask
	{
		// Token: 0x06014B3D RID: 84797 RVA: 0x0053ED48 File Offset: 0x0053CF48
		public UserGuideUITask(string name) : base(name)
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

		// Token: 0x06014B3E RID: 84798 RVA: 0x0053EE50 File Offset: 0x0053D050
		public static void Initialize()
		{
			global::Debug.Log("UserGuideUITask.Initialize()");
			if (UserGuideUITask.<>f__mg$cache0 == null)
			{
				UserGuideUITask.<>f__mg$cache0 = new Action<string>(UserGuideUITask.OnShowObject);
			}
			ShowHideEvent.m_onShowEvent -= UserGuideUITask.<>f__mg$cache0;
			if (UserGuideUITask.<>f__mg$cache1 == null)
			{
				UserGuideUITask.<>f__mg$cache1 = new Action<string>(UserGuideUITask.OnShowObject);
			}
			ShowHideEvent.m_onShowEvent += UserGuideUITask.<>f__mg$cache1;
			if (UserGuideUITask.<>f__mg$cache2 == null)
			{
				UserGuideUITask.<>f__mg$cache2 = new Action<string>(UserGuideUITask.OnHideObject);
			}
			ShowHideEvent.m_onHideEvent -= UserGuideUITask.<>f__mg$cache2;
			if (UserGuideUITask.<>f__mg$cache3 == null)
			{
				UserGuideUITask.<>f__mg$cache3 = new Action<string>(UserGuideUITask.OnHideObject);
			}
			ShowHideEvent.m_onHideEvent += UserGuideUITask.<>f__mg$cache3;
			if (UserGuideUITask.<>f__mg$cache4 == null)
			{
				UserGuideUITask.<>f__mg$cache4 = new Action<GameObject>(UserGuideUITask.OnPrefabAwake);
			}
			PrefabControllerBase.m_onAwake -= UserGuideUITask.<>f__mg$cache4;
			if (UserGuideUITask.<>f__mg$cache5 == null)
			{
				UserGuideUITask.<>f__mg$cache5 = new Action<GameObject>(UserGuideUITask.OnPrefabAwake);
			}
			PrefabControllerBase.m_onAwake += UserGuideUITask.<>f__mg$cache5;
			if (UserGuideUITask.<>f__mg$cache6 == null)
			{
				UserGuideUITask.<>f__mg$cache6 = new Action<GameObject, string>(UserGuideUITask.OnUIStateEnd);
			}
			CommonUIStateController.m_onUIStateEndEvent -= UserGuideUITask.<>f__mg$cache6;
			if (UserGuideUITask.<>f__mg$cache7 == null)
			{
				UserGuideUITask.<>f__mg$cache7 = new Action<GameObject, string>(UserGuideUITask.OnUIStateEnd);
			}
			CommonUIStateController.m_onUIStateEndEvent += UserGuideUITask.<>f__mg$cache7;
			if (UserGuideUITask.<>f__mg$cache8 == null)
			{
				UserGuideUITask.<>f__mg$cache8 = new Action<ClientBattleActor>(UserGuideUITask.OnSelectBattleActor);
			}
			BattleUITask.m_onActiveActorEvent -= UserGuideUITask.<>f__mg$cache8;
			if (UserGuideUITask.<>f__mg$cache9 == null)
			{
				UserGuideUITask.<>f__mg$cache9 = new Action<ClientBattleActor>(UserGuideUITask.OnSelectBattleActor);
			}
			BattleUITask.m_onActiveActorEvent += UserGuideUITask.<>f__mg$cache9;
			if (UserGuideUITask.<>f__mg$cacheA == null)
			{
				UserGuideUITask.<>f__mg$cacheA = new Action<ClientBattleActor>(UserGuideUITask.OnDeselectBattleActor);
			}
			BattleUITask.m_onDeactiveActorEvent -= UserGuideUITask.<>f__mg$cacheA;
			if (UserGuideUITask.<>f__mg$cacheB == null)
			{
				UserGuideUITask.<>f__mg$cacheB = new Action<ClientBattleActor>(UserGuideUITask.OnDeselectBattleActor);
			}
			BattleUITask.m_onDeactiveActorEvent += UserGuideUITask.<>f__mg$cacheB;
			if (UserGuideUITask.<>f__mg$cacheC == null)
			{
				UserGuideUITask.<>f__mg$cacheC = new Action<int>(UserGuideUITask.OnServerFinishUserGuide);
			}
			UserGuideSetNetTask.m_completeEvent -= UserGuideUITask.<>f__mg$cacheC;
			if (UserGuideUITask.<>f__mg$cacheD == null)
			{
				UserGuideUITask.<>f__mg$cacheD = new Action<int>(UserGuideUITask.OnServerFinishUserGuide);
			}
			UserGuideSetNetTask.m_completeEvent += UserGuideUITask.<>f__mg$cacheD;
			if (UserGuideUITask.<>f__mg$cacheE == null)
			{
				UserGuideUITask.<>f__mg$cacheE = new Action<int>(UserGuideUITask.OnGiftStoreGoodsBuy);
			}
			StoreUITask.m_onBuyGiftStoreGoodsEvent -= UserGuideUITask.<>f__mg$cacheE;
			if (UserGuideUITask.<>f__mg$cacheF == null)
			{
				UserGuideUITask.<>f__mg$cacheF = new Action<int>(UserGuideUITask.OnGiftStoreGoodsBuy);
			}
			StoreUITask.m_onBuyGiftStoreGoodsEvent += UserGuideUITask.<>f__mg$cacheF;
			UIManager instance = UIManager.Instance;
			if (UserGuideUITask.<>f__mg$cache10 == null)
			{
				UserGuideUITask.<>f__mg$cache10 = new Action<string>(UserGuideUITask.OnUITaskShow);
			}
			instance.EventOnUITaskShow -= UserGuideUITask.<>f__mg$cache10;
			UIManager instance2 = UIManager.Instance;
			if (UserGuideUITask.<>f__mg$cache11 == null)
			{
				UserGuideUITask.<>f__mg$cache11 = new Action<string>(UserGuideUITask.OnUITaskShow);
			}
			instance2.EventOnUITaskShow += UserGuideUITask.<>f__mg$cache11;
			UIManager instance3 = UIManager.Instance;
			if (UserGuideUITask.<>f__mg$cache12 == null)
			{
				UserGuideUITask.<>f__mg$cache12 = new Action<bool>(UserGuideUITask.OnReturnToLoginUI);
			}
			instance3.EventReturnToLoginUI -= UserGuideUITask.<>f__mg$cache12;
			UIManager instance4 = UIManager.Instance;
			if (UserGuideUITask.<>f__mg$cache13 == null)
			{
				UserGuideUITask.<>f__mg$cache13 = new Action<bool>(UserGuideUITask.OnReturnToLoginUI);
			}
			instance4.EventReturnToLoginUI += UserGuideUITask.<>f__mg$cache13;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			foreach (KeyValuePair<int, ConfigDataUserGuide> keyValuePair in configDataLoader.GetAllConfigDataUserGuide())
			{
				if (keyValuePair.Value.OpenTrigger.Count > 1 && keyValuePair.Value.OpenTrigger.Count != keyValuePair.Value.OTParam.Count)
				{
					global::Debug.LogError(string.Format("UserGuideUITask.Initialize: UserGuide {0} 's OpenTrigger and OTParam is not the same count.", keyValuePair.Value.ID));
				}
				else
				{
					UserGuideUITask.m_userGuideConfigs.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			UserGuideUITask.CollectUserGuideShowHideEventObjectPaths(UserGuideUITask.m_userGuideShowHideEventObjectPaths);
			UserGuideUITask.Enable = LocalConfig.Instance.Data.EnableUserGuide;
			UserGuideUITask.m_dragHeroToBattleUserGuideID = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_DragHeroToBattleUserGuideID);
		}

		// Token: 0x06014B3F RID: 84799 RVA: 0x0053F224 File Offset: 0x0053D424
		private static void AddUserGuideTriggerCount(int userGuideId)
		{
			if (UserGuideUITask.m_triggerUserGuideCounts == null)
			{
				return;
			}
			if (UserGuideUITask.m_triggerUserGuideCounts.ContainsKey(userGuideId))
			{
				Dictionary<int, int> triggerUserGuideCounts;
				(triggerUserGuideCounts = UserGuideUITask.m_triggerUserGuideCounts)[userGuideId] = triggerUserGuideCounts[userGuideId] + 1;
			}
			else
			{
				UserGuideUITask.m_triggerUserGuideCounts.Add(userGuideId, 1);
			}
			UserGuideUITask.SaveUserGuideProgress();
		}

		// Token: 0x06014B40 RID: 84800 RVA: 0x0053F27C File Offset: 0x0053D47C
		private static int GetUserGuideTriggerCount(int userGuideId)
		{
			if (UserGuideUITask.m_triggerUserGuideCounts == null)
			{
				UserGuideUITask.m_triggerUserGuideCounts = new Dictionary<int, int>();
				UserGuideUITask.LoadUserGuideProgress();
			}
			if (UserGuideUITask.m_triggerUserGuideCounts != null && UserGuideUITask.m_triggerUserGuideCounts.ContainsKey(userGuideId))
			{
				return UserGuideUITask.m_triggerUserGuideCounts[userGuideId];
			}
			return 0;
		}

		// Token: 0x06014B41 RID: 84801 RVA: 0x0053F2CC File Offset: 0x0053D4CC
		public static void SaveUserGuideProgress()
		{
			if (UserGuideUITask.m_triggerUserGuideCounts == null)
			{
				return;
			}
			string userGuideProgressFileName = UserGuideUITask.UserGuideProgressFileName;
			if (string.IsNullOrEmpty(userGuideProgressFileName))
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<int, int> keyValuePair in UserGuideUITask.m_triggerUserGuideCounts)
			{
				stringBuilder.AppendFormat("{0},{1};", keyValuePair.Key, keyValuePair.Value);
			}
			try
			{
				File.WriteAllText(userGuideProgressFileName, stringBuilder.ToString());
			}
			catch (Exception ex)
			{
				global::Debug.LogError(string.Format("UserGuideUITask.SaveUserGuideProgress Failed: {0}", ex.Message));
			}
		}

		// Token: 0x06014B42 RID: 84802 RVA: 0x0053F3A4 File Offset: 0x0053D5A4
		private static void LoadUserGuideProgress()
		{
			string userGuideProgressFileName = UserGuideUITask.UserGuideProgressFileName;
			if (string.IsNullOrEmpty(userGuideProgressFileName) || UserGuideUITask.m_triggerUserGuideCounts == null)
			{
				return;
			}
			try
			{
				if (File.Exists(userGuideProgressFileName))
				{
					string text = File.ReadAllText(userGuideProgressFileName);
					if (!string.IsNullOrEmpty(text))
					{
						string[] array = text.Split(new char[]
						{
							';'
						});
						if (array.Length != 0)
						{
							UserGuideUITask.m_triggerUserGuideCounts.Clear();
							foreach (string text2 in array)
							{
								string[] array3 = text2.Split(new char[]
								{
									','
								});
								int key;
								int value;
								if (array3.Length >= 2 && int.TryParse(array3[0], out key) && int.TryParse(array3[1], out value) && !UserGuideUITask.m_triggerUserGuideCounts.ContainsKey(key))
								{
									UserGuideUITask.m_triggerUserGuideCounts.Add(key, value);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError(string.Format("UserGuideUITask.LoadUserGuideProgress Failed: {0}", ex.Message));
			}
		}

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x06014B43 RID: 84803 RVA: 0x0053F4D4 File Offset: 0x0053D6D4
		private static string UserGuideProgressFileName
		{
			get
			{
				if (string.IsNullOrEmpty(LoginUITask.SessionAccountInfo))
				{
					global::Debug.Log("UserGuideUITask.UserGuideProgressFileName.get SessionAccountInfo is null.");
					return string.Empty;
				}
				return string.Format("{0}/ugp.{1}.{2}.txt", Application.persistentDataPath, Application.version, LoginUITask.SessionAccountInfo);
			}
		}

		// Token: 0x06014B44 RID: 84804 RVA: 0x0053F510 File Offset: 0x0053D710
		public static bool IsUserGuideBattle(int battleID)
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext == null)
			{
				return false;
			}
			foreach (KeyValuePair<int, ConfigDataUserGuide> keyValuePair in UserGuideUITask.m_userGuideConfigs)
			{
				if (keyValuePair.Value.OpenCondition == UserGuideCondition.UserGuideCondition_IsRunningBattleN && !projectLPlayerContext.IsUserGuideComplete(keyValuePair.Value.ID) && int.Parse(keyValuePair.Value.OCParam) == battleID && keyValuePair.Value.FirstStepID > 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06014B45 RID: 84805 RVA: 0x0053F5D8 File Offset: 0x0053D7D8
		public static bool NeedSkipBattlePrepareForUserGuide(int battleID)
		{
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (playerContext == null)
			{
				return false;
			}
			if (playerContext.IsUserGuideComplete(UserGuideUITask.m_dragHeroToBattleUserGuideID))
			{
				return false;
			}
			foreach (KeyValuePair<int, ConfigDataUserGuide> keyValuePair in UserGuideUITask.m_userGuideConfigs)
			{
				if (keyValuePair.Value.OpenCondition == UserGuideCondition.UserGuideCondition_IsRunningBattleN && !playerContext.IsUserGuideComplete(keyValuePair.Value.ID) && int.Parse(keyValuePair.Value.OCParam) == battleID)
				{
					if (keyValuePair.Value.OpenTrigger.Find((UserGuideTrigger t) => t == UserGuideTrigger.UserGuideTrigger_SelectBattleHeroN) == UserGuideTrigger.UserGuideTrigger_SelectBattleHeroN)
					{
						int num = keyValuePair.Value.EnforceHeros.Find((int h) => playerContext.GetHero(h) == null);
						if (num == 0)
						{
							return true;
						}
						global::Debug.LogError(string.Format("UserGuideUITask.NeedSkipBattlePrepareForUserGuide {0}, {1} Error: Enforce Hero {2} not exist.", keyValuePair.Value.ID, keyValuePair.Value.Name, num));
					}
				}
			}
			return false;
		}

		// Token: 0x06014B46 RID: 84806 RVA: 0x0053F748 File Offset: 0x0053D948
		public static List<int> GetEnforceHeros(int battleID)
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext == null)
			{
				return null;
			}
			foreach (KeyValuePair<int, ConfigDataUserGuide> keyValuePair in UserGuideUITask.m_userGuideConfigs)
			{
				if (keyValuePair.Value.OpenCondition == UserGuideCondition.UserGuideCondition_IsRunningBattleN && !projectLPlayerContext.IsUserGuideComplete(keyValuePair.Value.ID) && int.Parse(keyValuePair.Value.OCParam) == battleID)
				{
					return keyValuePair.Value.EnforceHeros;
				}
			}
			return null;
		}

		// Token: 0x06014B47 RID: 84807 RVA: 0x0053F80C File Offset: 0x0053DA0C
		private static void CollectUserGuideShowHideEventObjectPaths(List<string[]> paths)
		{
			if (paths == null)
			{
				return;
			}
			HashSet<string> hashSet = new HashSet<string>();
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			foreach (KeyValuePair<int, ConfigDataUserGuide> keyValuePair in configDataLoader.GetAllConfigDataUserGuide())
			{
				ConfigDataUserGuide value = keyValuePair.Value;
				if (value.CompleteTrigger == UserGuideTrigger.UserGuideTrigger_ShowObject || value.CompleteTrigger == UserGuideTrigger.UserGuideTrigger_HideObject)
				{
					hashSet.Add(value.CTParam);
				}
				for (int i = 0; i < value.OpenTrigger.Count; i++)
				{
					if (value.OpenTrigger[i] == UserGuideTrigger.UserGuideTrigger_ShowObject || value.OpenTrigger[i] == UserGuideTrigger.UserGuideTrigger_HideObject)
					{
						hashSet.Add(value.OTParam[i]);
					}
				}
			}
			foreach (KeyValuePair<int, ConfigDataUserGuideStep> keyValuePair2 in configDataLoader.GetAllConfigDataUserGuideStep())
			{
				for (int j = 0; j < keyValuePair2.Value.NextTrigger.Count; j++)
				{
					if (keyValuePair2.Value.NextTrigger[j] == UserGuideTrigger.UserGuideTrigger_ShowObject || keyValuePair2.Value.NextTrigger[j] == UserGuideTrigger.UserGuideTrigger_HideObject)
					{
						hashSet.Add(keyValuePair2.Value.NTParam[j]);
					}
				}
			}
			foreach (string text in hashSet)
			{
				paths.Add(text.Split(new char[]
				{
					'\\'
				}));
			}
		}

		// Token: 0x06014B48 RID: 84808 RVA: 0x0053FA1C File Offset: 0x0053DC1C
		private static bool IsArrayEqual<T>(T[] arr1, T[] arr2, Comparison<T> compare)
		{
			if (arr1.Length != arr2.Length)
			{
				return false;
			}
			for (int i = 0; i < arr1.Length; i++)
			{
				if (compare(arr1[i], arr2[i]) == 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06014B49 RID: 84809 RVA: 0x0053FA68 File Offset: 0x0053DC68
		public static void OnShowObject(string objectPath)
		{
			UserGuideUITask.Trigger(UserGuideTrigger.UserGuideTrigger_ShowObject, objectPath);
		}

		// Token: 0x06014B4A RID: 84810 RVA: 0x0053FA74 File Offset: 0x0053DC74
		public static void OnHideObject(string objectPath)
		{
			UserGuideUITask.Trigger(UserGuideTrigger.UserGuideTrigger_HideObject, objectPath);
		}

		// Token: 0x06014B4B RID: 84811 RVA: 0x0053FA80 File Offset: 0x0053DC80
		public static void OnUIStateEnd(GameObject obj, string stateName)
		{
			UserGuideUITask.Trigger(UserGuideTrigger.UserGuideTrigger_EndUIState, string.Format("{0},{1}", SceneManager.GetObjectPath(obj), stateName));
		}

		// Token: 0x06014B4C RID: 84812 RVA: 0x0053FA9C File Offset: 0x0053DC9C
		public static void OnSelectBattleActor(ClientBattleActor a)
		{
			UserGuideUITask.Trigger(UserGuideTrigger.UserGuideTrigger_SelectBattleHeroN, a.BattleActor.HeroId.ToString());
		}

		// Token: 0x06014B4D RID: 84813 RVA: 0x0053FACC File Offset: 0x0053DCCC
		public static void OnWorldUIGetReady()
		{
			UserGuideUITask.Trigger(UserGuideTrigger.UserGuideTrigger_WorldUIGetReady, string.Empty);
		}

		// Token: 0x06014B4E RID: 84814 RVA: 0x0053FADC File Offset: 0x0053DCDC
		public static void OnServerFinishUserGuide(int guideID)
		{
			global::Debug.Log(string.Format("UserGuideUITask.OnServerFinishUserGuide {0}", guideID));
			UserGuideUITask.Trigger(UserGuideTrigger.UserGuideTrigger_FinishUserGuideN, guideID.ToString());
		}

		// Token: 0x06014B4F RID: 84815 RVA: 0x0053FB08 File Offset: 0x0053DD08
		public static void OnDeselectBattleActor(ClientBattleActor a)
		{
			UserGuideUITask.Trigger(UserGuideTrigger.UserGuideTrigger_DeselectBattleHeroN, a.BattleActor.HeroId.ToString());
		}

		// Token: 0x06014B50 RID: 84816 RVA: 0x0053FB38 File Offset: 0x0053DD38
		public static void OnGiftStoreGoodsBuy(int goodsId)
		{
			UserGuideUITask.Trigger(UserGuideTrigger.UserGuideTrigger_BuyGiftStoreGoodsN, goodsId.ToString());
		}

		// Token: 0x06014B51 RID: 84817 RVA: 0x0053FB50 File Offset: 0x0053DD50
		public static void OnUITaskShow(string taskName)
		{
			if (taskName == typeof(InviteNotifyUITask).Name)
			{
				UserGuideUITask userGuideUITask = UIUtility.FindUITaskWithType(typeof(UserGuideUITask)) as UserGuideUITask;
				if (userGuideUITask != null && userGuideUITask.State == Task.TaskState.Running)
				{
					UITaskBase uitaskBase = UIManager.Instance.FindUITaskWithName(taskName);
					if (uitaskBase != null)
					{
						uitaskBase.Stop();
					}
				}
			}
		}

		// Token: 0x06014B52 RID: 84818 RVA: 0x0053FBB8 File Offset: 0x0053DDB8
		public static void OnReturnToLoginUI(bool obj)
		{
			UserGuideUITask.m_triggerUserGuideCounts = null;
		}

		// Token: 0x06014B53 RID: 84819 RVA: 0x0053FBC0 File Offset: 0x0053DDC0
		public static void OnPrefabAwake(GameObject awakeObj)
		{
			UserGuideUITask.AddShowHideEventForUserGuide(awakeObj);
		}

		// Token: 0x06014B54 RID: 84820 RVA: 0x0053FBC8 File Offset: 0x0053DDC8
		private static void AddShowHideEventForUserGuide(GameObject obj)
		{
			if (obj == null || obj.transform == null)
			{
				return;
			}
			if (obj.GetComponent<ShowHideEvent>() != null)
			{
				return;
			}
			if (UserGuideUITask.IsUserGuideTriggerObject(obj))
			{
				obj.AddComponent<ShowHideEvent>();
			}
			for (int i = 0; i < obj.transform.childCount; i++)
			{
				UserGuideUITask.AddShowHideEventForUserGuide(obj.transform.GetChild(i).gameObject);
			}
		}

		// Token: 0x06014B55 RID: 84821 RVA: 0x0053FC4C File Offset: 0x0053DE4C
		private static bool IsUserGuideTriggerObject(GameObject obj)
		{
			return null != UserGuideUITask.m_userGuideShowHideEventObjectPaths.Find(delegate(string[] path)
			{
				GameObject gameObject = obj;
				for (int i = path.Length - 1; i > -1; i--)
				{
					if (gameObject == null || path[i] != gameObject.name)
					{
						return false;
					}
					if (gameObject.transform.parent == null)
					{
						gameObject = null;
					}
					else
					{
						gameObject = gameObject.transform.parent.gameObject;
					}
				}
				return true;
			});
		}

		// Token: 0x06014B56 RID: 84822 RVA: 0x0053FC84 File Offset: 0x0053DE84
		private bool TriggerUserGuide(UserGuideTrigger trigger, string param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TriggerUserGuideUserGuideTriggerString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_TriggerUserGuideUserGuideTriggerString_hotfix.call(new object[]
				{
					this,
					trigger,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideStepInfo == null)
			{
				return false;
			}
			for (int i = 0; i < this.m_userGuideStepInfo.NextTrigger.Count; i++)
			{
				if (UserGuideUITask.MatchTrigger(this.m_userGuideStepInfo.NextTrigger[i], (i >= this.m_userGuideStepInfo.NTParam.Count) ? string.Empty : this.m_userGuideStepInfo.NTParam[i], trigger, param))
				{
					this.Next();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06014B57 RID: 84823 RVA: 0x0053FD98 File Offset: 0x0053DF98
		private static bool Trigger(UserGuideTrigger trigger, string param)
		{
			if (!UserGuideUITask.Enable)
			{
				return false;
			}
			if (GameManager.Instance == null)
			{
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext == null)
			{
				return false;
			}
			UserGuideUITask userGuideUITask = UIUtility.FindUITaskWithType(typeof(UserGuideUITask)) as UserGuideUITask;
			if (userGuideUITask != null && userGuideUITask.State == Task.TaskState.Running && userGuideUITask.TriggerUserGuide(trigger, param))
			{
				return true;
			}
			foreach (KeyValuePair<int, ConfigDataUserGuide> keyValuePair in UserGuideUITask.m_userGuideConfigs)
			{
				ConfigDataUserGuide value = keyValuePair.Value;
				if (!projectLPlayerContext.IsUserGuideComplete(value.ID))
				{
					if (value.OpenTrigger.Count > 0)
					{
						for (int i = 0; i < value.OpenTrigger.Count; i++)
						{
							if (UserGuideUITask.MatchTrigger(value.OpenTrigger[i], (i >= value.OTParam.Count) ? string.Empty : value.OTParam[i], trigger, param) && UserGuideUITask.CheckCondition(value.OpenCondition, value.OCParam) && UserGuideUITask.CheckCondition(value.OpenCondition2, value.OCParam2))
							{
								int num = (value.CompleteTrigger <= UserGuideTrigger.UserGuideTrigger_) ? 0 : UserGuideUITask.GetUserGuideTriggerCount(value.ID);
								global::Debug.Log(string.Format("UserGuideUITask.Trigger Start UserGuide {0}, {1}, count = {2}", value.ID, value.Name, num));
								UserGuideUITask.StartStep(value.ID, value.FirstStepID, num > 1);
								if (value.CompleteTrigger > UserGuideTrigger.UserGuideTrigger_)
								{
									UserGuideUITask.AddUserGuideTriggerCount(value.ID);
								}
								return true;
							}
						}
					}
					if (UserGuideUITask.MatchTrigger(value.CompleteTrigger, value.CTParam, trigger, param))
					{
						global::Debug.Log(string.Format("UserGuideUITask.Trigger Finish UserGuide {0}, {1}", value.ID, value.Name));
						UserGuideSetNetTask.StartUserGuideSetNetTask(value.ID);
					}
				}
			}
			return false;
		}

		// Token: 0x06014B58 RID: 84824 RVA: 0x0053FFF8 File Offset: 0x0053E1F8
		private static bool MatchTrigger(UserGuideTrigger trigger1, string param1, UserGuideTrigger trigger2, string param2)
		{
			if (trigger1 != trigger2)
			{
				return false;
			}
			if (trigger1 != UserGuideTrigger.UserGuideTrigger_ShowObject && trigger1 != UserGuideTrigger.UserGuideTrigger_HideObject && trigger1 != UserGuideTrigger.UserGuideTrigger_EndUIState)
			{
				return param1 == param2;
			}
			if (string.IsNullOrEmpty(param1) || string.IsNullOrEmpty(param2))
			{
				return false;
			}
			if (param1.Length > param2.Length)
			{
				return param1.EndsWith(param2);
			}
			return param2.EndsWith(param1);
		}

		// Token: 0x06014B59 RID: 84825 RVA: 0x00540064 File Offset: 0x0053E264
		public static bool CheckCondition(UserGuideCondition c, string param)
		{
			if (GameManager.Instance == null)
			{
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext == null)
			{
				return false;
			}
			if (c == UserGuideCondition.UserGuideCondition_StoryNFinished && !string.IsNullOrEmpty(param))
			{
				return projectLPlayerContext.IsScenarioFinished(int.Parse(param));
			}
			if (c == UserGuideCondition.UserGuideCondition_TodayIsSignedEqual && !string.IsNullOrEmpty(param))
			{
				return projectLPlayerContext.TodayIsSigned() == bool.Parse(param);
			}
			if (c == UserGuideCondition.UserGuideCondition_PlayerLevelReachN && !string.IsNullOrEmpty(param))
			{
				return projectLPlayerContext.GetPlayerLevel() >= int.Parse(param);
			}
			if (c == UserGuideCondition.UserGuideCondition_NeverOpenedActivityNoticeAndPlayerLevelReachN && !string.IsNullOrEmpty(param))
			{
				return projectLPlayerContext.HaveActivityNotice() && projectLPlayerContext.GetPlayerLevel() >= int.Parse(param) && projectLPlayerContext.IsFirstTryToOpenActivityNoticeUI();
			}
			if (c == UserGuideCondition.UserGuideCondition_GuideNFinished && !string.IsNullOrEmpty(param))
			{
				return projectLPlayerContext.IsUserGuideComplete(int.Parse(param));
			}
			if (c == UserGuideCondition.UserGuideCondition_RiftChapterNUnlockable && !string.IsNullOrEmpty(param))
			{
				return projectLPlayerContext.CanUnlockRiftChapter(int.Parse(param)) == 0;
			}
			if (c == UserGuideCondition.UserGuideCondition_RiftLevelNPassed && !string.IsNullOrEmpty(param))
			{
				return projectLPlayerContext.GetRiftLevelStars(int.Parse(param)) > 0;
			}
			if (c == UserGuideCondition.UserGuideCondition_IsRunningBattleN && !string.IsNullOrEmpty(param))
			{
				return projectLPlayerContext.CurrentBattle != null && projectLPlayerContext.CurrentBattle.BattleInfo != null && projectLPlayerContext.CurrentBattle.BattleInfo.ID == int.Parse(param);
			}
			if (c == UserGuideCondition.UserGuideCondition_IsWayPointNArrived && !string.IsNullOrEmpty(param))
			{
				return projectLPlayerContext.GetWaypointStatus(int.Parse(param)) == WayPointStatus.Arrived;
			}
			if (c == UserGuideCondition.UserGuideCondition_IsHeroNComposable && !string.IsNullOrEmpty(param))
			{
				return projectLPlayerContext.IsHeroCanComposed(int.Parse(param));
			}
			if (c == UserGuideCondition.UserGuideCondition_GuideNFinishedAndMNotFinished && !string.IsNullOrEmpty(param))
			{
				string[] array = param.Split(new char[]
				{
					','
				});
				if (array.Length != 2)
				{
					global::Debug.LogError(string.Format("UserGuideUITask.CheckCondition GuideNFinishedAndMNotFinished 's param {3} is wrong.", param));
					return false;
				}
				return projectLPlayerContext.IsUserGuideComplete(int.Parse(array[0])) && !projectLPlayerContext.IsUserGuideComplete(int.Parse(array[1]));
			}
			else
			{
				if (c == UserGuideCondition.UserGuideCondition_GuideNUnfinished && !string.IsNullOrEmpty(param))
				{
					return !projectLPlayerContext.IsUserGuideComplete(int.Parse(param));
				}
				return c == UserGuideCondition.UserGuideCondition_;
			}
		}

		// Token: 0x06014B5A RID: 84826 RVA: 0x005402B8 File Offset: 0x0053E4B8
		public static void StartStep(int userGuideId, int userGuideStepId, bool bSkipEnable = false)
		{
			if (!UserGuideUITask.Enable || userGuideStepId == 0)
			{
				return;
			}
			global::Debug.Log(string.Format("UserGuideUITask.StartStep() {0}", userGuideStepId));
			UserGuideUITask userGuideUITask = UIUtility.FindUITaskWithType(typeof(UserGuideUITask)) as UserGuideUITask;
			if (userGuideUITask != null && userGuideUITask.State == Task.TaskState.Running && userGuideUITask.m_userGuideStepInfo != null)
			{
				if (userGuideUITask.m_userGuideStepInfo.ID == userGuideStepId)
				{
					return;
				}
				userGuideUITask.ForceStop();
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataUserGuideStep configDataUserGuideStep = configDataLoader.GetConfigDataUserGuideStep(userGuideStepId);
			if (configDataUserGuideStep == null)
			{
				global::Debug.LogError("ConfigDataUserGuideInfo " + userGuideStepId + " not found.");
				return;
			}
			global::Debug.Log(string.Format("UserGuideUITask.StartStep: {0}, {1}", userGuideStepId, configDataUserGuideStep.Name));
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(UserGuideUITask).Name, null);
			uiintentCustom.SetParam("UserGuideStepInfo", configDataUserGuideStep);
			uiintentCustom.SetParam("UserGuideID", userGuideId);
			uiintentCustom.SetParam("EnableSkip", bSkipEnable);
			UIManager.Instance.StartUITask(uiintentCustom, true, false, null);
		}

		// Token: 0x06014B5B RID: 84827 RVA: 0x005403E4 File Offset: 0x0053E5E4
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
			this.InitDataFromUIIntent(intent);
			InviteNotifyUITask.StopUITask();
			return base.OnStart(intent);
		}

		// Token: 0x06014B5C RID: 84828 RVA: 0x00540474 File Offset: 0x0053E674
		private void ForceStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ForceStop_hotfix != null)
			{
				this.m_ForceStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError(string.Format("UserGuideUITask.ForceStop() {0}, {1}", this.m_userGuideStepInfo.ID, this.m_userGuideStepInfo.Name));
			if (this.m_initCoroutine != null)
			{
				CommonUIController.Instance.StopCoroutine(this.m_initCoroutine);
				this.m_initCoroutine = null;
			}
			this.m_isDoingUpdateViewAsync = false;
			this.Finish(false, true);
			this.m_userGuideStepInfo = null;
			base.Stop();
		}

		// Token: 0x06014B5D RID: 84829 RVA: 0x0054053C File Offset: 0x0053E73C
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			InviteNotifyUITask.StopUITask();
			return base.OnResume(intent);
		}

		// Token: 0x06014B5E RID: 84830 RVA: 0x005405CC File Offset: 0x0053E7CC
		private void InitDataFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDataFromUIIntentUIIntent_hotfix != null)
			{
				this.m_InitDataFromUIIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_userGuideStepInfo = null;
			this.m_userGuideStepInfo = null;
			this.m_pageIndex = 0;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_userGuideStepInfo = uiintentCustom.GetClassParam<ConfigDataUserGuideStep>("UserGuideStepInfo");
				this.m_isEnableSkip = uiintentCustom.GetStructParam<bool>("EnableSkip");
				this.m_nUserGuideId = uiintentCustom.GetStructParam<int>("UserGuideID");
			}
			if (this.m_userGuideStepInfo != null)
			{
				global::Debug.Log(string.Format("UserGuideUITask.InitDataFromUIIntent: {0}, {1}", this.m_userGuideStepInfo.ID, this.m_userGuideStepInfo.Name));
			}
			else
			{
				global::Debug.LogError("UserGuideUITask.InitDataFromUIIntent: m_userGuideStepInfo is null");
			}
		}

		// Token: 0x06014B5F RID: 84831 RVA: 0x005406D8 File Offset: 0x0053E8D8
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
			if (this.m_userGuideStepInfo != null)
			{
				if (!string.IsNullOrEmpty(this.m_userGuideStepInfo.PagesPrefab))
				{
					base.CollectAsset(this.m_userGuideStepInfo.PagesPrefab);
				}
				base.CollectAsset(this.m_userGuideStepInfo.FunctionOpenPrefab);
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014B60 RID: 84832 RVA: 0x00540794 File Offset: 0x0053E994
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
			this.InitUserGuideUIController();
		}

		// Token: 0x06014B61 RID: 84833 RVA: 0x00540800 File Offset: 0x0053EA00
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
			this.UninitUserGuideUIController();
		}

		// Token: 0x06014B62 RID: 84834 RVA: 0x0054086C File Offset: 0x0053EA6C
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
			this.DoUpdateView();
		}

		// Token: 0x06014B63 RID: 84835 RVA: 0x005408D4 File Offset: 0x0053EAD4
		private void AddShowHideEventForUserGuideStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddShowHideEventForUserGuideStep_hotfix != null)
			{
				this.m_AddShowHideEventForUserGuideStep_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideStepInfo == null)
			{
				return;
			}
			for (int i = 0; i < this.m_userGuideStepInfo.NextTrigger.Count; i++)
			{
				if (this.m_userGuideStepInfo.NextTrigger[i] == UserGuideTrigger.UserGuideTrigger_ShowObject || this.m_userGuideStepInfo.NextTrigger[i] == UserGuideTrigger.UserGuideTrigger_HideObject)
				{
					if (i < this.m_userGuideStepInfo.NTParam.Count && !string.IsNullOrEmpty(this.m_userGuideStepInfo.NTParam[i]))
					{
						GameObject gameObject = GameObjectUtility.FindChildObject(GameObjectUtility.SceneRoot, this.m_userGuideStepInfo.NTParam[i].Split(new char[]
						{
							'\\'
						}));
						if (!(gameObject == null))
						{
							if (!(gameObject.GetComponent<ShowHideEvent>() != null))
							{
								gameObject.AddComponent<ShowHideEvent>();
							}
						}
					}
				}
			}
		}

		// Token: 0x06014B64 RID: 84836 RVA: 0x00540A24 File Offset: 0x0053EC24
		private void DoUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoUpdateView_hotfix != null)
			{
				this.m_DoUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideUIController == null || !this.m_userGuideUIController.isActiveAndEnabled || this.m_userGuideStepInfo == null)
			{
				return;
			}
			global::Debug.Log(string.Format("UserGuideUITask.DoUpdateView: {0}, {1}", this.m_userGuideStepInfo.ID, this.m_userGuideStepInfo.Name));
			if (this.m_initCoroutine != null)
			{
				CommonUIController.Instance.StopCoroutine(this.m_initCoroutine);
			}
			this.m_initCoroutine = CommonUIController.Instance.StartCoroutine(this.DoUpdateViewAsync());
		}

		// Token: 0x06014B65 RID: 84837 RVA: 0x00540B0C File Offset: 0x0053ED0C
		[DebuggerHidden]
		private IEnumerator EnableInputLately(float time)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableInputLatelySingle_hotfix != null)
			{
				return (IEnumerator)this.m_EnableInputLatelySingle_hotfix.call(new object[]
				{
					this,
					time
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UserGuideUITask.<EnableInputLately>c__Iterator0 <EnableInputLately>c__Iterator = new UserGuideUITask.<EnableInputLately>c__Iterator0();
			<EnableInputLately>c__Iterator.time = time;
			return <EnableInputLately>c__Iterator;
		}

		// Token: 0x06014B66 RID: 84838 RVA: 0x00540B98 File Offset: 0x0053ED98
		[DebuggerHidden]
		private IEnumerator DoUpdateViewAsync()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoUpdateViewAsync_hotfix != null)
			{
				return (IEnumerator)this.m_DoUpdateViewAsync_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UserGuideUITask.<DoUpdateViewAsync>c__Iterator1 <DoUpdateViewAsync>c__Iterator = new UserGuideUITask.<DoUpdateViewAsync>c__Iterator1();
			<DoUpdateViewAsync>c__Iterator.$this = this;
			return <DoUpdateViewAsync>c__Iterator;
		}

		// Token: 0x06014B67 RID: 84839 RVA: 0x00540C14 File Offset: 0x0053EE14
		private void OnFunctionOpenAnimEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFunctionOpenAnimEnd_hotfix != null)
			{
				this.m_OnFunctionOpenAnimEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideStepInfo == null)
			{
				return;
			}
			this.m_userGuideUIController.HideFunctionOpen();
			this.Finish(true, false);
			if (this.m_userGuideStepInfo.NextTrigger.Count == 0)
			{
				this.Next();
			}
		}

		// Token: 0x06014B68 RID: 84840 RVA: 0x00540CB0 File Offset: 0x0053EEB0
		private static bool GetCenterScreenPosition(RectTransform rt, ref Vector2 pos)
		{
			if (rt == null || rt.gameObject == null)
			{
				return false;
			}
			Canvas componentInParent = rt.gameObject.GetComponentInParent<Canvas>();
			if (componentInParent == null)
			{
				return false;
			}
			Vector3[] array = new Vector3[4];
			rt.GetWorldCorners(array);
			Camera worldCamera = componentInParent.worldCamera;
			if (worldCamera == null)
			{
				return false;
			}
			Vector2 a = worldCamera.WorldToScreenPoint(array[0]);
			Vector2 b = worldCamera.WorldToScreenPoint(array[2]);
			pos = (a + b) * 0.5f;
			return true;
		}

		// Token: 0x06014B69 RID: 84841 RVA: 0x00540D64 File Offset: 0x0053EF64
		private static bool IsInsideScreen(Vector2 pos)
		{
			return pos.x > 0f && pos.x < (float)Screen.width && pos.y > 0f && pos.y < (float)Screen.height;
		}

		// Token: 0x06014B6A RID: 84842 RVA: 0x00540DB8 File Offset: 0x0053EFB8
		private bool IsClickable(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsClickableGameObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsClickableGameObject_hotfix.call(new object[]
				{
					this,
					obj
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (obj == null)
			{
				return false;
			}
			PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
			Vector2 zero = Vector2.zero;
			if (!UserGuideUITask.GetCenterScreenPosition(obj.transform as RectTransform, ref zero))
			{
				return false;
			}
			if (!UserGuideUITask.IsInsideScreen(zero))
			{
				return false;
			}
			pointerEventData.position = zero;
			List<RaycastResult> list = new List<RaycastResult>();
			EventSystem.current.RaycastAll(pointerEventData, list);
			while (list.Count > 1 && (this.m_userGuideUIController.IsBgButtonObj(list[0].gameObject) || CommonUIController.Instance.IsDisableInputObject(list[0].gameObject) || CommonUIController.Instance.IsTestToolbarObject(list[0].gameObject) || this.m_userGuideUIController.IsDisableInputObject(list[0].gameObject) || list[0].gameObject.tag == "ExcuteEventImage"))
			{
				list.RemoveAt(0);
			}
			return list.Count != 0 && (list[0].gameObject == obj || UserGuideUITask.IsChildTransform(obj.transform, list[0].gameObject.transform));
		}

		// Token: 0x06014B6B RID: 84843 RVA: 0x00540F9C File Offset: 0x0053F19C
		public static bool IsChildTransform(Transform parent, Transform child)
		{
			if (parent == null || child == null)
			{
				return false;
			}
			if (parent == child)
			{
				return true;
			}
			for (int i = 0; i < parent.childCount; i++)
			{
				if (UserGuideUITask.IsChildTransform(parent.GetChild(i), child))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06014B6C RID: 84844 RVA: 0x00541000 File Offset: 0x0053F200
		private void PrepareForGetUIPosition(GameObject uiObj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PrepareForGetUIPositionGameObject_hotfix != null)
			{
				this.m_PrepareForGetUIPositionGameObject_hotfix.call(new object[]
				{
					this,
					uiObj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (uiObj == null)
			{
				return;
			}
			WorldUIController componentInParent = uiObj.GetComponentInParent<WorldUIController>();
			if (componentInParent != null)
			{
				componentInParent.ShowMainButtonBar(true);
			}
		}

		// Token: 0x06014B6D RID: 84845 RVA: 0x00541098 File Offset: 0x0053F298
		private void ClickObject(string[] objPath)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClickObjectStringbe_hotfix != null)
			{
				this.m_ClickObjectStringbe_hotfix.call(new object[]
				{
					this,
					objPath
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (objPath.Length == 0)
			{
				return;
			}
			GameObject gameObject = GameObjectUtility.FindChildObject(GameObjectUtility.SceneRoot, objPath);
			if (gameObject == null)
			{
				global::Debug.LogError(string.Format("UserGuideUITask.ClickObject {0}, {1}, Failed to find object: {2}", this.m_userGuideStepInfo.ID, this.m_userGuideStepInfo.Name, this.ArrayToPathString(objPath)));
				return;
			}
			if (!this.Click(gameObject))
			{
				global::Debug.LogError(string.Format("UserGuideUITask.ClickObject: {0}, {1}, {2} is not clickable.", this.m_userGuideStepInfo.ID, this.m_userGuideStepInfo.Name, this.ArrayToPathString(objPath)));
			}
		}

		// Token: 0x06014B6E RID: 84846 RVA: 0x00541198 File Offset: 0x0053F398
		private bool Click(GameObject o)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClickGameObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_ClickGameObject_hotfix.call(new object[]
				{
					this,
					o
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (o == null)
			{
				return false;
			}
			List<Component> list = new List<Component>();
			o.GetComponents(typeof(MonoBehaviour), list);
			bool result = false;
			foreach (Component component in list)
			{
				IPointerDownHandler pointerDownHandler = component as IPointerDownHandler;
				if (pointerDownHandler != null)
				{
					pointerDownHandler.OnPointerDown(new PointerEventData(EventSystem.current));
					result = true;
				}
				IPointerUpHandler pointerUpHandler = component as IPointerUpHandler;
				if (pointerUpHandler != null)
				{
					pointerUpHandler.OnPointerUp(new PointerEventData(EventSystem.current));
					result = true;
				}
				IPointerClickHandler pointerClickHandler = component as IPointerClickHandler;
				if (pointerClickHandler != null)
				{
					pointerClickHandler.OnPointerClick(new PointerEventData(EventSystem.current));
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014B6F RID: 84847 RVA: 0x005412E8 File Offset: 0x0053F4E8
		private string ArrayToPathString(string[] path)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArrayToPathStringStringbe_hotfix != null)
			{
				return (string)this.m_ArrayToPathStringStringbe_hotfix.call(new object[]
				{
					this,
					path
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (path.Length == 0)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string value in path)
			{
				stringBuilder.Append(value);
				stringBuilder.Append("\\");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06014B70 RID: 84848 RVA: 0x005413AC File Offset: 0x0053F5AC
		[DebuggerHidden]
		private IEnumerator DoAction(UserGuideAction action, string param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoActionUserGuideActionString_hotfix != null)
			{
				return (IEnumerator)this.m_DoActionUserGuideActionString_hotfix.call(new object[]
				{
					this,
					action,
					param
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UserGuideUITask.<DoAction>c__Iterator2 <DoAction>c__Iterator = new UserGuideUITask.<DoAction>c__Iterator2();
			<DoAction>c__Iterator.action = action;
			<DoAction>c__Iterator.param = param;
			<DoAction>c__Iterator.$this = this;
			return <DoAction>c__Iterator;
		}

		// Token: 0x06014B71 RID: 84849 RVA: 0x00541454 File Offset: 0x0053F654
		private void EnableBattleCameraTouchMove(bool isEnable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableBattleCameraTouchMoveBoolean_hotfix != null)
			{
				this.m_EnableBattleCameraTouchMoveBoolean_hotfix.call(new object[]
				{
					this,
					isEnable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleUITask battleUITask = UIUtility.FindUITaskWithType(typeof(BattleUITask)) as BattleUITask;
			if (battleUITask != null && battleUITask.State == Task.TaskState.Running && battleUITask.ClientBattle != null)
			{
				battleUITask.ClientBattle.BattleCamera.EnableTouchMove2(isEnable);
			}
		}

		// Token: 0x06014B72 RID: 84850 RVA: 0x00541508 File Offset: 0x0053F708
		private void FinishCurrentUserGuide()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishCurrentUserGuide_hotfix != null)
			{
				this.m_FinishCurrentUserGuide_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideStepInfo == null)
			{
				global::Debug.Log("UserGuideUITask.FinishCurrentUserGuide m_userGuideStepInfo is null.");
			}
			global::Debug.Log(string.Format("UserGuideUITask.FinishCurrentUserGuide {0}, {1}, ...", this.m_userGuideStepInfo.ID, this.m_userGuideStepInfo.Name));
			for (ConfigDataUserGuideStep configDataUserGuideStep = this.m_userGuideStepInfo; configDataUserGuideStep != null; configDataUserGuideStep = configDataUserGuideStep.m_nextUserGuideInfo)
			{
				UserGuideUITask.Trigger(UserGuideTrigger.UserGuideTrigger_FinishGuideStepN, configDataUserGuideStep.ID.ToString());
			}
		}

		// Token: 0x06014B73 RID: 84851 RVA: 0x005415DC File Offset: 0x0053F7DC
		[DebuggerHidden]
		private IEnumerator WaitForObjectReady(string objPath)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WaitForObjectReadyString_hotfix != null)
			{
				return (IEnumerator)this.m_WaitForObjectReadyString_hotfix.call(new object[]
				{
					this,
					objPath
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UserGuideUITask.<WaitForObjectReady>c__Iterator3 <WaitForObjectReady>c__Iterator = new UserGuideUITask.<WaitForObjectReady>c__Iterator3();
			<WaitForObjectReady>c__Iterator.objPath = objPath;
			<WaitForObjectReady>c__Iterator.$this = this;
			return <WaitForObjectReady>c__Iterator;
		}

		// Token: 0x06014B74 RID: 84852 RVA: 0x00541670 File Offset: 0x0053F870
		[DebuggerHidden]
		private IEnumerator ScrollToItem(string scrollObjPath, string itemObjPath)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ScrollToItemStringString_hotfix != null)
			{
				return (IEnumerator)this.m_ScrollToItemStringString_hotfix.call(new object[]
				{
					this,
					scrollObjPath,
					itemObjPath
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UserGuideUITask.<ScrollToItem>c__Iterator4 <ScrollToItem>c__Iterator = new UserGuideUITask.<ScrollToItem>c__Iterator4();
			<ScrollToItem>c__Iterator.scrollObjPath = scrollObjPath;
			<ScrollToItem>c__Iterator.itemObjPath = itemObjPath;
			<ScrollToItem>c__Iterator.$this = this;
			return <ScrollToItem>c__Iterator;
		}

		// Token: 0x06014B75 RID: 84853 RVA: 0x00541718 File Offset: 0x0053F918
		private void EnableObject(GameObject obj, bool isEnable)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableObjectGameObjectBoolean_hotfix != null)
			{
				this.m_EnableObjectGameObjectBoolean_hotfix.call(new object[]
				{
					this,
					obj,
					isEnable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (obj == null)
			{
				return;
			}
			BattleSkillButton component = obj.GetComponent<BattleSkillButton>();
			if (component != null)
			{
				component.enabled = isEnable;
				return;
			}
			Button component2 = obj.GetComponent<Button>();
			if (component2 != null)
			{
				component2.enabled = isEnable;
				return;
			}
			Toggle component3 = obj.GetComponent<Toggle>();
			if (component3 != null)
			{
				component3.enabled = isEnable;
				return;
			}
			WorldWaypointUIController component4 = obj.GetComponent<WorldWaypointUIController>();
			if (component4 != null)
			{
				component4.enabled = isEnable;
				return;
			}
			obj.SetActive(isEnable);
		}

		// Token: 0x06014B76 RID: 84854 RVA: 0x00541818 File Offset: 0x0053FA18
		private void ClickBattleGrid(int x, int y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClickBattleGridInt32Int32_hotfix != null)
			{
				this.m_ClickBattleGridInt32Int32_hotfix.call(new object[]
				{
					this,
					x,
					y
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleUITask battleUITask = UIUtility.FindUITaskWithType(typeof(BattleUITask)) as BattleUITask;
			if (battleUITask != null)
			{
				if (battleUITask.ClientBattle.State == ClientBattleState.Prepare)
				{
					battleUITask.BattlePrepareUIController_OnPointerClick(PointerEventData.InputButton.Left, battleUITask.ClientBattle.GridPositionToScreenPosition(new GridPosition(x, y)));
				}
				else
				{
					battleUITask.OnBattleMapClick(new GridPosition(x, y), false);
				}
			}
		}

		// Token: 0x06014B77 RID: 84855 RVA: 0x005418F0 File Offset: 0x0053FAF0
		private void ShowCurrentPage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCurrentPage_hotfix != null)
			{
				this.m_ShowCurrentPage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool hasNext = this.m_pageIndex < this.m_userGuideUIController.GetPagesCount() - 1;
			bool hasPrev = this.m_pageIndex > 0;
			this.m_userGuideUIController.ShowPage(this.m_pageIndex, hasNext, hasPrev);
		}

		// Token: 0x06014B78 RID: 84856 RVA: 0x00541984 File Offset: 0x0053FB84
		private void InitUserGuideUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitUserGuideUIController_hotfix != null)
			{
				this.m_InitUserGuideUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_userGuideUIController = (this.m_uiCtrlArray[0] as UserGuideUIController);
				}
				if (!(this.m_userGuideUIController != null))
				{
					global::Debug.LogError("UserGuideUIController is null");
					return;
				}
				this.m_userGuideUIController.EventOnNext += this.OnNextButtonClicked;
				this.m_userGuideUIController.EventOnNextPage += this.UserGuideUIController_OnNextPage;
				this.m_userGuideUIController.EventOnPrevPage += this.UserGuideUIController_OnPrevPage;
				this.m_userGuideUIController.EventOnSkip += this.OnSkipUserGuide;
			}
		}

		// Token: 0x06014B79 RID: 84857 RVA: 0x00541A94 File Offset: 0x0053FC94
		private void UninitUserGuideUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitUserGuideUIController_hotfix != null)
			{
				this.m_UninitUserGuideUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideUIController != null)
			{
				this.m_userGuideUIController.EventOnNext -= this.OnNextButtonClicked;
				this.m_userGuideUIController.EventOnNextPage -= this.UserGuideUIController_OnNextPage;
				this.m_userGuideUIController.EventOnPrevPage -= this.UserGuideUIController_OnPrevPage;
				this.m_userGuideUIController.EventOnSkip -= this.OnSkipUserGuide;
				this.m_userGuideUIController = null;
			}
		}

		// Token: 0x06014B7A RID: 84858 RVA: 0x00541B68 File Offset: 0x0053FD68
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
			UIIntentReturnable uiintentReturnable = new UIIntentReturnable(this.m_currIntent, typeof(BattleDialogUITask).Name, null);
			uiintentReturnable.SetParam("BattleDialogInfo", this.m_userGuideStepInfo.m_battleDialogInfo);
			BattleDialogUITask battleDialogUITask = UIManager.Instance.StartUITask(uiintentReturnable, true, false, new Action(this.BattleDialogUITask_OnLoadAllResCompleted)) as BattleDialogUITask;
			if (this.m_battleDialogUITask == null)
			{
				this.m_battleDialogUITask = battleDialogUITask;
				this.m_battleDialogUITask.EventOnUserGuideClose += this.BattleDialogUITask_OnUserGuideClose;
			}
		}

		// Token: 0x06014B7B RID: 84859 RVA: 0x00541C5C File Offset: 0x0053FE5C
		private void BattleDialogUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleDialogUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_BattleDialogUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(BattleDialogUITask));
			if (uitaskBase != null)
			{
				UIUtility.ActivateLayer(this.m_userGuideUIController, false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06014B7C RID: 84860 RVA: 0x00541CE4 File Offset: 0x0053FEE4
		[DebuggerHidden]
		private IEnumerator StartUserGuideDialogUITask(ConfigDataUserGuideDialogInfo dialogInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUserGuideDialogUITaskConfigDataUserGuideDialogInfo_hotfix != null)
			{
				return (IEnumerator)this.m_StartUserGuideDialogUITaskConfigDataUserGuideDialogInfo_hotfix.call(new object[]
				{
					this,
					dialogInfo
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UserGuideUITask.<StartUserGuideDialogUITask>c__Iterator5 <StartUserGuideDialogUITask>c__Iterator = new UserGuideUITask.<StartUserGuideDialogUITask>c__Iterator5();
			<StartUserGuideDialogUITask>c__Iterator.dialogInfo = dialogInfo;
			<StartUserGuideDialogUITask>c__Iterator.$this = this;
			return <StartUserGuideDialogUITask>c__Iterator;
		}

		// Token: 0x06014B7D RID: 84861 RVA: 0x00541D78 File Offset: 0x0053FF78
		private void UserGuideDialogUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UserGuideDialogUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_UserGuideDialogUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(UserGuideDialogUITask));
			if (uitaskBase != null)
			{
				UIUtility.ActivateLayer(this.m_userGuideUIController, false);
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06014B7E RID: 84862 RVA: 0x00541E00 File Offset: 0x00540000
		private void OnNextButtonClicked()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNextButtonClicked_hotfix != null)
			{
				this.m_OnNextButtonClicked_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Finish(true, false);
			if (this.m_userGuideStepInfo != null && this.m_userGuideStepInfo.NextTrigger.Count == 0)
			{
				this.Next();
			}
		}

		// Token: 0x06014B7F RID: 84863 RVA: 0x00541E90 File Offset: 0x00540090
		private void OnSkipUserGuide()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkipUserGuide_hotfix != null)
			{
				this.m_OnSkipUserGuide_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("UserGuideUITask.OnSkipUserGuide");
			this.FinishCurrentUserGuide();
			this.ForceStop();
		}

		// Token: 0x06014B80 RID: 84864 RVA: 0x00541F08 File Offset: 0x00540108
		private void Finish(bool isClick = true, bool bForce = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishBooleanBoolean_hotfix != null)
			{
				this.m_FinishBooleanBoolean_hotfix.call(new object[]
				{
					this,
					isClick,
					bForce
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isFinished)
			{
				return;
			}
			if (this.m_isDoingUpdateViewAsync)
			{
				global::Debug.LogError(string.Format("UserGuideUITask.Finish {0}, {1}, Error: m_isDoingUpdateViewAsync = true", this.m_userGuideStepInfo.ID, this.m_userGuideStepInfo.Name));
				return;
			}
			if (this.m_isTemporaryDisableMoveBattleCamera || bForce)
			{
				this.EnableBattleCameraTouchMove(true);
				this.m_isTemporaryDisableMoveBattleCamera = false;
			}
			foreach (GameObject obj in this.m_temporaryDisableObjects)
			{
				this.EnableObject(obj, true);
			}
			this.m_temporaryDisableObjects.Clear();
			foreach (GameObject gameObject in this.m_temporaryDeactiveObjects)
			{
				if (gameObject != null)
				{
					gameObject.SetActive(true);
				}
			}
			this.m_temporaryDeactiveObjects.Clear();
			if (isClick)
			{
				if (!string.IsNullOrEmpty(this.m_userGuideStepInfo.ClickObjectPath))
				{
					this.ClickObject(this.m_userGuideStepInfo.ClickObjectPath.Split(new char[]
					{
						'\\'
					}));
				}
				else if (this.m_userGuideStepInfo.BattleMapX > 0)
				{
					this.ClickBattleGrid(this.m_userGuideStepInfo.BattleMapX, this.m_userGuideStepInfo.BattleMapY);
				}
			}
			this.m_userGuideUIController.HideFunctionOpen();
			this.m_userGuideUIController.HideUserGuideTips();
			this.m_userGuideUIController.HideClickMask();
			this.m_userGuideUIController.EnableBackgroundButton = false;
			this.m_userGuideUIController.HidePage();
			CommonUIController.Instance.EnableInput(true);
			this.m_isFinished = true;
			global::Debug.Log(string.Format("UserGuideUITask Finished: {0}, {1}", this.m_userGuideStepInfo.ID, this.m_userGuideStepInfo.Name));
			if (this.m_userGuideStepInfo != null)
			{
				UserGuideUITask.Trigger(UserGuideTrigger.UserGuideTrigger_FinishGuideStepN, this.m_userGuideStepInfo.ID.ToString());
			}
		}

		// Token: 0x06014B81 RID: 84865 RVA: 0x005421B4 File Offset: 0x005403B4
		private void Next()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Next_hotfix != null)
			{
				this.m_Next_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isDoingUpdateViewAsync)
			{
				global::Debug.LogError(string.Format("UserGuideUITask.Next {0}, {1}, Error: m_isDoingUpdateViewAsync = true", this.m_userGuideStepInfo.ID, this.m_userGuideStepInfo.Name));
				return;
			}
			if (!this.m_isFinished)
			{
				this.Finish(true, false);
			}
			if (this.m_initCoroutine != null)
			{
				CommonUIController.Instance.StopCoroutine(this.m_initCoroutine);
				this.m_initCoroutine = null;
			}
			if (this.m_userGuideStepInfo != null && this.m_userGuideStepInfo.m_nextUserGuideInfo != null)
			{
				global::Debug.Log(string.Format("UserGuideUITask.Next: Start {0}, {1} 's Next Step: {2}, {3}", new object[]
				{
					this.m_userGuideStepInfo.ID,
					this.m_userGuideStepInfo.Name,
					this.m_userGuideStepInfo.m_nextUserGuideInfo.ID,
					this.m_userGuideStepInfo.m_nextUserGuideInfo.Name
				}));
				this.m_userGuideStepInfo = this.m_userGuideStepInfo.m_nextUserGuideInfo;
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else
			{
				if (this.m_userGuideStepInfo != null)
				{
					global::Debug.Log(string.Format("UserGuideUITask.Next: {0}, {1}, No Next Step.", this.m_userGuideStepInfo.ID, this.m_userGuideStepInfo.Name));
				}
				base.Pause();
				this.m_userGuideStepInfo = null;
			}
		}

		// Token: 0x06014B82 RID: 84866 RVA: 0x00542360 File Offset: 0x00540560
		private void UserGuideUIController_OnNextPage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UserGuideUIController_OnNextPage_hotfix != null)
			{
				this.m_UserGuideUIController_OnNextPage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideStepInfo == null)
			{
				return;
			}
			if (this.m_pageIndex < this.m_userGuideUIController.GetPagesCount() - 1)
			{
				this.m_pageIndex++;
				this.ShowCurrentPage();
			}
		}

		// Token: 0x06014B83 RID: 84867 RVA: 0x005423F8 File Offset: 0x005405F8
		private void UserGuideUIController_OnPrevPage()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UserGuideUIController_OnPrevPage_hotfix != null)
			{
				this.m_UserGuideUIController_OnPrevPage_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideStepInfo == null)
			{
				return;
			}
			if (this.m_pageIndex > 0)
			{
				this.m_pageIndex--;
				this.ShowCurrentPage();
			}
		}

		// Token: 0x06014B84 RID: 84868 RVA: 0x00542484 File Offset: 0x00540684
		private void BattleDialogUITask_OnUserGuideClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleDialogUITask_OnUserGuideClose_hotfix != null)
			{
				this.m_BattleDialogUITask_OnUserGuideClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleDialogUITask != null)
			{
				this.m_battleDialogUITask.EventOnUserGuideClose -= this.BattleDialogUITask_OnUserGuideClose;
				this.m_battleDialogUITask = null;
			}
			if (this.m_battleDialogInfo == null || this.m_userGuideStepInfo == null)
			{
				return;
			}
			this.m_battleDialogInfo = null;
			UIUtility.ActivateLayer(this.m_userGuideUIController, true);
			this.Finish(true, false);
			if (this.m_userGuideStepInfo.NextTrigger.Count == 0)
			{
				this.Next();
			}
		}

		// Token: 0x06014B85 RID: 84869 RVA: 0x0054255C File Offset: 0x0054075C
		private void UserGuideDialogUITask_OnUserGuideClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UserGuideDialogUITask_OnUserGuideClose_hotfix != null)
			{
				this.m_UserGuideDialogUITask_OnUserGuideClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideDialogUITask != null)
			{
				WorldUITask.WorldUIController_ShowHide(true, true);
				this.m_userGuideDialogUITask.EventOnUserGuideClose -= this.UserGuideDialogUITask_OnUserGuideClose;
				this.m_userGuideDialogUITask = null;
			}
			if (this.m_userGuideStepInfo == null)
			{
				return;
			}
			UIUtility.ActivateLayer(this.m_userGuideUIController, true);
			this.Finish(true, false);
			if (this.m_userGuideStepInfo.NextTrigger.Count == 0)
			{
				this.Next();
			}
		}

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x06014B86 RID: 84870 RVA: 0x00542628 File Offset: 0x00540828
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

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x06014B87 RID: 84871 RVA: 0x0054269C File Offset: 0x0054089C
		// (set) Token: 0x06014B88 RID: 84872 RVA: 0x005426A4 File Offset: 0x005408A4
		public static bool Enable
		{
			get
			{
				return UserGuideUITask.m_isEnable;
			}
			set
			{
				if (UserGuideUITask.m_isEnable == value)
				{
					return;
				}
				UserGuideUITask userGuideUITask = UIUtility.FindUITaskWithType(typeof(UserGuideUITask)) as UserGuideUITask;
				if (userGuideUITask != null && userGuideUITask.State == Task.TaskState.Running)
				{
					userGuideUITask.ForceStop();
				}
				UserGuideUITask.m_isEnable = value;
				if (LocalConfig.Instance != null)
				{
					LocalConfig.Instance.Data.EnableUserGuide = UserGuideUITask.m_isEnable;
					LocalConfig.Instance.Save();
				}
			}
		}

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x06014B89 RID: 84873 RVA: 0x0054271C File Offset: 0x0054091C
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

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x06014B8A RID: 84874 RVA: 0x00542790 File Offset: 0x00540990
		// (set) Token: 0x06014B8B RID: 84875 RVA: 0x005427B0 File Offset: 0x005409B0
		[DoNotToLua]
		public new UserGuideUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UserGuideUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014B8C RID: 84876 RVA: 0x005427BC File Offset: 0x005409BC
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06014B8D RID: 84877 RVA: 0x005427C8 File Offset: 0x005409C8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06014B8E RID: 84878 RVA: 0x005427D0 File Offset: 0x005409D0
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06014B8F RID: 84879 RVA: 0x005427D8 File Offset: 0x005409D8
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06014B90 RID: 84880 RVA: 0x005427E4 File Offset: 0x005409E4
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06014B91 RID: 84881 RVA: 0x005427F0 File Offset: 0x005409F0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06014B92 RID: 84882 RVA: 0x005427FC File Offset: 0x005409FC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014B93 RID: 84883 RVA: 0x00542804 File Offset: 0x00540A04
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06014B94 RID: 84884 RVA: 0x0054280C File Offset: 0x00540A0C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06014B95 RID: 84885 RVA: 0x00542814 File Offset: 0x00540A14
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06014B96 RID: 84886 RVA: 0x0054281C File Offset: 0x00540A1C
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06014B97 RID: 84887 RVA: 0x00542824 File Offset: 0x00540A24
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06014B98 RID: 84888 RVA: 0x0054282C File Offset: 0x00540A2C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06014B99 RID: 84889 RVA: 0x00542834 File Offset: 0x00540A34
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06014B9A RID: 84890 RVA: 0x00542840 File Offset: 0x00540A40
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06014B9B RID: 84891 RVA: 0x0054284C File Offset: 0x00540A4C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06014B9C RID: 84892 RVA: 0x00542858 File Offset: 0x00540A58
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06014B9D RID: 84893 RVA: 0x00542864 File Offset: 0x00540A64
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06014B9E RID: 84894 RVA: 0x0054286C File Offset: 0x00540A6C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06014B9F RID: 84895 RVA: 0x00542874 File Offset: 0x00540A74
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06014BA0 RID: 84896 RVA: 0x0054287C File Offset: 0x00540A7C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06014BA1 RID: 84897 RVA: 0x00542884 File Offset: 0x00540A84
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06014BA2 RID: 84898 RVA: 0x0054288C File Offset: 0x00540A8C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06014BA5 RID: 84901 RVA: 0x005428C0 File Offset: 0x00540AC0
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
					this.m_TriggerUserGuideUserGuideTriggerString_hotfix = (luaObj.RawGet("TriggerUserGuide") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_ForceStop_hotfix = (luaObj.RawGet("ForceStop") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_AddShowHideEventForUserGuideStep_hotfix = (luaObj.RawGet("AddShowHideEventForUserGuideStep") as LuaFunction);
					this.m_DoUpdateView_hotfix = (luaObj.RawGet("DoUpdateView") as LuaFunction);
					this.m_EnableInputLatelySingle_hotfix = (luaObj.RawGet("EnableInputLately") as LuaFunction);
					this.m_DoUpdateViewAsync_hotfix = (luaObj.RawGet("DoUpdateViewAsync") as LuaFunction);
					this.m_OnFunctionOpenAnimEnd_hotfix = (luaObj.RawGet("OnFunctionOpenAnimEnd") as LuaFunction);
					this.m_IsClickableGameObject_hotfix = (luaObj.RawGet("IsClickable") as LuaFunction);
					this.m_PrepareForGetUIPositionGameObject_hotfix = (luaObj.RawGet("PrepareForGetUIPosition") as LuaFunction);
					this.m_ClickObjectStringbe_hotfix = (luaObj.RawGet("ClickObject") as LuaFunction);
					this.m_ClickGameObject_hotfix = (luaObj.RawGet("Click") as LuaFunction);
					this.m_ArrayToPathStringStringbe_hotfix = (luaObj.RawGet("ArrayToPathString") as LuaFunction);
					this.m_DoActionUserGuideActionString_hotfix = (luaObj.RawGet("DoAction") as LuaFunction);
					this.m_EnableBattleCameraTouchMoveBoolean_hotfix = (luaObj.RawGet("EnableBattleCameraTouchMove") as LuaFunction);
					this.m_FinishCurrentUserGuide_hotfix = (luaObj.RawGet("FinishCurrentUserGuide") as LuaFunction);
					this.m_WaitForObjectReadyString_hotfix = (luaObj.RawGet("WaitForObjectReady") as LuaFunction);
					this.m_ScrollToItemStringString_hotfix = (luaObj.RawGet("ScrollToItem") as LuaFunction);
					this.m_EnableObjectGameObjectBoolean_hotfix = (luaObj.RawGet("EnableObject") as LuaFunction);
					this.m_ClickBattleGridInt32Int32_hotfix = (luaObj.RawGet("ClickBattleGrid") as LuaFunction);
					this.m_ShowCurrentPage_hotfix = (luaObj.RawGet("ShowCurrentPage") as LuaFunction);
					this.m_InitUserGuideUIController_hotfix = (luaObj.RawGet("InitUserGuideUIController") as LuaFunction);
					this.m_UninitUserGuideUIController_hotfix = (luaObj.RawGet("UninitUserGuideUIController") as LuaFunction);
					this.m_StartBattleDialogUITaskConfigDataBattleDialogInfo_hotfix = (luaObj.RawGet("StartBattleDialogUITask") as LuaFunction);
					this.m_BattleDialogUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("BattleDialogUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartUserGuideDialogUITaskConfigDataUserGuideDialogInfo_hotfix = (luaObj.RawGet("StartUserGuideDialogUITask") as LuaFunction);
					this.m_UserGuideDialogUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("UserGuideDialogUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_OnNextButtonClicked_hotfix = (luaObj.RawGet("OnNextButtonClicked") as LuaFunction);
					this.m_OnSkipUserGuide_hotfix = (luaObj.RawGet("OnSkipUserGuide") as LuaFunction);
					this.m_FinishBooleanBoolean_hotfix = (luaObj.RawGet("Finish") as LuaFunction);
					this.m_Next_hotfix = (luaObj.RawGet("Next") as LuaFunction);
					this.m_UserGuideUIController_OnNextPage_hotfix = (luaObj.RawGet("UserGuideUIController_OnNextPage") as LuaFunction);
					this.m_UserGuideUIController_OnPrevPage_hotfix = (luaObj.RawGet("UserGuideUIController_OnPrevPage") as LuaFunction);
					this.m_BattleDialogUITask_OnUserGuideClose_hotfix = (luaObj.RawGet("BattleDialogUITask_OnUserGuideClose") as LuaFunction);
					this.m_UserGuideDialogUITask_OnUserGuideClose_hotfix = (luaObj.RawGet("UserGuideDialogUITask_OnUserGuideClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014BA6 RID: 84902 RVA: 0x00542DC0 File Offset: 0x00540FC0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UserGuideUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B595 RID: 46485
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "UserGuideUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/UserGuide_ABS/Prefab/UserGuideUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B596 RID: 46486
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "UserGuideUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.UserGuideUIController"),
				m_ctrlName = "UserGuideUIController"
			}
		};

		// Token: 0x0400B597 RID: 46487
		private Coroutine m_initCoroutine;

		// Token: 0x0400B598 RID: 46488
		private UserGuideUIController m_userGuideUIController;

		// Token: 0x0400B599 RID: 46489
		private ConfigDataUserGuideStep m_userGuideStepInfo;

		// Token: 0x0400B59A RID: 46490
		private const float m_waitForClickObjectTime = 0.2f;

		// Token: 0x0400B59B RID: 46491
		private const float m_maxWaitObjectTime = 20f;

		// Token: 0x0400B59C RID: 46492
		private ConfigDataBattleDialogInfo m_battleDialogInfo;

		// Token: 0x0400B59D RID: 46493
		private BattleDialogUITask m_battleDialogUITask;

		// Token: 0x0400B59E RID: 46494
		private UserGuideDialogUITask m_userGuideDialogUITask;

		// Token: 0x0400B59F RID: 46495
		private int m_pageIndex;

		// Token: 0x0400B5A0 RID: 46496
		private int m_nUserGuideId;

		// Token: 0x0400B5A1 RID: 46497
		private bool m_isDoingUpdateViewAsync;

		// Token: 0x0400B5A2 RID: 46498
		private List<GameObject> m_temporaryDisableObjects = new List<GameObject>();

		// Token: 0x0400B5A3 RID: 46499
		private List<GameObject> m_temporaryDeactiveObjects = new List<GameObject>();

		// Token: 0x0400B5A4 RID: 46500
		private bool m_isFinished;

		// Token: 0x0400B5A5 RID: 46501
		private bool m_isTemporaryDisableMoveBattleCamera;

		// Token: 0x0400B5A6 RID: 46502
		private bool m_isEnableSkip;

		// Token: 0x0400B5A7 RID: 46503
		private static Dictionary<int, int> m_triggerUserGuideCounts = null;

		// Token: 0x0400B5A8 RID: 46504
		private static Dictionary<int, ConfigDataUserGuide> m_userGuideConfigs = new Dictionary<int, ConfigDataUserGuide>();

		// Token: 0x0400B5A9 RID: 46505
		private static List<string[]> m_userGuideShowHideEventObjectPaths = new List<string[]>();

		// Token: 0x0400B5AA RID: 46506
		private static bool m_isEnable = true;

		// Token: 0x0400B5AB RID: 46507
		private static int m_dragHeroToBattleUserGuideID;

		// Token: 0x0400B5AC RID: 46508
		[DoNotToLua]
		private UserGuideUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B5AD RID: 46509
		[CompilerGenerated]
		private static Action<string> <>f__mg$cache0;

		// Token: 0x0400B5AE RID: 46510
		[CompilerGenerated]
		private static Action<string> <>f__mg$cache1;

		// Token: 0x0400B5AF RID: 46511
		[CompilerGenerated]
		private static Action<string> <>f__mg$cache2;

		// Token: 0x0400B5B0 RID: 46512
		[CompilerGenerated]
		private static Action<string> <>f__mg$cache3;

		// Token: 0x0400B5B1 RID: 46513
		[CompilerGenerated]
		private static Action<GameObject> <>f__mg$cache4;

		// Token: 0x0400B5B2 RID: 46514
		[CompilerGenerated]
		private static Action<GameObject> <>f__mg$cache5;

		// Token: 0x0400B5B3 RID: 46515
		[CompilerGenerated]
		private static Action<GameObject, string> <>f__mg$cache6;

		// Token: 0x0400B5B4 RID: 46516
		[CompilerGenerated]
		private static Action<GameObject, string> <>f__mg$cache7;

		// Token: 0x0400B5B5 RID: 46517
		[CompilerGenerated]
		private static Action<ClientBattleActor> <>f__mg$cache8;

		// Token: 0x0400B5B6 RID: 46518
		[CompilerGenerated]
		private static Action<ClientBattleActor> <>f__mg$cache9;

		// Token: 0x0400B5B7 RID: 46519
		[CompilerGenerated]
		private static Action<ClientBattleActor> <>f__mg$cacheA;

		// Token: 0x0400B5B8 RID: 46520
		[CompilerGenerated]
		private static Action<ClientBattleActor> <>f__mg$cacheB;

		// Token: 0x0400B5B9 RID: 46521
		[CompilerGenerated]
		private static Action<int> <>f__mg$cacheC;

		// Token: 0x0400B5BA RID: 46522
		[CompilerGenerated]
		private static Action<int> <>f__mg$cacheD;

		// Token: 0x0400B5BB RID: 46523
		[CompilerGenerated]
		private static Action<int> <>f__mg$cacheE;

		// Token: 0x0400B5BC RID: 46524
		[CompilerGenerated]
		private static Action<int> <>f__mg$cacheF;

		// Token: 0x0400B5BD RID: 46525
		[CompilerGenerated]
		private static Action<string> <>f__mg$cache10;

		// Token: 0x0400B5BE RID: 46526
		[CompilerGenerated]
		private static Action<string> <>f__mg$cache11;

		// Token: 0x0400B5BF RID: 46527
		[CompilerGenerated]
		private static Action<bool> <>f__mg$cache12;

		// Token: 0x0400B5C0 RID: 46528
		[CompilerGenerated]
		private static Action<bool> <>f__mg$cache13;

		// Token: 0x0400B5C2 RID: 46530
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B5C3 RID: 46531
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B5C4 RID: 46532
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B5C5 RID: 46533
		private LuaFunction m_TriggerUserGuideUserGuideTriggerString_hotfix;

		// Token: 0x0400B5C6 RID: 46534
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400B5C7 RID: 46535
		private LuaFunction m_ForceStop_hotfix;

		// Token: 0x0400B5C8 RID: 46536
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400B5C9 RID: 46537
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400B5CA RID: 46538
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400B5CB RID: 46539
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B5CC RID: 46540
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B5CD RID: 46541
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B5CE RID: 46542
		private LuaFunction m_AddShowHideEventForUserGuideStep_hotfix;

		// Token: 0x0400B5CF RID: 46543
		private LuaFunction m_DoUpdateView_hotfix;

		// Token: 0x0400B5D0 RID: 46544
		private LuaFunction m_EnableInputLatelySingle_hotfix;

		// Token: 0x0400B5D1 RID: 46545
		private LuaFunction m_DoUpdateViewAsync_hotfix;

		// Token: 0x0400B5D2 RID: 46546
		private LuaFunction m_OnFunctionOpenAnimEnd_hotfix;

		// Token: 0x0400B5D3 RID: 46547
		private LuaFunction m_IsClickableGameObject_hotfix;

		// Token: 0x0400B5D4 RID: 46548
		private LuaFunction m_PrepareForGetUIPositionGameObject_hotfix;

		// Token: 0x0400B5D5 RID: 46549
		private LuaFunction m_ClickObjectStringbe_hotfix;

		// Token: 0x0400B5D6 RID: 46550
		private LuaFunction m_ClickGameObject_hotfix;

		// Token: 0x0400B5D7 RID: 46551
		private LuaFunction m_ArrayToPathStringStringbe_hotfix;

		// Token: 0x0400B5D8 RID: 46552
		private LuaFunction m_DoActionUserGuideActionString_hotfix;

		// Token: 0x0400B5D9 RID: 46553
		private LuaFunction m_EnableBattleCameraTouchMoveBoolean_hotfix;

		// Token: 0x0400B5DA RID: 46554
		private LuaFunction m_FinishCurrentUserGuide_hotfix;

		// Token: 0x0400B5DB RID: 46555
		private LuaFunction m_WaitForObjectReadyString_hotfix;

		// Token: 0x0400B5DC RID: 46556
		private LuaFunction m_ScrollToItemStringString_hotfix;

		// Token: 0x0400B5DD RID: 46557
		private LuaFunction m_EnableObjectGameObjectBoolean_hotfix;

		// Token: 0x0400B5DE RID: 46558
		private LuaFunction m_ClickBattleGridInt32Int32_hotfix;

		// Token: 0x0400B5DF RID: 46559
		private LuaFunction m_ShowCurrentPage_hotfix;

		// Token: 0x0400B5E0 RID: 46560
		private LuaFunction m_InitUserGuideUIController_hotfix;

		// Token: 0x0400B5E1 RID: 46561
		private LuaFunction m_UninitUserGuideUIController_hotfix;

		// Token: 0x0400B5E2 RID: 46562
		private LuaFunction m_StartBattleDialogUITaskConfigDataBattleDialogInfo_hotfix;

		// Token: 0x0400B5E3 RID: 46563
		private LuaFunction m_BattleDialogUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B5E4 RID: 46564
		private LuaFunction m_StartUserGuideDialogUITaskConfigDataUserGuideDialogInfo_hotfix;

		// Token: 0x0400B5E5 RID: 46565
		private LuaFunction m_UserGuideDialogUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B5E6 RID: 46566
		private LuaFunction m_OnNextButtonClicked_hotfix;

		// Token: 0x0400B5E7 RID: 46567
		private LuaFunction m_OnSkipUserGuide_hotfix;

		// Token: 0x0400B5E8 RID: 46568
		private LuaFunction m_FinishBooleanBoolean_hotfix;

		// Token: 0x0400B5E9 RID: 46569
		private LuaFunction m_Next_hotfix;

		// Token: 0x0400B5EA RID: 46570
		private LuaFunction m_UserGuideUIController_OnNextPage_hotfix;

		// Token: 0x0400B5EB RID: 46571
		private LuaFunction m_UserGuideUIController_OnPrevPage_hotfix;

		// Token: 0x0400B5EC RID: 46572
		private LuaFunction m_BattleDialogUITask_OnUserGuideClose_hotfix;

		// Token: 0x0400B5ED RID: 46573
		private LuaFunction m_UserGuideDialogUITask_OnUserGuideClose_hotfix;

		// Token: 0x0400B5EE RID: 46574
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B5EF RID: 46575
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x0200100A RID: 4106
		public new class LuaExportHelper
		{
			// Token: 0x06014BA7 RID: 84903 RVA: 0x00542E28 File Offset: 0x00541028
			public LuaExportHelper(UserGuideUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014BA8 RID: 84904 RVA: 0x00542E38 File Offset: 0x00541038
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06014BA9 RID: 84905 RVA: 0x00542E48 File Offset: 0x00541048
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06014BAA RID: 84906 RVA: 0x00542E58 File Offset: 0x00541058
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06014BAB RID: 84907 RVA: 0x00542E68 File Offset: 0x00541068
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06014BAC RID: 84908 RVA: 0x00542E78 File Offset: 0x00541078
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06014BAD RID: 84909 RVA: 0x00542E88 File Offset: 0x00541088
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06014BAE RID: 84910 RVA: 0x00542E98 File Offset: 0x00541098
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06014BAF RID: 84911 RVA: 0x00542EA8 File Offset: 0x005410A8
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06014BB0 RID: 84912 RVA: 0x00542EB8 File Offset: 0x005410B8
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06014BB1 RID: 84913 RVA: 0x00542EC8 File Offset: 0x005410C8
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06014BB2 RID: 84914 RVA: 0x00542ED8 File Offset: 0x005410D8
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06014BB3 RID: 84915 RVA: 0x00542EE8 File Offset: 0x005410E8
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06014BB4 RID: 84916 RVA: 0x00542EF8 File Offset: 0x005410F8
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06014BB5 RID: 84917 RVA: 0x00542F08 File Offset: 0x00541108
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06014BB6 RID: 84918 RVA: 0x00542F18 File Offset: 0x00541118
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06014BB7 RID: 84919 RVA: 0x00542F28 File Offset: 0x00541128
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06014BB8 RID: 84920 RVA: 0x00542F38 File Offset: 0x00541138
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06014BB9 RID: 84921 RVA: 0x00542F48 File Offset: 0x00541148
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06014BBA RID: 84922 RVA: 0x00542F58 File Offset: 0x00541158
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06014BBB RID: 84923 RVA: 0x00542F68 File Offset: 0x00541168
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06014BBC RID: 84924 RVA: 0x00542F78 File Offset: 0x00541178
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06014BBD RID: 84925 RVA: 0x00542F88 File Offset: 0x00541188
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06014BBE RID: 84926 RVA: 0x00542F98 File Offset: 0x00541198
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003D3B RID: 15675
			// (get) Token: 0x06014BBF RID: 84927 RVA: 0x00542FA8 File Offset: 0x005411A8
			// (set) Token: 0x06014BC0 RID: 84928 RVA: 0x00542FB8 File Offset: 0x005411B8
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

			// Token: 0x17003D3C RID: 15676
			// (get) Token: 0x06014BC1 RID: 84929 RVA: 0x00542FC8 File Offset: 0x005411C8
			// (set) Token: 0x06014BC2 RID: 84930 RVA: 0x00542FD8 File Offset: 0x005411D8
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

			// Token: 0x17003D3D RID: 15677
			// (get) Token: 0x06014BC3 RID: 84931 RVA: 0x00542FE8 File Offset: 0x005411E8
			// (set) Token: 0x06014BC4 RID: 84932 RVA: 0x00542FF8 File Offset: 0x005411F8
			public Coroutine m_initCoroutine
			{
				get
				{
					return this.m_owner.m_initCoroutine;
				}
				set
				{
					this.m_owner.m_initCoroutine = value;
				}
			}

			// Token: 0x17003D3E RID: 15678
			// (get) Token: 0x06014BC5 RID: 84933 RVA: 0x00543008 File Offset: 0x00541208
			// (set) Token: 0x06014BC6 RID: 84934 RVA: 0x00543018 File Offset: 0x00541218
			public UserGuideUIController m_userGuideUIController
			{
				get
				{
					return this.m_owner.m_userGuideUIController;
				}
				set
				{
					this.m_owner.m_userGuideUIController = value;
				}
			}

			// Token: 0x17003D3F RID: 15679
			// (get) Token: 0x06014BC7 RID: 84935 RVA: 0x00543028 File Offset: 0x00541228
			// (set) Token: 0x06014BC8 RID: 84936 RVA: 0x00543038 File Offset: 0x00541238
			public ConfigDataUserGuideStep m_userGuideStepInfo
			{
				get
				{
					return this.m_owner.m_userGuideStepInfo;
				}
				set
				{
					this.m_owner.m_userGuideStepInfo = value;
				}
			}

			// Token: 0x17003D40 RID: 15680
			// (get) Token: 0x06014BC9 RID: 84937 RVA: 0x00543048 File Offset: 0x00541248
			public static float m_waitForClickObjectTime
			{
				get
				{
					return 0.2f;
				}
			}

			// Token: 0x17003D41 RID: 15681
			// (get) Token: 0x06014BCA RID: 84938 RVA: 0x00543050 File Offset: 0x00541250
			public static float m_maxWaitObjectTime
			{
				get
				{
					return 20f;
				}
			}

			// Token: 0x17003D42 RID: 15682
			// (get) Token: 0x06014BCB RID: 84939 RVA: 0x00543058 File Offset: 0x00541258
			// (set) Token: 0x06014BCC RID: 84940 RVA: 0x00543068 File Offset: 0x00541268
			public ConfigDataBattleDialogInfo m_battleDialogInfo
			{
				get
				{
					return this.m_owner.m_battleDialogInfo;
				}
				set
				{
					this.m_owner.m_battleDialogInfo = value;
				}
			}

			// Token: 0x17003D43 RID: 15683
			// (get) Token: 0x06014BCD RID: 84941 RVA: 0x00543078 File Offset: 0x00541278
			// (set) Token: 0x06014BCE RID: 84942 RVA: 0x00543088 File Offset: 0x00541288
			public BattleDialogUITask m_battleDialogUITask
			{
				get
				{
					return this.m_owner.m_battleDialogUITask;
				}
				set
				{
					this.m_owner.m_battleDialogUITask = value;
				}
			}

			// Token: 0x17003D44 RID: 15684
			// (get) Token: 0x06014BCF RID: 84943 RVA: 0x00543098 File Offset: 0x00541298
			// (set) Token: 0x06014BD0 RID: 84944 RVA: 0x005430A8 File Offset: 0x005412A8
			public UserGuideDialogUITask m_userGuideDialogUITask
			{
				get
				{
					return this.m_owner.m_userGuideDialogUITask;
				}
				set
				{
					this.m_owner.m_userGuideDialogUITask = value;
				}
			}

			// Token: 0x17003D45 RID: 15685
			// (get) Token: 0x06014BD1 RID: 84945 RVA: 0x005430B8 File Offset: 0x005412B8
			// (set) Token: 0x06014BD2 RID: 84946 RVA: 0x005430C8 File Offset: 0x005412C8
			public int m_pageIndex
			{
				get
				{
					return this.m_owner.m_pageIndex;
				}
				set
				{
					this.m_owner.m_pageIndex = value;
				}
			}

			// Token: 0x17003D46 RID: 15686
			// (get) Token: 0x06014BD3 RID: 84947 RVA: 0x005430D8 File Offset: 0x005412D8
			// (set) Token: 0x06014BD4 RID: 84948 RVA: 0x005430E8 File Offset: 0x005412E8
			public int m_nUserGuideId
			{
				get
				{
					return this.m_owner.m_nUserGuideId;
				}
				set
				{
					this.m_owner.m_nUserGuideId = value;
				}
			}

			// Token: 0x17003D47 RID: 15687
			// (get) Token: 0x06014BD5 RID: 84949 RVA: 0x005430F8 File Offset: 0x005412F8
			// (set) Token: 0x06014BD6 RID: 84950 RVA: 0x00543108 File Offset: 0x00541308
			public bool m_isDoingUpdateViewAsync
			{
				get
				{
					return this.m_owner.m_isDoingUpdateViewAsync;
				}
				set
				{
					this.m_owner.m_isDoingUpdateViewAsync = value;
				}
			}

			// Token: 0x17003D48 RID: 15688
			// (get) Token: 0x06014BD7 RID: 84951 RVA: 0x00543118 File Offset: 0x00541318
			// (set) Token: 0x06014BD8 RID: 84952 RVA: 0x00543128 File Offset: 0x00541328
			public List<GameObject> m_temporaryDisableObjects
			{
				get
				{
					return this.m_owner.m_temporaryDisableObjects;
				}
				set
				{
					this.m_owner.m_temporaryDisableObjects = value;
				}
			}

			// Token: 0x17003D49 RID: 15689
			// (get) Token: 0x06014BD9 RID: 84953 RVA: 0x00543138 File Offset: 0x00541338
			// (set) Token: 0x06014BDA RID: 84954 RVA: 0x00543148 File Offset: 0x00541348
			public List<GameObject> m_temporaryDeactiveObjects
			{
				get
				{
					return this.m_owner.m_temporaryDeactiveObjects;
				}
				set
				{
					this.m_owner.m_temporaryDeactiveObjects = value;
				}
			}

			// Token: 0x17003D4A RID: 15690
			// (get) Token: 0x06014BDB RID: 84955 RVA: 0x00543158 File Offset: 0x00541358
			// (set) Token: 0x06014BDC RID: 84956 RVA: 0x00543168 File Offset: 0x00541368
			public bool m_isFinished
			{
				get
				{
					return this.m_owner.m_isFinished;
				}
				set
				{
					this.m_owner.m_isFinished = value;
				}
			}

			// Token: 0x17003D4B RID: 15691
			// (get) Token: 0x06014BDD RID: 84957 RVA: 0x00543178 File Offset: 0x00541378
			// (set) Token: 0x06014BDE RID: 84958 RVA: 0x00543188 File Offset: 0x00541388
			public bool m_isTemporaryDisableMoveBattleCamera
			{
				get
				{
					return this.m_owner.m_isTemporaryDisableMoveBattleCamera;
				}
				set
				{
					this.m_owner.m_isTemporaryDisableMoveBattleCamera = value;
				}
			}

			// Token: 0x17003D4C RID: 15692
			// (get) Token: 0x06014BDF RID: 84959 RVA: 0x00543198 File Offset: 0x00541398
			// (set) Token: 0x06014BE0 RID: 84960 RVA: 0x005431A8 File Offset: 0x005413A8
			public bool m_isEnableSkip
			{
				get
				{
					return this.m_owner.m_isEnableSkip;
				}
				set
				{
					this.m_owner.m_isEnableSkip = value;
				}
			}

			// Token: 0x17003D4D RID: 15693
			// (get) Token: 0x06014BE1 RID: 84961 RVA: 0x005431B8 File Offset: 0x005413B8
			// (set) Token: 0x06014BE2 RID: 84962 RVA: 0x005431C0 File Offset: 0x005413C0
			public static Dictionary<int, int> m_triggerUserGuideCounts
			{
				get
				{
					return UserGuideUITask.m_triggerUserGuideCounts;
				}
				set
				{
					UserGuideUITask.m_triggerUserGuideCounts = value;
				}
			}

			// Token: 0x17003D4E RID: 15694
			// (get) Token: 0x06014BE3 RID: 84963 RVA: 0x005431C8 File Offset: 0x005413C8
			// (set) Token: 0x06014BE4 RID: 84964 RVA: 0x005431D0 File Offset: 0x005413D0
			public static Dictionary<int, ConfigDataUserGuide> m_userGuideConfigs
			{
				get
				{
					return UserGuideUITask.m_userGuideConfigs;
				}
				set
				{
					UserGuideUITask.m_userGuideConfigs = value;
				}
			}

			// Token: 0x17003D4F RID: 15695
			// (get) Token: 0x06014BE5 RID: 84965 RVA: 0x005431D8 File Offset: 0x005413D8
			// (set) Token: 0x06014BE6 RID: 84966 RVA: 0x005431E0 File Offset: 0x005413E0
			public static List<string[]> m_userGuideShowHideEventObjectPaths
			{
				get
				{
					return UserGuideUITask.m_userGuideShowHideEventObjectPaths;
				}
				set
				{
					UserGuideUITask.m_userGuideShowHideEventObjectPaths = value;
				}
			}

			// Token: 0x17003D50 RID: 15696
			// (get) Token: 0x06014BE7 RID: 84967 RVA: 0x005431E8 File Offset: 0x005413E8
			// (set) Token: 0x06014BE8 RID: 84968 RVA: 0x005431F0 File Offset: 0x005413F0
			public static bool m_isEnable
			{
				get
				{
					return UserGuideUITask.m_isEnable;
				}
				set
				{
					UserGuideUITask.m_isEnable = value;
				}
			}

			// Token: 0x17003D51 RID: 15697
			// (get) Token: 0x06014BE9 RID: 84969 RVA: 0x005431F8 File Offset: 0x005413F8
			// (set) Token: 0x06014BEA RID: 84970 RVA: 0x00543200 File Offset: 0x00541400
			public static int m_dragHeroToBattleUserGuideID
			{
				get
				{
					return UserGuideUITask.m_dragHeroToBattleUserGuideID;
				}
				set
				{
					UserGuideUITask.m_dragHeroToBattleUserGuideID = value;
				}
			}

			// Token: 0x17003D52 RID: 15698
			// (get) Token: 0x06014BEB RID: 84971 RVA: 0x00543208 File Offset: 0x00541408
			public static string UserGuideProgressFileName
			{
				get
				{
					return UserGuideUITask.UserGuideProgressFileName;
				}
			}

			// Token: 0x17003D53 RID: 15699
			// (get) Token: 0x06014BEC RID: 84972 RVA: 0x00543210 File Offset: 0x00541410
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003D54 RID: 15700
			// (get) Token: 0x06014BED RID: 84973 RVA: 0x00543220 File Offset: 0x00541420
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06014BEE RID: 84974 RVA: 0x00543230 File Offset: 0x00541430
			public static void AddUserGuideTriggerCount(int userGuideId)
			{
				UserGuideUITask.AddUserGuideTriggerCount(userGuideId);
			}

			// Token: 0x06014BEF RID: 84975 RVA: 0x00543238 File Offset: 0x00541438
			public static int GetUserGuideTriggerCount(int userGuideId)
			{
				return UserGuideUITask.GetUserGuideTriggerCount(userGuideId);
			}

			// Token: 0x06014BF0 RID: 84976 RVA: 0x00543240 File Offset: 0x00541440
			public static void LoadUserGuideProgress()
			{
				UserGuideUITask.LoadUserGuideProgress();
			}

			// Token: 0x06014BF1 RID: 84977 RVA: 0x00543248 File Offset: 0x00541448
			public static void CollectUserGuideShowHideEventObjectPaths(List<string[]> paths)
			{
				UserGuideUITask.CollectUserGuideShowHideEventObjectPaths(paths);
			}

			// Token: 0x06014BF2 RID: 84978 RVA: 0x00543250 File Offset: 0x00541450
			public static void AddShowHideEventForUserGuide(GameObject obj)
			{
				UserGuideUITask.AddShowHideEventForUserGuide(obj);
			}

			// Token: 0x06014BF3 RID: 84979 RVA: 0x00543258 File Offset: 0x00541458
			public static bool IsUserGuideTriggerObject(GameObject obj)
			{
				return UserGuideUITask.IsUserGuideTriggerObject(obj);
			}

			// Token: 0x06014BF4 RID: 84980 RVA: 0x00543260 File Offset: 0x00541460
			public bool TriggerUserGuide(UserGuideTrigger trigger, string param)
			{
				return this.m_owner.TriggerUserGuide(trigger, param);
			}

			// Token: 0x06014BF5 RID: 84981 RVA: 0x00543270 File Offset: 0x00541470
			public static bool Trigger(UserGuideTrigger trigger, string param)
			{
				return UserGuideUITask.Trigger(trigger, param);
			}

			// Token: 0x06014BF6 RID: 84982 RVA: 0x0054327C File Offset: 0x0054147C
			public static bool MatchTrigger(UserGuideTrigger trigger1, string param1, UserGuideTrigger trigger2, string param2)
			{
				return UserGuideUITask.MatchTrigger(trigger1, param1, trigger2, param2);
			}

			// Token: 0x06014BF7 RID: 84983 RVA: 0x00543288 File Offset: 0x00541488
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06014BF8 RID: 84984 RVA: 0x00543298 File Offset: 0x00541498
			public void ForceStop()
			{
				this.m_owner.ForceStop();
			}

			// Token: 0x06014BF9 RID: 84985 RVA: 0x005432A8 File Offset: 0x005414A8
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06014BFA RID: 84986 RVA: 0x005432B8 File Offset: 0x005414B8
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x06014BFB RID: 84987 RVA: 0x005432C8 File Offset: 0x005414C8
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06014BFC RID: 84988 RVA: 0x005432D8 File Offset: 0x005414D8
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06014BFD RID: 84989 RVA: 0x005432E8 File Offset: 0x005414E8
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06014BFE RID: 84990 RVA: 0x005432F8 File Offset: 0x005414F8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06014BFF RID: 84991 RVA: 0x00543308 File Offset: 0x00541508
			public void AddShowHideEventForUserGuideStep()
			{
				this.m_owner.AddShowHideEventForUserGuideStep();
			}

			// Token: 0x06014C00 RID: 84992 RVA: 0x00543318 File Offset: 0x00541518
			public void DoUpdateView()
			{
				this.m_owner.DoUpdateView();
			}

			// Token: 0x06014C01 RID: 84993 RVA: 0x00543328 File Offset: 0x00541528
			public IEnumerator EnableInputLately(float time)
			{
				return this.m_owner.EnableInputLately(time);
			}

			// Token: 0x06014C02 RID: 84994 RVA: 0x00543338 File Offset: 0x00541538
			public IEnumerator DoUpdateViewAsync()
			{
				return this.m_owner.DoUpdateViewAsync();
			}

			// Token: 0x06014C03 RID: 84995 RVA: 0x00543348 File Offset: 0x00541548
			public void OnFunctionOpenAnimEnd()
			{
				this.m_owner.OnFunctionOpenAnimEnd();
			}

			// Token: 0x06014C04 RID: 84996 RVA: 0x00543358 File Offset: 0x00541558
			public static bool GetCenterScreenPosition(RectTransform rt, ref Vector2 pos)
			{
				return UserGuideUITask.GetCenterScreenPosition(rt, ref pos);
			}

			// Token: 0x06014C05 RID: 84997 RVA: 0x00543364 File Offset: 0x00541564
			public static bool IsInsideScreen(Vector2 pos)
			{
				return UserGuideUITask.IsInsideScreen(pos);
			}

			// Token: 0x06014C06 RID: 84998 RVA: 0x0054336C File Offset: 0x0054156C
			public bool IsClickable(GameObject obj)
			{
				return this.m_owner.IsClickable(obj);
			}

			// Token: 0x06014C07 RID: 84999 RVA: 0x0054337C File Offset: 0x0054157C
			public void PrepareForGetUIPosition(GameObject uiObj)
			{
				this.m_owner.PrepareForGetUIPosition(uiObj);
			}

			// Token: 0x06014C08 RID: 85000 RVA: 0x0054338C File Offset: 0x0054158C
			public void ClickObject(string[] objPath)
			{
				this.m_owner.ClickObject(objPath);
			}

			// Token: 0x06014C09 RID: 85001 RVA: 0x0054339C File Offset: 0x0054159C
			public bool Click(GameObject o)
			{
				return this.m_owner.Click(o);
			}

			// Token: 0x06014C0A RID: 85002 RVA: 0x005433AC File Offset: 0x005415AC
			public string ArrayToPathString(string[] path)
			{
				return this.m_owner.ArrayToPathString(path);
			}

			// Token: 0x06014C0B RID: 85003 RVA: 0x005433BC File Offset: 0x005415BC
			public IEnumerator DoAction(UserGuideAction action, string param)
			{
				return this.m_owner.DoAction(action, param);
			}

			// Token: 0x06014C0C RID: 85004 RVA: 0x005433CC File Offset: 0x005415CC
			public void EnableBattleCameraTouchMove(bool isEnable)
			{
				this.m_owner.EnableBattleCameraTouchMove(isEnable);
			}

			// Token: 0x06014C0D RID: 85005 RVA: 0x005433DC File Offset: 0x005415DC
			public void FinishCurrentUserGuide()
			{
				this.m_owner.FinishCurrentUserGuide();
			}

			// Token: 0x06014C0E RID: 85006 RVA: 0x005433EC File Offset: 0x005415EC
			public IEnumerator WaitForObjectReady(string objPath)
			{
				return this.m_owner.WaitForObjectReady(objPath);
			}

			// Token: 0x06014C0F RID: 85007 RVA: 0x005433FC File Offset: 0x005415FC
			public IEnumerator ScrollToItem(string scrollObjPath, string itemObjPath)
			{
				return this.m_owner.ScrollToItem(scrollObjPath, itemObjPath);
			}

			// Token: 0x06014C10 RID: 85008 RVA: 0x0054340C File Offset: 0x0054160C
			public void EnableObject(GameObject obj, bool isEnable)
			{
				this.m_owner.EnableObject(obj, isEnable);
			}

			// Token: 0x06014C11 RID: 85009 RVA: 0x0054341C File Offset: 0x0054161C
			public void ClickBattleGrid(int x, int y)
			{
				this.m_owner.ClickBattleGrid(x, y);
			}

			// Token: 0x06014C12 RID: 85010 RVA: 0x0054342C File Offset: 0x0054162C
			public void ShowCurrentPage()
			{
				this.m_owner.ShowCurrentPage();
			}

			// Token: 0x06014C13 RID: 85011 RVA: 0x0054343C File Offset: 0x0054163C
			public void InitUserGuideUIController()
			{
				this.m_owner.InitUserGuideUIController();
			}

			// Token: 0x06014C14 RID: 85012 RVA: 0x0054344C File Offset: 0x0054164C
			public void UninitUserGuideUIController()
			{
				this.m_owner.UninitUserGuideUIController();
			}

			// Token: 0x06014C15 RID: 85013 RVA: 0x0054345C File Offset: 0x0054165C
			public void StartBattleDialogUITask(ConfigDataBattleDialogInfo dialogInfo)
			{
				this.m_owner.StartBattleDialogUITask(dialogInfo);
			}

			// Token: 0x06014C16 RID: 85014 RVA: 0x0054346C File Offset: 0x0054166C
			public void BattleDialogUITask_OnLoadAllResCompleted()
			{
				this.m_owner.BattleDialogUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06014C17 RID: 85015 RVA: 0x0054347C File Offset: 0x0054167C
			public IEnumerator StartUserGuideDialogUITask(ConfigDataUserGuideDialogInfo dialogInfo)
			{
				return this.m_owner.StartUserGuideDialogUITask(dialogInfo);
			}

			// Token: 0x06014C18 RID: 85016 RVA: 0x0054348C File Offset: 0x0054168C
			public void UserGuideDialogUITask_OnLoadAllResCompleted()
			{
				this.m_owner.UserGuideDialogUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06014C19 RID: 85017 RVA: 0x0054349C File Offset: 0x0054169C
			public void OnNextButtonClicked()
			{
				this.m_owner.OnNextButtonClicked();
			}

			// Token: 0x06014C1A RID: 85018 RVA: 0x005434AC File Offset: 0x005416AC
			public void OnSkipUserGuide()
			{
				this.m_owner.OnSkipUserGuide();
			}

			// Token: 0x06014C1B RID: 85019 RVA: 0x005434BC File Offset: 0x005416BC
			public void Finish(bool isClick, bool bForce)
			{
				this.m_owner.Finish(isClick, bForce);
			}

			// Token: 0x06014C1C RID: 85020 RVA: 0x005434CC File Offset: 0x005416CC
			public void Next()
			{
				this.m_owner.Next();
			}

			// Token: 0x06014C1D RID: 85021 RVA: 0x005434DC File Offset: 0x005416DC
			public void UserGuideUIController_OnNextPage()
			{
				this.m_owner.UserGuideUIController_OnNextPage();
			}

			// Token: 0x06014C1E RID: 85022 RVA: 0x005434EC File Offset: 0x005416EC
			public void UserGuideUIController_OnPrevPage()
			{
				this.m_owner.UserGuideUIController_OnPrevPage();
			}

			// Token: 0x06014C1F RID: 85023 RVA: 0x005434FC File Offset: 0x005416FC
			public void BattleDialogUITask_OnUserGuideClose()
			{
				this.m_owner.BattleDialogUITask_OnUserGuideClose();
			}

			// Token: 0x06014C20 RID: 85024 RVA: 0x0054350C File Offset: 0x0054170C
			public void UserGuideDialogUITask_OnUserGuideClose()
			{
				this.m_owner.UserGuideDialogUITask_OnUserGuideClose();
			}

			// Token: 0x0400B5F0 RID: 46576
			private UserGuideUITask m_owner;
		}
	}
}
