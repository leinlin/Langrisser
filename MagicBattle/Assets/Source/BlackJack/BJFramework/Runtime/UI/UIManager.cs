using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.Utils;
using SLua;

namespace BlackJack.BJFramework.Runtime.UI
{
	// Token: 0x0200010A RID: 266
	[CustomLuaClassWithProtected]
	public class UIManager
	{
		// Token: 0x06000A8D RID: 2701 RVA: 0x0002CCB0 File Offset: 0x0002AEB0
		private UIManager()
		{
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0002CD34 File Offset: 0x0002AF34
		[DoNotToLua]
		public static UIManager CreateUIManager()
		{
			if (UIManager.m_instance == null)
			{
				UIManager.m_instance = new UIManager();
			}
			return UIManager.m_instance;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0002CD50 File Offset: 0x0002AF50
		[DoNotToLua]
		public bool Initlize()
		{
			global::Debug.Log("UIManager.Initlize start");
			return true;
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0002CD60 File Offset: 0x0002AF60
		[DoNotToLua]
		public void Uninitlize()
		{
			List<string> list = new List<string>();
			list.AddRange(this.m_uiTaskDict.Keys);
			foreach (string taskName in list)
			{
				this.StopUITask(taskName);
			}
			global::Debug.Log("UIManager.Uninitlize");
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		public UITaskBase StartUITask(UIIntent intent, bool pushIntentToStack = false, bool clearIntentStack = false, Action redirectPipLineOnLoadAllResCompleted = null)
		{
			global::Debug.Log(string.Format("StartUITask task={0}", intent.TargetTaskName));
			if (!this.m_uiTaskRegDict.ContainsKey(intent.TargetTaskName))
			{
				global::Debug.LogError(string.Format("StartUITask fail for Unregisted TargetTaskName={0}", intent.TargetTaskName));
				return null;
			}
			UITaskBase orCreateUITask = this.GetOrCreateUITask(intent.TargetTaskName);
			if (orCreateUITask == null)
			{
				global::Debug.LogError(string.Format("StartUITask fail for GetOrCreateUITask null TargetTaskName={0}", intent.TargetTaskName));
				return null;
			}
			if (clearIntentStack)
			{
				this.m_uiIntentStack.Clear();
			}
			if (redirectPipLineOnLoadAllResCompleted != null)
			{
				orCreateUITask.RedirectPipLineOnAllResReady(redirectPipLineOnLoadAllResCompleted);
			}
			if (!this.StartUITaskInternal<UITaskBase>(orCreateUITask, intent, pushIntentToStack))
			{
				global::Debug.LogError(string.Format("StartUITask fail for StartUITaskInternal fail TargetTaskName={0}", intent.TargetTaskName));
				return null;
			}
			return orCreateUITask;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0002CE98 File Offset: 0x0002B098
		public void StartUITaskWithPrepare(UIIntent intent, Action<bool> onPrepareEnd, bool pushIntentToStack = false)
		{
			global::Debug.Log(string.Format("StartUITaskWithPrepare task={0}", intent.TargetTaskName));
			if (!this.m_uiTaskRegDict.ContainsKey(intent.TargetTaskName))
			{
				global::Debug.LogError(string.Format("StartUITask fail for Unregisted TargetTaskName={0}", intent.TargetTaskName));
				onPrepareEnd(false);
				return;
			}
			UITaskBase targetTask = this.GetOrCreateUITask(intent.TargetTaskName);
			targetTask.PrepareForStartOrResume(intent, delegate(bool lret)
			{
				if (!lret)
				{
					if (onPrepareEnd != null)
					{
						onPrepareEnd(false);
					}
					if (targetTask.State == Task.TaskState.Init || targetTask.State == Task.TaskState.Stopped)
					{
						this.m_uiTaskDict.Remove(targetTask.Name);
					}
				}
				else
				{
					if (onPrepareEnd != null)
					{
						onPrepareEnd(true);
					}
					this.StartUITaskInternal<UITaskBase>(targetTask, intent, pushIntentToStack);
				}
			});
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0002CF58 File Offset: 0x0002B158
		public UITaskBase ReturnUITask(UIIntent intent)
		{
			global::Debug.Log(string.Format("ReturnUITask task={0}", intent.TargetTaskName));
			UITaskBase uitaskBase = this.GetOrCreateUITask(intent.TargetTaskName);
			if (!this.PopIntentUntilReturnTarget(intent))
			{
				global::Debug.LogError(string.Format("ReturnUITask fail intent not in stack task={0}", intent.TargetTaskName));
				return null;
			}
			if (!this.StartUITaskInternal<UITaskBase>(uitaskBase, intent, false))
			{
				uitaskBase = null;
			}
			return uitaskBase;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0002CFBC File Offset: 0x0002B1BC
		public UITaskBase ReturnUITaskWithTaskName(string taskName)
		{
			global::Debug.Log(string.Format("ReturnToUITaskWithName task={0}", taskName));
			UIIntent uiintent = null;
			for (int i = this.m_uiIntentStack.Count - 1; i >= 0; i--)
			{
				if (this.m_uiIntentStack[i].TargetTaskName == taskName)
				{
					uiintent = this.m_uiIntentStack[i];
					break;
				}
			}
			if (uiintent == null)
			{
				global::Debug.LogError(string.Format("ReturnUITaskWithTaskName fail intent not in stack task={0}", taskName));
				return null;
			}
			return this.ReturnUITask(uiintent);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0002D048 File Offset: 0x0002B248
		public UITaskBase ReturnUITaskToLast()
		{
			return this.ReturnUITaskByStackIndex(-1);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0002D054 File Offset: 0x0002B254
		public UITaskBase ReturnUITaskByStackIndex(int index)
		{
			global::Debug.Log(string.Format("ReturnUITaskByStackIndex index={0}", index));
			if (this.m_uiIntentStack.Count <= 0)
			{
				global::Debug.LogError("ReturnUITaskByStackIndex IntentStack is empty");
				return null;
			}
			if (this.m_uiIntentStack.Count - 1 + index < 0)
			{
				return null;
			}
			UIIntent uiintent = this.m_uiIntentStack[this.m_uiIntentStack.Count - 1 + index];
			if (uiintent == null)
			{
				global::Debug.LogError(string.Format("ReturnUITaskByStackIndex fail intent not in stack index={0}", index));
				return null;
			}
			return this.ReturnUITask(uiintent);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0002D0EC File Offset: 0x0002B2EC
		public void ReturnUITaskWithPrepare(UIIntent intent, Action<bool> onPrepareEnd)
		{
			global::Debug.Log(string.Format("ReturnUITaskWithPrepare task={0}", intent.TargetTaskName));
			UITaskBase targetTask = this.GetOrCreateUITask(intent.TargetTaskName);
			targetTask.PrepareForStartOrResume(intent, delegate(bool lret)
			{
				if (!lret)
				{
					onPrepareEnd(false);
				}
				else
				{
					onPrepareEnd(true);
					if (!this.PopIntentUntilReturnTarget(intent))
					{
						global::Debug.LogError(string.Format("ReturnUITask fail intent not in stack task={0}", intent.TargetTaskName));
						onPrepareEnd(false);
						return;
					}
					this.StartUITaskInternal<UITaskBase>(targetTask, intent, false);
				}
			});
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0002D164 File Offset: 0x0002B364
		public void PauseUITask(string taskName)
		{
			UITaskBase uitaskBase = this.FindUITaskWithName(taskName);
			if (uitaskBase != null)
			{
				global::Debug.Log(string.Format("PauseUITask task={0}", taskName));
				uitaskBase.Pause();
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0002D198 File Offset: 0x0002B398
		public void StopUITask(string taskName)
		{
			UITaskBase uitaskBase = this.FindUITaskWithName(taskName);
			if (uitaskBase != null)
			{
				global::Debug.Log(string.Format("StopUITask task={0}", taskName));
				uitaskBase.Stop();
			}
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0002D1CC File Offset: 0x0002B3CC
		private UITaskBase GetOrCreateUITask(string taskName)
		{
			UITaskBase uitaskBase;
			if (this.m_uiTaskDict.TryGetValue(taskName, out uitaskBase))
			{
				return uitaskBase;
			}
			UIManager.UITaskRegItem uitaskRegItem;
			if (!this.m_uiTaskRegDict.TryGetValue(taskName, out uitaskRegItem))
			{
				global::Debug.LogError(string.Format("GetOrCreateUITask fail taskName={0} not registed", taskName));
				return null;
			}
			uitaskBase = (ClassLoader.Instance.CreateInstance(uitaskRegItem.m_taskTypeDnName, new object[]
			{
				taskName
			}) as UITaskBase);
			if (uitaskBase == null)
			{
				global::Debug.LogError(string.Format("GetOrCreateUITask CreateInstance fail taskName={0}", taskName));
				return null;
			}
			if (!string.IsNullOrEmpty(uitaskRegItem.m_luaModuleName) && !LuaManager.TryInitHotfixForObj(uitaskBase, uitaskRegItem.m_luaModuleName, null))
			{
				global::Debug.LogError(string.Format("GetOrCreateUITask fail LuaManager.TryInitHotfixForObj for taskName={0} luaModuleName={1}", taskName, uitaskRegItem.m_luaModuleName));
				return null;
			}
			uitaskBase.InitlizeBeforeManagerStartIt();
			this.m_uiTaskDict[taskName] = uitaskBase;
			return uitaskBase;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0002D29C File Offset: 0x0002B49C
		public UITaskBase FindUITaskWithName(string taskName)
		{
			UITaskBase result;
			if (!this.m_uiTaskDict.TryGetValue(taskName, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0002D2C0 File Offset: 0x0002B4C0
		[DoNotToLua]
		private bool StartUITaskInternal<TTaskType>(TTaskType targetTask, UIIntent intent, bool pushIntentToStack) where TTaskType : UITaskBase
		{
			this.CloseAllConflictUITask(intent.TargetTaskName);
			if (pushIntentToStack)
			{
				this.m_uiIntentStack.Add(intent);
			}
			if (!this.StartOrResumeTask(targetTask, intent))
			{
				global::Debug.LogError(string.Format("UIManager.StartUITaskInternal fail task={0}", targetTask.Name));
				return false;
			}
			return true;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0002D320 File Offset: 0x0002B520
		private bool StartOrResumeTask(UITaskBase targetTask, UIIntent intent)
		{
			switch (targetTask.State)
			{
			case Task.TaskState.Init:
				targetTask.EventOnStop += this.OnUITaskStop;
				targetTask.EventOnPostUpdateView += this.OnUITaskPostUpdateView;
				return targetTask.Start(intent);
			case Task.TaskState.Running:
				targetTask.EventOnPostUpdateView += this.OnUITaskPostUpdateView;
				return targetTask.OnNewIntent(intent);
			case Task.TaskState.Paused:
				targetTask.EventOnPostUpdateView += this.OnUITaskPostUpdateView;
				return targetTask.Resume(intent);
			case Task.TaskState.Stopped:
				global::Debug.LogError(string.Format("UIManager.StartOrResumeTask fail in TaskState.Stopped task={0}", targetTask.Name));
				return false;
			default:
				return false;
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0002D3C8 File Offset: 0x0002B5C8
		private bool PopIntentUntilReturnTarget(UIIntent intent)
		{
			if (!this.m_uiIntentStack.Contains(intent))
			{
				return false;
			}
			for (int i = this.m_uiIntentStack.Count - 1; i >= 0; i--)
			{
				UIIntent uiintent = this.m_uiIntentStack[i];
				if (uiintent == intent)
				{
					break;
				}
				this.m_uiIntentStack.Remove(uiintent);
			}
			return true;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0002D434 File Offset: 0x0002B634
		public void RemoveIntentFromStack(UIIntent intent)
		{
			foreach (UIIntent uiintent in this.m_uiIntentStack)
			{
				if (uiintent == intent)
				{
					this.m_uiIntentStack.Remove(uiintent);
					break;
				}
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0002D4A4 File Offset: 0x0002B6A4
		private void OnUITaskStop(Task task)
		{
			global::Debug.Log("UIManager::OnUITaskStop " + task.Name);
			if (this.m_uiTaskDict.ContainsKey(task.Name))
			{
				this.m_uiTaskDict.Remove(task.Name);
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002D4E4 File Offset: 0x0002B6E4
		private void OnUITaskPostUpdateView(UITaskBase task)
		{
			task.EventOnPostUpdateView -= this.OnUITaskPostUpdateView;
			if (this.EventOnUITaskShow != null)
			{
				this.EventOnUITaskShow(task.Name);
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0002D514 File Offset: 0x0002B714
		private void CloseAllConflictUITask(string taskName)
		{
			UIManager.UITaskRegItem uitaskRegItem;
			if (!this.m_uiTaskRegDict.TryGetValue(taskName, out uitaskRegItem))
			{
				return;
			}
			int taskGroup = uitaskRegItem.m_taskGroup;
			List<int> list = null;
			if (this.m_uiTaskGroupConflictList.Count > taskGroup)
			{
				list = this.m_uiTaskGroupConflictList[taskGroup];
			}
			if (list == null || list.Count == 0)
			{
				return;
			}
			foreach (KeyValuePair<string, UITaskBase> keyValuePair in this.m_uiTaskDict)
			{
				UIManager.UITaskRegItem uitaskRegItem2;
				if (this.m_uiTaskRegDict.TryGetValue(keyValuePair.Value.Name, out uitaskRegItem2))
				{
					int taskGroup2 = uitaskRegItem2.m_taskGroup;
					if (list.Contains(taskGroup2))
					{
						this.m_taskList4Stop.Add(keyValuePair.Value);
					}
				}
			}
			if (this.m_taskList4Stop.Count != 0)
			{
				foreach (UITaskBase uitaskBase in this.m_taskList4Stop)
				{
					uitaskBase.Stop();
				}
				this.m_taskList4Stop.Clear();
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0002D66C File Offset: 0x0002B86C
		public void StopUITaskByGroup(int group)
		{
			foreach (KeyValuePair<string, UITaskBase> keyValuePair in this.m_uiTaskDict)
			{
				UIManager.UITaskRegItem uitaskRegItem;
				if (this.m_uiTaskRegDict.TryGetValue(keyValuePair.Value.Name, out uitaskRegItem))
				{
					if (uitaskRegItem.m_taskGroup == group)
					{
						this.m_taskList4Stop.Add(keyValuePair.Value);
					}
				}
			}
			if (this.m_taskList4Stop.Count != 0)
			{
				foreach (UITaskBase uitaskBase in this.m_taskList4Stop)
				{
					uitaskBase.Stop();
				}
				this.m_taskList4Stop.Clear();
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0002D768 File Offset: 0x0002B968
		public void PauseUITaskByGroup(int group)
		{
			foreach (KeyValuePair<string, UITaskBase> keyValuePair in this.m_uiTaskDict)
			{
				UIManager.UITaskRegItem uitaskRegItem;
				if (this.m_uiTaskRegDict.TryGetValue(keyValuePair.Value.Name, out uitaskRegItem))
				{
					if (uitaskRegItem.m_taskGroup == group)
					{
						this.m_taskList4Stop.Add(keyValuePair.Value);
					}
				}
			}
			if (this.m_taskList4Stop.Count != 0)
			{
				foreach (UITaskBase uitaskBase in this.m_taskList4Stop)
				{
					uitaskBase.Pause();
				}
				this.m_taskList4Stop.Clear();
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0002D864 File Offset: 0x0002BA64
		public void PauseUITaskByTag(string tag, bool isExcept = false)
		{
			foreach (KeyValuePair<string, UITaskBase> keyValuePair in this.m_uiTaskDict)
			{
				if (!isExcept)
				{
					if (keyValuePair.Value.HasTag(tag))
					{
						this.m_taskList4Stop.Add(keyValuePair.Value);
					}
				}
				else if (!keyValuePair.Value.HasTag(tag))
				{
					this.m_taskList4Stop.Add(keyValuePair.Value);
				}
			}
			if (this.m_taskList4Stop.Count != 0)
			{
				foreach (UITaskBase uitaskBase in this.m_taskList4Stop)
				{
					uitaskBase.Pause();
				}
				this.m_taskList4Stop.Clear();
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0002D974 File Offset: 0x0002BB74
		public void StopUITaskByTag(string tag, bool isExcept)
		{
			foreach (KeyValuePair<string, UITaskBase> keyValuePair in this.m_uiTaskDict)
			{
				if (!isExcept)
				{
					if (keyValuePair.Value.HasTag(tag))
					{
						this.m_taskList4Stop.Add(keyValuePair.Value);
					}
				}
				else if (!keyValuePair.Value.HasTag(tag))
				{
					this.m_taskList4Stop.Add(keyValuePair.Value);
				}
			}
			if (this.m_taskList4Stop.Count != 0)
			{
				foreach (UITaskBase uitaskBase in this.m_taskList4Stop)
				{
					uitaskBase.Stop();
				}
				this.m_taskList4Stop.Clear();
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0002DA84 File Offset: 0x0002BC84
		public void RegisterUITaskWithGroup(string taskName, TypeDNName taskTypeDNName, int group, string luaModuleName = null)
		{
			UIManager.UITaskRegItem uitaskRegItem;
			if (!this.m_uiTaskRegDict.TryGetValue(taskName, out uitaskRegItem))
			{
				uitaskRegItem = new UIManager.UITaskRegItem();
				this.m_uiTaskRegDict.Add(taskName, uitaskRegItem);
			}
			uitaskRegItem.m_taskName = taskName;
			uitaskRegItem.m_taskTypeDnName = taskTypeDNName;
			uitaskRegItem.m_taskGroup = group;
			uitaskRegItem.m_luaModuleName = luaModuleName;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0002DAD4 File Offset: 0x0002BCD4
		public void SetUITaskGroupConflict(uint group1, uint group2)
		{
			if (group1 == group2)
			{
				return;
			}
			while ((long)this.m_uiTaskGroupConflictList.Count < (long)((ulong)(group1 + 1u)))
			{
				this.m_uiTaskGroupConflictList.Add(new List<int>());
			}
			while ((long)this.m_uiTaskGroupConflictList.Count < (long)((ulong)(group2 + 1u)))
			{
				this.m_uiTaskGroupConflictList.Add(new List<int>());
			}
			this.m_uiTaskGroupConflictList[(int)group1].Add((int)group2);
			this.m_uiTaskGroupConflictList[(int)group2].Add((int)group1);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0002DB64 File Offset: 0x0002BD64
		public void ReturnToLoginUI()
		{
			if (this.EventReturnToLoginUI != null)
			{
				this.EventReturnToLoginUI(false);
			}
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0002DB80 File Offset: 0x0002BD80
		public bool IsGlobalUIInputEnable()
		{
			return this.m_globalUIInputBlockDict.Count == 0;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0002DB90 File Offset: 0x0002BD90
		public void GlobalUIInputEnable(string srcName, bool enable)
		{
			int num2;
			if (enable)
			{
				int num;
				if (this.m_globalUIInputBlockDict.TryGetValue(srcName, out num))
				{
					if (num == 1)
					{
						this.m_globalUIInputBlockDict.Remove(srcName);
					}
					else
					{
						this.m_globalUIInputBlockDict[srcName] = num - 1;
					}
				}
			}
			else if (this.m_globalUIInputBlockDict.TryGetValue(srcName, out num2))
			{
				this.m_globalUIInputBlockDict[srcName] = num2 + 1;
			}
			else
			{
				this.m_globalUIInputBlockDict[srcName] = 1;
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0002DC18 File Offset: 0x0002BE18
		public void GlobalUIInputBlockClear(string srcName)
		{
			this.m_globalUIInputBlockDict.Remove(srcName);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0002DC28 File Offset: 0x0002BE28
		public void GlobalUIInputBlockForTicks(int ticks)
		{
			this.GlobalUIInputEnable(base.GetType().Name, false);
			this.m_delayExecHelper.DelayExec(delegate()
			{
				this.GlobalUIInputEnable(base.GetType().Name, true);
			}, ticks, (uint)Timer.m_currTick);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0002DC5C File Offset: 0x0002BE5C
		public void Tick()
		{
			this.m_delayExecHelper.Tick((uint)Timer.m_currTick);
			this.TickPauseTimeOut();
			this.TickUIProcessQueue();
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0002DC7C File Offset: 0x0002BE7C
		protected void TickPauseTimeOut()
		{
			if ((Timer.m_currTime - this.m_lastTickPauseTimeOutTime).TotalSeconds < 5.0)
			{
				return;
			}
			this.m_lastTickPauseTimeOutTime = Timer.m_currTime;
			DateTime t = Timer.m_currTime.AddSeconds(-120.0);
			foreach (KeyValuePair<string, UITaskBase> keyValuePair in this.m_uiTaskDict)
			{
				UITaskBase task = keyValuePair.Value;
				if (task.IsNeedPauseTimeOut && task.State == Task.TaskState.Paused && task.PauseStartTime <= t && this.m_uiIntentStack.Find((UIIntent intent) => intent.TargetTaskName == task.Name) == null)
				{
					this.m_taskList4Stop.Add(keyValuePair.Value);
				}
			}
			if (this.m_taskList4Stop.Count != 0)
			{
				foreach (UITaskBase uitaskBase in this.m_taskList4Stop)
				{
					uitaskBase.Stop();
				}
				this.m_taskList4Stop.Clear();
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000AB0 RID: 2736 RVA: 0x0002DE00 File Offset: 0x0002C000
		// (remove) Token: 0x06000AB1 RID: 2737 RVA: 0x0002DE38 File Offset: 0x0002C038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<string> EventOnUITaskShow;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000AB2 RID: 2738 RVA: 0x0002DE70 File Offset: 0x0002C070
		// (remove) Token: 0x06000AB3 RID: 2739 RVA: 0x0002DEA8 File Offset: 0x0002C0A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<bool> EventReturnToLoginUI;

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0002DEE0 File Offset: 0x0002C0E0
		public static UIManager Instance
		{
			get
			{
				return UIManager.m_instance;
			}
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
		public void RegisterUIProcess(UIManager.UIProcessQueueItem item)
		{
			this.m_uiProcessQueue.Add(item);
			if (item.m_waitTimeOut != 0)
			{
				item.m_waitTimeOutTime = new DateTime?(Timer.m_currTime.AddMilliseconds((double)item.m_waitTimeOut));
			}
			List<UIManager.UIProcessQueueItem> uiProcessQueue = this.m_uiProcessQueue;
			if (UIManager.<>f__mg$cache0 == null)
			{
				UIManager.<>f__mg$cache0 = new Comparison<UIManager.UIProcessQueueItem>(UIManager.UIProcessQueueComparsion);
			}
			uiProcessQueue.Sort(UIManager.<>f__mg$cache0);
			this.UpdateBlockGlobalUIInputForProcessQueue();
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0002DF58 File Offset: 0x0002C158
		public void UnregisterUIProcess(UIManager.UIProcessQueueItem item)
		{
			if (!this.m_uiProcessQueue.Remove(item))
			{
				return;
			}
			this.UpdateBlockGlobalUIInputForProcessQueue();
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0002DF74 File Offset: 0x0002C174
		public void RegisterUIProcessQueueBlocker(Func<UIManager.UIProcessQueueItem, bool> blocker)
		{
			this.m_uiProcessQueueBlockerList.Add(blocker);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002DF84 File Offset: 0x0002C184
		public void UnregisterUIProcessQueueBlocker(Func<UIManager.UIProcessQueueItem, bool> blocker)
		{
			this.m_uiProcessQueueBlockerList.Remove(blocker);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0002DF94 File Offset: 0x0002C194
		protected void TickUIProcessQueue()
		{
			bool flag = false;
			DateTime currTime = Timer.m_currTime;
			if (this.m_currRuningUIProcess != null)
			{
				DateTime? currRuningUIProcessTimeOut = this.m_currRuningUIProcessTimeOut;
				if (currRuningUIProcessTimeOut != null && this.m_currRuningUIProcessTimeOut.Value < currTime)
				{
					this.m_currRuningUIProcess.OnEnd();
				}
				return;
			}
			if (this.m_uiProcessQueue.Count == 0)
			{
				return;
			}
			for (int i = this.m_uiProcessQueue.Count - 1; i >= 0; i--)
			{
				this.m_currRuningUIProcess = this.m_uiProcessQueue[i];
				bool onlyTryOnce = this.m_currRuningUIProcess.m_onlyTryOnce;
				DateTime? waitTimeOutTime = this.m_currRuningUIProcess.m_waitTimeOutTime;
				if (waitTimeOutTime != null && this.m_currRuningUIProcess.m_waitTimeOutTime < currTime)
				{
					this.m_currRuningUIProcess = null;
					this.m_uiProcessQueue.RemoveAt(i);
					flag = true;
				}
				else
				{
					foreach (Func<UIManager.UIProcessQueueItem, bool> func in this.m_uiProcessQueueBlockerList)
					{
						if (func(this.m_currRuningUIProcess))
						{
							this.m_currRuningUIProcess = null;
							break;
						}
					}
					if (this.m_currRuningUIProcess != null && this.m_currRuningUIProcess.m_cbCanStart != null && !this.m_currRuningUIProcess.m_cbCanStart())
					{
						this.m_currRuningUIProcess = null;
						if (onlyTryOnce)
						{
							this.m_uiProcessQueue.RemoveAt(i);
							flag = true;
						}
					}
					else
					{
						this.m_uiProcessQueue.RemoveAt(i);
						flag = true;
					}
					if (this.m_currRuningUIProcess != null)
					{
						if (this.m_currRuningUIProcess.m_processTimeOut != 0)
						{
							this.m_currRuningUIProcessTimeOut = new DateTime?(Timer.m_currTime.AddMilliseconds((double)this.m_currRuningUIProcess.m_processTimeOut));
						}
						this.m_currRuningUIProcess.m_cbOnStart();
						if (this.m_currRuningUIProcess != null && this.m_currRuningUIProcess.m_blockGlobalUIInputForProcessing)
						{
							this.GlobalUIInputEnable(this.m_currRuningUIProcess.ToString(), false);
						}
						break;
					}
				}
			}
			if (flag)
			{
				this.UpdateBlockGlobalUIInputForProcessQueue();
			}
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0002E1F0 File Offset: 0x0002C3F0
		protected void OnUIProcessEnd(UIManager.UIProcessQueueItem item)
		{
			if (this.m_currRuningUIProcess == item)
			{
				this.m_currRuningUIProcess = null;
				this.m_currRuningUIProcessTimeOut = null;
			}
			if (item.m_blockGlobalUIInputForProcessing)
			{
				this.GlobalUIInputEnable(item.ToString(), true);
			}
			this.UpdateBlockGlobalUIInputForProcessQueue();
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0002E240 File Offset: 0x0002C440
		private void UpdateBlockGlobalUIInputForProcessQueue()
		{
			bool flag = false;
			foreach (UIManager.UIProcessQueueItem uiprocessQueueItem in this.m_uiProcessQueue)
			{
				if (uiprocessQueueItem.m_blockGlobalUIInputForWaiting)
				{
					flag = true;
					break;
				}
			}
			if (flag && !this.m_blockGlobalUIInputForWaitingItem)
			{
				this.m_blockGlobalUIInputForWaitingItem = true;
				this.GlobalUIInputEnable("UpdateBlockGlobalUIInputForProcessQueue", false);
			}
			else if (!flag && this.m_blockGlobalUIInputForWaitingItem)
			{
				this.m_blockGlobalUIInputForWaitingItem = false;
				this.GlobalUIInputEnable("UpdateBlockGlobalUIInputForProcessQueue", true);
			}
			bool flag2 = this.m_currRuningUIProcess != null && this.m_currRuningUIProcess.m_ignoreBlockGlobalUIInputForWaitingInProcessing;
			if (this.m_blockGlobalUIInputForWaitingItem && flag2)
			{
				this.m_blockGlobalUIInputForWaitingItem = false;
				this.GlobalUIInputEnable("UpdateBlockGlobalUIInputForProcessQueue", true);
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0002E338 File Offset: 0x0002C538
		public bool IsUIProcessQueueItemExist(string name)
		{
			if (this.m_currRuningUIProcess != null && this.m_currRuningUIProcess.m_name == name)
			{
				return true;
			}
			foreach (UIManager.UIProcessQueueItem uiprocessQueueItem in this.m_uiProcessQueue)
			{
				if (uiprocessQueueItem.m_name == name)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0002E3CC File Offset: 0x0002C5CC
		private static int UIProcessQueueComparsion(UIManager.UIProcessQueueItem x, UIManager.UIProcessQueueItem y)
		{
			if (x.m_priority < y.m_priority)
			{
				return -1;
			}
			if (x.m_priority == y.m_priority)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0002E3F8 File Offset: 0x0002C5F8
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0002E418 File Offset: 0x0002C618
		[DoNotToLua]
		public UIManager.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UIManager.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0002E424 File Offset: 0x0002C624
		private void __callDele_EventOnUITaskShow(string obj)
		{
			Action<string> eventOnUITaskShow = this.EventOnUITaskShow;
			if (eventOnUITaskShow != null)
			{
				eventOnUITaskShow(obj);
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0002E448 File Offset: 0x0002C648
		private void __clearDele_EventOnUITaskShow(string obj)
		{
			this.EventOnUITaskShow = null;
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0002E454 File Offset: 0x0002C654
		private void __callDele_EventReturnToLoginUI(bool obj)
		{
			Action<bool> eventReturnToLoginUI = this.EventReturnToLoginUI;
			if (eventReturnToLoginUI != null)
			{
				eventReturnToLoginUI(obj);
			}
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0002E478 File Offset: 0x0002C678
		private void __clearDele_EventReturnToLoginUI(bool obj)
		{
			this.EventReturnToLoginUI = null;
		}

		// Token: 0x04000649 RID: 1609
		private static UIManager m_instance;

		// Token: 0x0400064A RID: 1610
		protected Dictionary<string, int> m_globalUIInputBlockDict = new Dictionary<string, int>();

		// Token: 0x0400064B RID: 1611
		private List<UIIntent> m_uiIntentStack = new List<UIIntent>();

		// Token: 0x0400064C RID: 1612
		private Dictionary<string, UITaskBase> m_uiTaskDict = new Dictionary<string, UITaskBase>();

		// Token: 0x0400064D RID: 1613
		private Dictionary<string, UIManager.UITaskRegItem> m_uiTaskRegDict = new Dictionary<string, UIManager.UITaskRegItem>();

		// Token: 0x0400064E RID: 1614
		private List<UITaskBase> m_taskList4Stop = new List<UITaskBase>();

		// Token: 0x0400064F RID: 1615
		private List<List<int>> m_uiTaskGroupConflictList = new List<List<int>>();

		// Token: 0x04000650 RID: 1616
		protected DateTime m_lastTickPauseTimeOutTime = DateTime.MinValue;

		// Token: 0x04000651 RID: 1617
		protected DelayExecHelper m_delayExecHelper = new DelayExecHelper();

		// Token: 0x04000652 RID: 1618
		public const double UITaskPauseTimeOut = 120.0;

		// Token: 0x04000653 RID: 1619
		protected List<UIManager.UIProcessQueueItem> m_uiProcessQueue = new List<UIManager.UIProcessQueueItem>();

		// Token: 0x04000654 RID: 1620
		protected UIManager.UIProcessQueueItem m_currRuningUIProcess;

		// Token: 0x04000655 RID: 1621
		protected DateTime? m_currRuningUIProcessTimeOut;

		// Token: 0x04000656 RID: 1622
		private List<Func<UIManager.UIProcessQueueItem, bool>> m_uiProcessQueueBlockerList = new List<Func<UIManager.UIProcessQueueItem, bool>>();

		// Token: 0x04000657 RID: 1623
		private bool m_blockGlobalUIInputForWaitingItem;

		// Token: 0x04000658 RID: 1624
		[DoNotToLua]
		private UIManager.LuaExportHelper luaExportHelper;

		// Token: 0x04000659 RID: 1625
		[CompilerGenerated]
		private static Comparison<UIManager.UIProcessQueueItem> <>f__mg$cache0;

		// Token: 0x0200010B RID: 267
		public class UITaskRegItem
		{
			// Token: 0x0400065A RID: 1626
			public int m_taskGroup;

			// Token: 0x0400065B RID: 1627
			public string m_taskName;

			// Token: 0x0400065C RID: 1628
			public TypeDNName m_taskTypeDnName;

			// Token: 0x0400065D RID: 1629
			public string m_luaModuleName;
		}

		// Token: 0x0200010C RID: 268
		public class UIProcessQueueItem
		{
			// Token: 0x06000AC7 RID: 2759 RVA: 0x0002E4B0 File Offset: 0x0002C6B0
			public void OnEnd()
			{
				UIManager.Instance.OnUIProcessEnd(this);
				if (this.m_cbOnEnd != null)
				{
					this.m_cbOnEnd();
				}
			}

			// Token: 0x0400065E RID: 1630
			public int m_priority;

			// Token: 0x0400065F RID: 1631
			public int m_typeId;

			// Token: 0x04000660 RID: 1632
			public string m_name;

			// Token: 0x04000661 RID: 1633
			public object m_ctx;

			// Token: 0x04000662 RID: 1634
			public Func<bool> m_cbCanStart;

			// Token: 0x04000663 RID: 1635
			public Action m_cbOnStart;

			// Token: 0x04000664 RID: 1636
			public Action m_cbOnEnd;

			// Token: 0x04000665 RID: 1637
			public int m_waitTimeOut;

			// Token: 0x04000666 RID: 1638
			public DateTime? m_waitTimeOutTime;

			// Token: 0x04000667 RID: 1639
			public int m_processTimeOut;

			// Token: 0x04000668 RID: 1640
			public bool m_onlyTryOnce = true;

			// Token: 0x04000669 RID: 1641
			public bool m_blockGlobalUIInputForWaiting;

			// Token: 0x0400066A RID: 1642
			public bool m_blockGlobalUIInputForProcessing;

			// Token: 0x0400066B RID: 1643
			public bool m_ignoreBlockGlobalUIInputForWaitingInProcessing;
		}

		// Token: 0x0200010D RID: 269
		public class LuaExportHelper
		{
			// Token: 0x06000AC8 RID: 2760 RVA: 0x0002E4D4 File Offset: 0x0002C6D4
			public LuaExportHelper(UIManager owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06000AC9 RID: 2761 RVA: 0x0002E4E4 File Offset: 0x0002C6E4
			public void __callDele_EventOnUITaskShow(string obj)
			{
				this.m_owner.__callDele_EventOnUITaskShow(obj);
			}

			// Token: 0x06000ACA RID: 2762 RVA: 0x0002E4F4 File Offset: 0x0002C6F4
			public void __clearDele_EventOnUITaskShow(string obj)
			{
				this.m_owner.__clearDele_EventOnUITaskShow(obj);
			}

			// Token: 0x06000ACB RID: 2763 RVA: 0x0002E504 File Offset: 0x0002C704
			public void __callDele_EventReturnToLoginUI(bool obj)
			{
				this.m_owner.__callDele_EventReturnToLoginUI(obj);
			}

			// Token: 0x06000ACC RID: 2764 RVA: 0x0002E514 File Offset: 0x0002C714
			public void __clearDele_EventReturnToLoginUI(bool obj)
			{
				this.m_owner.__clearDele_EventReturnToLoginUI(obj);
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0002E524 File Offset: 0x0002C724
			// (set) Token: 0x06000ACE RID: 2766 RVA: 0x0002E52C File Offset: 0x0002C72C
			public static UIManager m_instance
			{
				get
				{
					return UIManager.m_instance;
				}
				set
				{
					UIManager.m_instance = value;
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0002E534 File Offset: 0x0002C734
			// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x0002E544 File Offset: 0x0002C744
			public Dictionary<string, int> m_globalUIInputBlockDict
			{
				get
				{
					return this.m_owner.m_globalUIInputBlockDict;
				}
				set
				{
					this.m_owner.m_globalUIInputBlockDict = value;
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0002E554 File Offset: 0x0002C754
			// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0002E564 File Offset: 0x0002C764
			public List<UIIntent> m_uiIntentStack
			{
				get
				{
					return this.m_owner.m_uiIntentStack;
				}
				set
				{
					this.m_owner.m_uiIntentStack = value;
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0002E574 File Offset: 0x0002C774
			// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x0002E584 File Offset: 0x0002C784
			public Dictionary<string, UITaskBase> m_uiTaskDict
			{
				get
				{
					return this.m_owner.m_uiTaskDict;
				}
				set
				{
					this.m_owner.m_uiTaskDict = value;
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0002E594 File Offset: 0x0002C794
			// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x0002E5A4 File Offset: 0x0002C7A4
			public Dictionary<string, UIManager.UITaskRegItem> m_uiTaskRegDict
			{
				get
				{
					return this.m_owner.m_uiTaskRegDict;
				}
				set
				{
					this.m_owner.m_uiTaskRegDict = value;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0002E5B4 File Offset: 0x0002C7B4
			// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x0002E5C4 File Offset: 0x0002C7C4
			public List<UITaskBase> m_taskList4Stop
			{
				get
				{
					return this.m_owner.m_taskList4Stop;
				}
				set
				{
					this.m_owner.m_taskList4Stop = value;
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0002E5D4 File Offset: 0x0002C7D4
			// (set) Token: 0x06000ADA RID: 2778 RVA: 0x0002E5E4 File Offset: 0x0002C7E4
			public List<List<int>> m_uiTaskGroupConflictList
			{
				get
				{
					return this.m_owner.m_uiTaskGroupConflictList;
				}
				set
				{
					this.m_owner.m_uiTaskGroupConflictList = value;
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0002E5F4 File Offset: 0x0002C7F4
			// (set) Token: 0x06000ADC RID: 2780 RVA: 0x0002E604 File Offset: 0x0002C804
			public DateTime m_lastTickPauseTimeOutTime
			{
				get
				{
					return this.m_owner.m_lastTickPauseTimeOutTime;
				}
				set
				{
					this.m_owner.m_lastTickPauseTimeOutTime = value;
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0002E614 File Offset: 0x0002C814
			// (set) Token: 0x06000ADE RID: 2782 RVA: 0x0002E624 File Offset: 0x0002C824
			public DelayExecHelper m_delayExecHelper
			{
				get
				{
					return this.m_owner.m_delayExecHelper;
				}
				set
				{
					this.m_owner.m_delayExecHelper = value;
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0002E634 File Offset: 0x0002C834
			// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x0002E644 File Offset: 0x0002C844
			public List<UIManager.UIProcessQueueItem> m_uiProcessQueue
			{
				get
				{
					return this.m_owner.m_uiProcessQueue;
				}
				set
				{
					this.m_owner.m_uiProcessQueue = value;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0002E654 File Offset: 0x0002C854
			// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x0002E664 File Offset: 0x0002C864
			public UIManager.UIProcessQueueItem m_currRuningUIProcess
			{
				get
				{
					return this.m_owner.m_currRuningUIProcess;
				}
				set
				{
					this.m_owner.m_currRuningUIProcess = value;
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0002E674 File Offset: 0x0002C874
			// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x0002E684 File Offset: 0x0002C884
			public DateTime? m_currRuningUIProcessTimeOut
			{
				get
				{
					return this.m_owner.m_currRuningUIProcessTimeOut;
				}
				set
				{
					this.m_owner.m_currRuningUIProcessTimeOut = value;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0002E694 File Offset: 0x0002C894
			// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0002E6A4 File Offset: 0x0002C8A4
			public List<Func<UIManager.UIProcessQueueItem, bool>> m_uiProcessQueueBlockerList
			{
				get
				{
					return this.m_owner.m_uiProcessQueueBlockerList;
				}
				set
				{
					this.m_owner.m_uiProcessQueueBlockerList = value;
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0002E6B4 File Offset: 0x0002C8B4
			// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0002E6C4 File Offset: 0x0002C8C4
			public bool m_blockGlobalUIInputForWaitingItem
			{
				get
				{
					return this.m_owner.m_blockGlobalUIInputForWaitingItem;
				}
				set
				{
					this.m_owner.m_blockGlobalUIInputForWaitingItem = value;
				}
			}

			// Token: 0x06000AE9 RID: 2793 RVA: 0x0002E6D4 File Offset: 0x0002C8D4
			public UITaskBase GetOrCreateUITask(string taskName)
			{
				return this.m_owner.GetOrCreateUITask(taskName);
			}

			// Token: 0x06000AEA RID: 2794 RVA: 0x0002E6E4 File Offset: 0x0002C8E4
			public bool StartOrResumeTask(UITaskBase targetTask, UIIntent intent)
			{
				return this.m_owner.StartOrResumeTask(targetTask, intent);
			}

			// Token: 0x06000AEB RID: 2795 RVA: 0x0002E6F4 File Offset: 0x0002C8F4
			public bool PopIntentUntilReturnTarget(UIIntent intent)
			{
				return this.m_owner.PopIntentUntilReturnTarget(intent);
			}

			// Token: 0x06000AEC RID: 2796 RVA: 0x0002E704 File Offset: 0x0002C904
			public void OnUITaskStop(Task task)
			{
				this.m_owner.OnUITaskStop(task);
			}

			// Token: 0x06000AED RID: 2797 RVA: 0x0002E714 File Offset: 0x0002C914
			public void OnUITaskPostUpdateView(UITaskBase task)
			{
				this.m_owner.OnUITaskPostUpdateView(task);
			}

			// Token: 0x06000AEE RID: 2798 RVA: 0x0002E724 File Offset: 0x0002C924
			public void CloseAllConflictUITask(string taskName)
			{
				this.m_owner.CloseAllConflictUITask(taskName);
			}

			// Token: 0x06000AEF RID: 2799 RVA: 0x0002E734 File Offset: 0x0002C934
			public void TickPauseTimeOut()
			{
				this.m_owner.TickPauseTimeOut();
			}

			// Token: 0x06000AF0 RID: 2800 RVA: 0x0002E744 File Offset: 0x0002C944
			public void TickUIProcessQueue()
			{
				this.m_owner.TickUIProcessQueue();
			}

			// Token: 0x06000AF1 RID: 2801 RVA: 0x0002E754 File Offset: 0x0002C954
			public void OnUIProcessEnd(UIManager.UIProcessQueueItem item)
			{
				this.m_owner.OnUIProcessEnd(item);
			}

			// Token: 0x06000AF2 RID: 2802 RVA: 0x0002E764 File Offset: 0x0002C964
			public void UpdateBlockGlobalUIInputForProcessQueue()
			{
				this.m_owner.UpdateBlockGlobalUIInputForProcessQueue();
			}

			// Token: 0x06000AF3 RID: 2803 RVA: 0x0002E774 File Offset: 0x0002C974
			public static int UIProcessQueueComparsion(UIManager.UIProcessQueueItem x, UIManager.UIProcessQueueItem y)
			{
				return UIManager.UIProcessQueueComparsion(x, y);
			}

			// Token: 0x0400066C RID: 1644
			private UIManager m_owner;
		}
	}
}
