using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001239 RID: 4665
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment : LuaObject
{
	// Token: 0x06018336 RID: 99126 RVA: 0x006BDD68 File Offset: 0x006BBF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment o = new HeroAssistantsTaskAssignment();
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

	// Token: 0x06018337 RID: 99127 RVA: 0x006BDDB0 File Offset: 0x006BBFB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TaskId(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTaskAssignment.TaskId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018338 RID: 99128 RVA: 0x006BDE04 File Offset: 0x006BC004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TaskId(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			heroAssistantsTaskAssignment.TaskId = taskId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018339 RID: 99129 RVA: 0x006BDE5C File Offset: 0x006BC05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Task(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTaskAssignment.Task);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601833A RID: 99130 RVA: 0x006BDEB0 File Offset: 0x006BC0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Task(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			HeroAssistantsTask task;
			LuaObject.checkType<HeroAssistantsTask>(l, 2, out task);
			heroAssistantsTaskAssignment.Task = task;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601833B RID: 99131 RVA: 0x006BDF08 File Offset: 0x006BC108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AssignedHeroIds(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTaskAssignment.AssignedHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601833C RID: 99132 RVA: 0x006BDF5C File Offset: 0x006BC15C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AssignedHeroIds(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			List<int> assignedHeroIds;
			LuaObject.checkType<List<int>>(l, 2, out assignedHeroIds);
			heroAssistantsTaskAssignment.AssignedHeroIds = assignedHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601833D RID: 99133 RVA: 0x006BDFB4 File Offset: 0x006BC1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartTime(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTaskAssignment.StartTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601833E RID: 99134 RVA: 0x006BE00C File Offset: 0x006BC20C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StartTime(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			DateTime startTime;
			LuaObject.checkValueType<DateTime>(l, 2, out startTime);
			heroAssistantsTaskAssignment.StartTime = startTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601833F RID: 99135 RVA: 0x006BE064 File Offset: 0x006BC264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EndTime(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTaskAssignment.EndTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018340 RID: 99136 RVA: 0x006BE0BC File Offset: 0x006BC2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EndTime(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			DateTime endTime;
			LuaObject.checkValueType<DateTime>(l, 2, out endTime);
			heroAssistantsTaskAssignment.EndTime = endTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018341 RID: 99137 RVA: 0x006BE114 File Offset: 0x006BC314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Slot(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTaskAssignment.Slot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018342 RID: 99138 RVA: 0x006BE168 File Offset: 0x006BC368
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Slot(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			heroAssistantsTaskAssignment.Slot = slot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018343 RID: 99139 RVA: 0x006BE1C0 File Offset: 0x006BC3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AssignPoints(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTaskAssignment.AssignPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018344 RID: 99140 RVA: 0x006BE214 File Offset: 0x006BC414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CompleteRate(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsTaskAssignment heroAssistantsTaskAssignment = (HeroAssistantsTaskAssignment)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTaskAssignment.CompleteRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018345 RID: 99141 RVA: 0x006BE268 File Offset: 0x006BC468
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroAssistantsTaskAssignment");
		string name = "TaskId";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.get_TaskId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.set_TaskId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache1, true);
		string name2 = "Task";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.get_Task);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.set_Task);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache3, true);
		string name3 = "AssignedHeroIds";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.get_AssignedHeroIds);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.set_AssignedHeroIds);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache5, true);
		string name4 = "StartTime";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.get_StartTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.set_StartTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache7, true);
		string name5 = "EndTime";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.get_EndTime);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.set_EndTime);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cache9, true);
		string name6 = "Slot";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.get_Slot);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.set_Slot);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheB, true);
		string name7 = "AssignPoints";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.get_AssignPoints);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheC, null, true);
		string name8 = "CompleteRate";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.get_CompleteRate);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheD, null, true);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsTaskAssignment.<>f__mg$cacheE, typeof(HeroAssistantsTaskAssignment));
	}

	// Token: 0x0400E8A6 RID: 59558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E8A7 RID: 59559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E8A8 RID: 59560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E8A9 RID: 59561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E8AA RID: 59562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E8AB RID: 59563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E8AC RID: 59564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E8AD RID: 59565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E8AE RID: 59566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E8AF RID: 59567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E8B0 RID: 59568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E8B1 RID: 59569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E8B2 RID: 59570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E8B3 RID: 59571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E8B4 RID: 59572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
