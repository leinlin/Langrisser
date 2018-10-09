using System;
using System.Collections.Generic;
using System.Diagnostics;
using SLua;

namespace BlackJack.BJFramework.Runtime.TaskNs
{
	// Token: 0x020000D1 RID: 209
	[CustomLuaClassWithProtected]
	public class Task : ITickable
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x00023EC0 File Offset: 0x000220C0
		public Task(string name)
		{
			this.Name = name;
			this.State = Task.TaskState.Init;
			this.m_taskManager = TaskManager.Instance;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00023EE4 File Offset: 0x000220E4
		public bool Start(object param = null)
		{
			if (this.State != Task.TaskState.Init)
			{
				global::Debug.LogError(string.Format("Task.Start {0} State != TaskState.Init", this.Name));
				return false;
			}
			if (!this.m_taskManager.RegisterTask(this))
			{
				global::Debug.LogError(string.Format("Task.Start {0} RegisterTask fail", this.Name));
				return false;
			}
			this.State = Task.TaskState.Running;
			if (!this.OnStart(param))
			{
				global::Debug.LogError(string.Format("Task.Start {0} OnStart fail", this.Name));
				this.Stop();
				return false;
			}
			if (this.EventOnStart != null)
			{
				this.EventOnStart(this);
			}
			return true;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00023F84 File Offset: 0x00022184
		public void Stop()
		{
			if (this.State == Task.TaskState.Stopped)
			{
				return;
			}
			this.State = Task.TaskState.Stopped;
			this.OnStop();
			if (this.EventOnStop != null)
			{
				this.EventOnStop(this);
			}
			this.m_taskManager.UnregisterTask(this);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00023FC4 File Offset: 0x000221C4
		public void Pause()
		{
			if (this.State != Task.TaskState.Running)
			{
				return;
			}
			this.PauseStartTime = Timer.m_currTime;
			this.OnPause();
			if (this.EventOnPause != null)
			{
				this.EventOnPause(this);
			}
			this.State = Task.TaskState.Paused;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00024004 File Offset: 0x00022204
		public bool Resume(object param = null)
		{
			if (this.State != Task.TaskState.Paused)
			{
				return false;
			}
			this.State = Task.TaskState.Running;
			if (!this.OnResume(param))
			{
				this.State = Task.TaskState.Paused;
				return false;
			}
			if (this.EventOnResume != null)
			{
				this.EventOnResume(this);
			}
			return true;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00024054 File Offset: 0x00022254
		protected void ClearOnStopEvent()
		{
			this.EventOnStop = null;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00024060 File Offset: 0x00022260
		void ITickable.Tick()
		{
			this.m_currTickCount += 1UL;
			if (this.State == Task.TaskState.Stopped)
			{
				if (this.m_currTickCount % 200UL == 0UL)
				{
					global::Debug.LogError("Still ticking an stopped task: " + this);
				}
				return;
			}
			if (this.State != Task.TaskState.Running)
			{
				return;
			}
			if (this.m_delayExecList != null)
			{
				while (this.m_delayExecList.First != null)
				{
					Task.DelayExecItem value = this.m_delayExecList.First.Value;
					if (value.m_execTargetTick > this.m_currTickCount)
					{
						break;
					}
					value.m_action();
					this.m_delayExecList.RemoveFirst();
				}
			}
			this.OnTick();
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00024124 File Offset: 0x00022324
		protected void ExecAfterTicks(Action action, ulong delayTickCount = 1UL)
		{
			if (this.m_delayExecList == null)
			{
				this.m_delayExecList = new LinkedList<Task.DelayExecItem>();
			}
			Task.DelayExecItem delayExecItem = new Task.DelayExecItem
			{
				m_execTargetTick = this.m_currTickCount + delayTickCount,
				m_action = action
			};
			if (this.m_delayExecList.Count == 0 || this.m_delayExecList.Last.Value.m_execTargetTick <= delayExecItem.m_execTargetTick)
			{
				this.m_delayExecList.AddLast(delayExecItem);
			}
			else
			{
				LinkedListNode<Task.DelayExecItem> linkedListNode = this.m_delayExecList.First;
				while (linkedListNode != null && linkedListNode.Value.m_execTargetTick <= delayExecItem.m_execTargetTick)
				{
					linkedListNode = linkedListNode.Next;
				}
				if (linkedListNode != null)
				{
					this.m_delayExecList.AddBefore(linkedListNode, delayExecItem);
				}
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000241F0 File Offset: 0x000223F0
		protected virtual bool OnStart(object param)
		{
			return true;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000241F4 File Offset: 0x000223F4
		protected virtual void OnPause()
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000241F8 File Offset: 0x000223F8
		protected virtual bool OnResume(object param = null)
		{
			return true;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000241FC File Offset: 0x000223FC
		protected virtual void OnStop()
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00024200 File Offset: 0x00022400
		protected virtual void OnTick()
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00024204 File Offset: 0x00022404
		public override string ToString()
		{
			return string.Format("[Task: name={0}, state={1}]", base.GetType().Name, this.State);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00024228 File Offset: 0x00022428
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00024230 File Offset: 0x00022430
		public string Name { get; private set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0002423C File Offset: 0x0002243C
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00024244 File Offset: 0x00022444
		public Task.TaskState State { get; private set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00024250 File Offset: 0x00022450
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x00024258 File Offset: 0x00022458
		public DateTime PauseStartTime { get; private set; }

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000810 RID: 2064 RVA: 0x00024264 File Offset: 0x00022464
		// (remove) Token: 0x06000811 RID: 2065 RVA: 0x0002429C File Offset: 0x0002249C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<Task> EventOnStart;

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000812 RID: 2066 RVA: 0x000242D4 File Offset: 0x000224D4
		// (remove) Token: 0x06000813 RID: 2067 RVA: 0x0002430C File Offset: 0x0002250C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<Task> EventOnStop;

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000814 RID: 2068 RVA: 0x00024344 File Offset: 0x00022544
		// (remove) Token: 0x06000815 RID: 2069 RVA: 0x0002437C File Offset: 0x0002257C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<Task> EventOnPause;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000816 RID: 2070 RVA: 0x000243B4 File Offset: 0x000225B4
		// (remove) Token: 0x06000817 RID: 2071 RVA: 0x000243EC File Offset: 0x000225EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<Task> EventOnResume;

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00024424 File Offset: 0x00022624
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00024444 File Offset: 0x00022644
		[DoNotToLua]
		public Task.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new Task.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00024450 File Offset: 0x00022650
		private void __callDele_EventOnStart(Task obj)
		{
			Action<Task> eventOnStart = this.EventOnStart;
			if (eventOnStart != null)
			{
				eventOnStart(obj);
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00024474 File Offset: 0x00022674
		private void __clearDele_EventOnStart(Task obj)
		{
			this.EventOnStart = null;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00024480 File Offset: 0x00022680
		private void __callDele_EventOnStop(Task obj)
		{
			Action<Task> eventOnStop = this.EventOnStop;
			if (eventOnStop != null)
			{
				eventOnStop(obj);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000244A4 File Offset: 0x000226A4
		private void __clearDele_EventOnStop(Task obj)
		{
			this.EventOnStop = null;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000244B0 File Offset: 0x000226B0
		private void __callDele_EventOnPause(Task obj)
		{
			Action<Task> eventOnPause = this.EventOnPause;
			if (eventOnPause != null)
			{
				eventOnPause(obj);
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000244D4 File Offset: 0x000226D4
		private void __clearDele_EventOnPause(Task obj)
		{
			this.EventOnPause = null;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000244E0 File Offset: 0x000226E0
		private void __callDele_EventOnResume(Task obj)
		{
			Action<Task> eventOnResume = this.EventOnResume;
			if (eventOnResume != null)
			{
				eventOnResume(obj);
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00024504 File Offset: 0x00022704
		private void __clearDele_EventOnResume(Task obj)
		{
			this.EventOnResume = null;
		}

		// Token: 0x0400051E RID: 1310
		private TaskManager m_taskManager;

		// Token: 0x0400051F RID: 1311
		private ulong m_currTickCount;

		// Token: 0x04000520 RID: 1312
		private LinkedList<Task.DelayExecItem> m_delayExecList;

		// Token: 0x04000525 RID: 1317
		[DoNotToLua]
		private Task.LuaExportHelper luaExportHelper;

		// Token: 0x020000D2 RID: 210
		public enum TaskState
		{
			// Token: 0x04000527 RID: 1319
			Init,
			// Token: 0x04000528 RID: 1320
			Running,
			// Token: 0x04000529 RID: 1321
			Paused,
			// Token: 0x0400052A RID: 1322
			Stopped
		}

		// Token: 0x020000D3 RID: 211
		public class DelayExecItem
		{
			// Token: 0x0400052B RID: 1323
			public ulong m_execTargetTick;

			// Token: 0x0400052C RID: 1324
			public Action m_action;
		}

		// Token: 0x020000D4 RID: 212
		public class LuaExportHelper
		{
			// Token: 0x06000823 RID: 2083 RVA: 0x00024518 File Offset: 0x00022718
			public LuaExportHelper(Task owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06000824 RID: 2084 RVA: 0x00024528 File Offset: 0x00022728
			public void __callDele_EventOnStart(Task obj)
			{
				this.m_owner.__callDele_EventOnStart(obj);
			}

			// Token: 0x06000825 RID: 2085 RVA: 0x00024538 File Offset: 0x00022738
			public void __clearDele_EventOnStart(Task obj)
			{
				this.m_owner.__clearDele_EventOnStart(obj);
			}

			// Token: 0x06000826 RID: 2086 RVA: 0x00024548 File Offset: 0x00022748
			public void __callDele_EventOnStop(Task obj)
			{
				this.m_owner.__callDele_EventOnStop(obj);
			}

			// Token: 0x06000827 RID: 2087 RVA: 0x00024558 File Offset: 0x00022758
			public void __clearDele_EventOnStop(Task obj)
			{
				this.m_owner.__clearDele_EventOnStop(obj);
			}

			// Token: 0x06000828 RID: 2088 RVA: 0x00024568 File Offset: 0x00022768
			public void __callDele_EventOnPause(Task obj)
			{
				this.m_owner.__callDele_EventOnPause(obj);
			}

			// Token: 0x06000829 RID: 2089 RVA: 0x00024578 File Offset: 0x00022778
			public void __clearDele_EventOnPause(Task obj)
			{
				this.m_owner.__clearDele_EventOnPause(obj);
			}

			// Token: 0x0600082A RID: 2090 RVA: 0x00024588 File Offset: 0x00022788
			public void __callDele_EventOnResume(Task obj)
			{
				this.m_owner.__callDele_EventOnResume(obj);
			}

			// Token: 0x0600082B RID: 2091 RVA: 0x00024598 File Offset: 0x00022798
			public void __clearDele_EventOnResume(Task obj)
			{
				this.m_owner.__clearDele_EventOnResume(obj);
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x0600082C RID: 2092 RVA: 0x000245A8 File Offset: 0x000227A8
			// (set) Token: 0x0600082D RID: 2093 RVA: 0x000245B8 File Offset: 0x000227B8
			public TaskManager m_taskManager
			{
				get
				{
					return this.m_owner.m_taskManager;
				}
				set
				{
					this.m_owner.m_taskManager = value;
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x0600082E RID: 2094 RVA: 0x000245C8 File Offset: 0x000227C8
			// (set) Token: 0x0600082F RID: 2095 RVA: 0x000245D8 File Offset: 0x000227D8
			public ulong m_currTickCount
			{
				get
				{
					return this.m_owner.m_currTickCount;
				}
				set
				{
					this.m_owner.m_currTickCount = value;
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000830 RID: 2096 RVA: 0x000245E8 File Offset: 0x000227E8
			// (set) Token: 0x06000831 RID: 2097 RVA: 0x000245F8 File Offset: 0x000227F8
			public LinkedList<Task.DelayExecItem> m_delayExecList
			{
				get
				{
					return this.m_owner.m_delayExecList;
				}
				set
				{
					this.m_owner.m_delayExecList = value;
				}
			}

			// Token: 0x170000CD RID: 205
			// (set) Token: 0x06000832 RID: 2098 RVA: 0x00024608 File Offset: 0x00022808
			public string Name
			{
				set
				{
					this.m_owner.Name = value;
				}
			}

			// Token: 0x170000CE RID: 206
			// (set) Token: 0x06000833 RID: 2099 RVA: 0x00024618 File Offset: 0x00022818
			public Task.TaskState State
			{
				set
				{
					this.m_owner.State = value;
				}
			}

			// Token: 0x170000CF RID: 207
			// (set) Token: 0x06000834 RID: 2100 RVA: 0x00024628 File Offset: 0x00022828
			public DateTime PauseStartTime
			{
				set
				{
					this.m_owner.PauseStartTime = value;
				}
			}

			// Token: 0x06000835 RID: 2101 RVA: 0x00024638 File Offset: 0x00022838
			public void ClearOnStopEvent()
			{
				this.m_owner.ClearOnStopEvent();
			}

			// Token: 0x06000836 RID: 2102 RVA: 0x00024648 File Offset: 0x00022848
			public void ExecAfterTicks(Action action, ulong delayTickCount)
			{
				this.m_owner.ExecAfterTicks(action, delayTickCount);
			}

			// Token: 0x06000837 RID: 2103 RVA: 0x00024658 File Offset: 0x00022858
			public bool OnStart(object param)
			{
				return this.m_owner.OnStart(param);
			}

			// Token: 0x06000838 RID: 2104 RVA: 0x00024668 File Offset: 0x00022868
			public void OnPause()
			{
				this.m_owner.OnPause();
			}

			// Token: 0x06000839 RID: 2105 RVA: 0x00024678 File Offset: 0x00022878
			public bool OnResume(object param)
			{
				return this.m_owner.OnResume(param);
			}

			// Token: 0x0600083A RID: 2106 RVA: 0x00024688 File Offset: 0x00022888
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600083B RID: 2107 RVA: 0x00024698 File Offset: 0x00022898
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0400052D RID: 1325
			private Task m_owner;
		}
	}
}
