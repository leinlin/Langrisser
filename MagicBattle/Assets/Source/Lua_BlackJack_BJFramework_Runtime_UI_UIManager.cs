using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.Utils;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200112B RID: 4395
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_UI_UIManager : LuaObject
{
	// Token: 0x06015DF4 RID: 89588 RVA: 0x005A9270 File Offset: 0x005A7470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool pushIntentToStack;
			LuaObject.checkType(l, 3, out pushIntentToStack);
			bool clearIntentStack;
			LuaObject.checkType(l, 4, out clearIntentStack);
			Action redirectPipLineOnLoadAllResCompleted;
			LuaObject.checkDelegate<Action>(l, 5, out redirectPipLineOnLoadAllResCompleted);
			UITaskBase o = uimanager.StartUITask(intent, pushIntentToStack, clearIntentStack, redirectPipLineOnLoadAllResCompleted);
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

	// Token: 0x06015DF5 RID: 89589 RVA: 0x005A92F8 File Offset: 0x005A74F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITaskWithPrepare(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			Action<bool> onPrepareEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 3, out onPrepareEnd);
			bool pushIntentToStack;
			LuaObject.checkType(l, 4, out pushIntentToStack);
			uimanager.StartUITaskWithPrepare(intent, onPrepareEnd, pushIntentToStack);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DF6 RID: 89590 RVA: 0x005A936C File Offset: 0x005A756C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnUITask(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			UITaskBase o = uimanager.ReturnUITask(intent);
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

	// Token: 0x06015DF7 RID: 89591 RVA: 0x005A93D0 File Offset: 0x005A75D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnUITaskWithTaskName(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string taskName;
			LuaObject.checkType(l, 2, out taskName);
			UITaskBase o = uimanager.ReturnUITaskWithTaskName(taskName);
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

	// Token: 0x06015DF8 RID: 89592 RVA: 0x005A9434 File Offset: 0x005A7634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnUITaskToLast(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UITaskBase o = uimanager.ReturnUITaskToLast();
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

	// Token: 0x06015DF9 RID: 89593 RVA: 0x005A9488 File Offset: 0x005A7688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnUITaskByStackIndex(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			UITaskBase o = uimanager.ReturnUITaskByStackIndex(index);
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

	// Token: 0x06015DFA RID: 89594 RVA: 0x005A94EC File Offset: 0x005A76EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnUITaskWithPrepare(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			Action<bool> onPrepareEnd;
			LuaObject.checkDelegate<Action<bool>>(l, 3, out onPrepareEnd);
			uimanager.ReturnUITaskWithPrepare(intent, onPrepareEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DFB RID: 89595 RVA: 0x005A9550 File Offset: 0x005A7750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PauseUITask(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string taskName;
			LuaObject.checkType(l, 2, out taskName);
			uimanager.PauseUITask(taskName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DFC RID: 89596 RVA: 0x005A95A8 File Offset: 0x005A77A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StopUITask(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string taskName;
			LuaObject.checkType(l, 2, out taskName);
			uimanager.StopUITask(taskName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DFD RID: 89597 RVA: 0x005A9600 File Offset: 0x005A7800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindUITaskWithName(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string taskName;
			LuaObject.checkType(l, 2, out taskName);
			UITaskBase o = uimanager.FindUITaskWithName(taskName);
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

	// Token: 0x06015DFE RID: 89598 RVA: 0x005A9664 File Offset: 0x005A7864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveIntentFromStack(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			uimanager.RemoveIntentFromStack(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DFF RID: 89599 RVA: 0x005A96BC File Offset: 0x005A78BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopUITaskByGroup(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			int group;
			LuaObject.checkType(l, 2, out group);
			uimanager.StopUITaskByGroup(group);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E00 RID: 89600 RVA: 0x005A9714 File Offset: 0x005A7914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PauseUITaskByGroup(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			int group;
			LuaObject.checkType(l, 2, out group);
			uimanager.PauseUITaskByGroup(group);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E01 RID: 89601 RVA: 0x005A976C File Offset: 0x005A796C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PauseUITaskByTag(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			bool isExcept;
			LuaObject.checkType(l, 3, out isExcept);
			uimanager.PauseUITaskByTag(tag, isExcept);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E02 RID: 89602 RVA: 0x005A97D0 File Offset: 0x005A79D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopUITaskByTag(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			bool isExcept;
			LuaObject.checkType(l, 3, out isExcept);
			uimanager.StopUITaskByTag(tag, isExcept);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E03 RID: 89603 RVA: 0x005A9834 File Offset: 0x005A7A34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegisterUITaskWithGroup(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string taskName;
			LuaObject.checkType(l, 2, out taskName);
			TypeDNName taskTypeDNName;
			LuaObject.checkType<TypeDNName>(l, 3, out taskTypeDNName);
			int group;
			LuaObject.checkType(l, 4, out group);
			string luaModuleName;
			LuaObject.checkType(l, 5, out luaModuleName);
			uimanager.RegisterUITaskWithGroup(taskName, taskTypeDNName, group, luaModuleName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E04 RID: 89604 RVA: 0x005A98B4 File Offset: 0x005A7AB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetUITaskGroupConflict(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			uint group;
			LuaObject.checkType(l, 2, out group);
			uint group2;
			LuaObject.checkType(l, 3, out group2);
			uimanager.SetUITaskGroupConflict(group, group2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E05 RID: 89605 RVA: 0x005A9918 File Offset: 0x005A7B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReturnToLoginUI(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			uimanager.ReturnToLoginUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E06 RID: 89606 RVA: 0x005A9964 File Offset: 0x005A7B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGlobalUIInputEnable(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			bool b = uimanager.IsGlobalUIInputEnable();
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

	// Token: 0x06015E07 RID: 89607 RVA: 0x005A99B8 File Offset: 0x005A7BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GlobalUIInputEnable(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string srcName;
			LuaObject.checkType(l, 2, out srcName);
			bool enable;
			LuaObject.checkType(l, 3, out enable);
			uimanager.GlobalUIInputEnable(srcName, enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E08 RID: 89608 RVA: 0x005A9A1C File Offset: 0x005A7C1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GlobalUIInputBlockClear(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string srcName;
			LuaObject.checkType(l, 2, out srcName);
			uimanager.GlobalUIInputBlockClear(srcName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E09 RID: 89609 RVA: 0x005A9A74 File Offset: 0x005A7C74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GlobalUIInputBlockForTicks(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			int ticks;
			LuaObject.checkType(l, 2, out ticks);
			uimanager.GlobalUIInputBlockForTicks(ticks);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E0A RID: 89610 RVA: 0x005A9ACC File Offset: 0x005A7CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			uimanager.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E0B RID: 89611 RVA: 0x005A9B18 File Offset: 0x005A7D18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RegisterUIProcess(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UIManager.UIProcessQueueItem item;
			LuaObject.checkType<UIManager.UIProcessQueueItem>(l, 2, out item);
			uimanager.RegisterUIProcess(item);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E0C RID: 89612 RVA: 0x005A9B70 File Offset: 0x005A7D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterUIProcess(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UIManager.UIProcessQueueItem item;
			LuaObject.checkType<UIManager.UIProcessQueueItem>(l, 2, out item);
			uimanager.UnregisterUIProcess(item);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E0D RID: 89613 RVA: 0x005A9BC8 File Offset: 0x005A7DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterUIProcessQueueBlocker(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			Func<UIManager.UIProcessQueueItem, bool> blocker;
			LuaObject.checkDelegate<Func<UIManager.UIProcessQueueItem, bool>>(l, 2, out blocker);
			uimanager.RegisterUIProcessQueueBlocker(blocker);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E0E RID: 89614 RVA: 0x005A9C20 File Offset: 0x005A7E20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UnregisterUIProcessQueueBlocker(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			Func<UIManager.UIProcessQueueItem, bool> blocker;
			LuaObject.checkDelegate<Func<UIManager.UIProcessQueueItem, bool>>(l, 2, out blocker);
			uimanager.UnregisterUIProcessQueueBlocker(blocker);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E0F RID: 89615 RVA: 0x005A9C78 File Offset: 0x005A7E78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsUIProcessQueueItemExist(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool b = uimanager.IsUIProcessQueueItemExist(name);
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

	// Token: 0x06015E10 RID: 89616 RVA: 0x005A9CDC File Offset: 0x005A7EDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetOrCreateUITask(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string taskName;
			LuaObject.checkType(l, 2, out taskName);
			UITaskBase orCreateUITask = uimanager.m_luaExportHelper.GetOrCreateUITask(taskName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, orCreateUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E11 RID: 89617 RVA: 0x005A9D44 File Offset: 0x005A7F44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartOrResumeTask(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UITaskBase targetTask;
			LuaObject.checkType<UITaskBase>(l, 2, out targetTask);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 3, out intent);
			bool b = uimanager.m_luaExportHelper.StartOrResumeTask(targetTask, intent);
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

	// Token: 0x06015E12 RID: 89618 RVA: 0x005A9DB8 File Offset: 0x005A7FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PopIntentUntilReturnTarget(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = uimanager.m_luaExportHelper.PopIntentUntilReturnTarget(intent);
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

	// Token: 0x06015E13 RID: 89619 RVA: 0x005A9E20 File Offset: 0x005A8020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUITaskStop(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			Task task;
			LuaObject.checkType<Task>(l, 2, out task);
			uimanager.m_luaExportHelper.OnUITaskStop(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E14 RID: 89620 RVA: 0x005A9E7C File Offset: 0x005A807C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUITaskPostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UITaskBase task;
			LuaObject.checkType<UITaskBase>(l, 2, out task);
			uimanager.m_luaExportHelper.OnUITaskPostUpdateView(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E15 RID: 89621 RVA: 0x005A9ED8 File Offset: 0x005A80D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CloseAllConflictUITask(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string taskName;
			LuaObject.checkType(l, 2, out taskName);
			uimanager.m_luaExportHelper.CloseAllConflictUITask(taskName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E16 RID: 89622 RVA: 0x005A9F34 File Offset: 0x005A8134
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TickPauseTimeOut(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			uimanager.m_luaExportHelper.TickPauseTimeOut();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E17 RID: 89623 RVA: 0x005A9F88 File Offset: 0x005A8188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickUIProcessQueue(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			uimanager.m_luaExportHelper.TickUIProcessQueue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E18 RID: 89624 RVA: 0x005A9FDC File Offset: 0x005A81DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUIProcessEnd(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UIManager.UIProcessQueueItem item;
			LuaObject.checkType<UIManager.UIProcessQueueItem>(l, 2, out item);
			uimanager.m_luaExportHelper.OnUIProcessEnd(item);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E19 RID: 89625 RVA: 0x005AA038 File Offset: 0x005A8238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateBlockGlobalUIInputForProcessQueue(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			uimanager.m_luaExportHelper.UpdateBlockGlobalUIInputForProcessQueue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E1A RID: 89626 RVA: 0x005AA08C File Offset: 0x005A828C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUITaskShow(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			uimanager.m_luaExportHelper.__callDele_EventOnUITaskShow(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E1B RID: 89627 RVA: 0x005AA0E8 File Offset: 0x005A82E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnUITaskShow(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			uimanager.m_luaExportHelper.__clearDele_EventOnUITaskShow(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E1C RID: 89628 RVA: 0x005AA144 File Offset: 0x005A8344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventReturnToLoginUI(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			uimanager.m_luaExportHelper.__callDele_EventReturnToLoginUI(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E1D RID: 89629 RVA: 0x005AA1A0 File Offset: 0x005A83A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventReturnToLoginUI(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			uimanager.m_luaExportHelper.__clearDele_EventReturnToLoginUI(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E1E RID: 89630 RVA: 0x005AA1FC File Offset: 0x005A83FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UIProcessQueueComparsion_s(IntPtr l)
	{
		int result;
		try
		{
			UIManager.UIProcessQueueItem x;
			LuaObject.checkType<UIManager.UIProcessQueueItem>(l, 1, out x);
			UIManager.UIProcessQueueItem y;
			LuaObject.checkType<UIManager.UIProcessQueueItem>(l, 2, out y);
			int i = UIManager.LuaExportHelper.UIProcessQueueComparsion(x, y);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E1F RID: 89631 RVA: 0x005AA25C File Offset: 0x005A845C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnUITaskShow(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					uimanager.EventOnUITaskShow += value;
				}
				else if (num == 2)
				{
					uimanager.EventOnUITaskShow -= value;
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

	// Token: 0x06015E20 RID: 89632 RVA: 0x005AA2DC File Offset: 0x005A84DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventReturnToLoginUI(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					uimanager.EventReturnToLoginUI += value;
				}
				else if (num == 2)
				{
					uimanager.EventReturnToLoginUI -= value;
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

	// Token: 0x06015E21 RID: 89633 RVA: 0x005AA35C File Offset: 0x005A855C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIManager.LuaExportHelper.m_instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E22 RID: 89634 RVA: 0x005AA3A4 File Offset: 0x005A85A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_instance(IntPtr l)
	{
		int result;
		try
		{
			UIManager instance;
			LuaObject.checkType<UIManager>(l, 2, out instance);
			UIManager.LuaExportHelper.m_instance = instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E23 RID: 89635 RVA: 0x005AA3F0 File Offset: 0x005A85F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_globalUIInputBlockDict(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_globalUIInputBlockDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E24 RID: 89636 RVA: 0x005AA448 File Offset: 0x005A8648
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_globalUIInputBlockDict(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			Dictionary<string, int> globalUIInputBlockDict;
			LuaObject.checkType<Dictionary<string, int>>(l, 2, out globalUIInputBlockDict);
			uimanager.m_luaExportHelper.m_globalUIInputBlockDict = globalUIInputBlockDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E25 RID: 89637 RVA: 0x005AA4A4 File Offset: 0x005A86A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiIntentStack(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_uiIntentStack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E26 RID: 89638 RVA: 0x005AA4FC File Offset: 0x005A86FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiIntentStack(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			List<UIIntent> uiIntentStack;
			LuaObject.checkType<List<UIIntent>>(l, 2, out uiIntentStack);
			uimanager.m_luaExportHelper.m_uiIntentStack = uiIntentStack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E27 RID: 89639 RVA: 0x005AA558 File Offset: 0x005A8758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiTaskDict(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_uiTaskDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E28 RID: 89640 RVA: 0x005AA5B0 File Offset: 0x005A87B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiTaskDict(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			Dictionary<string, UITaskBase> uiTaskDict;
			LuaObject.checkType<Dictionary<string, UITaskBase>>(l, 2, out uiTaskDict);
			uimanager.m_luaExportHelper.m_uiTaskDict = uiTaskDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E29 RID: 89641 RVA: 0x005AA60C File Offset: 0x005A880C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiTaskRegDict(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_uiTaskRegDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E2A RID: 89642 RVA: 0x005AA664 File Offset: 0x005A8864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiTaskRegDict(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			Dictionary<string, UIManager.UITaskRegItem> uiTaskRegDict;
			LuaObject.checkType<Dictionary<string, UIManager.UITaskRegItem>>(l, 2, out uiTaskRegDict);
			uimanager.m_luaExportHelper.m_uiTaskRegDict = uiTaskRegDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E2B RID: 89643 RVA: 0x005AA6C0 File Offset: 0x005A88C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_taskList4Stop(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_taskList4Stop);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E2C RID: 89644 RVA: 0x005AA718 File Offset: 0x005A8918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_taskList4Stop(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			List<UITaskBase> taskList4Stop;
			LuaObject.checkType<List<UITaskBase>>(l, 2, out taskList4Stop);
			uimanager.m_luaExportHelper.m_taskList4Stop = taskList4Stop;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E2D RID: 89645 RVA: 0x005AA774 File Offset: 0x005A8974
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiTaskGroupConflictList(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_uiTaskGroupConflictList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E2E RID: 89646 RVA: 0x005AA7CC File Offset: 0x005A89CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiTaskGroupConflictList(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			List<List<int>> uiTaskGroupConflictList;
			LuaObject.checkType<List<List<int>>>(l, 2, out uiTaskGroupConflictList);
			uimanager.m_luaExportHelper.m_uiTaskGroupConflictList = uiTaskGroupConflictList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E2F RID: 89647 RVA: 0x005AA828 File Offset: 0x005A8A28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lastTickPauseTimeOutTime(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_lastTickPauseTimeOutTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E30 RID: 89648 RVA: 0x005AA884 File Offset: 0x005A8A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastTickPauseTimeOutTime(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			DateTime lastTickPauseTimeOutTime;
			LuaObject.checkValueType<DateTime>(l, 2, out lastTickPauseTimeOutTime);
			uimanager.m_luaExportHelper.m_lastTickPauseTimeOutTime = lastTickPauseTimeOutTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E31 RID: 89649 RVA: 0x005AA8E0 File Offset: 0x005A8AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_delayExecHelper(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_delayExecHelper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E32 RID: 89650 RVA: 0x005AA938 File Offset: 0x005A8B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_delayExecHelper(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			DelayExecHelper delayExecHelper;
			LuaObject.checkType<DelayExecHelper>(l, 2, out delayExecHelper);
			uimanager.m_luaExportHelper.m_delayExecHelper = delayExecHelper;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E33 RID: 89651 RVA: 0x005AA994 File Offset: 0x005A8B94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UITaskPauseTimeOut(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 120.0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E34 RID: 89652 RVA: 0x005AA9E0 File Offset: 0x005A8BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiProcessQueue(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_uiProcessQueue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E35 RID: 89653 RVA: 0x005AAA38 File Offset: 0x005A8C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiProcessQueue(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			List<UIManager.UIProcessQueueItem> uiProcessQueue;
			LuaObject.checkType<List<UIManager.UIProcessQueueItem>>(l, 2, out uiProcessQueue);
			uimanager.m_luaExportHelper.m_uiProcessQueue = uiProcessQueue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E36 RID: 89654 RVA: 0x005AAA94 File Offset: 0x005A8C94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_currRuningUIProcess(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_currRuningUIProcess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E37 RID: 89655 RVA: 0x005AAAEC File Offset: 0x005A8CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currRuningUIProcess(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			UIManager.UIProcessQueueItem currRuningUIProcess;
			LuaObject.checkType<UIManager.UIProcessQueueItem>(l, 2, out currRuningUIProcess);
			uimanager.m_luaExportHelper.m_currRuningUIProcess = currRuningUIProcess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E38 RID: 89656 RVA: 0x005AAB48 File Offset: 0x005A8D48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_currRuningUIProcessTimeOut(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_currRuningUIProcessTimeOut);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E39 RID: 89657 RVA: 0x005AABA4 File Offset: 0x005A8DA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_currRuningUIProcessTimeOut(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			DateTime? currRuningUIProcessTimeOut;
			LuaObject.checkNullable<DateTime>(l, 2, out currRuningUIProcessTimeOut);
			uimanager.m_luaExportHelper.m_currRuningUIProcessTimeOut = currRuningUIProcessTimeOut;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E3A RID: 89658 RVA: 0x005AAC00 File Offset: 0x005A8E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiProcessQueueBlockerList(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_uiProcessQueueBlockerList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E3B RID: 89659 RVA: 0x005AAC58 File Offset: 0x005A8E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiProcessQueueBlockerList(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			List<Func<UIManager.UIProcessQueueItem, bool>> uiProcessQueueBlockerList;
			LuaObject.checkType<List<Func<UIManager.UIProcessQueueItem, bool>>>(l, 2, out uiProcessQueueBlockerList);
			uimanager.m_luaExportHelper.m_uiProcessQueueBlockerList = uiProcessQueueBlockerList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E3C RID: 89660 RVA: 0x005AACB4 File Offset: 0x005A8EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_blockGlobalUIInputForWaitingItem(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uimanager.m_luaExportHelper.m_blockGlobalUIInputForWaitingItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E3D RID: 89661 RVA: 0x005AAD0C File Offset: 0x005A8F0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_blockGlobalUIInputForWaitingItem(IntPtr l)
	{
		int result;
		try
		{
			UIManager uimanager = (UIManager)LuaObject.checkSelf(l);
			bool blockGlobalUIInputForWaitingItem;
			LuaObject.checkType(l, 2, out blockGlobalUIInputForWaitingItem);
			uimanager.m_luaExportHelper.m_blockGlobalUIInputForWaitingItem = blockGlobalUIInputForWaitingItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E3E RID: 89662 RVA: 0x005AAD68 File Offset: 0x005A8F68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIManager.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015E3F RID: 89663 RVA: 0x005AADB0 File Offset: 0x005A8FB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.UI.UIManager");
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.StartUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.StartUITaskWithPrepare);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.ReturnUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.ReturnUITaskWithTaskName);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.ReturnUITaskToLast);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.ReturnUITaskByStackIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.ReturnUITaskWithPrepare);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.PauseUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache7);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.StopUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache8);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.FindUITaskWithName);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache9);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.RemoveIntentFromStack);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheA);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.StopUITaskByGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheB);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.PauseUITaskByGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheC);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.PauseUITaskByTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheD);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.StopUITaskByTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheE);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.RegisterUITaskWithGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cacheF);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.SetUITaskGroupConflict);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache10);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.ReturnToLoginUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache11);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.IsGlobalUIInputEnable);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache12);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.GlobalUIInputEnable);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache13);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.GlobalUIInputBlockClear);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache14);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.GlobalUIInputBlockForTicks);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache15);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache16);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.RegisterUIProcess);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache17);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.UnregisterUIProcess);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache18);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.RegisterUIProcessQueueBlocker);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache19);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.UnregisterUIProcessQueueBlocker);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1A);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.IsUIProcessQueueItemExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1B);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.GetOrCreateUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1C);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.StartOrResumeTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1D);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.PopIntentUntilReturnTarget);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1E);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.OnUITaskStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache1F);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.OnUITaskPostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache20);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.CloseAllConflictUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache21);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.TickPauseTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache22);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.TickUIProcessQueue);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache23);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.OnUIProcessEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache24);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.UpdateBlockGlobalUIInputForProcessQueue);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache25);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.__callDele_EventOnUITaskShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache26);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.__clearDele_EventOnUITaskShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache27);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.__callDele_EventReturnToLoginUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache28);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.__clearDele_EventReturnToLoginUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache29);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.UIProcessQueueComparsion_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2A);
		string name = "EventOnUITaskShow";
		LuaCSFunction get = null;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_EventOnUITaskShow);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2B, true);
		string name2 = "EventReturnToLoginUI";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_EventReturnToLoginUI);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2C, true);
		string name3 = "m_instance";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_instance);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2D;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_instance);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2E, false);
		string name4 = "m_globalUIInputBlockDict";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_globalUIInputBlockDict);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache2F;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_globalUIInputBlockDict);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache30, true);
		string name5 = "m_uiIntentStack";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_uiIntentStack);
		}
		LuaCSFunction get5 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache31;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_uiIntentStack);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache32, true);
		string name6 = "m_uiTaskDict";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_uiTaskDict);
		}
		LuaCSFunction get6 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache33;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_uiTaskDict);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache34, true);
		string name7 = "m_uiTaskRegDict";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_uiTaskRegDict);
		}
		LuaCSFunction get7 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache35;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_uiTaskRegDict);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache36, true);
		string name8 = "m_taskList4Stop";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_taskList4Stop);
		}
		LuaCSFunction get8 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache37;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_taskList4Stop);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache38, true);
		string name9 = "m_uiTaskGroupConflictList";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_uiTaskGroupConflictList);
		}
		LuaCSFunction get9 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache39;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_uiTaskGroupConflictList);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3A, true);
		string name10 = "m_lastTickPauseTimeOutTime";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_lastTickPauseTimeOutTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3B;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_lastTickPauseTimeOutTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3C, true);
		string name11 = "m_delayExecHelper";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_delayExecHelper);
		}
		LuaCSFunction get11 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3D;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_delayExecHelper);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3E, true);
		string name12 = "UITaskPauseTimeOut";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_UITaskPauseTimeOut);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache3F, null, false);
		string name13 = "m_uiProcessQueue";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_uiProcessQueue);
		}
		LuaCSFunction get12 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache40;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_uiProcessQueue);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache41, true);
		string name14 = "m_currRuningUIProcess";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_currRuningUIProcess);
		}
		LuaCSFunction get13 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache42;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_currRuningUIProcess);
		}
		LuaObject.addMember(l, name14, get13, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache43, true);
		string name15 = "m_currRuningUIProcessTimeOut";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_currRuningUIProcessTimeOut);
		}
		LuaCSFunction get14 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache44;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_currRuningUIProcessTimeOut);
		}
		LuaObject.addMember(l, name15, get14, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache45, true);
		string name16 = "m_uiProcessQueueBlockerList";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_uiProcessQueueBlockerList);
		}
		LuaCSFunction get15 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache46;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_uiProcessQueueBlockerList);
		}
		LuaObject.addMember(l, name16, get15, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache47, true);
		string name17 = "m_blockGlobalUIInputForWaitingItem";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_m_blockGlobalUIInputForWaitingItem);
		}
		LuaCSFunction get16 = Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache48;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.set_m_blockGlobalUIInputForWaitingItem);
		}
		LuaObject.addMember(l, name17, get16, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache49, true);
		string name18 = "Instance";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIManager.get_Instance);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_BJFramework_Runtime_UI_UIManager.<>f__mg$cache4A, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(UIManager));
	}

	// Token: 0x0400C580 RID: 50560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C581 RID: 50561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C582 RID: 50562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C583 RID: 50563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C584 RID: 50564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C585 RID: 50565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C586 RID: 50566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C587 RID: 50567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C588 RID: 50568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C589 RID: 50569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C58A RID: 50570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C58B RID: 50571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C58C RID: 50572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400C58D RID: 50573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400C58E RID: 50574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400C58F RID: 50575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400C590 RID: 50576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400C591 RID: 50577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400C592 RID: 50578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400C593 RID: 50579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400C594 RID: 50580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400C595 RID: 50581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400C596 RID: 50582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400C597 RID: 50583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400C598 RID: 50584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400C599 RID: 50585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400C59A RID: 50586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400C59B RID: 50587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400C59C RID: 50588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400C59D RID: 50589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400C59E RID: 50590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400C59F RID: 50591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400C5A0 RID: 50592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400C5A1 RID: 50593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400C5A2 RID: 50594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400C5A3 RID: 50595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400C5A4 RID: 50596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400C5A5 RID: 50597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400C5A6 RID: 50598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400C5A7 RID: 50599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400C5A8 RID: 50600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400C5A9 RID: 50601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400C5AA RID: 50602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400C5AB RID: 50603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400C5AC RID: 50604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400C5AD RID: 50605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400C5AE RID: 50606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400C5AF RID: 50607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400C5B0 RID: 50608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400C5B1 RID: 50609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400C5B2 RID: 50610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400C5B3 RID: 50611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400C5B4 RID: 50612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400C5B5 RID: 50613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400C5B6 RID: 50614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400C5B7 RID: 50615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400C5B8 RID: 50616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400C5B9 RID: 50617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400C5BA RID: 50618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400C5BB RID: 50619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400C5BC RID: 50620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400C5BD RID: 50621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400C5BE RID: 50622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400C5BF RID: 50623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400C5C0 RID: 50624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400C5C1 RID: 50625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400C5C2 RID: 50626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400C5C3 RID: 50627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400C5C4 RID: 50628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400C5C5 RID: 50629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400C5C6 RID: 50630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400C5C7 RID: 50631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400C5C8 RID: 50632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400C5C9 RID: 50633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400C5CA RID: 50634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;
}
