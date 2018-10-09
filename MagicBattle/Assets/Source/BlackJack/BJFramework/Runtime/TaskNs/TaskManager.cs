using System;
using System.Collections.Generic;

namespace BlackJack.BJFramework.Runtime.TaskNs
{
	// Token: 0x020000D5 RID: 213
	public class TaskManager : ITickable
	{
		// Token: 0x0600083C RID: 2108 RVA: 0x000246A8 File Offset: 0x000228A8
		private TaskManager()
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000246D4 File Offset: 0x000228D4
		public static TaskManager CreateTaskManager()
		{
			if (TaskManager.m_instance == null)
			{
				TaskManager.m_instance = new TaskManager();
			}
			return TaskManager.m_instance;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000246F0 File Offset: 0x000228F0
		public bool Initlize()
		{
			return true;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000246F4 File Offset: 0x000228F4
		public void Uninitlize()
		{
			this.m_taskList4TickLoop.AddRange(this.m_taskList);
			foreach (Task task in this.m_taskList4TickLoop)
			{
				if (task.State != Task.TaskState.Stopped)
				{
					task.Stop();
				}
			}
			this.m_taskList.Clear();
			this.m_taskRegDict.Clear();
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00024784 File Offset: 0x00022984
		public bool RegisterTask(Task task)
		{
			if (!string.IsNullOrEmpty(task.Name) && this.m_taskRegDict.ContainsKey(task.Name))
			{
				if (this.m_taskRegDict[task.Name] != task)
				{
					Debug.LogError(string.Format("Task name collision. Name: {0}.", task.Name));
				}
				else
				{
					Debug.LogError(string.Format("Readding task. Name: {0}.", task.Name));
				}
				return false;
			}
			if (this.m_taskRegDict.ContainsValue(task))
			{
				Debug.LogError(string.Format("Re-adding same task with different name. Task name {0}", task.Name));
				return false;
			}
			this.m_taskList.Add(task);
			if (!string.IsNullOrEmpty(task.Name))
			{
				this.m_taskRegDict.Add(task.Name, task);
			}
			return true;
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00024858 File Offset: 0x00022A58
		public void UnregisterTask(Task task)
		{
			if (this.m_taskList.Remove(task))
			{
				if (!string.IsNullOrEmpty(task.Name))
				{
					this.m_taskRegDict.Remove(task.Name);
				}
				return;
			}
			Debug.LogWarning("Can't find task " + task.Name + " in task manager.");
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000248B4 File Offset: 0x00022AB4
		public void StopTaskWithTaskName(string taskName)
		{
			if (string.IsNullOrEmpty(taskName))
			{
				return;
			}
			Task task = null;
			if (this.m_taskRegDict.TryGetValue(taskName, out task))
			{
				task.Stop();
				this.UnregisterTask(task);
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000248F0 File Offset: 0x00022AF0
		public T FindTaskByName<T>(string taskName) where T : Task
		{
			if (string.IsNullOrEmpty(taskName))
			{
				return (T)((object)null);
			}
			Task task = null;
			if (this.m_taskRegDict.TryGetValue(taskName, out task))
			{
				return task as T;
			}
			return (T)((object)null);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00024938 File Offset: 0x00022B38
		public void Tick()
		{
			this.m_taskList4TickLoop.AddRange(this.m_taskList);
			foreach (ITickable tickable in this.m_taskList4TickLoop)
			{
				tickable.Tick();
			}
			this.m_taskList4TickLoop.Clear();
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000249B0 File Offset: 0x00022BB0
		public static TaskManager Instance
		{
			get
			{
				return TaskManager.m_instance;
			}
		}

		// Token: 0x0400052E RID: 1326
		private static TaskManager m_instance;

		// Token: 0x0400052F RID: 1327
		private List<Task> m_taskList = new List<Task>();

		// Token: 0x04000530 RID: 1328
		private List<Task> m_taskList4TickLoop = new List<Task>();

		// Token: 0x04000531 RID: 1329
		private Dictionary<string, Task> m_taskRegDict = new Dictionary<string, Task>();
	}
}
