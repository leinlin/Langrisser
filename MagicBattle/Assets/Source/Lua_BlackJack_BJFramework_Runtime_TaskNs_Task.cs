using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001124 RID: 4388
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_TaskNs_Task : LuaObject
{
	// Token: 0x06015D0A RID: 89354 RVA: 0x005A200C File Offset: 0x005A020C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			Task o = new Task(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D0B RID: 89355 RVA: 0x005A2060 File Offset: 0x005A0260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = task.Start(param);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D0C RID: 89356 RVA: 0x005A20C4 File Offset: 0x005A02C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Stop(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			task.Stop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D0D RID: 89357 RVA: 0x005A2110 File Offset: 0x005A0310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			task.Pause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D0E RID: 89358 RVA: 0x005A215C File Offset: 0x005A035C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Resume(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = task.Resume(param);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D0F RID: 89359 RVA: 0x005A21C0 File Offset: 0x005A03C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearOnStopEvent(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			task.m_luaExportHelper.ClearOnStopEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D10 RID: 89360 RVA: 0x005A2214 File Offset: 0x005A0414
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExecAfterTicks(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Action action;
			LuaObject.checkDelegate<Action>(l, 2, out action);
			ulong delayTickCount;
			LuaObject.checkType(l, 3, out delayTickCount);
			task.m_luaExportHelper.ExecAfterTicks(action, delayTickCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D11 RID: 89361 RVA: 0x005A2280 File Offset: 0x005A0480
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = task.m_luaExportHelper.OnStart(param);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D12 RID: 89362 RVA: 0x005A22E8 File Offset: 0x005A04E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPause(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			task.m_luaExportHelper.OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D13 RID: 89363 RVA: 0x005A233C File Offset: 0x005A053C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = task.m_luaExportHelper.OnResume(param);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D14 RID: 89364 RVA: 0x005A23A4 File Offset: 0x005A05A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			task.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D15 RID: 89365 RVA: 0x005A23F8 File Offset: 0x005A05F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnTick(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			task.m_luaExportHelper.OnTick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D16 RID: 89366 RVA: 0x005A244C File Offset: 0x005A064C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Task obj;
			LuaObject.checkType<Task>(l, 2, out obj);
			task.m_luaExportHelper.__callDele_EventOnStart(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D17 RID: 89367 RVA: 0x005A24A8 File Offset: 0x005A06A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Task obj;
			LuaObject.checkType<Task>(l, 2, out obj);
			task.m_luaExportHelper.__clearDele_EventOnStart(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D18 RID: 89368 RVA: 0x005A2504 File Offset: 0x005A0704
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnStop(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Task obj;
			LuaObject.checkType<Task>(l, 2, out obj);
			task.m_luaExportHelper.__callDele_EventOnStop(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D19 RID: 89369 RVA: 0x005A2560 File Offset: 0x005A0760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStop(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Task obj;
			LuaObject.checkType<Task>(l, 2, out obj);
			task.m_luaExportHelper.__clearDele_EventOnStop(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D1A RID: 89370 RVA: 0x005A25BC File Offset: 0x005A07BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPause(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Task obj;
			LuaObject.checkType<Task>(l, 2, out obj);
			task.m_luaExportHelper.__callDele_EventOnPause(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D1B RID: 89371 RVA: 0x005A2618 File Offset: 0x005A0818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPause(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Task obj;
			LuaObject.checkType<Task>(l, 2, out obj);
			task.m_luaExportHelper.__clearDele_EventOnPause(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D1C RID: 89372 RVA: 0x005A2674 File Offset: 0x005A0874
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnResume(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Task obj;
			LuaObject.checkType<Task>(l, 2, out obj);
			task.m_luaExportHelper.__callDele_EventOnResume(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D1D RID: 89373 RVA: 0x005A26D0 File Offset: 0x005A08D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnResume(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Task obj;
			LuaObject.checkType<Task>(l, 2, out obj);
			task.m_luaExportHelper.__clearDele_EventOnResume(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D1E RID: 89374 RVA: 0x005A272C File Offset: 0x005A092C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_taskManager(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, task.m_luaExportHelper.m_taskManager);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D1F RID: 89375 RVA: 0x005A2784 File Offset: 0x005A0984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_taskManager(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			TaskManager taskManager;
			LuaObject.checkType<TaskManager>(l, 2, out taskManager);
			task.m_luaExportHelper.m_taskManager = taskManager;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D20 RID: 89376 RVA: 0x005A27E0 File Offset: 0x005A09E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currTickCount(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, task.m_luaExportHelper.m_currTickCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D21 RID: 89377 RVA: 0x005A2838 File Offset: 0x005A0A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currTickCount(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			ulong currTickCount;
			LuaObject.checkType(l, 2, out currTickCount);
			task.m_luaExportHelper.m_currTickCount = currTickCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D22 RID: 89378 RVA: 0x005A2894 File Offset: 0x005A0A94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_delayExecList(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, task.m_luaExportHelper.m_delayExecList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D23 RID: 89379 RVA: 0x005A28EC File Offset: 0x005A0AEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_delayExecList(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			LinkedList<Task.DelayExecItem> delayExecList;
			LuaObject.checkType<LinkedList<Task.DelayExecItem>>(l, 2, out delayExecList);
			task.m_luaExportHelper.m_delayExecList = delayExecList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D24 RID: 89380 RVA: 0x005A2948 File Offset: 0x005A0B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStart(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Action<Task> value;
			int num = LuaObject.checkDelegate<Action<Task>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					task.EventOnStart += value;
				}
				else if (num == 2)
				{
					task.EventOnStart -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D25 RID: 89381 RVA: 0x005A29C8 File Offset: 0x005A0BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStop(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Action<Task> value;
			int num = LuaObject.checkDelegate<Action<Task>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					task.EventOnStop += value;
				}
				else if (num == 2)
				{
					task.EventOnStop -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D26 RID: 89382 RVA: 0x005A2A48 File Offset: 0x005A0C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPause(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Action<Task> value;
			int num = LuaObject.checkDelegate<Action<Task>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					task.EventOnPause += value;
				}
				else if (num == 2)
				{
					task.EventOnPause -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D27 RID: 89383 RVA: 0x005A2AC8 File Offset: 0x005A0CC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnResume(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Action<Task> value;
			int num = LuaObject.checkDelegate<Action<Task>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					task.EventOnResume += value;
				}
				else if (num == 2)
				{
					task.EventOnResume -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D28 RID: 89384 RVA: 0x005A2B48 File Offset: 0x005A0D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, task.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D29 RID: 89385 RVA: 0x005A2B9C File Offset: 0x005A0D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			task.m_luaExportHelper.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D2A RID: 89386 RVA: 0x005A2BF8 File Offset: 0x005A0DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_State(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)task.State);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D2B RID: 89387 RVA: 0x005A2C4C File Offset: 0x005A0E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_State(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			Task.TaskState state;
			LuaObject.checkEnum<Task.TaskState>(l, 2, out state);
			task.m_luaExportHelper.State = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D2C RID: 89388 RVA: 0x005A2CA8 File Offset: 0x005A0EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PauseStartTime(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, task.PauseStartTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D2D RID: 89389 RVA: 0x005A2D00 File Offset: 0x005A0F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PauseStartTime(IntPtr l)
	{
		int result;
		try
		{
			Task task = (Task)LuaObject.checkSelf(l);
			DateTime pauseStartTime;
			LuaObject.checkValueType<DateTime>(l, 2, out pauseStartTime);
			task.m_luaExportHelper.PauseStartTime = pauseStartTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015D2E RID: 89390 RVA: 0x005A2D5C File Offset: 0x005A0F5C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.TaskNs.Task");
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.Stop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.Resume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.ClearOnStopEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.ExecAfterTicks);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.OnTick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.__callDele_EventOnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.__clearDele_EventOnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.__callDele_EventOnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.__clearDele_EventOnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.__callDele_EventOnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.__clearDele_EventOnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.__callDele_EventOnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.__clearDele_EventOnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache12);
		string name = "m_taskManager";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.get_m_taskManager);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache13;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.set_m_taskManager);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache14, true);
		string name2 = "m_currTickCount";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.get_m_currTickCount);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache15;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.set_m_currTickCount);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache16, true);
		string name3 = "m_delayExecList";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.get_m_delayExecList);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache17;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.set_m_delayExecList);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache18, true);
		string name4 = "EventOnStart";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.set_EventOnStart);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache19, true);
		string name5 = "EventOnStop";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.set_EventOnStop);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1A, true);
		string name6 = "EventOnPause";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.set_EventOnPause);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1B, true);
		string name7 = "EventOnResume";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.set_EventOnResume);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1C, true);
		string name8 = "Name";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.get_Name);
		}
		LuaCSFunction get8 = Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1D;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.set_Name);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1E, true);
		string name9 = "State";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.get_State);
		}
		LuaCSFunction get9 = Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache1F;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.set_State);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache20, true);
		string name10 = "PauseStartTime";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.get_PauseStartTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache21;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.set_PauseStartTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache22, true);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_Task.<>f__mg$cache23, typeof(Task));
	}

	// Token: 0x0400C4A4 RID: 50340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C4A5 RID: 50341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C4A6 RID: 50342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C4A7 RID: 50343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C4A8 RID: 50344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C4A9 RID: 50345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C4AA RID: 50346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C4AB RID: 50347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C4AC RID: 50348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C4AD RID: 50349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C4AE RID: 50350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C4AF RID: 50351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C4B0 RID: 50352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C4B1 RID: 50353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C4B2 RID: 50354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C4B3 RID: 50355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C4B4 RID: 50356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C4B5 RID: 50357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C4B6 RID: 50358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C4B7 RID: 50359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C4B8 RID: 50360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C4B9 RID: 50361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C4BA RID: 50362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C4BB RID: 50363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C4BC RID: 50364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C4BD RID: 50365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C4BE RID: 50366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C4BF RID: 50367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C4C0 RID: 50368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C4C1 RID: 50369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C4C2 RID: 50370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C4C3 RID: 50371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C4C4 RID: 50372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C4C5 RID: 50373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C4C6 RID: 50374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C4C7 RID: 50375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
